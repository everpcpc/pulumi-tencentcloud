// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse.Outputs
{

    [OutputType]
    public sealed class GetInstanceBlueprintBlueprintInstanceSetSoftwareSetDetailSetResult
    {
        /// <summary>
        /// Unique detail key.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Detail title.
        /// </summary>
        public readonly string Title;
        /// <summary>
        /// Detail value.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GetInstanceBlueprintBlueprintInstanceSetSoftwareSetDetailSetResult(
            string key,

            string title,

            string value)
        {
            Key = key;
            Title = title;
            Value = value;
        }
    }
}
