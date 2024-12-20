// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cls
{
    /// <summary>
    /// Provides a resource to create a cls index.
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
    ///     var exampleLogset = new Tencentcloud.Cls.Logset("exampleLogset", new()
    ///     {
    ///         LogsetName = "tf_example",
    ///         Tags = 
    ///         {
    ///             { "demo", "test" },
    ///         },
    ///     });
    /// 
    ///     var exampleTopic = new Tencentcloud.Cls.Topic("exampleTopic", new()
    ///     {
    ///         TopicName = "tf_example",
    ///         LogsetId = exampleLogset.Id,
    ///         AutoSplit = false,
    ///         MaxSplitPartitions = 20,
    ///         PartitionCount = 1,
    ///         Period = 30,
    ///         StorageType = "hot",
    ///         Describes = "Test Demo.",
    ///         HotPeriod = 10,
    ///         Tags = 
    ///         {
    ///             { "test", "test" },
    ///         },
    ///     });
    /// 
    ///     var tokenizerValue = "@&amp;?|#()='\",;:&lt;&gt;[]{}";
    /// 
    ///     var exampleIndex = new Tencentcloud.Cls.Index("exampleIndex", new()
    ///     {
    ///         TopicId = exampleTopic.Id,
    ///         Rule = new Tencentcloud.Cls.Inputs.IndexRuleArgs
    ///         {
    ///             FullText = new Tencentcloud.Cls.Inputs.IndexRuleFullTextArgs
    ///             {
    ///                 CaseSensitive = true,
    ///                 Tokenizer = tokenizerValue,
    ///                 ContainZH = true,
    ///             },
    ///             KeyValue = new Tencentcloud.Cls.Inputs.IndexRuleKeyValueArgs
    ///             {
    ///                 CaseSensitive = true,
    ///                 KeyValues = new[]
    ///                 {
    ///                     new Tencentcloud.Cls.Inputs.IndexRuleKeyValueKeyValueArgs
    ///                     {
    ///                         Key = "hello",
    ///                         Value = new Tencentcloud.Cls.Inputs.IndexRuleKeyValueKeyValueValueArgs
    ///                         {
    ///                             ContainZH = true,
    ///                             SqlFlag = true,
    ///                             Tokenizer = tokenizerValue,
    ///                             Type = "text",
    ///                         },
    ///                     },
    ///                     new Tencentcloud.Cls.Inputs.IndexRuleKeyValueKeyValueArgs
    ///                     {
    ///                         Key = "world",
    ///                         Value = new Tencentcloud.Cls.Inputs.IndexRuleKeyValueKeyValueValueArgs
    ///                         {
    ///                             ContainZH = true,
    ///                             SqlFlag = true,
    ///                             Tokenizer = tokenizerValue,
    ///                             Type = "text",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             Tag = new Tencentcloud.Cls.Inputs.IndexRuleTagArgs
    ///             {
    ///                 CaseSensitive = true,
    ///                 KeyValues = new[]
    ///                 {
    ///                     new Tencentcloud.Cls.Inputs.IndexRuleTagKeyValueArgs
    ///                     {
    ///                         Key = "terraform",
    ///                         Value = new Tencentcloud.Cls.Inputs.IndexRuleTagKeyValueValueArgs
    ///                         {
    ///                             ContainZH = true,
    ///                             SqlFlag = true,
    ///                             Tokenizer = tokenizerValue,
    ///                             Type = "text",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             DynamicIndex = new Tencentcloud.Cls.Inputs.IndexRuleDynamicIndexArgs
    ///             {
    ///                 Status = true,
    ///             },
    ///         },
    ///         Status = true,
    ///         IncludeInternalFields = true,
    ///         MetadataFlag = 1,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// cls cos index can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Cls/index:Index example 0937e56f-4008-49d2-ad2d-69c52a9f11cc
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Cls/index:Index")]
    public partial class Index : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Internal field marker of full-text index. Default value: false. Valid value: false: excluding internal fields; true: including internal fields.
        /// </summary>
        [Output("includeInternalFields")]
        public Output<bool?> IncludeInternalFields { get; private set; } = null!;

        /// <summary>
        /// Metadata flag. Default value: 0. Valid value: 0: full-text index (including the metadata field with key-value index enabled); 1: full-text index (including all metadata fields); 2: full-text index (excluding metadata fields)..
        /// </summary>
        [Output("metadataFlag")]
        public Output<int?> MetadataFlag { get; private set; } = null!;

        /// <summary>
        /// Index rule.
        /// </summary>
        [Output("rule")]
        public Output<Outputs.IndexRule> Rule { get; private set; } = null!;

        /// <summary>
        /// Whether to take effect. Default value: true.
        /// </summary>
        [Output("status")]
        public Output<bool> Status { get; private set; } = null!;

        /// <summary>
        /// Log topic ID.
        /// </summary>
        [Output("topicId")]
        public Output<string> TopicId { get; private set; } = null!;


        /// <summary>
        /// Create a Index resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Index(string name, IndexArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cls/index:Index", name, args ?? new IndexArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Index(string name, Input<string> id, IndexState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cls/index:Index", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Index resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Index Get(string name, Input<string> id, IndexState? state = null, CustomResourceOptions? options = null)
        {
            return new Index(name, id, state, options);
        }
    }

    public sealed class IndexArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Internal field marker of full-text index. Default value: false. Valid value: false: excluding internal fields; true: including internal fields.
        /// </summary>
        [Input("includeInternalFields")]
        public Input<bool>? IncludeInternalFields { get; set; }

        /// <summary>
        /// Metadata flag. Default value: 0. Valid value: 0: full-text index (including the metadata field with key-value index enabled); 1: full-text index (including all metadata fields); 2: full-text index (excluding metadata fields)..
        /// </summary>
        [Input("metadataFlag")]
        public Input<int>? MetadataFlag { get; set; }

        /// <summary>
        /// Index rule.
        /// </summary>
        [Input("rule")]
        public Input<Inputs.IndexRuleArgs>? Rule { get; set; }

        /// <summary>
        /// Whether to take effect. Default value: true.
        /// </summary>
        [Input("status")]
        public Input<bool>? Status { get; set; }

        /// <summary>
        /// Log topic ID.
        /// </summary>
        [Input("topicId", required: true)]
        public Input<string> TopicId { get; set; } = null!;

        public IndexArgs()
        {
        }
        public static new IndexArgs Empty => new IndexArgs();
    }

    public sealed class IndexState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Internal field marker of full-text index. Default value: false. Valid value: false: excluding internal fields; true: including internal fields.
        /// </summary>
        [Input("includeInternalFields")]
        public Input<bool>? IncludeInternalFields { get; set; }

        /// <summary>
        /// Metadata flag. Default value: 0. Valid value: 0: full-text index (including the metadata field with key-value index enabled); 1: full-text index (including all metadata fields); 2: full-text index (excluding metadata fields)..
        /// </summary>
        [Input("metadataFlag")]
        public Input<int>? MetadataFlag { get; set; }

        /// <summary>
        /// Index rule.
        /// </summary>
        [Input("rule")]
        public Input<Inputs.IndexRuleGetArgs>? Rule { get; set; }

        /// <summary>
        /// Whether to take effect. Default value: true.
        /// </summary>
        [Input("status")]
        public Input<bool>? Status { get; set; }

        /// <summary>
        /// Log topic ID.
        /// </summary>
        [Input("topicId")]
        public Input<string>? TopicId { get; set; }

        public IndexState()
        {
        }
        public static new IndexState Empty => new IndexState();
    }
}
