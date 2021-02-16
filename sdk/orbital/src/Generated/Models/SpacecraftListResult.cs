// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Orbital.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// TagsObject
    /// </summary>
    /// <remarks>
    /// Response for the ListSpacecrafts API service call.
    /// </remarks>
    public partial class SpacecraftListResult
    {
        /// <summary>
        /// Initializes a new instance of the SpacecraftListResult class.
        /// </summary>
        public SpacecraftListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SpacecraftListResult class.
        /// </summary>
        /// <param name="value">A list of spacecraft resources in a resource
        /// group.</param>
        /// <param name="nextLink">The URL to get the next set of
        /// results.</param>
        public SpacecraftListResult(IList<Spacecraft> value = default(IList<Spacecraft>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of spacecraft resources in a resource group.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Spacecraft> Value { get; set; }

        /// <summary>
        /// Gets the URL to get the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
