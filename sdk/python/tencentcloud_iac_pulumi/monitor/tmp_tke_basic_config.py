# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['TmpTkeBasicConfigArgs', 'TmpTkeBasicConfig']

@pulumi.input_type
class TmpTkeBasicConfigArgs:
    def __init__(__self__, *,
                 cluster_id: pulumi.Input[str],
                 cluster_type: pulumi.Input[str],
                 instance_id: pulumi.Input[str],
                 metrics_names: pulumi.Input[Sequence[pulumi.Input[str]]],
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a TmpTkeBasicConfig resource.
        :param pulumi.Input[str] cluster_id: ID of cluster.
        :param pulumi.Input[str] cluster_type: Type of cluster.
        :param pulumi.Input[str] instance_id: ID of instance.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] metrics_names: Configure the name of the metric to keep on.
        :param pulumi.Input[str] name: Name. The naming rule is: namespace/name. If you don&#39;t have any namespace, use the default namespace: kube-system, otherwise use the specified one.
        """
        pulumi.set(__self__, "cluster_id", cluster_id)
        pulumi.set(__self__, "cluster_type", cluster_type)
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "metrics_names", metrics_names)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Input[str]:
        """
        ID of cluster.
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter(name="clusterType")
    def cluster_type(self) -> pulumi.Input[str]:
        """
        Type of cluster.
        """
        return pulumi.get(self, "cluster_type")

    @cluster_type.setter
    def cluster_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "cluster_type", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        ID of instance.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="metricsNames")
    def metrics_names(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        Configure the name of the metric to keep on.
        """
        return pulumi.get(self, "metrics_names")

    @metrics_names.setter
    def metrics_names(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "metrics_names", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name. The naming rule is: namespace/name. If you don&#39;t have any namespace, use the default namespace: kube-system, otherwise use the specified one.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _TmpTkeBasicConfigState:
    def __init__(__self__, *,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 cluster_type: Optional[pulumi.Input[str]] = None,
                 config: Optional[pulumi.Input[str]] = None,
                 config_type: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 metrics_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering TmpTkeBasicConfig resources.
        :param pulumi.Input[str] cluster_id: ID of cluster.
        :param pulumi.Input[str] cluster_type: Type of cluster.
        :param pulumi.Input[str] config: Full configuration in yaml format.
        :param pulumi.Input[str] config_type: config type, `service_monitors`, `pod_monitors`, `raw_jobs`.
        :param pulumi.Input[str] instance_id: ID of instance.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] metrics_names: Configure the name of the metric to keep on.
        :param pulumi.Input[str] name: Name. The naming rule is: namespace/name. If you don&#39;t have any namespace, use the default namespace: kube-system, otherwise use the specified one.
        """
        if cluster_id is not None:
            pulumi.set(__self__, "cluster_id", cluster_id)
        if cluster_type is not None:
            pulumi.set(__self__, "cluster_type", cluster_type)
        if config is not None:
            pulumi.set(__self__, "config", config)
        if config_type is not None:
            pulumi.set(__self__, "config_type", config_type)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if metrics_names is not None:
            pulumi.set(__self__, "metrics_names", metrics_names)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of cluster.
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter(name="clusterType")
    def cluster_type(self) -> Optional[pulumi.Input[str]]:
        """
        Type of cluster.
        """
        return pulumi.get(self, "cluster_type")

    @cluster_type.setter
    def cluster_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_type", value)

    @property
    @pulumi.getter
    def config(self) -> Optional[pulumi.Input[str]]:
        """
        Full configuration in yaml format.
        """
        return pulumi.get(self, "config")

    @config.setter
    def config(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "config", value)

    @property
    @pulumi.getter(name="configType")
    def config_type(self) -> Optional[pulumi.Input[str]]:
        """
        config type, `service_monitors`, `pod_monitors`, `raw_jobs`.
        """
        return pulumi.get(self, "config_type")

    @config_type.setter
    def config_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "config_type", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of instance.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="metricsNames")
    def metrics_names(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Configure the name of the metric to keep on.
        """
        return pulumi.get(self, "metrics_names")

    @metrics_names.setter
    def metrics_names(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "metrics_names", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name. The naming rule is: namespace/name. If you don&#39;t have any namespace, use the default namespace: kube-system, otherwise use the specified one.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


class TmpTkeBasicConfig(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 cluster_type: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 metrics_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a monitor tmp_tke_basic_config

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        tmp_tke_basic_config = tencentcloud.monitor.TmpTkeBasicConfig("tmpTkeBasicConfig",
            cluster_id="cls-xxxxxx",
            cluster_type="eks",
            instance_id="prom-xxxxxx",
            metrics_names=["kube_job_status_succeeded"])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_id: ID of cluster.
        :param pulumi.Input[str] cluster_type: Type of cluster.
        :param pulumi.Input[str] instance_id: ID of instance.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] metrics_names: Configure the name of the metric to keep on.
        :param pulumi.Input[str] name: Name. The naming rule is: namespace/name. If you don&#39;t have any namespace, use the default namespace: kube-system, otherwise use the specified one.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: TmpTkeBasicConfigArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a monitor tmp_tke_basic_config

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        tmp_tke_basic_config = tencentcloud.monitor.TmpTkeBasicConfig("tmpTkeBasicConfig",
            cluster_id="cls-xxxxxx",
            cluster_type="eks",
            instance_id="prom-xxxxxx",
            metrics_names=["kube_job_status_succeeded"])
        ```

        :param str resource_name: The name of the resource.
        :param TmpTkeBasicConfigArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(TmpTkeBasicConfigArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 cluster_type: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 metrics_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
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
            __props__ = TmpTkeBasicConfigArgs.__new__(TmpTkeBasicConfigArgs)

            if cluster_id is None and not opts.urn:
                raise TypeError("Missing required property 'cluster_id'")
            __props__.__dict__["cluster_id"] = cluster_id
            if cluster_type is None and not opts.urn:
                raise TypeError("Missing required property 'cluster_type'")
            __props__.__dict__["cluster_type"] = cluster_type
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            if metrics_names is None and not opts.urn:
                raise TypeError("Missing required property 'metrics_names'")
            __props__.__dict__["metrics_names"] = metrics_names
            __props__.__dict__["name"] = name
            __props__.__dict__["config"] = None
            __props__.__dict__["config_type"] = None
        super(TmpTkeBasicConfig, __self__).__init__(
            'tencentcloud:Monitor/tmpTkeBasicConfig:TmpTkeBasicConfig',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cluster_id: Optional[pulumi.Input[str]] = None,
            cluster_type: Optional[pulumi.Input[str]] = None,
            config: Optional[pulumi.Input[str]] = None,
            config_type: Optional[pulumi.Input[str]] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            metrics_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None) -> 'TmpTkeBasicConfig':
        """
        Get an existing TmpTkeBasicConfig resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_id: ID of cluster.
        :param pulumi.Input[str] cluster_type: Type of cluster.
        :param pulumi.Input[str] config: Full configuration in yaml format.
        :param pulumi.Input[str] config_type: config type, `service_monitors`, `pod_monitors`, `raw_jobs`.
        :param pulumi.Input[str] instance_id: ID of instance.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] metrics_names: Configure the name of the metric to keep on.
        :param pulumi.Input[str] name: Name. The naming rule is: namespace/name. If you don&#39;t have any namespace, use the default namespace: kube-system, otherwise use the specified one.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _TmpTkeBasicConfigState.__new__(_TmpTkeBasicConfigState)

        __props__.__dict__["cluster_id"] = cluster_id
        __props__.__dict__["cluster_type"] = cluster_type
        __props__.__dict__["config"] = config
        __props__.__dict__["config_type"] = config_type
        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["metrics_names"] = metrics_names
        __props__.__dict__["name"] = name
        return TmpTkeBasicConfig(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Output[str]:
        """
        ID of cluster.
        """
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter(name="clusterType")
    def cluster_type(self) -> pulumi.Output[str]:
        """
        Type of cluster.
        """
        return pulumi.get(self, "cluster_type")

    @property
    @pulumi.getter
    def config(self) -> pulumi.Output[str]:
        """
        Full configuration in yaml format.
        """
        return pulumi.get(self, "config")

    @property
    @pulumi.getter(name="configType")
    def config_type(self) -> pulumi.Output[str]:
        """
        config type, `service_monitors`, `pod_monitors`, `raw_jobs`.
        """
        return pulumi.get(self, "config_type")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        ID of instance.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="metricsNames")
    def metrics_names(self) -> pulumi.Output[Sequence[str]]:
        """
        Configure the name of the metric to keep on.
        """
        return pulumi.get(self, "metrics_names")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name. The naming rule is: namespace/name. If you don&#39;t have any namespace, use the default namespace: kube-system, otherwise use the specified one.
        """
        return pulumi.get(self, "name")
