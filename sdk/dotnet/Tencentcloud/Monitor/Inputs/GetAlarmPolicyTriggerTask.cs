// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor.Inputs
{

    public sealed class GetAlarmPolicyTriggerTaskArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Configuration information in JSON format, such as {Key1:Value1,Key2:Value2}Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("taskConfig", required: true)]
        public string TaskConfig { get; set; } = null!;

        /// <summary>
        /// Triggered task type. Valid value: AS (auto scaling)Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("type", required: true)]
        public string Type { get; set; } = null!;

        public GetAlarmPolicyTriggerTaskArgs()
        {
        }
        public static new GetAlarmPolicyTriggerTaskArgs Empty => new GetAlarmPolicyTriggerTaskArgs();
    }
}
