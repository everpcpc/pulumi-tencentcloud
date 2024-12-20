// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package clickhouse

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a clickhouse instance.
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Clickhouse"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Clickhouse.NewInstance(ctx, "cdwchInstance", &Clickhouse.InstanceArgs{
//				ChargeType: pulumi.String("POSTPAID_BY_HOUR"),
//				CommonSpec: &clickhouse.InstanceCommonSpecArgs{
//					Count:    pulumi.Int(3),
//					DiskSize: pulumi.Int(300),
//					SpecName: pulumi.String("SCH6"),
//				},
//				DataSpec: &clickhouse.InstanceDataSpecArgs{
//					Count:    pulumi.Int(2),
//					DiskSize: pulumi.Int(300),
//					SpecName: pulumi.String("SCH6"),
//				},
//				HaFlag:         pulumi.Bool(true),
//				InstanceName:   pulumi.String("tf-test-clickhouse"),
//				ProductVersion: pulumi.String("21.8.12.29"),
//				SubnetId:       pulumi.String("subnet-xxxxxx"),
//				VpcId:          pulumi.String("vpc-xxxxxx"),
//				Zone:           pulumi.String("ap-guangzhou-6"),
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
// ### PREPAID instance
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Clickhouse"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Clickhouse.NewInstance(ctx, "cdwchInstancePrepaid", &Clickhouse.InstanceArgs{
//				ChargeType: pulumi.String("PREPAID"),
//				CommonSpec: &clickhouse.InstanceCommonSpecArgs{
//					Count:    pulumi.Int(3),
//					DiskSize: pulumi.Int(300),
//					SpecName: pulumi.String("SCH6"),
//				},
//				DataSpec: &clickhouse.InstanceDataSpecArgs{
//					Count:    pulumi.Int(2),
//					DiskSize: pulumi.Int(300),
//					SpecName: pulumi.String("SCH6"),
//				},
//				HaFlag:         pulumi.Bool(true),
//				InstanceName:   pulumi.String("tf-test-clickhouse-prepaid"),
//				ProductVersion: pulumi.String("21.8.12.29"),
//				RenewFlag:      pulumi.Int(1),
//				SubnetId:       pulumi.String("subnet-xxxxxx"),
//				TimeSpan:       pulumi.Int(1),
//				VpcId:          pulumi.String("vpc-xxxxxx"),
//				Zone:           pulumi.String("ap-guangzhou-6"),
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
// Clickhouse instance can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Clickhouse/instance:Instance foo cdwch-xxxxxx
// ```
type Instance struct {
	pulumi.CustomResourceState

	// Billing type: `PREPAID` prepaid, `POSTPAID_BY_HOUR` postpaid.
	ChargeType pulumi.StringOutput `pulumi:"chargeType"`
	// CLS log set id.
	ClsLogSetId pulumi.StringOutput `pulumi:"clsLogSetId"`
	// ZK node.
	CommonSpec InstanceCommonSpecOutput `pulumi:"commonSpec"`
	// COS bucket name.
	CosBucketName pulumi.StringOutput `pulumi:"cosBucketName"`
	// Data spec.
	DataSpec InstanceDataSpecOutput `pulumi:"dataSpec"`
	// Expire time.
	ExpireTime pulumi.StringOutput `pulumi:"expireTime"`
	// Whether it is highly available.
	HaFlag pulumi.BoolOutput `pulumi:"haFlag"`
	// Whether ZK is highly available.
	HaZk pulumi.BoolOutput `pulumi:"haZk"`
	// Instance name.
	InstanceName pulumi.StringOutput `pulumi:"instanceName"`
	// Whether it is mounted on a bare disk.
	MountDiskType pulumi.IntOutput `pulumi:"mountDiskType"`
	// Product version.
	ProductVersion pulumi.StringOutput `pulumi:"productVersion"`
	// PREPAID needs to be passed. Whether to renew automatically. 1 means auto renewal is enabled.
	RenewFlag pulumi.IntOutput `pulumi:"renewFlag"`
	// Subnet.
	SubnetId pulumi.StringOutput `pulumi:"subnetId"`
	// Tag description list.
	Tags pulumi.MapOutput `pulumi:"tags"`
	// Prepaid needs to be delivered, billing time length, how many months.
	TimeSpan pulumi.IntPtrOutput `pulumi:"timeSpan"`
	// Private network.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
	// Availability zone.
	Zone pulumi.StringOutput `pulumi:"zone"`
}

