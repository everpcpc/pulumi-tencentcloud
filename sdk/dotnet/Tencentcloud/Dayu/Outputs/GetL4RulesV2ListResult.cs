// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dayu.Outputs
{

    [OutputType]
    public sealed class GetL4RulesV2ListResult
    {
        /// <summary>
        /// Bind the resource ID information.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Ip of the resource.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// session hold switch.
        /// </summary>
        public readonly bool KeepEnable;
        /// <summary>
        /// The keeptime of the layer 4 rule.
        /// </summary>
        public readonly int Keeptime;
        /// <summary>
        /// LB type of the rule, `1` for weight cycling and `2` for IP hash.
        /// </summary>
        public readonly int LbType;
        /// <summary>
        /// Rule modification time.
        /// </summary>
        public readonly string ModifyTime;
        /// <summary>
        /// Protocol of the rule.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Corresponding regional information.
        /// </summary>
        public readonly int Region;
        /// <summary>
        /// Remove the watermark state.
        /// </summary>
        public readonly bool RemoveSwitch;
        /// <summary>
        /// ID of the 4 layer rule.
        /// </summary>
        public readonly string RuleId;
        /// <summary>
        /// Name of the rule.
        /// </summary>
        public readonly string RuleName;
        public readonly ImmutableArray<Outputs.GetL4RulesV2ListSourceListResult> SourceLists;
        /// <summary>
        /// The source port of the layer 4 rule.
        /// </summary>
        public readonly int SourcePort;
        /// <summary>
        /// Source type, `1` for source of host, `2` for source of IP.
        /// </summary>
        public readonly int SourceType;
        /// <summary>
        /// Virtual port of resource.
        /// </summary>
        public readonly int VirtualPort;

        [OutputConstructor]
        private GetL4RulesV2ListResult(
            string id,

            string ip,

            bool keepEnable,

            int keeptime,

            int lbType,

            string modifyTime,

            string protocol,

            int region,

            bool removeSwitch,

            string ruleId,

            string ruleName,

            ImmutableArray<Outputs.GetL4RulesV2ListSourceListResult> sourceLists,

            int sourcePort,

            int sourceType,

            int virtualPort)
        {
            Id = id;
            Ip = ip;
            KeepEnable = keepEnable;
            Keeptime = keeptime;
            LbType = lbType;
            ModifyTime = modifyTime;
            Protocol = protocol;
            Region = region;
            RemoveSwitch = removeSwitch;
            RuleId = ruleId;
            RuleName = ruleName;
            SourceLists = sourceLists;
            SourcePort = sourcePort;
            SourceType = sourceType;
            VirtualPort = virtualPort;
        }
    }
}