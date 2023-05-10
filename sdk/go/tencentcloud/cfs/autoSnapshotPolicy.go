// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cfs

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a cfs autoSnapshotPolicy
//
// ## Example Usage
//
// use day of week
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cfs"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Cfs.NewAutoSnapshotPolicy(ctx, "autoSnapshotPolicy", &Cfs.AutoSnapshotPolicyArgs{
// 			AliveDays:  pulumi.Int(7),
// 			DayOfWeek:  pulumi.String("1,2"),
// 			Hour:       pulumi.String("2,3"),
// 			PolicyName: pulumi.String("policy_name"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// use day of month
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cfs"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Cfs.NewAutoSnapshotPolicy(ctx, "autoSnapshotPolicy", &Cfs.AutoSnapshotPolicyArgs{
// 			AliveDays:  pulumi.Int(7),
// 			DayOfMonth: pulumi.String("2,3,4"),
// 			Hour:       pulumi.String("2,3"),
// 			PolicyName: pulumi.String("policy_name"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// use interval days
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cfs"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Cfs.NewAutoSnapshotPolicy(ctx, "autoSnapshotPolicy", &Cfs.AutoSnapshotPolicyArgs{
// 			AliveDays:    pulumi.Int(7),
// 			Hour:         pulumi.String("2,3"),
// 			IntervalDays: pulumi.Int(1),
// 			PolicyName:   pulumi.String("policy_name"),
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
// cfs auto_snapshot_policy can be imported using the id, e.g.
//
// ```sh
//  $ pulumi import tencentcloud:Cfs/autoSnapshotPolicy:AutoSnapshotPolicy auto_snapshot_policy auto_snapshot_policy_id
// ```
type AutoSnapshotPolicy struct {
	pulumi.CustomResourceState

	// Snapshot retention period.
	AliveDays pulumi.IntPtrOutput `pulumi:"aliveDays"`
	// The specific day (day 1 to day 31) of the month on which to create a snapshot.
	DayOfMonth pulumi.StringPtrOutput `pulumi:"dayOfMonth"`
	// The day of the week on which to repeat the snapshot operation.
	DayOfWeek pulumi.StringPtrOutput `pulumi:"dayOfWeek"`
	// The time point when to repeat the snapshot operation.
	Hour pulumi.StringOutput `pulumi:"hour"`
	// The snapshot interval, in days.
	IntervalDays pulumi.IntPtrOutput `pulumi:"intervalDays"`
	// Policy name.
	PolicyName pulumi.StringPtrOutput `pulumi:"policyName"`
}

