# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['ConsumerGroupModifyOffsetArgs', 'ConsumerGroupModifyOffset']

@pulumi.input_type
class ConsumerGroupModifyOffsetArgs:
    def __init__(__self__, *,
                 group: pulumi.Input[str],
                 instance_id: pulumi.Input[str],
                 strategy: pulumi.Input[int],
                 offset: Optional[pulumi.Input[int]] = None,
                 partitions: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 shift: Optional[pulumi.Input[int]] = None,
                 shift_timestamp: Optional[pulumi.Input[int]] = None,
                 topics: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a ConsumerGroupModifyOffset resource.
        :param pulumi.Input[str] group: kafka group.
        :param pulumi.Input[str] instance_id: Kafka instance id.
        :param pulumi.Input[int] strategy: Reset the policy of offset.
               `0`: Move the offset forward or backward shift bar;
               `1`: Alignment reference (by-duration,to-datetime,to-earliest,to-latest), which means moving the offset to the location of the specified timestamp;
               `2`: Alignment reference (to-offset), which means to move the offset to the specified offset location.
        :param pulumi.Input[int] offset: The offset location that needs to be reset. When strategy is 2, this field must be included.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] partitions: The list of partition that needs to be reset if no Topics parameter is specified. Resets the partition in the corresponding Partition list of all topics. When Topics is specified, the partition of the corresponding topic list of the specified Partitions list is reset.
        :param pulumi.Input[int] shift: This field must be included when strategy is 0. If it is greater than zero, the offset will be moved backward by shift bars, and if it is less than zero, the offset will be traced back to the number of shift entries. After the correct reset, the new offset should be (old_offset + shift). It should be noted that if the new offset is less than partition's earliest, it will be set to earliest, and if the latest greater than partition will be set to latest.
        :param pulumi.Input[int] shift_timestamp: Unit ms. When strategy is 1, you must include this field, where-2 means to reset the offset to the beginning,-1 means to reset to the latest position (equivalent to emptying), and other values represent the specified time. You will get the offset of the specified time in the topic and then reset it. If there is no message at the specified time, get the last offset.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] topics: Indicates the topics that needs to be reset. Leave it empty means all.
        """
        pulumi.set(__self__, "group", group)
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "strategy", strategy)
        if offset is not None:
            pulumi.set(__self__, "offset", offset)
        if partitions is not None:
            pulumi.set(__self__, "partitions", partitions)
        if shift is not None:
            pulumi.set(__self__, "shift", shift)
        if shift_timestamp is not None:
            pulumi.set(__self__, "shift_timestamp", shift_timestamp)
        if topics is not None:
            pulumi.set(__self__, "topics", topics)

    @property
    @pulumi.getter
    def group(self) -> pulumi.Input[str]:
        """
        kafka group.
        """
        return pulumi.get(self, "group")

    @group.setter
    def group(self, value: pulumi.Input[str]):
        pulumi.set(self, "group", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        Kafka instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def strategy(self) -> pulumi.Input[int]:
        """
        Reset the policy of offset.
        `0`: Move the offset forward or backward shift bar;
        `1`: Alignment reference (by-duration,to-datetime,to-earliest,to-latest), which means moving the offset to the location of the specified timestamp;
        `2`: Alignment reference (to-offset), which means to move the offset to the specified offset location.
        """
        return pulumi.get(self, "strategy")

    @strategy.setter
    def strategy(self, value: pulumi.Input[int]):
        pulumi.set(self, "strategy", value)

    @property
    @pulumi.getter
    def offset(self) -> Optional[pulumi.Input[int]]:
        """
        The offset location that needs to be reset. When strategy is 2, this field must be included.
        """
        return pulumi.get(self, "offset")

    @offset.setter
    def offset(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "offset", value)

    @property
    @pulumi.getter
    def partitions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        The list of partition that needs to be reset if no Topics parameter is specified. Resets the partition in the corresponding Partition list of all topics. When Topics is specified, the partition of the corresponding topic list of the specified Partitions list is reset.
        """
        return pulumi.get(self, "partitions")

    @partitions.setter
    def partitions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "partitions", value)

    @property
    @pulumi.getter
    def shift(self) -> Optional[pulumi.Input[int]]:
        """
        This field must be included when strategy is 0. If it is greater than zero, the offset will be moved backward by shift bars, and if it is less than zero, the offset will be traced back to the number of shift entries. After the correct reset, the new offset should be (old_offset + shift). It should be noted that if the new offset is less than partition's earliest, it will be set to earliest, and if the latest greater than partition will be set to latest.
        """
        return pulumi.get(self, "shift")

    @shift.setter
    def shift(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "shift", value)

    @property
    @pulumi.getter(name="shiftTimestamp")
    def shift_timestamp(self) -> Optional[pulumi.Input[int]]:
        """
        Unit ms. When strategy is 1, you must include this field, where-2 means to reset the offset to the beginning,-1 means to reset to the latest position (equivalent to emptying), and other values represent the specified time. You will get the offset of the specified time in the topic and then reset it. If there is no message at the specified time, get the last offset.
        """
        return pulumi.get(self, "shift_timestamp")

    @shift_timestamp.setter
    def shift_timestamp(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "shift_timestamp", value)

    @property
    @pulumi.getter
    def topics(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Indicates the topics that needs to be reset. Leave it empty means all.
        """
        return pulumi.get(self, "topics")

    @topics.setter
    def topics(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "topics", value)


@pulumi.input_type
class _ConsumerGroupModifyOffsetState:
    def __init__(__self__, *,
                 group: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 offset: Optional[pulumi.Input[int]] = None,
                 partitions: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 shift: Optional[pulumi.Input[int]] = None,
                 shift_timestamp: Optional[pulumi.Input[int]] = None,
                 strategy: Optional[pulumi.Input[int]] = None,
                 topics: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering ConsumerGroupModifyOffset resources.
        :param pulumi.Input[str] group: kafka group.
        :param pulumi.Input[str] instance_id: Kafka instance id.
        :param pulumi.Input[int] offset: The offset location that needs to be reset. When strategy is 2, this field must be included.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] partitions: The list of partition that needs to be reset if no Topics parameter is specified. Resets the partition in the corresponding Partition list of all topics. When Topics is specified, the partition of the corresponding topic list of the specified Partitions list is reset.
        :param pulumi.Input[int] shift: This field must be included when strategy is 0. If it is greater than zero, the offset will be moved backward by shift bars, and if it is less than zero, the offset will be traced back to the number of shift entries. After the correct reset, the new offset should be (old_offset + shift). It should be noted that if the new offset is less than partition's earliest, it will be set to earliest, and if the latest greater than partition will be set to latest.
        :param pulumi.Input[int] shift_timestamp: Unit ms. When strategy is 1, you must include this field, where-2 means to reset the offset to the beginning,-1 means to reset to the latest position (equivalent to emptying), and other values represent the specified time. You will get the offset of the specified time in the topic and then reset it. If there is no message at the specified time, get the last offset.
        :param pulumi.Input[int] strategy: Reset the policy of offset.
               `0`: Move the offset forward or backward shift bar;
               `1`: Alignment reference (by-duration,to-datetime,to-earliest,to-latest), which means moving the offset to the location of the specified timestamp;
               `2`: Alignment reference (to-offset), which means to move the offset to the specified offset location.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] topics: Indicates the topics that needs to be reset. Leave it empty means all.
        """
        if group is not None:
            pulumi.set(__self__, "group", group)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if offset is not None:
            pulumi.set(__self__, "offset", offset)
        if partitions is not None:
            pulumi.set(__self__, "partitions", partitions)
        if shift is not None:
            pulumi.set(__self__, "shift", shift)
        if shift_timestamp is not None:
            pulumi.set(__self__, "shift_timestamp", shift_timestamp)
        if strategy is not None:
            pulumi.set(__self__, "strategy", strategy)
        if topics is not None:
            pulumi.set(__self__, "topics", topics)

    @property
    @pulumi.getter
    def group(self) -> Optional[pulumi.Input[str]]:
        """
        kafka group.
        """
        return pulumi.get(self, "group")

    @group.setter
    def group(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Kafka instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def offset(self) -> Optional[pulumi.Input[int]]:
        """
        The offset location that needs to be reset. When strategy is 2, this field must be included.
        """
        return pulumi.get(self, "offset")

    @offset.setter
    def offset(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "offset", value)

    @property
    @pulumi.getter
    def partitions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        The list of partition that needs to be reset if no Topics parameter is specified. Resets the partition in the corresponding Partition list of all topics. When Topics is specified, the partition of the corresponding topic list of the specified Partitions list is reset.
        """
        return pulumi.get(self, "partitions")

    @partitions.setter
    def partitions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "partitions", value)

    @property
    @pulumi.getter
    def shift(self) -> Optional[pulumi.Input[int]]:
        """
        This field must be included when strategy is 0. If it is greater than zero, the offset will be moved backward by shift bars, and if it is less than zero, the offset will be traced back to the number of shift entries. After the correct reset, the new offset should be (old_offset + shift). It should be noted that if the new offset is less than partition's earliest, it will be set to earliest, and if the latest greater than partition will be set to latest.
        """
        return pulumi.get(self, "shift")

    @shift.setter
    def shift(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "shift", value)

    @property
    @pulumi.getter(name="shiftTimestamp")
    def shift_timestamp(self) -> Optional[pulumi.Input[int]]:
        """
        Unit ms. When strategy is 1, you must include this field, where-2 means to reset the offset to the beginning,-1 means to reset to the latest position (equivalent to emptying), and other values represent the specified time. You will get the offset of the specified time in the topic and then reset it. If there is no message at the specified time, get the last offset.
        """
        return pulumi.get(self, "shift_timestamp")

    @shift_timestamp.setter
    def shift_timestamp(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "shift_timestamp", value)

    @property
    @pulumi.getter
    def strategy(self) -> Optional[pulumi.Input[int]]:
        """
        Reset the policy of offset.
        `0`: Move the offset forward or backward shift bar;
        `1`: Alignment reference (by-duration,to-datetime,to-earliest,to-latest), which means moving the offset to the location of the specified timestamp;
        `2`: Alignment reference (to-offset), which means to move the offset to the specified offset location.
        """
        return pulumi.get(self, "strategy")

    @strategy.setter
    def strategy(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "strategy", value)

    @property
    @pulumi.getter
    def topics(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Indicates the topics that needs to be reset. Leave it empty means all.
        """
        return pulumi.get(self, "topics")

    @topics.setter
    def topics(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "topics", value)


class ConsumerGroupModifyOffset(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 group: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 offset: Optional[pulumi.Input[int]] = None,
                 partitions: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 shift: Optional[pulumi.Input[int]] = None,
                 shift_timestamp: Optional[pulumi.Input[int]] = None,
                 strategy: Optional[pulumi.Input[int]] = None,
                 topics: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Provides a resource to create a ckafka consumer_group_modify_offset

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        consumer_group_modify_offset = tencentcloud.ckafka.ConsumerGroupModifyOffset("consumerGroupModifyOffset",
            group="xxxxxx",
            instance_id="ckafka-xxxxxx",
            offset=0,
            strategy=2,
            topics=["xxxxxx"])
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] group: kafka group.
        :param pulumi.Input[str] instance_id: Kafka instance id.
        :param pulumi.Input[int] offset: The offset location that needs to be reset. When strategy is 2, this field must be included.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] partitions: The list of partition that needs to be reset if no Topics parameter is specified. Resets the partition in the corresponding Partition list of all topics. When Topics is specified, the partition of the corresponding topic list of the specified Partitions list is reset.
        :param pulumi.Input[int] shift: This field must be included when strategy is 0. If it is greater than zero, the offset will be moved backward by shift bars, and if it is less than zero, the offset will be traced back to the number of shift entries. After the correct reset, the new offset should be (old_offset + shift). It should be noted that if the new offset is less than partition's earliest, it will be set to earliest, and if the latest greater than partition will be set to latest.
        :param pulumi.Input[int] shift_timestamp: Unit ms. When strategy is 1, you must include this field, where-2 means to reset the offset to the beginning,-1 means to reset to the latest position (equivalent to emptying), and other values represent the specified time. You will get the offset of the specified time in the topic and then reset it. If there is no message at the specified time, get the last offset.
        :param pulumi.Input[int] strategy: Reset the policy of offset.
               `0`: Move the offset forward or backward shift bar;
               `1`: Alignment reference (by-duration,to-datetime,to-earliest,to-latest), which means moving the offset to the location of the specified timestamp;
               `2`: Alignment reference (to-offset), which means to move the offset to the specified offset location.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] topics: Indicates the topics that needs to be reset. Leave it empty means all.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ConsumerGroupModifyOffsetArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a ckafka consumer_group_modify_offset

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        consumer_group_modify_offset = tencentcloud.ckafka.ConsumerGroupModifyOffset("consumerGroupModifyOffset",
            group="xxxxxx",
            instance_id="ckafka-xxxxxx",
            offset=0,
            strategy=2,
            topics=["xxxxxx"])
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param ConsumerGroupModifyOffsetArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ConsumerGroupModifyOffsetArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 group: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 offset: Optional[pulumi.Input[int]] = None,
                 partitions: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 shift: Optional[pulumi.Input[int]] = None,
                 shift_timestamp: Optional[pulumi.Input[int]] = None,
                 strategy: Optional[pulumi.Input[int]] = None,
                 topics: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ConsumerGroupModifyOffsetArgs.__new__(ConsumerGroupModifyOffsetArgs)

            if group is None and not opts.urn:
                raise TypeError("Missing required property 'group'")
            __props__.__dict__["group"] = group
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            __props__.__dict__["offset"] = offset
            __props__.__dict__["partitions"] = partitions
            __props__.__dict__["shift"] = shift
            __props__.__dict__["shift_timestamp"] = shift_timestamp
            if strategy is None and not opts.urn:
                raise TypeError("Missing required property 'strategy'")
            __props__.__dict__["strategy"] = strategy
            __props__.__dict__["topics"] = topics
        super(ConsumerGroupModifyOffset, __self__).__init__(
            'tencentcloud:Ckafka/consumerGroupModifyOffset:ConsumerGroupModifyOffset',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            group: Optional[pulumi.Input[str]] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            offset: Optional[pulumi.Input[int]] = None,
            partitions: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
            shift: Optional[pulumi.Input[int]] = None,
            shift_timestamp: Optional[pulumi.Input[int]] = None,
            strategy: Optional[pulumi.Input[int]] = None,
            topics: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'ConsumerGroupModifyOffset':
        """
        Get an existing ConsumerGroupModifyOffset resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] group: kafka group.
        :param pulumi.Input[str] instance_id: Kafka instance id.
        :param pulumi.Input[int] offset: The offset location that needs to be reset. When strategy is 2, this field must be included.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] partitions: The list of partition that needs to be reset if no Topics parameter is specified. Resets the partition in the corresponding Partition list of all topics. When Topics is specified, the partition of the corresponding topic list of the specified Partitions list is reset.
        :param pulumi.Input[int] shift: This field must be included when strategy is 0. If it is greater than zero, the offset will be moved backward by shift bars, and if it is less than zero, the offset will be traced back to the number of shift entries. After the correct reset, the new offset should be (old_offset + shift). It should be noted that if the new offset is less than partition's earliest, it will be set to earliest, and if the latest greater than partition will be set to latest.
        :param pulumi.Input[int] shift_timestamp: Unit ms. When strategy is 1, you must include this field, where-2 means to reset the offset to the beginning,-1 means to reset to the latest position (equivalent to emptying), and other values represent the specified time. You will get the offset of the specified time in the topic and then reset it. If there is no message at the specified time, get the last offset.
        :param pulumi.Input[int] strategy: Reset the policy of offset.
               `0`: Move the offset forward or backward shift bar;
               `1`: Alignment reference (by-duration,to-datetime,to-earliest,to-latest), which means moving the offset to the location of the specified timestamp;
               `2`: Alignment reference (to-offset), which means to move the offset to the specified offset location.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] topics: Indicates the topics that needs to be reset. Leave it empty means all.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ConsumerGroupModifyOffsetState.__new__(_ConsumerGroupModifyOffsetState)

        __props__.__dict__["group"] = group
        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["offset"] = offset
        __props__.__dict__["partitions"] = partitions
        __props__.__dict__["shift"] = shift
        __props__.__dict__["shift_timestamp"] = shift_timestamp
        __props__.__dict__["strategy"] = strategy
        __props__.__dict__["topics"] = topics
        return ConsumerGroupModifyOffset(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def group(self) -> pulumi.Output[str]:
        """
        kafka group.
        """
        return pulumi.get(self, "group")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        Kafka instance id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def offset(self) -> pulumi.Output[Optional[int]]:
        """
        The offset location that needs to be reset. When strategy is 2, this field must be included.
        """
        return pulumi.get(self, "offset")

    @property
    @pulumi.getter
    def partitions(self) -> pulumi.Output[Optional[Sequence[int]]]:
        """
        The list of partition that needs to be reset if no Topics parameter is specified. Resets the partition in the corresponding Partition list of all topics. When Topics is specified, the partition of the corresponding topic list of the specified Partitions list is reset.
        """
        return pulumi.get(self, "partitions")

    @property
    @pulumi.getter
    def shift(self) -> pulumi.Output[Optional[int]]:
        """
        This field must be included when strategy is 0. If it is greater than zero, the offset will be moved backward by shift bars, and if it is less than zero, the offset will be traced back to the number of shift entries. After the correct reset, the new offset should be (old_offset + shift). It should be noted that if the new offset is less than partition's earliest, it will be set to earliest, and if the latest greater than partition will be set to latest.
        """
        return pulumi.get(self, "shift")

    @property
    @pulumi.getter(name="shiftTimestamp")
    def shift_timestamp(self) -> pulumi.Output[Optional[int]]:
        """
        Unit ms. When strategy is 1, you must include this field, where-2 means to reset the offset to the beginning,-1 means to reset to the latest position (equivalent to emptying), and other values represent the specified time. You will get the offset of the specified time in the topic and then reset it. If there is no message at the specified time, get the last offset.
        """
        return pulumi.get(self, "shift_timestamp")

    @property
    @pulumi.getter
    def strategy(self) -> pulumi.Output[int]:
        """
        Reset the policy of offset.
        `0`: Move the offset forward or backward shift bar;
        `1`: Alignment reference (by-duration,to-datetime,to-earliest,to-latest), which means moving the offset to the location of the specified timestamp;
        `2`: Alignment reference (to-offset), which means to move the offset to the specified offset location.
        """
        return pulumi.get(self, "strategy")

    @property
    @pulumi.getter
    def topics(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Indicates the topics that needs to be reset. Leave it empty means all.
        """
        return pulumi.get(self, "topics")
