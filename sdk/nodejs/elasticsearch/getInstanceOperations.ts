// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of elasticsearch instance operations
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const instanceOperations = tencentcloud.Elasticsearch.getInstanceOperations({
 *     endTime: "2023-10-31 10:12:45",
 *     instanceId: "es-xxxxxx",
 *     startTime: "2018-01-01 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getInstanceOperations(args: GetInstanceOperationsArgs, opts?: pulumi.InvokeOptions): Promise<GetInstanceOperationsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Elasticsearch/getInstanceOperations:getInstanceOperations", {
        "endTime": args.endTime,
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
        "startTime": args.startTime,
    }, opts);
}

/**
 * A collection of arguments for invoking getInstanceOperations.
 */
export interface GetInstanceOperationsArgs {
    /**
     * End time, e.g. 2019-03-30 20:18:03.
     */
    endTime: string;
    /**
     * Instance id.
     */
    instanceId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Start time, e.g. 2019-03-07 16:30:39.
     */
    startTime: string;
}

/**
 * A collection of values returned by getInstanceOperations.
 */
export interface GetInstanceOperationsResult {
    readonly endTime: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    /**
     * Operation records.
     */
    readonly operations: outputs.Elasticsearch.GetInstanceOperationsOperation[];
    readonly resultOutputFile?: string;
    /**
     * Start time.
     */
    readonly startTime: string;
}
/**
 * Use this data source to query detailed information of elasticsearch instance operations
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const instanceOperations = tencentcloud.Elasticsearch.getInstanceOperations({
 *     endTime: "2023-10-31 10:12:45",
 *     instanceId: "es-xxxxxx",
 *     startTime: "2018-01-01 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getInstanceOperationsOutput(args: GetInstanceOperationsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInstanceOperationsResult> {
    return pulumi.output(args).apply((a: any) => getInstanceOperations(a, opts))
}

/**
 * A collection of arguments for invoking getInstanceOperations.
 */
export interface GetInstanceOperationsOutputArgs {
    /**
     * End time, e.g. 2019-03-30 20:18:03.
     */
    endTime: pulumi.Input<string>;
    /**
     * Instance id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Start time, e.g. 2019-03-07 16:30:39.
     */
    startTime: pulumi.Input<string>;
}