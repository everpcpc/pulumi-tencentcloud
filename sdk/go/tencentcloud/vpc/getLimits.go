// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vpc

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of vpc limits
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
//			_, err := Vpc.GetLimits(ctx, &vpc.GetLimitsArgs{
//				LimitTypes: []string{
//					"appid-max-vpcs",
//					"vpc-max-subnets",
//				},
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
func GetLimits(ctx *pulumi.Context, args *GetLimitsArgs, opts ...pulumi.InvokeOption) (*GetLimitsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetLimitsResult
	err := ctx.Invoke("tencentcloud:Vpc/getLimits:getLimits", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getLimits.
type GetLimitsArgs struct {
	// Quota name. A maximum of 100 quota types can be queried each time.
	LimitTypes []string `pulumi:"limitTypes"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getLimits.
type GetLimitsResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id               string   `pulumi:"id"`
	LimitTypes       []string `pulumi:"limitTypes"`
	ResultOutputFile *string  `pulumi:"resultOutputFile"`
	// vpc limit.
	VpcLimitSets []GetLimitsVpcLimitSet `pulumi:"vpcLimitSets"`
}

func GetLimitsOutput(ctx *pulumi.Context, args GetLimitsOutputArgs, opts ...pulumi.InvokeOption) GetLimitsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetLimitsResult, error) {
			args := v.(GetLimitsArgs)
			r, err := GetLimits(ctx, &args, opts...)
			var s GetLimitsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetLimitsResultOutput)
}

// A collection of arguments for invoking getLimits.
type GetLimitsOutputArgs struct {
	// Quota name. A maximum of 100 quota types can be queried each time.
	LimitTypes pulumi.StringArrayInput `pulumi:"limitTypes"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetLimitsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetLimitsArgs)(nil)).Elem()
}

// A collection of values returned by getLimits.
type GetLimitsResultOutput struct{ *pulumi.OutputState }

func (GetLimitsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetLimitsResult)(nil)).Elem()
}

func (o GetLimitsResultOutput) ToGetLimitsResultOutput() GetLimitsResultOutput {
	return o
}

func (o GetLimitsResultOutput) ToGetLimitsResultOutputWithContext(ctx context.Context) GetLimitsResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetLimitsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetLimitsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetLimitsResultOutput) LimitTypes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetLimitsResult) []string { return v.LimitTypes }).(pulumi.StringArrayOutput)
}

func (o GetLimitsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetLimitsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// vpc limit.
func (o GetLimitsResultOutput) VpcLimitSets() GetLimitsVpcLimitSetArrayOutput {
	return o.ApplyT(func(v GetLimitsResult) []GetLimitsVpcLimitSet { return v.VpcLimitSets }).(GetLimitsVpcLimitSetArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetLimitsResultOutput{})
}