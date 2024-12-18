// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Protocol
{
    public static class GetTemplates
    {
        /// <summary>
        /// Use this data source to query detailed information of protocol templates.
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
        ///     var name = Tencentcloud.Protocol.GetTemplates.Invoke(new()
        ///     {
        ///         Name = "test",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetTemplatesResult> InvokeAsync(GetTemplatesArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTemplatesResult>("tencentcloud:Protocol/getTemplates:getTemplates", args ?? new GetTemplatesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of protocol templates.
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
        ///     var name = Tencentcloud.Protocol.GetTemplates.Invoke(new()
        ///     {
        ///         Name = "test",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetTemplatesResult> Invoke(GetTemplatesInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTemplatesResult>("tencentcloud:Protocol/getTemplates:getTemplates", args ?? new GetTemplatesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTemplatesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of the protocol template to query.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the protocol template to query.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetTemplatesArgs()
        {
        }
        public static new GetTemplatesArgs Empty => new GetTemplatesArgs();
    }

    public sealed class GetTemplatesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of the protocol template to query.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Name of the protocol template to query.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetTemplatesInvokeArgs()
        {
        }
        public static new GetTemplatesInvokeArgs Empty => new GetTemplatesInvokeArgs();
    }


    [OutputType]
    public sealed class GetTemplatesResult
    {
        /// <summary>
        /// ID of the protocol template.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of protocol template.
        /// </summary>
        public readonly string? Name;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Information list of the dedicated protocol templates.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTemplatesTemplateListResult> TemplateLists;

        [OutputConstructor]
        private GetTemplatesResult(
            string? id,

            string? name,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetTemplatesTemplateListResult> templateLists)
        {
            Id = id;
            Name = name;
            ResultOutputFile = resultOutputFile;
            TemplateLists = templateLists;
        }
    }
}
