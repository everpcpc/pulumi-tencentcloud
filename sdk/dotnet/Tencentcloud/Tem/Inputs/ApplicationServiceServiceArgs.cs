// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tem.Inputs
{

    public sealed class ApplicationServiceServiceArgs : Pulumi.ResourceArgs
    {
        [Input("ip")]
        public Input<string>? Ip { get; set; }

        [Input("portMappingItemLists")]
        private InputList<Inputs.ApplicationServiceServicePortMappingItemListArgs>? _portMappingItemLists;

        /// <summary>
        /// port mapping item list.
        /// </summary>
        public InputList<Inputs.ApplicationServiceServicePortMappingItemListArgs> PortMappingItemLists
        {
            get => _portMappingItemLists ?? (_portMappingItemLists = new InputList<Inputs.ApplicationServiceServicePortMappingItemListArgs>());
            set => _portMappingItemLists = value;
        }

        /// <summary>
        /// application service name.
        /// </summary>
        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        /// <summary>
        /// ID of subnet instance, required when type is `VPC`.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// application service type: EXTERNAL | VPC | CLUSTER.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// ID of vpc instance, required when type is `VPC`.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public ApplicationServiceServiceArgs()
        {
        }
    }
}