// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Type of the account. </summary>
    public readonly partial struct DataAccountType : IEquatable<DataAccountType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DataAccountType"/> values are the same. </summary>
        public DataAccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StorageAccountValue = "StorageAccount";
        private const string ManagedDiskValue = "ManagedDisk";

        /// <summary> Storage Accounts . </summary>
        public static DataAccountType StorageAccount { get; } = new DataAccountType(StorageAccountValue);
        /// <summary> Azure Managed disk storage. </summary>
        public static DataAccountType ManagedDisk { get; } = new DataAccountType(ManagedDiskValue);
        /// <summary> Determines if two <see cref="DataAccountType"/> values are the same. </summary>
        public static bool operator ==(DataAccountType left, DataAccountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataAccountType"/> values are not the same. </summary>
        public static bool operator !=(DataAccountType left, DataAccountType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataAccountType"/>. </summary>
        public static implicit operator DataAccountType(string value) => new DataAccountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataAccountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataAccountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
