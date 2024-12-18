// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Bi.Inputs
{

    public sealed class DatasourceCloudServiceTypeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance Id.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Region.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        /// <summary>
        /// Service type, Cloud.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public DatasourceCloudServiceTypeGetArgs()
        {
        }
        public static new DatasourceCloudServiceTypeGetArgs Empty => new DatasourceCloudServiceTypeGetArgs();
    }
}
