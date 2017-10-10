// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A backup long term retention policy
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackupLongTermRetentionPolicy : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the BackupLongTermRetentionPolicy
        /// class.
        /// </summary>
        public BackupLongTermRetentionPolicy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupLongTermRetentionPolicy
        /// class.
        /// </summary>
        /// <param name="state">The status of the backup long term retention
        /// policy. Possible values include: 'Disabled', 'Enabled'</param>
        /// <param name="recoveryServicesBackupPolicyResourceId">The azure
        /// recovery services backup protection policy resource id</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        public BackupLongTermRetentionPolicy(BackupLongTermRetentionPolicyState state, string recoveryServicesBackupPolicyResourceId, string id = default(string), string name = default(string), string type = default(string), string location = default(string))
            : base(id, name, type)
        {
            Location = location;
            State = state;
            RecoveryServicesBackupPolicyResourceId = recoveryServicesBackupPolicyResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the geo-location where the resource lives
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or sets the status of the backup long term retention policy.
        /// Possible values include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public BackupLongTermRetentionPolicyState State { get; set; }

        /// <summary>
        /// Gets or sets the azure recovery services backup protection policy
        /// resource id
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoveryServicesBackupPolicyResourceId")]
        public string RecoveryServicesBackupPolicyResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RecoveryServicesBackupPolicyResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecoveryServicesBackupPolicyResourceId");
            }
        }
    }
}