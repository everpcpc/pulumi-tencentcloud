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
    public static class GetDescribeHostWafInstanceList
    {
        /// <summary>
        /// Use this data source to query detailed information of ssl describe_host_waf_instance_list
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
        ///     var describeHostWafInstanceList = Tencentcloud.Ssl.GetDescribeHostWafInstanceList.Invoke(new()
        ///     {
        ///         CertificateId = "8u8DII0l",
        ///         ResourceType = "waf",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDescribeHostWafInstanceListResult> InvokeAsync(GetDescribeHostWafInstanceListArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDescribeHostWafInstanceListResult>("tencentcloud:Ssl/getDescribeHostWafInstanceList:getDescribeHostWafInstanceList", args ?? new GetDescribeHostWafInstanceListArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of ssl describe_host_waf_instance_list
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
        ///     var describeHostWafInstanceList = Tencentcloud.Ssl.GetDescribeHostWafInstanceList.Invoke(new()
        ///     {
        ///         CertificateId = "8u8DII0l",
        ///         ResourceType = "waf",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDescribeHostWafInstanceListResult> Invoke(GetDescribeHostWafInstanceListInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDescribeHostWafInstanceListResult>("tencentcloud:Ssl/getDescribeHostWafInstanceList:getDescribeHostWafInstanceList", args ?? new GetDescribeHostWafInstanceListInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDescribeHostWafInstanceListArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Certificate ID to be deployed.
        /// </summary>
        [Input("certificateId", required: true)]
        public string CertificateId { get; set; } = null!;

        [Input("filters")]
        private List<Inputs.GetDescribeHostWafInstanceListFilterArgs>? _filters;

        /// <summary>
        /// List of filtering parameters; Filterkey: domainmatch.
        /// </summary>
        public List<Inputs.GetDescribeHostWafInstanceListFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetDescribeHostWafInstanceListFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Whether to query the cache, 1: Yes; 0: No, the default is the query cache, the cache is half an hour.
        /// </summary>
        [Input("isCache")]
        public int? IsCache { get; set; }

        /// <summary>
        /// Deployed certificate ID.
        /// </summary>
        [Input("oldCertificateId")]
        public string? OldCertificateId { get; set; }

        /// <summary>
        /// Deploy resource type.
        /// </summary>
        [Input("resourceType", required: true)]
        public string ResourceType { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDescribeHostWafInstanceListArgs()
        {
        }
        public static new GetDescribeHostWafInstanceListArgs Empty => new GetDescribeHostWafInstanceListArgs();
    }

    public sealed class GetDescribeHostWafInstanceListInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Certificate ID to be deployed.
        /// </summary>
        [Input("certificateId", required: true)]
        public Input<string> CertificateId { get; set; } = null!;

        [Input("filters")]
        private InputList<Inputs.GetDescribeHostWafInstanceListFilterInputArgs>? _filters;

        /// <summary>
        /// List of filtering parameters; Filterkey: domainmatch.
        /// </summary>
        public InputList<Inputs.GetDescribeHostWafInstanceListFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetDescribeHostWafInstanceListFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Whether to query the cache, 1: Yes; 0: No, the default is the query cache, the cache is half an hour.
        /// </summary>
        [Input("isCache")]
        public Input<int>? IsCache { get; set; }

        /// <summary>
        /// Deployed certificate ID.
        /// </summary>
        [Input("oldCertificateId")]
        public Input<string>? OldCertificateId { get; set; }

        /// <summary>
        /// Deploy resource type.
        /// </summary>
        [Input("resourceType", required: true)]
        public Input<string> ResourceType { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDescribeHostWafInstanceListInvokeArgs()
        {
        }
        public static new GetDescribeHostWafInstanceListInvokeArgs Empty => new GetDescribeHostWafInstanceListInvokeArgs();
    }


    [OutputType]
    public sealed class GetDescribeHostWafInstanceListResult
    {
        public readonly string CertificateId;
        public readonly ImmutableArray<Outputs.GetDescribeHostWafInstanceListFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// WAF instance listNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDescribeHostWafInstanceListInstanceListResult> InstanceLists;
        public readonly int? IsCache;
        public readonly string? OldCertificateId;
        public readonly string ResourceType;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDescribeHostWafInstanceListResult(
            string certificateId,

            ImmutableArray<Outputs.GetDescribeHostWafInstanceListFilterResult> filters,

            string id,

            ImmutableArray<Outputs.GetDescribeHostWafInstanceListInstanceListResult> instanceLists,

            int? isCache,

            string? oldCertificateId,

            string resourceType,

            string? resultOutputFile)
        {
            CertificateId = certificateId;
            Filters = filters;
            Id = id;
            InstanceLists = instanceLists;
            IsCache = isCache;
            OldCertificateId = oldCertificateId;
            ResourceType = resourceType;
            ResultOutputFile = resultOutputFile;
        }
    }
}