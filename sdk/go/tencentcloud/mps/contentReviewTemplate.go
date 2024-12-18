// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mps

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a mps contentReviewTemplate
//
// ## Import
//
// mps content_review_template can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Mps/contentReviewTemplate:ContentReviewTemplate content_review_template definition
// ```
type ContentReviewTemplate struct {
	pulumi.CustomResourceState

	// Content review template description information, length limit: 256 characters.
	Comment pulumi.StringPtrOutput `pulumi:"comment"`
	// Content review template name, length limit: 64 characters.
	Name pulumi.StringOutput `pulumi:"name"`
	// Political control parameters.
	PoliticalConfigure ContentReviewTemplatePoliticalConfigurePtrOutput `pulumi:"politicalConfigure"`
	// Control parameters for porn image.
	PornConfigure ContentReviewTemplatePornConfigurePtrOutput `pulumi:"pornConfigure"`
	// Prohibited control parameters. Prohibited content includes:abuse, drug-related violations.Note: this parameter is not yet supported.
	ProhibitedConfigure ContentReviewTemplateProhibitedConfigurePtrOutput `pulumi:"prohibitedConfigure"`
	// Control parameters for unsafe information.
	TerrorismConfigure ContentReviewTemplateTerrorismConfigurePtrOutput `pulumi:"terrorismConfigure"`
	// User-Defined Content Moderation Control Parameters.
	UserDefineConfigure ContentReviewTemplateUserDefineConfigurePtrOutput `pulumi:"userDefineConfigure"`
}

// NewContentReviewTemplate registers a new resource with the given unique name, arguments, and options.
func NewContentReviewTemplate(ctx *pulumi.Context,
	name string, args *ContentReviewTemplateArgs, opts ...pulumi.ResourceOption) (*ContentReviewTemplate, error) {
	if args == nil {
		args = &ContentReviewTemplateArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ContentReviewTemplate
	err := ctx.RegisterResource("tencentcloud:Mps/contentReviewTemplate:ContentReviewTemplate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContentReviewTemplate gets an existing ContentReviewTemplate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContentReviewTemplate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContentReviewTemplateState, opts ...pulumi.ResourceOption) (*ContentReviewTemplate, error) {
	var resource ContentReviewTemplate
	err := ctx.ReadResource("tencentcloud:Mps/contentReviewTemplate:ContentReviewTemplate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ContentReviewTemplate resources.
type contentReviewTemplateState struct {
	// Content review template description information, length limit: 256 characters.
	Comment *string `pulumi:"comment"`
	// Content review template name, length limit: 64 characters.
	Name *string `pulumi:"name"`
	// Political control parameters.
	PoliticalConfigure *ContentReviewTemplatePoliticalConfigure `pulumi:"politicalConfigure"`
	// Control parameters for porn image.
	PornConfigure *ContentReviewTemplatePornConfigure `pulumi:"pornConfigure"`
	// Prohibited control parameters. Prohibited content includes:abuse, drug-related violations.Note: this parameter is not yet supported.
	ProhibitedConfigure *ContentReviewTemplateProhibitedConfigure `pulumi:"prohibitedConfigure"`
	// Control parameters for unsafe information.
	TerrorismConfigure *ContentReviewTemplateTerrorismConfigure `pulumi:"terrorismConfigure"`
	// User-Defined Content Moderation Control Parameters.
	UserDefineConfigure *ContentReviewTemplateUserDefineConfigure `pulumi:"userDefineConfigure"`
}

type ContentReviewTemplateState struct {
	// Content review template description information, length limit: 256 characters.
	Comment pulumi.StringPtrInput
	// Content review template name, length limit: 64 characters.
	Name pulumi.StringPtrInput
	// Political control parameters.
	PoliticalConfigure ContentReviewTemplatePoliticalConfigurePtrInput
	// Control parameters for porn image.
	PornConfigure ContentReviewTemplatePornConfigurePtrInput
	// Prohibited control parameters. Prohibited content includes:abuse, drug-related violations.Note: this parameter is not yet supported.
	ProhibitedConfigure ContentReviewTemplateProhibitedConfigurePtrInput
	// Control parameters for unsafe information.
	TerrorismConfigure ContentReviewTemplateTerrorismConfigurePtrInput
	// User-Defined Content Moderation Control Parameters.
	UserDefineConfigure ContentReviewTemplateUserDefineConfigurePtrInput
}

func (ContentReviewTemplateState) ElementType() reflect.Type {
	return reflect.TypeOf((*contentReviewTemplateState)(nil)).Elem()
}

type contentReviewTemplateArgs struct {
	// Content review template description information, length limit: 256 characters.
	Comment *string `pulumi:"comment"`
	// Content review template name, length limit: 64 characters.
	Name *string `pulumi:"name"`
	// Political control parameters.
	PoliticalConfigure *ContentReviewTemplatePoliticalConfigure `pulumi:"politicalConfigure"`
	// Control parameters for porn image.
	PornConfigure *ContentReviewTemplatePornConfigure `pulumi:"pornConfigure"`
	// Prohibited control parameters. Prohibited content includes:abuse, drug-related violations.Note: this parameter is not yet supported.
	ProhibitedConfigure *ContentReviewTemplateProhibitedConfigure `pulumi:"prohibitedConfigure"`
	// Control parameters for unsafe information.
	TerrorismConfigure *ContentReviewTemplateTerrorismConfigure `pulumi:"terrorismConfigure"`
	// User-Defined Content Moderation Control Parameters.
	UserDefineConfigure *ContentReviewTemplateUserDefineConfigure `pulumi:"userDefineConfigure"`
}

// The set of arguments for constructing a ContentReviewTemplate resource.
type ContentReviewTemplateArgs struct {
	// Content review template description information, length limit: 256 characters.
	Comment pulumi.StringPtrInput
	// Content review template name, length limit: 64 characters.
	Name pulumi.StringPtrInput
	// Political control parameters.
	PoliticalConfigure ContentReviewTemplatePoliticalConfigurePtrInput
	// Control parameters for porn image.
	PornConfigure ContentReviewTemplatePornConfigurePtrInput
	// Prohibited control parameters. Prohibited content includes:abuse, drug-related violations.Note: this parameter is not yet supported.
	ProhibitedConfigure ContentReviewTemplateProhibitedConfigurePtrInput
	// Control parameters for unsafe information.
	TerrorismConfigure ContentReviewTemplateTerrorismConfigurePtrInput
	// User-Defined Content Moderation Control Parameters.
	UserDefineConfigure ContentReviewTemplateUserDefineConfigurePtrInput
}

func (ContentReviewTemplateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*contentReviewTemplateArgs)(nil)).Elem()
}

type ContentReviewTemplateInput interface {
	pulumi.Input

	ToContentReviewTemplateOutput() ContentReviewTemplateOutput
	ToContentReviewTemplateOutputWithContext(ctx context.Context) ContentReviewTemplateOutput
}

func (*ContentReviewTemplate) ElementType() reflect.Type {
	return reflect.TypeOf((**ContentReviewTemplate)(nil)).Elem()
}

func (i *ContentReviewTemplate) ToContentReviewTemplateOutput() ContentReviewTemplateOutput {
	return i.ToContentReviewTemplateOutputWithContext(context.Background())
}

func (i *ContentReviewTemplate) ToContentReviewTemplateOutputWithContext(ctx context.Context) ContentReviewTemplateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContentReviewTemplateOutput)
}

