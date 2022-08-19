// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package instance

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type InstanceDataDisk struct {
	// Data disk ID used to initialize the data disk. When data disk type is `LOCAL_BASIC` and `LOCAL_SSD`, disk id is not supported.
	DataDiskId *string `pulumi:"dataDiskId"`
	// Size of the data disk, and unit is GB. If disk type is `CLOUD_SSD`, the size range is [100, 16000], and the others are [10-16000].
	DataDiskSize int `pulumi:"dataDiskSize"`
	// Snapshot ID of the data disk. The selected data disk snapshot size must be smaller than the data disk size.
	DataDiskSnapshotId *string `pulumi:"dataDiskSnapshotId"`
	// Data disk type. For more information about limits on different data disk types, see [Storage Overview](https://intl.cloud.tencent.com/document/product/213/4952). Valid values: `LOCAL_BASIC`: local disk, `LOCAL_SSD`: local SSD disk, `CLOUD_PREMIUM`: Premium Cloud Storage, `CLOUD_SSD`: SSD, `CLOUD_HSSD`: Enhanced SSD. NOTE: `CLOUD_BASIC`, `LOCAL_BASIC` and `LOCAL_SSD` are deprecated.
	DataDiskType string `pulumi:"dataDiskType"`
	// Decides whether the disk is deleted with instance(only applied to `CLOUD_BASIC`, `CLOUD_SSD` and `CLOUD_PREMIUM` disk with `POSTPAID_BY_HOUR` instance), default is true.
	DeleteWithInstance *bool `pulumi:"deleteWithInstance"`
	// Decides whether the disk is encrypted. Default is `false`.
	Encrypt *bool `pulumi:"encrypt"`
	// Add extra performance to the data disk. Only works when disk type is `CLOUD_TSSD` or `CLOUD_HSSD`.
	ThroughputPerformance *int `pulumi:"throughputPerformance"`
}

// InstanceDataDiskInput is an input type that accepts InstanceDataDiskArgs and InstanceDataDiskOutput values.
// You can construct a concrete instance of `InstanceDataDiskInput` via:
//
//          InstanceDataDiskArgs{...}
type InstanceDataDiskInput interface {
	pulumi.Input

	ToInstanceDataDiskOutput() InstanceDataDiskOutput
	ToInstanceDataDiskOutputWithContext(context.Context) InstanceDataDiskOutput
}

type InstanceDataDiskArgs struct {
	// Data disk ID used to initialize the data disk. When data disk type is `LOCAL_BASIC` and `LOCAL_SSD`, disk id is not supported.
	DataDiskId pulumi.StringPtrInput `pulumi:"dataDiskId"`
	// Size of the data disk, and unit is GB. If disk type is `CLOUD_SSD`, the size range is [100, 16000], and the others are [10-16000].
	DataDiskSize pulumi.IntInput `pulumi:"dataDiskSize"`
	// Snapshot ID of the data disk. The selected data disk snapshot size must be smaller than the data disk size.
	DataDiskSnapshotId pulumi.StringPtrInput `pulumi:"dataDiskSnapshotId"`
	// Data disk type. For more information about limits on different data disk types, see [Storage Overview](https://intl.cloud.tencent.com/document/product/213/4952). Valid values: `LOCAL_BASIC`: local disk, `LOCAL_SSD`: local SSD disk, `CLOUD_PREMIUM`: Premium Cloud Storage, `CLOUD_SSD`: SSD, `CLOUD_HSSD`: Enhanced SSD. NOTE: `CLOUD_BASIC`, `LOCAL_BASIC` and `LOCAL_SSD` are deprecated.
	DataDiskType pulumi.StringInput `pulumi:"dataDiskType"`
	// Decides whether the disk is deleted with instance(only applied to `CLOUD_BASIC`, `CLOUD_SSD` and `CLOUD_PREMIUM` disk with `POSTPAID_BY_HOUR` instance), default is true.
	DeleteWithInstance pulumi.BoolPtrInput `pulumi:"deleteWithInstance"`
	// Decides whether the disk is encrypted. Default is `false`.
	Encrypt pulumi.BoolPtrInput `pulumi:"encrypt"`
	// Add extra performance to the data disk. Only works when disk type is `CLOUD_TSSD` or `CLOUD_HSSD`.
	ThroughputPerformance pulumi.IntPtrInput `pulumi:"throughputPerformance"`
}

func (InstanceDataDiskArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceDataDisk)(nil)).Elem()
}

