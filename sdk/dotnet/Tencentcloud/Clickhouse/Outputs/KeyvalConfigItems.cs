// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clickhouse.Outputs
{

    [OutputType]
    public sealed class KeyvalConfigItems
    {
        /// <summary>
        /// Instance config key.
        /// </summary>
        public readonly string ConfKey;
        /// <summary>
        /// Instance config value.
        /// </summary>
        public readonly string ConfValue;

        [OutputConstructor]
        private KeyvalConfigItems(
            string confKey,

            string confValue)
        {
            ConfKey = confKey;
            ConfValue = confValue;
        }
    }
}
