// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes.Inputs
{

    public sealed class NativeNodePoolNativeLifecycleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Custom script after node initialization.
        /// </summary>
        [Input("postInit")]
        public Input<string>? PostInit { get; set; }

        /// <summary>
        /// Custom script before node initialization.
        /// </summary>
        [Input("preInit")]
        public Input<string>? PreInit { get; set; }

        public NativeNodePoolNativeLifecycleArgs()
        {
        }
        public static new NativeNodePoolNativeLifecycleArgs Empty => new NativeNodePoolNativeLifecycleArgs();
    }
}