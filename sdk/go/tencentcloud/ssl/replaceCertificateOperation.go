// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ssl

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a ssl replaceCertificate
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Ssl"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Ssl.NewReplaceCertificateOperation(ctx, "replaceCertificate", &Ssl.ReplaceCertificateOperationArgs{
//				CertificateId: pulumi.String("8L6JsWq2"),
//				CsrType:       pulumi.String("online"),
//				ValidType:     pulumi.String("DNS_AUTO"),
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
//
// ## Import
//
// ssl replace_certificate can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Ssl/replaceCertificateOperation:ReplaceCertificateOperation replace_certificate replace_certificate_id
// ```
type ReplaceCertificateOperation struct {
	pulumi.CustomResourceState

	// CSR encryption method, optional: RSA, ECC, SM2. (Selectable only if CsrType is Online), default is RSA.
	CertCsrEncryptAlgo pulumi.StringPtrOutput `pulumi:"certCsrEncryptAlgo"`
	// CSR encryption parameter, when CsrEncryptAlgo is RSA, you can choose 2048, 4096, etc., and the default is 2048; when CsrEncryptAlgo is ECC, you can choose prime256v1, secp384r1, etc., and the default is prime256v1;.
	CertCsrKeyParameter pulumi.StringPtrOutput `pulumi:"certCsrKeyParameter"`
	// Certificate ID.
	CertificateId pulumi.StringOutput `pulumi:"certificateId"`
	// CSR Content.
	CsrContent pulumi.StringPtrOutput `pulumi:"csrContent"`
	// KEY Password.
	CsrKeyPassword pulumi.StringPtrOutput `pulumi:"csrKeyPassword"`
	// Type, default Original. Available options: Original = original certificate CSR, Upload = manual upload, Online = online generation.
	CsrType pulumi.StringPtrOutput `pulumi:"csrType"`
	// Reason for reissue.
	Reason pulumi.StringPtrOutput `pulumi:"reason"`
	// Verification type: DNS_AUTO = automatic DNS verification (this verification type is only supported for domain names that are resolved by Tencent Cloud and have normal resolution status), DNS = manual DNS verification, FILE = file verification.
	ValidType pulumi.StringOutput `pulumi:"validType"`
}

