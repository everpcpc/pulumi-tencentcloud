// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package eb

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a eb eventRule
//
// ## Example Usage
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"encoding/json"
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Eb"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			foo, err := Eb.NewEventBus(ctx, "foo", &Eb.EventBusArgs{
//				EventBusName: pulumi.String("tf-event_bus"),
//				Description:  pulumi.String("event bus desc"),
//				EnableStore:  pulumi.Bool(false),
//				SaveDays:     pulumi.Int(1),
//				Tags: pulumi.Map{
//					"createdBy": pulumi.Any("terraform"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			tmpJSON0, err := json.Marshal(map[string]interface{}{
//				"source": "apigw.cloud.tencent",
//				"type": []string{
//					"connector:apigw",
//				},
//			})
//			if err != nil {
//				return err
//			}
//			json0 := string(tmpJSON0)
//			_, err = Eb.NewEventRule(ctx, "eventRule", &Eb.EventRuleArgs{
//				EventBusId:   foo.ID(),
//				RuleName:     pulumi.String("tf-event_rule"),
//				Description:  pulumi.String("event rule desc"),
//				Enable:       pulumi.Bool(true),
//				EventPattern: pulumi.String(json0),
//				Tags: pulumi.Map{
//					"createdBy": pulumi.Any("terraform"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
//
// ## Import
//
// eb event_rule can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Eb/eventRule:EventRule event_rule event_rule_id
// ```
type EventRule struct {
	pulumi.CustomResourceState

	// Event set description, unlimited character type, description within 200 characters.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Enable switch.
	Enable pulumi.BoolPtrOutput `pulumi:"enable"`
	// event bus Id.
	EventBusId pulumi.StringOutput `pulumi:"eventBusId"`
	// Reference: [Event Mode](https://cloud.tencent.com/document/product/1359/56084).
	EventPattern pulumi.StringOutput `pulumi:"eventPattern"`
	// event rule id.
	RuleId pulumi.StringOutput `pulumi:"ruleId"`
	// Event rule name, which can only contain letters, numbers, underscores, hyphens, starts with a letter and ends with a number or letter, 2~60 characters.
	RuleName pulumi.StringOutput `pulumi:"ruleName"`
	// Tag description list.
	Tags pulumi.MapOutput `pulumi:"tags"`
}

