// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package redis

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a redis securityGroupAttachment
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Redis"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Redis"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Security"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		zone, err := Redis.GetZoneConfig(ctx, &redis.GetZoneConfigArgs{
// 			TypeId: pulumi.IntRef(7),
// 			Region: pulumi.StringRef("ap-guangzhou"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		vpc, err := Vpc.NewInstance(ctx, "vpc", &Vpc.InstanceArgs{
// 			CidrBlock: pulumi.String("10.0.0.0/16"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		subnet, err := Subnet.NewInstance(ctx, "subnet", &Subnet.InstanceArgs{
// 			VpcId:            vpc.ID(),
// 			AvailabilityZone: pulumi.String(zone.Lists[2].Zone),
// 			CidrBlock:        pulumi.String("10.0.1.0/24"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		fooGroup, err := Security.NewGroup(ctx, "fooGroup", nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = Security.NewGroupLiteRule(ctx, "fooGroupLiteRule", &Security.GroupLiteRuleArgs{
// 			SecurityGroupId: fooGroup.ID(),
// 			Ingresses: pulumi.StringArray{
// 				pulumi.String("ACCEPT#192.168.1.0/24#80#TCP"),
// 				pulumi.String("DROP#8.8.8.8#80,90#UDP"),
// 				pulumi.String("DROP#0.0.0.0/0#80-90#TCP"),
// 			},
// 			Egresses: pulumi.StringArray{
// 				pulumi.String("ACCEPT#192.168.0.0/16#ALL#TCP"),
// 				pulumi.String("ACCEPT#10.0.0.0/8#ALL#ICMP"),
// 				pulumi.String("DROP#0.0.0.0/0#ALL#ALL"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		fooInstance, err := Redis.NewInstance(ctx, "fooInstance", &Redis.InstanceArgs{
// 			AvailabilityZone: pulumi.String(zone.Lists[2].Zone),
// 			TypeId:           pulumi.Int(zone.Lists[2].TypeId),
// 			Password:         pulumi.String("test12345789"),
// 			MemSize:          pulumi.Int(8192),
// 			RedisShardNum:    pulumi.Int(zone.Lists[2].RedisShardNums[0]),
// 			RedisReplicasNum: pulumi.Int(zone.Lists[2].RedisReplicasNums[0]),
// 			Port:             pulumi.Int(6379),
// 			VpcId:            vpc.ID(),
// 			SubnetId:         subnet.ID(),
// 			SecurityGroups: pulumi.StringArray{
// 				fooGroup.ID(),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		instance, err := Redis.NewInstance(ctx, "instance", &Redis.InstanceArgs{
// 			AvailabilityZone: pulumi.String(zone.Lists[2].Zone),
// 			TypeId:           pulumi.Int(zone.Lists[2].TypeId),
// 			Password:         pulumi.String("test12345789"),
// 			MemSize:          pulumi.Int(8192),
// 			RedisShardNum:    pulumi.Int(zone.Lists[2].RedisShardNums[0]),
// 			RedisReplicasNum: pulumi.Int(zone.Lists[2].RedisReplicasNums[0]),
// 			Port:             pulumi.Int(6379),
// 			VpcId:            vpc.ID(),
// 			SubnetId:         subnet.ID(),
// 			SecurityGroups: pulumi.StringArray{
// 				fooGroup.ID(),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = Redis.NewReplicateAttachment(ctx, "replicateAttachment", &Redis.ReplicateAttachmentArgs{
// 			GroupId:          pulumi.String("crs-rpl-orfiwmn5"),
// 			MasterInstanceId: fooInstance.ID(),
// 			InstanceIds: pulumi.StringArray{
// 				instance.ID(),
// 			},
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
// redis security_group_attachment can be imported using the id, e.g.
//
// ```sh
//  $ pulumi import tencentcloud:Redis/securityGroupAttachment:SecurityGroupAttachment security_group_attachment instance_id#security_group_id
// ```
type SecurityGroupAttachment struct {
	pulumi.CustomResourceState

	// Instance ID.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Security group ID.
	SecurityGroupId pulumi.StringOutput `pulumi:"securityGroupId"`
}

