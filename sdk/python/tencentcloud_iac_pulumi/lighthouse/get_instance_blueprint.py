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
    'GetInstanceBlueprintResult',
    'AwaitableGetInstanceBlueprintResult',
    'get_instance_blueprint',
    'get_instance_blueprint_output',
]

@pulumi.output_type
class GetInstanceBlueprintResult:
    """
    A collection of values returned by getInstanceBlueprint.
    """
    def __init__(__self__, blueprint_instance_sets=None, id=None, instance_ids=None, result_output_file=None):
        if blueprint_instance_sets and not isinstance(blueprint_instance_sets, list):
            raise TypeError("Expected argument 'blueprint_instance_sets' to be a list")
        pulumi.set(__self__, "blueprint_instance_sets", blueprint_instance_sets)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_ids and not isinstance(instance_ids, list):
            raise TypeError("Expected argument 'instance_ids' to be a list")
        pulumi.set(__self__, "instance_ids", instance_ids)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="blueprintInstanceSets")
    def blueprint_instance_sets(self) -> Sequence['outputs.GetInstanceBlueprintBlueprintInstanceSetResult']:
        """
        Blueprint instance list information.
        """
        return pulumi.get(self, "blueprint_instance_sets")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceIds")
    def instance_ids(self) -> Sequence[str]:
        return pulumi.get(self, "instance_ids")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetInstanceBlueprintResult(GetInstanceBlueprintResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetInstanceBlueprintResult(
            blueprint_instance_sets=self.blueprint_instance_sets,
            id=self.id,
            instance_ids=self.instance_ids,
            result_output_file=self.result_output_file)


def get_instance_blueprint(instance_ids: Optional[Sequence[str]] = None,
                           result_output_file: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetInstanceBlueprintResult:
    """
    Use this data source to query detailed information of lighthouse instance_blueprint

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    instance_blueprint = tencentcloud.Lighthouse.get_instance_blueprint(instance_ids=["lhins-xxxxxx"])
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] instance_ids: Instance ID list, which currently can contain only one instance.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['instanceIds'] = instance_ids
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Lighthouse/getInstanceBlueprint:getInstanceBlueprint', __args__, opts=opts, typ=GetInstanceBlueprintResult).value

    return AwaitableGetInstanceBlueprintResult(
        blueprint_instance_sets=pulumi.get(__ret__, 'blueprint_instance_sets'),
        id=pulumi.get(__ret__, 'id'),
        instance_ids=pulumi.get(__ret__, 'instance_ids'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_instance_blueprint)
def get_instance_blueprint_output(instance_ids: Optional[pulumi.Input[Sequence[str]]] = None,
                                  result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetInstanceBlueprintResult]:
    """
    Use this data source to query detailed information of lighthouse instance_blueprint

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    instance_blueprint = tencentcloud.Lighthouse.get_instance_blueprint(instance_ids=["lhins-xxxxxx"])
    ```
    <!--End PulumiCodeChooser -->


    :param Sequence[str] instance_ids: Instance ID list, which currently can contain only one instance.
    :param str result_output_file: Used to save results.
    """
    ...