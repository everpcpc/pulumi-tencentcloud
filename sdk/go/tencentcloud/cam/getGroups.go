// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cam

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of CAM groups
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Cam"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cam"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Cam.GetGroups(ctx, &cam.GetGroupsArgs{
// 			GroupId: pulumi.StringRef(tencentcloud_cam_group.Foo.Id),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = Cam.GetGroups(ctx, &cam.GetGroupsArgs{
// 			Name: pulumi.StringRef("cam-group-test"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetGroups(ctx *pulumi.Context, args *GetGroupsArgs, opts ...pulumi.InvokeOption) (*GetGroupsResult, error) {
	var rv GetGroupsResult
	err := ctx.Invoke("tencentcloud:Cam/getGroups:getGroups", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getGroups.
type GetGroupsArgs struct {
	// ID of CAM group to be queried.
	GroupId *string `pulumi:"groupId"`
	// Name of the CAM group to be queried.
	Name *string `pulumi:"name"`
	// Description of the cam group to be queried.
	Remark *string `pulumi:"remark"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getGroups.
type GetGroupsResult struct {
	// ID of the CAM group.
	GroupId *string `pulumi:"groupId"`
	// A list of CAM groups. Each element contains the following attributes:
	GroupLists []GetGroupsGroupList `pulumi:"groupLists"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Name of CAM group.
	Name *string `pulumi:"name"`
	// Description of CAM group.
	Remark           *string `pulumi:"remark"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetGroupsOutput(ctx *pulumi.Context, args GetGroupsOutputArgs, opts ...pulumi.InvokeOption) GetGroupsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetGroupsResult, error) {
			args := v.(GetGroupsArgs)
			r, err := GetGroups(ctx, &args, opts...)
			var s GetGroupsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetGroupsResultOutput)
}

// A collection of arguments for invoking getGroups.
type GetGroupsOutputArgs struct {
	// ID of CAM group to be queried.
	GroupId pulumi.StringPtrInput `pulumi:"groupId"`
	// Name of the CAM group to be queried.
	Name pulumi.StringPtrInput `pulumi:"name"`
	// Description of the cam group to be queried.
	Remark pulumi.StringPtrInput `pulumi:"remark"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetGroupsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetGroupsArgs)(nil)).Elem()
}

// A collection of values returned by getGroups.
type GetGroupsResultOutput struct{ *pulumi.OutputState }

func (GetGroupsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetGroupsResult)(nil)).Elem()
}

func (o GetGroupsResultOutput) ToGetGroupsResultOutput() GetGroupsResultOutput {
	return o
}

func (o GetGroupsResultOutput) ToGetGroupsResultOutputWithContext(ctx context.Context) GetGroupsResultOutput {
	return o
}

// ID of the CAM group.
func (o GetGroupsResultOutput) GroupId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetGroupsResult) *string { return v.GroupId }).(pulumi.StringPtrOutput)
}

// A list of CAM groups. Each element contains the following attributes:
func (o GetGroupsResultOutput) GroupLists() GetGroupsGroupListArrayOutput {
	return o.ApplyT(func(v GetGroupsResult) []GetGroupsGroupList { return v.GroupLists }).(GetGroupsGroupListArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetGroupsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetGroupsResult) string { return v.Id }).(pulumi.StringOutput)
}

// Name of CAM group.
func (o GetGroupsResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetGroupsResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// Description of CAM group.
func (o GetGroupsResultOutput) Remark() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetGroupsResult) *string { return v.Remark }).(pulumi.StringPtrOutput)
}

func (o GetGroupsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetGroupsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetGroupsResultOutput{})
}