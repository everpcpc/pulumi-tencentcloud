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

// Provides a resource to create a mps processMediaOperation
//
// ## Example Usage
//
// ### Process mps media through CMQ
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
//				Bucket:     pulumi.String(fmt.Sprintf("tf-bucket-mps-edit-media-output-%v", local.App_id)),
//				ForceClean: pulumi.Bool(true),
//				Acl:        pulumi.String("public-read"),
//			})
//			if err != nil {
//				return err
//			}
//			object, err := Cos.GetBucketObject(ctx, &cos.GetBucketObjectArgs{
//				Bucket: fmt.Sprintf("keep-bucket-%v", local.App_id),
//				Key:    "/mps-test/test.mov",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = Mps.NewProcessMediaOperation(ctx, "operation", &Mps.ProcessMediaOperationArgs{
//				InputInfo: &mps.ProcessMediaOperationInputInfoArgs{
//					Type: pulumi.String("COS"),
//					CosInputInfo: &mps.ProcessMediaOperationInputInfoCosInputInfoArgs{
//						Bucket: pulumi.String(object.Bucket),
//						Region: pulumi.String("%s"),
//						Object: pulumi.String(object.Key),
//					},
//				},
//				OutputStorage: &mps.ProcessMediaOperationOutputStorageArgs{
//					Type: pulumi.String("COS"),
//					CosOutputStorage: &mps.ProcessMediaOperationOutputStorageCosOutputStorageArgs{
//						Bucket: output.Bucket,
//						Region: pulumi.String("%s"),
//					},
//				},
//				OutputDir: pulumi.String("output/"),
//				AiContentReviewTask: &mps.ProcessMediaOperationAiContentReviewTaskArgs{
//					Definition: pulumi.Int(10),
//				},
//				AiRecognitionTask: &mps.ProcessMediaOperationAiRecognitionTaskArgs{
//					Definition: pulumi.Int(10),
//				},
//				TaskNotifyConfig: &mps.ProcessMediaOperationTaskNotifyConfigArgs{
//					CmqModel:   pulumi.String("Queue"),
//					CmqRegion:  pulumi.String("gz"),
//					QueueName:  pulumi.String("test"),
//					TopicName:  pulumi.String("test"),
//					NotifyType: pulumi.String("CMQ"),
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
type ProcessMediaOperation struct {
	pulumi.CustomResourceState

	// Video content analysis task parameter.
	AiAnalysisTask ProcessMediaOperationAiAnalysisTaskPtrOutput `pulumi:"aiAnalysisTask"`
	// Type parameter of a video content audit task.
	AiContentReviewTask ProcessMediaOperationAiContentReviewTaskPtrOutput `pulumi:"aiContentReviewTask"`
	// The parameters of a quality control task.
	AiQualityControlTask ProcessMediaOperationAiQualityControlTaskPtrOutput `pulumi:"aiQualityControlTask"`
	// Type parameter of a video content recognition task.
	AiRecognitionTask ProcessMediaOperationAiRecognitionTaskPtrOutput `pulumi:"aiRecognitionTask"`
	// The information of the file to process.
	InputInfo ProcessMediaOperationInputInfoOutput `pulumi:"inputInfo"`
	// The media processing parameters to use.
	MediaProcessTask ProcessMediaOperationMediaProcessTaskPtrOutput `pulumi:"mediaProcessTask"`
	// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this parameter, the file will be saved to the directory specified in `InputInfo`.
	OutputDir pulumi.StringPtrOutput `pulumi:"outputDir"`
	// The storage location of the media processing output file. If this parameter is left empty, the storage location in `InputInfo` will be inherited.
	OutputStorage ProcessMediaOperationOutputStoragePtrOutput `pulumi:"outputStorage"`
	// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.Note 3: The trigger configured for a scheme is for automatically starting a scheme. It stops working when you manually call this API to start a scheme.
	ScheduleId pulumi.IntPtrOutput `pulumi:"scheduleId"`
	// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
	SessionContext pulumi.StringPtrOutput `pulumi:"sessionContext"`
	// The ID used for deduplication. If there was a request with the same ID in the last three days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
	SessionId pulumi.StringPtrOutput `pulumi:"sessionId"`
	// Event notification information of a task. If this parameter is left empty, no event notifications will be obtained.
	TaskNotifyConfig ProcessMediaOperationTaskNotifyConfigPtrOutput `pulumi:"taskNotifyConfig"`
	// The task type. `Online` (default): A task that is executed immediately. `Offline`: A task that is executed when the system is idle (within three days by default).
	TaskType pulumi.StringPtrOutput `pulumi:"taskType"`
	// Task flow priority. The higher the value, the higher the priority. Value range: [-10, 10]. If this parameter is left empty, 0 will be used.
	TasksPriority pulumi.IntPtrOutput `pulumi:"tasksPriority"`
}