// NewInstance registers a new resource with the given unique name, arguments, and options.
func NewInstance(ctx *pulumi.Context,
	name string, args *InstanceArgs, opts ...pulumi.ResourceOption) (*Instance, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ChargeType == nil {
		return nil, errors.New("invalid value for required argument 'ChargeType'")
	}
	if args.DataSpec == nil {
		return nil, errors.New("invalid value for required argument 'DataSpec'")
	}
	if args.HaFlag == nil {
		return nil, errors.New("invalid value for required argument 'HaFlag'")
	}
	if args.InstanceName == nil {
		return nil, errors.New("invalid value for required argument 'InstanceName'")
	}
	if args.ProductVersion == nil {
		return nil, errors.New("invalid value for required argument 'ProductVersion'")
	}
	if args.SubnetId == nil {
		return nil, errors.New("invalid value for required argument 'SubnetId'")
	}
	if args.VpcId == nil {
		return nil, errors.New("invalid value for required argument 'VpcId'")
	}
	if args.Zone == nil {
		return nil, errors.New("invalid value for required argument 'Zone'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Instance
	err := ctx.RegisterResource("tencentcloud:Clickhouse/instance:Instance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetInstance gets an existing Instance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *InstanceState, opts ...pulumi.ResourceOption) (*Instance, error) {
	var resource Instance
	err := ctx.ReadResource("tencentcloud:Clickhouse/instance:Instance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Instance resources.
type instanceState struct {
	// Billing type: `PREPAID` prepaid, `POSTPAID_BY_HOUR` postpaid.
	ChargeType *string `pulumi:"chargeType"`
	// CLS log set id.
	ClsLogSetId *string `pulumi:"clsLogSetId"`
	// ZK node.
	CommonSpec *InstanceCommonSpec `pulumi:"commonSpec"`
	// COS bucket name.
	CosBucketName *string `pulumi:"cosBucketName"`
	// Data spec.
	DataSpec *InstanceDataSpec `pulumi:"dataSpec"`
	// Expire time.
	ExpireTime *string `pulumi:"expireTime"`
	// Whether it is highly available.
	HaFlag *bool `pulumi:"haFlag"`
	// Whether ZK is highly available.
	HaZk *bool `pulumi:"haZk"`
	// Instance name.
	InstanceName *string `pulumi:"instanceName"`
	// Whether it is mounted on a bare disk.
	MountDiskType *int `pulumi:"mountDiskType"`
	// Product version.
	ProductVersion *string `pulumi:"productVersion"`
	// PREPAID needs to be passed. Whether to renew automatically. 1 means auto renewal is enabled.
	RenewFlag *int `pulumi:"renewFlag"`
	// Subnet.
	SubnetId *string `pulumi:"subnetId"`
	// Tag description list.
	Tags map[string]interface{} `pulumi:"tags"`
	// Prepaid needs to be delivered, billing time length, how many months.
	TimeSpan *int `pulumi:"timeSpan"`
	// Private network.
	VpcId *string `pulumi:"vpcId"`
	// Availability zone.
	Zone *string `pulumi:"zone"`
}

type InstanceState struct {
	// Billing type: `PREPAID` prepaid, `POSTPAID_BY_HOUR` postpaid.
	ChargeType pulumi.StringPtrInput
	// CLS log set id.
	ClsLogSetId pulumi.StringPtrInput
	// ZK node.
	CommonSpec InstanceCommonSpecPtrInput
	// COS bucket name.
	CosBucketName pulumi.StringPtrInput
	// Data spec.
	DataSpec InstanceDataSpecPtrInput
	// Expire time.
	ExpireTime pulumi.StringPtrInput
	// Whether it is highly available.
	HaFlag pulumi.BoolPtrInput
	// Whether ZK is highly available.
	HaZk pulumi.BoolPtrInput
	// Instance name.
	InstanceName pulumi.StringPtrInput
	// Whether it is mounted on a bare disk.
	MountDiskType pulumi.IntPtrInput
	// Product version.
	ProductVersion pulumi.StringPtrInput
	// PREPAID needs to be passed. Whether to renew automatically. 1 means auto renewal is enabled.
	RenewFlag pulumi.IntPtrInput
	// Subnet.
	SubnetId pulumi.StringPtrInput
	// Tag description list.
	Tags pulumi.MapInput
	// Prepaid needs to be delivered, billing time length, how many months.
	TimeSpan pulumi.IntPtrInput
	// Private network.
	VpcId pulumi.StringPtrInput
	// Availability zone.
	Zone pulumi.StringPtrInput
}

func (InstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*instanceState)(nil)).Elem()
}

type instanceArgs struct {
	// Billing type: `PREPAID` prepaid, `POSTPAID_BY_HOUR` postpaid.
	ChargeType string `pulumi:"chargeType"`
	// CLS log set id.
	ClsLogSetId *string `pulumi:"clsLogSetId"`
	// ZK node.
	CommonSpec *InstanceCommonSpec `pulumi:"commonSpec"`
	// COS bucket name.
	CosBucketName *string `pulumi:"cosBucketName"`
	// Data spec.
	DataSpec InstanceDataSpec `pulumi:"dataSpec"`
	// Whether it is highly available.
	HaFlag bool `pulumi:"haFlag"`
	// Whether ZK is highly available.
	HaZk *bool `pulumi:"haZk"`
	// Instance name.
	InstanceName string `pulumi:"instanceName"`
	// Whether it is mounted on a bare disk.
	MountDiskType *int `pulumi:"mountDiskType"`
	// Product version.
	ProductVersion string `pulumi:"productVersion"`
	// PREPAID needs to be passed. Whether to renew automatically. 1 means auto renewal is enabled.
	RenewFlag *int `pulumi:"renewFlag"`
	// Subnet.
	SubnetId string `pulumi:"subnetId"`
	// Tag description list.
	Tags map[string]interface{} `pulumi:"tags"`
	// Prepaid needs to be delivered, billing time length, how many months.
	TimeSpan *int `pulumi:"timeSpan"`
	// Private network.
	VpcId string `pulumi:"vpcId"`
	// Availability zone.
	Zone string `pulumi:"zone"`
}

// The set of arguments for constructing a Instance resource.
type InstanceArgs struct {
	// Billing type: `PREPAID` prepaid, `POSTPAID_BY_HOUR` postpaid.
	ChargeType pulumi.StringInput
	// CLS log set id.
	ClsLogSetId pulumi.StringPtrInput
	// ZK node.
	CommonSpec InstanceCommonSpecPtrInput
	// COS bucket name.
	CosBucketName pulumi.StringPtrInput
	// Data spec.
	DataSpec InstanceDataSpecInput
	// Whether it is highly available.
	HaFlag pulumi.BoolInput
	// Whether ZK is highly available.
	HaZk pulumi.BoolPtrInput
	// Instance name.
	InstanceName pulumi.StringInput
	// Whether it is mounted on a bare disk.
	MountDiskType pulumi.IntPtrInput
	// Product version.
	ProductVersion pulumi.StringInput
	// PREPAID needs to be passed. Whether to renew automatically. 1 means auto renewal is enabled.
	RenewFlag pulumi.IntPtrInput
	// Subnet.
	SubnetId pulumi.StringInput
	// Tag description list.
	Tags pulumi.MapInput
	// Prepaid needs to be delivered, billing time length, how many months.
	TimeSpan pulumi.IntPtrInput
	// Private network.
	VpcId pulumi.StringInput
	// Availability zone.
	Zone pulumi.StringInput
}

func (InstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*instanceArgs)(nil)).Elem()
}

type InstanceInput interface {
	pulumi.Input

	ToInstanceOutput() InstanceOutput
	ToInstanceOutputWithContext(ctx context.Context) InstanceOutput
}

func (*Instance) ElementType() reflect.Type {
	return reflect.TypeOf((**Instance)(nil)).Elem()
}

func (i *Instance) ToInstanceOutput() InstanceOutput {
	return i.ToInstanceOutputWithContext(context.Background())
}

func (i *Instance) ToInstanceOutputWithContext(ctx context.Context) InstanceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceOutput)
}

