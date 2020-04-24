// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to get SSH key information based on its ID or name.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as scaleway from "@pulumi/scaleway";
 * 
 * // Get info by SSH key id
 * const myKey = scaleway.getAccountSshKey({
 *     sshKeyId: "11111111-1111-1111-1111-111111111111",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-scaleway/blob/master/website/docs/d/account_ssh_key.html.markdown.
 */
export function getAccountSshKey(args?: GetAccountSshKeyArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountSshKeyResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("scaleway:index/getAccountSshKey:getAccountSshKey", {
        "name": args.name,
        "organizationId": args.organizationId,
        "sshKeyId": args.sshKeyId,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccountSshKey.
 */
export interface GetAccountSshKeyArgs {
    readonly name?: string;
    readonly organizationId?: string;
    readonly sshKeyId?: string;
}

/**
 * A collection of values returned by getAccountSshKey.
 */
export interface GetAccountSshKeyResult {
    readonly name: string;
    readonly organizationId: string;
    readonly publicKey: string;
    readonly sshKeyId: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}