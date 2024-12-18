// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provide a resource to create a TDMQ role.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const exampleInstance = new tencentcloud.tdmq.Instance("exampleInstance", {
 *     clusterName: "tf_example",
 *     remark: "remark.",
 *     tags: {
 *         createdBy: "terraform",
 *     },
 * });
 * const exampleRole = new tencentcloud.tdmq.Role("exampleRole", {
 *     roleName: "role_example",
 *     clusterId: exampleInstance.id,
 *     remark: "remark.",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class Role extends pulumi.CustomResource {
    /**
     * Get an existing Role resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RoleState, opts?: pulumi.CustomResourceOptions): Role {
        return new Role(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Tdmq/role:Role';

    /**
     * Returns true if the given object is an instance of Role.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Role {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Role.__pulumiType;
    }

    /**
     * The id of tdmq cluster.
     */
    public readonly clusterId!: pulumi.Output<string>;
    /**
     * The description of tdmq role.
     */
    public readonly remark!: pulumi.Output<string>;
    /**
     * The name of tdmq role.
     */
    public readonly roleName!: pulumi.Output<string>;

    /**
     * Create a Role resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RoleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RoleArgs | RoleState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RoleState | undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["remark"] = state ? state.remark : undefined;
            resourceInputs["roleName"] = state ? state.roleName : undefined;
        } else {
            const args = argsOrState as RoleArgs | undefined;
            if ((!args || args.clusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterId'");
            }
            if ((!args || args.remark === undefined) && !opts.urn) {
                throw new Error("Missing required property 'remark'");
            }
            if ((!args || args.roleName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'roleName'");
            }
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["remark"] = args ? args.remark : undefined;
            resourceInputs["roleName"] = args ? args.roleName : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Role.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Role resources.
 */
export interface RoleState {
    /**
     * The id of tdmq cluster.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * The description of tdmq role.
     */
    remark?: pulumi.Input<string>;
    /**
     * The name of tdmq role.
     */
    roleName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Role resource.
 */
export interface RoleArgs {
    /**
     * The id of tdmq cluster.
     */
    clusterId: pulumi.Input<string>;
    /**
     * The description of tdmq role.
     */
    remark: pulumi.Input<string>;
    /**
     * The name of tdmq role.
     */
    roleName: pulumi.Input<string>;
}
