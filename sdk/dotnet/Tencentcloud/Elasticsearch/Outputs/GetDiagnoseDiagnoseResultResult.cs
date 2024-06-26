// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Elasticsearch.Outputs
{

    [OutputType]
    public sealed class GetDiagnoseDiagnoseResultResult
    {
        /// <summary>
        /// Whether the diagnosis is complete or not.
        /// </summary>
        public readonly bool Completed;
        /// <summary>
        /// Create time.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Instance id.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// Diagnostic parameters such as diagnostic time, diagnostic index, etc.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDiagnoseDiagnoseResultJobParamResult> JobParams;
        /// <summary>
        /// Diagnostic item result list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDiagnoseDiagnoseResultJobResultResult> JobResults;
        /// <summary>
        /// Diagnosis type, 2 timing diagnosis, 3 customer manual trigger diagnosis.
        /// </summary>
        public readonly int JobType;
        /// <summary>
        /// Request id.
        /// </summary>
        public readonly string RequestId;
        /// <summary>
        /// Total diagnostic score.
        /// </summary>
        public readonly int Score;

        [OutputConstructor]
        private GetDiagnoseDiagnoseResultResult(
            bool completed,

            string createTime,

            string instanceId,

            ImmutableArray<Outputs.GetDiagnoseDiagnoseResultJobParamResult> jobParams,

            ImmutableArray<Outputs.GetDiagnoseDiagnoseResultJobResultResult> jobResults,

            int jobType,

            string requestId,

            int score)
        {
            Completed = completed;
            CreateTime = createTime;
            InstanceId = instanceId;
            JobParams = jobParams;
            JobResults = jobResults;
            JobType = jobType;
            RequestId = requestId;
            Score = score;
        }
    }
}
