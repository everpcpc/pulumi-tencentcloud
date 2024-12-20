// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Outputs
{

    [OutputType]
    public sealed class OutputOutputRtpSettingsDestination
    {
        /// <summary>
        /// Output IP.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// output port.
        /// </summary>
        public readonly int Port;

        [OutputConstructor]
        private OutputOutputRtpSettingsDestination(
            string ip,

            int port)
        {
            Ip = ip;
            Port = port;
        }
    }
}
