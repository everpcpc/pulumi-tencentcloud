// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package eip

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a eip publicAddressAdjust
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Eip"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Eip.NewPublicAddressAdjust(ctx, "publicAddressAdjust", &Eip.PublicAddressAdjustArgs{
// 			AddressId:  pulumi.String("eip-erft45fu"),
// 			InstanceId: pulumi.String("ins-cr2rfq78"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type PublicAddressAdjust struct {
	pulumi.CustomResourceState

	// A unique ID that identifies an EIP instance. The unique ID of EIP is in the form:`eip-erft45fu`.
	AddressId pulumi.StringPtrOutput `pulumi:"addressId"`
	// A unique ID that identifies the CVM instance. The unique ID of CVM is in the form:`ins-osckfnm7`.
	InstanceId pulumi.StringPtrOutput `pulumi:"instanceId"`
}

// NewPublicAddressAdjust registers a new resource with the given unique name, arguments, and options.
func NewPublicAddressAdjust(ctx *pulumi.Context,
	name string, args *PublicAddressAdjustArgs, opts ...pulumi.ResourceOption) (*PublicAddressAdjust, error) {
	if args == nil {
		args = &PublicAddressAdjustArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource PublicAddressAdjust
	err := ctx.RegisterResource("tencentcloud:Eip/publicAddressAdjust:PublicAddressAdjust", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPublicAddressAdjust gets an existing PublicAddressAdjust resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPublicAddressAdjust(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PublicAddressAdjustState, opts ...pulumi.ResourceOption) (*PublicAddressAdjust, error) {
	var resource PublicAddressAdjust
	err := ctx.ReadResource("tencentcloud:Eip/publicAddressAdjust:PublicAddressAdjust", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PublicAddressAdjust resources.
type publicAddressAdjustState struct {
	// A unique ID that identifies an EIP instance. The unique ID of EIP is in the form:`eip-erft45fu`.
	AddressId *string `pulumi:"addressId"`
	// A unique ID that identifies the CVM instance. The unique ID of CVM is in the form:`ins-osckfnm7`.
	InstanceId *string `pulumi:"instanceId"`
}

type PublicAddressAdjustState struct {
	// A unique ID that identifies an EIP instance. The unique ID of EIP is in the form:`eip-erft45fu`.
	AddressId pulumi.StringPtrInput
	// A unique ID that identifies the CVM instance. The unique ID of CVM is in the form:`ins-osckfnm7`.
	InstanceId pulumi.StringPtrInput
}

func (PublicAddressAdjustState) ElementType() reflect.Type {
	return reflect.TypeOf((*publicAddressAdjustState)(nil)).Elem()
}

type publicAddressAdjustArgs struct {
	// A unique ID that identifies an EIP instance. The unique ID of EIP is in the form:`eip-erft45fu`.
	AddressId *string `pulumi:"addressId"`
	// A unique ID that identifies the CVM instance. The unique ID of CVM is in the form:`ins-osckfnm7`.
	InstanceId *string `pulumi:"instanceId"`
}

// The set of arguments for constructing a PublicAddressAdjust resource.
type PublicAddressAdjustArgs struct {
	// A unique ID that identifies an EIP instance. The unique ID of EIP is in the form:`eip-erft45fu`.
	AddressId pulumi.StringPtrInput
	// A unique ID that identifies the CVM instance. The unique ID of CVM is in the form:`ins-osckfnm7`.
	InstanceId pulumi.StringPtrInput
}

func (PublicAddressAdjustArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*publicAddressAdjustArgs)(nil)).Elem()
}

type PublicAddressAdjustInput interface {
	pulumi.Input

	ToPublicAddressAdjustOutput() PublicAddressAdjustOutput
	ToPublicAddressAdjustOutputWithContext(ctx context.Context) PublicAddressAdjustOutput
}

func (*PublicAddressAdjust) ElementType() reflect.Type {
	return reflect.TypeOf((**PublicAddressAdjust)(nil)).Elem()
}

func (i *PublicAddressAdjust) ToPublicAddressAdjustOutput() PublicAddressAdjustOutput {
	return i.ToPublicAddressAdjustOutputWithContext(context.Background())
}

func (i *PublicAddressAdjust) ToPublicAddressAdjustOutputWithContext(ctx context.Context) PublicAddressAdjustOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PublicAddressAdjustOutput)
}

// PublicAddressAdjustArrayInput is an input type that accepts PublicAddressAdjustArray and PublicAddressAdjustArrayOutput values.
// You can construct a concrete instance of `PublicAddressAdjustArrayInput` via:
//
//          PublicAddressAdjustArray{ PublicAddressAdjustArgs{...} }
type PublicAddressAdjustArrayInput interface {
	pulumi.Input

	ToPublicAddressAdjustArrayOutput() PublicAddressAdjustArrayOutput
	ToPublicAddressAdjustArrayOutputWithContext(context.Context) PublicAddressAdjustArrayOutput
}

type PublicAddressAdjustArray []PublicAddressAdjustInput

func (PublicAddressAdjustArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PublicAddressAdjust)(nil)).Elem()
}

