// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of dnspod recordList
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const recordList = tencentcloud.Dnspod.getRecordList({
 *     domain: "iac-tf.cloud",
 *     groupIds: [],
 *     isExactSubDomain: true,
 *     keyword: "",
 *     mxBegin: 0,
 *     mxEnd: 10,
 *     recordStatuses: ["ENABLE"],
 *     recordTypes: [
 *         "A",
 *         "NS",
 *         "CNAME",
 *         "NS",
 *         "AAAA",
 *     ],
 *     recordValue: "bicycle.dnspod.net",
 *     remark: "",
 *     sortField: "UPDATED_ON",
 *     sortType: "DESC",
 *     ttlBegin: 1,
 *     ttlEnd: 864000,
 *     updatedAtBegin: "2021-09-07",
 *     updatedAtEnd: "2023-12-07",
 *     weightBegin: 0,
 *     weightEnd: 100,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getRecordList(args: GetRecordListArgs, opts?: pulumi.InvokeOptions): Promise<GetRecordListResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Dnspod/getRecordList:getRecordList", {
        "domain": args.domain,
        "domainId": args.domainId,
        "groupIds": args.groupIds,
        "isExactSubDomain": args.isExactSubDomain,
        "keyword": args.keyword,
        "mxBegin": args.mxBegin,
        "mxEnd": args.mxEnd,
        "projectId": args.projectId,
        "recordLines": args.recordLines,
        "recordStatuses": args.recordStatuses,
        "recordTypes": args.recordTypes,
        "recordValue": args.recordValue,
        "remark": args.remark,
        "resultOutputFile": args.resultOutputFile,
        "sortField": args.sortField,
        "sortType": args.sortType,
        "subDomain": args.subDomain,
        "ttlBegin": args.ttlBegin,
        "ttlEnd": args.ttlEnd,
        "updatedAtBegin": args.updatedAtBegin,
        "updatedAtEnd": args.updatedAtEnd,
        "weightBegin": args.weightBegin,
        "weightEnd": args.weightEnd,
    }, opts);
}

/**
 * A collection of arguments for invoking getRecordList.
 */
export interface GetRecordListArgs {
    /**
     * The domain to which the resolution record belongs.
     */
    domain: string;
    /**
     * The domain ID to which the resolution record belongs. If DomainId is provided, the system will ignore the Domain parameter. You can find all Domain and DomainId through the DescribeDomainList interface.
     */
    domainId?: number;
    /**
     * When retrieving resolution records under certain groups, pass this group ID. You can obtain the GroupId field through the DescribeRecordGroupList interface.
     */
    groupIds?: number[];
    /**
     * Whether to perform an exact search based on the SubDomain parameter.
     */
    isExactSubDomain?: boolean;
    /**
     * Search for resolution records by keyword, currently supporting searching host headers and record values.
     */
    keyword?: string;
    /**
     * The starting point of the resolution record MX priority query interval.
     */
    mxBegin?: number;
    /**
     * The endpoint of the resolution record MX priority query interval.
     */
    mxEnd?: number;
    /**
     * Project ID.
     */
    projectId?: number;
    /**
     * Retrieve resolution records for certain line IDs. You can view the allowed line information for the current domain through the DescribeRecordLineList interface.
     */
    recordLines?: string[];
    /**
     * Get the resolution record based on the resolution record status. The possible values are ENABLE and DISABLE. ENABLE: Normal DISABLE: Paused.
     */
    recordStatuses?: string[];
    /**
     * Retrieve certain types of resolution records, such as A, CNAME, NS, AAAA, explicit URL, implicit URL, CAA, SPF, etc.
     */
    recordTypes?: string[];
    /**
     * Get the resolution record based on the resolution record value.
     */
    recordValue?: string;
    /**
     * Get the resolution record based on the resolution record remark.
     */
    remark?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Sorting field, supporting NAME, LINE, TYPE, VALUE, WEIGHT, MX, TTL, UPDATED_ON fields. NAME: The host header of the resolution record LINE: The resolution record line TYPE: The resolution record type VALUE: The resolution record value WEIGHT: The weight MX: MX priority TTL: The resolution record cache time UPDATED_ON: The resolution record update time.
     */
    sortField?: string;
    /**
     * Sorting method, ascending: ASC, descending: DESC. The default value is ASC.
     */
    sortType?: string;
    /**
     * Retrieve resolution records based on the host header of the resolution record. Fuzzy matching is used by default. You can set the IsExactSubdomain parameter to true for precise searching.
     */
    subDomain?: string;
    /**
     * The starting point of the resolution record TTL query interval.
     */
    ttlBegin?: number;
    /**
     * The endpoint of the resolution record TTL query interval.
     */
    ttlEnd?: number;
    /**
     * The starting point of the resolution record update time query interval.
     */
    updatedAtBegin?: string;
    /**
     * The endpoint of the resolution record update time query interval.
     */
    updatedAtEnd?: string;
    /**
     * The starting point of the resolution record weight query interval.
     */
    weightBegin?: number;
    /**
     * The endpoint of the resolution record weight query interval.
     */
    weightEnd?: number;
}

/**
 * A collection of values returned by getRecordList.
 */
