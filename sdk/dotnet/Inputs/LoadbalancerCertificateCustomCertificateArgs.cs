// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Scaleway.Inputs
{

    public sealed class LoadbalancerCertificateCustomCertificateArgs : Pulumi.ResourceArgs
    {
        [Input("certificateChain", required: true)]
        public Input<string> CertificateChain { get; set; } = null!;

        public LoadbalancerCertificateCustomCertificateArgs()
        {
        }
    }
}
