// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor.Outputs
{

    [OutputType]
    public sealed class GetAlarmPolicyPolicyNoticeClsNoticeResult
    {
        /// <summary>
        /// Filter by alarm status. Valid values: [1]: enabled; [0]: disabled; [0, 1]: all.
        /// </summary>
        public readonly int Enable;
        /// <summary>
        /// Logset ID.
        /// </summary>
        public readonly string LogSetId;
        /// <summary>
        /// RegionNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Topic ID.
        /// </summary>
        public readonly string TopicId;

        [OutputConstructor]
        private GetAlarmPolicyPolicyNoticeClsNoticeResult(
            int enable,

            string logSetId,

            string region,

            string topicId)
        {
            Enable = enable;
            LogSetId = logSetId;
            Region = region;
            TopicId = topicId;
        }
    }
}
