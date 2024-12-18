// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cam

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a cam setPolicyVersionConfig
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cam"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Cam.NewSetPolicyVersionConfig(ctx, "setPolicyVersionConfig", &Cam.SetPolicyVersionConfigArgs{
//				PolicyId:  pulumi.Int(171162811),
//				VersionId: pulumi.Int(2),
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
// cam set_policy_version_config can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Cam/setPolicyVersionConfig:SetPolicyVersionConfig set_policy_version_config set_policy_version_config_id
// ```
type SetPolicyVersionConfig struct {
	pulumi.CustomResourceState

	// Policy ID.
	PolicyId pulumi.IntOutput `pulumi:"policyId"`
	// The policy version number, which can be obtained from ListPolicyVersions.
	VersionId pulumi.IntOutput `pulumi:"versionId"`
}

// NewSetPolicyVersionConfig registers a new resource with the given unique name, arguments, and options.
func NewSetPolicyVersionConfig(ctx *pulumi.Context,
	name string, args *SetPolicyVersionConfigArgs, opts ...pulumi.ResourceOption) (*SetPolicyVersionConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PolicyId == nil {
		return nil, errors.New("invalid value for required argument 'PolicyId'")
	}
	if args.VersionId == nil {
		return nil, errors.New("invalid value for required argument 'VersionId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource SetPolicyVersionConfig
	err := ctx.RegisterResource("tencentcloud:Cam/setPolicyVersionConfig:SetPolicyVersionConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSetPolicyVersionConfig gets an existing SetPolicyVersionConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSetPolicyVersionConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SetPolicyVersionConfigState, opts ...pulumi.ResourceOption) (*SetPolicyVersionConfig, error) {
	var resource SetPolicyVersionConfig
	err := ctx.ReadResource("tencentcloud:Cam/setPolicyVersionConfig:SetPolicyVersionConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SetPolicyVersionConfig resources.
type setPolicyVersionConfigState struct {
	// Policy ID.
	PolicyId *int `pulumi:"policyId"`
	// The policy version number, which can be obtained from ListPolicyVersions.
	VersionId *int `pulumi:"versionId"`
}

type SetPolicyVersionConfigState struct {
	// Policy ID.
	PolicyId pulumi.IntPtrInput
	// The policy version number, which can be obtained from ListPolicyVersions.
	VersionId pulumi.IntPtrInput
}

func (SetPolicyVersionConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*setPolicyVersionConfigState)(nil)).Elem()
}

type setPolicyVersionConfigArgs struct {
	// Policy ID.
	PolicyId int `pulumi:"policyId"`
	// The policy version number, which can be obtained from ListPolicyVersions.
	VersionId int `pulumi:"versionId"`
}

// The set of arguments for constructing a SetPolicyVersionConfig resource.
type SetPolicyVersionConfigArgs struct {
	// Policy ID.
	PolicyId pulumi.IntInput
	// The policy version number, which can be obtained from ListPolicyVersions.
	VersionId pulumi.IntInput
}

func (SetPolicyVersionConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*setPolicyVersionConfigArgs)(nil)).Elem()
}

type SetPolicyVersionConfigInput interface {
	pulumi.Input

	ToSetPolicyVersionConfigOutput() SetPolicyVersionConfigOutput
	ToSetPolicyVersionConfigOutputWithContext(ctx context.Context) SetPolicyVersionConfigOutput
}

func (*SetPolicyVersionConfig) ElementType() reflect.Type {
	return reflect.TypeOf((**SetPolicyVersionConfig)(nil)).Elem()
}

func (i *SetPolicyVersionConfig) ToSetPolicyVersionConfigOutput() SetPolicyVersionConfigOutput {
	return i.ToSetPolicyVersionConfigOutputWithContext(context.Background())
}

func (i *SetPolicyVersionConfig) ToSetPolicyVersionConfigOutputWithContext(ctx context.Context) SetPolicyVersionConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SetPolicyVersionConfigOutput)
}

// SetPolicyVersionConfigArrayInput is an input type that accepts SetPolicyVersionConfigArray and SetPolicyVersionConfigArrayOutput values.
// You can construct a concrete instance of `SetPolicyVersionConfigArrayInput` via:
//
//	SetPolicyVersionConfigArray{ SetPolicyVersionConfigArgs{...} }
type SetPolicyVersionConfigArrayInput interface {
	pulumi.Input

	ToSetPolicyVersionConfigArrayOutput() SetPolicyVersionConfigArrayOutput
	ToSetPolicyVersionConfigArrayOutputWithContext(context.Context) SetPolicyVersionConfigArrayOutput
}

type SetPolicyVersionConfigArray []SetPolicyVersionConfigInput

func (SetPolicyVersionConfigArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SetPolicyVersionConfig)(nil)).Elem()
}

func (i SetPolicyVersionConfigArray) ToSetPolicyVersionConfigArrayOutput() SetPolicyVersionConfigArrayOutput {
	return i.ToSetPolicyVersionConfigArrayOutputWithContext(context.Background())
}

