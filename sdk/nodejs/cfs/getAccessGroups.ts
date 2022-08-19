// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query the detail information of CFS access group.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const accessGroups = pulumi.output(tencentcloud.Cfs.getAccessGroups({
 *     accessGroupId: "pgroup-7nx89k7l",
 *     name: "test",
 * }));
 * ```
 */
export function getAccessGroups(args?: GetAccessGroupsArgs, opts?: pulumi.InvokeOptions): Promise<GetAccessGroupsResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Cfs/getAccessGroups:getAccessGroups", {
        "accessGroupId": args.accessGroupId,
        "name": args.name,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccessGroups.
 */
export interface GetAccessGroupsArgs {
    /**
     * A specified access group ID used to query.
     */
    accessGroupId?: string;
    /**
     * A access group Name used to query.
     */
    name?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getAccessGroups.
 */
export interface GetAccessGroupsResult {
    /**
     * ID of the access group.
     */
    readonly accessGroupId?: string;
    /**
     * An information list of CFS access group. Each element contains the following attributes:
     */
    readonly accessGroupLists: outputs.Cfs.GetAccessGroupsAccessGroupList[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Name of the access group.
     */
    readonly name?: string;
    readonly resultOutputFile?: string;
}

export function getAccessGroupsOutput(args?: GetAccessGroupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAccessGroupsResult> {
    return pulumi.output(args).apply(a => getAccessGroups(a, opts))
}

/**
 * A collection of arguments for invoking getAccessGroups.
 */
export interface GetAccessGroupsOutputArgs {
    /**
     * A specified access group ID used to query.
     */
    accessGroupId?: pulumi.Input<string>;
    /**
     * A access group Name used to query.
     */
    name?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}