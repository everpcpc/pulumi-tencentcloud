// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a tsf applicationPublicConfig
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const applicationPublicConfig = new tencentcloud.tsf.ApplicationPublicConfig("applicationPublicConfig", {
 *     configName: "my_config",
 *     configType: "P",
 *     configValue: "test: 1",
 *     configVersion: "1.0",
 *     configVersionDesc: "product version",
 *     encodeWithBase64: true,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class ApplicationPublicConfig extends pulumi.CustomResource {
    /**
     * Get an existing ApplicationPublicConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ApplicationPublicConfigState, opts?: pulumi.CustomResourceOptions): ApplicationPublicConfig {
        return new ApplicationPublicConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Tsf/applicationPublicConfig:ApplicationPublicConfig';

    /**
     * Returns true if the given object is an instance of ApplicationPublicConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApplicationPublicConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApplicationPublicConfig.__pulumiType;
    }

    /**
     * Config Name.
     */
    public readonly configName!: pulumi.Output<string>;
    /**
     * Config type.
     */
    public readonly configType!: pulumi.Output<string | undefined>;
    /**
     * config value, only yaml file allowed.
     */
    public readonly configValue!: pulumi.Output<string>;
    /**
     * config version.
     */
    public readonly configVersion!: pulumi.Output<string>;
    /**
     * Config version description.
     */
    public readonly configVersionDesc!: pulumi.Output<string | undefined>;
    /**
     * the config value is encoded with base64 or not.
     */
    public readonly encodeWithBase64!: pulumi.Output<boolean | undefined>;
    /**
     * datasource for auth.
     */
    public readonly programIdLists!: pulumi.Output<string[] | undefined>;

    /**
     * Create a ApplicationPublicConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApplicationPublicConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ApplicationPublicConfigArgs | ApplicationPublicConfigState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ApplicationPublicConfigState | undefined;
            resourceInputs["configName"] = state ? state.configName : undefined;
            resourceInputs["configType"] = state ? state.configType : undefined;
            resourceInputs["configValue"] = state ? state.configValue : undefined;
            resourceInputs["configVersion"] = state ? state.configVersion : undefined;
            resourceInputs["configVersionDesc"] = state ? state.configVersionDesc : undefined;
            resourceInputs["encodeWithBase64"] = state ? state.encodeWithBase64 : undefined;
            resourceInputs["programIdLists"] = state ? state.programIdLists : undefined;
        } else {
            const args = argsOrState as ApplicationPublicConfigArgs | undefined;
            if ((!args || args.configName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'configName'");
            }
            if ((!args || args.configValue === undefined) && !opts.urn) {
                throw new Error("Missing required property 'configValue'");
            }
            if ((!args || args.configVersion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'configVersion'");
            }
            resourceInputs["configName"] = args ? args.configName : undefined;
            resourceInputs["configType"] = args ? args.configType : undefined;
            resourceInputs["configValue"] = args ? args.configValue : undefined;
            resourceInputs["configVersion"] = args ? args.configVersion : undefined;
            resourceInputs["configVersionDesc"] = args ? args.configVersionDesc : undefined;
            resourceInputs["encodeWithBase64"] = args ? args.encodeWithBase64 : undefined;
            resourceInputs["programIdLists"] = args ? args.programIdLists : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ApplicationPublicConfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ApplicationPublicConfig resources.
 */
export interface ApplicationPublicConfigState {
    /**
     * Config Name.
     */
    configName?: pulumi.Input<string>;
    /**
     * Config type.
     */
    configType?: pulumi.Input<string>;
    /**
     * config value, only yaml file allowed.
     */
    configValue?: pulumi.Input<string>;
    /**
     * config version.
     */
    configVersion?: pulumi.Input<string>;
    /**
     * Config version description.
     */
    configVersionDesc?: pulumi.Input<string>;
    /**
     * the config value is encoded with base64 or not.
     */
    encodeWithBase64?: pulumi.Input<boolean>;
    /**
     * datasource for auth.
     */
    programIdLists?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a ApplicationPublicConfig resource.
 */
export interface ApplicationPublicConfigArgs {
    /**
     * Config Name.
     */
    configName: pulumi.Input<string>;
    /**
     * Config type.
     */
    configType?: pulumi.Input<string>;
    /**
     * config value, only yaml file allowed.
     */
    configValue: pulumi.Input<string>;
    /**
     * config version.
     */
    configVersion: pulumi.Input<string>;
    /**
     * Config version description.
     */
    configVersionDesc?: pulumi.Input<string>;
    /**
     * the config value is encoded with base64 or not.
     */
    encodeWithBase64?: pulumi.Input<boolean>;
    /**
     * datasource for auth.
     */
    programIdLists?: pulumi.Input<pulumi.Input<string>[]>;
}
