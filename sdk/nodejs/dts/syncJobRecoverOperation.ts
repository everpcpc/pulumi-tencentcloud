// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a dts syncJobRecoverOperation
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const syncJobRecoverOperation = new tencentcloud.dts.SyncJobRecoverOperation("syncJobRecoverOperation", {jobId: "sync-werwfs23"});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class SyncJobRecoverOperation extends pulumi.CustomResource {
    /**
     * Get an existing SyncJobRecoverOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SyncJobRecoverOperationState, opts?: pulumi.CustomResourceOptions): SyncJobRecoverOperation {
        return new SyncJobRecoverOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dts/syncJobRecoverOperation:SyncJobRecoverOperation';

    /**
     * Returns true if the given object is an instance of SyncJobRecoverOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SyncJobRecoverOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SyncJobRecoverOperation.__pulumiType;
    }

    /**
     * Synchronization instance id (i.e. identifies a synchronization job).
     */
    public readonly jobId!: pulumi.Output<string>;

    /**
     * Create a SyncJobRecoverOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SyncJobRecoverOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SyncJobRecoverOperationArgs | SyncJobRecoverOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SyncJobRecoverOperationState | undefined;
            resourceInputs["jobId"] = state ? state.jobId : undefined;
        } else {
            const args = argsOrState as SyncJobRecoverOperationArgs | undefined;
            if ((!args || args.jobId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'jobId'");
            }
            resourceInputs["jobId"] = args ? args.jobId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SyncJobRecoverOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SyncJobRecoverOperation resources.
 */
export interface SyncJobRecoverOperationState {
    /**
     * Synchronization instance id (i.e. identifies a synchronization job).
     */
    jobId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SyncJobRecoverOperation resource.
 */
export interface SyncJobRecoverOperationArgs {
    /**
     * Synchronization instance id (i.e. identifies a synchronization job).
     */
    jobId: pulumi.Input<string>;
}