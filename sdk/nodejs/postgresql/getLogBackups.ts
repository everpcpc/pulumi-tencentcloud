// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of postgresql logBackups
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const logBackups = tencentcloud.Postgresql.getLogBackups({
 *     minFinishTime: "%s",
 *     maxFinishTime: "%s",
 *     filters: [{
 *         name: "db-instance-id",
 *         values: [local.pgsql_id],
 *     }],
 *     orderBy: "StartTime",
 *     orderByType: "desc",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getLogBackups(args?: GetLogBackupsArgs, opts?: pulumi.InvokeOptions): Promise<GetLogBackupsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Postgresql/getLogBackups:getLogBackups", {
        "filters": args.filters,
        "maxFinishTime": args.maxFinishTime,
        "minFinishTime": args.minFinishTime,
        "orderBy": args.orderBy,
        "orderByType": args.orderByType,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getLogBackups.
 */
export interface GetLogBackupsArgs {
    /**
     * Filter instances using one or more criteria. Valid filter names:db-instance-id: Filter by instance ID (in string format).db-instance-name: Filter by instance name (in string format).db-instance-ip: Filter by instance VPC IP (in string format).
     */
    filters?: inputs.Postgresql.GetLogBackupsFilter[];
    /**
     * Maximum end time of a backup in the format of `2018-01-01 00:00:00`. It is the current time by default.
     */
    maxFinishTime?: string;
    /**
     * Minimum end time of a backup in the format of `2018-01-01 00:00:00`. It is 7 days ago by default.
     */
    minFinishTime?: string;
    /**
     * Sorting field. Valid values: `StartTime`, `FinishTime`, `Size`.
     */
    orderBy?: string;
    /**
     * Sorting order. Valid values: `asc` (ascending), `desc` (descending).
     */
    orderByType?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getLogBackups.
 */
export interface GetLogBackupsResult {
    readonly filters?: outputs.Postgresql.GetLogBackupsFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * List of log backup details.
     */
    readonly logBackupSets: outputs.Postgresql.GetLogBackupsLogBackupSet[];
    readonly maxFinishTime?: string;
    readonly minFinishTime?: string;
    readonly orderBy?: string;
    readonly orderByType?: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of postgresql logBackups
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const logBackups = tencentcloud.Postgresql.getLogBackups({
 *     minFinishTime: "%s",
 *     maxFinishTime: "%s",
 *     filters: [{
 *         name: "db-instance-id",
 *         values: [local.pgsql_id],
 *     }],
 *     orderBy: "StartTime",
 *     orderByType: "desc",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getLogBackupsOutput(args?: GetLogBackupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLogBackupsResult> {
    return pulumi.output(args).apply((a: any) => getLogBackups(a, opts))
}

/**
 * A collection of arguments for invoking getLogBackups.
 */
export interface GetLogBackupsOutputArgs {
    /**
     * Filter instances using one or more criteria. Valid filter names:db-instance-id: Filter by instance ID (in string format).db-instance-name: Filter by instance name (in string format).db-instance-ip: Filter by instance VPC IP (in string format).
     */
    filters?: pulumi.Input<pulumi.Input<inputs.Postgresql.GetLogBackupsFilterArgs>[]>;
    /**
     * Maximum end time of a backup in the format of `2018-01-01 00:00:00`. It is the current time by default.
     */
    maxFinishTime?: pulumi.Input<string>;
    /**
     * Minimum end time of a backup in the format of `2018-01-01 00:00:00`. It is 7 days ago by default.
     */
    minFinishTime?: pulumi.Input<string>;
    /**
     * Sorting field. Valid values: `StartTime`, `FinishTime`, `Size`.
     */
    orderBy?: pulumi.Input<string>;
    /**
     * Sorting order. Valid values: `asc` (ascending), `desc` (descending).
     */
    orderByType?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}