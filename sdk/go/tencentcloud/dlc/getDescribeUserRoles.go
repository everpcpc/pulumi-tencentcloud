// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dlc

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of dlc describeUserRoles
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
//			_, err := Dlc.GetDescribeUserRoles(ctx, &dlc.GetDescribeUserRolesArgs{
//				Fuzzy: pulumi.StringRef("1"),
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
func GetDescribeUserRoles(ctx *pulumi.Context, args *GetDescribeUserRolesArgs, opts ...pulumi.InvokeOption) (*GetDescribeUserRolesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetDescribeUserRolesResult
	err := ctx.Invoke("tencentcloud:Dlc/getDescribeUserRoles:getDescribeUserRoles", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getDescribeUserRoles.
type GetDescribeUserRolesArgs struct {
	// List according to ARN blur.
	Fuzzy *string `pulumi:"fuzzy"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// The return results are sorted according to this field.
	SortBy *string `pulumi:"sortBy"`
	// Positive or inverted, such as DESC.
	Sorting *string `pulumi:"sorting"`
}

// A collection of values returned by getDescribeUserRoles.
type GetDescribeUserRolesResult struct {
	Fuzzy *string `pulumi:"fuzzy"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	SortBy           *string `pulumi:"sortBy"`
	Sorting          *string `pulumi:"sorting"`
	// User role information.
	UserRoles []GetDescribeUserRolesUserRole `pulumi:"userRoles"`
}

func GetDescribeUserRolesOutput(ctx *pulumi.Context, args GetDescribeUserRolesOutputArgs, opts ...pulumi.InvokeOption) GetDescribeUserRolesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetDescribeUserRolesResult, error) {
			args := v.(GetDescribeUserRolesArgs)
			r, err := GetDescribeUserRoles(ctx, &args, opts...)
			var s GetDescribeUserRolesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetDescribeUserRolesResultOutput)
}

// A collection of arguments for invoking getDescribeUserRoles.
type GetDescribeUserRolesOutputArgs struct {
	// List according to ARN blur.
	Fuzzy pulumi.StringPtrInput `pulumi:"fuzzy"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// The return results are sorted according to this field.
	SortBy pulumi.StringPtrInput `pulumi:"sortBy"`
	// Positive or inverted, such as DESC.
	Sorting pulumi.StringPtrInput `pulumi:"sorting"`
}

func (GetDescribeUserRolesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDescribeUserRolesArgs)(nil)).Elem()
}

// A collection of values returned by getDescribeUserRoles.
type GetDescribeUserRolesResultOutput struct{ *pulumi.OutputState }

func (GetDescribeUserRolesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDescribeUserRolesResult)(nil)).Elem()
}

func (o GetDescribeUserRolesResultOutput) ToGetDescribeUserRolesResultOutput() GetDescribeUserRolesResultOutput {
	return o
}

func (o GetDescribeUserRolesResultOutput) ToGetDescribeUserRolesResultOutputWithContext(ctx context.Context) GetDescribeUserRolesResultOutput {
	return o
}

func (o GetDescribeUserRolesResultOutput) Fuzzy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetDescribeUserRolesResult) *string { return v.Fuzzy }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetDescribeUserRolesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetDescribeUserRolesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetDescribeUserRolesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetDescribeUserRolesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetDescribeUserRolesResultOutput) SortBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetDescribeUserRolesResult) *string { return v.SortBy }).(pulumi.StringPtrOutput)
}

func (o GetDescribeUserRolesResultOutput) Sorting() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetDescribeUserRolesResult) *string { return v.Sorting }).(pulumi.StringPtrOutput)
}

// User role information.
func (o GetDescribeUserRolesResultOutput) UserRoles() GetDescribeUserRolesUserRoleArrayOutput {
	return o.ApplyT(func(v GetDescribeUserRolesResult) []GetDescribeUserRolesUserRole { return v.UserRoles }).(GetDescribeUserRolesUserRoleArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetDescribeUserRolesResultOutput{})
}