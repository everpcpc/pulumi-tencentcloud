// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mysql

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a mysql renewDbInstanceOperation
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Availability"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Security"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			zones, err := Availability.GetZonesByProduct(ctx, &availability.GetZonesByProductArgs{
//				Product: "cdb",
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
//				AvailabilityZone: pulumi.String(zones.Zones[0].Name),
//				VpcId:            vpc.ID(),
//				CidrBlock:        pulumi.String("10.0.0.0/16"),
//				IsMulticast:      pulumi.Bool(false),
//			})
//			if err != nil {
//				return err
//			}
//			securityGroup, err := Security.NewGroup(ctx, "securityGroup", &Security.GroupArgs{
//				Description: pulumi.String("mysql test"),
//			})
//			if err != nil {
//				return err
//			}
//			exampleInstance, err := Mysql.NewInstance(ctx, "exampleInstance", &Mysql.InstanceArgs{
//				InternetService:  pulumi.Int(1),
//				EngineVersion:    pulumi.String("5.7"),
//				ChargeType:       pulumi.String("PREPAID"),
//				RootPassword:     pulumi.String("PassWord123"),
//				SlaveDeployMode:  pulumi.Int(1),
//				AvailabilityZone: pulumi.String(zones.Zones[0].Name),
//				FirstSlaveZone:   pulumi.String(zones.Zones[1].Name),
//				SlaveSyncMode:    pulumi.Int(1),
//				InstanceName:     pulumi.String("tf-example-mysql"),
//				MemSize:          pulumi.Int(4000),
//				VolumeSize:       pulumi.Int(200),
//				VpcId:            vpc.ID(),
//				SubnetId:         subnet.ID(),
//				IntranetPort:     pulumi.Int(3306),
//				SecurityGroups: pulumi.StringArray{
//					securityGroup.ID(),
//				},
//				Tags: pulumi.Map{
//					"name": pulumi.Any("test"),
//				},
//				Parameters: pulumi.Map{
//					"character_set_server": pulumi.Any("utf8"),
//					"max_connections":      pulumi.Any("1000"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_ = Mysql.GetRollbackRangeTimeOutput(ctx, mysql.GetRollbackRangeTimeOutputArgs{
//				InstanceIds: pulumi.StringArray{
//					exampleInstance.ID(),
//				},
//			}, nil)
//			_, err = Mysql.NewRenewDbInstanceOperation(ctx, "exampleRenewDbInstanceOperation", &Mysql.RenewDbInstanceOperationArgs{
//				InstanceId:    exampleInstance.ID(),
//				TimeSpan:      pulumi.Int(1),
//				ModifyPayType: pulumi.String("PREPAID"),
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
type RenewDbInstanceOperation struct {
	pulumi.CustomResourceState

	// Instance expiration time.
	DeadlineTime pulumi.StringOutput `pulumi:"deadlineTime"`
	// Deal id.
	DealId pulumi.StringOutput `pulumi:"dealId"`
	// The instance ID to be renewed, the format is: cdb-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page, you can use [Query Instance List](https://cloud.tencent.com/document/api/236/ 15872).
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// If you need to renew the Pay-As-You-Go instance to a Subscription instance, the value of this input parameter needs to be specified as `PREPAID`.
	ModifyPayType pulumi.StringPtrOutput `pulumi:"modifyPayType"`
	// Renewal duration, unit: month, optional values include [1,2,3,4,5,6,7,8,9,10,11,12,24,36].
	TimeSpan pulumi.IntOutput `pulumi:"timeSpan"`
}

// NewRenewDbInstanceOperation registers a new resource with the given unique name, arguments, and options.
func NewRenewDbInstanceOperation(ctx *pulumi.Context,
	name string, args *RenewDbInstanceOperationArgs, opts ...pulumi.ResourceOption) (*RenewDbInstanceOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.TimeSpan == nil {
		return nil, errors.New("invalid value for required argument 'TimeSpan'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RenewDbInstanceOperation
	err := ctx.RegisterResource("tencentcloud:Mysql/renewDbInstanceOperation:RenewDbInstanceOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRenewDbInstanceOperation gets an existing RenewDbInstanceOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRenewDbInstanceOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RenewDbInstanceOperationState, opts ...pulumi.ResourceOption) (*RenewDbInstanceOperation, error) {
	var resource RenewDbInstanceOperation
	err := ctx.ReadResource("tencentcloud:Mysql/renewDbInstanceOperation:RenewDbInstanceOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RenewDbInstanceOperation resources.
type renewDbInstanceOperationState struct {
	// Instance expiration time.
	DeadlineTime *string `pulumi:"deadlineTime"`
	// Deal id.
	DealId *string `pulumi:"dealId"`
	// The instance ID to be renewed, the format is: cdb-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page, you can use [Query Instance List](https://cloud.tencent.com/document/api/236/ 15872).
	InstanceId *string `pulumi:"instanceId"`
	// If you need to renew the Pay-As-You-Go instance to a Subscription instance, the value of this input parameter needs to be specified as `PREPAID`.
	ModifyPayType *string `pulumi:"modifyPayType"`
	// Renewal duration, unit: month, optional values include [1,2,3,4,5,6,7,8,9,10,11,12,24,36].
	TimeSpan *int `pulumi:"timeSpan"`
}

type RenewDbInstanceOperationState struct {
	// Instance expiration time.
	DeadlineTime pulumi.StringPtrInput
	// Deal id.
	DealId pulumi.StringPtrInput
	// The instance ID to be renewed, the format is: cdb-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page, you can use [Query Instance List](https://cloud.tencent.com/document/api/236/ 15872).
	InstanceId pulumi.StringPtrInput
	// If you need to renew the Pay-As-You-Go instance to a Subscription instance, the value of this input parameter needs to be specified as `PREPAID`.
	ModifyPayType pulumi.StringPtrInput
	// Renewal duration, unit: month, optional values include [1,2,3,4,5,6,7,8,9,10,11,12,24,36].
	TimeSpan pulumi.IntPtrInput
}

func (RenewDbInstanceOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*renewDbInstanceOperationState)(nil)).Elem()
}

type renewDbInstanceOperationArgs struct {
	// The instance ID to be renewed, the format is: cdb-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page, you can use [Query Instance List](https://cloud.tencent.com/document/api/236/ 15872).
	InstanceId string `pulumi:"instanceId"`
	// If you need to renew the Pay-As-You-Go instance to a Subscription instance, the value of this input parameter needs to be specified as `PREPAID`.
	ModifyPayType *string `pulumi:"modifyPayType"`
	// Renewal duration, unit: month, optional values include [1,2,3,4,5,6,7,8,9,10,11,12,24,36].
	TimeSpan int `pulumi:"timeSpan"`
}

// The set of arguments for constructing a RenewDbInstanceOperation resource.
type RenewDbInstanceOperationArgs struct {
	// The instance ID to be renewed, the format is: cdb-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page, you can use [Query Instance List](https://cloud.tencent.com/document/api/236/ 15872).
	InstanceId pulumi.StringInput
	// If you need to renew the Pay-As-You-Go instance to a Subscription instance, the value of this input parameter needs to be specified as `PREPAID`.
	ModifyPayType pulumi.StringPtrInput
	// Renewal duration, unit: month, optional values include [1,2,3,4,5,6,7,8,9,10,11,12,24,36].
	TimeSpan pulumi.IntInput
}

func (RenewDbInstanceOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*renewDbInstanceOperationArgs)(nil)).Elem()
}

type RenewDbInstanceOperationInput interface {
	pulumi.Input

	ToRenewDbInstanceOperationOutput() RenewDbInstanceOperationOutput
	ToRenewDbInstanceOperationOutputWithContext(ctx context.Context) RenewDbInstanceOperationOutput
}

func (*RenewDbInstanceOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**RenewDbInstanceOperation)(nil)).Elem()
}

func (i *RenewDbInstanceOperation) ToRenewDbInstanceOperationOutput() RenewDbInstanceOperationOutput {
	return i.ToRenewDbInstanceOperationOutputWithContext(context.Background())
}

func (i *RenewDbInstanceOperation) ToRenewDbInstanceOperationOutputWithContext(ctx context.Context) RenewDbInstanceOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RenewDbInstanceOperationOutput)
}

