// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a mysql passwordComplexity
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const zones = tencentcloud.Availability.getZonesByProduct({
 *     product: "cdb",
 * });
 * const vpc = new tencentcloud.vpc.Instance("vpc", {cidrBlock: "10.0.0.0/16"});
 * const subnet = new tencentcloud.subnet.Instance("subnet", {
 *     availabilityZone: zones.then(zones => zones.zones?.[0]?.name),
 *     vpcId: vpc.id,
 *     cidrBlock: "10.0.0.0/16",
 *     isMulticast: false,
 * });
 * const securityGroup = new tencentcloud.security.Group("securityGroup", {description: "mysql test"});
 * const exampleInstance = new tencentcloud.mysql.Instance("exampleInstance", {
 *     internetService: 1,
 *     engineVersion: "5.7",
 *     chargeType: "POSTPAID",
 *     rootPassword: "PassWord123",
 *     slaveDeployMode: 0,
 *     availabilityZone: zones.then(zones => zones.zones?.[0]?.name),
 *     slaveSyncMode: 1,
 *     instanceName: "tf-example-mysql",
 *     memSize: 4000,
 *     volumeSize: 200,
 *     vpcId: vpc.id,
 *     subnetId: subnet.id,
 *     intranetPort: 3306,
 *     securityGroups: [securityGroup.id],
 *     tags: {
 *         name: "test",
 *     },
 *     parameters: {
 *         character_set_server: "utf8",
 *         max_connections: "1000",
 *     },
 * });
 * const examplePasswordComplexity = new tencentcloud.mysql.PasswordComplexity("examplePasswordComplexity", {
 *     instanceId: exampleInstance.id,
 *     paramLists: [
 *         {
 *             name: "validate_password_length",
 *             currentValue: "8",
 *         },
 *         {
 *             name: "validate_password_mixed_case_count",
 *             currentValue: "2",
 *         },
 *         {
 *             name: "validate_password_number_count",
 *             currentValue: "2",
 *         },
 *         {
 *             name: "validate_password_special_char_count",
 *             currentValue: "2",
 *         },
 *     ],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class PasswordComplexity extends pulumi.CustomResource {
    /**
     * Get an existing PasswordComplexity resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: PasswordComplexityState, opts?: pulumi.CustomResourceOptions): PasswordComplexity {
        return new PasswordComplexity(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Mysql/passwordComplexity:PasswordComplexity';

    /**
     * Returns true if the given object is an instance of PasswordComplexity.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PasswordComplexity {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PasswordComplexity.__pulumiType;
    }

    /**
     * Instance ID.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * List of parameters to be modified. Every element is a combination of `Name` (parameter name) and `CurrentValue` (new value). Valid values for `Name` of version 8.0: `validate_password.policy`, `validate_password.lengt`, `validate_password.mixed_case_coun`, `validate_password.number_coun`, `validate_password.special_char_count`. Valid values for `Name` of version 5.6 and 5.7: `validatePasswordPolic`, `validatePasswordLengt` `validatePasswordMixedCaseCoun`, `validatePasswordNumberCoun`, `validatePasswordSpecialCharCoun`.
     */
    public readonly paramLists!: pulumi.Output<outputs.Mysql.PasswordComplexityParamList[] | undefined>;

    /**
     * Create a PasswordComplexity resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PasswordComplexityArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: PasswordComplexityArgs | PasswordComplexityState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as PasswordComplexityState | undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["paramLists"] = state ? state.paramLists : undefined;
        } else {
            const args = argsOrState as PasswordComplexityArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["paramLists"] = args ? args.paramLists : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(PasswordComplexity.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering PasswordComplexity resources.
 */
export interface PasswordComplexityState {
    /**
     * Instance ID.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * List of parameters to be modified. Every element is a combination of `Name` (parameter name) and `CurrentValue` (new value). Valid values for `Name` of version 8.0: `validate_password.policy`, `validate_password.lengt`, `validate_password.mixed_case_coun`, `validate_password.number_coun`, `validate_password.special_char_count`. Valid values for `Name` of version 5.6 and 5.7: `validatePasswordPolic`, `validatePasswordLengt` `validatePasswordMixedCaseCoun`, `validatePasswordNumberCoun`, `validatePasswordSpecialCharCoun`.
     */
    paramLists?: pulumi.Input<pulumi.Input<inputs.Mysql.PasswordComplexityParamList>[]>;
}

/**
 * The set of arguments for constructing a PasswordComplexity resource.
 */
export interface PasswordComplexityArgs {
    /**
     * Instance ID.
     */
    instanceId: pulumi.Input<string>;
    /**
     * List of parameters to be modified. Every element is a combination of `Name` (parameter name) and `CurrentValue` (new value). Valid values for `Name` of version 8.0: `validate_password.policy`, `validate_password.lengt`, `validate_password.mixed_case_coun`, `validate_password.number_coun`, `validate_password.special_char_count`. Valid values for `Name` of version 5.6 and 5.7: `validatePasswordPolic`, `validatePasswordLengt` `validatePasswordMixedCaseCoun`, `validatePasswordNumberCoun`, `validatePasswordSpecialCharCoun`.
     */
    paramLists?: pulumi.Input<pulumi.Input<inputs.Mysql.PasswordComplexityParamList>[]>;
}