﻿using TaleLearnCode.SpeakingEngagementManager.Entities;

namespace TaleLearnCode.SpeakingEngagementManager.Repository.EntityFramework.Cosmos
{

	/// <summary>
	/// Represents a type of session (i.e. 60-minute presentation, 4-hour workshop, etc.).
	/// </summary>
	/// <seealso cref="EntityFramework.SessionType" />
	/// <seealso cref="IPartitionKey" />
	public class SessionType : EntityFramework.SessionType, IPartitionKey
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