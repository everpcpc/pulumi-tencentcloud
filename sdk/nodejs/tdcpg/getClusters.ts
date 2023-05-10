// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tdcpg clusters.
 *
 * > **NOTE:** This data source is still in internal testing. To experience its functions, you need to apply for a whitelist from Tencent Cloud.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const clusters = pulumi.output(tencentcloud.Tdcpg.getClusters({
 *     clusterId: "",
 *     clusterName: "",
 *     payMode: "",
 *     projectId: 0,
 *     status: "",
 * }));
 * ```
 */
export function getClusters(args?: GetClustersArgs, opts?: pulumi.InvokeOptions): Promise<GetClustersResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Tdcpg/getClusters:getClusters", {
        "clusterId": args.clusterId,
        "clusterName": args.clusterName,
        "payMode": args.payMode,
        "projectId": args.projectId,
        "resultOutputFile": args.resultOutputFile,
        "status": args.status,
    }, opts);
}

/**
 * A collection of arguments for invoking getClusters.
 */
export interface GetClustersArgs {
    /**
     * cluster id.
     */
    clusterId?: string;
    /**
     * cluster name.
     */
    clusterName?: string;
    /**
     * pay mode.
     */
    payMode?: string;
    /**
     * project id, default to 0, means default project.
     */
    projectId?: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * cluster status.
     */
    status?: string;
}

/**
 * A collection of values returned by getClusters.
 */
export interface GetClustersResult {
    /**
     * cluster id.
     */
    readonly clusterId?: string;
    /**
     * cluster name.
     */
    readonly clusterName?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * cluster list.
     */
    readonly lists: outputs.Tdcpg.GetClustersList[];
    /**
     * pay mode.
     */
    readonly payMode?: string;
    /**
     * project id.
     */
    readonly projectId?: number;
    readonly resultOutputFile?: string;
    /**
     * status.
     */
    readonly status?: string;
}

export function getClustersOutput(args?: GetClustersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClustersResult> {
    return pulumi.output(args).apply(a => getClusters(a, opts))
}

/**
 * A collection of arguments for invoking getClusters.
 */
export interface GetClustersOutputArgs {
    /**
     * cluster id.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * cluster name.
     */
    clusterName?: pulumi.Input<string>;
    /**
     * pay mode.
     */
    payMode?: pulumi.Input<string>;
    /**
     * project id, default to 0, means default project.
     */
    projectId?: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * cluster status.
     */
    status?: pulumi.Input<string>;
}