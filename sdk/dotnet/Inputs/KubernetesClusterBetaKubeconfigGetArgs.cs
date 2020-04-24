// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Scaleway.Inputs
{

    public sealed class KubernetesClusterBetaKubeconfigGetArgs : Pulumi.ResourceArgs
    {
        [Input("clusterCaCertificate")]
        public Input<string>? ClusterCaCertificate { get; set; }

        [Input("configFile")]
        public Input<string>? ConfigFile { get; set; }

        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("token")]
        public Input<string>? Token { get; set; }

        public KubernetesClusterBetaKubeconfigGetArgs()
        {
        }
    }
}