// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cfs
{
    public static class GetAvailableZone
    {
        /// <summary>
        /// Use this data source to query detailed information of cfs available_zone
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
        ///         var availableZone = Output.Create(Tencentcloud.Cfs.GetAvailableZone.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAvailableZoneResult> InvokeAsync(GetAvailableZoneArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAvailableZoneResult>("tencentcloud:Cfs/getAvailableZone:getAvailableZone", args ?? new GetAvailableZoneArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cfs available_zone
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
        ///         var availableZone = Output.Create(Tencentcloud.Cfs.GetAvailableZone.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetAvailableZoneResult> Invoke(GetAvailableZoneInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAvailableZoneResult>("tencentcloud:Cfs/getAvailableZone:getAvailableZone", args ?? new GetAvailableZoneInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAvailableZoneArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetAvailableZoneArgs()
        {
        }
    }

    public sealed class GetAvailableZoneInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetAvailableZoneInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAvailableZoneResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Information such as resource availability in each AZ and the supported storage classes and protocols.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAvailableZoneRegionZoneResult> RegionZones;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetAvailableZoneResult(
            string id,

            ImmutableArray<Outputs.GetAvailableZoneRegionZoneResult> regionZones,

            string? resultOutputFile)
        {
            Id = id;
            RegionZones = regionZones;
            ResultOutputFile = resultOutputFile;
        }
    }
}
