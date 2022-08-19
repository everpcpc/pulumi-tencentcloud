// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Key.Outputs
{

    [OutputType]
    public sealed class GetPairsKeyPairListResult
    {
        /// <summary>
        /// Creation time of the key pair.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// ID of the key pair to be queried.
        /// </summary>
        public readonly string KeyId;
        /// <summary>
        /// Name of the key pair to be queried. Support regular expression search, only `^` and `$` are supported.
        /// </summary>
        public readonly string KeyName;
        /// <summary>
        /// Project ID of the key pair to be queried.
        /// </summary>
        public readonly int ProjectId;
        /// <summary>
        /// public key of the key pair.
        /// </summary>
        public readonly string PublicKey;

        [OutputConstructor]
        private GetPairsKeyPairListResult(
            string createTime,

            string keyId,

            string keyName,

            int projectId,

            string publicKey)
        {
            CreateTime = createTime;
            KeyId = keyId;
            KeyName = keyName;
            ProjectId = projectId;
            PublicKey = publicKey;
        }
    }
}