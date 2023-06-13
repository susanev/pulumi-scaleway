// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Scaleway.Outputs
{

    [OutputType]
    public sealed class BaremetalServerPrivateNetwork
    {
        /// <summary>
        /// The date and time of the creation of the private network.
        /// </summary>
        public readonly string? CreatedAt;
        /// <summary>
        /// The id of the private network to attach.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The private network status.
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// The date and time of the last update of the private network.
        /// </summary>
        public readonly string? UpdatedAt;
        /// <summary>
        /// The VLAN ID associated to the private network.
        /// </summary>
        public readonly int? Vlan;

        [OutputConstructor]
        private BaremetalServerPrivateNetwork(
            string? createdAt,

            string id,

            string? status,

            string? updatedAt,

            int? vlan)
        {
            CreatedAt = createdAt;
            Id = id;
            Status = status;
            UpdatedAt = updatedAt;
            Vlan = vlan;
        }
    }
}