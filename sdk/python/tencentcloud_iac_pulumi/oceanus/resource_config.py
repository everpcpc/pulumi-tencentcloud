# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['ResourceConfigArgs', 'ResourceConfig']

@pulumi.input_type
class ResourceConfigArgs:
    def __init__(__self__, *,
                 resource_id: pulumi.Input[str],
                 resource_loc: pulumi.Input['ResourceConfigResourceLocArgs'],
                 remark: Optional[pulumi.Input[str]] = None,
                 work_space_id: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ResourceConfig resource.
        :param pulumi.Input[str] resource_id: Resource ID.
        :param pulumi.Input['ResourceConfigResourceLocArgs'] resource_loc: Resource location.
        :param pulumi.Input[str] remark: Resource description.
        :param pulumi.Input[str] work_space_id: Workspace SerialId.
        """
        pulumi.set(__self__, "resource_id", resource_id)
        pulumi.set(__self__, "resource_loc", resource_loc)
        if remark is not None:
            pulumi.set(__self__, "remark", remark)
        if work_space_id is not None:
            pulumi.set(__self__, "work_space_id", work_space_id)

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> pulumi.Input[str]:
        """
        Resource ID.
        """
        return pulumi.get(self, "resource_id")

    @resource_id.setter
    def resource_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_id", value)

    @property
    @pulumi.getter(name="resourceLoc")
    def resource_loc(self) -> pulumi.Input['ResourceConfigResourceLocArgs']:
        """
        Resource location.
        """
        return pulumi.get(self, "resource_loc")

    @resource_loc.setter
    def resource_loc(self, value: pulumi.Input['ResourceConfigResourceLocArgs']):
        pulumi.set(self, "resource_loc", value)

    @property
    @pulumi.getter
    def remark(self) -> Optional[pulumi.Input[str]]:
        """
        Resource description.
        """
        return pulumi.get(self, "remark")

    @remark.setter
    def remark(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "remark", value)

    @property
    @pulumi.getter(name="workSpaceId")
    def work_space_id(self) -> Optional[pulumi.Input[str]]:
        """
        Workspace SerialId.
        """
        return pulumi.get(self, "work_space_id")

    @work_space_id.setter
    def work_space_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "work_space_id", value)


@pulumi.input_type
class _ResourceConfigState:
    def __init__(__self__, *,
                 remark: Optional[pulumi.Input[str]] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 resource_loc: Optional[pulumi.Input['ResourceConfigResourceLocArgs']] = None,
                 version: Optional[pulumi.Input[int]] = None,
                 work_space_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ResourceConfig resources.
        :param pulumi.Input[str] remark: Resource description.
        :param pulumi.Input[str] resource_id: Resource ID.
        :param pulumi.Input['ResourceConfigResourceLocArgs'] resource_loc: Resource location.
        :param pulumi.Input[int] version: Resource Config Version.
        :param pulumi.Input[str] work_space_id: Workspace SerialId.
        """
        if remark is not None:
            pulumi.set(__self__, "remark", remark)
        if resource_id is not None:
            pulumi.set(__self__, "resource_id", resource_id)
        if resource_loc is not None:
            pulumi.set(__self__, "resource_loc", resource_loc)
        if version is not None:
            pulumi.set(__self__, "version", version)
        if work_space_id is not None:
            pulumi.set(__self__, "work_space_id", work_space_id)

    @property
    @pulumi.getter
    def remark(self) -> Optional[pulumi.Input[str]]:
        """
        Resource description.
        """
        return pulumi.get(self, "remark")

    @remark.setter
    def remark(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "remark", value)

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> Optional[pulumi.Input[str]]:
        """
        Resource ID.
        """
        return pulumi.get(self, "resource_id")

    @resource_id.setter
    def resource_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource_id", value)

    @property
    @pulumi.getter(name="resourceLoc")
    def resource_loc(self) -> Optional[pulumi.Input['ResourceConfigResourceLocArgs']]:
        """
        Resource location.
        """
        return pulumi.get(self, "resource_loc")

    @resource_loc.setter
    def resource_loc(self, value: Optional[pulumi.Input['ResourceConfigResourceLocArgs']]):
        pulumi.set(self, "resource_loc", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[int]]:
        """
        Resource Config Version.
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "version", value)

    @property
    @pulumi.getter(name="workSpaceId")
    def work_space_id(self) -> Optional[pulumi.Input[str]]:
        """
        Workspace SerialId.
        """
        return pulumi.get(self, "work_space_id")

    @work_space_id.setter
    def work_space_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "work_space_id", value)


class ResourceConfig(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 remark: Optional[pulumi.Input[str]] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 resource_loc: Optional[pulumi.Input[pulumi.InputType['ResourceConfigResourceLocArgs']]] = None,
                 work_space_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a oceanus resource_config

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example_resource = tencentcloud.oceanus.Resource("exampleResource",
            resource_loc=tencentcloud.oceanus.ResourceResourceLocArgs(
                storage_type=1,
                param=tencentcloud.oceanus.ResourceResourceLocParamArgs(
                    bucket="keep-terraform-1257058945",
                    path="OceanusResource/junit-4.13.1.jar",
                    region="ap-guangzhou",
                ),
            ),
            resource_type=1,
            remark="remark.",
            resource_config_remark="config remark.",
            folder_id="folder-7ctl246z",
            work_space_id="space-2idq8wbr")
        example_resource_config = tencentcloud.oceanus.ResourceConfig("exampleResourceConfig",
            resource_id=example_resource.resource_id,
            resource_loc=tencentcloud.oceanus.ResourceConfigResourceLocArgs(
                storage_type=1,
                param=tencentcloud.oceanus.ResourceConfigResourceLocParamArgs(
                    bucket="keep-terraform-1257058945",
                    path="OceanusResource/junit-4.13.2.jar",
                    region="ap-guangzhou",
                ),
            ),
            remark="config remark.",
            work_space_id="space-2idq8wbr")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] remark: Resource description.
        :param pulumi.Input[str] resource_id: Resource ID.
        :param pulumi.Input[pulumi.InputType['ResourceConfigResourceLocArgs']] resource_loc: Resource location.
        :param pulumi.Input[str] work_space_id: Workspace SerialId.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ResourceConfigArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a oceanus resource_config

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example_resource = tencentcloud.oceanus.Resource("exampleResource",
            resource_loc=tencentcloud.oceanus.ResourceResourceLocArgs(
                storage_type=1,
                param=tencentcloud.oceanus.ResourceResourceLocParamArgs(
                    bucket="keep-terraform-1257058945",
                    path="OceanusResource/junit-4.13.1.jar",
                    region="ap-guangzhou",
                ),
            ),
            resource_type=1,
            remark="remark.",
            resource_config_remark="config remark.",
            folder_id="folder-7ctl246z",
            work_space_id="space-2idq8wbr")
        example_resource_config = tencentcloud.oceanus.ResourceConfig("exampleResourceConfig",
            resource_id=example_resource.resource_id,
            resource_loc=tencentcloud.oceanus.ResourceConfigResourceLocArgs(
                storage_type=1,
                param=tencentcloud.oceanus.ResourceConfigResourceLocParamArgs(
                    bucket="keep-terraform-1257058945",
                    path="OceanusResource/junit-4.13.2.jar",
                    region="ap-guangzhou",
                ),
            ),
            remark="config remark.",
            work_space_id="space-2idq8wbr")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param ResourceConfigArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ResourceConfigArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 remark: Optional[pulumi.Input[str]] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 resource_loc: Optional[pulumi.Input[pulumi.InputType['ResourceConfigResourceLocArgs']]] = None,
                 work_space_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ResourceConfigArgs.__new__(ResourceConfigArgs)

            __props__.__dict__["remark"] = remark
            if resource_id is None and not opts.urn:
                raise TypeError("Missing required property 'resource_id'")
            __props__.__dict__["resource_id"] = resource_id
            if resource_loc is None and not opts.urn:
                raise TypeError("Missing required property 'resource_loc'")
            __props__.__dict__["resource_loc"] = resource_loc
            __props__.__dict__["work_space_id"] = work_space_id
            __props__.__dict__["version"] = None
        super(ResourceConfig, __self__).__init__(
            'tencentcloud:Oceanus/resourceConfig:ResourceConfig',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            remark: Optional[pulumi.Input[str]] = None,
            resource_id: Optional[pulumi.Input[str]] = None,
            resource_loc: Optional[pulumi.Input[pulumi.InputType['ResourceConfigResourceLocArgs']]] = None,
            version: Optional[pulumi.Input[int]] = None,
            work_space_id: Optional[pulumi.Input[str]] = None) -> 'ResourceConfig':
        """
        Get an existing ResourceConfig resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] remark: Resource description.
        :param pulumi.Input[str] resource_id: Resource ID.
        :param pulumi.Input[pulumi.InputType['ResourceConfigResourceLocArgs']] resource_loc: Resource location.
        :param pulumi.Input[int] version: Resource Config Version.
        :param pulumi.Input[str] work_space_id: Workspace SerialId.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ResourceConfigState.__new__(_ResourceConfigState)

        __props__.__dict__["remark"] = remark
        __props__.__dict__["resource_id"] = resource_id
        __props__.__dict__["resource_loc"] = resource_loc
        __props__.__dict__["version"] = version
        __props__.__dict__["work_space_id"] = work_space_id
        return ResourceConfig(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def remark(self) -> pulumi.Output[Optional[str]]:
        """
        Resource description.
        """
        return pulumi.get(self, "remark")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> pulumi.Output[str]:
        """
        Resource ID.
        """
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="resourceLoc")
    def resource_loc(self) -> pulumi.Output['outputs.ResourceConfigResourceLoc']:
        """
        Resource location.
        """
        return pulumi.get(self, "resource_loc")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[int]:
        """
        Resource Config Version.
        """
        return pulumi.get(self, "version")

    @property
    @pulumi.getter(name="workSpaceId")
    def work_space_id(self) -> pulumi.Output[Optional[str]]:
        """
        Workspace SerialId.
        """
        return pulumi.get(self, "work_space_id")

