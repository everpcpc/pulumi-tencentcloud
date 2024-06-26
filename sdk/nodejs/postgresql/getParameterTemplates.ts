// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of postgresql parameterTemplates
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const parameterTemplates = pulumi.output(tencentcloud.Postgresql.getParameterTemplates({
 *     filters: [
 *         {
 *             name: "TemplateName",
 *             values: ["temp_name"],
 *         },
 *         {
 *             name: "DBEngine",
 *             values: ["postgresql"],
 *         },
 *     ],
 *     orderBy: "CreateTime",
 *     orderByType: "desc",
 * }));
 * ```
 */
export function getParameterTemplates(args?: GetParameterTemplatesArgs, opts?: pulumi.InvokeOptions): Promise<GetParameterTemplatesResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Postgresql/getParameterTemplates:getParameterTemplates", {
        "filters": args.filters,
        "orderBy": args.orderBy,
        "orderByType": args.orderByType,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getParameterTemplates.
 */
export interface GetParameterTemplatesArgs {
    /**
     * Filter conditions. Valid values:TemplateName, TemplateId, DBMajorVersion, DBEngine.
     */
    filters?: inputs.Postgresql.GetParameterTemplatesFilter[];
    /**
     * Sorting metric. Valid values:CreateTime, TemplateName, DBMajorVersion.
     */
    orderBy?: string;
    /**
     * Sorting order. Valid values:asc (ascending order),desc (descending order).
     */
    orderByType?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getParameterTemplates.
 */
export interface GetParameterTemplatesResult {
    readonly filters?: outputs.Postgresql.GetParameterTemplatesFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * list of parameter templates.
     */
    readonly lists: outputs.Postgresql.GetParameterTemplatesList[];
    readonly orderBy?: string;
    readonly orderByType?: string;
    readonly resultOutputFile?: string;
}

export function getParameterTemplatesOutput(args?: GetParameterTemplatesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetParameterTemplatesResult> {
    return pulumi.output(args).apply(a => getParameterTemplates(a, opts))
}

/**
 * A collection of arguments for invoking getParameterTemplates.
 */
export interface GetParameterTemplatesOutputArgs {
    /**
     * Filter conditions. Valid values:TemplateName, TemplateId, DBMajorVersion, DBEngine.
     */
    filters?: pulumi.Input<pulumi.Input<inputs.Postgresql.GetParameterTemplatesFilterArgs>[]>;
    /**
     * Sorting metric. Valid values:CreateTime, TemplateName, DBMajorVersion.
     */
    orderBy?: pulumi.Input<string>;
    /**
     * Sorting order. Valid values:asc (ascending order),desc (descending order).
     */
    orderByType?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
