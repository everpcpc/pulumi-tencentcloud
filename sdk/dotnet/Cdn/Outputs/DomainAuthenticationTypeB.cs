// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Outputs
{

    [OutputType]
    public sealed class DomainAuthenticationTypeB
    {
        /// <summary>
        /// Used for calculate a signature. 6-32 characters. Only digits and letters are allowed.
        /// </summary>
        public readonly string? BackupSecretKey;
        /// <summary>
        /// Signature expiration time in second. The maximum value is 630720000.
        /// </summary>
        public readonly int ExpireTime;
        /// <summary>
        /// File extension list settings determining if authentication should be performed. NOTE: If it contains an asterisk (*), this indicates all files.
        /// </summary>
        public readonly ImmutableArray<string> FileExtensions;
        /// <summary>
        /// Available values: `whitelist` - all types apart from `file_extensions` are authenticated, `blacklist`: - only the types in the `file_extensions` are authenticated.
        /// </summary>
        public readonly string FilterType;
        /// <summary>
        /// The key for signature calculation. Only digits, upper and lower-case letters are allowed. Length limit: 6-32 characters.
        /// </summary>
        public readonly string SecretKey;

        [OutputConstructor]
        private DomainAuthenticationTypeB(
            string? backupSecretKey,

            int expireTime,

            ImmutableArray<string> fileExtensions,

            string filterType,

            string secretKey)
        {
            BackupSecretKey = backupSecretKey;
            ExpireTime = expireTime;
            FileExtensions = fileExtensions;
            FilterType = filterType;
            SecretKey = secretKey;
        }
    }
}