// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dbbrain.Outputs
{

    [OutputType]
    public sealed class GetTopSpaceTableTimeSeriesTopSpaceTableTimeSeriesSeriesDataSeriesResult
    {
        /// <summary>
        /// Indicator name.
        /// </summary>
        public readonly string Metric;
        /// <summary>
        /// Indicator unit.
        /// </summary>
        public readonly string Unit;
        /// <summary>
        /// Index value. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<double> Values;

        [OutputConstructor]
        private GetTopSpaceTableTimeSeriesTopSpaceTableTimeSeriesSeriesDataSeriesResult(
            string metric,

            string unit,

            ImmutableArray<double> values)
        {
            Metric = metric;
            Unit = unit;
            Values = values;
        }
    }
}