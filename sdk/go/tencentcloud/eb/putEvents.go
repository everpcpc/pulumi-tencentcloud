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

// Provides a resource to create a eb putEvents
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
//				"topic":     "test-topic",
//				"Partition": 1,
//				"offset":    37,
//				"msgKey":    "test",
//				"msgBody":   "Hello from Ckafka again!",
//			})
//			if err != nil {
//				return err
//			}
//			json0 := string(tmpJSON0)
//			_, err = Eb.NewPutEvents(ctx, "putEvents", &Eb.PutEventsArgs{
//				EventLists: eb.PutEventsEventListArray{
//					&eb.PutEventsEventListArgs{
//						Source:  pulumi.String("ckafka.cloud.tencent"),
//						Data:    pulumi.String(json0),
//						Type:    pulumi.String("connector:ckafka"),
//						Subject: pulumi.String("qcs::ckafka:ap-guangzhou:uin/1250000000:ckafkaId/uin/1250000000/ckafka-123456"),
//						Time:    pulumi.Int(1691572461939),
//					},
//				},
//				EventBusId: foo.ID(),
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
type PutEvents struct {
	pulumi.CustomResourceState

	// event bus Id.
	EventBusId pulumi.StringOutput `pulumi:"eventBusId"`
	// event list.
	EventLists PutEventsEventListArrayOutput `pulumi:"eventLists"`
}

// NewPutEvents registers a new resource with the given unique name, arguments, and options.
func NewPutEvents(ctx *pulumi.Context,
	name string, args *PutEventsArgs, opts ...pulumi.ResourceOption) (*PutEvents, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EventBusId == nil {
		return nil, errors.New("invalid value for required argument 'EventBusId'")
	}
	if args.EventLists == nil {
		return nil, errors.New("invalid value for required argument 'EventLists'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource PutEvents
	err := ctx.RegisterResource("tencentcloud:Eb/putEvents:PutEvents", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPutEvents gets an existing PutEvents resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPutEvents(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PutEventsState, opts ...pulumi.ResourceOption) (*PutEvents, error) {
	var resource PutEvents
	err := ctx.ReadResource("tencentcloud:Eb/putEvents:PutEvents", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PutEvents resources.
type putEventsState struct {
	// event bus Id.
	EventBusId *string `pulumi:"eventBusId"`
	// event list.
	EventLists []PutEventsEventList `pulumi:"eventLists"`
}

type PutEventsState struct {
	// event bus Id.
	EventBusId pulumi.StringPtrInput
	// event list.
	EventLists PutEventsEventListArrayInput
}

func (PutEventsState) ElementType() reflect.Type {
	return reflect.TypeOf((*putEventsState)(nil)).Elem()
}

type putEventsArgs struct {
	// event bus Id.
	EventBusId string `pulumi:"eventBusId"`
	// event list.
	EventLists []PutEventsEventList `pulumi:"eventLists"`
}

// The set of arguments for constructing a PutEvents resource.
type PutEventsArgs struct {
	// event bus Id.
	EventBusId pulumi.StringInput
	// event list.
	EventLists PutEventsEventListArrayInput
}

func (PutEventsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*putEventsArgs)(nil)).Elem()
}

type PutEventsInput interface {
	pulumi.Input

	ToPutEventsOutput() PutEventsOutput
	ToPutEventsOutputWithContext(ctx context.Context) PutEventsOutput
}

func (*PutEvents) ElementType() reflect.Type {
	return reflect.TypeOf((**PutEvents)(nil)).Elem()
}

func (i *PutEvents) ToPutEventsOutput() PutEventsOutput {
	return i.ToPutEventsOutputWithContext(context.Background())
}

func (i *PutEvents) ToPutEventsOutputWithContext(ctx context.Context) PutEventsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PutEventsOutput)
}

// PutEventsArrayInput is an input type that accepts PutEventsArray and PutEventsArrayOutput values.
// You can construct a concrete instance of `PutEventsArrayInput` via:
//
//	PutEventsArray{ PutEventsArgs{...} }
type PutEventsArrayInput interface {
	pulumi.Input

	ToPutEventsArrayOutput() PutEventsArrayOutput
	ToPutEventsArrayOutputWithContext(context.Context) PutEventsArrayOutput
}

type PutEventsArray []PutEventsInput

func (PutEventsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PutEvents)(nil)).Elem()
}

