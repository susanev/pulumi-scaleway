// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Gets information about Scaleway Secrets.
 * For more information, see [the documentation](https://developers.scaleway.com/en/products/secret_manager/api/v1alpha1/).
 *
 * ## Examples
 *
 * ### Basic
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as scaleway from "@lbrlabs/pulumi-scaleway";
 * import * as scaleway from "@pulumi/scaleway";
 *
 * const main = new scaleway.Secret("main", {description: "barr"});
 * const mySecret = scaleway.getSecret({
 *     secretId: "11111111-1111-1111-1111-111111111111",
 * });
 * const byName = scaleway.getSecret({
 *     name: "your_secret_name",
 * });
 * ```
 */
export function getSecret(args?: GetSecretArgs, opts?: pulumi.InvokeOptions): Promise<GetSecretResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("scaleway:index/getSecret:getSecret", {
        "name": args.name,
        "organizationId": args.organizationId,
        "projectId": args.projectId,
        "region": args.region,
        "secretId": args.secretId,
    }, opts);
}

/**
 * A collection of arguments for invoking getSecret.
 */
export interface GetSecretArgs {
    /**
     * The secret name.
     * Only one of `name` and `secretId` should be specified.
     */
    name?: string;
    /**
     * The organization ID the Project is associated with.
     * If no default organizationId is set, one must be set explicitly in this datasource
     */
    organizationId?: string;
    /**
     * `projectId`) The ID of the
     * project the secret is associated with.
     */
    projectId?: string;
    /**
     * `region`) The region in which the secret exists.
     */
    region?: string;
    /**
     * The secret id.
     * Only one of `name` and `secretId` should be specified.
     */
    secretId?: string;
}

/**
 * A collection of values returned by getSecret.
 */
export interface GetSecretResult {
    readonly createdAt: string;
    readonly description: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name?: string;
    readonly organizationId: string;
    readonly projectId?: string;
    readonly region?: string;
    readonly secretId?: string;
    readonly status: string;
    readonly tags: string[];
    readonly updatedAt: string;
    readonly versionCount: number;
}
/**
 * Gets information about Scaleway Secrets.
 * For more information, see [the documentation](https://developers.scaleway.com/en/products/secret_manager/api/v1alpha1/).
 *
 * ## Examples
 *
 * ### Basic
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as scaleway from "@lbrlabs/pulumi-scaleway";
 * import * as scaleway from "@pulumi/scaleway";
 *
 * const main = new scaleway.Secret("main", {description: "barr"});
 * const mySecret = scaleway.getSecret({
 *     secretId: "11111111-1111-1111-1111-111111111111",
 * });
 * const byName = scaleway.getSecret({
 *     name: "your_secret_name",
 * });
 * ```
 */
export function getSecretOutput(args?: GetSecretOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSecretResult> {
    return pulumi.output(args).apply((a: any) => getSecret(a, opts))
}

/**
 * A collection of arguments for invoking getSecret.
 */
export interface GetSecretOutputArgs {
    /**
     * The secret name.
     * Only one of `name` and `secretId` should be specified.
     */
    name?: pulumi.Input<string>;
    /**
     * The organization ID the Project is associated with.
     * If no default organizationId is set, one must be set explicitly in this datasource
     */
    organizationId?: pulumi.Input<string>;
    /**
     * `projectId`) The ID of the
     * project the secret is associated with.
     */
    projectId?: pulumi.Input<string>;
    /**
     * `region`) The region in which the secret exists.
     */
    region?: pulumi.Input<string>;
    /**
     * The secret id.
     * Only one of `name` and `secretId` should be specified.
     */
    secretId?: pulumi.Input<string>;
}
