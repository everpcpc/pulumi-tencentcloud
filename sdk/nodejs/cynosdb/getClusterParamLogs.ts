// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of cynosdb clusterParamLogs
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const clusterParamLogs = tencentcloud.Cynosdb.getClusterParamLogs({
 *     clusterId: "cynosdbmysql-bws8h88b",
 *     instanceIds: ["cynosdbmysql-ins-afqx1hy0"],
 *     orderBy: "CreateTime",
 *     orderByType: "DESC",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getClusterParamLogs(args: GetClusterParamLogsArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterParamLogsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Cynosdb/getClusterParamLogs:getClusterParamLogs", {
        "clusterId": args.clusterId,
        "instanceIds": args.instanceIds,
        "orderBy": args.orderBy,
        "orderByType": args.orderByType,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getClusterParamLogs.
 */
export interface GetClusterParamLogsArgs {
    /**
     * Cluster ID.
     */
    clusterId: string;
    /**
     * Instance ID list, used to record specific instances of operations.
     */
    instanceIds?: string[];
    /**
     * Sort field, defining which field to sort based on when returning results.
     */
    orderBy?: string;
    /**
     * Define specific sorting rules, limited to one of desc, asc, DESC, or ASC.
     */
    orderByType?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getClusterParamLogs.
 */
export interface GetClusterParamLogsResult {
    /**
     * Cluster ID.
     */
    readonly clusterId: string;
    /**
     * Parameter modification record note: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly clusterParamLogs: outputs.Cynosdb.GetClusterParamLogsClusterParamLog[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceIds?: string[];
    readonly orderBy?: string;
    readonly orderByType?: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of cynosdb clusterParamLogs
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const clusterParamLogs = tencentcloud.Cynosdb.getClusterParamLogs({
 *     clusterId: "cynosdbmysql-bws8h88b",
 *     instanceIds: ["cynosdbmysql-ins-afqx1hy0"],
 *     orderBy: "CreateTime",
 *     orderByType: "DESC",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getClusterParamLogsOutput(args: GetClusterParamLogsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClusterParamLogsResult> {
    return pulumi.output(args).apply((a: any) => getClusterParamLogs(a, opts))
}

/**
 * A collection of arguments for invoking getClusterParamLogs.
 */
export interface GetClusterParamLogsOutputArgs {
    /**
     * Cluster ID.
     */
    clusterId: pulumi.Input<string>;
    /**
     * Instance ID list, used to record specific instances of operations.
     */
    instanceIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Sort field, defining which field to sort based on when returning results.
     */
    orderBy?: pulumi.Input<string>;
    /**
     * Define specific sorting rules, limited to one of desc, asc, DESC, or ASC.
     */
    orderByType?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}