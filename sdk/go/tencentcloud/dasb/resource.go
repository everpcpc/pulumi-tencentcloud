// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dasb

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a dasb resource
//
// ## Example Usage
//
// ### Create a standard version instance
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dasb"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Dasb.NewResource(ctx, "example", &Dasb.ResourceArgs{
//				AutoRenewFlag:    pulumi.Int(1),
//				CidrBlock:        pulumi.String("10.35.20.0/24"),
//				DeployRegion:     pulumi.String("ap-guangzhou"),
//				DeployZone:       pulumi.String("ap-guangzhou-6"),
//				PackageBandwidth: pulumi.Int(1),
//				ResourceEdition:  pulumi.String("standard"),
//				ResourceNode:     pulumi.Int(50),
//				SubnetId:         pulumi.String("subnet-g7jhwhi2"),
//				TimeSpan:         pulumi.Int(1),
//				TimeUnit:         pulumi.String("m"),
//				VpcCidrBlock:     pulumi.String("10.35.0.0/16"),
//				VpcId:            pulumi.String("vpc-fmz6l9nz"),
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
// ### Create a professional instance
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dasb"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Dasb.NewResource(ctx, "example", &Dasb.ResourceArgs{
//				AutoRenewFlag:    pulumi.Int(1),
//				CidrBlock:        pulumi.String("10.35.20.0/24"),
//				DeployRegion:     pulumi.String("ap-guangzhou"),
//				DeployZone:       pulumi.String("ap-guangzhou-6"),
//				PackageBandwidth: pulumi.Int(1),
//				ResourceEdition:  pulumi.String("pro"),
//				ResourceNode:     pulumi.Int(50),
//				SubnetId:         pulumi.String("subnet-g7jhwhi2"),
//				TimeSpan:         pulumi.Int(1),
//				TimeUnit:         pulumi.String("m"),
//				VpcCidrBlock:     pulumi.String("10.35.0.0/16"),
//				VpcId:            pulumi.String("vpc-fmz6l9nz"),
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
// dasb resource can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Dasb/resource:Resource example bh-saas-kgckynrt
// ```
type Resource struct {
	pulumi.CustomResourceState

	// Automatic renewal. 1 is auto renew flag, 0 is not.
	AutoRenewFlag pulumi.IntOutput `pulumi:"autoRenewFlag"`
	// Subnet segments that require service activation.
	CidrBlock pulumi.StringOutput `pulumi:"cidrBlock"`
	// Deploy region.
	DeployRegion pulumi.StringOutput `pulumi:"deployRegion"`
	// Deploy zone.
	DeployZone pulumi.StringOutput `pulumi:"deployZone"`
	// Number of bandwidth expansion packets (4M), The set value is an integer multiple of 4.
	PackageBandwidth pulumi.IntOutput `pulumi:"packageBandwidth"`
	// Resource type.Value:standard/pro.
	ResourceEdition pulumi.StringOutput `pulumi:"resourceEdition"`
	// Number of resource nodes.
	ResourceNode pulumi.IntOutput `pulumi:"resourceNode"`
	// Deploy resource subnetId.
	SubnetId pulumi.StringOutput `pulumi:"subnetId"`
	// Billing time. This field is mandatory, with a minimum value of 1.
	TimeSpan pulumi.IntPtrOutput `pulumi:"timeSpan"`
	// Billing cycle, only support m: month. This field is mandatory, fill in m.
	TimeUnit pulumi.StringPtrOutput `pulumi:"timeUnit"`
	// The network segment corresponding to the VPC that requires service activation.
	VpcCidrBlock pulumi.StringOutput `pulumi:"vpcCidrBlock"`
	// Deploy resource vpcId.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
}

