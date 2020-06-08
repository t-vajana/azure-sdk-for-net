// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Copy Log Details for a disk. </summary>
    public partial class DataBoxDiskCopyLogDetails : CopyLogDetails
    {
        /// <summary> Initializes a new instance of DataBoxDiskCopyLogDetails. </summary>
        public DataBoxDiskCopyLogDetails()
        {
            CopyLogDetailsType = "DataBoxDisk";
        }

        /// <summary> Initializes a new instance of DataBoxDiskCopyLogDetails. </summary>
        /// <param name="copyLogDetailsType"> Indicates the type of job details. </param>
        /// <param name="diskSerialNumber"> Disk Serial Number. </param>
        /// <param name="errorLogLink"> Link for copy error logs. </param>
        /// <param name="verboseLogLink"> Link for copy verbose logs. </param>
        internal DataBoxDiskCopyLogDetails(ClassDiscriminator copyLogDetailsType, string diskSerialNumber, string errorLogLink, string verboseLogLink) : base(copyLogDetailsType)
        {
            DiskSerialNumber = diskSerialNumber;
            ErrorLogLink = errorLogLink;
            VerboseLogLink = verboseLogLink;
            CopyLogDetailsType = copyLogDetailsType;
        }

        /// <summary> Disk Serial Number. </summary>
        public string DiskSerialNumber { get; }
        /// <summary> Link for copy error logs. </summary>
        public string ErrorLogLink { get; }
        /// <summary> Link for copy verbose logs. </summary>
        public string VerboseLogLink { get; }
    }
}
