// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of dbbrain slowLogs
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const slowLogs = tencentcloud.Dbbrain.getSlowLogs({
 *     endTime: "%s",
 *     instanceId: "%s",
 *     md5: "4961208426639258265",
 *     product: "mysql",
 *     startTime: "%s",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getSlowLogs(args: GetSlowLogsArgs, opts?: pulumi.InvokeOptions): Promise<GetSlowLogsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Dbbrain/getSlowLogs:getSlowLogs", {
        "dbs": args.dbs,
        "endTime": args.endTime,
        "instanceId": args.instanceId,
        "ips": args.ips,
        "keys": args.keys,
        "md5": args.md5,
        "product": args.product,
        "resultOutputFile": args.resultOutputFile,
        "startTime": args.startTime,
        "times": args.times,
        "users": args.users,
    }, opts);
}

/**
 * A collection of arguments for invoking getSlowLogs.
 */
export interface GetSlowLogsArgs {
    /**
     * database list.
     */
    dbs?: string[];
    /**
     * The deadline, such as 2019-09-11 10:13:14, the interval between the deadline and the start time is less than 7 days.
     */
    endTime: string;
    /**
     * instance Id.
     */
    instanceId: string;
    /**
     * ip.
     */
    ips?: string[];
    /**
     * keywords.
     */
    keys?: string[];
    /**
     * md5 value of sql template.
     */
    md5: string;
    /**
     * Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL, the default is mysql.
     */
    product: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Start time, such as 2019-09-10 12:13:14.
     */
    startTime: string;
    /**
     * Time-consuming interval, the left and right boundaries of the time-consuming interval correspond to the 0th element and the first element of the array respectively.
     */
    times?: number[];
    /**
     * user.
     */
    users?: string[];
}

/**
 * A collection of values returned by getSlowLogs.
 */
export interface GetSlowLogsResult {
    readonly dbs?: string[];
    readonly endTime: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly ips?: string[];
    readonly keys?: string[];
    readonly md5: string;
    readonly product: string;
    readonly resultOutputFile?: string;
    /**
     * Slow log details.
     */
    readonly rows: outputs.Dbbrain.GetSlowLogsRow[];
    readonly startTime: string;
    readonly times?: number[];
    readonly users?: string[];
}
/**
 * Use this data source to query detailed information of dbbrain slowLogs
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const slowLogs = tencentcloud.Dbbrain.getSlowLogs({
 *     endTime: "%s",
 *     instanceId: "%s",
 *     md5: "4961208426639258265",
 *     product: "mysql",
 *     startTime: "%s",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getSlowLogsOutput(args: GetSlowLogsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSlowLogsResult> {
    return pulumi.output(args).apply((a: any) => getSlowLogs(a, opts))
}

/**
 * A collection of arguments for invoking getSlowLogs.
 */
export interface GetSlowLogsOutputArgs {
    /**
     * database list.
     */
    dbs?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The deadline, such as 2019-09-11 10:13:14, the interval between the deadline and the start time is less than 7 days.
     */
    endTime: pulumi.Input<string>;
    /**
     * instance Id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * ip.
     */
    ips?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * keywords.
     */
    keys?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * md5 value of sql template.
     */
    md5: pulumi.Input<string>;
    /**
     * Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL, the default is mysql.
     */
    product: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Start time, such as 2019-09-10 12:13:14.
     */
    startTime: pulumi.Input<string>;
    /**
     * Time-consuming interval, the left and right boundaries of the time-consuming interval correspond to the 0th element and the first element of the array respectively.
     */
    times?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * user.
     */
    users?: pulumi.Input<pulumi.Input<string>[]>;
}