// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Oceanus.Inputs
{

    public sealed class RunJobRunJobDescriptionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Custom timestamp.
        /// </summary>
        [Input("customTimestamp")]
        public Input<int>? CustomTimestamp { get; set; }

        /// <summary>
        /// A certain version of the current job(Not passed by default as a non-draft job version).
        /// </summary>
        [Input("jobConfigVersion")]
        public Input<int>? JobConfigVersion { get; set; }

        /// <summary>
        /// Job ID.
        /// </summary>
        [Input("jobId", required: true)]
        public Input<string> JobId { get; set; } = null!;

        /// <summary>
        /// The type of the run. 1 indicates start, and 2 indicates resume.
        /// </summary>
        [Input("runType", required: true)]
        public Input<int> RunType { get; set; } = null!;

        /// <summary>
        /// Savepoint ID.
        /// </summary>
        [Input("savepointId")]
        public Input<string>? SavepointId { get; set; }

        /// <summary>
        /// Savepoint path.
        /// </summary>
        [Input("savepointPath")]
        public Input<string>? SavepointPath { get; set; }

        /// <summary>
        /// Compatible with the startup parameters of the old SQL type job: specify the start time point of data source consumption (recommended to pass the value)Ensure that the parameter is LATEST, EARLIEST, T+Timestamp (example: T1557394288000).
        /// </summary>
        [Input("startMode")]
        public Input<string>? StartMode { get; set; }

        /// <summary>
        /// Use the historical version of the system dependency.
        /// </summary>
        [Input("useOldSystemConnector")]
        public Input<bool>? UseOldSystemConnector { get; set; }

        public RunJobRunJobDescriptionGetArgs()
        {
        }
        public static new RunJobRunJobDescriptionGetArgs Empty => new RunJobRunJobDescriptionGetArgs();
    }
}