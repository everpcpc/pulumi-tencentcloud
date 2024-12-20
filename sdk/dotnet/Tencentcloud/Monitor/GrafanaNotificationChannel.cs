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
    /// <summary>
    /// Provides a resource to create a monitor grafanaNotificationChannel
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
    ///     var config = new Config();
    ///     var availabilityZone = config.Get("availabilityZone") ?? "ap-guangzhou-6";
    ///     var vpc = new Tencentcloud.Vpc.Instance("vpc", new()
    ///     {
    ///         CidrBlock = "10.0.0.0/16",
    ///     });
    /// 
    ///     var subnet = new Tencentcloud.Subnet.Instance("subnet", new()
    ///     {
    ///         VpcId = vpc.Id,
    ///         AvailabilityZone = availabilityZone,
    ///         CidrBlock = "10.0.1.0/24",
    ///     });
    /// 
    ///     var fooGrafanaInstance = new Tencentcloud.Monitor.GrafanaInstance("fooGrafanaInstance", new()
    ///     {
    ///         InstanceName = "test-grafana",
    ///         VpcId = vpc.Id,
    ///         SubnetIds = new[]
    ///         {
    ///             subnet.Id,
    ///         },
    ///         GrafanaInitPassword = "1234567890",
    ///         EnableInternet = false,
    ///         Tags = 
    ///         {
    ///             { "createdBy", "test" },
    ///         },
    ///     });
    /// 
    ///     var fooAlarmNotice = new Tencentcloud.Monitor.AlarmNotice("fooAlarmNotice", new()
    ///     {
    ///         NoticeType = "ALL",
    ///         NoticeLanguage = "zh-CN",
    ///         UserNotices = new[]
    ///         {
    ///             new Tencentcloud.Monitor.Inputs.AlarmNoticeUserNoticeArgs
    ///             {
    ///                 ReceiverType = "USER",
    ///                 StartTime = 0,
    ///                 EndTime = 1,
    ///                 NoticeWays = new[]
    ///                 {
    ///                     "SMS",
    ///                     "EMAIL",
    ///                 },
    ///                 UserIds = new[]
    ///                 {
    ///                     10001,
    ///                 },
    ///                 GroupIds = new() { },
    ///                 PhoneOrders = new[]
    ///                 {
    ///                     10001,
    ///                 },
    ///                 PhoneCircleTimes = 2,
    ///                 PhoneCircleInterval = 50,
    ///                 PhoneInnerInterval = 60,
    ///                 NeedPhoneArriveNotice = 1,
    ///                 PhoneCallType = "CIRCLE",
    ///                 Weekdays = new[]
    ///                 {
    ///                     1,
    ///                     2,
    ///                     3,
    ///                     4,
    ///                     5,
    ///                     6,
    ///                     7,
    ///                 },
    ///             },
    ///         },
    ///         UrlNotices = new[]
    ///         {
    ///             new Tencentcloud.Monitor.Inputs.AlarmNoticeUrlNoticeArgs
    ///             {
    ///                 Url = "https://www.mytest.com/validate",
    ///                 EndTime = 0,
    ///                 StartTime = 1,
    ///                 Weekdays = new[]
    ///                 {
    ///                     1,
    ///                     2,
    ///                     3,
    ///                     4,
    ///                     5,
    ///                     6,
    ///                     7,
    ///                 },
    ///             },
    ///         },
    ///     });
    /// 
    ///     var grafanaNotificationChannel = new Tencentcloud.Monitor.GrafanaNotificationChannel("grafanaNotificationChannel", new()
    ///     {
    ///         InstanceId = fooGrafanaInstance.Id,
    ///         ChannelName = "tf-channel",
    ///         OrgId = 1,
    ///         Receivers = new[]
    ///         {
    ///             fooAlarmNotice.AmpConsumerId,
    ///         },
    ///         ExtraOrgIds = new[]
    ///         {
    ///             "1",
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Monitor/grafanaNotificationChannel:GrafanaNotificationChannel")]
    public partial class GrafanaNotificationChannel : global::Pulumi.CustomResource
    {
        /// <summary>
        /// plugin id.
        /// </summary>
        [Output("channelId")]
        public Output<string> ChannelId { get; private set; } = null!;

        /// <summary>
        /// channel name.
        /// </summary>
        [Output("channelName")]
        public Output<string> ChannelName { get; private set; } = null!;

        /// <summary>
        /// extra grafana organization id list, default to 1 representing Main Org.
        /// </summary>
        [Output("extraOrgIds")]
        public Output<ImmutableArray<string>> ExtraOrgIds { get; private set; } = null!;

        /// <summary>
        /// grafana instance id.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// Grafana organization which channel will be installed, default to 1 representing Main Org.
        /// </summary>
        [Output("orgId")]
        public Output<int> OrgId { get; private set; } = null!;

        /// <summary>
        /// cloud monitor notification template notice-id list.
        /// </summary>
        [Output("receivers")]
        public Output<ImmutableArray<string>> Receivers { get; private set; } = null!;


        /// <summary>
        /// Create a GrafanaNotificationChannel resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GrafanaNotificationChannel(string name, GrafanaNotificationChannelArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Monitor/grafanaNotificationChannel:GrafanaNotificationChannel", name, args ?? new GrafanaNotificationChannelArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GrafanaNotificationChannel(string name, Input<string> id, GrafanaNotificationChannelState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Monitor/grafanaNotificationChannel:GrafanaNotificationChannel", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing GrafanaNotificationChannel resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GrafanaNotificationChannel Get(string name, Input<string> id, GrafanaNotificationChannelState? state = null, CustomResourceOptions? options = null)
        {
            return new GrafanaNotificationChannel(name, id, state, options);
        }
    }

    public sealed class GrafanaNotificationChannelArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// channel name.
        /// </summary>
        [Input("channelName")]
        public Input<string>? ChannelName { get; set; }

        [Input("extraOrgIds")]
        private InputList<string>? _extraOrgIds;

        /// <summary>
        /// extra grafana organization id list, default to 1 representing Main Org.
        /// </summary>
        public InputList<string> ExtraOrgIds
        {
            get => _extraOrgIds ?? (_extraOrgIds = new InputList<string>());
            set => _extraOrgIds = value;
        }

        /// <summary>
        /// grafana instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Grafana organization which channel will be installed, default to 1 representing Main Org.
        /// </summary>
        [Input("orgId")]
        public Input<int>? OrgId { get; set; }

        [Input("receivers")]
        private InputList<string>? _receivers;

        /// <summary>
        /// cloud monitor notification template notice-id list.
        /// </summary>
        public InputList<string> Receivers
        {
            get => _receivers ?? (_receivers = new InputList<string>());
            set => _receivers = value;
        }

        public GrafanaNotificationChannelArgs()
        {
        }
        public static new GrafanaNotificationChannelArgs Empty => new GrafanaNotificationChannelArgs();
    }

    public sealed class GrafanaNotificationChannelState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// plugin id.
        /// </summary>
        [Input("channelId")]
        public Input<string>? ChannelId { get; set; }

        /// <summary>
        /// channel name.
        /// </summary>
        [Input("channelName")]
        public Input<string>? ChannelName { get; set; }

        [Input("extraOrgIds")]
        private InputList<string>? _extraOrgIds;

        /// <summary>
        /// extra grafana organization id list, default to 1 representing Main Org.
        /// </summary>
        public InputList<string> ExtraOrgIds
        {
            get => _extraOrgIds ?? (_extraOrgIds = new InputList<string>());
            set => _extraOrgIds = value;
        }

        /// <summary>
        /// grafana instance id.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// Grafana organization which channel will be installed, default to 1 representing Main Org.
        /// </summary>
        [Input("orgId")]
        public Input<int>? OrgId { get; set; }

        [Input("receivers")]
        private InputList<string>? _receivers;

        /// <summary>
        /// cloud monitor notification template notice-id list.
        /// </summary>
        public InputList<string> Receivers
        {
            get => _receivers ?? (_receivers = new InputList<string>());
            set => _receivers = value;
        }

        public GrafanaNotificationChannelState()
        {
        }
        public static new GrafanaNotificationChannelState Empty => new GrafanaNotificationChannelState();
    }
}
