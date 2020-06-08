// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.DataBox.Models
{
    public partial class AvailableSkuRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("transferType");
            writer.WriteStringValue(TransferType.ToSerialString());
            writer.WritePropertyName("country");
            writer.WriteStringValue(Country);
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (SkuNames != null)
            {
                writer.WritePropertyName("skuNames");
                writer.WriteStartArray();
                foreach (var item in SkuNames)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
