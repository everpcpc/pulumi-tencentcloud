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
    public static class GetSwitchRecord
    {
        /// <summary>
        /// Use this data source to query detailed information of mysql switch_record
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
        ///         var switchRecord = Output.Create(Tencentcloud.Mysql.GetSwitchRecord.InvokeAsync(new Tencentcloud.Mysql.GetSwitchRecordArgs
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
        public static Task<GetSwitchRecordResult> InvokeAsync(GetSwitchRecordArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSwitchRecordResult>("tencentcloud:Mysql/getSwitchRecord:getSwitchRecord", args ?? new GetSwitchRecordArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of mysql switch_record
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
        ///         var switchRecord = Output.Create(Tencentcloud.Mysql.GetSwitchRecord.InvokeAsync(new Tencentcloud.Mysql.GetSwitchRecordArgs
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
        public static Output<GetSwitchRecordResult> Invoke(GetSwitchRecordInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSwitchRecordResult>("tencentcloud:Mysql/getSwitchRecord:getSwitchRecord", args ?? new GetSwitchRecordInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSwitchRecordArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Instance ID, the format is: cdb-c1nl9rpv or cdbro-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetSwitchRecordArgs()
        {
        }
    }

    public sealed class GetSwitchRecordInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Instance ID, the format is: cdb-c1nl9rpv or cdbro-c1nl9rpv, which is the same as the instance ID displayed on the cloud database console page.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetSwitchRecordInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSwitchRecordResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        /// <summary>
        /// Instance switching record details.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSwitchRecordItemResult> Items;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetSwitchRecordResult(
            string id,

            string instanceId,

            ImmutableArray<Outputs.GetSwitchRecordItemResult> items,

            string? resultOutputFile)
        {
            Id = id;
            InstanceId = instanceId;
            Items = items;
            ResultOutputFile = resultOutputFile;
        }
    }
}
