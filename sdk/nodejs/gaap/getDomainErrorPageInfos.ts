// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of gaap domain error page infos
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const domainErrorPageInfos = tencentcloud.Gaap.getDomainErrorPageInfos({
 *     errorPageIds: ["errorPage-xxxxxx"],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDomainErrorPageInfos(args: GetDomainErrorPageInfosArgs, opts?: pulumi.InvokeOptions): Promise<GetDomainErrorPageInfosResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Gaap/getDomainErrorPageInfos:getDomainErrorPageInfos", {
        "errorPageIds": args.errorPageIds,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getDomainErrorPageInfos.
 */
export interface GetDomainErrorPageInfosArgs {
    /**
     * Customized error ID list, supporting up to 10.
     */
    errorPageIds: string[];
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getDomainErrorPageInfos.
 */
export interface GetDomainErrorPageInfosResult {
    readonly errorPageIds: string[];
    /**
     * Custom error response configuration setNote: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly errorPageSets: outputs.Gaap.GetDomainErrorPageInfosErrorPageSet[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of gaap domain error page infos
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const domainErrorPageInfos = tencentcloud.Gaap.getDomainErrorPageInfos({
 *     errorPageIds: ["errorPage-xxxxxx"],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDomainErrorPageInfosOutput(args: GetDomainErrorPageInfosOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDomainErrorPageInfosResult> {
    return pulumi.output(args).apply((a: any) => getDomainErrorPageInfos(a, opts))
}

/**
 * A collection of arguments for invoking getDomainErrorPageInfos.
 */
export interface GetDomainErrorPageInfosOutputArgs {
    /**
     * Customized error ID list, supporting up to 10.
     */
    errorPageIds: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}