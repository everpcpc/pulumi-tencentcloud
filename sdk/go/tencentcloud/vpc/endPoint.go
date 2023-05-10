// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vpc

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a vpc endPoint
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Vpc.NewEndPoint(ctx, "endPoint", &Vpc.EndPointArgs{
// 			EndPointName:      pulumi.String("terraform-test"),
// 			EndPointServiceId: pulumi.String("vpcsvc-69y13tdb"),
// 			EndPointVip:       pulumi.String("10.0.2.1"),
// 			SubnetId:          pulumi.String("subnet-ljyn7h30"),
// 			VpcId:             pulumi.String("vpc-391sv4w3"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// vpc end_point can be imported using the id, e.g.
//
// ```sh
//  $ pulumi import tencentcloud:Vpc/endPoint:EndPoint end_point end_point_id
// ```
type EndPoint struct {
	pulumi.CustomResourceState

	// Create Time.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// Name of endpoint.
	EndPointName pulumi.StringOutput `pulumi:"endPointName"`
	// APPID.
	EndPointOwner pulumi.StringOutput `pulumi:"endPointOwner"`
	// ID of endpoint service.
	EndPointServiceId pulumi.StringOutput `pulumi:"endPointServiceId"`
	// VIP of endpoint ip.
	EndPointVip pulumi.StringPtrOutput `pulumi:"endPointVip"`
	// state of end point.
	State pulumi.StringOutput `pulumi:"state"`
	// ID of subnet instance.
	SubnetId pulumi.StringOutput `pulumi:"subnetId"`
	// ID of vpc instance.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
}

// NewEndPoint registers a new resource with the given unique name, arguments, and options.
func NewEndPoint(ctx *pulumi.Context,
	name string, args *EndPointArgs, opts ...pulumi.ResourceOption) (*EndPoint, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EndPointName == nil {
		return nil, errors.New("invalid value for required argument 'EndPointName'")
	}
	if args.EndPointServiceId == nil {
		return nil, errors.New("invalid value for required argument 'EndPointServiceId'")
	}
	if args.SubnetId == nil {
		return nil, errors.New("invalid value for required argument 'SubnetId'")
	}
	if args.VpcId == nil {
		return nil, errors.New("invalid value for required argument 'VpcId'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource EndPoint
	err := ctx.RegisterResource("tencentcloud:Vpc/endPoint:EndPoint", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEndPoint gets an existing EndPoint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEndPoint(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EndPointState, opts ...pulumi.ResourceOption) (*EndPoint, error) {
	var resource EndPoint
	err := ctx.ReadResource("tencentcloud:Vpc/endPoint:EndPoint", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EndPoint resources.
type endPointState struct {
	// Create Time.
	CreateTime *string `pulumi:"createTime"`
	// Name of endpoint.
	EndPointName *string `pulumi:"endPointName"`
	// APPID.
	EndPointOwner *string `pulumi:"endPointOwner"`
	// ID of endpoint service.
	EndPointServiceId *string `pulumi:"endPointServiceId"`
	// VIP of endpoint ip.
	EndPointVip *string `pulumi:"endPointVip"`
	// state of end point.
	State *string `pulumi:"state"`
	// ID of subnet instance.
	SubnetId *string `pulumi:"subnetId"`
	// ID of vpc instance.
	VpcId *string `pulumi:"vpcId"`
}

type EndPointState struct {
	// Create Time.
	CreateTime pulumi.StringPtrInput
	// Name of endpoint.
	EndPointName pulumi.StringPtrInput
	// APPID.
	EndPointOwner pulumi.StringPtrInput
	// ID of endpoint service.
	EndPointServiceId pulumi.StringPtrInput
	// VIP of endpoint ip.
	EndPointVip pulumi.StringPtrInput
	// state of end point.
	State pulumi.StringPtrInput
	// ID of subnet instance.
	SubnetId pulumi.StringPtrInput
	// ID of vpc instance.
	VpcId pulumi.StringPtrInput
}

func (EndPointState) ElementType() reflect.Type {
	return reflect.TypeOf((*endPointState)(nil)).Elem()
}

type endPointArgs struct {
	// Name of endpoint.
	EndPointName string `pulumi:"endPointName"`
	// ID of endpoint service.
	EndPointServiceId string `pulumi:"endPointServiceId"`
	// VIP of endpoint ip.
	EndPointVip *string `pulumi:"endPointVip"`
	// ID of subnet instance.
	SubnetId string `pulumi:"subnetId"`
	// ID of vpc instance.
	VpcId string `pulumi:"vpcId"`
}

// The set of arguments for constructing a EndPoint resource.
type EndPointArgs struct {
	// Name of endpoint.
	EndPointName pulumi.StringInput
	// ID of endpoint service.
	EndPointServiceId pulumi.StringInput
	// VIP of endpoint ip.
	EndPointVip pulumi.StringPtrInput
	// ID of subnet instance.
	SubnetId pulumi.StringInput
	// ID of vpc instance.
	VpcId pulumi.StringInput
}

func (EndPointArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*endPointArgs)(nil)).Elem()
}

type EndPointInput interface {
	pulumi.Input

	ToEndPointOutput() EndPointOutput
	ToEndPointOutputWithContext(ctx context.Context) EndPointOutput
}

func (*EndPoint) ElementType() reflect.Type {
	return reflect.TypeOf((**EndPoint)(nil)).Elem()
}

func (i *EndPoint) ToEndPointOutput() EndPointOutput {
	return i.ToEndPointOutputWithContext(context.Background())
}

func (i *EndPoint) ToEndPointOutputWithContext(ctx context.Context) EndPointOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EndPointOutput)
}

// EndPointArrayInput is an input type that accepts EndPointArray and EndPointArrayOutput values.
// You can construct a concrete instance of `EndPointArrayInput` via:
//
//          EndPointArray{ EndPointArgs{...} }
type EndPointArrayInput interface {
	pulumi.Input

	ToEndPointArrayOutput() EndPointArrayOutput
	ToEndPointArrayOutputWithContext(context.Context) EndPointArrayOutput
}

type EndPointArray []EndPointInput

func (EndPointArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*EndPoint)(nil)).Elem()
}

func (i EndPointArray) ToEndPointArrayOutput() EndPointArrayOutput {
	return i.ToEndPointArrayOutputWithContext(context.Background())
}

func (i EndPointArray) ToEndPointArrayOutputWithContext(ctx context.Context) EndPointArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EndPointArrayOutput)
}

