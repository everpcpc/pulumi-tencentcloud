// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ccn

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to limit CCN bandwidth.
//
// ## Example Usage
//
// Set the upper limit of regional outbound bandwidth
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi/config"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Ccn"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		cfg := config.New(ctx, "")
// 		otherRegion1 := "ap-shanghai"
// 		if param := cfg.Get("otherRegion1"); param != "" {
// 			otherRegion1 = param
// 		}
// 		main, err := Ccn.NewInstance(ctx, "main", &Ccn.InstanceArgs{
// 			Description: pulumi.String("ci-temp-test-ccn-des"),
// 			Qos:         pulumi.String("AG"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = Ccn.NewBandwidthLimit(ctx, "limit1", &Ccn.BandwidthLimitArgs{
// 			CcnId:          main.ID(),
// 			Region:         pulumi.String(otherRegion1),
// 			BandwidthLimit: pulumi.Int(500),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// Set the upper limit between regions
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi/config"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Ccn"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		cfg := config.New(ctx, "")
// 		otherRegion1 := "ap-shanghai"
// 		if param := cfg.Get("otherRegion1"); param != "" {
// 			otherRegion1 = param
// 		}
// 		otherRegion2 := "ap-nanjing"
// 		if param := cfg.Get("otherRegion2"); param != "" {
// 			otherRegion2 = param
// 		}
// 		main, err := Ccn.NewInstance(ctx, "main", &Ccn.InstanceArgs{
// 			Description:        pulumi.String("ci-temp-test-ccn-des"),
// 			Qos:                pulumi.String("AG"),
// 			BandwidthLimitType: pulumi.String("INTER_REGION_LIMIT"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = Ccn.NewBandwidthLimit(ctx, "limit1", &Ccn.BandwidthLimitArgs{
// 			CcnId:          main.ID(),
// 			Region:         pulumi.String(otherRegion1),
// 			DstRegion:      pulumi.String(otherRegion2),
// 			BandwidthLimit: pulumi.Int(100),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type BandwidthLimit struct {
	pulumi.CustomResourceState

	// Limitation of bandwidth.
	BandwidthLimit pulumi.IntOutput `pulumi:"bandwidthLimit"`
	// ID of the CCN.
	CcnId pulumi.StringOutput `pulumi:"ccnId"`
	// Destination area restriction. If the `CCN` rate limit type is `OUTER_REGION_LIMIT`, this value does not need to be set.
	DstRegion pulumi.StringPtrOutput `pulumi:"dstRegion"`
	// Limitation of region.
	Region pulumi.StringOutput `pulumi:"region"`
}

