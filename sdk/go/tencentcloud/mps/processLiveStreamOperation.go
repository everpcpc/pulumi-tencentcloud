// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mps

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a mps processLiveStreamOperation
//
// ## Example Usage
//
// ### Process mps live stream through CMQ
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"fmt"
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cos"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mps"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			output, err := Cos.NewBucket(ctx, "output", &Cos.BucketArgs{
//				Bucket:     pulumi.String(fmt.Sprintf("tf-bucket-mps-process-live-stream-output-%v", local.App_id)),
//				ForceClean: pulumi.Bool(true),
//				Acl:        pulumi.String("public-read"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Mps.NewProcessLiveStreamOperation(ctx, "operation", &Mps.ProcessLiveStreamOperationArgs{
//				Url: pulumi.String("http://www.abc.com/abc.m3u8"),
//				TaskNotifyConfig: &mps.ProcessLiveStreamOperationTaskNotifyConfigArgs{
//					CmqModel:   pulumi.String("Queue"),
//					CmqRegion:  pulumi.String("gz"),
//					QueueName:  pulumi.String("test"),
//					TopicName:  pulumi.String("test"),
//					NotifyType: pulumi.String("CMQ"),
//				},
//				OutputStorage: &mps.ProcessLiveStreamOperationOutputStorageArgs{
//					Type: pulumi.String("COS"),
//					CosOutputStorage: &mps.ProcessLiveStreamOperationOutputStorageCosOutputStorageArgs{
//						Bucket: output.Bucket,
//						Region: pulumi.String("%s"),
//					},
//				},
//				OutputDir: pulumi.String("/output/"),
//				AiContentReviewTask: &mps.ProcessLiveStreamOperationAiContentReviewTaskArgs{
//					Definition: pulumi.Int(10),
//				},
//				AiRecognitionTask: &mps.ProcessLiveStreamOperationAiRecognitionTaskArgs{
//					Definition: pulumi.Int(10),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
type ProcessLiveStreamOperation struct {
	pulumi.CustomResourceState

	// AI video intelligent analysis input parameter types.
	AiAnalysisTask ProcessLiveStreamOperationAiAnalysisTaskPtrOutput `pulumi:"aiAnalysisTask"`
	// Type parameter of a video content audit task.
	AiContentReviewTask ProcessLiveStreamOperationAiContentReviewTaskPtrOutput `pulumi:"aiContentReviewTask"`
	// The parameters for a video quality control task.
	AiQualityControlTask ProcessLiveStreamOperationAiQualityControlTaskPtrOutput `pulumi:"aiQualityControlTask"`
	// Type parameter of video content recognition task.
	AiRecognitionTask ProcessLiveStreamOperationAiRecognitionTaskPtrOutput `pulumi:"aiRecognitionTask"`
	// Target directory of a live stream processing output file, such as `/movie/201909/`. If this parameter is left empty, the `/` directory will be used.
	OutputDir pulumi.StringPtrOutput `pulumi:"outputDir"`
	// Target bucket of a live stream processing output file. This parameter is required if a file will be output.
	OutputStorage ProcessLiveStreamOperationOutputStoragePtrOutput `pulumi:"outputStorage"`
	// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`:If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.
	ScheduleId pulumi.IntPtrOutput `pulumi:"scheduleId"`
	// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
	SessionContext pulumi.StringPtrOutput `pulumi:"sessionContext"`
	// The ID used for deduplication. If there was a request with the same ID in the last seven days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
	SessionId pulumi.StringPtrOutput `pulumi:"sessionId"`
	// Event notification information of a task, which is used to specify the live stream processing result.
	TaskNotifyConfig ProcessLiveStreamOperationTaskNotifyConfigOutput `pulumi:"taskNotifyConfig"`
	// Live stream URL, which must be a live stream file address. RTMP, HLS, and FLV are supported.
	Url pulumi.StringOutput `pulumi:"url"`
}

// NewProcessLiveStreamOperation registers a new resource with the given unique name, arguments, and options.
func NewProcessLiveStreamOperation(ctx *pulumi.Context,
	name string, args *ProcessLiveStreamOperationArgs, opts ...pulumi.ResourceOption) (*ProcessLiveStreamOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.TaskNotifyConfig == nil {
		return nil, errors.New("invalid value for required argument 'TaskNotifyConfig'")
	}
	if args.Url == nil {
		return nil, errors.New("invalid value for required argument 'Url'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ProcessLiveStreamOperation
	err := ctx.RegisterResource("tencentcloud:Mps/processLiveStreamOperation:ProcessLiveStreamOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProcessLiveStreamOperation gets an existing ProcessLiveStreamOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProcessLiveStreamOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProcessLiveStreamOperationState, opts ...pulumi.ResourceOption) (*ProcessLiveStreamOperation, error) {
	var resource ProcessLiveStreamOperation
	err := ctx.ReadResource("tencentcloud:Mps/processLiveStreamOperation:ProcessLiveStreamOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProcessLiveStreamOperation resources.
type processLiveStreamOperationState struct {
	// AI video intelligent analysis input parameter types.
	AiAnalysisTask *ProcessLiveStreamOperationAiAnalysisTask `pulumi:"aiAnalysisTask"`
	// Type parameter of a video content audit task.
	AiContentReviewTask *ProcessLiveStreamOperationAiContentReviewTask `pulumi:"aiContentReviewTask"`
	// The parameters for a video quality control task.
	AiQualityControlTask *ProcessLiveStreamOperationAiQualityControlTask `pulumi:"aiQualityControlTask"`
	// Type parameter of video content recognition task.
	AiRecognitionTask *ProcessLiveStreamOperationAiRecognitionTask `pulumi:"aiRecognitionTask"`
	// Target directory of a live stream processing output file, such as `/movie/201909/`. If this parameter is left empty, the `/` directory will be used.
	OutputDir *string `pulumi:"outputDir"`
	// Target bucket of a live stream processing output file. This parameter is required if a file will be output.
	OutputStorage *ProcessLiveStreamOperationOutputStorage `pulumi:"outputStorage"`
	// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`:If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.
	ScheduleId *int `pulumi:"scheduleId"`
	// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
	SessionContext *string `pulumi:"sessionContext"`
	// The ID used for deduplication. If there was a request with the same ID in the last seven days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
	SessionId *string `pulumi:"sessionId"`
	// Event notification information of a task, which is used to specify the live stream processing result.
	TaskNotifyConfig *ProcessLiveStreamOperationTaskNotifyConfig `pulumi:"taskNotifyConfig"`
	// Live stream URL, which must be a live stream file address. RTMP, HLS, and FLV are supported.
	Url *string `pulumi:"url"`
}

type ProcessLiveStreamOperationState struct {
	// AI video intelligent analysis input parameter types.
	AiAnalysisTask ProcessLiveStreamOperationAiAnalysisTaskPtrInput
	// Type parameter of a video content audit task.
	AiContentReviewTask ProcessLiveStreamOperationAiContentReviewTaskPtrInput
	// The parameters for a video quality control task.
	AiQualityControlTask ProcessLiveStreamOperationAiQualityControlTaskPtrInput
	// Type parameter of video content recognition task.
	AiRecognitionTask ProcessLiveStreamOperationAiRecognitionTaskPtrInput
	// Target directory of a live stream processing output file, such as `/movie/201909/`. If this parameter is left empty, the `/` directory will be used.
	OutputDir pulumi.StringPtrInput
	// Target bucket of a live stream processing output file. This parameter is required if a file will be output.
	OutputStorage ProcessLiveStreamOperationOutputStoragePtrInput
	// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`:If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.
	ScheduleId pulumi.IntPtrInput
	// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
	SessionContext pulumi.StringPtrInput
	// The ID used for deduplication. If there was a request with the same ID in the last seven days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
	SessionId pulumi.StringPtrInput
	// Event notification information of a task, which is used to specify the live stream processing result.
	TaskNotifyConfig ProcessLiveStreamOperationTaskNotifyConfigPtrInput
	// Live stream URL, which must be a live stream file address. RTMP, HLS, and FLV are supported.
	Url pulumi.StringPtrInput
}

func (ProcessLiveStreamOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*processLiveStreamOperationState)(nil)).Elem()
}

type processLiveStreamOperationArgs struct {
	// AI video intelligent analysis input parameter types.
	AiAnalysisTask *ProcessLiveStreamOperationAiAnalysisTask `pulumi:"aiAnalysisTask"`
	// Type parameter of a video content audit task.
	AiContentReviewTask *ProcessLiveStreamOperationAiContentReviewTask `pulumi:"aiContentReviewTask"`
	// The parameters for a video quality control task.
	AiQualityControlTask *ProcessLiveStreamOperationAiQualityControlTask `pulumi:"aiQualityControlTask"`
	// Type parameter of video content recognition task.
	AiRecognitionTask *ProcessLiveStreamOperationAiRecognitionTask `pulumi:"aiRecognitionTask"`
	// Target directory of a live stream processing output file, such as `/movie/201909/`. If this parameter is left empty, the `/` directory will be used.
	OutputDir *string `pulumi:"outputDir"`
	// Target bucket of a live stream processing output file. This parameter is required if a file will be output.
	OutputStorage *ProcessLiveStreamOperationOutputStorage `pulumi:"outputStorage"`
	// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`:If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.
	ScheduleId *int `pulumi:"scheduleId"`
	// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
	SessionContext *string `pulumi:"sessionContext"`
	// The ID used for deduplication. If there was a request with the same ID in the last seven days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
	SessionId *string `pulumi:"sessionId"`
	// Event notification information of a task, which is used to specify the live stream processing result.
	TaskNotifyConfig ProcessLiveStreamOperationTaskNotifyConfig `pulumi:"taskNotifyConfig"`
	// Live stream URL, which must be a live stream file address. RTMP, HLS, and FLV are supported.
	Url string `pulumi:"url"`
}

// The set of arguments for constructing a ProcessLiveStreamOperation resource.
type ProcessLiveStreamOperationArgs struct {
	// AI video intelligent analysis input parameter types.
	AiAnalysisTask ProcessLiveStreamOperationAiAnalysisTaskPtrInput
	// Type parameter of a video content audit task.
	AiContentReviewTask ProcessLiveStreamOperationAiContentReviewTaskPtrInput
	// The parameters for a video quality control task.
	AiQualityControlTask ProcessLiveStreamOperationAiQualityControlTaskPtrInput
	// Type parameter of video content recognition task.
	AiRecognitionTask ProcessLiveStreamOperationAiRecognitionTaskPtrInput
	// Target directory of a live stream processing output file, such as `/movie/201909/`. If this parameter is left empty, the `/` directory will be used.
	OutputDir pulumi.StringPtrInput
	// Target bucket of a live stream processing output file. This parameter is required if a file will be output.
	OutputStorage ProcessLiveStreamOperationOutputStoragePtrInput
	// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`:If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.
	ScheduleId pulumi.IntPtrInput
	// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
	SessionContext pulumi.StringPtrInput
	// The ID used for deduplication. If there was a request with the same ID in the last seven days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
	SessionId pulumi.StringPtrInput
	// Event notification information of a task, which is used to specify the live stream processing result.
	TaskNotifyConfig ProcessLiveStreamOperationTaskNotifyConfigInput
	// Live stream URL, which must be a live stream file address. RTMP, HLS, and FLV are supported.
	Url pulumi.StringInput
}

func (ProcessLiveStreamOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*processLiveStreamOperationArgs)(nil)).Elem()
}

type ProcessLiveStreamOperationInput interface {
	pulumi.Input

	ToProcessLiveStreamOperationOutput() ProcessLiveStreamOperationOutput
	ToProcessLiveStreamOperationOutputWithContext(ctx context.Context) ProcessLiveStreamOperationOutput
}

func (*ProcessLiveStreamOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**ProcessLiveStreamOperation)(nil)).Elem()
}

func (i *ProcessLiveStreamOperation) ToProcessLiveStreamOperationOutput() ProcessLiveStreamOperationOutput {
	return i.ToProcessLiveStreamOperationOutputWithContext(context.Background())
}

func (i *ProcessLiveStreamOperation) ToProcessLiveStreamOperationOutputWithContext(ctx context.Context) ProcessLiveStreamOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProcessLiveStreamOperationOutput)
}

