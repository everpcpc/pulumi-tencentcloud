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
    public sealed class GetAlarmConditionsTemplateTemplateGroupListPolicyGroupResult
    {
        /// <summary>
        /// Can it be set as the default alarm strategy.
        /// </summary>
        public readonly bool CanSetDefault;
        /// <summary>
        /// Alarm Policy Enable Status.
        /// </summary>
        public readonly bool Enable;
        /// <summary>
        /// Filter queries based on trigger condition template ID.
        /// </summary>
        public readonly int GroupId;
        /// <summary>
        /// Filter queries based on trigger condition template names.
        /// </summary>
        public readonly string GroupName;
        /// <summary>
        /// Creation time.
        /// </summary>
        public readonly int InsertTime;
        /// <summary>
        /// Is it the default alarm policy.
        /// </summary>
        public readonly int IsDefault;
        /// <summary>
        /// Is it a relationship rule with.
        /// </summary>
        public readonly int IsUnionRule;
        /// <summary>
        /// Last modified by UIN.
        /// </summary>
        public readonly int LastEditUin;
        /// <summary>
        /// Number of unshielded instances.
        /// </summary>
        public readonly int NoShieldedInstanceCount;
        /// <summary>
        /// Parent Policy Group ID.
        /// </summary>
        public readonly int ParentGroupId;
        /// <summary>
        /// Project ID.
        /// </summary>
        public readonly int ProjectId;
        /// <summary>
        /// Alarm receiving object information.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAlarmConditionsTemplateTemplateGroupListPolicyGroupReceiverInfoResult> ReceiverInfos;
        /// <summary>
        /// Remarks.
        /// </summary>
        public readonly string Remark;
        /// <summary>
        /// Total number of bound instances.
        /// </summary>
        public readonly int TotalInstanceCount;
        /// <summary>
        /// Update time.
        /// </summary>
        public readonly int UpdateTime;
        /// <summary>
        /// View name, composed of DescribeAllNamespacesObtain. For cloud product monitoring, retrieve the QceNamespacesNew. N.ID parameter from the interface, such as cvm_ Device.
        /// </summary>
        public readonly string ViewName;

        [OutputConstructor]
        private GetAlarmConditionsTemplateTemplateGroupListPolicyGroupResult(
            bool canSetDefault,

            bool enable,

            int groupId,

            string groupName,

            int insertTime,

            int isDefault,

            int isUnionRule,

            int lastEditUin,

            int noShieldedInstanceCount,

            int parentGroupId,

            int projectId,

            ImmutableArray<Outputs.GetAlarmConditionsTemplateTemplateGroupListPolicyGroupReceiverInfoResult> receiverInfos,

            string remark,

            int totalInstanceCount,

            int updateTime,

            string viewName)
        {
            CanSetDefault = canSetDefault;
            Enable = enable;
            GroupId = groupId;
            GroupName = groupName;
            InsertTime = insertTime;
            IsDefault = isDefault;
            IsUnionRule = isUnionRule;
            LastEditUin = lastEditUin;
            NoShieldedInstanceCount = noShieldedInstanceCount;
            ParentGroupId = parentGroupId;
            ProjectId = projectId;
            ReceiverInfos = receiverInfos;
            Remark = remark;
            TotalInstanceCount = totalInstanceCount;
            UpdateTime = updateTime;
            ViewName = viewName;
        }
    }
}