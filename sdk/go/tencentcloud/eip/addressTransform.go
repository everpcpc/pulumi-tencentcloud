// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package eip

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a eip addressTransform
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Eip"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Instance"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			// create vpc
//			vpc, err := Vpc.NewInstance(ctx, "vpc", &Vpc.InstanceArgs{
//				CidrBlock: pulumi.String("10.0.0.0/16"),
//			})
//			if err != nil {
//				return err
//			}
//			// create vpc subnet
//			subnet, err := Subnet.NewInstance(ctx, "subnet", &Subnet.InstanceArgs{
//				VpcId:            vpc.ID(),
//				AvailabilityZone: pulumi.String("ap-guangzhou-6"),
//				CidrBlock:        pulumi.String("10.0.20.0/28"),
//				IsMulticast:      pulumi.Bool(false),
//			})
//			if err != nil {
//				return err
//			}
//			// create cvm
//			exampleInstance, err := Instance.NewInstance(ctx, "exampleInstance", &Instance.InstanceArgs{
//				InstanceName:            pulumi.String("tf_example"),
//				AvailabilityZone:        pulumi.String("ap-guangzhou-6"),
//				ImageId:                 pulumi.String("img-9qrfy1xt"),
//				InstanceType:            pulumi.String("SA3.MEDIUM4"),
//				SystemDiskType:          pulumi.String("CLOUD_HSSD"),
//				SystemDiskSize:          pulumi.Int(100),
//				Hostname:                pulumi.String("example"),
//				ProjectId:               pulumi.Int(0),
//				VpcId:                   vpc.ID(),
//				SubnetId:                subnet.ID(),
//				AllocatePublicIp:        pulumi.Bool(true),
//				InternetMaxBandwidthOut: pulumi.Int(10),
//				DataDisks: instance.InstanceDataDiskArray{
//					&instance.InstanceDataDiskArgs{
//						DataDiskType: pulumi.String("CLOUD_HSSD"),
//						DataDiskSize: pulumi.Int(50),
//						Encrypt:      pulumi.Bool(false),
//					},
//				},
//				Tags: pulumi.Map{
//					"tagKey": pulumi.Any("tagValue"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Eip.NewAddressTransform(ctx, "exampleAddressTransform", &Eip.AddressTransformArgs{
//				InstanceId: exampleInstance.ID(),
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
type AddressTransform struct {
	pulumi.CustomResourceState

	// the instance ID of a normal public network IP to be operated. eg:ins-23mk45jn.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
}

// NewAddressTransform registers a new resource with the given unique name, arguments, and options.
func NewAddressTransform(ctx *pulumi.Context,
	name string, args *AddressTransformArgs, opts ...pulumi.ResourceOption) (*AddressTransform, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AddressTransform
	err := ctx.RegisterResource("tencentcloud:Eip/addressTransform:AddressTransform", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAddressTransform gets an existing AddressTransform resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAddressTransform(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AddressTransformState, opts ...pulumi.ResourceOption) (*AddressTransform, error) {
	var resource AddressTransform
	err := ctx.ReadResource("tencentcloud:Eip/addressTransform:AddressTransform", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AddressTransform resources.
type addressTransformState struct {
	// the instance ID of a normal public network IP to be operated. eg:ins-23mk45jn.
	InstanceId *string `pulumi:"instanceId"`
}

type AddressTransformState struct {
	// the instance ID of a normal public network IP to be operated. eg:ins-23mk45jn.
	InstanceId pulumi.StringPtrInput
}

func (AddressTransformState) ElementType() reflect.Type {
	return reflect.TypeOf((*addressTransformState)(nil)).Elem()
}

type addressTransformArgs struct {
	// the instance ID of a normal public network IP to be operated. eg:ins-23mk45jn.
	InstanceId string `pulumi:"instanceId"`
}

// The set of arguments for constructing a AddressTransform resource.
type AddressTransformArgs struct {
	// the instance ID of a normal public network IP to be operated. eg:ins-23mk45jn.
	InstanceId pulumi.StringInput
}

func (AddressTransformArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*addressTransformArgs)(nil)).Elem()
}

type AddressTransformInput interface {
	pulumi.Input

	ToAddressTransformOutput() AddressTransformOutput
	ToAddressTransformOutputWithContext(ctx context.Context) AddressTransformOutput
}

func (*AddressTransform) ElementType() reflect.Type {
	return reflect.TypeOf((**AddressTransform)(nil)).Elem()
}

func (i *AddressTransform) ToAddressTransformOutput() AddressTransformOutput {
	return i.ToAddressTransformOutputWithContext(context.Background())
}

func (i *AddressTransform) ToAddressTransformOutputWithContext(ctx context.Context) AddressTransformOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AddressTransformOutput)
}

