﻿using TaleLearnCode.SpeakingEngagementManager.Entities;

namespace CosmosRepository
{

	/// <summary>
	/// Represents a type of session (i.e. 60-minute presentation, 4-hour workshop, etc.).
	/// </summary>
	/// <seealso cref="ISessionType" />
	/// <seealso cref="IPartitionKey" />
	public class SessionType : ISessionType, IPartitionKey
	{

		/// <summary>
		/// Gets the identifier of the session type.
		/// </summary>
		/// <value>
		/// A <c>string</c> representing the session type identifier.
		/// </value>
		public string Id { get; init; }

		/// <summary>
		/// Gets or sets the email address of the data owner.
		/// </summary>
		/// <value>
		/// A <c>string</c> representing the data owner's email address.
		/// </value>
		public string OwnerEmailAddress { get; set; }


		/// <summary>
		/// Gets or sets the name of the session type.
		/// </summary>
		/// <value>
		/// A <c>string</c> representing the session type name.
		/// </value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the duration of a session of this type.
		/// </summary>
		/// <value>
		/// A <c>int</c> representing the duration of a session of this type in minutes.
		/// </value>
		public int Duration { get; set; }

	}

}