// NewAutoSnapshotPolicy registers a new resource with the given unique name, arguments, and options.
func NewAutoSnapshotPolicy(ctx *pulumi.Context,
	name string, args *AutoSnapshotPolicyArgs, opts ...pulumi.ResourceOption) (*AutoSnapshotPolicy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Hour == nil {
		return nil, errors.New("invalid value for required argument 'Hour'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource AutoSnapshotPolicy
	err := ctx.RegisterResource("tencentcloud:Cfs/autoSnapshotPolicy:AutoSnapshotPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAutoSnapshotPolicy gets an existing AutoSnapshotPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAutoSnapshotPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AutoSnapshotPolicyState, opts ...pulumi.ResourceOption) (*AutoSnapshotPolicy, error) {
	var resource AutoSnapshotPolicy
	err := ctx.ReadResource("tencentcloud:Cfs/autoSnapshotPolicy:AutoSnapshotPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AutoSnapshotPolicy resources.
type autoSnapshotPolicyState struct {
	// Snapshot retention period.
	AliveDays *int `pulumi:"aliveDays"`
	// The specific day (day 1 to day 31) of the month on which to create a snapshot.
	DayOfMonth *string `pulumi:"dayOfMonth"`
	// The day of the week on which to repeat the snapshot operation.
	DayOfWeek *string `pulumi:"dayOfWeek"`
	// The time point when to repeat the snapshot operation.
	Hour *string `pulumi:"hour"`
	// The snapshot interval, in days.
	IntervalDays *int `pulumi:"intervalDays"`
	// Policy name.
	PolicyName *string `pulumi:"policyName"`
}

type AutoSnapshotPolicyState struct {
	// Snapshot retention period.
	AliveDays pulumi.IntPtrInput
	// The specific day (day 1 to day 31) of the month on which to create a snapshot.
	DayOfMonth pulumi.StringPtrInput
	// The day of the week on which to repeat the snapshot operation.
	DayOfWeek pulumi.StringPtrInput
	// The time point when to repeat the snapshot operation.
	Hour pulumi.StringPtrInput
	// The snapshot interval, in days.
	IntervalDays pulumi.IntPtrInput
	// Policy name.
	PolicyName pulumi.StringPtrInput
}

func (AutoSnapshotPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*autoSnapshotPolicyState)(nil)).Elem()
}

type autoSnapshotPolicyArgs struct {
	// Snapshot retention period.
	AliveDays *int `pulumi:"aliveDays"`
	// The specific day (day 1 to day 31) of the month on which to create a snapshot.
	DayOfMonth *string `pulumi:"dayOfMonth"`
	// The day of the week on which to repeat the snapshot operation.
	DayOfWeek *string `pulumi:"dayOfWeek"`
	// The time point when to repeat the snapshot operation.
	Hour string `pulumi:"hour"`
	// The snapshot interval, in days.
	IntervalDays *int `pulumi:"intervalDays"`
	// Policy name.
	PolicyName *string `pulumi:"policyName"`
}

// The set of arguments for constructing a AutoSnapshotPolicy resource.
type AutoSnapshotPolicyArgs struct {
	// Snapshot retention period.
	AliveDays pulumi.IntPtrInput
	// The specific day (day 1 to day 31) of the month on which to create a snapshot.
	DayOfMonth pulumi.StringPtrInput
	// The day of the week on which to repeat the snapshot operation.
	DayOfWeek pulumi.StringPtrInput
	// The time point when to repeat the snapshot operation.
	Hour pulumi.StringInput
	// The snapshot interval, in days.
	IntervalDays pulumi.IntPtrInput
	// Policy name.
	PolicyName pulumi.StringPtrInput
}

func (AutoSnapshotPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*autoSnapshotPolicyArgs)(nil)).Elem()
}

type AutoSnapshotPolicyInput interface {
	pulumi.Input

	ToAutoSnapshotPolicyOutput() AutoSnapshotPolicyOutput
	ToAutoSnapshotPolicyOutputWithContext(ctx context.Context) AutoSnapshotPolicyOutput
}

func (*AutoSnapshotPolicy) ElementType() reflect.Type {
	return reflect.TypeOf((**AutoSnapshotPolicy)(nil)).Elem()
}

func (i *AutoSnapshotPolicy) ToAutoSnapshotPolicyOutput() AutoSnapshotPolicyOutput {
	return i.ToAutoSnapshotPolicyOutputWithContext(context.Background())
}

func (i *AutoSnapshotPolicy) ToAutoSnapshotPolicyOutputWithContext(ctx context.Context) AutoSnapshotPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutoSnapshotPolicyOutput)
}

// AutoSnapshotPolicyArrayInput is an input type that accepts AutoSnapshotPolicyArray and AutoSnapshotPolicyArrayOutput values.
// You can construct a concrete instance of `AutoSnapshotPolicyArrayInput` via:
//
//          AutoSnapshotPolicyArray{ AutoSnapshotPolicyArgs{...} }
type AutoSnapshotPolicyArrayInput interface {
	pulumi.Input

	ToAutoSnapshotPolicyArrayOutput() AutoSnapshotPolicyArrayOutput
	ToAutoSnapshotPolicyArrayOutputWithContext(context.Context) AutoSnapshotPolicyArrayOutput
}

type AutoSnapshotPolicyArray []AutoSnapshotPolicyInput

func (AutoSnapshotPolicyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AutoSnapshotPolicy)(nil)).Elem()
}

func (i AutoSnapshotPolicyArray) ToAutoSnapshotPolicyArrayOutput() AutoSnapshotPolicyArrayOutput {
	return i.ToAutoSnapshotPolicyArrayOutputWithContext(context.Background())
}

func (i AutoSnapshotPolicyArray) ToAutoSnapshotPolicyArrayOutputWithContext(ctx context.Context) AutoSnapshotPolicyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutoSnapshotPolicyArrayOutput)
}

// AutoSnapshotPolicyMapInput is an input type that accepts AutoSnapshotPolicyMap and AutoSnapshotPolicyMapOutput values.
// You can construct a concrete instance of `AutoSnapshotPolicyMapInput` via:
//
//          AutoSnapshotPolicyMap{ "key": AutoSnapshotPolicyArgs{...} }
type AutoSnapshotPolicyMapInput interface {
	pulumi.Input

	ToAutoSnapshotPolicyMapOutput() AutoSnapshotPolicyMapOutput
	ToAutoSnapshotPolicyMapOutputWithContext(context.Context) AutoSnapshotPolicyMapOutput
}

type AutoSnapshotPolicyMap map[string]AutoSnapshotPolicyInput

func (AutoSnapshotPolicyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AutoSnapshotPolicy)(nil)).Elem()
}

func (i AutoSnapshotPolicyMap) ToAutoSnapshotPolicyMapOutput() AutoSnapshotPolicyMapOutput {
	return i.ToAutoSnapshotPolicyMapOutputWithContext(context.Background())
}

