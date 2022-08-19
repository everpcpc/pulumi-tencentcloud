// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cos

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query the metadata of an object stored inside a bucket.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Cos"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cos"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Cos.GetBucketObject(ctx, &cos.GetBucketObjectArgs{
// 			Bucket:           "mycos-test-1258798060",
// 			Key:              "hello-world.py",
// 			ResultOutputFile: pulumi.StringRef("TFresults"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupBucketObject(ctx *pulumi.Context, args *LookupBucketObjectArgs, opts ...pulumi.InvokeOption) (*LookupBucketObjectResult, error) {
	var rv LookupBucketObjectResult
	err := ctx.Invoke("tencentcloud:Cos/getBucketObject:getBucketObject", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBucketObject.
type LookupBucketObjectArgs struct {
	// Name of the bucket that contains the objects to query.
	Bucket string `pulumi:"bucket"`
	// The full path to the object inside the bucket.
	Key string `pulumi:"key"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getBucketObject.
type LookupBucketObjectResult struct {
	Bucket string `pulumi:"bucket"`
	// Specifies caching behavior along the request/reply chain.
	CacheControl string `pulumi:"cacheControl"`
	// Specifies presentational information for the object.
	ContentDisposition string `pulumi:"contentDisposition"`
	// Specifies what content encodings have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field.
	ContentEncoding string `pulumi:"contentEncoding"`
	// A standard MIME type describing the format of the object data.
	ContentType string `pulumi:"contentType"`
	// ETag generated for the object, which is may not equal to MD5 value.
	Etag string `pulumi:"etag"`
	// The provider-assigned unique ID for this managed resource.
	Id  string `pulumi:"id"`
	Key string `pulumi:"key"`
	// Last modified date of the object.
	LastModified     string  `pulumi:"lastModified"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Object storage type such as STANDARD.
	StorageClass string `pulumi:"storageClass"`
}

func LookupBucketObjectOutput(ctx *pulumi.Context, args LookupBucketObjectOutputArgs, opts ...pulumi.InvokeOption) LookupBucketObjectResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupBucketObjectResult, error) {
			args := v.(LookupBucketObjectArgs)
			r, err := LookupBucketObject(ctx, &args, opts...)
			var s LookupBucketObjectResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupBucketObjectResultOutput)
}

// A collection of arguments for invoking getBucketObject.
type LookupBucketObjectOutputArgs struct {
	// Name of the bucket that contains the objects to query.
	Bucket pulumi.StringInput `pulumi:"bucket"`
	// The full path to the object inside the bucket.
	Key pulumi.StringInput `pulumi:"key"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (LookupBucketObjectOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupBucketObjectArgs)(nil)).Elem()
}

// A collection of values returned by getBucketObject.
type LookupBucketObjectResultOutput struct{ *pulumi.OutputState }

func (LookupBucketObjectResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupBucketObjectResult)(nil)).Elem()
}

func (o LookupBucketObjectResultOutput) ToLookupBucketObjectResultOutput() LookupBucketObjectResultOutput {
	return o
}

func (o LookupBucketObjectResultOutput) ToLookupBucketObjectResultOutputWithContext(ctx context.Context) LookupBucketObjectResultOutput {
	return o
}

func (o LookupBucketObjectResultOutput) Bucket() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) string { return v.Bucket }).(pulumi.StringOutput)
}

// Specifies caching behavior along the request/reply chain.
func (o LookupBucketObjectResultOutput) CacheControl() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) string { return v.CacheControl }).(pulumi.StringOutput)
}

// Specifies presentational information for the object.
func (o LookupBucketObjectResultOutput) ContentDisposition() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) string { return v.ContentDisposition }).(pulumi.StringOutput)
}

// Specifies what content encodings have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field.
func (o LookupBucketObjectResultOutput) ContentEncoding() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) string { return v.ContentEncoding }).(pulumi.StringOutput)
}

// A standard MIME type describing the format of the object data.
func (o LookupBucketObjectResultOutput) ContentType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) string { return v.ContentType }).(pulumi.StringOutput)
}

// ETag generated for the object, which is may not equal to MD5 value.
func (o LookupBucketObjectResultOutput) Etag() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) string { return v.Etag }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupBucketObjectResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupBucketObjectResultOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) string { return v.Key }).(pulumi.StringOutput)
}

// Last modified date of the object.
func (o LookupBucketObjectResultOutput) LastModified() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) string { return v.LastModified }).(pulumi.StringOutput)
}

func (o LookupBucketObjectResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Object storage type such as STANDARD.
func (o LookupBucketObjectResultOutput) StorageClass() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBucketObjectResult) string { return v.StorageClass }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupBucketObjectResultOutput{})
}