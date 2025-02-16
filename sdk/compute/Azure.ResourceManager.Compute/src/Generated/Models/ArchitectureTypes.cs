// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The architecture of the image. Applicable to OS disks only. </summary>
    public readonly partial struct ArchitectureTypes : IEquatable<ArchitectureTypes>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArchitectureTypes"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArchitectureTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string X64Value = "x64";
        private const string Arm64Value = "Arm64";

        /// <summary> x64. </summary>
        public static ArchitectureTypes X64 { get; } = new ArchitectureTypes(X64Value);
        /// <summary> Arm64. </summary>
        public static ArchitectureTypes Arm64 { get; } = new ArchitectureTypes(Arm64Value);
        /// <summary> Determines if two <see cref="ArchitectureTypes"/> values are the same. </summary>
        public static bool operator ==(ArchitectureTypes left, ArchitectureTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArchitectureTypes"/> values are not the same. </summary>
        public static bool operator !=(ArchitectureTypes left, ArchitectureTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArchitectureTypes"/>. </summary>
        public static implicit operator ArchitectureTypes(string value) => new ArchitectureTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArchitectureTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArchitectureTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
