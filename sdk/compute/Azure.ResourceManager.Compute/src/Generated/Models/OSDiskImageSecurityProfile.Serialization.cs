// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class OSDiskImageSecurityProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConfidentialVmEncryptionType))
            {
                writer.WritePropertyName("confidentialVMEncryptionType");
                writer.WriteStringValue(ConfidentialVmEncryptionType.Value.ToString());
            }
            if (Optional.IsDefined(SecureVmDiskEncryptionSetId))
            {
                writer.WritePropertyName("secureVMDiskEncryptionSetId");
                writer.WriteStringValue(SecureVmDiskEncryptionSetId);
            }
            writer.WriteEndObject();
        }

        internal static OSDiskImageSecurityProfile DeserializeOSDiskImageSecurityProfile(JsonElement element)
        {
            Optional<ConfidentialVmEncryptionType> confidentialVMEncryptionType = default;
            Optional<string> secureVMDiskEncryptionSetId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("confidentialVMEncryptionType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    confidentialVMEncryptionType = new ConfidentialVmEncryptionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secureVMDiskEncryptionSetId"))
                {
                    secureVMDiskEncryptionSetId = property.Value.GetString();
                    continue;
                }
            }
            return new OSDiskImageSecurityProfile(Optional.ToNullable(confidentialVMEncryptionType), secureVMDiskEncryptionSetId.Value);
        }
    }
}
