// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clickhouse.Inputs
{

    public sealed class KeyvalConfigItemsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance config key.
        /// </summary>
        [Input("confKey", required: true)]
        public Input<string> ConfKey { get; set; } = null!;

        /// <summary>
        /// Instance config value.
        /// </summary>
        [Input("confValue", required: true)]
        public Input<string> ConfValue { get; set; } = null!;

        public KeyvalConfigItemsArgs()
        {
        }
        public static new KeyvalConfigItemsArgs Empty => new KeyvalConfigItemsArgs();
    }
}