// NewEventRule registers a new resource with the given unique name, arguments, and options.
func NewEventRule(ctx *pulumi.Context,
	name string, args *EventRuleArgs, opts ...pulumi.ResourceOption) (*EventRule, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EventBusId == nil {
		return nil, errors.New("invalid value for required argument 'EventBusId'")
	}
	if args.EventPattern == nil {
		return nil, errors.New("invalid value for required argument 'EventPattern'")
	}
	if args.RuleName == nil {
		return nil, errors.New("invalid value for required argument 'RuleName'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource EventRule
	err := ctx.RegisterResource("tencentcloud:Eb/eventRule:EventRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEventRule gets an existing EventRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEventRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EventRuleState, opts ...pulumi.ResourceOption) (*EventRule, error) {
	var resource EventRule
	err := ctx.ReadResource("tencentcloud:Eb/eventRule:EventRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EventRule resources.
type eventRuleState struct {
	// Event set description, unlimited character type, description within 200 characters.
	Description *string `pulumi:"description"`
	// Enable switch.
	Enable *bool `pulumi:"enable"`
	// event bus Id.
	EventBusId *string `pulumi:"eventBusId"`
	// Reference: [Event Mode](https://cloud.tencent.com/document/product/1359/56084).
	EventPattern *string `pulumi:"eventPattern"`
	// event rule id.
	RuleId *string `pulumi:"ruleId"`
	// Event rule name, which can only contain letters, numbers, underscores, hyphens, starts with a letter and ends with a number or letter, 2~60 characters.
	RuleName *string `pulumi:"ruleName"`
	// Tag description list.
	Tags map[string]interface{} `pulumi:"tags"`
}

type EventRuleState struct {
	// Event set description, unlimited character type, description within 200 characters.
	Description pulumi.StringPtrInput
	// Enable switch.
	Enable pulumi.BoolPtrInput
	// event bus Id.
	EventBusId pulumi.StringPtrInput
	// Reference: [Event Mode](https://cloud.tencent.com/document/product/1359/56084).
	EventPattern pulumi.StringPtrInput
	// event rule id.
	RuleId pulumi.StringPtrInput
	// Event rule name, which can only contain letters, numbers, underscores, hyphens, starts with a letter and ends with a number or letter, 2~60 characters.
	RuleName pulumi.StringPtrInput
	// Tag description list.
	Tags pulumi.MapInput
}

func (EventRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*eventRuleState)(nil)).Elem()
}

type eventRuleArgs struct {
	// Event set description, unlimited character type, description within 200 characters.
	Description *string `pulumi:"description"`
	// Enable switch.
	Enable *bool `pulumi:"enable"`
	// event bus Id.
	EventBusId string `pulumi:"eventBusId"`
	// Reference: [Event Mode](https://cloud.tencent.com/document/product/1359/56084).
	EventPattern string `pulumi:"eventPattern"`
	// Event rule name, which can only contain letters, numbers, underscores, hyphens, starts with a letter and ends with a number or letter, 2~60 characters.
	RuleName string `pulumi:"ruleName"`
	// Tag description list.
	Tags map[string]interface{} `pulumi:"tags"`
}

// The set of arguments for constructing a EventRule resource.
type EventRuleArgs struct {
	// Event set description, unlimited character type, description within 200 characters.
	Description pulumi.StringPtrInput
	// Enable switch.
	Enable pulumi.BoolPtrInput
	// event bus Id.
	EventBusId pulumi.StringInput
	// Reference: [Event Mode](https://cloud.tencent.com/document/product/1359/56084).
	EventPattern pulumi.StringInput
	// Event rule name, which can only contain letters, numbers, underscores, hyphens, starts with a letter and ends with a number or letter, 2~60 characters.
	RuleName pulumi.StringInput
	// Tag description list.
	Tags pulumi.MapInput
}

func (EventRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*eventRuleArgs)(nil)).Elem()
}

type EventRuleInput interface {
	pulumi.Input

	ToEventRuleOutput() EventRuleOutput
	ToEventRuleOutputWithContext(ctx context.Context) EventRuleOutput
}

func (*EventRule) ElementType() reflect.Type {
	return reflect.TypeOf((**EventRule)(nil)).Elem()
}

func (i *EventRule) ToEventRuleOutput() EventRuleOutput {
	return i.ToEventRuleOutputWithContext(context.Background())
}

func (i *EventRule) ToEventRuleOutputWithContext(ctx context.Context) EventRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventRuleOutput)
}

// EventRuleArrayInput is an input type that accepts EventRuleArray and EventRuleArrayOutput values.
// You can construct a concrete instance of `EventRuleArrayInput` via:
//
//	EventRuleArray{ EventRuleArgs{...} }
type EventRuleArrayInput interface {
	pulumi.Input

	ToEventRuleArrayOutput() EventRuleArrayOutput
	ToEventRuleArrayOutputWithContext(context.Context) EventRuleArrayOutput
}

type EventRuleArray []EventRuleInput

func (EventRuleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*EventRule)(nil)).Elem()
}

func (i EventRuleArray) ToEventRuleArrayOutput() EventRuleArrayOutput {
	return i.ToEventRuleArrayOutputWithContext(context.Background())
}

func (i EventRuleArray) ToEventRuleArrayOutputWithContext(ctx context.Context) EventRuleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventRuleArrayOutput)
}

// EventRuleMapInput is an input type that accepts EventRuleMap and EventRuleMapOutput values.
// You can construct a concrete instance of `EventRuleMapInput` via:
//
//	EventRuleMap{ "key": EventRuleArgs{...} }
type EventRuleMapInput interface {
	pulumi.Input

	ToEventRuleMapOutput() EventRuleMapOutput
	ToEventRuleMapOutputWithContext(context.Context) EventRuleMapOutput
}

type EventRuleMap map[string]EventRuleInput

