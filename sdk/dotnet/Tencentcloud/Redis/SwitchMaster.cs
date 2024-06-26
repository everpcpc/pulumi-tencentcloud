// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Redis
{
    /// <summary>
    /// Provides a resource to create a redis switch_master
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
    ///         var zone = Output.Create(Tencentcloud.Redis.GetZoneConfig.InvokeAsync(new Tencentcloud.Redis.GetZoneConfigArgs
    ///         {
    ///             TypeId = 7,
    ///             Region = "ap-guangzhou",
    ///         }));
    ///         var config = new Config();
    ///         var replicaZoneIds = config.GetObject&lt;dynamic&gt;("replicaZoneIds") ?? 
    ///         {
    ///             100004,
    ///             100006,
    ///         };
    ///         var vpc = new Tencentcloud.Vpc.Instance("vpc", new Tencentcloud.Vpc.InstanceArgs
    ///         {
    ///             CidrBlock = "10.0.0.0/16",
    ///         });
    ///         var subnet = new Tencentcloud.Subnet.Instance("subnet", new Tencentcloud.Subnet.InstanceArgs
    ///         {
    ///             VpcId = vpc.Id,
    ///             AvailabilityZone = zone.Apply(zone =&gt; zone.Lists?[2]?.Zone),
    ///             CidrBlock = "10.0.1.0/24",
    ///         });
    ///         var fooGroup = new Tencentcloud.Security.Group("fooGroup", new Tencentcloud.Security.GroupArgs
    ///         {
    ///         });
    ///         var fooGroupLiteRule = new Tencentcloud.Security.GroupLiteRule("fooGroupLiteRule", new Tencentcloud.Security.GroupLiteRuleArgs
    ///         {
    ///             SecurityGroupId = fooGroup.Id,
    ///             Ingresses = 
    ///             {
    ///                 "ACCEPT#192.168.1.0/24#80#TCP",
    ///                 "DROP#8.8.8.8#80,90#UDP",
    ///                 "DROP#0.0.0.0/0#80-90#TCP",
    ///             },
    ///             Egresses = 
    ///             {
    ///                 "ACCEPT#192.168.0.0/16#ALL#TCP",
    ///                 "ACCEPT#10.0.0.0/8#ALL#ICMP",
    ///                 "DROP#0.0.0.0/0#ALL#ALL",
    ///             },
    ///         });
    ///         var fooInstance = new Tencentcloud.Redis.Instance("fooInstance", new Tencentcloud.Redis.InstanceArgs
    ///         {
    ///             AvailabilityZone = zone.Apply(zone =&gt; zone.Lists?[2]?.Zone),
    ///             TypeId = zone.Apply(zone =&gt; zone.Lists?[2]?.TypeId),
    ///             Password = "test12345789",
    ///             MemSize = 8192,
    ///             RedisShardNum = zone.Apply(zone =&gt; zone.Lists?[2]?.RedisShardNums?[0]),
    ///             RedisReplicasNum = 2,
    ///             ReplicaZoneIds = replicaZoneIds,
    ///             Port = 6379,
    ///             VpcId = vpc.Id,
    ///             SubnetId = subnet.Id,
    ///             SecurityGroups = 
    ///             {
    ///                 fooGroup.Id,
    ///             },
    ///         });
    ///         var fooInstanceZoneInfo = Tencentcloud.Redis.GetInstanceZoneInfo.Invoke(new Tencentcloud.Redis.GetInstanceZoneInfoInvokeArgs
    ///         {
    ///             InstanceId = fooInstance.Id,
    ///         });
    ///         var switchMaster = new Tencentcloud.Redis.SwitchMaster("switchMaster", new Tencentcloud.Redis.SwitchMasterArgs
    ///         {
    ///             InstanceId = fooInstance.Id,
    ///             GroupId = fooInstanceZoneInfo.Apply(fooInstanceZoneInfo =&gt; fooInstanceZoneInfo.ReplicaGroups?[1]?.GroupId),
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Redis/switchMaster:SwitchMaster")]
    public partial class SwitchMaster : Pulumi.CustomResource
    {
        /// <summary>
        /// Replication group ID, required for multi-AZ instances.
        /// </summary>
        [Output("groupId")]
        public Output<int?> GroupId { get; private set; } = null!;

        /// <summary>
        /// The ID of instance.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;


        /// <summary>
        /// Create a SwitchMaster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SwitchMaster(string name, SwitchMasterArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Redis/switchMaster:SwitchMaster", name, args ?? new SwitchMasterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SwitchMaster(string name, Input<string> id, SwitchMasterState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Redis/switchMaster:SwitchMaster", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SwitchMaster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SwitchMaster Get(string name, Input<string> id, SwitchMasterState? state = null, CustomResourceOptions? options = null)
        {
            return new SwitchMaster(name, id, state, options);
        }
    }

    public sealed class SwitchMasterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Replication group ID, required for multi-AZ instances.
        /// </summary>
        [Input("groupId")]
        public Input<int>? GroupId { get; set; }

        /// <summary>
        /// The ID of instance.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        public SwitchMasterArgs()
        {
        }
    }

    public sealed class SwitchMasterState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Replication group ID, required for multi-AZ instances.
        /// </summary>
        [Input("groupId")]
        public Input<int>? GroupId { get; set; }

        /// <summary>
        /// The ID of instance.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        public SwitchMasterState()
        {
        }
    }
}
