// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package teo

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a teo ddosPolicy
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Teo"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Teo"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Teo.NewDdosPolicy(ctx, "ddosPolicy", &Teo.DdosPolicyArgs{
// 			DdosRule: &teo.DdosPolicyDdosRuleArgs{
// 				Acl: &teo.DdosPolicyDdosRuleAclArgs{
// 					Switch: pulumi.String("on"),
// 				},
// 				AllowBlock: &teo.DdosPolicyDdosRuleAllowBlockArgs{
// 					Switch: pulumi.String("on"),
// 				},
// 				AntiPly: &teo.DdosPolicyDdosRuleAntiPlyArgs{
// 					AbnormalConnectNum:      pulumi.Int(0),
// 					AbnormalSynNum:          pulumi.Int(0),
// 					AbnormalSynRatio:        pulumi.Int(0),
// 					ConnectTimeout:          pulumi.Int(0),
// 					DestinationConnectLimit: pulumi.Int(0),
// 					DestinationCreateLimit:  pulumi.Int(0),
// 					DropIcmp:                pulumi.String("off"),
// 					DropOther:               pulumi.String("off"),
// 					DropTcp:                 pulumi.String("off"),
// 					DropUdp:                 pulumi.String("off"),
// 					EmptyConnectProtect:     pulumi.String("off"),
// 					SourceConnectLimit:      pulumi.Int(0),
// 					SourceCreateLimit:       pulumi.Int(0),
// 					UdpShard:                pulumi.String("off"),
// 				},
// 				GeoIp: &teo.DdosPolicyDdosRuleGeoIpArgs{
// 					RegionIds: pulumi.IntArray{},
// 					Switch:    pulumi.String("on"),
// 				},
// 				PacketFilter: &teo.DdosPolicyDdosRulePacketFilterArgs{
// 					Switch: pulumi.String("on"),
// 				},
// 				SpeedLimit: &teo.DdosPolicyDdosRuleSpeedLimitArgs{
// 					FluxLimit:    pulumi.String("0 bps"),
// 					PackageLimit: pulumi.String("0 pps"),
// 				},
// 				StatusInfo: &teo.DdosPolicyDdosRuleStatusInfoArgs{
// 					PlyLevel: pulumi.String("middle"),
// 				},
// 				Switch: pulumi.String("on"),
// 			},
// 			PolicyId: pulumi.Int(1278),
// 			ZoneId:   pulumi.String("zone-2983wizgxqvm"),
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
// teo ddos_policy can be imported using the id#ddosPolicy_id, e.g.
//
// ```sh
//  $ pulumi import tencentcloud:Teo/ddosPolicy:DdosPolicy ddos_policy zone-2a1u0y616jz6#11587
// ```
type DdosPolicy struct {
	pulumi.CustomResourceState

	// DDoS Configuration of the zone.
	DdosRule DdosPolicyDdosRuleOutput `pulumi:"ddosRule"`
	// Policy ID.
	PolicyId pulumi.IntOutput `pulumi:"policyId"`
	// Site ID.
	ZoneId pulumi.StringOutput `pulumi:"zoneId"`
}

// NewDdosPolicy registers a new resource with the given unique name, arguments, and options.
func NewDdosPolicy(ctx *pulumi.Context,
	name string, args *DdosPolicyArgs, opts ...pulumi.ResourceOption) (*DdosPolicy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PolicyId == nil {
		return nil, errors.New("invalid value for required argument 'PolicyId'")
	}
	if args.ZoneId == nil {
		return nil, errors.New("invalid value for required argument 'ZoneId'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource DdosPolicy
	err := ctx.RegisterResource("tencentcloud:Teo/ddosPolicy:DdosPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDdosPolicy gets an existing DdosPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDdosPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DdosPolicyState, opts ...pulumi.ResourceOption) (*DdosPolicy, error) {
	var resource DdosPolicy
	err := ctx.ReadResource("tencentcloud:Teo/ddosPolicy:DdosPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DdosPolicy resources.
type ddosPolicyState struct {
	// DDoS Configuration of the zone.
	DdosRule *DdosPolicyDdosRule `pulumi:"ddosRule"`
	// Policy ID.
	PolicyId *int `pulumi:"policyId"`
	// Site ID.
	ZoneId *string `pulumi:"zoneId"`
}

type DdosPolicyState struct {
	// DDoS Configuration of the zone.
	DdosRule DdosPolicyDdosRulePtrInput
	// Policy ID.
	PolicyId pulumi.IntPtrInput
	// Site ID.
	ZoneId pulumi.StringPtrInput
}

func (DdosPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*ddosPolicyState)(nil)).Elem()
}

type ddosPolicyArgs struct {
	// DDoS Configuration of the zone.
	DdosRule *DdosPolicyDdosRule `pulumi:"ddosRule"`
	// Policy ID.
	PolicyId int `pulumi:"policyId"`
	// Site ID.
	ZoneId string `pulumi:"zoneId"`
}

// The set of arguments for constructing a DdosPolicy resource.
type DdosPolicyArgs struct {
	// DDoS Configuration of the zone.
	DdosRule DdosPolicyDdosRulePtrInput
	// Policy ID.
	PolicyId pulumi.IntInput
	// Site ID.
	ZoneId pulumi.StringInput
}

func (DdosPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ddosPolicyArgs)(nil)).Elem()
}

type DdosPolicyInput interface {
	pulumi.Input

	ToDdosPolicyOutput() DdosPolicyOutput
	ToDdosPolicyOutputWithContext(ctx context.Context) DdosPolicyOutput
}

func (*DdosPolicy) ElementType() reflect.Type {
	return reflect.TypeOf((**DdosPolicy)(nil)).Elem()
}

func (i *DdosPolicy) ToDdosPolicyOutput() DdosPolicyOutput {
	return i.ToDdosPolicyOutputWithContext(context.Background())
}

func (i *DdosPolicy) ToDdosPolicyOutputWithContext(ctx context.Context) DdosPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DdosPolicyOutput)
}

// DdosPolicyArrayInput is an input type that accepts DdosPolicyArray and DdosPolicyArrayOutput values.
// You can construct a concrete instance of `DdosPolicyArrayInput` via:
//
//          DdosPolicyArray{ DdosPolicyArgs{...} }
type DdosPolicyArrayInput interface {
	pulumi.Input

	ToDdosPolicyArrayOutput() DdosPolicyArrayOutput
	ToDdosPolicyArrayOutputWithContext(context.Context) DdosPolicyArrayOutput
}

type DdosPolicyArray []DdosPolicyInput

func (DdosPolicyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DdosPolicy)(nil)).Elem()
}

