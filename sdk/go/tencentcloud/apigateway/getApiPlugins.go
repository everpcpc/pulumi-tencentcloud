// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package apigateway

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of apiGateway apiPlugins
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/ApiGateway"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := ApiGateway.GetApiPlugins(ctx, &apigateway.GetApiPluginsArgs{
//				ApiId:           "api-0cvmf4x4",
//				EnvironmentName: pulumi.StringRef("test"),
//				ServiceId:       "service-nxz6yync",
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
func LookupApiPlugins(ctx *pulumi.Context, args *LookupApiPluginsArgs, opts ...pulumi.InvokeOption) (*LookupApiPluginsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupApiPluginsResult
	err := ctx.Invoke("tencentcloud:ApiGateway/getApiPlugins:getApiPlugins", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getApiPlugins.
type LookupApiPluginsArgs struct {
	// API ID to be queried.
	ApiId string `pulumi:"apiId"`
	// Environment information.
	EnvironmentName *string `pulumi:"environmentName"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// The service ID to be queried.
	ServiceId string `pulumi:"serviceId"`
}

// A collection of values returned by getApiPlugins.
type LookupApiPluginsResult struct {
	ApiId           string  `pulumi:"apiId"`
	EnvironmentName *string `pulumi:"environmentName"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// API list information that the plug-in can bind.
	Results   []GetApiPluginsResult `pulumi:"results"`
	ServiceId string                `pulumi:"serviceId"`
}

func LookupApiPluginsOutput(ctx *pulumi.Context, args LookupApiPluginsOutputArgs, opts ...pulumi.InvokeOption) LookupApiPluginsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupApiPluginsResult, error) {
			args := v.(LookupApiPluginsArgs)
			r, err := LookupApiPlugins(ctx, &args, opts...)
			var s LookupApiPluginsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupApiPluginsResultOutput)
}

// A collection of arguments for invoking getApiPlugins.
type LookupApiPluginsOutputArgs struct {
	// API ID to be queried.
	ApiId pulumi.StringInput `pulumi:"apiId"`
	// Environment information.
	EnvironmentName pulumi.StringPtrInput `pulumi:"environmentName"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// The service ID to be queried.
	ServiceId pulumi.StringInput `pulumi:"serviceId"`
}

func (LookupApiPluginsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupApiPluginsArgs)(nil)).Elem()
}

// A collection of values returned by getApiPlugins.
type LookupApiPluginsResultOutput struct{ *pulumi.OutputState }

func (LookupApiPluginsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupApiPluginsResult)(nil)).Elem()
}

func (o LookupApiPluginsResultOutput) ToLookupApiPluginsResultOutput() LookupApiPluginsResultOutput {
	return o
}

func (o LookupApiPluginsResultOutput) ToLookupApiPluginsResultOutputWithContext(ctx context.Context) LookupApiPluginsResultOutput {
	return o
}

func (o LookupApiPluginsResultOutput) ApiId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApiPluginsResult) string { return v.ApiId }).(pulumi.StringOutput)
}

func (o LookupApiPluginsResultOutput) EnvironmentName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupApiPluginsResult) *string { return v.EnvironmentName }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupApiPluginsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApiPluginsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupApiPluginsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupApiPluginsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// API list information that the plug-in can bind.
func (o LookupApiPluginsResultOutput) Results() GetApiPluginsResultArrayOutput {
	return o.ApplyT(func(v LookupApiPluginsResult) []GetApiPluginsResult { return v.Results }).(GetApiPluginsResultArrayOutput)
}

func (o LookupApiPluginsResultOutput) ServiceId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApiPluginsResult) string { return v.ServiceId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupApiPluginsResultOutput{})
}