// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of waf userClbRegions
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = pulumi.output(tencentcloud.Waf.getUserClbRegions());
 * ```
 */
export function getUserClbRegions(args?: GetUserClbRegionsArgs, opts?: pulumi.InvokeOptions): Promise<GetUserClbRegionsResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Waf/getUserClbRegions:getUserClbRegions", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getUserClbRegions.
 */
export interface GetUserClbRegionsArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getUserClbRegions.
 */
export interface GetUserClbRegionsResult {
    /**
     * Region list(ap-xxx format).
     */
    readonly datas: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * Detail info for region.
     */
    readonly richDatas: outputs.Waf.GetUserClbRegionsRichData[];
}

export function getUserClbRegionsOutput(args?: GetUserClbRegionsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetUserClbRegionsResult> {
    return pulumi.output(args).apply(a => getUserClbRegions(a, opts))
}

/**
 * A collection of arguments for invoking getUserClbRegions.
 */
export interface GetUserClbRegionsOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
