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

    public sealed class DatahubTaskSourceResourceMySqlParamDropClsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// cls LogSet id.
        /// </summary>
        [Input("dropClsLogSet")]
        public Input<string>? DropClsLogSet { get; set; }

        /// <summary>
        /// account.
        /// </summary>
        [Input("dropClsOwneruin")]
        public Input<string>? DropClsOwneruin { get; set; }

        /// <summary>
        /// The region where the cls is delivered.
        /// </summary>
        [Input("dropClsRegion")]
        public Input<string>? DropClsRegion { get; set; }

        /// <summary>
        /// cls topic.
        /// </summary>
        [Input("dropClsTopicId")]
        public Input<string>? DropClsTopicId { get; set; }

        /// <summary>
        /// Whether to deliver to cls.
        /// </summary>
        [Input("dropInvalidMessageToCls")]
        public Input<bool>? DropInvalidMessageToCls { get; set; }

        public DatahubTaskSourceResourceMySqlParamDropClsArgs()
        {
        }
        public static new DatahubTaskSourceResourceMySqlParamDropClsArgs Empty => new DatahubTaskSourceResourceMySqlParamDropClsArgs();
    }
}