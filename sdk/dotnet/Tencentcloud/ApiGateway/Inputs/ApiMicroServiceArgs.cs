// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.ApiGateway.Inputs
{

    public sealed class ApiMicroServiceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Micro service cluster.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// Microservice name.
        /// </summary>
        [Input("microServiceName", required: true)]
        public Input<string> MicroServiceName { get; set; } = null!;

        /// <summary>
        /// Microservice namespace.
        /// </summary>
        [Input("namespaceId", required: true)]
        public Input<string> NamespaceId { get; set; } = null!;

        public ApiMicroServiceArgs()
        {
        }
        public static new ApiMicroServiceArgs Empty => new ApiMicroServiceArgs();
    }
}
