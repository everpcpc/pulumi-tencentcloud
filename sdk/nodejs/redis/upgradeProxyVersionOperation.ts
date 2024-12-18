// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a redis upgradeProxyVersionOperation
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const upgradeProxyVersionOperation = new tencentcloud.redis.UpgradeProxyVersionOperation("upgradeProxyVersionOperation", {
 *     currentProxyVersion: "5.0.0",
 *     instanceId: "crs-c1nl9rpv",
 *     instanceTypeUpgradeNow: 1,
 *     upgradeProxyVersion: "5.0.0",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class UpgradeProxyVersionOperation extends pulumi.CustomResource {
    /**
     * Get an existing UpgradeProxyVersionOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UpgradeProxyVersionOperationState, opts?: pulumi.CustomResourceOptions): UpgradeProxyVersionOperation {
        return new UpgradeProxyVersionOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Redis/upgradeProxyVersionOperation:UpgradeProxyVersionOperation';

    /**
     * Returns true if the given object is an instance of UpgradeProxyVersionOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is UpgradeProxyVersionOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === UpgradeProxyVersionOperation.__pulumiType;
    }

    /**
     * Current proxy version.
     */
    public readonly currentProxyVersion!: pulumi.Output<string>;
    /**
     * The ID of instance.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Switch mode:1 - Upgrade now0 - Maintenance window upgrade.
     */
    public readonly instanceTypeUpgradeNow!: pulumi.Output<number>;
    /**
     * Upgradeable redis proxy version.
     */
    public readonly upgradeProxyVersion!: pulumi.Output<string>;

    /**
     * Create a UpgradeProxyVersionOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UpgradeProxyVersionOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UpgradeProxyVersionOperationArgs | UpgradeProxyVersionOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as UpgradeProxyVersionOperationState | undefined;
            resourceInputs["currentProxyVersion"] = state ? state.currentProxyVersion : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["instanceTypeUpgradeNow"] = state ? state.instanceTypeUpgradeNow : undefined;
            resourceInputs["upgradeProxyVersion"] = state ? state.upgradeProxyVersion : undefined;
        } else {
            const args = argsOrState as UpgradeProxyVersionOperationArgs | undefined;
            if ((!args || args.currentProxyVersion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'currentProxyVersion'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.instanceTypeUpgradeNow === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceTypeUpgradeNow'");
            }
            if ((!args || args.upgradeProxyVersion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'upgradeProxyVersion'");
            }
            resourceInputs["currentProxyVersion"] = args ? args.currentProxyVersion : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["instanceTypeUpgradeNow"] = args ? args.instanceTypeUpgradeNow : undefined;
            resourceInputs["upgradeProxyVersion"] = args ? args.upgradeProxyVersion : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(UpgradeProxyVersionOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering UpgradeProxyVersionOperation resources.
 */
export interface UpgradeProxyVersionOperationState {
    /**
     * Current proxy version.
     */
    currentProxyVersion?: pulumi.Input<string>;
    /**
     * The ID of instance.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Switch mode:1 - Upgrade now0 - Maintenance window upgrade.
     */
    instanceTypeUpgradeNow?: pulumi.Input<number>;
    /**
     * Upgradeable redis proxy version.
     */
    upgradeProxyVersion?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a UpgradeProxyVersionOperation resource.
 */
export interface UpgradeProxyVersionOperationArgs {
    /**
     * Current proxy version.
     */
    currentProxyVersion: pulumi.Input<string>;
    /**
     * The ID of instance.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Switch mode:1 - Upgrade now0 - Maintenance window upgrade.
     */
    instanceTypeUpgradeNow: pulumi.Input<number>;
    /**
     * Upgradeable redis proxy version.
     */
    upgradeProxyVersion: pulumi.Input<string>;
}