export interface GetRecordListResult {
    readonly domain: string;
    readonly domainId?: number;
    readonly groupIds?: number[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly isExactSubDomain?: boolean;
    readonly keyword?: string;
    readonly mxBegin?: number;
    readonly mxEnd?: number;
    readonly projectId?: number;
    /**
     * Statistics of the number of records.
     */
    readonly recordCountInfos: outputs.Dnspod.GetRecordListRecordCountInfo[];
    readonly recordLines?: string[];
    /**
     * List of records.
     */
    readonly recordLists: outputs.Dnspod.GetRecordListRecordList[];
    readonly recordStatuses?: string[];
    readonly recordTypes?: string[];
    readonly recordValue?: string;
    /**
     * Record remark description.
     */
    readonly remark?: string;
    readonly resultOutputFile?: string;
    readonly sortField?: string;
    readonly sortType?: string;
    readonly subDomain?: string;
    readonly ttlBegin?: number;
    readonly ttlEnd?: number;
    readonly updatedAtBegin?: string;
    readonly updatedAtEnd?: string;
    readonly weightBegin?: number;
    readonly weightEnd?: number;
}
/**
 * Use this data source to query detailed information of dnspod recordList
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const recordList = tencentcloud.Dnspod.getRecordList({
 *     domain: "iac-tf.cloud",
 *     groupIds: [],
 *     isExactSubDomain: true,
 *     keyword: "",
 *     mxBegin: 0,
 *     mxEnd: 10,
 *     recordStatuses: ["ENABLE"],
 *     recordTypes: [
 *         "A",
 *         "NS",
 *         "CNAME",
 *         "NS",
 *         "AAAA",
 *     ],
 *     recordValue: "bicycle.dnspod.net",
 *     remark: "",
 *     sortField: "UPDATED_ON",
 *     sortType: "DESC",
 *     ttlBegin: 1,
 *     ttlEnd: 864000,
 *     updatedAtBegin: "2021-09-07",
 *     updatedAtEnd: "2023-12-07",
 *     weightBegin: 0,
 *     weightEnd: 100,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getRecordListOutput(args: GetRecordListOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRecordListResult> {
    return pulumi.output(args).apply((a: any) => getRecordList(a, opts))
}

/**
 * A collection of arguments for invoking getRecordList.
 */
export interface GetRecordListOutputArgs {
    /**
     * The domain to which the resolution record belongs.
     */
    domain: pulumi.Input<string>;
    /**
     * The domain ID to which the resolution record belongs. If DomainId is provided, the system will ignore the Domain parameter. You can find all Domain and DomainId through the DescribeDomainList interface.
     */
    domainId?: pulumi.Input<number>;
    /**
     * When retrieving resolution records under certain groups, pass this group ID. You can obtain the GroupId field through the DescribeRecordGroupList interface.
     */
    groupIds?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Whether to perform an exact search based on the SubDomain parameter.
     */
    isExactSubDomain?: pulumi.Input<boolean>;
    /**
     * Search for resolution records by keyword, currently supporting searching host headers and record values.
     */
    keyword?: pulumi.Input<string>;
    /**
     * The starting point of the resolution record MX priority query interval.
     */
    mxBegin?: pulumi.Input<number>;
    /**
     * The endpoint of the resolution record MX priority query interval.
     */
    mxEnd?: pulumi.Input<number>;
    /**
     * Project ID.
     */
    projectId?: pulumi.Input<number>;
    /**
     * Retrieve resolution records for certain line IDs. You can view the allowed line information for the current domain through the DescribeRecordLineList interface.
     */
    recordLines?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Get the resolution record based on the resolution record status. The possible values are ENABLE and DISABLE. ENABLE: Normal DISABLE: Paused.
     */
    recordStatuses?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Retrieve certain types of resolution records, such as A, CNAME, NS, AAAA, explicit URL, implicit URL, CAA, SPF, etc.
     */
    recordTypes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Get the resolution record based on the resolution record value.
     */
    recordValue?: pulumi.Input<string>;
    /**
     * Get the resolution record based on the resolution record remark.
     */
    remark?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Sorting field, supporting NAME, LINE, TYPE, VALUE, WEIGHT, MX, TTL, UPDATED_ON fields. NAME: The host header of the resolution record LINE: The resolution record line TYPE: The resolution record type VALUE: The resolution record value WEIGHT: The weight MX: MX priority TTL: The resolution record cache time UPDATED_ON: The resolution record update time.
     */
    sortField?: pulumi.Input<string>;
    /**
     * Sorting method, ascending: ASC, descending: DESC. The default value is ASC.
     */
    sortType?: pulumi.Input<string>;
    /**
     * Retrieve resolution records based on the host header of the resolution record. Fuzzy matching is used by default. You can set the IsExactSubdomain parameter to true for precise searching.
     */
    subDomain?: pulumi.Input<string>;
    /**
     * The starting point of the resolution record TTL query interval.
     */
    ttlBegin?: pulumi.Input<number>;
    /**
     * The endpoint of the resolution record TTL query interval.
     */
    ttlEnd?: pulumi.Input<number>;
    /**
     * The starting point of the resolution record update time query interval.
     */
    updatedAtBegin?: pulumi.Input<string>;
    /**
     * The endpoint of the resolution record update time query interval.
     */
    updatedAtEnd?: pulumi.Input<string>;
    /**
     * The starting point of the resolution record weight query interval.
     */
    weightBegin?: pulumi.Input<number>;
    /**
     * The endpoint of the resolution record weight query interval.
     */
    weightEnd?: pulumi.Input<number>;
}