// NewResource registers a new resource with the given unique name, arguments, and options.
func NewResource(ctx *pulumi.Context,
	name string, args *ResourceArgs, opts ...pulumi.ResourceOption) (*Resource, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AutoRenewFlag == nil {
		return nil, errors.New("invalid value for required argument 'AutoRenewFlag'")
	}
	if args.CidrBlock == nil {
		return nil, errors.New("invalid value for required argument 'CidrBlock'")
	}
	if args.DeployRegion == nil {
		return nil, errors.New("invalid value for required argument 'DeployRegion'")
	}
	if args.DeployZone == nil {
		return nil, errors.New("invalid value for required argument 'DeployZone'")
	}
	if args.ResourceEdition == nil {
		return nil, errors.New("invalid value for required argument 'ResourceEdition'")
	}
	if args.ResourceNode == nil {
		return nil, errors.New("invalid value for required argument 'ResourceNode'")
	}
	if args.SubnetId == nil {
		return nil, errors.New("invalid value for required argument 'SubnetId'")
	}
	if args.VpcCidrBlock == nil {
		return nil, errors.New("invalid value for required argument 'VpcCidrBlock'")
	}
	if args.VpcId == nil {
		return nil, errors.New("invalid value for required argument 'VpcId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Resource
	err := ctx.RegisterResource("tencentcloud:Dasb/resource:Resource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResource gets an existing Resource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourceState, opts ...pulumi.ResourceOption) (*Resource, error) {
	var resource Resource
	err := ctx.ReadResource("tencentcloud:Dasb/resource:Resource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Resource resources.
type resourceState struct {
	// Automatic renewal. 1 is auto renew flag, 0 is not.
	AutoRenewFlag *int `pulumi:"autoRenewFlag"`
	// Subnet segments that require service activation.
	CidrBlock *string `pulumi:"cidrBlock"`
	// Deploy region.
	DeployRegion *string `pulumi:"deployRegion"`
	// Deploy zone.
	DeployZone *string `pulumi:"deployZone"`
	// Number of bandwidth expansion packets (4M), The set value is an integer multiple of 4.
	PackageBandwidth *int `pulumi:"packageBandwidth"`
	// Resource type.Value:standard/pro.
	ResourceEdition *string `pulumi:"resourceEdition"`
	// Number of resource nodes.
	ResourceNode *int `pulumi:"resourceNode"`
	// Deploy resource subnetId.
	SubnetId *string `pulumi:"subnetId"`
	// Billing time. This field is mandatory, with a minimum value of 1.
	TimeSpan *int `pulumi:"timeSpan"`
	// Billing cycle, only support m: month. This field is mandatory, fill in m.
	TimeUnit *string `pulumi:"timeUnit"`
	// The network segment corresponding to the VPC that requires service activation.
	VpcCidrBlock *string `pulumi:"vpcCidrBlock"`
	// Deploy resource vpcId.
	VpcId *string `pulumi:"vpcId"`
}

type ResourceState struct {
	// Automatic renewal. 1 is auto renew flag, 0 is not.
	AutoRenewFlag pulumi.IntPtrInput
	// Subnet segments that require service activation.
	CidrBlock pulumi.StringPtrInput
	// Deploy region.
	DeployRegion pulumi.StringPtrInput
	// Deploy zone.
	DeployZone pulumi.StringPtrInput
	// Number of bandwidth expansion packets (4M), The set value is an integer multiple of 4.
	PackageBandwidth pulumi.IntPtrInput
	// Resource type.Value:standard/pro.
	ResourceEdition pulumi.StringPtrInput
	// Number of resource nodes.
	ResourceNode pulumi.IntPtrInput
	// Deploy resource subnetId.
	SubnetId pulumi.StringPtrInput
	// Billing time. This field is mandatory, with a minimum value of 1.
	TimeSpan pulumi.IntPtrInput
	// Billing cycle, only support m: month. This field is mandatory, fill in m.
	TimeUnit pulumi.StringPtrInput
	// The network segment corresponding to the VPC that requires service activation.
	VpcCidrBlock pulumi.StringPtrInput
	// Deploy resource vpcId.
	VpcId pulumi.StringPtrInput
}

func (ResourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceState)(nil)).Elem()
}

type resourceArgs struct {
	// Automatic renewal. 1 is auto renew flag, 0 is not.
	AutoRenewFlag int `pulumi:"autoRenewFlag"`
	// Subnet segments that require service activation.
	CidrBlock string `pulumi:"cidrBlock"`
	// Deploy region.
	DeployRegion string `pulumi:"deployRegion"`
	// Deploy zone.
	DeployZone string `pulumi:"deployZone"`
	// Number of bandwidth expansion packets (4M), The set value is an integer multiple of 4.
	PackageBandwidth *int `pulumi:"packageBandwidth"`
	// Resource type.Value:standard/pro.
	ResourceEdition string `pulumi:"resourceEdition"`
	// Number of resource nodes.
	ResourceNode int `pulumi:"resourceNode"`
	// Deploy resource subnetId.
	SubnetId string `pulumi:"subnetId"`
	// Billing time. This field is mandatory, with a minimum value of 1.
	TimeSpan *int `pulumi:"timeSpan"`
	// Billing cycle, only support m: month. This field is mandatory, fill in m.
	TimeUnit *string `pulumi:"timeUnit"`
	// The network segment corresponding to the VPC that requires service activation.
	VpcCidrBlock string `pulumi:"vpcCidrBlock"`
	// Deploy resource vpcId.
	VpcId string `pulumi:"vpcId"`
}

// The set of arguments for constructing a Resource resource.
type ResourceArgs struct {
	// Automatic renewal. 1 is auto renew flag, 0 is not.
	AutoRenewFlag pulumi.IntInput
	// Subnet segments that require service activation.
	CidrBlock pulumi.StringInput
	// Deploy region.
	DeployRegion pulumi.StringInput
	// Deploy zone.
	DeployZone pulumi.StringInput
	// Number of bandwidth expansion packets (4M), The set value is an integer multiple of 4.
	PackageBandwidth pulumi.IntPtrInput
	// Resource type.Value:standard/pro.
	ResourceEdition pulumi.StringInput
	// Number of resource nodes.
	ResourceNode pulumi.IntInput
	// Deploy resource subnetId.
	SubnetId pulumi.StringInput
	// Billing time. This field is mandatory, with a minimum value of 1.
	TimeSpan pulumi.IntPtrInput
	// Billing cycle, only support m: month. This field is mandatory, fill in m.
	TimeUnit pulumi.StringPtrInput
	// The network segment corresponding to the VPC that requires service activation.
	VpcCidrBlock pulumi.StringInput
	// Deploy resource vpcId.
	VpcId pulumi.StringInput
}

func (ResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceArgs)(nil)).Elem()
}

type ResourceInput interface {
	pulumi.Input

	ToResourceOutput() ResourceOutput
	ToResourceOutputWithContext(ctx context.Context) ResourceOutput
}

func (*Resource) ElementType() reflect.Type {
	return reflect.TypeOf((**Resource)(nil)).Elem()
}

func (i *Resource) ToResourceOutput() ResourceOutput {
	return i.ToResourceOutputWithContext(context.Background())
}

func (i *Resource) ToResourceOutputWithContext(ctx context.Context) ResourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourceOutput)
}

