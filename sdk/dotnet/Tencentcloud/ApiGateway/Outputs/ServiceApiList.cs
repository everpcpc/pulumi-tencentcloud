// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.ApiGateway.Outputs
{

    [OutputType]
    public sealed class ServiceApiList
    {
        /// <summary>
        /// Description of the API.
        /// </summary>
        public readonly string? ApiDesc;
        /// <summary>
        /// ID of the API.
        /// </summary>
        public readonly string? ApiId;
        /// <summary>
        /// Name of the API.
        /// </summary>
        public readonly string? ApiName;
        /// <summary>
        /// Method of the API.
        /// </summary>
        public readonly string? Method;
        /// <summary>
        /// Path of the API.
        /// </summary>
        public readonly string? Path;

        [OutputConstructor]
        private ServiceApiList(
            string? apiDesc,

            string? apiId,

            string? apiName,

            string? method,

            string? path)
        {
            ApiDesc = apiDesc;
            ApiId = apiId;
            ApiName = apiName;
            Method = method;
            Path = path;
        }
    }
}