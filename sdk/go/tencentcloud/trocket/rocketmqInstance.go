// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package trocket

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a rocketmq 5.x instance
//
// > **NOTE:** It only supports create postpaid rocketmq 5.x instance.
//
// ## Example Usage
//
// ### Create Basic Instance
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Trocket"
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
//			// create rocketmq instance
//			_, err = Trocket.NewRocketmqInstance(ctx, "example", &Trocket.RocketmqInstanceArgs{
//				InstanceType: pulumi.String("PRO"),
//				SkuCode:      pulumi.String("pro_4k"),
//				Remark:       pulumi.String("remark"),
//				VpcId:        vpc.ID(),
//				SubnetId:     subnet.ID(),
//				Tags: pulumi.Map{
//					"tag_key":   pulumi.Any("rocketmq"),
//					"tag_value": pulumi.Any("5.x"),
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
// ### Create Enable Public Network Instance
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Trocket"
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
//			// create rocketmq instance
//			_, err = Trocket.NewRocketmqInstance(ctx, "example", &Trocket.RocketmqInstanceArgs{
//				InstanceType: pulumi.String("PRO"),
//				SkuCode:      pulumi.String("pro_4k"),
//				Remark:       pulumi.String("remark"),
//				VpcId:        vpc.ID(),
//				SubnetId:     subnet.ID(),
//				EnablePublic: pulumi.Bool(true),
//				Bandwidth:    pulumi.Int(10),
//				Tags: pulumi.Map{
//					"tag_key":   pulumi.Any("rocketmq"),
//					"tag_value": pulumi.Any("5.x"),
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
// ## Import
//
// trocket rocketmq_instance can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Trocket/rocketmqInstance:RocketmqInstance rocketmq_instance rmq-n5qado7m
// ```
type RocketmqInstance struct {
	pulumi.CustomResourceState

	// Public network bandwidth. `bandwidth` must be greater than zero when `enablePublic` equal true.
	Bandwidth pulumi.IntOutput `pulumi:"bandwidth"`
	// Whether to enable the public network. Must set `bandwidth` when `enablePublic` equal true.
	EnablePublic pulumi.BoolOutput `pulumi:"enablePublic"`
	// Instance type. Valid values: `EXPERIMENT`, `BASIC`, `PRO`, `PLATINUM`.
	InstanceType pulumi.StringOutput `pulumi:"instanceType"`
	// Public network access whitelist.
	IpRules RocketmqInstanceIpRuleArrayOutput `pulumi:"ipRules"`
	// Message retention time in hours.
	MessageRetention pulumi.IntOutput `pulumi:"messageRetention"`
	// Instance name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Public network access address.
	PublicEndPoint pulumi.StringOutput `pulumi:"publicEndPoint"`
	// Remark.
	Remark pulumi.StringPtrOutput `pulumi:"remark"`
	// SKU code. Available specifications are as follows: experiment_500, basic_1k, basic_2k, basic_3k, basic_4k, basic_5k, basic_6k, basic_7k, basic_8k, basic_9k, basic_10k, pro_4k, pro_6k, pro_8k, pro_1w, pro_15k, pro_2w, pro_25k, pro_3w, pro_35k, pro_4w, pro_45k, pro_5w, pro_55k, pro_60k, pro_65k, pro_70k, pro_75k, pro_80k, pro_85k, pro_90k, pro_95k, pro_100k, platinum_1w, platinum_2w, platinum_3w, platinum_4w, platinum_5w, platinum_6w, platinum_7w, platinum_8w, platinum_9w, platinum_10w, platinum_12w, platinum_14w, platinum_16w, platinum_18w, platinum_20w, platinum_25w, platinum_30w, platinum_35w, platinum_40w, platinum_45w, platinum_50w, platinum_60w, platinum_70w, platinum_80w, platinum_90w, platinum_100w.
	SkuCode pulumi.StringOutput `pulumi:"skuCode"`
	// Subnet id.
	SubnetId pulumi.StringOutput `pulumi:"subnetId"`
	// Tag description list.
	Tags pulumi.MapOutput `pulumi:"tags"`
	// VPC access address.
	VpcEndPoint pulumi.StringOutput `pulumi:"vpcEndPoint"`
	// VPC id.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
}