// NewProcessMediaOperation registers a new resource with the given unique name, arguments, and options.
func NewProcessMediaOperation(ctx *pulumi.Context,
	name string, args *ProcessMediaOperationArgs, opts ...pulumi.ResourceOption) (*ProcessMediaOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InputInfo == nil {
		return nil, errors.New("invalid value for required argument 'InputInfo'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ProcessMediaOperation
	err := ctx.RegisterResource("tencentcloud:Mps/processMediaOperation:ProcessMediaOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProcessMediaOperation gets an existing ProcessMediaOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProcessMediaOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProcessMediaOperationState, opts ...pulumi.ResourceOption) (*ProcessMediaOperation, error) {
	var resource ProcessMediaOperation
	err := ctx.ReadResource("tencentcloud:Mps/processMediaOperation:ProcessMediaOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProcessMediaOperation resources.
type processMediaOperationState struct {
	// Video content analysis task parameter.
	AiAnalysisTask *ProcessMediaOperationAiAnalysisTask `pulumi:"aiAnalysisTask"`
	// Type parameter of a video content audit task.
	AiContentReviewTask *ProcessMediaOperationAiContentReviewTask `pulumi:"aiContentReviewTask"`
	// The parameters of a quality control task.
	AiQualityControlTask *ProcessMediaOperationAiQualityControlTask `pulumi:"aiQualityControlTask"`
	// Type parameter of a video content recognition task.
	AiRecognitionTask *ProcessMediaOperationAiRecognitionTask `pulumi:"aiRecognitionTask"`
	// The information of the file to process.
	InputInfo *ProcessMediaOperationInputInfo `pulumi:"inputInfo"`
	// The media processing parameters to use.
	MediaProcessTask *ProcessMediaOperationMediaProcessTask `pulumi:"mediaProcessTask"`
	// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this parameter, the file will be saved to the directory specified in `InputInfo`.
	OutputDir *string `pulumi:"outputDir"`
	// The storage location of the media processing output file. If this parameter is left empty, the storage location in `InputInfo` will be inherited.
	OutputStorage *ProcessMediaOperationOutputStorage `pulumi:"outputStorage"`
	// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.Note 3: The trigger configured for a scheme is for automatically starting a scheme. It stops working when you manually call this API to start a scheme.
	ScheduleId *int `pulumi:"scheduleId"`
	// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
	SessionContext *string `pulumi:"sessionContext"`
	// The ID used for deduplication. If there was a request with the same ID in the last three days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
	SessionId *string `pulumi:"sessionId"`
	// Event notification information of a task. If this parameter is left empty, no event notifications will be obtained.
	TaskNotifyConfig *ProcessMediaOperationTaskNotifyConfig `pulumi:"taskNotifyConfig"`
	// The task type. `Online` (default): A task that is executed immediately. `Offline`: A task that is executed when the system is idle (within three days by default).
	TaskType *string `pulumi:"taskType"`
	// Task flow priority. The higher the value, the higher the priority. Value range: [-10, 10]. If this parameter is left empty, 0 will be used.
	TasksPriority *int `pulumi:"tasksPriority"`
}

type ProcessMediaOperationState struct {
	// Video content analysis task parameter.
	AiAnalysisTask ProcessMediaOperationAiAnalysisTaskPtrInput
	// Type parameter of a video content audit task.
	AiContentReviewTask ProcessMediaOperationAiContentReviewTaskPtrInput
	// The parameters of a quality control task.
	AiQualityControlTask ProcessMediaOperationAiQualityControlTaskPtrInput
	// Type parameter of a video content recognition task.
	AiRecognitionTask ProcessMediaOperationAiRecognitionTaskPtrInput
	// The information of the file to process.
	InputInfo ProcessMediaOperationInputInfoPtrInput
	// The media processing parameters to use.
	MediaProcessTask ProcessMediaOperationMediaProcessTaskPtrInput
	// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this parameter, the file will be saved to the directory specified in `InputInfo`.
	OutputDir pulumi.StringPtrInput
	// The storage location of the media processing output file. If this parameter is left empty, the storage location in `InputInfo` will be inherited.
	OutputStorage ProcessMediaOperationOutputStoragePtrInput
	// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.Note 3: The trigger configured for a scheme is for automatically starting a scheme. It stops working when you manually call this API to start a scheme.
	ScheduleId pulumi.IntPtrInput
	// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
	SessionContext pulumi.StringPtrInput
	// The ID used for deduplication. If there was a request with the same ID in the last three days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
	SessionId pulumi.StringPtrInput
	// Event notification information of a task. If this parameter is left empty, no event notifications will be obtained.
	TaskNotifyConfig ProcessMediaOperationTaskNotifyConfigPtrInput
	// The task type. `Online` (default): A task that is executed immediately. `Offline`: A task that is executed when the system is idle (within three days by default).
	TaskType pulumi.StringPtrInput
	// Task flow priority. The higher the value, the higher the priority. Value range: [-10, 10]. If this parameter is left empty, 0 will be used.
	TasksPriority pulumi.IntPtrInput
}

func (ProcessMediaOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*processMediaOperationState)(nil)).Elem()
}

type processMediaOperationArgs struct {
	// Video content analysis task parameter.
	AiAnalysisTask *ProcessMediaOperationAiAnalysisTask `pulumi:"aiAnalysisTask"`
	// Type parameter of a video content audit task.
	AiContentReviewTask *ProcessMediaOperationAiContentReviewTask `pulumi:"aiContentReviewTask"`
	// The parameters of a quality control task.
	AiQualityControlTask *ProcessMediaOperationAiQualityControlTask `pulumi:"aiQualityControlTask"`
	// Type parameter of a video content recognition task.
	AiRecognitionTask *ProcessMediaOperationAiRecognitionTask `pulumi:"aiRecognitionTask"`
	// The information of the file to process.
	InputInfo ProcessMediaOperationInputInfo `pulumi:"inputInfo"`
	// The media processing parameters to use.
	MediaProcessTask *ProcessMediaOperationMediaProcessTask `pulumi:"mediaProcessTask"`
	// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this parameter, the file will be saved to the directory specified in `InputInfo`.
	OutputDir *string `pulumi:"outputDir"`
	// The storage location of the media processing output file. If this parameter is left empty, the storage location in `InputInfo` will be inherited.
	OutputStorage *ProcessMediaOperationOutputStorage `pulumi:"outputStorage"`
	// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.Note 3: The trigger configured for a scheme is for automatically starting a scheme. It stops working when you manually call this API to start a scheme.
	ScheduleId *int `pulumi:"scheduleId"`
	// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
	SessionContext *string `pulumi:"sessionContext"`
	// The ID used for deduplication. If there was a request with the same ID in the last three days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
	SessionId *string `pulumi:"sessionId"`
	// Event notification information of a task. If this parameter is left empty, no event notifications will be obtained.
	TaskNotifyConfig *ProcessMediaOperationTaskNotifyConfig `pulumi:"taskNotifyConfig"`
	// The task type. `Online` (default): A task that is executed immediately. `Offline`: A task that is executed when the system is idle (within three days by default).
	TaskType *string `pulumi:"taskType"`
	// Task flow priority. The higher the value, the higher the priority. Value range: [-10, 10]. If this parameter is left empty, 0 will be used.
	TasksPriority *int `pulumi:"tasksPriority"`
}

// The set of arguments for constructing a ProcessMediaOperation resource.
type ProcessMediaOperationArgs struct {
	// Video content analysis task parameter.
	AiAnalysisTask ProcessMediaOperationAiAnalysisTaskPtrInput
	// Type parameter of a video content audit task.
	AiContentReviewTask ProcessMediaOperationAiContentReviewTaskPtrInput
	// The parameters of a quality control task.
	AiQualityControlTask ProcessMediaOperationAiQualityControlTaskPtrInput
	// Type parameter of a video content recognition task.
	AiRecognitionTask ProcessMediaOperationAiRecognitionTaskPtrInput
	// The information of the file to process.
	InputInfo ProcessMediaOperationInputInfoInput
	// The media processing parameters to use.
	MediaProcessTask ProcessMediaOperationMediaProcessTaskPtrInput
	// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this parameter, the file will be saved to the directory specified in `InputInfo`.
	OutputDir pulumi.StringPtrInput
	// The storage location of the media processing output file. If this parameter is left empty, the storage location in `InputInfo` will be inherited.
	OutputStorage ProcessMediaOperationOutputStoragePtrInput
	// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.Note 3: The trigger configured for a scheme is for automatically starting a scheme. It stops working when you manually call this API to start a scheme.
	ScheduleId pulumi.IntPtrInput
	// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
	SessionContext pulumi.StringPtrInput
	// The ID used for deduplication. If there was a request with the same ID in the last three days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
	SessionId pulumi.StringPtrInput
	// Event notification information of a task. If this parameter is left empty, no event notifications will be obtained.
	TaskNotifyConfig ProcessMediaOperationTaskNotifyConfigPtrInput
	// The task type. `Online` (default): A task that is executed immediately. `Offline`: A task that is executed when the system is idle (within three days by default).
	TaskType pulumi.StringPtrInput
	// Task flow priority. The higher the value, the higher the priority. Value range: [-10, 10]. If this parameter is left empty, 0 will be used.
	TasksPriority pulumi.IntPtrInput
}

func (ProcessMediaOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*processMediaOperationArgs)(nil)).Elem()
}

type ProcessMediaOperationInput interface {
	pulumi.Input

	ToProcessMediaOperationOutput() ProcessMediaOperationOutput
	ToProcessMediaOperationOutputWithContext(ctx context.Context) ProcessMediaOperationOutput
}

func (*ProcessMediaOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**ProcessMediaOperation)(nil)).Elem()
}