func (i PublicAddressAdjustArray) ToPublicAddressAdjustArrayOutput() PublicAddressAdjustArrayOutput {
	return i.ToPublicAddressAdjustArrayOutputWithContext(context.Background())
}

func (i PublicAddressAdjustArray) ToPublicAddressAdjustArrayOutputWithContext(ctx context.Context) PublicAddressAdjustArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PublicAddressAdjustArrayOutput)
}

// PublicAddressAdjustMapInput is an input type that accepts PublicAddressAdjustMap and PublicAddressAdjustMapOutput values.
// You can construct a concrete instance of `PublicAddressAdjustMapInput` via:
//
//          PublicAddressAdjustMap{ "key": PublicAddressAdjustArgs{...} }
type PublicAddressAdjustMapInput interface {
	pulumi.Input

	ToPublicAddressAdjustMapOutput() PublicAddressAdjustMapOutput
	ToPublicAddressAdjustMapOutputWithContext(context.Context) PublicAddressAdjustMapOutput
}

type PublicAddressAdjustMap map[string]PublicAddressAdjustInput

func (PublicAddressAdjustMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PublicAddressAdjust)(nil)).Elem()
}

func (i PublicAddressAdjustMap) ToPublicAddressAdjustMapOutput() PublicAddressAdjustMapOutput {
	return i.ToPublicAddressAdjustMapOutputWithContext(context.Background())
}

func (i PublicAddressAdjustMap) ToPublicAddressAdjustMapOutputWithContext(ctx context.Context) PublicAddressAdjustMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PublicAddressAdjustMapOutput)
}

type PublicAddressAdjustOutput struct{ *pulumi.OutputState }

func (PublicAddressAdjustOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PublicAddressAdjust)(nil)).Elem()
}

func (o PublicAddressAdjustOutput) ToPublicAddressAdjustOutput() PublicAddressAdjustOutput {
	return o
}

func (o PublicAddressAdjustOutput) ToPublicAddressAdjustOutputWithContext(ctx context.Context) PublicAddressAdjustOutput {
	return o
}

// A unique ID that identifies an EIP instance. The unique ID of EIP is in the form:`eip-erft45fu`.
func (o PublicAddressAdjustOutput) AddressId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PublicAddressAdjust) pulumi.StringPtrOutput { return v.AddressId }).(pulumi.StringPtrOutput)
}

// A unique ID that identifies the CVM instance. The unique ID of CVM is in the form:`ins-osckfnm7`.
func (o PublicAddressAdjustOutput) InstanceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PublicAddressAdjust) pulumi.StringPtrOutput { return v.InstanceId }).(pulumi.StringPtrOutput)
}

type PublicAddressAdjustArrayOutput struct{ *pulumi.OutputState }

func (PublicAddressAdjustArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PublicAddressAdjust)(nil)).Elem()
}

func (o PublicAddressAdjustArrayOutput) ToPublicAddressAdjustArrayOutput() PublicAddressAdjustArrayOutput {
	return o
}

func (o PublicAddressAdjustArrayOutput) ToPublicAddressAdjustArrayOutputWithContext(ctx context.Context) PublicAddressAdjustArrayOutput {
	return o
}

func (o PublicAddressAdjustArrayOutput) Index(i pulumi.IntInput) PublicAddressAdjustOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *PublicAddressAdjust {
		return vs[0].([]*PublicAddressAdjust)[vs[1].(int)]
	}).(PublicAddressAdjustOutput)
}

type PublicAddressAdjustMapOutput struct{ *pulumi.OutputState }

func (PublicAddressAdjustMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PublicAddressAdjust)(nil)).Elem()
}

func (o PublicAddressAdjustMapOutput) ToPublicAddressAdjustMapOutput() PublicAddressAdjustMapOutput {
	return o
}

func (o PublicAddressAdjustMapOutput) ToPublicAddressAdjustMapOutputWithContext(ctx context.Context) PublicAddressAdjustMapOutput {
	return o
}

func (o PublicAddressAdjustMapOutput) MapIndex(k pulumi.StringInput) PublicAddressAdjustOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *PublicAddressAdjust {
		return vs[0].(map[string]*PublicAddressAdjust)[vs[1].(string)]
	}).(PublicAddressAdjustOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PublicAddressAdjustInput)(nil)).Elem(), &PublicAddressAdjust{})
	pulumi.RegisterInputType(reflect.TypeOf((*PublicAddressAdjustArrayInput)(nil)).Elem(), PublicAddressAdjustArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*PublicAddressAdjustMapInput)(nil)).Elem(), PublicAddressAdjustMap{})
	pulumi.RegisterOutputType(PublicAddressAdjustOutput{})
	pulumi.RegisterOutputType(PublicAddressAdjustArrayOutput{})
	pulumi.RegisterOutputType(PublicAddressAdjustMapOutput{})
}
