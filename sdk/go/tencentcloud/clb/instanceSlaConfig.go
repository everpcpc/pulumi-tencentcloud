// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package clb

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a clb instanceSlaConfig
//
// ## Example Usage
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Clb"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Clb.NewInstanceSlaConfig(ctx, "instanceSlaConfig", &Clb.InstanceSlaConfigArgs{
//				LoadBalancerId: pulumi.String("lb-5dnrkgry"),
//				SlaType:        pulumi.String("SLA"),
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
// clb instance_sla_config can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Clb/instanceSlaConfig:InstanceSlaConfig instance_sla_config instance_id
// ```
type InstanceSlaConfig struct {
	pulumi.CustomResourceState

	// ID of the CLB instance.
	LoadBalancerId pulumi.StringOutput `pulumi:"loadBalancerId"`
	// This parameter is required to create LCU-supported instances. Values:`SLA`: Super Large 4. When you have activated Super Large models, `SLA` refers to Super Large 4; `clb.c2.medium`: Standard; `clb.c3.small`: Advanced 1; `clb.c3.medium`: Advanced 1; `clb.c4.small`: Super Large 1; `clb.c4.medium`: Super Large 2; `clb.c4.large`: Super Large 3; `clb.c4.xlarge`: Super Large 4. For more details, see [Instance Specifications](https://intl.cloud.tencent.com/document/product/214/84689?from_cn_redirect=1).
	SlaType pulumi.StringOutput `pulumi:"slaType"`
}

// NewInstanceSlaConfig registers a new resource with the given unique name, arguments, and options.
func NewInstanceSlaConfig(ctx *pulumi.Context,
	name string, args *InstanceSlaConfigArgs, opts ...pulumi.ResourceOption) (*InstanceSlaConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.LoadBalancerId == nil {
		return nil, errors.New("invalid value for required argument 'LoadBalancerId'")
	}
	if args.SlaType == nil {
		return nil, errors.New("invalid value for required argument 'SlaType'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource InstanceSlaConfig
	err := ctx.RegisterResource("tencentcloud:Clb/instanceSlaConfig:InstanceSlaConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetInstanceSlaConfig gets an existing InstanceSlaConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetInstanceSlaConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *InstanceSlaConfigState, opts ...pulumi.ResourceOption) (*InstanceSlaConfig, error) {
	var resource InstanceSlaConfig
	err := ctx.ReadResource("tencentcloud:Clb/instanceSlaConfig:InstanceSlaConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering InstanceSlaConfig resources.
type instanceSlaConfigState struct {
	// ID of the CLB instance.
	LoadBalancerId *string `pulumi:"loadBalancerId"`
	// This parameter is required to create LCU-supported instances. Values:`SLA`: Super Large 4. When you have activated Super Large models, `SLA` refers to Super Large 4; `clb.c2.medium`: Standard; `clb.c3.small`: Advanced 1; `clb.c3.medium`: Advanced 1; `clb.c4.small`: Super Large 1; `clb.c4.medium`: Super Large 2; `clb.c4.large`: Super Large 3; `clb.c4.xlarge`: Super Large 4. For more details, see [Instance Specifications](https://intl.cloud.tencent.com/document/product/214/84689?from_cn_redirect=1).
	SlaType *string `pulumi:"slaType"`
}

type InstanceSlaConfigState struct {
	// ID of the CLB instance.
	LoadBalancerId pulumi.StringPtrInput
	// This parameter is required to create LCU-supported instances. Values:`SLA`: Super Large 4. When you have activated Super Large models, `SLA` refers to Super Large 4; `clb.c2.medium`: Standard; `clb.c3.small`: Advanced 1; `clb.c3.medium`: Advanced 1; `clb.c4.small`: Super Large 1; `clb.c4.medium`: Super Large 2; `clb.c4.large`: Super Large 3; `clb.c4.xlarge`: Super Large 4. For more details, see [Instance Specifications](https://intl.cloud.tencent.com/document/product/214/84689?from_cn_redirect=1).
	SlaType pulumi.StringPtrInput
}

func (InstanceSlaConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*instanceSlaConfigState)(nil)).Elem()
}

type instanceSlaConfigArgs struct {
	// ID of the CLB instance.
	LoadBalancerId string `pulumi:"loadBalancerId"`
	// This parameter is required to create LCU-supported instances. Values:`SLA`: Super Large 4. When you have activated Super Large models, `SLA` refers to Super Large 4; `clb.c2.medium`: Standard; `clb.c3.small`: Advanced 1; `clb.c3.medium`: Advanced 1; `clb.c4.small`: Super Large 1; `clb.c4.medium`: Super Large 2; `clb.c4.large`: Super Large 3; `clb.c4.xlarge`: Super Large 4. For more details, see [Instance Specifications](https://intl.cloud.tencent.com/document/product/214/84689?from_cn_redirect=1).
	SlaType string `pulumi:"slaType"`
}

// The set of arguments for constructing a InstanceSlaConfig resource.
type InstanceSlaConfigArgs struct {
	// ID of the CLB instance.
	LoadBalancerId pulumi.StringInput
	// This parameter is required to create LCU-supported instances. Values:`SLA`: Super Large 4. When you have activated Super Large models, `SLA` refers to Super Large 4; `clb.c2.medium`: Standard; `clb.c3.small`: Advanced 1; `clb.c3.medium`: Advanced 1; `clb.c4.small`: Super Large 1; `clb.c4.medium`: Super Large 2; `clb.c4.large`: Super Large 3; `clb.c4.xlarge`: Super Large 4. For more details, see [Instance Specifications](https://intl.cloud.tencent.com/document/product/214/84689?from_cn_redirect=1).
	SlaType pulumi.StringInput
}

func (InstanceSlaConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*instanceSlaConfigArgs)(nil)).Elem()
}

type InstanceSlaConfigInput interface {
	pulumi.Input

	ToInstanceSlaConfigOutput() InstanceSlaConfigOutput
	ToInstanceSlaConfigOutputWithContext(ctx context.Context) InstanceSlaConfigOutput
}

func (*InstanceSlaConfig) ElementType() reflect.Type {
	return reflect.TypeOf((**InstanceSlaConfig)(nil)).Elem()
}

func (i *InstanceSlaConfig) ToInstanceSlaConfigOutput() InstanceSlaConfigOutput {
	return i.ToInstanceSlaConfigOutputWithContext(context.Background())
}

func (i *InstanceSlaConfig) ToInstanceSlaConfigOutputWithContext(ctx context.Context) InstanceSlaConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceSlaConfigOutput)
}

