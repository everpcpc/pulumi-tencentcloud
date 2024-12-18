// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of oceanus clusters
 *
 * ## Example Usage
 *
 * ### Query all clusters
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Oceanus.getClusters({});
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Query the specified cluster
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Oceanus.getClusters({
 *     clusterIds: ["cluster-5c42n3a5"],
 *     filters: [{
 *         name: "name",
 *         values: ["tf_example"],
 *     }],
 *     orderType: 1,
 *     workSpaceId: "space-2idq8wbr",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getClusters(args?: GetClustersArgs, opts?: pulumi.InvokeOptions): Promise<GetClustersResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Oceanus/getClusters:getClusters", {
        "clusterIds": args.clusterIds,
        "filters": args.filters,
        "orderType": args.orderType,
        "resultOutputFile": args.resultOutputFile,
        "workSpaceId": args.workSpaceId,
    }, opts);
}

/**
 * A collection of arguments for invoking getClusters.
 */
export interface GetClustersArgs {
    /**
     * Query one or more clusters by their ID. The maximum number of clusters that can be queried at once is 100.
     */
    clusterIds?: string[];
    /**
     * The filtering rules.
     */
    filters?: inputs.Oceanus.GetClustersFilter[];
    /**
     * The sorting rule of the cluster information results. Possible values are 1 (sort by time in descending order), 2 (sort by time in ascending order), and 3 (sort by status).
     */
    orderType?: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Workspace SerialId.
     */
    workSpaceId?: string;
}

/**
 * A collection of values returned by getClusters.
 */
export interface GetClustersResult {
    readonly clusterIds?: string[];
    /**
     * Cluster list.
     */
    readonly clusterSets: outputs.Oceanus.GetClustersClusterSet[];
    readonly filters?: outputs.Oceanus.GetClustersFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly orderType?: number;
    readonly resultOutputFile?: string;
    /**
     * Workspace SerialId.
     */
    readonly workSpaceId?: string;
}
/**
 * Use this data source to query detailed information of oceanus clusters
 *
 * ## Example Usage
 *
 * ### Query all clusters
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Oceanus.getClusters({});
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Query the specified cluster
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Oceanus.getClusters({
 *     clusterIds: ["cluster-5c42n3a5"],
 *     filters: [{
 *         name: "name",
 *         values: ["tf_example"],
 *     }],
 *     orderType: 1,
 *     workSpaceId: "space-2idq8wbr",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getClustersOutput(args?: GetClustersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClustersResult> {
    return pulumi.output(args).apply((a: any) => getClusters(a, opts))
}

/**
 * A collection of arguments for invoking getClusters.
 */
export interface GetClustersOutputArgs {
    /**
     * Query one or more clusters by their ID. The maximum number of clusters that can be queried at once is 100.
     */
    clusterIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The filtering rules.
     */
    filters?: pulumi.Input<pulumi.Input<inputs.Oceanus.GetClustersFilterArgs>[]>;
    /**
     * The sorting rule of the cluster information results. Possible values are 1 (sort by time in descending order), 2 (sort by time in ascending order), and 3 (sort by status).
     */
    orderType?: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Workspace SerialId.
     */
    workSpaceId?: pulumi.Input<string>;
}
