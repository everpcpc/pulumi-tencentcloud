// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of CLB attachments
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const clblab = pulumi.output(tencentcloud.Clb.getAttachments({
 *     clbId: "lb-k2zjp9lv",
 *     listenerId: "lbl-hh141sn9",
 *     ruleId: "loc-4xxr2cy7",
 * }));
 * ```
 */
export function getAttachments(args: GetAttachmentsArgs, opts?: pulumi.InvokeOptions): Promise<GetAttachmentsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Clb/getAttachments:getAttachments", {
        "clbId": args.clbId,
        "listenerId": args.listenerId,
        "resultOutputFile": args.resultOutputFile,
        "ruleId": args.ruleId,
    }, opts);
}

/**
 * A collection of arguments for invoking getAttachments.
 */
export interface GetAttachmentsArgs {
    /**
     * ID of the CLB to be queried.
     */
    clbId: string;
    /**
     * ID of the CLB listener to be queried.
     */
    listenerId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * ID of the CLB listener rule. If the protocol of listener is `HTTP`/`HTTPS`, this para is required.
     */
    ruleId?: string;
}

/**
 * A collection of values returned by getAttachments.
 */
export interface GetAttachmentsResult {
    /**
     * A list of cloud load balancer attachment configurations. Each element contains the following attributes:
     */
    readonly attachmentLists: outputs.Clb.GetAttachmentsAttachmentList[];
    /**
     * ID of the CLB.
     */
    readonly clbId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * ID of the CLB listener.
     */
    readonly listenerId: string;
    readonly resultOutputFile?: string;
    /**
     * ID of the CLB listener rule.
     */
    readonly ruleId?: string;
}

export function getAttachmentsOutput(args: GetAttachmentsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAttachmentsResult> {
    return pulumi.output(args).apply(a => getAttachments(a, opts))
}

/**
 * A collection of arguments for invoking getAttachments.
 */
export interface GetAttachmentsOutputArgs {
    /**
     * ID of the CLB to be queried.
     */
    clbId: pulumi.Input<string>;
    /**
     * ID of the CLB listener to be queried.
     */
    listenerId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * ID of the CLB listener rule. If the protocol of listener is `HTTP`/`HTTPS`, this para is required.
     */
    ruleId?: pulumi.Input<string>;
}