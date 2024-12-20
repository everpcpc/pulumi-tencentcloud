// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of scf asyncEventStatus
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const asyncEventStatus = tencentcloud.Scf.getAsyncEventStatus({
 *     invokeRequestId: "9de9405a-e33a-498d-bb59-e80b7bed1191",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAsyncEventStatus(args: GetAsyncEventStatusArgs, opts?: pulumi.InvokeOptions): Promise<GetAsyncEventStatusResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Scf/getAsyncEventStatus:getAsyncEventStatus", {
        "invokeRequestId": args.invokeRequestId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getAsyncEventStatus.
 */
export interface GetAsyncEventStatusArgs {
    /**
     * ID of the async execution request.
     */
    invokeRequestId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getAsyncEventStatus.
 */
export interface GetAsyncEventStatusResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Async execution request ID.
     */
    readonly invokeRequestId: string;
    readonly resultOutputFile?: string;
    /**
     * Async event status.
     */
    readonly results: outputs.Scf.GetAsyncEventStatusResult[];
}
/**
 * Use this data source to query detailed information of scf asyncEventStatus
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const asyncEventStatus = tencentcloud.Scf.getAsyncEventStatus({
 *     invokeRequestId: "9de9405a-e33a-498d-bb59-e80b7bed1191",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAsyncEventStatusOutput(args: GetAsyncEventStatusOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAsyncEventStatusResult> {
    return pulumi.output(args).apply((a: any) => getAsyncEventStatus(a, opts))
}

/**
 * A collection of arguments for invoking getAsyncEventStatus.
 */
export interface GetAsyncEventStatusOutputArgs {
    /**
     * ID of the async execution request.
     */
    invokeRequestId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
