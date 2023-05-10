// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dbbrain.Inputs
{

    public sealed class ModifyDiagDbInstanceOperationInstanceConfsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Database inspection switch, Yes/No.
        /// </summary>
        [Input("dailyInspection")]
        public Input<string>? DailyInspection { get; set; }

        /// <summary>
        /// Instance overview switch, Yes/No.
        /// </summary>
        [Input("overviewDisplay")]
        public Input<string>? OverviewDisplay { get; set; }

        public ModifyDiagDbInstanceOperationInstanceConfsArgs()
        {
        }
    }
}