// AddressTransformArrayInput is an input type that accepts AddressTransformArray and AddressTransformArrayOutput values.
// You can construct a concrete instance of `AddressTransformArrayInput` via:
//
//	AddressTransformArray{ AddressTransformArgs{...} }
type AddressTransformArrayInput interface {
	pulumi.Input

	ToAddressTransformArrayOutput() AddressTransformArrayOutput
	ToAddressTransformArrayOutputWithContext(context.Context) AddressTransformArrayOutput
}

type AddressTransformArray []AddressTransformInput

func (AddressTransformArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AddressTransform)(nil)).Elem()
}

func (i AddressTransformArray) ToAddressTransformArrayOutput() AddressTransformArrayOutput {
	return i.ToAddressTransformArrayOutputWithContext(context.Background())
}

func (i AddressTransformArray) ToAddressTransformArrayOutputWithContext(ctx context.Context) AddressTransformArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AddressTransformArrayOutput)
}

// AddressTransformMapInput is an input type that accepts AddressTransformMap and AddressTransformMapOutput values.
// You can construct a concrete instance of `AddressTransformMapInput` via:
//
//	AddressTransformMap{ "key": AddressTransformArgs{...} }
type AddressTransformMapInput interface {
	pulumi.Input

	ToAddressTransformMapOutput() AddressTransformMapOutput
	ToAddressTransformMapOutputWithContext(context.Context) AddressTransformMapOutput
}

type AddressTransformMap map[string]AddressTransformInput

func (AddressTransformMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AddressTransform)(nil)).Elem()
}

func (i AddressTransformMap) ToAddressTransformMapOutput() AddressTransformMapOutput {
	return i.ToAddressTransformMapOutputWithContext(context.Background())
}

func (i AddressTransformMap) ToAddressTransformMapOutputWithContext(ctx context.Context) AddressTransformMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AddressTransformMapOutput)
}

type AddressTransformOutput struct{ *pulumi.OutputState }

func (AddressTransformOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AddressTransform)(nil)).Elem()
}

func (o AddressTransformOutput) ToAddressTransformOutput() AddressTransformOutput {
	return o
}

func (o AddressTransformOutput) ToAddressTransformOutputWithContext(ctx context.Context) AddressTransformOutput {
	return o
}

// the instance ID of a normal public network IP to be operated. eg:ins-23mk45jn.
func (o AddressTransformOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *AddressTransform) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

type AddressTransformArrayOutput struct{ *pulumi.OutputState }

func (AddressTransformArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AddressTransform)(nil)).Elem()
}

func (o AddressTransformArrayOutput) ToAddressTransformArrayOutput() AddressTransformArrayOutput {
	return o
}

func (o AddressTransformArrayOutput) ToAddressTransformArrayOutputWithContext(ctx context.Context) AddressTransformArrayOutput {
	return o
}

func (o AddressTransformArrayOutput) Index(i pulumi.IntInput) AddressTransformOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AddressTransform {
		return vs[0].([]*AddressTransform)[vs[1].(int)]
	}).(AddressTransformOutput)
}

type AddressTransformMapOutput struct{ *pulumi.OutputState }

func (AddressTransformMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AddressTransform)(nil)).Elem()
}

func (o AddressTransformMapOutput) ToAddressTransformMapOutput() AddressTransformMapOutput {
	return o
}

func (o AddressTransformMapOutput) ToAddressTransformMapOutputWithContext(ctx context.Context) AddressTransformMapOutput {
	return o
}

func (o AddressTransformMapOutput) MapIndex(k pulumi.StringInput) AddressTransformOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AddressTransform {
		return vs[0].(map[string]*AddressTransform)[vs[1].(string)]
	}).(AddressTransformOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AddressTransformInput)(nil)).Elem(), &AddressTransform{})
	pulumi.RegisterInputType(reflect.TypeOf((*AddressTransformArrayInput)(nil)).Elem(), AddressTransformArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AddressTransformMapInput)(nil)).Elem(), AddressTransformMap{})
	pulumi.RegisterOutputType(AddressTransformOutput{})
	pulumi.RegisterOutputType(AddressTransformArrayOutput{})
	pulumi.RegisterOutputType(AddressTransformMapOutput{})
}