// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of kubernetes clusterAuthenticationOptions
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const clusterAuthenticationOptions = tencentcloud.Kubernetes.getClusterAuthenticationOptions({
 *     clusterId: "cls-kzilgv5m",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getClusterAuthenticationOptions(args: GetClusterAuthenticationOptionsArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterAuthenticationOptionsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Kubernetes/getClusterAuthenticationOptions:getClusterAuthenticationOptions", {
        "clusterId": args.clusterId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getClusterAuthenticationOptions.
 */
export interface GetClusterAuthenticationOptionsArgs {
    /**
     * Cluster ID.
     */
    clusterId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getClusterAuthenticationOptions.
 */
export interface GetClusterAuthenticationOptionsResult {
    readonly clusterId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Result of the last modification. Values: `Updating`, `Success`, `Failed` or `TimeOut`. Note: this field may return `null`, indicating that no valid values can be obtained.
     */
    readonly latestOperationState: string;
    /**
     * OIDC authentication configurations. Note: This field may return `null`, indicating that no valid value can be obtained.
     */
    readonly oidcConfigs: outputs.Kubernetes.GetClusterAuthenticationOptionsOidcConfig[];
    readonly resultOutputFile?: string;
    /**
     * ServiceAccount authentication configuration. Note: this field may return `null`, indicating that no valid values can be obtained.
     */
    readonly serviceAccounts: outputs.Kubernetes.GetClusterAuthenticationOptionsServiceAccount[];
}
/**
 * Use this data source to query detailed information of kubernetes clusterAuthenticationOptions
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const clusterAuthenticationOptions = tencentcloud.Kubernetes.getClusterAuthenticationOptions({
 *     clusterId: "cls-kzilgv5m",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getClusterAuthenticationOptionsOutput(args: GetClusterAuthenticationOptionsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClusterAuthenticationOptionsResult> {
    return pulumi.output(args).apply((a: any) => getClusterAuthenticationOptions(a, opts))
}

/**
 * A collection of arguments for invoking getClusterAuthenticationOptions.
 */
export interface GetClusterAuthenticationOptionsOutputArgs {
    /**
     * Cluster ID.
     */
    clusterId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}