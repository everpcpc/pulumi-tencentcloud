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
    public sealed class LaunchTemplateVersionEnhancedServiceSecurityService
    {
        /// <summary>
        /// Whether to enable Cloud Security.
        /// </summary>
        public readonly bool? Enabled;

        [OutputConstructor]
        private LaunchTemplateVersionEnhancedServiceSecurityService(bool? enabled)
        {
            Enabled = enabled;
        }
    }
}