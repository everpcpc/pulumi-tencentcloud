// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to set postgresql instance syncMode
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.postgresql.InstanceHaConfig("example", {
 *     instanceId: "postgres-gzg9jb2n",
 *     maxStandbyLag: 10,
 *     maxStandbyLatency: 10737418240,
 *     maxSyncStandbyLag: 5,
 *     maxSyncStandbyLatency: 52428800,
 *     syncMode: "Semi-sync",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.postgresql.InstanceHaConfig("example", {
 *     instanceId: "postgres-gzg9jb2n",
 *     maxStandbyLag: 10,
 *     maxStandbyLatency: 10737418240,
 *     syncMode: "Async",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class InstanceHaConfig extends pulumi.CustomResource {
    /**
     * Get an existing InstanceHaConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: InstanceHaConfigState, opts?: pulumi.CustomResourceOptions): InstanceHaConfig {
        return new InstanceHaConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Postgresql/instanceHaConfig:InstanceHaConfig';

    /**
     * Returns true if the given object is an instance of InstanceHaConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is InstanceHaConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === InstanceHaConfig.__pulumiType;
    }

    /**
     * instance id.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Maximum latency of highly available backup machines. When the delay time of the backup node is less than or equal to this value, and the amount of delay data of the backup node is less than or equal to MaxStandbyLatency, the primary node can be switched. Unit: s; Parameter range: [5, 10].
     */
    public readonly maxStandbyLag!: pulumi.Output<number>;
    /**
     * Maximum latency data volume for highly available backup machines. When the delay data amount of the backup node is less than or equal to this value, and the delay time of the backup node is less than or equal to MaxStandbyLag, it can switch to the main node. Unit: byte; Parameter range: [1073741824, 322122547200].
     */
    public readonly maxStandbyLatency!: pulumi.Output<number>;
    /**
     * Maximum delay time for synchronous backup. When the delay time of the standby machine is less than or equal to this value, and the amount of delay data of the standby machine is less than or equal to MaxSyncStandbyLatency, then the standby machine adopts synchronous replication; Otherwise, adopt asynchronous replication. This parameter value is valid for instances where SyncMode is set to Semi sync. When a semi synchronous instance prohibits degradation to asynchronous replication, MaxSyncStandbyLatency and MaxSyncStandbyLag are not set. When semi synchronous instances allow degenerate asynchronous replication, PostgreSQL version 9 instances must have MaxSyncStandbyLatency set and MaxSyncStandbyLag not set, while PostgreSQL version 10 and above instances must have MaxSyncStandbyLatency and MaxSyncStandbyLag set.
     */
    public readonly maxSyncStandbyLag!: pulumi.Output<number | undefined>;
    /**
     * Maximum latency data for synchronous backup. When the amount of data delayed by the backup machine is less than or equal to this value, and the delay time of the backup machine is less than or equal to MaxSyncStandbyLag, then the backup machine adopts synchronous replication; Otherwise, adopt asynchronous replication. This parameter value is valid for instances where SyncMode is set to Semi sync. When a semi synchronous instance prohibits degradation to asynchronous replication, MaxSyncStandbyLatency and MaxSyncStandbyLag are not set. When semi synchronous instances allow degenerate asynchronous replication, PostgreSQL version 9 instances must have MaxSyncStandbyLatency set and MaxSyncStandbyLag not set, while PostgreSQL version 10 and above instances must have MaxSyncStandbyLatency and MaxSyncStandbyLag set.
     */
    public readonly maxSyncStandbyLatency!: pulumi.Output<number | undefined>;
    /**
     * Master slave synchronization method, Semi-sync: Semi synchronous; Async: Asynchronous. Main instance default value: Semi-sync, Read-only instance default value: Async.
     */
    public readonly syncMode!: pulumi.Output<string>;

    /**
     * Create a InstanceHaConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InstanceHaConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: InstanceHaConfigArgs | InstanceHaConfigState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as InstanceHaConfigState | undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["maxStandbyLag"] = state ? state.maxStandbyLag : undefined;
            resourceInputs["maxStandbyLatency"] = state ? state.maxStandbyLatency : undefined;
            resourceInputs["maxSyncStandbyLag"] = state ? state.maxSyncStandbyLag : undefined;
            resourceInputs["maxSyncStandbyLatency"] = state ? state.maxSyncStandbyLatency : undefined;
            resourceInputs["syncMode"] = state ? state.syncMode : undefined;
        } else {
            const args = argsOrState as InstanceHaConfigArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.maxStandbyLag === undefined) && !opts.urn) {
                throw new Error("Missing required property 'maxStandbyLag'");
            }
            if ((!args || args.maxStandbyLatency === undefined) && !opts.urn) {
                throw new Error("Missing required property 'maxStandbyLatency'");
            }
            if ((!args || args.syncMode === undefined) && !opts.urn) {
                throw new Error("Missing required property 'syncMode'");
            }
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["maxStandbyLag"] = args ? args.maxStandbyLag : undefined;
            resourceInputs["maxStandbyLatency"] = args ? args.maxStandbyLatency : undefined;
            resourceInputs["maxSyncStandbyLag"] = args ? args.maxSyncStandbyLag : undefined;
            resourceInputs["maxSyncStandbyLatency"] = args ? args.maxSyncStandbyLatency : undefined;
            resourceInputs["syncMode"] = args ? args.syncMode : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(InstanceHaConfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering InstanceHaConfig resources.
 */
export interface InstanceHaConfigState {
    /**
     * instance id.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Maximum latency of highly available backup machines. When the delay time of the backup node is less than or equal to this value, and the amount of delay data of the backup node is less than or equal to MaxStandbyLatency, the primary node can be switched. Unit: s; Parameter range: [5, 10].
     */
    maxStandbyLag?: pulumi.Input<number>;
    /**
     * Maximum latency data volume for highly available backup machines. When the delay data amount of the backup node is less than or equal to this value, and the delay time of the backup node is less than or equal to MaxStandbyLag, it can switch to the main node. Unit: byte; Parameter range: [1073741824, 322122547200].
     */
    maxStandbyLatency?: pulumi.Input<number>;
    /**
     * Maximum delay time for synchronous backup. When the delay time of the standby machine is less than or equal to this value, and the amount of delay data of the standby machine is less than or equal to MaxSyncStandbyLatency, then the standby machine adopts synchronous replication; Otherwise, adopt asynchronous replication. This parameter value is valid for instances where SyncMode is set to Semi sync. When a semi synchronous instance prohibits degradation to asynchronous replication, MaxSyncStandbyLatency and MaxSyncStandbyLag are not set. When semi synchronous instances allow degenerate asynchronous replication, PostgreSQL version 9 instances must have MaxSyncStandbyLatency set and MaxSyncStandbyLag not set, while PostgreSQL version 10 and above instances must have MaxSyncStandbyLatency and MaxSyncStandbyLag set.
     */
    maxSyncStandbyLag?: pulumi.Input<number>;
    /**
     * Maximum latency data for synchronous backup. When the amount of data delayed by the backup machine is less than or equal to this value, and the delay time of the backup machine is less than or equal to MaxSyncStandbyLag, then the backup machine adopts synchronous replication; Otherwise, adopt asynchronous replication. This parameter value is valid for instances where SyncMode is set to Semi sync. When a semi synchronous instance prohibits degradation to asynchronous replication, MaxSyncStandbyLatency and MaxSyncStandbyLag are not set. When semi synchronous instances allow degenerate asynchronous replication, PostgreSQL version 9 instances must have MaxSyncStandbyLatency set and MaxSyncStandbyLag not set, while PostgreSQL version 10 and above instances must have MaxSyncStandbyLatency and MaxSyncStandbyLag set.
     */
    maxSyncStandbyLatency?: pulumi.Input<number>;
    /**
     * Master slave synchronization method, Semi-sync: Semi synchronous; Async: Asynchronous. Main instance default value: Semi-sync, Read-only instance default value: Async.
     */
    syncMode?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a InstanceHaConfig resource.
 */
export interface InstanceHaConfigArgs {
    /**
     * instance id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Maximum latency of highly available backup machines. When the delay time of the backup node is less than or equal to this value, and the amount of delay data of the backup node is less than or equal to MaxStandbyLatency, the primary node can be switched. Unit: s; Parameter range: [5, 10].
     */
    maxStandbyLag: pulumi.Input<number>;
    /**
     * Maximum latency data volume for highly available backup machines. When the delay data amount of the backup node is less than or equal to this value, and the delay time of the backup node is less than or equal to MaxStandbyLag, it can switch to the main node. Unit: byte; Parameter range: [1073741824, 322122547200].
     */
    maxStandbyLatency: pulumi.Input<number>;
    /**
     * Maximum delay time for synchronous backup. When the delay time of the standby machine is less than or equal to this value, and the amount of delay data of the standby machine is less than or equal to MaxSyncStandbyLatency, then the standby machine adopts synchronous replication; Otherwise, adopt asynchronous replication. This parameter value is valid for instances where SyncMode is set to Semi sync. When a semi synchronous instance prohibits degradation to asynchronous replication, MaxSyncStandbyLatency and MaxSyncStandbyLag are not set. When semi synchronous instances allow degenerate asynchronous replication, PostgreSQL version 9 instances must have MaxSyncStandbyLatency set and MaxSyncStandbyLag not set, while PostgreSQL version 10 and above instances must have MaxSyncStandbyLatency and MaxSyncStandbyLag set.
     */
    maxSyncStandbyLag?: pulumi.Input<number>;
    /**
     * Maximum latency data for synchronous backup. When the amount of data delayed by the backup machine is less than or equal to this value, and the delay time of the backup machine is less than or equal to MaxSyncStandbyLag, then the backup machine adopts synchronous replication; Otherwise, adopt asynchronous replication. This parameter value is valid for instances where SyncMode is set to Semi sync. When a semi synchronous instance prohibits degradation to asynchronous replication, MaxSyncStandbyLatency and MaxSyncStandbyLag are not set. When semi synchronous instances allow degenerate asynchronous replication, PostgreSQL version 9 instances must have MaxSyncStandbyLatency set and MaxSyncStandbyLag not set, while PostgreSQL version 10 and above instances must have MaxSyncStandbyLatency and MaxSyncStandbyLag set.
     */
    maxSyncStandbyLatency?: pulumi.Input<number>;
    /**
     * Master slave synchronization method, Semi-sync: Semi synchronous; Async: Asynchronous. Main instance default value: Semi-sync, Read-only instance default value: Async.
     */
    syncMode: pulumi.Input<string>;
}