// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * **DEPRECATED**: This resource is deprecated and will be removed in `v2.0+`.
 * Please use `scaleway..InstanceServer` instead.
 * 
 * Provides user data for servers.
 * For additional details please refer to [API documentation](https://developer.scaleway.com/#user-data).
 * 
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-scaleway/blob/master/website/docs/r/user_data.html.markdown.
 */
export class UserData extends pulumi.CustomResource {
    /**
     * Get an existing UserData resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UserDataState, opts?: pulumi.CustomResourceOptions): UserData {
        return new UserData(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'scaleway:index/userData:UserData';

    /**
     * Returns true if the given object is an instance of UserData.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is UserData {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === UserData.__pulumiType;
    }

    /**
     * The key of the user data object
     */
    public readonly key!: pulumi.Output<string>;
    /**
     * ID of server to associate the user data with
     */
    public readonly server!: pulumi.Output<string>;
    /**
     * The value of the user data object
     */
    public readonly value!: pulumi.Output<string>;

    /**
     * Create a UserData resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UserDataArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UserDataArgs | UserDataState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as UserDataState | undefined;
            inputs["key"] = state ? state.key : undefined;
            inputs["server"] = state ? state.server : undefined;
            inputs["value"] = state ? state.value : undefined;
        } else {
            const args = argsOrState as UserDataArgs | undefined;
            if (!args || args.key === undefined) {
                throw new Error("Missing required property 'key'");
            }
            if (!args || args.server === undefined) {
                throw new Error("Missing required property 'server'");
            }
            if (!args || args.value === undefined) {
                throw new Error("Missing required property 'value'");
            }
            inputs["key"] = args ? args.key : undefined;
            inputs["server"] = args ? args.server : undefined;
            inputs["value"] = args ? args.value : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(UserData.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering UserData resources.
 */
export interface UserDataState {
    /**
     * The key of the user data object
     */
    readonly key?: pulumi.Input<string>;
    /**
     * ID of server to associate the user data with
     */
    readonly server?: pulumi.Input<string>;
    /**
     * The value of the user data object
     */
    readonly value?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a UserData resource.
 */
export interface UserDataArgs {
    /**
     * The key of the user data object
     */
    readonly key: pulumi.Input<string>;
    /**
     * ID of server to associate the user data with
     */
    readonly server: pulumi.Input<string>;
    /**
     * The value of the user data object
     */
    readonly value: pulumi.Input<string>;
}