// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Antiddos.Outputs
{

    [OutputType]
    public sealed class GetListListenerLayer7ListenerResult
    {
        /// <summary>
        /// Domain.
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// Resource instance to which the rule belongs.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetListListenerLayer7ListenerInstanceDetailRuleResult> InstanceDetailRules;
        /// <summary>
        /// InstanceDetails.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetListListenerLayer7ListenerInstanceDetailResult> InstanceDetails;
        /// <summary>
        /// Protocol.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// List of forwarding types.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetListListenerLayer7ListenerProxyTypeListResult> ProxyTypeLists;
        /// <summary>
        /// Source server list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetListListenerLayer7ListenerRealServerResult> RealServers;
        /// <summary>
        /// Port.
        /// </summary>
        public readonly int Vport;

        [OutputConstructor]
        private GetListListenerLayer7ListenerResult(
            string domain,

            ImmutableArray<Outputs.GetListListenerLayer7ListenerInstanceDetailRuleResult> instanceDetailRules,

            ImmutableArray<Outputs.GetListListenerLayer7ListenerInstanceDetailResult> instanceDetails,

            string protocol,

            ImmutableArray<Outputs.GetListListenerLayer7ListenerProxyTypeListResult> proxyTypeLists,

            ImmutableArray<Outputs.GetListListenerLayer7ListenerRealServerResult> realServers,

            int vport)
        {
            Domain = domain;
            InstanceDetailRules = instanceDetailRules;
            InstanceDetails = instanceDetails;
            Protocol = protocol;
            ProxyTypeLists = proxyTypeLists;
            RealServers = realServers;
            Vport = vport;
        }
    }
}