// NewRocketmqInstance registers a new resource with the given unique name, arguments, and options.
func NewRocketmqInstance(ctx *pulumi.Context,
	name string, args *RocketmqInstanceArgs, opts ...pulumi.ResourceOption) (*RocketmqInstance, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceType == nil {
		return nil, errors.New("invalid value for required argument 'InstanceType'")
	}
	if args.SkuCode == nil {
		return nil, errors.New("invalid value for required argument 'SkuCode'")
	}
	if args.SubnetId == nil {
		return nil, errors.New("invalid value for required argument 'SubnetId'")
	}
	if args.VpcId == nil {
		return nil, errors.New("invalid value for required argument 'VpcId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RocketmqInstance
	err := ctx.RegisterResource("tencentcloud:Trocket/rocketmqInstance:RocketmqInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRocketmqInstance gets an existing RocketmqInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRocketmqInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RocketmqInstanceState, opts ...pulumi.ResourceOption) (*RocketmqInstance, error) {
	var resource RocketmqInstance
	err := ctx.ReadResource("tencentcloud:Trocket/rocketmqInstance:RocketmqInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RocketmqInstance resources.
type rocketmqInstanceState struct {
	// Public network bandwidth. `bandwidth` must be greater than zero when `enablePublic` equal true.
	Bandwidth *int `pulumi:"bandwidth"`
	// Whether to enable the public network. Must set `bandwidth` when `enablePublic` equal true.
	EnablePublic *bool `pulumi:"enablePublic"`
	// Instance type. Valid values: `EXPERIMENT`, `BASIC`, `PRO`, `PLATINUM`.
	InstanceType *string `pulumi:"instanceType"`
	// Public network access whitelist.
	IpRules []RocketmqInstanceIpRule `pulumi:"ipRules"`
	// Message retention time in hours.
	MessageRetention *int `pulumi:"messageRetention"`
	// Instance name.
	Name *string `pulumi:"name"`
	// Public network access address.
	PublicEndPoint *string `pulumi:"publicEndPoint"`
	// Remark.
	Remark *string `pulumi:"remark"`
	// SKU code. Available specifications are as follows: experiment_500, basic_1k, basic_2k, basic_3k, basic_4k, basic_5k, basic_6k, basic_7k, basic_8k, basic_9k, basic_10k, pro_4k, pro_6k, pro_8k, pro_1w, pro_15k, pro_2w, pro_25k, pro_3w, pro_35k, pro_4w, pro_45k, pro_5w, pro_55k, pro_60k, pro_65k, pro_70k, pro_75k, pro_80k, pro_85k, pro_90k, pro_95k, pro_100k, platinum_1w, platinum_2w, platinum_3w, platinum_4w, platinum_5w, platinum_6w, platinum_7w, platinum_8w, platinum_9w, platinum_10w, platinum_12w, platinum_14w, platinum_16w, platinum_18w, platinum_20w, platinum_25w, platinum_30w, platinum_35w, platinum_40w, platinum_45w, platinum_50w, platinum_60w, platinum_70w, platinum_80w, platinum_90w, platinum_100w.
	SkuCode *string `pulumi:"skuCode"`
	// Subnet id.
	SubnetId *string `pulumi:"subnetId"`
	// Tag description list.
	Tags map[string]interface{} `pulumi:"tags"`
	// VPC access address.
	VpcEndPoint *string `pulumi:"vpcEndPoint"`
	// VPC id.
	VpcId *string `pulumi:"vpcId"`
}

type RocketmqInstanceState struct {
	// Public network bandwidth. `bandwidth` must be greater than zero when `enablePublic` equal true.
	Bandwidth pulumi.IntPtrInput
	// Whether to enable the public network. Must set `bandwidth` when `enablePublic` equal true.
	EnablePublic pulumi.BoolPtrInput
	// Instance type. Valid values: `EXPERIMENT`, `BASIC`, `PRO`, `PLATINUM`.
	InstanceType pulumi.StringPtrInput
	// Public network access whitelist.
	IpRules RocketmqInstanceIpRuleArrayInput
	// Message retention time in hours.
	MessageRetention pulumi.IntPtrInput
	// Instance name.
	Name pulumi.StringPtrInput
	// Public network access address.
	PublicEndPoint pulumi.StringPtrInput
	// Remark.
	Remark pulumi.StringPtrInput
	// SKU code. Available specifications are as follows: experiment_500, basic_1k, basic_2k, basic_3k, basic_4k, basic_5k, basic_6k, basic_7k, basic_8k, basic_9k, basic_10k, pro_4k, pro_6k, pro_8k, pro_1w, pro_15k, pro_2w, pro_25k, pro_3w, pro_35k, pro_4w, pro_45k, pro_5w, pro_55k, pro_60k, pro_65k, pro_70k, pro_75k, pro_80k, pro_85k, pro_90k, pro_95k, pro_100k, platinum_1w, platinum_2w, platinum_3w, platinum_4w, platinum_5w, platinum_6w, platinum_7w, platinum_8w, platinum_9w, platinum_10w, platinum_12w, platinum_14w, platinum_16w, platinum_18w, platinum_20w, platinum_25w, platinum_30w, platinum_35w, platinum_40w, platinum_45w, platinum_50w, platinum_60w, platinum_70w, platinum_80w, platinum_90w, platinum_100w.
	SkuCode pulumi.StringPtrInput
	// Subnet id.
	SubnetId pulumi.StringPtrInput
	// Tag description list.
	Tags pulumi.MapInput
	// VPC access address.
	VpcEndPoint pulumi.StringPtrInput
	// VPC id.
	VpcId pulumi.StringPtrInput
}

func (RocketmqInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*rocketmqInstanceState)(nil)).Elem()
}

type rocketmqInstanceArgs struct {
	// Public network bandwidth. `bandwidth` must be greater than zero when `enablePublic` equal true.
	Bandwidth *int `pulumi:"bandwidth"`
	// Whether to enable the public network. Must set `bandwidth` when `enablePublic` equal true.
	EnablePublic *bool `pulumi:"enablePublic"`
	// Instance type. Valid values: `EXPERIMENT`, `BASIC`, `PRO`, `PLATINUM`.
	InstanceType string `pulumi:"instanceType"`
	// Public network access whitelist.
	IpRules []RocketmqInstanceIpRule `pulumi:"ipRules"`
	// Message retention time in hours.
	MessageRetention *int `pulumi:"messageRetention"`
	// Instance name.
	Name *string `pulumi:"name"`
	// Remark.
	Remark *string `pulumi:"remark"`
	// SKU code. Available specifications are as follows: experiment_500, basic_1k, basic_2k, basic_3k, basic_4k, basic_5k, basic_6k, basic_7k, basic_8k, basic_9k, basic_10k, pro_4k, pro_6k, pro_8k, pro_1w, pro_15k, pro_2w, pro_25k, pro_3w, pro_35k, pro_4w, pro_45k, pro_5w, pro_55k, pro_60k, pro_65k, pro_70k, pro_75k, pro_80k, pro_85k, pro_90k, pro_95k, pro_100k, platinum_1w, platinum_2w, platinum_3w, platinum_4w, platinum_5w, platinum_6w, platinum_7w, platinum_8w, platinum_9w, platinum_10w, platinum_12w, platinum_14w, platinum_16w, platinum_18w, platinum_20w, platinum_25w, platinum_30w, platinum_35w, platinum_40w, platinum_45w, platinum_50w, platinum_60w, platinum_70w, platinum_80w, platinum_90w, platinum_100w.
	SkuCode string `pulumi:"skuCode"`
	// Subnet id.
	SubnetId string `pulumi:"subnetId"`
	// Tag description list.
	Tags map[string]interface{} `pulumi:"tags"`
	// VPC id.
	VpcId string `pulumi:"vpcId"`
}

// The set of arguments for constructing a RocketmqInstance resource.
type RocketmqInstanceArgs struct {
	// Public network bandwidth. `bandwidth` must be greater than zero when `enablePublic` equal true.
	Bandwidth pulumi.IntPtrInput
	// Whether to enable the public network. Must set `bandwidth` when `enablePublic` equal true.
	EnablePublic pulumi.BoolPtrInput
	// Instance type. Valid values: `EXPERIMENT`, `BASIC`, `PRO`, `PLATINUM`.
	InstanceType pulumi.StringInput
	// Public network access whitelist.
	IpRules RocketmqInstanceIpRuleArrayInput
	// Message retention time in hours.
	MessageRetention pulumi.IntPtrInput
	// Instance name.
	Name pulumi.StringPtrInput
	// Remark.
	Remark pulumi.StringPtrInput
	// SKU code. Available specifications are as follows: experiment_500, basic_1k, basic_2k, basic_3k, basic_4k, basic_5k, basic_6k, basic_7k, basic_8k, basic_9k, basic_10k, pro_4k, pro_6k, pro_8k, pro_1w, pro_15k, pro_2w, pro_25k, pro_3w, pro_35k, pro_4w, pro_45k, pro_5w, pro_55k, pro_60k, pro_65k, pro_70k, pro_75k, pro_80k, pro_85k, pro_90k, pro_95k, pro_100k, platinum_1w, platinum_2w, platinum_3w, platinum_4w, platinum_5w, platinum_6w, platinum_7w, platinum_8w, platinum_9w, platinum_10w, platinum_12w, platinum_14w, platinum_16w, platinum_18w, platinum_20w, platinum_25w, platinum_30w, platinum_35w, platinum_40w, platinum_45w, platinum_50w, platinum_60w, platinum_70w, platinum_80w, platinum_90w, platinum_100w.
	SkuCode pulumi.StringInput
	// Subnet id.
	SubnetId pulumi.StringInput
	// Tag description list.
	Tags pulumi.MapInput
	// VPC id.
	VpcId pulumi.StringInput
}

func (RocketmqInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*rocketmqInstanceArgs)(nil)).Elem()
}

type RocketmqInstanceInput interface {
	pulumi.Input

	ToRocketmqInstanceOutput() RocketmqInstanceOutput
	ToRocketmqInstanceOutputWithContext(ctx context.Context) RocketmqInstanceOutput
}

func (*RocketmqInstance) ElementType() reflect.Type {
	return reflect.TypeOf((**RocketmqInstance)(nil)).Elem()
}

func (i *RocketmqInstance) ToRocketmqInstanceOutput() RocketmqInstanceOutput {
	return i.ToRocketmqInstanceOutputWithContext(context.Background())
}

func (i *RocketmqInstance) ToRocketmqInstanceOutputWithContext(ctx context.Context) RocketmqInstanceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RocketmqInstanceOutput)
}