// ProcessLiveStreamOperationArrayInput is an input type that accepts ProcessLiveStreamOperationArray and ProcessLiveStreamOperationArrayOutput values.
// You can construct a concrete instance of `ProcessLiveStreamOperationArrayInput` via:
//
//	ProcessLiveStreamOperationArray{ ProcessLiveStreamOperationArgs{...} }
type ProcessLiveStreamOperationArrayInput interface {
	pulumi.Input

	ToProcessLiveStreamOperationArrayOutput() ProcessLiveStreamOperationArrayOutput
	ToProcessLiveStreamOperationArrayOutputWithContext(context.Context) ProcessLiveStreamOperationArrayOutput
}

type ProcessLiveStreamOperationArray []ProcessLiveStreamOperationInput

func (ProcessLiveStreamOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProcessLiveStreamOperation)(nil)).Elem()
}

func (i ProcessLiveStreamOperationArray) ToProcessLiveStreamOperationArrayOutput() ProcessLiveStreamOperationArrayOutput {
	return i.ToProcessLiveStreamOperationArrayOutputWithContext(context.Background())
}

func (i ProcessLiveStreamOperationArray) ToProcessLiveStreamOperationArrayOutputWithContext(ctx context.Context) ProcessLiveStreamOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProcessLiveStreamOperationArrayOutput)
}

