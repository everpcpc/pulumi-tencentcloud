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

__all__ = ['ServerlessNodePoolArgs', 'ServerlessNodePool']

@pulumi.input_type
class ServerlessNodePoolArgs:
    def __init__(__self__, *,
                 cluster_id: pulumi.Input[str],
                 serverless_nodes: pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolServerlessNodeArgs']]],
                 labels: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 taints: Optional[pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolTaintArgs']]]] = None):
        """
        The set of arguments for constructing a ServerlessNodePool resource.
        :param pulumi.Input[str] cluster_id: cluster id of serverless node pool.
        :param pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolServerlessNodeArgs']]] serverless_nodes: node list of serverless node pool.
        :param pulumi.Input[Mapping[str, Any]] labels: labels of serverless node.
        :param pulumi.Input[str] name: serverless node pool name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] security_group_ids: security groups of serverless node pool.
        :param pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolTaintArgs']]] taints: taints of serverless node.
        """
        pulumi.set(__self__, "cluster_id", cluster_id)
        pulumi.set(__self__, "serverless_nodes", serverless_nodes)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if security_group_ids is not None:
            pulumi.set(__self__, "security_group_ids", security_group_ids)
        if taints is not None:
            pulumi.set(__self__, "taints", taints)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Input[str]:
        """
        cluster id of serverless node pool.
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter(name="serverlessNodes")
    def serverless_nodes(self) -> pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolServerlessNodeArgs']]]:
        """
        node list of serverless node pool.
        """
        return pulumi.get(self, "serverless_nodes")

    @serverless_nodes.setter
    def serverless_nodes(self, value: pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolServerlessNodeArgs']]]):
        pulumi.set(self, "serverless_nodes", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        labels of serverless node.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        serverless node pool name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        security groups of serverless node pool.
        """
        return pulumi.get(self, "security_group_ids")

    @security_group_ids.setter
    def security_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "security_group_ids", value)

    @property
    @pulumi.getter
    def taints(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolTaintArgs']]]]:
        """
        taints of serverless node.
        """
        return pulumi.get(self, "taints")

    @taints.setter
    def taints(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolTaintArgs']]]]):
        pulumi.set(self, "taints", value)


@pulumi.input_type
class _ServerlessNodePoolState:
    def __init__(__self__, *,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 life_state: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 serverless_nodes: Optional[pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolServerlessNodeArgs']]]] = None,
                 taints: Optional[pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolTaintArgs']]]] = None):
        """
        Input properties used for looking up and filtering ServerlessNodePool resources.
        :param pulumi.Input[str] cluster_id: cluster id of serverless node pool.
        :param pulumi.Input[Mapping[str, Any]] labels: labels of serverless node.
        :param pulumi.Input[str] life_state: life state of serverless node pool.
        :param pulumi.Input[str] name: serverless node pool name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] security_group_ids: security groups of serverless node pool.
        :param pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolServerlessNodeArgs']]] serverless_nodes: node list of serverless node pool.
        :param pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolTaintArgs']]] taints: taints of serverless node.
        """
        if cluster_id is not None:
            pulumi.set(__self__, "cluster_id", cluster_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if life_state is not None:
            pulumi.set(__self__, "life_state", life_state)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if security_group_ids is not None:
            pulumi.set(__self__, "security_group_ids", security_group_ids)
        if serverless_nodes is not None:
            pulumi.set(__self__, "serverless_nodes", serverless_nodes)
        if taints is not None:
            pulumi.set(__self__, "taints", taints)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> Optional[pulumi.Input[str]]:
        """
        cluster id of serverless node pool.
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        labels of serverless node.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter(name="lifeState")
    def life_state(self) -> Optional[pulumi.Input[str]]:
        """
        life state of serverless node pool.
        """
        return pulumi.get(self, "life_state")

    @life_state.setter
    def life_state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "life_state", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        serverless node pool name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        security groups of serverless node pool.
        """
        return pulumi.get(self, "security_group_ids")

    @security_group_ids.setter
    def security_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "security_group_ids", value)

    @property
    @pulumi.getter(name="serverlessNodes")
    def serverless_nodes(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolServerlessNodeArgs']]]]:
        """
        node list of serverless node pool.
        """
        return pulumi.get(self, "serverless_nodes")

    @serverless_nodes.setter
    def serverless_nodes(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolServerlessNodeArgs']]]]):
        pulumi.set(self, "serverless_nodes", value)

    @property
    @pulumi.getter
    def taints(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolTaintArgs']]]]:
        """
        taints of serverless node.
        """
        return pulumi.get(self, "taints")

    @taints.setter
    def taints(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ServerlessNodePoolTaintArgs']]]]):
        pulumi.set(self, "taints", value)


class ServerlessNodePool(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 serverless_nodes: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServerlessNodePoolServerlessNodeArgs']]]]] = None,
                 taints: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServerlessNodePoolTaintArgs']]]]] = None,
                 __props__=None):
        """
        Provide a resource to create serverless node pool of cluster.

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example_serverless_node_pool = tencentcloud.kubernetes.ServerlessNodePool("exampleServerlessNodePool",
            cluster_id=tencentcloud_kubernetes_cluster["example"]["id"],
            serverless_nodes=[
                tencentcloud.kubernetes.ServerlessNodePoolServerlessNodeArgs(
                    display_name="serverless_node1",
                    subnet_id="subnet-xxx",
                ),
                tencentcloud.kubernetes.ServerlessNodePoolServerlessNodeArgs(
                    display_name="serverless_node2",
                    subnet_id="subnet-xxx",
                ),
            ],
            security_group_ids=["sg-xxx"],
            labels={
                "example1": "test1",
                "example2": "test2",
            })
        ```

        ## Import

        serverless node pool can be imported, e.g.

        ```sh
         $ pulumi import tencentcloud:Kubernetes/serverlessNodePool:ServerlessNodePool test cls-xxx#np-xxx
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_id: cluster id of serverless node pool.
        :param pulumi.Input[Mapping[str, Any]] labels: labels of serverless node.
        :param pulumi.Input[str] name: serverless node pool name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] security_group_ids: security groups of serverless node pool.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServerlessNodePoolServerlessNodeArgs']]]] serverless_nodes: node list of serverless node pool.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServerlessNodePoolTaintArgs']]]] taints: taints of serverless node.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ServerlessNodePoolArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provide a resource to create serverless node pool of cluster.

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example_serverless_node_pool = tencentcloud.kubernetes.ServerlessNodePool("exampleServerlessNodePool",
            cluster_id=tencentcloud_kubernetes_cluster["example"]["id"],
            serverless_nodes=[
                tencentcloud.kubernetes.ServerlessNodePoolServerlessNodeArgs(
                    display_name="serverless_node1",
                    subnet_id="subnet-xxx",
                ),
                tencentcloud.kubernetes.ServerlessNodePoolServerlessNodeArgs(
                    display_name="serverless_node2",
                    subnet_id="subnet-xxx",
                ),
            ],
            security_group_ids=["sg-xxx"],
            labels={
                "example1": "test1",
                "example2": "test2",
            })
        ```

        ## Import

        serverless node pool can be imported, e.g.

        ```sh
         $ pulumi import tencentcloud:Kubernetes/serverlessNodePool:ServerlessNodePool test cls-xxx#np-xxx
        ```

        :param str resource_name: The name of the resource.
        :param ServerlessNodePoolArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ServerlessNodePoolArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 serverless_nodes: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServerlessNodePoolServerlessNodeArgs']]]]] = None,
                 taints: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServerlessNodePoolTaintArgs']]]]] = None,
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
            __props__ = ServerlessNodePoolArgs.__new__(ServerlessNodePoolArgs)

            if cluster_id is None and not opts.urn:
                raise TypeError("Missing required property 'cluster_id'")
            __props__.__dict__["cluster_id"] = cluster_id
            __props__.__dict__["labels"] = labels
            __props__.__dict__["name"] = name
            __props__.__dict__["security_group_ids"] = security_group_ids
            if serverless_nodes is None and not opts.urn:
                raise TypeError("Missing required property 'serverless_nodes'")
            __props__.__dict__["serverless_nodes"] = serverless_nodes
            __props__.__dict__["taints"] = taints
            __props__.__dict__["life_state"] = None
        super(ServerlessNodePool, __self__).__init__(
            'tencentcloud:Kubernetes/serverlessNodePool:ServerlessNodePool',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cluster_id: Optional[pulumi.Input[str]] = None,
            labels: Optional[pulumi.Input[Mapping[str, Any]]] = None,
            life_state: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            serverless_nodes: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServerlessNodePoolServerlessNodeArgs']]]]] = None,
            taints: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServerlessNodePoolTaintArgs']]]]] = None) -> 'ServerlessNodePool':
        """
        Get an existing ServerlessNodePool resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_id: cluster id of serverless node pool.
        :param pulumi.Input[Mapping[str, Any]] labels: labels of serverless node.
        :param pulumi.Input[str] life_state: life state of serverless node pool.
        :param pulumi.Input[str] name: serverless node pool name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] security_group_ids: security groups of serverless node pool.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServerlessNodePoolServerlessNodeArgs']]]] serverless_nodes: node list of serverless node pool.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServerlessNodePoolTaintArgs']]]] taints: taints of serverless node.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ServerlessNodePoolState.__new__(_ServerlessNodePoolState)

        __props__.__dict__["cluster_id"] = cluster_id
        __props__.__dict__["labels"] = labels
        __props__.__dict__["life_state"] = life_state
        __props__.__dict__["name"] = name
        __props__.__dict__["security_group_ids"] = security_group_ids
        __props__.__dict__["serverless_nodes"] = serverless_nodes
        __props__.__dict__["taints"] = taints
        return ServerlessNodePool(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Output[str]:
        """
        cluster id of serverless node pool.
        """
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, Any]]]:
        """
        labels of serverless node.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="lifeState")
    def life_state(self) -> pulumi.Output[str]:
        """
        life state of serverless node pool.
        """
        return pulumi.get(self, "life_state")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        serverless node pool name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        security groups of serverless node pool.
        """
        return pulumi.get(self, "security_group_ids")

    @property
    @pulumi.getter(name="serverlessNodes")
    def serverless_nodes(self) -> pulumi.Output[Sequence['outputs.ServerlessNodePoolServerlessNode']]:
        """
        node list of serverless node pool.
        """
        return pulumi.get(self, "serverless_nodes")

    @property
    @pulumi.getter
    def taints(self) -> pulumi.Output[Optional[Sequence['outputs.ServerlessNodePoolTaint']]]:
        """
        taints of serverless node.
        """
        return pulumi.get(self, "taints")
