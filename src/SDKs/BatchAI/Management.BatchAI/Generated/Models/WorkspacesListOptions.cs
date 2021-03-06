// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for List operation.
    /// </summary>
    public partial class WorkspacesListOptions
    {
        /// <summary>
        /// Initializes a new instance of the WorkspacesListOptions class.
        /// </summary>
        public WorkspacesListOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspacesListOptions class.
        /// </summary>
        /// <param name="maxResults">The maximum number of items to return in
        /// the response. A maximum of 1000 files can be returned.</param>
        public WorkspacesListOptions(int? maxResults = default(int?))
        {
            MaxResults = maxResults;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the maximum number of items to return in the response.
        /// A maximum of 1000 files can be returned.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int? MaxResults { get; set; }

    }
}
