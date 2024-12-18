// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a mps executeFunctionOperation
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const operation = new tencentcloud.mps.ExecuteFunctionOperation("operation", {
 *     functionArg: "arg1",
 *     functionName: "ExampleFunc",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class ExecuteFunctionOperation extends pulumi.CustomResource {
    /**
     * Get an existing ExecuteFunctionOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ExecuteFunctionOperationState, opts?: pulumi.CustomResourceOptions): ExecuteFunctionOperation {
        return new ExecuteFunctionOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Mps/executeFunctionOperation:ExecuteFunctionOperation';

    /**
     * Returns true if the given object is an instance of ExecuteFunctionOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ExecuteFunctionOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ExecuteFunctionOperation.__pulumiType;
    }

    /**
     * API parameter. Parameter format will depend on the actual function definition.
     */
    public readonly functionArg!: pulumi.Output<string>;
    /**
     * Name of called backend API.
     */
    public readonly functionName!: pulumi.Output<string>;

    /**
     * Create a ExecuteFunctionOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExecuteFunctionOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ExecuteFunctionOperationArgs | ExecuteFunctionOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ExecuteFunctionOperationState | undefined;
            resourceInputs["functionArg"] = state ? state.functionArg : undefined;
            resourceInputs["functionName"] = state ? state.functionName : undefined;
        } else {
            const args = argsOrState as ExecuteFunctionOperationArgs | undefined;
            if ((!args || args.functionArg === undefined) && !opts.urn) {
                throw new Error("Missing required property 'functionArg'");
            }
            if ((!args || args.functionName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'functionName'");
            }
            resourceInputs["functionArg"] = args ? args.functionArg : undefined;
            resourceInputs["functionName"] = args ? args.functionName : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ExecuteFunctionOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ExecuteFunctionOperation resources.
 */
export interface ExecuteFunctionOperationState {
    /**
     * API parameter. Parameter format will depend on the actual function definition.
     */
    functionArg?: pulumi.Input<string>;
    /**
     * Name of called backend API.
     */
    functionName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ExecuteFunctionOperation resource.
 */
export interface ExecuteFunctionOperationArgs {
    /**
     * API parameter. Parameter format will depend on the actual function definition.
     */
    functionArg: pulumi.Input<string>;
    /**
     * Name of called backend API.
     */
    functionName: pulumi.Input<string>;
}