// ContentReviewTemplateArrayInput is an input type that accepts ContentReviewTemplateArray and ContentReviewTemplateArrayOutput values.
// You can construct a concrete instance of `ContentReviewTemplateArrayInput` via:
//
//	ContentReviewTemplateArray{ ContentReviewTemplateArgs{...} }
type ContentReviewTemplateArrayInput interface {
	pulumi.Input

	ToContentReviewTemplateArrayOutput() ContentReviewTemplateArrayOutput
	ToContentReviewTemplateArrayOutputWithContext(context.Context) ContentReviewTemplateArrayOutput
}

type ContentReviewTemplateArray []ContentReviewTemplateInput

func (ContentReviewTemplateArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContentReviewTemplate)(nil)).Elem()
}

func (i ContentReviewTemplateArray) ToContentReviewTemplateArrayOutput() ContentReviewTemplateArrayOutput {
	return i.ToContentReviewTemplateArrayOutputWithContext(context.Background())
}

func (i ContentReviewTemplateArray) ToContentReviewTemplateArrayOutputWithContext(ctx context.Context) ContentReviewTemplateArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContentReviewTemplateArrayOutput)
}

// ContentReviewTemplateMapInput is an input type that accepts ContentReviewTemplateMap and ContentReviewTemplateMapOutput values.
// You can construct a concrete instance of `ContentReviewTemplateMapInput` via:
//
//	ContentReviewTemplateMap{ "key": ContentReviewTemplateArgs{...} }
type ContentReviewTemplateMapInput interface {
	pulumi.Input

	ToContentReviewTemplateMapOutput() ContentReviewTemplateMapOutput
	ToContentReviewTemplateMapOutputWithContext(context.Context) ContentReviewTemplateMapOutput
}

type ContentReviewTemplateMap map[string]ContentReviewTemplateInput

func (ContentReviewTemplateMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContentReviewTemplate)(nil)).Elem()
}

func (i ContentReviewTemplateMap) ToContentReviewTemplateMapOutput() ContentReviewTemplateMapOutput {
	return i.ToContentReviewTemplateMapOutputWithContext(context.Background())
}

func (i ContentReviewTemplateMap) ToContentReviewTemplateMapOutputWithContext(ctx context.Context) ContentReviewTemplateMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContentReviewTemplateMapOutput)
}

type ContentReviewTemplateOutput struct{ *pulumi.OutputState }

