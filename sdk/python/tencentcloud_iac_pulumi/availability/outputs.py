# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetRegionsRegionResult',
    'GetZonesByProductZoneResult',
]

@pulumi.output_type
class GetRegionsRegionResult(dict):
    def __init__(__self__, *,
                 description: str,
                 name: str,
                 state: str):
        """
        :param str description: The description of the region, like `Guangzhou Region`.
        :param str name: When specified, only the region with the exactly name match will be returned. `default` value means it consistent with the provider region.
        :param str state: The state of the region, indicate availability using `AVAILABLE` and `UNAVAILABLE` values.
        """
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The description of the region, like `Guangzhou Region`.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        When specified, only the region with the exactly name match will be returned. `default` value means it consistent with the provider region.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def state(self) -> str:
        """
        The state of the region, indicate availability using `AVAILABLE` and `UNAVAILABLE` values.
        """
        return pulumi.get(self, "state")


@pulumi.output_type
class GetZonesByProductZoneResult(dict):
    def __init__(__self__, *,
                 description: str,
                 id: str,
                 name: str,
                 state: str):
        """
        :param str description: The description of the zone, like `Guangzhou Zone 3`.
        :param str id: An internal id for the zone, like `200003`, usually not so useful.
        :param str name: When specified, only the zone with the exactly name match will be returned.
        :param str state: The state of the zone, indicate availability using `AVAILABLE` and `UNAVAILABLE` values.
        """
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The description of the zone, like `Guangzhou Zone 3`.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        An internal id for the zone, like `200003`, usually not so useful.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        When specified, only the zone with the exactly name match will be returned.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def state(self) -> str:
        """
        The state of the zone, indicate availability using `AVAILABLE` and `UNAVAILABLE` values.
        """
        return pulumi.get(self, "state")

