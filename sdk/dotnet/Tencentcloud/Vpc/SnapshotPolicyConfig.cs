// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc
{
    /// <summary>
    /// Provides a resource to create a vpc snapshot_policy_config
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
    ///     var exampleBucket = new Tencentcloud.Cos.Bucket("exampleBucket", new()
    ///     {
    ///         CosBucket = "tf-example-1308919341",
    ///         Acl = "private",
    ///     });
    /// 
    ///     var exampleSnapshotPolicy = new Tencentcloud.Vpc.SnapshotPolicy("exampleSnapshotPolicy", new()
    ///     {
    ///         SnapshotPolicyName = "tf-example",
    ///         BackupType = "time",
    ///         CosBucket = exampleBucket.CosBucket,
    ///         CosRegion = "ap-guangzhou",
    ///         CreateNewCos = false,
    ///         KeepTime = 2,
    ///         BackupPolicies = new[]
    ///         {
    ///             new Tencentcloud.Vpc.Inputs.SnapshotPolicyBackupPolicyArgs
    ///             {
    ///                 BackupDay = "monday",
    ///                 BackupTime = "00:00:00",
    ///             },
    ///             new Tencentcloud.Vpc.Inputs.SnapshotPolicyBackupPolicyArgs
    ///             {
    ///                 BackupDay = "tuesday",
    ///                 BackupTime = "01:00:00",
    ///             },
    ///             new Tencentcloud.Vpc.Inputs.SnapshotPolicyBackupPolicyArgs
    ///             {
    ///                 BackupDay = "wednesday",
    ///                 BackupTime = "02:00:00",
    ///             },
    ///         },
    ///     });
    /// 
    ///     var config = new Tencentcloud.Vpc.SnapshotPolicyConfig("config", new()
    ///     {
    ///         SnapshotPolicyId = exampleSnapshotPolicy.Id,
    ///         Enable = false,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// vpc snapshot_policy_config can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Vpc/snapshotPolicyConfig:SnapshotPolicyConfig snapshot_policy_config snapshot_policy_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Vpc/snapshotPolicyConfig:SnapshotPolicyConfig")]
    public partial class SnapshotPolicyConfig : global::Pulumi.CustomResource
    {
        /// <summary>
        /// If enable snapshot policy.
        /// </summary>
        [Output("enable")]
        public Output<bool> Enable { get; private set; } = null!;

        /// <summary>
        /// Snapshot policy Id.
        /// </summary>
        [Output("snapshotPolicyId")]
        public Output<string> SnapshotPolicyId { get; private set; } = null!;


        /// <summary>
        /// Create a SnapshotPolicyConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SnapshotPolicyConfig(string name, SnapshotPolicyConfigArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpc/snapshotPolicyConfig:SnapshotPolicyConfig", name, args ?? new SnapshotPolicyConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SnapshotPolicyConfig(string name, Input<string> id, SnapshotPolicyConfigState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpc/snapshotPolicyConfig:SnapshotPolicyConfig", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SnapshotPolicyConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SnapshotPolicyConfig Get(string name, Input<string> id, SnapshotPolicyConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new SnapshotPolicyConfig(name, id, state, options);
        }
    }

    public sealed class SnapshotPolicyConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If enable snapshot policy.
        /// </summary>
        [Input("enable", required: true)]
        public Input<bool> Enable { get; set; } = null!;

        /// <summary>
        /// Snapshot policy Id.
        /// </summary>
        [Input("snapshotPolicyId", required: true)]
        public Input<string> SnapshotPolicyId { get; set; } = null!;

        public SnapshotPolicyConfigArgs()
        {
        }
        public static new SnapshotPolicyConfigArgs Empty => new SnapshotPolicyConfigArgs();
    }

    public sealed class SnapshotPolicyConfigState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If enable snapshot policy.
        /// </summary>
        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        /// <summary>
        /// Snapshot policy Id.
        /// </summary>
        [Input("snapshotPolicyId")]
        public Input<string>? SnapshotPolicyId { get; set; }

        public SnapshotPolicyConfigState()
        {
        }
        public static new SnapshotPolicyConfigState Empty => new SnapshotPolicyConfigState();
    }
}