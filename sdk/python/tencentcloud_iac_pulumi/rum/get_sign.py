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
    'GetSignResult',
    'AwaitableGetSignResult',
    'get_sign',
    'get_sign_output',
]

@pulumi.output_type
class GetSignResult:
    """
    A collection of values returned by getSign.
    """
    def __init__(__self__, expired_time=None, file_type=None, id=None, result_output_file=None, secret_id=None, secret_key=None, session_token=None, start_time=None, timeout=None):
        if expired_time and not isinstance(expired_time, int):
            raise TypeError("Expected argument 'expired_time' to be a int")
        pulumi.set(__self__, "expired_time", expired_time)
        if file_type and not isinstance(file_type, int):
            raise TypeError("Expected argument 'file_type' to be a int")
        pulumi.set(__self__, "file_type", file_type)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if secret_id and not isinstance(secret_id, str):
            raise TypeError("Expected argument 'secret_id' to be a str")
        pulumi.set(__self__, "secret_id", secret_id)
        if secret_key and not isinstance(secret_key, str):
            raise TypeError("Expected argument 'secret_key' to be a str")
        pulumi.set(__self__, "secret_key", secret_key)
        if session_token and not isinstance(session_token, str):
            raise TypeError("Expected argument 'session_token' to be a str")
        pulumi.set(__self__, "session_token", session_token)
        if start_time and not isinstance(start_time, int):
            raise TypeError("Expected argument 'start_time' to be a int")
        pulumi.set(__self__, "start_time", start_time)
        if timeout and not isinstance(timeout, int):
            raise TypeError("Expected argument 'timeout' to be a int")
        pulumi.set(__self__, "timeout", timeout)

    @property
    @pulumi.getter(name="expiredTime")
    def expired_time(self) -> int:
        """
        Expiration timestamp.
        """
        return pulumi.get(self, "expired_time")

    @property
    @pulumi.getter(name="fileType")
    def file_type(self) -> Optional[int]:
        return pulumi.get(self, "file_type")

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

    @property
    @pulumi.getter(name="secretId")
    def secret_id(self) -> str:
        """
        Temporary access key ID.
        """
        return pulumi.get(self, "secret_id")

    @property
    @pulumi.getter(name="secretKey")
    def secret_key(self) -> str:
        """
        Temporary access key.
        """
        return pulumi.get(self, "secret_key")

    @property
    @pulumi.getter(name="sessionToken")
    def session_token(self) -> str:
        """
        Temporary access key token.
        """
        return pulumi.get(self, "session_token")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> int:
        """
        Start timestamp.
        """
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter
    def timeout(self) -> Optional[int]:
        return pulumi.get(self, "timeout")


class AwaitableGetSignResult(GetSignResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSignResult(
            expired_time=self.expired_time,
            file_type=self.file_type,
            id=self.id,
            result_output_file=self.result_output_file,
            secret_id=self.secret_id,
            secret_key=self.secret_key,
            session_token=self.session_token,
            start_time=self.start_time,
            timeout=self.timeout)


def get_sign(file_type: Optional[int] = None,
             result_output_file: Optional[str] = None,
             timeout: Optional[int] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSignResult:
    """
    Use this data source to query detailed information of rum sign

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    sign = tencentcloud.Rum.get_sign(file_type=1,
        timeout=1800)
    ```
    <!--End PulumiCodeChooser -->


    :param int file_type: Bucket type. `1`:web project; `2`:app project.
    :param str result_output_file: Used to save results.
    :param int timeout: Timeout duration.
    """
    __args__ = dict()
    __args__['fileType'] = file_type
    __args__['resultOutputFile'] = result_output_file
    __args__['timeout'] = timeout
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Rum/getSign:getSign', __args__, opts=opts, typ=GetSignResult).value

    return AwaitableGetSignResult(
        expired_time=pulumi.get(__ret__, 'expired_time'),
        file_type=pulumi.get(__ret__, 'file_type'),
        id=pulumi.get(__ret__, 'id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        secret_id=pulumi.get(__ret__, 'secret_id'),
        secret_key=pulumi.get(__ret__, 'secret_key'),
        session_token=pulumi.get(__ret__, 'session_token'),
        start_time=pulumi.get(__ret__, 'start_time'),
        timeout=pulumi.get(__ret__, 'timeout'))


@_utilities.lift_output_func(get_sign)
def get_sign_output(file_type: Optional[pulumi.Input[Optional[int]]] = None,
                    result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                    timeout: Optional[pulumi.Input[Optional[int]]] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSignResult]:
    """
    Use this data source to query detailed information of rum sign

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    sign = tencentcloud.Rum.get_sign(file_type=1,
        timeout=1800)
    ```
    <!--End PulumiCodeChooser -->


    :param int file_type: Bucket type. `1`:web project; `2`:app project.
    :param str result_output_file: Used to save results.
    :param int timeout: Timeout duration.
    """
    ...