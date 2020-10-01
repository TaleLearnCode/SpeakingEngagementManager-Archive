﻿using System.Collections.Generic;
using TaleLearnCode.SpeakingEngagementManager.Domain;

namespace TaleLearnCode.SpeakingEngagementManager.Data.EntityFramework.Cosmos
{

	/// <summary>
	/// Represents a tag for a presentation.
	/// </summary>
	/// <seealso cref="EntityFramework.Tag" />
	/// <seealso cref="IPartitionKey" />
	public class Tag : ITag, IPartitionKey
	{

		/// <summary>
		/// Gets or sets the email address of the data owner.
		/// </summary>
		/// <value>
		/// A <c>string</c> representing the data owner's email address.
		/// </value>
		public string OwnerEmailAddress { get; set; }

		/// <summary>
		/// Gets the identifier of the tag.
		/// </summary>
		/// <value>
		/// A <c>string</c> representing the tag identifier.
		/// </value>
		public string Id { get; init; }

		/// <summary>
		/// Gets or sets the name of the tag.
		/// </summary>
		/// <value>
		/// A <c>string</c> representing the tag's name.
		/// </value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the presentations associated with the tag.
		/// </summary>
		/// <value>
		/// A <see cref="List{PresentationTag}"/> representing the associated presentations.
		/// </value>
		public List<PresentationTag> PresentationTags { get; set; } = new();

	}

}