// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vpc

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of vpc securityGroupReferences
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
//			_, err := Vpc.GetSecurityGroupReferences(ctx, &vpc.GetSecurityGroupReferencesArgs{
//				SecurityGroupIds: []string{
//					"sg-edmur627",
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
func GetSecurityGroupReferences(ctx *pulumi.Context, args *GetSecurityGroupReferencesArgs, opts ...pulumi.InvokeOption) (*GetSecurityGroupReferencesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetSecurityGroupReferencesResult
	err := ctx.Invoke("tencentcloud:Vpc/getSecurityGroupReferences:getSecurityGroupReferences", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSecurityGroupReferences.
type GetSecurityGroupReferencesArgs struct {
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// A set of security group instance IDs, e.g. [sg-12345678].
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
}

// A collection of values returned by getSecurityGroupReferences.
type GetSecurityGroupReferencesResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Referred security groups.
	ReferredSecurityGroupSets []GetSecurityGroupReferencesReferredSecurityGroupSet `pulumi:"referredSecurityGroupSets"`
	ResultOutputFile          *string                                              `pulumi:"resultOutputFile"`
	SecurityGroupIds          []string                                             `pulumi:"securityGroupIds"`
}

func GetSecurityGroupReferencesOutput(ctx *pulumi.Context, args GetSecurityGroupReferencesOutputArgs, opts ...pulumi.InvokeOption) GetSecurityGroupReferencesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetSecurityGroupReferencesResult, error) {
			args := v.(GetSecurityGroupReferencesArgs)
			r, err := GetSecurityGroupReferences(ctx, &args, opts...)
			var s GetSecurityGroupReferencesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetSecurityGroupReferencesResultOutput)
}

// A collection of arguments for invoking getSecurityGroupReferences.
type GetSecurityGroupReferencesOutputArgs struct {
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// A set of security group instance IDs, e.g. [sg-12345678].
	SecurityGroupIds pulumi.StringArrayInput `pulumi:"securityGroupIds"`
}

func (GetSecurityGroupReferencesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSecurityGroupReferencesArgs)(nil)).Elem()
}

// A collection of values returned by getSecurityGroupReferences.
type GetSecurityGroupReferencesResultOutput struct{ *pulumi.OutputState }

func (GetSecurityGroupReferencesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSecurityGroupReferencesResult)(nil)).Elem()
}

func (o GetSecurityGroupReferencesResultOutput) ToGetSecurityGroupReferencesResultOutput() GetSecurityGroupReferencesResultOutput {
	return o
}

func (o GetSecurityGroupReferencesResultOutput) ToGetSecurityGroupReferencesResultOutputWithContext(ctx context.Context) GetSecurityGroupReferencesResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetSecurityGroupReferencesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetSecurityGroupReferencesResult) string { return v.Id }).(pulumi.StringOutput)
}

// Referred security groups.
func (o GetSecurityGroupReferencesResultOutput) ReferredSecurityGroupSets() GetSecurityGroupReferencesReferredSecurityGroupSetArrayOutput {
	return o.ApplyT(func(v GetSecurityGroupReferencesResult) []GetSecurityGroupReferencesReferredSecurityGroupSet {
		return v.ReferredSecurityGroupSets
	}).(GetSecurityGroupReferencesReferredSecurityGroupSetArrayOutput)
}

func (o GetSecurityGroupReferencesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSecurityGroupReferencesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetSecurityGroupReferencesResultOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetSecurityGroupReferencesResult) []string { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSecurityGroupReferencesResultOutput{})
}