// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of antiddos overviewDdosEventList
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const overviewDdosEventList = tencentcloud.Antiddos.getOverviewDdosEventList({
 *     attackStatus: "end",
 *     endTime: "2023-11-21 00:00:00",
 *     startTime: "2023-11-20 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getOverviewDdosEventList(args: GetOverviewDdosEventListArgs, opts?: pulumi.InvokeOptions): Promise<GetOverviewDdosEventListResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Antiddos/getOverviewDdosEventList:getOverviewDdosEventList", {
        "attackStatus": args.attackStatus,
        "endTime": args.endTime,
        "resultOutputFile": args.resultOutputFile,
        "startTime": args.startTime,
    }, opts);
}

/**
 * A collection of arguments for invoking getOverviewDdosEventList.
 */
export interface GetOverviewDdosEventListArgs {
    /**
     * filter event by attack status, start: attacking; end: attack end.
     */
    attackStatus?: string;
    /**
     * EndTime.
     */
    endTime: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * StartTime.
     */
    startTime: string;
}

/**
 * A collection of values returned by getOverviewDdosEventList.
 */
export interface GetOverviewDdosEventListResult {
    /**
     * Attack status, 0: Under attack; 1: End of attack.
     */
    readonly attackStatus?: string;
    /**
     * EndTime.
     */
    readonly endTime: string;
    /**
     * EventList.
     */
    readonly eventLists: outputs.Antiddos.GetOverviewDdosEventListEventList[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * StartTime.
     */
    readonly startTime: string;
}
/**
 * Use this data source to query detailed information of antiddos overviewDdosEventList
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const overviewDdosEventList = tencentcloud.Antiddos.getOverviewDdosEventList({
 *     attackStatus: "end",
 *     endTime: "2023-11-21 00:00:00",
 *     startTime: "2023-11-20 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getOverviewDdosEventListOutput(args: GetOverviewDdosEventListOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetOverviewDdosEventListResult> {
    return pulumi.output(args).apply((a: any) => getOverviewDdosEventList(a, opts))
}

/**
 * A collection of arguments for invoking getOverviewDdosEventList.
 */
export interface GetOverviewDdosEventListOutputArgs {
    /**
     * filter event by attack status, start: attacking; end: attack end.
     */
    attackStatus?: pulumi.Input<string>;
    /**
     * EndTime.
     */
    endTime: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * StartTime.
     */
    startTime: pulumi.Input<string>;
}