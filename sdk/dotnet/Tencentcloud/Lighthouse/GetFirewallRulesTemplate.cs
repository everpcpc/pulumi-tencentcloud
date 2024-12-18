// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse
{
    public static class GetFirewallRulesTemplate
    {
        /// <summary>
        /// Use this data source to query detailed information of lighthouse firewall_rules_template
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
        ///     var firewallRulesTemplate = Tencentcloud.Lighthouse.GetFirewallRulesTemplate.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetFirewallRulesTemplateResult> InvokeAsync(GetFirewallRulesTemplateArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetFirewallRulesTemplateResult>("tencentcloud:Lighthouse/getFirewallRulesTemplate:getFirewallRulesTemplate", args ?? new GetFirewallRulesTemplateArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of lighthouse firewall_rules_template
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
        ///     var firewallRulesTemplate = Tencentcloud.Lighthouse.GetFirewallRulesTemplate.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetFirewallRulesTemplateResult> Invoke(GetFirewallRulesTemplateInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetFirewallRulesTemplateResult>("tencentcloud:Lighthouse/getFirewallRulesTemplate:getFirewallRulesTemplate", args ?? new GetFirewallRulesTemplateInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFirewallRulesTemplateArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetFirewallRulesTemplateArgs()
        {
        }
        public static new GetFirewallRulesTemplateArgs Empty => new GetFirewallRulesTemplateArgs();
    }

    public sealed class GetFirewallRulesTemplateInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetFirewallRulesTemplateInvokeArgs()
        {
        }
        public static new GetFirewallRulesTemplateInvokeArgs Empty => new GetFirewallRulesTemplateInvokeArgs();
    }


    [OutputType]
    public sealed class GetFirewallRulesTemplateResult
    {
        /// <summary>
        /// Firewall rule details list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFirewallRulesTemplateFirewallRuleSetResult> FirewallRuleSets;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetFirewallRulesTemplateResult(
            ImmutableArray<Outputs.GetFirewallRulesTemplateFirewallRuleSetResult> firewallRuleSets,

            string id,

            string? resultOutputFile)
        {
            FirewallRuleSets = firewallRuleSets;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