// RocketmqInstanceArrayInput is an input type that accepts RocketmqInstanceArray and RocketmqInstanceArrayOutput values.
// You can construct a concrete instance of `RocketmqInstanceArrayInput` via:
//
//	RocketmqInstanceArray{ RocketmqInstanceArgs{...} }
type RocketmqInstanceArrayInput interface {
	pulumi.Input

	ToRocketmqInstanceArrayOutput() RocketmqInstanceArrayOutput
	ToRocketmqInstanceArrayOutputWithContext(context.Context) RocketmqInstanceArrayOutput
}

type RocketmqInstanceArray []RocketmqInstanceInput

func (RocketmqInstanceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RocketmqInstance)(nil)).Elem()
}

func (i RocketmqInstanceArray) ToRocketmqInstanceArrayOutput() RocketmqInstanceArrayOutput {
	return i.ToRocketmqInstanceArrayOutputWithContext(context.Background())
}

func (i RocketmqInstanceArray) ToRocketmqInstanceArrayOutputWithContext(ctx context.Context) RocketmqInstanceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RocketmqInstanceArrayOutput)
}

// RocketmqInstanceMapInput is an input type that accepts RocketmqInstanceMap and RocketmqInstanceMapOutput values.
// You can construct a concrete instance of `RocketmqInstanceMapInput` via:
//
//	RocketmqInstanceMap{ "key": RocketmqInstanceArgs{...} }
type RocketmqInstanceMapInput interface {
	pulumi.Input

	ToRocketmqInstanceMapOutput() RocketmqInstanceMapOutput
	ToRocketmqInstanceMapOutputWithContext(context.Context) RocketmqInstanceMapOutput
}