// InstanceArrayInput is an input type that accepts InstanceArray and InstanceArrayOutput values.
// You can construct a concrete instance of `InstanceArrayInput` via:
//
//	InstanceArray{ InstanceArgs{...} }
type InstanceArrayInput interface {
	pulumi.Input

	ToInstanceArrayOutput() InstanceArrayOutput
	ToInstanceArrayOutputWithContext(context.Context) InstanceArrayOutput
}

type InstanceArray []InstanceInput

func (InstanceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Instance)(nil)).Elem()
}

func (i InstanceArray) ToInstanceArrayOutput() InstanceArrayOutput {
	return i.ToInstanceArrayOutputWithContext(context.Background())
}

func (i InstanceArray) ToInstanceArrayOutputWithContext(ctx context.Context) InstanceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceArrayOutput)
}

// InstanceMapInput is an input type that accepts InstanceMap and InstanceMapOutput values.
// You can construct a concrete instance of `InstanceMapInput` via:
//
//	InstanceMap{ "key": InstanceArgs{...} }
type InstanceMapInput interface {
	pulumi.Input

	ToInstanceMapOutput() InstanceMapOutput
	ToInstanceMapOutputWithContext(context.Context) InstanceMapOutput
}

type InstanceMap map[string]InstanceInput

func (InstanceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Instance)(nil)).Elem()
}

