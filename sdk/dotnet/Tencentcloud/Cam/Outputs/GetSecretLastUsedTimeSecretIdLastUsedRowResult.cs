// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cam.Outputs
{

    [OutputType]
    public sealed class GetSecretLastUsedTimeSecretIdLastUsedRowResult
    {
        /// <summary>
        /// Last used timestamp.
        /// </summary>
        public readonly int LastSecretUsedDate;
        /// <summary>
        /// Last used date (with 1 day delay).
        /// </summary>
        public readonly string LastUsedDate;
        /// <summary>
        /// Secret Id.
        /// </summary>
        public readonly string SecretId;

        [OutputConstructor]
        private GetSecretLastUsedTimeSecretIdLastUsedRowResult(
            int lastSecretUsedDate,

            string lastUsedDate,

            string secretId)
        {
            LastSecretUsedDate = lastSecretUsedDate;
            LastUsedDate = lastUsedDate;
            SecretId = secretId;
        }
    }
}