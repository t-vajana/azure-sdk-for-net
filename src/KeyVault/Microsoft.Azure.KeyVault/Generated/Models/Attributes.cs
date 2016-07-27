// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The object attributes managed by the KeyVault service
    /// </summary>
    public partial class Attributes
    {
        /// <summary>
        /// Initializes a new instance of the Attributes class.
        /// </summary>
        public Attributes() { }

        /// <summary>
        /// Initializes a new instance of the Attributes class.
        /// </summary>
        /// <param name="enabled">Determines whether the object is
        /// enabled</param>
        /// <param name="notBefore">Not before date in UTC</param>
        /// <param name="expires">Expiry date in UTC</param>
        /// <param name="created">Creation time in UTC</param>
        /// <param name="updated">Last updated time in UTC</param>
        public Attributes(bool? enabled = default(bool?), DateTime? notBefore = default(DateTime?), DateTime? expires = default(DateTime?), DateTime? created = default(DateTime?), DateTime? updated = default(DateTime?))
        {
            Enabled = enabled;
            NotBefore = notBefore;
            Expires = expires;
            Created = created;
            Updated = updated;
        }

        /// <summary>
        /// Gets or sets determines whether the object is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets not before date in UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "nbf")]
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// Gets or sets expiry date in UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "exp")]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Gets creation time in UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "created")]
        public DateTime? Created { get; private set; }

        /// <summary>
        /// Gets last updated time in UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "updated")]
        public DateTime? Updated { get; private set; }

    }
}
