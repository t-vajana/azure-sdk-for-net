// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Type of encryption key used for key encryption. </summary>
    public readonly partial struct KekType : IEquatable<KekType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="KekType"/> values are the same. </summary>
        public KekType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftManagedValue = "MicrosoftManaged";
        private const string CustomerManagedValue = "CustomerManaged";

        /// <summary> Key encryption key is managed by Microsoft. </summary>
        public static KekType MicrosoftManaged { get; } = new KekType(MicrosoftManagedValue);
        /// <summary> Key encryption key is managed by the Customer. </summary>
        public static KekType CustomerManaged { get; } = new KekType(CustomerManagedValue);
        /// <summary> Determines if two <see cref="KekType"/> values are the same. </summary>
        public static bool operator ==(KekType left, KekType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KekType"/> values are not the same. </summary>
        public static bool operator !=(KekType left, KekType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KekType"/>. </summary>
        public static implicit operator KekType(string value) => new KekType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KekType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KekType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
