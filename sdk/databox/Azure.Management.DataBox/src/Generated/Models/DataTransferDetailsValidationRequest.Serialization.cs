// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.DataBox.Models
{
    public partial class DataTransferDetailsValidationRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DataExportDetails != null)
            {
                writer.WritePropertyName("dataExportDetails");
                writer.WriteStartArray();
                foreach (var item in DataExportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DataImportDetails != null)
            {
                writer.WritePropertyName("dataImportDetails");
                writer.WriteStartArray();
                foreach (var item in DataImportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("deviceType");
            writer.WriteStringValue(DeviceType.ToString());
            writer.WritePropertyName("transferType");
            writer.WriteStringValue(TransferType.ToString());
            writer.WritePropertyName("validationType");
            writer.WriteStringValue(ValidationType.ToString());
            writer.WriteEndObject();
        }
    }
}
