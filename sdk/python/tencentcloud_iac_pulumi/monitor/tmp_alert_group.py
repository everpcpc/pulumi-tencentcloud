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

__all__ = ['TmpAlertGroupArgs', 'TmpAlertGroup']

@pulumi.input_type
class TmpAlertGroupArgs:
    def __init__(__self__, *,
                 amp_receivers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 custom_receiver: Optional[pulumi.Input['TmpAlertGroupCustomReceiverArgs']] = None,
                 group_name: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 repeat_interval: Optional[pulumi.Input[str]] = None,
                 rules: Optional[pulumi.Input[Sequence[pulumi.Input['TmpAlertGroupRuleArgs']]]] = None):
        """
        The set of arguments for constructing a TmpAlertGroup resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] amp_receivers: Tencent cloud notification template id list.
        :param pulumi.Input['TmpAlertGroupCustomReceiverArgs'] custom_receiver: User custom notification template, such as webhook, alertmanager.
        :param pulumi.Input[str] group_name: Unique alert group name.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input[str] repeat_interval: Alert message send interval, default 1 hour.
        :param pulumi.Input[Sequence[pulumi.Input['TmpAlertGroupRuleArgs']]] rules: A list of alert rules.
        """
        if amp_receivers is not None:
            pulumi.set(__self__, "amp_receivers", amp_receivers)
        if custom_receiver is not None:
            pulumi.set(__self__, "custom_receiver", custom_receiver)
        if group_name is not None:
            pulumi.set(__self__, "group_name", group_name)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if repeat_interval is not None:
            pulumi.set(__self__, "repeat_interval", repeat_interval)
        if rules is not None:
            pulumi.set(__self__, "rules", rules)

    @property
    @pulumi.getter(name="ampReceivers")
    def amp_receivers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Tencent cloud notification template id list.
        """
        return pulumi.get(self, "amp_receivers")

    @amp_receivers.setter
    def amp_receivers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "amp_receivers", value)

    @property
    @pulumi.getter(name="customReceiver")
    def custom_receiver(self) -> Optional[pulumi.Input['TmpAlertGroupCustomReceiverArgs']]:
        """
        User custom notification template, such as webhook, alertmanager.
        """
        return pulumi.get(self, "custom_receiver")

    @custom_receiver.setter
    def custom_receiver(self, value: Optional[pulumi.Input['TmpAlertGroupCustomReceiverArgs']]):
        pulumi.set(self, "custom_receiver", value)

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> Optional[pulumi.Input[str]]:
        """
        Unique alert group name.
        """
        return pulumi.get(self, "group_name")

    @group_name.setter
    def group_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group_name", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="repeatInterval")
    def repeat_interval(self) -> Optional[pulumi.Input[str]]:
        """
        Alert message send interval, default 1 hour.
        """
        return pulumi.get(self, "repeat_interval")

    @repeat_interval.setter
    def repeat_interval(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "repeat_interval", value)

    @property
    @pulumi.getter
    def rules(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TmpAlertGroupRuleArgs']]]]:
        """
        A list of alert rules.
        """
        return pulumi.get(self, "rules")

    @rules.setter
    def rules(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TmpAlertGroupRuleArgs']]]]):
        pulumi.set(self, "rules", value)


@pulumi.input_type
class _TmpAlertGroupState:
    def __init__(__self__, *,
                 amp_receivers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 custom_receiver: Optional[pulumi.Input['TmpAlertGroupCustomReceiverArgs']] = None,
                 group_id: Optional[pulumi.Input[str]] = None,
                 group_name: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 repeat_interval: Optional[pulumi.Input[str]] = None,
                 rules: Optional[pulumi.Input[Sequence[pulumi.Input['TmpAlertGroupRuleArgs']]]] = None):
        """
        Input properties used for looking up and filtering TmpAlertGroup resources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] amp_receivers: Tencent cloud notification template id list.
        :param pulumi.Input['TmpAlertGroupCustomReceiverArgs'] custom_receiver: User custom notification template, such as webhook, alertmanager.
        :param pulumi.Input[str] group_id: Alarm group id.
        :param pulumi.Input[str] group_name: Unique alert group name.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input[str] repeat_interval: Alert message send interval, default 1 hour.
        :param pulumi.Input[Sequence[pulumi.Input['TmpAlertGroupRuleArgs']]] rules: A list of alert rules.
        """
        if amp_receivers is not None:
            pulumi.set(__self__, "amp_receivers", amp_receivers)
        if custom_receiver is not None:
            pulumi.set(__self__, "custom_receiver", custom_receiver)
        if group_id is not None:
            pulumi.set(__self__, "group_id", group_id)
        if group_name is not None:
            pulumi.set(__self__, "group_name", group_name)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if repeat_interval is not None:
            pulumi.set(__self__, "repeat_interval", repeat_interval)
        if rules is not None:
            pulumi.set(__self__, "rules", rules)

    @property
    @pulumi.getter(name="ampReceivers")
    def amp_receivers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Tencent cloud notification template id list.
        """
        return pulumi.get(self, "amp_receivers")

    @amp_receivers.setter
    def amp_receivers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "amp_receivers", value)

    @property
    @pulumi.getter(name="customReceiver")
    def custom_receiver(self) -> Optional[pulumi.Input['TmpAlertGroupCustomReceiverArgs']]:
        """
        User custom notification template, such as webhook, alertmanager.
        """
        return pulumi.get(self, "custom_receiver")

    @custom_receiver.setter
    def custom_receiver(self, value: Optional[pulumi.Input['TmpAlertGroupCustomReceiverArgs']]):
        pulumi.set(self, "custom_receiver", value)

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> Optional[pulumi.Input[str]]:
        """
        Alarm group id.
        """
        return pulumi.get(self, "group_id")

    @group_id.setter
    def group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group_id", value)

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> Optional[pulumi.Input[str]]:
        """
        Unique alert group name.
        """
        return pulumi.get(self, "group_name")

    @group_name.setter
    def group_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group_name", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="repeatInterval")
    def repeat_interval(self) -> Optional[pulumi.Input[str]]:
        """
        Alert message send interval, default 1 hour.
        """
        return pulumi.get(self, "repeat_interval")

    @repeat_interval.setter
    def repeat_interval(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "repeat_interval", value)

    @property
    @pulumi.getter
    def rules(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TmpAlertGroupRuleArgs']]]]:
        """
        A list of alert rules.
        """
        return pulumi.get(self, "rules")

    @rules.setter
    def rules(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TmpAlertGroupRuleArgs']]]]):
        pulumi.set(self, "rules", value)


class TmpAlertGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 amp_receivers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 custom_receiver: Optional[pulumi.Input[pulumi.InputType['TmpAlertGroupCustomReceiverArgs']]] = None,
                 group_name: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 repeat_interval: Optional[pulumi.Input[str]] = None,
                 rules: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TmpAlertGroupRuleArgs']]]]] = None,
                 __props__=None):
        """
        Provides a resource to create a monitor tmp_alert_group

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        tmp_alert_group = tencentcloud.monitor.TmpAlertGroup("tmpAlertGroup",
            amp_receivers=["notice-om017kc2"],
            custom_receiver=tencentcloud.monitor.TmpAlertGroupCustomReceiverArgs(
                type="amp",
            ),
            group_name="tf-test",
            instance_id="prom-ip429jis",
            repeat_interval="5m",
            rules=[tencentcloud.monitor.TmpAlertGroupRuleArgs(
                annotations={
                    "description": "Agent {{$labels.instance}} is deactivated, please pay attention!",
                    "summary": "Agent health check",
                },
                duration="1m",
                expr="up{job=\\"prometheus-agent\\"} != 1",
                labels={
                    "severity": "critical",
                },
                rule_name="Agent health check",
                state=2,
            )])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        monitor tmp_alert_group can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Monitor/tmpAlertGroup:TmpAlertGroup tmp_alert_group instance_id#group_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] amp_receivers: Tencent cloud notification template id list.
        :param pulumi.Input[pulumi.InputType['TmpAlertGroupCustomReceiverArgs']] custom_receiver: User custom notification template, such as webhook, alertmanager.
        :param pulumi.Input[str] group_name: Unique alert group name.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input[str] repeat_interval: Alert message send interval, default 1 hour.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TmpAlertGroupRuleArgs']]]] rules: A list of alert rules.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[TmpAlertGroupArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a monitor tmp_alert_group

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        tmp_alert_group = tencentcloud.monitor.TmpAlertGroup("tmpAlertGroup",
            amp_receivers=["notice-om017kc2"],
            custom_receiver=tencentcloud.monitor.TmpAlertGroupCustomReceiverArgs(
                type="amp",
            ),
            group_name="tf-test",
            instance_id="prom-ip429jis",
            repeat_interval="5m",
            rules=[tencentcloud.monitor.TmpAlertGroupRuleArgs(
                annotations={
                    "description": "Agent {{$labels.instance}} is deactivated, please pay attention!",
                    "summary": "Agent health check",
                },
                duration="1m",
                expr="up{job=\\"prometheus-agent\\"} != 1",
                labels={
                    "severity": "critical",
                },
                rule_name="Agent health check",
                state=2,
            )])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        monitor tmp_alert_group can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Monitor/tmpAlertGroup:TmpAlertGroup tmp_alert_group instance_id#group_id
        ```

        :param str resource_name: The name of the resource.
        :param TmpAlertGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(TmpAlertGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 amp_receivers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 custom_receiver: Optional[pulumi.Input[pulumi.InputType['TmpAlertGroupCustomReceiverArgs']]] = None,
                 group_name: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 repeat_interval: Optional[pulumi.Input[str]] = None,
                 rules: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TmpAlertGroupRuleArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = TmpAlertGroupArgs.__new__(TmpAlertGroupArgs)

            __props__.__dict__["amp_receivers"] = amp_receivers
            __props__.__dict__["custom_receiver"] = custom_receiver
            __props__.__dict__["group_name"] = group_name
            __props__.__dict__["instance_id"] = instance_id
            __props__.__dict__["repeat_interval"] = repeat_interval
            __props__.__dict__["rules"] = rules
            __props__.__dict__["group_id"] = None
        super(TmpAlertGroup, __self__).__init__(
            'tencentcloud:Monitor/tmpAlertGroup:TmpAlertGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            amp_receivers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            custom_receiver: Optional[pulumi.Input[pulumi.InputType['TmpAlertGroupCustomReceiverArgs']]] = None,
            group_id: Optional[pulumi.Input[str]] = None,
            group_name: Optional[pulumi.Input[str]] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            repeat_interval: Optional[pulumi.Input[str]] = None,
            rules: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TmpAlertGroupRuleArgs']]]]] = None) -> 'TmpAlertGroup':
        """
        Get an existing TmpAlertGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] amp_receivers: Tencent cloud notification template id list.
        :param pulumi.Input[pulumi.InputType['TmpAlertGroupCustomReceiverArgs']] custom_receiver: User custom notification template, such as webhook, alertmanager.
        :param pulumi.Input[str] group_id: Alarm group id.
        :param pulumi.Input[str] group_name: Unique alert group name.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input[str] repeat_interval: Alert message send interval, default 1 hour.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TmpAlertGroupRuleArgs']]]] rules: A list of alert rules.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _TmpAlertGroupState.__new__(_TmpAlertGroupState)

        __props__.__dict__["amp_receivers"] = amp_receivers
        __props__.__dict__["custom_receiver"] = custom_receiver
        __props__.__dict__["group_id"] = group_id
        __props__.__dict__["group_name"] = group_name
        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["repeat_interval"] = repeat_interval
        __props__.__dict__["rules"] = rules
        return TmpAlertGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="ampReceivers")
    def amp_receivers(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Tencent cloud notification template id list.
        """
        return pulumi.get(self, "amp_receivers")

    @property
    @pulumi.getter(name="customReceiver")
    def custom_receiver(self) -> pulumi.Output[Optional['outputs.TmpAlertGroupCustomReceiver']]:
        """
        User custom notification template, such as webhook, alertmanager.
        """
        return pulumi.get(self, "custom_receiver")

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> pulumi.Output[str]:
        """
        Alarm group id.
        """
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> pulumi.Output[Optional[str]]:
        """
        Unique alert group name.
        """
        return pulumi.get(self, "group_name")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[Optional[str]]:
        """
        Instance id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="repeatInterval")
    def repeat_interval(self) -> pulumi.Output[Optional[str]]:
        """
        Alert message send interval, default 1 hour.
        """
        return pulumi.get(self, "repeat_interval")

    @property
    @pulumi.getter
    def rules(self) -> pulumi.Output[Optional[Sequence['outputs.TmpAlertGroupRule']]]:
        """
        A list of alert rules.
        """
        return pulumi.get(self, "rules")