func (EventRuleMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*EventRule)(nil)).Elem()
}

func (i EventRuleMap) ToEventRuleMapOutput() EventRuleMapOutput {
	return i.ToEventRuleMapOutputWithContext(context.Background())
}

func (i EventRuleMap) ToEventRuleMapOutputWithContext(ctx context.Context) EventRuleMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventRuleMapOutput)
}

type EventRuleOutput struct{ *pulumi.OutputState }

func (EventRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EventRule)(nil)).Elem()
}

func (o EventRuleOutput) ToEventRuleOutput() EventRuleOutput {
	return o
}

func (o EventRuleOutput) ToEventRuleOutputWithContext(ctx context.Context) EventRuleOutput {
	return o
}

// Event set description, unlimited character type, description within 200 characters.
func (o EventRuleOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EventRule) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Enable switch.
func (o EventRuleOutput) Enable() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *EventRule) pulumi.BoolPtrOutput { return v.Enable }).(pulumi.BoolPtrOutput)
}

// event bus Id.
func (o EventRuleOutput) EventBusId() pulumi.StringOutput {
	return o.ApplyT(func(v *EventRule) pulumi.StringOutput { return v.EventBusId }).(pulumi.StringOutput)
}

// Reference: [Event Mode](https://cloud.tencent.com/document/product/1359/56084).
func (o EventRuleOutput) EventPattern() pulumi.StringOutput {
	return o.ApplyT(func(v *EventRule) pulumi.StringOutput { return v.EventPattern }).(pulumi.StringOutput)
}

// event rule id.
func (o EventRuleOutput) RuleId() pulumi.StringOutput {
	return o.ApplyT(func(v *EventRule) pulumi.StringOutput { return v.RuleId }).(pulumi.StringOutput)
}

// Event rule name, which can only contain letters, numbers, underscores, hyphens, starts with a letter and ends with a number or letter, 2~60 characters.
func (o EventRuleOutput) RuleName() pulumi.StringOutput {
	return o.ApplyT(func(v *EventRule) pulumi.StringOutput { return v.RuleName }).(pulumi.StringOutput)
}

// Tag description list.
func (o EventRuleOutput) Tags() pulumi.MapOutput {
	return o.ApplyT(func(v *EventRule) pulumi.MapOutput { return v.Tags }).(pulumi.MapOutput)
}

type EventRuleArrayOutput struct{ *pulumi.OutputState }

func (EventRuleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*EventRule)(nil)).Elem()
}

func (o EventRuleArrayOutput) ToEventRuleArrayOutput() EventRuleArrayOutput {
	return o
}

func (o EventRuleArrayOutput) ToEventRuleArrayOutputWithContext(ctx context.Context) EventRuleArrayOutput {
	return o
}

func (o EventRuleArrayOutput) Index(i pulumi.IntInput) EventRuleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *EventRule {
		return vs[0].([]*EventRule)[vs[1].(int)]
	}).(EventRuleOutput)
}

type EventRuleMapOutput struct{ *pulumi.OutputState }

func (EventRuleMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*EventRule)(nil)).Elem()
}

func (o EventRuleMapOutput) ToEventRuleMapOutput() EventRuleMapOutput {
	return o
}

func (o EventRuleMapOutput) ToEventRuleMapOutputWithContext(ctx context.Context) EventRuleMapOutput {
	return o
}

func (o EventRuleMapOutput) MapIndex(k pulumi.StringInput) EventRuleOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *EventRule {
		return vs[0].(map[string]*EventRule)[vs[1].(string)]
	}).(EventRuleOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*EventRuleInput)(nil)).Elem(), &EventRule{})
	pulumi.RegisterInputType(reflect.TypeOf((*EventRuleArrayInput)(nil)).Elem(), EventRuleArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*EventRuleMapInput)(nil)).Elem(), EventRuleMap{})
	pulumi.RegisterOutputType(EventRuleOutput{})
	pulumi.RegisterOutputType(EventRuleArrayOutput{})
	pulumi.RegisterOutputType(EventRuleMapOutput{})
}