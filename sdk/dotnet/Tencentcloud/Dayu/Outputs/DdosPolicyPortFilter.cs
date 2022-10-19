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
    public sealed class DdosPolicyPortFilter
    {
        /// <summary>
        /// Action of port to take. Valid values: `drop`, `transmit`.
        /// </summary>
        public readonly string? Action;
        /// <summary>
        /// End port. Valid value ranges: (0~65535). It must be greater than `start_port`.
        /// </summary>
        public readonly int? EndPort;
        /// <summary>
        /// The type of forbidden port. Valid values: `0`, `1`, `2`. `0` for destination ports make effect, `1` for source ports make effect. `2` for both destination and source ports.
        /// </summary>
        public readonly int? Kind;
        /// <summary>
        /// Protocol. Valid values are `tcp`, `udp`, `icmp`, `all`.
        /// </summary>
        public readonly string? Protocol;
        /// <summary>
        /// Start port. Valid value ranges: (0~65535).
        /// </summary>
        public readonly int? StartPort;

        [OutputConstructor]
        private DdosPolicyPortFilter(
            string? action,

            int? endPort,

            int? kind,

            string? protocol,

            int? startPort)
        {
            Action = action;
            EndPort = endPort;
            Kind = kind;
            Protocol = protocol;
            StartPort = startPort;
        }
    }
}