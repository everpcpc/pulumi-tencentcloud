// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a antiddos ddosGeoIpBlockConfig
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const ddosGeoIpBlockConfig = new tencentcloud.antiddos.DdosGeoIpBlockConfig("ddosGeoIpBlockConfig", {
 *     ddosGeoIpBlockConfig: {
 *         action: "drop",
 *         areaLists: [100002],
 *         regionType: "customized",
 *     },
 *     instanceId: "bgp-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * antiddos ddos_geo_ip_block_config can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Antiddos/ddosGeoIpBlockConfig:DdosGeoIpBlockConfig ddos_geo_ip_block_config ${instanceId}#${configId}
 * ```
 */
export class DdosGeoIpBlockConfig extends pulumi.CustomResource {
    /**
     * Get an existing DdosGeoIpBlockConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DdosGeoIpBlockConfigState, opts?: pulumi.CustomResourceOptions): DdosGeoIpBlockConfig {
        return new DdosGeoIpBlockConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Antiddos/ddosGeoIpBlockConfig:DdosGeoIpBlockConfig';

    /**
     * Returns true if the given object is an instance of DdosGeoIpBlockConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DdosGeoIpBlockConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DdosGeoIpBlockConfig.__pulumiType;
    }

    /**
     * DDoS region blocking configuration, configuration ID cannot be empty when filling in parameters.
     */
    public readonly ddosGeoIpBlockConfig!: pulumi.Output<outputs.Antiddos.DdosGeoIpBlockConfigDdosGeoIpBlockConfig>;
    /**
     * InstanceId.
     */
    public readonly instanceId!: pulumi.Output<string>;

    /**
     * Create a DdosGeoIpBlockConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DdosGeoIpBlockConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DdosGeoIpBlockConfigArgs | DdosGeoIpBlockConfigState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DdosGeoIpBlockConfigState | undefined;
            resourceInputs["ddosGeoIpBlockConfig"] = state ? state.ddosGeoIpBlockConfig : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
        } else {
            const args = argsOrState as DdosGeoIpBlockConfigArgs | undefined;
            if ((!args || args.ddosGeoIpBlockConfig === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ddosGeoIpBlockConfig'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["ddosGeoIpBlockConfig"] = args ? args.ddosGeoIpBlockConfig : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DdosGeoIpBlockConfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DdosGeoIpBlockConfig resources.
 */
export interface DdosGeoIpBlockConfigState {
    /**
     * DDoS region blocking configuration, configuration ID cannot be empty when filling in parameters.
     */
    ddosGeoIpBlockConfig?: pulumi.Input<inputs.Antiddos.DdosGeoIpBlockConfigDdosGeoIpBlockConfig>;
    /**
     * InstanceId.
     */
    instanceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DdosGeoIpBlockConfig resource.
 */
export interface DdosGeoIpBlockConfigArgs {
    /**
     * DDoS region blocking configuration, configuration ID cannot be empty when filling in parameters.
     */
    ddosGeoIpBlockConfig: pulumi.Input<inputs.Antiddos.DdosGeoIpBlockConfigDdosGeoIpBlockConfig>;
    /**
     * InstanceId.
     */
    instanceId: pulumi.Input<string>;
}