// InstanceSlaConfigArrayInput is an input type that accepts InstanceSlaConfigArray and InstanceSlaConfigArrayOutput values.
// You can construct a concrete instance of `InstanceSlaConfigArrayInput` via:
//
//	InstanceSlaConfigArray{ InstanceSlaConfigArgs{...} }
type InstanceSlaConfigArrayInput interface {
	pulumi.Input

	ToInstanceSlaConfigArrayOutput() InstanceSlaConfigArrayOutput
	ToInstanceSlaConfigArrayOutputWithContext(context.Context) InstanceSlaConfigArrayOutput
}

type InstanceSlaConfigArray []InstanceSlaConfigInput

func (InstanceSlaConfigArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*InstanceSlaConfig)(nil)).Elem()
}

func (i InstanceSlaConfigArray) ToInstanceSlaConfigArrayOutput() InstanceSlaConfigArrayOutput {
	return i.ToInstanceSlaConfigArrayOutputWithContext(context.Background())
}

func (i InstanceSlaConfigArray) ToInstanceSlaConfigArrayOutputWithContext(ctx context.Context) InstanceSlaConfigArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceSlaConfigArrayOutput)
}

// InstanceSlaConfigMapInput is an input type that accepts InstanceSlaConfigMap and InstanceSlaConfigMapOutput values.
// You can construct a concrete instance of `InstanceSlaConfigMapInput` via:
//
//	InstanceSlaConfigMap{ "key": InstanceSlaConfigArgs{...} }
type InstanceSlaConfigMapInput interface {
	pulumi.Input

	ToInstanceSlaConfigMapOutput() InstanceSlaConfigMapOutput
	ToInstanceSlaConfigMapOutputWithContext(context.Context) InstanceSlaConfigMapOutput
}

type InstanceSlaConfigMap map[string]InstanceSlaConfigInput

