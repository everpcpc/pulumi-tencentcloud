// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a tse instance
 *
 * ## Example Usage
 *
 * ### Create zookeeper standard version
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const zookeeperStandard = new tencentcloud.tse.Instance("zookeeperStandard", {
 *     engineName: "zookeeper-test",
 *     engineNodeNum: 3,
 *     engineProductVersion: "STANDARD",
 *     engineRegion: "ap-guangzhou",
 *     engineResourceSpec: "spec-qvj6k7t4q",
 *     engineType: "zookeeper",
 *     engineVersion: "3.5.9.4",
 *     subnetId: "subnet-dwj7ipnc",
 *     tags: {
 *         createdBy: "terraform",
 *     },
 *     tradeType: 0,
 *     vpcId: "vpc-4owdpnwr",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Create zookeeper professional version
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const zookeeperProfessional = new tencentcloud.tse.Instance("zookeeperProfessional", {
 *     engineName: "zookeeper-test",
 *     engineNodeNum: 3,
 *     engineProductVersion: "PROFESSIONAL",
 *     engineRegion: "ap-guangzhou",
 *     engineRegionInfos: [{
 *         engineRegion: "ap-guangzhou",
 *         replica: 3,
 *         vpcInfos: [
 *             {
 *                 subnetId: "subnet-dwj7ipnc",
 *                 vpcId: "vpc-4owdpnwr",
 *             },
 *             {
 *                 subnetId: "subnet-403mgks4",
 *                 vpcId: "vpc-b1puef4z",
 *             },
 *         ],
 *     }],
 *     engineResourceSpec: "spec-qvj6k7t4q",
 *     engineType: "zookeeper",
 *     engineVersion: "3.5.9.4",
 *     subnetId: "subnet-dwj7ipnc",
 *     tags: {
 *         createdBy: "terraform",
 *     },
 *     tradeType: 0,
 *     vpcId: "vpc-4owdpnwr",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Create nacos standard version
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const nacos = new tencentcloud.tse.Instance("nacos", {
 *     enableClientInternetAccess: false,
 *     engineName: "test",
 *     engineNodeNum: 3,
 *     engineProductVersion: "STANDARD",
 *     engineRegion: "ap-guangzhou",
 *     engineResourceSpec: "spec-1160a35a",
 *     engineType: "nacos",
 *     engineVersion: "2.0.3.4",
 *     subnetId: "subnet-5vpegquy",
 *     tags: {
 *         createdBy: "terraform",
 *     },
 *     tradeType: 0,
 *     vpcId: "vpc-99xmasf9",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Create polaris base version
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const polaris = new tencentcloud.tse.Instance("polaris", {
 *     enableClientInternetAccess: false,
 *     engineName: "test",
 *     engineNodeNum: 2,
 *     engineProductVersion: "BASE",
 *     engineRegion: "ap-guangzhou",
 *     engineResourceSpec: "spec-c160bas1",
 *     engineType: "polaris",
 *     engineVersion: "1.16.0.1",
 *     subnetId: "subnet-5vpegquy",
 *     tags: {
 *         createdBy: "terraform",
 *     },
 *     tradeType: 0,
 *     vpcId: "vpc-99xmasf9",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * tse instance can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Tse/instance:Instance instance instance_id
 * ```
 */
export class Instance extends pulumi.CustomResource {
    /**
     * Get an existing Instance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: InstanceState, opts?: pulumi.CustomResourceOptions): Instance {
        return new Instance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Tse/instance:Instance';

    /**
     * Returns true if the given object is an instance of Instance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Instance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Instance.__pulumiType;
    }

    /**
     * Client public network access, `true`: on, `false`: off, default: false.
     */
    public readonly enableClientInternetAccess!: pulumi.Output<boolean | undefined>;
    /**
     * engien name. Reference value: nacos-test.
     */
    public readonly engineName!: pulumi.Output<string>;
    /**
     * engine node num. see EngineProductVersion.
     */
    public readonly engineNodeNum!: pulumi.Output<number | undefined>;
    /**
     * Engine product version. Reference value: `Nacos`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Zookeeper`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`; `PROFESSIONAL`: professional versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Polarismesh`: `BASE`: Base version, optional node num: `1`, optional spec list: `NUM50`; `PROFESSIONAL`: Enterprise versions, optional node num: `2`, `3`, optional spec list: `NUM50`, `NUM100`, `NUM200`, `NUM500`, `NUM1000`, `NUM5000`, `NUM10000`, `NUM50000`.
     */
    public readonly engineProductVersion!: pulumi.Output<string>;
    /**
     * engine deploy region. Reference value: `China area` Reference value: `ap-guangzhou`, `ap-beijing`, `ap-chengdu`, `ap-chongqing`, `ap-nanjing`, `ap-shanghai` `ap-beijing-fsi`, `ap-shanghai-fsi`, `ap-shenzhen-fsi`. `Asia Pacific` area Reference value: `ap-hongkong`, `ap-taipei`, `ap-jakarta`, `ap-singapore`, `ap-bangkok`, `ap-seoul`, `ap-tokyo`. `North America area` Reference value: `na-toronto`, `sa-saopaulo`, `na-siliconvalley`, `na-ashburn`.
     */
    public readonly engineRegion!: pulumi.Output<string>;
    /**
     * Details about the regional configuration of the engine in cross-region deployment, only zookeeper professional requires the use of the EngineRegionInfos parameter.
     */
    public readonly engineRegionInfos!: pulumi.Output<outputs.Tse.InstanceEngineRegionInfo[] | undefined>;
    /**
     * engine spec ID. see EngineProductVersion.
     */
    public readonly engineResourceSpec!: pulumi.Output<string | undefined>;
    /**
     * engine type. Reference value: `zookeeper`, `nacos`, `polaris`.
     */
    public readonly engineType!: pulumi.Output<string>;
    /**
     * An open source version of the engine. Each engine supports different open source versions, refer to the product documentation or console purchase page.
     */
    public readonly engineVersion!: pulumi.Output<string>;
    /**
     * Prepaid time, in monthly units.
     */
    public readonly prepaidPeriod!: pulumi.Output<number | undefined>;
    /**
     * Automatic renewal mark, prepaid only.  Reference value: `0`: No automatic renewal, `1`: Automatic renewal.
     */
    public readonly prepaidRenewFlag!: pulumi.Output<number | undefined>;
    /**
     * subnet ID. Assign an IP address to the engine in the VPC subnet. Reference value: subnet-ahde9me9.
     */
    public readonly subnetId!: pulumi.Output<string | undefined>;
    /**
     * Tag description list.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * trade type. Reference value:- 0:postpaid- 1:Prepaid (Interface does not support the creation of prepaid instances yet).
     */
    public readonly tradeType!: pulumi.Output<number>;
    /**
     * VPC ID. Assign an IP address to the engine in the VPC subnet. Reference value: vpc-conz6aix.
     */
    public readonly vpcId!: pulumi.Output<string | undefined>;

    /**
     * Create a Instance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: InstanceArgs | InstanceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as InstanceState | undefined;
            resourceInputs["enableClientInternetAccess"] = state ? state.enableClientInternetAccess : undefined;
            resourceInputs["engineName"] = state ? state.engineName : undefined;
            resourceInputs["engineNodeNum"] = state ? state.engineNodeNum : undefined;
            resourceInputs["engineProductVersion"] = state ? state.engineProductVersion : undefined;
            resourceInputs["engineRegion"] = state ? state.engineRegion : undefined;
            resourceInputs["engineRegionInfos"] = state ? state.engineRegionInfos : undefined;
            resourceInputs["engineResourceSpec"] = state ? state.engineResourceSpec : undefined;
            resourceInputs["engineType"] = state ? state.engineType : undefined;
            resourceInputs["engineVersion"] = state ? state.engineVersion : undefined;
            resourceInputs["prepaidPeriod"] = state ? state.prepaidPeriod : undefined;
            resourceInputs["prepaidRenewFlag"] = state ? state.prepaidRenewFlag : undefined;
            resourceInputs["subnetId"] = state ? state.subnetId : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["tradeType"] = state ? state.tradeType : undefined;
            resourceInputs["vpcId"] = state ? state.vpcId : undefined;
        } else {
            const args = argsOrState as InstanceArgs | undefined;
            if ((!args || args.engineName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'engineName'");
            }
            if ((!args || args.engineProductVersion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'engineProductVersion'");
            }
            if ((!args || args.engineRegion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'engineRegion'");
            }
            if ((!args || args.engineType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'engineType'");
            }
            if ((!args || args.engineVersion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'engineVersion'");
            }
            if ((!args || args.tradeType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'tradeType'");
            }
            resourceInputs["enableClientInternetAccess"] = args ? args.enableClientInternetAccess : undefined;
            resourceInputs["engineName"] = args ? args.engineName : undefined;
            resourceInputs["engineNodeNum"] = args ? args.engineNodeNum : undefined;
            resourceInputs["engineProductVersion"] = args ? args.engineProductVersion : undefined;
            resourceInputs["engineRegion"] = args ? args.engineRegion : undefined;
            resourceInputs["engineRegionInfos"] = args ? args.engineRegionInfos : undefined;
            resourceInputs["engineResourceSpec"] = args ? args.engineResourceSpec : undefined;
            resourceInputs["engineType"] = args ? args.engineType : undefined;
            resourceInputs["engineVersion"] = args ? args.engineVersion : undefined;
            resourceInputs["prepaidPeriod"] = args ? args.prepaidPeriod : undefined;
            resourceInputs["prepaidRenewFlag"] = args ? args.prepaidRenewFlag : undefined;
            resourceInputs["subnetId"] = args ? args.subnetId : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["tradeType"] = args ? args.tradeType : undefined;
            resourceInputs["vpcId"] = args ? args.vpcId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Instance.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Instance resources.
 */
export interface InstanceState {
    /**
     * Client public network access, `true`: on, `false`: off, default: false.
     */
    enableClientInternetAccess?: pulumi.Input<boolean>;
    /**
     * engien name. Reference value: nacos-test.
     */
    engineName?: pulumi.Input<string>;
    /**
     * engine node num. see EngineProductVersion.
     */
    engineNodeNum?: pulumi.Input<number>;
    /**
     * Engine product version. Reference value: `Nacos`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Zookeeper`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`; `PROFESSIONAL`: professional versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Polarismesh`: `BASE`: Base version, optional node num: `1`, optional spec list: `NUM50`; `PROFESSIONAL`: Enterprise versions, optional node num: `2`, `3`, optional spec list: `NUM50`, `NUM100`, `NUM200`, `NUM500`, `NUM1000`, `NUM5000`, `NUM10000`, `NUM50000`.
     */
    engineProductVersion?: pulumi.Input<string>;
    /**
     * engine deploy region. Reference value: `China area` Reference value: `ap-guangzhou`, `ap-beijing`, `ap-chengdu`, `ap-chongqing`, `ap-nanjing`, `ap-shanghai` `ap-beijing-fsi`, `ap-shanghai-fsi`, `ap-shenzhen-fsi`. `Asia Pacific` area Reference value: `ap-hongkong`, `ap-taipei`, `ap-jakarta`, `ap-singapore`, `ap-bangkok`, `ap-seoul`, `ap-tokyo`. `North America area` Reference value: `na-toronto`, `sa-saopaulo`, `na-siliconvalley`, `na-ashburn`.
     */
    engineRegion?: pulumi.Input<string>;
    /**
     * Details about the regional configuration of the engine in cross-region deployment, only zookeeper professional requires the use of the EngineRegionInfos parameter.
     */
    engineRegionInfos?: pulumi.Input<pulumi.Input<inputs.Tse.InstanceEngineRegionInfo>[]>;
    /**
     * engine spec ID. see EngineProductVersion.
     */
    engineResourceSpec?: pulumi.Input<string>;
    /**
     * engine type. Reference value: `zookeeper`, `nacos`, `polaris`.
     */
    engineType?: pulumi.Input<string>;
    /**
     * An open source version of the engine. Each engine supports different open source versions, refer to the product documentation or console purchase page.
     */
    engineVersion?: pulumi.Input<string>;
    /**
     * Prepaid time, in monthly units.
     */
    prepaidPeriod?: pulumi.Input<number>;
    /**
     * Automatic renewal mark, prepaid only.  Reference value: `0`: No automatic renewal, `1`: Automatic renewal.
     */
    prepaidRenewFlag?: pulumi.Input<number>;
    /**
     * subnet ID. Assign an IP address to the engine in the VPC subnet. Reference value: subnet-ahde9me9.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * Tag description list.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * trade type. Reference value:- 0:postpaid- 1:Prepaid (Interface does not support the creation of prepaid instances yet).
     */
    tradeType?: pulumi.Input<number>;
    /**
     * VPC ID. Assign an IP address to the engine in the VPC subnet. Reference value: vpc-conz6aix.
     */
    vpcId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Instance resource.
 */
export interface InstanceArgs {
    /**
     * Client public network access, `true`: on, `false`: off, default: false.
     */
    enableClientInternetAccess?: pulumi.Input<boolean>;
    /**
     * engien name. Reference value: nacos-test.
     */
    engineName: pulumi.Input<string>;
    /**
     * engine node num. see EngineProductVersion.
     */
    engineNodeNum?: pulumi.Input<number>;
    /**
     * Engine product version. Reference value: `Nacos`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Zookeeper`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`; `PROFESSIONAL`: professional versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Polarismesh`: `BASE`: Base version, optional node num: `1`, optional spec list: `NUM50`; `PROFESSIONAL`: Enterprise versions, optional node num: `2`, `3`, optional spec list: `NUM50`, `NUM100`, `NUM200`, `NUM500`, `NUM1000`, `NUM5000`, `NUM10000`, `NUM50000`.
     */
    engineProductVersion: pulumi.Input<string>;
    /**
     * engine deploy region. Reference value: `China area` Reference value: `ap-guangzhou`, `ap-beijing`, `ap-chengdu`, `ap-chongqing`, `ap-nanjing`, `ap-shanghai` `ap-beijing-fsi`, `ap-shanghai-fsi`, `ap-shenzhen-fsi`. `Asia Pacific` area Reference value: `ap-hongkong`, `ap-taipei`, `ap-jakarta`, `ap-singapore`, `ap-bangkok`, `ap-seoul`, `ap-tokyo`. `North America area` Reference value: `na-toronto`, `sa-saopaulo`, `na-siliconvalley`, `na-ashburn`.
     */
    engineRegion: pulumi.Input<string>;
    /**
     * Details about the regional configuration of the engine in cross-region deployment, only zookeeper professional requires the use of the EngineRegionInfos parameter.
     */
    engineRegionInfos?: pulumi.Input<pulumi.Input<inputs.Tse.InstanceEngineRegionInfo>[]>;
    /**
     * engine spec ID. see EngineProductVersion.
     */
    engineResourceSpec?: pulumi.Input<string>;
    /**
     * engine type. Reference value: `zookeeper`, `nacos`, `polaris`.
     */
    engineType: pulumi.Input<string>;
    /**
     * An open source version of the engine. Each engine supports different open source versions, refer to the product documentation or console purchase page.
     */
    engineVersion: pulumi.Input<string>;
    /**
     * Prepaid time, in monthly units.
     */
    prepaidPeriod?: pulumi.Input<number>;
    /**
     * Automatic renewal mark, prepaid only.  Reference value: `0`: No automatic renewal, `1`: Automatic renewal.
     */
    prepaidRenewFlag?: pulumi.Input<number>;
    /**
     * subnet ID. Assign an IP address to the engine in the VPC subnet. Reference value: subnet-ahde9me9.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * Tag description list.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * trade type. Reference value:- 0:postpaid- 1:Prepaid (Interface does not support the creation of prepaid instances yet).
     */
    tradeType: pulumi.Input<number>;
    /**
     * VPC ID. Assign an IP address to the engine in the VPC subnet. Reference value: vpc-conz6aix.
     */
    vpcId?: pulumi.Input<string>;
}