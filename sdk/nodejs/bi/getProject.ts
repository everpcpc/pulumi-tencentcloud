// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of bi project
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const project = tencentcloud.Bi.getProject({
 *     allPage: true,
 *     keyword: "abc",
 *     moduleCollection: "sys_common_user",
 *     pageNo: 1,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getProject(args?: GetProjectArgs, opts?: pulumi.InvokeOptions): Promise<GetProjectResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Bi/getProject:getProject", {
        "allPage": args.allPage,
        "keyword": args.keyword,
        "moduleCollection": args.moduleCollection,
        "pageNo": args.pageNo,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getProject.
 */
export interface GetProjectArgs {
    /**
     * Whether to display all, if true, ignore paging.
     */
    allPage?: boolean;
    /**
     * Retrieve fuzzy fields.
     */
    keyword?: string;
    /**
     * Role information, can be ignored.
     */
    moduleCollection?: string;
    /**
     * Page number.
     */
    pageNo?: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getProject.
 */
export interface GetProjectResult {
    readonly allPage?: boolean;
    /**
     * Additional information(Note: This field may return null, indicating that no valid value can be obtained).
     */
    readonly extra: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly keyword?: string;
    /**
     * Array(Note: This field may return null, indicating that no valid value can be obtained).
     */
    readonly lists: outputs.Bi.GetProjectList[];
    readonly moduleCollection?: string;
    /**
     * Interface information(Note: This field may return null, indicating that no valid value can be obtained).
     */
    readonly msg: string;
    readonly pageNo?: number;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of bi project
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const project = tencentcloud.Bi.getProject({
 *     allPage: true,
 *     keyword: "abc",
 *     moduleCollection: "sys_common_user",
 *     pageNo: 1,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getProjectOutput(args?: GetProjectOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProjectResult> {
    return pulumi.output(args).apply((a: any) => getProject(a, opts))
}

/**
 * A collection of arguments for invoking getProject.
 */
export interface GetProjectOutputArgs {
    /**
     * Whether to display all, if true, ignore paging.
     */
    allPage?: pulumi.Input<boolean>;
    /**
     * Retrieve fuzzy fields.
     */
    keyword?: pulumi.Input<string>;
    /**
     * Role information, can be ignored.
     */
    moduleCollection?: pulumi.Input<string>;
    /**
     * Page number.
     */
    pageNo?: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}