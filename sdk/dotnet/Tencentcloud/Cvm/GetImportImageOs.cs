// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cvm
{
    public static class GetImportImageOs
    {
        /// <summary>
        /// Use this data source to query detailed information of cvm import_image_os
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
        ///     var importImageOs = Tencentcloud.Cvm.GetImportImageOs.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetImportImageOsResult> InvokeAsync(GetImportImageOsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetImportImageOsResult>("tencentcloud:Cvm/getImportImageOs:getImportImageOs", args ?? new GetImportImageOsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cvm import_image_os
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
        ///     var importImageOs = Tencentcloud.Cvm.GetImportImageOs.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetImportImageOsResult> Invoke(GetImportImageOsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetImportImageOsResult>("tencentcloud:Cvm/getImportImageOs:getImportImageOs", args ?? new GetImportImageOsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetImportImageOsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetImportImageOsArgs()
        {
        }
        public static new GetImportImageOsArgs Empty => new GetImportImageOsArgs();
    }

    public sealed class GetImportImageOsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetImportImageOsInvokeArgs()
        {
        }
        public static new GetImportImageOsInvokeArgs Empty => new GetImportImageOsInvokeArgs();
    }


    [OutputType]
    public sealed class GetImportImageOsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Supported operating system types of imported images.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetImportImageOsImportImageOsListSupportedResult> ImportImageOsListSupporteds;
        /// <summary>
        /// Supported operating system versions of imported images.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetImportImageOsImportImageOsVersionSetResult> ImportImageOsVersionSets;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetImportImageOsResult(
            string id,

            ImmutableArray<Outputs.GetImportImageOsImportImageOsListSupportedResult> importImageOsListSupporteds,

            ImmutableArray<Outputs.GetImportImageOsImportImageOsVersionSetResult> importImageOsVersionSets,

            string? resultOutputFile)
        {
            Id = id;
            ImportImageOsListSupporteds = importImageOsListSupporteds;
            ImportImageOsVersionSets = importImageOsVersionSets;
            ResultOutputFile = resultOutputFile;
        }
    }
}