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
    'GetAlarmNoticeCallbacksResult',
    'AwaitableGetAlarmNoticeCallbacksResult',
    'get_alarm_notice_callbacks',
    'get_alarm_notice_callbacks_output',
]

@pulumi.output_type
class GetAlarmNoticeCallbacksResult:
    """
    A collection of values returned by getAlarmNoticeCallbacks.
    """
    def __init__(__self__, id=None, result_output_file=None, tags=None, url_notices=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if url_notices and not isinstance(url_notices, list):
            raise TypeError("Expected argument 'url_notices' to be a list")
        pulumi.set(__self__, "url_notices", url_notices)

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
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, Any]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="urlNotices")
    def url_notices(self) -> Sequence['outputs.GetAlarmNoticeCallbacksUrlNoticeResult']:
        """
        Alarm callback notification.
        """
        return pulumi.get(self, "url_notices")


class AwaitableGetAlarmNoticeCallbacksResult(GetAlarmNoticeCallbacksResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAlarmNoticeCallbacksResult(
            id=self.id,
            result_output_file=self.result_output_file,
            tags=self.tags,
            url_notices=self.url_notices)


def get_alarm_notice_callbacks(result_output_file: Optional[str] = None,
                               tags: Optional[Mapping[str, Any]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAlarmNoticeCallbacksResult:
    """
    Use this data source to query detailed information of monitor alarm_notice_callbacks

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    alarm_notice_callbacks = tencentcloud.Monitor.get_alarm_notice_callbacks()
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    :param Mapping[str, Any] tags: Tag description list.
    """
    __args__ = dict()
    __args__['resultOutputFile'] = result_output_file
    __args__['tags'] = tags
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Monitor/getAlarmNoticeCallbacks:getAlarmNoticeCallbacks', __args__, opts=opts, typ=GetAlarmNoticeCallbacksResult).value

    return AwaitableGetAlarmNoticeCallbacksResult(
        id=pulumi.get(__ret__, 'id'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        tags=pulumi.get(__ret__, 'tags'),
        url_notices=pulumi.get(__ret__, 'url_notices'))


@_utilities.lift_output_func(get_alarm_notice_callbacks)
def get_alarm_notice_callbacks_output(result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                      tags: Optional[pulumi.Input[Optional[Mapping[str, Any]]]] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAlarmNoticeCallbacksResult]:
    """
    Use this data source to query detailed information of monitor alarm_notice_callbacks

    ## Example Usage

    <!--Start PulumiCodeChooser -->
    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    alarm_notice_callbacks = tencentcloud.Monitor.get_alarm_notice_callbacks()
    ```
    <!--End PulumiCodeChooser -->


    :param str result_output_file: Used to save results.
    :param Mapping[str, Any] tags: Tag description list.
    """
    ...
