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
    [ScalewayResourceType("scaleway:index/instanceServer:InstanceServer")]
    public partial class InstanceServer : Pulumi.CustomResource
    {
        /// <summary>
        /// The additional volumes attached to the server
        /// </summary>
        [Output("additionalVolumeIds")]
        public Output<ImmutableArray<string>> AdditionalVolumeIds { get; private set; } = null!;

        /// <summary>
        /// The boot type of the server
        /// </summary>
        [Output("bootType")]
        public Output<string?> BootType { get; private set; } = null!;

        /// <summary>
        /// ID of the target bootscript (set boot_type to bootscript)
        /// </summary>
        [Output("bootscriptId")]
        public Output<string> BootscriptId { get; private set; } = null!;

        /// <summary>
        /// The cloud init script associated with this server
        /// </summary>
        [Output("cloudInit")]
        public Output<string?> CloudInit { get; private set; } = null!;

        /// <summary>
        /// Enable dynamic IP on the server
        /// </summary>
        [Output("enableDynamicIp")]
        public Output<bool?> EnableDynamicIp { get; private set; } = null!;

        /// <summary>
        /// Determines if IPv6 is enabled for the server
        /// </summary>
        [Output("enableIpv6")]
        public Output<bool?> EnableIpv6 { get; private set; } = null!;

        /// <summary>
        /// The UUID or the label of the base image used by the server
        /// </summary>
        [Output("image")]
        public Output<string> Image { get; private set; } = null!;

        /// <summary>
        /// The ID of the reserved IP for the server
        /// </summary>
        [Output("ipId")]
        public Output<string?> IpId { get; private set; } = null!;

        /// <summary>
        /// The default public IPv6 address routed to the server.
        /// </summary>
        [Output("ipv6Address")]
        public Output<string> Ipv6Address { get; private set; } = null!;

        /// <summary>
        /// The IPv6 gateway address
        /// </summary>
        [Output("ipv6Gateway")]
        public Output<string> Ipv6Gateway { get; private set; } = null!;

        /// <summary>
        /// The IPv6 prefix length routed to the server.
        /// </summary>
        [Output("ipv6PrefixLength")]
        public Output<int> Ipv6PrefixLength { get; private set; } = null!;

        /// <summary>
        /// The name of the server
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The organization_id you want to attach the resource to
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// The placement group the server is attached to
        /// </summary>
        [Output("placementGroupId")]
        public Output<string?> PlacementGroupId { get; private set; } = null!;

        /// <summary>
        /// True when the placement group policy is respected
        /// </summary>
        [Output("placementGroupPolicyRespected")]
        public Output<bool> PlacementGroupPolicyRespected { get; private set; } = null!;

        /// <summary>
        /// The Scaleway internal IP address of the server
        /// </summary>
        [Output("privateIp")]
        public Output<string> PrivateIp { get; private set; } = null!;

        /// <summary>
        /// List of private network to connect with your instance
        /// </summary>
        [Output("privateNetworks")]
        public Output<ImmutableArray<Outputs.InstanceServerPrivateNetwork>> PrivateNetworks { get; private set; } = null!;

        /// <summary>
        /// The project_id you want to attach the resource to
        /// </summary>
        [Output("projectId")]
        public Output<string> ProjectId { get; private set; } = null!;

        /// <summary>
        /// The public IPv4 address of the server
        /// </summary>
        [Output("publicIp")]
        public Output<string> PublicIp { get; private set; } = null!;

        /// <summary>
        /// Root volume attached to the server on creation
        /// </summary>
        [Output("rootVolume")]
        public Output<Outputs.InstanceServerRootVolume> RootVolume { get; private set; } = null!;

        /// <summary>
        /// The security group the server is attached to
        /// </summary>
        [Output("securityGroupId")]
        public Output<string> SecurityGroupId { get; private set; } = null!;

        /// <summary>
        /// The state of the server should be: started, stopped, standby
        /// </summary>
        [Output("state")]
        public Output<string?> State { get; private set; } = null!;

        /// <summary>
        /// The tags associated with the server
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// The instance type of the server
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The user data associated with the server
        /// </summary>
        [Output("userData")]
        public Output<ImmutableDictionary<string, string>?> UserData { get; private set; } = null!;

        /// <summary>
        /// The zone you want to attach the resource to
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a InstanceServer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public InstanceServer(string name, InstanceServerArgs args, CustomResourceOptions? options = null)
            : base("scaleway:index/instanceServer:InstanceServer", name, args ?? new InstanceServerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private InstanceServer(string name, Input<string> id, InstanceServerState? state = null, CustomResourceOptions? options = null)
            : base("scaleway:index/instanceServer:InstanceServer", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing InstanceServer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static InstanceServer Get(string name, Input<string> id, InstanceServerState? state = null, CustomResourceOptions? options = null)
        {
            return new InstanceServer(name, id, state, options);
        }
    }

    public sealed class InstanceServerArgs : Pulumi.ResourceArgs
    {
        [Input("additionalVolumeIds")]
        private InputList<string>? _additionalVolumeIds;

        /// <summary>
        /// The additional volumes attached to the server
        /// </summary>
        public InputList<string> AdditionalVolumeIds
        {
            get => _additionalVolumeIds ?? (_additionalVolumeIds = new InputList<string>());
            set => _additionalVolumeIds = value;
        }

        /// <summary>
        /// The boot type of the server
        /// </summary>
        [Input("bootType")]
        public Input<string>? BootType { get; set; }

        /// <summary>
        /// ID of the target bootscript (set boot_type to bootscript)
        /// </summary>
        [Input("bootscriptId")]
        public Input<string>? BootscriptId { get; set; }

        /// <summary>
        /// The cloud init script associated with this server
        /// </summary>
        [Input("cloudInit")]
        public Input<string>? CloudInit { get; set; }

        /// <summary>
        /// Enable dynamic IP on the server
        /// </summary>
        [Input("enableDynamicIp")]
        public Input<bool>? EnableDynamicIp { get; set; }

        /// <summary>
        /// Determines if IPv6 is enabled for the server
        /// </summary>
        [Input("enableIpv6")]
        public Input<bool>? EnableIpv6 { get; set; }

        /// <summary>
        /// The UUID or the label of the base image used by the server
        /// </summary>
        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        /// <summary>
        /// The ID of the reserved IP for the server
        /// </summary>
        [Input("ipId")]
        public Input<string>? IpId { get; set; }

        /// <summary>
        /// The name of the server
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The placement group the server is attached to
        /// </summary>
        [Input("placementGroupId")]
        public Input<string>? PlacementGroupId { get; set; }

        [Input("privateNetworks")]
        private InputList<Inputs.InstanceServerPrivateNetworkArgs>? _privateNetworks;

        /// <summary>
        /// List of private network to connect with your instance
        /// </summary>
        public InputList<Inputs.InstanceServerPrivateNetworkArgs> PrivateNetworks
        {
            get => _privateNetworks ?? (_privateNetworks = new InputList<Inputs.InstanceServerPrivateNetworkArgs>());
            set => _privateNetworks = value;
        }

        /// <summary>
        /// The project_id you want to attach the resource to
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        /// <summary>
        /// Root volume attached to the server on creation
        /// </summary>
        [Input("rootVolume")]
        public Input<Inputs.InstanceServerRootVolumeArgs>? RootVolume { get; set; }

        /// <summary>
        /// The security group the server is attached to
        /// </summary>
        [Input("securityGroupId")]
        public Input<string>? SecurityGroupId { get; set; }

        /// <summary>
        /// The state of the server should be: started, stopped, standby
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// The tags associated with the server
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The instance type of the server
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("userData")]
        private InputMap<string>? _userData;

        /// <summary>
        /// The user data associated with the server
        /// </summary>
        public InputMap<string> UserData
        {
            get => _userData ?? (_userData = new InputMap<string>());
            set => _userData = value;
        }

        /// <summary>
        /// The zone you want to attach the resource to
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public InstanceServerArgs()
        {
        }
    }

    public sealed class InstanceServerState : Pulumi.ResourceArgs
    {
        [Input("additionalVolumeIds")]
        private InputList<string>? _additionalVolumeIds;

        /// <summary>
        /// The additional volumes attached to the server
        /// </summary>
        public InputList<string> AdditionalVolumeIds
        {
            get => _additionalVolumeIds ?? (_additionalVolumeIds = new InputList<string>());
            set => _additionalVolumeIds = value;
        }

        /// <summary>
        /// The boot type of the server
        /// </summary>
        [Input("bootType")]
        public Input<string>? BootType { get; set; }

        /// <summary>
        /// ID of the target bootscript (set boot_type to bootscript)
        /// </summary>
        [Input("bootscriptId")]
        public Input<string>? BootscriptId { get; set; }

        /// <summary>
        /// The cloud init script associated with this server
        /// </summary>
        [Input("cloudInit")]
        public Input<string>? CloudInit { get; set; }

        /// <summary>
        /// Enable dynamic IP on the server
        /// </summary>
        [Input("enableDynamicIp")]
        public Input<bool>? EnableDynamicIp { get; set; }

        /// <summary>
        /// Determines if IPv6 is enabled for the server
        /// </summary>
        [Input("enableIpv6")]
        public Input<bool>? EnableIpv6 { get; set; }

        /// <summary>
        /// The UUID or the label of the base image used by the server
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// The ID of the reserved IP for the server
        /// </summary>
        [Input("ipId")]
        public Input<string>? IpId { get; set; }

        /// <summary>
        /// The default public IPv6 address routed to the server.
        /// </summary>
        [Input("ipv6Address")]
        public Input<string>? Ipv6Address { get; set; }

        /// <summary>
        /// The IPv6 gateway address
        /// </summary>
        [Input("ipv6Gateway")]
        public Input<string>? Ipv6Gateway { get; set; }

        /// <summary>
        /// The IPv6 prefix length routed to the server.
        /// </summary>
        [Input("ipv6PrefixLength")]
        public Input<int>? Ipv6PrefixLength { get; set; }

        /// <summary>
        /// The name of the server
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The organization_id you want to attach the resource to
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        /// <summary>
        /// The placement group the server is attached to
        /// </summary>
        [Input("placementGroupId")]
        public Input<string>? PlacementGroupId { get; set; }

        /// <summary>
        /// True when the placement group policy is respected
        /// </summary>
        [Input("placementGroupPolicyRespected")]
        public Input<bool>? PlacementGroupPolicyRespected { get; set; }

        /// <summary>
        /// The Scaleway internal IP address of the server
        /// </summary>
        [Input("privateIp")]
        public Input<string>? PrivateIp { get; set; }

        [Input("privateNetworks")]
        private InputList<Inputs.InstanceServerPrivateNetworkGetArgs>? _privateNetworks;

        /// <summary>
        /// List of private network to connect with your instance
        /// </summary>
        public InputList<Inputs.InstanceServerPrivateNetworkGetArgs> PrivateNetworks
        {
            get => _privateNetworks ?? (_privateNetworks = new InputList<Inputs.InstanceServerPrivateNetworkGetArgs>());
            set => _privateNetworks = value;
        }

        /// <summary>
        /// The project_id you want to attach the resource to
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        /// <summary>
        /// The public IPv4 address of the server
        /// </summary>
        [Input("publicIp")]
        public Input<string>? PublicIp { get; set; }

        /// <summary>
        /// Root volume attached to the server on creation
        /// </summary>
        [Input("rootVolume")]
        public Input<Inputs.InstanceServerRootVolumeGetArgs>? RootVolume { get; set; }

        /// <summary>
        /// The security group the server is attached to
        /// </summary>
        [Input("securityGroupId")]
        public Input<string>? SecurityGroupId { get; set; }

        /// <summary>
        /// The state of the server should be: started, stopped, standby
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// The tags associated with the server
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The instance type of the server
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("userData")]
        private InputMap<string>? _userData;

        /// <summary>
        /// The user data associated with the server
        /// </summary>
        public InputMap<string> UserData
        {
            get => _userData ?? (_userData = new InputMap<string>());
            set => _userData = value;
        }

        /// <summary>
        /// The zone you want to attach the resource to
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public InstanceServerState()
        {
        }
    }
}
