// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cynosdb
{
    /// <summary>
    /// Provides a resource to create a cynosdb cluster_password_complexity
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var clusterPasswordComplexity = new Tencentcloud.Cynosdb.ClusterPasswordComplexity("clusterPasswordComplexity", new()
    ///     {
    ///         ClusterId = "cynosdbmysql-cgd2gpwr",
    ///         ValidatePasswordDictionaries = new[]
    ///         {
    ///             "cccc",
    ///             "xxxx",
    ///         },
    ///         ValidatePasswordLength = 8,
    ///         ValidatePasswordMixedCaseCount = 1,
    ///         ValidatePasswordNumberCount = 1,
    ///         ValidatePasswordPolicy = "STRONG",
    ///         ValidatePasswordSpecialCharCount = 1,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// cynosdb cluster_password_complexity can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Cynosdb/clusterPasswordComplexity:ClusterPasswordComplexity cluster_password_complexity cluster_password_complexity_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Cynosdb/clusterPasswordComplexity:ClusterPasswordComplexity")]
    public partial class ClusterPasswordComplexity : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [Output("clusterId")]
        public Output<string> ClusterId { get; private set; } = null!;

        /// <summary>
        /// Data dictionary.
        /// </summary>
        [Output("validatePasswordDictionaries")]
        public Output<ImmutableArray<string>> ValidatePasswordDictionaries { get; private set; } = null!;

        /// <summary>
        /// Password length.
        /// </summary>
        [Output("validatePasswordLength")]
        public Output<int> ValidatePasswordLength { get; private set; } = null!;

        /// <summary>
        /// Number of uppercase and lowercase characters.
        /// </summary>
        [Output("validatePasswordMixedCaseCount")]
        public Output<int> ValidatePasswordMixedCaseCount { get; private set; } = null!;

        /// <summary>
        /// Number of digits.
        /// </summary>
        [Output("validatePasswordNumberCount")]
        public Output<int> ValidatePasswordNumberCount { get; private set; } = null!;

        /// <summary>
        /// Password strength (MEDIUM, STRONG).
        /// </summary>
        [Output("validatePasswordPolicy")]
        public Output<string> ValidatePasswordPolicy { get; private set; } = null!;

        /// <summary>
        /// Number of special characters.
        /// </summary>
        [Output("validatePasswordSpecialCharCount")]
        public Output<int> ValidatePasswordSpecialCharCount { get; private set; } = null!;


        /// <summary>
        /// Create a ClusterPasswordComplexity resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ClusterPasswordComplexity(string name, ClusterPasswordComplexityArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cynosdb/clusterPasswordComplexity:ClusterPasswordComplexity", name, args ?? new ClusterPasswordComplexityArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ClusterPasswordComplexity(string name, Input<string> id, ClusterPasswordComplexityState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cynosdb/clusterPasswordComplexity:ClusterPasswordComplexity", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ClusterPasswordComplexity resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ClusterPasswordComplexity Get(string name, Input<string> id, ClusterPasswordComplexityState? state = null, CustomResourceOptions? options = null)
        {
            return new ClusterPasswordComplexity(name, id, state, options);
        }
    }

    public sealed class ClusterPasswordComplexityArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        [Input("validatePasswordDictionaries")]
        private InputList<string>? _validatePasswordDictionaries;

        /// <summary>
        /// Data dictionary.
        /// </summary>
        public InputList<string> ValidatePasswordDictionaries
        {
            get => _validatePasswordDictionaries ?? (_validatePasswordDictionaries = new InputList<string>());
            set => _validatePasswordDictionaries = value;
        }

        /// <summary>
        /// Password length.
        /// </summary>
        [Input("validatePasswordLength", required: true)]
        public Input<int> ValidatePasswordLength { get; set; } = null!;

        /// <summary>
        /// Number of uppercase and lowercase characters.
        /// </summary>
        [Input("validatePasswordMixedCaseCount", required: true)]
        public Input<int> ValidatePasswordMixedCaseCount { get; set; } = null!;

        /// <summary>
        /// Number of digits.
        /// </summary>
        [Input("validatePasswordNumberCount", required: true)]
        public Input<int> ValidatePasswordNumberCount { get; set; } = null!;

        /// <summary>
        /// Password strength (MEDIUM, STRONG).
        /// </summary>
        [Input("validatePasswordPolicy", required: true)]
        public Input<string> ValidatePasswordPolicy { get; set; } = null!;

        /// <summary>
        /// Number of special characters.
        /// </summary>
        [Input("validatePasswordSpecialCharCount", required: true)]
        public Input<int> ValidatePasswordSpecialCharCount { get; set; } = null!;

        public ClusterPasswordComplexityArgs()
        {
        }
        public static new ClusterPasswordComplexityArgs Empty => new ClusterPasswordComplexityArgs();
    }

    public sealed class ClusterPasswordComplexityState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        [Input("validatePasswordDictionaries")]
        private InputList<string>? _validatePasswordDictionaries;

        /// <summary>
        /// Data dictionary.
        /// </summary>
        public InputList<string> ValidatePasswordDictionaries
        {
            get => _validatePasswordDictionaries ?? (_validatePasswordDictionaries = new InputList<string>());
            set => _validatePasswordDictionaries = value;
        }

        /// <summary>
        /// Password length.
        /// </summary>
        [Input("validatePasswordLength")]
        public Input<int>? ValidatePasswordLength { get; set; }

        /// <summary>
        /// Number of uppercase and lowercase characters.
        /// </summary>
        [Input("validatePasswordMixedCaseCount")]
        public Input<int>? ValidatePasswordMixedCaseCount { get; set; }

        /// <summary>
        /// Number of digits.
        /// </summary>
        [Input("validatePasswordNumberCount")]
        public Input<int>? ValidatePasswordNumberCount { get; set; }

        /// <summary>
        /// Password strength (MEDIUM, STRONG).
        /// </summary>
        [Input("validatePasswordPolicy")]
        public Input<string>? ValidatePasswordPolicy { get; set; }

        /// <summary>
        /// Number of special characters.
        /// </summary>
        [Input("validatePasswordSpecialCharCount")]
        public Input<int>? ValidatePasswordSpecialCharCount { get; set; }

        public ClusterPasswordComplexityState()
        {
        }
        public static new ClusterPasswordComplexityState Empty => new ClusterPasswordComplexityState();
    }
}