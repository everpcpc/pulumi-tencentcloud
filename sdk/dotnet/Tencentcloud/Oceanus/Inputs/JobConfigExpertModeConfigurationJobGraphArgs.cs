// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Oceanus.Inputs
{

    public sealed class JobConfigExpertModeConfigurationJobGraphArgs : global::Pulumi.ResourceArgs
    {
        [Input("edges")]
        private InputList<Inputs.JobConfigExpertModeConfigurationJobGraphEdgeArgs>? _edges;

        /// <summary>
        /// Edge set of the running graphNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public InputList<Inputs.JobConfigExpertModeConfigurationJobGraphEdgeArgs> Edges
        {
            get => _edges ?? (_edges = new InputList<Inputs.JobConfigExpertModeConfigurationJobGraphEdgeArgs>());
            set => _edges = value;
        }

        [Input("nodes")]
        private InputList<Inputs.JobConfigExpertModeConfigurationJobGraphNodeArgs>? _nodes;

        /// <summary>
        /// Point set of the running graphNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public InputList<Inputs.JobConfigExpertModeConfigurationJobGraphNodeArgs> Nodes
        {
            get => _nodes ?? (_nodes = new InputList<Inputs.JobConfigExpertModeConfigurationJobGraphNodeArgs>());
            set => _nodes = value;
        }

        public JobConfigExpertModeConfigurationJobGraphArgs()
        {
        }
        public static new JobConfigExpertModeConfigurationJobGraphArgs Empty => new JobConfigExpertModeConfigurationJobGraphArgs();
    }
}
