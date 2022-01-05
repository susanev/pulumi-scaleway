// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Scaleway.Outputs
{

    [OutputType]
    public sealed class DatabaseInstanceReadReplica
    {
        /// <summary>
        /// IP of the endpoint.
        /// </summary>
        public readonly string? Ip;
        /// <summary>
        /// The name of the Database Instance.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Port of the endpoint.
        /// </summary>
        public readonly int? Port;

        [OutputConstructor]
        private DatabaseInstanceReadReplica(
            string? ip,

            string? name,

            int? port)
        {
            Ip = ip;
            Name = name;
            Port = port;
        }
    }
}