// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cdwpg

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

var _ = internal.GetEnvOrDefault

type InstanceChargeProperties struct {
	// Charge type, vaild values: PREPAID, POSTPAID_BY_HOUR.
	ChargeType *string `pulumi:"chargeType"`
	// 0-no automatic renewal,1-automatic renewalNote: This field may return null, indicating that a valid value cannot be obtained.
	RenewFlag int `pulumi:"renewFlag"`
	// Time RangeNote: This field may return null, indicating that a valid value cannot be obtained.
	TimeSpan int `pulumi:"timeSpan"`
	// Time Unit,Generally h and mNote: This field may return null, indicating that a valid value cannot be obtained.
	TimeUnit string `pulumi:"timeUnit"`
}

// InstanceChargePropertiesInput is an input type that accepts InstanceChargePropertiesArgs and InstanceChargePropertiesOutput values.
// You can construct a concrete instance of `InstanceChargePropertiesInput` via:
//
//	InstanceChargePropertiesArgs{...}
type InstanceChargePropertiesInput interface {
	pulumi.Input

	ToInstanceChargePropertiesOutput() InstanceChargePropertiesOutput
	ToInstanceChargePropertiesOutputWithContext(context.Context) InstanceChargePropertiesOutput
}

type InstanceChargePropertiesArgs struct {
	// Charge type, vaild values: PREPAID, POSTPAID_BY_HOUR.
	ChargeType pulumi.StringPtrInput `pulumi:"chargeType"`
	// 0-no automatic renewal,1-automatic renewalNote: This field may return null, indicating that a valid value cannot be obtained.
	RenewFlag pulumi.IntInput `pulumi:"renewFlag"`
	// Time RangeNote: This field may return null, indicating that a valid value cannot be obtained.
	TimeSpan pulumi.IntInput `pulumi:"timeSpan"`
	// Time Unit,Generally h and mNote: This field may return null, indicating that a valid value cannot be obtained.
	TimeUnit pulumi.StringInput `pulumi:"timeUnit"`
}

func (InstanceChargePropertiesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceChargeProperties)(nil)).Elem()
}

func (i InstanceChargePropertiesArgs) ToInstanceChargePropertiesOutput() InstanceChargePropertiesOutput {
	return i.ToInstanceChargePropertiesOutputWithContext(context.Background())
}

func (i InstanceChargePropertiesArgs) ToInstanceChargePropertiesOutputWithContext(ctx context.Context) InstanceChargePropertiesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceChargePropertiesOutput)
}

func (i InstanceChargePropertiesArgs) ToInstanceChargePropertiesPtrOutput() InstanceChargePropertiesPtrOutput {
	return i.ToInstanceChargePropertiesPtrOutputWithContext(context.Background())
}

func (i InstanceChargePropertiesArgs) ToInstanceChargePropertiesPtrOutputWithContext(ctx context.Context) InstanceChargePropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceChargePropertiesOutput).ToInstanceChargePropertiesPtrOutputWithContext(ctx)
}

// InstanceChargePropertiesPtrInput is an input type that accepts InstanceChargePropertiesArgs, InstanceChargePropertiesPtr and InstanceChargePropertiesPtrOutput values.
// You can construct a concrete instance of `InstanceChargePropertiesPtrInput` via:
//
//	        InstanceChargePropertiesArgs{...}
//
//	or:
//
//	        nil
type InstanceChargePropertiesPtrInput interface {
	pulumi.Input

	ToInstanceChargePropertiesPtrOutput() InstanceChargePropertiesPtrOutput
	ToInstanceChargePropertiesPtrOutputWithContext(context.Context) InstanceChargePropertiesPtrOutput
}

type instanceChargePropertiesPtrType InstanceChargePropertiesArgs

func InstanceChargePropertiesPtr(v *InstanceChargePropertiesArgs) InstanceChargePropertiesPtrInput {
	return (*instanceChargePropertiesPtrType)(v)
}

func (*instanceChargePropertiesPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**InstanceChargeProperties)(nil)).Elem()
}

func (i *instanceChargePropertiesPtrType) ToInstanceChargePropertiesPtrOutput() InstanceChargePropertiesPtrOutput {
	return i.ToInstanceChargePropertiesPtrOutputWithContext(context.Background())
}

