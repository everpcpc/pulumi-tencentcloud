// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sqlserver

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a sqlserver completeExpansion
//
// ## Example Usage
//
// ### First, Create a basic SQL instance
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Availability"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Security"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Sqlserver"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			zones, err := Availability.GetZonesByProduct(ctx, &availability.GetZonesByProductArgs{
//				Product: "sqlserver",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			vpc, err := Vpc.NewInstance(ctx, "vpc", &Vpc.InstanceArgs{
//				CidrBlock: pulumi.String("10.0.0.0/16"),
//			})
//			if err != nil {
//				return err
//			}
//			subnet, err := Subnet.NewInstance(ctx, "subnet", &Subnet.InstanceArgs{
//				AvailabilityZone: pulumi.String(zones.Zones[4].Name),
//				VpcId:            vpc.ID(),
//				CidrBlock:        pulumi.String("10.0.0.0/16"),
//				IsMulticast:      pulumi.Bool(false),
//			})
//			if err != nil {
//				return err
//			}
//			securityGroup, err := Security.NewGroup(ctx, "securityGroup", &Security.GroupArgs{
//				Description: pulumi.String("desc."),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Sqlserver.NewInstance(ctx, "example", &Sqlserver.InstanceArgs{
//				AvailabilityZone: pulumi.String(zones.Zones[4].Name),
//				ChargeType:       pulumi.String("POSTPAID_BY_HOUR"),
//				VpcId:            vpc.ID(),
//				SubnetId:         subnet.ID(),
//				SecurityGroups: pulumi.StringArray{
//					securityGroup.ID(),
//				},
//				ProjectId: pulumi.Int(0),
//				Memory:    pulumi.Int(2),
//				Storage:   pulumi.Int(20),
//				MaintenanceWeekSets: pulumi.IntArray{
//					pulumi.Int(1),
//					pulumi.Int(2),
//					pulumi.Int(3),
//				},
//				MaintenanceStartTime: pulumi.String("01:00"),
//				MaintenanceTimeSpan:  pulumi.Int(3),
//				Tags: pulumi.Map{
//					"createBy": pulumi.Any("tfExample"),
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
// ### Expand the current instance, storage: 20->40, waitSwitch = 1
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Sqlserver"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Sqlserver.NewInstance(ctx, "example", &Sqlserver.InstanceArgs{
//				AvailabilityZone: pulumi.Any(data.Tencentcloud_availability_zones_by_product.Zones.Zones[4].Name),
//				ChargeType:       pulumi.String("POSTPAID_BY_HOUR"),
//				VpcId:            pulumi.Any(tencentcloud_vpc.Vpc.Id),
//				SubnetId:         pulumi.Any(tencentcloud_subnet.Subnet.Id),
//				SecurityGroups: pulumi.StringArray{
//					tencentcloud_security_group.Security_group.Id,
//				},
//				ProjectId:  pulumi.Int(0),
//				Memory:     pulumi.Int(2),
//				Storage:    pulumi.Int(40),
//				WaitSwitch: pulumi.Int(1),
//				MaintenanceWeekSets: pulumi.IntArray{
//					pulumi.Int(1),
//					pulumi.Int(2),
//					pulumi.Int(3),
//				},
//				MaintenanceStartTime: pulumi.String("01:00"),
//				MaintenanceTimeSpan:  pulumi.Int(3),
//				Tags: pulumi.Map{
//					"createBy": pulumi.Any("tfExample"),
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
// ### Complete the expansion task immediately
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Sqlserver"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Sqlserver.NewCompleteExpansion(ctx, "example", &Sqlserver.CompleteExpansionArgs{
//				InstanceId: pulumi.Any(tencentcloud_sqlserver_instance.Example.Id),
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
type CompleteExpansion struct {
	pulumi.CustomResourceState

	// ID of imported target instance.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
}

// NewCompleteExpansion registers a new resource with the given unique name, arguments, and options.
func NewCompleteExpansion(ctx *pulumi.Context,
	name string, args *CompleteExpansionArgs, opts ...pulumi.ResourceOption) (*CompleteExpansion, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource CompleteExpansion
	err := ctx.RegisterResource("tencentcloud:Sqlserver/completeExpansion:CompleteExpansion", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCompleteExpansion gets an existing CompleteExpansion resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCompleteExpansion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CompleteExpansionState, opts ...pulumi.ResourceOption) (*CompleteExpansion, error) {
	var resource CompleteExpansion
	err := ctx.ReadResource("tencentcloud:Sqlserver/completeExpansion:CompleteExpansion", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CompleteExpansion resources.
type completeExpansionState struct {
	// ID of imported target instance.
	InstanceId *string `pulumi:"instanceId"`
}

type CompleteExpansionState struct {
	// ID of imported target instance.
	InstanceId pulumi.StringPtrInput
}

func (CompleteExpansionState) ElementType() reflect.Type {
	return reflect.TypeOf((*completeExpansionState)(nil)).Elem()
}

type completeExpansionArgs struct {
	// ID of imported target instance.
	InstanceId string `pulumi:"instanceId"`
}

// The set of arguments for constructing a CompleteExpansion resource.
type CompleteExpansionArgs struct {
	// ID of imported target instance.
	InstanceId pulumi.StringInput
}

func (CompleteExpansionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*completeExpansionArgs)(nil)).Elem()
}

type CompleteExpansionInput interface {
	pulumi.Input

	ToCompleteExpansionOutput() CompleteExpansionOutput
	ToCompleteExpansionOutputWithContext(ctx context.Context) CompleteExpansionOutput
}

func (*CompleteExpansion) ElementType() reflect.Type {
	return reflect.TypeOf((**CompleteExpansion)(nil)).Elem()
}

func (i *CompleteExpansion) ToCompleteExpansionOutput() CompleteExpansionOutput {
	return i.ToCompleteExpansionOutputWithContext(context.Background())
}

func (i *CompleteExpansion) ToCompleteExpansionOutputWithContext(ctx context.Context) CompleteExpansionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CompleteExpansionOutput)
}

