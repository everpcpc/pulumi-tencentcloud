// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vpc.Outputs
{

    [OutputType]
    public sealed class GetAclsAclListEgressResult
    {
        /// <summary>
        /// The IPv4 CIDR of the subnet.
        /// </summary>
        public readonly string CidrBlock;
        /// <summary>
        /// Rule description.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Rule policy of Network ACL.
        /// </summary>
        public readonly string Policy;
        /// <summary>
        /// Range of the port.
        /// </summary>
        public readonly string Port;
        /// <summary>
        /// Type of IP protocol.
        /// </summary>
        public readonly string Protocol;

        [OutputConstructor]
        private GetAclsAclListEgressResult(
            string cidrBlock,

            string description,

            string policy,

            string port,

            string protocol)
        {
            CidrBlock = cidrBlock;
            Description = description;
            Policy = policy;
            Port = port;
            Protocol = protocol;
        }
    }
}