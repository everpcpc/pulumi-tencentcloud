// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mariadb
{
    public static class GetInstanceSpecs
    {
        /// <summary>
        /// Use this data source to query detailed information of mariadb instance_specs
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
        ///     var instanceSpecs = Tencentcloud.Mariadb.GetInstanceSpecs.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetInstanceSpecsResult> InvokeAsync(GetInstanceSpecsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceSpecsResult>("tencentcloud:Mariadb/getInstanceSpecs:getInstanceSpecs", args ?? new GetInstanceSpecsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of mariadb instance_specs
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
        ///     var instanceSpecs = Tencentcloud.Mariadb.GetInstanceSpecs.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetInstanceSpecsResult> Invoke(GetInstanceSpecsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceSpecsResult>("tencentcloud:Mariadb/getInstanceSpecs:getInstanceSpecs", args ?? new GetInstanceSpecsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceSpecsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstanceSpecsArgs()
        {
        }
        public static new GetInstanceSpecsArgs Empty => new GetInstanceSpecsArgs();
    }

    public sealed class GetInstanceSpecsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstanceSpecsInvokeArgs()
        {
        }
        public static new GetInstanceSpecsInvokeArgs Empty => new GetInstanceSpecsInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceSpecsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// list of instance specifications.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceSpecsSpecResult> Specs;

        [OutputConstructor]
        private GetInstanceSpecsResult(
            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetInstanceSpecsSpecResult> specs)
        {
            Id = id;
            ResultOutputFile = resultOutputFile;
            Specs = specs;
        }
    }
}