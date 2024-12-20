// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package gaap

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a gaap global domain dns
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Gaap"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Gaap.NewGlobalDomainDns(ctx, "globalDomainDns", &Gaap.GlobalDomainDnsArgs{
//				DomainId: pulumi.String("dm-xxxxxx"),
//				NationCountryInnerCodes: pulumi.StringArray{
//					pulumi.String("101001"),
//				},
//				ProxyIdLists: pulumi.StringArray{
//					pulumi.String("link-xxxxxx"),
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
//
// ## Import
//
// gaap global_domain_dns can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Gaap/globalDomainDns:GlobalDomainDns global_domain_dns ${domainId}#${dnsRecordId}
// ```
type GlobalDomainDns struct {
	pulumi.CustomResourceState

	// Domain Id.
	DomainId pulumi.StringOutput `pulumi:"domainId"`
	// Nation Country Inner Codes.
	NationCountryInnerCodes pulumi.StringArrayOutput `pulumi:"nationCountryInnerCodes"`
	// Proxy Id List.
	ProxyIdLists pulumi.StringArrayOutput `pulumi:"proxyIdLists"`
}

// NewGlobalDomainDns registers a new resource with the given unique name, arguments, and options.
func NewGlobalDomainDns(ctx *pulumi.Context,
	name string, args *GlobalDomainDnsArgs, opts ...pulumi.ResourceOption) (*GlobalDomainDns, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DomainId == nil {
		return nil, errors.New("invalid value for required argument 'DomainId'")
	}
	if args.NationCountryInnerCodes == nil {
		return nil, errors.New("invalid value for required argument 'NationCountryInnerCodes'")
	}
	if args.ProxyIdLists == nil {
		return nil, errors.New("invalid value for required argument 'ProxyIdLists'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource GlobalDomainDns
	err := ctx.RegisterResource("tencentcloud:Gaap/globalDomainDns:GlobalDomainDns", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGlobalDomainDns gets an existing GlobalDomainDns resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGlobalDomainDns(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GlobalDomainDnsState, opts ...pulumi.ResourceOption) (*GlobalDomainDns, error) {
	var resource GlobalDomainDns
	err := ctx.ReadResource("tencentcloud:Gaap/globalDomainDns:GlobalDomainDns", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GlobalDomainDns resources.
type globalDomainDnsState struct {
	// Domain Id.
	DomainId *string `pulumi:"domainId"`
	// Nation Country Inner Codes.
	NationCountryInnerCodes []string `pulumi:"nationCountryInnerCodes"`
	// Proxy Id List.
	ProxyIdLists []string `pulumi:"proxyIdLists"`
}

type GlobalDomainDnsState struct {
	// Domain Id.
	DomainId pulumi.StringPtrInput
	// Nation Country Inner Codes.
	NationCountryInnerCodes pulumi.StringArrayInput
	// Proxy Id List.
	ProxyIdLists pulumi.StringArrayInput
}

func (GlobalDomainDnsState) ElementType() reflect.Type {
	return reflect.TypeOf((*globalDomainDnsState)(nil)).Elem()
}

type globalDomainDnsArgs struct {
	// Domain Id.
	DomainId string `pulumi:"domainId"`
	// Nation Country Inner Codes.
	NationCountryInnerCodes []string `pulumi:"nationCountryInnerCodes"`
	// Proxy Id List.
	ProxyIdLists []string `pulumi:"proxyIdLists"`
}

// The set of arguments for constructing a GlobalDomainDns resource.
type GlobalDomainDnsArgs struct {
	// Domain Id.
	DomainId pulumi.StringInput
	// Nation Country Inner Codes.
	NationCountryInnerCodes pulumi.StringArrayInput
	// Proxy Id List.
	ProxyIdLists pulumi.StringArrayInput
}

func (GlobalDomainDnsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*globalDomainDnsArgs)(nil)).Elem()
}

type GlobalDomainDnsInput interface {
	pulumi.Input

	ToGlobalDomainDnsOutput() GlobalDomainDnsOutput
	ToGlobalDomainDnsOutputWithContext(ctx context.Context) GlobalDomainDnsOutput
}

func (*GlobalDomainDns) ElementType() reflect.Type {
	return reflect.TypeOf((**GlobalDomainDns)(nil)).Elem()
}

func (i *GlobalDomainDns) ToGlobalDomainDnsOutput() GlobalDomainDnsOutput {
	return i.ToGlobalDomainDnsOutputWithContext(context.Background())
}

func (i *GlobalDomainDns) ToGlobalDomainDnsOutputWithContext(ctx context.Context) GlobalDomainDnsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GlobalDomainDnsOutput)
}

// GlobalDomainDnsArrayInput is an input type that accepts GlobalDomainDnsArray and GlobalDomainDnsArrayOutput values.
// You can construct a concrete instance of `GlobalDomainDnsArrayInput` via:
//
//	GlobalDomainDnsArray{ GlobalDomainDnsArgs{...} }
type GlobalDomainDnsArrayInput interface {
	pulumi.Input

	ToGlobalDomainDnsArrayOutput() GlobalDomainDnsArrayOutput
	ToGlobalDomainDnsArrayOutputWithContext(context.Context) GlobalDomainDnsArrayOutput
}

type GlobalDomainDnsArray []GlobalDomainDnsInput

func (GlobalDomainDnsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*GlobalDomainDns)(nil)).Elem()
}

