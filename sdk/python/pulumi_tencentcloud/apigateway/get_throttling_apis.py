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
    'GetThrottlingApisResult',
    'AwaitableGetThrottlingApisResult',
    'get_throttling_apis',
    'get_throttling_apis_output',
]

@pulumi.output_type
class GetThrottlingApisResult:
    """
    A collection of values returned by getThrottlingApis.
    """
    def __init__(__self__, environment_names=None, id=None, lists=None, result_output_file=None, service_id=None):
        if environment_names and not isinstance(environment_names, list):
            raise TypeError("Expected argument 'environment_names' to be a list")
        pulumi.set(__self__, "environment_names", environment_names)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if lists and not isinstance(lists, list):
            raise TypeError("Expected argument 'lists' to be a list")
        pulumi.set(__self__, "lists", lists)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if service_id and not isinstance(service_id, str):
            raise TypeError("Expected argument 'service_id' to be a str")
        pulumi.set(__self__, "service_id", service_id)

    @property
    @pulumi.getter(name="environmentNames")
    def environment_names(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "environment_names")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def lists(self) -> Sequence['outputs.GetThrottlingApisListResult']:
        """
        A list of policies bound to API.
        """
        return pulumi.get(self, "lists")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="serviceId")
    def service_id(self) -> Optional[str]:
        """
        Unique service ID of API.
        """
        return pulumi.get(self, "service_id")


class AwaitableGetThrottlingApisResult(GetThrottlingApisResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetThrottlingApisResult(
            environment_names=self.environment_names,
            id=self.id,
            lists=self.lists,
            result_output_file=self.result_output_file,
            service_id=self.service_id)


def get_throttling_apis(environment_names: Optional[Sequence[str]] = None,
                        result_output_file: Optional[str] = None,
                        service_id: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetThrottlingApisResult:
    """
    Use this data source to query API gateway throttling APIs.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    service = tencentcloud.api_gateway.Service("service",
        service_name="niceservice",
        protocol="http&https",
        service_desc="your nice service",
        net_types=[
            "INNER",
            "OUTER",
        ],
        ip_version="IPv4")
    api = tencentcloud.api_gateway.Api("api",
        service_id=service.id,
        api_name="hello_update",
        api_desc="my hello api update",
        auth_type="SECRET",
        protocol="HTTP",
        enable_cors=True,
        request_config_path="/user/info",
        request_config_method="POST",
        request_parameters=[tencentcloud.api.gateway.ApiRequestParameterArgs(
            name="email",
            position="QUERY",
            type="string",
            desc="your email please?",
            default_value="tom@qq.com",
            required=True,
        )],
        service_config_type="HTTP",
        service_config_timeout=10,
        service_config_url="http://www.tencent.com",
        service_config_path="/user",
        service_config_method="POST",
        response_type="XML",
        response_success_example="<note>success</note>",
        response_fail_example="<note>fail</note>",
        response_error_codes=[tencentcloud.api.gateway.ApiResponseErrorCodeArgs(
            code=10,
            msg="system error",
            desc="system error code",
            converted_code=-10,
            need_convert=True,
        )],
        release_limit=100,
        pre_limit=100,
        test_limit=100)
    id = tencentcloud.ApiGateway.get_throttling_apis(service_id=tencentcloud_api_gateway_api["service_id"])
    foo = tencentcloud.ApiGateway.get_throttling_apis(service_id=tencentcloud_api_gateway_api["service"]["service_id"],
        environment_names=[
            "release",
            "test",
        ])
    ```


    :param Sequence[str] environment_names: Environment list.
    :param str result_output_file: Used to save results.
    :param str service_id: Unique service ID of API.
    """
    __args__ = dict()
    __args__['environmentNames'] = environment_names
    __args__['resultOutputFile'] = result_output_file
    __args__['serviceId'] = service_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('tencentcloud:ApiGateway/getThrottlingApis:getThrottlingApis', __args__, opts=opts, typ=GetThrottlingApisResult).value

    return AwaitableGetThrottlingApisResult(
        environment_names=__ret__.environment_names,
        id=__ret__.id,
        lists=__ret__.lists,
        result_output_file=__ret__.result_output_file,
        service_id=__ret__.service_id)


@_utilities.lift_output_func(get_throttling_apis)
def get_throttling_apis_output(environment_names: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                               result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                               service_id: Optional[pulumi.Input[Optional[str]]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetThrottlingApisResult]:
    """
    Use this data source to query API gateway throttling APIs.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    service = tencentcloud.api_gateway.Service("service",
        service_name="niceservice",
        protocol="http&https",
        service_desc="your nice service",
        net_types=[
            "INNER",
            "OUTER",
        ],
        ip_version="IPv4")
    api = tencentcloud.api_gateway.Api("api",
        service_id=service.id,
        api_name="hello_update",
        api_desc="my hello api update",
        auth_type="SECRET",
        protocol="HTTP",
        enable_cors=True,
        request_config_path="/user/info",
        request_config_method="POST",
        request_parameters=[tencentcloud.api.gateway.ApiRequestParameterArgs(
            name="email",
            position="QUERY",
            type="string",
            desc="your email please?",
            default_value="tom@qq.com",
            required=True,
        )],
        service_config_type="HTTP",
        service_config_timeout=10,
        service_config_url="http://www.tencent.com",
        service_config_path="/user",
        service_config_method="POST",
        response_type="XML",
        response_success_example="<note>success</note>",
        response_fail_example="<note>fail</note>",
        response_error_codes=[tencentcloud.api.gateway.ApiResponseErrorCodeArgs(
            code=10,
            msg="system error",
            desc="system error code",
            converted_code=-10,
            need_convert=True,
        )],
        release_limit=100,
        pre_limit=100,
        test_limit=100)
    id = tencentcloud.ApiGateway.get_throttling_apis(service_id=tencentcloud_api_gateway_api["service_id"])
    foo = tencentcloud.ApiGateway.get_throttling_apis(service_id=tencentcloud_api_gateway_api["service"]["service_id"],
        environment_names=[
            "release",
            "test",
        ])
    ```


    :param Sequence[str] environment_names: Environment list.
    :param str result_output_file: Used to save results.
    :param str service_id: Unique service ID of API.
    """
    ...