// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcr
{
    public static class GetTagRetentionExecutionTasks
    {
        /// <summary>
        /// Use this data source to query detailed information of tcr tag_retention_execution_tasks
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var tasks = Tencentcloud.Tcr.GetTagRetentionExecutionTasks.Invoke(new()
        ///     {
        ///         ExecutionId = 1,
        ///         RegistryId = "tcr_ins_id",
        ///         RetentionId = 1,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetTagRetentionExecutionTasksResult> InvokeAsync(GetTagRetentionExecutionTasksArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTagRetentionExecutionTasksResult>("tencentcloud:Tcr/getTagRetentionExecutionTasks:getTagRetentionExecutionTasks", args ?? new GetTagRetentionExecutionTasksArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of tcr tag_retention_execution_tasks
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var tasks = Tencentcloud.Tcr.GetTagRetentionExecutionTasks.Invoke(new()
        ///     {
        ///         ExecutionId = 1,
        ///         RegistryId = "tcr_ins_id",
        ///         RetentionId = 1,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetTagRetentionExecutionTasksResult> Invoke(GetTagRetentionExecutionTasksInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTagRetentionExecutionTasksResult>("tencentcloud:Tcr/getTagRetentionExecutionTasks:getTagRetentionExecutionTasks", args ?? new GetTagRetentionExecutionTasksInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTagRetentionExecutionTasksArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// execution id.
        /// </summary>
        [Input("executionId", required: true)]
        public int ExecutionId { get; set; }

        /// <summary>
        /// instance id.
        /// </summary>
        [Input("registryId", required: true)]
        public string RegistryId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// retention id.
        /// </summary>
        [Input("retentionId", required: true)]
        public int RetentionId { get; set; }

        public GetTagRetentionExecutionTasksArgs()
        {
        }
        public static new GetTagRetentionExecutionTasksArgs Empty => new GetTagRetentionExecutionTasksArgs();
    }

    public sealed class GetTagRetentionExecutionTasksInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// execution id.
        /// </summary>
        [Input("executionId", required: true)]
        public Input<int> ExecutionId { get; set; } = null!;

        /// <summary>
        /// instance id.
        /// </summary>
        [Input("registryId", required: true)]
        public Input<string> RegistryId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// retention id.
        /// </summary>
        [Input("retentionId", required: true)]
        public Input<int> RetentionId { get; set; } = null!;

        public GetTagRetentionExecutionTasksInvokeArgs()
        {
        }
        public static new GetTagRetentionExecutionTasksInvokeArgs Empty => new GetTagRetentionExecutionTasksInvokeArgs();
    }


    [OutputType]
    public sealed class GetTagRetentionExecutionTasksResult
    {
        /// <summary>
        /// the rule execution id.
        /// </summary>
        public readonly int ExecutionId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string RegistryId;
        public readonly string? ResultOutputFile;
        public readonly int RetentionId;
        /// <summary>
        /// list of version retention tasks.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTagRetentionExecutionTasksRetentionTaskListResult> RetentionTaskLists;

        [OutputConstructor]
        private GetTagRetentionExecutionTasksResult(
            int executionId,

            string id,

            string registryId,

            string? resultOutputFile,

            int retentionId,

            ImmutableArray<Outputs.GetTagRetentionExecutionTasksRetentionTaskListResult> retentionTaskLists)
        {
            ExecutionId = executionId;
            Id = id;
            RegistryId = registryId;
            ResultOutputFile = resultOutputFile;
            RetentionId = retentionId;
            RetentionTaskLists = retentionTaskLists;
        }
    }
}