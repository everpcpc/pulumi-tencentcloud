// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of ssl describeManagerDetail
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const describeManagerDetail = tencentcloud.Ssl.getDescribeManagerDetail({
 *     managerId: "",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDescribeManagerDetail(args: GetDescribeManagerDetailArgs, opts?: pulumi.InvokeOptions): Promise<GetDescribeManagerDetailResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Ssl/getDescribeManagerDetail:getDescribeManagerDetail", {
        "managerId": args.managerId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getDescribeManagerDetail.
 */
export interface GetDescribeManagerDetailArgs {
    /**
     * Manager ID.
     */
    managerId: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getDescribeManagerDetail.
 */
export interface GetDescribeManagerDetailResult {
    /**
     * Company ID.
     */
    readonly companyId: number;
    /**
     * Manager&amp;#39;s company information.
     */
    readonly companyInfos: outputs.Ssl.GetDescribeManagerDetailCompanyInfo[];
    /**
     * Contact name.
     */
    readonly contactFirstName: string;
    /**
     * Contact name.
     */
    readonly contactLastName: string;
    /**
     * Contact mailbox.
     */
    readonly contactMail: string;
    /**
     * contact number.
     */
    readonly contactPhone: string;
    /**
     * Contact position.
     */
    readonly contactPosition: string;
    /**
     * Creation time.
     */
    readonly createTime: string;
    /**
     * Verify expiration timeNote: This field may return NULL, indicating that the valid value cannot be obtained.
     */
    readonly expireTime: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Administrator department.
     */
    readonly managerDepartment: string;
    /**
     * Manager name.
     */
    readonly managerFirstName: string;
    readonly managerId: number;
    /**
     * Manager name.
     */
    readonly managerLastName: string;
    /**
     * Manager mailbox.
     */
    readonly managerMail: string;
    /**
     * Manager phone call.
     */
    readonly managerPhone: string;
    /**
     * Manager position.
     */
    readonly managerPosition: string;
    readonly resultOutputFile?: string;
    /**
     * Status: Audit: OK during the review: review passed inValid: expired expiRing: is about to expire Expired: expired.
     */
    readonly status: string;
    /**
     * Verify timeNote: This field may return NULL, indicating that the valid value cannot be obtained.
     */
    readonly verifyTime: string;
}
/**
 * Use this data source to query detailed information of ssl describeManagerDetail
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const describeManagerDetail = tencentcloud.Ssl.getDescribeManagerDetail({
 *     managerId: "",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDescribeManagerDetailOutput(args: GetDescribeManagerDetailOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDescribeManagerDetailResult> {
    return pulumi.output(args).apply((a: any) => getDescribeManagerDetail(a, opts))
}

/**
 * A collection of arguments for invoking getDescribeManagerDetail.
 */
export interface GetDescribeManagerDetailOutputArgs {
    /**
     * Manager ID.
     */
    managerId: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}