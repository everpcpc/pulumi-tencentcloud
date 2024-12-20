// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dlc

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

type AttachWorkGroupPolicyOperation struct {
	pulumi.CustomResourceState

	// The set of policies to be bound.
	PolicySets AttachWorkGroupPolicyOperationPolicySetArrayOutput `pulumi:"policySets"`
	// Work group id.
	WorkGroupId pulumi.IntOutput `pulumi:"workGroupId"`
}

// NewAttachWorkGroupPolicyOperation registers a new resource with the given unique name, arguments, and options.
func NewAttachWorkGroupPolicyOperation(ctx *pulumi.Context,
	name string, args *AttachWorkGroupPolicyOperationArgs, opts ...pulumi.ResourceOption) (*AttachWorkGroupPolicyOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.WorkGroupId == nil {
		return nil, errors.New("invalid value for required argument 'WorkGroupId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AttachWorkGroupPolicyOperation
	err := ctx.RegisterResource("tencentcloud:Dlc/attachWorkGroupPolicyOperation:AttachWorkGroupPolicyOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAttachWorkGroupPolicyOperation gets an existing AttachWorkGroupPolicyOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAttachWorkGroupPolicyOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AttachWorkGroupPolicyOperationState, opts ...pulumi.ResourceOption) (*AttachWorkGroupPolicyOperation, error) {
	var resource AttachWorkGroupPolicyOperation
	err := ctx.ReadResource("tencentcloud:Dlc/attachWorkGroupPolicyOperation:AttachWorkGroupPolicyOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AttachWorkGroupPolicyOperation resources.
type attachWorkGroupPolicyOperationState struct {
	// The set of policies to be bound.
	PolicySets []AttachWorkGroupPolicyOperationPolicySet `pulumi:"policySets"`
	// Work group id.
	WorkGroupId *int `pulumi:"workGroupId"`
}

type AttachWorkGroupPolicyOperationState struct {
	// The set of policies to be bound.
	PolicySets AttachWorkGroupPolicyOperationPolicySetArrayInput
	// Work group id.
	WorkGroupId pulumi.IntPtrInput
}

func (AttachWorkGroupPolicyOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*attachWorkGroupPolicyOperationState)(nil)).Elem()
}

type attachWorkGroupPolicyOperationArgs struct {
	// The set of policies to be bound.
	PolicySets []AttachWorkGroupPolicyOperationPolicySet `pulumi:"policySets"`
	// Work group id.
	WorkGroupId int `pulumi:"workGroupId"`
}

// The set of arguments for constructing a AttachWorkGroupPolicyOperation resource.
type AttachWorkGroupPolicyOperationArgs struct {
	// The set of policies to be bound.
	PolicySets AttachWorkGroupPolicyOperationPolicySetArrayInput
	// Work group id.
	WorkGroupId pulumi.IntInput
}

func (AttachWorkGroupPolicyOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*attachWorkGroupPolicyOperationArgs)(nil)).Elem()
}

type AttachWorkGroupPolicyOperationInput interface {
	pulumi.Input

	ToAttachWorkGroupPolicyOperationOutput() AttachWorkGroupPolicyOperationOutput
	ToAttachWorkGroupPolicyOperationOutputWithContext(ctx context.Context) AttachWorkGroupPolicyOperationOutput
}

func (*AttachWorkGroupPolicyOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**AttachWorkGroupPolicyOperation)(nil)).Elem()
}

func (i *AttachWorkGroupPolicyOperation) ToAttachWorkGroupPolicyOperationOutput() AttachWorkGroupPolicyOperationOutput {
	return i.ToAttachWorkGroupPolicyOperationOutputWithContext(context.Background())
}

func (i *AttachWorkGroupPolicyOperation) ToAttachWorkGroupPolicyOperationOutputWithContext(ctx context.Context) AttachWorkGroupPolicyOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttachWorkGroupPolicyOperationOutput)
}

// AttachWorkGroupPolicyOperationArrayInput is an input type that accepts AttachWorkGroupPolicyOperationArray and AttachWorkGroupPolicyOperationArrayOutput values.
// You can construct a concrete instance of `AttachWorkGroupPolicyOperationArrayInput` via:
//
//	AttachWorkGroupPolicyOperationArray{ AttachWorkGroupPolicyOperationArgs{...} }
type AttachWorkGroupPolicyOperationArrayInput interface {
	pulumi.Input

	ToAttachWorkGroupPolicyOperationArrayOutput() AttachWorkGroupPolicyOperationArrayOutput
	ToAttachWorkGroupPolicyOperationArrayOutputWithContext(context.Context) AttachWorkGroupPolicyOperationArrayOutput
}

type AttachWorkGroupPolicyOperationArray []AttachWorkGroupPolicyOperationInput

func (AttachWorkGroupPolicyOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AttachWorkGroupPolicyOperation)(nil)).Elem()
}

func (i AttachWorkGroupPolicyOperationArray) ToAttachWorkGroupPolicyOperationArrayOutput() AttachWorkGroupPolicyOperationArrayOutput {
	return i.ToAttachWorkGroupPolicyOperationArrayOutputWithContext(context.Background())
}

func (i AttachWorkGroupPolicyOperationArray) ToAttachWorkGroupPolicyOperationArrayOutputWithContext(ctx context.Context) AttachWorkGroupPolicyOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttachWorkGroupPolicyOperationArrayOutput)
}

