// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse.Outputs
{

    [OutputType]
    public sealed class GetSceneSceneSetResult
    {
        /// <summary>
        /// Use scene description.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Use the scene presentation name.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Use scene Id.
        /// </summary>
        public readonly string SceneId;

        [OutputConstructor]
        private GetSceneSceneSetResult(
            string description,

            string displayName,

            string sceneId)
        {
            Description = description;
            DisplayName = displayName;
            SceneId = sceneId;
        }
    }
}
