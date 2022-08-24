// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Scaleway
{
    [ScalewayResourceType("scaleway:index/loadbalancerFrontend:LoadbalancerFrontend")]
    public partial class LoadbalancerFrontend : Pulumi.CustomResource
    {
        /// <summary>
        /// ACL rules
        /// </summary>
        [Output("acls")]
        public Output<ImmutableArray<Outputs.LoadbalancerFrontendAcl>> Acls { get; private set; } = null!;

        /// <summary>
        /// The load-balancer backend ID
        /// </summary>
        [Output("backendId")]
        public Output<string> BackendId { get; private set; } = null!;

        /// <summary>
        /// Certificate ID
        /// </summary>
        [Output("certificateId")]
        public Output<string> CertificateId { get; private set; } = null!;

        /// <summary>
        /// Collection of Certificate IDs related to the load balancer and domain
        /// </summary>
        [Output("certificateIds")]
        public Output<ImmutableArray<string>> CertificateIds { get; private set; } = null!;

        /// <summary>
        /// TCP port to listen on the front side
        /// </summary>
        [Output("inboundPort")]
        public Output<int> InboundPort { get; private set; } = null!;

        /// <summary>
        /// The load-balancer ID
        /// </summary>
        [Output("lbId")]
        public Output<string> LbId { get; private set; } = null!;

        /// <summary>
        /// The name of the frontend
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Set the maximum inactivity time on the client side
        /// </summary>
        [Output("timeoutClient")]
        public Output<string?> TimeoutClient { get; private set; } = null!;


        /// <summary>
        /// Create a LoadbalancerFrontend resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LoadbalancerFrontend(string name, LoadbalancerFrontendArgs args, CustomResourceOptions? options = null)
            : base("scaleway:index/loadbalancerFrontend:LoadbalancerFrontend", name, args ?? new LoadbalancerFrontendArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LoadbalancerFrontend(string name, Input<string> id, LoadbalancerFrontendState? state = null, CustomResourceOptions? options = null)
            : base("scaleway:index/loadbalancerFrontend:LoadbalancerFrontend", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LoadbalancerFrontend resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LoadbalancerFrontend Get(string name, Input<string> id, LoadbalancerFrontendState? state = null, CustomResourceOptions? options = null)
        {
            return new LoadbalancerFrontend(name, id, state, options);
        }
    }

    public sealed class LoadbalancerFrontendArgs : Pulumi.ResourceArgs
    {
        [Input("acls")]
        private InputList<Inputs.LoadbalancerFrontendAclArgs>? _acls;

        /// <summary>
        /// ACL rules
        /// </summary>
        public InputList<Inputs.LoadbalancerFrontendAclArgs> Acls
        {
            get => _acls ?? (_acls = new InputList<Inputs.LoadbalancerFrontendAclArgs>());
            set => _acls = value;
        }

        /// <summary>
        /// The load-balancer backend ID
        /// </summary>
        [Input("backendId", required: true)]
        public Input<string> BackendId { get; set; } = null!;

        [Input("certificateIds")]
        private InputList<string>? _certificateIds;

        /// <summary>
        /// Collection of Certificate IDs related to the load balancer and domain
        /// </summary>
        public InputList<string> CertificateIds
        {
            get => _certificateIds ?? (_certificateIds = new InputList<string>());
            set => _certificateIds = value;
        }

        /// <summary>
        /// TCP port to listen on the front side
        /// </summary>
        [Input("inboundPort", required: true)]
        public Input<int> InboundPort { get; set; } = null!;

        /// <summary>
        /// The load-balancer ID
        /// </summary>
        [Input("lbId", required: true)]
        public Input<string> LbId { get; set; } = null!;

        /// <summary>
        /// The name of the frontend
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Set the maximum inactivity time on the client side
        /// </summary>
        [Input("timeoutClient")]
        public Input<string>? TimeoutClient { get; set; }

        public LoadbalancerFrontendArgs()
        {
        }
    }

    public sealed class LoadbalancerFrontendState : Pulumi.ResourceArgs
    {
        [Input("acls")]
        private InputList<Inputs.LoadbalancerFrontendAclGetArgs>? _acls;

        /// <summary>
        /// ACL rules
        /// </summary>
        public InputList<Inputs.LoadbalancerFrontendAclGetArgs> Acls
        {
            get => _acls ?? (_acls = new InputList<Inputs.LoadbalancerFrontendAclGetArgs>());
            set => _acls = value;
        }

        /// <summary>
        /// The load-balancer backend ID
        /// </summary>
        [Input("backendId")]
        public Input<string>? BackendId { get; set; }

        /// <summary>
        /// Certificate ID
        /// </summary>
        [Input("certificateId")]
        public Input<string>? CertificateId { get; set; }

        [Input("certificateIds")]
        private InputList<string>? _certificateIds;

        /// <summary>
        /// Collection of Certificate IDs related to the load balancer and domain
        /// </summary>
        public InputList<string> CertificateIds
        {
            get => _certificateIds ?? (_certificateIds = new InputList<string>());
            set => _certificateIds = value;
        }

        /// <summary>
        /// TCP port to listen on the front side
        /// </summary>
        [Input("inboundPort")]
        public Input<int>? InboundPort { get; set; }

        /// <summary>
        /// The load-balancer ID
        /// </summary>
        [Input("lbId")]
        public Input<string>? LbId { get; set; }

        /// <summary>
        /// The name of the frontend
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Set the maximum inactivity time on the client side
        /// </summary>
        [Input("timeoutClient")]
        public Input<string>? TimeoutClient { get; set; }

        public LoadbalancerFrontendState()
        {
        }
    }
}
