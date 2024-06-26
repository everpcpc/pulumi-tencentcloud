// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of dlc describeDataEnginePythonSparkImages
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const describeDataEnginePythonSparkImages = pulumi.output(tencentcloud.Dlc.getDescribeDataEnginePythonSparkImages({
 *     childImageVersionId: "d3ftghd4-9a7e-4f64-a3f4-f38507c69742",
 * }));
 * ```
 */
export function getDescribeDataEnginePythonSparkImages(args: GetDescribeDataEnginePythonSparkImagesArgs, opts?: pulumi.InvokeOptions): Promise<GetDescribeDataEnginePythonSparkImagesResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Dlc/getDescribeDataEnginePythonSparkImages:getDescribeDataEnginePythonSparkImages", {
        "childImageVersionId": args.childImageVersionId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getDescribeDataEnginePythonSparkImages.
 */
export interface GetDescribeDataEnginePythonSparkImagesArgs {
    /**
     * Engine Image version id.
     */
    childImageVersionId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getDescribeDataEnginePythonSparkImages.
 */
export interface GetDescribeDataEnginePythonSparkImagesResult {
    /**
     * Engine Image version id.
     */
    readonly childImageVersionId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Pyspark image list.
     */
    readonly pythonSparkImages: outputs.Dlc.GetDescribeDataEnginePythonSparkImagesPythonSparkImage[];
    readonly resultOutputFile?: string;
}

export function getDescribeDataEnginePythonSparkImagesOutput(args: GetDescribeDataEnginePythonSparkImagesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDescribeDataEnginePythonSparkImagesResult> {
    return pulumi.output(args).apply(a => getDescribeDataEnginePythonSparkImages(a, opts))
}

/**
 * A collection of arguments for invoking getDescribeDataEnginePythonSparkImages.
 */
export interface GetDescribeDataEnginePythonSparkImagesOutputArgs {
    /**
     * Engine Image version id.
     */
    childImageVersionId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
