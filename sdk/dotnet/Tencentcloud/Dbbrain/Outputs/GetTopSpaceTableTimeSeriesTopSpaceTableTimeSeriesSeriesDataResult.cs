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
    public sealed class GetTopSpaceTableTimeSeriesTopSpaceTableTimeSeriesSeriesDataResult
    {
        /// <summary>
        /// Monitor metrics.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTopSpaceTableTimeSeriesTopSpaceTableTimeSeriesSeriesDataSeriesResult> Series;
        /// <summary>
        /// The timestamp corresponding to the monitoring indicator.
        /// </summary>
        public readonly ImmutableArray<int> Timestamps;

        [OutputConstructor]
        private GetTopSpaceTableTimeSeriesTopSpaceTableTimeSeriesSeriesDataResult(
            ImmutableArray<Outputs.GetTopSpaceTableTimeSeriesTopSpaceTableTimeSeriesSeriesDataSeriesResult> series,

            ImmutableArray<int> timestamps)
        {
            Series = series;
            Timestamps = timestamps;
        }
    }
}
