// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of mariadb securityGroups
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const securityGroups = pulumi.output(tencentcloud.Mariadb.getSecurityGroups({
 *     instanceId: "tdsql-4pzs5b67",
 *     product: "mariadb",
 * }));
 * ```
 */
export function getSecurityGroups(args: GetSecurityGroupsArgs, opts?: pulumi.InvokeOptions): Promise<GetSecurityGroupsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Mariadb/getSecurityGroups:getSecurityGroups", {
        "instanceId": args.instanceId,
        "product": args.product,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getSecurityGroups.
 */
export interface GetSecurityGroupsArgs {
    /**
     * instance id.
     */
    instanceId: string;
    /**
     * product name, fixed to mariadb.
     */
    product: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getSecurityGroups.
 */
export interface GetSecurityGroupsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    /**
     * SecurityGroup list.
     */
    readonly lists: outputs.Mariadb.GetSecurityGroupsList[];
    readonly product: string;
    readonly resultOutputFile?: string;
}

export function getSecurityGroupsOutput(args: GetSecurityGroupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSecurityGroupsResult> {
    return pulumi.output(args).apply(a => getSecurityGroups(a, opts))
}

/**
 * A collection of arguments for invoking getSecurityGroups.
 */
export interface GetSecurityGroupsOutputArgs {
    /**
     * instance id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * product name, fixed to mariadb.
     */
    product: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}