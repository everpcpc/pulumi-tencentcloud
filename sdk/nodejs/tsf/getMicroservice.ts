// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tsf microservice
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const microservice = tencentcloud.Tsf.getMicroservice({
 *     namespaceId: _var.namespace_id,
 *     microserviceIdLists: ["ms-yq3jo6jd"],
 *     microserviceNameLists: ["provider-demo"],
 * });
 * ```
 */
export function getMicroservice(args: GetMicroserviceArgs, opts?: pulumi.InvokeOptions): Promise<GetMicroserviceResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Tsf/getMicroservice:getMicroservice", {
        "microserviceIdLists": args.microserviceIdLists,
        "microserviceNameLists": args.microserviceNameLists,
        "namespaceId": args.namespaceId,
        "resultOutputFile": args.resultOutputFile,
        "statuses": args.statuses,
    }, opts);
}

/**
 * A collection of arguments for invoking getMicroservice.
 */
export interface GetMicroserviceArgs {
    /**
     * microservice id list.
     */
    microserviceIdLists?: string[];
    /**
     * List of service names for search.
     */
    microserviceNameLists?: string[];
    /**
     * namespace id.
     */
    namespaceId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * status filter, online, offline, single_online.
     */
    statuses?: string[];
}

/**
 * A collection of values returned by getMicroservice.
 */
export interface GetMicroserviceResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly microserviceIdLists?: string[];
    readonly microserviceNameLists?: string[];
    /**
     * Namespace Id.  Note: This field may return null, indicating that no valid values can be obtained.
     */
    readonly namespaceId: string;
    readonly resultOutputFile?: string;
    /**
     * Microservice paging list information. Note: This field may return null, indicating that no valid value can be obtained.
     */
    readonly results: outputs.Tsf.GetMicroserviceResult[];
    readonly statuses?: string[];
}

export function getMicroserviceOutput(args: GetMicroserviceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMicroserviceResult> {
    return pulumi.output(args).apply(a => getMicroservice(a, opts))
}

/**
 * A collection of arguments for invoking getMicroservice.
 */
export interface GetMicroserviceOutputArgs {
    /**
     * microservice id list.
     */
    microserviceIdLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * List of service names for search.
     */
    microserviceNameLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * namespace id.
     */
    namespaceId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * status filter, online, offline, single_online.
     */
    statuses?: pulumi.Input<pulumi.Input<string>[]>;
}