func (i InstanceDataDiskArgs) ToInstanceDataDiskOutput() InstanceDataDiskOutput {
	return i.ToInstanceDataDiskOutputWithContext(context.Background())
}

func (i InstanceDataDiskArgs) ToInstanceDataDiskOutputWithContext(ctx context.Context) InstanceDataDiskOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceDataDiskOutput)
}

// InstanceDataDiskArrayInput is an input type that accepts InstanceDataDiskArray and InstanceDataDiskArrayOutput values.
// You can construct a concrete instance of `InstanceDataDiskArrayInput` via:
//
//          InstanceDataDiskArray{ InstanceDataDiskArgs{...} }
type InstanceDataDiskArrayInput interface {
	pulumi.Input

	ToInstanceDataDiskArrayOutput() InstanceDataDiskArrayOutput
	ToInstanceDataDiskArrayOutputWithContext(context.Context) InstanceDataDiskArrayOutput
}

type InstanceDataDiskArray []InstanceDataDiskInput

func (InstanceDataDiskArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]InstanceDataDisk)(nil)).Elem()
}

func (i InstanceDataDiskArray) ToInstanceDataDiskArrayOutput() InstanceDataDiskArrayOutput {
	return i.ToInstanceDataDiskArrayOutputWithContext(context.Background())
}

func (i InstanceDataDiskArray) ToInstanceDataDiskArrayOutputWithContext(ctx context.Context) InstanceDataDiskArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceDataDiskArrayOutput)
}

type InstanceDataDiskOutput struct{ *pulumi.OutputState }

func (InstanceDataDiskOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceDataDisk)(nil)).Elem()
}

func (o InstanceDataDiskOutput) ToInstanceDataDiskOutput() InstanceDataDiskOutput {
	return o
}

func (o InstanceDataDiskOutput) ToInstanceDataDiskOutputWithContext(ctx context.Context) InstanceDataDiskOutput {
	return o
}

// Data disk ID used to initialize the data disk. When data disk type is `LOCAL_BASIC` and `LOCAL_SSD`, disk id is not supported.
func (o InstanceDataDiskOutput) DataDiskId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v InstanceDataDisk) *string { return v.DataDiskId }).(pulumi.StringPtrOutput)
}

// Size of the data disk, and unit is GB. If disk type is `CLOUD_SSD`, the size range is [100, 16000], and the others are [10-16000].
func (o InstanceDataDiskOutput) DataDiskSize() pulumi.IntOutput {
	return o.ApplyT(func(v InstanceDataDisk) int { return v.DataDiskSize }).(pulumi.IntOutput)
}

// Snapshot ID of the data disk. The selected data disk snapshot size must be smaller than the data disk size.
func (o InstanceDataDiskOutput) DataDiskSnapshotId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v InstanceDataDisk) *string { return v.DataDiskSnapshotId }).(pulumi.StringPtrOutput)
}

// Data disk type. For more information about limits on different data disk types, see [Storage Overview](https://intl.cloud.tencent.com/document/product/213/4952). Valid values: `LOCAL_BASIC`: local disk, `LOCAL_SSD`: local SSD disk, `CLOUD_PREMIUM`: Premium Cloud Storage, `CLOUD_SSD`: SSD, `CLOUD_HSSD`: Enhanced SSD. NOTE: `CLOUD_BASIC`, `LOCAL_BASIC` and `LOCAL_SSD` are deprecated.
func (o InstanceDataDiskOutput) DataDiskType() pulumi.StringOutput {
	return o.ApplyT(func(v InstanceDataDisk) string { return v.DataDiskType }).(pulumi.StringOutput)
}

// Decides whether the disk is deleted with instance(only applied to `CLOUD_BASIC`, `CLOUD_SSD` and `CLOUD_PREMIUM` disk with `POSTPAID_BY_HOUR` instance), default is true.
func (o InstanceDataDiskOutput) DeleteWithInstance() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v InstanceDataDisk) *bool { return v.DeleteWithInstance }).(pulumi.BoolPtrOutput)
}

// Decides whether the disk is encrypted. Default is `false`.
func (o InstanceDataDiskOutput) Encrypt() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v InstanceDataDisk) *bool { return v.Encrypt }).(pulumi.BoolPtrOutput)
}

