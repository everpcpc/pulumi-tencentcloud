// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Eks.Outputs
{

    [OutputType]
    public sealed class GetClustersListDnsServerResult
    {
        /// <summary>
        /// DNS Server domain. Empty indicates all domain.
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// List of DNS Server IP address.
        /// </summary>
        public readonly ImmutableArray<string> Servers;

        [OutputConstructor]
        private GetClustersListDnsServerResult(
            string domain,

            ImmutableArray<string> servers)
        {
            Domain = domain;
            Servers = servers;
        }
    }
}