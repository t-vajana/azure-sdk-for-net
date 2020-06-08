// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Indicates the type of job details. </summary>
    public readonly partial struct ClassDiscriminator : IEquatable<ClassDiscriminator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ClassDiscriminator"/> values are the same. </summary>
        public ClassDiscriminator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DataBoxValue = "DataBox";
        private const string DataBoxDiskValue = "DataBoxDisk";
        private const string DataBoxHeavyValue = "DataBoxHeavy";

        /// <summary> Data Box orders. </summary>
        public static ClassDiscriminator DataBox { get; } = new ClassDiscriminator(DataBoxValue);
        /// <summary> Data Box Disk orders. </summary>
        public static ClassDiscriminator DataBoxDisk { get; } = new ClassDiscriminator(DataBoxDiskValue);
        /// <summary> Data Box Heavy orders. </summary>
        public static ClassDiscriminator DataBoxHeavy { get; } = new ClassDiscriminator(DataBoxHeavyValue);
        /// <summary> Determines if two <see cref="ClassDiscriminator"/> values are the same. </summary>
        public static bool operator ==(ClassDiscriminator left, ClassDiscriminator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClassDiscriminator"/> values are not the same. </summary>
        public static bool operator !=(ClassDiscriminator left, ClassDiscriminator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClassDiscriminator"/>. </summary>
        public static implicit operator ClassDiscriminator(string value) => new ClassDiscriminator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClassDiscriminator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClassDiscriminator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
