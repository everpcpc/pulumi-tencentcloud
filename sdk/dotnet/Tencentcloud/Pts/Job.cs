// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Pts
{
    /// <summary>
    /// Provides a resource to create a pts job
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var job = new Tencentcloud.Pts.Job("job", new Tencentcloud.Pts.JobArgs
    ///         {
    ///             JobOwner = "username",
    ///             Note = "desc",
    ///             ProjectId = "project-45vw7v82",
    ///             ScenarioId = "scenario-22q19f3k",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// pts job can be imported using the projectId#scenarioId#jobId, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import tencentcloud:Pts/job:Job job project-45vw7v82#scenario-22q19f3k#job-dtm93vx0
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Pts/job:Job")]
    public partial class Job : Pulumi.CustomResource
    {
        /// <summary>
        /// Cause of interruption.
        /// </summary>
        [Output("abortReason")]
        public Output<int> AbortReason { get; private set; } = null!;

        /// <summary>
        /// Creation time of the job.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Scheduled job ID.
        /// </summary>
        [Output("cronId")]
        public Output<string> CronId { get; private set; } = null!;

        /// <summary>
        /// Dataset file for the job.
        /// </summary>
        [Output("datasets")]
        public Output<ImmutableArray<Outputs.JobDataset>> Datasets { get; private set; } = null!;

        /// <summary>
        /// Whether to debug.
        /// </summary>
        [Output("debug")]
        public Output<bool?> Debug { get; private set; } = null!;

        /// <summary>
        /// Domain name binding configuration.
        /// </summary>
        [Output("domainNameConfigs")]
        public Output<ImmutableArray<Outputs.JobDomainNameConfig>> DomainNameConfigs { get; private set; } = null!;

        /// <summary>
        /// Job duration.
        /// </summary>
        [Output("duration")]
        public Output<int> Duration { get; private set; } = null!;

        /// <summary>
        /// End time of the job.
        /// </summary>
        [Output("endTime")]
        public Output<string> EndTime { get; private set; } = null!;

        /// <summary>
        /// Percentage of error rate.
        /// </summary>
        [Output("errorRate")]
        public Output<double> ErrorRate { get; private set; } = null!;

        /// <summary>
        /// Job owner.
        /// </summary>
        [Output("jobOwner")]
        public Output<string> JobOwner { get; private set; } = null!;

        /// <summary>
        /// Pressure configuration of job.
        /// </summary>
        [Output("loads")]
        public Output<ImmutableArray<Outputs.JobLoad>> Loads { get; private set; } = null!;

        /// <summary>
        /// Maximum requests per second.
        /// </summary>
        [Output("maxRequestsPerSecond")]
        public Output<int> MaxRequestsPerSecond { get; private set; } = null!;

        /// <summary>
        /// Maximum number of VU for the job.
        /// </summary>
        [Output("maxVirtualUserCount")]
        public Output<int> MaxVirtualUserCount { get; private set; } = null!;

        /// <summary>
        /// Note.
        /// </summary>
        [Output("note")]
        public Output<string?> Note { get; private set; } = null!;

        /// <summary>
        /// Expansion package file information.
        /// </summary>
        [Output("plugins")]
        public Output<ImmutableArray<Outputs.JobPlugin>> Plugins { get; private set; } = null!;

        /// <summary>
        /// Project ID.
        /// </summary>
        [Output("projectId")]
        public Output<string> ProjectId { get; private set; } = null!;

        /// <summary>
        /// Protocol script information.
        /// </summary>
        [Output("protocols")]
        public Output<ImmutableArray<Outputs.JobProtocol>> Protocols { get; private set; } = null!;

        /// <summary>
        /// Request file information.
        /// </summary>
        [Output("requestFiles")]
        public Output<ImmutableArray<Outputs.JobRequestFile>> RequestFiles { get; private set; } = null!;

        /// <summary>
        /// Total number of requests.
        /// </summary>
        [Output("requestTotal")]
        public Output<double> RequestTotal { get; private set; } = null!;

        /// <summary>
        /// Average number of requests per second.
        /// </summary>
        [Output("requestsPerSecond")]
        public Output<double> RequestsPerSecond { get; private set; } = null!;

        /// <summary>
        /// Average response time.
        /// </summary>
        [Output("responseTimeAverage")]
        public Output<double> ResponseTimeAverage { get; private set; } = null!;

        /// <summary>
        /// Maximum response time.
        /// </summary>
        [Output("responseTimeMax")]
        public Output<double> ResponseTimeMax { get; private set; } = null!;

        /// <summary>
        /// Minimum response time.
        /// </summary>
        [Output("responseTimeMin")]
        public Output<double> ResponseTimeMin { get; private set; } = null!;

        /// <summary>
        /// 90th percentile response time.
        /// </summary>
        [Output("responseTimeP90")]
        public Output<double> ResponseTimeP90 { get; private set; } = null!;

        /// <summary>
        /// 95th percentile response time.
        /// </summary>
        [Output("responseTimeP95")]
        public Output<double> ResponseTimeP95 { get; private set; } = null!;

        /// <summary>
        /// 99th percentile response time.
        /// </summary>
        [Output("responseTimeP99")]
        public Output<double> ResponseTimeP99 { get; private set; } = null!;

        /// <summary>
        /// Pts scenario id.
        /// </summary>
        [Output("scenarioId")]
        public Output<string> ScenarioId { get; private set; } = null!;

        /// <summary>
        /// Start time of the job.
        /// </summary>
        [Output("startTime")]
        public Output<string> StartTime { get; private set; } = null!;

        /// <summary>
        /// The running status of the task; `0`: JobUnknown, `1`: JobCreated, `2`: JobPending, `3`: JobPreparing, `4`: JobSelectClustering, `5`: JobCreateTasking, `6`: JobSyncTasking, `11`: JobRunning, `12`: JobFinished, `13`: JobPrepareException, `14`: JobFinishException, `15`: JobAborting, `16`: JobAborted, `17`: JobAbortException, `18`: JobDeleted, `19`: JobSelectClusterException, `20`: JobCreateTaskException, `21`: JobSyncTaskException.
        /// </summary>
        [Output("status")]
        public Output<int> Status { get; private set; } = null!;

        /// <summary>
        /// Test script information.
        /// </summary>
        [Output("testScripts")]
        public Output<ImmutableArray<Outputs.JobTestScript>> TestScripts { get; private set; } = null!;

        /// <summary>
        /// Scene Type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Job resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Job(string name, JobArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Pts/job:Job", name, args ?? new JobArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Job(string name, Input<string> id, JobState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Pts/job:Job", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Job resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Job Get(string name, Input<string> id, JobState? state = null, CustomResourceOptions? options = null)
        {
            return new Job(name, id, state, options);
        }
    }

    public sealed class JobArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to debug.
        /// </summary>
        [Input("debug")]
        public Input<bool>? Debug { get; set; }

        /// <summary>
        /// Job owner.
        /// </summary>
        [Input("jobOwner", required: true)]
        public Input<string> JobOwner { get; set; } = null!;

        /// <summary>
        /// Note.
        /// </summary>
        [Input("note")]
        public Input<string>? Note { get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        /// <summary>
        /// Pts scenario id.
        /// </summary>
        [Input("scenarioId", required: true)]
        public Input<string> ScenarioId { get; set; } = null!;

        public JobArgs()
        {
        }
    }

    public sealed class JobState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cause of interruption.
        /// </summary>
        [Input("abortReason")]
        public Input<int>? AbortReason { get; set; }

        /// <summary>
        /// Creation time of the job.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Scheduled job ID.
        /// </summary>
        [Input("cronId")]
        public Input<string>? CronId { get; set; }

        [Input("datasets")]
        private InputList<Inputs.JobDatasetGetArgs>? _datasets;

        /// <summary>
        /// Dataset file for the job.
        /// </summary>
        public InputList<Inputs.JobDatasetGetArgs> Datasets
        {
            get => _datasets ?? (_datasets = new InputList<Inputs.JobDatasetGetArgs>());
            set => _datasets = value;
        }

        /// <summary>
        /// Whether to debug.
        /// </summary>
        [Input("debug")]
        public Input<bool>? Debug { get; set; }

        [Input("domainNameConfigs")]
        private InputList<Inputs.JobDomainNameConfigGetArgs>? _domainNameConfigs;

        /// <summary>
        /// Domain name binding configuration.
        /// </summary>
        public InputList<Inputs.JobDomainNameConfigGetArgs> DomainNameConfigs
        {
            get => _domainNameConfigs ?? (_domainNameConfigs = new InputList<Inputs.JobDomainNameConfigGetArgs>());
            set => _domainNameConfigs = value;
        }

        /// <summary>
        /// Job duration.
        /// </summary>
        [Input("duration")]
        public Input<int>? Duration { get; set; }

        /// <summary>
        /// End time of the job.
        /// </summary>
        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        /// <summary>
        /// Percentage of error rate.
        /// </summary>
        [Input("errorRate")]
        public Input<double>? ErrorRate { get; set; }

        /// <summary>
        /// Job owner.
        /// </summary>
        [Input("jobOwner")]
        public Input<string>? JobOwner { get; set; }

        [Input("loads")]
        private InputList<Inputs.JobLoadGetArgs>? _loads;

        /// <summary>
        /// Pressure configuration of job.
        /// </summary>
        public InputList<Inputs.JobLoadGetArgs> Loads
        {
            get => _loads ?? (_loads = new InputList<Inputs.JobLoadGetArgs>());
            set => _loads = value;
        }

        /// <summary>
        /// Maximum requests per second.
        /// </summary>
        [Input("maxRequestsPerSecond")]
        public Input<int>? MaxRequestsPerSecond { get; set; }

        /// <summary>
        /// Maximum number of VU for the job.
        /// </summary>
        [Input("maxVirtualUserCount")]
        public Input<int>? MaxVirtualUserCount { get; set; }

        /// <summary>
        /// Note.
        /// </summary>
        [Input("note")]
        public Input<string>? Note { get; set; }

        [Input("plugins")]
        private InputList<Inputs.JobPluginGetArgs>? _plugins;

        /// <summary>
        /// Expansion package file information.
        /// </summary>
        public InputList<Inputs.JobPluginGetArgs> Plugins
        {
            get => _plugins ?? (_plugins = new InputList<Inputs.JobPluginGetArgs>());
            set => _plugins = value;
        }

        /// <summary>
        /// Project ID.
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        [Input("protocols")]
        private InputList<Inputs.JobProtocolGetArgs>? _protocols;

        /// <summary>
        /// Protocol script information.
        /// </summary>
        public InputList<Inputs.JobProtocolGetArgs> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<Inputs.JobProtocolGetArgs>());
            set => _protocols = value;
        }

        [Input("requestFiles")]
        private InputList<Inputs.JobRequestFileGetArgs>? _requestFiles;

        /// <summary>
        /// Request file information.
        /// </summary>
        public InputList<Inputs.JobRequestFileGetArgs> RequestFiles
        {
            get => _requestFiles ?? (_requestFiles = new InputList<Inputs.JobRequestFileGetArgs>());
            set => _requestFiles = value;
        }

        /// <summary>
        /// Total number of requests.
        /// </summary>
        [Input("requestTotal")]
        public Input<double>? RequestTotal { get; set; }

        /// <summary>
        /// Average number of requests per second.
        /// </summary>
        [Input("requestsPerSecond")]
        public Input<double>? RequestsPerSecond { get; set; }

        /// <summary>
        /// Average response time.
        /// </summary>
        [Input("responseTimeAverage")]
        public Input<double>? ResponseTimeAverage { get; set; }

        /// <summary>
        /// Maximum response time.
        /// </summary>
        [Input("responseTimeMax")]
        public Input<double>? ResponseTimeMax { get; set; }

        /// <summary>
        /// Minimum response time.
        /// </summary>
        [Input("responseTimeMin")]
        public Input<double>? ResponseTimeMin { get; set; }

        /// <summary>
        /// 90th percentile response time.
        /// </summary>
        [Input("responseTimeP90")]
        public Input<double>? ResponseTimeP90 { get; set; }

        /// <summary>
        /// 95th percentile response time.
        /// </summary>
        [Input("responseTimeP95")]
        public Input<double>? ResponseTimeP95 { get; set; }

        /// <summary>
        /// 99th percentile response time.
        /// </summary>
        [Input("responseTimeP99")]
        public Input<double>? ResponseTimeP99 { get; set; }

        /// <summary>
        /// Pts scenario id.
        /// </summary>
        [Input("scenarioId")]
        public Input<string>? ScenarioId { get; set; }

        /// <summary>
        /// Start time of the job.
        /// </summary>
        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        /// <summary>
        /// The running status of the task; `0`: JobUnknown, `1`: JobCreated, `2`: JobPending, `3`: JobPreparing, `4`: JobSelectClustering, `5`: JobCreateTasking, `6`: JobSyncTasking, `11`: JobRunning, `12`: JobFinished, `13`: JobPrepareException, `14`: JobFinishException, `15`: JobAborting, `16`: JobAborted, `17`: JobAbortException, `18`: JobDeleted, `19`: JobSelectClusterException, `20`: JobCreateTaskException, `21`: JobSyncTaskException.
        /// </summary>
        [Input("status")]
        public Input<int>? Status { get; set; }

        [Input("testScripts")]
        private InputList<Inputs.JobTestScriptGetArgs>? _testScripts;

        /// <summary>
        /// Test script information.
        /// </summary>
        public InputList<Inputs.JobTestScriptGetArgs> TestScripts
        {
            get => _testScripts ?? (_testScripts = new InputList<Inputs.JobTestScriptGetArgs>());
            set => _testScripts = value;
        }

        /// <summary>
        /// Scene Type.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public JobState()
        {
        }
    }
}