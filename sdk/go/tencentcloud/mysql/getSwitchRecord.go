// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mysql

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of mysql switchRecord
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Mysql.GetSwitchRecord(ctx, &mysql.GetSwitchRecordArgs{
//				InstanceId: "cdb-fitq5t9h",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func GetSwitchRecord(ctx *pulumi.Context, args *GetSwitchRecordArgs, opts ...pulumi.InvokeOption) (*GetSwitchRecordResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetSwitchRecordResult
	err := ctx.Invoke("tencentcloud:Mysql/getSwitchRecord:getSwitchRecord", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSwitchRecord.
type GetSwitchRecordArgs struct {
	// Instance ID, the format is: cdb-c1nl9rpv or cdbro-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page.
	InstanceId string `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getSwitchRecord.
type GetSwitchRecordResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id         string `pulumi:"id"`
	InstanceId string `pulumi:"instanceId"`
	// Instance switching record details.
	Items            []GetSwitchRecordItem `pulumi:"items"`
	ResultOutputFile *string               `pulumi:"resultOutputFile"`
}

func GetSwitchRecordOutput(ctx *pulumi.Context, args GetSwitchRecordOutputArgs, opts ...pulumi.InvokeOption) GetSwitchRecordResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetSwitchRecordResult, error) {
			args := v.(GetSwitchRecordArgs)
			r, err := GetSwitchRecord(ctx, &args, opts...)
			var s GetSwitchRecordResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetSwitchRecordResultOutput)
}

// A collection of arguments for invoking getSwitchRecord.
type GetSwitchRecordOutputArgs struct {
	// Instance ID, the format is: cdb-c1nl9rpv or cdbro-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page.
	InstanceId pulumi.StringInput `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetSwitchRecordOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSwitchRecordArgs)(nil)).Elem()
}

// A collection of values returned by getSwitchRecord.
type GetSwitchRecordResultOutput struct{ *pulumi.OutputState }

func (GetSwitchRecordResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSwitchRecordResult)(nil)).Elem()
}

func (o GetSwitchRecordResultOutput) ToGetSwitchRecordResultOutput() GetSwitchRecordResultOutput {
	return o
}

func (o GetSwitchRecordResultOutput) ToGetSwitchRecordResultOutputWithContext(ctx context.Context) GetSwitchRecordResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetSwitchRecordResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetSwitchRecordResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetSwitchRecordResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetSwitchRecordResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

// Instance switching record details.
func (o GetSwitchRecordResultOutput) Items() GetSwitchRecordItemArrayOutput {
	return o.ApplyT(func(v GetSwitchRecordResult) []GetSwitchRecordItem { return v.Items }).(GetSwitchRecordItemArrayOutput)
}

func (o GetSwitchRecordResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSwitchRecordResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSwitchRecordResultOutput{})
}