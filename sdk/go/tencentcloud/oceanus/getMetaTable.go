// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package oceanus

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of oceanus metaTable
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Oceanus"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Oceanus.GetMetaTable(ctx, &oceanus.GetMetaTableArgs{
//				Catalog:     "_dc",
//				Database:    "_db",
//				Table:       "tf_table",
//				WorkSpaceId: "space-6w8eab6f",
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
func GetMetaTable(ctx *pulumi.Context, args *GetMetaTableArgs, opts ...pulumi.InvokeOption) (*GetMetaTableResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetMetaTableResult
	err := ctx.Invoke("tencentcloud:Oceanus/getMetaTable:getMetaTable", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMetaTable.
type GetMetaTableArgs struct {
	// Catalog name.
	Catalog string `pulumi:"catalog"`
	// Database name.
	Database string `pulumi:"database"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Table name.
	Table string `pulumi:"table"`
	// Unique identifier of the space.
	WorkSpaceId string `pulumi:"workSpaceId"`
}

// A collection of values returned by getMetaTable.
type GetMetaTableResult struct {
	Catalog string `pulumi:"catalog"`
	// Scene time.
	CreateTime string `pulumi:"createTime"`
	Database   string `pulumi:"database"`
	// Table creation statement, encoded in Base64.For example,Q1JFQVRFIFRBQkxFIGRhdGFnZW5fc291cmNlX3RhYmxlICggCiAgICBpZCBJTlQsIAogICAgbmFtZSBTVFJJTkcgCikgV0lUSCAoCidjb25uZWN0b3InPSdkYXRhZ2VuJywKJ3Jvd3MtcGVyLXNlY29uZCcgPSAnMScKKTs=.
	Ddl string `pulumi:"ddl"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Unique identifier of the metadata table.
	SerialId    string `pulumi:"serialId"`
	Table       string `pulumi:"table"`
	WorkSpaceId string `pulumi:"workSpaceId"`
}

func GetMetaTableOutput(ctx *pulumi.Context, args GetMetaTableOutputArgs, opts ...pulumi.InvokeOption) GetMetaTableResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetMetaTableResult, error) {
			args := v.(GetMetaTableArgs)
			r, err := GetMetaTable(ctx, &args, opts...)
			var s GetMetaTableResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetMetaTableResultOutput)
}

// A collection of arguments for invoking getMetaTable.
type GetMetaTableOutputArgs struct {
	// Catalog name.
	Catalog pulumi.StringInput `pulumi:"catalog"`
	// Database name.
	Database pulumi.StringInput `pulumi:"database"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Table name.
	Table pulumi.StringInput `pulumi:"table"`
	// Unique identifier of the space.
	WorkSpaceId pulumi.StringInput `pulumi:"workSpaceId"`
}

func (GetMetaTableOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetMetaTableArgs)(nil)).Elem()
}

// A collection of values returned by getMetaTable.
type GetMetaTableResultOutput struct{ *pulumi.OutputState }

func (GetMetaTableResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetMetaTableResult)(nil)).Elem()
}

func (o GetMetaTableResultOutput) ToGetMetaTableResultOutput() GetMetaTableResultOutput {
	return o
}

func (o GetMetaTableResultOutput) ToGetMetaTableResultOutputWithContext(ctx context.Context) GetMetaTableResultOutput {
	return o
}

func (o GetMetaTableResultOutput) Catalog() pulumi.StringOutput {
	return o.ApplyT(func(v GetMetaTableResult) string { return v.Catalog }).(pulumi.StringOutput)
}

// Scene time.
func (o GetMetaTableResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetMetaTableResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

func (o GetMetaTableResultOutput) Database() pulumi.StringOutput {
	return o.ApplyT(func(v GetMetaTableResult) string { return v.Database }).(pulumi.StringOutput)
}

// Table creation statement, encoded in Base64.For example,Q1JFQVRFIFRBQkxFIGRhdGFnZW5fc291cmNlX3RhYmxlICggCiAgICBpZCBJTlQsIAogICAgbmFtZSBTVFJJTkcgCikgV0lUSCAoCidjb25uZWN0b3InPSdkYXRhZ2VuJywKJ3Jvd3MtcGVyLXNlY29uZCcgPSAnMScKKTs=.
func (o GetMetaTableResultOutput) Ddl() pulumi.StringOutput {
	return o.ApplyT(func(v GetMetaTableResult) string { return v.Ddl }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetMetaTableResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetMetaTableResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetMetaTableResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMetaTableResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Unique identifier of the metadata table.
func (o GetMetaTableResultOutput) SerialId() pulumi.StringOutput {
	return o.ApplyT(func(v GetMetaTableResult) string { return v.SerialId }).(pulumi.StringOutput)
}

func (o GetMetaTableResultOutput) Table() pulumi.StringOutput {
	return o.ApplyT(func(v GetMetaTableResult) string { return v.Table }).(pulumi.StringOutput)
}

func (o GetMetaTableResultOutput) WorkSpaceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetMetaTableResult) string { return v.WorkSpaceId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetMetaTableResultOutput{})
}