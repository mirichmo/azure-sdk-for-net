// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties for creating a custom image from a virtual machine.
    /// </summary>
    public partial class CustomImagePropertiesFromVmFragment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CustomImagePropertiesFromVmFragment class.
        /// </summary>
        public CustomImagePropertiesFromVmFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CustomImagePropertiesFromVmFragment class.
        /// </summary>
        /// <param name="sourceVmId">The source vm identifier.</param>
        /// <param name="windowsOsInfo">The Windows OS information of the
        /// VM.</param>
        /// <param name="linuxOsInfo">The Linux OS information of the
        /// VM.</param>
        public CustomImagePropertiesFromVmFragment(string sourceVmId = default(string), WindowsOsInfoFragment windowsOsInfo = default(WindowsOsInfoFragment), LinuxOsInfoFragment linuxOsInfo = default(LinuxOsInfoFragment))
        {
            SourceVmId = sourceVmId;
            WindowsOsInfo = windowsOsInfo;
            LinuxOsInfo = linuxOsInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source vm identifier.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVmId")]
        public string SourceVmId { get; set; }

        /// <summary>
        /// Gets or sets the Windows OS information of the VM.
        /// </summary>
        [JsonProperty(PropertyName = "windowsOsInfo")]
        public WindowsOsInfoFragment WindowsOsInfo { get; set; }

        /// <summary>
        /// Gets or sets the Linux OS information of the VM.
        /// </summary>
        [JsonProperty(PropertyName = "linuxOsInfo")]
        public LinuxOsInfoFragment LinuxOsInfo { get; set; }

    }
}