// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clickhouse
{
    public static class GetBackupJobDetail
    {
        /// <summary>
        /// Use this data source to query detailed information of clickhouse backup job detail
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var backupJobDetail = Output.Create(Tencentcloud.Clickhouse.GetBackupJobDetail.InvokeAsync(new Tencentcloud.Clickhouse.GetBackupJobDetailArgs
        ///         {
        ///             BackUpJobId = 1234,
        ///             InstanceId = "cdwch-xxxxxx",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetBackupJobDetailResult> InvokeAsync(GetBackupJobDetailArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBackupJobDetailResult>("tencentcloud:Clickhouse/getBackupJobDetail:getBackupJobDetail", args ?? new GetBackupJobDetailArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of clickhouse backup job detail
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var backupJobDetail = Output.Create(Tencentcloud.Clickhouse.GetBackupJobDetail.InvokeAsync(new Tencentcloud.Clickhouse.GetBackupJobDetailArgs
        ///         {
        ///             BackUpJobId = 1234,
        ///             InstanceId = "cdwch-xxxxxx",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetBackupJobDetailResult> Invoke(GetBackupJobDetailInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetBackupJobDetailResult>("tencentcloud:Clickhouse/getBackupJobDetail:getBackupJobDetail", args ?? new GetBackupJobDetailInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBackupJobDetailArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Back up job id.
        /// </summary>
        [Input("backUpJobId", required: true)]
        public int BackUpJobId { get; set; }

        /// <summary>
        /// Instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetBackupJobDetailArgs()
        {
        }
    }

    public sealed class GetBackupJobDetailInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Back up job id.
        /// </summary>
        [Input("backUpJobId", required: true)]
        public Input<int> BackUpJobId { get; set; } = null!;

        /// <summary>
        /// Instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetBackupJobDetailInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBackupJobDetailResult
    {
        public readonly int BackUpJobId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Back up tables.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetBackupJobDetailTableContentResult> TableContents;

        [OutputConstructor]
        private GetBackupJobDetailResult(
            int backUpJobId,

            string id,

            string instanceId,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetBackupJobDetailTableContentResult> tableContents)
        {
            BackUpJobId = backUpJobId;
            Id = id;
            InstanceId = instanceId;
            ResultOutputFile = resultOutputFile;
            TableContents = tableContents;
        }
    }
}
