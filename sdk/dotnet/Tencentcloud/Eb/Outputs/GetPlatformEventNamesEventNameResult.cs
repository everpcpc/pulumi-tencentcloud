// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Eb.Outputs
{

    [OutputType]
    public sealed class GetPlatformEventNamesEventNameResult
    {
        /// <summary>
        /// Event name.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string EventName;
        /// <summary>
        /// Event type.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string EventType;

        [OutputConstructor]
        private GetPlatformEventNamesEventNameResult(
            string eventName,

            string eventType)
        {
            EventName = eventName;
            EventType = eventType;
        }
    }
}