func (i InstanceMap) ToInstanceMapOutput() InstanceMapOutput {
	return i.ToInstanceMapOutputWithContext(context.Background())
}

func (i InstanceMap) ToInstanceMapOutputWithContext(ctx context.Context) InstanceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceMapOutput)
}

type InstanceOutput struct{ *pulumi.OutputState }

func (InstanceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Instance)(nil)).Elem()
}

func (o InstanceOutput) ToInstanceOutput() InstanceOutput {
	return o
}

func (o InstanceOutput) ToInstanceOutputWithContext(ctx context.Context) InstanceOutput {
	return o
}

// Billing type: `PREPAID` prepaid, `POSTPAID_BY_HOUR` postpaid.
func (o InstanceOutput) ChargeType() pulumi.StringOutput {
	return o.ApplyT(func(v *Instance) pulumi.StringOutput { return v.ChargeType }).(pulumi.StringOutput)
}

// CLS log set id.
func (o InstanceOutput) ClsLogSetId() pulumi.StringOutput {
	return o.ApplyT(func(v *Instance) pulumi.StringOutput { return v.ClsLogSetId }).(pulumi.StringOutput)
}

// ZK node.
func (o InstanceOutput) CommonSpec() InstanceCommonSpecOutput {
	return o.ApplyT(func(v *Instance) InstanceCommonSpecOutput { return v.CommonSpec }).(InstanceCommonSpecOutput)
}

// COS bucket name.
func (o InstanceOutput) CosBucketName() pulumi.StringOutput {
	return o.ApplyT(func(v *Instance) pulumi.StringOutput { return v.CosBucketName }).(pulumi.StringOutput)
}

// Data spec.
func (o InstanceOutput) DataSpec() InstanceDataSpecOutput {
	return o.ApplyT(func(v *Instance) InstanceDataSpecOutput { return v.DataSpec }).(InstanceDataSpecOutput)
}

// Expire time.
func (o InstanceOutput) ExpireTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Instance) pulumi.StringOutput { return v.ExpireTime }).(pulumi.StringOutput)
}

