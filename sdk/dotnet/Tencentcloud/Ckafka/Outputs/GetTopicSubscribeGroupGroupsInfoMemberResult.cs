// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class GetTopicSubscribeGroupGroupsInfoMemberResult
    {
        /// <summary>
        /// Stores the partition information assigned to the consumer.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTopicSubscribeGroupGroupsInfoMemberAssignmentResult> Assignments;
        /// <summary>
        /// Generally store the customer&amp;#39;s IP address.
        /// </summary>
        public readonly string ClientHost;
        /// <summary>
        /// The client.id information set by the client consumer SDK itself.
        /// </summary>
        public readonly string ClientId;
        /// <summary>
        /// ID that the coordinator generated for consumer.
        /// </summary>
        public readonly string MemberId;

        [OutputConstructor]
        private GetTopicSubscribeGroupGroupsInfoMemberResult(
            ImmutableArray<Outputs.GetTopicSubscribeGroupGroupsInfoMemberAssignmentResult> assignments,

            string clientHost,

            string clientId,

            string memberId)
        {
            Assignments = assignments;
            ClientHost = clientHost;
            ClientId = clientId;
            MemberId = memberId;
        }
    }
}