func (i DdosPolicyArray) ToDdosPolicyArrayOutput() DdosPolicyArrayOutput {
	return i.ToDdosPolicyArrayOutputWithContext(context.Background())
}

func (i DdosPolicyArray) ToDdosPolicyArrayOutputWithContext(ctx context.Context) DdosPolicyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DdosPolicyArrayOutput)
}

// DdosPolicyMapInput is an input type that accepts DdosPolicyMap and DdosPolicyMapOutput values.
// You can construct a concrete instance of `DdosPolicyMapInput` via:
//
//          DdosPolicyMap{ "key": DdosPolicyArgs{...} }
type DdosPolicyMapInput interface {
	pulumi.Input

	ToDdosPolicyMapOutput() DdosPolicyMapOutput
	ToDdosPolicyMapOutputWithContext(context.Context) DdosPolicyMapOutput
}

type DdosPolicyMap map[string]DdosPolicyInput

func (DdosPolicyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DdosPolicy)(nil)).Elem()
}

func (i DdosPolicyMap) ToDdosPolicyMapOutput() DdosPolicyMapOutput {
	return i.ToDdosPolicyMapOutputWithContext(context.Background())
}

func (i DdosPolicyMap) ToDdosPolicyMapOutputWithContext(ctx context.Context) DdosPolicyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DdosPolicyMapOutput)
}

type DdosPolicyOutput struct{ *pulumi.OutputState }

func (DdosPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DdosPolicy)(nil)).Elem()
}

func (o DdosPolicyOutput) ToDdosPolicyOutput() DdosPolicyOutput {
	return o
}

func (o DdosPolicyOutput) ToDdosPolicyOutputWithContext(ctx context.Context) DdosPolicyOutput {
	return o
}

// DDoS Configuration of the zone.
func (o DdosPolicyOutput) DdosRule() DdosPolicyDdosRuleOutput {
	return o.ApplyT(func(v *DdosPolicy) DdosPolicyDdosRuleOutput { return v.DdosRule }).(DdosPolicyDdosRuleOutput)
}

// Policy ID.
func (o DdosPolicyOutput) PolicyId() pulumi.IntOutput {
	return o.ApplyT(func(v *DdosPolicy) pulumi.IntOutput { return v.PolicyId }).(pulumi.IntOutput)
}

// Site ID.
func (o DdosPolicyOutput) ZoneId() pulumi.StringOutput {
	return o.ApplyT(func(v *DdosPolicy) pulumi.StringOutput { return v.ZoneId }).(pulumi.StringOutput)
}

type DdosPolicyArrayOutput struct{ *pulumi.OutputState }

func (DdosPolicyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DdosPolicy)(nil)).Elem()
}

func (o DdosPolicyArrayOutput) ToDdosPolicyArrayOutput() DdosPolicyArrayOutput {
	return o
}

func (o DdosPolicyArrayOutput) ToDdosPolicyArrayOutputWithContext(ctx context.Context) DdosPolicyArrayOutput {
	return o
}

func (o DdosPolicyArrayOutput) Index(i pulumi.IntInput) DdosPolicyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DdosPolicy {
		return vs[0].([]*DdosPolicy)[vs[1].(int)]
	}).(DdosPolicyOutput)
}

type DdosPolicyMapOutput struct{ *pulumi.OutputState }

func (DdosPolicyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DdosPolicy)(nil)).Elem()
}

func (o DdosPolicyMapOutput) ToDdosPolicyMapOutput() DdosPolicyMapOutput {
	return o
}

func (o DdosPolicyMapOutput) ToDdosPolicyMapOutputWithContext(ctx context.Context) DdosPolicyMapOutput {
	return o
}

func (o DdosPolicyMapOutput) MapIndex(k pulumi.StringInput) DdosPolicyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DdosPolicy {
		return vs[0].(map[string]*DdosPolicy)[vs[1].(string)]
	}).(DdosPolicyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DdosPolicyInput)(nil)).Elem(), &DdosPolicy{})
	pulumi.RegisterInputType(reflect.TypeOf((*DdosPolicyArrayInput)(nil)).Elem(), DdosPolicyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DdosPolicyMapInput)(nil)).Elem(), DdosPolicyMap{})
	pulumi.RegisterOutputType(DdosPolicyOutput{})
	pulumi.RegisterOutputType(DdosPolicyArrayOutput{})
	pulumi.RegisterOutputType(DdosPolicyMapOutput{})
}