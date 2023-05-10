// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcmq
{
    public static class GetTopic
    {
        /// <summary>
        /// Use this data source to query detailed information of tcmq topic
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var topic = Output.Create(Tencentcloud.Tcmq.GetTopic.InvokeAsync(new Tencentcloud.Tcmq.GetTopicArgs
        ///         {
        ///             TopicName = "topic_name",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetTopicResult> InvokeAsync(GetTopicArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTopicResult>("tencentcloud:Tcmq/getTopic:getTopic", args ?? new GetTopicArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of tcmq topic
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var topic = Output.Create(Tencentcloud.Tcmq.GetTopic.InvokeAsync(new Tencentcloud.Tcmq.GetTopicArgs
        ///         {
        ///             TopicName = "topic_name",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetTopicResult> Invoke(GetTopicInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetTopicResult>("tencentcloud:Tcmq/getTopic:getTopic", args ?? new GetTopicInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTopicArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetTopicFilterArgs>? _filters;

        /// <summary>
        /// Filter. Currently, you can filter by tag. The tag name must be prefixed with `tag:`, such as `tag: owner`, `tag: environment`, or `tag: business`.
        /// </summary>
        public List<Inputs.GetTopicFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetTopicFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// For filtering by tag, this parameter must be set to `true`.
        /// </summary>
        [Input("isTagFilter")]
        public bool? IsTagFilter { get; set; }

        /// <summary>
        /// Number of topics to be returned per page in case of paginated return. If this parameter is not passed in, 20 will be used by default. Maximum value: 50.
        /// </summary>
        [Input("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Starting position of the list of topics to be returned on the current page in case of paginated return. If a value is entered, limit is required. If this parameter is left empty, 0 will be used by default.
        /// </summary>
        [Input("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Fuzzy search by TopicName.
        /// </summary>
        [Input("topicName")]
        public string? TopicName { get; set; }

        [Input("topicNameLists")]
        private List<string>? _topicNameLists;

        /// <summary>
        /// Filter by CMQ topic name.
        /// </summary>
        public List<string> TopicNameLists
        {
            get => _topicNameLists ?? (_topicNameLists = new List<string>());
            set => _topicNameLists = value;
        }

        public GetTopicArgs()
        {
        }
    }

    public sealed class GetTopicInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetTopicFilterInputArgs>? _filters;

        /// <summary>
        /// Filter. Currently, you can filter by tag. The tag name must be prefixed with `tag:`, such as `tag: owner`, `tag: environment`, or `tag: business`.
        /// </summary>
        public InputList<Inputs.GetTopicFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetTopicFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// For filtering by tag, this parameter must be set to `true`.
        /// </summary>
        [Input("isTagFilter")]
        public Input<bool>? IsTagFilter { get; set; }

        /// <summary>
        /// Number of topics to be returned per page in case of paginated return. If this parameter is not passed in, 20 will be used by default. Maximum value: 50.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        /// <summary>
        /// Starting position of the list of topics to be returned on the current page in case of paginated return. If a value is entered, limit is required. If this parameter is left empty, 0 will be used by default.
        /// </summary>
        [Input("offset")]
        public Input<int>? Offset { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Fuzzy search by TopicName.
        /// </summary>
        [Input("topicName")]
        public Input<string>? TopicName { get; set; }

        [Input("topicNameLists")]
        private InputList<string>? _topicNameLists;

        /// <summary>
        /// Filter by CMQ topic name.
        /// </summary>
        public InputList<string> TopicNameLists
        {
            get => _topicNameLists ?? (_topicNameLists = new InputList<string>());
            set => _topicNameLists = value;
        }

        public GetTopicInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetTopicResult
    {
        public readonly ImmutableArray<Outputs.GetTopicFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly bool? IsTagFilter;
        public readonly int? Limit;
        public readonly int? Offset;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Topic list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTopicTopicListResult> TopicLists;
        /// <summary>
        /// Topic name.
        /// </summary>
        public readonly string? TopicName;
        public readonly ImmutableArray<string> TopicNameLists;

        [OutputConstructor]
        private GetTopicResult(
            ImmutableArray<Outputs.GetTopicFilterResult> filters,

            string id,

            bool? isTagFilter,

            int? limit,

            int? offset,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetTopicTopicListResult> topicLists,

            string? topicName,

            ImmutableArray<string> topicNameLists)
        {
            Filters = filters;
            Id = id;
            IsTagFilter = isTagFilter;
            Limit = limit;
            Offset = offset;
            ResultOutputFile = resultOutputFile;
            TopicLists = topicLists;
            TopicName = topicName;
            TopicNameLists = topicNameLists;
        }
    }
}