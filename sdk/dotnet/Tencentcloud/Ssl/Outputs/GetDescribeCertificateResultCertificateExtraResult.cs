// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ssl.Outputs
{

    [OutputType]
    public sealed class GetDescribeCertificateResultCertificateExtraResult
    {
        /// <summary>
        /// Type of company. Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly int CompanyType;
        /// <summary>
        /// Certificate can be configured in the number of domain names.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string DomainNumber;
        /// <summary>
        /// Original certificate ID.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string OriginCertificateId;
        /// <summary>
        /// New order certificate ID.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string RenewOrder;
        /// <summary>
        /// Re -issue the original ID of the certificate.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string ReplacedBy;
        /// <summary>
        /// Re -issue a new ID.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string ReplacedFor;
        /// <summary>
        /// Is it a national secret certificateNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly int SMCert;

        [OutputConstructor]
        private GetDescribeCertificateResultCertificateExtraResult(
            int companyType,

            string domainNumber,

            string originCertificateId,

            string renewOrder,

            string replacedBy,

            string replacedFor,

            int sMCert)
        {
            CompanyType = companyType;
            DomainNumber = domainNumber;
            OriginCertificateId = originCertificateId;
            RenewOrder = renewOrder;
            ReplacedBy = replacedBy;
            ReplacedFor = replacedFor;
            SMCert = sMCert;
        }
    }
}
