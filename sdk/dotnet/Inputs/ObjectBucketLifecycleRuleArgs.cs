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

    public sealed class ObjectBucketLifecycleRuleArgs : Pulumi.ResourceArgs
    {
        [Input("abortIncompleteMultipartUploadDays")]
        public Input<int>? AbortIncompleteMultipartUploadDays { get; set; }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("expiration")]
        public Input<Inputs.ObjectBucketLifecycleRuleExpirationArgs>? Expiration { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        [Input("transitions")]
        private InputList<Inputs.ObjectBucketLifecycleRuleTransitionArgs>? _transitions;
        public InputList<Inputs.ObjectBucketLifecycleRuleTransitionArgs> Transitions
        {
            get => _transitions ?? (_transitions = new InputList<Inputs.ObjectBucketLifecycleRuleTransitionArgs>());
            set => _transitions = value;
        }

        public ObjectBucketLifecycleRuleArgs()
        {
        }
    }
}
