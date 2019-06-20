// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class JitNetworkAccessPortRule
    {
        /// <summary>
        /// Initializes a new instance of the JitNetworkAccessPortRule class.
        /// </summary>
        public JitNetworkAccessPortRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JitNetworkAccessPortRule class.
        /// </summary>
        /// <param name="protocol">Possible values include: 'TCP', 'UDP',
        /// 'All'</param>
        /// <param name="maxRequestAccessDuration">Maximum duration requests
        /// can be made for. In ISO 8601 duration format. Minimum 5 minutes,
        /// maximum 1 day</param>
        /// <param name="allowedSourceAddressPrefix">Mutually exclusive with
        /// the "allowedSourceAddressPrefixes" parameter. Should be an IP
        /// address or CIDR, for example "192.168.0.3" or
        /// "192.168.0.0/16".</param>
        /// <param name="allowedSourceAddressPrefixes">Mutually exclusive with
        /// the "allowedSourceAddressPrefix" parameter.</param>
        public JitNetworkAccessPortRule(int number, string protocol, string maxRequestAccessDuration, string allowedSourceAddressPrefix = default(string), IList<string> allowedSourceAddressPrefixes = default(IList<string>))
        {
            Number = number;
            Protocol = protocol;
            AllowedSourceAddressPrefix = allowedSourceAddressPrefix;
            AllowedSourceAddressPrefixes = allowedSourceAddressPrefixes;
            MaxRequestAccessDuration = maxRequestAccessDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'TCP', 'UDP', 'All'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets mutually exclusive with the
        /// "allowedSourceAddressPrefixes" parameter. Should be an IP address
        /// or CIDR, for example "192.168.0.3" or "192.168.0.0/16".
        /// </summary>
        [JsonProperty(PropertyName = "allowedSourceAddressPrefix")]
        public string AllowedSourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets mutually exclusive with the
        /// "allowedSourceAddressPrefix" parameter.
        /// </summary>
        [JsonProperty(PropertyName = "allowedSourceAddressPrefixes")]
        public IList<string> AllowedSourceAddressPrefixes { get; set; }

        /// <summary>
        /// Gets or sets maximum duration requests can be made for. In ISO 8601
        /// duration format. Minimum 5 minutes, maximum 1 day
        /// </summary>
        [JsonProperty(PropertyName = "maxRequestAccessDuration")]
        public string MaxRequestAccessDuration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Protocol == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Protocol");
            }
            if (MaxRequestAccessDuration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MaxRequestAccessDuration");
            }
        }
    }
}