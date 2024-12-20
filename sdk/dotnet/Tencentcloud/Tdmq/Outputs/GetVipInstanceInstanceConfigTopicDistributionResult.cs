// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tdmq.Outputs
{

    [OutputType]
    public sealed class GetVipInstanceInstanceConfigTopicDistributionResult
    {
        /// <summary>
        /// Number of topics.
        /// </summary>
        public readonly int Count;
        /// <summary>
        /// Topic type.
        /// </summary>
        public readonly string TopicType;

        [OutputConstructor]
        private GetVipInstanceInstanceConfigTopicDistributionResult(
            int count,

            string topicType)
        {
            Count = count;
            TopicType = topicType;
        }
    }
}