// ResourceArrayInput is an input type that accepts ResourceArray and ResourceArrayOutput values.
// You can construct a concrete instance of `ResourceArrayInput` via:
//
//	ResourceArray{ ResourceArgs{...} }
type ResourceArrayInput interface {
	pulumi.Input

	ToResourceArrayOutput() ResourceArrayOutput
	ToResourceArrayOutputWithContext(context.Context) ResourceArrayOutput
}

type ResourceArray []ResourceInput

func (ResourceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Resource)(nil)).Elem()
}

func (i ResourceArray) ToResourceArrayOutput() ResourceArrayOutput {
	return i.ToResourceArrayOutputWithContext(context.Background())
}

func (i ResourceArray) ToResourceArrayOutputWithContext(ctx context.Context) ResourceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourceArrayOutput)
}

// ResourceMapInput is an input type that accepts ResourceMap and ResourceMapOutput values.
// You can construct a concrete instance of `ResourceMapInput` via:
//
//	ResourceMap{ "key": ResourceArgs{...} }
type ResourceMapInput interface {
	pulumi.Input

	ToResourceMapOutput() ResourceMapOutput
	ToResourceMapOutputWithContext(context.Context) ResourceMapOutput
}

type ResourceMap map[string]ResourceInput

func (ResourceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Resource)(nil)).Elem()
}

func (i ResourceMap) ToResourceMapOutput() ResourceMapOutput {
	return i.ToResourceMapOutputWithContext(context.Background())
}

func (i ResourceMap) ToResourceMapOutputWithContext(ctx context.Context) ResourceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourceMapOutput)
}

type ResourceOutput struct{ *pulumi.OutputState }

func (ResourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Resource)(nil)).Elem()
}

func (o ResourceOutput) ToResourceOutput() ResourceOutput {
	return o
}

func (o ResourceOutput) ToResourceOutputWithContext(ctx context.Context) ResourceOutput {
	return o
}

// Automatic renewal. 1 is auto renew flag, 0 is not.
func (o ResourceOutput) AutoRenewFlag() pulumi.IntOutput {
	return o.ApplyT(func(v *Resource) pulumi.IntOutput { return v.AutoRenewFlag }).(pulumi.IntOutput)
}

