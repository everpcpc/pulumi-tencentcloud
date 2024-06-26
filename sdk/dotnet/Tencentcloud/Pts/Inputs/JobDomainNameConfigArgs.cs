// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Pts.Inputs
{

    public sealed class JobDomainNameConfigArgs : Pulumi.ResourceArgs
    {
        [Input("dnsConfig")]
        public Input<Inputs.JobDomainNameConfigDnsConfigArgs>? DnsConfig { get; set; }

        [Input("hostAliases")]
        private InputList<Inputs.JobDomainNameConfigHostAliasArgs>? _hostAliases;
        public InputList<Inputs.JobDomainNameConfigHostAliasArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Inputs.JobDomainNameConfigHostAliasArgs>());
            set => _hostAliases = value;
        }

        public JobDomainNameConfigArgs()
        {
        }
    }
}
