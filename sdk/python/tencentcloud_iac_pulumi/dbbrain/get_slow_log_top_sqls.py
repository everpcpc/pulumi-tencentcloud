# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = [
    'GetSlowLogTopSqlsResult',
    'AwaitableGetSlowLogTopSqlsResult',
    'get_slow_log_top_sqls',
    'get_slow_log_top_sqls_output',
]

@pulumi.output_type
class GetSlowLogTopSqlsResult:
    """
    A collection of values returned by getSlowLogTopSqls.
    """
    def __init__(__self__, end_time=None, id=None, instance_id=None, order_by=None, product=None, result_output_file=None, rows=None, schema_lists=None, sort_by=None, start_time=None):
        if end_time and not isinstance(end_time, str):
            raise TypeError("Expected argument 'end_time' to be a str")
        pulumi.set(__self__, "end_time", end_time)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if order_by and not isinstance(order_by, str):
            raise TypeError("Expected argument 'order_by' to be a str")
        pulumi.set(__self__, "order_by", order_by)
        if product and not isinstance(product, str):
            raise TypeError("Expected argument 'product' to be a str")
        pulumi.set(__self__, "product", product)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if rows and not isinstance(rows, list):
            raise TypeError("Expected argument 'rows' to be a list")
        pulumi.set(__self__, "rows", rows)
        if schema_lists and not isinstance(schema_lists, list):
            raise TypeError("Expected argument 'schema_lists' to be a list")
        pulumi.set(__self__, "schema_lists", schema_lists)
        if sort_by and not isinstance(sort_by, str):
            raise TypeError("Expected argument 'sort_by' to be a str")
        pulumi.set(__self__, "sort_by", sort_by)
        if start_time and not isinstance(start_time, str):
            raise TypeError("Expected argument 'start_time' to be a str")
        pulumi.set(__self__, "start_time", start_time)

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> str:
        return pulumi.get(self, "end_time")

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
    @pulumi.getter(name="orderBy")
    def order_by(self) -> Optional[str]:
        return pulumi.get(self, "order_by")

    @property
    @pulumi.getter
    def product(self) -> Optional[str]:
        return pulumi.get(self, "product")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter
    def rows(self) -> Sequence['outputs.GetSlowLogTopSqlsRowResult']:
        """
        Slow log top sql list.
        """
        return pulumi.get(self, "rows")

    @property
    @pulumi.getter(name="schemaLists")
    def schema_lists(self) -> Optional[Sequence['outputs.GetSlowLogTopSqlsSchemaListResult']]:
        return pulumi.get(self, "schema_lists")

    @property
    @pulumi.getter(name="sortBy")
    def sort_by(self) -> Optional[str]:
        return pulumi.get(self, "sort_by")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> str:
        return pulumi.get(self, "start_time")


class AwaitableGetSlowLogTopSqlsResult(GetSlowLogTopSqlsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSlowLogTopSqlsResult(
            end_time=self.end_time,
            id=self.id,
            instance_id=self.instance_id,
            order_by=self.order_by,
            product=self.product,
            result_output_file=self.result_output_file,
            rows=self.rows,
            schema_lists=self.schema_lists,
            sort_by=self.sort_by,
            start_time=self.start_time)


def get_slow_log_top_sqls(end_time: Optional[str] = None,
                          instance_id: Optional[str] = None,
                          order_by: Optional[str] = None,
                          product: Optional[str] = None,
                          result_output_file: Optional[str] = None,
                          schema_lists: Optional[Sequence[pulumi.InputType['GetSlowLogTopSqlsSchemaListArgs']]] = None,
                          sort_by: Optional[str] = None,
                          start_time: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSlowLogTopSqlsResult:
    """
    Use this data source to query detailed information of dbbrain slow_log_top_sqls

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    test = tencentcloud.Dbbrain.get_slow_log_top_sqls(end_time="%s",
        instance_id="%s",
        order_by="ASC",
        product="mysql",
        sort_by="QueryTimeMax",
        start_time="%s")
    ```


    :param str end_time: The deadline, such as `2019-09-11 10:13:14`, the interval between the deadline and the start time is less than 7 days.
    :param str instance_id: instance id.
    :param str order_by: The sorting method supports ASC (ascending) and DESC (descending). The default is DESC.
    :param str product: Service product type, supported values include: `mysql` - cloud database MySQL, `cynosdb` - cloud database CynosDB for MySQL, the default is `mysql`.
    :param str result_output_file: Used to save results.
    :param Sequence[pulumi.InputType['GetSlowLogTopSqlsSchemaListArgs']] schema_lists: Array of database names.
    :param str sort_by: Sort key, currently supports sort keys such as QueryTime, ExecTimes, RowsSent, LockTime and RowsExamined, the default is QueryTime.
    :param str start_time: Start time, such as `2019-09-10 12:13:14`.
    """
    __args__ = dict()
    __args__['endTime'] = end_time
    __args__['instanceId'] = instance_id
    __args__['orderBy'] = order_by
    __args__['product'] = product
    __args__['resultOutputFile'] = result_output_file
    __args__['schemaLists'] = schema_lists
    __args__['sortBy'] = sort_by
    __args__['startTime'] = start_time
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Dbbrain/getSlowLogTopSqls:getSlowLogTopSqls', __args__, opts=opts, typ=GetSlowLogTopSqlsResult).value

    return AwaitableGetSlowLogTopSqlsResult(
        end_time=__ret__.end_time,
        id=__ret__.id,
        instance_id=__ret__.instance_id,
        order_by=__ret__.order_by,
        product=__ret__.product,
        result_output_file=__ret__.result_output_file,
        rows=__ret__.rows,
        schema_lists=__ret__.schema_lists,
        sort_by=__ret__.sort_by,
        start_time=__ret__.start_time)


@_utilities.lift_output_func(get_slow_log_top_sqls)
def get_slow_log_top_sqls_output(end_time: Optional[pulumi.Input[str]] = None,
                                 instance_id: Optional[pulumi.Input[str]] = None,
                                 order_by: Optional[pulumi.Input[Optional[str]]] = None,
                                 product: Optional[pulumi.Input[Optional[str]]] = None,
                                 result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                 schema_lists: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetSlowLogTopSqlsSchemaListArgs']]]]] = None,
                                 sort_by: Optional[pulumi.Input[Optional[str]]] = None,
                                 start_time: Optional[pulumi.Input[str]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSlowLogTopSqlsResult]:
    """
    Use this data source to query detailed information of dbbrain slow_log_top_sqls

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    test = tencentcloud.Dbbrain.get_slow_log_top_sqls(end_time="%s",
        instance_id="%s",
        order_by="ASC",
        product="mysql",
        sort_by="QueryTimeMax",
        start_time="%s")
    ```


    :param str end_time: The deadline, such as `2019-09-11 10:13:14`, the interval between the deadline and the start time is less than 7 days.
    :param str instance_id: instance id.
    :param str order_by: The sorting method supports ASC (ascending) and DESC (descending). The default is DESC.
    :param str product: Service product type, supported values include: `mysql` - cloud database MySQL, `cynosdb` - cloud database CynosDB for MySQL, the default is `mysql`.
    :param str result_output_file: Used to save results.
    :param Sequence[pulumi.InputType['GetSlowLogTopSqlsSchemaListArgs']] schema_lists: Array of database names.
    :param str sort_by: Sort key, currently supports sort keys such as QueryTime, ExecTimes, RowsSent, LockTime and RowsExamined, the default is QueryTime.
    :param str start_time: Start time, such as `2019-09-10 12:13:14`.
    """
    ...