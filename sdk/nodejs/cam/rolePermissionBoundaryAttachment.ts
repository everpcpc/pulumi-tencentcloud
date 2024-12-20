// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a cam rolePermissionBoundaryAttachment
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const rolePermissionBoundaryAttachment = new tencentcloud.cam.RolePermissionBoundaryAttachment("rolePermissionBoundaryAttachment", {
 *     policyId: 1,
 *     roleName: "test-cam-tag",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * cam role_permission_boundary_attachment can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Cam/rolePermissionBoundaryAttachment:RolePermissionBoundaryAttachment role_permission_boundary_attachment role_permission_boundary_attachment_id
 * ```
 */
export class RolePermissionBoundaryAttachment extends pulumi.CustomResource {
    /**
     * Get an existing RolePermissionBoundaryAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RolePermissionBoundaryAttachmentState, opts?: pulumi.CustomResourceOptions): RolePermissionBoundaryAttachment {
        return new RolePermissionBoundaryAttachment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Cam/rolePermissionBoundaryAttachment:RolePermissionBoundaryAttachment';

    /**
     * Returns true if the given object is an instance of RolePermissionBoundaryAttachment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RolePermissionBoundaryAttachment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RolePermissionBoundaryAttachment.__pulumiType;
    }

    /**
     * Role ID.
     */
    public readonly policyId!: pulumi.Output<number>;
    /**
     * Role ID (at least one should be filled in with the role name).
     */
    public readonly roleId!: pulumi.Output<string>;
    /**
     * Role name (at least one should be filled in with the role ID).
     */
    public readonly roleName!: pulumi.Output<string | undefined>;

    /**
     * Create a RolePermissionBoundaryAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RolePermissionBoundaryAttachmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RolePermissionBoundaryAttachmentArgs | RolePermissionBoundaryAttachmentState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RolePermissionBoundaryAttachmentState | undefined;
            resourceInputs["policyId"] = state ? state.policyId : undefined;
            resourceInputs["roleId"] = state ? state.roleId : undefined;
            resourceInputs["roleName"] = state ? state.roleName : undefined;
        } else {
            const args = argsOrState as RolePermissionBoundaryAttachmentArgs | undefined;
            if ((!args || args.policyId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policyId'");
            }
            resourceInputs["policyId"] = args ? args.policyId : undefined;
            resourceInputs["roleId"] = args ? args.roleId : undefined;
            resourceInputs["roleName"] = args ? args.roleName : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(RolePermissionBoundaryAttachment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RolePermissionBoundaryAttachment resources.
 */
export interface RolePermissionBoundaryAttachmentState {
    /**
     * Role ID.
     */
    policyId?: pulumi.Input<number>;
    /**
     * Role ID (at least one should be filled in with the role name).
     */
    roleId?: pulumi.Input<string>;
    /**
     * Role name (at least one should be filled in with the role ID).
     */
    roleName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RolePermissionBoundaryAttachment resource.
 */
export interface RolePermissionBoundaryAttachmentArgs {
    /**
     * Role ID.
     */
    policyId: pulumi.Input<number>;
    /**
     * Role ID (at least one should be filled in with the role name).
     */
    roleId?: pulumi.Input<string>;
    /**
     * Role name (at least one should be filled in with the role ID).
     */
    roleName?: pulumi.Input<string>;
}
