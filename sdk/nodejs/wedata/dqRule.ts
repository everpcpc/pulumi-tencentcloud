// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a wedata dqRule
 *
 * ## Import
 *
 * wedata dq_rule can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Wedata/dqRule:DqRule example 1948767646355341312#894
 * ```
 */
export class DqRule extends pulumi.CustomResource {
    /**
     * Get an existing DqRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DqRuleState, opts?: pulumi.CustomResourceOptions): DqRule {
        return new DqRule(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Wedata/dqRule:DqRule';

    /**
     * Returns true if the given object is an instance of DqRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DqRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DqRule.__pulumiType;
    }

    /**
     * Alarm trigger levels 1. Low, 2. Medium, 3. High.
     */
    public readonly alarmLevel!: pulumi.Output<number>;
    /**
     * Alarm trigger condition.
     */
    public readonly compareRule!: pulumi.Output<outputs.Wedata.DqRuleCompareRule>;
    /**
     * Condition scans WHERE condition expressions.
     */
    public readonly conditionExpression!: pulumi.Output<string | undefined>;
    /**
     * Detection scope 1. Full Table 2. Conditional scan.
     */
    public readonly conditionType!: pulumi.Output<number>;
    /**
     * Custom sql.
     */
    public readonly customSql!: pulumi.Output<string | undefined>;
    /**
     * Rule description.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Custom template sql expression field replacement parameters.
     */
    public readonly fieldConfig!: pulumi.Output<outputs.Wedata.DqRuleFieldConfig | undefined>;
    /**
     * Rule name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Project id.
     */
    public readonly projectId!: pulumi.Output<string>;
    /**
     * Rules belong to quality dimensions (1. accuracy, 2. uniqueness, 3. completeness, 4. consistency, 5. timeliness, 6. effectiveness).
     */
    public readonly qualityDim!: pulumi.Output<number>;
    /**
     * The source field and the target field are associated with a conditional on expression.
     */
    public readonly relConditionExpr!: pulumi.Output<string | undefined>;
    /**
     * Rule group id.
     */
    public readonly ruleGroupId!: pulumi.Output<number | undefined>;
    /**
     * Rule ID.
     */
    public /*out*/ readonly ruleId!: pulumi.Output<string>;
    /**
     * Rule template id.
     */
    public readonly ruleTemplateId!: pulumi.Output<number>;
    /**
     * List of execution engines supported by this rule.
     */
    public readonly sourceEngineTypes!: pulumi.Output<number[]>;
    /**
     * Source field type. int, string.
     */
    public readonly sourceObjectDataTypeName!: pulumi.Output<string>;
    /**
     * Source field name.
     */
    public readonly sourceObjectValue!: pulumi.Output<string>;
    /**
     * Table id.
     */
    public readonly tableId!: pulumi.Output<string | undefined>;
    /**
     * Target filter condition expression.
     */
    public readonly targetConditionExpr!: pulumi.Output<string | undefined>;
    /**
     * Target database id.
     */
    public readonly targetDatabaseId!: pulumi.Output<string | undefined>;
    /**
     * Target field name  CITY.
     */
    public readonly targetObjectValue!: pulumi.Output<string | undefined>;
    /**
     * Target table id.
     */
    public readonly targetTableId!: pulumi.Output<string | undefined>;
    /**
     * Rule Type 1. System Template, 2. Custom Template, 3. Custom SQL.
     */
    public readonly type!: pulumi.Output<number>;

    /**
     * Create a DqRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DqRuleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DqRuleArgs | DqRuleState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DqRuleState | undefined;
            resourceInputs["alarmLevel"] = state ? state.alarmLevel : undefined;
            resourceInputs["compareRule"] = state ? state.compareRule : undefined;
            resourceInputs["conditionExpression"] = state ? state.conditionExpression : undefined;
            resourceInputs["conditionType"] = state ? state.conditionType : undefined;
            resourceInputs["customSql"] = state ? state.customSql : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["fieldConfig"] = state ? state.fieldConfig : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["projectId"] = state ? state.projectId : undefined;
            resourceInputs["qualityDim"] = state ? state.qualityDim : undefined;
            resourceInputs["relConditionExpr"] = state ? state.relConditionExpr : undefined;
            resourceInputs["ruleGroupId"] = state ? state.ruleGroupId : undefined;
            resourceInputs["ruleId"] = state ? state.ruleId : undefined;
            resourceInputs["ruleTemplateId"] = state ? state.ruleTemplateId : undefined;
            resourceInputs["sourceEngineTypes"] = state ? state.sourceEngineTypes : undefined;
            resourceInputs["sourceObjectDataTypeName"] = state ? state.sourceObjectDataTypeName : undefined;
            resourceInputs["sourceObjectValue"] = state ? state.sourceObjectValue : undefined;
            resourceInputs["tableId"] = state ? state.tableId : undefined;
            resourceInputs["targetConditionExpr"] = state ? state.targetConditionExpr : undefined;
            resourceInputs["targetDatabaseId"] = state ? state.targetDatabaseId : undefined;
            resourceInputs["targetObjectValue"] = state ? state.targetObjectValue : undefined;
            resourceInputs["targetTableId"] = state ? state.targetTableId : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as DqRuleArgs | undefined;
            if ((!args || args.alarmLevel === undefined) && !opts.urn) {
                throw new Error("Missing required property 'alarmLevel'");
            }
            if ((!args || args.compareRule === undefined) && !opts.urn) {
                throw new Error("Missing required property 'compareRule'");
            }
            if ((!args || args.conditionType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'conditionType'");
            }
            if ((!args || args.projectId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectId'");
            }
            if ((!args || args.ruleTemplateId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ruleTemplateId'");
            }
            if ((!args || args.sourceObjectDataTypeName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sourceObjectDataTypeName'");
            }
            if ((!args || args.sourceObjectValue === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sourceObjectValue'");
            }
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            resourceInputs["alarmLevel"] = args ? args.alarmLevel : undefined;
            resourceInputs["compareRule"] = args ? args.compareRule : undefined;
            resourceInputs["conditionExpression"] = args ? args.conditionExpression : undefined;
            resourceInputs["conditionType"] = args ? args.conditionType : undefined;
            resourceInputs["customSql"] = args ? args.customSql : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["fieldConfig"] = args ? args.fieldConfig : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["projectId"] = args ? args.projectId : undefined;
            resourceInputs["qualityDim"] = args ? args.qualityDim : undefined;
            resourceInputs["relConditionExpr"] = args ? args.relConditionExpr : undefined;
            resourceInputs["ruleGroupId"] = args ? args.ruleGroupId : undefined;
            resourceInputs["ruleTemplateId"] = args ? args.ruleTemplateId : undefined;
            resourceInputs["sourceEngineTypes"] = args ? args.sourceEngineTypes : undefined;
            resourceInputs["sourceObjectDataTypeName"] = args ? args.sourceObjectDataTypeName : undefined;
            resourceInputs["sourceObjectValue"] = args ? args.sourceObjectValue : undefined;
            resourceInputs["tableId"] = args ? args.tableId : undefined;
            resourceInputs["targetConditionExpr"] = args ? args.targetConditionExpr : undefined;
            resourceInputs["targetDatabaseId"] = args ? args.targetDatabaseId : undefined;
            resourceInputs["targetObjectValue"] = args ? args.targetObjectValue : undefined;
            resourceInputs["targetTableId"] = args ? args.targetTableId : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["ruleId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DqRule.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DqRule resources.
 */
export interface DqRuleState {
    /**
     * Alarm trigger levels 1. Low, 2. Medium, 3. High.
     */
    alarmLevel?: pulumi.Input<number>;
    /**
     * Alarm trigger condition.
     */
    compareRule?: pulumi.Input<inputs.Wedata.DqRuleCompareRule>;
    /**
     * Condition scans WHERE condition expressions.
     */
    conditionExpression?: pulumi.Input<string>;
    /**
     * Detection scope 1. Full Table 2. Conditional scan.
     */
    conditionType?: pulumi.Input<number>;
    /**
     * Custom sql.
     */
    customSql?: pulumi.Input<string>;
    /**
     * Rule description.
     */
    description?: pulumi.Input<string>;
    /**
     * Custom template sql expression field replacement parameters.
     */
    fieldConfig?: pulumi.Input<inputs.Wedata.DqRuleFieldConfig>;
    /**
     * Rule name.
     */
    name?: pulumi.Input<string>;
    /**
     * Project id.
     */
    projectId?: pulumi.Input<string>;
    /**
     * Rules belong to quality dimensions (1. accuracy, 2. uniqueness, 3. completeness, 4. consistency, 5. timeliness, 6. effectiveness).
     */
    qualityDim?: pulumi.Input<number>;
    /**
     * The source field and the target field are associated with a conditional on expression.
     */
    relConditionExpr?: pulumi.Input<string>;
    /**
     * Rule group id.
     */
    ruleGroupId?: pulumi.Input<number>;
    /**
     * Rule ID.
     */
    ruleId?: pulumi.Input<string>;
    /**
     * Rule template id.
     */
    ruleTemplateId?: pulumi.Input<number>;
    /**
     * List of execution engines supported by this rule.
     */
    sourceEngineTypes?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Source field type. int, string.
     */
    sourceObjectDataTypeName?: pulumi.Input<string>;
    /**
     * Source field name.
     */
    sourceObjectValue?: pulumi.Input<string>;
    /**
     * Table id.
     */
    tableId?: pulumi.Input<string>;
    /**
     * Target filter condition expression.
     */
    targetConditionExpr?: pulumi.Input<string>;
    /**
     * Target database id.
     */
    targetDatabaseId?: pulumi.Input<string>;
    /**
     * Target field name  CITY.
     */
    targetObjectValue?: pulumi.Input<string>;
    /**
     * Target table id.
     */
    targetTableId?: pulumi.Input<string>;
    /**
     * Rule Type 1. System Template, 2. Custom Template, 3. Custom SQL.
     */
    type?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a DqRule resource.
 */
export interface DqRuleArgs {
    /**
     * Alarm trigger levels 1. Low, 2. Medium, 3. High.
     */
    alarmLevel: pulumi.Input<number>;
    /**
     * Alarm trigger condition.
     */
    compareRule: pulumi.Input<inputs.Wedata.DqRuleCompareRule>;
    /**
     * Condition scans WHERE condition expressions.
     */
    conditionExpression?: pulumi.Input<string>;
    /**
     * Detection scope 1. Full Table 2. Conditional scan.
     */
    conditionType: pulumi.Input<number>;
    /**
     * Custom sql.
     */
    customSql?: pulumi.Input<string>;
    /**
     * Rule description.
     */
    description?: pulumi.Input<string>;
    /**
     * Custom template sql expression field replacement parameters.
     */
    fieldConfig?: pulumi.Input<inputs.Wedata.DqRuleFieldConfig>;
    /**
     * Rule name.
     */
    name?: pulumi.Input<string>;
    /**
     * Project id.
     */
    projectId: pulumi.Input<string>;
    /**
     * Rules belong to quality dimensions (1. accuracy, 2. uniqueness, 3. completeness, 4. consistency, 5. timeliness, 6. effectiveness).
     */
    qualityDim?: pulumi.Input<number>;
    /**
     * The source field and the target field are associated with a conditional on expression.
     */
    relConditionExpr?: pulumi.Input<string>;
    /**
     * Rule group id.
     */
    ruleGroupId?: pulumi.Input<number>;
    /**
     * Rule template id.
     */
    ruleTemplateId: pulumi.Input<number>;
    /**
     * List of execution engines supported by this rule.
     */
    sourceEngineTypes?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Source field type. int, string.
     */
    sourceObjectDataTypeName: pulumi.Input<string>;
    /**
     * Source field name.
     */
    sourceObjectValue: pulumi.Input<string>;
    /**
     * Table id.
     */
    tableId?: pulumi.Input<string>;
    /**
     * Target filter condition expression.
     */
    targetConditionExpr?: pulumi.Input<string>;
    /**
     * Target database id.
     */
    targetDatabaseId?: pulumi.Input<string>;
    /**
     * Target field name  CITY.
     */
    targetObjectValue?: pulumi.Input<string>;
    /**
     * Target table id.
     */
    targetTableId?: pulumi.Input<string>;
    /**
     * Rule Type 1. System Template, 2. Custom Template, 3. Custom SQL.
     */
    type: pulumi.Input<number>;
}
