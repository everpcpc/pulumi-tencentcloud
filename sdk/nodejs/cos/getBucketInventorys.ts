// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query the COS bucket inventorys.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const cosBucketInventorys = pulumi.output(tencentcloud.Cos.getBucketInventorys({
 *     bucket: "xxxxxx",
 * }));
 * ```
 */
export function getBucketInventorys(args: GetBucketInventorysArgs, opts?: pulumi.InvokeOptions): Promise<GetBucketInventorysResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Cos/getBucketInventorys:getBucketInventorys", {
        "bucket": args.bucket,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getBucketInventorys.
 */
export interface GetBucketInventorysArgs {
    /**
     * Bucket.
     */
    bucket: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getBucketInventorys.
 */
export interface GetBucketInventorysResult {
    /**
     * Bucket name.
     */
    readonly bucket: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Multiple batch processing task information.
     */
    readonly inventorys: outputs.Cos.GetBucketInventorysInventory[];
    readonly resultOutputFile?: string;
}

export function getBucketInventorysOutput(args: GetBucketInventorysOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetBucketInventorysResult> {
    return pulumi.output(args).apply(a => getBucketInventorys(a, opts))
}

/**
 * A collection of arguments for invoking getBucketInventorys.
 */
export interface GetBucketInventorysOutputArgs {
    /**
     * Bucket.
     */
    bucket: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