func (i *ProcessMediaOperation) ToProcessMediaOperationOutput() ProcessMediaOperationOutput {
	return i.ToProcessMediaOperationOutputWithContext(context.Background())
}

func (i *ProcessMediaOperation) ToProcessMediaOperationOutputWithContext(ctx context.Context) ProcessMediaOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProcessMediaOperationOutput)
}

// ProcessMediaOperationArrayInput is an input type that accepts ProcessMediaOperationArray and ProcessMediaOperationArrayOutput values.
// You can construct a concrete instance of `ProcessMediaOperationArrayInput` via:
//
//	ProcessMediaOperationArray{ ProcessMediaOperationArgs{...} }
type ProcessMediaOperationArrayInput interface {
	pulumi.Input

	ToProcessMediaOperationArrayOutput() ProcessMediaOperationArrayOutput
	ToProcessMediaOperationArrayOutputWithContext(context.Context) ProcessMediaOperationArrayOutput
}

type ProcessMediaOperationArray []ProcessMediaOperationInput

func (ProcessMediaOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProcessMediaOperation)(nil)).Elem()
}

func (i ProcessMediaOperationArray) ToProcessMediaOperationArrayOutput() ProcessMediaOperationArrayOutput {
	return i.ToProcessMediaOperationArrayOutputWithContext(context.Background())
}

