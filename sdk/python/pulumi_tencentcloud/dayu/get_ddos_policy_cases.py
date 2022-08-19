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
    'GetDdosPolicyCasesResult',
    'AwaitableGetDdosPolicyCasesResult',
    'get_ddos_policy_cases',
    'get_ddos_policy_cases_output',
]

@pulumi.output_type
class GetDdosPolicyCasesResult:
    """
    A collection of values returned by getDdosPolicyCases.
    """
    def __init__(__self__, id=None, lists=None, resource_type=None, result_output_file=None, scene_id=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if lists and not isinstance(lists, list):
            raise TypeError("Expected argument 'lists' to be a list")
        pulumi.set(__self__, "lists", lists)
        if resource_type and not isinstance(resource_type, str):
            raise TypeError("Expected argument 'resource_type' to be a str")
        pulumi.set(__self__, "resource_type", resource_type)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if scene_id and not isinstance(scene_id, str):
            raise TypeError("Expected argument 'scene_id' to be a str")
        pulumi.set(__self__, "scene_id", scene_id)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def lists(self) -> Sequence['outputs.GetDdosPolicyCasesListResult']:
        """
        A list of DDoS policy cases. Each element contains the following attributes:
        """
        return pulumi.get(self, "lists")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> str:
        """
        Type of the resource that the DDoS policy case works for.
        """
        return pulumi.get(self, "resource_type")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="sceneId")
    def scene_id(self) -> str:
        """
        ID of the DDoS policy case.
        """
        return pulumi.get(self, "scene_id")


class AwaitableGetDdosPolicyCasesResult(GetDdosPolicyCasesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDdosPolicyCasesResult(
            id=self.id,
            lists=self.lists,
            resource_type=self.resource_type,
            result_output_file=self.result_output_file,
            scene_id=self.scene_id)


def get_ddos_policy_cases(resource_type: Optional[str] = None,
                          result_output_file: Optional[str] = None,
                          scene_id: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDdosPolicyCasesResult:
    """
    Use this data source to query dayu DDoS policy cases

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    id_test = tencentcloud.Dayu.get_ddos_policy_cases(resource_type=tencentcloud_dayu_ddos_policy_case["test_policy_case"]["resource_type"],
        scene_id=tencentcloud_dayu_ddos_policy_case["test_policy_case"]["scene_id"])
    ```


    :param str resource_type: Type of the resource that the DDoS policy case works for, valid values are `bgpip`, `bgp`, `bgp-multip` and `net`.
    :param str result_output_file: Used to save results.
    :param str scene_id: ID of the DDoS policy case to be query.
    """
    __args__ = dict()
    __args__['resourceType'] = resource_type
    __args__['resultOutputFile'] = result_output_file
    __args__['sceneId'] = scene_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Dayu/getDdosPolicyCases:getDdosPolicyCases', __args__, opts=opts, typ=GetDdosPolicyCasesResult).value

    return AwaitableGetDdosPolicyCasesResult(
        id=__ret__.id,
        lists=__ret__.lists,
        resource_type=__ret__.resource_type,
        result_output_file=__ret__.result_output_file,
        scene_id=__ret__.scene_id)


@_utilities.lift_output_func(get_ddos_policy_cases)
def get_ddos_policy_cases_output(resource_type: Optional[pulumi.Input[str]] = None,
                                 result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                 scene_id: Optional[pulumi.Input[str]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDdosPolicyCasesResult]:
    """
    Use this data source to query dayu DDoS policy cases

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    id_test = tencentcloud.Dayu.get_ddos_policy_cases(resource_type=tencentcloud_dayu_ddos_policy_case["test_policy_case"]["resource_type"],
        scene_id=tencentcloud_dayu_ddos_policy_case["test_policy_case"]["scene_id"])
    ```


    :param str resource_type: Type of the resource that the DDoS policy case works for, valid values are `bgpip`, `bgp`, `bgp-multip` and `net`.
    :param str result_output_file: Used to save results.
    :param str scene_id: ID of the DDoS policy case to be query.
    """
    ...