// ProcessLiveStreamOperationMapInput is an input type that accepts ProcessLiveStreamOperationMap and ProcessLiveStreamOperationMapOutput values.
// You can construct a concrete instance of `ProcessLiveStreamOperationMapInput` via:
//
//	ProcessLiveStreamOperationMap{ "key": ProcessLiveStreamOperationArgs{...} }
type ProcessLiveStreamOperationMapInput interface {
	pulumi.Input

	ToProcessLiveStreamOperationMapOutput() ProcessLiveStreamOperationMapOutput
	ToProcessLiveStreamOperationMapOutputWithContext(context.Context) ProcessLiveStreamOperationMapOutput
}

type ProcessLiveStreamOperationMap map[string]ProcessLiveStreamOperationInput

func (ProcessLiveStreamOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProcessLiveStreamOperation)(nil)).Elem()
}

func (i ProcessLiveStreamOperationMap) ToProcessLiveStreamOperationMapOutput() ProcessLiveStreamOperationMapOutput {
	return i.ToProcessLiveStreamOperationMapOutputWithContext(context.Background())
}

func (i ProcessLiveStreamOperationMap) ToProcessLiveStreamOperationMapOutputWithContext(ctx context.Context) ProcessLiveStreamOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProcessLiveStreamOperationMapOutput)
}

