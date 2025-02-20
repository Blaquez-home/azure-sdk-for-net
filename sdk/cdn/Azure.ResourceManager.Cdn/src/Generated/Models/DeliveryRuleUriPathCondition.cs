// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the UrlPath condition for the delivery rule. </summary>
    public partial class DeliveryRuleUriPathCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRuleUriPathCondition. </summary>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleUriPathCondition(UriPathMatchCondition properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
            Name = MatchVariable.UriPath;
        }

        /// <summary> Initializes a new instance of DeliveryRuleUriPathCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        internal DeliveryRuleUriPathCondition(MatchVariable name, UriPathMatchCondition properties) : base(name)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public UriPathMatchCondition Properties { get; set; }
    }
}
