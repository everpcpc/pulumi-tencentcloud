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
    public sealed class CustomRuleStrategy
    {
        /// <summary>
        /// Matching parameters.
        /// </summary>
        public readonly string Arg;
        /// <summary>
        /// Logical symbol.
        /// </summary>
        public readonly string CompareFunc;
        /// <summary>
        /// Matching Content.
        /// </summary>
        public readonly string Content;
        /// <summary>
        /// Matching Fields.
        /// </summary>
        public readonly string Field;

        [OutputConstructor]
        private CustomRuleStrategy(
            string arg,

            string compareFunc,

            string content,

            string field)
        {
            Arg = arg;
            CompareFunc = compareFunc;
            Content = content;
            Field = field;
        }
    }
}