// CompleteExpansionArrayInput is an input type that accepts CompleteExpansionArray and CompleteExpansionArrayOutput values.
// You can construct a concrete instance of `CompleteExpansionArrayInput` via:
//
//	CompleteExpansionArray{ CompleteExpansionArgs{...} }
type CompleteExpansionArrayInput interface {
	pulumi.Input

	ToCompleteExpansionArrayOutput() CompleteExpansionArrayOutput
	ToCompleteExpansionArrayOutputWithContext(context.Context) CompleteExpansionArrayOutput
}

type CompleteExpansionArray []CompleteExpansionInput

func (CompleteExpansionArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CompleteExpansion)(nil)).Elem()
}

func (i CompleteExpansionArray) ToCompleteExpansionArrayOutput() CompleteExpansionArrayOutput {
	return i.ToCompleteExpansionArrayOutputWithContext(context.Background())
}

func (i CompleteExpansionArray) ToCompleteExpansionArrayOutputWithContext(ctx context.Context) CompleteExpansionArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CompleteExpansionArrayOutput)
}

// CompleteExpansionMapInput is an input type that accepts CompleteExpansionMap and CompleteExpansionMapOutput values.
// You can construct a concrete instance of `CompleteExpansionMapInput` via:
//
//	CompleteExpansionMap{ "key": CompleteExpansionArgs{...} }
type CompleteExpansionMapInput interface {
	pulumi.Input

	ToCompleteExpansionMapOutput() CompleteExpansionMapOutput
	ToCompleteExpansionMapOutputWithContext(context.Context) CompleteExpansionMapOutput
}

type CompleteExpansionMap map[string]CompleteExpansionInput

func (CompleteExpansionMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CompleteExpansion)(nil)).Elem()
}

func (i CompleteExpansionMap) ToCompleteExpansionMapOutput() CompleteExpansionMapOutput {
	return i.ToCompleteExpansionMapOutputWithContext(context.Background())
}

func (i CompleteExpansionMap) ToCompleteExpansionMapOutputWithContext(ctx context.Context) CompleteExpansionMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CompleteExpansionMapOutput)
}

type CompleteExpansionOutput struct{ *pulumi.OutputState }

func (CompleteExpansionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CompleteExpansion)(nil)).Elem()
}

func (o CompleteExpansionOutput) ToCompleteExpansionOutput() CompleteExpansionOutput {
	return o
}

func (o CompleteExpansionOutput) ToCompleteExpansionOutputWithContext(ctx context.Context) CompleteExpansionOutput {
	return o
}

// ID of imported target instance.
func (o CompleteExpansionOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *CompleteExpansion) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

type CompleteExpansionArrayOutput struct{ *pulumi.OutputState }

func (CompleteExpansionArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CompleteExpansion)(nil)).Elem()
}

func (o CompleteExpansionArrayOutput) ToCompleteExpansionArrayOutput() CompleteExpansionArrayOutput {
	return o
}

func (o CompleteExpansionArrayOutput) ToCompleteExpansionArrayOutputWithContext(ctx context.Context) CompleteExpansionArrayOutput {
	return o
}

func (o CompleteExpansionArrayOutput) Index(i pulumi.IntInput) CompleteExpansionOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CompleteExpansion {
		return vs[0].([]*CompleteExpansion)[vs[1].(int)]
	}).(CompleteExpansionOutput)
}

type CompleteExpansionMapOutput struct{ *pulumi.OutputState }

func (CompleteExpansionMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CompleteExpansion)(nil)).Elem()
}

func (o CompleteExpansionMapOutput) ToCompleteExpansionMapOutput() CompleteExpansionMapOutput {
	return o
}

func (o CompleteExpansionMapOutput) ToCompleteExpansionMapOutputWithContext(ctx context.Context) CompleteExpansionMapOutput {
	return o
}

func (o CompleteExpansionMapOutput) MapIndex(k pulumi.StringInput) CompleteExpansionOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CompleteExpansion {
		return vs[0].(map[string]*CompleteExpansion)[vs[1].(string)]
	}).(CompleteExpansionOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CompleteExpansionInput)(nil)).Elem(), &CompleteExpansion{})
	pulumi.RegisterInputType(reflect.TypeOf((*CompleteExpansionArrayInput)(nil)).Elem(), CompleteExpansionArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CompleteExpansionMapInput)(nil)).Elem(), CompleteExpansionMap{})
	pulumi.RegisterOutputType(CompleteExpansionOutput{})
	pulumi.RegisterOutputType(CompleteExpansionArrayOutput{})
	pulumi.RegisterOutputType(CompleteExpansionMapOutput{})
}