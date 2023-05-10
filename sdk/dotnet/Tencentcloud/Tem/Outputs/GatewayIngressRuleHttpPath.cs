// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tem.Outputs
{

    [OutputType]
    public sealed class GatewayIngressRuleHttpPath
    {
        /// <summary>
        /// backend payload.
        /// </summary>
        public readonly Outputs.GatewayIngressRuleHttpPathBackend Backend;
        /// <summary>
        /// path.
        /// </summary>
        public readonly string Path;

        [OutputConstructor]
        private GatewayIngressRuleHttpPath(
            Outputs.GatewayIngressRuleHttpPathBackend backend,

            string path)
        {
            Backend = backend;
            Path = path;
        }
    }
}