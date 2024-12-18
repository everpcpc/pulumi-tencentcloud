// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Scf.Outputs
{

    [OutputType]
    public sealed class GetFunctionsFunctionImageConfigResult
    {
        /// <summary>
        /// the parameters of command.
        /// </summary>
        public readonly string Args;
        /// <summary>
        /// The command of entrypoint.
        /// </summary>
        public readonly string Command;
        /// <summary>
        /// Image accelerate switch.
        /// </summary>
        public readonly bool ContainerImageAccelerate;
        /// <summary>
        /// The entrypoint of app.
        /// </summary>
        public readonly string EntryPoint;
        /// <summary>
        /// Image function port setting. Default is `9000`, -1 indicates no port mirroring function. Other value ranges 0 ~ 65535.
        /// </summary>
        public readonly int ImagePort;
        /// <summary>
        /// The image type. personal or enterprise.
        /// </summary>
        public readonly string ImageType;
        /// <summary>
        /// The uri of image.
        /// </summary>
        public readonly string ImageUri;
        /// <summary>
        /// The registry id of TCR. When image type is enterprise, it must be set.
        /// </summary>
        public readonly string RegistryId;

        [OutputConstructor]
        private GetFunctionsFunctionImageConfigResult(
            string args,

            string command,

            bool containerImageAccelerate,

            string entryPoint,

            int imagePort,

            string imageType,

            string imageUri,

            string registryId)
        {
            Args = args;
            Command = command;
            ContainerImageAccelerate = containerImageAccelerate;
            EntryPoint = entryPoint;
            ImagePort = imagePort;
            ImageType = imageType;
            ImageUri = imageUri;
            RegistryId = registryId;
        }
    }
}
