# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetSupportedPrivilegesResult',
    'AwaitableGetSupportedPrivilegesResult',
    'get_supported_privileges',
    'get_supported_privileges_output',
]

@pulumi.output_type
class GetSupportedPrivilegesResult:
    """
    A collection of values returned by getSupportedPrivileges.
    """
    def __init__(__self__, column_supported_privileges=None, database_supported_privileges=None, global_supported_privileges=None, id=None, instance_id=None, result_output_file=None, table_supported_privileges=None):
        if column_supported_privileges and not isinstance(column_supported_privileges, list):
            raise TypeError("Expected argument 'column_supported_privileges' to be a list")
        pulumi.set(__self__, "column_supported_privileges", column_supported_privileges)
        if database_supported_privileges and not isinstance(database_supported_privileges, list):
            raise TypeError("Expected argument 'database_supported_privileges' to be a list")
        pulumi.set(__self__, "database_supported_privileges", database_supported_privileges)
        if global_supported_privileges and not isinstance(global_supported_privileges, list):
            raise TypeError("Expected argument 'global_supported_privileges' to be a list")
        pulumi.set(__self__, "global_supported_privileges", global_supported_privileges)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if table_supported_privileges and not isinstance(table_supported_privileges, list):
            raise TypeError("Expected argument 'table_supported_privileges' to be a list")
        pulumi.set(__self__, "table_supported_privileges", table_supported_privileges)

    @property
    @pulumi.getter(name="columnSupportedPrivileges")
    def column_supported_privileges(self) -> Sequence[str]:
        """
        The database column permissions supported by the instance.
        """
        return pulumi.get(self, "column_supported_privileges")

    @property
    @pulumi.getter(name="databaseSupportedPrivileges")
    def database_supported_privileges(self) -> Sequence[str]:
        """
        Database permissions supported by the instance.
        """
        return pulumi.get(self, "database_supported_privileges")

    @property
    @pulumi.getter(name="globalSupportedPrivileges")
    def global_supported_privileges(self) -> Sequence[str]:
        """
        Global permissions supported by the instance.
        """
        return pulumi.get(self, "global_supported_privileges")

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
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="tableSupportedPrivileges")
    def table_supported_privileges(self) -> Sequence[str]:
        """
        Database table permissions supported by the instance.
        """
        return pulumi.get(self, "table_supported_privileges")


class AwaitableGetSupportedPrivilegesResult(GetSupportedPrivilegesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSupportedPrivilegesResult(
            column_supported_privileges=self.column_supported_privileges,
            database_supported_privileges=self.database_supported_privileges,
            global_supported_privileges=self.global_supported_privileges,
            id=self.id,
            instance_id=self.instance_id,
            result_output_file=self.result_output_file,
            table_supported_privileges=self.table_supported_privileges)


def get_supported_privileges(instance_id: Optional[str] = None,
                             result_output_file: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSupportedPrivilegesResult:
    """
    Use this data source to query detailed information of mysql supported_privileges

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    supported_privileges = tencentcloud.Mysql.get_supported_privileges(instance_id="cdb-fitq5t9h")
    ```
    <!--End PulumiCodeChooser -->


    :param str instance_id: The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['instanceId'] = instance_id
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Mysql/getSupportedPrivileges:getSupportedPrivileges', __args__, opts=opts, typ=GetSupportedPrivilegesResult).value

    return AwaitableGetSupportedPrivilegesResult(
        column_supported_privileges=pulumi.get(__ret__, 'column_supported_privileges'),
        database_supported_privileges=pulumi.get(__ret__, 'database_supported_privileges'),
        global_supported_privileges=pulumi.get(__ret__, 'global_supported_privileges'),
        id=pulumi.get(__ret__, 'id'),
        instance_id=pulumi.get(__ret__, 'instance_id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        table_supported_privileges=pulumi.get(__ret__, 'table_supported_privileges'))


@_utilities.lift_output_func(get_supported_privileges)
def get_supported_privileges_output(instance_id: Optional[pulumi.Input[str]] = None,
                                    result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSupportedPrivilegesResult]:
    """
    Use this data source to query detailed information of mysql supported_privileges

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    supported_privileges = tencentcloud.Mysql.get_supported_privileges(instance_id="cdb-fitq5t9h")
    ```
    <!--End PulumiCodeChooser -->


    :param str instance_id: The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.
    :param str result_output_file: Used to save results.
    """
    ...