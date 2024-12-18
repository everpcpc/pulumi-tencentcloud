# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'DatasourceCloudServiceTypeArgs',
]

@pulumi.input_type
class DatasourceCloudServiceTypeArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 region: pulumi.Input[str],
                 type: pulumi.Input[str]):
        """
        :param pulumi.Input[str] instance_id: Instance Id.
        :param pulumi.Input[str] region: Region.
        :param pulumi.Input[str] type: Service type, Cloud.
        """
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "region", region)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        Instance Id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def region(self) -> pulumi.Input[str]:
        """
        Region.
        """
        return pulumi.get(self, "region")

    @region.setter
    def region(self, value: pulumi.Input[str]):
        pulumi.set(self, "region", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Service type, Cloud.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)


