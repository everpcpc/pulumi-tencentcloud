# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['InvokeFunctionArgs', 'InvokeFunction']

@pulumi.input_type
class InvokeFunctionArgs:
    def __init__(__self__, *,
                 function_name: pulumi.Input[str],
                 client_context: Optional[pulumi.Input[str]] = None,
                 invocation_type: Optional[pulumi.Input[str]] = None,
                 log_type: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 qualifier: Optional[pulumi.Input[str]] = None,
                 routing_key: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a InvokeFunction resource.
        :param pulumi.Input[str] function_name: Function name.
        :param pulumi.Input[str] client_context: Function running parameter, which is in the JSON format. The maximum parameter size is 6 MB for synchronized invocations and 128KB for asynchronized invocations. This field corresponds to event input parameter.
        :param pulumi.Input[str] invocation_type: Fill in RequestResponse for synchronized invocations (default and recommended) and Event for asychronized invocations. Note that for synchronized invocations, the max timeout period is 300s. Choose asychronized invocations if the required timeout period is longer than 300 seconds. You can also use InvokeFunction for synchronized invocations.
        :param pulumi.Input[str] log_type: Null for async invocations.
        :param pulumi.Input[str] namespace: Namespace.
        :param pulumi.Input[str] qualifier: The version or alias of the triggered function. It defaults to $LATEST.
        :param pulumi.Input[str] routing_key: Traffic routing config in json format, e.g., {k:v}. Please note that both k and v must be strings. Up to 1024 bytes allowed.
        """
        pulumi.set(__self__, "function_name", function_name)
        if client_context is not None:
            pulumi.set(__self__, "client_context", client_context)
        if invocation_type is not None:
            pulumi.set(__self__, "invocation_type", invocation_type)
        if log_type is not None:
            pulumi.set(__self__, "log_type", log_type)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)
        if qualifier is not None:
            pulumi.set(__self__, "qualifier", qualifier)
        if routing_key is not None:
            pulumi.set(__self__, "routing_key", routing_key)

    @property
    @pulumi.getter(name="functionName")
    def function_name(self) -> pulumi.Input[str]:
        """
        Function name.
        """
        return pulumi.get(self, "function_name")

    @function_name.setter
    def function_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "function_name", value)

    @property
    @pulumi.getter(name="clientContext")
    def client_context(self) -> Optional[pulumi.Input[str]]:
        """
        Function running parameter, which is in the JSON format. The maximum parameter size is 6 MB for synchronized invocations and 128KB for asynchronized invocations. This field corresponds to event input parameter.
        """
        return pulumi.get(self, "client_context")

    @client_context.setter
    def client_context(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "client_context", value)

    @property
    @pulumi.getter(name="invocationType")
    def invocation_type(self) -> Optional[pulumi.Input[str]]:
        """
        Fill in RequestResponse for synchronized invocations (default and recommended) and Event for asychronized invocations. Note that for synchronized invocations, the max timeout period is 300s. Choose asychronized invocations if the required timeout period is longer than 300 seconds. You can also use InvokeFunction for synchronized invocations.
        """
        return pulumi.get(self, "invocation_type")

    @invocation_type.setter
    def invocation_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "invocation_type", value)

    @property
    @pulumi.getter(name="logType")
    def log_type(self) -> Optional[pulumi.Input[str]]:
        """
        Null for async invocations.
        """
        return pulumi.get(self, "log_type")

    @log_type.setter
    def log_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "log_type", value)

    @property
    @pulumi.getter
    def namespace(self) -> Optional[pulumi.Input[str]]:
        """
        Namespace.
        """
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "namespace", value)

    @property
    @pulumi.getter
    def qualifier(self) -> Optional[pulumi.Input[str]]:
        """
        The version or alias of the triggered function. It defaults to $LATEST.
        """
        return pulumi.get(self, "qualifier")

    @qualifier.setter
    def qualifier(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "qualifier", value)

    @property
    @pulumi.getter(name="routingKey")
    def routing_key(self) -> Optional[pulumi.Input[str]]:
        """
        Traffic routing config in json format, e.g., {k:v}. Please note that both k and v must be strings. Up to 1024 bytes allowed.
        """
        return pulumi.get(self, "routing_key")

    @routing_key.setter
    def routing_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "routing_key", value)


@pulumi.input_type
class _InvokeFunctionState:
    def __init__(__self__, *,
                 client_context: Optional[pulumi.Input[str]] = None,
                 function_name: Optional[pulumi.Input[str]] = None,
                 invocation_type: Optional[pulumi.Input[str]] = None,
                 log_type: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 qualifier: Optional[pulumi.Input[str]] = None,
                 routing_key: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering InvokeFunction resources.
        :param pulumi.Input[str] client_context: Function running parameter, which is in the JSON format. The maximum parameter size is 6 MB for synchronized invocations and 128KB for asynchronized invocations. This field corresponds to event input parameter.
        :param pulumi.Input[str] function_name: Function name.
        :param pulumi.Input[str] invocation_type: Fill in RequestResponse for synchronized invocations (default and recommended) and Event for asychronized invocations. Note that for synchronized invocations, the max timeout period is 300s. Choose asychronized invocations if the required timeout period is longer than 300 seconds. You can also use InvokeFunction for synchronized invocations.
        :param pulumi.Input[str] log_type: Null for async invocations.
        :param pulumi.Input[str] namespace: Namespace.
        :param pulumi.Input[str] qualifier: The version or alias of the triggered function. It defaults to $LATEST.
        :param pulumi.Input[str] routing_key: Traffic routing config in json format, e.g., {k:v}. Please note that both k and v must be strings. Up to 1024 bytes allowed.
        """
        if client_context is not None:
            pulumi.set(__self__, "client_context", client_context)
        if function_name is not None:
            pulumi.set(__self__, "function_name", function_name)
        if invocation_type is not None:
            pulumi.set(__self__, "invocation_type", invocation_type)
        if log_type is not None:
            pulumi.set(__self__, "log_type", log_type)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)
        if qualifier is not None:
            pulumi.set(__self__, "qualifier", qualifier)
        if routing_key is not None:
            pulumi.set(__self__, "routing_key", routing_key)

    @property
    @pulumi.getter(name="clientContext")
    def client_context(self) -> Optional[pulumi.Input[str]]:
        """
        Function running parameter, which is in the JSON format. The maximum parameter size is 6 MB for synchronized invocations and 128KB for asynchronized invocations. This field corresponds to event input parameter.
        """
        return pulumi.get(self, "client_context")

    @client_context.setter
    def client_context(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "client_context", value)

    @property
    @pulumi.getter(name="functionName")
    def function_name(self) -> Optional[pulumi.Input[str]]:
        """
        Function name.
        """
        return pulumi.get(self, "function_name")

    @function_name.setter
    def function_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "function_name", value)

    @property
    @pulumi.getter(name="invocationType")
    def invocation_type(self) -> Optional[pulumi.Input[str]]:
        """
        Fill in RequestResponse for synchronized invocations (default and recommended) and Event for asychronized invocations. Note that for synchronized invocations, the max timeout period is 300s. Choose asychronized invocations if the required timeout period is longer than 300 seconds. You can also use InvokeFunction for synchronized invocations.
        """
        return pulumi.get(self, "invocation_type")

    @invocation_type.setter
    def invocation_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "invocation_type", value)

    @property
    @pulumi.getter(name="logType")
    def log_type(self) -> Optional[pulumi.Input[str]]:
        """
        Null for async invocations.
        """
        return pulumi.get(self, "log_type")

    @log_type.setter
    def log_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "log_type", value)

    @property
    @pulumi.getter
    def namespace(self) -> Optional[pulumi.Input[str]]:
        """
        Namespace.
        """
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "namespace", value)

    @property
    @pulumi.getter
    def qualifier(self) -> Optional[pulumi.Input[str]]:
        """
        The version or alias of the triggered function. It defaults to $LATEST.
        """
        return pulumi.get(self, "qualifier")

    @qualifier.setter
    def qualifier(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "qualifier", value)

    @property
    @pulumi.getter(name="routingKey")
    def routing_key(self) -> Optional[pulumi.Input[str]]:
        """
        Traffic routing config in json format, e.g., {k:v}. Please note that both k and v must be strings. Up to 1024 bytes allowed.
        """
        return pulumi.get(self, "routing_key")

    @routing_key.setter
    def routing_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "routing_key", value)