type RocketmqInstanceMap map[string]RocketmqInstanceInput

func (RocketmqInstanceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RocketmqInstance)(nil)).Elem()
}

func (i RocketmqInstanceMap) ToRocketmqInstanceMapOutput() RocketmqInstanceMapOutput {
	return i.ToRocketmqInstanceMapOutputWithContext(context.Background())
}

func (i RocketmqInstanceMap) ToRocketmqInstanceMapOutputWithContext(ctx context.Context) RocketmqInstanceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RocketmqInstanceMapOutput)
}

type RocketmqInstanceOutput struct{ *pulumi.OutputState }

func (RocketmqInstanceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RocketmqInstance)(nil)).Elem()
}

func (o RocketmqInstanceOutput) ToRocketmqInstanceOutput() RocketmqInstanceOutput {
	return o
}

func (o RocketmqInstanceOutput) ToRocketmqInstanceOutputWithContext(ctx context.Context) RocketmqInstanceOutput {
	return o
}

// Public network bandwidth. `bandwidth` must be greater than zero when `enablePublic` equal true.
func (o RocketmqInstanceOutput) Bandwidth() pulumi.IntOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.IntOutput { return v.Bandwidth }).(pulumi.IntOutput)
}

// Whether to enable the public network. Must set `bandwidth` when `enablePublic` equal true.
func (o RocketmqInstanceOutput) EnablePublic() pulumi.BoolOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.BoolOutput { return v.EnablePublic }).(pulumi.BoolOutput)
}

