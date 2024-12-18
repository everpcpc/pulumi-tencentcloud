// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor
{
    public static class GetAlarmBasicAlarms
    {
        /// <summary>
        /// Use this data source to query detailed information of monitor basic_alarms
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
        ///     var alarms = Tencentcloud.Monitor.GetAlarmBasicAlarms.Invoke(new()
        ///     {
        ///         AlarmStatuses = new[]
        ///         {
        ///             1,
        ///         },
        ///         EndTime = 1697098903,
        ///         InstanceGroupIds = new[]
        ///         {
        ///             5497073,
        ///         },
        ///         MetricNames = new[]
        ///         {
        ///             "cpu_usage",
        ///         },
        ///         Module = "monitor",
        ///         OccurTimeOrder = "DESC",
        ///         ProjectIds = new[]
        ///         {
        ///             0,
        ///         },
        ///         StartTime = 1696990903,
        ///         ViewNames = new[]
        ///         {
        ///             "cvm_device",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetAlarmBasicAlarmsResult> InvokeAsync(GetAlarmBasicAlarmsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetAlarmBasicAlarmsResult>("tencentcloud:Monitor/getAlarmBasicAlarms:getAlarmBasicAlarms", args ?? new GetAlarmBasicAlarmsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of monitor basic_alarms
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
        ///     var alarms = Tencentcloud.Monitor.GetAlarmBasicAlarms.Invoke(new()
        ///     {
        ///         AlarmStatuses = new[]
        ///         {
        ///             1,
        ///         },
        ///         EndTime = 1697098903,
        ///         InstanceGroupIds = new[]
        ///         {
        ///             5497073,
        ///         },
        ///         MetricNames = new[]
        ///         {
        ///             "cpu_usage",
        ///         },
        ///         Module = "monitor",
        ///         OccurTimeOrder = "DESC",
        ///         ProjectIds = new[]
        ///         {
        ///             0,
        ///         },
        ///         StartTime = 1696990903,
        ///         ViewNames = new[]
        ///         {
        ///             "cvm_device",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetAlarmBasicAlarmsResult> Invoke(GetAlarmBasicAlarmsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetAlarmBasicAlarmsResult>("tencentcloud:Monitor/getAlarmBasicAlarms:getAlarmBasicAlarms", args ?? new GetAlarmBasicAlarmsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAlarmBasicAlarmsArgs : global::Pulumi.InvokeArgs
    {
        [Input("alarmStatuses")]
        private List<int>? _alarmStatuses;

        /// <summary>
        /// Filter based on alarm status.
        /// </summary>
        public List<int> AlarmStatuses
        {
            get => _alarmStatuses ?? (_alarmStatuses = new List<int>());
            set => _alarmStatuses = value;
        }

        /// <summary>
        /// End time, default to current timestamp.
        /// </summary>
        [Input("endTime")]
        public int? EndTime { get; set; }

        [Input("instanceGroupIds")]
        private List<int>? _instanceGroupIds;

        /// <summary>
        /// Filter based on instance group ID.
        /// </summary>
        public List<int> InstanceGroupIds
        {
            get => _instanceGroupIds ?? (_instanceGroupIds = new List<int>());
            set => _instanceGroupIds = value;
        }

        [Input("metricNames")]
        private List<string>? _metricNames;

        /// <summary>
        /// Filter by indicator name.
        /// </summary>
        public List<string> MetricNames
        {
            get => _metricNames ?? (_metricNames = new List<string>());
            set => _metricNames = value;
        }

        /// <summary>
        /// Interface module name, current value monitor.
        /// </summary>
        [Input("module", required: true)]
        public string Module { get; set; } = null!;

        /// <summary>
        /// Filter based on alarm objects.
        /// </summary>
        [Input("objLike")]
        public string? ObjLike { get; set; }

        /// <summary>
        /// Sort by occurrence time, taking ASC or DESC values.
        /// </summary>
        [Input("occurTimeOrder")]
        public string? OccurTimeOrder { get; set; }

        [Input("projectIds")]
        private List<int>? _projectIds;

        /// <summary>
        /// Filter based on project ID.
        /// </summary>
        public List<int> ProjectIds
        {
            get => _projectIds ?? (_projectIds = new List<int>());
            set => _projectIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Start time, default to one day is timestamp.
        /// </summary>
        [Input("startTime")]
        public int? StartTime { get; set; }

        [Input("viewNames")]
        private List<string>? _viewNames;

        /// <summary>
        /// Filter based on policy type.
        /// </summary>
        public List<string> ViewNames
        {
            get => _viewNames ?? (_viewNames = new List<string>());
            set => _viewNames = value;
        }

        public GetAlarmBasicAlarmsArgs()
        {
        }
        public static new GetAlarmBasicAlarmsArgs Empty => new GetAlarmBasicAlarmsArgs();
    }

    public sealed class GetAlarmBasicAlarmsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("alarmStatuses")]
        private InputList<int>? _alarmStatuses;

        /// <summary>
        /// Filter based on alarm status.
        /// </summary>
        public InputList<int> AlarmStatuses
        {
            get => _alarmStatuses ?? (_alarmStatuses = new InputList<int>());
            set => _alarmStatuses = value;
        }

        /// <summary>
        /// End time, default to current timestamp.
        /// </summary>
        [Input("endTime")]
        public Input<int>? EndTime { get; set; }

        [Input("instanceGroupIds")]
        private InputList<int>? _instanceGroupIds;

        /// <summary>
        /// Filter based on instance group ID.
        /// </summary>
        public InputList<int> InstanceGroupIds
        {
            get => _instanceGroupIds ?? (_instanceGroupIds = new InputList<int>());
            set => _instanceGroupIds = value;
        }

        [Input("metricNames")]
        private InputList<string>? _metricNames;

        /// <summary>
        /// Filter by indicator name.
        /// </summary>
        public InputList<string> MetricNames
        {
            get => _metricNames ?? (_metricNames = new InputList<string>());
            set => _metricNames = value;
        }

        /// <summary>
        /// Interface module name, current value monitor.
        /// </summary>
        [Input("module", required: true)]
        public Input<string> Module { get; set; } = null!;

        /// <summary>
        /// Filter based on alarm objects.
        /// </summary>
        [Input("objLike")]
        public Input<string>? ObjLike { get; set; }

        /// <summary>
        /// Sort by occurrence time, taking ASC or DESC values.
        /// </summary>
        [Input("occurTimeOrder")]
        public Input<string>? OccurTimeOrder { get; set; }

        [Input("projectIds")]
        private InputList<int>? _projectIds;

        /// <summary>
        /// Filter based on project ID.
        /// </summary>
        public InputList<int> ProjectIds
        {
            get => _projectIds ?? (_projectIds = new InputList<int>());
            set => _projectIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Start time, default to one day is timestamp.
        /// </summary>
        [Input("startTime")]
        public Input<int>? StartTime { get; set; }

        [Input("viewNames")]
        private InputList<string>? _viewNames;

        /// <summary>
        /// Filter based on policy type.
        /// </summary>
        public InputList<string> ViewNames
        {
            get => _viewNames ?? (_viewNames = new InputList<string>());
            set => _viewNames = value;
        }

        public GetAlarmBasicAlarmsInvokeArgs()
        {
        }
        public static new GetAlarmBasicAlarmsInvokeArgs Empty => new GetAlarmBasicAlarmsInvokeArgs();
    }


    [OutputType]
    public sealed class GetAlarmBasicAlarmsResult
    {
        /// <summary>
        /// Alarm status, ALARM indicates not recovered; OK indicates that it has been restored; NO_ DATA indicates insufficient data; NO_ CONF indicates that it has expired.
        /// </summary>
        public readonly ImmutableArray<int> AlarmStatuses;
        /// <summary>
        /// Alarm List.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAlarmBasicAlarmsAlarmResult> Alarms;
        public readonly int? EndTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<int> InstanceGroupIds;
        public readonly ImmutableArray<string> MetricNames;
        public readonly string Module;
        public readonly string? ObjLike;
        public readonly string? OccurTimeOrder;
        public readonly ImmutableArray<int> ProjectIds;
        public readonly string? ResultOutputFile;
        public readonly int? StartTime;
        public readonly ImmutableArray<string> ViewNames;
        /// <summary>
        /// Remarks.
        /// </summary>
        public readonly string Warning;

        [OutputConstructor]
        private GetAlarmBasicAlarmsResult(
            ImmutableArray<int> alarmStatuses,

            ImmutableArray<Outputs.GetAlarmBasicAlarmsAlarmResult> alarms,

            int? endTime,

            string id,

            ImmutableArray<int> instanceGroupIds,

            ImmutableArray<string> metricNames,

            string module,

            string? objLike,

            string? occurTimeOrder,

            ImmutableArray<int> projectIds,

            string? resultOutputFile,

            int? startTime,

            ImmutableArray<string> viewNames,

            string warning)
        {
            AlarmStatuses = alarmStatuses;
            Alarms = alarms;
            EndTime = endTime;
            Id = id;
            InstanceGroupIds = instanceGroupIds;
            MetricNames = metricNames;
            Module = module;
            ObjLike = objLike;
            OccurTimeOrder = occurTimeOrder;
            ProjectIds = projectIds;
            ResultOutputFile = resultOutputFile;
            StartTime = startTime;
            ViewNames = viewNames;
            Warning = warning;
        }
    }
}
