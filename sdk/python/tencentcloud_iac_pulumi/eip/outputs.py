# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetAddressQuotaQuotaSetResult',
]

@pulumi.output_type
class GetAddressQuotaQuotaSetResult(dict):
    def __init__(__self__, *,
                 quota_current: int,
                 quota_id: str,
                 quota_limit: int):
        """
        :param int quota_current: Current count.
        :param str quota_id: Quota name: TOTAL_EIP_QUOTA,DAILY_EIP_APPLY,DAILY_PUBLIC_IP_ASSIGN.
        :param int quota_limit: quota count.
        """
        pulumi.set(__self__, "quota_current", quota_current)
        pulumi.set(__self__, "quota_id", quota_id)
        pulumi.set(__self__, "quota_limit", quota_limit)

    @property
    @pulumi.getter(name="quotaCurrent")
    def quota_current(self) -> int:
        """
        Current count.
        """
        return pulumi.get(self, "quota_current")

    @property
    @pulumi.getter(name="quotaId")
    def quota_id(self) -> str:
        """
        Quota name: TOTAL_EIP_QUOTA,DAILY_EIP_APPLY,DAILY_PUBLIC_IP_ASSIGN.
        """
        return pulumi.get(self, "quota_id")

    @property
    @pulumi.getter(name="quotaLimit")
    def quota_limit(self) -> int:
        """
        quota count.
        """
        return pulumi.get(self, "quota_limit")

