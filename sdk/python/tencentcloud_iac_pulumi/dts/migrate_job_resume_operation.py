# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['MigrateJobResumeOperationArgs', 'MigrateJobResumeOperation']

@pulumi.input_type
class MigrateJobResumeOperationArgs:
    def __init__(__self__, *,
                 job_id: pulumi.Input[str],
                 resume_option: pulumi.Input[str]):
        """
        The set of arguments for constructing a MigrateJobResumeOperation resource.
        :param pulumi.Input[str] job_id: job id.
        :param pulumi.Input[str] resume_option: resume mode: 1.clearData-Clear target data; 2.overwrite-The task is executed in overwrite mode; 3.normal-No extra action. Note that clearData and overwrite are valid only for redis links, normal is valid only for non-Redis links.
        """
        pulumi.set(__self__, "job_id", job_id)
        pulumi.set(__self__, "resume_option", resume_option)

    @property
    @pulumi.getter(name="jobId")
    def job_id(self) -> pulumi.Input[str]:
        """
        job id.
        """
        return pulumi.get(self, "job_id")

    @job_id.setter
    def job_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "job_id", value)

    @property
    @pulumi.getter(name="resumeOption")
    def resume_option(self) -> pulumi.Input[str]:
        """
        resume mode: 1.clearData-Clear target data; 2.overwrite-The task is executed in overwrite mode; 3.normal-No extra action. Note that clearData and overwrite are valid only for redis links, normal is valid only for non-Redis links.
        """
        return pulumi.get(self, "resume_option")

    @resume_option.setter
    def resume_option(self, value: pulumi.Input[str]):
        pulumi.set(self, "resume_option", value)


@pulumi.input_type
class _MigrateJobResumeOperationState:
    def __init__(__self__, *,
                 job_id: Optional[pulumi.Input[str]] = None,
                 resume_option: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering MigrateJobResumeOperation resources.
        :param pulumi.Input[str] job_id: job id.
        :param pulumi.Input[str] resume_option: resume mode: 1.clearData-Clear target data; 2.overwrite-The task is executed in overwrite mode; 3.normal-No extra action. Note that clearData and overwrite are valid only for redis links, normal is valid only for non-Redis links.
        """
        if job_id is not None:
            pulumi.set(__self__, "job_id", job_id)
        if resume_option is not None:
            pulumi.set(__self__, "resume_option", resume_option)

    @property
    @pulumi.getter(name="jobId")
    def job_id(self) -> Optional[pulumi.Input[str]]:
        """
        job id.
        """
        return pulumi.get(self, "job_id")

    @job_id.setter
    def job_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "job_id", value)

    @property
    @pulumi.getter(name="resumeOption")
    def resume_option(self) -> Optional[pulumi.Input[str]]:
        """
        resume mode: 1.clearData-Clear target data; 2.overwrite-The task is executed in overwrite mode; 3.normal-No extra action. Note that clearData and overwrite are valid only for redis links, normal is valid only for non-Redis links.
        """
        return pulumi.get(self, "resume_option")

    @resume_option.setter
    def resume_option(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resume_option", value)


class MigrateJobResumeOperation(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 job_id: Optional[pulumi.Input[str]] = None,
                 resume_option: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a dts migrate_job_resume_operation

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        resume = tencentcloud.dts.MigrateJobResumeOperation("resume",
            job_id="job_id",
            resume_option="normal")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] job_id: job id.
        :param pulumi.Input[str] resume_option: resume mode: 1.clearData-Clear target data; 2.overwrite-The task is executed in overwrite mode; 3.normal-No extra action. Note that clearData and overwrite are valid only for redis links, normal is valid only for non-Redis links.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: MigrateJobResumeOperationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a dts migrate_job_resume_operation

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        resume = tencentcloud.dts.MigrateJobResumeOperation("resume",
            job_id="job_id",
            resume_option="normal")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param MigrateJobResumeOperationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(MigrateJobResumeOperationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 job_id: Optional[pulumi.Input[str]] = None,
                 resume_option: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = MigrateJobResumeOperationArgs.__new__(MigrateJobResumeOperationArgs)

            if job_id is None and not opts.urn:
                raise TypeError("Missing required property 'job_id'")
            __props__.__dict__["job_id"] = job_id
            if resume_option is None and not opts.urn:
                raise TypeError("Missing required property 'resume_option'")
            __props__.__dict__["resume_option"] = resume_option
        super(MigrateJobResumeOperation, __self__).__init__(
            'tencentcloud:Dts/migrateJobResumeOperation:MigrateJobResumeOperation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            job_id: Optional[pulumi.Input[str]] = None,
            resume_option: Optional[pulumi.Input[str]] = None) -> 'MigrateJobResumeOperation':
        """
        Get an existing MigrateJobResumeOperation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] job_id: job id.
        :param pulumi.Input[str] resume_option: resume mode: 1.clearData-Clear target data; 2.overwrite-The task is executed in overwrite mode; 3.normal-No extra action. Note that clearData and overwrite are valid only for redis links, normal is valid only for non-Redis links.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _MigrateJobResumeOperationState.__new__(_MigrateJobResumeOperationState)

        __props__.__dict__["job_id"] = job_id
        __props__.__dict__["resume_option"] = resume_option
        return MigrateJobResumeOperation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="jobId")
    def job_id(self) -> pulumi.Output[str]:
        """
        job id.
        """
        return pulumi.get(self, "job_id")

    @property
    @pulumi.getter(name="resumeOption")
    def resume_option(self) -> pulumi.Output[str]:
        """
        resume mode: 1.clearData-Clear target data; 2.overwrite-The task is executed in overwrite mode; 3.normal-No extra action. Note that clearData and overwrite are valid only for redis links, normal is valid only for non-Redis links.
        """
        return pulumi.get(self, "resume_option")

