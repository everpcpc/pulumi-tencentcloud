// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Sqlserver.Outputs
{

    [OutputType]
    public sealed class GetDescHaLogSwitchLogResult
    {
        /// <summary>
        /// Switch end time Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string EndTime;
        /// <summary>
        /// Switch event ID Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string EventId;
        /// <summary>
        /// Machine failure causes automatic switching Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Switch start time Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// Switching mode 0-system automatic switching, 1-manual switching Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly int SwitchType;

        [OutputConstructor]
        private GetDescHaLogSwitchLogResult(
            string endTime,

            string eventId,

            string reason,

            string startTime,

            int switchType)
        {
            EndTime = endTime;
            EventId = eventId;
            Reason = reason;
            StartTime = startTime;
            SwitchType = switchType;
        }
    }
}