// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of organization orgAuthNode
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const orgAuthNode = tencentcloud.Organization.getOrgAuthNode({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getOrgAuthNode(args?: GetOrgAuthNodeArgs, opts?: pulumi.InvokeOptions): Promise<GetOrgAuthNodeResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Organization/getOrgAuthNode:getOrgAuthNode", {
        "authName": args.authName,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getOrgAuthNode.
 */
export interface GetOrgAuthNodeArgs {
    /**
     * Verified company name.
     */
    authName?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getOrgAuthNode.
 */
export interface GetOrgAuthNodeResult {
    /**
     * Verified company name.
     */
    readonly authName?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Organization auth node list.
     */
    readonly items: outputs.Organization.GetOrgAuthNodeItem[];
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of organization orgAuthNode
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const orgAuthNode = tencentcloud.Organization.getOrgAuthNode({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getOrgAuthNodeOutput(args?: GetOrgAuthNodeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetOrgAuthNodeResult> {
    return pulumi.output(args).apply((a: any) => getOrgAuthNode(a, opts))
}

/**
 * A collection of arguments for invoking getOrgAuthNode.
 */
export interface GetOrgAuthNodeOutputArgs {
    /**
     * Verified company name.
     */
    authName?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}