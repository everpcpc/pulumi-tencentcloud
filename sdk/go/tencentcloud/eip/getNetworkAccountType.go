// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package eip

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of eip networkAccountType
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Eip"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Eip.GetNetworkAccountType(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func GetNetworkAccountType(ctx *pulumi.Context, args *GetNetworkAccountTypeArgs, opts ...pulumi.InvokeOption) (*GetNetworkAccountTypeResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetNetworkAccountTypeResult
	err := ctx.Invoke("tencentcloud:Eip/getNetworkAccountType:getNetworkAccountType", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getNetworkAccountType.
type GetNetworkAccountTypeArgs struct {
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getNetworkAccountType.
type GetNetworkAccountTypeResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The network type of the user account, STANDARD is a standard user, LEGACY is a traditional user.
	NetworkAccountType string  `pulumi:"networkAccountType"`
	ResultOutputFile   *string `pulumi:"resultOutputFile"`
}

func GetNetworkAccountTypeOutput(ctx *pulumi.Context, args GetNetworkAccountTypeOutputArgs, opts ...pulumi.InvokeOption) GetNetworkAccountTypeResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetNetworkAccountTypeResult, error) {
			args := v.(GetNetworkAccountTypeArgs)
			r, err := GetNetworkAccountType(ctx, &args, opts...)
			var s GetNetworkAccountTypeResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetNetworkAccountTypeResultOutput)
}

// A collection of arguments for invoking getNetworkAccountType.
type GetNetworkAccountTypeOutputArgs struct {
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetNetworkAccountTypeOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetNetworkAccountTypeArgs)(nil)).Elem()
}

// A collection of values returned by getNetworkAccountType.
type GetNetworkAccountTypeResultOutput struct{ *pulumi.OutputState }

func (GetNetworkAccountTypeResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetNetworkAccountTypeResult)(nil)).Elem()
}

func (o GetNetworkAccountTypeResultOutput) ToGetNetworkAccountTypeResultOutput() GetNetworkAccountTypeResultOutput {
	return o
}

func (o GetNetworkAccountTypeResultOutput) ToGetNetworkAccountTypeResultOutputWithContext(ctx context.Context) GetNetworkAccountTypeResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetNetworkAccountTypeResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetNetworkAccountTypeResult) string { return v.Id }).(pulumi.StringOutput)
}

// The network type of the user account, STANDARD is a standard user, LEGACY is a traditional user.
func (o GetNetworkAccountTypeResultOutput) NetworkAccountType() pulumi.StringOutput {
	return o.ApplyT(func(v GetNetworkAccountTypeResult) string { return v.NetworkAccountType }).(pulumi.StringOutput)
}

func (o GetNetworkAccountTypeResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetNetworkAccountTypeResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetNetworkAccountTypeResultOutput{})
}
