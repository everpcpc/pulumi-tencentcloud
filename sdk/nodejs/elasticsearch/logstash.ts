// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a elasticsearch logstash
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const logstash = new tencentcloud.elasticsearch.Logstash("logstash", {
 *     chargeType: "POSTPAID_BY_HOUR",
 *     diskSize: 20,
 *     diskType: "CLOUD_SSD",
 *     instanceName: "logstash-test",
 *     licenseType: "xpack",
 *     logstashVersion: "7.14.2",
 *     nodeNum: 1,
 *     nodeType: "LOGSTASH.SA2.MEDIUM4",
 *     operationDuration: {
 *         periods: [
 *             1,
 *             2,
 *             3,
 *             4,
 *             5,
 *             6,
 *             0,
 *         ],
 *         timeEnd: "06:00",
 *         timeStart: "02:00",
 *         timeZone: "UTC+8",
 *     },
 *     subnetId: "subnet-4o0zd840",
 *     tags: {
 *         tagKey: "tagValue",
 *     },
 *     vpcId: "vpc-4owdpnwr",
 *     zone: "ap-guangzhou-6",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * elasticsearch logstash can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Elasticsearch/logstash:Logstash logstash logstash_id
 * ```
 */
export class Logstash extends pulumi.CustomResource {
    /**
     * Get an existing Logstash resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LogstashState, opts?: pulumi.CustomResourceOptions): Logstash {
        return new Logstash(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Elasticsearch/logstash:Logstash';

    /**
     * Returns true if the given object is an instance of Logstash.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Logstash {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Logstash.__pulumiType;
    }

    /**
     * whether to use voucher auto, 1 when use, else 0.
     */
    public readonly autoVoucher!: pulumi.Output<number | undefined>;
    /**
     * Period when charged by months or years(unit depends on TimeUnit).
     */
    public readonly chargePeriod!: pulumi.Output<number | undefined>;
    /**
     * Charge type. PREPAID: charged by months or years; POSTPAID_BY_HOUR: charged by hours; default vaule: POSTPAID_BY_HOUR.
     */
    public readonly chargeType!: pulumi.Output<string | undefined>;
    /**
     * node disk size (unit GB).
     */
    public readonly diskSize!: pulumi.Output<number | undefined>;
    /**
     * Disk type. CLOUD_SSD: SSD cloud disk; CLOUD_PREMIUM: high hard energy cloud disk; default: CLOUD_SSD.
     */
    public readonly diskType!: pulumi.Output<string | undefined>;
    /**
     * Instance name (compose of 1-50 letter, number, - or _).
     */
    public readonly instanceName!: pulumi.Output<string>;
    /**
     * License type. oss: open source version; xpack:xpack version; default: xpack.
     */
    public readonly licenseType!: pulumi.Output<string | undefined>;
    /**
     * Instance version(6.8.13, 7.10.1).
     */
    public readonly logstashVersion!: pulumi.Output<string>;
    /**
     * Node num(range 2-50).
     */
    public readonly nodeNum!: pulumi.Output<number | undefined>;
    /**
     * Node type. Valid values:
     * - LOGSTASH.S1.SMALL2: 1 core 2G;
     * - LOGSTASH.S1.MEDIUM4:2 core 4G;
     * - LOGSTASH.S1.MEDIUM8:2 core 8G;
     * - LOGSTASH.S1.LARGE16:4 core 16G;
     * - LOGSTASH.S1.2XLARGE32:8 core 32G;
     * - LOGSTASH.S1.4XLARGE32:16 core 32G;
     * - LOGSTASH.S1.4XLARGE64:16 core 64G.
     */
    public readonly nodeType!: pulumi.Output<string | undefined>;
    /**
     * operation time by tencent clound.
     */
    public readonly operationDuration!: pulumi.Output<outputs.Elasticsearch.LogstashOperationDuration | undefined>;
    /**
     * Automatic renewal flag. RENEW_FLAG_AUTO: auto renewal; RENEW_FLAG_MANUAL: do not renew automatically, users renew manually. It needs to be set when ChargeType is PREPAID. If this parameter is not passed, ordinary users will not renew automatically by default, and SVIP users will renew automatically.
     */
    public readonly renewFlag!: pulumi.Output<string | undefined>;
    /**
     * Subnet id.
     */
    public readonly subnetId!: pulumi.Output<string>;
    /**
     * Tag description list.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any}>;
    /**
     * charge time unit(set when ChargeType is PREPAID, default value: ms).
     */
    public readonly timeUnit!: pulumi.Output<string | undefined>;
    /**
     * Voucher list(only can use one voucher by now).
     */
    public readonly voucherIds!: pulumi.Output<string[] | undefined>;
    /**
     * VPC id.
     */
    public readonly vpcId!: pulumi.Output<string>;
    /**
     * Available zone.
     */
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a Logstash resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LogstashArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LogstashArgs | LogstashState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as LogstashState | undefined;
            resourceInputs["autoVoucher"] = state ? state.autoVoucher : undefined;
            resourceInputs["chargePeriod"] = state ? state.chargePeriod : undefined;
            resourceInputs["chargeType"] = state ? state.chargeType : undefined;
            resourceInputs["diskSize"] = state ? state.diskSize : undefined;
            resourceInputs["diskType"] = state ? state.diskType : undefined;
            resourceInputs["instanceName"] = state ? state.instanceName : undefined;
            resourceInputs["licenseType"] = state ? state.licenseType : undefined;
            resourceInputs["logstashVersion"] = state ? state.logstashVersion : undefined;
            resourceInputs["nodeNum"] = state ? state.nodeNum : undefined;
            resourceInputs["nodeType"] = state ? state.nodeType : undefined;
            resourceInputs["operationDuration"] = state ? state.operationDuration : undefined;
            resourceInputs["renewFlag"] = state ? state.renewFlag : undefined;
            resourceInputs["subnetId"] = state ? state.subnetId : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["timeUnit"] = state ? state.timeUnit : undefined;
            resourceInputs["voucherIds"] = state ? state.voucherIds : undefined;
            resourceInputs["vpcId"] = state ? state.vpcId : undefined;
            resourceInputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as LogstashArgs | undefined;
            if ((!args || args.instanceName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceName'");
            }
            if ((!args || args.logstashVersion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'logstashVersion'");
            }
            if ((!args || args.subnetId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'subnetId'");
            }
            if ((!args || args.vpcId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpcId'");
            }
            if ((!args || args.zone === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zone'");
            }
            resourceInputs["autoVoucher"] = args ? args.autoVoucher : undefined;
            resourceInputs["chargePeriod"] = args ? args.chargePeriod : undefined;
            resourceInputs["chargeType"] = args ? args.chargeType : undefined;
            resourceInputs["diskSize"] = args ? args.diskSize : undefined;
            resourceInputs["diskType"] = args ? args.diskType : undefined;
            resourceInputs["instanceName"] = args ? args.instanceName : undefined;
            resourceInputs["licenseType"] = args ? args.licenseType : undefined;
            resourceInputs["logstashVersion"] = args ? args.logstashVersion : undefined;
            resourceInputs["nodeNum"] = args ? args.nodeNum : undefined;
            resourceInputs["nodeType"] = args ? args.nodeType : undefined;
            resourceInputs["operationDuration"] = args ? args.operationDuration : undefined;
            resourceInputs["renewFlag"] = args ? args.renewFlag : undefined;
            resourceInputs["subnetId"] = args ? args.subnetId : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["timeUnit"] = args ? args.timeUnit : undefined;
            resourceInputs["voucherIds"] = args ? args.voucherIds : undefined;
            resourceInputs["vpcId"] = args ? args.vpcId : undefined;
            resourceInputs["zone"] = args ? args.zone : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Logstash.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Logstash resources.
 */
export interface LogstashState {
    /**
     * whether to use voucher auto, 1 when use, else 0.
     */
    autoVoucher?: pulumi.Input<number>;
    /**
     * Period when charged by months or years(unit depends on TimeUnit).
     */
    chargePeriod?: pulumi.Input<number>;
    /**
     * Charge type. PREPAID: charged by months or years; POSTPAID_BY_HOUR: charged by hours; default vaule: POSTPAID_BY_HOUR.
     */
    chargeType?: pulumi.Input<string>;
    /**
     * node disk size (unit GB).
     */
    diskSize?: pulumi.Input<number>;
    /**
     * Disk type. CLOUD_SSD: SSD cloud disk; CLOUD_PREMIUM: high hard energy cloud disk; default: CLOUD_SSD.
     */
    diskType?: pulumi.Input<string>;
    /**
     * Instance name (compose of 1-50 letter, number, - or _).
     */
    instanceName?: pulumi.Input<string>;
    /**
     * License type. oss: open source version; xpack:xpack version; default: xpack.
     */
    licenseType?: pulumi.Input<string>;
    /**
     * Instance version(6.8.13, 7.10.1).
     */
    logstashVersion?: pulumi.Input<string>;
    /**
     * Node num(range 2-50).
     */
    nodeNum?: pulumi.Input<number>;
    /**
     * Node type. Valid values:
     * - LOGSTASH.S1.SMALL2: 1 core 2G;
     * - LOGSTASH.S1.MEDIUM4:2 core 4G;
     * - LOGSTASH.S1.MEDIUM8:2 core 8G;
     * - LOGSTASH.S1.LARGE16:4 core 16G;
     * - LOGSTASH.S1.2XLARGE32:8 core 32G;
     * - LOGSTASH.S1.4XLARGE32:16 core 32G;
     * - LOGSTASH.S1.4XLARGE64:16 core 64G.
     */
    nodeType?: pulumi.Input<string>;
    /**
     * operation time by tencent clound.
     */
    operationDuration?: pulumi.Input<inputs.Elasticsearch.LogstashOperationDuration>;
    /**
     * Automatic renewal flag. RENEW_FLAG_AUTO: auto renewal; RENEW_FLAG_MANUAL: do not renew automatically, users renew manually. It needs to be set when ChargeType is PREPAID. If this parameter is not passed, ordinary users will not renew automatically by default, and SVIP users will renew automatically.
     */
    renewFlag?: pulumi.Input<string>;
    /**
     * Subnet id.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * Tag description list.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * charge time unit(set when ChargeType is PREPAID, default value: ms).
     */
    timeUnit?: pulumi.Input<string>;
    /**
     * Voucher list(only can use one voucher by now).
     */
    voucherIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * VPC id.
     */
    vpcId?: pulumi.Input<string>;
    /**
     * Available zone.
     */
    zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Logstash resource.
 */
export interface LogstashArgs {
    /**
     * whether to use voucher auto, 1 when use, else 0.
     */
    autoVoucher?: pulumi.Input<number>;
    /**
     * Period when charged by months or years(unit depends on TimeUnit).
     */
    chargePeriod?: pulumi.Input<number>;
    /**
     * Charge type. PREPAID: charged by months or years; POSTPAID_BY_HOUR: charged by hours; default vaule: POSTPAID_BY_HOUR.
     */
    chargeType?: pulumi.Input<string>;
    /**
     * node disk size (unit GB).
     */
    diskSize?: pulumi.Input<number>;
    /**
     * Disk type. CLOUD_SSD: SSD cloud disk; CLOUD_PREMIUM: high hard energy cloud disk; default: CLOUD_SSD.
     */
    diskType?: pulumi.Input<string>;
    /**
     * Instance name (compose of 1-50 letter, number, - or _).
     */
    instanceName: pulumi.Input<string>;
    /**
     * License type. oss: open source version; xpack:xpack version; default: xpack.
     */
    licenseType?: pulumi.Input<string>;
    /**
     * Instance version(6.8.13, 7.10.1).
     */
    logstashVersion: pulumi.Input<string>;
    /**
     * Node num(range 2-50).
     */
    nodeNum?: pulumi.Input<number>;
    /**
     * Node type. Valid values:
     * - LOGSTASH.S1.SMALL2: 1 core 2G;
     * - LOGSTASH.S1.MEDIUM4:2 core 4G;
     * - LOGSTASH.S1.MEDIUM8:2 core 8G;
     * - LOGSTASH.S1.LARGE16:4 core 16G;
     * - LOGSTASH.S1.2XLARGE32:8 core 32G;
     * - LOGSTASH.S1.4XLARGE32:16 core 32G;
     * - LOGSTASH.S1.4XLARGE64:16 core 64G.
     */
    nodeType?: pulumi.Input<string>;
    /**
     * operation time by tencent clound.
     */
    operationDuration?: pulumi.Input<inputs.Elasticsearch.LogstashOperationDuration>;
    /**
     * Automatic renewal flag. RENEW_FLAG_AUTO: auto renewal; RENEW_FLAG_MANUAL: do not renew automatically, users renew manually. It needs to be set when ChargeType is PREPAID. If this parameter is not passed, ordinary users will not renew automatically by default, and SVIP users will renew automatically.
     */
    renewFlag?: pulumi.Input<string>;
    /**
     * Subnet id.
     */
    subnetId: pulumi.Input<string>;
    /**
     * Tag description list.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * charge time unit(set when ChargeType is PREPAID, default value: ms).
     */
    timeUnit?: pulumi.Input<string>;
    /**
     * Voucher list(only can use one voucher by now).
     */
    voucherIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * VPC id.
     */
    vpcId: pulumi.Input<string>;
    /**
     * Available zone.
     */
    zone: pulumi.Input<string>;
}