// EndPointMapInput is an input type that accepts EndPointMap and EndPointMapOutput values.
// You can construct a concrete instance of `EndPointMapInput` via:
//
//          EndPointMap{ "key": EndPointArgs{...} }
type EndPointMapInput interface {
	pulumi.Input

	ToEndPointMapOutput() EndPointMapOutput
	ToEndPointMapOutputWithContext(context.Context) EndPointMapOutput
}

type EndPointMap map[string]EndPointInput

func (EndPointMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*EndPoint)(nil)).Elem()
}

func (i EndPointMap) ToEndPointMapOutput() EndPointMapOutput {
	return i.ToEndPointMapOutputWithContext(context.Background())
}

func (i EndPointMap) ToEndPointMapOutputWithContext(ctx context.Context) EndPointMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EndPointMapOutput)
}

type EndPointOutput struct{ *pulumi.OutputState }

func (EndPointOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EndPoint)(nil)).Elem()
}

func (o EndPointOutput) ToEndPointOutput() EndPointOutput {
	return o
}

func (o EndPointOutput) ToEndPointOutputWithContext(ctx context.Context) EndPointOutput {
	return o
}

// Create Time.
func (o EndPointOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *EndPoint) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// Name of endpoint.
func (o EndPointOutput) EndPointName() pulumi.StringOutput {
	return o.ApplyT(func(v *EndPoint) pulumi.StringOutput { return v.EndPointName }).(pulumi.StringOutput)
}

// APPID.
func (o EndPointOutput) EndPointOwner() pulumi.StringOutput {
	return o.ApplyT(func(v *EndPoint) pulumi.StringOutput { return v.EndPointOwner }).(pulumi.StringOutput)
}

// ID of endpoint service.
func (o EndPointOutput) EndPointServiceId() pulumi.StringOutput {
	return o.ApplyT(func(v *EndPoint) pulumi.StringOutput { return v.EndPointServiceId }).(pulumi.StringOutput)
}

// VIP of endpoint ip.
func (o EndPointOutput) EndPointVip() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EndPoint) pulumi.StringPtrOutput { return v.EndPointVip }).(pulumi.StringPtrOutput)
}

// state of end point.
func (o EndPointOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *EndPoint) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

// ID of subnet instance.
func (o EndPointOutput) SubnetId() pulumi.StringOutput {
	return o.ApplyT(func(v *EndPoint) pulumi.StringOutput { return v.SubnetId }).(pulumi.StringOutput)
}

// ID of vpc instance.
func (o EndPointOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v *EndPoint) pulumi.StringOutput { return v.VpcId }).(pulumi.StringOutput)
}

type EndPointArrayOutput struct{ *pulumi.OutputState }

func (EndPointArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*EndPoint)(nil)).Elem()
}

func (o EndPointArrayOutput) ToEndPointArrayOutput() EndPointArrayOutput {
	return o
}

func (o EndPointArrayOutput) ToEndPointArrayOutputWithContext(ctx context.Context) EndPointArrayOutput {
	return o
}

func (o EndPointArrayOutput) Index(i pulumi.IntInput) EndPointOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *EndPoint {
		return vs[0].([]*EndPoint)[vs[1].(int)]
	}).(EndPointOutput)
}

type EndPointMapOutput struct{ *pulumi.OutputState }

func (EndPointMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*EndPoint)(nil)).Elem()
}

func (o EndPointMapOutput) ToEndPointMapOutput() EndPointMapOutput {
	return o
}

func (o EndPointMapOutput) ToEndPointMapOutputWithContext(ctx context.Context) EndPointMapOutput {
	return o
}

func (o EndPointMapOutput) MapIndex(k pulumi.StringInput) EndPointOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *EndPoint {
		return vs[0].(map[string]*EndPoint)[vs[1].(string)]
	}).(EndPointOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*EndPointInput)(nil)).Elem(), &EndPoint{})
	pulumi.RegisterInputType(reflect.TypeOf((*EndPointArrayInput)(nil)).Elem(), EndPointArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*EndPointMapInput)(nil)).Elem(), EndPointMap{})
	pulumi.RegisterOutputType(EndPointOutput{})
	pulumi.RegisterOutputType(EndPointArrayOutput{})
	pulumi.RegisterOutputType(EndPointMapOutput{})
}