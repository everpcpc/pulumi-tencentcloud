// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clickhouse.Outputs
{

    [OutputType]
    public sealed class AccountPermissionDatabasePrivilegeListTablePrivilegeList
    {
        /// <summary>
        /// Table name.
        /// </summary>
        public readonly string TableName;
        /// <summary>
        /// Table privileges. Valid values: SELECT, INSERT_ALL, ALTER, TRUNCATE, DROP_TABLE.
        /// </summary>
        public readonly ImmutableArray<string> TablePrivileges;

        [OutputConstructor]
        private AccountPermissionDatabasePrivilegeListTablePrivilegeList(
            string tableName,

            ImmutableArray<string> tablePrivileges)
        {
            TableName = tableName;
            TablePrivileges = tablePrivileges;
        }
    }
}
