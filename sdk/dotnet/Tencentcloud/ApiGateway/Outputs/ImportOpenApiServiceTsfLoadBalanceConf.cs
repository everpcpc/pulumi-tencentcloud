// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.ApiGateway.Outputs
{

    [OutputType]
    public sealed class ImportOpenApiServiceTsfLoadBalanceConf
    {
        /// <summary>
        /// Is load balancing enabled.Note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly bool? IsLoadBalance;
        /// <summary>
        /// Load balancing method.Note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string? Method;
        /// <summary>
        /// Whether to enable session persistence.Note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly bool? SessionStickRequired;
        /// <summary>
        /// Session hold timeout.Note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly int? SessionStickTimeout;

        [OutputConstructor]
        private ImportOpenApiServiceTsfLoadBalanceConf(
            bool? isLoadBalance,

            string? method,

            bool? sessionStickRequired,

            int? sessionStickTimeout)
        {
            IsLoadBalance = isLoadBalance;
            Method = method;
            SessionStickRequired = sessionStickRequired;
            SessionStickTimeout = sessionStickTimeout;
        }
    }
}
