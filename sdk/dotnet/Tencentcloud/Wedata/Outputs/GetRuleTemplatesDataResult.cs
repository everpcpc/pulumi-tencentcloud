// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Wedata.Outputs
{

    [OutputType]
    public sealed class GetRuleTemplatesDataResult
    {
        /// <summary>
        /// Citations.
        /// </summary>
        public readonly int CitationCount;
        /// <summary>
        /// The type of comparison method supported by the rule (1: fixed value comparison, greater than, less than, greater than or equal to, etc. 2: fluctuating value comparison, absolute value, rise, fall).
        /// </summary>
        public readonly int CompareType;
        /// <summary>
        /// Description of rule template.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Whether to associate other library tables.
        /// </summary>
        public readonly bool MultiSourceFlag;
        /// <summary>
        /// Name of rule template.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Quality inspection dimensions. `1`: Accuracy, `2`: Uniqueness, `3`: Completeness, `4`: Consistency, `5`: Timeliness, `6`: Effectiveness.
        /// </summary>
        public readonly int QualityDim;
        /// <summary>
        /// ID of rule template.
        /// </summary>
        public readonly int RuleTemplateId;
        /// <summary>
        /// Content of rule template.
        /// </summary>
        public readonly string SourceContent;
        /// <summary>
        /// Applicable type of source data.
        /// </summary>
        public readonly ImmutableArray<int> SourceEngineTypes;
        /// <summary>
        /// Source data object type. `1`: value, `2`: string.
        /// </summary>
        public readonly int SourceObjectDataType;
        /// <summary>
        /// Source data object type. `1`: Constant, `2`: Offline table level, `3`: Offline field level.
        /// </summary>
        public readonly int SourceObjectType;
        /// <summary>
        /// Sql Expression.
        /// </summary>
        public readonly string SqlExpression;
        /// <summary>
        /// Sub Quality inspection dimensions. `1`: Accuracy, `2`: Uniqueness, `3`: Completeness, `4`: Consistency, `5`: Timeliness, `6`: Effectiveness.
        /// </summary>
        public readonly int SubQualityDim;
        /// <summary>
        /// Template type. `1` means System template, `2` means Custom template.
        /// </summary>
        public readonly int Type;
        /// <summary>
        /// update time, like: yyyy-MM-dd HH:mm:ss.
        /// </summary>
        public readonly string UpdateTime;
        /// <summary>
        /// user id.
        /// </summary>
        public readonly int UserId;
        /// <summary>
        /// user name.
        /// </summary>
        public readonly string UserName;
        /// <summary>
        /// If add where.
        /// </summary>
        public readonly bool WhereFlag;

        [OutputConstructor]
        private GetRuleTemplatesDataResult(
            int citationCount,

            int compareType,

            string description,

            bool multiSourceFlag,

            string name,

            int qualityDim,

            int ruleTemplateId,

            string sourceContent,

            ImmutableArray<int> sourceEngineTypes,

            int sourceObjectDataType,

            int sourceObjectType,

            string sqlExpression,

            int subQualityDim,

            int type,

            string updateTime,

            int userId,

            string userName,

            bool whereFlag)
        {
            CitationCount = citationCount;
            CompareType = compareType;
            Description = description;
            MultiSourceFlag = multiSourceFlag;
            Name = name;
            QualityDim = qualityDim;
            RuleTemplateId = ruleTemplateId;
            SourceContent = sourceContent;
            SourceEngineTypes = sourceEngineTypes;
            SourceObjectDataType = sourceObjectDataType;
            SourceObjectType = sourceObjectType;
            SqlExpression = sqlExpression;
            SubQualityDim = subQualityDim;
            Type = type;
            UpdateTime = updateTime;
            UserId = userId;
            UserName = userName;
            WhereFlag = whereFlag;
        }
    }
}
