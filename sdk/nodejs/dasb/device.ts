// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a dasb device
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.dasb.Device("example", {
 *     departmentId: "1.2.3",
 *     ip: "192.168.0.1",
 *     osName: "Linux",
 *     port: 80,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * dasb device can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Dasb/device:Device example 17
 * ```
 */
export class Device extends pulumi.CustomResource {
    /**
     * Get an existing Device resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DeviceState, opts?: pulumi.CustomResourceOptions): Device {
        return new Device(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dasb/device:Device';

    /**
     * Returns true if the given object is an instance of Device.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Device {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Device.__pulumiType;
    }

    /**
     * The department ID to which the device belongs.
     */
    public readonly departmentId!: pulumi.Output<string | undefined>;
    /**
     * IP address.
     */
    public readonly ip!: pulumi.Output<string>;
    /**
     * Asset multi-node: fields ip and port.
     */
    public readonly ipPortSets!: pulumi.Output<string[]>;
    /**
     * Hostname, can be empty.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Operating system name, only Linux, Windows or MySQL.
     */
    public readonly osName!: pulumi.Output<string>;
    /**
     * Management port.
     */
    public readonly port!: pulumi.Output<number>;

    /**
     * Create a Device resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DeviceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DeviceArgs | DeviceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DeviceState | undefined;
            resourceInputs["departmentId"] = state ? state.departmentId : undefined;
            resourceInputs["ip"] = state ? state.ip : undefined;
            resourceInputs["ipPortSets"] = state ? state.ipPortSets : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["osName"] = state ? state.osName : undefined;
            resourceInputs["port"] = state ? state.port : undefined;
        } else {
            const args = argsOrState as DeviceArgs | undefined;
            if ((!args || args.ip === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ip'");
            }
            if ((!args || args.osName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'osName'");
            }
            if ((!args || args.port === undefined) && !opts.urn) {
                throw new Error("Missing required property 'port'");
            }
            resourceInputs["departmentId"] = args ? args.departmentId : undefined;
            resourceInputs["ip"] = args ? args.ip : undefined;
            resourceInputs["ipPortSets"] = args ? args.ipPortSets : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["osName"] = args ? args.osName : undefined;
            resourceInputs["port"] = args ? args.port : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Device.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Device resources.
 */
export interface DeviceState {
    /**
     * The department ID to which the device belongs.
     */
    departmentId?: pulumi.Input<string>;
    /**
     * IP address.
     */
    ip?: pulumi.Input<string>;
    /**
     * Asset multi-node: fields ip and port.
     */
    ipPortSets?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Hostname, can be empty.
     */
    name?: pulumi.Input<string>;
    /**
     * Operating system name, only Linux, Windows or MySQL.
     */
    osName?: pulumi.Input<string>;
    /**
     * Management port.
     */
    port?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a Device resource.
 */
export interface DeviceArgs {
    /**
     * The department ID to which the device belongs.
     */
    departmentId?: pulumi.Input<string>;
    /**
     * IP address.
     */
    ip: pulumi.Input<string>;
    /**
     * Asset multi-node: fields ip and port.
     */
    ipPortSets?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Hostname, can be empty.
     */
    name?: pulumi.Input<string>;
    /**
     * Operating system name, only Linux, Windows or MySQL.
     */
    osName: pulumi.Input<string>;
    /**
     * Management port.
     */
    port: pulumi.Input<number>;
}