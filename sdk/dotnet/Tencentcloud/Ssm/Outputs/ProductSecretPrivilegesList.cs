// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ssm.Outputs
{

    [OutputType]
    public sealed class ProductSecretPrivilegesList
    {
        /// <summary>
        /// This value takes effect only when `PrivilegeName` is `ColumnPrivileges`, and the following parameters are required in this case:Database: explicitly indicate the database instance.TableName: explicitly indicate the table.
        /// </summary>
        public readonly string? ColumnName;
        /// <summary>
        /// This value takes effect only when `PrivilegeName` is `DatabasePrivileges`.
        /// </summary>
        public readonly string? Database;
        /// <summary>
        /// Permission name. Valid values: `GlobalPrivileges`, `DatabasePrivileges`, `TablePrivileges`, `ColumnPrivileges`. When the permission is `DatabasePrivileges`, the database name must be specified by the `Database` parameter; When the permission is `TablePrivileges`, the database name and the table name in the database must be specified by the `Database` and `TableName` parameters; When the permission is `ColumnPrivileges`, the database name, table name in the database, and column name in the table must be specified by the `Database`, `TableName`, and `ColumnName` parameters.
        /// </summary>
        public readonly string PrivilegeName;
        /// <summary>
        /// Permission list. For the `Mysql` service, optional permission values are: 1. Valid values of `GlobalPrivileges`: SELECT,INSERT,UPDATE,DELETE,CREATE, PROCESS, DROP,REFERENCES,INDEX,ALTER,SHOW DATABASES,CREATE TEMPORARY TABLES,LOCK TABLES,EXECUTE,CREATE VIEW,SHOW VIEW,CREATE ROUTINE,ALTER ROUTINE,EVENT,TRIGGER. Note: if this parameter is not passed in, it means to clear the permission. 2. Valid values of `DatabasePrivileges`: SELECT,INSERT,UPDATE,DELETE,CREATE, DROP,REFERENCES,INDEX,ALTER,CREATE TEMPORARY TABLES,LOCK TABLES,EXECUTE,CREATE VIEW,SHOW VIEW,CREATE ROUTINE,ALTER ROUTINE,EVENT,TRIGGER. Note: if this parameter is not passed in, it means to clear the permission. 3. Valid values of `TablePrivileges`: SELECT,INSERT,UPDATE,DELETE,CREATE, DROP,REFERENCES,INDEX,ALTER,CREATE VIEW,SHOW VIEW, TRIGGER. Note: if this parameter is not passed in, it means to clear the permission. 4. Valid values of `ColumnPrivileges`: SELECT,INSERT,UPDATE,REFERENCES.Note: if this parameter is not passed in, it means to clear the permission.
        /// </summary>
        public readonly ImmutableArray<string> Privileges;
        /// <summary>
        /// This value takes effect only when `PrivilegeName` is `TablePrivileges`, and the `Database` parameter is required in this case to explicitly indicate the database instance.
        /// </summary>
        public readonly string? TableName;

        [OutputConstructor]
        private ProductSecretPrivilegesList(
            string? columnName,

            string? database,

            string privilegeName,

            ImmutableArray<string> privileges,

            string? tableName)
        {
            ColumnName = columnName;
            Database = database;
            PrivilegeName = privilegeName;
            Privileges = privileges;
            TableName = tableName;
        }
    }
}