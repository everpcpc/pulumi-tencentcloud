// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class ZoneOwnershipVerificationDnsVerification
    {
        /// <summary>
        /// Record type.
        /// </summary>
        public readonly string? RecordType;
        /// <summary>
        /// Record the value.
        /// </summary>
        public readonly string? RecordValue;
        /// <summary>
        /// Host record.
        /// </summary>
        public readonly string? Subdomain;

        [OutputConstructor]
        private ZoneOwnershipVerificationDnsVerification(
            string? recordType,

            string? recordValue,

            string? subdomain)
        {
            RecordType = recordType;
            RecordValue = recordValue;
            Subdomain = subdomain;
        }
    }
}
