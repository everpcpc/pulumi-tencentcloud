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

__all__ = ['VpcPolicyArgs', 'VpcPolicy']

@pulumi.input_type
class VpcPolicyArgs:
    def __init__(__self__, *,
                 description: pulumi.Input[str],
                 dest_content: pulumi.Input[str],
                 dest_type: pulumi.Input[str],
                 port: pulumi.Input[str],
                 protocol: pulumi.Input[str],
                 rule_action: pulumi.Input[str],
                 source_content: pulumi.Input[str],
                 source_type: pulumi.Input[str],
                 enable: Optional[pulumi.Input[str]] = None,
                 fw_group_id: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a VpcPolicy resource.
        :param pulumi.Input[str] description: Describe.
        :param pulumi.Input[str] dest_content: Access purpose example: net:IP/CIDR(192.168.0.2) domain:domain rule, for example*.qq.com.
        :param pulumi.Input[str] dest_type: Access purpose type, the type can be: net, template.
        :param pulumi.Input[str] port: The port for the access control policy. Value: -1/-1: All ports; 80: port 80.
        :param pulumi.Input[str] protocol: Protocol, optional value:TCP, UDP, ICMP, ANY, HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL.
        :param pulumi.Input[str] rule_action: How traffic set in the access control policy passes through the cloud firewall. Value: accept:accept, drop:drop, log:log.
        :param pulumi.Input[str] source_content: Access source examplnet:IP/CIDR(192.168.0.2).
        :param pulumi.Input[str] source_type: Access source type, the type can be: net, template.
        :param pulumi.Input[str] enable: Rule status, true means enabled, false means disabled. Default is true.
        :param pulumi.Input[str] fw_group_id: Firewall instance ID where the rule takes effect. Default is ALL.
        """
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "dest_content", dest_content)
        pulumi.set(__self__, "dest_type", dest_type)
        pulumi.set(__self__, "port", port)
        pulumi.set(__self__, "protocol", protocol)
        pulumi.set(__self__, "rule_action", rule_action)
        pulumi.set(__self__, "source_content", source_content)
        pulumi.set(__self__, "source_type", source_type)
        if enable is not None:
            pulumi.set(__self__, "enable", enable)
        if fw_group_id is not None:
            pulumi.set(__self__, "fw_group_id", fw_group_id)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Input[str]:
        """
        Describe.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: pulumi.Input[str]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="destContent")
    def dest_content(self) -> pulumi.Input[str]:
        """
        Access purpose example: net:IP/CIDR(192.168.0.2) domain:domain rule, for example*.qq.com.
        """
        return pulumi.get(self, "dest_content")

    @dest_content.setter
    def dest_content(self, value: pulumi.Input[str]):
        pulumi.set(self, "dest_content", value)

    @property
    @pulumi.getter(name="destType")
    def dest_type(self) -> pulumi.Input[str]:
        """
        Access purpose type, the type can be: net, template.
        """
        return pulumi.get(self, "dest_type")

    @dest_type.setter
    def dest_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "dest_type", value)

    @property
    @pulumi.getter
    def port(self) -> pulumi.Input[str]:
        """
        The port for the access control policy. Value: -1/-1: All ports; 80: port 80.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: pulumi.Input[str]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter
    def protocol(self) -> pulumi.Input[str]:
        """
        Protocol, optional value:TCP, UDP, ICMP, ANY, HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL.
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: pulumi.Input[str]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter(name="ruleAction")
    def rule_action(self) -> pulumi.Input[str]:
        """
        How traffic set in the access control policy passes through the cloud firewall. Value: accept:accept, drop:drop, log:log.
        """
        return pulumi.get(self, "rule_action")

    @rule_action.setter
    def rule_action(self, value: pulumi.Input[str]):
        pulumi.set(self, "rule_action", value)

    @property
    @pulumi.getter(name="sourceContent")
    def source_content(self) -> pulumi.Input[str]:
        """
        Access source examplnet:IP/CIDR(192.168.0.2).
        """
        return pulumi.get(self, "source_content")

    @source_content.setter
    def source_content(self, value: pulumi.Input[str]):
        pulumi.set(self, "source_content", value)

    @property
    @pulumi.getter(name="sourceType")
    def source_type(self) -> pulumi.Input[str]:
        """
        Access source type, the type can be: net, template.
        """
        return pulumi.get(self, "source_type")

    @source_type.setter
    def source_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "source_type", value)

    @property
    @pulumi.getter
    def enable(self) -> Optional[pulumi.Input[str]]:
        """
        Rule status, true means enabled, false means disabled. Default is true.
        """
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter(name="fwGroupId")
    def fw_group_id(self) -> Optional[pulumi.Input[str]]:
        """
        Firewall instance ID where the rule takes effect. Default is ALL.
        """
        return pulumi.get(self, "fw_group_id")

    @fw_group_id.setter
    def fw_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "fw_group_id", value)


