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
    public sealed class GetRuleEngineSettingsActionPropertyChoicePropertyExtraParameterResult
    {
        /// <summary>
        /// A list of choices which can be used when `Type` is `CHOICE`.
        /// </summary>
        public readonly ImmutableArray<string> Choices;
        /// <summary>
        /// Parameter name. Valid values:- `Action`: this extra parameter is required when modify HTTP header, this action should be a `RewriteAction`.- `StatusCode`: this extra parameter is required when modify HTTP status code, this action should be a `CodeAction`.- `NULL`: this action should be a `NormalAction`.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Property value type. Valid values:- `CHOICE`: enum type, must select one of the value in `ChoicesValue`.- `TOGGLE`: switch type, must select one of the value in `ChoicesValue`.- `OBJECT`: object type, the `ChoiceProperties` list all properties of the object.- `CUSTOM_NUM`: integer type.- `CUSTOM_STRING`: string type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetRuleEngineSettingsActionPropertyChoicePropertyExtraParameterResult(
            ImmutableArray<string> choices,

            string id,

            string type)
        {
            Choices = choices;
            Id = id;
            Type = type;
        }
    }
}
