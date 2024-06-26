// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dts.Outputs
{

    [OutputType]
    public sealed class MigrateJobMigrateOptionDatabaseTable
    {
        /// <summary>
        /// AdvancedObjects.
        /// </summary>
        public readonly ImmutableArray<string> AdvancedObjects;
        /// <summary>
        /// The database list.
        /// </summary>
        public readonly ImmutableArray<Outputs.MigrateJobMigrateOptionDatabaseTableDatabase> Databases;
        /// <summary>
        /// Object mode. eg:all,partial.
        /// </summary>
        public readonly string ObjectMode;

        [OutputConstructor]
        private MigrateJobMigrateOptionDatabaseTable(
            ImmutableArray<string> advancedObjects,

            ImmutableArray<Outputs.MigrateJobMigrateOptionDatabaseTableDatabase> databases,

            string objectMode)
        {
            AdvancedObjects = advancedObjects;
            Databases = databases;
            ObjectMode = objectMode;
        }
    }
}
