// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vpc

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of vpc bandwidthPackageBillUsage
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Vpc.GetBandwidthPackageBillUsage(ctx, &vpc.GetBandwidthPackageBillUsageArgs{
//				BandwidthPackageId: "bwp-234rfgt5",
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
func GetBandwidthPackageBillUsage(ctx *pulumi.Context, args *GetBandwidthPackageBillUsageArgs, opts ...pulumi.InvokeOption) (*GetBandwidthPackageBillUsageResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetBandwidthPackageBillUsageResult
	err := ctx.Invoke("tencentcloud:Vpc/getBandwidthPackageBillUsage:getBandwidthPackageBillUsage", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBandwidthPackageBillUsage.
type GetBandwidthPackageBillUsageArgs struct {
	// The unique ID of the postpaid bandwidth package.
	BandwidthPackageId string `pulumi:"bandwidthPackageId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getBandwidthPackageBillUsage.
type GetBandwidthPackageBillUsageResult struct {
	// current billing amount.
	BandwidthPackageBillBandwidthSets []GetBandwidthPackageBillUsageBandwidthPackageBillBandwidthSet `pulumi:"bandwidthPackageBillBandwidthSets"`
	BandwidthPackageId                string                                                         `pulumi:"bandwidthPackageId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetBandwidthPackageBillUsageOutput(ctx *pulumi.Context, args GetBandwidthPackageBillUsageOutputArgs, opts ...pulumi.InvokeOption) GetBandwidthPackageBillUsageResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetBandwidthPackageBillUsageResult, error) {
			args := v.(GetBandwidthPackageBillUsageArgs)
			r, err := GetBandwidthPackageBillUsage(ctx, &args, opts...)
			var s GetBandwidthPackageBillUsageResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetBandwidthPackageBillUsageResultOutput)
}

// A collection of arguments for invoking getBandwidthPackageBillUsage.
type GetBandwidthPackageBillUsageOutputArgs struct {
	// The unique ID of the postpaid bandwidth package.
	BandwidthPackageId pulumi.StringInput `pulumi:"bandwidthPackageId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetBandwidthPackageBillUsageOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBandwidthPackageBillUsageArgs)(nil)).Elem()
}

// A collection of values returned by getBandwidthPackageBillUsage.
type GetBandwidthPackageBillUsageResultOutput struct{ *pulumi.OutputState }

func (GetBandwidthPackageBillUsageResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBandwidthPackageBillUsageResult)(nil)).Elem()
}

func (o GetBandwidthPackageBillUsageResultOutput) ToGetBandwidthPackageBillUsageResultOutput() GetBandwidthPackageBillUsageResultOutput {
	return o
}

func (o GetBandwidthPackageBillUsageResultOutput) ToGetBandwidthPackageBillUsageResultOutputWithContext(ctx context.Context) GetBandwidthPackageBillUsageResultOutput {
	return o
}

// current billing amount.
func (o GetBandwidthPackageBillUsageResultOutput) BandwidthPackageBillBandwidthSets() GetBandwidthPackageBillUsageBandwidthPackageBillBandwidthSetArrayOutput {
	return o.ApplyT(func(v GetBandwidthPackageBillUsageResult) []GetBandwidthPackageBillUsageBandwidthPackageBillBandwidthSet {
		return v.BandwidthPackageBillBandwidthSets
	}).(GetBandwidthPackageBillUsageBandwidthPackageBillBandwidthSetArrayOutput)
}

func (o GetBandwidthPackageBillUsageResultOutput) BandwidthPackageId() pulumi.StringOutput {
	return o.ApplyT(func(v GetBandwidthPackageBillUsageResult) string { return v.BandwidthPackageId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetBandwidthPackageBillUsageResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetBandwidthPackageBillUsageResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetBandwidthPackageBillUsageResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBandwidthPackageBillUsageResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetBandwidthPackageBillUsageResultOutput{})
}