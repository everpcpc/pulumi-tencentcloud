// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Oceanus.Outputs
{

    [OutputType]
    public sealed class GetTreeJobsTreeInfoResult
    {
        /// <summary>
        /// Subdirectory Information.
        /// </summary>
        public readonly string Children;
        /// <summary>
        /// ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// List of jobs.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTreeJobsTreeInfoJobSetResult> JobSets;
        /// <summary>
        /// Field to be filtered. Can only be set `Zone` or `JobType` or `JobStatus`.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Parent Id.
        /// </summary>
        public readonly string ParentId;

        [OutputConstructor]
        private GetTreeJobsTreeInfoResult(
            string children,

            string id,

            ImmutableArray<Outputs.GetTreeJobsTreeInfoJobSetResult> jobSets,

            string name,

            string parentId)
        {
            Children = children;
            Id = id;
            JobSets = jobSets;
            Name = name;
            ParentId = parentId;
        }
    }
}
