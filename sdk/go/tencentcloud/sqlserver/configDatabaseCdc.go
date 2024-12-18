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

// Provides a resource to create a sqlserver configDatabaseCdc
//
// ## Example Usage
//
// ### Turn off database data change capture (CDC)
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
//			exampleBasicInstance, err := Sqlserver.NewBasicInstance(ctx, "exampleBasicInstance", &Sqlserver.BasicInstanceArgs{
//				AvailabilityZone: pulumi.String(zones.Zones[4].Name),
//				ChargeType:       pulumi.String("POSTPAID_BY_HOUR"),
//				VpcId:            vpc.ID(),
//				SubnetId:         subnet.ID(),
//				ProjectId:        pulumi.Int(0),
//				Memory:           pulumi.Int(4),
//				Storage:          pulumi.Int(100),
//				Cpu:              pulumi.Int(2),
//				MachineType:      pulumi.String("CLOUD_PREMIUM"),
//				MaintenanceWeekSets: pulumi.IntArray{
//					pulumi.Int(1),
//					pulumi.Int(2),
//					pulumi.Int(3),
//				},
//				MaintenanceStartTime: pulumi.String("09:00"),
//				MaintenanceTimeSpan:  pulumi.Int(3),
//				SecurityGroups: pulumi.StringArray{
//					securityGroup.ID(),
//				},
//				Tags: pulumi.Map{
//					"test": pulumi.Any("test"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			exampleDb, err := Sqlserver.NewDb(ctx, "exampleDb", &Sqlserver.DbArgs{
//				InstanceId: exampleBasicInstance.ID(),
//				Charset:    pulumi.String("Chinese_PRC_BIN"),
//				Remark:     pulumi.String("test-remark"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Sqlserver.NewConfigDatabaseCdc(ctx, "exampleConfigDatabaseCdc", &Sqlserver.ConfigDatabaseCdcArgs{
//				InstanceId: exampleBasicInstance.ID(),
//				DbName:     exampleDb.Name,
//				ModifyType: pulumi.String("disable"),
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
// ### Enable Database Data Change Capture (CDC)
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
//			_, err := Sqlserver.NewConfigDatabaseCdc(ctx, "example", &Sqlserver.ConfigDatabaseCdcArgs{
//				InstanceId: pulumi.Any(tencentcloud_sqlserver_basic_instance.Example.Id),
//				DbName:     pulumi.Any(tencentcloud_sqlserver_db.Example.Name),
//				ModifyType: pulumi.String("enable"),
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
// sqlserver config_database_cdc can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Sqlserver/configDatabaseCdc:ConfigDatabaseCdc example mssql-i9ma6oy7#tf_example_db
// ```
type ConfigDatabaseCdc struct {
	pulumi.CustomResourceState

	// database name.
	DbName pulumi.StringOutput `pulumi:"dbName"`
	// Instance ID.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Enable or disable CDC. Valid values: enable, disable.
	ModifyType pulumi.StringOutput `pulumi:"modifyType"`
}

