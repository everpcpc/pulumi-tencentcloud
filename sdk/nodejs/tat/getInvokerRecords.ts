// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tat invokerRecords
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const invokerRecords = tencentcloud.Tat.getInvokerRecords({
 *     invokerIds: ["ivk-cas4upyf"],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getInvokerRecords(args?: GetInvokerRecordsArgs, opts?: pulumi.InvokeOptions): Promise<GetInvokerRecordsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tat/getInvokerRecords:getInvokerRecords", {
        "invokerIds": args.invokerIds,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getInvokerRecords.
 */
export interface GetInvokerRecordsArgs {
    /**
     * List of invoker IDs. Up to 100 IDs are allowed.
     */
    invokerIds?: string[];
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getInvokerRecords.
 */
export interface GetInvokerRecordsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly invokerIds?: string[];
    /**
     * Execution history of an invoker.
     */
    readonly invokerRecordSets: outputs.Tat.GetInvokerRecordsInvokerRecordSet[];
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of tat invokerRecords
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const invokerRecords = tencentcloud.Tat.getInvokerRecords({
 *     invokerIds: ["ivk-cas4upyf"],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getInvokerRecordsOutput(args?: GetInvokerRecordsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInvokerRecordsResult> {
    return pulumi.output(args).apply((a: any) => getInvokerRecords(a, opts))
}

/**
 * A collection of arguments for invoking getInvokerRecords.
 */
export interface GetInvokerRecordsOutputArgs {
    /**
     * List of invoker IDs. Up to 100 IDs are allowed.
     */
    invokerIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
