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
    'GetStatisticDataResult',
    'AwaitableGetStatisticDataResult',
    'get_statistic_data',
    'get_statistic_data_output',
]

@pulumi.output_type
class GetStatisticDataResult:
    """
    A collection of values returned by getStatisticData.
    """
    def __init__(__self__, conditions=None, datas=None, end_time=None, group_bys=None, id=None, metric_names=None, module=None, namespace=None, period=None, result_output_file=None, start_time=None):
        if conditions and not isinstance(conditions, list):
            raise TypeError("Expected argument 'conditions' to be a list")
        pulumi.set(__self__, "conditions", conditions)
        if datas and not isinstance(datas, list):
            raise TypeError("Expected argument 'datas' to be a list")
        pulumi.set(__self__, "datas", datas)
        if end_time and not isinstance(end_time, str):
            raise TypeError("Expected argument 'end_time' to be a str")
        pulumi.set(__self__, "end_time", end_time)
        if group_bys and not isinstance(group_bys, list):
            raise TypeError("Expected argument 'group_bys' to be a list")
        pulumi.set(__self__, "group_bys", group_bys)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if metric_names and not isinstance(metric_names, list):
            raise TypeError("Expected argument 'metric_names' to be a list")
        pulumi.set(__self__, "metric_names", metric_names)
        if module and not isinstance(module, str):
            raise TypeError("Expected argument 'module' to be a str")
        pulumi.set(__self__, "module", module)
        if namespace and not isinstance(namespace, str):
            raise TypeError("Expected argument 'namespace' to be a str")
        pulumi.set(__self__, "namespace", namespace)
        if period and not isinstance(period, int):
            raise TypeError("Expected argument 'period' to be a int")
        pulumi.set(__self__, "period", period)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if start_time and not isinstance(start_time, str):
            raise TypeError("Expected argument 'start_time' to be a str")
        pulumi.set(__self__, "start_time", start_time)

    @property
    @pulumi.getter
    def conditions(self) -> Optional[Sequence['outputs.GetStatisticDataConditionResult']]:
        return pulumi.get(self, "conditions")

    @property
    @pulumi.getter
    def datas(self) -> Sequence['outputs.GetStatisticDataDataResult']:
        return pulumi.get(self, "datas")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> str:
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter(name="groupBys")
    def group_bys(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "group_bys")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="metricNames")
    def metric_names(self) -> Sequence[str]:
        return pulumi.get(self, "metric_names")

    @property
    @pulumi.getter
    def module(self) -> str:
        return pulumi.get(self, "module")

    @property
    @pulumi.getter
    def namespace(self) -> str:
        return pulumi.get(self, "namespace")

    @property
    @pulumi.getter
    def period(self) -> int:
        return pulumi.get(self, "period")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> str:
        return pulumi.get(self, "start_time")


class AwaitableGetStatisticDataResult(GetStatisticDataResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetStatisticDataResult(
            conditions=self.conditions,
            datas=self.datas,
            end_time=self.end_time,
            group_bys=self.group_bys,
            id=self.id,
            metric_names=self.metric_names,
            module=self.module,
            namespace=self.namespace,
            period=self.period,
            result_output_file=self.result_output_file,
            start_time=self.start_time)


def get_statistic_data(conditions: Optional[Sequence[pulumi.InputType['GetStatisticDataConditionArgs']]] = None,
                       group_bys: Optional[Sequence[str]] = None,
                       metric_names: Optional[Sequence[str]] = None,
                       module: Optional[str] = None,
                       namespace: Optional[str] = None,
                       result_output_file: Optional[str] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetStatisticDataResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['conditions'] = conditions
    __args__['groupBys'] = group_bys
    __args__['metricNames'] = metric_names
    __args__['module'] = module
    __args__['namespace'] = namespace
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Monitor/getStatisticData:getStatisticData', __args__, opts=opts, typ=GetStatisticDataResult).value

    return AwaitableGetStatisticDataResult(
        conditions=pulumi.get(__ret__, 'conditions'),
        datas=pulumi.get(__ret__, 'datas'),
        end_time=pulumi.get(__ret__, 'end_time'),
        group_bys=pulumi.get(__ret__, 'group_bys'),
        id=pulumi.get(__ret__, 'id'),
        metric_names=pulumi.get(__ret__, 'metric_names'),
        module=pulumi.get(__ret__, 'module'),
        namespace=pulumi.get(__ret__, 'namespace'),
        period=pulumi.get(__ret__, 'period'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        start_time=pulumi.get(__ret__, 'start_time'))


@_utilities.lift_output_func(get_statistic_data)
def get_statistic_data_output(conditions: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetStatisticDataConditionArgs']]]]] = None,
                              group_bys: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                              metric_names: Optional[pulumi.Input[Sequence[str]]] = None,
                              module: Optional[pulumi.Input[str]] = None,
                              namespace: Optional[pulumi.Input[str]] = None,
                              result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetStatisticDataResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...