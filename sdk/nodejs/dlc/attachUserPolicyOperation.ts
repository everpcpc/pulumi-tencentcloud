// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

export class AttachUserPolicyOperation extends pulumi.CustomResource {
    /**
     * Get an existing AttachUserPolicyOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AttachUserPolicyOperationState, opts?: pulumi.CustomResourceOptions): AttachUserPolicyOperation {
        return new AttachUserPolicyOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dlc/attachUserPolicyOperation:AttachUserPolicyOperation';

    /**
     * Returns true if the given object is an instance of AttachUserPolicyOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AttachUserPolicyOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AttachUserPolicyOperation.__pulumiType;
    }

    /**
     * Authentication policy collection.
     */
    public readonly policySets!: pulumi.Output<outputs.Dlc.AttachUserPolicyOperationPolicySet[] | undefined>;
    /**
     * User id, the same as the sub-user uin.
     */
    public readonly userId!: pulumi.Output<string>;

    /**
     * Create a AttachUserPolicyOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AttachUserPolicyOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AttachUserPolicyOperationArgs | AttachUserPolicyOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AttachUserPolicyOperationState | undefined;
            resourceInputs["policySets"] = state ? state.policySets : undefined;
            resourceInputs["userId"] = state ? state.userId : undefined;
        } else {
            const args = argsOrState as AttachUserPolicyOperationArgs | undefined;
            if ((!args || args.userId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'userId'");
            }
            resourceInputs["policySets"] = args ? args.policySets : undefined;
            resourceInputs["userId"] = args ? args.userId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AttachUserPolicyOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AttachUserPolicyOperation resources.
 */
export interface AttachUserPolicyOperationState {
    /**
     * Authentication policy collection.
     */
    policySets?: pulumi.Input<pulumi.Input<inputs.Dlc.AttachUserPolicyOperationPolicySet>[]>;
    /**
     * User id, the same as the sub-user uin.
     */
    userId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AttachUserPolicyOperation resource.
 */
export interface AttachUserPolicyOperationArgs {
    /**
     * Authentication policy collection.
     */
    policySets?: pulumi.Input<pulumi.Input<inputs.Dlc.AttachUserPolicyOperationPolicySet>[]>;
    /**
     * User id, the same as the sub-user uin.
     */
    userId: pulumi.Input<string>;
}
