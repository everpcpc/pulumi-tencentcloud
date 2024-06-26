# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'AssumeRole',
]

@pulumi.output_type
class AssumeRole(dict):
    def __init__(__self__, *,
                 role_arn: str,
                 session_duration: int,
                 session_name: str,
                 policy: Optional[str] = None):
        pulumi.set(__self__, "role_arn", role_arn)
        pulumi.set(__self__, "session_duration", session_duration)
        pulumi.set(__self__, "session_name", session_name)
        if policy is not None:
            pulumi.set(__self__, "policy", policy)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> str:
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter(name="sessionDuration")
    def session_duration(self) -> int:
        return pulumi.get(self, "session_duration")

    @property
    @pulumi.getter(name="sessionName")
    def session_name(self) -> str:
        return pulumi.get(self, "session_name")

    @property
    @pulumi.getter
    def policy(self) -> Optional[str]:
        return pulumi.get(self, "policy")


