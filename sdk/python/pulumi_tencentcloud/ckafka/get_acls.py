# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'GetAclsResult',
    'AwaitableGetAclsResult',
    'get_acls',
    'get_acls_output',
]

@pulumi.output_type
class GetAclsResult:
    """
    A collection of values returned by getAcls.
    """
    def __init__(__self__, acl_lists=None, host=None, id=None, instance_id=None, resource_name=None, resource_type=None, result_output_file=None):
        if acl_lists and not isinstance(acl_lists, list):
            raise TypeError("Expected argument 'acl_lists' to be a list")
        pulumi.set(__self__, "acl_lists", acl_lists)
        if host and not isinstance(host, str):
            raise TypeError("Expected argument 'host' to be a str")
        pulumi.set(__self__, "host", host)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if resource_name and not isinstance(resource_name, str):
            raise TypeError("Expected argument 'resource_name' to be a str")
        pulumi.set(__self__, "resource_name", resource_name)
        if resource_type and not isinstance(resource_type, str):
            raise TypeError("Expected argument 'resource_type' to be a str")
        pulumi.set(__self__, "resource_type", resource_type)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="aclLists")
    def acl_lists(self) -> Sequence['outputs.GetAclsAclListResult']:
        """
        A list of ckafka acls. Each element contains the following attributes:
        """
        return pulumi.get(self, "acl_lists")

    @property
    @pulumi.getter
    def host(self) -> Optional[str]:
        """
        IP address allowed to access.
        """
        return pulumi.get(self, "host")

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
    @pulumi.getter(name="resourceName")
    def resource_name(self) -> str:
        """
        ACL resource name, which is related to `resource_type`.
        """
        return pulumi.get(self, "resource_name")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> str:
        """
        ACL resource type.
        """
        return pulumi.get(self, "resource_type")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetAclsResult(GetAclsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAclsResult(
            acl_lists=self.acl_lists,
            host=self.host,
            id=self.id,
            instance_id=self.instance_id,
            resource_name=self.resource_name,
            resource_type=self.resource_type,
            result_output_file=self.result_output_file)


def get_acls(host: Optional[str] = None,
             instance_id: Optional[str] = None,
             resource_name: Optional[str] = None,
             resource_type: Optional[str] = None,
             result_output_file: Optional[str] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAclsResult:
    """
    Use this data source to query detailed acl information of Ckafka

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    foo = tencentcloud.Ckafka.get_acls(host="2",
        instance_id="ckafka-f9ife4zz",
        resource_name="topic-tf-test",
        resource_type="TOPIC")
    ```


    :param str host: Host substr used for querying.
    :param str instance_id: Id of the ckafka instance.
    :param str resource_name: ACL resource name, which is related to `resource_type`. For example, if `resource_type` is `TOPIC`, this field indicates the topic name; if `resource_type` is `GROUP`, this field indicates the group name.
    :param str resource_type: ACL resource type. Valid values are `UNKNOWN`, `ANY`, `TOPIC`, `GROUP`, `CLUSTER`, `TRANSACTIONAL_ID`. Currently, only `TOPIC` is available, and other fields will be used for future ACLs compatible with open-source Kafka.
    :param str result_output_file: Used to save results.
    """
    __args__ = dict()
    __args__['host'] = host
    __args__['instanceId'] = instance_id
    __args__['resourceName'] = resource_name
    __args__['resourceType'] = resource_type
    __args__['resultOutputFile'] = result_output_file
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Ckafka/getAcls:getAcls', __args__, opts=opts, typ=GetAclsResult).value

    return AwaitableGetAclsResult(
        acl_lists=__ret__.acl_lists,
        host=__ret__.host,
        id=__ret__.id,
        instance_id=__ret__.instance_id,
        resource_name=__ret__.resource_name,
        resource_type=__ret__.resource_type,
        result_output_file=__ret__.result_output_file)


@_utilities.lift_output_func(get_acls)
def get_acls_output(host: Optional[pulumi.Input[Optional[str]]] = None,
                    instance_id: Optional[pulumi.Input[str]] = None,
                    resource_name: Optional[pulumi.Input[str]] = None,
                    resource_type: Optional[pulumi.Input[str]] = None,
                    result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAclsResult]:
    """
    Use this data source to query detailed acl information of Ckafka

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    foo = tencentcloud.Ckafka.get_acls(host="2",
        instance_id="ckafka-f9ife4zz",
        resource_name="topic-tf-test",
        resource_type="TOPIC")
    ```


    :param str host: Host substr used for querying.
    :param str instance_id: Id of the ckafka instance.
    :param str resource_name: ACL resource name, which is related to `resource_type`. For example, if `resource_type` is `TOPIC`, this field indicates the topic name; if `resource_type` is `GROUP`, this field indicates the group name.
    :param str resource_type: ACL resource type. Valid values are `UNKNOWN`, `ANY`, `TOPIC`, `GROUP`, `CLUSTER`, `TRANSACTIONAL_ID`. Currently, only `TOPIC` is available, and other fields will be used for future ACLs compatible with open-source Kafka.
    :param str result_output_file: Used to save results.
    """
    ...