func (i GlobalDomainDnsArray) ToGlobalDomainDnsArrayOutput() GlobalDomainDnsArrayOutput {
	return i.ToGlobalDomainDnsArrayOutputWithContext(context.Background())
}

func (i GlobalDomainDnsArray) ToGlobalDomainDnsArrayOutputWithContext(ctx context.Context) GlobalDomainDnsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GlobalDomainDnsArrayOutput)
}

// GlobalDomainDnsMapInput is an input type that accepts GlobalDomainDnsMap and GlobalDomainDnsMapOutput values.
// You can construct a concrete instance of `GlobalDomainDnsMapInput` via:
//
//	GlobalDomainDnsMap{ "key": GlobalDomainDnsArgs{...} }
type GlobalDomainDnsMapInput interface {
	pulumi.Input

	ToGlobalDomainDnsMapOutput() GlobalDomainDnsMapOutput
	ToGlobalDomainDnsMapOutputWithContext(context.Context) GlobalDomainDnsMapOutput
}

type GlobalDomainDnsMap map[string]GlobalDomainDnsInput

func (GlobalDomainDnsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*GlobalDomainDns)(nil)).Elem()
}

func (i GlobalDomainDnsMap) ToGlobalDomainDnsMapOutput() GlobalDomainDnsMapOutput {
	return i.ToGlobalDomainDnsMapOutputWithContext(context.Background())
}

func (i GlobalDomainDnsMap) ToGlobalDomainDnsMapOutputWithContext(ctx context.Context) GlobalDomainDnsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GlobalDomainDnsMapOutput)
}

type GlobalDomainDnsOutput struct{ *pulumi.OutputState }

func (GlobalDomainDnsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**GlobalDomainDns)(nil)).Elem()
}

func (o GlobalDomainDnsOutput) ToGlobalDomainDnsOutput() GlobalDomainDnsOutput {
	return o
}

func (o GlobalDomainDnsOutput) ToGlobalDomainDnsOutputWithContext(ctx context.Context) GlobalDomainDnsOutput {
	return o
}

// Domain Id.
func (o GlobalDomainDnsOutput) DomainId() pulumi.StringOutput {
	return o.ApplyT(func(v *GlobalDomainDns) pulumi.StringOutput { return v.DomainId }).(pulumi.StringOutput)
}

// Nation Country Inner Codes.
func (o GlobalDomainDnsOutput) NationCountryInnerCodes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *GlobalDomainDns) pulumi.StringArrayOutput { return v.NationCountryInnerCodes }).(pulumi.StringArrayOutput)
}

// Proxy Id List.
func (o GlobalDomainDnsOutput) ProxyIdLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *GlobalDomainDns) pulumi.StringArrayOutput { return v.ProxyIdLists }).(pulumi.StringArrayOutput)
}

type GlobalDomainDnsArrayOutput struct{ *pulumi.OutputState }

func (GlobalDomainDnsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*GlobalDomainDns)(nil)).Elem()
}

func (o GlobalDomainDnsArrayOutput) ToGlobalDomainDnsArrayOutput() GlobalDomainDnsArrayOutput {
	return o
}

func (o GlobalDomainDnsArrayOutput) ToGlobalDomainDnsArrayOutputWithContext(ctx context.Context) GlobalDomainDnsArrayOutput {
	return o
}

func (o GlobalDomainDnsArrayOutput) Index(i pulumi.IntInput) GlobalDomainDnsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *GlobalDomainDns {
		return vs[0].([]*GlobalDomainDns)[vs[1].(int)]
	}).(GlobalDomainDnsOutput)
}

type GlobalDomainDnsMapOutput struct{ *pulumi.OutputState }

func (GlobalDomainDnsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*GlobalDomainDns)(nil)).Elem()
}

func (o GlobalDomainDnsMapOutput) ToGlobalDomainDnsMapOutput() GlobalDomainDnsMapOutput {
	return o
}

func (o GlobalDomainDnsMapOutput) ToGlobalDomainDnsMapOutputWithContext(ctx context.Context) GlobalDomainDnsMapOutput {
	return o
}

func (o GlobalDomainDnsMapOutput) MapIndex(k pulumi.StringInput) GlobalDomainDnsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *GlobalDomainDns {
		return vs[0].(map[string]*GlobalDomainDns)[vs[1].(string)]
	}).(GlobalDomainDnsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GlobalDomainDnsInput)(nil)).Elem(), &GlobalDomainDns{})
	pulumi.RegisterInputType(reflect.TypeOf((*GlobalDomainDnsArrayInput)(nil)).Elem(), GlobalDomainDnsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*GlobalDomainDnsMapInput)(nil)).Elem(), GlobalDomainDnsMap{})
	pulumi.RegisterOutputType(GlobalDomainDnsOutput{})
	pulumi.RegisterOutputType(GlobalDomainDnsArrayOutput{})
	pulumi.RegisterOutputType(GlobalDomainDnsMapOutput{})
}
