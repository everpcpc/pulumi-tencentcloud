// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcr.Outputs
{

    [OutputType]
    public sealed class GetWebhookTriggerLogsLogResult
    {
        /// <summary>
        /// creation time.
        /// </summary>
        public readonly string CreationTime;
        /// <summary>
        /// webhook trigger detail.
        /// </summary>
        public readonly string Detail;
        /// <summary>
        /// event type.
        /// </summary>
        public readonly string EventType;
        /// <summary>
        /// log id.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// notification type.
        /// </summary>
        public readonly string NotifyType;
        /// <summary>
        /// status.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// trigger id.
        /// </summary>
        public readonly int TriggerId;
        /// <summary>
        /// update time.
        /// </summary>
        public readonly string UpdateTime;

        [OutputConstructor]
        private GetWebhookTriggerLogsLogResult(
            string creationTime,

            string detail,

            string eventType,

            int id,

            string notifyType,

            string status,

            int triggerId,

            string updateTime)
        {
            CreationTime = creationTime;
            Detail = detail;
            EventType = eventType;
            Id = id;
            NotifyType = notifyType;
            Status = status;
            TriggerId = triggerId;
            UpdateTime = updateTime;
        }
    }
}
