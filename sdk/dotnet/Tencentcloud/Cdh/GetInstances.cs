// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cdh
{
    public static class GetInstances
    {
        /// <summary>
        /// Use this data source to query CDH instances.
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
        ///         var list = Output.Create(Tencentcloud.Cdh.GetInstances.InvokeAsync(new Tencentcloud.Cdh.GetInstancesArgs
        ///         {
        ///             AvailabilityZone = "ap-guangzhou-3",
        ///             HostId = "host-d6s7i5q4",
        ///             HostName = "test",
        ///             HostState = "RUNNING",
        ///             ProjectId = 1154137,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetInstancesResult> InvokeAsync(GetInstancesArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetInstancesResult>("tencentcloud:Cdh/getInstances:getInstances", args ?? new GetInstancesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query CDH instances.
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
        ///         var list = Output.Create(Tencentcloud.Cdh.GetInstances.InvokeAsync(new Tencentcloud.Cdh.GetInstancesArgs
        ///         {
        ///             AvailabilityZone = "ap-guangzhou-3",
        ///             HostId = "host-d6s7i5q4",
        ///             HostName = "test",
        ///             HostState = "RUNNING",
        ///             ProjectId = 1154137,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetInstancesResult> Invoke(GetInstancesInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetInstancesResult>("tencentcloud:Cdh/getInstances:getInstances", args ?? new GetInstancesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstancesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The available zone that the CDH instance locates at.
        /// </summary>
        [Input("availabilityZone")]
        public string? AvailabilityZone { get; set; }

        /// <summary>
        /// ID of the CDH instances to be queried.
        /// </summary>
        [Input("hostId")]
        public string? HostId { get; set; }

        /// <summary>
        /// Name of the CDH instances to be queried.
        /// </summary>
        [Input("hostName")]
        public string? HostName { get; set; }

        /// <summary>
        /// State of the CDH instances to be queried. Valid values: `PENDING`, `LAUNCH_FAILURE`, `RUNNING`, `EXPIRED`.
        /// </summary>
        [Input("hostState")]
        public string? HostState { get; set; }

        /// <summary>
        /// The project CDH belongs to.
        /// </summary>
        [Input("projectId")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstancesArgs()
        {
        }
    }

    public sealed class GetInstancesInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The available zone that the CDH instance locates at.
        /// </summary>
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        /// <summary>
        /// ID of the CDH instances to be queried.
        /// </summary>
        [Input("hostId")]
        public Input<string>? HostId { get; set; }

        /// <summary>
        /// Name of the CDH instances to be queried.
        /// </summary>
        [Input("hostName")]
        public Input<string>? HostName { get; set; }

        /// <summary>
        /// State of the CDH instances to be queried. Valid values: `PENDING`, `LAUNCH_FAILURE`, `RUNNING`, `EXPIRED`.
        /// </summary>
        [Input("hostState")]
        public Input<string>? HostState { get; set; }

        /// <summary>
        /// The project CDH belongs to.
        /// </summary>
        [Input("projectId")]
        public Input<int>? ProjectId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstancesInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetInstancesResult
    {
        /// <summary>
        /// The available zone that the CDH instance locates at.
        /// </summary>
        public readonly string? AvailabilityZone;
        /// <summary>
        /// An information list of cdh instance. Each element contains the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstancesCdhInstanceListResult> CdhInstanceLists;
        /// <summary>
        /// ID of the CDH instance.
        /// </summary>
        public readonly string? HostId;
        /// <summary>
        /// Name of the CDH instance.
        /// </summary>
        public readonly string? HostName;
        /// <summary>
        /// State of the CDH instance.
        /// </summary>
        public readonly string? HostState;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The project CDH belongs to.
        /// </summary>
        public readonly int? ProjectId;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInstancesResult(
            string? availabilityZone,

            ImmutableArray<Outputs.GetInstancesCdhInstanceListResult> cdhInstanceLists,

            string? hostId,

            string? hostName,

            string? hostState,

            string id,

            int? projectId,

            string? resultOutputFile)
        {
            AvailabilityZone = availabilityZone;
            CdhInstanceLists = cdhInstanceLists;
            HostId = hostId;
            HostName = hostName;
            HostState = hostState;
            Id = id;
            ProjectId = projectId;
            ResultOutputFile = resultOutputFile;
        }
    }
}