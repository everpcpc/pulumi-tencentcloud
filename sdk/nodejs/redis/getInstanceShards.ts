// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of redis instanceShards
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const instanceShards = pulumi.output(tencentcloud.Redis.getInstanceShards({
 *     filterSlave: false,
 *     instanceId: "crs-c1nl9rpv",
 * }));
 * ```
 */
export function getInstanceShards(args: GetInstanceShardsArgs, opts?: pulumi.InvokeOptions): Promise<GetInstanceShardsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Redis/getInstanceShards:getInstanceShards", {
        "filterSlave": args.filterSlave,
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getInstanceShards.
 */
export interface GetInstanceShardsArgs {
    /**
     * Whether to filter out slave information.
     */
    filterSlave?: boolean;
    /**
     * The ID of instance.
     */
    instanceId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getInstanceShards.
 */
export interface GetInstanceShardsResult {
    readonly filterSlave?: boolean;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    /**
     * Instance shard list information.
     */
    readonly instanceShards: outputs.Redis.GetInstanceShardsInstanceShard[];
    readonly resultOutputFile?: string;
}

export function getInstanceShardsOutput(args: GetInstanceShardsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInstanceShardsResult> {
    return pulumi.output(args).apply(a => getInstanceShards(a, opts))
}

/**
 * A collection of arguments for invoking getInstanceShards.
 */
export interface GetInstanceShardsOutputArgs {
    /**
     * Whether to filter out slave information.
     */
    filterSlave?: pulumi.Input<boolean>;
    /**
     * The ID of instance.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}