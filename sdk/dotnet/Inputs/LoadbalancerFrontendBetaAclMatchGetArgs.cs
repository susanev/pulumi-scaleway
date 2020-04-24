// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Scaleway.Inputs
{

    public sealed class LoadbalancerFrontendBetaAclMatchGetArgs : Pulumi.ResourceArgs
    {
        [Input("httpFilter")]
        public Input<string>? HttpFilter { get; set; }

        [Input("httpFilterValues")]
        private InputList<string>? _httpFilterValues;
        public InputList<string> HttpFilterValues
        {
            get => _httpFilterValues ?? (_httpFilterValues = new InputList<string>());
            set => _httpFilterValues = value;
        }

        [Input("invert")]
        public Input<bool>? Invert { get; set; }

        [Input("ipSubnets")]
        private InputList<string>? _ipSubnets;
        public InputList<string> IpSubnets
        {
            get => _ipSubnets ?? (_ipSubnets = new InputList<string>());
            set => _ipSubnets = value;
        }

        public LoadbalancerFrontendBetaAclMatchGetArgs()
        {
        }
    }
}