// NewConfigDatabaseCdc registers a new resource with the given unique name, arguments, and options.
func NewConfigDatabaseCdc(ctx *pulumi.Context,
	name string, args *ConfigDatabaseCdcArgs, opts ...pulumi.ResourceOption) (*ConfigDatabaseCdc, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DbName == nil {
		return nil, errors.New("invalid value for required argument 'DbName'")
	}
	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.ModifyType == nil {
		return nil, errors.New("invalid value for required argument 'ModifyType'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ConfigDatabaseCdc
	err := ctx.RegisterResource("tencentcloud:Sqlserver/configDatabaseCdc:ConfigDatabaseCdc", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConfigDatabaseCdc gets an existing ConfigDatabaseCdc resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConfigDatabaseCdc(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConfigDatabaseCdcState, opts ...pulumi.ResourceOption) (*ConfigDatabaseCdc, error) {
	var resource ConfigDatabaseCdc
	err := ctx.ReadResource("tencentcloud:Sqlserver/configDatabaseCdc:ConfigDatabaseCdc", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConfigDatabaseCdc resources.
type configDatabaseCdcState struct {
	// database name.
	DbName *string `pulumi:"dbName"`
	// Instance ID.
	InstanceId *string `pulumi:"instanceId"`
	// Enable or disable CDC. Valid values: enable, disable.
	ModifyType *string `pulumi:"modifyType"`
}

type ConfigDatabaseCdcState struct {
	// database name.
	DbName pulumi.StringPtrInput
	// Instance ID.
	InstanceId pulumi.StringPtrInput
	// Enable or disable CDC. Valid values: enable, disable.
	ModifyType pulumi.StringPtrInput
}

func (ConfigDatabaseCdcState) ElementType() reflect.Type {
	return reflect.TypeOf((*configDatabaseCdcState)(nil)).Elem()
}

type configDatabaseCdcArgs struct {
	// database name.
	DbName string `pulumi:"dbName"`
	// Instance ID.
	InstanceId string `pulumi:"instanceId"`
	// Enable or disable CDC. Valid values: enable, disable.
	ModifyType string `pulumi:"modifyType"`
}

// The set of arguments for constructing a ConfigDatabaseCdc resource.
type ConfigDatabaseCdcArgs struct {
	// database name.
	DbName pulumi.StringInput
	// Instance ID.
	InstanceId pulumi.StringInput
	// Enable or disable CDC. Valid values: enable, disable.
	ModifyType pulumi.StringInput
}

func (ConfigDatabaseCdcArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*configDatabaseCdcArgs)(nil)).Elem()
}

type ConfigDatabaseCdcInput interface {
	pulumi.Input

	ToConfigDatabaseCdcOutput() ConfigDatabaseCdcOutput
	ToConfigDatabaseCdcOutputWithContext(ctx context.Context) ConfigDatabaseCdcOutput
}

func (*ConfigDatabaseCdc) ElementType() reflect.Type {
	return reflect.TypeOf((**ConfigDatabaseCdc)(nil)).Elem()
}

func (i *ConfigDatabaseCdc) ToConfigDatabaseCdcOutput() ConfigDatabaseCdcOutput {
	return i.ToConfigDatabaseCdcOutputWithContext(context.Background())
}

func (i *ConfigDatabaseCdc) ToConfigDatabaseCdcOutputWithContext(ctx context.Context) ConfigDatabaseCdcOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfigDatabaseCdcOutput)
}

// ConfigDatabaseCdcArrayInput is an input type that accepts ConfigDatabaseCdcArray and ConfigDatabaseCdcArrayOutput values.
// You can construct a concrete instance of `ConfigDatabaseCdcArrayInput` via:
//
//	ConfigDatabaseCdcArray{ ConfigDatabaseCdcArgs{...} }
type ConfigDatabaseCdcArrayInput interface {
	pulumi.Input

	ToConfigDatabaseCdcArrayOutput() ConfigDatabaseCdcArrayOutput
	ToConfigDatabaseCdcArrayOutputWithContext(context.Context) ConfigDatabaseCdcArrayOutput
}

type ConfigDatabaseCdcArray []ConfigDatabaseCdcInput

func (ConfigDatabaseCdcArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ConfigDatabaseCdc)(nil)).Elem()
}

func (i ConfigDatabaseCdcArray) ToConfigDatabaseCdcArrayOutput() ConfigDatabaseCdcArrayOutput {
	return i.ToConfigDatabaseCdcArrayOutputWithContext(context.Background())
}

func (i ConfigDatabaseCdcArray) ToConfigDatabaseCdcArrayOutputWithContext(ctx context.Context) ConfigDatabaseCdcArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfigDatabaseCdcArrayOutput)
}

// ConfigDatabaseCdcMapInput is an input type that accepts ConfigDatabaseCdcMap and ConfigDatabaseCdcMapOutput values.
// You can construct a concrete instance of `ConfigDatabaseCdcMapInput` via:
//
//	ConfigDatabaseCdcMap{ "key": ConfigDatabaseCdcArgs{...} }
type ConfigDatabaseCdcMapInput interface {
	pulumi.Input

	ToConfigDatabaseCdcMapOutput() ConfigDatabaseCdcMapOutput
	ToConfigDatabaseCdcMapOutputWithContext(context.Context) ConfigDatabaseCdcMapOutput
}

