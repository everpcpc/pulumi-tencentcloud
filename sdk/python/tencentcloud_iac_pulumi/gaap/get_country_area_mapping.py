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
    'GetCountryAreaMappingResult',
    'AwaitableGetCountryAreaMappingResult',
    'get_country_area_mapping',
    'get_country_area_mapping_output',
]

@pulumi.output_type
class GetCountryAreaMappingResult:
    """
    A collection of values returned by getCountryAreaMapping.
    """
    def __init__(__self__, country_area_mapping_lists=None, id=None, result_output_file=None):
        if country_area_mapping_lists and not isinstance(country_area_mapping_lists, list):
            raise TypeError("Expected argument 'country_area_mapping_lists' to be a list")
        pulumi.set(__self__, "country_area_mapping_lists", country_area_mapping_lists)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="countryAreaMappingLists")
    def country_area_mapping_lists(self) -> Sequence['outputs.GetCountryAreaMappingCountryAreaMappingListResult']:
        """
        Country/region code mapping table.
        """
        return pulumi.get(self, "country_area_mapping_lists")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetCountryAreaMappingResult(GetCountryAreaMappingResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCountryAreaMappingResult(
            country_area_mapping_lists=self.country_area_mapping_lists,
            id=self.id,
            result_output_file=self.result_output_file)


def get_country_area_mapping(result_output_file: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCountryAreaMappingResult:
    """
    Use this data source to query detailed information of gaap country area mapping

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    country_area_mapping = tencentcloud.Gaap.get_country_area_mapping()
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Gaap/getCountryAreaMapping:getCountryAreaMapping', __args__, opts=opts, typ=GetCountryAreaMappingResult).value

    return AwaitableGetCountryAreaMappingResult(
        country_area_mapping_lists=pulumi.get(__ret__, 'country_area_mapping_lists'),
        id=pulumi.get(__ret__, 'id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_country_area_mapping)
def get_country_area_mapping_output(result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetCountryAreaMappingResult]:
    """
    Use this data source to query detailed information of gaap country area mapping

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    country_area_mapping = tencentcloud.Gaap.get_country_area_mapping()
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    """
    ...