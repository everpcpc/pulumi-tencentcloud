// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tdmq

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of tdmq message
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Tdmq"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Tdmq.GetRocketmqMessages(ctx, &tdmq.GetRocketmqMessagesArgs{
//				ClusterId:     "rocketmq-rkrbm52djmro",
//				EnvironmentId: "keep_ns",
//				MsgId:         "A9FE8D0567FE15DB97425FC08EEF0000",
//				QueryDlqMsg:   pulumi.BoolRef(false),
//				TopicName:     "keep-topic",
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
func GetRocketmqMessages(ctx *pulumi.Context, args *GetRocketmqMessagesArgs, opts ...pulumi.InvokeOption) (*GetRocketmqMessagesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetRocketmqMessagesResult
	err := ctx.Invoke("tencentcloud:Tdmq/getRocketmqMessages:getRocketmqMessages", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRocketmqMessages.
type GetRocketmqMessagesArgs struct {
	// Cluster id.
	ClusterId string `pulumi:"clusterId"`
	// Environment.
	EnvironmentId string `pulumi:"environmentId"`
	// Message ID.
	MsgId string `pulumi:"msgId"`
	// The value is true when querying dead letters, only valid for Rocketmq.
	QueryDlqMsg *bool `pulumi:"queryDlqMsg"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Topic, groupId is passed when querying dead letters.
	TopicName string `pulumi:"topicName"`
}

// A collection of values returned by getRocketmqMessages.
type GetRocketmqMessagesResult struct {
	// Message body.
	Body          string `pulumi:"body"`
	ClusterId     string `pulumi:"clusterId"`
	EnvironmentId string `pulumi:"environmentId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Consumer Group ConsumptionNote: This field may return null, indicating that no valid value can be obtained.
	MessageTracks []GetRocketmqMessagesMessageTrack `pulumi:"messageTracks"`
	MsgId         string                            `pulumi:"msgId"`
	// Production time.
	ProduceTime string `pulumi:"produceTime"`
	// Producer address.
	ProducerAddr string `pulumi:"producerAddr"`
	// Detailed parameters.
	Properties       string  `pulumi:"properties"`
	QueryDlqMsg      *bool   `pulumi:"queryDlqMsg"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// The topic name displayed on the details pageNote: This field may return null, indicating that no valid value can be obtained.
	ShowTopicName string `pulumi:"showTopicName"`
	TopicName     string `pulumi:"topicName"`
}

func GetRocketmqMessagesOutput(ctx *pulumi.Context, args GetRocketmqMessagesOutputArgs, opts ...pulumi.InvokeOption) GetRocketmqMessagesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetRocketmqMessagesResult, error) {
			args := v.(GetRocketmqMessagesArgs)
			r, err := GetRocketmqMessages(ctx, &args, opts...)
			var s GetRocketmqMessagesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetRocketmqMessagesResultOutput)
}

// A collection of arguments for invoking getRocketmqMessages.
type GetRocketmqMessagesOutputArgs struct {
	// Cluster id.
	ClusterId pulumi.StringInput `pulumi:"clusterId"`
	// Environment.
	EnvironmentId pulumi.StringInput `pulumi:"environmentId"`
	// Message ID.
	MsgId pulumi.StringInput `pulumi:"msgId"`
	// The value is true when querying dead letters, only valid for Rocketmq.
	QueryDlqMsg pulumi.BoolPtrInput `pulumi:"queryDlqMsg"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Topic, groupId is passed when querying dead letters.
	TopicName pulumi.StringInput `pulumi:"topicName"`
}

func (GetRocketmqMessagesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRocketmqMessagesArgs)(nil)).Elem()
}

// A collection of values returned by getRocketmqMessages.
type GetRocketmqMessagesResultOutput struct{ *pulumi.OutputState }

func (GetRocketmqMessagesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRocketmqMessagesResult)(nil)).Elem()
}

func (o GetRocketmqMessagesResultOutput) ToGetRocketmqMessagesResultOutput() GetRocketmqMessagesResultOutput {
	return o
}

func (o GetRocketmqMessagesResultOutput) ToGetRocketmqMessagesResultOutputWithContext(ctx context.Context) GetRocketmqMessagesResultOutput {
	return o
}

// Message body.
func (o GetRocketmqMessagesResultOutput) Body() pulumi.StringOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) string { return v.Body }).(pulumi.StringOutput)
}

func (o GetRocketmqMessagesResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o GetRocketmqMessagesResultOutput) EnvironmentId() pulumi.StringOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) string { return v.EnvironmentId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetRocketmqMessagesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) string { return v.Id }).(pulumi.StringOutput)
}

// Consumer Group ConsumptionNote: This field may return null, indicating that no valid value can be obtained.
func (o GetRocketmqMessagesResultOutput) MessageTracks() GetRocketmqMessagesMessageTrackArrayOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) []GetRocketmqMessagesMessageTrack { return v.MessageTracks }).(GetRocketmqMessagesMessageTrackArrayOutput)
}

func (o GetRocketmqMessagesResultOutput) MsgId() pulumi.StringOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) string { return v.MsgId }).(pulumi.StringOutput)
}

// Production time.
func (o GetRocketmqMessagesResultOutput) ProduceTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) string { return v.ProduceTime }).(pulumi.StringOutput)
}

// Producer address.
func (o GetRocketmqMessagesResultOutput) ProducerAddr() pulumi.StringOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) string { return v.ProducerAddr }).(pulumi.StringOutput)
}

// Detailed parameters.
func (o GetRocketmqMessagesResultOutput) Properties() pulumi.StringOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) string { return v.Properties }).(pulumi.StringOutput)
}

func (o GetRocketmqMessagesResultOutput) QueryDlqMsg() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) *bool { return v.QueryDlqMsg }).(pulumi.BoolPtrOutput)
}

func (o GetRocketmqMessagesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// The topic name displayed on the details pageNote: This field may return null, indicating that no valid value can be obtained.
func (o GetRocketmqMessagesResultOutput) ShowTopicName() pulumi.StringOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) string { return v.ShowTopicName }).(pulumi.StringOutput)
}

func (o GetRocketmqMessagesResultOutput) TopicName() pulumi.StringOutput {
	return o.ApplyT(func(v GetRocketmqMessagesResult) string { return v.TopicName }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetRocketmqMessagesResultOutput{})
}