// Add extra performance to the data disk. Only works when disk type is `CLOUD_TSSD` or `CLOUD_HSSD`.
func (o InstanceDataDiskOutput) ThroughputPerformance() pulumi.IntPtrOutput {
	return o.ApplyT(func(v InstanceDataDisk) *int { return v.ThroughputPerformance }).(pulumi.IntPtrOutput)
}

type InstanceDataDiskArrayOutput struct{ *pulumi.OutputState }

func (InstanceDataDiskArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]InstanceDataDisk)(nil)).Elem()
}

func (o InstanceDataDiskArrayOutput) ToInstanceDataDiskArrayOutput() InstanceDataDiskArrayOutput {
	return o
}

func (o InstanceDataDiskArrayOutput) ToInstanceDataDiskArrayOutputWithContext(ctx context.Context) InstanceDataDiskArrayOutput {
	return o
}

func (o InstanceDataDiskArrayOutput) Index(i pulumi.IntInput) InstanceDataDiskOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) InstanceDataDisk {
		return vs[0].([]InstanceDataDisk)[vs[1].(int)]
	}).(InstanceDataDiskOutput)
}

type GetTypesFilter struct {
	// The filter name. Valid values: `zone`, `instance-family` and `instance-charge-type`.
	Name string `pulumi:"name"`
	// The filter values.
	Values []string `pulumi:"values"`
}

// GetTypesFilterInput is an input type that accepts GetTypesFilterArgs and GetTypesFilterOutput values.
// You can construct a concrete instance of `GetTypesFilterInput` via:
//
//          GetTypesFilterArgs{...}
type GetTypesFilterInput interface {
	pulumi.Input

	ToGetTypesFilterOutput() GetTypesFilterOutput
	ToGetTypesFilterOutputWithContext(context.Context) GetTypesFilterOutput
}

type GetTypesFilterArgs struct {
	// The filter name. Valid values: `zone`, `instance-family` and `instance-charge-type`.
	Name pulumi.StringInput `pulumi:"name"`
	// The filter values.
	Values pulumi.StringArrayInput `pulumi:"values"`
}

func (GetTypesFilterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTypesFilter)(nil)).Elem()
}

func (i GetTypesFilterArgs) ToGetTypesFilterOutput() GetTypesFilterOutput {
	return i.ToGetTypesFilterOutputWithContext(context.Background())
}

func (i GetTypesFilterArgs) ToGetTypesFilterOutputWithContext(ctx context.Context) GetTypesFilterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetTypesFilterOutput)
}

// GetTypesFilterArrayInput is an input type that accepts GetTypesFilterArray and GetTypesFilterArrayOutput values.
// You can construct a concrete instance of `GetTypesFilterArrayInput` via:
//
//          GetTypesFilterArray{ GetTypesFilterArgs{...} }
type GetTypesFilterArrayInput interface {
	pulumi.Input

	ToGetTypesFilterArrayOutput() GetTypesFilterArrayOutput
	ToGetTypesFilterArrayOutputWithContext(context.Context) GetTypesFilterArrayOutput
}

type GetTypesFilterArray []GetTypesFilterInput

func (GetTypesFilterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetTypesFilter)(nil)).Elem()
}

func (i GetTypesFilterArray) ToGetTypesFilterArrayOutput() GetTypesFilterArrayOutput {
	return i.ToGetTypesFilterArrayOutputWithContext(context.Background())
}

func (i GetTypesFilterArray) ToGetTypesFilterArrayOutputWithContext(ctx context.Context) GetTypesFilterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetTypesFilterArrayOutput)
}

type GetTypesFilterOutput struct{ *pulumi.OutputState }

func (GetTypesFilterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTypesFilter)(nil)).Elem()
}

func (o GetTypesFilterOutput) ToGetTypesFilterOutput() GetTypesFilterOutput {
	return o
}

func (o GetTypesFilterOutput) ToGetTypesFilterOutputWithContext(ctx context.Context) GetTypesFilterOutput {
	return o
}

// The filter name. Valid values: `zone`, `instance-family` and `instance-charge-type`.
func (o GetTypesFilterOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetTypesFilter) string { return v.Name }).(pulumi.StringOutput)
}

// The filter values.
func (o GetTypesFilterOutput) Values() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetTypesFilter) []string { return v.Values }).(pulumi.StringArrayOutput)
}

type GetTypesFilterArrayOutput struct{ *pulumi.OutputState }

func (GetTypesFilterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetTypesFilter)(nil)).Elem()
}

func (o GetTypesFilterArrayOutput) ToGetTypesFilterArrayOutput() GetTypesFilterArrayOutput {
	return o
}

