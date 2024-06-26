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
    public sealed class GetAlarmPolicyPolicyNoticeUserNoticeResult
    {
        /// <summary>
        /// Notification end time, which is expressed by the number of seconds since 00:00:00. Value range: 0-86399Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int EndTime;
        /// <summary>
        /// User group ID listNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<int> GroupIds;
        /// <summary>
        /// Whether receipt notification is required. Valid values: 0 (no), 1 (yes)Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int NeedPhoneArriveNotice;
        /// <summary>
        /// Notification channel list. Valid values: EMAIL (email), SMS (SMS), CALL (phone), WECHAT (WeChat), RTX (WeCom)Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> NoticeWays;
        /// <summary>
        /// List of schedule IDsNote: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> OnCallFormIds;
        /// <summary>
        /// Dial type. SYNC (simultaneous dial), CIRCLE (polled dial). Default value: CIRCLE.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string PhoneCallType;
        /// <summary>
        /// Polling interval in seconds. Value range: 60-900Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int PhoneCircleInterval;
        /// <summary>
        /// Number of phone pollings. Value range: 1-5Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int PhoneCircleTimes;
        /// <summary>
        /// Call interval in seconds within one polling. Value range: 60-900Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int PhoneInnerInterval;
        /// <summary>
        /// Phone polling listNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<int> PhoneOrders;
        /// <summary>
        /// Recipient type. Valid values: USER (user), GROUP (user group)Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string ReceiverType;
        /// <summary>
        /// Notification start time, which is expressed by the number of seconds since 00:00:00. Value range: 0-86399Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int StartTime;
        /// <summary>
        /// User uid listNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<int> UserIds;
        /// <summary>
        /// Notification cycle. The values 1-7 indicate Monday to Sunday.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<int> Weekdays;

        [OutputConstructor]
        private GetAlarmPolicyPolicyNoticeUserNoticeResult(
            int endTime,

            ImmutableArray<int> groupIds,

            int needPhoneArriveNotice,

            ImmutableArray<string> noticeWays,

            ImmutableArray<string> onCallFormIds,

            string phoneCallType,

            int phoneCircleInterval,

            int phoneCircleTimes,

            int phoneInnerInterval,

            ImmutableArray<int> phoneOrders,

            string receiverType,

            int startTime,

            ImmutableArray<int> userIds,

            ImmutableArray<int> weekdays)
        {
            EndTime = endTime;
            GroupIds = groupIds;
            NeedPhoneArriveNotice = needPhoneArriveNotice;
            NoticeWays = noticeWays;
            OnCallFormIds = onCallFormIds;
            PhoneCallType = phoneCallType;
            PhoneCircleInterval = phoneCircleInterval;
            PhoneCircleTimes = phoneCircleTimes;
            PhoneInnerInterval = phoneInnerInterval;
            PhoneOrders = phoneOrders;
            ReceiverType = receiverType;
            StartTime = startTime;
            UserIds = userIds;
            Weekdays = weekdays;
        }
    }
}