class InvokeFunction(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 client_context: Optional[pulumi.Input[str]] = None,
                 function_name: Optional[pulumi.Input[str]] = None,
                 invocation_type: Optional[pulumi.Input[str]] = None,
                 log_type: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 qualifier: Optional[pulumi.Input[str]] = None,
                 routing_key: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a scf invoke_function

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        invoke_function = tencentcloud.scf.InvokeFunction("invokeFunction",
            function_name="keep-1676351130",
            namespace="default",
            qualifier="2")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] client_context: Function running parameter, which is in the JSON format. The maximum parameter size is 6 MB for synchronized invocations and 128KB for asynchronized invocations. This field corresponds to event input parameter.
        :param pulumi.Input[str] function_name: Function name.
        :param pulumi.Input[str] invocation_type: Fill in RequestResponse for synchronized invocations (default and recommended) and Event for asychronized invocations. Note that for synchronized invocations, the max timeout period is 300s. Choose asychronized invocations if the required timeout period is longer than 300 seconds. You can also use InvokeFunction for synchronized invocations.
        :param pulumi.Input[str] log_type: Null for async invocations.
        :param pulumi.Input[str] namespace: Namespace.
        :param pulumi.Input[str] qualifier: The version or alias of the triggered function. It defaults to $LATEST.
        :param pulumi.Input[str] routing_key: Traffic routing config in json format, e.g., {k:v}. Please note that both k and v must be strings. Up to 1024 bytes allowed.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: InvokeFunctionArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a scf invoke_function

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        invoke_function = tencentcloud.scf.InvokeFunction("invokeFunction",
            function_name="keep-1676351130",
            namespace="default",
            qualifier="2")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param InvokeFunctionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(InvokeFunctionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 client_context: Optional[pulumi.Input[str]] = None,
                 function_name: Optional[pulumi.Input[str]] = None,
                 invocation_type: Optional[pulumi.Input[str]] = None,
                 log_type: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 qualifier: Optional[pulumi.Input[str]] = None,
                 routing_key: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = InvokeFunctionArgs.__new__(InvokeFunctionArgs)

            __props__.__dict__["client_context"] = client_context
            if function_name is None and not opts.urn:
                raise TypeError("Missing required property 'function_name'")
            __props__.__dict__["function_name"] = function_name
            __props__.__dict__["invocation_type"] = invocation_type
            __props__.__dict__["log_type"] = log_type
            __props__.__dict__["namespace"] = namespace
            __props__.__dict__["qualifier"] = qualifier
            __props__.__dict__["routing_key"] = routing_key
        super(InvokeFunction, __self__).__init__(
            'tencentcloud:Scf/invokeFunction:InvokeFunction',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            client_context: Optional[pulumi.Input[str]] = None,
            function_name: Optional[pulumi.Input[str]] = None,
            invocation_type: Optional[pulumi.Input[str]] = None,
            log_type: Optional[pulumi.Input[str]] = None,
            namespace: Optional[pulumi.Input[str]] = None,
            qualifier: Optional[pulumi.Input[str]] = None,
            routing_key: Optional[pulumi.Input[str]] = None) -> 'InvokeFunction':
        """
        Get an existing InvokeFunction resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] client_context: Function running parameter, which is in the JSON format. The maximum parameter size is 6 MB for synchronized invocations and 128KB for asynchronized invocations. This field corresponds to event input parameter.
        :param pulumi.Input[str] function_name: Function name.
        :param pulumi.Input[str] invocation_type: Fill in RequestResponse for synchronized invocations (default and recommended) and Event for asychronized invocations. Note that for synchronized invocations, the max timeout period is 300s. Choose asychronized invocations if the required timeout period is longer than 300 seconds. You can also use InvokeFunction for synchronized invocations.
        :param pulumi.Input[str] log_type: Null for async invocations.
        :param pulumi.Input[str] namespace: Namespace.
        :param pulumi.Input[str] qualifier: The version or alias of the triggered function. It defaults to $LATEST.
        :param pulumi.Input[str] routing_key: Traffic routing config in json format, e.g., {k:v}. Please note that both k and v must be strings. Up to 1024 bytes allowed.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _InvokeFunctionState.__new__(_InvokeFunctionState)

        __props__.__dict__["client_context"] = client_context
        __props__.__dict__["function_name"] = function_name
        __props__.__dict__["invocation_type"] = invocation_type
        __props__.__dict__["log_type"] = log_type
        __props__.__dict__["namespace"] = namespace
        __props__.__dict__["qualifier"] = qualifier
        __props__.__dict__["routing_key"] = routing_key
        return InvokeFunction(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="clientContext")
    def client_context(self) -> pulumi.Output[Optional[str]]:
        """
        Function running parameter, which is in the JSON format. The maximum parameter size is 6 MB for synchronized invocations and 128KB for asynchronized invocations. This field corresponds to event input parameter.
        """
        return pulumi.get(self, "client_context")

    @property
    @pulumi.getter(name="functionName")
    def function_name(self) -> pulumi.Output[str]:
        """
        Function name.
        """
        return pulumi.get(self, "function_name")

    @property
    @pulumi.getter(name="invocationType")
    def invocation_type(self) -> pulumi.Output[Optional[str]]:
        """
        Fill in RequestResponse for synchronized invocations (default and recommended) and Event for asychronized invocations. Note that for synchronized invocations, the max timeout period is 300s. Choose asychronized invocations if the required timeout period is longer than 300 seconds. You can also use InvokeFunction for synchronized invocations.
        """
        return pulumi.get(self, "invocation_type")

    @property
    @pulumi.getter(name="logType")
    def log_type(self) -> pulumi.Output[Optional[str]]:
        """
        Null for async invocations.
        """
        return pulumi.get(self, "log_type")

    @property
    @pulumi.getter
    def namespace(self) -> pulumi.Output[Optional[str]]:
        """
        Namespace.
        """
        return pulumi.get(self, "namespace")

    @property
    @pulumi.getter
    def qualifier(self) -> pulumi.Output[Optional[str]]:
        """
        The version or alias of the triggered function. It defaults to $LATEST.
        """
        return pulumi.get(self, "qualifier")

    @property
    @pulumi.getter(name="routingKey")
    def routing_key(self) -> pulumi.Output[Optional[str]]:
        """
        Traffic routing config in json format, e.g., {k:v}. Please note that both k and v must be strings. Up to 1024 bytes allowed.
        """
        return pulumi.get(self, "routing_key")
