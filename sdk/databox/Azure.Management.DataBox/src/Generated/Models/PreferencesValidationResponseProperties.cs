// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Properties of data center and transport preference validation response. </summary>
    public partial class PreferencesValidationResponseProperties : ValidationInputResponse
    {
        /// <summary> Initializes a new instance of PreferencesValidationResponseProperties. </summary>
        internal PreferencesValidationResponseProperties()
        {
            ValidationType = "ValidatePreferences";
        }

        /// <summary> Initializes a new instance of PreferencesValidationResponseProperties. </summary>
        /// <param name="validationType"> Identifies the type of validation response. </param>
        /// <param name="error"> Error code and message of validation response. </param>
        /// <param name="status"> Validation status of requested data center and transport. </param>
        internal PreferencesValidationResponseProperties(ValidationInputDiscriminator validationType, CloudError error, ValidationStatus? status) : base(validationType, error)
        {
            Status = status;
            ValidationType = validationType;
        }

        /// <summary> Validation status of requested data center and transport. </summary>
        public ValidationStatus? Status { get; }
    }
}
