// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ses

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of ses sendEmailStatus
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Ses"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Ses.GetSendEmailStatus(ctx, &ses.GetSendEmailStatusArgs{
//				MessageId:      pulumi.StringRef("qcloudses-30-4123414323-date-20210101094334-syNARhMTbKI1"),
//				RequestDate:    "2020-09-22",
//				ToEmailAddress: pulumi.StringRef("example@cloud.com"),
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
func GetSendEmailStatus(ctx *pulumi.Context, args *GetSendEmailStatusArgs, opts ...pulumi.InvokeOption) (*GetSendEmailStatusResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetSendEmailStatusResult
	err := ctx.Invoke("tencentcloud:Ses/getSendEmailStatus:getSendEmailStatus", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSendEmailStatus.
type GetSendEmailStatusArgs struct {
	// The MessageId field returned by the SendMail API.
	MessageId *string `pulumi:"messageId"`
	// Date sent. This parameter is required. You can only query the sending status for a single date at a time.
	RequestDate string `pulumi:"requestDate"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Recipient email address.
	ToEmailAddress *string `pulumi:"toEmailAddress"`
}

// A collection of values returned by getSendEmailStatus.
type GetSendEmailStatusResult struct {
	// Status of sent emails.
	EmailStatusLists []GetSendEmailStatusEmailStatusList `pulumi:"emailStatusLists"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The MessageId field returned by the SendEmail API.
	MessageId        *string `pulumi:"messageId"`
	RequestDate      string  `pulumi:"requestDate"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Recipient email address.
	ToEmailAddress *string `pulumi:"toEmailAddress"`
}

func GetSendEmailStatusOutput(ctx *pulumi.Context, args GetSendEmailStatusOutputArgs, opts ...pulumi.InvokeOption) GetSendEmailStatusResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetSendEmailStatusResult, error) {
			args := v.(GetSendEmailStatusArgs)
			r, err := GetSendEmailStatus(ctx, &args, opts...)
			var s GetSendEmailStatusResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetSendEmailStatusResultOutput)
}

// A collection of arguments for invoking getSendEmailStatus.
type GetSendEmailStatusOutputArgs struct {
	// The MessageId field returned by the SendMail API.
	MessageId pulumi.StringPtrInput `pulumi:"messageId"`
	// Date sent. This parameter is required. You can only query the sending status for a single date at a time.
	RequestDate pulumi.StringInput `pulumi:"requestDate"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Recipient email address.
	ToEmailAddress pulumi.StringPtrInput `pulumi:"toEmailAddress"`
}

func (GetSendEmailStatusOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSendEmailStatusArgs)(nil)).Elem()
}

// A collection of values returned by getSendEmailStatus.
type GetSendEmailStatusResultOutput struct{ *pulumi.OutputState }

func (GetSendEmailStatusResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSendEmailStatusResult)(nil)).Elem()
}

func (o GetSendEmailStatusResultOutput) ToGetSendEmailStatusResultOutput() GetSendEmailStatusResultOutput {
	return o
}

func (o GetSendEmailStatusResultOutput) ToGetSendEmailStatusResultOutputWithContext(ctx context.Context) GetSendEmailStatusResultOutput {
	return o
}

// Status of sent emails.
func (o GetSendEmailStatusResultOutput) EmailStatusLists() GetSendEmailStatusEmailStatusListArrayOutput {
	return o.ApplyT(func(v GetSendEmailStatusResult) []GetSendEmailStatusEmailStatusList { return v.EmailStatusLists }).(GetSendEmailStatusEmailStatusListArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetSendEmailStatusResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetSendEmailStatusResult) string { return v.Id }).(pulumi.StringOutput)
}

// The MessageId field returned by the SendEmail API.
func (o GetSendEmailStatusResultOutput) MessageId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSendEmailStatusResult) *string { return v.MessageId }).(pulumi.StringPtrOutput)
}

func (o GetSendEmailStatusResultOutput) RequestDate() pulumi.StringOutput {
	return o.ApplyT(func(v GetSendEmailStatusResult) string { return v.RequestDate }).(pulumi.StringOutput)
}

func (o GetSendEmailStatusResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSendEmailStatusResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Recipient email address.
func (o GetSendEmailStatusResultOutput) ToEmailAddress() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSendEmailStatusResult) *string { return v.ToEmailAddress }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSendEmailStatusResultOutput{})
}