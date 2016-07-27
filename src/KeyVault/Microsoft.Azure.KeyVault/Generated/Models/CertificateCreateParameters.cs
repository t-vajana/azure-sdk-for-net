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
    /// The certificate create parameters
    /// </summary>
    public partial class CertificateCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the CertificateCreateParameters
        /// class.
        /// </summary>
        public CertificateCreateParameters() { }

        /// <summary>
        /// Initializes a new instance of the CertificateCreateParameters
        /// class.
        /// </summary>
        /// <param name="certificatePolicy">The management policy for the
        /// certificate</param>
        /// <param name="certificateAttributes">The attributes of the
        /// certificate (optional)</param>
        /// <param name="tags">Application-specific metadata in the form of
        /// key-value pairs</param>
        public CertificateCreateParameters(CertificatePolicy certificatePolicy = default(CertificatePolicy), CertificateAttributes certificateAttributes = default(CertificateAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            CertificatePolicy = certificatePolicy;
            CertificateAttributes = certificateAttributes;
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets the management policy for the certificate
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public CertificatePolicy CertificatePolicy { get; set; }

        /// <summary>
        /// Gets or sets the attributes of the certificate (optional)
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public CertificateAttributes CertificateAttributes { get; set; }

        /// <summary>
        /// Gets or sets application-specific metadata in the form of
        /// key-value pairs
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.CertificatePolicy != null)
            {
                this.CertificatePolicy.Validate();
            }
        }
    }
}
