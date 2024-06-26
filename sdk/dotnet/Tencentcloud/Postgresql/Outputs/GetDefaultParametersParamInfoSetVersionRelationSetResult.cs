// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Postgresql.Outputs
{

    [OutputType]
    public sealed class GetDefaultParametersParamInfoSetVersionRelationSetResult
    {
        /// <summary>
        /// The kernel version that corresponds to the parameter informationNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string DbKernelVersion;
        /// <summary>
        /// Value range of the enum parameterNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> EnumValues;
        /// <summary>
        /// The maximum value of the `integer` or `real` parameterNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly double Max;
        /// <summary>
        /// The minimum value of the `integer` or `real` parameterNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly double Min;
        /// <summary>
        /// Parameter nameNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Unit of the parameter value. If the parameter has no unit, this field will return null.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Unit;
        /// <summary>
        /// Default parameter value under the kernel version and specification of the instanceNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GetDefaultParametersParamInfoSetVersionRelationSetResult(
            string dbKernelVersion,

            ImmutableArray<string> enumValues,

            double max,

            double min,

            string name,

            string unit,

            string value)
        {
            DbKernelVersion = dbKernelVersion;
            EnumValues = enumValues;
            Max = max;
            Min = min;
            Name = name;
            Unit = unit;
            Value = value;
        }
    }
}
