// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cos.Outputs
{

    [OutputType]
    public sealed class BatchOperationCosPutObjectCopy
    {
        /// <summary>
        /// This element specifies how ACL is copied. Valid values:
        /// - Copy: inherits the source object ACL
        /// - Replaced: replace source ACL
        /// - Add: add a new ACL based on the source ACL.
        /// </summary>
        public readonly string? AccessControlDirective;
        /// <summary>
        /// Controls the specific access to the object.
        /// </summary>
        public readonly Outputs.BatchOperationCosPutObjectCopyAccessControlGrants? AccessControlGrants;
        /// <summary>
        /// Defines the ACL property of the object. Valid values: private, public-read.
        /// </summary>
        public readonly string? CannedAccessControlList;
        /// <summary>
        /// This element specifies whether to copy object metadata from the source object or replace it with metadata in the &lt; NewObjectMetadata &gt; element. Valid values are: Copy, Replaced, Add. Copy: inherit source object metadata; Replaced: replace source metadata; Add: add new metadata based on source metadata.
        /// </summary>
        public readonly string? MetadataDirective;
        /// <summary>
        /// When the object is modified after the specified time, the operation is performed, otherwise 412 is returned.
        /// </summary>
        public readonly int? ModifiedSinceConstraint;
        /// <summary>
        /// Configure the metadata for the object.
        /// </summary>
        public readonly Outputs.BatchOperationCosPutObjectCopyNewObjectMetadata? NewObjectMetadata;
        /// <summary>
        /// The label of the configuration object, which must be specified when the &lt; TaggingDirective &gt; value is Replace or Add.
        /// </summary>
        public readonly ImmutableArray<Outputs.BatchOperationCosPutObjectCopyNewObjectTagging> NewObjectTaggings;
        /// <summary>
        /// Specifies whether the prefix of the source object needs to be replaced. A value of true indicates the replacement object prefix, which needs to be used with &lt;ResourcesPrefix&gt; and &lt;TargetKeyPrefix&gt;. Default value: false.
        /// </summary>
        public readonly bool? PrefixReplace;
        /// <summary>
        /// This field is valid only when the &lt; PrefixReplace &gt; value is true. Specify the source object prefix to be replaced, and the replacement directory should end with `/`. Can be empty with a maximum length of 1024 bytes.
        /// </summary>
        public readonly string? ResourcesPrefix;
        /// <summary>
        /// Sets the storage level of the object. Enumerated value: STANDARD,STANDARD_IA. Default value: STANDARD.
        /// </summary>
        public readonly string? StorageClass;
        /// <summary>
        /// This element specifies whether to copy the object tag from the source object or replace it with the tag in the &lt; NewObjectTagging &gt; element. Valid values are: Copy, Replaced, Add. Copy: inherits the source object tag; Replaced: replaces the source tag; Add: adds a new tag based on the source tag.
        /// </summary>
        public readonly string? TaggingDirective;
        /// <summary>
        /// This field is valid only when the &lt;PrefixReplace&gt; value is true. This value represents the replaced prefix, and the replacement directory should end with /. Can be empty with a maximum length of 1024 bytes.
        /// </summary>
        public readonly string? TargetKeyPrefix;
        /// <summary>
        /// Sets the target bucket for the Copy. Use qcs to specify, for example, qcs::cos:ap-chengdu:uid/1250000000:examplebucket-1250000000.
        /// </summary>
        public readonly string TargetResource;
        /// <summary>
        /// When the object has not been modified after the specified time, the operation is performed, otherwise 412 is returned.
        /// </summary>
        public readonly int? UnmodifiedSinceConstraint;

        [OutputConstructor]
        private BatchOperationCosPutObjectCopy(
            string? accessControlDirective,

            Outputs.BatchOperationCosPutObjectCopyAccessControlGrants? accessControlGrants,

            string? cannedAccessControlList,

            string? metadataDirective,

            int? modifiedSinceConstraint,

            Outputs.BatchOperationCosPutObjectCopyNewObjectMetadata? newObjectMetadata,

            ImmutableArray<Outputs.BatchOperationCosPutObjectCopyNewObjectTagging> newObjectTaggings,

            bool? prefixReplace,

            string? resourcesPrefix,

            string? storageClass,

            string? taggingDirective,

            string? targetKeyPrefix,

            string targetResource,

            int? unmodifiedSinceConstraint)
        {
            AccessControlDirective = accessControlDirective;
            AccessControlGrants = accessControlGrants;
            CannedAccessControlList = cannedAccessControlList;
            MetadataDirective = metadataDirective;
            ModifiedSinceConstraint = modifiedSinceConstraint;
            NewObjectMetadata = newObjectMetadata;
            NewObjectTaggings = newObjectTaggings;
            PrefixReplace = prefixReplace;
            ResourcesPrefix = resourcesPrefix;
            StorageClass = storageClass;
            TaggingDirective = taggingDirective;
            TargetKeyPrefix = targetKeyPrefix;
            TargetResource = targetResource;
            UnmodifiedSinceConstraint = unmodifiedSinceConstraint;
        }
    }
}