# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'InstanceConfig',
    'InstanceDynamicRetentionConfig',
    'InstanceTag',
    'GetAclsAclListResult',
    'GetInstancesFilterResult',
    'GetInstancesInstanceListResult',
    'GetInstancesInstanceListTagResult',
    'GetInstancesInstanceListVipListResult',
    'GetTopicsInstanceListResult',
    'GetUsersUserListResult',
]

@pulumi.output_type
class InstanceConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "autoCreateTopicEnable":
            suggest = "auto_create_topic_enable"
        elif key == "defaultNumPartitions":
            suggest = "default_num_partitions"
        elif key == "defaultReplicationFactor":
            suggest = "default_replication_factor"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in InstanceConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        InstanceConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        InstanceConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 auto_create_topic_enable: bool,
                 default_num_partitions: int,
                 default_replication_factor: int):
        """
        :param bool auto_create_topic_enable: Automatic creation. true: enabled, false: not enabled.
        :param int default_num_partitions: If auto.create.topic.enable is set to true and this value is not set, 3 will be used by default.
        :param int default_replication_factor: If auto.create.topic.enable is set to true but this value is not set, 2 will be used by default.
        """
        pulumi.set(__self__, "auto_create_topic_enable", auto_create_topic_enable)
        pulumi.set(__self__, "default_num_partitions", default_num_partitions)
        pulumi.set(__self__, "default_replication_factor", default_replication_factor)

    @property
    @pulumi.getter(name="autoCreateTopicEnable")
    def auto_create_topic_enable(self) -> bool:
        """
        Automatic creation. true: enabled, false: not enabled.
        """
        return pulumi.get(self, "auto_create_topic_enable")

    @property
    @pulumi.getter(name="defaultNumPartitions")
    def default_num_partitions(self) -> int:
        """
        If auto.create.topic.enable is set to true and this value is not set, 3 will be used by default.
        """
        return pulumi.get(self, "default_num_partitions")

    @property
    @pulumi.getter(name="defaultReplicationFactor")
    def default_replication_factor(self) -> int:
        """
        If auto.create.topic.enable is set to true but this value is not set, 2 will be used by default.
        """
        return pulumi.get(self, "default_replication_factor")


@pulumi.output_type
class InstanceDynamicRetentionConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "bottomRetention":
            suggest = "bottom_retention"
        elif key == "diskQuotaPercentage":
            suggest = "disk_quota_percentage"
        elif key == "stepForwardPercentage":
            suggest = "step_forward_percentage"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in InstanceDynamicRetentionConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        InstanceDynamicRetentionConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        InstanceDynamicRetentionConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 bottom_retention: Optional[int] = None,
                 disk_quota_percentage: Optional[int] = None,
                 enable: Optional[int] = None,
                 step_forward_percentage: Optional[int] = None):
        """
        :param int bottom_retention: Minimum retention time, in minutes.
        :param int disk_quota_percentage: Disk quota threshold (in percentage) for triggering the message retention time change event.
        :param int enable: Whether the dynamic message retention time configuration is enabled. 0: disabled; 1: enabled.
        :param int step_forward_percentage: Percentage by which the message retention time is shortened each time.
        """
        if bottom_retention is not None:
            pulumi.set(__self__, "bottom_retention", bottom_retention)
        if disk_quota_percentage is not None:
            pulumi.set(__self__, "disk_quota_percentage", disk_quota_percentage)
        if enable is not None:
            pulumi.set(__self__, "enable", enable)
        if step_forward_percentage is not None:
            pulumi.set(__self__, "step_forward_percentage", step_forward_percentage)

    @property
    @pulumi.getter(name="bottomRetention")
    def bottom_retention(self) -> Optional[int]:
        """
        Minimum retention time, in minutes.
        """
        return pulumi.get(self, "bottom_retention")

    @property
    @pulumi.getter(name="diskQuotaPercentage")
    def disk_quota_percentage(self) -> Optional[int]:
        """
        Disk quota threshold (in percentage) for triggering the message retention time change event.
        """
        return pulumi.get(self, "disk_quota_percentage")

    @property
    @pulumi.getter
    def enable(self) -> Optional[int]:
        """
        Whether the dynamic message retention time configuration is enabled. 0: disabled; 1: enabled.
        """
        return pulumi.get(self, "enable")

    @property
    @pulumi.getter(name="stepForwardPercentage")
    def step_forward_percentage(self) -> Optional[int]:
        """
        Percentage by which the message retention time is shortened each time.
        """
        return pulumi.get(self, "step_forward_percentage")


