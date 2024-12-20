// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package postgresql

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of postgresql baseBackups
func GetBaseBackups(ctx *pulumi.Context, args *GetBaseBackupsArgs, opts ...pulumi.InvokeOption) (*GetBaseBackupsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetBaseBackupsResult
	err := ctx.Invoke("tencentcloud:Postgresql/getBaseBackups:getBaseBackups", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBaseBackups.
type GetBaseBackupsArgs struct {
	// Filter instances using one or more criteria. Valid filter names: `db-instance-id`: Filter by instance ID (in string format). `db-instance-name`: Filter by instance name (in string format). `db-instance-ip`: Filter by instance VPC IP (in string format). `base-backup-id`: Filter by base backup ID (in string format).
	Filters []GetBaseBackupsFilter `pulumi:"filters"`
	// Maximum end time of a backup in the format of `2018-01-01 00:00:00`. It is the current time by default.
	MaxFinishTime *string `pulumi:"maxFinishTime"`
	// Minimum end time of a backup in the format of `2018-01-01 00:00:00`. It is 7 days ago by default.
	MinFinishTime *string `pulumi:"minFinishTime"`
	// Sorting field. Valid values: `StartTime`, `FinishTime`, `Size`.
	OrderBy *string `pulumi:"orderBy"`
	// Sorting order. Valid values: `asc` (ascending), `desc` (descending).
	OrderByType *string `pulumi:"orderByType"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getBaseBackups.
type GetBaseBackupsResult struct {
	// List of full backup details.
	BaseBackupSets []GetBaseBackupsBaseBackupSet `pulumi:"baseBackupSets"`
	Filters        []GetBaseBackupsFilter        `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	MaxFinishTime    *string `pulumi:"maxFinishTime"`
	MinFinishTime    *string `pulumi:"minFinishTime"`
	OrderBy          *string `pulumi:"orderBy"`
	OrderByType      *string `pulumi:"orderByType"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetBaseBackupsOutput(ctx *pulumi.Context, args GetBaseBackupsOutputArgs, opts ...pulumi.InvokeOption) GetBaseBackupsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetBaseBackupsResult, error) {
			args := v.(GetBaseBackupsArgs)
			r, err := GetBaseBackups(ctx, &args, opts...)
			var s GetBaseBackupsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetBaseBackupsResultOutput)
}

// A collection of arguments for invoking getBaseBackups.
type GetBaseBackupsOutputArgs struct {
	// Filter instances using one or more criteria. Valid filter names: `db-instance-id`: Filter by instance ID (in string format). `db-instance-name`: Filter by instance name (in string format). `db-instance-ip`: Filter by instance VPC IP (in string format). `base-backup-id`: Filter by base backup ID (in string format).
	Filters GetBaseBackupsFilterArrayInput `pulumi:"filters"`
	// Maximum end time of a backup in the format of `2018-01-01 00:00:00`. It is the current time by default.
	MaxFinishTime pulumi.StringPtrInput `pulumi:"maxFinishTime"`
	// Minimum end time of a backup in the format of `2018-01-01 00:00:00`. It is 7 days ago by default.
	MinFinishTime pulumi.StringPtrInput `pulumi:"minFinishTime"`
	// Sorting field. Valid values: `StartTime`, `FinishTime`, `Size`.
	OrderBy pulumi.StringPtrInput `pulumi:"orderBy"`
	// Sorting order. Valid values: `asc` (ascending), `desc` (descending).
	OrderByType pulumi.StringPtrInput `pulumi:"orderByType"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetBaseBackupsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBaseBackupsArgs)(nil)).Elem()
}

// A collection of values returned by getBaseBackups.
type GetBaseBackupsResultOutput struct{ *pulumi.OutputState }

func (GetBaseBackupsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBaseBackupsResult)(nil)).Elem()
}

func (o GetBaseBackupsResultOutput) ToGetBaseBackupsResultOutput() GetBaseBackupsResultOutput {
	return o
}

func (o GetBaseBackupsResultOutput) ToGetBaseBackupsResultOutputWithContext(ctx context.Context) GetBaseBackupsResultOutput {
	return o
}

// List of full backup details.
func (o GetBaseBackupsResultOutput) BaseBackupSets() GetBaseBackupsBaseBackupSetArrayOutput {
	return o.ApplyT(func(v GetBaseBackupsResult) []GetBaseBackupsBaseBackupSet { return v.BaseBackupSets }).(GetBaseBackupsBaseBackupSetArrayOutput)
}

func (o GetBaseBackupsResultOutput) Filters() GetBaseBackupsFilterArrayOutput {
	return o.ApplyT(func(v GetBaseBackupsResult) []GetBaseBackupsFilter { return v.Filters }).(GetBaseBackupsFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetBaseBackupsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetBaseBackupsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetBaseBackupsResultOutput) MaxFinishTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBaseBackupsResult) *string { return v.MaxFinishTime }).(pulumi.StringPtrOutput)
}

func (o GetBaseBackupsResultOutput) MinFinishTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBaseBackupsResult) *string { return v.MinFinishTime }).(pulumi.StringPtrOutput)
}

func (o GetBaseBackupsResultOutput) OrderBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBaseBackupsResult) *string { return v.OrderBy }).(pulumi.StringPtrOutput)
}

func (o GetBaseBackupsResultOutput) OrderByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBaseBackupsResult) *string { return v.OrderByType }).(pulumi.StringPtrOutput)
}

func (o GetBaseBackupsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBaseBackupsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetBaseBackupsResultOutput{})
}
