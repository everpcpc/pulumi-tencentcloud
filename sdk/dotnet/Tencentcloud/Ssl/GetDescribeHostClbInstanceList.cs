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
    public static class GetDescribeHostClbInstanceList
    {
        /// <summary>
        /// Use this data source to query detailed information of ssl describe_host_clb_instance_list
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
        ///     var describeHostClbInstanceList = Tencentcloud.Ssl.GetDescribeHostClbInstanceList.Invoke(new()
        ///     {
        ///         CertificateId = "8u8DII0l",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDescribeHostClbInstanceListResult> InvokeAsync(GetDescribeHostClbInstanceListArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDescribeHostClbInstanceListResult>("tencentcloud:Ssl/getDescribeHostClbInstanceList:getDescribeHostClbInstanceList", args ?? new GetDescribeHostClbInstanceListArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of ssl describe_host_clb_instance_list
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
        ///     var describeHostClbInstanceList = Tencentcloud.Ssl.GetDescribeHostClbInstanceList.Invoke(new()
        ///     {
        ///         CertificateId = "8u8DII0l",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDescribeHostClbInstanceListResult> Invoke(GetDescribeHostClbInstanceListInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDescribeHostClbInstanceListResult>("tencentcloud:Ssl/getDescribeHostClbInstanceList:getDescribeHostClbInstanceList", args ?? new GetDescribeHostClbInstanceListInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDescribeHostClbInstanceListArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Whether to cache asynchronous.
        /// </summary>
        [Input("asyncCache")]
        public int? AsyncCache { get; set; }

        /// <summary>
        /// Certificate ID to be deployed.
        /// </summary>
        [Input("certificateId", required: true)]
        public string CertificateId { get; set; } = null!;

        [Input("filters")]
        private List<Inputs.GetDescribeHostClbInstanceListFilterArgs>? _filters;

        /// <summary>
        /// List of filtering parameters; Filterkey: domainmatch.
        /// </summary>
        public List<Inputs.GetDescribeHostClbInstanceListFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetDescribeHostClbInstanceListFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Whether to query the cache, 1: Yes; 0: No, the default is the query cache, the cache is half an hour.
        /// </summary>
        [Input("isCache")]
        public int? IsCache { get; set; }

        /// <summary>
        /// Original certificate ID.
        /// </summary>
        [Input("oldCertificateId")]
        public string? OldCertificateId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDescribeHostClbInstanceListArgs()
        {
        }
        public static new GetDescribeHostClbInstanceListArgs Empty => new GetDescribeHostClbInstanceListArgs();
    }

    public sealed class GetDescribeHostClbInstanceListInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Whether to cache asynchronous.
        /// </summary>
        [Input("asyncCache")]
        public Input<int>? AsyncCache { get; set; }

        /// <summary>
        /// Certificate ID to be deployed.
        /// </summary>
        [Input("certificateId", required: true)]
        public Input<string> CertificateId { get; set; } = null!;

        [Input("filters")]
        private InputList<Inputs.GetDescribeHostClbInstanceListFilterInputArgs>? _filters;

        /// <summary>
        /// List of filtering parameters; Filterkey: domainmatch.
        /// </summary>
        public InputList<Inputs.GetDescribeHostClbInstanceListFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetDescribeHostClbInstanceListFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Whether to query the cache, 1: Yes; 0: No, the default is the query cache, the cache is half an hour.
        /// </summary>
        [Input("isCache")]
        public Input<int>? IsCache { get; set; }

        /// <summary>
        /// Original certificate ID.
        /// </summary>
        [Input("oldCertificateId")]
        public Input<string>? OldCertificateId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDescribeHostClbInstanceListInvokeArgs()
        {
        }
        public static new GetDescribeHostClbInstanceListInvokeArgs Empty => new GetDescribeHostClbInstanceListInvokeArgs();
    }


    [OutputType]
    public sealed class GetDescribeHostClbInstanceListResult
    {
        public readonly int? AsyncCache;
        /// <summary>
        /// Current cache read timeNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string AsyncCacheTime;
        /// <summary>
        /// Asynchronous refresh current execution numberNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly int AsyncOffset;
        /// <summary>
        /// The total number of asynchronous refreshNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly int AsyncTotalNum;
        public readonly string CertificateId;
        public readonly ImmutableArray<Outputs.GetDescribeHostClbInstanceListFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// CLB instance listener listNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDescribeHostClbInstanceListInstanceListResult> InstanceLists;
        public readonly int? IsCache;
        public readonly string? OldCertificateId;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDescribeHostClbInstanceListResult(
            int? asyncCache,

            string asyncCacheTime,

            int asyncOffset,

            int asyncTotalNum,

            string certificateId,

            ImmutableArray<Outputs.GetDescribeHostClbInstanceListFilterResult> filters,

            string id,

            ImmutableArray<Outputs.GetDescribeHostClbInstanceListInstanceListResult> instanceLists,

            int? isCache,

            string? oldCertificateId,

            string? resultOutputFile)
        {
            AsyncCache = asyncCache;
            AsyncCacheTime = asyncCacheTime;
            AsyncOffset = asyncOffset;
            AsyncTotalNum = asyncTotalNum;
            CertificateId = certificateId;
            Filters = filters;
            Id = id;
            InstanceLists = instanceLists;
            IsCache = isCache;
            OldCertificateId = oldCertificateId;
            ResultOutputFile = resultOutputFile;
        }
    }
}