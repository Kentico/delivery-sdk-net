﻿using Newtonsoft.Json.Linq;
using System;

namespace KenticoCloud.Delivery
{
    /// <summary>
    /// Represents system attributes of a content type.
    /// </summary>
    public sealed class ContentTypeSystemAttributes
    {
        /// <summary>
        /// Gets the identifier of the content type.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the name of the content type.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the codename of the content type.
        /// </summary>
        public string Codename { get; }

        /// <summary>
        /// Gets the time the content type was last modified.
        /// </summary>
        public DateTime LastModified { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentTypeSystemAttributes"/> class with the specified JSON data.
        /// </summary>
        /// <param name="source">The JSON data to deserialize.</param>
        internal ContentTypeSystemAttributes(JToken source)
        {
            Id = source["id"].ToString();
            Name = source["name"].ToString();
            Codename = source["codename"].ToString();
            LastModified = source["last_modified"].Value<DateTime>();
        }
    }
}