func (i *instanceChargePropertiesPtrType) ToInstanceChargePropertiesPtrOutputWithContext(ctx context.Context) InstanceChargePropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceChargePropertiesPtrOutput)
}

type InstanceChargePropertiesOutput struct{ *pulumi.OutputState }

func (InstanceChargePropertiesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceChargeProperties)(nil)).Elem()
}

func (o InstanceChargePropertiesOutput) ToInstanceChargePropertiesOutput() InstanceChargePropertiesOutput {
	return o
}

func (o InstanceChargePropertiesOutput) ToInstanceChargePropertiesOutputWithContext(ctx context.Context) InstanceChargePropertiesOutput {
	return o
}

func (o InstanceChargePropertiesOutput) ToInstanceChargePropertiesPtrOutput() InstanceChargePropertiesPtrOutput {
	return o.ToInstanceChargePropertiesPtrOutputWithContext(context.Background())
}

func (o InstanceChargePropertiesOutput) ToInstanceChargePropertiesPtrOutputWithContext(ctx context.Context) InstanceChargePropertiesPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v InstanceChargeProperties) *InstanceChargeProperties {
		return &v
	}).(InstanceChargePropertiesPtrOutput)
}

// Charge type, vaild values: PREPAID, POSTPAID_BY_HOUR.
func (o InstanceChargePropertiesOutput) ChargeType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v InstanceChargeProperties) *string { return v.ChargeType }).(pulumi.StringPtrOutput)
}

// 0-no automatic renewal,1-automatic renewalNote: This field may return null, indicating that a valid value cannot be obtained.
func (o InstanceChargePropertiesOutput) RenewFlag() pulumi.IntOutput {
	return o.ApplyT(func(v InstanceChargeProperties) int { return v.RenewFlag }).(pulumi.IntOutput)
}

// Time RangeNote: This field may return null, indicating that a valid value cannot be obtained.
func (o InstanceChargePropertiesOutput) TimeSpan() pulumi.IntOutput {
	return o.ApplyT(func(v InstanceChargeProperties) int { return v.TimeSpan }).(pulumi.IntOutput)
}

// Time Unit,Generally h and mNote: This field may return null, indicating that a valid value cannot be obtained.
func (o InstanceChargePropertiesOutput) TimeUnit() pulumi.StringOutput {
	return o.ApplyT(func(v InstanceChargeProperties) string { return v.TimeUnit }).(pulumi.StringOutput)
}

type InstanceChargePropertiesPtrOutput struct{ *pulumi.OutputState }

func (InstanceChargePropertiesPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**InstanceChargeProperties)(nil)).Elem()
}

func (o InstanceChargePropertiesPtrOutput) ToInstanceChargePropertiesPtrOutput() InstanceChargePropertiesPtrOutput {
	return o
}

func (o InstanceChargePropertiesPtrOutput) ToInstanceChargePropertiesPtrOutputWithContext(ctx context.Context) InstanceChargePropertiesPtrOutput {
	return o
}

func (o InstanceChargePropertiesPtrOutput) Elem() InstanceChargePropertiesOutput {
	return o.ApplyT(func(v *InstanceChargeProperties) InstanceChargeProperties {
		if v != nil {
			return *v
		}
		var ret InstanceChargeProperties
		return ret
	}).(InstanceChargePropertiesOutput)
}

// Charge type, vaild values: PREPAID, POSTPAID_BY_HOUR.
func (o InstanceChargePropertiesPtrOutput) ChargeType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *InstanceChargeProperties) *string {
		if v == nil {
			return nil
		}
		return v.ChargeType
	}).(pulumi.StringPtrOutput)
}

// 0-no automatic renewal,1-automatic renewalNote: This field may return null, indicating that a valid value cannot be obtained.
func (o InstanceChargePropertiesPtrOutput) RenewFlag() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *InstanceChargeProperties) *int {
		if v == nil {
			return nil
		}
		return &v.RenewFlag
	}).(pulumi.IntPtrOutput)
}

// Time RangeNote: This field may return null, indicating that a valid value cannot be obtained.
func (o InstanceChargePropertiesPtrOutput) TimeSpan() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *InstanceChargeProperties) *int {
		if v == nil {
			return nil
		}
		return &v.TimeSpan
	}).(pulumi.IntPtrOutput)
}

