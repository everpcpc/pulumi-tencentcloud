// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package kms

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of kms listAlgorithms
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Kms"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Kms.GetListAlgorithms(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func GetListAlgorithms(ctx *pulumi.Context, args *GetListAlgorithmsArgs, opts ...pulumi.InvokeOption) (*GetListAlgorithmsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetListAlgorithmsResult
	err := ctx.Invoke("tencentcloud:Kms/getListAlgorithms:getListAlgorithms", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getListAlgorithms.
type GetListAlgorithmsArgs struct {
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getListAlgorithms.
type GetListAlgorithmsResult struct {
	// Asymmetric encryption algorithms supported in this region.
	AsymmetricAlgorithms []GetListAlgorithmsAsymmetricAlgorithm `pulumi:"asymmetricAlgorithms"`
	// Asymmetric signature verification algorithms supported in this region.
	AsymmetricSignVerifyAlgorithms []GetListAlgorithmsAsymmetricSignVerifyAlgorithm `pulumi:"asymmetricSignVerifyAlgorithms"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Symmetric encryption algorithms supported in this region.
	SymmetricAlgorithms []GetListAlgorithmsSymmetricAlgorithm `pulumi:"symmetricAlgorithms"`
}

func GetListAlgorithmsOutput(ctx *pulumi.Context, args GetListAlgorithmsOutputArgs, opts ...pulumi.InvokeOption) GetListAlgorithmsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetListAlgorithmsResult, error) {
			args := v.(GetListAlgorithmsArgs)
			r, err := GetListAlgorithms(ctx, &args, opts...)
			var s GetListAlgorithmsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetListAlgorithmsResultOutput)
}

// A collection of arguments for invoking getListAlgorithms.
type GetListAlgorithmsOutputArgs struct {
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetListAlgorithmsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetListAlgorithmsArgs)(nil)).Elem()
}

// A collection of values returned by getListAlgorithms.
type GetListAlgorithmsResultOutput struct{ *pulumi.OutputState }

func (GetListAlgorithmsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetListAlgorithmsResult)(nil)).Elem()
}

func (o GetListAlgorithmsResultOutput) ToGetListAlgorithmsResultOutput() GetListAlgorithmsResultOutput {
	return o
}

func (o GetListAlgorithmsResultOutput) ToGetListAlgorithmsResultOutputWithContext(ctx context.Context) GetListAlgorithmsResultOutput {
	return o
}

// Asymmetric encryption algorithms supported in this region.
func (o GetListAlgorithmsResultOutput) AsymmetricAlgorithms() GetListAlgorithmsAsymmetricAlgorithmArrayOutput {
	return o.ApplyT(func(v GetListAlgorithmsResult) []GetListAlgorithmsAsymmetricAlgorithm { return v.AsymmetricAlgorithms }).(GetListAlgorithmsAsymmetricAlgorithmArrayOutput)
}

// Asymmetric signature verification algorithms supported in this region.
func (o GetListAlgorithmsResultOutput) AsymmetricSignVerifyAlgorithms() GetListAlgorithmsAsymmetricSignVerifyAlgorithmArrayOutput {
	return o.ApplyT(func(v GetListAlgorithmsResult) []GetListAlgorithmsAsymmetricSignVerifyAlgorithm {
		return v.AsymmetricSignVerifyAlgorithms
	}).(GetListAlgorithmsAsymmetricSignVerifyAlgorithmArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetListAlgorithmsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetListAlgorithmsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetListAlgorithmsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetListAlgorithmsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Symmetric encryption algorithms supported in this region.
func (o GetListAlgorithmsResultOutput) SymmetricAlgorithms() GetListAlgorithmsSymmetricAlgorithmArrayOutput {
	return o.ApplyT(func(v GetListAlgorithmsResult) []GetListAlgorithmsSymmetricAlgorithm { return v.SymmetricAlgorithms }).(GetListAlgorithmsSymmetricAlgorithmArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetListAlgorithmsResultOutput{})
}
