// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Oceanus
{
    public static class GetJobSubmissionLog
    {
        /// <summary>
        /// Use this data source to query detailed information of oceanus job_submission_log
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
        ///     var example = Tencentcloud.Oceanus.GetJobSubmissionLog.Invoke(new()
        ///     {
        ///         EndTime = 1698118169241,
        ///         JobId = "cql-314rw6w0",
        ///         OrderType = "desc",
        ///         RunningOrderId = 0,
        ///         StartTime = 1696130964345,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetJobSubmissionLogResult> InvokeAsync(GetJobSubmissionLogArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetJobSubmissionLogResult>("tencentcloud:Oceanus/getJobSubmissionLog:getJobSubmissionLog", args ?? new GetJobSubmissionLogArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of oceanus job_submission_log
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
        ///     var example = Tencentcloud.Oceanus.GetJobSubmissionLog.Invoke(new()
        ///     {
        ///         EndTime = 1698118169241,
        ///         JobId = "cql-314rw6w0",
        ///         OrderType = "desc",
        ///         RunningOrderId = 0,
        ///         StartTime = 1696130964345,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetJobSubmissionLogResult> Invoke(GetJobSubmissionLogInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetJobSubmissionLogResult>("tencentcloud:Oceanus/getJobSubmissionLog:getJobSubmissionLog", args ?? new GetJobSubmissionLogInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetJobSubmissionLogArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Cursor, default empty, first request does not need to pass in.
        /// </summary>
        [Input("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// End time, unix timestamp, in milliseconds.
        /// </summary>
        [Input("endTime", required: true)]
        public int EndTime { get; set; }

        /// <summary>
        /// Job ID.
        /// </summary>
        [Input("jobId", required: true)]
        public string JobId { get; set; } = null!;

        /// <summary>
        /// Keyword, default empty.
        /// </summary>
        [Input("keyword")]
        public string? Keyword { get; set; }

        /// <summary>
        /// Sorting method, default asc, asc: ascending, desc: descending.
        /// </summary>
        [Input("orderType")]
        public string? OrderType { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Job instance ID.
        /// </summary>
        [Input("runningOrderId")]
        public int? RunningOrderId { get; set; }

        /// <summary>
        /// Start time, unix timestamp, in milliseconds.
        /// </summary>
        [Input("startTime", required: true)]
        public int StartTime { get; set; }

        public GetJobSubmissionLogArgs()
        {
        }
        public static new GetJobSubmissionLogArgs Empty => new GetJobSubmissionLogArgs();
    }

    public sealed class GetJobSubmissionLogInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Cursor, default empty, first request does not need to pass in.
        /// </summary>
        [Input("cursor")]
        public Input<string>? Cursor { get; set; }

        /// <summary>
        /// End time, unix timestamp, in milliseconds.
        /// </summary>
        [Input("endTime", required: true)]
        public Input<int> EndTime { get; set; } = null!;

        /// <summary>
        /// Job ID.
        /// </summary>
        [Input("jobId", required: true)]
        public Input<string> JobId { get; set; } = null!;

        /// <summary>
        /// Keyword, default empty.
        /// </summary>
        [Input("keyword")]
        public Input<string>? Keyword { get; set; }

        /// <summary>
        /// Sorting method, default asc, asc: ascending, desc: descending.
        /// </summary>
        [Input("orderType")]
        public Input<string>? OrderType { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Job instance ID.
        /// </summary>
        [Input("runningOrderId")]
        public Input<int>? RunningOrderId { get; set; }

        /// <summary>
        /// Start time, unix timestamp, in milliseconds.
        /// </summary>
        [Input("startTime", required: true)]
        public Input<int> StartTime { get; set; } = null!;

        public GetJobSubmissionLogInvokeArgs()
        {
        }
        public static new GetJobSubmissionLogInvokeArgs Empty => new GetJobSubmissionLogInvokeArgs();
    }


    [OutputType]
    public sealed class GetJobSubmissionLogResult
    {
        public readonly string Cursor;
        public readonly int EndTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string JobId;
        /// <summary>
        /// Job instance list during the specified time period.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetJobSubmissionLogJobInstanceListResult> JobInstanceLists;
        /// <summary>
        /// Request ID of starting job.
        /// </summary>
        public readonly string JobRequestId;
        public readonly string? Keyword;
        /// <summary>
        /// Whether the list is over.
        /// </summary>
        public readonly bool ListOver;
        /// <summary>
        /// The list of log contents.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetJobSubmissionLogLogContentListResult> LogContentLists;
        /// <summary>
        /// Log list, deprecated.
        /// </summary>
        public readonly ImmutableArray<string> LogLists;
        public readonly string? OrderType;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// The ID of the instance, starting from 1 in the order of startup time.
        /// </summary>
        public readonly int? RunningOrderId;
        public readonly int StartTime;

        [OutputConstructor]
        private GetJobSubmissionLogResult(
            string cursor,

            int endTime,

            string id,

            string jobId,

            ImmutableArray<Outputs.GetJobSubmissionLogJobInstanceListResult> jobInstanceLists,

            string jobRequestId,

            string? keyword,

            bool listOver,

            ImmutableArray<Outputs.GetJobSubmissionLogLogContentListResult> logContentLists,

            ImmutableArray<string> logLists,

            string? orderType,

            string? resultOutputFile,

            int? runningOrderId,

            int startTime)
        {
            Cursor = cursor;
            EndTime = endTime;
            Id = id;
            JobId = jobId;
            JobInstanceLists = jobInstanceLists;
            JobRequestId = jobRequestId;
            Keyword = keyword;
            ListOver = listOver;
            LogContentLists = logContentLists;
            LogLists = logLists;
            OrderType = orderType;
            ResultOutputFile = resultOutputFile;
            RunningOrderId = runningOrderId;
            StartTime = startTime;
        }
    }
}