// Time Unit,Generally h and mNote: This field may return null, indicating that a valid value cannot be obtained.
func (o InstanceChargePropertiesPtrOutput) TimeUnit() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *InstanceChargeProperties) *string {
		if v == nil {
			return nil
		}
		return &v.TimeUnit
	}).(pulumi.StringPtrOutput)
}

type InstanceResource struct {
	// resource count.
	Count int `pulumi:"count"`
	// disk Information.
	DiskSpec InstanceResourceDiskSpec `pulumi:"diskSpec"`
	// resource name.
	SpecName string `pulumi:"specName"`
	// resource type.
	Type string `pulumi:"type"`
}

// InstanceResourceInput is an input type that accepts InstanceResourceArgs and InstanceResourceOutput values.
// You can construct a concrete instance of `InstanceResourceInput` via:
//
//	InstanceResourceArgs{...}
type InstanceResourceInput interface {
	pulumi.Input

	ToInstanceResourceOutput() InstanceResourceOutput
	ToInstanceResourceOutputWithContext(context.Context) InstanceResourceOutput
}

type InstanceResourceArgs struct {
	// resource count.
	Count pulumi.IntInput `pulumi:"count"`
	// disk Information.
	DiskSpec InstanceResourceDiskSpecInput `pulumi:"diskSpec"`
	// resource name.
	SpecName pulumi.StringInput `pulumi:"specName"`
	// resource type.
	Type pulumi.StringInput `pulumi:"type"`
}

func (InstanceResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceResource)(nil)).Elem()
}

func (i InstanceResourceArgs) ToInstanceResourceOutput() InstanceResourceOutput {
	return i.ToInstanceResourceOutputWithContext(context.Background())
}

func (i InstanceResourceArgs) ToInstanceResourceOutputWithContext(ctx context.Context) InstanceResourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceResourceOutput)
}

// InstanceResourceArrayInput is an input type that accepts InstanceResourceArray and InstanceResourceArrayOutput values.
// You can construct a concrete instance of `InstanceResourceArrayInput` via:
//
//	InstanceResourceArray{ InstanceResourceArgs{...} }
type InstanceResourceArrayInput interface {
	pulumi.Input

	ToInstanceResourceArrayOutput() InstanceResourceArrayOutput
	ToInstanceResourceArrayOutputWithContext(context.Context) InstanceResourceArrayOutput
}

type InstanceResourceArray []InstanceResourceInput

func (InstanceResourceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]InstanceResource)(nil)).Elem()
}

func (i InstanceResourceArray) ToInstanceResourceArrayOutput() InstanceResourceArrayOutput {
	return i.ToInstanceResourceArrayOutputWithContext(context.Background())
}

func (i InstanceResourceArray) ToInstanceResourceArrayOutputWithContext(ctx context.Context) InstanceResourceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceResourceArrayOutput)
}

type InstanceResourceOutput struct{ *pulumi.OutputState }

func (InstanceResourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceResource)(nil)).Elem()
}

func (o InstanceResourceOutput) ToInstanceResourceOutput() InstanceResourceOutput {
	return o
}

func (o InstanceResourceOutput) ToInstanceResourceOutputWithContext(ctx context.Context) InstanceResourceOutput {
	return o
}

// resource count.
func (o InstanceResourceOutput) Count() pulumi.IntOutput {
	return o.ApplyT(func(v InstanceResource) int { return v.Count }).(pulumi.IntOutput)
}

// disk Information.
func (o InstanceResourceOutput) DiskSpec() InstanceResourceDiskSpecOutput {
	return o.ApplyT(func(v InstanceResource) InstanceResourceDiskSpec { return v.DiskSpec }).(InstanceResourceDiskSpecOutput)
}

// resource name.
func (o InstanceResourceOutput) SpecName() pulumi.StringOutput {
	return o.ApplyT(func(v InstanceResource) string { return v.SpecName }).(pulumi.StringOutput)
}

// resource type.
func (o InstanceResourceOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v InstanceResource) string { return v.Type }).(pulumi.StringOutput)
}

type InstanceResourceArrayOutput struct{ *pulumi.OutputState }

func (InstanceResourceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]InstanceResource)(nil)).Elem()
}