@pulumi.input_type
class _VpcPolicyState:
    def __init__(__self__, *,
                 beta_lists: Optional[pulumi.Input[Sequence[pulumi.Input['VpcPolicyBetaListArgs']]]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dest_content: Optional[pulumi.Input[str]] = None,
                 dest_type: Optional[pulumi.Input[str]] = None,
                 enable: Optional[pulumi.Input[str]] = None,
                 fw_group_id: Optional[pulumi.Input[str]] = None,
                 fw_group_name: Optional[pulumi.Input[str]] = None,
                 internal_uuid: Optional[pulumi.Input[int]] = None,
                 param_template_id: Optional[pulumi.Input[str]] = None,
                 param_template_name: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 rule_action: Optional[pulumi.Input[str]] = None,
                 source_content: Optional[pulumi.Input[str]] = None,
                 source_type: Optional[pulumi.Input[str]] = None,
                 uuid: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering VpcPolicy resources.
        :param pulumi.Input[Sequence[pulumi.Input['VpcPolicyBetaListArgs']]] beta_lists: Beta mission details. Note: This field may return null, indicating that no valid value can be obtained.
        :param pulumi.Input[str] description: Describe.
        :param pulumi.Input[str] dest_content: Access purpose example: net:IP/CIDR(192.168.0.2) domain:domain rule, for example*.qq.com.
        :param pulumi.Input[str] dest_type: Access purpose type, the type can be: net, template.
        :param pulumi.Input[str] enable: Rule status, true means enabled, false means disabled. Default is true.
        :param pulumi.Input[str] fw_group_id: Firewall instance ID where the rule takes effect. Default is ALL.
        :param pulumi.Input[str] fw_group_name: Firewall name.
        :param pulumi.Input[int] internal_uuid: Uuid used internally, this field is generally not used.
        :param pulumi.Input[str] param_template_id: Parameter template id. Note: This field may return null, indicating that no valid value can be obtained.
        :param pulumi.Input[str] param_template_name: Parameter template Name. Note: This field may return null, indicating that no valid value can be obtained.
        :param pulumi.Input[str] port: The port for the access control policy. Value: -1/-1: All ports; 80: port 80.
        :param pulumi.Input[str] protocol: Protocol, optional value:TCP, UDP, ICMP, ANY, HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL.
        :param pulumi.Input[str] rule_action: How traffic set in the access control policy passes through the cloud firewall. Value: accept:accept, drop:drop, log:log.
        :param pulumi.Input[str] source_content: Access source examplnet:IP/CIDR(192.168.0.2).
        :param pulumi.Input[str] source_type: Access source type, the type can be: net, template.
        :param pulumi.Input[int] uuid: The unique id corresponding to the rule.
        """
        if beta_lists is not None:
            pulumi.set(__self__, "beta_lists", beta_lists)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if dest_content is not None:
            pulumi.set(__self__, "dest_content", dest_content)
        if dest_type is not None:
            pulumi.set(__self__, "dest_type", dest_type)
        if enable is not None:
            pulumi.set(__self__, "enable", enable)
        if fw_group_id is not None:
            pulumi.set(__self__, "fw_group_id", fw_group_id)
        if fw_group_name is not None:
            pulumi.set(__self__, "fw_group_name", fw_group_name)
        if internal_uuid is not None:
            pulumi.set(__self__, "internal_uuid", internal_uuid)
        if param_template_id is not None:
            pulumi.set(__self__, "param_template_id", param_template_id)
        if param_template_name is not None:
            pulumi.set(__self__, "param_template_name", param_template_name)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if protocol is not None:
            pulumi.set(__self__, "protocol", protocol)
        if rule_action is not None:
            pulumi.set(__self__, "rule_action", rule_action)
        if source_content is not None:
            pulumi.set(__self__, "source_content", source_content)
        if source_type is not None:
            pulumi.set(__self__, "source_type", source_type)
        if uuid is not None:
            pulumi.set(__self__, "uuid", uuid)

    @property
    @pulumi.getter(name="betaLists")
    def beta_lists(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VpcPolicyBetaListArgs']]]]:
        """
        Beta mission details. Note: This field may return null, indicating that no valid value can be obtained.
        """
        return pulumi.get(self, "beta_lists")

    @beta_lists.setter
    def beta_lists(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VpcPolicyBetaListArgs']]]]):
        pulumi.set(self, "beta_lists", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Describe.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="destContent")
    def dest_content(self) -> Optional[pulumi.Input[str]]:
        """
        Access purpose example: net:IP/CIDR(192.168.0.2) domain:domain rule, for example*.qq.com.
        """
        return pulumi.get(self, "dest_content")

    @dest_content.setter
    def dest_content(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dest_content", value)

    @property
    @pulumi.getter(name="destType")
    def dest_type(self) -> Optional[pulumi.Input[str]]:
        """
        Access purpose type, the type can be: net, template.
        """
        return pulumi.get(self, "dest_type")

    @dest_type.setter
    def dest_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dest_type", value)

    @property
    @pulumi.getter
    def enable(self) -> Optional[pulumi.Input[str]]:
        """
        Rule status, true means enabled, false means disabled. Default is true.
        """
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter(name="fwGroupId")
    def fw_group_id(self) -> Optional[pulumi.Input[str]]:
        """
        Firewall instance ID where the rule takes effect. Default is ALL.
        """
        return pulumi.get(self, "fw_group_id")

    @fw_group_id.setter
    def fw_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "fw_group_id", value)

    @property
    @pulumi.getter(name="fwGroupName")
    def fw_group_name(self) -> Optional[pulumi.Input[str]]:
        """
        Firewall name.
        """
        return pulumi.get(self, "fw_group_name")

    @fw_group_name.setter
    def fw_group_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "fw_group_name", value)

    @property
    @pulumi.getter(name="internalUuid")
    def internal_uuid(self) -> Optional[pulumi.Input[int]]:
        """
        Uuid used internally, this field is generally not used.
        """
        return pulumi.get(self, "internal_uuid")

    @internal_uuid.setter
    def internal_uuid(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "internal_uuid", value)

    @property
    @pulumi.getter(name="paramTemplateId")
    def param_template_id(self) -> Optional[pulumi.Input[str]]:
        """
        Parameter template id. Note: This field may return null, indicating that no valid value can be obtained.
        """
        return pulumi.get(self, "param_template_id")

    @param_template_id.setter
    def param_template_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "param_template_id", value)

    @property
    @pulumi.getter(name="paramTemplateName")
    def param_template_name(self) -> Optional[pulumi.Input[str]]:
        """
        Parameter template Name. Note: This field may return null, indicating that no valid value can be obtained.
        """
        return pulumi.get(self, "param_template_name")

    @param_template_name.setter
    def param_template_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "param_template_name", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[str]]:
        """
        The port for the access control policy. Value: -1/-1: All ports; 80: port 80.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter
    def protocol(self) -> Optional[pulumi.Input[str]]:
        """
        Protocol, optional value:TCP, UDP, ICMP, ANY, HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL.
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter(name="ruleAction")
    def rule_action(self) -> Optional[pulumi.Input[str]]:
        """
        How traffic set in the access control policy passes through the cloud firewall. Value: accept:accept, drop:drop, log:log.
        """
        return pulumi.get(self, "rule_action")

    @rule_action.setter
    def rule_action(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "rule_action", value)

    @property
    @pulumi.getter(name="sourceContent")
    def source_content(self) -> Optional[pulumi.Input[str]]:
        """
        Access source examplnet:IP/CIDR(192.168.0.2).
        """
        return pulumi.get(self, "source_content")

    @source_content.setter
    def source_content(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "source_content", value)

    @property
    @pulumi.getter(name="sourceType")
    def source_type(self) -> Optional[pulumi.Input[str]]:
        """
        Access source type, the type can be: net, template.
        """
        return pulumi.get(self, "source_type")

    @source_type.setter
    def source_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "source_type", value)

    @property
    @pulumi.getter
    def uuid(self) -> Optional[pulumi.Input[int]]:
        """
        The unique id corresponding to the rule.
        """
        return pulumi.get(self, "uuid")

    @uuid.setter
    def uuid(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "uuid", value)


class VpcPolicy(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dest_content: Optional[pulumi.Input[str]] = None,
                 dest_type: Optional[pulumi.Input[str]] = None,
                 enable: Optional[pulumi.Input[str]] = None,
                 fw_group_id: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 rule_action: Optional[pulumi.Input[str]] = None,
                 source_content: Optional[pulumi.Input[str]] = None,
                 source_type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a cfw vpc_policy

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.cfw.VpcPolicy("example",
            description="description.",
            dest_content="192.168.0.2",
            dest_type="net",
            enable="true",
            fw_group_id="ALL",
            port="-1/-1",
            protocol="ANY",
            rule_action="log",
            source_content="0.0.0.0/0",
            source_type="net")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cfw vpc_policy can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cfw/vpcPolicy:VpcPolicy vpc_policy vpc_policy_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Describe.
        :param pulumi.Input[str] dest_content: Access purpose example: net:IP/CIDR(192.168.0.2) domain:domain rule, for example*.qq.com.
        :param pulumi.Input[str] dest_type: Access purpose type, the type can be: net, template.
        :param pulumi.Input[str] enable: Rule status, true means enabled, false means disabled. Default is true.
        :param pulumi.Input[str] fw_group_id: Firewall instance ID where the rule takes effect. Default is ALL.
        :param pulumi.Input[str] port: The port for the access control policy. Value: -1/-1: All ports; 80: port 80.
        :param pulumi.Input[str] protocol: Protocol, optional value:TCP, UDP, ICMP, ANY, HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL.
        :param pulumi.Input[str] rule_action: How traffic set in the access control policy passes through the cloud firewall. Value: accept:accept, drop:drop, log:log.
        :param pulumi.Input[str] source_content: Access source examplnet:IP/CIDR(192.168.0.2).
        :param pulumi.Input[str] source_type: Access source type, the type can be: net, template.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VpcPolicyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a cfw vpc_policy

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.cfw.VpcPolicy("example",
            description="description.",
            dest_content="192.168.0.2",
            dest_type="net",
            enable="true",
            fw_group_id="ALL",
            port="-1/-1",
            protocol="ANY",
            rule_action="log",
            source_content="0.0.0.0/0",
            source_type="net")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cfw vpc_policy can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cfw/vpcPolicy:VpcPolicy vpc_policy vpc_policy_id
        ```

        :param str resource_name: The name of the resource.
        :param VpcPolicyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VpcPolicyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 dest_content: Optional[pulumi.Input[str]] = None,
                 dest_type: Optional[pulumi.Input[str]] = None,
                 enable: Optional[pulumi.Input[str]] = None,
                 fw_group_id: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 rule_action: Optional[pulumi.Input[str]] = None,
                 source_content: Optional[pulumi.Input[str]] = None,
                 source_type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VpcPolicyArgs.__new__(VpcPolicyArgs)

            if description is None and not opts.urn:
                raise TypeError("Missing required property 'description'")
            __props__.__dict__["description"] = description
            if dest_content is None and not opts.urn:
                raise TypeError("Missing required property 'dest_content'")
            __props__.__dict__["dest_content"] = dest_content
            if dest_type is None and not opts.urn:
                raise TypeError("Missing required property 'dest_type'")
            __props__.__dict__["dest_type"] = dest_type
            __props__.__dict__["enable"] = enable
            __props__.__dict__["fw_group_id"] = fw_group_id
            if port is None and not opts.urn:
                raise TypeError("Missing required property 'port'")
            __props__.__dict__["port"] = port
            if protocol is None and not opts.urn:
                raise TypeError("Missing required property 'protocol'")
            __props__.__dict__["protocol"] = protocol
            if rule_action is None and not opts.urn:
                raise TypeError("Missing required property 'rule_action'")
            __props__.__dict__["rule_action"] = rule_action
            if source_content is None and not opts.urn:
                raise TypeError("Missing required property 'source_content'")
            __props__.__dict__["source_content"] = source_content
            if source_type is None and not opts.urn:
                raise TypeError("Missing required property 'source_type'")
            __props__.__dict__["source_type"] = source_type
            __props__.__dict__["beta_lists"] = None
            __props__.__dict__["fw_group_name"] = None
            __props__.__dict__["internal_uuid"] = None
            __props__.__dict__["param_template_id"] = None
            __props__.__dict__["param_template_name"] = None
            __props__.__dict__["uuid"] = None
        super(VpcPolicy, __self__).__init__(
            'tencentcloud:Cfw/vpcPolicy:VpcPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            beta_lists: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcPolicyBetaListArgs']]]]] = None,
            description: Optional[pulumi.Input[str]] = None,
            dest_content: Optional[pulumi.Input[str]] = None,
            dest_type: Optional[pulumi.Input[str]] = None,
            enable: Optional[pulumi.Input[str]] = None,
            fw_group_id: Optional[pulumi.Input[str]] = None,
            fw_group_name: Optional[pulumi.Input[str]] = None,
            internal_uuid: Optional[pulumi.Input[int]] = None,
            param_template_id: Optional[pulumi.Input[str]] = None,
            param_template_name: Optional[pulumi.Input[str]] = None,
            port: Optional[pulumi.Input[str]] = None,
            protocol: Optional[pulumi.Input[str]] = None,
            rule_action: Optional[pulumi.Input[str]] = None,
            source_content: Optional[pulumi.Input[str]] = None,
            source_type: Optional[pulumi.Input[str]] = None,
            uuid: Optional[pulumi.Input[int]] = None) -> 'VpcPolicy':
        """
        Get an existing VpcPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VpcPolicyBetaListArgs']]]] beta_lists: Beta mission details. Note: This field may return null, indicating that no valid value can be obtained.
        :param pulumi.Input[str] description: Describe.
        :param pulumi.Input[str] dest_content: Access purpose example: net:IP/CIDR(192.168.0.2) domain:domain rule, for example*.qq.com.
        :param pulumi.Input[str] dest_type: Access purpose type, the type can be: net, template.
        :param pulumi.Input[str] enable: Rule status, true means enabled, false means disabled. Default is true.
        :param pulumi.Input[str] fw_group_id: Firewall instance ID where the rule takes effect. Default is ALL.
        :param pulumi.Input[str] fw_group_name: Firewall name.
        :param pulumi.Input[int] internal_uuid: Uuid used internally, this field is generally not used.
        :param pulumi.Input[str] param_template_id: Parameter template id. Note: This field may return null, indicating that no valid value can be obtained.
        :param pulumi.Input[str] param_template_name: Parameter template Name. Note: This field may return null, indicating that no valid value can be obtained.
        :param pulumi.Input[str] port: The port for the access control policy. Value: -1/-1: All ports; 80: port 80.
        :param pulumi.Input[str] protocol: Protocol, optional value:TCP, UDP, ICMP, ANY, HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL.
        :param pulumi.Input[str] rule_action: How traffic set in the access control policy passes through the cloud firewall. Value: accept:accept, drop:drop, log:log.
        :param pulumi.Input[str] source_content: Access source examplnet:IP/CIDR(192.168.0.2).
        :param pulumi.Input[str] source_type: Access source type, the type can be: net, template.
        :param pulumi.Input[int] uuid: The unique id corresponding to the rule.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _VpcPolicyState.__new__(_VpcPolicyState)

        __props__.__dict__["beta_lists"] = beta_lists
        __props__.__dict__["description"] = description
        __props__.__dict__["dest_content"] = dest_content
        __props__.__dict__["dest_type"] = dest_type
        __props__.__dict__["enable"] = enable
        __props__.__dict__["fw_group_id"] = fw_group_id
        __props__.__dict__["fw_group_name"] = fw_group_name
        __props__.__dict__["internal_uuid"] = internal_uuid
        __props__.__dict__["param_template_id"] = param_template_id
        __props__.__dict__["param_template_name"] = param_template_name
        __props__.__dict__["port"] = port
        __props__.__dict__["protocol"] = protocol
        __props__.__dict__["rule_action"] = rule_action
        __props__.__dict__["source_content"] = source_content
        __props__.__dict__["source_type"] = source_type
        __props__.__dict__["uuid"] = uuid
        return VpcPolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="betaLists")
    def beta_lists(self) -> pulumi.Output[Sequence['outputs.VpcPolicyBetaList']]:
        """
        Beta mission details. Note: This field may return null, indicating that no valid value can be obtained.
        """
        return pulumi.get(self, "beta_lists")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        """
        Describe.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="destContent")
    def dest_content(self) -> pulumi.Output[str]:
        """
        Access purpose example: net:IP/CIDR(192.168.0.2) domain:domain rule, for example*.qq.com.
        """
        return pulumi.get(self, "dest_content")

    @property
    @pulumi.getter(name="destType")
    def dest_type(self) -> pulumi.Output[str]:
        """
        Access purpose type, the type can be: net, template.
        """
        return pulumi.get(self, "dest_type")

    @property
    @pulumi.getter
    def enable(self) -> pulumi.Output[Optional[str]]:
        """
        Rule status, true means enabled, false means disabled. Default is true.
        """
        return pulumi.get(self, "enable")

    @property
    @pulumi.getter(name="fwGroupId")
    def fw_group_id(self) -> pulumi.Output[Optional[str]]:
        """
        Firewall instance ID where the rule takes effect. Default is ALL.
        """
        return pulumi.get(self, "fw_group_id")

    @property
    @pulumi.getter(name="fwGroupName")
    def fw_group_name(self) -> pulumi.Output[str]:
        """
        Firewall name.
        """
        return pulumi.get(self, "fw_group_name")

    @property
    @pulumi.getter(name="internalUuid")
    def internal_uuid(self) -> pulumi.Output[int]:
        """
        Uuid used internally, this field is generally not used.
        """
        return pulumi.get(self, "internal_uuid")

    @property
    @pulumi.getter(name="paramTemplateId")
    def param_template_id(self) -> pulumi.Output[str]:
        """
        Parameter template id. Note: This field may return null, indicating that no valid value can be obtained.
        """
        return pulumi.get(self, "param_template_id")

    @property
    @pulumi.getter(name="paramTemplateName")
    def param_template_name(self) -> pulumi.Output[str]:
        """
        Parameter template Name. Note: This field may return null, indicating that no valid value can be obtained.
        """
        return pulumi.get(self, "param_template_name")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[str]:
        """
        The port for the access control policy. Value: -1/-1: All ports; 80: port 80.
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter
    def protocol(self) -> pulumi.Output[str]:
        """
        Protocol, optional value:TCP, UDP, ICMP, ANY, HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL.
        """
        return pulumi.get(self, "protocol")

    @property
    @pulumi.getter(name="ruleAction")
    def rule_action(self) -> pulumi.Output[str]:
        """
        How traffic set in the access control policy passes through the cloud firewall. Value: accept:accept, drop:drop, log:log.
        """
        return pulumi.get(self, "rule_action")

    @property
    @pulumi.getter(name="sourceContent")
    def source_content(self) -> pulumi.Output[str]:
        """
        Access source examplnet:IP/CIDR(192.168.0.2).
        """
        return pulumi.get(self, "source_content")

    @property
    @pulumi.getter(name="sourceType")
    def source_type(self) -> pulumi.Output[str]:
        """
        Access source type, the type can be: net, template.
        """
        return pulumi.get(self, "source_type")

    @property
    @pulumi.getter
    def uuid(self) -> pulumi.Output[int]:
        """
        The unique id corresponding to the rule.
        """
        return pulumi.get(self, "uuid")