func (i SetPolicyVersionConfigArray) ToSetPolicyVersionConfigArrayOutputWithContext(ctx context.Context) SetPolicyVersionConfigArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SetPolicyVersionConfigArrayOutput)
}

// SetPolicyVersionConfigMapInput is an input type that accepts SetPolicyVersionConfigMap and SetPolicyVersionConfigMapOutput values.
// You can construct a concrete instance of `SetPolicyVersionConfigMapInput` via:
//
//	SetPolicyVersionConfigMap{ "key": SetPolicyVersionConfigArgs{...} }
type SetPolicyVersionConfigMapInput interface {
	pulumi.Input

	ToSetPolicyVersionConfigMapOutput() SetPolicyVersionConfigMapOutput
	ToSetPolicyVersionConfigMapOutputWithContext(context.Context) SetPolicyVersionConfigMapOutput
}

type SetPolicyVersionConfigMap map[string]SetPolicyVersionConfigInput

func (SetPolicyVersionConfigMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SetPolicyVersionConfig)(nil)).Elem()
}

func (i SetPolicyVersionConfigMap) ToSetPolicyVersionConfigMapOutput() SetPolicyVersionConfigMapOutput {
	return i.ToSetPolicyVersionConfigMapOutputWithContext(context.Background())
}

func (i SetPolicyVersionConfigMap) ToSetPolicyVersionConfigMapOutputWithContext(ctx context.Context) SetPolicyVersionConfigMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SetPolicyVersionConfigMapOutput)
}

type SetPolicyVersionConfigOutput struct{ *pulumi.OutputState }

func (SetPolicyVersionConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SetPolicyVersionConfig)(nil)).Elem()
}

func (o SetPolicyVersionConfigOutput) ToSetPolicyVersionConfigOutput() SetPolicyVersionConfigOutput {
	return o
}

func (o SetPolicyVersionConfigOutput) ToSetPolicyVersionConfigOutputWithContext(ctx context.Context) SetPolicyVersionConfigOutput {
	return o
}

// Policy ID.
func (o SetPolicyVersionConfigOutput) PolicyId() pulumi.IntOutput {
	return o.ApplyT(func(v *SetPolicyVersionConfig) pulumi.IntOutput { return v.PolicyId }).(pulumi.IntOutput)
}

// The policy version number, which can be obtained from ListPolicyVersions.
func (o SetPolicyVersionConfigOutput) VersionId() pulumi.IntOutput {
	return o.ApplyT(func(v *SetPolicyVersionConfig) pulumi.IntOutput { return v.VersionId }).(pulumi.IntOutput)
}

type SetPolicyVersionConfigArrayOutput struct{ *pulumi.OutputState }

func (SetPolicyVersionConfigArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SetPolicyVersionConfig)(nil)).Elem()
}

func (o SetPolicyVersionConfigArrayOutput) ToSetPolicyVersionConfigArrayOutput() SetPolicyVersionConfigArrayOutput {
	return o
}

func (o SetPolicyVersionConfigArrayOutput) ToSetPolicyVersionConfigArrayOutputWithContext(ctx context.Context) SetPolicyVersionConfigArrayOutput {
	return o
}

func (o SetPolicyVersionConfigArrayOutput) Index(i pulumi.IntInput) SetPolicyVersionConfigOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SetPolicyVersionConfig {
		return vs[0].([]*SetPolicyVersionConfig)[vs[1].(int)]
	}).(SetPolicyVersionConfigOutput)
}

type SetPolicyVersionConfigMapOutput struct{ *pulumi.OutputState }

func (SetPolicyVersionConfigMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SetPolicyVersionConfig)(nil)).Elem()
}

func (o SetPolicyVersionConfigMapOutput) ToSetPolicyVersionConfigMapOutput() SetPolicyVersionConfigMapOutput {
	return o
}

func (o SetPolicyVersionConfigMapOutput) ToSetPolicyVersionConfigMapOutputWithContext(ctx context.Context) SetPolicyVersionConfigMapOutput {
	return o
}

func (o SetPolicyVersionConfigMapOutput) MapIndex(k pulumi.StringInput) SetPolicyVersionConfigOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SetPolicyVersionConfig {
		return vs[0].(map[string]*SetPolicyVersionConfig)[vs[1].(string)]
	}).(SetPolicyVersionConfigOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SetPolicyVersionConfigInput)(nil)).Elem(), &SetPolicyVersionConfig{})
	pulumi.RegisterInputType(reflect.TypeOf((*SetPolicyVersionConfigArrayInput)(nil)).Elem(), SetPolicyVersionConfigArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SetPolicyVersionConfigMapInput)(nil)).Elem(), SetPolicyVersionConfigMap{})
	pulumi.RegisterOutputType(SetPolicyVersionConfigOutput{})
	pulumi.RegisterOutputType(SetPolicyVersionConfigArrayOutput{})
	pulumi.RegisterOutputType(SetPolicyVersionConfigMapOutput{})
}