func (i ProcessMediaOperationArray) ToProcessMediaOperationArrayOutputWithContext(ctx context.Context) ProcessMediaOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProcessMediaOperationArrayOutput)
}

// ProcessMediaOperationMapInput is an input type that accepts ProcessMediaOperationMap and ProcessMediaOperationMapOutput values.
// You can construct a concrete instance of `ProcessMediaOperationMapInput` via:
//
//	ProcessMediaOperationMap{ "key": ProcessMediaOperationArgs{...} }
type ProcessMediaOperationMapInput interface {
	pulumi.Input

	ToProcessMediaOperationMapOutput() ProcessMediaOperationMapOutput
	ToProcessMediaOperationMapOutputWithContext(context.Context) ProcessMediaOperationMapOutput
}

type ProcessMediaOperationMap map[string]ProcessMediaOperationInput

func (ProcessMediaOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProcessMediaOperation)(nil)).Elem()
}

func (i ProcessMediaOperationMap) ToProcessMediaOperationMapOutput() ProcessMediaOperationMapOutput {
	return i.ToProcessMediaOperationMapOutputWithContext(context.Background())
}

func (i ProcessMediaOperationMap) ToProcessMediaOperationMapOutputWithContext(ctx context.Context) ProcessMediaOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProcessMediaOperationMapOutput)
}