func (o GetTypesFilterArrayOutput) ToGetTypesFilterArrayOutputWithContext(ctx context.Context) GetTypesFilterArrayOutput {
	return o
}

func (o GetTypesFilterArrayOutput) Index(i pulumi.IntInput) GetTypesFilterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetTypesFilter {
		return vs[0].([]GetTypesFilter)[vs[1].(int)]
	}).(GetTypesFilterOutput)
}

type GetTypesInstanceType struct {
	// The available zone that the CVM instance locates at. This field is conflict with `filter`.
	AvailabilityZone string `pulumi:"availabilityZone"`
	// The number of CPU cores of the instance.
	CpuCoreCount int `pulumi:"cpuCoreCount"`
	// Type series of the instance.
	Family string `pulumi:"family"`
	// The number of GPU cores of the instance.
	GpuCoreCount int `pulumi:"gpuCoreCount"`
	// Charge type of the instance.
	InstanceChargeType string `pulumi:"instanceChargeType"`
	// Type of the instance.
	InstanceType string `pulumi:"instanceType"`
	// Instance memory capacity, unit in GB.
	MemorySize int `pulumi:"memorySize"`
	// Sell status of the instance.
	Status string `pulumi:"status"`
}

// GetTypesInstanceTypeInput is an input type that accepts GetTypesInstanceTypeArgs and GetTypesInstanceTypeOutput values.
// You can construct a concrete instance of `GetTypesInstanceTypeInput` via:
//
//          GetTypesInstanceTypeArgs{...}
type GetTypesInstanceTypeInput interface {
	pulumi.Input

	ToGetTypesInstanceTypeOutput() GetTypesInstanceTypeOutput
	ToGetTypesInstanceTypeOutputWithContext(context.Context) GetTypesInstanceTypeOutput
}

type GetTypesInstanceTypeArgs struct {
	// The available zone that the CVM instance locates at. This field is conflict with `filter`.
	AvailabilityZone pulumi.StringInput `pulumi:"availabilityZone"`
	// The number of CPU cores of the instance.
	CpuCoreCount pulumi.IntInput `pulumi:"cpuCoreCount"`
	// Type series of the instance.
	Family pulumi.StringInput `pulumi:"family"`
	// The number of GPU cores of the instance.
	GpuCoreCount pulumi.IntInput `pulumi:"gpuCoreCount"`
	// Charge type of the instance.
	InstanceChargeType pulumi.StringInput `pulumi:"instanceChargeType"`
	// Type of the instance.
	InstanceType pulumi.StringInput `pulumi:"instanceType"`
	// Instance memory capacity, unit in GB.
	MemorySize pulumi.IntInput `pulumi:"memorySize"`
	// Sell status of the instance.
	Status pulumi.StringInput `pulumi:"status"`
}

func (GetTypesInstanceTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTypesInstanceType)(nil)).Elem()
}

func (i GetTypesInstanceTypeArgs) ToGetTypesInstanceTypeOutput() GetTypesInstanceTypeOutput {
	return i.ToGetTypesInstanceTypeOutputWithContext(context.Background())
}

func (i GetTypesInstanceTypeArgs) ToGetTypesInstanceTypeOutputWithContext(ctx context.Context) GetTypesInstanceTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetTypesInstanceTypeOutput)
}

// GetTypesInstanceTypeArrayInput is an input type that accepts GetTypesInstanceTypeArray and GetTypesInstanceTypeArrayOutput values.
// You can construct a concrete instance of `GetTypesInstanceTypeArrayInput` via:
//
//          GetTypesInstanceTypeArray{ GetTypesInstanceTypeArgs{...} }
type GetTypesInstanceTypeArrayInput interface {
	pulumi.Input

	ToGetTypesInstanceTypeArrayOutput() GetTypesInstanceTypeArrayOutput
	ToGetTypesInstanceTypeArrayOutputWithContext(context.Context) GetTypesInstanceTypeArrayOutput
}

type GetTypesInstanceTypeArray []GetTypesInstanceTypeInput

func (GetTypesInstanceTypeArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetTypesInstanceType)(nil)).Elem()
}

func (i GetTypesInstanceTypeArray) ToGetTypesInstanceTypeArrayOutput() GetTypesInstanceTypeArrayOutput {
	return i.ToGetTypesInstanceTypeArrayOutputWithContext(context.Background())
}

