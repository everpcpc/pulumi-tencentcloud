// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcm.Outputs
{

    [OutputType]
    public sealed class GetMeshMeshListConfigIstioResult
    {
        /// <summary>
        /// Disable http retry.
        /// </summary>
        public readonly bool DisableHttpRetry;
        /// <summary>
        /// Disable policy checks.
        /// </summary>
        public readonly bool DisablePolicyChecks;
        /// <summary>
        /// Enable HTTP/1.0 support.
        /// </summary>
        public readonly bool EnablePilotHttp;
        /// <summary>
        /// Outbound traffic policy.
        /// </summary>
        public readonly string OutboundTrafficPolicy;
        /// <summary>
        /// SmartDNS configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMeshMeshListConfigIstioSmartDnResult> SmartDns;

        [OutputConstructor]
        private GetMeshMeshListConfigIstioResult(
            bool disableHttpRetry,

            bool disablePolicyChecks,

            bool enablePilotHttp,

            string outboundTrafficPolicy,

            ImmutableArray<Outputs.GetMeshMeshListConfigIstioSmartDnResult> smartDns)
        {
            DisableHttpRetry = disableHttpRetry;
            DisablePolicyChecks = disablePolicyChecks;
            EnablePilotHttp = enablePilotHttp;
            OutboundTrafficPolicy = outboundTrafficPolicy;
            SmartDns = smartDns;
        }
    }
}