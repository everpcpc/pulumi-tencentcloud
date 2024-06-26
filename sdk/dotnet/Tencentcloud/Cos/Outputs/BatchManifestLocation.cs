// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cos.Outputs
{

    [OutputType]
    public sealed class BatchManifestLocation
    {
        /// <summary>
        /// Specifies the etag of the object list. Length 1-1024 bytes.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Specifies the unique resource identifier of the object manifest, which is 1-1024 bytes long.
        /// </summary>
        public readonly string ObjectArn;
        /// <summary>
        /// Specifies the version of the object manifest ID, which is 1-1024 bytes long.
        /// </summary>
        public readonly string? ObjectVersionId;

        [OutputConstructor]
        private BatchManifestLocation(
            string etag,

            string objectArn,

            string? objectVersionId)
        {
            Etag = etag;
            ObjectArn = objectArn;
            ObjectVersionId = objectVersionId;
        }
    }
}
