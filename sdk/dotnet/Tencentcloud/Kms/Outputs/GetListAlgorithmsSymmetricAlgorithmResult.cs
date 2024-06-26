// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kms.Outputs
{

    [OutputType]
    public sealed class GetListAlgorithmsSymmetricAlgorithmResult
    {
        /// <summary>
        /// Algorithm.
        /// </summary>
        public readonly string Algorithm;
        /// <summary>
        /// Key usage.
        /// </summary>
        public readonly string KeyUsage;

        [OutputConstructor]
        private GetListAlgorithmsSymmetricAlgorithmResult(
            string algorithm,

            string keyUsage)
        {
            Algorithm = algorithm;
            KeyUsage = keyUsage;
        }
    }
}
