// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of waf attackOverview
 *
 * ## Example Usage
 *
 * ### Basic Query
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Waf.getAttackOverview({
 *     fromTime: "2023-09-01 00:00:00",
 *     toTime: "2023-09-07 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Query by filter
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Waf.getAttackOverview({
 *     appid: 1304251372,
 *     domain: "test.com",
 *     edition: "clb-waf",
 *     fromTime: "2023-09-01 00:00:00",
 *     instanceId: "waf_2kxtlbky00b2v1fn",
 *     toTime: "2023-09-07 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAttackOverview(args: GetAttackOverviewArgs, opts?: pulumi.InvokeOptions): Promise<GetAttackOverviewResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Waf/getAttackOverview:getAttackOverview", {
        "appid": args.appid,
        "domain": args.domain,
        "edition": args.edition,
        "fromTime": args.fromTime,
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
        "toTime": args.toTime,
    }, opts);
}

/**
 * A collection of arguments for invoking getAttackOverview.
 */
export interface GetAttackOverviewArgs {
    /**
     * App id.
     */
    appid?: number;
    /**
     * Domain.
     */
    domain?: string;
    /**
     * support `sparta-waf`, `clb-waf`, otherwise not filter.
     */
    edition?: string;
    /**
     * Begin time.
     */
    fromTime: string;
    /**
     * Waf instanceId, otherwise not filter.
     */
    instanceId?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * End time.
     */
    toTime: string;
}

/**
 * A collection of values returned by getAttackOverview.
 */
export interface GetAttackOverviewResult {
    /**
     * Access count.
     */
    readonly accessCount: number;
    /**
     * Access control count.
     */
    readonly aclCount: number;
    /**
     * Api asset count.
     */
    readonly apiAssetsCount: number;
    /**
     * Number of API risk events.
     */
    readonly apiRiskEventCount: number;
    readonly appid?: number;
    /**
     * Attack count.
     */
    readonly attackCount: number;
    /**
     * Bot attack count.
     */
    readonly botCount: number;
    /**
     * CC attack count.
     */
    readonly ccCount: number;
    readonly domain?: string;
    readonly edition?: string;
    readonly fromTime: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId?: string;
    readonly resultOutputFile?: string;
    readonly toTime: string;
}
/**
 * Use this data source to query detailed information of waf attackOverview
 *
 * ## Example Usage
 *
 * ### Basic Query
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Waf.getAttackOverview({
 *     fromTime: "2023-09-01 00:00:00",
 *     toTime: "2023-09-07 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Query by filter
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Waf.getAttackOverview({
 *     appid: 1304251372,
 *     domain: "test.com",
 *     edition: "clb-waf",
 *     fromTime: "2023-09-01 00:00:00",
 *     instanceId: "waf_2kxtlbky00b2v1fn",
 *     toTime: "2023-09-07 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAttackOverviewOutput(args: GetAttackOverviewOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAttackOverviewResult> {
    return pulumi.output(args).apply((a: any) => getAttackOverview(a, opts))
}

/**
 * A collection of arguments for invoking getAttackOverview.
 */
export interface GetAttackOverviewOutputArgs {
    /**
     * App id.
     */
    appid?: pulumi.Input<number>;
    /**
     * Domain.
     */
    domain?: pulumi.Input<string>;
    /**
     * support `sparta-waf`, `clb-waf`, otherwise not filter.
     */
    edition?: pulumi.Input<string>;
    /**
     * Begin time.
     */
    fromTime: pulumi.Input<string>;
    /**
     * Waf instanceId, otherwise not filter.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * End time.
     */
    toTime: pulumi.Input<string>;
}