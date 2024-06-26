// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Css
{
    public static class GetStreamMonitorList
    {
        /// <summary>
        /// Use this data source to query detailed information of css stream_monitor_list
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
        ///         var streamMonitorList = Output.Create(Tencentcloud.Css.GetStreamMonitorList.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetStreamMonitorListResult> InvokeAsync(GetStreamMonitorListArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStreamMonitorListResult>("tencentcloud:Css/getStreamMonitorList:getStreamMonitorList", args ?? new GetStreamMonitorListArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of css stream_monitor_list
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
        ///         var streamMonitorList = Output.Create(Tencentcloud.Css.GetStreamMonitorList.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetStreamMonitorListResult> Invoke(GetStreamMonitorListInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetStreamMonitorListResult>("tencentcloud:Css/getStreamMonitorList:getStreamMonitorList", args ?? new GetStreamMonitorListInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetStreamMonitorListArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetStreamMonitorListArgs()
        {
        }
    }

    public sealed class GetStreamMonitorListInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetStreamMonitorListInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetStreamMonitorListResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The list of live stream monitoring tasks.Note: This field may return null, indicating that no valid value is available.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetStreamMonitorListLiveStreamMonitorResult> LiveStreamMonitors;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetStreamMonitorListResult(
            string id,

            ImmutableArray<Outputs.GetStreamMonitorListLiveStreamMonitorResult> liveStreamMonitors,

            string? resultOutputFile)
        {
            Id = id;
            LiveStreamMonitors = liveStreamMonitors;
            ResultOutputFile = resultOutputFile;
        }
    }
}
