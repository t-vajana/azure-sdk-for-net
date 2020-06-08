// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.DataBox.Models
{
    public partial class DataBoxJobDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (CopyProgress != null)
            {
                writer.WritePropertyName("copyProgress");
                writer.WriteStartArray();
                foreach (var item in CopyProgress)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DevicePassword != null)
            {
                writer.WritePropertyName("devicePassword");
                writer.WriteStringValue(DevicePassword);
            }
            if (JobStages != null)
            {
                writer.WritePropertyName("jobStages");
                writer.WriteStartArray();
                foreach (var item in JobStages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("contactDetails");
            writer.WriteObjectValue(ContactDetails);
            if (ShippingAddress != null)
            {
                writer.WritePropertyName("shippingAddress");
                writer.WriteObjectValue(ShippingAddress);
            }
            if (DeliveryPackage != null)
            {
                writer.WritePropertyName("deliveryPackage");
                writer.WriteObjectValue(DeliveryPackage);
            }
            if (ReturnPackage != null)
            {
                writer.WritePropertyName("returnPackage");
                writer.WriteObjectValue(ReturnPackage);
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
            writer.WritePropertyName("jobDetailsType");
            writer.WriteStringValue(JobDetailsType.ToString());
            if (Preferences != null)
            {
                writer.WritePropertyName("preferences");
                writer.WriteObjectValue(Preferences);
            }
            if (CopyLogDetails != null)
            {
                writer.WritePropertyName("copyLogDetails");
                writer.WriteStartArray();
                foreach (var item in CopyLogDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ReverseShipmentLabelSasKey != null)
            {
                writer.WritePropertyName("reverseShipmentLabelSasKey");
                writer.WriteStringValue(ReverseShipmentLabelSasKey);
            }
            if (ChainOfCustodySasKey != null)
            {
                writer.WritePropertyName("chainOfCustodySasKey");
                writer.WriteStringValue(ChainOfCustodySasKey);
            }
            if (KeyEncryptionKey != null)
            {
                writer.WritePropertyName("keyEncryptionKey");
                writer.WriteObjectValue(KeyEncryptionKey);
            }
            if (ExpectedDataSizeInTerabytes != null)
            {
                writer.WritePropertyName("expectedDataSizeInTerabytes");
                writer.WriteNumberValue(ExpectedDataSizeInTerabytes.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataBoxJobDetails DeserializeDataBoxJobDetails(JsonElement element)
        {
            IList<CopyProgress> copyProgress = default;
            string devicePassword = default;
            IList<JobStages> jobStages = default;
            ContactDetails contactDetails = default;
            ShippingAddress shippingAddress = default;
            PackageShippingDetails deliveryPackage = default;
            PackageShippingDetails returnPackage = default;
            IList<DataImportDetails> dataImportDetails = default;
            IList<DataExportDetails> dataExportDetails = default;
            ClassDiscriminator jobDetailsType = default;
            Preferences preferences = default;
            IList<CopyLogDetails> copyLogDetails = default;
            string reverseShipmentLabelSasKey = default;
            string chainOfCustodySasKey = default;
            KeyEncryptionKey keyEncryptionKey = default;
            int? expectedDataSizeInTerabytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyProgress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CopyProgress> array = new List<CopyProgress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Models.CopyProgress.DeserializeCopyProgress(item));
                        }
                    }
                    copyProgress = array;
                    continue;
                }
                if (property.NameEquals("devicePassword"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobStages"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JobStages> array = new List<JobStages>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Models.JobStages.DeserializeJobStages(item));
                        }
                    }
                    jobStages = array;
                    continue;
                }
                if (property.NameEquals("contactDetails"))
                {
                    contactDetails = ContactDetails.DeserializeContactDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("shippingAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingAddress = ShippingAddress.DeserializeShippingAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("deliveryPackage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("returnPackage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("dataImportDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataImportDetails> array = new List<DataImportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Models.DataImportDetails.DeserializeDataImportDetails(item));
                        }
                    }
                    dataImportDetails = array;
                    continue;
                }
                if (property.NameEquals("dataExportDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataExportDetails> array = new List<DataExportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Models.DataExportDetails.DeserializeDataExportDetails(item));
                        }
                    }
                    dataExportDetails = array;
                    continue;
                }
                if (property.NameEquals("jobDetailsType"))
                {
                    jobDetailsType = new ClassDiscriminator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("preferences"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferences = Preferences.DeserializePreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("copyLogDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CopyLogDetails> array = new List<CopyLogDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(Models.CopyLogDetails.DeserializeCopyLogDetails(item));
                        }
                    }
                    copyLogDetails = array;
                    continue;
                }
                if (property.NameEquals("reverseShipmentLabelSasKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseShipmentLabelSasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chainOfCustodySasKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    chainOfCustodySasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyEncryptionKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKey = KeyEncryptionKey.DeserializeKeyEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("expectedDataSizeInTerabytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expectedDataSizeInTerabytes = property.Value.GetInt32();
                    continue;
                }
            }
            return new DataBoxJobDetails(jobStages, contactDetails, shippingAddress, deliveryPackage, returnPackage, dataImportDetails, dataExportDetails, jobDetailsType, preferences, copyLogDetails, reverseShipmentLabelSasKey, chainOfCustodySasKey, keyEncryptionKey, expectedDataSizeInTerabytes, copyProgress, devicePassword);
        }
    }
}
