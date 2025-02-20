// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    public partial class AzureActiveDirectory : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(Registration))
            {
                writer.WritePropertyName("registration");
                writer.WriteObjectValue(Registration);
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login");
                writer.WriteObjectValue(Login);
            }
            if (Optional.IsDefined(Validation))
            {
                writer.WritePropertyName("validation");
                writer.WriteObjectValue(Validation);
            }
            if (Optional.IsDefined(IsAutoProvisioned))
            {
                writer.WritePropertyName("isAutoProvisioned");
                writer.WriteBooleanValue(IsAutoProvisioned.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureActiveDirectory DeserializeAzureActiveDirectory(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<AzureActiveDirectoryRegistration> registration = default;
            Optional<AzureActiveDirectoryLogin> login = default;
            Optional<AzureActiveDirectoryValidation> validation = default;
            Optional<bool> isAutoProvisioned = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("registration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    registration = AzureActiveDirectoryRegistration.DeserializeAzureActiveDirectoryRegistration(property.Value);
                    continue;
                }
                if (property.NameEquals("login"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    login = AzureActiveDirectoryLogin.DeserializeAzureActiveDirectoryLogin(property.Value);
                    continue;
                }
                if (property.NameEquals("validation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validation = AzureActiveDirectoryValidation.DeserializeAzureActiveDirectoryValidation(property.Value);
                    continue;
                }
                if (property.NameEquals("isAutoProvisioned"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAutoProvisioned = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AzureActiveDirectory(Optional.ToNullable(enabled), registration.Value, login.Value, validation.Value, Optional.ToNullable(isAutoProvisioned));
        }
    }
}
