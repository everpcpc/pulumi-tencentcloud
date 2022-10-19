// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor
{
    public static class GetPolicyGroups
    {
        /// <summary>
        /// Use this data source to query monitor policy groups (There is a lot of data and it is recommended to output to a file)
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
        ///         var groups = Output.Create(Tencentcloud.Monitor.GetPolicyGroups.InvokeAsync(new Tencentcloud.Monitor.GetPolicyGroupsArgs
        ///         {
        ///             PolicyViewNames = 
        ///             {
        ///                 "REDIS-CLUSTER",
        ///                 "cvm_device",
        ///             },
        ///         }));
        ///         var name = Output.Create(Tencentcloud.Monitor.GetPolicyGroups.InvokeAsync(new Tencentcloud.Monitor.GetPolicyGroupsArgs
        ///         {
        ///             Name = "test",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetPolicyGroupsResult> InvokeAsync(GetPolicyGroupsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPolicyGroupsResult>("tencentcloud:Monitor/getPolicyGroups:getPolicyGroups", args ?? new GetPolicyGroupsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query monitor policy groups (There is a lot of data and it is recommended to output to a file)
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
        ///         var groups = Output.Create(Tencentcloud.Monitor.GetPolicyGroups.InvokeAsync(new Tencentcloud.Monitor.GetPolicyGroupsArgs
        ///         {
        ///             PolicyViewNames = 
        ///             {
        ///                 "REDIS-CLUSTER",
        ///                 "cvm_device",
        ///             },
        ///         }));
        ///         var name = Output.Create(Tencentcloud.Monitor.GetPolicyGroups.InvokeAsync(new Tencentcloud.Monitor.GetPolicyGroupsArgs
        ///         {
        ///             Name = "test",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetPolicyGroupsResult> Invoke(GetPolicyGroupsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPolicyGroupsResult>("tencentcloud:Monitor/getPolicyGroups:getPolicyGroups", args ?? new GetPolicyGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPolicyGroupsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Policy group name for query.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        [Input("policyViewNames")]
        private List<string>? _policyViewNames;

        /// <summary>
        /// The policy view for query.
        /// </summary>
        public List<string> PolicyViewNames
        {
            get => _policyViewNames ?? (_policyViewNames = new List<string>());
            set => _policyViewNames = value;
        }

        /// <summary>
        /// Used to store results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetPolicyGroupsArgs()
        {
        }
    }

    public sealed class GetPolicyGroupsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Policy group name for query.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("policyViewNames")]
        private InputList<string>? _policyViewNames;

        /// <summary>
        /// The policy view for query.
        /// </summary>
        public InputList<string> PolicyViewNames
        {
            get => _policyViewNames ?? (_policyViewNames = new InputList<string>());
            set => _policyViewNames = value;
        }

        /// <summary>
        /// Used to store results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetPolicyGroupsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPolicyGroupsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A list policy groups. Each element contains the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPolicyGroupsListResult> Lists;
        public readonly string? Name;
        public readonly ImmutableArray<string> PolicyViewNames;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetPolicyGroupsResult(
            string id,

            ImmutableArray<Outputs.GetPolicyGroupsListResult> lists,

            string? name,

            ImmutableArray<string> policyViewNames,

            string? resultOutputFile)
        {
            Id = id;
            Lists = lists;
            Name = name;
            PolicyViewNames = policyViewNames;
            ResultOutputFile = resultOutputFile;
        }
    }
}