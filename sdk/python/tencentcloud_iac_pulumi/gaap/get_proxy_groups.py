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

__all__ = [
    'GetProxyGroupsResult',
    'AwaitableGetProxyGroupsResult',
    'get_proxy_groups',
    'get_proxy_groups_output',
]

@pulumi.output_type
class GetProxyGroupsResult:
    """
    A collection of values returned by getProxyGroups.
    """
    def __init__(__self__, filters=None, id=None, project_id=None, proxy_group_lists=None, result_output_file=None, tag_sets=None):
        if filters and not isinstance(filters, list):
            raise TypeError("Expected argument 'filters' to be a list")
        pulumi.set(__self__, "filters", filters)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if project_id and not isinstance(project_id, int):
            raise TypeError("Expected argument 'project_id' to be a int")
        pulumi.set(__self__, "project_id", project_id)
        if proxy_group_lists and not isinstance(proxy_group_lists, list):
            raise TypeError("Expected argument 'proxy_group_lists' to be a list")
        pulumi.set(__self__, "proxy_group_lists", proxy_group_lists)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if tag_sets and not isinstance(tag_sets, list):
            raise TypeError("Expected argument 'tag_sets' to be a list")
        pulumi.set(__self__, "tag_sets", tag_sets)

    @property
    @pulumi.getter
    def filters(self) -> Optional[Sequence['outputs.GetProxyGroupsFilterResult']]:
        return pulumi.get(self, "filters")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> int:
        """
        Project Id.
        """
        return pulumi.get(self, "project_id")

    @property
    @pulumi.getter(name="proxyGroupLists")
    def proxy_group_lists(self) -> Sequence['outputs.GetProxyGroupsProxyGroupListResult']:
        """
        List of proxy groups.Note: This field may return null, indicating that a valid value cannot be obtained.
        """
        return pulumi.get(self, "proxy_group_lists")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="tagSets")
    def tag_sets(self) -> Optional[Sequence['outputs.GetProxyGroupsTagSetResult']]:
        """
        Tag Set.
        """
        return pulumi.get(self, "tag_sets")


class AwaitableGetProxyGroupsResult(GetProxyGroupsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetProxyGroupsResult(
            filters=self.filters,
            id=self.id,
            project_id=self.project_id,
            proxy_group_lists=self.proxy_group_lists,
            result_output_file=self.result_output_file,
            tag_sets=self.tag_sets)


def get_proxy_groups(filters: Optional[Sequence[pulumi.InputType['GetProxyGroupsFilterArgs']]] = None,
                     project_id: Optional[int] = None,
                     result_output_file: Optional[str] = None,
                     tag_sets: Optional[Sequence[pulumi.InputType['GetProxyGroupsTagSetArgs']]] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetProxyGroupsResult:
    """
    Use this data source to query detailed information of gaap proxy groups

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    proxy_groups = tencentcloud.Gaap.get_proxy_groups(filters=[tencentcloud.gaap.GetProxyGroupsFilterArgs(
            name="GroupId",
            values=["lg-2foz7wjh"],
        )],
        project_id=0)
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[pulumi.InputType['GetProxyGroupsFilterArgs']] filters: Filter conditions,The upper limit of Filter.Values per request is 5.RealServerRegion - String - Required: No - (filtering criteria) Filter by real server region, refer to the RegionId in the returned results of the DescribeDestRegions interface.PackageType - String - Required: No - (Filter condition) proxy group type, where &amp;#39;Thunder&amp;#39; represents the standard proxy group and &amp;#39;Accelerator&amp;#39; represents the silver acceleration proxy group.
    :param int project_id: Project ID. Value range:-1, All projects under this user0, default projectOther values, specified items.
    :param str result_output_file: Used to save results.
    :param Sequence[pulumi.InputType['GetProxyGroupsTagSetArgs']] tag_sets: Tag list, when this field exists, pulls the resource list under the corresponding tag.Supports a maximum of 5 labels. When there are two or more labels and any one of them is met, the proxy group will be pulled out.
    """
    __args__ = dict()
    __args__['filters'] = filters
    __args__['projectId'] = project_id
    __args__['resultOutputFile'] = result_output_file
    __args__['tagSets'] = tag_sets
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Gaap/getProxyGroups:getProxyGroups', __args__, opts=opts, typ=GetProxyGroupsResult).value

    return AwaitableGetProxyGroupsResult(
        filters=pulumi.get(__ret__, 'filters'),
        id=pulumi.get(__ret__, 'id'),
        project_id=pulumi.get(__ret__, 'project_id'),
        proxy_group_lists=pulumi.get(__ret__, 'proxy_group_lists'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        tag_sets=pulumi.get(__ret__, 'tag_sets'))


@_utilities.lift_output_func(get_proxy_groups)
def get_proxy_groups_output(filters: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetProxyGroupsFilterArgs']]]]] = None,
                            project_id: Optional[pulumi.Input[int]] = None,
                            result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                            tag_sets: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetProxyGroupsTagSetArgs']]]]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetProxyGroupsResult]:
    """
    Use this data source to query detailed information of gaap proxy groups

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    proxy_groups = tencentcloud.Gaap.get_proxy_groups(filters=[tencentcloud.gaap.GetProxyGroupsFilterArgs(
            name="GroupId",
            values=["lg-2foz7wjh"],
        )],
        project_id=0)
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[pulumi.InputType['GetProxyGroupsFilterArgs']] filters: Filter conditions,The upper limit of Filter.Values per request is 5.RealServerRegion - String - Required: No - (filtering criteria) Filter by real server region, refer to the RegionId in the returned results of the DescribeDestRegions interface.PackageType - String - Required: No - (Filter condition) proxy group type, where &amp;#39;Thunder&amp;#39; represents the standard proxy group and &amp;#39;Accelerator&amp;#39; represents the silver acceleration proxy group.
    :param int project_id: Project ID. Value range:-1, All projects under this user0, default projectOther values, specified items.
    :param str result_output_file: Used to save results.
    :param Sequence[pulumi.InputType['GetProxyGroupsTagSetArgs']] tag_sets: Tag list, when this field exists, pulls the resource list under the corresponding tag.Supports a maximum of 5 labels. When there are two or more labels and any one of them is met, the proxy group will be pulled out.
    """
    ...