// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object model for updating the name or description of an application.
    /// </summary>
    public partial class ApplicationUpdateObject
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationUpdateObject class.
        /// </summary>
        public ApplicationUpdateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationUpdateObject class.
        /// </summary>
        /// <param name="name">The application's new name.</param>
        /// <param name="description">The application's new
        /// description.</param>
        public ApplicationUpdateObject(string name = default(string), string description = default(string))
        {
            Name = name;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the application's new name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the application's new description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}