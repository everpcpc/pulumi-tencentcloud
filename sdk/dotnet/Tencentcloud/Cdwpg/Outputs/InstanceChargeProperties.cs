// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cdwpg.Outputs
{

    [OutputType]
    public sealed class InstanceChargeProperties
    {
        /// <summary>
        /// Charge type, vaild values: PREPAID, POSTPAID_BY_HOUR.
        /// </summary>
        public readonly string? ChargeType;
        /// <summary>
        /// 0-no automatic renewal,1-automatic renewalNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly int RenewFlag;
        /// <summary>
        /// Time RangeNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly int TimeSpan;
        /// <summary>
        /// Time Unit,Generally h and mNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string TimeUnit;

        [OutputConstructor]
        private InstanceChargeProperties(
            string? chargeType,

            int renewFlag,

            int timeSpan,

            string timeUnit)
        {
            ChargeType = chargeType;
            RenewFlag = renewFlag;
            TimeSpan = timeSpan;
            TimeUnit = timeUnit;
        }
    }
}