// NewSecurityGroupAttachment registers a new resource with the given unique name, arguments, and options.
func NewSecurityGroupAttachment(ctx *pulumi.Context,
	name string, args *SecurityGroupAttachmentArgs, opts ...pulumi.ResourceOption) (*SecurityGroupAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.SecurityGroupId == nil {
		return nil, errors.New("invalid value for required argument 'SecurityGroupId'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource SecurityGroupAttachment
	err := ctx.RegisterResource("tencentcloud:Redis/securityGroupAttachment:SecurityGroupAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurityGroupAttachment gets an existing SecurityGroupAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityGroupAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityGroupAttachmentState, opts ...pulumi.ResourceOption) (*SecurityGroupAttachment, error) {
	var resource SecurityGroupAttachment
	err := ctx.ReadResource("tencentcloud:Redis/securityGroupAttachment:SecurityGroupAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecurityGroupAttachment resources.
type securityGroupAttachmentState struct {
	// Instance ID.
	InstanceId *string `pulumi:"instanceId"`
	// Security group ID.
	SecurityGroupId *string `pulumi:"securityGroupId"`
}

type SecurityGroupAttachmentState struct {
	// Instance ID.
	InstanceId pulumi.StringPtrInput
	// Security group ID.
	SecurityGroupId pulumi.StringPtrInput
}

func (SecurityGroupAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityGroupAttachmentState)(nil)).Elem()
}

type securityGroupAttachmentArgs struct {
	// Instance ID.
	InstanceId string `pulumi:"instanceId"`
	// Security group ID.
	SecurityGroupId string `pulumi:"securityGroupId"`
}

// The set of arguments for constructing a SecurityGroupAttachment resource.
type SecurityGroupAttachmentArgs struct {
	// Instance ID.
	InstanceId pulumi.StringInput
	// Security group ID.
	SecurityGroupId pulumi.StringInput
}

func (SecurityGroupAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityGroupAttachmentArgs)(nil)).Elem()
}

type SecurityGroupAttachmentInput interface {
	pulumi.Input

	ToSecurityGroupAttachmentOutput() SecurityGroupAttachmentOutput
	ToSecurityGroupAttachmentOutputWithContext(ctx context.Context) SecurityGroupAttachmentOutput
}

func (*SecurityGroupAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((**SecurityGroupAttachment)(nil)).Elem()
}

func (i *SecurityGroupAttachment) ToSecurityGroupAttachmentOutput() SecurityGroupAttachmentOutput {
	return i.ToSecurityGroupAttachmentOutputWithContext(context.Background())
}

func (i *SecurityGroupAttachment) ToSecurityGroupAttachmentOutputWithContext(ctx context.Context) SecurityGroupAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityGroupAttachmentOutput)
}

// SecurityGroupAttachmentArrayInput is an input type that accepts SecurityGroupAttachmentArray and SecurityGroupAttachmentArrayOutput values.
// You can construct a concrete instance of `SecurityGroupAttachmentArrayInput` via:
//
//          SecurityGroupAttachmentArray{ SecurityGroupAttachmentArgs{...} }
type SecurityGroupAttachmentArrayInput interface {
	pulumi.Input

	ToSecurityGroupAttachmentArrayOutput() SecurityGroupAttachmentArrayOutput
	ToSecurityGroupAttachmentArrayOutputWithContext(context.Context) SecurityGroupAttachmentArrayOutput
}

type SecurityGroupAttachmentArray []SecurityGroupAttachmentInput

func (SecurityGroupAttachmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SecurityGroupAttachment)(nil)).Elem()
}

func (i SecurityGroupAttachmentArray) ToSecurityGroupAttachmentArrayOutput() SecurityGroupAttachmentArrayOutput {
	return i.ToSecurityGroupAttachmentArrayOutputWithContext(context.Background())
}

func (i SecurityGroupAttachmentArray) ToSecurityGroupAttachmentArrayOutputWithContext(ctx context.Context) SecurityGroupAttachmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityGroupAttachmentArrayOutput)
}

