// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Postgresql
{
    public static class GetParameterTemplates
    {
        /// <summary>
        /// Use this data source to query detailed information of postgresql parameter_templates
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
        ///         var parameterTemplates = Output.Create(Tencentcloud.Postgresql.GetParameterTemplates.InvokeAsync(new Tencentcloud.Postgresql.GetParameterTemplatesArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Tencentcloud.Postgresql.Inputs.GetParameterTemplatesFilterArgs
        ///                 {
        ///                     Name = "TemplateName",
        ///                     Values = 
        ///                     {
        ///                         "temp_name",
        ///                     },
        ///                 },
        ///                 new Tencentcloud.Postgresql.Inputs.GetParameterTemplatesFilterArgs
        ///                 {
        ///                     Name = "DBEngine",
        ///                     Values = 
        ///                     {
        ///                         "postgresql",
        ///                     },
        ///                 },
        ///             },
        ///             OrderBy = "CreateTime",
        ///             OrderByType = "desc",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetParameterTemplatesResult> InvokeAsync(GetParameterTemplatesArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetParameterTemplatesResult>("tencentcloud:Postgresql/getParameterTemplates:getParameterTemplates", args ?? new GetParameterTemplatesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of postgresql parameter_templates
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
        ///         var parameterTemplates = Output.Create(Tencentcloud.Postgresql.GetParameterTemplates.InvokeAsync(new Tencentcloud.Postgresql.GetParameterTemplatesArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Tencentcloud.Postgresql.Inputs.GetParameterTemplatesFilterArgs
        ///                 {
        ///                     Name = "TemplateName",
        ///                     Values = 
        ///                     {
        ///                         "temp_name",
        ///                     },
        ///                 },
        ///                 new Tencentcloud.Postgresql.Inputs.GetParameterTemplatesFilterArgs
        ///                 {
        ///                     Name = "DBEngine",
        ///                     Values = 
        ///                     {
        ///                         "postgresql",
        ///                     },
        ///                 },
        ///             },
        ///             OrderBy = "CreateTime",
        ///             OrderByType = "desc",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetParameterTemplatesResult> Invoke(GetParameterTemplatesInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetParameterTemplatesResult>("tencentcloud:Postgresql/getParameterTemplates:getParameterTemplates", args ?? new GetParameterTemplatesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetParameterTemplatesArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetParameterTemplatesFilterArgs>? _filters;

        /// <summary>
        /// Filter conditions. Valid values:TemplateName, TemplateId, DBMajorVersion, DBEngine.
        /// </summary>
        public List<Inputs.GetParameterTemplatesFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetParameterTemplatesFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Sorting metric. Valid values:CreateTime, TemplateName, DBMajorVersion.
        /// </summary>
        [Input("orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Sorting order. Valid values:asc (ascending order),desc (descending order).
        /// </summary>
        [Input("orderByType")]
        public string? OrderByType { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetParameterTemplatesArgs()
        {
        }
    }

    public sealed class GetParameterTemplatesInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetParameterTemplatesFilterInputArgs>? _filters;

        /// <summary>
        /// Filter conditions. Valid values:TemplateName, TemplateId, DBMajorVersion, DBEngine.
        /// </summary>
        public InputList<Inputs.GetParameterTemplatesFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetParameterTemplatesFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Sorting metric. Valid values:CreateTime, TemplateName, DBMajorVersion.
        /// </summary>
        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        /// <summary>
        /// Sorting order. Valid values:asc (ascending order),desc (descending order).
        /// </summary>
        [Input("orderByType")]
        public Input<string>? OrderByType { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetParameterTemplatesInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetParameterTemplatesResult
    {
        public readonly ImmutableArray<Outputs.GetParameterTemplatesFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// list of parameter templates.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetParameterTemplatesListResult> Lists;
        public readonly string? OrderBy;
        public readonly string? OrderByType;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetParameterTemplatesResult(
            ImmutableArray<Outputs.GetParameterTemplatesFilterResult> filters,

            string id,

            ImmutableArray<Outputs.GetParameterTemplatesListResult> lists,

            string? orderBy,

            string? orderByType,

            string? resultOutputFile)
        {
            Filters = filters;
            Id = id;
            Lists = lists;
            OrderBy = orderBy;
            OrderByType = orderByType;
            ResultOutputFile = resultOutputFile;
        }
    }
}