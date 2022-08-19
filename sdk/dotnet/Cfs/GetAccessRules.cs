// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cfs
{
    public static class GetAccessRules
    {
        /// <summary>
        /// Use this data source to query the detail information of CFS access rule.
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
        ///         var accessRules = Output.Create(Tencentcloud.Cfs.GetAccessRules.InvokeAsync(new Tencentcloud.Cfs.GetAccessRulesArgs
        ///         {
        ///             AccessGroupId = "pgroup-7nx89k7l",
        ///             AccessRuleId = "rule-qcndbqzj",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAccessRulesResult> InvokeAsync(GetAccessRulesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAccessRulesResult>("tencentcloud:Cfs/getAccessRules:getAccessRules", args ?? new GetAccessRulesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query the detail information of CFS access rule.
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
        ///         var accessRules = Output.Create(Tencentcloud.Cfs.GetAccessRules.InvokeAsync(new Tencentcloud.Cfs.GetAccessRulesArgs
        ///         {
        ///             AccessGroupId = "pgroup-7nx89k7l",
        ///             AccessRuleId = "rule-qcndbqzj",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetAccessRulesResult> Invoke(GetAccessRulesInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAccessRulesResult>("tencentcloud:Cfs/getAccessRules:getAccessRules", args ?? new GetAccessRulesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAccessRulesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// A specified access group ID used to query.
        /// </summary>
        [Input("accessGroupId", required: true)]
        public string AccessGroupId { get; set; } = null!;

        /// <summary>
        /// A specified access rule ID used to query.
        /// </summary>
        [Input("accessRuleId")]
        public string? AccessRuleId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetAccessRulesArgs()
        {
        }
    }

    public sealed class GetAccessRulesInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// A specified access group ID used to query.
        /// </summary>
        [Input("accessGroupId", required: true)]
        public Input<string> AccessGroupId { get; set; } = null!;

        /// <summary>
        /// A specified access rule ID used to query.
        /// </summary>
        [Input("accessRuleId")]
        public Input<string>? AccessRuleId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetAccessRulesInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAccessRulesResult
    {
        public readonly string AccessGroupId;
        /// <summary>
        /// ID of the access rule.
        /// </summary>
        public readonly string? AccessRuleId;
        /// <summary>
        /// An information list of CFS access rule. Each element contains the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAccessRulesAccessRuleListResult> AccessRuleLists;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetAccessRulesResult(
            string accessGroupId,

            string? accessRuleId,

            ImmutableArray<Outputs.GetAccessRulesAccessRuleListResult> accessRuleLists,

            string id,

            string? resultOutputFile)
        {
            AccessGroupId = accessGroupId;
            AccessRuleId = accessRuleId;
            AccessRuleLists = accessRuleLists;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}