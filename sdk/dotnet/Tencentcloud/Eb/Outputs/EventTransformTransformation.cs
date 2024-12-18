// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Eb.Outputs
{

    [OutputType]
    public sealed class EventTransformTransformation
    {
        /// <summary>
        /// Describe how to filter data.
        /// </summary>
        public readonly Outputs.EventTransformTransformationEtlFilter? EtlFilter;
        /// <summary>
        /// Describe how to extract data.
        /// </summary>
        public readonly Outputs.EventTransformTransformationExtraction? Extraction;
        /// <summary>
        /// Describe how to convert data.
        /// </summary>
        public readonly Outputs.EventTransformTransformationTransform? Transform;

        [OutputConstructor]
        private EventTransformTransformation(
            Outputs.EventTransformTransformationEtlFilter? etlFilter,

            Outputs.EventTransformTransformationExtraction? extraction,

            Outputs.EventTransformTransformationTransform? transform)
        {
            EtlFilter = etlFilter;
            Extraction = extraction;
            Transform = transform;
        }
    }
}