type ConfigDatabaseCdcMap map[string]ConfigDatabaseCdcInput

func (ConfigDatabaseCdcMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ConfigDatabaseCdc)(nil)).Elem()
}

func (i ConfigDatabaseCdcMap) ToConfigDatabaseCdcMapOutput() ConfigDatabaseCdcMapOutput {
	return i.ToConfigDatabaseCdcMapOutputWithContext(context.Background())
}

func (i ConfigDatabaseCdcMap) ToConfigDatabaseCdcMapOutputWithContext(ctx context.Context) ConfigDatabaseCdcMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfigDatabaseCdcMapOutput)
}

type ConfigDatabaseCdcOutput struct{ *pulumi.OutputState }

func (ConfigDatabaseCdcOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ConfigDatabaseCdc)(nil)).Elem()
}

func (o ConfigDatabaseCdcOutput) ToConfigDatabaseCdcOutput() ConfigDatabaseCdcOutput {
	return o
}

func (o ConfigDatabaseCdcOutput) ToConfigDatabaseCdcOutputWithContext(ctx context.Context) ConfigDatabaseCdcOutput {
	return o
}

// database name.
func (o ConfigDatabaseCdcOutput) DbName() pulumi.StringOutput {
	return o.ApplyT(func(v *ConfigDatabaseCdc) pulumi.StringOutput { return v.DbName }).(pulumi.StringOutput)
}

// Instance ID.
func (o ConfigDatabaseCdcOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *ConfigDatabaseCdc) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// Enable or disable CDC. Valid values: enable, disable.
func (o ConfigDatabaseCdcOutput) ModifyType() pulumi.StringOutput {
	return o.ApplyT(func(v *ConfigDatabaseCdc) pulumi.StringOutput { return v.ModifyType }).(pulumi.StringOutput)
}

type ConfigDatabaseCdcArrayOutput struct{ *pulumi.OutputState }

func (ConfigDatabaseCdcArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ConfigDatabaseCdc)(nil)).Elem()
}

func (o ConfigDatabaseCdcArrayOutput) ToConfigDatabaseCdcArrayOutput() ConfigDatabaseCdcArrayOutput {
	return o
}

func (o ConfigDatabaseCdcArrayOutput) ToConfigDatabaseCdcArrayOutputWithContext(ctx context.Context) ConfigDatabaseCdcArrayOutput {
	return o
}

func (o ConfigDatabaseCdcArrayOutput) Index(i pulumi.IntInput) ConfigDatabaseCdcOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ConfigDatabaseCdc {
		return vs[0].([]*ConfigDatabaseCdc)[vs[1].(int)]
	}).(ConfigDatabaseCdcOutput)
}

type ConfigDatabaseCdcMapOutput struct{ *pulumi.OutputState }

func (ConfigDatabaseCdcMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ConfigDatabaseCdc)(nil)).Elem()
}

func (o ConfigDatabaseCdcMapOutput) ToConfigDatabaseCdcMapOutput() ConfigDatabaseCdcMapOutput {
	return o
}

func (o ConfigDatabaseCdcMapOutput) ToConfigDatabaseCdcMapOutputWithContext(ctx context.Context) ConfigDatabaseCdcMapOutput {
	return o
}

func (o ConfigDatabaseCdcMapOutput) MapIndex(k pulumi.StringInput) ConfigDatabaseCdcOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ConfigDatabaseCdc {
		return vs[0].(map[string]*ConfigDatabaseCdc)[vs[1].(string)]
	}).(ConfigDatabaseCdcOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ConfigDatabaseCdcInput)(nil)).Elem(), &ConfigDatabaseCdc{})
	pulumi.RegisterInputType(reflect.TypeOf((*ConfigDatabaseCdcArrayInput)(nil)).Elem(), ConfigDatabaseCdcArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ConfigDatabaseCdcMapInput)(nil)).Elem(), ConfigDatabaseCdcMap{})
	pulumi.RegisterOutputType(ConfigDatabaseCdcOutput{})
	pulumi.RegisterOutputType(ConfigDatabaseCdcArrayOutput{})
	pulumi.RegisterOutputType(ConfigDatabaseCdcMapOutput{})
}