type ProcessMediaOperationOutput struct{ *pulumi.OutputState }

func (ProcessMediaOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ProcessMediaOperation)(nil)).Elem()
}

func (o ProcessMediaOperationOutput) ToProcessMediaOperationOutput() ProcessMediaOperationOutput {
	return o
}

func (o ProcessMediaOperationOutput) ToProcessMediaOperationOutputWithContext(ctx context.Context) ProcessMediaOperationOutput {
	return o
}

// Video content analysis task parameter.
func (o ProcessMediaOperationOutput) AiAnalysisTask() ProcessMediaOperationAiAnalysisTaskPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) ProcessMediaOperationAiAnalysisTaskPtrOutput { return v.AiAnalysisTask }).(ProcessMediaOperationAiAnalysisTaskPtrOutput)
}

// Type parameter of a video content audit task.
func (o ProcessMediaOperationOutput) AiContentReviewTask() ProcessMediaOperationAiContentReviewTaskPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) ProcessMediaOperationAiContentReviewTaskPtrOutput {
		return v.AiContentReviewTask
	}).(ProcessMediaOperationAiContentReviewTaskPtrOutput)
}

// The parameters of a quality control task.
func (o ProcessMediaOperationOutput) AiQualityControlTask() ProcessMediaOperationAiQualityControlTaskPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) ProcessMediaOperationAiQualityControlTaskPtrOutput {
		return v.AiQualityControlTask
	}).(ProcessMediaOperationAiQualityControlTaskPtrOutput)
}

// Type parameter of a video content recognition task.
func (o ProcessMediaOperationOutput) AiRecognitionTask() ProcessMediaOperationAiRecognitionTaskPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) ProcessMediaOperationAiRecognitionTaskPtrOutput {
		return v.AiRecognitionTask
	}).(ProcessMediaOperationAiRecognitionTaskPtrOutput)
}

// The information of the file to process.
func (o ProcessMediaOperationOutput) InputInfo() ProcessMediaOperationInputInfoOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) ProcessMediaOperationInputInfoOutput { return v.InputInfo }).(ProcessMediaOperationInputInfoOutput)
}

// The media processing parameters to use.
func (o ProcessMediaOperationOutput) MediaProcessTask() ProcessMediaOperationMediaProcessTaskPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) ProcessMediaOperationMediaProcessTaskPtrOutput {
		return v.MediaProcessTask
	}).(ProcessMediaOperationMediaProcessTaskPtrOutput)
}

// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this parameter, the file will be saved to the directory specified in `InputInfo`.
func (o ProcessMediaOperationOutput) OutputDir() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) pulumi.StringPtrOutput { return v.OutputDir }).(pulumi.StringPtrOutput)
}

// The storage location of the media processing output file. If this parameter is left empty, the storage location in `InputInfo` will be inherited.
func (o ProcessMediaOperationOutput) OutputStorage() ProcessMediaOperationOutputStoragePtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) ProcessMediaOperationOutputStoragePtrOutput { return v.OutputStorage }).(ProcessMediaOperationOutputStoragePtrOutput)
}

