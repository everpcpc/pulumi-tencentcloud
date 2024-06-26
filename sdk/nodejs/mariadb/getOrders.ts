// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of mariadb orders
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const orders = pulumi.output(tencentcloud.Mariadb.getOrders({
 *     dealName: "20230607164033835942781",
 * }));
 * ```
 */
export function getOrders(args: GetOrdersArgs, opts?: pulumi.InvokeOptions): Promise<GetOrdersResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Mariadb/getOrders:getOrders", {
        "dealName": args.dealName,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getOrders.
 */
export interface GetOrdersArgs {
    /**
     * List of long order numbers to be queried, which are returned for the APIs for creating, renewing, or scaling instances.
     */
    dealName: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getOrders.
 */
export interface GetOrdersResult {
    /**
     * Order number.
     */
    readonly dealName: string;
    /**
     * Order information list.
     */
    readonly deals: outputs.Mariadb.GetOrdersDeal[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}

export function getOrdersOutput(args: GetOrdersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetOrdersResult> {
    return pulumi.output(args).apply(a => getOrders(a, opts))
}

/**
 * A collection of arguments for invoking getOrders.
 */
export interface GetOrdersOutputArgs {
    /**
     * List of long order numbers to be queried, which are returned for the APIs for creating, renewing, or scaling instances.
     */
    dealName: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
