// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of waf ports
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Waf.getPorts({});
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Or
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Waf.getPorts({
 *     edition: "clb-waf",
 *     instanceId: "waf_2kxtlbky00b2v1fn",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getPorts(args?: GetPortsArgs, opts?: pulumi.InvokeOptions): Promise<GetPortsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Waf/getPorts:getPorts", {
        "edition": args.edition,
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getPorts.
 */
export interface GetPortsArgs {
    /**
     * Instance type, sparta-waf represents SAAS WAF, clb-waf represents CLB WAF.
     */
    edition?: string;
    /**
     * Instance unique ID.
     */
    instanceId?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getPorts.
 */
export interface GetPortsResult {
    readonly edition?: string;
    /**
     * Http port list for instance.
     */
    readonly httpPorts: string[];
    /**
     * Https port list for instance.
     */
    readonly httpsPorts: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId?: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of waf ports
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Waf.getPorts({});
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Or
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Waf.getPorts({
 *     edition: "clb-waf",
 *     instanceId: "waf_2kxtlbky00b2v1fn",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getPortsOutput(args?: GetPortsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetPortsResult> {
    return pulumi.output(args).apply((a: any) => getPorts(a, opts))
}

/**
 * A collection of arguments for invoking getPorts.
 */
export interface GetPortsOutputArgs {
    /**
     * Instance type, sparta-waf represents SAAS WAF, clb-waf represents CLB WAF.
     */
    edition?: pulumi.Input<string>;
    /**
     * Instance unique ID.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}