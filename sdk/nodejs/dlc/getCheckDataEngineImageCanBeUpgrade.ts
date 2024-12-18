// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of dlc checkDataEngineImageCanBeUpgrade
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const checkDataEngineImageCanBeUpgrade = tencentcloud.Dlc.getCheckDataEngineImageCanBeUpgrade({
 *     dataEngineId: "DataEngine-cgkvbas6",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCheckDataEngineImageCanBeUpgrade(args: GetCheckDataEngineImageCanBeUpgradeArgs, opts?: pulumi.InvokeOptions): Promise<GetCheckDataEngineImageCanBeUpgradeResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Dlc/getCheckDataEngineImageCanBeUpgrade:getCheckDataEngineImageCanBeUpgrade", {
        "dataEngineId": args.dataEngineId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getCheckDataEngineImageCanBeUpgrade.
 */
export interface GetCheckDataEngineImageCanBeUpgradeArgs {
    /**
     * Engine unique id.
     */
    dataEngineId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getCheckDataEngineImageCanBeUpgrade.
 */
export interface GetCheckDataEngineImageCanBeUpgradeResult {
    /**
     * The latest image version id that can be upgraded.
     */
    readonly childImageVersionId: string;
    readonly dataEngineId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Is it possible to upgrade.
     */
    readonly isUpgrade: boolean;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of dlc checkDataEngineImageCanBeUpgrade
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const checkDataEngineImageCanBeUpgrade = tencentcloud.Dlc.getCheckDataEngineImageCanBeUpgrade({
 *     dataEngineId: "DataEngine-cgkvbas6",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCheckDataEngineImageCanBeUpgradeOutput(args: GetCheckDataEngineImageCanBeUpgradeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCheckDataEngineImageCanBeUpgradeResult> {
    return pulumi.output(args).apply((a: any) => getCheckDataEngineImageCanBeUpgrade(a, opts))
}

/**
 * A collection of arguments for invoking getCheckDataEngineImageCanBeUpgrade.
 */
export interface GetCheckDataEngineImageCanBeUpgradeOutputArgs {
    /**
     * Engine unique id.
     */
    dataEngineId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
