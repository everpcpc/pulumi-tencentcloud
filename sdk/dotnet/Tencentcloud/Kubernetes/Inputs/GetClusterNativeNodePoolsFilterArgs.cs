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

    public sealed class GetClusterNativeNodePoolsFilterInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The attribute name, if there are multiple filters, the relationship between the filters is a logical AND relationship.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("values", required: true)]
        private InputList<string>? _values;

        /// <summary>
        /// Attribute values, if there are multiple values in the same filter, the relationship between values under the same filter is a logical OR relationship.
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public GetClusterNativeNodePoolsFilterInputArgs()
        {
        }
        public static new GetClusterNativeNodePoolsFilterInputArgs Empty => new GetClusterNativeNodePoolsFilterInputArgs();
    }
}