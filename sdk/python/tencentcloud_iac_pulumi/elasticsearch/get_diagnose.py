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
    'GetDiagnoseResult',
    'AwaitableGetDiagnoseResult',
    'get_diagnose',
    'get_diagnose_output',
]

@pulumi.output_type
class GetDiagnoseResult:
    """
    A collection of values returned by getDiagnose.
    """
    def __init__(__self__, date=None, diagnose_results=None, id=None, instance_id=None, limit=None, result_output_file=None):
        if date and not isinstance(date, str):
            raise TypeError("Expected argument 'date' to be a str")
        pulumi.set(__self__, "date", date)
        if diagnose_results and not isinstance(diagnose_results, list):
            raise TypeError("Expected argument 'diagnose_results' to be a list")
        pulumi.set(__self__, "diagnose_results", diagnose_results)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if limit and not isinstance(limit, int):
            raise TypeError("Expected argument 'limit' to be a int")
        pulumi.set(__self__, "limit", limit)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter
    def date(self) -> Optional[str]:
        return pulumi.get(self, "date")

    @property
    @pulumi.getter(name="diagnoseResults")
    def diagnose_results(self) -> Sequence['outputs.GetDiagnoseDiagnoseResultResult']:
        """
        List of diagnostic reports.
        """
        return pulumi.get(self, "diagnose_results")

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
        """
        Instance id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def limit(self) -> Optional[int]:
        return pulumi.get(self, "limit")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetDiagnoseResult(GetDiagnoseResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDiagnoseResult(
            date=self.date,
            diagnose_results=self.diagnose_results,
            id=self.id,
            instance_id=self.instance_id,
            limit=self.limit,
            result_output_file=self.result_output_file)


def get_diagnose(date: Optional[str] = None,
                 instance_id: Optional[str] = None,
                 limit: Optional[int] = None,
                 result_output_file: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDiagnoseResult:
    """
    Use this data source to query detailed information of elasticsearch diagnose

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    diagnose = tencentcloud.Elasticsearch.get_diagnose(date="20231030",
        instance_id="es-xxxxxx",
        limit=1)
    ```
    <!--End PulumiCodeChooser -->


    :param str date: Report date, format 20210301.
    :param str instance_id: Instance id.
    :param int limit: Number of copies returned in the report. Default value 1.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['date'] = date
    __args__['instanceId'] = instance_id
    __args__['limit'] = limit
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Elasticsearch/getDiagnose:getDiagnose', __args__, opts=opts, typ=GetDiagnoseResult).value

    return AwaitableGetDiagnoseResult(
        date=pulumi.get(__ret__, 'date'),
        diagnose_results=pulumi.get(__ret__, 'diagnose_results'),
        id=pulumi.get(__ret__, 'id'),
        instance_id=pulumi.get(__ret__, 'instance_id'),
        limit=pulumi.get(__ret__, 'limit'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_diagnose)
def get_diagnose_output(date: Optional[pulumi.Input[Optional[str]]] = None,
                        instance_id: Optional[pulumi.Input[str]] = None,
                        limit: Optional[pulumi.Input[Optional[int]]] = None,
                        result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDiagnoseResult]:
    """
    Use this data source to query detailed information of elasticsearch diagnose

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    diagnose = tencentcloud.Elasticsearch.get_diagnose(date="20231030",
        instance_id="es-xxxxxx",
        limit=1)
    ```
    <!--End PulumiCodeChooser -->


    :param str date: Report date, format 20210301.
    :param str instance_id: Instance id.
    :param int limit: Number of copies returned in the report. Default value 1.
    :param str result_output_file: Used to save results.
    """
    ...
