﻿using TaleLearnCode.SpeakingEngagementManager.Entities;

namespace TaleLearnCode.SpeakingEngagementManager.Repository.EntityFramework.Cosmos
{

	/// <summary>
	/// Represents the many-to-many relationship between presentations and session types.
	/// </summary>
	/// <seealso cref="EntityFramework.PresentationSessionType" />
	/// <seealso cref="IPartitionKey" />
	public class PresentationSessionType : EntityFramework.PresentationSessionType, IPartitionKey
	{

		/// <summary>
		/// Gets or sets the email address of the data owner.
		/// </summary>
		/// <value>
		/// A <c>string</c> representing the data owner's email address.
		/// </value>
		public string OwnerEmailAddress { get; set; }

	}

}