// Instance type. Valid values: `EXPERIMENT`, `BASIC`, `PRO`, `PLATINUM`.
func (o RocketmqInstanceOutput) InstanceType() pulumi.StringOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.StringOutput { return v.InstanceType }).(pulumi.StringOutput)
}

// Public network access whitelist.
func (o RocketmqInstanceOutput) IpRules() RocketmqInstanceIpRuleArrayOutput {
	return o.ApplyT(func(v *RocketmqInstance) RocketmqInstanceIpRuleArrayOutput { return v.IpRules }).(RocketmqInstanceIpRuleArrayOutput)
}

// Message retention time in hours.
func (o RocketmqInstanceOutput) MessageRetention() pulumi.IntOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.IntOutput { return v.MessageRetention }).(pulumi.IntOutput)
}

// Instance name.
func (o RocketmqInstanceOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Public network access address.
func (o RocketmqInstanceOutput) PublicEndPoint() pulumi.StringOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.StringOutput { return v.PublicEndPoint }).(pulumi.StringOutput)
}

// Remark.
func (o RocketmqInstanceOutput) Remark() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.StringPtrOutput { return v.Remark }).(pulumi.StringPtrOutput)
}

// SKU code. Available specifications are as follows: experiment_500, basic_1k, basic_2k, basic_3k, basic_4k, basic_5k, basic_6k, basic_7k, basic_8k, basic_9k, basic_10k, pro_4k, pro_6k, pro_8k, pro_1w, pro_15k, pro_2w, pro_25k, pro_3w, pro_35k, pro_4w, pro_45k, pro_5w, pro_55k, pro_60k, pro_65k, pro_70k, pro_75k, pro_80k, pro_85k, pro_90k, pro_95k, pro_100k, platinum_1w, platinum_2w, platinum_3w, platinum_4w, platinum_5w, platinum_6w, platinum_7w, platinum_8w, platinum_9w, platinum_10w, platinum_12w, platinum_14w, platinum_16w, platinum_18w, platinum_20w, platinum_25w, platinum_30w, platinum_35w, platinum_40w, platinum_45w, platinum_50w, platinum_60w, platinum_70w, platinum_80w, platinum_90w, platinum_100w.
func (o RocketmqInstanceOutput) SkuCode() pulumi.StringOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.StringOutput { return v.SkuCode }).(pulumi.StringOutput)
}

