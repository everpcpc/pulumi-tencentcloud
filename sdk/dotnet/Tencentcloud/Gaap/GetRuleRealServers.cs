// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Gaap
{
    public static class GetRuleRealServers
    {
        /// <summary>
        /// Use this data source to query detailed information of gaap rule real servers
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
        ///     var ruleRealServers = Tencentcloud.Gaap.GetRuleRealServers.Invoke(new()
        ///     {
        ///         RuleId = "rule-xxxxxx",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetRuleRealServersResult> InvokeAsync(GetRuleRealServersArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetRuleRealServersResult>("tencentcloud:Gaap/getRuleRealServers:getRuleRealServers", args ?? new GetRuleRealServersArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of gaap rule real servers
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
        ///     var ruleRealServers = Tencentcloud.Gaap.GetRuleRealServers.Invoke(new()
        ///     {
        ///         RuleId = "rule-xxxxxx",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetRuleRealServersResult> Invoke(GetRuleRealServersInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetRuleRealServersResult>("tencentcloud:Gaap/getRuleRealServers:getRuleRealServers", args ?? new GetRuleRealServersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRuleRealServersArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Rule Id.
        /// </summary>
        [Input("ruleId", required: true)]
        public string RuleId { get; set; } = null!;

        public GetRuleRealServersArgs()
        {
        }
        public static new GetRuleRealServersArgs Empty => new GetRuleRealServersArgs();
    }

    public sealed class GetRuleRealServersInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Rule Id.
        /// </summary>
        [Input("ruleId", required: true)]
        public Input<string> RuleId { get; set; } = null!;

        public GetRuleRealServersInvokeArgs()
        {
        }
        public static new GetRuleRealServersInvokeArgs Empty => new GetRuleRealServersInvokeArgs();
    }


    [OutputType]
    public sealed class GetRuleRealServersResult
    {
        /// <summary>
        /// Bind Real Server info.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRuleRealServersBindRealServerSetResult> BindRealServerSets;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Real Server Set.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRuleRealServersRealServerSetResult> RealServerSets;
        public readonly string? ResultOutputFile;
        public readonly string RuleId;

        [OutputConstructor]
        private GetRuleRealServersResult(
            ImmutableArray<Outputs.GetRuleRealServersBindRealServerSetResult> bindRealServerSets,

            string id,

            ImmutableArray<Outputs.GetRuleRealServersRealServerSetResult> realServerSets,

            string? resultOutputFile,

            string ruleId)
        {
            BindRealServerSets = bindRealServerSets;
            Id = id;
            RealServerSets = realServerSets;
            ResultOutputFile = resultOutputFile;
            RuleId = ruleId;
        }
    }
}