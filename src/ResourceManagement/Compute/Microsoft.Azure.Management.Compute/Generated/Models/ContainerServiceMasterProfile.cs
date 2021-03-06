// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Profile for the container service master.
    /// </summary>
    public partial class ContainerServiceMasterProfile
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceMasterProfile
        /// class.
        /// </summary>
        public ContainerServiceMasterProfile() { }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceMasterProfile
        /// class.
        /// </summary>
        /// <param name="dnsPrefix">DNS prefix to be used to create the FQDN
        /// for master.</param>
        /// <param name="count">Number of masters (VMs) in the container
        /// service cluster. Allowed values are 1, 3, and 5. The default value
        /// is 1.</param>
        /// <param name="fqdn">FDQN for the master.</param>
        public ContainerServiceMasterProfile(string dnsPrefix, int? count = default(int?), string fqdn = default(string))
        {
            Count = count;
            DnsPrefix = dnsPrefix;
            Fqdn = fqdn;
        }

        /// <summary>
        /// Gets or sets number of masters (VMs) in the container service
        /// cluster. Allowed values are 1, 3, and 5. The default value is 1.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets DNS prefix to be used to create the FQDN for master.
        /// </summary>
        [JsonProperty(PropertyName = "dnsPrefix")]
        public string DnsPrefix { get; set; }

        /// <summary>
        /// Gets FDQN for the master.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DnsPrefix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DnsPrefix");
            }
        }
    }
}

