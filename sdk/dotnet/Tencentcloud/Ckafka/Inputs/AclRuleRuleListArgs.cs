// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Inputs
{

    public sealed class AclRuleRuleListArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The default is *, which means that any host can be accessed. Currently, ckafka does not support host and ip network segment.
        /// </summary>
        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        /// <summary>
        /// Acl operation mode, enumeration value (all operations All, read Read, write Write).
        /// </summary>
        [Input("operation", required: true)]
        public Input<string> Operation { get; set; } = null!;

        /// <summary>
        /// permission type, (Deny|Allow).
        /// </summary>
        [Input("permissionType", required: true)]
        public Input<string> PermissionType { get; set; } = null!;

        /// <summary>
        /// User list, the default is User:, which means that any user can access, and the current user can only be the user included in the user list. The input format needs to be prefixed with [User:]. For example, user A is passed in as User:A.
        /// </summary>
        [Input("principal", required: true)]
        public Input<string> Principal { get; set; } = null!;

        public AclRuleRuleListArgs()
        {
        }
        public static new AclRuleRuleListArgs Empty => new AclRuleRuleListArgs();
    }
}
