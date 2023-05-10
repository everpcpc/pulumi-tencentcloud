// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mysql
{
    public static class GetCloneList
    {
        /// <summary>
        /// Use this data source to query detailed information of mysql clone_list
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
        ///         var cloneList = Output.Create(Tencentcloud.Mysql.GetCloneList.InvokeAsync(new Tencentcloud.Mysql.GetCloneListArgs
        ///         {
        ///             InstanceId = "cdb-fitq5t9h",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetCloneListResult> InvokeAsync(GetCloneListArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCloneListResult>("tencentcloud:Mysql/getCloneList:getCloneList", args ?? new GetCloneListArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of mysql clone_list
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
        ///         var cloneList = Output.Create(Tencentcloud.Mysql.GetCloneList.InvokeAsync(new Tencentcloud.Mysql.GetCloneListArgs
        ///         {
        ///             InstanceId = "cdb-fitq5t9h",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetCloneListResult> Invoke(GetCloneListInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetCloneListResult>("tencentcloud:Mysql/getCloneList:getCloneList", args ?? new GetCloneListInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCloneListArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Query the list of cloning tasks for the specified source instance.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetCloneListArgs()
        {
        }
    }

    public sealed class GetCloneListInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Query the list of cloning tasks for the specified source instance.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetCloneListInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetCloneListResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        /// <summary>
        /// Clone task list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetCloneListItemResult> Items;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetCloneListResult(
            string id,

            string instanceId,

            ImmutableArray<Outputs.GetCloneListItemResult> items,

            string? resultOutputFile)
        {
            Id = id;
            InstanceId = instanceId;
            Items = items;
            ResultOutputFile = resultOutputFile;
        }
    }
}