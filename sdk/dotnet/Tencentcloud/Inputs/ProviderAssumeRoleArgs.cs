// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Inputs
{

    public sealed class ProviderAssumeRoleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A more restrictive policy when making the AssumeRole call. Its content must not contains `principal` elements. Notice: more syntax references, please refer to: [policies syntax logic](https://intl.cloud.tencent.com/document/product/598/10603).
        /// </summary>
        [Input("policy")]
        public Input<string>? Policy { get; set; }

        /// <summary>
        /// The ARN of the role to assume. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_ARN`.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        /// <summary>
        /// The duration of the session when making the AssumeRole call. Its value ranges from 0 to 43200(seconds), and default is 7200 seconds. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_DURATION`.
        /// </summary>
        [Input("sessionDuration", required: true)]
        public Input<int> SessionDuration { get; set; } = null!;

        /// <summary>
        /// The session name to use when making the AssumeRole call. It can be sourced from the `TENCENTCLOUD_ASSUME_ROLE_SESSION_NAME`.
        /// </summary>
        [Input("sessionName", required: true)]
        public Input<string> SessionName { get; set; } = null!;

        public ProviderAssumeRoleArgs()
        {
        }
        public static new ProviderAssumeRoleArgs Empty => new ProviderAssumeRoleArgs();
    }
}
