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
    public static class GetSecurityGroupReferences
    {
        /// <summary>
        /// Use this data source to query detailed information of vpc security_group_references
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
        ///     var securityGroupReferences = Tencentcloud.Vpc.GetSecurityGroupReferences.Invoke(new()
        ///     {
        ///         SecurityGroupIds = new[]
        ///         {
        ///             "sg-edmur627",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetSecurityGroupReferencesResult> InvokeAsync(GetSecurityGroupReferencesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSecurityGroupReferencesResult>("tencentcloud:Vpc/getSecurityGroupReferences:getSecurityGroupReferences", args ?? new GetSecurityGroupReferencesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of vpc security_group_references
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
        ///     var securityGroupReferences = Tencentcloud.Vpc.GetSecurityGroupReferences.Invoke(new()
        ///     {
        ///         SecurityGroupIds = new[]
        ///         {
        ///             "sg-edmur627",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetSecurityGroupReferencesResult> Invoke(GetSecurityGroupReferencesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSecurityGroupReferencesResult>("tencentcloud:Vpc/getSecurityGroupReferences:getSecurityGroupReferences", args ?? new GetSecurityGroupReferencesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSecurityGroupReferencesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("securityGroupIds", required: true)]
        private List<string>? _securityGroupIds;

        /// <summary>
        /// A set of security group instance IDs, e.g. [sg-12345678].
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new List<string>());
            set => _securityGroupIds = value;
        }

        public GetSecurityGroupReferencesArgs()
        {
        }
        public static new GetSecurityGroupReferencesArgs Empty => new GetSecurityGroupReferencesArgs();
    }

    public sealed class GetSecurityGroupReferencesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("securityGroupIds", required: true)]
        private InputList<string>? _securityGroupIds;

        /// <summary>
        /// A set of security group instance IDs, e.g. [sg-12345678].
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        public GetSecurityGroupReferencesInvokeArgs()
        {
        }
        public static new GetSecurityGroupReferencesInvokeArgs Empty => new GetSecurityGroupReferencesInvokeArgs();
    }


    [OutputType]
    public sealed class GetSecurityGroupReferencesResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Referred security groups.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSecurityGroupReferencesReferredSecurityGroupSetResult> ReferredSecurityGroupSets;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<string> SecurityGroupIds;

        [OutputConstructor]
        private GetSecurityGroupReferencesResult(
            string id,

            ImmutableArray<Outputs.GetSecurityGroupReferencesReferredSecurityGroupSetResult> referredSecurityGroupSets,

            string? resultOutputFile,

            ImmutableArray<string> securityGroupIds)
        {
            Id = id;
            ReferredSecurityGroupSets = referredSecurityGroupSets;
            ResultOutputFile = resultOutputFile;
            SecurityGroupIds = securityGroupIds;
        }
    }
}