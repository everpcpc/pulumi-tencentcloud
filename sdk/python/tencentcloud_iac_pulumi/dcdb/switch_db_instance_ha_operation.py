# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['SwitchDbInstanceHaOperationArgs', 'SwitchDbInstanceHaOperation']

@pulumi.input_type
class SwitchDbInstanceHaOperationArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 zone: pulumi.Input[str]):
        """
        The set of arguments for constructing a SwitchDbInstanceHaOperation resource.
        :param pulumi.Input[str] instance_id: Instance ID in the format of tdsqlshard-ow728lmc.
        :param pulumi.Input[str] zone: Target AZ. The node with the lowest delay in the target AZ will be automatically promoted to primary node.
        """
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        Instance ID in the format of tdsqlshard-ow728lmc.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def zone(self) -> pulumi.Input[str]:
        """
        Target AZ. The node with the lowest delay in the target AZ will be automatically promoted to primary node.
        """
        return pulumi.get(self, "zone")

    @zone.setter
    def zone(self, value: pulumi.Input[str]):
        pulumi.set(self, "zone", value)


@pulumi.input_type
class _SwitchDbInstanceHaOperationState:
    def __init__(__self__, *,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering SwitchDbInstanceHaOperation resources.
        :param pulumi.Input[str] instance_id: Instance ID in the format of tdsqlshard-ow728lmc.
        :param pulumi.Input[str] zone: Target AZ. The node with the lowest delay in the target AZ will be automatically promoted to primary node.
        """
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if zone is not None:
            pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Instance ID in the format of tdsqlshard-ow728lmc.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def zone(self) -> Optional[pulumi.Input[str]]:
        """
        Target AZ. The node with the lowest delay in the target AZ will be automatically promoted to primary node.
        """
        return pulumi.get(self, "zone")

    @zone.setter
    def zone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zone", value)


class SwitchDbInstanceHaOperation(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a dcdb switch_db_instance_ha_operation

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        switch_operation = tencentcloud.dcdb.SwitchDbInstanceHaOperation("switchOperation",
            instance_id=local["dcdb_id"],
            zone="ap-guangzhou-4")
        #3 to 4
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: Instance ID in the format of tdsqlshard-ow728lmc.
        :param pulumi.Input[str] zone: Target AZ. The node with the lowest delay in the target AZ will be automatically promoted to primary node.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SwitchDbInstanceHaOperationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a dcdb switch_db_instance_ha_operation

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        switch_operation = tencentcloud.dcdb.SwitchDbInstanceHaOperation("switchOperation",
            instance_id=local["dcdb_id"],
            zone="ap-guangzhou-4")
        #3 to 4
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param SwitchDbInstanceHaOperationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SwitchDbInstanceHaOperationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SwitchDbInstanceHaOperationArgs.__new__(SwitchDbInstanceHaOperationArgs)

            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            if zone is None and not opts.urn:
                raise TypeError("Missing required property 'zone'")
            __props__.__dict__["zone"] = zone
        super(SwitchDbInstanceHaOperation, __self__).__init__(
            'tencentcloud:Dcdb/switchDbInstanceHaOperation:SwitchDbInstanceHaOperation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            zone: Optional[pulumi.Input[str]] = None) -> 'SwitchDbInstanceHaOperation':
        """
        Get an existing SwitchDbInstanceHaOperation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: Instance ID in the format of tdsqlshard-ow728lmc.
        :param pulumi.Input[str] zone: Target AZ. The node with the lowest delay in the target AZ will be automatically promoted to primary node.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SwitchDbInstanceHaOperationState.__new__(_SwitchDbInstanceHaOperationState)

        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["zone"] = zone
        return SwitchDbInstanceHaOperation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        Instance ID in the format of tdsqlshard-ow728lmc.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def zone(self) -> pulumi.Output[str]:
        """
        Target AZ. The node with the lowest delay in the target AZ will be automatically promoted to primary node.
        """
        return pulumi.get(self, "zone")
