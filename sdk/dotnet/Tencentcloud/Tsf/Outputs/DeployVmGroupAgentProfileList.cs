// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class DeployVmGroupAgentProfileList
    {
        /// <summary>
        /// Agent type.
        /// </summary>
        public readonly string? AgentType;
        /// <summary>
        /// Agent version.
        /// </summary>
        public readonly string? AgentVersion;

        [OutputConstructor]
        private DeployVmGroupAgentProfileList(
            string? agentType,

            string? agentVersion)
        {
            AgentType = agentType;
            AgentVersion = agentVersion;
        }
    }
}