// AttachWorkGroupPolicyOperationMapInput is an input type that accepts AttachWorkGroupPolicyOperationMap and AttachWorkGroupPolicyOperationMapOutput values.
// You can construct a concrete instance of `AttachWorkGroupPolicyOperationMapInput` via:
//
//	AttachWorkGroupPolicyOperationMap{ "key": AttachWorkGroupPolicyOperationArgs{...} }
type AttachWorkGroupPolicyOperationMapInput interface {
	pulumi.Input

	ToAttachWorkGroupPolicyOperationMapOutput() AttachWorkGroupPolicyOperationMapOutput
	ToAttachWorkGroupPolicyOperationMapOutputWithContext(context.Context) AttachWorkGroupPolicyOperationMapOutput
}

type AttachWorkGroupPolicyOperationMap map[string]AttachWorkGroupPolicyOperationInput

func (AttachWorkGroupPolicyOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AttachWorkGroupPolicyOperation)(nil)).Elem()
}

func (i AttachWorkGroupPolicyOperationMap) ToAttachWorkGroupPolicyOperationMapOutput() AttachWorkGroupPolicyOperationMapOutput {
	return i.ToAttachWorkGroupPolicyOperationMapOutputWithContext(context.Background())
}

func (i AttachWorkGroupPolicyOperationMap) ToAttachWorkGroupPolicyOperationMapOutputWithContext(ctx context.Context) AttachWorkGroupPolicyOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttachWorkGroupPolicyOperationMapOutput)
}

type AttachWorkGroupPolicyOperationOutput struct{ *pulumi.OutputState }

func (AttachWorkGroupPolicyOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AttachWorkGroupPolicyOperation)(nil)).Elem()
}

func (o AttachWorkGroupPolicyOperationOutput) ToAttachWorkGroupPolicyOperationOutput() AttachWorkGroupPolicyOperationOutput {
	return o
}

func (o AttachWorkGroupPolicyOperationOutput) ToAttachWorkGroupPolicyOperationOutputWithContext(ctx context.Context) AttachWorkGroupPolicyOperationOutput {
	return o
}

// The set of policies to be bound.
func (o AttachWorkGroupPolicyOperationOutput) PolicySets() AttachWorkGroupPolicyOperationPolicySetArrayOutput {
	return o.ApplyT(func(v *AttachWorkGroupPolicyOperation) AttachWorkGroupPolicyOperationPolicySetArrayOutput {
		return v.PolicySets
	}).(AttachWorkGroupPolicyOperationPolicySetArrayOutput)
}

// Work group id.
func (o AttachWorkGroupPolicyOperationOutput) WorkGroupId() pulumi.IntOutput {
	return o.ApplyT(func(v *AttachWorkGroupPolicyOperation) pulumi.IntOutput { return v.WorkGroupId }).(pulumi.IntOutput)
}

type AttachWorkGroupPolicyOperationArrayOutput struct{ *pulumi.OutputState }

func (AttachWorkGroupPolicyOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AttachWorkGroupPolicyOperation)(nil)).Elem()
}

func (o AttachWorkGroupPolicyOperationArrayOutput) ToAttachWorkGroupPolicyOperationArrayOutput() AttachWorkGroupPolicyOperationArrayOutput {
	return o
}

func (o AttachWorkGroupPolicyOperationArrayOutput) ToAttachWorkGroupPolicyOperationArrayOutputWithContext(ctx context.Context) AttachWorkGroupPolicyOperationArrayOutput {
	return o
}

func (o AttachWorkGroupPolicyOperationArrayOutput) Index(i pulumi.IntInput) AttachWorkGroupPolicyOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AttachWorkGroupPolicyOperation {
		return vs[0].([]*AttachWorkGroupPolicyOperation)[vs[1].(int)]
	}).(AttachWorkGroupPolicyOperationOutput)
}

type AttachWorkGroupPolicyOperationMapOutput struct{ *pulumi.OutputState }

func (AttachWorkGroupPolicyOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AttachWorkGroupPolicyOperation)(nil)).Elem()
}

func (o AttachWorkGroupPolicyOperationMapOutput) ToAttachWorkGroupPolicyOperationMapOutput() AttachWorkGroupPolicyOperationMapOutput {
	return o
}

func (o AttachWorkGroupPolicyOperationMapOutput) ToAttachWorkGroupPolicyOperationMapOutputWithContext(ctx context.Context) AttachWorkGroupPolicyOperationMapOutput {
	return o
}

func (o AttachWorkGroupPolicyOperationMapOutput) MapIndex(k pulumi.StringInput) AttachWorkGroupPolicyOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AttachWorkGroupPolicyOperation {
		return vs[0].(map[string]*AttachWorkGroupPolicyOperation)[vs[1].(string)]
	}).(AttachWorkGroupPolicyOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AttachWorkGroupPolicyOperationInput)(nil)).Elem(), &AttachWorkGroupPolicyOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*AttachWorkGroupPolicyOperationArrayInput)(nil)).Elem(), AttachWorkGroupPolicyOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AttachWorkGroupPolicyOperationMapInput)(nil)).Elem(), AttachWorkGroupPolicyOperationMap{})
	pulumi.RegisterOutputType(AttachWorkGroupPolicyOperationOutput{})
	pulumi.RegisterOutputType(AttachWorkGroupPolicyOperationArrayOutput{})
	pulumi.RegisterOutputType(AttachWorkGroupPolicyOperationMapOutput{})
}