// NewBandwidthLimit registers a new resource with the given unique name, arguments, and options.
func NewBandwidthLimit(ctx *pulumi.Context,
	name string, args *BandwidthLimitArgs, opts ...pulumi.ResourceOption) (*BandwidthLimit, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CcnId == nil {
		return nil, errors.New("invalid value for required argument 'CcnId'")
	}
	if args.Region == nil {
		return nil, errors.New("invalid value for required argument 'Region'")
	}
	var resource BandwidthLimit
	err := ctx.RegisterResource("tencentcloud:Ccn/bandwidthLimit:BandwidthLimit", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBandwidthLimit gets an existing BandwidthLimit resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBandwidthLimit(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BandwidthLimitState, opts ...pulumi.ResourceOption) (*BandwidthLimit, error) {
	var resource BandwidthLimit
	err := ctx.ReadResource("tencentcloud:Ccn/bandwidthLimit:BandwidthLimit", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BandwidthLimit resources.
type bandwidthLimitState struct {
	// Limitation of bandwidth.
	BandwidthLimit *int `pulumi:"bandwidthLimit"`
	// ID of the CCN.
	CcnId *string `pulumi:"ccnId"`
	// Destination area restriction. If the `CCN` rate limit type is `OUTER_REGION_LIMIT`, this value does not need to be set.
	DstRegion *string `pulumi:"dstRegion"`
	// Limitation of region.
	Region *string `pulumi:"region"`
}

type BandwidthLimitState struct {
	// Limitation of bandwidth.
	BandwidthLimit pulumi.IntPtrInput
	// ID of the CCN.
	CcnId pulumi.StringPtrInput
	// Destination area restriction. If the `CCN` rate limit type is `OUTER_REGION_LIMIT`, this value does not need to be set.
	DstRegion pulumi.StringPtrInput
	// Limitation of region.
	Region pulumi.StringPtrInput
}

func (BandwidthLimitState) ElementType() reflect.Type {
	return reflect.TypeOf((*bandwidthLimitState)(nil)).Elem()
}

type bandwidthLimitArgs struct {
	// Limitation of bandwidth.
	BandwidthLimit *int `pulumi:"bandwidthLimit"`
	// ID of the CCN.
	CcnId string `pulumi:"ccnId"`
	// Destination area restriction. If the `CCN` rate limit type is `OUTER_REGION_LIMIT`, this value does not need to be set.
	DstRegion *string `pulumi:"dstRegion"`
	// Limitation of region.
	Region string `pulumi:"region"`
}

// The set of arguments for constructing a BandwidthLimit resource.
type BandwidthLimitArgs struct {
	// Limitation of bandwidth.
	BandwidthLimit pulumi.IntPtrInput
	// ID of the CCN.
	CcnId pulumi.StringInput
	// Destination area restriction. If the `CCN` rate limit type is `OUTER_REGION_LIMIT`, this value does not need to be set.
	DstRegion pulumi.StringPtrInput
	// Limitation of region.
	Region pulumi.StringInput
}

func (BandwidthLimitArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bandwidthLimitArgs)(nil)).Elem()
}

type BandwidthLimitInput interface {
	pulumi.Input

	ToBandwidthLimitOutput() BandwidthLimitOutput
	ToBandwidthLimitOutputWithContext(ctx context.Context) BandwidthLimitOutput
}

func (*BandwidthLimit) ElementType() reflect.Type {
	return reflect.TypeOf((**BandwidthLimit)(nil)).Elem()
}

func (i *BandwidthLimit) ToBandwidthLimitOutput() BandwidthLimitOutput {
	return i.ToBandwidthLimitOutputWithContext(context.Background())
}

func (i *BandwidthLimit) ToBandwidthLimitOutputWithContext(ctx context.Context) BandwidthLimitOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BandwidthLimitOutput)
}

// BandwidthLimitArrayInput is an input type that accepts BandwidthLimitArray and BandwidthLimitArrayOutput values.
// You can construct a concrete instance of `BandwidthLimitArrayInput` via:
//
//          BandwidthLimitArray{ BandwidthLimitArgs{...} }
type BandwidthLimitArrayInput interface {
	pulumi.Input

	ToBandwidthLimitArrayOutput() BandwidthLimitArrayOutput
	ToBandwidthLimitArrayOutputWithContext(context.Context) BandwidthLimitArrayOutput
}

type BandwidthLimitArray []BandwidthLimitInput

func (BandwidthLimitArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BandwidthLimit)(nil)).Elem()
}

func (i BandwidthLimitArray) ToBandwidthLimitArrayOutput() BandwidthLimitArrayOutput {
	return i.ToBandwidthLimitArrayOutputWithContext(context.Background())
}

func (i BandwidthLimitArray) ToBandwidthLimitArrayOutputWithContext(ctx context.Context) BandwidthLimitArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BandwidthLimitArrayOutput)
}

// BandwidthLimitMapInput is an input type that accepts BandwidthLimitMap and BandwidthLimitMapOutput values.
// You can construct a concrete instance of `BandwidthLimitMapInput` via:
//
//          BandwidthLimitMap{ "key": BandwidthLimitArgs{...} }
type BandwidthLimitMapInput interface {
	pulumi.Input

	ToBandwidthLimitMapOutput() BandwidthLimitMapOutput
	ToBandwidthLimitMapOutputWithContext(context.Context) BandwidthLimitMapOutput
}

