// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of as lastActivity
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const lastActivity = pulumi.output(tencentcloud.As.getLastActivity({
 *     autoScalingGroupIds: ["asc-lo0b94oy"],
 * }));
 * ```
 */
export function getLastActivity(args: GetLastActivityArgs, opts?: pulumi.InvokeOptions): Promise<GetLastActivityResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:As/getLastActivity:getLastActivity", {
        "autoScalingGroupIds": args.autoScalingGroupIds,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getLastActivity.
 */
export interface GetLastActivityArgs {
    /**
     * ID list of an auto scaling group.
     */
    autoScalingGroupIds: string[];
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getLastActivity.
 */
export interface GetLastActivityResult {
    /**
     * Information set of eligible scaling activities. Scaling groups without scaling activities are not returned. For example, if there are 50 auto scaling group IDs but only 45 records are returned, it indicates that 5 of the auto scaling groups do not have scaling activities.
     */
    readonly activitySets: outputs.As.GetLastActivityActivitySet[];
    readonly autoScalingGroupIds: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}

export function getLastActivityOutput(args: GetLastActivityOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLastActivityResult> {
    return pulumi.output(args).apply(a => getLastActivity(a, opts))
}

/**
 * A collection of arguments for invoking getLastActivity.
 */
export interface GetLastActivityOutputArgs {
    /**
     * ID list of an auto scaling group.
     */
    autoScalingGroupIds: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