// NewReplaceCertificateOperation registers a new resource with the given unique name, arguments, and options.
func NewReplaceCertificateOperation(ctx *pulumi.Context,
	name string, args *ReplaceCertificateOperationArgs, opts ...pulumi.ResourceOption) (*ReplaceCertificateOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CertificateId == nil {
		return nil, errors.New("invalid value for required argument 'CertificateId'")
	}
	if args.ValidType == nil {
		return nil, errors.New("invalid value for required argument 'ValidType'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ReplaceCertificateOperation
	err := ctx.RegisterResource("tencentcloud:Ssl/replaceCertificateOperation:ReplaceCertificateOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetReplaceCertificateOperation gets an existing ReplaceCertificateOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetReplaceCertificateOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ReplaceCertificateOperationState, opts ...pulumi.ResourceOption) (*ReplaceCertificateOperation, error) {
	var resource ReplaceCertificateOperation
	err := ctx.ReadResource("tencentcloud:Ssl/replaceCertificateOperation:ReplaceCertificateOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ReplaceCertificateOperation resources.
type replaceCertificateOperationState struct {
	// CSR encryption method, optional: RSA, ECC, SM2. (Selectable only if CsrType is Online), default is RSA.
	CertCsrEncryptAlgo *string `pulumi:"certCsrEncryptAlgo"`
	// CSR encryption parameter, when CsrEncryptAlgo is RSA, you can choose 2048, 4096, etc., and the default is 2048; when CsrEncryptAlgo is ECC, you can choose prime256v1, secp384r1, etc., and the default is prime256v1;.
	CertCsrKeyParameter *string `pulumi:"certCsrKeyParameter"`
	// Certificate ID.
	CertificateId *string `pulumi:"certificateId"`
	// CSR Content.
	CsrContent *string `pulumi:"csrContent"`
	// KEY Password.
	CsrKeyPassword *string `pulumi:"csrKeyPassword"`
	// Type, default Original. Available options: Original = original certificate CSR, Upload = manual upload, Online = online generation.
	CsrType *string `pulumi:"csrType"`
	// Reason for reissue.
	Reason *string `pulumi:"reason"`
	// Verification type: DNS_AUTO = automatic DNS verification (this verification type is only supported for domain names that are resolved by Tencent Cloud and have normal resolution status), DNS = manual DNS verification, FILE = file verification.
	ValidType *string `pulumi:"validType"`
}

type ReplaceCertificateOperationState struct {
	// CSR encryption method, optional: RSA, ECC, SM2. (Selectable only if CsrType is Online), default is RSA.
	CertCsrEncryptAlgo pulumi.StringPtrInput
	// CSR encryption parameter, when CsrEncryptAlgo is RSA, you can choose 2048, 4096, etc., and the default is 2048; when CsrEncryptAlgo is ECC, you can choose prime256v1, secp384r1, etc., and the default is prime256v1;.
	CertCsrKeyParameter pulumi.StringPtrInput
	// Certificate ID.
	CertificateId pulumi.StringPtrInput
	// CSR Content.
	CsrContent pulumi.StringPtrInput
	// KEY Password.
	CsrKeyPassword pulumi.StringPtrInput
	// Type, default Original. Available options: Original = original certificate CSR, Upload = manual upload, Online = online generation.
	CsrType pulumi.StringPtrInput
	// Reason for reissue.
	Reason pulumi.StringPtrInput
	// Verification type: DNS_AUTO = automatic DNS verification (this verification type is only supported for domain names that are resolved by Tencent Cloud and have normal resolution status), DNS = manual DNS verification, FILE = file verification.
	ValidType pulumi.StringPtrInput
}

func (ReplaceCertificateOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*replaceCertificateOperationState)(nil)).Elem()
}

type replaceCertificateOperationArgs struct {
	// CSR encryption method, optional: RSA, ECC, SM2. (Selectable only if CsrType is Online), default is RSA.
	CertCsrEncryptAlgo *string `pulumi:"certCsrEncryptAlgo"`
	// CSR encryption parameter, when CsrEncryptAlgo is RSA, you can choose 2048, 4096, etc., and the default is 2048; when CsrEncryptAlgo is ECC, you can choose prime256v1, secp384r1, etc., and the default is prime256v1;.
	CertCsrKeyParameter *string `pulumi:"certCsrKeyParameter"`
	// Certificate ID.
	CertificateId string `pulumi:"certificateId"`
	// CSR Content.
	CsrContent *string `pulumi:"csrContent"`
	// KEY Password.
	CsrKeyPassword *string `pulumi:"csrKeyPassword"`
	// Type, default Original. Available options: Original = original certificate CSR, Upload = manual upload, Online = online generation.
	CsrType *string `pulumi:"csrType"`
	// Reason for reissue.
	Reason *string `pulumi:"reason"`
	// Verification type: DNS_AUTO = automatic DNS verification (this verification type is only supported for domain names that are resolved by Tencent Cloud and have normal resolution status), DNS = manual DNS verification, FILE = file verification.
	ValidType string `pulumi:"validType"`
}

// The set of arguments for constructing a ReplaceCertificateOperation resource.
type ReplaceCertificateOperationArgs struct {
	// CSR encryption method, optional: RSA, ECC, SM2. (Selectable only if CsrType is Online), default is RSA.
	CertCsrEncryptAlgo pulumi.StringPtrInput
	// CSR encryption parameter, when CsrEncryptAlgo is RSA, you can choose 2048, 4096, etc., and the default is 2048; when CsrEncryptAlgo is ECC, you can choose prime256v1, secp384r1, etc., and the default is prime256v1;.
	CertCsrKeyParameter pulumi.StringPtrInput
	// Certificate ID.
	CertificateId pulumi.StringInput
	// CSR Content.
	CsrContent pulumi.StringPtrInput
	// KEY Password.
	CsrKeyPassword pulumi.StringPtrInput
	// Type, default Original. Available options: Original = original certificate CSR, Upload = manual upload, Online = online generation.
	CsrType pulumi.StringPtrInput
	// Reason for reissue.
	Reason pulumi.StringPtrInput
	// Verification type: DNS_AUTO = automatic DNS verification (this verification type is only supported for domain names that are resolved by Tencent Cloud and have normal resolution status), DNS = manual DNS verification, FILE = file verification.
	ValidType pulumi.StringInput
}

func (ReplaceCertificateOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*replaceCertificateOperationArgs)(nil)).Elem()
}

type ReplaceCertificateOperationInput interface {
	pulumi.Input

	ToReplaceCertificateOperationOutput() ReplaceCertificateOperationOutput
	ToReplaceCertificateOperationOutputWithContext(ctx context.Context) ReplaceCertificateOperationOutput
}

func (*ReplaceCertificateOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**ReplaceCertificateOperation)(nil)).Elem()
}

