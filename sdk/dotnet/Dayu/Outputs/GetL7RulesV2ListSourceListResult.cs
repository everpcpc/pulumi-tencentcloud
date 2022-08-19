// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu.Outputs
{

    [OutputType]
    public sealed class GetL7RulesV2ListSourceListResult
    {
        /// <summary>
        /// Back-to-source IP or domain name.
        /// </summary>
        public readonly string Source;
        /// <summary>
        /// Weight value, take value [0,100].
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private GetL7RulesV2ListSourceListResult(
            string source,

            int weight)
        {
            Source = source;
            Weight = weight;
        }
    }
}