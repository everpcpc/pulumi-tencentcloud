# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['SwitchDataEngineImageOperationArgs', 'SwitchDataEngineImageOperation']

@pulumi.input_type
class SwitchDataEngineImageOperationArgs:
    def __init__(__self__, *,
                 data_engine_id: pulumi.Input[str],
                 new_image_version_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a SwitchDataEngineImageOperation resource.
        :param pulumi.Input[str] data_engine_id: Engine unique id.
        :param pulumi.Input[str] new_image_version_id: New image version id.
        """
        pulumi.set(__self__, "data_engine_id", data_engine_id)
        pulumi.set(__self__, "new_image_version_id", new_image_version_id)

    @property
    @pulumi.getter(name="dataEngineId")
    def data_engine_id(self) -> pulumi.Input[str]:
        """
        Engine unique id.
        """
        return pulumi.get(self, "data_engine_id")

    @data_engine_id.setter
    def data_engine_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "data_engine_id", value)

    @property
    @pulumi.getter(name="newImageVersionId")
    def new_image_version_id(self) -> pulumi.Input[str]:
        """
        New image version id.
        """
        return pulumi.get(self, "new_image_version_id")

    @new_image_version_id.setter
    def new_image_version_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "new_image_version_id", value)


@pulumi.input_type
class _SwitchDataEngineImageOperationState:
    def __init__(__self__, *,
                 data_engine_id: Optional[pulumi.Input[str]] = None,
                 new_image_version_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering SwitchDataEngineImageOperation resources.
        :param pulumi.Input[str] data_engine_id: Engine unique id.
        :param pulumi.Input[str] new_image_version_id: New image version id.
        """
        if data_engine_id is not None:
            pulumi.set(__self__, "data_engine_id", data_engine_id)
        if new_image_version_id is not None:
            pulumi.set(__self__, "new_image_version_id", new_image_version_id)

    @property
    @pulumi.getter(name="dataEngineId")
    def data_engine_id(self) -> Optional[pulumi.Input[str]]:
        """
        Engine unique id.
        """
        return pulumi.get(self, "data_engine_id")

    @data_engine_id.setter
    def data_engine_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "data_engine_id", value)

    @property
    @pulumi.getter(name="newImageVersionId")
    def new_image_version_id(self) -> Optional[pulumi.Input[str]]:
        """
        New image version id.
        """
        return pulumi.get(self, "new_image_version_id")

    @new_image_version_id.setter
    def new_image_version_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "new_image_version_id", value)


class SwitchDataEngineImageOperation(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 data_engine_id: Optional[pulumi.Input[str]] = None,
                 new_image_version_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a dlc switch_data_engine_image_operation

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        switch_data_engine_image_operation = tencentcloud.dlc.SwitchDataEngineImageOperation("switchDataEngineImageOperation",
            data_engine_id="DataEngine-g5ds87d8",
            new_image_version_id="344ba1c6-b7a9-403a-a255-422fffed6d38")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] data_engine_id: Engine unique id.
        :param pulumi.Input[str] new_image_version_id: New image version id.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SwitchDataEngineImageOperationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a dlc switch_data_engine_image_operation

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        switch_data_engine_image_operation = tencentcloud.dlc.SwitchDataEngineImageOperation("switchDataEngineImageOperation",
            data_engine_id="DataEngine-g5ds87d8",
            new_image_version_id="344ba1c6-b7a9-403a-a255-422fffed6d38")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param SwitchDataEngineImageOperationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SwitchDataEngineImageOperationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 data_engine_id: Optional[pulumi.Input[str]] = None,
                 new_image_version_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SwitchDataEngineImageOperationArgs.__new__(SwitchDataEngineImageOperationArgs)

            if data_engine_id is None and not opts.urn:
                raise TypeError("Missing required property 'data_engine_id'")
            __props__.__dict__["data_engine_id"] = data_engine_id
            if new_image_version_id is None and not opts.urn:
                raise TypeError("Missing required property 'new_image_version_id'")
            __props__.__dict__["new_image_version_id"] = new_image_version_id
        super(SwitchDataEngineImageOperation, __self__).__init__(
            'tencentcloud:Dlc/switchDataEngineImageOperation:SwitchDataEngineImageOperation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            data_engine_id: Optional[pulumi.Input[str]] = None,
            new_image_version_id: Optional[pulumi.Input[str]] = None) -> 'SwitchDataEngineImageOperation':
        """
        Get an existing SwitchDataEngineImageOperation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] data_engine_id: Engine unique id.
        :param pulumi.Input[str] new_image_version_id: New image version id.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SwitchDataEngineImageOperationState.__new__(_SwitchDataEngineImageOperationState)

        __props__.__dict__["data_engine_id"] = data_engine_id
        __props__.__dict__["new_image_version_id"] = new_image_version_id
        return SwitchDataEngineImageOperation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dataEngineId")
    def data_engine_id(self) -> pulumi.Output[str]:
        """
        Engine unique id.
        """
        return pulumi.get(self, "data_engine_id")

    @property
    @pulumi.getter(name="newImageVersionId")
    def new_image_version_id(self) -> pulumi.Output[str]:
        """
        New image version id.
        """
        return pulumi.get(self, "new_image_version_id")

