// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.DataBox.Models
{
    public partial class CreateOrderLimitForSubscriptionValidationResponseProperties
    {
        internal static CreateOrderLimitForSubscriptionValidationResponseProperties DeserializeCreateOrderLimitForSubscriptionValidationResponseProperties(JsonElement element)
        {
            ValidationStatus? status = default;
            ValidationType validationType = default;
            CloudError error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToValidationStatus();
                    continue;
                }
                if (property.NameEquals("validationType"))
                {
                    validationType = new ValidationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = CloudError.DeserializeCloudError(property.Value);
                    continue;
                }
            }
            return new CreateOrderLimitForSubscriptionValidationResponseProperties(validationType, error, status);
        }
    }
}
