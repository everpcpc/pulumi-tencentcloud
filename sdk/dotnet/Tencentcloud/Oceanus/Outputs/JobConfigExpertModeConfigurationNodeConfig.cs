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
    public sealed class JobConfigExpertModeConfigurationNodeConfig
    {
        /// <summary>
        /// Configuration propertiesNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.JobConfigExpertModeConfigurationNodeConfigConfiguration> Configurations;
        /// <summary>
        /// Node IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// Node parallelismNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly int? Parallelism;
        /// <summary>
        /// Slot sharing groupNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? SlotSharingGroup;
        /// <summary>
        /// State TTL configuration of the node, separated by semicolonsNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? StateTtl;

        [OutputConstructor]
        private JobConfigExpertModeConfigurationNodeConfig(
            ImmutableArray<Outputs.JobConfigExpertModeConfigurationNodeConfigConfiguration> configurations,

            int id,

            int? parallelism,

            string? slotSharingGroup,

            string? stateTtl)
        {
            Configurations = configurations;
            Id = id;
            Parallelism = parallelism;
            SlotSharingGroup = slotSharingGroup;
            StateTtl = stateTtl;
        }
    }
}