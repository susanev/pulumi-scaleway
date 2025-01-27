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
    public sealed class GetBaremetalServerPrivateNetworkResult
    {
        public readonly string CreatedAt;
        /// <summary>
        /// The ID of the server.
        /// </summary>
        public readonly string Id;
        public readonly string Status;
        public readonly string UpdatedAt;
        public readonly int Vlan;

        [OutputConstructor]
        private GetBaremetalServerPrivateNetworkResult(
            string createdAt,

            string id,

            string status,

            string updatedAt,

            int vlan)
        {
            CreatedAt = createdAt;
            Id = id;
            Status = status;
            UpdatedAt = updatedAt;
            Vlan = vlan;
        }
    }
}
