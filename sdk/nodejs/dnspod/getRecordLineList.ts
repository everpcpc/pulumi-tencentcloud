// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of dnspod recordLineList
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const recordLineList = tencentcloud.Dnspod.getRecordLineList({
 *     domain: "iac-tf.cloud",
 *     domainGrade: "DP_FREE",
 *     domainId: 123,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getRecordLineList(args: GetRecordLineListArgs, opts?: pulumi.InvokeOptions): Promise<GetRecordLineListResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Dnspod/getRecordLineList:getRecordLineList", {
        "domain": args.domain,
        "domainGrade": args.domainGrade,
        "domainId": args.domainId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getRecordLineList.
 */
export interface GetRecordLineListArgs {
    /**
     * Domain.
     */
    domain: string;
    /**
     * Domain level. + Old packages: D_FREE, D_PLUS, D_EXTRA, D_EXPERT, D_ULTRA correspond to free package, personal luxury, enterprise 1, enterprise 2, enterprise 3. + New packages: DP_FREE, DP_PLUS, DP_EXTRA, DP_EXPERT, DP_ULTRA correspond to new free, personal professional, enterprise basic, enterprise standard, enterprise flagship.
     */
    domainGrade: string;
    /**
     * Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
     */
    domainId?: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getRecordLineList.
 */
export interface GetRecordLineListResult {
    readonly domain: string;
    readonly domainGrade: string;
    readonly domainId?: number;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Line group list.
     */
    readonly lineGroupLists: outputs.Dnspod.GetRecordLineListLineGroupList[];
    /**
     * Line list.
     */
    readonly lineLists: outputs.Dnspod.GetRecordLineListLineList[];
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of dnspod recordLineList
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const recordLineList = tencentcloud.Dnspod.getRecordLineList({
 *     domain: "iac-tf.cloud",
 *     domainGrade: "DP_FREE",
 *     domainId: 123,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getRecordLineListOutput(args: GetRecordLineListOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRecordLineListResult> {
    return pulumi.output(args).apply((a: any) => getRecordLineList(a, opts))
}

/**
 * A collection of arguments for invoking getRecordLineList.
 */
export interface GetRecordLineListOutputArgs {
    /**
     * Domain.
     */
    domain: pulumi.Input<string>;
    /**
     * Domain level. + Old packages: D_FREE, D_PLUS, D_EXTRA, D_EXPERT, D_ULTRA correspond to free package, personal luxury, enterprise 1, enterprise 2, enterprise 3. + New packages: DP_FREE, DP_PLUS, DP_EXTRA, DP_EXPERT, DP_ULTRA correspond to new free, personal professional, enterprise basic, enterprise standard, enterprise flagship.
     */
    domainGrade: pulumi.Input<string>;
    /**
     * Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
     */
    domainId?: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}