// RenewDbInstanceOperationArrayInput is an input type that accepts RenewDbInstanceOperationArray and RenewDbInstanceOperationArrayOutput values.
// You can construct a concrete instance of `RenewDbInstanceOperationArrayInput` via:
//
//	RenewDbInstanceOperationArray{ RenewDbInstanceOperationArgs{...} }
type RenewDbInstanceOperationArrayInput interface {
	pulumi.Input

	ToRenewDbInstanceOperationArrayOutput() RenewDbInstanceOperationArrayOutput
	ToRenewDbInstanceOperationArrayOutputWithContext(context.Context) RenewDbInstanceOperationArrayOutput
}

type RenewDbInstanceOperationArray []RenewDbInstanceOperationInput

func (RenewDbInstanceOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RenewDbInstanceOperation)(nil)).Elem()
}

func (i RenewDbInstanceOperationArray) ToRenewDbInstanceOperationArrayOutput() RenewDbInstanceOperationArrayOutput {
	return i.ToRenewDbInstanceOperationArrayOutputWithContext(context.Background())
}

func (i RenewDbInstanceOperationArray) ToRenewDbInstanceOperationArrayOutputWithContext(ctx context.Context) RenewDbInstanceOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RenewDbInstanceOperationArrayOutput)
}

// RenewDbInstanceOperationMapInput is an input type that accepts RenewDbInstanceOperationMap and RenewDbInstanceOperationMapOutput values.
// You can construct a concrete instance of `RenewDbInstanceOperationMapInput` via:
//
//	RenewDbInstanceOperationMap{ "key": RenewDbInstanceOperationArgs{...} }
type RenewDbInstanceOperationMapInput interface {
	pulumi.Input

	ToRenewDbInstanceOperationMapOutput() RenewDbInstanceOperationMapOutput
	ToRenewDbInstanceOperationMapOutputWithContext(context.Context) RenewDbInstanceOperationMapOutput
}

