// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Transport Shipment Type supported for given region. </summary>
    public readonly partial struct TransportShipmentTypes : IEquatable<TransportShipmentTypes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TransportShipmentTypes"/> values are the same. </summary>
        public TransportShipmentTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CustomerManagedValue = "CustomerManaged";
        private const string MicrosoftManagedValue = "MicrosoftManaged";

        /// <summary> Shipment Logistics is handled by the customer. </summary>
        public static TransportShipmentTypes CustomerManaged { get; } = new TransportShipmentTypes(CustomerManagedValue);
        /// <summary> Shipment Logistics is handled by Microsoft. </summary>
        public static TransportShipmentTypes MicrosoftManaged { get; } = new TransportShipmentTypes(MicrosoftManagedValue);
        /// <summary> Determines if two <see cref="TransportShipmentTypes"/> values are the same. </summary>
        public static bool operator ==(TransportShipmentTypes left, TransportShipmentTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TransportShipmentTypes"/> values are not the same. </summary>
        public static bool operator !=(TransportShipmentTypes left, TransportShipmentTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TransportShipmentTypes"/>. </summary>
        public static implicit operator TransportShipmentTypes(string value) => new TransportShipmentTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TransportShipmentTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TransportShipmentTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
