// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties of the cost summary.
    /// </summary>
    public partial class LabCostSummaryProperties
    {
        /// <summary>
        /// Initializes a new instance of the LabCostSummaryProperties class.
        /// </summary>
        public LabCostSummaryProperties() { }

        /// <summary>
        /// Initializes a new instance of the LabCostSummaryProperties class.
        /// </summary>
        public LabCostSummaryProperties(double? estimatedLabCost = default(double?))
        {
            EstimatedLabCost = estimatedLabCost;
        }

        /// <summary>
        /// The cost component of the cost item.
        /// </summary>
        [JsonProperty(PropertyName = "estimatedLabCost")]
        public double? EstimatedLabCost { get; set; }

    }
}