// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of cynosdb accountAllGrantPrivileges
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const accountAllGrantPrivileges = tencentcloud.Cynosdb.getAccountAllGrantPrivileges({
 *     account: {
 *         accountName: "keep_dts",
 *         host: "%",
 *     },
 *     clusterId: "cynosdbmysql-bws8h88b",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAccountAllGrantPrivileges(args: GetAccountAllGrantPrivilegesArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountAllGrantPrivilegesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Cynosdb/getAccountAllGrantPrivileges:getAccountAllGrantPrivileges", {
        "account": args.account,
        "clusterId": args.clusterId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccountAllGrantPrivileges.
 */
export interface GetAccountAllGrantPrivilegesArgs {
    /**
     * account information.
     */
    account: inputs.Cynosdb.GetAccountAllGrantPrivilegesAccount;
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
 * A collection of values returned by getAccountAllGrantPrivileges.
 */
export interface GetAccountAllGrantPrivilegesResult {
    readonly account: outputs.Cynosdb.GetAccountAllGrantPrivilegesAccount;
    readonly clusterId: string;
    /**
     * Database permissions note: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly databasePrivileges: outputs.Cynosdb.GetAccountAllGrantPrivilegesDatabasePrivilege[];
    /**
     * Global permission note: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly globalPrivileges: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Permission statement note: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly privilegeStatements: string[];
    readonly resultOutputFile?: string;
    /**
     * Database table permissions note: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly tablePrivileges: outputs.Cynosdb.GetAccountAllGrantPrivilegesTablePrivilege[];
}
/**
 * Use this data source to query detailed information of cynosdb accountAllGrantPrivileges
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const accountAllGrantPrivileges = tencentcloud.Cynosdb.getAccountAllGrantPrivileges({
 *     account: {
 *         accountName: "keep_dts",
 *         host: "%",
 *     },
 *     clusterId: "cynosdbmysql-bws8h88b",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAccountAllGrantPrivilegesOutput(args: GetAccountAllGrantPrivilegesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAccountAllGrantPrivilegesResult> {
    return pulumi.output(args).apply((a: any) => getAccountAllGrantPrivileges(a, opts))
}

/**
 * A collection of arguments for invoking getAccountAllGrantPrivileges.
 */
export interface GetAccountAllGrantPrivilegesOutputArgs {
    /**
     * account information.
     */
    account: pulumi.Input<inputs.Cynosdb.GetAccountAllGrantPrivilegesAccountArgs>;
    /**
     * Cluster ID.
     */
    clusterId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
