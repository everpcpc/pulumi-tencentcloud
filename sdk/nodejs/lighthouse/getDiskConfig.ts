// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of lighthouse diskConfig
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const diskConfig = tencentcloud.Lighthouse.getDiskConfig({
 *     filters: [{
 *         name: "zone",
 *         values: ["ap-guangzhou-3"],
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDiskConfig(args?: GetDiskConfigArgs, opts?: pulumi.InvokeOptions): Promise<GetDiskConfigResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Lighthouse/getDiskConfig:getDiskConfig", {
        "filters": args.filters,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getDiskConfig.
 */
export interface GetDiskConfigArgs {
    /**
     * Filter list.zoneFilter by availability zone.Type: StringRequired: no.
     */
    filters?: inputs.Lighthouse.GetDiskConfigFilter[];
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getDiskConfig.
 */
export interface GetDiskConfigResult {
    /**
     * List of cloud disk configurations.
     */
    readonly diskConfigSets: outputs.Lighthouse.GetDiskConfigDiskConfigSet[];
    readonly filters?: outputs.Lighthouse.GetDiskConfigFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of lighthouse diskConfig
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const diskConfig = tencentcloud.Lighthouse.getDiskConfig({
 *     filters: [{
 *         name: "zone",
 *         values: ["ap-guangzhou-3"],
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDiskConfigOutput(args?: GetDiskConfigOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDiskConfigResult> {
    return pulumi.output(args).apply((a: any) => getDiskConfig(a, opts))
}

/**
 * A collection of arguments for invoking getDiskConfig.
 */
export interface GetDiskConfigOutputArgs {
    /**
     * Filter list.zoneFilter by availability zone.Type: StringRequired: no.
     */
    filters?: pulumi.Input<pulumi.Input<inputs.Lighthouse.GetDiskConfigFilterArgs>[]>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}