type ProcessLiveStreamOperationOutput struct{ *pulumi.OutputState }

func (ProcessLiveStreamOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ProcessLiveStreamOperation)(nil)).Elem()
}

func (o ProcessLiveStreamOperationOutput) ToProcessLiveStreamOperationOutput() ProcessLiveStreamOperationOutput {
	return o
}

func (o ProcessLiveStreamOperationOutput) ToProcessLiveStreamOperationOutputWithContext(ctx context.Context) ProcessLiveStreamOperationOutput {
	return o
}

// AI video intelligent analysis input parameter types.
func (o ProcessLiveStreamOperationOutput) AiAnalysisTask() ProcessLiveStreamOperationAiAnalysisTaskPtrOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) ProcessLiveStreamOperationAiAnalysisTaskPtrOutput {
		return v.AiAnalysisTask
	}).(ProcessLiveStreamOperationAiAnalysisTaskPtrOutput)
}

// Type parameter of a video content audit task.
func (o ProcessLiveStreamOperationOutput) AiContentReviewTask() ProcessLiveStreamOperationAiContentReviewTaskPtrOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) ProcessLiveStreamOperationAiContentReviewTaskPtrOutput {
		return v.AiContentReviewTask
	}).(ProcessLiveStreamOperationAiContentReviewTaskPtrOutput)
}

// The parameters for a video quality control task.
func (o ProcessLiveStreamOperationOutput) AiQualityControlTask() ProcessLiveStreamOperationAiQualityControlTaskPtrOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) ProcessLiveStreamOperationAiQualityControlTaskPtrOutput {
		return v.AiQualityControlTask
	}).(ProcessLiveStreamOperationAiQualityControlTaskPtrOutput)
}

// Type parameter of video content recognition task.
func (o ProcessLiveStreamOperationOutput) AiRecognitionTask() ProcessLiveStreamOperationAiRecognitionTaskPtrOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) ProcessLiveStreamOperationAiRecognitionTaskPtrOutput {
		return v.AiRecognitionTask
	}).(ProcessLiveStreamOperationAiRecognitionTaskPtrOutput)
}

