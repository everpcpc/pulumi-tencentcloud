// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Gaap.Outputs
{

    [OutputType]
    public sealed class GetListenerStatisticsStatisticsDataResult
    {
        /// <summary>
        /// Metric Data.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetListenerStatisticsStatisticsDataMetricDataResult> MetricDatas;
        /// <summary>
        /// Metric Name.
        /// </summary>
        public readonly string MetricName;

        [OutputConstructor]
        private GetListenerStatisticsStatisticsDataResult(
            ImmutableArray<Outputs.GetListenerStatisticsStatisticsDataMetricDataResult> metricDatas,

            string metricName)
        {
            MetricDatas = metricDatas;
            MetricName = metricName;
        }
    }
}