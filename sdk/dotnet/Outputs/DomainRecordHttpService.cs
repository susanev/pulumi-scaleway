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
    public sealed class DomainRecordHttpService
    {
        public readonly ImmutableArray<string> Ips;
        public readonly string MustContain;
        public readonly string Strategy;
        public readonly string Url;
        public readonly string? UserAgent;

        [OutputConstructor]
        private DomainRecordHttpService(
            ImmutableArray<string> ips,

            string mustContain,

            string strategy,

            string url,

            string? userAgent)
        {
            Ips = ips;
            MustContain = mustContain;
            Strategy = strategy;
            Url = url;
            UserAgent = userAgent;
        }
    }
}
