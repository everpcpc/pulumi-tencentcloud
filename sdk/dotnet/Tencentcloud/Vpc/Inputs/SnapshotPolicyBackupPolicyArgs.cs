// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc.Inputs
{

    public sealed class SnapshotPolicyBackupPolicyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Backup cycle time, the value can be monday, tuesday, wednesday, thursday, friday, saturday, sunday.
        /// </summary>
        [Input("backupDay", required: true)]
        public Input<string> BackupDay { get; set; } = null!;

        /// <summary>
        /// Backup time point, format:HH:mm:ss.
        /// </summary>
        [Input("backupTime", required: true)]
        public Input<string> BackupTime { get; set; } = null!;

        public SnapshotPolicyBackupPolicyArgs()
        {
        }
        public static new SnapshotPolicyBackupPolicyArgs Empty => new SnapshotPolicyBackupPolicyArgs();
    }
}
