// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of scf asyncEventManagement
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const asyncEventManagement = tencentcloud.Scf.getAsyncEventManagement({
 *     functionName: "keep-1676351130",
 *     namespace: "default",
 *     order: "ASC",
 *     orderby: "StartTime",
 *     qualifier: "$LATEST",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAsyncEventManagement(args: GetAsyncEventManagementArgs, opts?: pulumi.InvokeOptions): Promise<GetAsyncEventManagementResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Scf/getAsyncEventManagement:getAsyncEventManagement", {
        "functionName": args.functionName,
        "invokeRequestId": args.invokeRequestId,
        "invokeTypes": args.invokeTypes,
        "namespace": args.namespace,
        "order": args.order,
        "orderby": args.orderby,
        "qualifier": args.qualifier,
        "resultOutputFile": args.resultOutputFile,
        "statuses": args.statuses,
    }, opts);
}

/**
 * A collection of arguments for invoking getAsyncEventManagement.
 */
export interface GetAsyncEventManagementArgs {
    /**
     * Function name.
     */
    functionName: string;
    /**
     * Filter (event invocation request ID).
     */
    invokeRequestId?: string;
    /**
     * Filter (invocation type list), Values: CMQ, CKAFKA_TRIGGER, APIGW, COS, TRIGGER_TIMER, MPS_TRIGGER, CLS_TRIGGER, OTHERS.
     */
    invokeTypes?: string[];
    /**
     * Function namespace.
     */
    namespace?: string;
    /**
     * Valid values: ASC, DESC. Default value: DESC.
     */
    order?: string;
    /**
     * Valid values: StartTime, EndTime. Default value: StartTime.
     */
    orderby?: string;
    /**
     * Filter (function version).
     */
    qualifier?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Filter (event status list), Values: RUNNING, FINISHED, ABORTED, FAILED.
     */
    statuses?: string[];
}

/**
 * A collection of values returned by getAsyncEventManagement.
 */
export interface GetAsyncEventManagementResult {
    /**
     * Async event list.
     */
    readonly eventLists: outputs.Scf.GetAsyncEventManagementEventList[];
    readonly functionName: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Invocation request ID.
     */
    readonly invokeRequestId?: string;
    /**
     * Invocation type.
     */
    readonly invokeTypes?: string[];
    readonly namespace?: string;
    readonly order?: string;
    readonly orderby?: string;
    /**
     * Function version.
     */
    readonly qualifier?: string;
    readonly resultOutputFile?: string;
    /**
     * Event status. Values: `RUNNING`; `FINISHED` (invoked successfully); `ABORTED` (invocation ended); `FAILED` (invocation failed).
     */
    readonly statuses?: string[];
}
/**
 * Use this data source to query detailed information of scf asyncEventManagement
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const asyncEventManagement = tencentcloud.Scf.getAsyncEventManagement({
 *     functionName: "keep-1676351130",
 *     namespace: "default",
 *     order: "ASC",
 *     orderby: "StartTime",
 *     qualifier: "$LATEST",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAsyncEventManagementOutput(args: GetAsyncEventManagementOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAsyncEventManagementResult> {
    return pulumi.output(args).apply((a: any) => getAsyncEventManagement(a, opts))
}

/**
 * A collection of arguments for invoking getAsyncEventManagement.
 */
export interface GetAsyncEventManagementOutputArgs {
    /**
     * Function name.
     */
    functionName: pulumi.Input<string>;
    /**
     * Filter (event invocation request ID).
     */
    invokeRequestId?: pulumi.Input<string>;
    /**
     * Filter (invocation type list), Values: CMQ, CKAFKA_TRIGGER, APIGW, COS, TRIGGER_TIMER, MPS_TRIGGER, CLS_TRIGGER, OTHERS.
     */
    invokeTypes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Function namespace.
     */
    namespace?: pulumi.Input<string>;
    /**
     * Valid values: ASC, DESC. Default value: DESC.
     */
    order?: pulumi.Input<string>;
    /**
     * Valid values: StartTime, EndTime. Default value: StartTime.
     */
    orderby?: pulumi.Input<string>;
    /**
     * Filter (function version).
     */
    qualifier?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Filter (event status list), Values: RUNNING, FINISHED, ABORTED, FAILED.
     */
    statuses?: pulumi.Input<pulumi.Input<string>[]>;
}
