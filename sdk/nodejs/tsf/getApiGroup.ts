// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tsf apiGroup
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const apiGroup = tencentcloud.Tsf.getApiGroup({
 *     authType: "none",
 *     gatewayInstanceId: "gw-ins-lvdypq5k",
 *     groupType: "ms",
 *     orderBy: "created_time",
 *     orderType: 0,
 *     searchWord: "xxx01",
 *     status: "released",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getApiGroup(args?: GetApiGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetApiGroupResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tsf/getApiGroup:getApiGroup", {
        "authType": args.authType,
        "gatewayInstanceId": args.gatewayInstanceId,
        "groupType": args.groupType,
        "orderBy": args.orderBy,
        "orderType": args.orderType,
        "resultOutputFile": args.resultOutputFile,
        "searchWord": args.searchWord,
        "status": args.status,
    }, opts);
}

/**
 * A collection of arguments for invoking getApiGroup.
 */
export interface GetApiGroupArgs {
    /**
     * Authentication type. secret: Secret key authentication; none: No authentication.
     */
    authType?: string;
    /**
     * Gateway Instance Id.
     */
    gatewayInstanceId?: string;
    /**
     * Group type. ms: Microservice group; external: External API group.
     */
    groupType?: string;
    /**
     * Sorting field: createdTime or group_context.
     */
    orderBy?: string;
    /**
     * Sorting type: 0 (ASC) or 1 (DESC).
     */
    orderType?: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * search word.
     */
    searchWord?: string;
    /**
     * Publishing status. drafted: Not published. released: Published.
     */
    status?: string;
}

/**
 * A collection of values returned by getApiGroup.
 */
export interface GetApiGroupResult {
    /**
     * Authentication type. secret: key authentication; none: no authentication.Note: This field may return null, indicating that no valid values can be obtained.
     */
    readonly authType?: string;
    /**
     * Gateway Instance Id.Note: This field may return null, indicating that no valid values can be obtained.
     */
    readonly gatewayInstanceId?: string;
    /**
     * Group type.Note: This field may return null, indicating that no valid values can be obtained.
     */
    readonly groupType?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly orderBy?: string;
    readonly orderType?: number;
    readonly resultOutputFile?: string;
    /**
     * Pagination structure.Note: This field may return null, indicating that no valid values can be obtained.
     */
    readonly results: outputs.Tsf.GetApiGroupResult[];
    readonly searchWord?: string;
    /**
     * Release status. drafted: not released. released: released.Note: This field may return null, indicating that no valid values can be obtained.
     */
    readonly status?: string;
}
/**
 * Use this data source to query detailed information of tsf apiGroup
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const apiGroup = tencentcloud.Tsf.getApiGroup({
 *     authType: "none",
 *     gatewayInstanceId: "gw-ins-lvdypq5k",
 *     groupType: "ms",
 *     orderBy: "created_time",
 *     orderType: 0,
 *     searchWord: "xxx01",
 *     status: "released",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getApiGroupOutput(args?: GetApiGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApiGroupResult> {
    return pulumi.output(args).apply((a: any) => getApiGroup(a, opts))
}

/**
 * A collection of arguments for invoking getApiGroup.
 */
export interface GetApiGroupOutputArgs {
    /**
     * Authentication type. secret: Secret key authentication; none: No authentication.
     */
    authType?: pulumi.Input<string>;
    /**
     * Gateway Instance Id.
     */
    gatewayInstanceId?: pulumi.Input<string>;
    /**
     * Group type. ms: Microservice group; external: External API group.
     */
    groupType?: pulumi.Input<string>;
    /**
     * Sorting field: createdTime or group_context.
     */
    orderBy?: pulumi.Input<string>;
    /**
     * Sorting type: 0 (ASC) or 1 (DESC).
     */
    orderType?: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * search word.
     */
    searchWord?: pulumi.Input<string>;
    /**
     * Publishing status. drafted: Not published. released: Published.
     */
    status?: pulumi.Input<string>;
}