// The scheme ID.Note 1: About `OutputStorage` and `OutputDir`If an output storage and directory are specified for a subtask of the scheme, those output settings will be applied.If an output storage and directory are not specified for the subtasks of a scheme, the output parameters passed in the `ProcessMedia` API will be applied.Note 2: If `TaskNotifyConfig` is specified, the specified settings will be used instead of the default callback settings of the scheme.Note 3: The trigger configured for a scheme is for automatically starting a scheme. It stops working when you manually call this API to start a scheme.
func (o ProcessMediaOperationOutput) ScheduleId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) pulumi.IntPtrOutput { return v.ScheduleId }).(pulumi.IntPtrOutput)
}

// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
func (o ProcessMediaOperationOutput) SessionContext() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) pulumi.StringPtrOutput { return v.SessionContext }).(pulumi.StringPtrOutput)
}

// The ID used for deduplication. If there was a request with the same ID in the last three days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
func (o ProcessMediaOperationOutput) SessionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) pulumi.StringPtrOutput { return v.SessionId }).(pulumi.StringPtrOutput)
}

// Event notification information of a task. If this parameter is left empty, no event notifications will be obtained.
func (o ProcessMediaOperationOutput) TaskNotifyConfig() ProcessMediaOperationTaskNotifyConfigPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) ProcessMediaOperationTaskNotifyConfigPtrOutput {
		return v.TaskNotifyConfig
	}).(ProcessMediaOperationTaskNotifyConfigPtrOutput)
}

// The task type. `Online` (default): A task that is executed immediately. `Offline`: A task that is executed when the system is idle (within three days by default).
func (o ProcessMediaOperationOutput) TaskType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) pulumi.StringPtrOutput { return v.TaskType }).(pulumi.StringPtrOutput)
}

// Task flow priority. The higher the value, the higher the priority. Value range: [-10, 10]. If this parameter is left empty, 0 will be used.
func (o ProcessMediaOperationOutput) TasksPriority() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ProcessMediaOperation) pulumi.IntPtrOutput { return v.TasksPriority }).(pulumi.IntPtrOutput)
}

type ProcessMediaOperationArrayOutput struct{ *pulumi.OutputState }

func (ProcessMediaOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProcessMediaOperation)(nil)).Elem()
}

func (o ProcessMediaOperationArrayOutput) ToProcessMediaOperationArrayOutput() ProcessMediaOperationArrayOutput {
	return o
}

func (o ProcessMediaOperationArrayOutput) ToProcessMediaOperationArrayOutputWithContext(ctx context.Context) ProcessMediaOperationArrayOutput {
	return o
}

func (o ProcessMediaOperationArrayOutput) Index(i pulumi.IntInput) ProcessMediaOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ProcessMediaOperation {
		return vs[0].([]*ProcessMediaOperation)[vs[1].(int)]
	}).(ProcessMediaOperationOutput)
}

type ProcessMediaOperationMapOutput struct{ *pulumi.OutputState }

func (ProcessMediaOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProcessMediaOperation)(nil)).Elem()
}

func (o ProcessMediaOperationMapOutput) ToProcessMediaOperationMapOutput() ProcessMediaOperationMapOutput {
	return o
}

func (o ProcessMediaOperationMapOutput) ToProcessMediaOperationMapOutputWithContext(ctx context.Context) ProcessMediaOperationMapOutput {
	return o
}

func (o ProcessMediaOperationMapOutput) MapIndex(k pulumi.StringInput) ProcessMediaOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ProcessMediaOperation {
		return vs[0].(map[string]*ProcessMediaOperation)[vs[1].(string)]
	}).(ProcessMediaOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProcessMediaOperationInput)(nil)).Elem(), &ProcessMediaOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProcessMediaOperationArrayInput)(nil)).Elem(), ProcessMediaOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProcessMediaOperationMapInput)(nil)).Elem(), ProcessMediaOperationMap{})
	pulumi.RegisterOutputType(ProcessMediaOperationOutput{})
	pulumi.RegisterOutputType(ProcessMediaOperationArrayOutput{})
	pulumi.RegisterOutputType(ProcessMediaOperationMapOutput{})
}