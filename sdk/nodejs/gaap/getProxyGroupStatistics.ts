// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of gaap proxy group statistics
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const proxyGroupStatistics = tencentcloud.Gaap.getProxyGroupStatistics({
 *     endTime: "2023-10-09 23:59:59",
 *     granularity: 300,
 *     groupId: "link-m9t4yho9",
 *     metricNames: [
 *         "InBandwidth",
 *         "OutBandwidth",
 *         "InFlow",
 *         "OutFlow",
 *     ],
 *     startTime: "2023-10-09 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getProxyGroupStatistics(args: GetProxyGroupStatisticsArgs, opts?: pulumi.InvokeOptions): Promise<GetProxyGroupStatisticsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Gaap/getProxyGroupStatistics:getProxyGroupStatistics", {
        "endTime": args.endTime,
        "granularity": args.granularity,
        "groupId": args.groupId,
        "metricNames": args.metricNames,
        "resultOutputFile": args.resultOutputFile,
        "startTime": args.startTime,
    }, opts);
}

/**
 * A collection of arguments for invoking getProxyGroupStatistics.
 */
export interface GetProxyGroupStatisticsArgs {
    /**
     * End Time.
     */
    endTime: string;
    /**
     * Monitoring granularity, currently supporting 60 300 3600 86400, in seconds.When the time range does not exceed 1 day, support a minimum granularity of 60 seconds;When the time range does not exceed 7 days, support a minimum granularity of 3600 seconds;When the time range does not exceed 30 days, the minimum granularity supported is 86400 seconds.
     */
    granularity: number;
    /**
     * Group Id.
     */
    groupId: string;
    /**
     * Metric Names. support, InBandwidth, OutBandwidth, Concurrent, InPackets, OutPackets.
     */
    metricNames: string[];
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Start Time.
     */
    startTime: string;
}

/**
 * A collection of values returned by getProxyGroupStatistics.
 */
export interface GetProxyGroupStatisticsResult {
    readonly endTime: string;
    readonly granularity: number;
    readonly groupId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly metricNames: string[];
    readonly resultOutputFile?: string;
    readonly startTime: string;
    /**
     * proxy Group Statistics.
     */
    readonly statisticsDatas: outputs.Gaap.GetProxyGroupStatisticsStatisticsData[];
}
/**
 * Use this data source to query detailed information of gaap proxy group statistics
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const proxyGroupStatistics = tencentcloud.Gaap.getProxyGroupStatistics({
 *     endTime: "2023-10-09 23:59:59",
 *     granularity: 300,
 *     groupId: "link-m9t4yho9",
 *     metricNames: [
 *         "InBandwidth",
 *         "OutBandwidth",
 *         "InFlow",
 *         "OutFlow",
 *     ],
 *     startTime: "2023-10-09 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getProxyGroupStatisticsOutput(args: GetProxyGroupStatisticsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProxyGroupStatisticsResult> {
    return pulumi.output(args).apply((a: any) => getProxyGroupStatistics(a, opts))
}

/**
 * A collection of arguments for invoking getProxyGroupStatistics.
 */
export interface GetProxyGroupStatisticsOutputArgs {
    /**
     * End Time.
     */
    endTime: pulumi.Input<string>;
    /**
     * Monitoring granularity, currently supporting 60 300 3600 86400, in seconds.When the time range does not exceed 1 day, support a minimum granularity of 60 seconds;When the time range does not exceed 7 days, support a minimum granularity of 3600 seconds;When the time range does not exceed 30 days, the minimum granularity supported is 86400 seconds.
     */
    granularity: pulumi.Input<number>;
    /**
     * Group Id.
     */
    groupId: pulumi.Input<string>;
    /**
     * Metric Names. support, InBandwidth, OutBandwidth, Concurrent, InPackets, OutPackets.
     */
    metricNames: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Start Time.
     */
    startTime: pulumi.Input<string>;
}
