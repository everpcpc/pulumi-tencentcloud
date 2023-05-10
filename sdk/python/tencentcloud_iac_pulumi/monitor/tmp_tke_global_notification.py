# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['TmpTkeGlobalNotificationArgs', 'TmpTkeGlobalNotification']

@pulumi.input_type
class TmpTkeGlobalNotificationArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 notification: pulumi.Input['TmpTkeGlobalNotificationNotificationArgs']):
        """
        The set of arguments for constructing a TmpTkeGlobalNotification resource.
        :param pulumi.Input[str] instance_id: Instance Id.
        :param pulumi.Input['TmpTkeGlobalNotificationNotificationArgs'] notification: Alarm notification channels.
        """
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "notification", notification)

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
    def notification(self) -> pulumi.Input['TmpTkeGlobalNotificationNotificationArgs']:
        """
        Alarm notification channels.
        """
        return pulumi.get(self, "notification")

    @notification.setter
    def notification(self, value: pulumi.Input['TmpTkeGlobalNotificationNotificationArgs']):
        pulumi.set(self, "notification", value)


@pulumi.input_type
class _TmpTkeGlobalNotificationState:
    def __init__(__self__, *,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 notification: Optional[pulumi.Input['TmpTkeGlobalNotificationNotificationArgs']] = None):
        """
        Input properties used for looking up and filtering TmpTkeGlobalNotification resources.
        :param pulumi.Input[str] instance_id: Instance Id.
        :param pulumi.Input['TmpTkeGlobalNotificationNotificationArgs'] notification: Alarm notification channels.
        """
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if notification is not None:
            pulumi.set(__self__, "notification", notification)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Instance Id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def notification(self) -> Optional[pulumi.Input['TmpTkeGlobalNotificationNotificationArgs']]:
        """
        Alarm notification channels.
        """
        return pulumi.get(self, "notification")

    @notification.setter
    def notification(self, value: Optional[pulumi.Input['TmpTkeGlobalNotificationNotificationArgs']]):
        pulumi.set(self, "notification", value)


class TmpTkeGlobalNotification(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 notification: Optional[pulumi.Input[pulumi.InputType['TmpTkeGlobalNotificationNotificationArgs']]] = None,
                 __props__=None):
        """
        Provides a resource to create a tmp tke global notification

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        basic = tencentcloud.monitor.TmpTkeGlobalNotification("basic",
            instance_id="prom-xxxxxx",
            notification=tencentcloud.monitor.TmpTkeGlobalNotificationNotificationArgs(
                alert_managers=[tencentcloud.monitor.TmpTkeGlobalNotificationNotificationAlertManagerArgs(
                    cluster_id="",
                    cluster_type="",
                    url="",
                )],
                enabled=True,
                notify_ways=[
                    "SMS",
                    "EMAIL",
                ],
                phone_arrive_notice=False,
                phone_circle_interval=0,
                phone_circle_times=0,
                phone_inner_interval=0,
                phone_notify_orders=[],
                receiver_groups=[],
                repeat_interval="5m",
                time_range_end="23:59:59",
                time_range_start="00:00:00",
                type="webhook",
                web_hook="",
            ))
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: Instance Id.
        :param pulumi.Input[pulumi.InputType['TmpTkeGlobalNotificationNotificationArgs']] notification: Alarm notification channels.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: TmpTkeGlobalNotificationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a tmp tke global notification

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        basic = tencentcloud.monitor.TmpTkeGlobalNotification("basic",
            instance_id="prom-xxxxxx",
            notification=tencentcloud.monitor.TmpTkeGlobalNotificationNotificationArgs(
                alert_managers=[tencentcloud.monitor.TmpTkeGlobalNotificationNotificationAlertManagerArgs(
                    cluster_id="",
                    cluster_type="",
                    url="",
                )],
                enabled=True,
                notify_ways=[
                    "SMS",
                    "EMAIL",
                ],
                phone_arrive_notice=False,
                phone_circle_interval=0,
                phone_circle_times=0,
                phone_inner_interval=0,
                phone_notify_orders=[],
                receiver_groups=[],
                repeat_interval="5m",
                time_range_end="23:59:59",
                time_range_start="00:00:00",
                type="webhook",
                web_hook="",
            ))
        ```

        :param str resource_name: The name of the resource.
        :param TmpTkeGlobalNotificationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(TmpTkeGlobalNotificationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 notification: Optional[pulumi.Input[pulumi.InputType['TmpTkeGlobalNotificationNotificationArgs']]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = TmpTkeGlobalNotificationArgs.__new__(TmpTkeGlobalNotificationArgs)

            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            if notification is None and not opts.urn:
                raise TypeError("Missing required property 'notification'")
            __props__.__dict__["notification"] = notification
        super(TmpTkeGlobalNotification, __self__).__init__(
            'tencentcloud:Monitor/tmpTkeGlobalNotification:TmpTkeGlobalNotification',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            notification: Optional[pulumi.Input[pulumi.InputType['TmpTkeGlobalNotificationNotificationArgs']]] = None) -> 'TmpTkeGlobalNotification':
        """
        Get an existing TmpTkeGlobalNotification resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: Instance Id.
        :param pulumi.Input[pulumi.InputType['TmpTkeGlobalNotificationNotificationArgs']] notification: Alarm notification channels.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _TmpTkeGlobalNotificationState.__new__(_TmpTkeGlobalNotificationState)

        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["notification"] = notification
        return TmpTkeGlobalNotification(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        Instance Id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def notification(self) -> pulumi.Output['outputs.TmpTkeGlobalNotificationNotification']:
        """
        Alarm notification channels.
        """
        return pulumi.get(self, "notification")