func (ContentReviewTemplateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ContentReviewTemplate)(nil)).Elem()
}

func (o ContentReviewTemplateOutput) ToContentReviewTemplateOutput() ContentReviewTemplateOutput {
	return o
}

func (o ContentReviewTemplateOutput) ToContentReviewTemplateOutputWithContext(ctx context.Context) ContentReviewTemplateOutput {
	return o
}

// Content review template description information, length limit: 256 characters.
func (o ContentReviewTemplateOutput) Comment() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ContentReviewTemplate) pulumi.StringPtrOutput { return v.Comment }).(pulumi.StringPtrOutput)
}

// Content review template name, length limit: 64 characters.
func (o ContentReviewTemplateOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ContentReviewTemplate) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Political control parameters.
func (o ContentReviewTemplateOutput) PoliticalConfigure() ContentReviewTemplatePoliticalConfigurePtrOutput {
	return o.ApplyT(func(v *ContentReviewTemplate) ContentReviewTemplatePoliticalConfigurePtrOutput {
		return v.PoliticalConfigure
	}).(ContentReviewTemplatePoliticalConfigurePtrOutput)
}

// Control parameters for porn image.
func (o ContentReviewTemplateOutput) PornConfigure() ContentReviewTemplatePornConfigurePtrOutput {
	return o.ApplyT(func(v *ContentReviewTemplate) ContentReviewTemplatePornConfigurePtrOutput { return v.PornConfigure }).(ContentReviewTemplatePornConfigurePtrOutput)
}

// Prohibited control parameters. Prohibited content includes:abuse, drug-related violations.Note: this parameter is not yet supported.
func (o ContentReviewTemplateOutput) ProhibitedConfigure() ContentReviewTemplateProhibitedConfigurePtrOutput {
	return o.ApplyT(func(v *ContentReviewTemplate) ContentReviewTemplateProhibitedConfigurePtrOutput {
		return v.ProhibitedConfigure
	}).(ContentReviewTemplateProhibitedConfigurePtrOutput)
}

// Control parameters for unsafe information.
func (o ContentReviewTemplateOutput) TerrorismConfigure() ContentReviewTemplateTerrorismConfigurePtrOutput {
	return o.ApplyT(func(v *ContentReviewTemplate) ContentReviewTemplateTerrorismConfigurePtrOutput {
		return v.TerrorismConfigure
	}).(ContentReviewTemplateTerrorismConfigurePtrOutput)
}

// User-Defined Content Moderation Control Parameters.
func (o ContentReviewTemplateOutput) UserDefineConfigure() ContentReviewTemplateUserDefineConfigurePtrOutput {
	return o.ApplyT(func(v *ContentReviewTemplate) ContentReviewTemplateUserDefineConfigurePtrOutput {
		return v.UserDefineConfigure
	}).(ContentReviewTemplateUserDefineConfigurePtrOutput)
}

type ContentReviewTemplateArrayOutput struct{ *pulumi.OutputState }

func (ContentReviewTemplateArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContentReviewTemplate)(nil)).Elem()
}

func (o ContentReviewTemplateArrayOutput) ToContentReviewTemplateArrayOutput() ContentReviewTemplateArrayOutput {
	return o
}

func (o ContentReviewTemplateArrayOutput) ToContentReviewTemplateArrayOutputWithContext(ctx context.Context) ContentReviewTemplateArrayOutput {
	return o
}

func (o ContentReviewTemplateArrayOutput) Index(i pulumi.IntInput) ContentReviewTemplateOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ContentReviewTemplate {
		return vs[0].([]*ContentReviewTemplate)[vs[1].(int)]
	}).(ContentReviewTemplateOutput)
}

type ContentReviewTemplateMapOutput struct{ *pulumi.OutputState }

func (ContentReviewTemplateMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContentReviewTemplate)(nil)).Elem()
}

func (o ContentReviewTemplateMapOutput) ToContentReviewTemplateMapOutput() ContentReviewTemplateMapOutput {
	return o
}

func (o ContentReviewTemplateMapOutput) ToContentReviewTemplateMapOutputWithContext(ctx context.Context) ContentReviewTemplateMapOutput {
	return o
}

func (o ContentReviewTemplateMapOutput) MapIndex(k pulumi.StringInput) ContentReviewTemplateOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ContentReviewTemplate {
		return vs[0].(map[string]*ContentReviewTemplate)[vs[1].(string)]
	}).(ContentReviewTemplateOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ContentReviewTemplateInput)(nil)).Elem(), &ContentReviewTemplate{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContentReviewTemplateArrayInput)(nil)).Elem(), ContentReviewTemplateArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContentReviewTemplateMapInput)(nil)).Elem(), ContentReviewTemplateMap{})
	pulumi.RegisterOutputType(ContentReviewTemplateOutput{})
	pulumi.RegisterOutputType(ContentReviewTemplateArrayOutput{})
	pulumi.RegisterOutputType(ContentReviewTemplateMapOutput{})
}
