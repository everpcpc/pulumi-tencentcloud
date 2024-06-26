// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of ckafka datahubTask
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const datahubTask = pulumi.output(tencentcloud.Ckafka.getDatahubTask());
 * ```
 */
export function getDatahubTask(args?: GetDatahubTaskArgs, opts?: pulumi.InvokeOptions): Promise<GetDatahubTaskResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Ckafka/getDatahubTask:getDatahubTask", {
        "resource": args.resource,
        "resultOutputFile": args.resultOutputFile,
        "searchWord": args.searchWord,
        "sourceType": args.sourceType,
        "targetType": args.targetType,
        "taskType": args.taskType,
    }, opts);
}

/**
 * A collection of arguments for invoking getDatahubTask.
 */
export interface GetDatahubTaskArgs {
    /**
     * Resource.
     */
    resource?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * search key.
     */
    searchWord?: string;
    /**
     * The source type.
     */
    sourceType?: string;
    /**
     * Destination type of dump.
     */
    targetType?: string;
    /**
     * Task type, SOURCE|SINK.
     */
    taskType?: string;
}

/**
 * A collection of values returned by getDatahubTask.
 */
export interface GetDatahubTaskResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The topic name of the topic sold separately.
     */
    readonly resource?: string;
    readonly resultOutputFile?: string;
    readonly searchWord?: string;
    readonly sourceType?: string;
    readonly targetType?: string;
    /**
     * Datahub task information list.
     */
    readonly taskLists: outputs.Ckafka.GetDatahubTaskTaskList[];
    /**
     * TaskType, SOURCE|SINK.
     */
    readonly taskType?: string;
}

export function getDatahubTaskOutput(args?: GetDatahubTaskOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDatahubTaskResult> {
    return pulumi.output(args).apply(a => getDatahubTask(a, opts))
}

/**
 * A collection of arguments for invoking getDatahubTask.
 */
export interface GetDatahubTaskOutputArgs {
    /**
     * Resource.
     */
    resource?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * search key.
     */
    searchWord?: pulumi.Input<string>;
    /**
     * The source type.
     */
    sourceType?: pulumi.Input<string>;
    /**
     * Destination type of dump.
     */
    targetType?: pulumi.Input<string>;
    /**
     * Task type, SOURCE|SINK.
     */
    taskType?: pulumi.Input<string>;
}
