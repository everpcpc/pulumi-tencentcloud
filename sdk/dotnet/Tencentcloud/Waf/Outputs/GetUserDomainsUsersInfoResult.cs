// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Waf.Outputs
{

    [OutputType]
    public sealed class GetUserDomainsUsersInfoResult
    {
        /// <summary>
        /// User appid.
        /// </summary>
        public readonly int Appid;
        /// <summary>
        /// CLS switch 1: write, 0: do not writeNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly int Cls;
        /// <summary>
        /// Domain name.
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// Domain unique id.
        /// </summary>
        public readonly string DomainId;
        /// <summary>
        /// Instance type, sparta-waf represents SAAS WAF, clb-waf represents CLB WAF.
        /// </summary>
        public readonly string Edition;
        /// <summary>
        /// Instance unique id.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// Instance name.
        /// </summary>
        public readonly string InstanceName;
        /// <summary>
        /// Instance level infoNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string Level;
        /// <summary>
        /// Switch for accessing log fieldsNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string WriteConfig;

        [OutputConstructor]
        private GetUserDomainsUsersInfoResult(
            int appid,

            int cls,

            string domain,

            string domainId,

            string edition,

            string instanceId,

            string instanceName,

            string level,

            string writeConfig)
        {
            Appid = appid;
            Cls = cls;
            Domain = domain;
            DomainId = domainId;
            Edition = edition;
            InstanceId = instanceId;
            InstanceName = instanceName;
            Level = level;
            WriteConfig = writeConfig;
        }
    }
}
