// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a cfw vpcPolicy
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.cfw.VpcPolicy("example", {
 *     description: "description.",
 *     destContent: "192.168.0.2",
 *     destType: "net",
 *     enable: "true",
 *     fwGroupId: "ALL",
 *     port: "-1/-1",
 *     protocol: "ANY",
 *     ruleAction: "log",
 *     sourceContent: "0.0.0.0/0",
 *     sourceType: "net",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * cfw vpc_policy can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Cfw/vpcPolicy:VpcPolicy vpc_policy vpc_policy_id
 * ```
 */
export class VpcPolicy extends pulumi.CustomResource {
    /**
     * Get an existing VpcPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VpcPolicyState, opts?: pulumi.CustomResourceOptions): VpcPolicy {
        return new VpcPolicy(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Cfw/vpcPolicy:VpcPolicy';

    /**
     * Returns true if the given object is an instance of VpcPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VpcPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VpcPolicy.__pulumiType;
    }

    /**
     * Beta mission details. Note: This field may return null, indicating that no valid value can be obtained.
     */
    public /*out*/ readonly betaLists!: pulumi.Output<outputs.Cfw.VpcPolicyBetaList[]>;
    /**
     * Describe.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * Access purpose example: net:IP/CIDR(192.168.0.2) domain:domain rule, for example*.qq.com.
     */
    public readonly destContent!: pulumi.Output<string>;
    /**
     * Access purpose type, the type can be: net, template.
     */
    public readonly destType!: pulumi.Output<string>;
    /**
     * Rule status, true means enabled, false means disabled. Default is true.
     */
    public readonly enable!: pulumi.Output<string | undefined>;
    /**
     * Firewall instance ID where the rule takes effect. Default is ALL.
     */
    public readonly fwGroupId!: pulumi.Output<string | undefined>;
    /**
     * Firewall name.
     */
    public /*out*/ readonly fwGroupName!: pulumi.Output<string>;
    /**
     * Uuid used internally, this field is generally not used.
     */
    public /*out*/ readonly internalUuid!: pulumi.Output<number>;
    /**
     * Parameter template id. Note: This field may return null, indicating that no valid value can be obtained.
     */
    public /*out*/ readonly paramTemplateId!: pulumi.Output<string>;
    /**
     * Parameter template Name. Note: This field may return null, indicating that no valid value can be obtained.
     */
    public /*out*/ readonly paramTemplateName!: pulumi.Output<string>;
    /**
     * The port for the access control policy. Value: -1/-1: All ports; 80: port 80.
     */
    public readonly port!: pulumi.Output<string>;
    /**
     * Protocol, optional value:TCP, UDP, ICMP, ANY, HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL.
     */
    public readonly protocol!: pulumi.Output<string>;
    /**
     * How traffic set in the access control policy passes through the cloud firewall. Value: accept:accept, drop:drop, log:log.
     */
    public readonly ruleAction!: pulumi.Output<string>;
    /**
     * Access source examplnet:IP/CIDR(192.168.0.2).
     */
    public readonly sourceContent!: pulumi.Output<string>;
    /**
     * Access source type, the type can be: net, template.
     */
    public readonly sourceType!: pulumi.Output<string>;
    /**
     * The unique id corresponding to the rule.
     */
    public /*out*/ readonly uuid!: pulumi.Output<number>;

    /**
     * Create a VpcPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VpcPolicyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VpcPolicyArgs | VpcPolicyState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as VpcPolicyState | undefined;
            resourceInputs["betaLists"] = state ? state.betaLists : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["destContent"] = state ? state.destContent : undefined;
            resourceInputs["destType"] = state ? state.destType : undefined;
            resourceInputs["enable"] = state ? state.enable : undefined;
            resourceInputs["fwGroupId"] = state ? state.fwGroupId : undefined;
            resourceInputs["fwGroupName"] = state ? state.fwGroupName : undefined;
            resourceInputs["internalUuid"] = state ? state.internalUuid : undefined;
            resourceInputs["paramTemplateId"] = state ? state.paramTemplateId : undefined;
            resourceInputs["paramTemplateName"] = state ? state.paramTemplateName : undefined;
            resourceInputs["port"] = state ? state.port : undefined;
            resourceInputs["protocol"] = state ? state.protocol : undefined;
            resourceInputs["ruleAction"] = state ? state.ruleAction : undefined;
            resourceInputs["sourceContent"] = state ? state.sourceContent : undefined;
            resourceInputs["sourceType"] = state ? state.sourceType : undefined;
            resourceInputs["uuid"] = state ? state.uuid : undefined;
        } else {
            const args = argsOrState as VpcPolicyArgs | undefined;
            if ((!args || args.description === undefined) && !opts.urn) {
                throw new Error("Missing required property 'description'");
            }
            if ((!args || args.destContent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'destContent'");
            }
            if ((!args || args.destType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'destType'");
            }
            if ((!args || args.port === undefined) && !opts.urn) {
                throw new Error("Missing required property 'port'");
            }
            if ((!args || args.protocol === undefined) && !opts.urn) {
                throw new Error("Missing required property 'protocol'");
            }
            if ((!args || args.ruleAction === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ruleAction'");
            }
            if ((!args || args.sourceContent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sourceContent'");
            }
            if ((!args || args.sourceType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sourceType'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["destContent"] = args ? args.destContent : undefined;
            resourceInputs["destType"] = args ? args.destType : undefined;
            resourceInputs["enable"] = args ? args.enable : undefined;
            resourceInputs["fwGroupId"] = args ? args.fwGroupId : undefined;
            resourceInputs["port"] = args ? args.port : undefined;
            resourceInputs["protocol"] = args ? args.protocol : undefined;
            resourceInputs["ruleAction"] = args ? args.ruleAction : undefined;
            resourceInputs["sourceContent"] = args ? args.sourceContent : undefined;
            resourceInputs["sourceType"] = args ? args.sourceType : undefined;
            resourceInputs["betaLists"] = undefined /*out*/;
            resourceInputs["fwGroupName"] = undefined /*out*/;
            resourceInputs["internalUuid"] = undefined /*out*/;
            resourceInputs["paramTemplateId"] = undefined /*out*/;
            resourceInputs["paramTemplateName"] = undefined /*out*/;
            resourceInputs["uuid"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(VpcPolicy.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VpcPolicy resources.
 */
export interface VpcPolicyState {
    /**
     * Beta mission details. Note: This field may return null, indicating that no valid value can be obtained.
     */
    betaLists?: pulumi.Input<pulumi.Input<inputs.Cfw.VpcPolicyBetaList>[]>;
    /**
     * Describe.
     */
    description?: pulumi.Input<string>;
    /**
     * Access purpose example: net:IP/CIDR(192.168.0.2) domain:domain rule, for example*.qq.com.
     */
    destContent?: pulumi.Input<string>;
    /**
     * Access purpose type, the type can be: net, template.
     */
    destType?: pulumi.Input<string>;
    /**
     * Rule status, true means enabled, false means disabled. Default is true.
     */
    enable?: pulumi.Input<string>;
    /**
     * Firewall instance ID where the rule takes effect. Default is ALL.
     */
    fwGroupId?: pulumi.Input<string>;
    /**
     * Firewall name.
     */
    fwGroupName?: pulumi.Input<string>;
    /**
     * Uuid used internally, this field is generally not used.
     */
    internalUuid?: pulumi.Input<number>;
    /**
     * Parameter template id. Note: This field may return null, indicating that no valid value can be obtained.
     */
    paramTemplateId?: pulumi.Input<string>;
    /**
     * Parameter template Name. Note: This field may return null, indicating that no valid value can be obtained.
     */
    paramTemplateName?: pulumi.Input<string>;
    /**
     * The port for the access control policy. Value: -1/-1: All ports; 80: port 80.
     */
    port?: pulumi.Input<string>;
    /**
     * Protocol, optional value:TCP, UDP, ICMP, ANY, HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL.
     */
    protocol?: pulumi.Input<string>;
    /**
     * How traffic set in the access control policy passes through the cloud firewall. Value: accept:accept, drop:drop, log:log.
     */
    ruleAction?: pulumi.Input<string>;
    /**
     * Access source examplnet:IP/CIDR(192.168.0.2).
     */
    sourceContent?: pulumi.Input<string>;
    /**
     * Access source type, the type can be: net, template.
     */
    sourceType?: pulumi.Input<string>;
    /**
     * The unique id corresponding to the rule.
     */
    uuid?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a VpcPolicy resource.
 */
export interface VpcPolicyArgs {
    /**
     * Describe.
     */
    description: pulumi.Input<string>;
    /**
     * Access purpose example: net:IP/CIDR(192.168.0.2) domain:domain rule, for example*.qq.com.
     */
    destContent: pulumi.Input<string>;
    /**
     * Access purpose type, the type can be: net, template.
     */
    destType: pulumi.Input<string>;
    /**
     * Rule status, true means enabled, false means disabled. Default is true.
     */
    enable?: pulumi.Input<string>;
    /**
     * Firewall instance ID where the rule takes effect. Default is ALL.
     */
    fwGroupId?: pulumi.Input<string>;
    /**
     * The port for the access control policy. Value: -1/-1: All ports; 80: port 80.
     */
    port: pulumi.Input<string>;
    /**
     * Protocol, optional value:TCP, UDP, ICMP, ANY, HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL.
     */
    protocol: pulumi.Input<string>;
    /**
     * How traffic set in the access control policy passes through the cloud firewall. Value: accept:accept, drop:drop, log:log.
     */
    ruleAction: pulumi.Input<string>;
    /**
     * Access source examplnet:IP/CIDR(192.168.0.2).
     */
    sourceContent: pulumi.Input<string>;
    /**
     * Access source type, the type can be: net, template.
     */
    sourceType: pulumi.Input<string>;
}