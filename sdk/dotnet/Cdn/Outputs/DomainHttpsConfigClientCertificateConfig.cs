// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Outputs
{

    [OutputType]
    public sealed class DomainHttpsConfigClientCertificateConfig
    {
        /// <summary>
        /// Client Certificate PEM format, requires Base64 encoding.
        /// </summary>
        public readonly string CertificateContent;
        public readonly string? CertificateName;
        public readonly string? DeployTime;
        /// <summary>
        /// Signature expiration time in second. The maximum value is 630720000.
        /// </summary>
        public readonly string? ExpireTime;

        [OutputConstructor]
        private DomainHttpsConfigClientCertificateConfig(
            string certificateContent,

            string? certificateName,

            string? deployTime,

            string? expireTime)
        {
            CertificateContent = certificateContent;
            CertificateName = certificateName;
            DeployTime = deployTime;
            ExpireTime = expireTime;
        }
    }
}