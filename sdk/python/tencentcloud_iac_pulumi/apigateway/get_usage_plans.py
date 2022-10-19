# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'GetUsagePlansResult',
    'AwaitableGetUsagePlansResult',
    'get_usage_plans',
    'get_usage_plans_output',
]

@pulumi.output_type
class GetUsagePlansResult:
    """
    A collection of values returned by getUsagePlans.
    """
    def __init__(__self__, id=None, lists=None, result_output_file=None, usage_plan_id=None, usage_plan_name=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if lists and not isinstance(lists, list):
            raise TypeError("Expected argument 'lists' to be a list")
        pulumi.set(__self__, "lists", lists)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if usage_plan_id and not isinstance(usage_plan_id, str):
            raise TypeError("Expected argument 'usage_plan_id' to be a str")
        pulumi.set(__self__, "usage_plan_id", usage_plan_id)
        if usage_plan_name and not isinstance(usage_plan_name, str):
            raise TypeError("Expected argument 'usage_plan_name' to be a str")
        pulumi.set(__self__, "usage_plan_name", usage_plan_name)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def lists(self) -> Sequence['outputs.GetUsagePlansListResult']:
        """
        A list of usage plans.
        """
        return pulumi.get(self, "lists")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="usagePlanId")
    def usage_plan_id(self) -> Optional[str]:
        """
        ID of the usage plan.
        """
        return pulumi.get(self, "usage_plan_id")

    @property
    @pulumi.getter(name="usagePlanName")
    def usage_plan_name(self) -> Optional[str]:
        """
        Name of the usage plan.
        """
        return pulumi.get(self, "usage_plan_name")


class AwaitableGetUsagePlansResult(GetUsagePlansResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetUsagePlansResult(
            id=self.id,
            lists=self.lists,
            result_output_file=self.result_output_file,
            usage_plan_id=self.usage_plan_id,
            usage_plan_name=self.usage_plan_name)


def get_usage_plans(result_output_file: Optional[str] = None,
                    usage_plan_id: Optional[str] = None,
                    usage_plan_name: Optional[str] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetUsagePlansResult:
    """
    Use this data source to query API gateway usage plans.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud
    import tencentcloud_iac_pulumi as tencentcloud

    plan = tencentcloud.api_gateway.UsagePlan("plan",
        usage_plan_name="my_plan",
        usage_plan_desc="nice plan",
        max_request_num=100,
        max_request_num_pre_sec=10)
    name = tencentcloud.ApiGateway.get_usage_plans_output(usage_plan_name=plan.usage_plan_name)
    id = tencentcloud.ApiGateway.get_usage_plans_output(usage_plan_id=plan.id)
    ```


    :param str result_output_file: Used to save results.
    :param str usage_plan_id: ID of the usage plan.
    :param str usage_plan_name: Name of the usage plan.
    """
    __args__ = dict()
    __args__['resultOutputFile'] = result_output_file
    __args__['usagePlanId'] = usage_plan_id
    __args__['usagePlanName'] = usage_plan_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('tencentcloud:ApiGateway/getUsagePlans:getUsagePlans', __args__, opts=opts, typ=GetUsagePlansResult).value

    return AwaitableGetUsagePlansResult(
        id=__ret__.id,
        lists=__ret__.lists,
        result_output_file=__ret__.result_output_file,
        usage_plan_id=__ret__.usage_plan_id,
        usage_plan_name=__ret__.usage_plan_name)


@_utilities.lift_output_func(get_usage_plans)
def get_usage_plans_output(result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                           usage_plan_id: Optional[pulumi.Input[Optional[str]]] = None,
                           usage_plan_name: Optional[pulumi.Input[Optional[str]]] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetUsagePlansResult]:
    """
    Use this data source to query API gateway usage plans.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud
    import tencentcloud_iac_pulumi as tencentcloud

    plan = tencentcloud.api_gateway.UsagePlan("plan",
        usage_plan_name="my_plan",
        usage_plan_desc="nice plan",
        max_request_num=100,
        max_request_num_pre_sec=10)
    name = tencentcloud.ApiGateway.get_usage_plans_output(usage_plan_name=plan.usage_plan_name)
    id = tencentcloud.ApiGateway.get_usage_plans_output(usage_plan_id=plan.id)
    ```


    :param str result_output_file: Used to save results.
    :param str usage_plan_id: ID of the usage plan.
    :param str usage_plan_name: Name of the usage plan.
    """
    ...