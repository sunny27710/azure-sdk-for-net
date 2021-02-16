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
    using System.Linq;

    /// <summary>
    /// TagsObject
    /// </summary>
    /// <remarks>
    /// Customer retrieves list of Available Contacts for a spacecraft
    /// resource. Later, one of the available contact can be selected to create
    /// a contact.
    /// </remarks>
    public partial class AvailableContacts
    {
        /// <summary>
        /// Initializes a new instance of the AvailableContacts class.
        /// </summary>
        public AvailableContacts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableContacts class.
        /// </summary>
        /// <param name="spacecraft">The reference to the spacecraft
        /// resource.</param>
        /// <param name="groundStationName">Name of Azure Ground
        /// Station.</param>
        /// <param name="location">Azure region.</param>
        /// <param name="properties">Properties of Contact resource.</param>
        public AvailableContacts(ResourceReference spacecraft = default(ResourceReference), string groundStationName = default(string), string location = default(string), ContactInstanceProperties properties = default(ContactInstanceProperties))
        {
            Spacecraft = spacecraft;
            GroundStationName = groundStationName;
            Location = location;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference to the spacecraft resource.
        /// </summary>
        [JsonProperty(PropertyName = "spacecraft")]
        public ResourceReference Spacecraft { get; set; }

        /// <summary>
        /// Gets name of Azure Ground Station.
        /// </summary>
        [JsonProperty(PropertyName = "groundStationName")]
        public string GroundStationName { get; private set; }

        /// <summary>
        /// Gets azure region.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or sets properties of Contact resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ContactInstanceProperties Properties { get; set; }

    }
}
