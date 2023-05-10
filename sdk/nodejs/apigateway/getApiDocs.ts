// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query list information of apiGateway api_doc
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const myApiDoc = pulumi.output(tencentcloud.ApiGateway.getApiDocs());
 * ```
 */
export function getApiDocs(args?: GetApiDocsArgs, opts?: pulumi.InvokeOptions): Promise<GetApiDocsResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:ApiGateway/getApiDocs:getApiDocs", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getApiDocs.
 */
export interface GetApiDocsArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getApiDocs.
 */
export interface GetApiDocsResult {
    /**
     * List of ApiDocs.
     */
    readonly apiDocLists: outputs.ApiGateway.GetApiDocsApiDocList[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}

export function getApiDocsOutput(args?: GetApiDocsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApiDocsResult> {
    return pulumi.output(args).apply(a => getApiDocs(a, opts))
}

/**
 * A collection of arguments for invoking getApiDocs.
 */
export interface GetApiDocsOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}