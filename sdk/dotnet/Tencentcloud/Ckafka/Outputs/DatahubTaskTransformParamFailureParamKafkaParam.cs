// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class DatahubTaskTransformParamFailureParamKafkaParam
    {
        /// <summary>
        /// Whether to compress when writing to the Topic, if it is not enabled, fill in none, if it is enabled, fill in open.
        /// </summary>
        public readonly string? CompressionType;
        /// <summary>
        /// enable dead letter queue.
        /// </summary>
        public readonly bool? EnableToleration;
        /// <summary>
        /// 1 source topic message is amplified into msg Multiple and written to the target topic (this parameter is currently only applicable to ckafka flowing into ckafka).
        /// </summary>
        public readonly int? MsgMultiple;
        /// <summary>
        /// Offset type, from beginning:earliest, from latest:latest, from specific time:timestamp.
        /// </summary>
        public readonly string? OffsetType;
        /// <summary>
        /// the partition num of the topic.
        /// </summary>
        public readonly int? PartitionNum;
        /// <summary>
        /// Qps(query per seconds) limit.
        /// </summary>
        public readonly int? QpsLimit;
        /// <summary>
        /// instance resource.
        /// </summary>
        public readonly string Resource;
        /// <summary>
        /// instance name.
        /// </summary>
        public readonly string? ResourceName;
        /// <summary>
        /// whether the cluster is built by yourself instead of cloud product.
        /// </summary>
        public readonly bool SelfBuilt;
        /// <summary>
        /// when Offset type timestamp is required.
        /// </summary>
        public readonly int? StartTime;
        /// <summary>
        /// maps of table to topic, required when multi topic is selected.
        /// </summary>
        public readonly ImmutableArray<Outputs.DatahubTaskTransformParamFailureParamKafkaParamTableMapping> TableMappings;
        /// <summary>
        /// Topic name, use `,` when more than 1 topic.
        /// </summary>
        public readonly string? Topic;
        /// <summary>
        /// Topic id.
        /// </summary>
        public readonly string? TopicId;
        /// <summary>
        /// Does the used topic need to be automatically created (currently only supports SOURCE inflow tasks, if you do not use to distribute to multiple topics, you need to fill in the topic name that needs to be automatically created in the Topic field).
        /// </summary>
        public readonly bool? UseAutoCreateTopic;
        /// <summary>
        /// whether to use multi table.
        /// </summary>
        public readonly bool? UseTableMapping;
        /// <summary>
        /// Zone ID.
        /// </summary>
        public readonly int? ZoneId;

        [OutputConstructor]
        private DatahubTaskTransformParamFailureParamKafkaParam(
            string? compressionType,

            bool? enableToleration,

            int? msgMultiple,

            string? offsetType,

            int? partitionNum,

            int? qpsLimit,

            string resource,

            string? resourceName,

            bool selfBuilt,

            int? startTime,

            ImmutableArray<Outputs.DatahubTaskTransformParamFailureParamKafkaParamTableMapping> tableMappings,

            string? topic,

            string? topicId,

            bool? useAutoCreateTopic,

            bool? useTableMapping,

            int? zoneId)
        {
            CompressionType = compressionType;
            EnableToleration = enableToleration;
            MsgMultiple = msgMultiple;
            OffsetType = offsetType;
            PartitionNum = partitionNum;
            QpsLimit = qpsLimit;
            Resource = resource;
            ResourceName = resourceName;
            SelfBuilt = selfBuilt;
            StartTime = startTime;
            TableMappings = tableMappings;
            Topic = topic;
            TopicId = topicId;
            UseAutoCreateTopic = useAutoCreateTopic;
            UseTableMapping = useTableMapping;
            ZoneId = zoneId;
        }
    }
}