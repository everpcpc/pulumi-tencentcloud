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
    'GetLayerVersionsResult',
    'AwaitableGetLayerVersionsResult',
    'get_layer_versions',
    'get_layer_versions_output',
]

@pulumi.output_type
class GetLayerVersionsResult:
    """
    A collection of values returned by getLayerVersions.
    """
    def __init__(__self__, compatible_runtimes=None, id=None, layer_name=None, layer_versions=None, result_output_file=None):
        if compatible_runtimes and not isinstance(compatible_runtimes, list):
            raise TypeError("Expected argument 'compatible_runtimes' to be a list")
        pulumi.set(__self__, "compatible_runtimes", compatible_runtimes)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if layer_name and not isinstance(layer_name, str):
            raise TypeError("Expected argument 'layer_name' to be a str")
        pulumi.set(__self__, "layer_name", layer_name)
        if layer_versions and not isinstance(layer_versions, list):
            raise TypeError("Expected argument 'layer_versions' to be a list")
        pulumi.set(__self__, "layer_versions", layer_versions)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="compatibleRuntimes")
    def compatible_runtimes(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "compatible_runtimes")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="layerName")
    def layer_name(self) -> str:
        """
        Layer name.
        """
        return pulumi.get(self, "layer_name")

    @property
    @pulumi.getter(name="layerVersions")
    def layer_versions(self) -> Sequence['outputs.GetLayerVersionsLayerVersionResult']:
        """
        Layer version list.
        """
        return pulumi.get(self, "layer_versions")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetLayerVersionsResult(GetLayerVersionsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetLayerVersionsResult(
            compatible_runtimes=self.compatible_runtimes,
            id=self.id,
            layer_name=self.layer_name,
            layer_versions=self.layer_versions,
            result_output_file=self.result_output_file)


def get_layer_versions(compatible_runtimes: Optional[Sequence[str]] = None,
                       layer_name: Optional[str] = None,
                       result_output_file: Optional[str] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetLayerVersionsResult:
    """
    Use this data source to query detailed information of scf layer_versions

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    layer_versions = tencentcloud.Scf.get_layer_versions(layer_name="tf-test")
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] compatible_runtimes: Compatible runtimes.
    :param str layer_name: Layer name.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['compatibleRuntimes'] = compatible_runtimes
    __args__['layerName'] = layer_name
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Scf/getLayerVersions:getLayerVersions', __args__, opts=opts, typ=GetLayerVersionsResult).value

    return AwaitableGetLayerVersionsResult(
        compatible_runtimes=pulumi.get(__ret__, 'compatible_runtimes'),
        id=pulumi.get(__ret__, 'id'),
        layer_name=pulumi.get(__ret__, 'layer_name'),
        layer_versions=pulumi.get(__ret__, 'layer_versions'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_layer_versions)
def get_layer_versions_output(compatible_runtimes: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                              layer_name: Optional[pulumi.Input[str]] = None,
                              result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetLayerVersionsResult]:
    """
    Use this data source to query detailed information of scf layer_versions

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    layer_versions = tencentcloud.Scf.get_layer_versions(layer_name="tf-test")
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] compatible_runtimes: Compatible runtimes.
    :param str layer_name: Layer name.
    :param str result_output_file: Used to save results.
    """
    ...