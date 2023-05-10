// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dts.Inputs
{

    public sealed class CompareTaskObjectsArgs : Pulumi.ResourceArgs
    {
        [Input("objectItems")]
        private InputList<Inputs.CompareTaskObjectsObjectItemArgs>? _objectItems;

        /// <summary>
        /// object items.
        /// </summary>
        public InputList<Inputs.CompareTaskObjectsObjectItemArgs> ObjectItems
        {
            get => _objectItems ?? (_objectItems = new InputList<Inputs.CompareTaskObjectsObjectItemArgs>());
            set => _objectItems = value;
        }

        /// <summary>
        /// object mode.
        /// </summary>
        [Input("objectMode", required: true)]
        public Input<string> ObjectMode { get; set; } = null!;

        public CompareTaskObjectsArgs()
        {
        }
    }
}