@pulumi.output_type
class InstanceTag(dict):
    def __init__(__self__, *,
                 key: str,
                 value: str):
        """
        :param str key: Tag key.
        :param str value: Tag value.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        Tag key.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        Tag value.
        """
        return pulumi.get(self, "value")


@pulumi.output_type
class GetAclsAclListResult(dict):
    def __init__(__self__, *,
                 host: str,
                 operation_type: str,
                 permission_type: str,
                 principal: str,
                 resource_name: str,
                 resource_type: str):
        """
        :param str host: Host substr used for querying.
        :param str operation_type: ACL operation mode.
        :param str permission_type: ACL permission type, valid values are `UNKNOWN`, `ANY`, `DENY`, `ALLOW`, and `ALLOW` by default. Currently, CKafka supports `ALLOW` (equivalent to allow list), and other fields will be used for future ACLs compatible with open-source Kafka.
        :param str principal: User which can access. `*` means that any user can access.
        :param str resource_name: ACL resource name, which is related to `resource_type`. For example, if `resource_type` is `TOPIC`, this field indicates the topic name; if `resource_type` is `GROUP`, this field indicates the group name.
        :param str resource_type: ACL resource type. Valid values are `UNKNOWN`, `ANY`, `TOPIC`, `GROUP`, `CLUSTER`, `TRANSACTIONAL_ID`. Currently, only `TOPIC` is available, and other fields will be used for future ACLs compatible with open-source Kafka.
        """
        pulumi.set(__self__, "host", host)
        pulumi.set(__self__, "operation_type", operation_type)
        pulumi.set(__self__, "permission_type", permission_type)
        pulumi.set(__self__, "principal", principal)
        pulumi.set(__self__, "resource_name", resource_name)
        pulumi.set(__self__, "resource_type", resource_type)

    @property
    @pulumi.getter
    def host(self) -> str:
        """
        Host substr used for querying.
        """
        return pulumi.get(self, "host")

    @property
    @pulumi.getter(name="operationType")
    def operation_type(self) -> str:
        """
        ACL operation mode.
        """
        return pulumi.get(self, "operation_type")

    @property
    @pulumi.getter(name="permissionType")
    def permission_type(self) -> str:
        """
        ACL permission type, valid values are `UNKNOWN`, `ANY`, `DENY`, `ALLOW`, and `ALLOW` by default. Currently, CKafka supports `ALLOW` (equivalent to allow list), and other fields will be used for future ACLs compatible with open-source Kafka.
        """
        return pulumi.get(self, "permission_type")

    @property
    @pulumi.getter
    def principal(self) -> str:
        """
        User which can access. `*` means that any user can access.
        """
        return pulumi.get(self, "principal")

    @property
    @pulumi.getter(name="resourceName")
    def resource_name(self) -> str:
        """
        ACL resource name, which is related to `resource_type`. For example, if `resource_type` is `TOPIC`, this field indicates the topic name; if `resource_type` is `GROUP`, this field indicates the group name.
        """
        return pulumi.get(self, "resource_name")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> str:
        """
        ACL resource type. Valid values are `UNKNOWN`, `ANY`, `TOPIC`, `GROUP`, `CLUSTER`, `TRANSACTIONAL_ID`. Currently, only `TOPIC` is available, and other fields will be used for future ACLs compatible with open-source Kafka.
        """
        return pulumi.get(self, "resource_type")


