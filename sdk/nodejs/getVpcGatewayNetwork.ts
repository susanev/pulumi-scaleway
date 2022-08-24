// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Gets information about a gateway network.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as scaleway from "@pulumi/scaleway";
 * import * as scaleway from "@pulumiverse/scaleway";
 *
 * const main = new scaleway.VpcGatewayNetwork("main", {
 *     gatewayId: scaleway_vpc_public_gateway.pg01.id,
 *     privateNetworkId: scaleway_vpc_private_network.pn01.id,
 *     dhcpId: scaleway_vpc_public_gateway_dhcp.dhcp01.id,
 *     cleanupDhcp: true,
 *     enableMasquerade: true,
 * });
 * const byId = scaleway.getVpcGatewayNetworkOutput({
 *     gatewayNetworkId: main.id,
 * });
 * const byGatewayAndPn = scaleway.getVpcGatewayNetwork({
 *     gatewayId: scaleway_vpc_public_gateway.pg01.id,
 *     privateNetworkId: scaleway_vpc_private_network.pn01.id,
 * });
 * ```
 */
export function getVpcGatewayNetwork(args?: GetVpcGatewayNetworkArgs, opts?: pulumi.InvokeOptions): Promise<GetVpcGatewayNetworkResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("scaleway:index/getVpcGatewayNetwork:getVpcGatewayNetwork", {
        "dhcpId": args.dhcpId,
        "enableMasquerade": args.enableMasquerade,
        "gatewayId": args.gatewayId,
        "gatewayNetworkId": args.gatewayNetworkId,
        "privateNetworkId": args.privateNetworkId,
    }, opts);
}

/**
 * A collection of arguments for invoking getVpcGatewayNetwork.
 */
export interface GetVpcGatewayNetworkArgs {
    /**
     * ID of the public gateway DHCP config
     */
    dhcpId?: string;
    /**
     * If masquerade is enabled on requested network
     */
    enableMasquerade?: boolean;
    /**
     * ID of the public gateway the gateway network is linked to
     */
    gatewayId?: string;
    /**
     * ID of the gateway network.
     */
    gatewayNetworkId?: string;
    /**
     * ID of the private network the gateway network is linked to
     */
    privateNetworkId?: string;
}

/**
 * A collection of values returned by getVpcGatewayNetwork.
 */
export interface GetVpcGatewayNetworkResult {
    readonly cleanupDhcp: boolean;
    readonly createdAt: string;
    readonly dhcpId?: string;
    readonly enableDhcp: boolean;
    readonly enableMasquerade?: boolean;
    readonly gatewayId?: string;
    readonly gatewayNetworkId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly macAddress: string;
    readonly privateNetworkId?: string;
    readonly staticAddress: string;
    readonly updatedAt: string;
    readonly zone: string;
}

export function getVpcGatewayNetworkOutput(args?: GetVpcGatewayNetworkOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVpcGatewayNetworkResult> {
    return pulumi.output(args).apply(a => getVpcGatewayNetwork(a, opts))
}

/**
 * A collection of arguments for invoking getVpcGatewayNetwork.
 */
export interface GetVpcGatewayNetworkOutputArgs {
    /**
     * ID of the public gateway DHCP config
     */
    dhcpId?: pulumi.Input<string>;
    /**
     * If masquerade is enabled on requested network
     */
    enableMasquerade?: pulumi.Input<boolean>;
    /**
     * ID of the public gateway the gateway network is linked to
     */
    gatewayId?: pulumi.Input<string>;
    /**
     * ID of the gateway network.
     */
    gatewayNetworkId?: pulumi.Input<string>;
    /**
     * ID of the private network the gateway network is linked to
     */
    privateNetworkId?: pulumi.Input<string>;
}