func (i GetTypesInstanceTypeArray) ToGetTypesInstanceTypeArrayOutputWithContext(ctx context.Context) GetTypesInstanceTypeArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetTypesInstanceTypeArrayOutput)
}

type GetTypesInstanceTypeOutput struct{ *pulumi.OutputState }

func (GetTypesInstanceTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTypesInstanceType)(nil)).Elem()
}

func (o GetTypesInstanceTypeOutput) ToGetTypesInstanceTypeOutput() GetTypesInstanceTypeOutput {
	return o
}

func (o GetTypesInstanceTypeOutput) ToGetTypesInstanceTypeOutputWithContext(ctx context.Context) GetTypesInstanceTypeOutput {
	return o
}

// The available zone that the CVM instance locates at. This field is conflict with `filter`.
func (o GetTypesInstanceTypeOutput) AvailabilityZone() pulumi.StringOutput {
	return o.ApplyT(func(v GetTypesInstanceType) string { return v.AvailabilityZone }).(pulumi.StringOutput)
}

// The number of CPU cores of the instance.
func (o GetTypesInstanceTypeOutput) CpuCoreCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetTypesInstanceType) int { return v.CpuCoreCount }).(pulumi.IntOutput)
}

// Type series of the instance.
func (o GetTypesInstanceTypeOutput) Family() pulumi.StringOutput {
	return o.ApplyT(func(v GetTypesInstanceType) string { return v.Family }).(pulumi.StringOutput)
}

// The number of GPU cores of the instance.
func (o GetTypesInstanceTypeOutput) GpuCoreCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetTypesInstanceType) int { return v.GpuCoreCount }).(pulumi.IntOutput)
}

// Charge type of the instance.
func (o GetTypesInstanceTypeOutput) InstanceChargeType() pulumi.StringOutput {
	return o.ApplyT(func(v GetTypesInstanceType) string { return v.InstanceChargeType }).(pulumi.StringOutput)
}

// Type of the instance.
func (o GetTypesInstanceTypeOutput) InstanceType() pulumi.StringOutput {
	return o.ApplyT(func(v GetTypesInstanceType) string { return v.InstanceType }).(pulumi.StringOutput)
}

// Instance memory capacity, unit in GB.
func (o GetTypesInstanceTypeOutput) MemorySize() pulumi.IntOutput {
	return o.ApplyT(func(v GetTypesInstanceType) int { return v.MemorySize }).(pulumi.IntOutput)
}

// Sell status of the instance.
func (o GetTypesInstanceTypeOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v GetTypesInstanceType) string { return v.Status }).(pulumi.StringOutput)
}

type GetTypesInstanceTypeArrayOutput struct{ *pulumi.OutputState }

func (GetTypesInstanceTypeArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetTypesInstanceType)(nil)).Elem()
}

func (o GetTypesInstanceTypeArrayOutput) ToGetTypesInstanceTypeArrayOutput() GetTypesInstanceTypeArrayOutput {
	return o
}

func (o GetTypesInstanceTypeArrayOutput) ToGetTypesInstanceTypeArrayOutputWithContext(ctx context.Context) GetTypesInstanceTypeArrayOutput {
	return o
}

func (o GetTypesInstanceTypeArrayOutput) Index(i pulumi.IntInput) GetTypesInstanceTypeOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetTypesInstanceType {
		return vs[0].([]GetTypesInstanceType)[vs[1].(int)]
	}).(GetTypesInstanceTypeOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceDataDiskInput)(nil)).Elem(), InstanceDataDiskArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceDataDiskArrayInput)(nil)).Elem(), InstanceDataDiskArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetTypesFilterInput)(nil)).Elem(), GetTypesFilterArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetTypesFilterArrayInput)(nil)).Elem(), GetTypesFilterArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetTypesInstanceTypeInput)(nil)).Elem(), GetTypesInstanceTypeArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetTypesInstanceTypeArrayInput)(nil)).Elem(), GetTypesInstanceTypeArray{})
	pulumi.RegisterOutputType(InstanceDataDiskOutput{})
	pulumi.RegisterOutputType(InstanceDataDiskArrayOutput{})
	pulumi.RegisterOutputType(GetTypesFilterOutput{})
	pulumi.RegisterOutputType(GetTypesFilterArrayOutput{})
	pulumi.RegisterOutputType(GetTypesInstanceTypeOutput{})
	pulumi.RegisterOutputType(GetTypesInstanceTypeArrayOutput{})
}