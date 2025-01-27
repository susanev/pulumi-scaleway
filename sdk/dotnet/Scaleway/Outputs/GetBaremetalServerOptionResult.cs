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
    public sealed class GetBaremetalServerOptionResult
    {
        public readonly string ExpiresAt;
        /// <summary>
        /// The ID of the server.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The server name. Only one of `name` and `server_id` should be specified.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetBaremetalServerOptionResult(
            string expiresAt,

            string id,

            string name)
        {
            ExpiresAt = expiresAt;
            Id = id;
            Name = name;
        }
    }
}
