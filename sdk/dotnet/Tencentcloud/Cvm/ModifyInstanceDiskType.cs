// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cvm
{
    [TencentcloudResourceType("tencentcloud:Cvm/modifyInstanceDiskType:ModifyInstanceDiskType")]
    public partial class ModifyInstanceDiskType : global::Pulumi.CustomResource
    {
        /// <summary>
        /// For instance data disk configuration information, you only need to specify the media type of the target cloud disk to be
        /// converted, and specify the value of DiskType. Currently, only one data disk conversion is supported. The CdcId parameter
        /// is only supported for instances of the CDHPAID type.
        /// </summary>
        [Output("dataDisks")]
        public Output<ImmutableArray<Outputs.ModifyInstanceDiskTypeDataDisk>> DataDisks { get; private set; } = null!;

        /// <summary>
        /// Instance ID. To obtain the instance IDs, you can call DescribeInstances and look for InstanceId in the response.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// For instance system disk configuration information, you only need to specify the nature type of the target cloud disk to
        /// be converted, and specify the value of DiskType. Only CDHPAID type instances are supported to specify Cd.
        /// </summary>
        [Output("systemDisk")]
        public Output<Outputs.ModifyInstanceDiskTypeSystemDisk?> SystemDisk { get; private set; } = null!;


        /// <summary>
        /// Create a ModifyInstanceDiskType resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ModifyInstanceDiskType(string name, ModifyInstanceDiskTypeArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cvm/modifyInstanceDiskType:ModifyInstanceDiskType", name, args ?? new ModifyInstanceDiskTypeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ModifyInstanceDiskType(string name, Input<string> id, ModifyInstanceDiskTypeState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cvm/modifyInstanceDiskType:ModifyInstanceDiskType", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ModifyInstanceDiskType resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ModifyInstanceDiskType Get(string name, Input<string> id, ModifyInstanceDiskTypeState? state = null, CustomResourceOptions? options = null)
        {
            return new ModifyInstanceDiskType(name, id, state, options);
        }
    }

    public sealed class ModifyInstanceDiskTypeArgs : global::Pulumi.ResourceArgs
    {
        [Input("dataDisks")]
        private InputList<Inputs.ModifyInstanceDiskTypeDataDiskArgs>? _dataDisks;

        /// <summary>
        /// For instance data disk configuration information, you only need to specify the media type of the target cloud disk to be
        /// converted, and specify the value of DiskType. Currently, only one data disk conversion is supported. The CdcId parameter
        /// is only supported for instances of the CDHPAID type.
        /// </summary>
        public InputList<Inputs.ModifyInstanceDiskTypeDataDiskArgs> DataDisks
        {
            get => _dataDisks ?? (_dataDisks = new InputList<Inputs.ModifyInstanceDiskTypeDataDiskArgs>());
            set => _dataDisks = value;
        }

        /// <summary>
        /// Instance ID. To obtain the instance IDs, you can call DescribeInstances and look for InstanceId in the response.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// For instance system disk configuration information, you only need to specify the nature type of the target cloud disk to
        /// be converted, and specify the value of DiskType. Only CDHPAID type instances are supported to specify Cd.
        /// </summary>
        [Input("systemDisk")]
        public Input<Inputs.ModifyInstanceDiskTypeSystemDiskArgs>? SystemDisk { get; set; }

        public ModifyInstanceDiskTypeArgs()
        {
        }
        public static new ModifyInstanceDiskTypeArgs Empty => new ModifyInstanceDiskTypeArgs();
    }

    public sealed class ModifyInstanceDiskTypeState : global::Pulumi.ResourceArgs
    {
        [Input("dataDisks")]
        private InputList<Inputs.ModifyInstanceDiskTypeDataDiskGetArgs>? _dataDisks;

        /// <summary>
        /// For instance data disk configuration information, you only need to specify the media type of the target cloud disk to be
        /// converted, and specify the value of DiskType. Currently, only one data disk conversion is supported. The CdcId parameter
        /// is only supported for instances of the CDHPAID type.
        /// </summary>
        public InputList<Inputs.ModifyInstanceDiskTypeDataDiskGetArgs> DataDisks
        {
            get => _dataDisks ?? (_dataDisks = new InputList<Inputs.ModifyInstanceDiskTypeDataDiskGetArgs>());
            set => _dataDisks = value;
        }

        /// <summary>
        /// Instance ID. To obtain the instance IDs, you can call DescribeInstances and look for InstanceId in the response.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// For instance system disk configuration information, you only need to specify the nature type of the target cloud disk to
        /// be converted, and specify the value of DiskType. Only CDHPAID type instances are supported to specify Cd.
        /// </summary>
        [Input("systemDisk")]
        public Input<Inputs.ModifyInstanceDiskTypeSystemDiskGetArgs>? SystemDisk { get; set; }

        public ModifyInstanceDiskTypeState()
        {
        }
        public static new ModifyInstanceDiskTypeState Empty => new ModifyInstanceDiskTypeState();
    }
}