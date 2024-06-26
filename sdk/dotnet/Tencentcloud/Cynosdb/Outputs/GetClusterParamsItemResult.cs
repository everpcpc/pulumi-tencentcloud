// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cynosdb.Outputs
{

    [OutputType]
    public sealed class GetClusterParamsItemResult
    {
        /// <summary>
        /// Current value.
        /// </summary>
        public readonly string CurrentValue;
        /// <summary>
        /// Default value.
        /// </summary>
        public readonly string Default;
        /// <summary>
        /// The description of parameter.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// When the parameter is enum/string/bool, the optional value list.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> EnumValues;
        /// <summary>
        /// Function.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string Func;
        /// <summary>
        /// Is it a function.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly bool IsFunc;
        /// <summary>
        /// Is it a global parameter.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly int IsGlobal;
        /// <summary>
        /// Matching type, multiVal, regex is used when the parameter type is string.
        /// </summary>
        public readonly string MatchType;
        /// <summary>
        /// Match the target value, when multiVal, each key is divided by `;`.
        /// </summary>
        public readonly string MatchValue;
        /// <summary>
        /// The maximum value when the parameter type is float/integer.
        /// </summary>
        public readonly string Max;
        /// <summary>
        /// The minimum value when the parameter type is float/integer.
        /// </summary>
        public readonly string Min;
        /// <summary>
        /// Whether to reboot.
        /// </summary>
        public readonly int NeedReboot;
        /// <summary>
        /// Parameter name.
        /// </summary>
        public readonly string ParamName;
        /// <summary>
        /// Parameter type: integer/float/string/enum/bool.
        /// </summary>
        public readonly string ParamType;

        [OutputConstructor]
        private GetClusterParamsItemResult(
            string currentValue,

            string @default,

            string description,

            ImmutableArray<string> enumValues,

            string func,

            bool isFunc,

            int isGlobal,

            string matchType,

            string matchValue,

            string max,

            string min,

            int needReboot,

            string paramName,

            string paramType)
        {
            CurrentValue = currentValue;
            Default = @default;
            Description = description;
            EnumValues = enumValues;
            Func = func;
            IsFunc = isFunc;
            IsGlobal = isGlobal;
            MatchType = matchType;
            MatchValue = matchValue;
            Max = max;
            Min = min;
            NeedReboot = needReboot;
            ParamName = paramName;
            ParamType = paramType;
        }
    }
}