// Subnet segments that require service activation.
func (o ResourceOutput) CidrBlock() pulumi.StringOutput {
	return o.ApplyT(func(v *Resource) pulumi.StringOutput { return v.CidrBlock }).(pulumi.StringOutput)
}

// Deploy region.
func (o ResourceOutput) DeployRegion() pulumi.StringOutput {
	return o.ApplyT(func(v *Resource) pulumi.StringOutput { return v.DeployRegion }).(pulumi.StringOutput)
}

// Deploy zone.
func (o ResourceOutput) DeployZone() pulumi.StringOutput {
	return o.ApplyT(func(v *Resource) pulumi.StringOutput { return v.DeployZone }).(pulumi.StringOutput)
}

// Number of bandwidth expansion packets (4M), The set value is an integer multiple of 4.
func (o ResourceOutput) PackageBandwidth() pulumi.IntOutput {
	return o.ApplyT(func(v *Resource) pulumi.IntOutput { return v.PackageBandwidth }).(pulumi.IntOutput)
}

// Resource type.Value:standard/pro.
func (o ResourceOutput) ResourceEdition() pulumi.StringOutput {
	return o.ApplyT(func(v *Resource) pulumi.StringOutput { return v.ResourceEdition }).(pulumi.StringOutput)
}

// Number of resource nodes.
func (o ResourceOutput) ResourceNode() pulumi.IntOutput {
	return o.ApplyT(func(v *Resource) pulumi.IntOutput { return v.ResourceNode }).(pulumi.IntOutput)
}

// Deploy resource subnetId.
func (o ResourceOutput) SubnetId() pulumi.StringOutput {
	return o.ApplyT(func(v *Resource) pulumi.StringOutput { return v.SubnetId }).(pulumi.StringOutput)
}

// Billing time. This field is mandatory, with a minimum value of 1.
func (o ResourceOutput) TimeSpan() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Resource) pulumi.IntPtrOutput { return v.TimeSpan }).(pulumi.IntPtrOutput)
}

// Billing cycle, only support m: month. This field is mandatory, fill in m.
func (o ResourceOutput) TimeUnit() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Resource) pulumi.StringPtrOutput { return v.TimeUnit }).(pulumi.StringPtrOutput)
}

// The network segment corresponding to the VPC that requires service activation.
func (o ResourceOutput) VpcCidrBlock() pulumi.StringOutput {
	return o.ApplyT(func(v *Resource) pulumi.StringOutput { return v.VpcCidrBlock }).(pulumi.StringOutput)
}

// Deploy resource vpcId.
func (o ResourceOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v *Resource) pulumi.StringOutput { return v.VpcId }).(pulumi.StringOutput)
}

type ResourceArrayOutput struct{ *pulumi.OutputState }

func (ResourceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Resource)(nil)).Elem()
}

func (o ResourceArrayOutput) ToResourceArrayOutput() ResourceArrayOutput {
	return o
}

func (o ResourceArrayOutput) ToResourceArrayOutputWithContext(ctx context.Context) ResourceArrayOutput {
	return o
}

func (o ResourceArrayOutput) Index(i pulumi.IntInput) ResourceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Resource {
		return vs[0].([]*Resource)[vs[1].(int)]
	}).(ResourceOutput)
}

type ResourceMapOutput struct{ *pulumi.OutputState }

func (ResourceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Resource)(nil)).Elem()
}

func (o ResourceMapOutput) ToResourceMapOutput() ResourceMapOutput {
	return o
}

func (o ResourceMapOutput) ToResourceMapOutputWithContext(ctx context.Context) ResourceMapOutput {
	return o
}

func (o ResourceMapOutput) MapIndex(k pulumi.StringInput) ResourceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Resource {
		return vs[0].(map[string]*Resource)[vs[1].(string)]
	}).(ResourceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ResourceInput)(nil)).Elem(), &Resource{})
	pulumi.RegisterInputType(reflect.TypeOf((*ResourceArrayInput)(nil)).Elem(), ResourceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ResourceMapInput)(nil)).Elem(), ResourceMap{})
	pulumi.RegisterOutputType(ResourceOutput{})
	pulumi.RegisterOutputType(ResourceArrayOutput{})
	pulumi.RegisterOutputType(ResourceMapOutput{})
}