type BandwidthLimitMap map[string]BandwidthLimitInput

func (BandwidthLimitMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BandwidthLimit)(nil)).Elem()
}

func (i BandwidthLimitMap) ToBandwidthLimitMapOutput() BandwidthLimitMapOutput {
	return i.ToBandwidthLimitMapOutputWithContext(context.Background())
}

func (i BandwidthLimitMap) ToBandwidthLimitMapOutputWithContext(ctx context.Context) BandwidthLimitMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BandwidthLimitMapOutput)
}

type BandwidthLimitOutput struct{ *pulumi.OutputState }

func (BandwidthLimitOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BandwidthLimit)(nil)).Elem()
}

func (o BandwidthLimitOutput) ToBandwidthLimitOutput() BandwidthLimitOutput {
	return o
}

func (o BandwidthLimitOutput) ToBandwidthLimitOutputWithContext(ctx context.Context) BandwidthLimitOutput {
	return o
}

// Limitation of bandwidth.
func (o BandwidthLimitOutput) BandwidthLimit() pulumi.IntOutput {
	return o.ApplyT(func(v *BandwidthLimit) pulumi.IntOutput { return v.BandwidthLimit }).(pulumi.IntOutput)
}

// ID of the CCN.
func (o BandwidthLimitOutput) CcnId() pulumi.StringOutput {
	return o.ApplyT(func(v *BandwidthLimit) pulumi.StringOutput { return v.CcnId }).(pulumi.StringOutput)
}

// Destination area restriction. If the `CCN` rate limit type is `OUTER_REGION_LIMIT`, this value does not need to be set.
func (o BandwidthLimitOutput) DstRegion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *BandwidthLimit) pulumi.StringPtrOutput { return v.DstRegion }).(pulumi.StringPtrOutput)
}

// Limitation of region.
func (o BandwidthLimitOutput) Region() pulumi.StringOutput {
	return o.ApplyT(func(v *BandwidthLimit) pulumi.StringOutput { return v.Region }).(pulumi.StringOutput)
}

type BandwidthLimitArrayOutput struct{ *pulumi.OutputState }

func (BandwidthLimitArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BandwidthLimit)(nil)).Elem()
}

func (o BandwidthLimitArrayOutput) ToBandwidthLimitArrayOutput() BandwidthLimitArrayOutput {
	return o
}

func (o BandwidthLimitArrayOutput) ToBandwidthLimitArrayOutputWithContext(ctx context.Context) BandwidthLimitArrayOutput {
	return o
}

func (o BandwidthLimitArrayOutput) Index(i pulumi.IntInput) BandwidthLimitOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *BandwidthLimit {
		return vs[0].([]*BandwidthLimit)[vs[1].(int)]
	}).(BandwidthLimitOutput)
}

type BandwidthLimitMapOutput struct{ *pulumi.OutputState }

func (BandwidthLimitMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BandwidthLimit)(nil)).Elem()
}

func (o BandwidthLimitMapOutput) ToBandwidthLimitMapOutput() BandwidthLimitMapOutput {
	return o
}

func (o BandwidthLimitMapOutput) ToBandwidthLimitMapOutputWithContext(ctx context.Context) BandwidthLimitMapOutput {
	return o
}

func (o BandwidthLimitMapOutput) MapIndex(k pulumi.StringInput) BandwidthLimitOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *BandwidthLimit {
		return vs[0].(map[string]*BandwidthLimit)[vs[1].(string)]
	}).(BandwidthLimitOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*BandwidthLimitInput)(nil)).Elem(), &BandwidthLimit{})
	pulumi.RegisterInputType(reflect.TypeOf((*BandwidthLimitArrayInput)(nil)).Elem(), BandwidthLimitArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*BandwidthLimitMapInput)(nil)).Elem(), BandwidthLimitMap{})
	pulumi.RegisterOutputType(BandwidthLimitOutput{})
	pulumi.RegisterOutputType(BandwidthLimitArrayOutput{})
	pulumi.RegisterOutputType(BandwidthLimitMapOutput{})
}