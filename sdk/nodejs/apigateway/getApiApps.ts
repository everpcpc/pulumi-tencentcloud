// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query list information of apiGateway api_app
 */
export function getApiApps(args?: GetApiAppsArgs, opts?: pulumi.InvokeOptions): Promise<GetApiAppsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:ApiGateway/getApiApps:getApiApps", {
        "apiAppId": args.apiAppId,
        "apiAppName": args.apiAppName,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getApiApps.
 */
export interface GetApiAppsArgs {
    /**
     * Api app ID.
     */
    apiAppId?: string;
    /**
     * Api app name.
     */
    apiAppName?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getApiApps.
 */
export interface GetApiAppsResult {
    /**
     * ApiApp ID.
     */
    readonly apiAppId?: string;
    /**
     * List of ApiApp.
     */
    readonly apiAppLists: outputs.ApiGateway.GetApiAppsApiAppList[];
    /**
     * ApiApp Name.
     */
    readonly apiAppName?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query list information of apiGateway api_app
 */
export function getApiAppsOutput(args?: GetApiAppsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApiAppsResult> {
    return pulumi.output(args).apply((a: any) => getApiApps(a, opts))
}

/**
 * A collection of arguments for invoking getApiApps.
 */
export interface GetApiAppsOutputArgs {
    /**
     * Api app ID.
     */
    apiAppId?: pulumi.Input<string>;
    /**
     * Api app name.
     */
    apiAppName?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
