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
    public static class GetReadonlyGroups
    {
        /// <summary>
        /// Use this data source to query detailed information of postgresql read_only_groups
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var @group = new Tencentcloud.Postgresql.ReadonlyGroup("group", new Tencentcloud.Postgresql.ReadonlyGroupArgs
        ///         {
        ///             MasterDbInstanceId = "postgres-gzg9jb2n",
        ///             ProjectId = 0,
        ///             VpcId = "vpc-86v957zb",
        ///             SubnetId = "subnet-enm92y0m",
        ///             ReplayLagEliminate = 1,
        ///             ReplayLatencyEliminate = 1,
        ///             MaxReplayLag = 100,
        ///             MaxReplayLatency = 512,
        ///             MinDelayEliminateReserve = 1,
        ///         });
        ///         var readOnlyGroups = Tencentcloud.Postgresql.GetReadonlyGroups.Invoke(new Tencentcloud.Postgresql.GetReadonlyGroupsInvokeArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Tencentcloud.Postgresql.Inputs.GetReadonlyGroupsFilterInputArgs
        ///                 {
        ///                     Name = "db-master-instance-id",
        ///                     Values = 
        ///                     {
        ///                         @group.MasterDbInstanceId,
        ///                     },
        ///                 },
        ///             },
        ///             OrderBy = "CreateTime",
        ///             OrderByType = "asc",
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetReadonlyGroupsResult> InvokeAsync(GetReadonlyGroupsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetReadonlyGroupsResult>("tencentcloud:Postgresql/getReadonlyGroups:getReadonlyGroups", args ?? new GetReadonlyGroupsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of postgresql read_only_groups
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var @group = new Tencentcloud.Postgresql.ReadonlyGroup("group", new Tencentcloud.Postgresql.ReadonlyGroupArgs
        ///         {
        ///             MasterDbInstanceId = "postgres-gzg9jb2n",
        ///             ProjectId = 0,
        ///             VpcId = "vpc-86v957zb",
        ///             SubnetId = "subnet-enm92y0m",
        ///             ReplayLagEliminate = 1,
        ///             ReplayLatencyEliminate = 1,
        ///             MaxReplayLag = 100,
        ///             MaxReplayLatency = 512,
        ///             MinDelayEliminateReserve = 1,
        ///         });
        ///         var readOnlyGroups = Tencentcloud.Postgresql.GetReadonlyGroups.Invoke(new Tencentcloud.Postgresql.GetReadonlyGroupsInvokeArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Tencentcloud.Postgresql.Inputs.GetReadonlyGroupsFilterInputArgs
        ///                 {
        ///                     Name = "db-master-instance-id",
        ///                     Values = 
        ///                     {
        ///                         @group.MasterDbInstanceId,
        ///                     },
        ///                 },
        ///             },
        ///             OrderBy = "CreateTime",
        ///             OrderByType = "asc",
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetReadonlyGroupsResult> Invoke(GetReadonlyGroupsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetReadonlyGroupsResult>("tencentcloud:Postgresql/getReadonlyGroups:getReadonlyGroups", args ?? new GetReadonlyGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetReadonlyGroupsArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetReadonlyGroupsFilterArgs>? _filters;

        /// <summary>
        /// Filter condition. The primary ID must be specified in the format of db-master-instance-id to filter results, or else null will be returned.
        /// </summary>
        public List<Inputs.GetReadonlyGroupsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetReadonlyGroupsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Sorting criterion. Valid values:ROGroupId, CreateTime, Name.
        /// </summary>
        [Input("orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Sorting order. Valid values:desc, asc.
        /// </summary>
        [Input("orderByType")]
        public string? OrderByType { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetReadonlyGroupsArgs()
        {
        }
    }

    public sealed class GetReadonlyGroupsInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetReadonlyGroupsFilterInputArgs>? _filters;

        /// <summary>
        /// Filter condition. The primary ID must be specified in the format of db-master-instance-id to filter results, or else null will be returned.
        /// </summary>
        public InputList<Inputs.GetReadonlyGroupsFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetReadonlyGroupsFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Sorting criterion. Valid values:ROGroupId, CreateTime, Name.
        /// </summary>
        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        /// <summary>
        /// Sorting order. Valid values:desc, asc.
        /// </summary>
        [Input("orderByType")]
        public Input<string>? OrderByType { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetReadonlyGroupsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetReadonlyGroupsResult
    {
        public readonly ImmutableArray<Outputs.GetReadonlyGroupsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? OrderBy;
        public readonly string? OrderByType;
        /// <summary>
        /// list of read-only groups.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetReadonlyGroupsReadOnlyGroupListResult> ReadOnlyGroupLists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetReadonlyGroupsResult(
            ImmutableArray<Outputs.GetReadonlyGroupsFilterResult> filters,

            string id,

            string? orderBy,

            string? orderByType,

            ImmutableArray<Outputs.GetReadonlyGroupsReadOnlyGroupListResult> readOnlyGroupLists,

            string? resultOutputFile)
        {
            Filters = filters;
            Id = id;
            OrderBy = orderBy;
            OrderByType = orderByType;
            ReadOnlyGroupLists = readOnlyGroupLists;
            ResultOutputFile = resultOutputFile;
        }
    }
}
