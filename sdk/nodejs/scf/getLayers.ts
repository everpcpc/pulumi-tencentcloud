// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of scf layers
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const layers = tencentcloud.Scf.getLayers({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getLayers(args?: GetLayersArgs, opts?: pulumi.InvokeOptions): Promise<GetLayersResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Scf/getLayers:getLayers", {
        "compatibleRuntime": args.compatibleRuntime,
        "resultOutputFile": args.resultOutputFile,
        "searchKey": args.searchKey,
    }, opts);
}

/**
 * A collection of arguments for invoking getLayers.
 */
export interface GetLayersArgs {
    /**
     * Compatible runtimes.
     */
    compatibleRuntime?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Query key, which fuzzily matches the name.
     */
    searchKey?: string;
}

/**
 * A collection of values returned by getLayers.
 */
export interface GetLayersResult {
    readonly compatibleRuntime?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Layer list.
     */
    readonly layers: outputs.Scf.GetLayersLayer[];
    readonly resultOutputFile?: string;
    readonly searchKey?: string;
}
/**
 * Use this data source to query detailed information of scf layers
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const layers = tencentcloud.Scf.getLayers({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getLayersOutput(args?: GetLayersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLayersResult> {
    return pulumi.output(args).apply((a: any) => getLayers(a, opts))
}

/**
 * A collection of arguments for invoking getLayers.
 */
export interface GetLayersOutputArgs {
    /**
     * Compatible runtimes.
     */
    compatibleRuntime?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Query key, which fuzzily matches the name.
     */
    searchKey?: pulumi.Input<string>;
}