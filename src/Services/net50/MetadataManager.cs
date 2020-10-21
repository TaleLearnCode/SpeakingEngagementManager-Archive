﻿using Azure.Cosmos;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaleLearnCode.SpeakingEngagementManager.Domain;

namespace TaleLearnCode.SpeakingEngagementManager.Services
{

	public class MetadataManager
	{

		private CosmosContainer _CosmosContainer;

		public MetadataManager(CosmosContainer cosmosContainer)
		{
			_CosmosContainer = cosmosContainer;
		}

		public async Task<T> CreateMetadataAsync<T>(IMetadata metadata)
		{
			metadata.IsValid();  // Will throw an exception if not valid
			return (await _CosmosContainer.CreateItemAsync((T)metadata, new PartitionKey(metadata.OwnerEmailAddress))).Value;
		}

		public async Task<T> GetMetadataByIdAsync<T>(string id, string ownerEmailAddress)
		{
			return await Common.GetCosmosDataAsync<T>(
				new QueryDefinition($"SELECT * FROM c WHERE c.ownerEmailAddress = @OwnerEmailAddress AND c.id = @Id AND c.discriminator = '{Discriminators.Metadata}'")
					.WithParameter("@OwnerEmailAddress", ownerEmailAddress)
					.WithParameter("@Id", id),
				_CosmosContainer);
		}

		public async Task<List<T>> GetMetadataByTypeAsync<T>(string ownerEmailAddress)
		{
			return await Common.GetDocumentsAsync<T>(
				new QueryDefinition("SELECT * FROM c WHERE c.ownerEmailAddress = @OwnerEmailAddress AND c.discriminator = @Discriminator")
					.WithParameter("@OwnerEmailAddress", ownerEmailAddress)
					.WithParameter("@Discriminator", Discriminators.Metadata)
					.WithParameter("@MetadataType", Metadata.GetMetadataTypeByType(typeof(T))),
				_CosmosContainer);
		}

	}

}