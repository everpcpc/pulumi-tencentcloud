// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cvm.Outputs
{

    [OutputType]
    public sealed class LaunchTemplateVersionLoginSettings
    {
        /// <summary>
        /// Whether to keep the original settings of an image.
        /// </summary>
        public readonly string? KeepImageLogin;
        /// <summary>
        /// List of key IDs. After an instance is associated with a key, you can access the instance with the private key in the key pair.
        /// </summary>
        public readonly ImmutableArray<string> KeyIds;
        /// <summary>
        /// Login password of the instance.
        /// </summary>
        public readonly string? Password;

        [OutputConstructor]
        private LaunchTemplateVersionLoginSettings(
            string? keepImageLogin,

            ImmutableArray<string> keyIds,

            string? password)
        {
            KeepImageLogin = keepImageLogin;
            KeyIds = keyIds;
            Password = password;
        }
    }
}