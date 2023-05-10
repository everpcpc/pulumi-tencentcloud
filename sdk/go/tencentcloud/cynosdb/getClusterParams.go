// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cynosdb

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of cynosdb clusterParams
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Cynosdb"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cynosdb"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Cynosdb.GetClusterParams(ctx, &cynosdb.GetClusterParamsArgs{
// 			ClusterId: "cynosdbmysql-bws8h88b",
// 			ParamName: pulumi.StringRef("innodb_checksum_algorithm"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetClusterParams(ctx *pulumi.Context, args *GetClusterParamsArgs, opts ...pulumi.InvokeOption) (*GetClusterParamsResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetClusterParamsResult
	err := ctx.Invoke("tencentcloud:Cynosdb/getClusterParams:getClusterParams", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getClusterParams.
type GetClusterParamsArgs struct {
	// The ID of cluster.
	ClusterId string `pulumi:"clusterId"`
	// Parameter name.
	ParamName *string `pulumi:"paramName"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getClusterParams.
type GetClusterParamsResult struct {
	ClusterId string `pulumi:"clusterId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Instance parameter list. Note: This field may return null, indicating that no valid value can be obtained.
	Items []GetClusterParamsItem `pulumi:"items"`
	// The name of parameter.
	ParamName        *string `pulumi:"paramName"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetClusterParamsOutput(ctx *pulumi.Context, args GetClusterParamsOutputArgs, opts ...pulumi.InvokeOption) GetClusterParamsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetClusterParamsResult, error) {
			args := v.(GetClusterParamsArgs)
			r, err := GetClusterParams(ctx, &args, opts...)
			var s GetClusterParamsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetClusterParamsResultOutput)
}

// A collection of arguments for invoking getClusterParams.
type GetClusterParamsOutputArgs struct {
	// The ID of cluster.
	ClusterId pulumi.StringInput `pulumi:"clusterId"`
	// Parameter name.
	ParamName pulumi.StringPtrInput `pulumi:"paramName"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetClusterParamsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetClusterParamsArgs)(nil)).Elem()
}

// A collection of values returned by getClusterParams.
type GetClusterParamsResultOutput struct{ *pulumi.OutputState }

func (GetClusterParamsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetClusterParamsResult)(nil)).Elem()
}

func (o GetClusterParamsResultOutput) ToGetClusterParamsResultOutput() GetClusterParamsResultOutput {
	return o
}

func (o GetClusterParamsResultOutput) ToGetClusterParamsResultOutputWithContext(ctx context.Context) GetClusterParamsResultOutput {
	return o
}

func (o GetClusterParamsResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v GetClusterParamsResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetClusterParamsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetClusterParamsResult) string { return v.Id }).(pulumi.StringOutput)
}

// Instance parameter list. Note: This field may return null, indicating that no valid value can be obtained.
func (o GetClusterParamsResultOutput) Items() GetClusterParamsItemArrayOutput {
	return o.ApplyT(func(v GetClusterParamsResult) []GetClusterParamsItem { return v.Items }).(GetClusterParamsItemArrayOutput)
}

// The name of parameter.
func (o GetClusterParamsResultOutput) ParamName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetClusterParamsResult) *string { return v.ParamName }).(pulumi.StringPtrOutput)
}

func (o GetClusterParamsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetClusterParamsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetClusterParamsResultOutput{})
}