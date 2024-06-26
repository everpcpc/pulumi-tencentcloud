// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mariadb.Outputs
{

    [OutputType]
    public sealed class AccountPrivilegesProcedurePrivilege
    {
        /// <summary>
        /// Database name.
        /// </summary>
        public readonly string Database;
        /// <summary>
        /// Permission information.
        /// </summary>
        public readonly ImmutableArray<string> Privileges;
        /// <summary>
        /// Procedure name.
        /// </summary>
        public readonly string Procedure;

        [OutputConstructor]
        private AccountPrivilegesProcedurePrivilege(
            string database,

            ImmutableArray<string> privileges,

            string procedure)
        {
            Database = database;
            Privileges = privileges;
            Procedure = procedure;
        }
    }
}
