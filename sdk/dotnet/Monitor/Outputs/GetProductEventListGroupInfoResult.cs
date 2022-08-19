// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Outputs
{

    [OutputType]
    public sealed class GetProductEventListGroupInfoResult
    {
        /// <summary>
        /// Policy group ID.
        /// </summary>
        public readonly string GroupId;
        /// <summary>
        /// Policy group name.
        /// </summary>
        public readonly string GroupName;

        [OutputConstructor]
        private GetProductEventListGroupInfoResult(
            string groupId,

            string groupName)
        {
            GroupId = groupId;
            GroupName = groupName;
        }
    }
}