// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dlc
{
    public static class GetCheckDataEngineImageCanBeUpgrade
    {
        /// <summary>
        /// Use this data source to query detailed information of dlc check_data_engine_image_can_be_upgrade
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
        ///     var checkDataEngineImageCanBeUpgrade = Tencentcloud.Dlc.GetCheckDataEngineImageCanBeUpgrade.Invoke(new()
        ///     {
        ///         DataEngineId = "DataEngine-cgkvbas6",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetCheckDataEngineImageCanBeUpgradeResult> InvokeAsync(GetCheckDataEngineImageCanBeUpgradeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetCheckDataEngineImageCanBeUpgradeResult>("tencentcloud:Dlc/getCheckDataEngineImageCanBeUpgrade:getCheckDataEngineImageCanBeUpgrade", args ?? new GetCheckDataEngineImageCanBeUpgradeArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of dlc check_data_engine_image_can_be_upgrade
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
        ///     var checkDataEngineImageCanBeUpgrade = Tencentcloud.Dlc.GetCheckDataEngineImageCanBeUpgrade.Invoke(new()
        ///     {
        ///         DataEngineId = "DataEngine-cgkvbas6",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetCheckDataEngineImageCanBeUpgradeResult> Invoke(GetCheckDataEngineImageCanBeUpgradeInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetCheckDataEngineImageCanBeUpgradeResult>("tencentcloud:Dlc/getCheckDataEngineImageCanBeUpgrade:getCheckDataEngineImageCanBeUpgrade", args ?? new GetCheckDataEngineImageCanBeUpgradeInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCheckDataEngineImageCanBeUpgradeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Engine unique id.
        /// </summary>
        [Input("dataEngineId", required: true)]
        public string DataEngineId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetCheckDataEngineImageCanBeUpgradeArgs()
        {
        }
        public static new GetCheckDataEngineImageCanBeUpgradeArgs Empty => new GetCheckDataEngineImageCanBeUpgradeArgs();
    }

    public sealed class GetCheckDataEngineImageCanBeUpgradeInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Engine unique id.
        /// </summary>
        [Input("dataEngineId", required: true)]
        public Input<string> DataEngineId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetCheckDataEngineImageCanBeUpgradeInvokeArgs()
        {
        }
        public static new GetCheckDataEngineImageCanBeUpgradeInvokeArgs Empty => new GetCheckDataEngineImageCanBeUpgradeInvokeArgs();
    }


    [OutputType]
    public sealed class GetCheckDataEngineImageCanBeUpgradeResult
    {
        /// <summary>
        /// The latest image version id that can be upgraded.
        /// </summary>
        public readonly string ChildImageVersionId;
        public readonly string DataEngineId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Is it possible to upgrade.
        /// </summary>
        public readonly bool IsUpgrade;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetCheckDataEngineImageCanBeUpgradeResult(
            string childImageVersionId,

            string dataEngineId,

            string id,

            bool isUpgrade,

            string? resultOutputFile)
        {
            ChildImageVersionId = childImageVersionId;
            DataEngineId = dataEngineId;
            Id = id;
            IsUpgrade = isUpgrade;
            ResultOutputFile = resultOutputFile;
        }
    }
}