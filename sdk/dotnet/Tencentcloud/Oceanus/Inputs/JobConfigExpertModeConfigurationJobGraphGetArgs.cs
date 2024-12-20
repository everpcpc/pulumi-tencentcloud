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

    public sealed class JobConfigExpertModeConfigurationJobGraphGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("edges")]
        private InputList<Inputs.JobConfigExpertModeConfigurationJobGraphEdgeGetArgs>? _edges;

        /// <summary>
        /// Edge set of the running graphNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public InputList<Inputs.JobConfigExpertModeConfigurationJobGraphEdgeGetArgs> Edges
        {
            get => _edges ?? (_edges = new InputList<Inputs.JobConfigExpertModeConfigurationJobGraphEdgeGetArgs>());
            set => _edges = value;
        }

        [Input("nodes")]
        private InputList<Inputs.JobConfigExpertModeConfigurationJobGraphNodeGetArgs>? _nodes;

        /// <summary>
        /// Point set of the running graphNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public InputList<Inputs.JobConfigExpertModeConfigurationJobGraphNodeGetArgs> Nodes
        {
            get => _nodes ?? (_nodes = new InputList<Inputs.JobConfigExpertModeConfigurationJobGraphNodeGetArgs>());
            set => _nodes = value;
        }

        public JobConfigExpertModeConfigurationJobGraphGetArgs()
        {
        }
        public static new JobConfigExpertModeConfigurationJobGraphGetArgs Empty => new JobConfigExpertModeConfigurationJobGraphGetArgs();
    }
}