func (i PutEventsArray) ToPutEventsArrayOutput() PutEventsArrayOutput {
	return i.ToPutEventsArrayOutputWithContext(context.Background())
}

func (i PutEventsArray) ToPutEventsArrayOutputWithContext(ctx context.Context) PutEventsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PutEventsArrayOutput)
}

// PutEventsMapInput is an input type that accepts PutEventsMap and PutEventsMapOutput values.
// You can construct a concrete instance of `PutEventsMapInput` via:
//
//	PutEventsMap{ "key": PutEventsArgs{...} }
type PutEventsMapInput interface {
	pulumi.Input

	ToPutEventsMapOutput() PutEventsMapOutput
	ToPutEventsMapOutputWithContext(context.Context) PutEventsMapOutput
}

type PutEventsMap map[string]PutEventsInput

func (PutEventsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PutEvents)(nil)).Elem()
}

func (i PutEventsMap) ToPutEventsMapOutput() PutEventsMapOutput {
	return i.ToPutEventsMapOutputWithContext(context.Background())
}

func (i PutEventsMap) ToPutEventsMapOutputWithContext(ctx context.Context) PutEventsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PutEventsMapOutput)
}

type PutEventsOutput struct{ *pulumi.OutputState }

func (PutEventsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PutEvents)(nil)).Elem()
}

func (o PutEventsOutput) ToPutEventsOutput() PutEventsOutput {
	return o
}

func (o PutEventsOutput) ToPutEventsOutputWithContext(ctx context.Context) PutEventsOutput {
	return o
}

// event bus Id.
func (o PutEventsOutput) EventBusId() pulumi.StringOutput {
	return o.ApplyT(func(v *PutEvents) pulumi.StringOutput { return v.EventBusId }).(pulumi.StringOutput)
}

// event list.
func (o PutEventsOutput) EventLists() PutEventsEventListArrayOutput {
	return o.ApplyT(func(v *PutEvents) PutEventsEventListArrayOutput { return v.EventLists }).(PutEventsEventListArrayOutput)
}

type PutEventsArrayOutput struct{ *pulumi.OutputState }

func (PutEventsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PutEvents)(nil)).Elem()
}

func (o PutEventsArrayOutput) ToPutEventsArrayOutput() PutEventsArrayOutput {
	return o
}

func (o PutEventsArrayOutput) ToPutEventsArrayOutputWithContext(ctx context.Context) PutEventsArrayOutput {
	return o
}

func (o PutEventsArrayOutput) Index(i pulumi.IntInput) PutEventsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *PutEvents {
		return vs[0].([]*PutEvents)[vs[1].(int)]
	}).(PutEventsOutput)
}

type PutEventsMapOutput struct{ *pulumi.OutputState }

func (PutEventsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PutEvents)(nil)).Elem()
}

func (o PutEventsMapOutput) ToPutEventsMapOutput() PutEventsMapOutput {
	return o
}

func (o PutEventsMapOutput) ToPutEventsMapOutputWithContext(ctx context.Context) PutEventsMapOutput {
	return o
}

func (o PutEventsMapOutput) MapIndex(k pulumi.StringInput) PutEventsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *PutEvents {
		return vs[0].(map[string]*PutEvents)[vs[1].(string)]
	}).(PutEventsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PutEventsInput)(nil)).Elem(), &PutEvents{})
	pulumi.RegisterInputType(reflect.TypeOf((*PutEventsArrayInput)(nil)).Elem(), PutEventsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*PutEventsMapInput)(nil)).Elem(), PutEventsMap{})
	pulumi.RegisterOutputType(PutEventsOutput{})
	pulumi.RegisterOutputType(PutEventsArrayOutput{})
	pulumi.RegisterOutputType(PutEventsMapOutput{})
}