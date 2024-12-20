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

__all__ = ['AclRuleArgs', 'AclRule']

@pulumi.input_type
class AclRuleArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 pattern_type: pulumi.Input[str],
                 resource_type: pulumi.Input[str],
                 rule_lists: pulumi.Input[Sequence[pulumi.Input['AclRuleRuleListArgs']]],
                 rule_name: pulumi.Input[str],
                 is_applied: Optional[pulumi.Input[int]] = None,
                 pattern: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a AclRule resource.
        :param pulumi.Input[str] instance_id: instance id.
        :param pulumi.Input[str] pattern_type: Match type, currently supports prefix matching and preset strategy, enumeration value list{PREFIXED/PRESET}.
        :param pulumi.Input[str] resource_type: Acl resource type, currently only supports Topic, enumeration value list{Topic}.
        :param pulumi.Input[Sequence[pulumi.Input['AclRuleRuleListArgs']]] rule_lists: List of configured ACL rules.
        :param pulumi.Input[str] rule_name: rule name.
        :param pulumi.Input[int] is_applied: Whether the preset ACL rule is applied to the newly added topic.
        :param pulumi.Input[str] pattern: A value representing the prefix that the prefix matches.
        """
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "pattern_type", pattern_type)
        pulumi.set(__self__, "resource_type", resource_type)
        pulumi.set(__self__, "rule_lists", rule_lists)
        pulumi.set(__self__, "rule_name", rule_name)
        if is_applied is not None:
            pulumi.set(__self__, "is_applied", is_applied)
        if pattern is not None:
            pulumi.set(__self__, "pattern", pattern)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="patternType")
    def pattern_type(self) -> pulumi.Input[str]:
        """
        Match type, currently supports prefix matching and preset strategy, enumeration value list{PREFIXED/PRESET}.
        """
        return pulumi.get(self, "pattern_type")

    @pattern_type.setter
    def pattern_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "pattern_type", value)

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> pulumi.Input[str]:
        """
        Acl resource type, currently only supports Topic, enumeration value list{Topic}.
        """
        return pulumi.get(self, "resource_type")

    @resource_type.setter
    def resource_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_type", value)

    @property
    @pulumi.getter(name="ruleLists")
    def rule_lists(self) -> pulumi.Input[Sequence[pulumi.Input['AclRuleRuleListArgs']]]:
        """
        List of configured ACL rules.
        """
        return pulumi.get(self, "rule_lists")

    @rule_lists.setter
    def rule_lists(self, value: pulumi.Input[Sequence[pulumi.Input['AclRuleRuleListArgs']]]):
        pulumi.set(self, "rule_lists", value)

    @property
    @pulumi.getter(name="ruleName")
    def rule_name(self) -> pulumi.Input[str]:
        """
        rule name.
        """
        return pulumi.get(self, "rule_name")

    @rule_name.setter
    def rule_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "rule_name", value)

    @property
    @pulumi.getter(name="isApplied")
    def is_applied(self) -> Optional[pulumi.Input[int]]:
        """
        Whether the preset ACL rule is applied to the newly added topic.
        """
        return pulumi.get(self, "is_applied")

    @is_applied.setter
    def is_applied(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "is_applied", value)

    @property
    @pulumi.getter
    def pattern(self) -> Optional[pulumi.Input[str]]:
        """
        A value representing the prefix that the prefix matches.
        """
        return pulumi.get(self, "pattern")

    @pattern.setter
    def pattern(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pattern", value)


@pulumi.input_type
class _AclRuleState:
    def __init__(__self__, *,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 is_applied: Optional[pulumi.Input[int]] = None,
                 pattern: Optional[pulumi.Input[str]] = None,
                 pattern_type: Optional[pulumi.Input[str]] = None,
                 resource_type: Optional[pulumi.Input[str]] = None,
                 rule_lists: Optional[pulumi.Input[Sequence[pulumi.Input['AclRuleRuleListArgs']]]] = None,
                 rule_name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering AclRule resources.
        :param pulumi.Input[str] instance_id: instance id.
        :param pulumi.Input[int] is_applied: Whether the preset ACL rule is applied to the newly added topic.
        :param pulumi.Input[str] pattern: A value representing the prefix that the prefix matches.
        :param pulumi.Input[str] pattern_type: Match type, currently supports prefix matching and preset strategy, enumeration value list{PREFIXED/PRESET}.
        :param pulumi.Input[str] resource_type: Acl resource type, currently only supports Topic, enumeration value list{Topic}.
        :param pulumi.Input[Sequence[pulumi.Input['AclRuleRuleListArgs']]] rule_lists: List of configured ACL rules.
        :param pulumi.Input[str] rule_name: rule name.
        """
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if is_applied is not None:
            pulumi.set(__self__, "is_applied", is_applied)
        if pattern is not None:
            pulumi.set(__self__, "pattern", pattern)
        if pattern_type is not None:
            pulumi.set(__self__, "pattern_type", pattern_type)
        if resource_type is not None:
            pulumi.set(__self__, "resource_type", resource_type)
        if rule_lists is not None:
            pulumi.set(__self__, "rule_lists", rule_lists)
        if rule_name is not None:
            pulumi.set(__self__, "rule_name", rule_name)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="isApplied")
    def is_applied(self) -> Optional[pulumi.Input[int]]:
        """
        Whether the preset ACL rule is applied to the newly added topic.
        """
        return pulumi.get(self, "is_applied")

    @is_applied.setter
    def is_applied(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "is_applied", value)

    @property
    @pulumi.getter
    def pattern(self) -> Optional[pulumi.Input[str]]:
        """
        A value representing the prefix that the prefix matches.
        """
        return pulumi.get(self, "pattern")

    @pattern.setter
    def pattern(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pattern", value)

    @property
    @pulumi.getter(name="patternType")
    def pattern_type(self) -> Optional[pulumi.Input[str]]:
        """
        Match type, currently supports prefix matching and preset strategy, enumeration value list{PREFIXED/PRESET}.
        """
        return pulumi.get(self, "pattern_type")

    @pattern_type.setter
    def pattern_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pattern_type", value)

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> Optional[pulumi.Input[str]]:
        """
        Acl resource type, currently only supports Topic, enumeration value list{Topic}.
        """
        return pulumi.get(self, "resource_type")

    @resource_type.setter
    def resource_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource_type", value)

    @property
    @pulumi.getter(name="ruleLists")
    def rule_lists(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AclRuleRuleListArgs']]]]:
        """
        List of configured ACL rules.
        """
        return pulumi.get(self, "rule_lists")

    @rule_lists.setter
    def rule_lists(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AclRuleRuleListArgs']]]]):
        pulumi.set(self, "rule_lists", value)

    @property
    @pulumi.getter(name="ruleName")
    def rule_name(self) -> Optional[pulumi.Input[str]]:
        """
        rule name.
        """
        return pulumi.get(self, "rule_name")

    @rule_name.setter
    def rule_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "rule_name", value)


class AclRule(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 is_applied: Optional[pulumi.Input[int]] = None,
                 pattern: Optional[pulumi.Input[str]] = None,
                 pattern_type: Optional[pulumi.Input[str]] = None,
                 resource_type: Optional[pulumi.Input[str]] = None,
                 rule_lists: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AclRuleRuleListArgs']]]]] = None,
                 rule_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a ckafka acl_rule

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        acl_rule = tencentcloud.ckafka.AclRule("aclRule",
            instance_id="ckafka-xxx",
            is_applied=1,
            pattern="prefix",
            pattern_type="PREFIXED",
            resource_type="Topic",
            rule_lists=[tencentcloud.ckafka.AclRuleRuleListArgs(
                host="*",
                operation="All",
                permission_type="Deny",
                principal="User:*",
            )],
            rule_name="RuleName")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        ckafka acl_rule can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Ckafka/aclRule:AclRule acl_rule acl_rule_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: instance id.
        :param pulumi.Input[int] is_applied: Whether the preset ACL rule is applied to the newly added topic.
        :param pulumi.Input[str] pattern: A value representing the prefix that the prefix matches.
        :param pulumi.Input[str] pattern_type: Match type, currently supports prefix matching and preset strategy, enumeration value list{PREFIXED/PRESET}.
        :param pulumi.Input[str] resource_type: Acl resource type, currently only supports Topic, enumeration value list{Topic}.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AclRuleRuleListArgs']]]] rule_lists: List of configured ACL rules.
        :param pulumi.Input[str] rule_name: rule name.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AclRuleArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a ckafka acl_rule

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        acl_rule = tencentcloud.ckafka.AclRule("aclRule",
            instance_id="ckafka-xxx",
            is_applied=1,
            pattern="prefix",
            pattern_type="PREFIXED",
            resource_type="Topic",
            rule_lists=[tencentcloud.ckafka.AclRuleRuleListArgs(
                host="*",
                operation="All",
                permission_type="Deny",
                principal="User:*",
            )],
            rule_name="RuleName")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        ckafka acl_rule can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Ckafka/aclRule:AclRule acl_rule acl_rule_id
        ```

        :param str resource_name: The name of the resource.
        :param AclRuleArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AclRuleArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 is_applied: Optional[pulumi.Input[int]] = None,
                 pattern: Optional[pulumi.Input[str]] = None,
                 pattern_type: Optional[pulumi.Input[str]] = None,
                 resource_type: Optional[pulumi.Input[str]] = None,
                 rule_lists: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AclRuleRuleListArgs']]]]] = None,
                 rule_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AclRuleArgs.__new__(AclRuleArgs)

            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            __props__.__dict__["is_applied"] = is_applied
            __props__.__dict__["pattern"] = pattern
            if pattern_type is None and not opts.urn:
                raise TypeError("Missing required property 'pattern_type'")
            __props__.__dict__["pattern_type"] = pattern_type
            if resource_type is None and not opts.urn:
                raise TypeError("Missing required property 'resource_type'")
            __props__.__dict__["resource_type"] = resource_type
            if rule_lists is None and not opts.urn:
                raise TypeError("Missing required property 'rule_lists'")
            __props__.__dict__["rule_lists"] = rule_lists
            if rule_name is None and not opts.urn:
                raise TypeError("Missing required property 'rule_name'")
            __props__.__dict__["rule_name"] = rule_name
        super(AclRule, __self__).__init__(
            'tencentcloud:Ckafka/aclRule:AclRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            is_applied: Optional[pulumi.Input[int]] = None,
            pattern: Optional[pulumi.Input[str]] = None,
            pattern_type: Optional[pulumi.Input[str]] = None,
            resource_type: Optional[pulumi.Input[str]] = None,
            rule_lists: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AclRuleRuleListArgs']]]]] = None,
            rule_name: Optional[pulumi.Input[str]] = None) -> 'AclRule':
        """
        Get an existing AclRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: instance id.
        :param pulumi.Input[int] is_applied: Whether the preset ACL rule is applied to the newly added topic.
        :param pulumi.Input[str] pattern: A value representing the prefix that the prefix matches.
        :param pulumi.Input[str] pattern_type: Match type, currently supports prefix matching and preset strategy, enumeration value list{PREFIXED/PRESET}.
        :param pulumi.Input[str] resource_type: Acl resource type, currently only supports Topic, enumeration value list{Topic}.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AclRuleRuleListArgs']]]] rule_lists: List of configured ACL rules.
        :param pulumi.Input[str] rule_name: rule name.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AclRuleState.__new__(_AclRuleState)

        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["is_applied"] = is_applied
        __props__.__dict__["pattern"] = pattern
        __props__.__dict__["pattern_type"] = pattern_type
        __props__.__dict__["resource_type"] = resource_type
        __props__.__dict__["rule_lists"] = rule_lists
        __props__.__dict__["rule_name"] = rule_name
        return AclRule(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        instance id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="isApplied")
    def is_applied(self) -> pulumi.Output[Optional[int]]:
        """
        Whether the preset ACL rule is applied to the newly added topic.
        """
        return pulumi.get(self, "is_applied")

    @property
    @pulumi.getter
    def pattern(self) -> pulumi.Output[Optional[str]]:
        """
        A value representing the prefix that the prefix matches.
        """
        return pulumi.get(self, "pattern")

    @property
    @pulumi.getter(name="patternType")
    def pattern_type(self) -> pulumi.Output[str]:
        """
        Match type, currently supports prefix matching and preset strategy, enumeration value list{PREFIXED/PRESET}.
        """
        return pulumi.get(self, "pattern_type")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> pulumi.Output[str]:
        """
        Acl resource type, currently only supports Topic, enumeration value list{Topic}.
        """
        return pulumi.get(self, "resource_type")

    @property
    @pulumi.getter(name="ruleLists")
    def rule_lists(self) -> pulumi.Output[Sequence['outputs.AclRuleRuleList']]:
        """
        List of configured ACL rules.
        """
        return pulumi.get(self, "rule_lists")

    @property
    @pulumi.getter(name="ruleName")
    def rule_name(self) -> pulumi.Output[str]:
        """
        rule name.
        """
        return pulumi.get(self, "rule_name")