// Target directory of a live stream processing output file, such as `/movie/201909/`. If this parameter is left empty, the `/` directory will be used.
func (o ProcessLiveStreamOperationOutput) OutputDir() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) pulumi.StringPtrOutput { return v.OutputDir }).(pulumi.StringPtrOutput)
}

// Target bucket of a live stream processing output file. This parameter is required if a file will be output.
func (o ProcessLiveStreamOperationOutput) OutputStorage() ProcessLiveStreamOperationOutputStoragePtrOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) ProcessLiveStreamOperationOutputStoragePtrOutput {
		return v.OutputStorage
	}).(ProcessLiveStreamOperationOutputStoragePtrOutput)
}

// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`:If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.
func (o ProcessLiveStreamOperationOutput) ScheduleId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) pulumi.IntPtrOutput { return v.ScheduleId }).(pulumi.IntPtrOutput)
}

// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
func (o ProcessLiveStreamOperationOutput) SessionContext() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) pulumi.StringPtrOutput { return v.SessionContext }).(pulumi.StringPtrOutput)
}

// The ID used for deduplication. If there was a request with the same ID in the last seven days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
func (o ProcessLiveStreamOperationOutput) SessionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) pulumi.StringPtrOutput { return v.SessionId }).(pulumi.StringPtrOutput)
}

// Event notification information of a task, which is used to specify the live stream processing result.
func (o ProcessLiveStreamOperationOutput) TaskNotifyConfig() ProcessLiveStreamOperationTaskNotifyConfigOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) ProcessLiveStreamOperationTaskNotifyConfigOutput {
		return v.TaskNotifyConfig
	}).(ProcessLiveStreamOperationTaskNotifyConfigOutput)
}

// Live stream URL, which must be a live stream file address. RTMP, HLS, and FLV are supported.
func (o ProcessLiveStreamOperationOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v *ProcessLiveStreamOperation) pulumi.StringOutput { return v.Url }).(pulumi.StringOutput)
}

type ProcessLiveStreamOperationArrayOutput struct{ *pulumi.OutputState }

func (ProcessLiveStreamOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProcessLiveStreamOperation)(nil)).Elem()
}

func (o ProcessLiveStreamOperationArrayOutput) ToProcessLiveStreamOperationArrayOutput() ProcessLiveStreamOperationArrayOutput {
	return o
}

func (o ProcessLiveStreamOperationArrayOutput) ToProcessLiveStreamOperationArrayOutputWithContext(ctx context.Context) ProcessLiveStreamOperationArrayOutput {
	return o
}

func (o ProcessLiveStreamOperationArrayOutput) Index(i pulumi.IntInput) ProcessLiveStreamOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ProcessLiveStreamOperation {
		return vs[0].([]*ProcessLiveStreamOperation)[vs[1].(int)]
	}).(ProcessLiveStreamOperationOutput)
}

type ProcessLiveStreamOperationMapOutput struct{ *pulumi.OutputState }

func (ProcessLiveStreamOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProcessLiveStreamOperation)(nil)).Elem()
}

func (o ProcessLiveStreamOperationMapOutput) ToProcessLiveStreamOperationMapOutput() ProcessLiveStreamOperationMapOutput {
	return o
}

func (o ProcessLiveStreamOperationMapOutput) ToProcessLiveStreamOperationMapOutputWithContext(ctx context.Context) ProcessLiveStreamOperationMapOutput {
	return o
}

func (o ProcessLiveStreamOperationMapOutput) MapIndex(k pulumi.StringInput) ProcessLiveStreamOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ProcessLiveStreamOperation {
		return vs[0].(map[string]*ProcessLiveStreamOperation)[vs[1].(string)]
	}).(ProcessLiveStreamOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProcessLiveStreamOperationInput)(nil)).Elem(), &ProcessLiveStreamOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProcessLiveStreamOperationArrayInput)(nil)).Elem(), ProcessLiveStreamOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProcessLiveStreamOperationMapInput)(nil)).Elem(), ProcessLiveStreamOperationMap{})
	pulumi.RegisterOutputType(ProcessLiveStreamOperationOutput{})
	pulumi.RegisterOutputType(ProcessLiveStreamOperationArrayOutput{})
	pulumi.RegisterOutputType(ProcessLiveStreamOperationMapOutput{})
}