// SecurityGroupAttachmentMapInput is an input type that accepts SecurityGroupAttachmentMap and SecurityGroupAttachmentMapOutput values.
// You can construct a concrete instance of `SecurityGroupAttachmentMapInput` via:
//
//          SecurityGroupAttachmentMap{ "key": SecurityGroupAttachmentArgs{...} }
type SecurityGroupAttachmentMapInput interface {
	pulumi.Input

	ToSecurityGroupAttachmentMapOutput() SecurityGroupAttachmentMapOutput
	ToSecurityGroupAttachmentMapOutputWithContext(context.Context) SecurityGroupAttachmentMapOutput
}

type SecurityGroupAttachmentMap map[string]SecurityGroupAttachmentInput

func (SecurityGroupAttachmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SecurityGroupAttachment)(nil)).Elem()
}

func (i SecurityGroupAttachmentMap) ToSecurityGroupAttachmentMapOutput() SecurityGroupAttachmentMapOutput {
	return i.ToSecurityGroupAttachmentMapOutputWithContext(context.Background())
}

func (i SecurityGroupAttachmentMap) ToSecurityGroupAttachmentMapOutputWithContext(ctx context.Context) SecurityGroupAttachmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityGroupAttachmentMapOutput)
}

type SecurityGroupAttachmentOutput struct{ *pulumi.OutputState }

func (SecurityGroupAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SecurityGroupAttachment)(nil)).Elem()
}

func (o SecurityGroupAttachmentOutput) ToSecurityGroupAttachmentOutput() SecurityGroupAttachmentOutput {
	return o
}

func (o SecurityGroupAttachmentOutput) ToSecurityGroupAttachmentOutputWithContext(ctx context.Context) SecurityGroupAttachmentOutput {
	return o
}

// Instance ID.
func (o SecurityGroupAttachmentOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityGroupAttachment) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// Security group ID.
func (o SecurityGroupAttachmentOutput) SecurityGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityGroupAttachment) pulumi.StringOutput { return v.SecurityGroupId }).(pulumi.StringOutput)
}

type SecurityGroupAttachmentArrayOutput struct{ *pulumi.OutputState }

func (SecurityGroupAttachmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SecurityGroupAttachment)(nil)).Elem()
}

func (o SecurityGroupAttachmentArrayOutput) ToSecurityGroupAttachmentArrayOutput() SecurityGroupAttachmentArrayOutput {
	return o
}

func (o SecurityGroupAttachmentArrayOutput) ToSecurityGroupAttachmentArrayOutputWithContext(ctx context.Context) SecurityGroupAttachmentArrayOutput {
	return o
}

func (o SecurityGroupAttachmentArrayOutput) Index(i pulumi.IntInput) SecurityGroupAttachmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SecurityGroupAttachment {
		return vs[0].([]*SecurityGroupAttachment)[vs[1].(int)]
	}).(SecurityGroupAttachmentOutput)
}

type SecurityGroupAttachmentMapOutput struct{ *pulumi.OutputState }

func (SecurityGroupAttachmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SecurityGroupAttachment)(nil)).Elem()
}

func (o SecurityGroupAttachmentMapOutput) ToSecurityGroupAttachmentMapOutput() SecurityGroupAttachmentMapOutput {
	return o
}

func (o SecurityGroupAttachmentMapOutput) ToSecurityGroupAttachmentMapOutputWithContext(ctx context.Context) SecurityGroupAttachmentMapOutput {
	return o
}

func (o SecurityGroupAttachmentMapOutput) MapIndex(k pulumi.StringInput) SecurityGroupAttachmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SecurityGroupAttachment {
		return vs[0].(map[string]*SecurityGroupAttachment)[vs[1].(string)]
	}).(SecurityGroupAttachmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityGroupAttachmentInput)(nil)).Elem(), &SecurityGroupAttachment{})
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityGroupAttachmentArrayInput)(nil)).Elem(), SecurityGroupAttachmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityGroupAttachmentMapInput)(nil)).Elem(), SecurityGroupAttachmentMap{})
	pulumi.RegisterOutputType(SecurityGroupAttachmentOutput{})
	pulumi.RegisterOutputType(SecurityGroupAttachmentArrayOutput{})
	pulumi.RegisterOutputType(SecurityGroupAttachmentMapOutput{})
}
