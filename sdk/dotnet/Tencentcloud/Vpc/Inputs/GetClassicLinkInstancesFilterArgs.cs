// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc.Inputs
{

    public sealed class GetClassicLinkInstancesFilterInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The attribute name. If more than one Filter exists, the logical relation between these Filters is `AND`.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("values", required: true)]
        private InputList<string>? _values;

        /// <summary>
        /// The attribute value. If there are multiple Values for one Filter, the logical relation between these Values under the same Filter is `OR`.
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public GetClassicLinkInstancesFilterInputArgs()
        {
        }
        public static new GetClassicLinkInstancesFilterInputArgs Empty => new GetClassicLinkInstancesFilterInputArgs();
    }
}