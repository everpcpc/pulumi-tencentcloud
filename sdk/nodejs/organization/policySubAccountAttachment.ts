// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a organization policySubAccountAttachment
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const policySubAccountAttachment = new tencentcloud.organization.PolicySubAccountAttachment("policySubAccountAttachment", {
 *     memberUin: 100028582828,
 *     orgSubAccountUin: 100028223737,
 *     policyId: 144256499,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * organization policy_sub_account_attachment can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Organization/policySubAccountAttachment:PolicySubAccountAttachment policy_sub_account_attachment policyId#memberUin#orgSubAccountUin
 * ```
 */
export class PolicySubAccountAttachment extends pulumi.CustomResource {
    /**
     * Get an existing PolicySubAccountAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: PolicySubAccountAttachmentState, opts?: pulumi.CustomResourceOptions): PolicySubAccountAttachment {
        return new PolicySubAccountAttachment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Organization/policySubAccountAttachment:PolicySubAccountAttachment';

    /**
     * Returns true if the given object is an instance of PolicySubAccountAttachment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PolicySubAccountAttachment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PolicySubAccountAttachment.__pulumiType;
    }

    /**
     * Creation time.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Manage Identity ID.
     */
    public /*out*/ readonly identityId!: pulumi.Output<number>;
    /**
     * Identity role alias name.
     */
    public /*out*/ readonly identityRoleAliasName!: pulumi.Output<string>;
    /**
     * Identity role name.
     */
    public /*out*/ readonly identityRoleName!: pulumi.Output<string>;
    /**
     * Organization member uin.
     */
    public readonly memberUin!: pulumi.Output<number>;
    /**
     * Organization administrator sub account name.
     */
    public /*out*/ readonly orgSubAccountName!: pulumi.Output<string>;
    /**
     * Organization administrator sub account uin list.
     */
    public readonly orgSubAccountUin!: pulumi.Output<number>;
    /**
     * Policy ID.
     */
    public readonly policyId!: pulumi.Output<number>;
    /**
     * Policy name.
     */
    public /*out*/ readonly policyName!: pulumi.Output<string>;
    /**
     * Update time.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;

    /**
     * Create a PolicySubAccountAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PolicySubAccountAttachmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: PolicySubAccountAttachmentArgs | PolicySubAccountAttachmentState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as PolicySubAccountAttachmentState | undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["identityId"] = state ? state.identityId : undefined;
            resourceInputs["identityRoleAliasName"] = state ? state.identityRoleAliasName : undefined;
            resourceInputs["identityRoleName"] = state ? state.identityRoleName : undefined;
            resourceInputs["memberUin"] = state ? state.memberUin : undefined;
            resourceInputs["orgSubAccountName"] = state ? state.orgSubAccountName : undefined;
            resourceInputs["orgSubAccountUin"] = state ? state.orgSubAccountUin : undefined;
            resourceInputs["policyId"] = state ? state.policyId : undefined;
            resourceInputs["policyName"] = state ? state.policyName : undefined;
            resourceInputs["updateTime"] = state ? state.updateTime : undefined;
        } else {
            const args = argsOrState as PolicySubAccountAttachmentArgs | undefined;
            if ((!args || args.memberUin === undefined) && !opts.urn) {
                throw new Error("Missing required property 'memberUin'");
            }
            if ((!args || args.orgSubAccountUin === undefined) && !opts.urn) {
                throw new Error("Missing required property 'orgSubAccountUin'");
            }
            if ((!args || args.policyId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policyId'");
            }
            resourceInputs["memberUin"] = args ? args.memberUin : undefined;
            resourceInputs["orgSubAccountUin"] = args ? args.orgSubAccountUin : undefined;
            resourceInputs["policyId"] = args ? args.policyId : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["identityId"] = undefined /*out*/;
            resourceInputs["identityRoleAliasName"] = undefined /*out*/;
            resourceInputs["identityRoleName"] = undefined /*out*/;
            resourceInputs["orgSubAccountName"] = undefined /*out*/;
            resourceInputs["policyName"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(PolicySubAccountAttachment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering PolicySubAccountAttachment resources.
 */
export interface PolicySubAccountAttachmentState {
    /**
     * Creation time.
     */
    createTime?: pulumi.Input<string>;
    /**
     * Manage Identity ID.
     */
    identityId?: pulumi.Input<number>;
    /**
     * Identity role alias name.
     */
    identityRoleAliasName?: pulumi.Input<string>;
    /**
     * Identity role name.
     */
    identityRoleName?: pulumi.Input<string>;
    /**
     * Organization member uin.
     */
    memberUin?: pulumi.Input<number>;
    /**
     * Organization administrator sub account name.
     */
    orgSubAccountName?: pulumi.Input<string>;
    /**
     * Organization administrator sub account uin list.
     */
    orgSubAccountUin?: pulumi.Input<number>;
    /**
     * Policy ID.
     */
    policyId?: pulumi.Input<number>;
    /**
     * Policy name.
     */
    policyName?: pulumi.Input<string>;
    /**
     * Update time.
     */
    updateTime?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a PolicySubAccountAttachment resource.
 */
export interface PolicySubAccountAttachmentArgs {
    /**
     * Organization member uin.
     */
    memberUin: pulumi.Input<number>;
    /**
     * Organization administrator sub account uin list.
     */
    orgSubAccountUin: pulumi.Input<number>;
    /**
     * Policy ID.
     */
    policyId: pulumi.Input<number>;
}
