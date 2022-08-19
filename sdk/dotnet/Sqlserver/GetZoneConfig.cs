// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Sqlserver
{
    public static class GetZoneConfig
    {
        /// <summary>
        /// Use this data source to query purchasable specification configuration for each availability zone in this specific region.
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
        ///         var mysqlserver = Output.Create(Tencentcloud.Sqlserver.GetZoneConfig.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetZoneConfigResult> InvokeAsync(GetZoneConfigArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetZoneConfigResult>("tencentcloud:Sqlserver/getZoneConfig:getZoneConfig", args ?? new GetZoneConfigArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query purchasable specification configuration for each availability zone in this specific region.
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
        ///         var mysqlserver = Output.Create(Tencentcloud.Sqlserver.GetZoneConfig.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetZoneConfigResult> Invoke(GetZoneConfigInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetZoneConfigResult>("tencentcloud:Sqlserver/getZoneConfig:getZoneConfig", args ?? new GetZoneConfigInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetZoneConfigArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to store results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetZoneConfigArgs()
        {
        }
    }

    public sealed class GetZoneConfigInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to store results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetZoneConfigInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetZoneConfigResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// A list of availability zones. Each element contains the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetZoneConfigZoneListResult> ZoneLists;

        [OutputConstructor]
        private GetZoneConfigResult(
            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetZoneConfigZoneListResult> zoneLists)
        {
            Id = id;
            ResultOutputFile = resultOutputFile;
            ZoneLists = zoneLists;
        }
    }
}