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
    'GetInstanceNodeInfoResult',
    'AwaitableGetInstanceNodeInfoResult',
    'get_instance_node_info',
    'get_instance_node_info_output',
]

@pulumi.output_type
class GetInstanceNodeInfoResult:
    """
    A collection of values returned by getInstanceNodeInfo.
    """
    def __init__(__self__, id=None, instance_id=None, nodes_infos=None, result_output_file=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if nodes_infos and not isinstance(nodes_infos, list):
            raise TypeError("Expected argument 'nodes_infos' to be a list")
        pulumi.set(__self__, "nodes_infos", nodes_infos)
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
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="nodesInfos")
    def nodes_infos(self) -> Sequence['outputs.GetInstanceNodeInfoNodesInfoResult']:
        """
        Node information.
        """
        return pulumi.get(self, "nodes_infos")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetInstanceNodeInfoResult(GetInstanceNodeInfoResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetInstanceNodeInfoResult(
            id=self.id,
            instance_id=self.instance_id,
            nodes_infos=self.nodes_infos,
            result_output_file=self.result_output_file)


def get_instance_node_info(instance_id: Optional[str] = None,
                           result_output_file: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetInstanceNodeInfoResult:
    """
    Use this data source to query detailed information of dcdb instance_node_info

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    instance_node_info = tencentcloud.Dcdb.get_instance_node_info(instance_id=local["dcdb_id"])
    ```
    <!--End PulumiCodeChooser -->


    :param str instance_id: Instance ID, such as tdsqlshard-6ltok4u9.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['instanceId'] = instance_id
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Dcdb/getInstanceNodeInfo:getInstanceNodeInfo', __args__, opts=opts, typ=GetInstanceNodeInfoResult).value

    return AwaitableGetInstanceNodeInfoResult(
        id=pulumi.get(__ret__, 'id'),
        instance_id=pulumi.get(__ret__, 'instance_id'),
        nodes_infos=pulumi.get(__ret__, 'nodes_infos'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_instance_node_info)
def get_instance_node_info_output(instance_id: Optional[pulumi.Input[str]] = None,
                                  result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetInstanceNodeInfoResult]:
    """
    Use this data source to query detailed information of dcdb instance_node_info

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    instance_node_info = tencentcloud.Dcdb.get_instance_node_info(instance_id=local["dcdb_id"])
    ```
    <!--End PulumiCodeChooser -->


    :param str instance_id: Instance ID, such as tdsqlshard-6ltok4u9.
    :param str result_output_file: Used to save results.
    """
    ...