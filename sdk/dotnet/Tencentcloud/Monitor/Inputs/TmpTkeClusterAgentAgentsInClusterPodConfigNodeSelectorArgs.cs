// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor.Inputs
{

    public sealed class TmpTkeClusterAgentAgentsInClusterPodConfigNodeSelectorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The pod configuration name of the component deployed in the cluster.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Pod configuration values for components deployed in the cluster.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public TmpTkeClusterAgentAgentsInClusterPodConfigNodeSelectorArgs()
        {
        }
    }
}