// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dbbrain
{
    public static class GetNoPrimaryKeyTables
    {
        /// <summary>
        /// Use this data source to query detailed information of dbbrain no_primary_key_tables
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
        ///     var noPrimaryKeyTables = Tencentcloud.Dbbrain.GetNoPrimaryKeyTables.Invoke(new()
        ///     {
        ///         Date = "",
        ///         InstanceId = "",
        ///         Product = "",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetNoPrimaryKeyTablesResult> InvokeAsync(GetNoPrimaryKeyTablesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNoPrimaryKeyTablesResult>("tencentcloud:Dbbrain/getNoPrimaryKeyTables:getNoPrimaryKeyTables", args ?? new GetNoPrimaryKeyTablesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of dbbrain no_primary_key_tables
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
        ///     var noPrimaryKeyTables = Tencentcloud.Dbbrain.GetNoPrimaryKeyTables.Invoke(new()
        ///     {
        ///         Date = "",
        ///         InstanceId = "",
        ///         Product = "",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetNoPrimaryKeyTablesResult> Invoke(GetNoPrimaryKeyTablesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNoPrimaryKeyTablesResult>("tencentcloud:Dbbrain/getNoPrimaryKeyTables:getNoPrimaryKeyTables", args ?? new GetNoPrimaryKeyTablesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNoPrimaryKeyTablesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Query date, such as 2021-05-27, the earliest date is 30 days ago.
        /// </summary>
        [Input("date", required: true)]
        public string Date { get; set; } = null!;

        /// <summary>
        /// instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Service product type, supported values: `mysql` - ApsaraDB for MySQL, the default is `mysql`.
        /// </summary>
        [Input("product")]
        public string? Product { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetNoPrimaryKeyTablesArgs()
        {
        }
        public static new GetNoPrimaryKeyTablesArgs Empty => new GetNoPrimaryKeyTablesArgs();
    }

    public sealed class GetNoPrimaryKeyTablesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Query date, such as 2021-05-27, the earliest date is 30 days ago.
        /// </summary>
        [Input("date", required: true)]
        public Input<string> Date { get; set; } = null!;

        /// <summary>
        /// instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Service product type, supported values: `mysql` - ApsaraDB for MySQL, the default is `mysql`.
        /// </summary>
        [Input("product")]
        public Input<string>? Product { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetNoPrimaryKeyTablesInvokeArgs()
        {
        }
        public static new GetNoPrimaryKeyTablesInvokeArgs Empty => new GetNoPrimaryKeyTablesInvokeArgs();
    }


    [OutputType]
    public sealed class GetNoPrimaryKeyTablesResult
    {
        public readonly string Date;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        /// <summary>
        /// The difference with yesterday&amp;amp;#39;s scan of the table without a primary key. A positive number means an increase, a negative number means a decrease, and 0 means no change.
        /// </summary>
        public readonly int NoPrimaryKeyTableCountDiff;
        /// <summary>
        /// A list of tables without primary keys.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNoPrimaryKeyTablesNoPrimaryKeyTableResult> DbbrainNoPrimaryKeyTables;
        public readonly string? Product;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Collection timestamp (seconds).
        /// </summary>
        public readonly int Timestamp;

        [OutputConstructor]
        private GetNoPrimaryKeyTablesResult(
            string date,

            string id,

            string instanceId,

            int noPrimaryKeyTableCountDiff,

            ImmutableArray<Outputs.GetNoPrimaryKeyTablesNoPrimaryKeyTableResult> noPrimaryKeyTables,

            string? product,

            string? resultOutputFile,

            int timestamp)
        {
            Date = date;
            Id = id;
            InstanceId = instanceId;
            NoPrimaryKeyTableCountDiff = noPrimaryKeyTableCountDiff;
            DbbrainNoPrimaryKeyTables = noPrimaryKeyTables;
            Product = product;
            ResultOutputFile = resultOutputFile;
            Timestamp = timestamp;
        }
    }
}