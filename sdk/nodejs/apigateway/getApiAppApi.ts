// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of apiGateway apiAppApi
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.ApiGateway.getApiAppApi({
 *     apiId: "api-0cvmf4x4",
 *     apiRegion: "ap-guangzhou",
 *     serviceId: "service-nxz6yync",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getApiAppApi(args: GetApiAppApiArgs, opts?: pulumi.InvokeOptions): Promise<GetApiAppApiResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:ApiGateway/getApiAppApi:getApiAppApi", {
        "apiId": args.apiId,
        "apiRegion": args.apiRegion,
        "resultOutputFile": args.resultOutputFile,
        "serviceId": args.serviceId,
    }, opts);
}

/**
 * A collection of arguments for invoking getApiAppApi.
 */
export interface GetApiAppApiArgs {
    /**
     * API interface unique ID.
     */
    apiId: string;
    /**
     * Api region.
     */
    apiRegion: string;
    /**
     * Used to save apiAppApis.
     */
    resultOutputFile?: string;
    /**
     * The unique ID of the service where the API resides.
     */
    serviceId: string;
}

/**
 * A collection of values returned by getApiAppApi.
 */
export interface GetApiAppApiResult {
    /**
     * API interface unique ID.
     */
    readonly apiId: string;
    readonly apiRegion: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * API details.
     */
    readonly results: outputs.ApiGateway.GetApiAppApiResult[];
    /**
     * The unique ID of the service where the API resides.
     */
    readonly serviceId: string;
}
/**
 * Use this data source to query detailed information of apiGateway apiAppApi
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.ApiGateway.getApiAppApi({
 *     apiId: "api-0cvmf4x4",
 *     apiRegion: "ap-guangzhou",
 *     serviceId: "service-nxz6yync",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getApiAppApiOutput(args: GetApiAppApiOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApiAppApiResult> {
    return pulumi.output(args).apply((a: any) => getApiAppApi(a, opts))
}

/**
 * A collection of arguments for invoking getApiAppApi.
 */
export interface GetApiAppApiOutputArgs {
    /**
     * API interface unique ID.
     */
    apiId: pulumi.Input<string>;
    /**
     * Api region.
     */
    apiRegion: pulumi.Input<string>;
    /**
     * Used to save apiAppApis.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * The unique ID of the service where the API resides.
     */
    serviceId: pulumi.Input<string>;
}