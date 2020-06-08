// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Job details. </summary>
    public partial class JobDetails
    {
        /// <summary> Initializes a new instance of JobDetails. </summary>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        public JobDetails(ContactDetails contactDetails)
        {
            if (contactDetails == null)
            {
                throw new ArgumentNullException(nameof(contactDetails));
            }

            ContactDetails = contactDetails;
            JobDetailsType = null;
        }

        /// <summary> Initializes a new instance of JobDetails. </summary>
        /// <param name="jobStages"> List of stages that run in the job. </param>
        /// <param name="contactDetails"> Contact details for notification and shipping. </param>
        /// <param name="shippingAddress"> Shipping address of the customer. </param>
        /// <param name="deliveryPackage"> Delivery package shipping details. </param>
        /// <param name="returnPackage"> Return package shipping details. </param>
        /// <param name="dataImportDetails"> Details of the data to be imported into azure. </param>
        /// <param name="dataExportDetails"> Details of the data to be exported from azure. </param>
        /// <param name="jobDetailsType"> Indicates the type of job details. </param>
        /// <param name="preferences"> Preferences for the order. </param>
        /// <param name="copyLogDetails"> List of copy log details. </param>
        /// <param name="reverseShipmentLabelSasKey"> Shared access key to download the return shipment label. </param>
        /// <param name="chainOfCustodySasKey"> Shared access key to download the chain of custody logs. </param>
        /// <param name="keyEncryptionKey"> Details about which key encryption type is being used. </param>
        /// <param name="expectedDataSizeInTerabytes"> The expected size of the data, which needs to be transfered in this job, in tera bytes. </param>
        internal JobDetails(IList<JobStages> jobStages, ContactDetails contactDetails, ShippingAddress shippingAddress, PackageShippingDetails deliveryPackage, PackageShippingDetails returnPackage, IList<DataImportDetails> dataImportDetails, IList<DataExportDetails> dataExportDetails, ClassDiscriminator jobDetailsType, Preferences preferences, IList<CopyLogDetails> copyLogDetails, string reverseShipmentLabelSasKey, string chainOfCustodySasKey, KeyEncryptionKey keyEncryptionKey, int? expectedDataSizeInTerabytes)
        {
            JobStages = jobStages;
            ContactDetails = contactDetails;
            ShippingAddress = shippingAddress;
            DeliveryPackage = deliveryPackage;
            ReturnPackage = returnPackage;
            DataImportDetails = dataImportDetails;
            DataExportDetails = dataExportDetails;
            JobDetailsType = jobDetailsType;
            Preferences = preferences;
            CopyLogDetails = copyLogDetails;
            ReverseShipmentLabelSasKey = reverseShipmentLabelSasKey;
            ChainOfCustodySasKey = chainOfCustodySasKey;
            KeyEncryptionKey = keyEncryptionKey;
            ExpectedDataSizeInTerabytes = expectedDataSizeInTerabytes;
        }

        /// <summary> List of stages that run in the job. </summary>
        public IList<JobStages> JobStages { get; }
        /// <summary> Contact details for notification and shipping. </summary>
        public ContactDetails ContactDetails { get; set; }
        /// <summary> Shipping address of the customer. </summary>
        public ShippingAddress ShippingAddress { get; set; }
        /// <summary> Delivery package shipping details. </summary>
        public PackageShippingDetails DeliveryPackage { get; }
        /// <summary> Return package shipping details. </summary>
        public PackageShippingDetails ReturnPackage { get; }
        /// <summary> Details of the data to be imported into azure. </summary>
        public IList<DataImportDetails> DataImportDetails { get; set; }
        /// <summary> Details of the data to be exported from azure. </summary>
        public IList<DataExportDetails> DataExportDetails { get; set; }
        /// <summary> Indicates the type of job details. </summary>
        internal ClassDiscriminator JobDetailsType { get; set; }
        /// <summary> Preferences for the order. </summary>
        public Preferences Preferences { get; set; }
        /// <summary> List of copy log details. </summary>
        public IList<CopyLogDetails> CopyLogDetails { get; }
        /// <summary> Shared access key to download the return shipment label. </summary>
        public string ReverseShipmentLabelSasKey { get; }
        /// <summary> Shared access key to download the chain of custody logs. </summary>
        public string ChainOfCustodySasKey { get; }
        /// <summary> Details about which key encryption type is being used. </summary>
        public KeyEncryptionKey KeyEncryptionKey { get; }
        /// <summary> The expected size of the data, which needs to be transfered in this job, in tera bytes. </summary>
        public int? ExpectedDataSizeInTerabytes { get; set; }
    }
}
