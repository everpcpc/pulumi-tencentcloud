// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query which instance types of Redis are available in a specific region.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const redislab = pulumi.output(tencentcloud.Redis.getZoneConfig({
 *     region: "ap-hongkong",
 *     resultOutputFile: "/temp/mytestpath",
 * }));
 * ```
 */
export function getZoneConfig(args?: GetZoneConfigArgs, opts?: pulumi.InvokeOptions): Promise<GetZoneConfigResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Redis/getZoneConfig:getZoneConfig", {
        "region": args.region,
        "resultOutputFile": args.resultOutputFile,
        "typeId": args.typeId,
    }, opts);
}

/**
 * A collection of arguments for invoking getZoneConfig.
 */
export interface GetZoneConfigArgs {
    /**
     * Name of a region. If this value is not set, the current region getting from provider's configuration will be used.
     */
    region?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Instance type ID.
     */
    typeId?: number;
}

/**
 * A collection of values returned by getZoneConfig.
 */
export interface GetZoneConfigResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A list of zone. Each element contains the following attributes:
     */
    readonly lists: outputs.Redis.GetZoneConfigList[];
    readonly region?: string;
    readonly resultOutputFile?: string;
    /**
     * Instance type. Which redis type supports in this zone.
     */
    readonly typeId?: number;
}

export function getZoneConfigOutput(args?: GetZoneConfigOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetZoneConfigResult> {
    return pulumi.output(args).apply(a => getZoneConfig(a, opts))
}

/**
 * A collection of arguments for invoking getZoneConfig.
 */
export interface GetZoneConfigOutputArgs {
    /**
     * Name of a region. If this value is not set, the current region getting from provider's configuration will be used.
     */
    region?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Instance type ID.
     */
    typeId?: pulumi.Input<number>;
}