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
    /// Provides a resource to create a cls scheduled_sql
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
    ///     var logset = new Tencentcloud.Cls.Logset("logset", new()
    ///     {
    ///         LogsetName = "tf-example-logset",
    ///         Tags = 
    ///         {
    ///             { "createdBy", "terraform" },
    ///         },
    ///     });
    /// 
    ///     var topic = new Tencentcloud.Cls.Topic("topic", new()
    ///     {
    ///         TopicName = "tf-example-topic",
    ///         LogsetId = logset.Id,
    ///         AutoSplit = false,
    ///         MaxSplitPartitions = 20,
    ///         PartitionCount = 1,
    ///         Period = 10,
    ///         StorageType = "hot",
    ///         Tags = 
    ///         {
    ///             { "test", "test" },
    ///         },
    ///     });
    /// 
    ///     var scheduledSql = new Tencentcloud.Cls.ScheduledSql("scheduledSql", new()
    ///     {
    ///         SrcTopicId = topic.Id,
    ///         EnableFlag = 1,
    ///         DstResource = new Tencentcloud.Cls.Inputs.ScheduledSqlDstResourceArgs
    ///         {
    ///             TopicId = topic.Id,
    ///             Region = "ap-guangzhou",
    ///             BizType = 0,
    ///             MetricName = "test",
    ///         },
    ///         ScheduledSqlContent = "xxx",
    ///         ProcessStartTime = 1690515360000,
    ///         ProcessType = 1,
    ///         ProcessPeriod = 10,
    ///         ProcessTimeWindow = "@m-15m,@m",
    ///         ProcessDelay = 5,
    ///         SrcTopicRegion = "ap-guangzhou",
    ///         ProcessEndTime = 1690515360000,
    ///         SyntaxRule = 0,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// cls scheduled_sql can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Cls/scheduledSql:ScheduledSql scheduled_sql scheduled_sql_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Cls/scheduledSql:ScheduledSql")]
    public partial class ScheduledSql : global::Pulumi.CustomResource
    {
        /// <summary>
        /// scheduled slq dst resource.
        /// </summary>
        [Output("dstResource")]
        public Output<Outputs.ScheduledSqlDstResource> DstResource { get; private set; } = null!;

        /// <summary>
        /// task enable flag.
        /// </summary>
        [Output("enableFlag")]
        public Output<int> EnableFlag { get; private set; } = null!;

        /// <summary>
        /// task name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// process delay.
        /// </summary>
        [Output("processDelay")]
        public Output<int> ProcessDelay { get; private set; } = null!;

        /// <summary>
        /// process end timestamp.
        /// </summary>
        [Output("processEndTime")]
        public Output<int> ProcessEndTime { get; private set; } = null!;

        /// <summary>
        /// process period.
        /// </summary>
        [Output("processPeriod")]
        public Output<int> ProcessPeriod { get; private set; } = null!;

        /// <summary>
        /// process start timestamp.
        /// </summary>
        [Output("processStartTime")]
        public Output<int> ProcessStartTime { get; private set; } = null!;

        /// <summary>
        /// process time window.
        /// </summary>
        [Output("processTimeWindow")]
        public Output<string> ProcessTimeWindow { get; private set; } = null!;

        /// <summary>
        /// process type.
        /// </summary>
        [Output("processType")]
        public Output<int> ProcessType { get; private set; } = null!;

        /// <summary>
        /// scheduled sql content.
        /// </summary>
        [Output("scheduledSqlContent")]
        public Output<string> ScheduledSqlContent { get; private set; } = null!;

        /// <summary>
        /// src topic id.
        /// </summary>
        [Output("srcTopicId")]
        public Output<string> SrcTopicId { get; private set; } = null!;

        /// <summary>
        /// src topic region.
        /// </summary>
        [Output("srcTopicRegion")]
        public Output<string> SrcTopicRegion { get; private set; } = null!;

        /// <summary>
        /// syntax rule.
        /// </summary>
        [Output("syntaxRule")]
        public Output<int?> SyntaxRule { get; private set; } = null!;


        /// <summary>
        /// Create a ScheduledSql resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ScheduledSql(string name, ScheduledSqlArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cls/scheduledSql:ScheduledSql", name, args ?? new ScheduledSqlArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ScheduledSql(string name, Input<string> id, ScheduledSqlState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cls/scheduledSql:ScheduledSql", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ScheduledSql resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ScheduledSql Get(string name, Input<string> id, ScheduledSqlState? state = null, CustomResourceOptions? options = null)
        {
            return new ScheduledSql(name, id, state, options);
        }
    }

    public sealed class ScheduledSqlArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// scheduled slq dst resource.
        /// </summary>
        [Input("dstResource", required: true)]
        public Input<Inputs.ScheduledSqlDstResourceArgs> DstResource { get; set; } = null!;

        /// <summary>
        /// task enable flag.
        /// </summary>
        [Input("enableFlag", required: true)]
        public Input<int> EnableFlag { get; set; } = null!;

        /// <summary>
        /// task name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// process delay.
        /// </summary>
        [Input("processDelay", required: true)]
        public Input<int> ProcessDelay { get; set; } = null!;

        /// <summary>
        /// process end timestamp.
        /// </summary>
        [Input("processEndTime")]
        public Input<int>? ProcessEndTime { get; set; }

        /// <summary>
        /// process period.
        /// </summary>
        [Input("processPeriod", required: true)]
        public Input<int> ProcessPeriod { get; set; } = null!;

        /// <summary>
        /// process start timestamp.
        /// </summary>
        [Input("processStartTime", required: true)]
        public Input<int> ProcessStartTime { get; set; } = null!;

        /// <summary>
        /// process time window.
        /// </summary>
        [Input("processTimeWindow", required: true)]
        public Input<string> ProcessTimeWindow { get; set; } = null!;

        /// <summary>
        /// process type.
        /// </summary>
        [Input("processType", required: true)]
        public Input<int> ProcessType { get; set; } = null!;

        /// <summary>
        /// scheduled sql content.
        /// </summary>
        [Input("scheduledSqlContent", required: true)]
        public Input<string> ScheduledSqlContent { get; set; } = null!;

        /// <summary>
        /// src topic id.
        /// </summary>
        [Input("srcTopicId", required: true)]
        public Input<string> SrcTopicId { get; set; } = null!;

        /// <summary>
        /// src topic region.
        /// </summary>
        [Input("srcTopicRegion", required: true)]
        public Input<string> SrcTopicRegion { get; set; } = null!;

        /// <summary>
        /// syntax rule.
        /// </summary>
        [Input("syntaxRule")]
        public Input<int>? SyntaxRule { get; set; }

        public ScheduledSqlArgs()
        {
        }
        public static new ScheduledSqlArgs Empty => new ScheduledSqlArgs();
    }

    public sealed class ScheduledSqlState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// scheduled slq dst resource.
        /// </summary>
        [Input("dstResource")]
        public Input<Inputs.ScheduledSqlDstResourceGetArgs>? DstResource { get; set; }

        /// <summary>
        /// task enable flag.
        /// </summary>
        [Input("enableFlag")]
        public Input<int>? EnableFlag { get; set; }

        /// <summary>
        /// task name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// process delay.
        /// </summary>
        [Input("processDelay")]
        public Input<int>? ProcessDelay { get; set; }

        /// <summary>
        /// process end timestamp.
        /// </summary>
        [Input("processEndTime")]
        public Input<int>? ProcessEndTime { get; set; }

        /// <summary>
        /// process period.
        /// </summary>
        [Input("processPeriod")]
        public Input<int>? ProcessPeriod { get; set; }

        /// <summary>
        /// process start timestamp.
        /// </summary>
        [Input("processStartTime")]
        public Input<int>? ProcessStartTime { get; set; }

        /// <summary>
        /// process time window.
        /// </summary>
        [Input("processTimeWindow")]
        public Input<string>? ProcessTimeWindow { get; set; }

        /// <summary>
        /// process type.
        /// </summary>
        [Input("processType")]
        public Input<int>? ProcessType { get; set; }

        /// <summary>
        /// scheduled sql content.
        /// </summary>
        [Input("scheduledSqlContent")]
        public Input<string>? ScheduledSqlContent { get; set; }

        /// <summary>
        /// src topic id.
        /// </summary>
        [Input("srcTopicId")]
        public Input<string>? SrcTopicId { get; set; }

        /// <summary>
        /// src topic region.
        /// </summary>
        [Input("srcTopicRegion")]
        public Input<string>? SrcTopicRegion { get; set; }

        /// <summary>
        /// syntax rule.
        /// </summary>
        [Input("syntaxRule")]
        public Input<int>? SyntaxRule { get; set; }

        public ScheduledSqlState()
        {
        }
        public static new ScheduledSqlState Empty => new ScheduledSqlState();
    }
}