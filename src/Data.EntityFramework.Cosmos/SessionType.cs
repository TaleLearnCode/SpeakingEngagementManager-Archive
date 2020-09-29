﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using TaleLearnCode.SpeakingEngagementManager.Domain;

namespace TaleLearnCode.SpeakingEngagementManager.Data.EntityFramework.Cosmos
{

	/// <summary>
	/// Represents a type of session (i.e. 60-minute presentation, 4-hour workshop, etc.).
	/// </summary>
	/// <seealso cref="EntityFramework.SessionType" />
	/// <seealso cref="IPartitionKey" />
	public class SessionType : Data.EntityFramework.SessionType, IPartitionKey
	{

		/// <summary>
		/// Gets or sets the email address of the data owner.
		/// </summary>
		/// <value>
		/// A <c>string</c> representing the data owner's email address.
		/// </value>
		[JsonPropertyName(Domain.PropertyNames.PartitionKey.CosmosPartitionKey)]
		public string OwnerEmailAddress { get; set; }

		/// <summary>
		/// Gets or sets the presentations associated with the session type.
		/// </summary>
		/// <value>
		/// A <see cref="List{PresentationSessionType}"/> representing the associated presentations.
		/// </value>
		[JsonPropertyName("presentationSessionTypes")]
		public new List<PresentationSessionType> PresentationSessionTypes { get; set; } = new();

	}

}