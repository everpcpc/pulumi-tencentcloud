// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.As
{
    /// <summary>
    /// Provides a resource to create a as complete_lifecycle
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = Pulumi.Tencentcloud;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var zones = Tencentcloud.Availability.GetZonesByProduct.Invoke(new()
    ///     {
    ///         Product = "as",
    ///     });
    /// 
    ///     var image = Tencentcloud.Images.GetInstance.Invoke(new()
    ///     {
    ///         ImageTypes = new[]
    ///         {
    ///             "PUBLIC_IMAGE",
    ///         },
    ///         OsName = "TencentOS Server 3.2 (Final)",
    ///     });
    /// 
    ///     var instanceTypes = Tencentcloud.Instance.GetTypes.Invoke(new()
    ///     {
    ///         Filters = new[]
    ///         {
    ///             new Tencentcloud.Instance.Inputs.GetTypesFilterInputArgs
    ///             {
    ///                 Name = "zone",
    ///                 Values = new[]
    ///                 {
    ///                     zones.Apply(getZonesByProductResult =&gt; getZonesByProductResult.Zones[0]?.Name),
    ///                 },
    ///             },
    ///             new Tencentcloud.Instance.Inputs.GetTypesFilterInputArgs
    ///             {
    ///                 Name = "instance-family",
    ///                 Values = new[]
    ///                 {
    ///                     "S5",
    ///                 },
    ///             },
    ///         },
    ///         CpuCoreCount = 2,
    ///         ExcludeSoldOut = true,
    ///     });
    /// 
    ///     var vpc = new Tencentcloud.Vpc.Instance("vpc", new()
    ///     {
    ///         CidrBlock = "10.0.0.0/16",
    ///     });
    /// 
    ///     var subnet = new Tencentcloud.Subnet.Instance("subnet", new()
    ///     {
    ///         VpcId = vpc.Id,
    ///         CidrBlock = "10.0.0.0/16",
    ///         AvailabilityZone = zones.Apply(getZonesByProductResult =&gt; getZonesByProductResult.Zones[0]?.Name),
    ///     });
    /// 
    ///     var exampleScalingConfig = new Tencentcloud.As.ScalingConfig("exampleScalingConfig", new()
    ///     {
    ///         ConfigurationName = "tf-example",
    ///         ImageId = image.Apply(getInstanceResult =&gt; getInstanceResult.Images[0]?.ImageId),
    ///         InstanceTypes = new[]
    ///         {
    ///             "SA1.SMALL1",
    ///             "SA2.SMALL1",
    ///             "SA2.SMALL2",
    ///             "SA2.SMALL4",
    ///         },
    ///         InstanceNameSettings = new Tencentcloud.As.Inputs.ScalingConfigInstanceNameSettingsArgs
    ///         {
    ///             InstanceName = "test-ins-name",
    ///         },
    ///     });
    /// 
    ///     var exampleScalingGroup = new Tencentcloud.As.ScalingGroup("exampleScalingGroup", new()
    ///     {
    ///         ScalingGroupName = "tf-example",
    ///         ConfigurationId = exampleScalingConfig.Id,
    ///         MaxSize = 1,
    ///         MinSize = 0,
    ///         VpcId = vpc.Id,
    ///         SubnetIds = new[]
    ///         {
    ///             subnet.Id,
    ///         },
    ///     });
    /// 
    ///     var exampleLifecycleHook = new Tencentcloud.As.LifecycleHook("exampleLifecycleHook", new()
    ///     {
    ///         ScalingGroupId = exampleScalingGroup.Id,
    ///         LifecycleHookName = "tf-as-lifecycle-hook",
    ///         LifecycleTransition = "INSTANCE_LAUNCHING",
    ///         DefaultResult = "CONTINUE",
    ///         HeartbeatTimeout = 500,
    ///         NotificationMetadata = "tf test",
    ///     });
    /// 
    ///     var exampleInstance = new Tencentcloud.Instance.Instance("exampleInstance", new()
    ///     {
    ///         InstanceName = "tf_example",
    ///         AvailabilityZone = zones.Apply(getZonesByProductResult =&gt; getZonesByProductResult.Zones[0]?.Name),
    ///         ImageId = image.Apply(getInstanceResult =&gt; getInstanceResult.Images[0]?.ImageId),
    ///         InstanceType = instanceTypes.Apply(getTypesResult =&gt; getTypesResult.InstanceTypes[0]?.InstanceType),
    ///         SystemDiskType = "CLOUD_PREMIUM",
    ///         SystemDiskSize = 50,
    ///         Hostname = "user",
    ///         ProjectId = 0,
    ///         VpcId = vpc.Id,
    ///         SubnetId = subnet.Id,
    ///     });
    /// 
    ///     var completeLifecycle = new Tencentcloud.As.CompleteLifecycle("completeLifecycle", new()
    ///     {
    ///         LifecycleHookId = exampleLifecycleHook.Id,
    ///         InstanceId = exampleInstance.Id,
    ///         LifecycleActionResult = "CONTINUE",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [TencentcloudResourceType("tencentcloud:As/completeLifecycle:CompleteLifecycle")]
    public partial class CompleteLifecycle : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Instance ID. Either InstanceId or LifecycleActionToken must be specified.
        /// </summary>
        [Output("instanceId")]
        public Output<string?> InstanceId { get; private set; } = null!;

        /// <summary>
        /// Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
        /// </summary>
        [Output("lifecycleActionResult")]
        public Output<string> LifecycleActionResult { get; private set; } = null!;

        /// <summary>
        /// Either InstanceId or LifecycleActionToken must be specified.
        /// </summary>
        [Output("lifecycleActionToken")]
        public Output<string?> LifecycleActionToken { get; private set; } = null!;

        /// <summary>
        /// Lifecycle hook ID.
        /// </summary>
        [Output("lifecycleHookId")]
        public Output<string> LifecycleHookId { get; private set; } = null!;


        /// <summary>
        /// Create a CompleteLifecycle resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CompleteLifecycle(string name, CompleteLifecycleArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:As/completeLifecycle:CompleteLifecycle", name, args ?? new CompleteLifecycleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CompleteLifecycle(string name, Input<string> id, CompleteLifecycleState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:As/completeLifecycle:CompleteLifecycle", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CompleteLifecycle resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CompleteLifecycle Get(string name, Input<string> id, CompleteLifecycleState? state = null, CustomResourceOptions? options = null)
        {
            return new CompleteLifecycle(name, id, state, options);
        }
    }

    public sealed class CompleteLifecycleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance ID. Either InstanceId or LifecycleActionToken must be specified.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
        /// </summary>
        [Input("lifecycleActionResult", required: true)]
        public Input<string> LifecycleActionResult { get; set; } = null!;

        /// <summary>
        /// Either InstanceId or LifecycleActionToken must be specified.
        /// </summary>
        [Input("lifecycleActionToken")]
        public Input<string>? LifecycleActionToken { get; set; }

        /// <summary>
        /// Lifecycle hook ID.
        /// </summary>
        [Input("lifecycleHookId", required: true)]
        public Input<string> LifecycleHookId { get; set; } = null!;

        public CompleteLifecycleArgs()
        {
        }
        public static new CompleteLifecycleArgs Empty => new CompleteLifecycleArgs();
    }

    public sealed class CompleteLifecycleState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance ID. Either InstanceId or LifecycleActionToken must be specified.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
        /// </summary>
        [Input("lifecycleActionResult")]
        public Input<string>? LifecycleActionResult { get; set; }

        /// <summary>
        /// Either InstanceId or LifecycleActionToken must be specified.
        /// </summary>
        [Input("lifecycleActionToken")]
        public Input<string>? LifecycleActionToken { get; set; }

        /// <summary>
        /// Lifecycle hook ID.
        /// </summary>
        [Input("lifecycleHookId")]
        public Input<string>? LifecycleHookId { get; set; }

        public CompleteLifecycleState()
        {
        }
        public static new CompleteLifecycleState Empty => new CompleteLifecycleState();
    }
}