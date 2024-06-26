// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cfw.Outputs
{

    [OutputType]
    public sealed class VpcInstanceVpcFwInstanceFwDeploy
    {
        /// <summary>
        /// Off-site disaster recovery 1: use off-site disaster recovery; 0: do not use off-site disaster recovery; if it is empty, off-site disaster recovery will not be used by default.
        /// </summary>
        public readonly int? CrossAZone;
        /// <summary>
        /// Firewall Deployment Region.
        /// </summary>
        public readonly string DeployRegion;
        /// <summary>
        /// Bandwidth, unit: Mbps.
        /// </summary>
        public readonly int Width;
        /// <summary>
        /// Zone list.
        /// </summary>
        public readonly ImmutableArray<string> ZoneSets;

        [OutputConstructor]
        private VpcInstanceVpcFwInstanceFwDeploy(
            int? crossAZone,

            string deployRegion,

            int width,

            ImmutableArray<string> zoneSets)
        {
            CrossAZone = crossAZone;
            DeployRegion = deployRegion;
            Width = width;
            ZoneSets = zoneSets;
        }
    }
}
