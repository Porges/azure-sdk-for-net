// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent
{
    using VirtualMachine.Definition;
    using Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using System.Threading.Tasks;
    using System.Threading;

    /// <summary>
    /// Entry point to virtual machine management API.
    /// </summary>
    public interface IVirtualMachines  :
        ISupportsListing<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachine>,
        ISupportsListingByResourceGroup<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachine>,
        ISupportsGettingByResourceGroup<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachine>,
        ISupportsGettingById<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachine>,
        ISupportsCreating<VirtualMachine.Definition.IBlank>,
        ISupportsDeletingById,
        ISupportsDeletingByResourceGroup,
        ISupportsBatchCreation<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachine>,
        ISupportsBatchDeletion,
        IHasManager<IComputeManager>,
        IHasInner<IVirtualMachinesOperations>
    {
        /// <summary>
        /// Gets available virtual machine sizes.
        /// </summary>
        Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineSizes Sizes { get; }

        /// <summary>
        /// Restart a virtual machine.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        void Restart(string groupName, string name);

        /// <summary>
        /// Restart a virtual machine.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        Task RestartAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Power off (stop) a virtual machine.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        void PowerOff(string groupName, string name);

        /// <summary>
        /// Power off (stop) a virtual machine.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        Task PowerOffAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Shuts down the virtual machine and releases the compute resources.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        void Deallocate(string groupName, string name);

        /// <summary>
        /// Shuts down the virtual machine and releases the compute resources.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        Task DeallocateAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Start a virtual machine.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        void Start(string groupName, string name);

        /// <summary>
        /// Start a virtual machine.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        Task StartAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Convert (migrate) the virtual machine with un-managed disks to use managed disk.
        /// </summary>
        /// <param name="groupName">The resource group name.</param>
        /// <param name="name">The virtual machine name.</param>
        void ConvertToManaged(string groupName, string name);

        /// <summary>
        /// Convert (migrate) the virtual machine with un-managed disks to use managed disk.
        /// </summary>
        /// <param name="groupName">The resource group name.</param>
        /// <param name="name">The virtual machine name.</param>
        Task ConvertToManagedAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generalize the virtual machine.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        void Generalize(string groupName, string name);

        /// <summary>
        /// Generalize the virtual machine.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        Task GeneralizeAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Redeploy a virtual machine.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        void Redeploy(string groupName, string name);

        /// <summary>
        /// Redeploy a virtual machine.
        /// </summary>
        /// <param name="groupName">The name of the resource group the virtual machine is in.</param>
        /// <param name="name">The virtual machine name.</param>
        Task RedeployAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Captures the virtual machine by copying virtual hard disks of the VM and returns template as json
        /// string that can be used to create similar VMs.
        /// </summary>
        /// <param name="groupName">The resource group name.</param>
        /// <param name="name">The virtual machine name.</param>
        /// <param name="containerName">Destination container name to store the captured VHD.</param>
        /// <param name="vhdPrefix">The prefix for the vhd holding captured image.</param>
        /// <param name="overwriteVhd">Whether to overwrites destination VHD if it exists.</param>
        /// <return>The template as JSON string.</return>
        string Capture(string groupName, string name, string containerName, string vhdPrefix, bool overwriteVhd);
        
        /// <summary>
        /// Captures the virtual machine by copying virtual hard disks of the VM and returns template as json
        /// string that can be used to create similar VMs.
        /// </summary>
        /// <param name="groupName">The resource group name.</param>
        /// <param name="name">The virtual machine name.</param>
        /// <param name="containerName">Destination container name to store the captured VHD.</param>
        /// <param name="vhdPrefix">The prefix for the vhd holding captured image.</param>
        /// <param name="overwriteVhd">Whether to overwrites destination VHD if it exists.</param>
        /// <return>The template as JSON string.</return>
        Task<string> CaptureAsync(
            string groupName, 
            string name, 
            string containerName, 
            string vhdPrefix, 
            bool overwriteVhd,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}