func (i AutoSnapshotPolicyMap) ToAutoSnapshotPolicyMapOutputWithContext(ctx context.Context) AutoSnapshotPolicyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutoSnapshotPolicyMapOutput)
}

type AutoSnapshotPolicyOutput struct{ *pulumi.OutputState }

func (AutoSnapshotPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AutoSnapshotPolicy)(nil)).Elem()
}

func (o AutoSnapshotPolicyOutput) ToAutoSnapshotPolicyOutput() AutoSnapshotPolicyOutput {
	return o
}

func (o AutoSnapshotPolicyOutput) ToAutoSnapshotPolicyOutputWithContext(ctx context.Context) AutoSnapshotPolicyOutput {
	return o
}

// Snapshot retention period.
func (o AutoSnapshotPolicyOutput) AliveDays() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *AutoSnapshotPolicy) pulumi.IntPtrOutput { return v.AliveDays }).(pulumi.IntPtrOutput)
}

// The specific day (day 1 to day 31) of the month on which to create a snapshot.
func (o AutoSnapshotPolicyOutput) DayOfMonth() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AutoSnapshotPolicy) pulumi.StringPtrOutput { return v.DayOfMonth }).(pulumi.StringPtrOutput)
}

// The day of the week on which to repeat the snapshot operation.
func (o AutoSnapshotPolicyOutput) DayOfWeek() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AutoSnapshotPolicy) pulumi.StringPtrOutput { return v.DayOfWeek }).(pulumi.StringPtrOutput)
}

// The time point when to repeat the snapshot operation.
func (o AutoSnapshotPolicyOutput) Hour() pulumi.StringOutput {
	return o.ApplyT(func(v *AutoSnapshotPolicy) pulumi.StringOutput { return v.Hour }).(pulumi.StringOutput)
}

// The snapshot interval, in days.
func (o AutoSnapshotPolicyOutput) IntervalDays() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *AutoSnapshotPolicy) pulumi.IntPtrOutput { return v.IntervalDays }).(pulumi.IntPtrOutput)
}

// Policy name.
func (o AutoSnapshotPolicyOutput) PolicyName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AutoSnapshotPolicy) pulumi.StringPtrOutput { return v.PolicyName }).(pulumi.StringPtrOutput)
}

type AutoSnapshotPolicyArrayOutput struct{ *pulumi.OutputState }

func (AutoSnapshotPolicyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AutoSnapshotPolicy)(nil)).Elem()
}

func (o AutoSnapshotPolicyArrayOutput) ToAutoSnapshotPolicyArrayOutput() AutoSnapshotPolicyArrayOutput {
	return o
}

func (o AutoSnapshotPolicyArrayOutput) ToAutoSnapshotPolicyArrayOutputWithContext(ctx context.Context) AutoSnapshotPolicyArrayOutput {
	return o
}

func (o AutoSnapshotPolicyArrayOutput) Index(i pulumi.IntInput) AutoSnapshotPolicyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AutoSnapshotPolicy {
		return vs[0].([]*AutoSnapshotPolicy)[vs[1].(int)]
	}).(AutoSnapshotPolicyOutput)
}

type AutoSnapshotPolicyMapOutput struct{ *pulumi.OutputState }

func (AutoSnapshotPolicyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AutoSnapshotPolicy)(nil)).Elem()
}

func (o AutoSnapshotPolicyMapOutput) ToAutoSnapshotPolicyMapOutput() AutoSnapshotPolicyMapOutput {
	return o
}

func (o AutoSnapshotPolicyMapOutput) ToAutoSnapshotPolicyMapOutputWithContext(ctx context.Context) AutoSnapshotPolicyMapOutput {
	return o
}

func (o AutoSnapshotPolicyMapOutput) MapIndex(k pulumi.StringInput) AutoSnapshotPolicyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AutoSnapshotPolicy {
		return vs[0].(map[string]*AutoSnapshotPolicy)[vs[1].(string)]
	}).(AutoSnapshotPolicyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AutoSnapshotPolicyInput)(nil)).Elem(), &AutoSnapshotPolicy{})
	pulumi.RegisterInputType(reflect.TypeOf((*AutoSnapshotPolicyArrayInput)(nil)).Elem(), AutoSnapshotPolicyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AutoSnapshotPolicyMapInput)(nil)).Elem(), AutoSnapshotPolicyMap{})
	pulumi.RegisterOutputType(AutoSnapshotPolicyOutput{})
	pulumi.RegisterOutputType(AutoSnapshotPolicyArrayOutput{})
	pulumi.RegisterOutputType(AutoSnapshotPolicyMapOutput{})
}