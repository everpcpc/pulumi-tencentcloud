// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes.Inputs
{

    public sealed class EncryptionProtectionKmsConfigurationGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// kms id.
        /// </summary>
        [Input("keyId")]
        public Input<string>? KeyId { get; set; }

        /// <summary>
        /// kms region.
        /// </summary>
        [Input("kmsRegion")]
        public Input<string>? KmsRegion { get; set; }

        public EncryptionProtectionKmsConfigurationGetArgs()
        {
        }
        public static new EncryptionProtectionKmsConfigurationGetArgs Empty => new EncryptionProtectionKmsConfigurationGetArgs();
    }
}