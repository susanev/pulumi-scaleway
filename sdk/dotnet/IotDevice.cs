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
    /// ## Import
    /// 
    /// IoT devices can be imported using the `{region}/{id}`, e.g. bash
    /// 
    /// ```sh
    ///  $ pulumi import scaleway:index/iotDevice:IotDevice device01 fr-par/11111111-1111-1111-1111-111111111111
    /// ```
    /// </summary>
    [ScalewayResourceType("scaleway:index/iotDevice:IotDevice")]
    public partial class IotDevice : Pulumi.CustomResource
    {
        /// <summary>
        /// Allow plain and server-authenticated TLS connections in addition to mutually-authenticated ones.
        /// </summary>
        [Output("allowInsecure")]
        public Output<bool?> AllowInsecure { get; private set; } = null!;

        /// <summary>
        /// Allow more than one simultaneous connection using the same device credentials.
        /// </summary>
        [Output("allowMultipleConnections")]
        public Output<bool?> AllowMultipleConnections { get; private set; } = null!;

        /// <summary>
        /// The certificate bundle of the device.
        /// </summary>
        [Output("certificate")]
        public Output<Outputs.IotDeviceCertificate> Certificate { get; private set; } = null!;

        /// <summary>
        /// The date and time the device was created.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// The description of the IoT device (e.g. `living room`).
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The ID of the hub on which this device will be created.
        /// </summary>
        [Output("hubId")]
        public Output<string> HubId { get; private set; } = null!;

        /// <summary>
        /// The current connection status of the device.
        /// </summary>
        [Output("isConnected")]
        public Output<bool> IsConnected { get; private set; } = null!;

        /// <summary>
        /// The last MQTT activity of the device.
        /// </summary>
        [Output("lastActivityAt")]
        public Output<string> LastActivityAt { get; private set; } = null!;

        /// <summary>
        /// Rules that define which messages are authorized or denied based on their topic.
        /// </summary>
        [Output("messageFilters")]
        public Output<Outputs.IotDeviceMessageFilters?> MessageFilters { get; private set; } = null!;

        /// <summary>
        /// The name of the IoT device you want to create (e.g. `my-device`).
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The region you want to attach the resource to
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        /// <summary>
        /// The current status of the device.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The date and time the device resource was updated.
        /// </summary>
        [Output("updatedAt")]
        public Output<string> UpdatedAt { get; private set; } = null!;


        /// <summary>
        /// Create a IotDevice resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IotDevice(string name, IotDeviceArgs args, CustomResourceOptions? options = null)
            : base("scaleway:index/iotDevice:IotDevice", name, args ?? new IotDeviceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IotDevice(string name, Input<string> id, IotDeviceState? state = null, CustomResourceOptions? options = null)
            : base("scaleway:index/iotDevice:IotDevice", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IotDevice resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IotDevice Get(string name, Input<string> id, IotDeviceState? state = null, CustomResourceOptions? options = null)
        {
            return new IotDevice(name, id, state, options);
        }
    }

    public sealed class IotDeviceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Allow plain and server-authenticated TLS connections in addition to mutually-authenticated ones.
        /// </summary>
        [Input("allowInsecure")]
        public Input<bool>? AllowInsecure { get; set; }

        /// <summary>
        /// Allow more than one simultaneous connection using the same device credentials.
        /// </summary>
        [Input("allowMultipleConnections")]
        public Input<bool>? AllowMultipleConnections { get; set; }

        /// <summary>
        /// The certificate bundle of the device.
        /// </summary>
        [Input("certificate")]
        public Input<Inputs.IotDeviceCertificateArgs>? Certificate { get; set; }

        /// <summary>
        /// The description of the IoT device (e.g. `living room`).
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the hub on which this device will be created.
        /// </summary>
        [Input("hubId", required: true)]
        public Input<string> HubId { get; set; } = null!;

        /// <summary>
        /// Rules that define which messages are authorized or denied based on their topic.
        /// </summary>
        [Input("messageFilters")]
        public Input<Inputs.IotDeviceMessageFiltersArgs>? MessageFilters { get; set; }

        /// <summary>
        /// The name of the IoT device you want to create (e.g. `my-device`).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The region you want to attach the resource to
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        public IotDeviceArgs()
        {
        }
    }

    public sealed class IotDeviceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Allow plain and server-authenticated TLS connections in addition to mutually-authenticated ones.
        /// </summary>
        [Input("allowInsecure")]
        public Input<bool>? AllowInsecure { get; set; }

        /// <summary>
        /// Allow more than one simultaneous connection using the same device credentials.
        /// </summary>
        [Input("allowMultipleConnections")]
        public Input<bool>? AllowMultipleConnections { get; set; }

        /// <summary>
        /// The certificate bundle of the device.
        /// </summary>
        [Input("certificate")]
        public Input<Inputs.IotDeviceCertificateGetArgs>? Certificate { get; set; }

        /// <summary>
        /// The date and time the device was created.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// The description of the IoT device (e.g. `living room`).
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the hub on which this device will be created.
        /// </summary>
        [Input("hubId")]
        public Input<string>? HubId { get; set; }

        /// <summary>
        /// The current connection status of the device.
        /// </summary>
        [Input("isConnected")]
        public Input<bool>? IsConnected { get; set; }

        /// <summary>
        /// The last MQTT activity of the device.
        /// </summary>
        [Input("lastActivityAt")]
        public Input<string>? LastActivityAt { get; set; }

        /// <summary>
        /// Rules that define which messages are authorized or denied based on their topic.
        /// </summary>
        [Input("messageFilters")]
        public Input<Inputs.IotDeviceMessageFiltersGetArgs>? MessageFilters { get; set; }

        /// <summary>
        /// The name of the IoT device you want to create (e.g. `my-device`).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The region you want to attach the resource to
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The current status of the device.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The date and time the device resource was updated.
        /// </summary>
        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        public IotDeviceState()
        {
        }
    }
}
