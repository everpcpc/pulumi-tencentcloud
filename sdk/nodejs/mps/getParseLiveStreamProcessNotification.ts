// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of mps parseLiveStreamProcessNotification
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const parseLiveStreamProcessNotification = tencentcloud.Mps.getParseLiveStreamProcessNotification({
 *     content: "your_content",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getParseLiveStreamProcessNotification(args: GetParseLiveStreamProcessNotificationArgs, opts?: pulumi.InvokeOptions): Promise<GetParseLiveStreamProcessNotificationResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Mps/getParseLiveStreamProcessNotification:getParseLiveStreamProcessNotification", {
        "content": args.content,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getParseLiveStreamProcessNotification.
 */
export interface GetParseLiveStreamProcessNotificationArgs {
    /**
     * Live stream event notification obtained from CMQ.
     */
    content: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getParseLiveStreamProcessNotification.
 */
export interface GetParseLiveStreamProcessNotificationResult {
    readonly content: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of mps parseLiveStreamProcessNotification
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const parseLiveStreamProcessNotification = tencentcloud.Mps.getParseLiveStreamProcessNotification({
 *     content: "your_content",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getParseLiveStreamProcessNotificationOutput(args: GetParseLiveStreamProcessNotificationOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetParseLiveStreamProcessNotificationResult> {
    return pulumi.output(args).apply((a: any) => getParseLiveStreamProcessNotification(a, opts))
}

/**
 * A collection of arguments for invoking getParseLiveStreamProcessNotification.
 */
export interface GetParseLiveStreamProcessNotificationOutputArgs {
    /**
     * Live stream event notification obtained from CMQ.
     */
    content: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}