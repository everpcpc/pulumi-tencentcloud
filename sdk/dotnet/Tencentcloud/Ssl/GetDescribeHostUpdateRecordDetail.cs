// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ssl
{
    public static class GetDescribeHostUpdateRecordDetail
    {
        /// <summary>
        /// Use this data source to query detailed information of ssl describe_host_update_record_detail
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
        ///     var describeHostUpdateRecordDetail = Tencentcloud.Ssl.GetDescribeHostUpdateRecordDetail.Invoke(new()
        ///     {
        ///         DeployRecordId = "35364",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDescribeHostUpdateRecordDetailResult> InvokeAsync(GetDescribeHostUpdateRecordDetailArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDescribeHostUpdateRecordDetailResult>("tencentcloud:Ssl/getDescribeHostUpdateRecordDetail:getDescribeHostUpdateRecordDetail", args ?? new GetDescribeHostUpdateRecordDetailArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of ssl describe_host_update_record_detail
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
        ///     var describeHostUpdateRecordDetail = Tencentcloud.Ssl.GetDescribeHostUpdateRecordDetail.Invoke(new()
        ///     {
        ///         DeployRecordId = "35364",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDescribeHostUpdateRecordDetailResult> Invoke(GetDescribeHostUpdateRecordDetailInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDescribeHostUpdateRecordDetailResult>("tencentcloud:Ssl/getDescribeHostUpdateRecordDetail:getDescribeHostUpdateRecordDetail", args ?? new GetDescribeHostUpdateRecordDetailInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDescribeHostUpdateRecordDetailArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// One -click update record ID.
        /// </summary>
        [Input("deployRecordId", required: true)]
        public string DeployRecordId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDescribeHostUpdateRecordDetailArgs()
        {
        }
        public static new GetDescribeHostUpdateRecordDetailArgs Empty => new GetDescribeHostUpdateRecordDetailArgs();
    }

    public sealed class GetDescribeHostUpdateRecordDetailInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// One -click update record ID.
        /// </summary>
        [Input("deployRecordId", required: true)]
        public Input<string> DeployRecordId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDescribeHostUpdateRecordDetailInvokeArgs()
        {
        }
        public static new GetDescribeHostUpdateRecordDetailInvokeArgs Empty => new GetDescribeHostUpdateRecordDetailInvokeArgs();
    }


    [OutputType]
    public sealed class GetDescribeHostUpdateRecordDetailResult
    {
        public readonly string DeployRecordId;
        /// <summary>
        /// Total number of failuresNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly int FailedTotalCount;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Certificate deployment record listNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDescribeHostUpdateRecordDetailRecordDetailListResult> RecordDetailLists;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Total number of deploymentNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly int RunningTotalCount;
        /// <summary>
        /// Total successNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly int SuccessTotalCount;

        [OutputConstructor]
        private GetDescribeHostUpdateRecordDetailResult(
            string deployRecordId,

            int failedTotalCount,

            string id,

            ImmutableArray<Outputs.GetDescribeHostUpdateRecordDetailRecordDetailListResult> recordDetailLists,

            string? resultOutputFile,

            int runningTotalCount,

            int successTotalCount)
        {
            DeployRecordId = deployRecordId;
            FailedTotalCount = failedTotalCount;
            Id = id;
            RecordDetailLists = recordDetailLists;
            ResultOutputFile = resultOutputFile;
            RunningTotalCount = runningTotalCount;
            SuccessTotalCount = successTotalCount;
        }
    }
}