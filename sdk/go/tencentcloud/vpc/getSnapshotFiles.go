// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vpc

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of vpc snapshotFiles
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
//			_, err := Vpc.GetSnapshotFiles(ctx, &vpc.GetSnapshotFilesArgs{
//				BusinessType: "securitygroup",
//				EndDate:      "2023-10-30 19:00:00",
//				InstanceId:   "sg-902tl7t7",
//				StartDate:    "2022-10-10 00:00:00",
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
func GetSnapshotFiles(ctx *pulumi.Context, args *GetSnapshotFilesArgs, opts ...pulumi.InvokeOption) (*GetSnapshotFilesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetSnapshotFilesResult
	err := ctx.Invoke("tencentcloud:Vpc/getSnapshotFiles:getSnapshotFiles", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSnapshotFiles.
type GetSnapshotFilesArgs struct {
	// Business type, currently supports security group:securitygroup.
	BusinessType string `pulumi:"businessType"`
	// End date in the format %Y-%m-%d %H:%M:%S.
	EndDate string `pulumi:"endDate"`
	// InstanceId.
	InstanceId string `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Start date in the format %Y-%m-%d %H:%M:%S.
	StartDate string `pulumi:"startDate"`
}

// A collection of values returned by getSnapshotFiles.
type GetSnapshotFilesResult struct {
	BusinessType string `pulumi:"businessType"`
	EndDate      string `pulumi:"endDate"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// instance id.
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// snap shot file set.
	SnapshotFileSets []GetSnapshotFilesSnapshotFileSet `pulumi:"snapshotFileSets"`
	StartDate        string                            `pulumi:"startDate"`
}

func GetSnapshotFilesOutput(ctx *pulumi.Context, args GetSnapshotFilesOutputArgs, opts ...pulumi.InvokeOption) GetSnapshotFilesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetSnapshotFilesResult, error) {
			args := v.(GetSnapshotFilesArgs)
			r, err := GetSnapshotFiles(ctx, &args, opts...)
			var s GetSnapshotFilesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetSnapshotFilesResultOutput)
}

// A collection of arguments for invoking getSnapshotFiles.
type GetSnapshotFilesOutputArgs struct {
	// Business type, currently supports security group:securitygroup.
	BusinessType pulumi.StringInput `pulumi:"businessType"`
	// End date in the format %Y-%m-%d %H:%M:%S.
	EndDate pulumi.StringInput `pulumi:"endDate"`
	// InstanceId.
	InstanceId pulumi.StringInput `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Start date in the format %Y-%m-%d %H:%M:%S.
	StartDate pulumi.StringInput `pulumi:"startDate"`
}

func (GetSnapshotFilesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSnapshotFilesArgs)(nil)).Elem()
}

// A collection of values returned by getSnapshotFiles.
type GetSnapshotFilesResultOutput struct{ *pulumi.OutputState }

func (GetSnapshotFilesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSnapshotFilesResult)(nil)).Elem()
}

func (o GetSnapshotFilesResultOutput) ToGetSnapshotFilesResultOutput() GetSnapshotFilesResultOutput {
	return o
}

func (o GetSnapshotFilesResultOutput) ToGetSnapshotFilesResultOutputWithContext(ctx context.Context) GetSnapshotFilesResultOutput {
	return o
}

func (o GetSnapshotFilesResultOutput) BusinessType() pulumi.StringOutput {
	return o.ApplyT(func(v GetSnapshotFilesResult) string { return v.BusinessType }).(pulumi.StringOutput)
}

func (o GetSnapshotFilesResultOutput) EndDate() pulumi.StringOutput {
	return o.ApplyT(func(v GetSnapshotFilesResult) string { return v.EndDate }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetSnapshotFilesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetSnapshotFilesResult) string { return v.Id }).(pulumi.StringOutput)
}

// instance id.
func (o GetSnapshotFilesResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetSnapshotFilesResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetSnapshotFilesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSnapshotFilesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// snap shot file set.
func (o GetSnapshotFilesResultOutput) SnapshotFileSets() GetSnapshotFilesSnapshotFileSetArrayOutput {
	return o.ApplyT(func(v GetSnapshotFilesResult) []GetSnapshotFilesSnapshotFileSet { return v.SnapshotFileSets }).(GetSnapshotFilesSnapshotFileSetArrayOutput)
}

func (o GetSnapshotFilesResultOutput) StartDate() pulumi.StringOutput {
	return o.ApplyT(func(v GetSnapshotFilesResult) string { return v.StartDate }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSnapshotFilesResultOutput{})
}