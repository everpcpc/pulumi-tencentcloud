// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Redis.Inputs
{

    public sealed class GetBackupDownloadInfoLimitVpcInputArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Customize the region of the VPC to which the backup file is downloaded.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("vpcLists", required: true)]
        private InputList<string>? _vpcLists;

        /// <summary>
        /// Customize the list of VPCs to download backup files.
        /// </summary>
        public InputList<string> VpcLists
        {
            get => _vpcLists ?? (_vpcLists = new InputList<string>());
            set => _vpcLists = value;
        }

        public GetBackupDownloadInfoLimitVpcInputArgs()
        {
        }
    }
}