// Whether it is highly available.
func (o InstanceOutput) HaFlag() pulumi.BoolOutput {
	return o.ApplyT(func(v *Instance) pulumi.BoolOutput { return v.HaFlag }).(pulumi.BoolOutput)
}

// Whether ZK is highly available.
func (o InstanceOutput) HaZk() pulumi.BoolOutput {
	return o.ApplyT(func(v *Instance) pulumi.BoolOutput { return v.HaZk }).(pulumi.BoolOutput)
}

// Instance name.
func (o InstanceOutput) InstanceName() pulumi.StringOutput {
	return o.ApplyT(func(v *Instance) pulumi.StringOutput { return v.InstanceName }).(pulumi.StringOutput)
}

// Whether it is mounted on a bare disk.
func (o InstanceOutput) MountDiskType() pulumi.IntOutput {
	return o.ApplyT(func(v *Instance) pulumi.IntOutput { return v.MountDiskType }).(pulumi.IntOutput)
}

// Product version.
func (o InstanceOutput) ProductVersion() pulumi.StringOutput {
	return o.ApplyT(func(v *Instance) pulumi.StringOutput { return v.ProductVersion }).(pulumi.StringOutput)
}

// PREPAID needs to be passed. Whether to renew automatically. 1 means auto renewal is enabled.
func (o InstanceOutput) RenewFlag() pulumi.IntOutput {
	return o.ApplyT(func(v *Instance) pulumi.IntOutput { return v.RenewFlag }).(pulumi.IntOutput)
}

// Subnet.
func (o InstanceOutput) SubnetId() pulumi.StringOutput {
	return o.ApplyT(func(v *Instance) pulumi.StringOutput { return v.SubnetId }).(pulumi.StringOutput)
}

// Tag description list.
func (o InstanceOutput) Tags() pulumi.MapOutput {
	return o.ApplyT(func(v *Instance) pulumi.MapOutput { return v.Tags }).(pulumi.MapOutput)
}

// Prepaid needs to be delivered, billing time length, how many months.
func (o InstanceOutput) TimeSpan() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Instance) pulumi.IntPtrOutput { return v.TimeSpan }).(pulumi.IntPtrOutput)
}

// Private network.
func (o InstanceOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v *Instance) pulumi.StringOutput { return v.VpcId }).(pulumi.StringOutput)
}

// Availability zone.
func (o InstanceOutput) Zone() pulumi.StringOutput {
	return o.ApplyT(func(v *Instance) pulumi.StringOutput { return v.Zone }).(pulumi.StringOutput)
}

type InstanceArrayOutput struct{ *pulumi.OutputState }

func (InstanceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Instance)(nil)).Elem()
}

func (o InstanceArrayOutput) ToInstanceArrayOutput() InstanceArrayOutput {
	return o
}

func (o InstanceArrayOutput) ToInstanceArrayOutputWithContext(ctx context.Context) InstanceArrayOutput {
	return o
}

func (o InstanceArrayOutput) Index(i pulumi.IntInput) InstanceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Instance {
		return vs[0].([]*Instance)[vs[1].(int)]
	}).(InstanceOutput)
}

type InstanceMapOutput struct{ *pulumi.OutputState }

func (InstanceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Instance)(nil)).Elem()
}

func (o InstanceMapOutput) ToInstanceMapOutput() InstanceMapOutput {
	return o
}

func (o InstanceMapOutput) ToInstanceMapOutputWithContext(ctx context.Context) InstanceMapOutput {
	return o
}

func (o InstanceMapOutput) MapIndex(k pulumi.StringInput) InstanceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Instance {
		return vs[0].(map[string]*Instance)[vs[1].(string)]
	}).(InstanceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceInput)(nil)).Elem(), &Instance{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceArrayInput)(nil)).Elem(), InstanceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceMapInput)(nil)).Elem(), InstanceMap{})
	pulumi.RegisterOutputType(InstanceOutput{})
	pulumi.RegisterOutputType(InstanceArrayOutput{})
	pulumi.RegisterOutputType(InstanceMapOutput{})
}
