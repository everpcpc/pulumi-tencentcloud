// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package clb

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of clb targetGroupList
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Clb"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Clb.GetTargetGroupList(ctx, &clb.GetTargetGroupListArgs{
//				Filters: []clb.GetTargetGroupListFilter{
//					{
//						Name: "TargetGroupName",
//						Values: []string{
//							"keep-tgg",
//						},
//					},
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
func GetTargetGroupList(ctx *pulumi.Context, args *GetTargetGroupListArgs, opts ...pulumi.InvokeOption) (*GetTargetGroupListResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetTargetGroupListResult
	err := ctx.Invoke("tencentcloud:Clb/getTargetGroupList:getTargetGroupList", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTargetGroupList.
type GetTargetGroupListArgs struct {
	// Filter array, which is exclusive of TargetGroupIds. Valid values: TargetGroupVpcId and TargetGroupName. Target group ID will be used first.
	Filters []GetTargetGroupListFilter `pulumi:"filters"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Target group ID array.
	TargetGroupIds []string `pulumi:"targetGroupIds"`
}

// A collection of values returned by getTargetGroupList.
type GetTargetGroupListResult struct {
	Filters []GetTargetGroupListFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id               string   `pulumi:"id"`
	ResultOutputFile *string  `pulumi:"resultOutputFile"`
	TargetGroupIds   []string `pulumi:"targetGroupIds"`
	// Information set of displayed target groups.
	TargetGroupSets []GetTargetGroupListTargetGroupSet `pulumi:"targetGroupSets"`
}

func GetTargetGroupListOutput(ctx *pulumi.Context, args GetTargetGroupListOutputArgs, opts ...pulumi.InvokeOption) GetTargetGroupListResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetTargetGroupListResult, error) {
			args := v.(GetTargetGroupListArgs)
			r, err := GetTargetGroupList(ctx, &args, opts...)
			var s GetTargetGroupListResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetTargetGroupListResultOutput)
}

// A collection of arguments for invoking getTargetGroupList.
type GetTargetGroupListOutputArgs struct {
	// Filter array, which is exclusive of TargetGroupIds. Valid values: TargetGroupVpcId and TargetGroupName. Target group ID will be used first.
	Filters GetTargetGroupListFilterArrayInput `pulumi:"filters"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Target group ID array.
	TargetGroupIds pulumi.StringArrayInput `pulumi:"targetGroupIds"`
}

func (GetTargetGroupListOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTargetGroupListArgs)(nil)).Elem()
}

// A collection of values returned by getTargetGroupList.
type GetTargetGroupListResultOutput struct{ *pulumi.OutputState }

func (GetTargetGroupListResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTargetGroupListResult)(nil)).Elem()
}

func (o GetTargetGroupListResultOutput) ToGetTargetGroupListResultOutput() GetTargetGroupListResultOutput {
	return o
}

func (o GetTargetGroupListResultOutput) ToGetTargetGroupListResultOutputWithContext(ctx context.Context) GetTargetGroupListResultOutput {
	return o
}

func (o GetTargetGroupListResultOutput) Filters() GetTargetGroupListFilterArrayOutput {
	return o.ApplyT(func(v GetTargetGroupListResult) []GetTargetGroupListFilter { return v.Filters }).(GetTargetGroupListFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetTargetGroupListResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetTargetGroupListResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetTargetGroupListResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetTargetGroupListResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetTargetGroupListResultOutput) TargetGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetTargetGroupListResult) []string { return v.TargetGroupIds }).(pulumi.StringArrayOutput)
}

// Information set of displayed target groups.
func (o GetTargetGroupListResultOutput) TargetGroupSets() GetTargetGroupListTargetGroupSetArrayOutput {
	return o.ApplyT(func(v GetTargetGroupListResult) []GetTargetGroupListTargetGroupSet { return v.TargetGroupSets }).(GetTargetGroupListTargetGroupSetArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetTargetGroupListResultOutput{})
}