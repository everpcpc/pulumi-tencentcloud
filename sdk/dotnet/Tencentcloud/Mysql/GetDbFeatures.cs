// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mysql
{
    public static class GetDbFeatures
    {
        /// <summary>
        /// Use this data source to query detailed information of mysql db_features
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
        ///     var dbFeatures = Tencentcloud.Mysql.GetDbFeatures.Invoke(new()
        ///     {
        ///         InstanceId = "cdb-fitq5t9h",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDbFeaturesResult> InvokeAsync(GetDbFeaturesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDbFeaturesResult>("tencentcloud:Mysql/getDbFeatures:getDbFeatures", args ?? new GetDbFeaturesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of mysql db_features
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
        ///     var dbFeatures = Tencentcloud.Mysql.GetDbFeatures.Invoke(new()
        ///     {
        ///         InstanceId = "cdb-fitq5t9h",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDbFeaturesResult> Invoke(GetDbFeaturesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDbFeaturesResult>("tencentcloud:Mysql/getDbFeatures:getDbFeatures", args ?? new GetDbFeaturesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDbFeaturesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Instance ID, the format is: cdb-c1nl9rpv or cdbro-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDbFeaturesArgs()
        {
        }
        public static new GetDbFeaturesArgs Empty => new GetDbFeaturesArgs();
    }

    public sealed class GetDbFeaturesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Instance ID, the format is: cdb-c1nl9rpv or cdbro-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDbFeaturesInvokeArgs()
        {
        }
        public static new GetDbFeaturesInvokeArgs Empty => new GetDbFeaturesInvokeArgs();
    }


    [OutputType]
    public sealed class GetDbFeaturesResult
    {
        /// <summary>
        /// Whether to enable auditing needs to upgrade the kernel version.
        /// </summary>
        public readonly bool AuditNeedUpgrade;
        /// <summary>
        /// Current kernel version.
        /// </summary>
        public readonly string CurrentSubVersion;
        /// <summary>
        /// Whether to enable encryption needs to upgrade the kernel version.
        /// </summary>
        public readonly bool EncryptionNeedUpgrade;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        /// <summary>
        /// Whether it is a remote read-only instance.
        /// </summary>
        public readonly bool IsRemoteRo;
        /// <summary>
        /// Whether to support the database audit function.
        /// </summary>
        public readonly bool IsSupportAudit;
        /// <summary>
        /// Whether to support the database encryption function.
        /// </summary>
        public readonly bool IsSupportEncryption;
        /// <summary>
        /// Whether to support minor version upgrades.
        /// </summary>
        public readonly bool IsSupportUpdateSubVersion;
        /// <summary>
        /// The region where the master instance is located.
        /// </summary>
        public readonly string MasterRegion;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Available kernel versions for upgrade.
        /// </summary>
        public readonly string TargetSubVersion;

        [OutputConstructor]
        private GetDbFeaturesResult(
            bool auditNeedUpgrade,

            string currentSubVersion,

            bool encryptionNeedUpgrade,

            string id,

            string instanceId,

            bool isRemoteRo,

            bool isSupportAudit,

            bool isSupportEncryption,

            bool isSupportUpdateSubVersion,

            string masterRegion,

            string? resultOutputFile,

            string targetSubVersion)
        {
            AuditNeedUpgrade = auditNeedUpgrade;
            CurrentSubVersion = currentSubVersion;
            EncryptionNeedUpgrade = encryptionNeedUpgrade;
            Id = id;
            InstanceId = instanceId;
            IsRemoteRo = isRemoteRo;
            IsSupportAudit = isSupportAudit;
            IsSupportEncryption = isSupportEncryption;
            IsSupportUpdateSubVersion = isSupportUpdateSubVersion;
            MasterRegion = masterRegion;
            ResultOutputFile = resultOutputFile;
            TargetSubVersion = targetSubVersion;
        }
    }
}