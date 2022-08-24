// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Scaleway.Outputs
{

    [OutputType]
    public sealed class GetDatabaseInstanceLoadBalancerResult
    {
        public readonly string EndpointId;
        public readonly string Hostname;
        public readonly string Ip;
        public readonly string Name;
        public readonly int Port;

        [OutputConstructor]
        private GetDatabaseInstanceLoadBalancerResult(
            string endpointId,

            string hostname,

            string ip,

            string name,

            int port)
        {
            EndpointId = endpointId;
            Hostname = hostname;
            Ip = ip;
            Name = name;
            Port = port;
        }
    }
}
