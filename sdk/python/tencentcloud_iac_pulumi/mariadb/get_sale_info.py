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

__all__ = [
    'GetSaleInfoResult',
    'AwaitableGetSaleInfoResult',
    'get_sale_info',
    'get_sale_info_output',
]

@pulumi.output_type
class GetSaleInfoResult:
    """
    A collection of values returned by getSaleInfo.
    """
    def __init__(__self__, id=None, region_lists=None, result_output_file=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if region_lists and not isinstance(region_lists, list):
            raise TypeError("Expected argument 'region_lists' to be a list")
        pulumi.set(__self__, "region_lists", region_lists)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="regionLists")
    def region_lists(self) -> Sequence['outputs.GetSaleInfoRegionListResult']:
        """
        list of sale region info.
        """
        return pulumi.get(self, "region_lists")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetSaleInfoResult(GetSaleInfoResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSaleInfoResult(
            id=self.id,
            region_lists=self.region_lists,
            result_output_file=self.result_output_file)


def get_sale_info(result_output_file: Optional[str] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSaleInfoResult:
    """
    Use this data source to query detailed information of mariadb sale_info

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    sale_info = tencentcloud.Mariadb.get_sale_info()
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Mariadb/getSaleInfo:getSaleInfo', __args__, opts=opts, typ=GetSaleInfoResult).value

    return AwaitableGetSaleInfoResult(
        id=pulumi.get(__ret__, 'id'),
        region_lists=pulumi.get(__ret__, 'region_lists'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_sale_info)
def get_sale_info_output(result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSaleInfoResult]:
    """
    Use this data source to query detailed information of mariadb sale_info

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    sale_info = tencentcloud.Mariadb.get_sale_info()
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    """
    ...