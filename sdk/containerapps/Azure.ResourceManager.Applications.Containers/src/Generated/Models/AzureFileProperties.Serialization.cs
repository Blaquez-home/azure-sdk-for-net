// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    public partial class AzureFileProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName");
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey");
                writer.WriteStringValue(AccountKey);
            }
            if (Optional.IsDefined(AccessMode))
            {
                writer.WritePropertyName("accessMode");
                writer.WriteStringValue(AccessMode.Value.ToString());
            }
            if (Optional.IsDefined(ShareName))
            {
                writer.WritePropertyName("shareName");
                writer.WriteStringValue(ShareName);
            }
            writer.WriteEndObject();
        }

        internal static AzureFileProperties DeserializeAzureFileProperties(JsonElement element)
        {
            Optional<string> accountName = default;
            Optional<string> accountKey = default;
            Optional<AccessMode> accessMode = default;
            Optional<string> shareName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountKey"))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accessMode = new AccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("shareName"))
                {
                    shareName = property.Value.GetString();
                    continue;
                }
            }
            return new AzureFileProperties(accountName.Value, accountKey.Value, Optional.ToNullable(accessMode), shareName.Value);
        }
    }
}
