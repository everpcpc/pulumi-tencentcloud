// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Waf
{
    public static class GetCiphers
    {
        /// <summary>
        /// Use this data source to query detailed information of waf ciphers
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
        ///         var example = Output.Create(Tencentcloud.Waf.GetCiphers.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetCiphersResult> InvokeAsync(GetCiphersArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCiphersResult>("tencentcloud:Waf/getCiphers:getCiphers", args ?? new GetCiphersArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of waf ciphers
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
        ///         var example = Output.Create(Tencentcloud.Waf.GetCiphers.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetCiphersResult> Invoke(GetCiphersInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetCiphersResult>("tencentcloud:Waf/getCiphers:getCiphers", args ?? new GetCiphersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCiphersArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetCiphersArgs()
        {
        }
    }

    public sealed class GetCiphersInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetCiphersInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetCiphersResult
    {
        /// <summary>
        /// Encryption Suite InformationNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetCiphersCipherResult> WafCiphers;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetCiphersResult(
            ImmutableArray<Outputs.GetCiphersCipherResult> ciphers,

            string id,

            string? resultOutputFile)
        {
            WafCiphers = ciphers;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
