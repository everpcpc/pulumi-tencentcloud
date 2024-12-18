# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['GrafanaPluginArgs', 'GrafanaPlugin']

@pulumi.input_type
class GrafanaPluginArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 plugin_id: pulumi.Input[str],
                 version: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a GrafanaPlugin resource.
        :param pulumi.Input[str] instance_id: Grafana instance id.
        :param pulumi.Input[str] plugin_id: Plugin id.
        :param pulumi.Input[str] version: Plugin version.
        """
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "plugin_id", plugin_id)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        Grafana instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="pluginId")
    def plugin_id(self) -> pulumi.Input[str]:
        """
        Plugin id.
        """
        return pulumi.get(self, "plugin_id")

    @plugin_id.setter
    def plugin_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "plugin_id", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Plugin version.
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


@pulumi.input_type
class _GrafanaPluginState:
    def __init__(__self__, *,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 plugin_id: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering GrafanaPlugin resources.
        :param pulumi.Input[str] instance_id: Grafana instance id.
        :param pulumi.Input[str] plugin_id: Plugin id.
        :param pulumi.Input[str] version: Plugin version.
        """
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if plugin_id is not None:
            pulumi.set(__self__, "plugin_id", plugin_id)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Grafana instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="pluginId")
    def plugin_id(self) -> Optional[pulumi.Input[str]]:
        """
        Plugin id.
        """
        return pulumi.get(self, "plugin_id")

    @plugin_id.setter
    def plugin_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "plugin_id", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Plugin version.
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


class GrafanaPlugin(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 plugin_id: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a monitor grafanaPlugin

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        config = pulumi.Config()
        availability_zone = config.get("availabilityZone")
        if availability_zone is None:
            availability_zone = "ap-guangzhou-6"
        vpc = tencentcloud.vpc.Instance("vpc", cidr_block="10.0.0.0/16")
        subnet = tencentcloud.subnet.Instance("subnet",
            vpc_id=vpc.id,
            availability_zone=availability_zone,
            cidr_block="10.0.1.0/24")
        foo = tencentcloud.monitor.GrafanaInstance("foo",
            instance_name="test-grafana",
            vpc_id=vpc.id,
            subnet_ids=[subnet.id],
            grafana_init_password="1234567890",
            enable_internet=False,
            tags={
                "createdBy": "test",
            })
        grafana_plugin = tencentcloud.monitor.GrafanaPlugin("grafanaPlugin",
            instance_id=foo.id,
            plugin_id="grafana-piechart-panel",
            version="1.6.2")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        monitor grafanaPlugin can be imported using the instance_id#plugin_id, e.g.

        ```sh
        $ pulumi import tencentcloud:Monitor/grafanaPlugin:GrafanaPlugin grafanaPlugin grafana-50nj6v00#grafana-piechart-panel
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: Grafana instance id.
        :param pulumi.Input[str] plugin_id: Plugin id.
        :param pulumi.Input[str] version: Plugin version.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: GrafanaPluginArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a monitor grafanaPlugin

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        config = pulumi.Config()
        availability_zone = config.get("availabilityZone")
        if availability_zone is None:
            availability_zone = "ap-guangzhou-6"
        vpc = tencentcloud.vpc.Instance("vpc", cidr_block="10.0.0.0/16")
        subnet = tencentcloud.subnet.Instance("subnet",
            vpc_id=vpc.id,
            availability_zone=availability_zone,
            cidr_block="10.0.1.0/24")
        foo = tencentcloud.monitor.GrafanaInstance("foo",
            instance_name="test-grafana",
            vpc_id=vpc.id,
            subnet_ids=[subnet.id],
            grafana_init_password="1234567890",
            enable_internet=False,
            tags={
                "createdBy": "test",
            })
        grafana_plugin = tencentcloud.monitor.GrafanaPlugin("grafanaPlugin",
            instance_id=foo.id,
            plugin_id="grafana-piechart-panel",
            version="1.6.2")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        monitor grafanaPlugin can be imported using the instance_id#plugin_id, e.g.

        ```sh
        $ pulumi import tencentcloud:Monitor/grafanaPlugin:GrafanaPlugin grafanaPlugin grafana-50nj6v00#grafana-piechart-panel
        ```

        :param str resource_name: The name of the resource.
        :param GrafanaPluginArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(GrafanaPluginArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 plugin_id: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = GrafanaPluginArgs.__new__(GrafanaPluginArgs)

            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            if plugin_id is None and not opts.urn:
                raise TypeError("Missing required property 'plugin_id'")
            __props__.__dict__["plugin_id"] = plugin_id
            __props__.__dict__["version"] = version
        super(GrafanaPlugin, __self__).__init__(
            'tencentcloud:Monitor/grafanaPlugin:GrafanaPlugin',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            plugin_id: Optional[pulumi.Input[str]] = None,
            version: Optional[pulumi.Input[str]] = None) -> 'GrafanaPlugin':
        """
        Get an existing GrafanaPlugin resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: Grafana instance id.
        :param pulumi.Input[str] plugin_id: Plugin id.
        :param pulumi.Input[str] version: Plugin version.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _GrafanaPluginState.__new__(_GrafanaPluginState)

        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["plugin_id"] = plugin_id
        __props__.__dict__["version"] = version
        return GrafanaPlugin(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        Grafana instance id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="pluginId")
    def plugin_id(self) -> pulumi.Output[str]:
        """
        Plugin id.
        """
        return pulumi.get(self, "plugin_id")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[str]:
        """
        Plugin version.
        """
        return pulumi.get(self, "version")