func (InstanceSlaConfigMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*InstanceSlaConfig)(nil)).Elem()
}

func (i InstanceSlaConfigMap) ToInstanceSlaConfigMapOutput() InstanceSlaConfigMapOutput {
	return i.ToInstanceSlaConfigMapOutputWithContext(context.Background())
}

func (i InstanceSlaConfigMap) ToInstanceSlaConfigMapOutputWithContext(ctx context.Context) InstanceSlaConfigMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceSlaConfigMapOutput)
}

type InstanceSlaConfigOutput struct{ *pulumi.OutputState }

func (InstanceSlaConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**InstanceSlaConfig)(nil)).Elem()
}

func (o InstanceSlaConfigOutput) ToInstanceSlaConfigOutput() InstanceSlaConfigOutput {
	return o
}

func (o InstanceSlaConfigOutput) ToInstanceSlaConfigOutputWithContext(ctx context.Context) InstanceSlaConfigOutput {
	return o
}

// ID of the CLB instance.
func (o InstanceSlaConfigOutput) LoadBalancerId() pulumi.StringOutput {
	return o.ApplyT(func(v *InstanceSlaConfig) pulumi.StringOutput { return v.LoadBalancerId }).(pulumi.StringOutput)
}

// This parameter is required to create LCU-supported instances. Values:`SLA`: Super Large 4. When you have activated Super Large models, `SLA` refers to Super Large 4; `clb.c2.medium`: Standard; `clb.c3.small`: Advanced 1; `clb.c3.medium`: Advanced 1; `clb.c4.small`: Super Large 1; `clb.c4.medium`: Super Large 2; `clb.c4.large`: Super Large 3; `clb.c4.xlarge`: Super Large 4. For more details, see [Instance Specifications](https://intl.cloud.tencent.com/document/product/214/84689?from_cn_redirect=1).
func (o InstanceSlaConfigOutput) SlaType() pulumi.StringOutput {
	return o.ApplyT(func(v *InstanceSlaConfig) pulumi.StringOutput { return v.SlaType }).(pulumi.StringOutput)
}

type InstanceSlaConfigArrayOutput struct{ *pulumi.OutputState }

func (InstanceSlaConfigArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*InstanceSlaConfig)(nil)).Elem()
}

func (o InstanceSlaConfigArrayOutput) ToInstanceSlaConfigArrayOutput() InstanceSlaConfigArrayOutput {
	return o
}

func (o InstanceSlaConfigArrayOutput) ToInstanceSlaConfigArrayOutputWithContext(ctx context.Context) InstanceSlaConfigArrayOutput {
	return o
}

func (o InstanceSlaConfigArrayOutput) Index(i pulumi.IntInput) InstanceSlaConfigOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *InstanceSlaConfig {
		return vs[0].([]*InstanceSlaConfig)[vs[1].(int)]
	}).(InstanceSlaConfigOutput)
}

type InstanceSlaConfigMapOutput struct{ *pulumi.OutputState }

func (InstanceSlaConfigMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*InstanceSlaConfig)(nil)).Elem()
}

func (o InstanceSlaConfigMapOutput) ToInstanceSlaConfigMapOutput() InstanceSlaConfigMapOutput {
	return o
}

func (o InstanceSlaConfigMapOutput) ToInstanceSlaConfigMapOutputWithContext(ctx context.Context) InstanceSlaConfigMapOutput {
	return o
}

func (o InstanceSlaConfigMapOutput) MapIndex(k pulumi.StringInput) InstanceSlaConfigOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *InstanceSlaConfig {
		return vs[0].(map[string]*InstanceSlaConfig)[vs[1].(string)]
	}).(InstanceSlaConfigOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceSlaConfigInput)(nil)).Elem(), &InstanceSlaConfig{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceSlaConfigArrayInput)(nil)).Elem(), InstanceSlaConfigArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceSlaConfigMapInput)(nil)).Elem(), InstanceSlaConfigMap{})
	pulumi.RegisterOutputType(InstanceSlaConfigOutput{})
	pulumi.RegisterOutputType(InstanceSlaConfigArrayOutput{})
	pulumi.RegisterOutputType(InstanceSlaConfigMapOutput{})
}