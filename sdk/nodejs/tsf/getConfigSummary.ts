// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tsf configSummary
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const configSummary = tencentcloud.Tsf.getConfigSummary({
 *     applicationId: "application-a24x29xv",
 *     configIdLists: ["dcfg-y54wzk3a"],
 *     disableProgramAuthCheck: true,
 *     orderBy: "last_update_time",
 *     orderType: 0,
 *     searchWord: "terraform",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getConfigSummary(args?: GetConfigSummaryArgs, opts?: pulumi.InvokeOptions): Promise<GetConfigSummaryResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tsf/getConfigSummary:getConfigSummary", {
        "applicationId": args.applicationId,
        "configIdLists": args.configIdLists,
        "configTagLists": args.configTagLists,
        "disableProgramAuthCheck": args.disableProgramAuthCheck,
        "orderBy": args.orderBy,
        "orderType": args.orderType,
        "resultOutputFile": args.resultOutputFile,
        "searchWord": args.searchWord,
    }, opts);
}

/**
 * A collection of arguments for invoking getConfigSummary.
 */
export interface GetConfigSummaryArgs {
    /**
     * Application ID. If not passed, the query will be for all.
     */
    applicationId?: string;
    /**
     * Config Id List.
     */
    configIdLists?: string[];
    /**
     * config tag list.
     */
    configTagLists?: string[];
    /**
     * Whether to disable dataset authentication.
     */
    disableProgramAuthCheck?: boolean;
    /**
     * Order term. support Sort by time: creation_time; or Sort by name: config_name.
     */
    orderBy?: string;
    /**
     * Pass 0 for ascending order and 1 for descending order.
     */
    orderType?: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Query keyword, fuzzy query: application name, configuration item name. If not passed, the query will be for all.
     */
    searchWord?: string;
}

/**
 * A collection of values returned by getConfigSummary.
 */
export interface GetConfigSummaryResult {
    /**
     * Application ID.Note: This field may return null, indicating that no valid value was found.
     */
    readonly applicationId?: string;
    readonly configIdLists?: string[];
    readonly configTagLists?: string[];
    readonly disableProgramAuthCheck?: boolean;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly orderBy?: string;
    readonly orderType?: number;
    readonly resultOutputFile?: string;
    /**
     * config Page Item.
     */
    readonly results: outputs.Tsf.GetConfigSummaryResult[];
    readonly searchWord?: string;
}
/**
 * Use this data source to query detailed information of tsf configSummary
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const configSummary = tencentcloud.Tsf.getConfigSummary({
 *     applicationId: "application-a24x29xv",
 *     configIdLists: ["dcfg-y54wzk3a"],
 *     disableProgramAuthCheck: true,
 *     orderBy: "last_update_time",
 *     orderType: 0,
 *     searchWord: "terraform",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getConfigSummaryOutput(args?: GetConfigSummaryOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetConfigSummaryResult> {
    return pulumi.output(args).apply((a: any) => getConfigSummary(a, opts))
}

/**
 * A collection of arguments for invoking getConfigSummary.
 */
export interface GetConfigSummaryOutputArgs {
    /**
     * Application ID. If not passed, the query will be for all.
     */
    applicationId?: pulumi.Input<string>;
    /**
     * Config Id List.
     */
    configIdLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * config tag list.
     */
    configTagLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Whether to disable dataset authentication.
     */
    disableProgramAuthCheck?: pulumi.Input<boolean>;
    /**
     * Order term. support Sort by time: creation_time; or Sort by name: config_name.
     */
    orderBy?: pulumi.Input<string>;
    /**
     * Pass 0 for ascending order and 1 for descending order.
     */
    orderType?: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Query keyword, fuzzy query: application name, configuration item name. If not passed, the query will be for all.
     */
    searchWord?: pulumi.Input<string>;
}