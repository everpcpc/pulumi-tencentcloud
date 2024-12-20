// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dlc

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of dlc checkDataEngineConfigPairsValidity
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dlc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Dlc.GetCheckDataEngineConfigPairsValidity(ctx, &dlc.GetCheckDataEngineConfigPairsValidityArgs{
//				ChildImageVersionId: pulumi.StringRef("d3ftghd4-9a7e-4f64-a3f4-f38507c69742"),
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
func GetCheckDataEngineConfigPairsValidity(ctx *pulumi.Context, args *GetCheckDataEngineConfigPairsValidityArgs, opts ...pulumi.InvokeOption) (*GetCheckDataEngineConfigPairsValidityResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetCheckDataEngineConfigPairsValidityResult
	err := ctx.Invoke("tencentcloud:Dlc/getCheckDataEngineConfigPairsValidity:getCheckDataEngineConfigPairsValidity", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCheckDataEngineConfigPairsValidity.
type GetCheckDataEngineConfigPairsValidityArgs struct {
	// Engine Image version id.
	ChildImageVersionId *string `pulumi:"childImageVersionId"`
	// User-defined parameters.
	DataEngineConfigPairs []GetCheckDataEngineConfigPairsValidityDataEngineConfigPair `pulumi:"dataEngineConfigPairs"`
	// Engine major version id. If a minor version id exists, you only need to pass in the minor version id. If it does not exist, the latest minor version id under the current major version will be obtained.
	ImageVersionId *string `pulumi:"imageVersionId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getCheckDataEngineConfigPairsValidity.
type GetCheckDataEngineConfigPairsValidityResult struct {
	ChildImageVersionId   *string                                                     `pulumi:"childImageVersionId"`
	DataEngineConfigPairs []GetCheckDataEngineConfigPairsValidityDataEngineConfigPair `pulumi:"dataEngineConfigPairs"`
	// The provider-assigned unique ID for this managed resource.
	Id             string  `pulumi:"id"`
	ImageVersionId *string `pulumi:"imageVersionId"`
	// Parameter validity: true: valid, false: at least one invalid parameter exists.
	IsAvailable      bool    `pulumi:"isAvailable"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Invalid parameter set.
	UnavailableConfigs []string `pulumi:"unavailableConfigs"`
}

func GetCheckDataEngineConfigPairsValidityOutput(ctx *pulumi.Context, args GetCheckDataEngineConfigPairsValidityOutputArgs, opts ...pulumi.InvokeOption) GetCheckDataEngineConfigPairsValidityResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetCheckDataEngineConfigPairsValidityResult, error) {
			args := v.(GetCheckDataEngineConfigPairsValidityArgs)
			r, err := GetCheckDataEngineConfigPairsValidity(ctx, &args, opts...)
			var s GetCheckDataEngineConfigPairsValidityResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetCheckDataEngineConfigPairsValidityResultOutput)
}

// A collection of arguments for invoking getCheckDataEngineConfigPairsValidity.
type GetCheckDataEngineConfigPairsValidityOutputArgs struct {
	// Engine Image version id.
	ChildImageVersionId pulumi.StringPtrInput `pulumi:"childImageVersionId"`
	// User-defined parameters.
	DataEngineConfigPairs GetCheckDataEngineConfigPairsValidityDataEngineConfigPairArrayInput `pulumi:"dataEngineConfigPairs"`
	// Engine major version id. If a minor version id exists, you only need to pass in the minor version id. If it does not exist, the latest minor version id under the current major version will be obtained.
	ImageVersionId pulumi.StringPtrInput `pulumi:"imageVersionId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetCheckDataEngineConfigPairsValidityOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetCheckDataEngineConfigPairsValidityArgs)(nil)).Elem()
}

// A collection of values returned by getCheckDataEngineConfigPairsValidity.
type GetCheckDataEngineConfigPairsValidityResultOutput struct{ *pulumi.OutputState }

func (GetCheckDataEngineConfigPairsValidityResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetCheckDataEngineConfigPairsValidityResult)(nil)).Elem()
}

func (o GetCheckDataEngineConfigPairsValidityResultOutput) ToGetCheckDataEngineConfigPairsValidityResultOutput() GetCheckDataEngineConfigPairsValidityResultOutput {
	return o
}

func (o GetCheckDataEngineConfigPairsValidityResultOutput) ToGetCheckDataEngineConfigPairsValidityResultOutputWithContext(ctx context.Context) GetCheckDataEngineConfigPairsValidityResultOutput {
	return o
}

func (o GetCheckDataEngineConfigPairsValidityResultOutput) ChildImageVersionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetCheckDataEngineConfigPairsValidityResult) *string { return v.ChildImageVersionId }).(pulumi.StringPtrOutput)
}

func (o GetCheckDataEngineConfigPairsValidityResultOutput) DataEngineConfigPairs() GetCheckDataEngineConfigPairsValidityDataEngineConfigPairArrayOutput {
	return o.ApplyT(func(v GetCheckDataEngineConfigPairsValidityResult) []GetCheckDataEngineConfigPairsValidityDataEngineConfigPair {
		return v.DataEngineConfigPairs
	}).(GetCheckDataEngineConfigPairsValidityDataEngineConfigPairArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetCheckDataEngineConfigPairsValidityResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetCheckDataEngineConfigPairsValidityResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetCheckDataEngineConfigPairsValidityResultOutput) ImageVersionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetCheckDataEngineConfigPairsValidityResult) *string { return v.ImageVersionId }).(pulumi.StringPtrOutput)
}

// Parameter validity: true: valid, false: at least one invalid parameter exists.
func (o GetCheckDataEngineConfigPairsValidityResultOutput) IsAvailable() pulumi.BoolOutput {
	return o.ApplyT(func(v GetCheckDataEngineConfigPairsValidityResult) bool { return v.IsAvailable }).(pulumi.BoolOutput)
}

func (o GetCheckDataEngineConfigPairsValidityResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetCheckDataEngineConfigPairsValidityResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Invalid parameter set.
func (o GetCheckDataEngineConfigPairsValidityResultOutput) UnavailableConfigs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetCheckDataEngineConfigPairsValidityResult) []string { return v.UnavailableConfigs }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetCheckDataEngineConfigPairsValidityResultOutput{})
}
