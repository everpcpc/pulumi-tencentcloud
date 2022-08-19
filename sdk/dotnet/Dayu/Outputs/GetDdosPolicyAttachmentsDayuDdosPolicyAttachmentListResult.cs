// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu.Outputs
{

    [OutputType]
    public sealed class GetDdosPolicyAttachmentsDayuDdosPolicyAttachmentListResult
    {
        /// <summary>
        /// Id of the policy to be queried.
        /// </summary>
        public readonly string PolicyId;
        /// <summary>
        /// ID of the attached resource to be queried.
        /// </summary>
        public readonly string ResourceId;
        /// <summary>
        /// Type of the resource that the DDoS policy works for, valid values are `bgpip`, `bgp`, `bgp-multip` and `net`.
        /// </summary>
        public readonly string ResourceType;

        [OutputConstructor]
        private GetDdosPolicyAttachmentsDayuDdosPolicyAttachmentListResult(
            string policyId,

            string resourceId,

            string resourceType)
        {
            PolicyId = policyId;
            ResourceId = resourceId;
            ResourceType = resourceType;
        }
    }
}