func (i *ReplaceCertificateOperation) ToReplaceCertificateOperationOutput() ReplaceCertificateOperationOutput {
	return i.ToReplaceCertificateOperationOutputWithContext(context.Background())
}

func (i *ReplaceCertificateOperation) ToReplaceCertificateOperationOutputWithContext(ctx context.Context) ReplaceCertificateOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplaceCertificateOperationOutput)
}

// ReplaceCertificateOperationArrayInput is an input type that accepts ReplaceCertificateOperationArray and ReplaceCertificateOperationArrayOutput values.
// You can construct a concrete instance of `ReplaceCertificateOperationArrayInput` via:
//
//	ReplaceCertificateOperationArray{ ReplaceCertificateOperationArgs{...} }
type ReplaceCertificateOperationArrayInput interface {
	pulumi.Input

	ToReplaceCertificateOperationArrayOutput() ReplaceCertificateOperationArrayOutput
	ToReplaceCertificateOperationArrayOutputWithContext(context.Context) ReplaceCertificateOperationArrayOutput
}

type ReplaceCertificateOperationArray []ReplaceCertificateOperationInput

func (ReplaceCertificateOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ReplaceCertificateOperation)(nil)).Elem()
}

func (i ReplaceCertificateOperationArray) ToReplaceCertificateOperationArrayOutput() ReplaceCertificateOperationArrayOutput {
	return i.ToReplaceCertificateOperationArrayOutputWithContext(context.Background())
}

func (i ReplaceCertificateOperationArray) ToReplaceCertificateOperationArrayOutputWithContext(ctx context.Context) ReplaceCertificateOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplaceCertificateOperationArrayOutput)
}

// ReplaceCertificateOperationMapInput is an input type that accepts ReplaceCertificateOperationMap and ReplaceCertificateOperationMapOutput values.
// You can construct a concrete instance of `ReplaceCertificateOperationMapInput` via:
//
//	ReplaceCertificateOperationMap{ "key": ReplaceCertificateOperationArgs{...} }
type ReplaceCertificateOperationMapInput interface {
	pulumi.Input

	ToReplaceCertificateOperationMapOutput() ReplaceCertificateOperationMapOutput
	ToReplaceCertificateOperationMapOutputWithContext(context.Context) ReplaceCertificateOperationMapOutput
}

type ReplaceCertificateOperationMap map[string]ReplaceCertificateOperationInput

func (ReplaceCertificateOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ReplaceCertificateOperation)(nil)).Elem()
}

func (i ReplaceCertificateOperationMap) ToReplaceCertificateOperationMapOutput() ReplaceCertificateOperationMapOutput {
	return i.ToReplaceCertificateOperationMapOutputWithContext(context.Background())
}

func (i ReplaceCertificateOperationMap) ToReplaceCertificateOperationMapOutputWithContext(ctx context.Context) ReplaceCertificateOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplaceCertificateOperationMapOutput)
}

type ReplaceCertificateOperationOutput struct{ *pulumi.OutputState }

func (ReplaceCertificateOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ReplaceCertificateOperation)(nil)).Elem()
}

func (o ReplaceCertificateOperationOutput) ToReplaceCertificateOperationOutput() ReplaceCertificateOperationOutput {
	return o
}

func (o ReplaceCertificateOperationOutput) ToReplaceCertificateOperationOutputWithContext(ctx context.Context) ReplaceCertificateOperationOutput {
	return o
}

// CSR encryption method, optional: RSA, ECC, SM2. (Selectable only if CsrType is Online), default is RSA.
func (o ReplaceCertificateOperationOutput) CertCsrEncryptAlgo() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReplaceCertificateOperation) pulumi.StringPtrOutput { return v.CertCsrEncryptAlgo }).(pulumi.StringPtrOutput)
}

