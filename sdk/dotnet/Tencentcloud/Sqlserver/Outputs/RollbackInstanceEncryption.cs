// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Sqlserver.Outputs
{

    [OutputType]
    public sealed class RollbackInstanceEncryption
    {
        /// <summary>
        /// Database name.
        /// </summary>
        public readonly string? DbName;
        /// <summary>
        /// encryption, `enable` encrypted, `disable` unencrypted.
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private RollbackInstanceEncryption(
            string? dbName,

            string? status)
        {
            DbName = dbName;
            Status = status;
        }
    }
}
