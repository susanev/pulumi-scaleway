// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Scaleway
{
    /// <summary>
    /// Creates and manages Scaleway VPC Public Gateway PAT (Port Address Translation).
    /// For more information, see [the documentation](https://developers.scaleway.com/en/products/vpc-gw/api/v1#pat-rules-e75d10).
    /// 
    /// ## Example
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Scaleway = Pulumi.Scaleway;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var pg01 = new Scaleway.VpcPublicGateway("pg01", new Scaleway.VpcPublicGatewayArgs
    ///         {
    ///             Type = "VPC-GW-S",
    ///         });
    ///         var dhcp01 = new Scaleway.VpcPublicGatewayDhcp("dhcp01", new Scaleway.VpcPublicGatewayDhcpArgs
    ///         {
    ///             Subnet = "192.168.1.0/24",
    ///         });
    ///         var pn01 = new Scaleway.VpcPrivateNetwork("pn01", new Scaleway.VpcPrivateNetworkArgs
    ///         {
    ///         });
    ///         var gn01 = new Scaleway.VpcGatewayNetwork("gn01", new Scaleway.VpcGatewayNetworkArgs
    ///         {
    ///             GatewayId = pg01.Id,
    ///             PrivateNetworkId = pn01.Id,
    ///             DhcpId = dhcp01.Id,
    ///             CleanupDhcp = true,
    ///         });
    ///         var main = new Scaleway.VpcPublicGatewayPatRule("main", new Scaleway.VpcPublicGatewayPatRuleArgs
    ///         {
    ///             GatewayId = pg01.Id,
    ///             PrivateIp = dhcp01.Address,
    ///             PrivatePort = 42,
    ///             PublicPort = 42,
    ///             Protocol = "both",
    ///         }, new CustomResourceOptions
    ///         {
    ///             DependsOn = 
    ///             {
    ///                 gn01,
    ///                 pn01,
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Public gateway PAT rules config can be imported using the `{zone}/{id}`, e.g. bash
    /// 
    /// ```sh
    ///  $ pulumi import scaleway:index/vpcPublicGatewayPatRule:VpcPublicGatewayPatRule main fr-par-1/11111111-1111-1111-1111-111111111111
    /// ```
    /// </summary>
    [ScalewayResourceType("scaleway:index/vpcPublicGatewayPatRule:VpcPublicGatewayPatRule")]
    public partial class VpcPublicGatewayPatRule : Pulumi.CustomResource
    {
        /// <summary>
        /// The date and time of the creation of the pat rule config.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// The ID of the public gateway.
        /// </summary>
        [Output("gatewayId")]
        public Output<string> GatewayId { get; private set; } = null!;

        /// <summary>
        /// The organization ID the pat rule config is associated with.
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// The Private IP to forward data to (IP address).
        /// </summary>
        [Output("privateIp")]
        public Output<string> PrivateIp { get; private set; } = null!;

        /// <summary>
        /// The Private port to translate to.
        /// </summary>
        [Output("privatePort")]
        public Output<int> PrivatePort { get; private set; } = null!;

        /// <summary>
        /// The Protocol the rule should apply to. Possible values are both, tcp and udp.
        /// </summary>
        [Output("protocol")]
        public Output<string?> Protocol { get; private set; } = null!;

        /// <summary>
        /// The Public port to listen on.
        /// </summary>
        [Output("publicPort")]
        public Output<int> PublicPort { get; private set; } = null!;

        /// <summary>
        /// The date and time of the last update of the pat rule config.
        /// </summary>
        [Output("updatedAt")]
        public Output<string> UpdatedAt { get; private set; } = null!;

        /// <summary>
        /// `zone`) The zone in which the public gateway DHCP config should be created.
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a VpcPublicGatewayPatRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VpcPublicGatewayPatRule(string name, VpcPublicGatewayPatRuleArgs args, CustomResourceOptions? options = null)
            : base("scaleway:index/vpcPublicGatewayPatRule:VpcPublicGatewayPatRule", name, args ?? new VpcPublicGatewayPatRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VpcPublicGatewayPatRule(string name, Input<string> id, VpcPublicGatewayPatRuleState? state = null, CustomResourceOptions? options = null)
            : base("scaleway:index/vpcPublicGatewayPatRule:VpcPublicGatewayPatRule", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/jaxxstorm/pulumi-scaleway/releases/download/${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VpcPublicGatewayPatRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VpcPublicGatewayPatRule Get(string name, Input<string> id, VpcPublicGatewayPatRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new VpcPublicGatewayPatRule(name, id, state, options);
        }
    }

    public sealed class VpcPublicGatewayPatRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the public gateway.
        /// </summary>
        [Input("gatewayId", required: true)]
        public Input<string> GatewayId { get; set; } = null!;

        /// <summary>
        /// The Private IP to forward data to (IP address).
        /// </summary>
        [Input("privateIp", required: true)]
        public Input<string> PrivateIp { get; set; } = null!;

        /// <summary>
        /// The Private port to translate to.
        /// </summary>
        [Input("privatePort", required: true)]
        public Input<int> PrivatePort { get; set; } = null!;

        /// <summary>
        /// The Protocol the rule should apply to. Possible values are both, tcp and udp.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The Public port to listen on.
        /// </summary>
        [Input("publicPort", required: true)]
        public Input<int> PublicPort { get; set; } = null!;

        /// <summary>
        /// `zone`) The zone in which the public gateway DHCP config should be created.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public VpcPublicGatewayPatRuleArgs()
        {
        }
    }

    public sealed class VpcPublicGatewayPatRuleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The date and time of the creation of the pat rule config.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// The ID of the public gateway.
        /// </summary>
        [Input("gatewayId")]
        public Input<string>? GatewayId { get; set; }

        /// <summary>
        /// The organization ID the pat rule config is associated with.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        /// <summary>
        /// The Private IP to forward data to (IP address).
        /// </summary>
        [Input("privateIp")]
        public Input<string>? PrivateIp { get; set; }

        /// <summary>
        /// The Private port to translate to.
        /// </summary>
        [Input("privatePort")]
        public Input<int>? PrivatePort { get; set; }

        /// <summary>
        /// The Protocol the rule should apply to. Possible values are both, tcp and udp.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The Public port to listen on.
        /// </summary>
        [Input("publicPort")]
        public Input<int>? PublicPort { get; set; }

        /// <summary>
        /// The date and time of the last update of the pat rule config.
        /// </summary>
        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        /// <summary>
        /// `zone`) The zone in which the public gateway DHCP config should be created.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public VpcPublicGatewayPatRuleState()
        {
        }
    }
}
