// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of vpc addressQuota
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const addressQuota = pulumi.output(tencentcloud.Eip.getAddressQuota());
 * ```
 */
export function getAddressQuota(args?: GetAddressQuotaArgs, opts?: pulumi.InvokeOptions): Promise<GetAddressQuotaResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Eip/getAddressQuota:getAddressQuota", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getAddressQuota.
 */
export interface GetAddressQuotaArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getAddressQuota.
 */
export interface GetAddressQuotaResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The specified account EIP quota information.
     */
    readonly quotaSets: outputs.Eip.GetAddressQuotaQuotaSet[];
    readonly resultOutputFile?: string;
}

export function getAddressQuotaOutput(args?: GetAddressQuotaOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAddressQuotaResult> {
    return pulumi.output(args).apply(a => getAddressQuota(a, opts))
}

/**
 * A collection of arguments for invoking getAddressQuota.
 */
export interface GetAddressQuotaOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
