// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of monitor alarmNoticeCallbacks
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const alarmNoticeCallbacks = tencentcloud.Monitor.getAlarmNoticeCallbacks({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAlarmNoticeCallbacks(args?: GetAlarmNoticeCallbacksArgs, opts?: pulumi.InvokeOptions): Promise<GetAlarmNoticeCallbacksResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Monitor/getAlarmNoticeCallbacks:getAlarmNoticeCallbacks", {
        "resultOutputFile": args.resultOutputFile,
        "tags": args.tags,
    }, opts);
}

/**
 * A collection of arguments for invoking getAlarmNoticeCallbacks.
 */
export interface GetAlarmNoticeCallbacksArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Tag description list.
     */
    tags?: {[key: string]: any};
}

/**
 * A collection of values returned by getAlarmNoticeCallbacks.
 */
export interface GetAlarmNoticeCallbacksResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    readonly tags?: {[key: string]: any};
    /**
     * Alarm callback notification.
     */
    readonly urlNotices: outputs.Monitor.GetAlarmNoticeCallbacksUrlNotice[];
}
/**
 * Use this data source to query detailed information of monitor alarmNoticeCallbacks
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const alarmNoticeCallbacks = tencentcloud.Monitor.getAlarmNoticeCallbacks({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAlarmNoticeCallbacksOutput(args?: GetAlarmNoticeCallbacksOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAlarmNoticeCallbacksResult> {
    return pulumi.output(args).apply((a: any) => getAlarmNoticeCallbacks(a, opts))
}

/**
 * A collection of arguments for invoking getAlarmNoticeCallbacks.
 */
export interface GetAlarmNoticeCallbacksOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Tag description list.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
}