// Subnet id.
func (o RocketmqInstanceOutput) SubnetId() pulumi.StringOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.StringOutput { return v.SubnetId }).(pulumi.StringOutput)
}

// Tag description list.
func (o RocketmqInstanceOutput) Tags() pulumi.MapOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.MapOutput { return v.Tags }).(pulumi.MapOutput)
}

// VPC access address.
func (o RocketmqInstanceOutput) VpcEndPoint() pulumi.StringOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.StringOutput { return v.VpcEndPoint }).(pulumi.StringOutput)
}

// VPC id.
func (o RocketmqInstanceOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v *RocketmqInstance) pulumi.StringOutput { return v.VpcId }).(pulumi.StringOutput)
}

type RocketmqInstanceArrayOutput struct{ *pulumi.OutputState }

func (RocketmqInstanceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RocketmqInstance)(nil)).Elem()
}

func (o RocketmqInstanceArrayOutput) ToRocketmqInstanceArrayOutput() RocketmqInstanceArrayOutput {
	return o
}

func (o RocketmqInstanceArrayOutput) ToRocketmqInstanceArrayOutputWithContext(ctx context.Context) RocketmqInstanceArrayOutput {
	return o
}

func (o RocketmqInstanceArrayOutput) Index(i pulumi.IntInput) RocketmqInstanceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RocketmqInstance {
		return vs[0].([]*RocketmqInstance)[vs[1].(int)]
	}).(RocketmqInstanceOutput)
}

type RocketmqInstanceMapOutput struct{ *pulumi.OutputState }

func (RocketmqInstanceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RocketmqInstance)(nil)).Elem()
}

func (o RocketmqInstanceMapOutput) ToRocketmqInstanceMapOutput() RocketmqInstanceMapOutput {
	return o
}

func (o RocketmqInstanceMapOutput) ToRocketmqInstanceMapOutputWithContext(ctx context.Context) RocketmqInstanceMapOutput {
	return o
}

func (o RocketmqInstanceMapOutput) MapIndex(k pulumi.StringInput) RocketmqInstanceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RocketmqInstance {
		return vs[0].(map[string]*RocketmqInstance)[vs[1].(string)]
	}).(RocketmqInstanceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RocketmqInstanceInput)(nil)).Elem(), &RocketmqInstance{})
	pulumi.RegisterInputType(reflect.TypeOf((*RocketmqInstanceArrayInput)(nil)).Elem(), RocketmqInstanceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RocketmqInstanceMapInput)(nil)).Elem(), RocketmqInstanceMap{})
	pulumi.RegisterOutputType(RocketmqInstanceOutput{})
	pulumi.RegisterOutputType(RocketmqInstanceArrayOutput{})
	pulumi.RegisterOutputType(RocketmqInstanceMapOutput{})
}