// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SSIS package location.
    /// </summary>
    public partial class SSISPackageLocation
    {
        /// <summary>
        /// Initializes a new instance of the SSISPackageLocation class.
        /// </summary>
        public SSISPackageLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SSISPackageLocation class.
        /// </summary>
        /// <param name="packagePath">The SSIS package path. Type: string (or
        /// Expression with resultType string).</param>
        public SSISPackageLocation(object packagePath)
        {
            PackagePath = packagePath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SSIS package path. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "packagePath")]
        public object PackagePath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PackagePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PackagePath");
            }
        }
    }
}