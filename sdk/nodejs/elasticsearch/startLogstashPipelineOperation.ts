// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to start a elasticsearch logstash pipeline
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const startLogstashPipelineOperation = new tencentcloud.elasticsearch.StartLogstashPipelineOperation("startLogstashPipelineOperation", {
 *     instanceId: "ls-xxxxxx",
 *     pipelineId: "xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class StartLogstashPipelineOperation extends pulumi.CustomResource {
    /**
     * Get an existing StartLogstashPipelineOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: StartLogstashPipelineOperationState, opts?: pulumi.CustomResourceOptions): StartLogstashPipelineOperation {
        return new StartLogstashPipelineOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Elasticsearch/startLogstashPipelineOperation:StartLogstashPipelineOperation';

    /**
     * Returns true if the given object is an instance of StartLogstashPipelineOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StartLogstashPipelineOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StartLogstashPipelineOperation.__pulumiType;
    }

    /**
     * Instance id.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Pipeline id.
     */
    public readonly pipelineId!: pulumi.Output<string>;

    /**
     * Create a StartLogstashPipelineOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: StartLogstashPipelineOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: StartLogstashPipelineOperationArgs | StartLogstashPipelineOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as StartLogstashPipelineOperationState | undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["pipelineId"] = state ? state.pipelineId : undefined;
        } else {
            const args = argsOrState as StartLogstashPipelineOperationArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.pipelineId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'pipelineId'");
            }
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["pipelineId"] = args ? args.pipelineId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(StartLogstashPipelineOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering StartLogstashPipelineOperation resources.
 */
export interface StartLogstashPipelineOperationState {
    /**
     * Instance id.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Pipeline id.
     */
    pipelineId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a StartLogstashPipelineOperation resource.
 */
export interface StartLogstashPipelineOperationArgs {
    /**
     * Instance id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Pipeline id.
     */
    pipelineId: pulumi.Input<string>;
}