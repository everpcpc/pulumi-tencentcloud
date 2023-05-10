# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'PlayDomainCertAttachmentDomainInfoArgs',
    'PullStreamTaskWatermarkListArgs',
]

@pulumi.input_type
class PlayDomainCertAttachmentDomainInfoArgs:
    def __init__(__self__, *,
                 domain_name: pulumi.Input[str],
                 status: pulumi.Input[int]):
        """
        :param pulumi.Input[str] domain_name: domain name.
        :param pulumi.Input[int] status: Whether to enable the https rule for the domain name. 1: enable, 0: disabled, -1: remain unchanged.
        """
        pulumi.set(__self__, "domain_name", domain_name)
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> pulumi.Input[str]:
        """
        domain name.
        """
        return pulumi.get(self, "domain_name")

    @domain_name.setter
    def domain_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "domain_name", value)

    @property
    @pulumi.getter
    def status(self) -> pulumi.Input[int]:
        """
        Whether to enable the https rule for the domain name. 1: enable, 0: disabled, -1: remain unchanged.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: pulumi.Input[int]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class PullStreamTaskWatermarkListArgs:
    def __init__(__self__, *,
                 height: pulumi.Input[int],
                 location: pulumi.Input[int],
                 picture_url: pulumi.Input[str],
                 width: pulumi.Input[int],
                 x_position: pulumi.Input[int],
                 y_position: pulumi.Input[int]):
        """
        :param pulumi.Input[int] height: pic height.
        :param pulumi.Input[int] location: position type, 0:left top, 1:right top, 2:right bot, 3: left bot.
        :param pulumi.Input[str] picture_url: watermark picture url.
        :param pulumi.Input[int] width: pic width.
        :param pulumi.Input[int] x_position: x position.
        :param pulumi.Input[int] y_position: y position.
        """
        pulumi.set(__self__, "height", height)
        pulumi.set(__self__, "location", location)
        pulumi.set(__self__, "picture_url", picture_url)
        pulumi.set(__self__, "width", width)
        pulumi.set(__self__, "x_position", x_position)
        pulumi.set(__self__, "y_position", y_position)

    @property
    @pulumi.getter
    def height(self) -> pulumi.Input[int]:
        """
        pic height.
        """
        return pulumi.get(self, "height")

    @height.setter
    def height(self, value: pulumi.Input[int]):
        pulumi.set(self, "height", value)

    @property
    @pulumi.getter
    def location(self) -> pulumi.Input[int]:
        """
        position type, 0:left top, 1:right top, 2:right bot, 3: left bot.
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: pulumi.Input[int]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter(name="pictureUrl")
    def picture_url(self) -> pulumi.Input[str]:
        """
        watermark picture url.
        """
        return pulumi.get(self, "picture_url")

    @picture_url.setter
    def picture_url(self, value: pulumi.Input[str]):
        pulumi.set(self, "picture_url", value)

    @property
    @pulumi.getter
    def width(self) -> pulumi.Input[int]:
        """
        pic width.
        """
        return pulumi.get(self, "width")

    @width.setter
    def width(self, value: pulumi.Input[int]):
        pulumi.set(self, "width", value)

    @property
    @pulumi.getter(name="xPosition")
    def x_position(self) -> pulumi.Input[int]:
        """
        x position.
        """
        return pulumi.get(self, "x_position")

    @x_position.setter
    def x_position(self, value: pulumi.Input[int]):
        pulumi.set(self, "x_position", value)

    @property
    @pulumi.getter(name="yPosition")
    def y_position(self) -> pulumi.Input[int]:
        """
        y position.
        """
        return pulumi.get(self, "y_position")

    @y_position.setter
    def y_position(self, value: pulumi.Input[int]):
        pulumi.set(self, "y_position", value)

