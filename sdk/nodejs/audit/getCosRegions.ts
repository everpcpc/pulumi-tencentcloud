// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query the cos region list supported by the audit.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = tencentcloud.Audit.getCosRegions({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCosRegions(args?: GetCosRegionsArgs, opts?: pulumi.InvokeOptions): Promise<GetCosRegionsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Audit/getCosRegions:getCosRegions", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getCosRegions.
 */
export interface GetCosRegionsArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getCosRegions.
 */
export interface GetCosRegionsResult {
    /**
     * List of available regions supported by audit cos.
     */
    readonly auditCosRegionLists: outputs.Audit.GetCosRegionsAuditCosRegionList[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query the cos region list supported by the audit.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = tencentcloud.Audit.getCosRegions({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCosRegionsOutput(args?: GetCosRegionsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCosRegionsResult> {
    return pulumi.output(args).apply((a: any) => getCosRegions(a, opts))
}

/**
 * A collection of arguments for invoking getCosRegions.
 */
export interface GetCosRegionsOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
