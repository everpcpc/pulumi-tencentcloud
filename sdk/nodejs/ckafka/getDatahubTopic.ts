// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of ckafka datahubTopic
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const datahubTopic = tencentcloud.Ckafka.getDatahubTopic({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDatahubTopic(args?: GetDatahubTopicArgs, opts?: pulumi.InvokeOptions): Promise<GetDatahubTopicResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Ckafka/getDatahubTopic:getDatahubTopic", {
        "limit": args.limit,
        "offset": args.offset,
        "resultOutputFile": args.resultOutputFile,
        "searchWord": args.searchWord,
    }, opts);
}

/**
 * A collection of arguments for invoking getDatahubTopic.
 */
export interface GetDatahubTopicArgs {
    /**
     * The maximum number of results returned this time, the default is 50, and the maximum value is 50.
     */
    limit?: number;
    /**
     * The offset position of this query, the default is 0.
     */
    offset?: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * query key word.
     */
    searchWord?: string;
}

/**
 * A collection of values returned by getDatahubTopic.
 */
export interface GetDatahubTopicResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly limit?: number;
    readonly offset?: number;
    readonly resultOutputFile?: string;
    readonly searchWord?: string;
    /**
     * Topic list.
     */
    readonly topicLists: outputs.Ckafka.GetDatahubTopicTopicList[];
}
/**
 * Use this data source to query detailed information of ckafka datahubTopic
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const datahubTopic = tencentcloud.Ckafka.getDatahubTopic({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDatahubTopicOutput(args?: GetDatahubTopicOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDatahubTopicResult> {
    return pulumi.output(args).apply((a: any) => getDatahubTopic(a, opts))
}

/**
 * A collection of arguments for invoking getDatahubTopic.
 */
export interface GetDatahubTopicOutputArgs {
    /**
     * The maximum number of results returned this time, the default is 50, and the maximum value is 50.
     */
    limit?: pulumi.Input<number>;
    /**
     * The offset position of this query, the default is 0.
     */
    offset?: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * query key word.
     */
    searchWord?: pulumi.Input<string>;
}
