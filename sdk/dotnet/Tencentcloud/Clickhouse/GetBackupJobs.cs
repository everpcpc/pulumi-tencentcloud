// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clickhouse
{
    public static class GetBackupJobs
    {
        /// <summary>
        /// Use this data source to query detailed information of clickhouse backup jobs
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
        ///     var backupJobs = Tencentcloud.Clickhouse.GetBackupJobs.Invoke(new()
        ///     {
        ///         InstanceId = "cdwch-xxxxxx",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetBackupJobsResult> InvokeAsync(GetBackupJobsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetBackupJobsResult>("tencentcloud:Clickhouse/getBackupJobs:getBackupJobs", args ?? new GetBackupJobsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of clickhouse backup jobs
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
        ///     var backupJobs = Tencentcloud.Clickhouse.GetBackupJobs.Invoke(new()
        ///     {
        ///         InstanceId = "cdwch-xxxxxx",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetBackupJobsResult> Invoke(GetBackupJobsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetBackupJobsResult>("tencentcloud:Clickhouse/getBackupJobs:getBackupJobs", args ?? new GetBackupJobsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBackupJobsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Begin time.
        /// </summary>
        [Input("beginTime")]
        public string? BeginTime { get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [Input("endTime")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetBackupJobsArgs()
        {
        }
        public static new GetBackupJobsArgs Empty => new GetBackupJobsArgs();
    }

    public sealed class GetBackupJobsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Begin time.
        /// </summary>
        [Input("beginTime")]
        public Input<string>? BeginTime { get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        /// <summary>
        /// Instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetBackupJobsInvokeArgs()
        {
        }
        public static new GetBackupJobsInvokeArgs Empty => new GetBackupJobsInvokeArgs();
    }


    [OutputType]
    public sealed class GetBackupJobsResult
    {
        /// <summary>
        /// Back up jobs.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetBackupJobsBackUpJobResult> BackUpJobs;
        public readonly string? BeginTime;
        public readonly string? EndTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetBackupJobsResult(
            ImmutableArray<Outputs.GetBackupJobsBackUpJobResult> backUpJobs,

            string? beginTime,

            string? endTime,

            string id,

            string instanceId,

            string? resultOutputFile)
        {
            BackUpJobs = backUpJobs;
            BeginTime = beginTime;
            EndTime = endTime;
            Id = id;
            InstanceId = instanceId;
            ResultOutputFile = resultOutputFile;
        }
    }
}