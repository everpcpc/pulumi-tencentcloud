// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Inputs
{

    public sealed class ZoneSettingCacheFollowOriginGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies whether to follow the origin server configuration.
        /// </summary>
        [Input("switch")]
        public Input<string>? Switch { get; set; }

        public ZoneSettingCacheFollowOriginGetArgs()
        {
        }
        public static new ZoneSettingCacheFollowOriginGetArgs Empty => new ZoneSettingCacheFollowOriginGetArgs();
    }
}
