// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcr
{
    public static class GetImageManifests
    {
        /// <summary>
        /// Use this data source to query detailed information of tcr image_manifests
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
        ///     var imageManifests = Tencentcloud.Tcr.GetImageManifests.Invoke(new()
        ///     {
        ///         ImageVersion = "v1",
        ///         NamespaceName = "%s",
        ///         RegistryId = "%s",
        ///         RepositoryName = "%s",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetImageManifestsResult> InvokeAsync(GetImageManifestsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetImageManifestsResult>("tencentcloud:Tcr/getImageManifests:getImageManifests", args ?? new GetImageManifestsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of tcr image_manifests
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
        ///     var imageManifests = Tencentcloud.Tcr.GetImageManifests.Invoke(new()
        ///     {
        ///         ImageVersion = "v1",
        ///         NamespaceName = "%s",
        ///         RegistryId = "%s",
        ///         RepositoryName = "%s",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetImageManifestsResult> Invoke(GetImageManifestsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetImageManifestsResult>("tencentcloud:Tcr/getImageManifests:getImageManifests", args ?? new GetImageManifestsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetImageManifestsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// mirror version.
        /// </summary>
        [Input("imageVersion", required: true)]
        public string ImageVersion { get; set; } = null!;

        /// <summary>
        /// namespace name.
        /// </summary>
        [Input("namespaceName", required: true)]
        public string NamespaceName { get; set; } = null!;

        /// <summary>
        /// instance ID.
        /// </summary>
        [Input("registryId", required: true)]
        public string RegistryId { get; set; } = null!;

        /// <summary>
        /// mirror warehouse name.
        /// </summary>
        [Input("repositoryName", required: true)]
        public string RepositoryName { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetImageManifestsArgs()
        {
        }
        public static new GetImageManifestsArgs Empty => new GetImageManifestsArgs();
    }

    public sealed class GetImageManifestsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// mirror version.
        /// </summary>
        [Input("imageVersion", required: true)]
        public Input<string> ImageVersion { get; set; } = null!;

        /// <summary>
        /// namespace name.
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// instance ID.
        /// </summary>
        [Input("registryId", required: true)]
        public Input<string> RegistryId { get; set; } = null!;

        /// <summary>
        /// mirror warehouse name.
        /// </summary>
        [Input("repositoryName", required: true)]
        public Input<string> RepositoryName { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetImageManifestsInvokeArgs()
        {
        }
        public static new GetImageManifestsInvokeArgs Empty => new GetImageManifestsInvokeArgs();
    }


    [OutputType]
    public sealed class GetImageManifestsResult
    {
        /// <summary>
        /// configuration information of the image.
        /// </summary>
        public readonly string Config;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string ImageVersion;
        /// <summary>
        /// Manifest information of the image.
        /// </summary>
        public readonly string Manifest;
        public readonly string NamespaceName;
        public readonly string RegistryId;
        public readonly string RepositoryName;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetImageManifestsResult(
            string config,

            string id,

            string imageVersion,

            string manifest,

            string namespaceName,

            string registryId,

            string repositoryName,

            string? resultOutputFile)
        {
            Config = config;
            Id = id;
            ImageVersion = imageVersion;
            Manifest = manifest;
            NamespaceName = namespaceName;
            RegistryId = registryId;
            RepositoryName = repositoryName;
            ResultOutputFile = resultOutputFile;
        }
    }
}