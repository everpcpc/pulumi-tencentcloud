// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of css timeShiftRecordDetail
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const timeShiftRecordDetail = tencentcloud.Css.getTimeShiftRecordDetail({
 *     appName: "qqq",
 *     domain: "177154.push.tlivecloud.com",
 *     domainGroup: "tf-test",
 *     endTime: 1698820641,
 *     startTime: 1698768000,
 *     streamName: "live",
 *     transCodeId: 0,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getTimeShiftRecordDetail(args: GetTimeShiftRecordDetailArgs, opts?: pulumi.InvokeOptions): Promise<GetTimeShiftRecordDetailResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Css/getTimeShiftRecordDetail:getTimeShiftRecordDetail", {
        "appName": args.appName,
        "domain": args.domain,
        "domainGroup": args.domainGroup,
        "endTime": args.endTime,
        "resultOutputFile": args.resultOutputFile,
        "startTime": args.startTime,
        "streamName": args.streamName,
        "transCodeId": args.transCodeId,
    }, opts);
}

/**
 * A collection of arguments for invoking getTimeShiftRecordDetail.
 */
export interface GetTimeShiftRecordDetailArgs {
    /**
     * Push path.
     */
    appName: string;
    /**
     * Push domain.
     */
    domain: string;
    /**
     * The streaming domain belongs to a group. If there is no domain group or the domain group is an empty string, it can be left blank.
     */
    domainGroup?: string;
    /**
     * The ending time of the query range is specified in Unix timestamp.
     */
    endTime: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * The starting time of the query range is specified in Unix timestamp.
     */
    startTime: number;
    /**
     * Stream name.
     */
    streamName: string;
    /**
     * The transcoding template ID can be left blank if it is 0.
     */
    transCodeId?: number;
}

/**
 * A collection of values returned by getTimeShiftRecordDetail.
 */
export interface GetTimeShiftRecordDetailResult {
    readonly appName: string;
    readonly domain: string;
    readonly domainGroup?: string;
    /**
     * The end time of the recording session is specified in Unix timestamp.
     */
    readonly endTime: number;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The array of time-shift recording sessions.Note: This field may return null, indicating that no valid value was found.
     */
    readonly recordLists: outputs.Css.GetTimeShiftRecordDetailRecordList[];
    readonly resultOutputFile?: string;
    /**
     * The start time of the recording session is specified in Unix timestamp.
     */
    readonly startTime: number;
    readonly streamName: string;
    readonly transCodeId?: number;
}
/**
 * Use this data source to query detailed information of css timeShiftRecordDetail
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const timeShiftRecordDetail = tencentcloud.Css.getTimeShiftRecordDetail({
 *     appName: "qqq",
 *     domain: "177154.push.tlivecloud.com",
 *     domainGroup: "tf-test",
 *     endTime: 1698820641,
 *     startTime: 1698768000,
 *     streamName: "live",
 *     transCodeId: 0,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getTimeShiftRecordDetailOutput(args: GetTimeShiftRecordDetailOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTimeShiftRecordDetailResult> {
    return pulumi.output(args).apply((a: any) => getTimeShiftRecordDetail(a, opts))
}

/**
 * A collection of arguments for invoking getTimeShiftRecordDetail.
 */
export interface GetTimeShiftRecordDetailOutputArgs {
    /**
     * Push path.
     */
    appName: pulumi.Input<string>;
    /**
     * Push domain.
     */
    domain: pulumi.Input<string>;
    /**
     * The streaming domain belongs to a group. If there is no domain group or the domain group is an empty string, it can be left blank.
     */
    domainGroup?: pulumi.Input<string>;
    /**
     * The ending time of the query range is specified in Unix timestamp.
     */
    endTime: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * The starting time of the query range is specified in Unix timestamp.
     */
    startTime: pulumi.Input<number>;
    /**
     * Stream name.
     */
    streamName: pulumi.Input<string>;
    /**
     * The transcoding template ID can be left blank if it is 0.
     */
    transCodeId?: pulumi.Input<number>;
}