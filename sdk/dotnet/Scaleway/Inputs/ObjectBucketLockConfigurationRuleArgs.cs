// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Scaleway.Inputs
{

    public sealed class ObjectBucketLockConfigurationRuleArgs : global::Pulumi.ResourceArgs
    {
        [Input("defaultRetention", required: true)]
        public Input<Inputs.ObjectBucketLockConfigurationRuleDefaultRetentionArgs> DefaultRetention { get; set; } = null!;

        public ObjectBucketLockConfigurationRuleArgs()
        {
        }
        public static new ObjectBucketLockConfigurationRuleArgs Empty => new ObjectBucketLockConfigurationRuleArgs();
    }
}
