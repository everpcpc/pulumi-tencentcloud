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
    public static class GetNetDetectStateCheck
    {
        /// <summary>
        /// Use this data source to query detailed information of vpc net_detect_state_check
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
        ///     var netDetectStateCheck = Tencentcloud.Vpc.GetNetDetectStateCheck.Invoke(new()
        ///     {
        ///         DetectDestinationIps = new[]
        ///         {
        ///             "10.0.0.3",
        ///             "10.0.0.2",
        ///         },
        ///         NetDetectId = "netd-12345678",
        ///         NextHopDestination = "10.0.0.4",
        ///         NextHopType = "NORMAL_CVM",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetNetDetectStateCheckResult> InvokeAsync(GetNetDetectStateCheckArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNetDetectStateCheckResult>("tencentcloud:Vpc/getNetDetectStateCheck:getNetDetectStateCheck", args ?? new GetNetDetectStateCheckArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of vpc net_detect_state_check
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
        ///     var netDetectStateCheck = Tencentcloud.Vpc.GetNetDetectStateCheck.Invoke(new()
        ///     {
        ///         DetectDestinationIps = new[]
        ///         {
        ///             "10.0.0.3",
        ///             "10.0.0.2",
        ///         },
        ///         NetDetectId = "netd-12345678",
        ///         NextHopDestination = "10.0.0.4",
        ///         NextHopType = "NORMAL_CVM",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetNetDetectStateCheckResult> Invoke(GetNetDetectStateCheckInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNetDetectStateCheckResult>("tencentcloud:Vpc/getNetDetectStateCheck:getNetDetectStateCheck", args ?? new GetNetDetectStateCheckInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNetDetectStateCheckArgs : global::Pulumi.InvokeArgs
    {
        [Input("detectDestinationIps", required: true)]
        private List<string>? _detectDestinationIps;

        /// <summary>
        /// The array of detection destination IPv4 addresses, which contains at most two IP addresses.
        /// </summary>
        public List<string> DetectDestinationIps
        {
            get => _detectDestinationIps ?? (_detectDestinationIps = new List<string>());
            set => _detectDestinationIps = value;
        }

        /// <summary>
        /// ID of a network inspector instance, e.g. netd-12345678. Enter at least one of this parameter, VpcId, SubnetId, and NetDetectName. Use NetDetectId if it is present.
        /// </summary>
        [Input("netDetectId")]
        public string? NetDetectId { get; set; }

        /// <summary>
        /// The name of a network inspector, up to 60 bytes in length. It is used together with VpcId and NetDetectName. You should enter either this parameter or NetDetectId, or both. Use NetDetectId if it is present.
        /// </summary>
        [Input("netDetectName")]
        public string? NetDetectName { get; set; }

        /// <summary>
        /// The next-hop destination gateway. The value is related to NextHopType.If NextHopType is set to VPN, the value of this parameter is the VPN gateway ID, such as vpngw-12345678.If NextHopType is set to DIRECTCONNECT, the value of this parameter is the direct connect gateway ID, such as dcg-12345678.If NextHopType is set to PEERCONNECTION, the value of this parameter is the peering connection ID, such as pcx-12345678.If NextHopType is set to NAT, the value of this parameter is the NAT gateway ID, such as nat-12345678.If NextHopType is set to NORMAL_CVM, the value of this parameter is the IPv4 address of the CVM, such as 10.0.0.12.
        /// </summary>
        [Input("nextHopDestination", required: true)]
        public string NextHopDestination { get; set; } = null!;

        /// <summary>
        /// The type of the next hop. Currently supported types are:VPN: VPN gateway;DIRECTCONNECT: direct connect gateway;PEERCONNECTION: peering connection;NAT: NAT gateway;NORMAL_CVM: normal CVM.
        /// </summary>
        [Input("nextHopType", required: true)]
        public string NextHopType { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// ID of a subnet instance, e.g. `subnet-12345678`, which is used together with VpcId and NetDetectName. You should enter either this parameter or NetDetectId, or both. Use NetDetectId if it is present.
        /// </summary>
        [Input("subnetId")]
        public string? SubnetId { get; set; }

        /// <summary>
        /// ID of a `VPC` instance, e.g. `vpc-12345678`, which is used together with SubnetId and NetDetectName. You should enter either this parameter or NetDetectId, or both. Use NetDetectId if it is present.
        /// </summary>
        [Input("vpcId")]
        public string? VpcId { get; set; }

        public GetNetDetectStateCheckArgs()
        {
        }
        public static new GetNetDetectStateCheckArgs Empty => new GetNetDetectStateCheckArgs();
    }

    public sealed class GetNetDetectStateCheckInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("detectDestinationIps", required: true)]
        private InputList<string>? _detectDestinationIps;

        /// <summary>
        /// The array of detection destination IPv4 addresses, which contains at most two IP addresses.
        /// </summary>
        public InputList<string> DetectDestinationIps
        {
            get => _detectDestinationIps ?? (_detectDestinationIps = new InputList<string>());
            set => _detectDestinationIps = value;
        }

        /// <summary>
        /// ID of a network inspector instance, e.g. netd-12345678. Enter at least one of this parameter, VpcId, SubnetId, and NetDetectName. Use NetDetectId if it is present.
        /// </summary>
        [Input("netDetectId")]
        public Input<string>? NetDetectId { get; set; }

        /// <summary>
        /// The name of a network inspector, up to 60 bytes in length. It is used together with VpcId and NetDetectName. You should enter either this parameter or NetDetectId, or both. Use NetDetectId if it is present.
        /// </summary>
        [Input("netDetectName")]
        public Input<string>? NetDetectName { get; set; }

        /// <summary>
        /// The next-hop destination gateway. The value is related to NextHopType.If NextHopType is set to VPN, the value of this parameter is the VPN gateway ID, such as vpngw-12345678.If NextHopType is set to DIRECTCONNECT, the value of this parameter is the direct connect gateway ID, such as dcg-12345678.If NextHopType is set to PEERCONNECTION, the value of this parameter is the peering connection ID, such as pcx-12345678.If NextHopType is set to NAT, the value of this parameter is the NAT gateway ID, such as nat-12345678.If NextHopType is set to NORMAL_CVM, the value of this parameter is the IPv4 address of the CVM, such as 10.0.0.12.
        /// </summary>
        [Input("nextHopDestination", required: true)]
        public Input<string> NextHopDestination { get; set; } = null!;

        /// <summary>
        /// The type of the next hop. Currently supported types are:VPN: VPN gateway;DIRECTCONNECT: direct connect gateway;PEERCONNECTION: peering connection;NAT: NAT gateway;NORMAL_CVM: normal CVM.
        /// </summary>
        [Input("nextHopType", required: true)]
        public Input<string> NextHopType { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// ID of a subnet instance, e.g. `subnet-12345678`, which is used together with VpcId and NetDetectName. You should enter either this parameter or NetDetectId, or both. Use NetDetectId if it is present.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// ID of a `VPC` instance, e.g. `vpc-12345678`, which is used together with SubnetId and NetDetectName. You should enter either this parameter or NetDetectId, or both. Use NetDetectId if it is present.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public GetNetDetectStateCheckInvokeArgs()
        {
        }
        public static new GetNetDetectStateCheckInvokeArgs Empty => new GetNetDetectStateCheckInvokeArgs();
    }


    [OutputType]
    public sealed class GetNetDetectStateCheckResult
    {
        /// <summary>
        /// The destination IPv4 address of network detection.
        /// </summary>
        public readonly ImmutableArray<string> DetectDestinationIps;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? NetDetectId;
        /// <summary>
        /// The array of network detection verification results.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNetDetectStateCheckNetDetectIpStateSetResult> NetDetectIpStateSets;
        public readonly string? NetDetectName;
        public readonly string NextHopDestination;
        public readonly string NextHopType;
        public readonly string? ResultOutputFile;
        public readonly string? SubnetId;
        public readonly string? VpcId;

        [OutputConstructor]
        private GetNetDetectStateCheckResult(
            ImmutableArray<string> detectDestinationIps,

            string id,

            string? netDetectId,

            ImmutableArray<Outputs.GetNetDetectStateCheckNetDetectIpStateSetResult> netDetectIpStateSets,

            string? netDetectName,

            string nextHopDestination,

            string nextHopType,

            string? resultOutputFile,

            string? subnetId,

            string? vpcId)
        {
            DetectDestinationIps = detectDestinationIps;
            Id = id;
            NetDetectId = netDetectId;
            NetDetectIpStateSets = netDetectIpStateSets;
            NetDetectName = netDetectName;
            NextHopDestination = nextHopDestination;
            NextHopType = nextHopType;
            ResultOutputFile = resultOutputFile;
            SubnetId = subnetId;
            VpcId = vpcId;
        }
    }
}