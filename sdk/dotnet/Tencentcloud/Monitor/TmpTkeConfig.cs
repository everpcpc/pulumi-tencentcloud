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
    /// Provides a resource to create a tke tmpPrometheusConfig
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Tencentcloud = Pulumi.Tencentcloud;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var config = new Config();
    ///         var defaultInstanceType = config.Get("defaultInstanceType") ?? "SA1.MEDIUM2";
    ///         var availabilityZoneFirst = config.Get("availabilityZoneFirst") ?? "ap-guangzhou-3";
    ///         var availabilityZoneSecond = config.Get("availabilityZoneSecond") ?? "ap-guangzhou-4";
    ///         var exampleClusterCidr = config.Get("exampleClusterCidr") ?? "10.31.0.0/16";
    ///         var vpcOne = Output.Create(Tencentcloud.Vpc.GetSubnets.InvokeAsync(new Tencentcloud.Vpc.GetSubnetsArgs
    ///         {
    ///             IsDefault = true,
    ///             AvailabilityZone = availabilityZoneFirst,
    ///         }));
    ///         var firstVpcId = vpcOne.Apply(vpcOne =&gt; vpcOne.InstanceLists?[0]?.VpcId);
    ///         var firstSubnetId = vpcOne.Apply(vpcOne =&gt; vpcOne.InstanceLists?[0]?.SubnetId);
    ///         var vpcTwo = Output.Create(Tencentcloud.Vpc.GetSubnets.InvokeAsync(new Tencentcloud.Vpc.GetSubnetsArgs
    ///         {
    ///             IsDefault = true,
    ///             AvailabilityZone = availabilityZoneSecond,
    ///         }));
    ///         var secondVpcId = vpcTwo.Apply(vpcTwo =&gt; vpcTwo.InstanceLists?[0]?.VpcId);
    ///         var secondSubnetId = vpcTwo.Apply(vpcTwo =&gt; vpcTwo.InstanceLists?[0]?.SubnetId);
    ///         var sg = new Tencentcloud.Security.Group("sg", new Tencentcloud.Security.GroupArgs
    ///         {
    ///         });
    ///         var sgId = sg.Id;
    ///         var @default = Output.Create(Tencentcloud.Images.GetInstance.InvokeAsync(new Tencentcloud.Images.GetInstanceArgs
    ///         {
    ///             ImageTypes = 
    ///             {
    ///                 "PUBLIC_IMAGE",
    ///             },
    ///             ImageNameRegex = "Final",
    ///         }));
    ///         var imageId = @default.Apply(@default =&gt; @default.ImageId);
    ///         var sgRule = new Tencentcloud.Security.GroupLiteRule("sgRule", new Tencentcloud.Security.GroupLiteRuleArgs
    ///         {
    ///             SecurityGroupId = sg.Id,
    ///             Ingresses = 
    ///             {
    ///                 "ACCEPT#10.0.0.0/16#ALL#ALL",
    ///                 "ACCEPT#172.16.0.0/22#ALL#ALL",
    ///                 "DROP#0.0.0.0/0#ALL#ALL",
    ///             },
    ///             Egresses = 
    ///             {
    ///                 "ACCEPT#172.16.0.0/22#ALL#ALL",
    ///             },
    ///         });
    ///         var example = new Tencentcloud.Kubernetes.Cluster("example", new Tencentcloud.Kubernetes.ClusterArgs
    ///         {
    ///             VpcId = firstVpcId,
    ///             ClusterCidr = exampleClusterCidr,
    ///             ClusterMaxPodNum = 32,
    ///             ClusterName = "tf_example_cluster",
    ///             ClusterDesc = "example for tke cluster",
    ///             ClusterMaxServiceNum = 32,
    ///             ClusterInternet = false,
    ///             ClusterInternetSecurityGroup = sgId,
    ///             ClusterVersion = "1.22.5",
    ///             ClusterDeployType = "MANAGED_CLUSTER",
    ///             WorkerConfigs = 
    ///             {
    ///                 new Tencentcloud.Kubernetes.Inputs.ClusterWorkerConfigArgs
    ///                 {
    ///                     Count = 1,
    ///                     AvailabilityZone = availabilityZoneFirst,
    ///                     InstanceType = defaultInstanceType,
    ///                     SystemDiskType = "CLOUD_SSD",
    ///                     SystemDiskSize = 60,
    ///                     InternetChargeType = "TRAFFIC_POSTPAID_BY_HOUR",
    ///                     InternetMaxBandwidthOut = 100,
    ///                     PublicIpAssigned = true,
    ///                     SubnetId = firstSubnetId,
    ///                     ImgId = imageId,
    ///                     DataDisks = 
    ///                     {
    ///                         new Tencentcloud.Kubernetes.Inputs.ClusterWorkerConfigDataDiskArgs
    ///                         {
    ///                             DiskType = "CLOUD_PREMIUM",
    ///                             DiskSize = 50,
    ///                         },
    ///                     },
    ///                     EnhancedSecurityService = false,
    ///                     EnhancedMonitorService = false,
    ///                     UserData = "dGVzdA==",
    ///                     Password = "ZZXXccvv1212",
    ///                 },
    ///                 new Tencentcloud.Kubernetes.Inputs.ClusterWorkerConfigArgs
    ///                 {
    ///                     Count = 1,
    ///                     AvailabilityZone = availabilityZoneSecond,
    ///                     InstanceType = defaultInstanceType,
    ///                     SystemDiskType = "CLOUD_SSD",
    ///                     SystemDiskSize = 60,
    ///                     InternetChargeType = "TRAFFIC_POSTPAID_BY_HOUR",
    ///                     InternetMaxBandwidthOut = 100,
    ///                     PublicIpAssigned = true,
    ///                     SubnetId = secondSubnetId,
    ///                     DataDisks = 
    ///                     {
    ///                         new Tencentcloud.Kubernetes.Inputs.ClusterWorkerConfigDataDiskArgs
    ///                         {
    ///                             DiskType = "CLOUD_PREMIUM",
    ///                             DiskSize = 50,
    ///                         },
    ///                     },
    ///                     EnhancedSecurityService = false,
    ///                     EnhancedMonitorService = false,
    ///                     UserData = "dGVzdA==",
    ///                     CamRoleName = "CVM_QcsRole",
    ///                     Password = "ZZXXccvv1212",
    ///                 },
    ///             },
    ///             Labels = 
    ///             {
    ///                 { "test1", "test1" },
    ///                 { "test2", "test2" },
    ///             },
    ///         });
    ///         var zone = config.Get("zone") ?? "ap-guangzhou";
    ///         var clusterType = config.Get("clusterType") ?? "tke";
    ///         var fooTmpInstance = new Tencentcloud.Monitor.TmpInstance("fooTmpInstance", new Tencentcloud.Monitor.TmpInstanceArgs
    ///         {
    ///             InstanceName = "tf-tmp-instance",
    ///             VpcId = firstVpcId,
    ///             SubnetId = firstSubnetId,
    ///             DataRetentionTime = 30,
    ///             Zone = availabilityZoneSecond,
    ///             Tags = 
    ///             {
    ///                 { "createdBy", "terraform" },
    ///             },
    ///         });
    ///         // tmp tke bind
    ///         var fooTmpTkeClusterAgent = new Tencentcloud.Monitor.TmpTkeClusterAgent("fooTmpTkeClusterAgent", new Tencentcloud.Monitor.TmpTkeClusterAgentArgs
    ///         {
    ///             InstanceId = fooTmpInstance.Id,
    ///             Agents = new Tencentcloud.Monitor.Inputs.TmpTkeClusterAgentAgentsArgs
    ///             {
    ///                 Region = zone,
    ///                 ClusterType = clusterType,
    ///                 ClusterId = example.Id,
    ///                 EnableExternal = false,
    ///             },
    ///         });
    ///         var fooTmpTkeConfig = new Tencentcloud.Monitor.TmpTkeConfig("fooTmpTkeConfig", new Tencentcloud.Monitor.TmpTkeConfigArgs
    ///         {
    ///             InstanceId = fooTmpInstance.Id,
    ///             ClusterType = clusterType,
    ///             ClusterId = example.Id,
    ///             RawJobs = 
    ///             {
    ///                 new Tencentcloud.Monitor.Inputs.TmpTkeConfigRawJobArgs
    ///                 {
    ///                     Name = "raw_jobs_001",
    ///                     Config = @"your config for raw_jobs_001
    /// ",
    ///                 },
    ///             },
    ///             ServiceMonitors = 
    ///             {
    ///                 new Tencentcloud.Monitor.Inputs.TmpTkeConfigServiceMonitorArgs
    ///                 {
    ///                     Name = "kube-system/service-monitor-001",
    ///                     Config = @"apiVersion: monitoring.coreos.com/v1
    /// kind: ServiceMonitor
    /// metadata:
    ///   name: service-monitor-001
    ///   namespace: kube-system
    /// ",
    ///                 },
    ///             },
    ///             PodMonitors = 
    ///             {
    ///                 new Tencentcloud.Monitor.Inputs.TmpTkeConfigPodMonitorArgs
    ///                 {
    ///                     Name = "mynamespace/pod-monitor-001",
    ///                     Config = @"apiVersion: monitoring.coreos.com/v1
    /// kind: PodMonitor
    /// metadata:
    ///   name: pod-monitor-001
    ///   namespace: mynamespace
    /// ",
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Monitor/tmpTkeConfig:TmpTkeConfig")]
    public partial class TmpTkeConfig : Pulumi.CustomResource
    {
        /// <summary>
        /// ID of cluster.
        /// </summary>
        [Output("clusterId")]
        public Output<string> ClusterId { get; private set; } = null!;

        /// <summary>
        /// Type of cluster.
        /// </summary>
        [Output("clusterType")]
        public Output<string> ClusterType { get; private set; } = null!;

        /// <summary>
        /// Config.
        /// </summary>
        [Output("config")]
        public Output<string> Config { get; private set; } = null!;

        /// <summary>
        /// ID of instance.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// Configuration of the pod monitors.
        /// </summary>
        [Output("podMonitors")]
        public Output<ImmutableArray<Outputs.TmpTkeConfigPodMonitor>> PodMonitors { get; private set; } = null!;

        /// <summary>
        /// Configuration of the native prometheus job.
        /// </summary>
        [Output("rawJobs")]
        public Output<ImmutableArray<Outputs.TmpTkeConfigRawJob>> RawJobs { get; private set; } = null!;

        /// <summary>
        /// Configuration of the service monitors.
        /// </summary>
        [Output("serviceMonitors")]
        public Output<ImmutableArray<Outputs.TmpTkeConfigServiceMonitor>> ServiceMonitors { get; private set; } = null!;


        /// <summary>
        /// Create a TmpTkeConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TmpTkeConfig(string name, TmpTkeConfigArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Monitor/tmpTkeConfig:TmpTkeConfig", name, args ?? new TmpTkeConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TmpTkeConfig(string name, Input<string> id, TmpTkeConfigState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Monitor/tmpTkeConfig:TmpTkeConfig", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing TmpTkeConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TmpTkeConfig Get(string name, Input<string> id, TmpTkeConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new TmpTkeConfig(name, id, state, options);
        }
    }

    public sealed class TmpTkeConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of cluster.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// Type of cluster.
        /// </summary>
        [Input("clusterType", required: true)]
        public Input<string> ClusterType { get; set; } = null!;

        /// <summary>
        /// ID of instance.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("podMonitors")]
        private InputList<Inputs.TmpTkeConfigPodMonitorArgs>? _podMonitors;

        /// <summary>
        /// Configuration of the pod monitors.
        /// </summary>
        public InputList<Inputs.TmpTkeConfigPodMonitorArgs> PodMonitors
        {
            get => _podMonitors ?? (_podMonitors = new InputList<Inputs.TmpTkeConfigPodMonitorArgs>());
            set => _podMonitors = value;
        }

        [Input("rawJobs")]
        private InputList<Inputs.TmpTkeConfigRawJobArgs>? _rawJobs;

        /// <summary>
        /// Configuration of the native prometheus job.
        /// </summary>
        public InputList<Inputs.TmpTkeConfigRawJobArgs> RawJobs
        {
            get => _rawJobs ?? (_rawJobs = new InputList<Inputs.TmpTkeConfigRawJobArgs>());
            set => _rawJobs = value;
        }

        [Input("serviceMonitors")]
        private InputList<Inputs.TmpTkeConfigServiceMonitorArgs>? _serviceMonitors;

        /// <summary>
        /// Configuration of the service monitors.
        /// </summary>
        public InputList<Inputs.TmpTkeConfigServiceMonitorArgs> ServiceMonitors
        {
            get => _serviceMonitors ?? (_serviceMonitors = new InputList<Inputs.TmpTkeConfigServiceMonitorArgs>());
            set => _serviceMonitors = value;
        }

        public TmpTkeConfigArgs()
        {
        }
    }

    public sealed class TmpTkeConfigState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of cluster.
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        /// <summary>
        /// Type of cluster.
        /// </summary>
        [Input("clusterType")]
        public Input<string>? ClusterType { get; set; }

        /// <summary>
        /// Config.
        /// </summary>
        [Input("config")]
        public Input<string>? Config { get; set; }

        /// <summary>
        /// ID of instance.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("podMonitors")]
        private InputList<Inputs.TmpTkeConfigPodMonitorGetArgs>? _podMonitors;

        /// <summary>
        /// Configuration of the pod monitors.
        /// </summary>
        public InputList<Inputs.TmpTkeConfigPodMonitorGetArgs> PodMonitors
        {
            get => _podMonitors ?? (_podMonitors = new InputList<Inputs.TmpTkeConfigPodMonitorGetArgs>());
            set => _podMonitors = value;
        }

        [Input("rawJobs")]
        private InputList<Inputs.TmpTkeConfigRawJobGetArgs>? _rawJobs;

        /// <summary>
        /// Configuration of the native prometheus job.
        /// </summary>
        public InputList<Inputs.TmpTkeConfigRawJobGetArgs> RawJobs
        {
            get => _rawJobs ?? (_rawJobs = new InputList<Inputs.TmpTkeConfigRawJobGetArgs>());
            set => _rawJobs = value;
        }

        [Input("serviceMonitors")]
        private InputList<Inputs.TmpTkeConfigServiceMonitorGetArgs>? _serviceMonitors;

        /// <summary>
        /// Configuration of the service monitors.
        /// </summary>
        public InputList<Inputs.TmpTkeConfigServiceMonitorGetArgs> ServiceMonitors
        {
            get => _serviceMonitors ?? (_serviceMonitors = new InputList<Inputs.TmpTkeConfigServiceMonitorGetArgs>());
            set => _serviceMonitors = value;
        }

        public TmpTkeConfigState()
        {
        }
    }
}
