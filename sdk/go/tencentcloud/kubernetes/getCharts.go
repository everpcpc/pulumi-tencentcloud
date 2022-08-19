// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package kubernetes

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of kubernetes cluster addons.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Kubernetes"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Kubernetes"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Kubernetes.GetCharts(ctx, nil, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetCharts(ctx *pulumi.Context, args *GetChartsArgs, opts ...pulumi.InvokeOption) (*GetChartsResult, error) {
	var rv GetChartsResult
	err := ctx.Invoke("tencentcloud:Kubernetes/getCharts:getCharts", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCharts.
type GetChartsArgs struct {
	// Operation system app supported. Available values: `arm32`, `arm64`, `amd64`.
	Arch *string `pulumi:"arch"`
	// Cluster type. Available values: `tke`, `eks`.
	ClusterType *string `pulumi:"clusterType"`
	// Kind of app chart. Available values: `log`, `scheduler`, `network`, `storage`, `monitor`, `dns`, `image`, `other`, `invisible`.
	Kind *string `pulumi:"kind"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getCharts.
type GetChartsResult struct {
	Arch *string `pulumi:"arch"`
	// App chart list.
	ChartLists  []GetChartsChartList `pulumi:"chartLists"`
	ClusterType *string              `pulumi:"clusterType"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	Kind             *string `pulumi:"kind"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetChartsOutput(ctx *pulumi.Context, args GetChartsOutputArgs, opts ...pulumi.InvokeOption) GetChartsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetChartsResult, error) {
			args := v.(GetChartsArgs)
			r, err := GetCharts(ctx, &args, opts...)
			var s GetChartsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetChartsResultOutput)
}

// A collection of arguments for invoking getCharts.
type GetChartsOutputArgs struct {
	// Operation system app supported. Available values: `arm32`, `arm64`, `amd64`.
	Arch pulumi.StringPtrInput `pulumi:"arch"`
	// Cluster type. Available values: `tke`, `eks`.
	ClusterType pulumi.StringPtrInput `pulumi:"clusterType"`
	// Kind of app chart. Available values: `log`, `scheduler`, `network`, `storage`, `monitor`, `dns`, `image`, `other`, `invisible`.
	Kind pulumi.StringPtrInput `pulumi:"kind"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetChartsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetChartsArgs)(nil)).Elem()
}

// A collection of values returned by getCharts.
type GetChartsResultOutput struct{ *pulumi.OutputState }

func (GetChartsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetChartsResult)(nil)).Elem()
}

func (o GetChartsResultOutput) ToGetChartsResultOutput() GetChartsResultOutput {
	return o
}

func (o GetChartsResultOutput) ToGetChartsResultOutputWithContext(ctx context.Context) GetChartsResultOutput {
	return o
}

func (o GetChartsResultOutput) Arch() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetChartsResult) *string { return v.Arch }).(pulumi.StringPtrOutput)
}

// App chart list.
func (o GetChartsResultOutput) ChartLists() GetChartsChartListArrayOutput {
	return o.ApplyT(func(v GetChartsResult) []GetChartsChartList { return v.ChartLists }).(GetChartsChartListArrayOutput)
}

func (o GetChartsResultOutput) ClusterType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetChartsResult) *string { return v.ClusterType }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetChartsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetChartsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetChartsResultOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetChartsResult) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o GetChartsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetChartsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetChartsResultOutput{})
}