func (o InstanceResourceArrayOutput) ToInstanceResourceArrayOutput() InstanceResourceArrayOutput {
	return o
}

func (o InstanceResourceArrayOutput) ToInstanceResourceArrayOutputWithContext(ctx context.Context) InstanceResourceArrayOutput {
	return o
}

func (o InstanceResourceArrayOutput) Index(i pulumi.IntInput) InstanceResourceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) InstanceResource {
		return vs[0].([]InstanceResource)[vs[1].(int)]
	}).(InstanceResourceOutput)
}

type InstanceResourceDiskSpec struct {
	// disk count.
	DiskCount int `pulumi:"diskCount"`
	// disk size.
	DiskSize int `pulumi:"diskSize"`
	// disk type.
	DiskType string `pulumi:"diskType"`
}

// InstanceResourceDiskSpecInput is an input type that accepts InstanceResourceDiskSpecArgs and InstanceResourceDiskSpecOutput values.
// You can construct a concrete instance of `InstanceResourceDiskSpecInput` via:
//
//	InstanceResourceDiskSpecArgs{...}
type InstanceResourceDiskSpecInput interface {
	pulumi.Input

	ToInstanceResourceDiskSpecOutput() InstanceResourceDiskSpecOutput
	ToInstanceResourceDiskSpecOutputWithContext(context.Context) InstanceResourceDiskSpecOutput
}

type InstanceResourceDiskSpecArgs struct {
	// disk count.
	DiskCount pulumi.IntInput `pulumi:"diskCount"`
	// disk size.
	DiskSize pulumi.IntInput `pulumi:"diskSize"`
	// disk type.
	DiskType pulumi.StringInput `pulumi:"diskType"`
}

func (InstanceResourceDiskSpecArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceResourceDiskSpec)(nil)).Elem()
}

func (i InstanceResourceDiskSpecArgs) ToInstanceResourceDiskSpecOutput() InstanceResourceDiskSpecOutput {
	return i.ToInstanceResourceDiskSpecOutputWithContext(context.Background())
}

func (i InstanceResourceDiskSpecArgs) ToInstanceResourceDiskSpecOutputWithContext(ctx context.Context) InstanceResourceDiskSpecOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceResourceDiskSpecOutput)
}

type InstanceResourceDiskSpecOutput struct{ *pulumi.OutputState }

func (InstanceResourceDiskSpecOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceResourceDiskSpec)(nil)).Elem()
}

func (o InstanceResourceDiskSpecOutput) ToInstanceResourceDiskSpecOutput() InstanceResourceDiskSpecOutput {
	return o
}

func (o InstanceResourceDiskSpecOutput) ToInstanceResourceDiskSpecOutputWithContext(ctx context.Context) InstanceResourceDiskSpecOutput {
	return o
}

// disk count.
func (o InstanceResourceDiskSpecOutput) DiskCount() pulumi.IntOutput {
	return o.ApplyT(func(v InstanceResourceDiskSpec) int { return v.DiskCount }).(pulumi.IntOutput)
}

// disk size.
func (o InstanceResourceDiskSpecOutput) DiskSize() pulumi.IntOutput {
	return o.ApplyT(func(v InstanceResourceDiskSpec) int { return v.DiskSize }).(pulumi.IntOutput)
}

// disk type.
func (o InstanceResourceDiskSpecOutput) DiskType() pulumi.StringOutput {
	return o.ApplyT(func(v InstanceResourceDiskSpec) string { return v.DiskType }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceChargePropertiesInput)(nil)).Elem(), InstanceChargePropertiesArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceChargePropertiesPtrInput)(nil)).Elem(), InstanceChargePropertiesArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceResourceInput)(nil)).Elem(), InstanceResourceArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceResourceArrayInput)(nil)).Elem(), InstanceResourceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceResourceDiskSpecInput)(nil)).Elem(), InstanceResourceDiskSpecArgs{})
	pulumi.RegisterOutputType(InstanceChargePropertiesOutput{})
	pulumi.RegisterOutputType(InstanceChargePropertiesPtrOutput{})
	pulumi.RegisterOutputType(InstanceResourceOutput{})
	pulumi.RegisterOutputType(InstanceResourceArrayOutput{})
	pulumi.RegisterOutputType(InstanceResourceDiskSpecOutput{})
}
