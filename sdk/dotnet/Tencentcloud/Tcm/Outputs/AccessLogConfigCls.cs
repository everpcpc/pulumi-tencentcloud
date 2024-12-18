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
    public sealed class AccessLogConfigCls
    {
        /// <summary>
        /// Whether enable CLS.
        /// </summary>
        public readonly bool Enable;
        /// <summary>
        /// Log set of CLS.
        /// </summary>
        public readonly string? LogSet;
        /// <summary>
        /// Log topic of CLS.
        /// </summary>
        public readonly string? Topic;

        [OutputConstructor]
        private AccessLogConfigCls(
            bool enable,

            string? logSet,

            string? topic)
        {
            Enable = enable;
            LogSet = logSet;
            Topic = topic;
        }
    }
}