type RenewDbInstanceOperationMap map[string]RenewDbInstanceOperationInput

func (RenewDbInstanceOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RenewDbInstanceOperation)(nil)).Elem()
}

func (i RenewDbInstanceOperationMap) ToRenewDbInstanceOperationMapOutput() RenewDbInstanceOperationMapOutput {
	return i.ToRenewDbInstanceOperationMapOutputWithContext(context.Background())
}

func (i RenewDbInstanceOperationMap) ToRenewDbInstanceOperationMapOutputWithContext(ctx context.Context) RenewDbInstanceOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RenewDbInstanceOperationMapOutput)
}

type RenewDbInstanceOperationOutput struct{ *pulumi.OutputState }

func (RenewDbInstanceOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RenewDbInstanceOperation)(nil)).Elem()
}

func (o RenewDbInstanceOperationOutput) ToRenewDbInstanceOperationOutput() RenewDbInstanceOperationOutput {
	return o
}

func (o RenewDbInstanceOperationOutput) ToRenewDbInstanceOperationOutputWithContext(ctx context.Context) RenewDbInstanceOperationOutput {
	return o
}

// Instance expiration time.
func (o RenewDbInstanceOperationOutput) DeadlineTime() pulumi.StringOutput {
	return o.ApplyT(func(v *RenewDbInstanceOperation) pulumi.StringOutput { return v.DeadlineTime }).(pulumi.StringOutput)
}

// Deal id.
func (o RenewDbInstanceOperationOutput) DealId() pulumi.StringOutput {
	return o.ApplyT(func(v *RenewDbInstanceOperation) pulumi.StringOutput { return v.DealId }).(pulumi.StringOutput)
}

// The instance ID to be renewed, the format is: cdb-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page, you can use [Query Instance List](https://cloud.tencent.com/document/api/236/ 15872).
func (o RenewDbInstanceOperationOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *RenewDbInstanceOperation) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// If you need to renew the Pay-As-You-Go instance to a Subscription instance, the value of this input parameter needs to be specified as `PREPAID`.
func (o RenewDbInstanceOperationOutput) ModifyPayType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *RenewDbInstanceOperation) pulumi.StringPtrOutput { return v.ModifyPayType }).(pulumi.StringPtrOutput)
}

// Renewal duration, unit: month, optional values include [1,2,3,4,5,6,7,8,9,10,11,12,24,36].
func (o RenewDbInstanceOperationOutput) TimeSpan() pulumi.IntOutput {
	return o.ApplyT(func(v *RenewDbInstanceOperation) pulumi.IntOutput { return v.TimeSpan }).(pulumi.IntOutput)
}

type RenewDbInstanceOperationArrayOutput struct{ *pulumi.OutputState }

func (RenewDbInstanceOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RenewDbInstanceOperation)(nil)).Elem()
}

func (o RenewDbInstanceOperationArrayOutput) ToRenewDbInstanceOperationArrayOutput() RenewDbInstanceOperationArrayOutput {
	return o
}

func (o RenewDbInstanceOperationArrayOutput) ToRenewDbInstanceOperationArrayOutputWithContext(ctx context.Context) RenewDbInstanceOperationArrayOutput {
	return o
}

func (o RenewDbInstanceOperationArrayOutput) Index(i pulumi.IntInput) RenewDbInstanceOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RenewDbInstanceOperation {
		return vs[0].([]*RenewDbInstanceOperation)[vs[1].(int)]
	}).(RenewDbInstanceOperationOutput)
}

type RenewDbInstanceOperationMapOutput struct{ *pulumi.OutputState }

func (RenewDbInstanceOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RenewDbInstanceOperation)(nil)).Elem()
}

func (o RenewDbInstanceOperationMapOutput) ToRenewDbInstanceOperationMapOutput() RenewDbInstanceOperationMapOutput {
	return o
}

func (o RenewDbInstanceOperationMapOutput) ToRenewDbInstanceOperationMapOutputWithContext(ctx context.Context) RenewDbInstanceOperationMapOutput {
	return o
}

func (o RenewDbInstanceOperationMapOutput) MapIndex(k pulumi.StringInput) RenewDbInstanceOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RenewDbInstanceOperation {
		return vs[0].(map[string]*RenewDbInstanceOperation)[vs[1].(string)]
	}).(RenewDbInstanceOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RenewDbInstanceOperationInput)(nil)).Elem(), &RenewDbInstanceOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*RenewDbInstanceOperationArrayInput)(nil)).Elem(), RenewDbInstanceOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RenewDbInstanceOperationMapInput)(nil)).Elem(), RenewDbInstanceOperationMap{})
	pulumi.RegisterOutputType(RenewDbInstanceOperationOutput{})
	pulumi.RegisterOutputType(RenewDbInstanceOperationArrayOutput{})
	pulumi.RegisterOutputType(RenewDbInstanceOperationMapOutput{})
}