@pulumi.output_type
class GetInstancesFilterResult(dict):
    def __init__(__self__, *,
                 name: str,
                 values: Sequence[str]):
        """
        :param str name: The field that needs to be filtered.
        :param Sequence[str] values: The filtered value of the field.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "values", values)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The field that needs to be filtered.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def values(self) -> Sequence[str]:
        """
        The filtered value of the field.
        """
        return pulumi.get(self, "values")


@pulumi.output_type
class GetInstancesInstanceListResult(dict):
    def __init__(__self__, *,
                 bandwidth: int,
                 create_time: int,
                 cvm: int,
                 disk_size: int,
                 disk_type: str,
                 expire_time: int,
                 healthy: int,
                 healthy_message: str,
                 instance_id: str,
                 instance_name: str,
                 instance_type: str,
                 is_internal: int,
                 max_partition_number: int,
                 max_topic_number: int,
                 partition_number: int,
                 public_network: int,
                 public_network_charge_type: str,
                 rebalance_time: str,
                 renew_flag: int,
                 status: int,
                 subnet_id: str,
                 tags: Sequence['outputs.GetInstancesInstanceListTagResult'],
                 topic_num: int,
                 version: str,
                 vip: str,
                 vip_list: 'outputs.GetInstancesInstanceListVipListResult',
                 vpc_id: str,
                 vport: str,
                 zone_id: int,
                 zone_ids: Sequence[int]):
        """
        :param int bandwidth: Instance bandwidth, in Mbps.
        :param int create_time: The time when the instance was created.
        :param int cvm: ckafka sale type. Note: This field may return null, indicating that a valid value could not be retrieved.
        :param int disk_size: The storage size of the instance, in GB.
        :param str disk_type: Disk Type. Note: This field may return null, indicating that a valid value could not be retrieved.
        :param int expire_time: The instance expiration time.
        :param int healthy: Instance status int: 1 indicates health, 2 indicates alarm, and 3 indicates abnormal instance status.
        :param str healthy_message: Instance status information.
        :param str instance_id: The instance ID.
        :param str instance_name: The instance name.
        :param str instance_type: ckafka instance type. Note: This field may return null, indicating that a valid value could not be retrieved.
        :param int is_internal: Whether it is an internal customer. A value of 1 indicates an internal customer.
        :param int max_partition_number: The maximum number of Partitions for the current specifications. Note: This field may return null, indicating that a valid value could not be retrieved.
        :param int max_topic_number: The maximum number of topics in the current specifications. Note: This field may return null, indicating that a valid value could not be retrieved..
        :param int partition_number: The current number of instances. Note: This field may return null, indicating that a valid value could not be retrieved..
        :param int public_network: The Internet bandwidth value. Note: This field may return null, indicating that a valid value could not be retrieved..
        :param str public_network_charge_type: The type of Internet bandwidth. Note: This field may return null, indicating that a valid value could not be retrieved..
        :param str rebalance_time: Schedule the upgrade configuration time. Note: This field may return null, indicating that a valid value could not be retrieved..
        :param int renew_flag: Whether the instance is renewed, the int enumeration value: 1 indicates auto-renewal, and 2 indicates that it is not automatically renewed.
        :param int status: (Filter Criteria) The status of the instance. 0: Create, 1: Run, 2: Delete, do not fill the default return all.
        :param str subnet_id: Subnet id.
        :param Sequence['GetInstancesInstanceListTagArgs'] tags: Tag infomation.
        :param int topic_num: The number of topics.
        :param str version: Kafka version information. Note: This field may return null, indicating that a valid value could not be retrieved.
        :param str vip: Virtual IP.
        :param 'GetInstancesInstanceListVipListArgs' vip_list: Virtual IP entities.
        :param str vpc_id: VpcId, if empty, indicates that it is the underlying network.
        :param str vport: Virtual PORT.
        :param int zone_id: Availability Zone ID.
        :param Sequence[int] zone_ids: Across Availability Zones. Note: This field may return null, indicating that a valid value could not be retrieved.
        """
        pulumi.set(__self__, "bandwidth", bandwidth)
        pulumi.set(__self__, "create_time", create_time)
        pulumi.set(__self__, "cvm", cvm)
        pulumi.set(__self__, "disk_size", disk_size)
        pulumi.set(__self__, "disk_type", disk_type)
        pulumi.set(__self__, "expire_time", expire_time)
        pulumi.set(__self__, "healthy", healthy)
        pulumi.set(__self__, "healthy_message", healthy_message)
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "instance_name", instance_name)
        pulumi.set(__self__, "instance_type", instance_type)
        pulumi.set(__self__, "is_internal", is_internal)
        pulumi.set(__self__, "max_partition_number", max_partition_number)
        pulumi.set(__self__, "max_topic_number", max_topic_number)
        pulumi.set(__self__, "partition_number", partition_number)
        pulumi.set(__self__, "public_network", public_network)
        pulumi.set(__self__, "public_network_charge_type", public_network_charge_type)
        pulumi.set(__self__, "rebalance_time", rebalance_time)
        pulumi.set(__self__, "renew_flag", renew_flag)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "subnet_id", subnet_id)
        pulumi.set(__self__, "tags", tags)
        pulumi.set(__self__, "topic_num", topic_num)
        pulumi.set(__self__, "version", version)
        pulumi.set(__self__, "vip", vip)
        pulumi.set(__self__, "vip_list", vip_list)
        pulumi.set(__self__, "vpc_id", vpc_id)
        pulumi.set(__self__, "vport", vport)
        pulumi.set(__self__, "zone_id", zone_id)
        pulumi.set(__self__, "zone_ids", zone_ids)

    @property
    @pulumi.getter
    def bandwidth(self) -> int:
        """
        Instance bandwidth, in Mbps.
        """
        return pulumi.get(self, "bandwidth")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> int:
        """
        The time when the instance was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def cvm(self) -> int:
        """
        ckafka sale type. Note: This field may return null, indicating that a valid value could not be retrieved.
        """
        return pulumi.get(self, "cvm")

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> int:
        """
        The storage size of the instance, in GB.
        """
        return pulumi.get(self, "disk_size")

    @property
    @pulumi.getter(name="diskType")
    def disk_type(self) -> str:
        """
        Disk Type. Note: This field may return null, indicating that a valid value could not be retrieved.
        """
        return pulumi.get(self, "disk_type")

    @property
    @pulumi.getter(name="expireTime")
    def expire_time(self) -> int:
        """
        The instance expiration time.
        """
        return pulumi.get(self, "expire_time")

    @property
    @pulumi.getter
    def healthy(self) -> int:
        """
        Instance status int: 1 indicates health, 2 indicates alarm, and 3 indicates abnormal instance status.
        """
        return pulumi.get(self, "healthy")

    @property
    @pulumi.getter(name="healthyMessage")
    def healthy_message(self) -> str:
        """
        Instance status information.
        """
        return pulumi.get(self, "healthy_message")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        """
        The instance ID.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="instanceName")
    def instance_name(self) -> str:
        """
        The instance name.
        """
        return pulumi.get(self, "instance_name")

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> str:
        """
        ckafka instance type. Note: This field may return null, indicating that a valid value could not be retrieved.
        """
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="isInternal")
    def is_internal(self) -> int:
        """
        Whether it is an internal customer. A value of 1 indicates an internal customer.
        """
        return pulumi.get(self, "is_internal")

    @property
    @pulumi.getter(name="maxPartitionNumber")
    def max_partition_number(self) -> int:
        """
        The maximum number of Partitions for the current specifications. Note: This field may return null, indicating that a valid value could not be retrieved.
        """
        return pulumi.get(self, "max_partition_number")

    @property
    @pulumi.getter(name="maxTopicNumber")
    def max_topic_number(self) -> int:
        """
        The maximum number of topics in the current specifications. Note: This field may return null, indicating that a valid value could not be retrieved..
        """
        return pulumi.get(self, "max_topic_number")

    @property
    @pulumi.getter(name="partitionNumber")
    def partition_number(self) -> int:
        """
        The current number of instances. Note: This field may return null, indicating that a valid value could not be retrieved..
        """
        return pulumi.get(self, "partition_number")

    @property
    @pulumi.getter(name="publicNetwork")
    def public_network(self) -> int:
        """
        The Internet bandwidth value. Note: This field may return null, indicating that a valid value could not be retrieved..
        """
        return pulumi.get(self, "public_network")

    @property
    @pulumi.getter(name="publicNetworkChargeType")
    def public_network_charge_type(self) -> str:
        """
        The type of Internet bandwidth. Note: This field may return null, indicating that a valid value could not be retrieved..
        """
        return pulumi.get(self, "public_network_charge_type")

    @property
    @pulumi.getter(name="rebalanceTime")
    def rebalance_time(self) -> str:
        """
        Schedule the upgrade configuration time. Note: This field may return null, indicating that a valid value could not be retrieved..
        """
        return pulumi.get(self, "rebalance_time")

    @property
    @pulumi.getter(name="renewFlag")
    def renew_flag(self) -> int:
        """
        Whether the instance is renewed, the int enumeration value: 1 indicates auto-renewal, and 2 indicates that it is not automatically renewed.
        """
        return pulumi.get(self, "renew_flag")

    @property
    @pulumi.getter
    def status(self) -> int:
        """
        (Filter Criteria) The status of the instance. 0: Create, 1: Run, 2: Delete, do not fill the default return all.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> str:
        """
        Subnet id.
        """
        return pulumi.get(self, "subnet_id")

    @property
    @pulumi.getter
    def tags(self) -> Sequence['outputs.GetInstancesInstanceListTagResult']:
        """
        Tag infomation.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="topicNum")
    def topic_num(self) -> int:
        """
        The number of topics.
        """
        return pulumi.get(self, "topic_num")

    @property
    @pulumi.getter
    def version(self) -> str:
        """
        Kafka version information. Note: This field may return null, indicating that a valid value could not be retrieved.
        """
        return pulumi.get(self, "version")

    @property
    @pulumi.getter
    def vip(self) -> str:
        """
        Virtual IP.
        """
        return pulumi.get(self, "vip")

    @property
    @pulumi.getter(name="vipList")
    def vip_list(self) -> 'outputs.GetInstancesInstanceListVipListResult':
        """
        Virtual IP entities.
        """
        return pulumi.get(self, "vip_list")

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> str:
        """
        VpcId, if empty, indicates that it is the underlying network.
        """
        return pulumi.get(self, "vpc_id")

    @property
    @pulumi.getter
    def vport(self) -> str:
        """
        Virtual PORT.
        """
        return pulumi.get(self, "vport")

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> int:
        """
        Availability Zone ID.
        """
        return pulumi.get(self, "zone_id")

    @property
    @pulumi.getter(name="zoneIds")
    def zone_ids(self) -> Sequence[int]:
        """
        Across Availability Zones. Note: This field may return null, indicating that a valid value could not be retrieved.
        """
        return pulumi.get(self, "zone_ids")


@pulumi.output_type
class GetInstancesInstanceListTagResult(dict):
    def __init__(__self__, *,
                 tag_key: str,
                 tag_value: str):
        """
        :param str tag_key: Matches the tag key value.
        :param str tag_value: Tag Value.
        """
        pulumi.set(__self__, "tag_key", tag_key)
        pulumi.set(__self__, "tag_value", tag_value)

    @property
    @pulumi.getter(name="tagKey")
    def tag_key(self) -> str:
        """
        Matches the tag key value.
        """
        return pulumi.get(self, "tag_key")

    @property
    @pulumi.getter(name="tagValue")
    def tag_value(self) -> str:
        """
        Tag Value.
        """
        return pulumi.get(self, "tag_value")


@pulumi.output_type
class GetInstancesInstanceListVipListResult(dict):
    def __init__(__self__, *,
                 vip: str,
                 vport: str):
        """
        :param str vip: Virtual IP.
        :param str vport: Virtual PORT.
        """
        pulumi.set(__self__, "vip", vip)
        pulumi.set(__self__, "vport", vport)

    @property
    @pulumi.getter
    def vip(self) -> str:
        """
        Virtual IP.
        """
        return pulumi.get(self, "vip")

    @property
    @pulumi.getter
    def vport(self) -> str:
        """
        Virtual PORT.
        """
        return pulumi.get(self, "vport")


@pulumi.output_type
class GetTopicsInstanceListResult(dict):
    def __init__(__self__, *,
                 clean_up_policy: str,
                 create_time: str,
                 enable_white_list: bool,
                 forward_cos_bucket: str,
                 forward_interval: int,
                 forward_status: int,
                 ip_white_list_count: int,
                 max_message_bytes: int,
                 note: str,
                 partition_num: int,
                 replica_num: int,
                 retention: int,
                 segment: int,
                 segment_bytes: int,
                 sync_replica_min_num: int,
                 topic_id: str,
                 topic_name: str,
                 unclean_leader_election_enable: bool):
        """
        :param str clean_up_policy: Clear log policy, log clear mode. `delete`: logs are deleted according to the storage time, `compact`: logs are compressed according to the key, `compact, delete`: logs are compressed according to the key and will be deleted according to the storage time.
        :param str create_time: Create time of the CKafka topic.
        :param bool enable_white_list: Whether to open the IP Whitelist. `true`: open, `false`: close.
        :param str forward_cos_bucket: Data backup cos bucket: the bucket address that is dumped to cos.
        :param int forward_interval: Periodic frequency of data backup to cos.
        :param int forward_status: Data backup cos status. `1`: do not open data backup, `0`: open data backup.
        :param int ip_white_list_count: IP Whitelist count.
        :param int max_message_bytes: Max message bytes.
        :param str note: CKafka topic note description.
        :param int partition_num: The number of partition.
        :param int replica_num: The number of replica.
        :param int retention: Message can be selected. Retention time(unit ms).
        :param int segment: Segment scrolling time, in ms.
        :param int segment_bytes: Number of bytes rolled by shard.
        :param int sync_replica_min_num: Min number of sync replicas.
        :param str topic_id: ID of the CKafka topic.
        :param str topic_name: Name of the CKafka topic. It must start with a letter, the rest can contain letters, numbers and dashes(-). The length range is from 1 to 64.
        :param bool unclean_leader_election_enable: Whether to allow unsynchronized replicas to be selected as leader, default is `false`, `true: `allowed, `false`: not allowed.
        """
        pulumi.set(__self__, "clean_up_policy", clean_up_policy)
        pulumi.set(__self__, "create_time", create_time)
        pulumi.set(__self__, "enable_white_list", enable_white_list)
        pulumi.set(__self__, "forward_cos_bucket", forward_cos_bucket)
        pulumi.set(__self__, "forward_interval", forward_interval)
        pulumi.set(__self__, "forward_status", forward_status)
        pulumi.set(__self__, "ip_white_list_count", ip_white_list_count)
        pulumi.set(__self__, "max_message_bytes", max_message_bytes)
        pulumi.set(__self__, "note", note)
        pulumi.set(__self__, "partition_num", partition_num)
        pulumi.set(__self__, "replica_num", replica_num)
        pulumi.set(__self__, "retention", retention)
        pulumi.set(__self__, "segment", segment)
        pulumi.set(__self__, "segment_bytes", segment_bytes)
        pulumi.set(__self__, "sync_replica_min_num", sync_replica_min_num)
        pulumi.set(__self__, "topic_id", topic_id)
        pulumi.set(__self__, "topic_name", topic_name)
        pulumi.set(__self__, "unclean_leader_election_enable", unclean_leader_election_enable)

    @property
    @pulumi.getter(name="cleanUpPolicy")
    def clean_up_policy(self) -> str:
        """
        Clear log policy, log clear mode. `delete`: logs are deleted according to the storage time, `compact`: logs are compressed according to the key, `compact, delete`: logs are compressed according to the key and will be deleted according to the storage time.
        """
        return pulumi.get(self, "clean_up_policy")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        Create time of the CKafka topic.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="enableWhiteList")
    def enable_white_list(self) -> bool:
        """
        Whether to open the IP Whitelist. `true`: open, `false`: close.
        """
        return pulumi.get(self, "enable_white_list")

    @property
    @pulumi.getter(name="forwardCosBucket")
    def forward_cos_bucket(self) -> str:
        """
        Data backup cos bucket: the bucket address that is dumped to cos.
        """
        return pulumi.get(self, "forward_cos_bucket")

    @property
    @pulumi.getter(name="forwardInterval")
    def forward_interval(self) -> int:
        """
        Periodic frequency of data backup to cos.
        """
        return pulumi.get(self, "forward_interval")

    @property
    @pulumi.getter(name="forwardStatus")
    def forward_status(self) -> int:
        """
        Data backup cos status. `1`: do not open data backup, `0`: open data backup.
        """
        return pulumi.get(self, "forward_status")

    @property
    @pulumi.getter(name="ipWhiteListCount")
    def ip_white_list_count(self) -> int:
        """
        IP Whitelist count.
        """
        return pulumi.get(self, "ip_white_list_count")

    @property
    @pulumi.getter(name="maxMessageBytes")
    def max_message_bytes(self) -> int:
        """
        Max message bytes.
        """
        return pulumi.get(self, "max_message_bytes")

    @property
    @pulumi.getter
    def note(self) -> str:
        """
        CKafka topic note description.
        """
        return pulumi.get(self, "note")

    @property
    @pulumi.getter(name="partitionNum")
    def partition_num(self) -> int:
        """
        The number of partition.
        """
        return pulumi.get(self, "partition_num")

    @property
    @pulumi.getter(name="replicaNum")
    def replica_num(self) -> int:
        """
        The number of replica.
        """
        return pulumi.get(self, "replica_num")

    @property
    @pulumi.getter
    def retention(self) -> int:
        """
        Message can be selected. Retention time(unit ms).
        """
        return pulumi.get(self, "retention")

    @property
    @pulumi.getter
    def segment(self) -> int:
        """
        Segment scrolling time, in ms.
        """
        return pulumi.get(self, "segment")

    @property
    @pulumi.getter(name="segmentBytes")
    def segment_bytes(self) -> int:
        """
        Number of bytes rolled by shard.
        """
        return pulumi.get(self, "segment_bytes")

    @property
    @pulumi.getter(name="syncReplicaMinNum")
    def sync_replica_min_num(self) -> int:
        """
        Min number of sync replicas.
        """
        return pulumi.get(self, "sync_replica_min_num")

    @property
    @pulumi.getter(name="topicId")
    def topic_id(self) -> str:
        """
        ID of the CKafka topic.
        """
        return pulumi.get(self, "topic_id")

    @property
    @pulumi.getter(name="topicName")
    def topic_name(self) -> str:
        """
        Name of the CKafka topic. It must start with a letter, the rest can contain letters, numbers and dashes(-). The length range is from 1 to 64.
        """
        return pulumi.get(self, "topic_name")

    @property
    @pulumi.getter(name="uncleanLeaderElectionEnable")
    def unclean_leader_election_enable(self) -> bool:
        """
        Whether to allow unsynchronized replicas to be selected as leader, default is `false`, `true: `allowed, `false`: not allowed.
        """
        return pulumi.get(self, "unclean_leader_election_enable")


@pulumi.output_type
class GetUsersUserListResult(dict):
    def __init__(__self__, *,
                 account_name: str,
                 create_time: str,
                 update_time: str):
        """
        :param str account_name: Account name used when query ckafka users' infos. Could be a substr of user name.
        :param str create_time: Creation time of the account.
        :param str update_time: The last update time of the account.
        """
        pulumi.set(__self__, "account_name", account_name)
        pulumi.set(__self__, "create_time", create_time)
        pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter(name="accountName")
    def account_name(self) -> str:
        """
        Account name used when query ckafka users' infos. Could be a substr of user name.
        """
        return pulumi.get(self, "account_name")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        Creation time of the account.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> str:
        """
        The last update time of the account.
        """
        return pulumi.get(self, "update_time")

