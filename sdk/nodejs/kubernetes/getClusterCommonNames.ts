// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Provide a datasource to query cluster CommonNames.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = pulumi.output(tencentcloud.Kubernetes.getClusterCommonNames({
 *     clusterId: "cls-12345678",
 *     subaccountUins: [
 *         "1234567890",
 *         "0987654321",
 *     ],
 * }));
 * ```
 */
export function getClusterCommonNames(args?: GetClusterCommonNamesArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterCommonNamesResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Kubernetes/getClusterCommonNames:getClusterCommonNames", {
        "clusterId": args.clusterId,
        "resultOutputFile": args.resultOutputFile,
        "roleIds": args.roleIds,
        "subaccountUins": args.subaccountUins,
    }, opts);
}

/**
 * A collection of arguments for invoking getClusterCommonNames.
 */
export interface GetClusterCommonNamesArgs {
    /**
     * Cluster ID.
     */
    clusterId?: string;
    /**
     * Used for save result.
     */
    resultOutputFile?: string;
    /**
     * List of Role ID. Up to 50 sub-accounts can be passed in at a time.
     */
    roleIds?: string[];
    /**
     * List of sub-account. Up to 50 sub-accounts can be passed in at a time.
     */
    subaccountUins?: string[];
}

/**
 * A collection of values returned by getClusterCommonNames.
 */
export interface GetClusterCommonNamesResult {
    readonly clusterId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * List of the CommonName in the certificate of the client corresponding to the sub-account UIN.
     */
    readonly lists: outputs.Kubernetes.GetClusterCommonNamesList[];
    readonly resultOutputFile?: string;
    readonly roleIds?: string[];
    readonly subaccountUins?: string[];
}

export function getClusterCommonNamesOutput(args?: GetClusterCommonNamesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClusterCommonNamesResult> {
    return pulumi.output(args).apply(a => getClusterCommonNames(a, opts))
}

/**
 * A collection of arguments for invoking getClusterCommonNames.
 */
export interface GetClusterCommonNamesOutputArgs {
    /**
     * Cluster ID.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * Used for save result.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * List of Role ID. Up to 50 sub-accounts can be passed in at a time.
     */
    roleIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * List of sub-account. Up to 50 sub-accounts can be passed in at a time.
     */
    subaccountUins?: pulumi.Input<pulumi.Input<string>[]>;
}