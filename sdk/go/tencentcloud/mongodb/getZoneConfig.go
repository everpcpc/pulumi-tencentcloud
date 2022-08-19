// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mongodb

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query the available mongodb specifications for different zone.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Mongodb"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mongodb"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Mongodb.GetZoneConfig(ctx, &mongodb.GetZoneConfigArgs{
// 			AvailableZone: pulumi.StringRef("ap-guangzhou-2"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetZoneConfig(ctx *pulumi.Context, args *GetZoneConfigArgs, opts ...pulumi.InvokeOption) (*GetZoneConfigResult, error) {
	var rv GetZoneConfigResult
	err := ctx.Invoke("tencentcloud:Mongodb/getZoneConfig:getZoneConfig", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getZoneConfig.
type GetZoneConfigArgs struct {
	// The available zone of the Mongodb.
	AvailableZone *string `pulumi:"availableZone"`
	// Used to store results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getZoneConfig.
type GetZoneConfigResult struct {
	// The available zone of the Mongodb.
	AvailableZone *string `pulumi:"availableZone"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// A list of zone config. Each element contains the following attributes:
	Lists            []GetZoneConfigList `pulumi:"lists"`
	ResultOutputFile *string             `pulumi:"resultOutputFile"`
}

func GetZoneConfigOutput(ctx *pulumi.Context, args GetZoneConfigOutputArgs, opts ...pulumi.InvokeOption) GetZoneConfigResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetZoneConfigResult, error) {
			args := v.(GetZoneConfigArgs)
			r, err := GetZoneConfig(ctx, &args, opts...)
			var s GetZoneConfigResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetZoneConfigResultOutput)
}

// A collection of arguments for invoking getZoneConfig.
type GetZoneConfigOutputArgs struct {
	// The available zone of the Mongodb.
	AvailableZone pulumi.StringPtrInput `pulumi:"availableZone"`
	// Used to store results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetZoneConfigOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetZoneConfigArgs)(nil)).Elem()
}

// A collection of values returned by getZoneConfig.
type GetZoneConfigResultOutput struct{ *pulumi.OutputState }

func (GetZoneConfigResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetZoneConfigResult)(nil)).Elem()
}

func (o GetZoneConfigResultOutput) ToGetZoneConfigResultOutput() GetZoneConfigResultOutput {
	return o
}

func (o GetZoneConfigResultOutput) ToGetZoneConfigResultOutputWithContext(ctx context.Context) GetZoneConfigResultOutput {
	return o
}

// The available zone of the Mongodb.
func (o GetZoneConfigResultOutput) AvailableZone() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetZoneConfigResult) *string { return v.AvailableZone }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetZoneConfigResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetZoneConfigResult) string { return v.Id }).(pulumi.StringOutput)
}

// A list of zone config. Each element contains the following attributes:
func (o GetZoneConfigResultOutput) Lists() GetZoneConfigListArrayOutput {
	return o.ApplyT(func(v GetZoneConfigResult) []GetZoneConfigList { return v.Lists }).(GetZoneConfigListArrayOutput)
}

func (o GetZoneConfigResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetZoneConfigResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetZoneConfigResultOutput{})
}