// CSR encryption parameter, when CsrEncryptAlgo is RSA, you can choose 2048, 4096, etc., and the default is 2048; when CsrEncryptAlgo is ECC, you can choose prime256v1, secp384r1, etc., and the default is prime256v1;.
func (o ReplaceCertificateOperationOutput) CertCsrKeyParameter() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReplaceCertificateOperation) pulumi.StringPtrOutput { return v.CertCsrKeyParameter }).(pulumi.StringPtrOutput)
}

// Certificate ID.
func (o ReplaceCertificateOperationOutput) CertificateId() pulumi.StringOutput {
	return o.ApplyT(func(v *ReplaceCertificateOperation) pulumi.StringOutput { return v.CertificateId }).(pulumi.StringOutput)
}

// CSR Content.
func (o ReplaceCertificateOperationOutput) CsrContent() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReplaceCertificateOperation) pulumi.StringPtrOutput { return v.CsrContent }).(pulumi.StringPtrOutput)
}

// KEY Password.
func (o ReplaceCertificateOperationOutput) CsrKeyPassword() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReplaceCertificateOperation) pulumi.StringPtrOutput { return v.CsrKeyPassword }).(pulumi.StringPtrOutput)
}

// Type, default Original. Available options: Original = original certificate CSR, Upload = manual upload, Online = online generation.
func (o ReplaceCertificateOperationOutput) CsrType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReplaceCertificateOperation) pulumi.StringPtrOutput { return v.CsrType }).(pulumi.StringPtrOutput)
}

// Reason for reissue.
func (o ReplaceCertificateOperationOutput) Reason() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReplaceCertificateOperation) pulumi.StringPtrOutput { return v.Reason }).(pulumi.StringPtrOutput)
}

// Verification type: DNS_AUTO = automatic DNS verification (this verification type is only supported for domain names that are resolved by Tencent Cloud and have normal resolution status), DNS = manual DNS verification, FILE = file verification.
func (o ReplaceCertificateOperationOutput) ValidType() pulumi.StringOutput {
	return o.ApplyT(func(v *ReplaceCertificateOperation) pulumi.StringOutput { return v.ValidType }).(pulumi.StringOutput)
}

type ReplaceCertificateOperationArrayOutput struct{ *pulumi.OutputState }

func (ReplaceCertificateOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ReplaceCertificateOperation)(nil)).Elem()
}

func (o ReplaceCertificateOperationArrayOutput) ToReplaceCertificateOperationArrayOutput() ReplaceCertificateOperationArrayOutput {
	return o
}

func (o ReplaceCertificateOperationArrayOutput) ToReplaceCertificateOperationArrayOutputWithContext(ctx context.Context) ReplaceCertificateOperationArrayOutput {
	return o
}

func (o ReplaceCertificateOperationArrayOutput) Index(i pulumi.IntInput) ReplaceCertificateOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ReplaceCertificateOperation {
		return vs[0].([]*ReplaceCertificateOperation)[vs[1].(int)]
	}).(ReplaceCertificateOperationOutput)
}

type ReplaceCertificateOperationMapOutput struct{ *pulumi.OutputState }

func (ReplaceCertificateOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ReplaceCertificateOperation)(nil)).Elem()
}

func (o ReplaceCertificateOperationMapOutput) ToReplaceCertificateOperationMapOutput() ReplaceCertificateOperationMapOutput {
	return o
}

func (o ReplaceCertificateOperationMapOutput) ToReplaceCertificateOperationMapOutputWithContext(ctx context.Context) ReplaceCertificateOperationMapOutput {
	return o
}

func (o ReplaceCertificateOperationMapOutput) MapIndex(k pulumi.StringInput) ReplaceCertificateOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ReplaceCertificateOperation {
		return vs[0].(map[string]*ReplaceCertificateOperation)[vs[1].(string)]
	}).(ReplaceCertificateOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ReplaceCertificateOperationInput)(nil)).Elem(), &ReplaceCertificateOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*ReplaceCertificateOperationArrayInput)(nil)).Elem(), ReplaceCertificateOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ReplaceCertificateOperationMapInput)(nil)).Elem(), ReplaceCertificateOperationMap{})
	pulumi.RegisterOutputType(ReplaceCertificateOperationOutput{})
	pulumi.RegisterOutputType(ReplaceCertificateOperationArrayOutput{})
	pulumi.RegisterOutputType(ReplaceCertificateOperationMapOutput{})
}
