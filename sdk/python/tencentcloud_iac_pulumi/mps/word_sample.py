# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['WordSampleArgs', 'WordSample']

@pulumi.input_type
class WordSampleArgs:
    def __init__(__self__, *,
                 keyword: pulumi.Input[str],
                 usages: pulumi.Input[Sequence[pulumi.Input[str]]],
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a WordSample resource.
        :param pulumi.Input[str] keyword: Keyword. Length limit: 20 characters.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] usages: Keyword usage. Valid values: 1.`Recognition.Ocr`: OCR-based content recognition. 2.`Recognition.Asr`: ASR-based content recognition. 3.`Review.Ocr`: OCR-based inappropriate information recognition. 4.`Review.Asr`: ASR-based inappropriate information recognition.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: Keyword tag. Array length limit: 20 tags. Each tag length limit: 128 characters.
        """
        pulumi.set(__self__, "keyword", keyword)
        pulumi.set(__self__, "usages", usages)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def keyword(self) -> pulumi.Input[str]:
        """
        Keyword. Length limit: 20 characters.
        """
        return pulumi.get(self, "keyword")

    @keyword.setter
    def keyword(self, value: pulumi.Input[str]):
        pulumi.set(self, "keyword", value)

    @property
    @pulumi.getter
    def usages(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        Keyword usage. Valid values: 1.`Recognition.Ocr`: OCR-based content recognition. 2.`Recognition.Asr`: ASR-based content recognition. 3.`Review.Ocr`: OCR-based inappropriate information recognition. 4.`Review.Asr`: ASR-based inappropriate information recognition.
        """
        return pulumi.get(self, "usages")

    @usages.setter
    def usages(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "usages", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Keyword tag. Array length limit: 20 tags. Each tag length limit: 128 characters.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)


@pulumi.input_type
class _WordSampleState:
    def __init__(__self__, *,
                 keyword: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 usages: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering WordSample resources.
        :param pulumi.Input[str] keyword: Keyword. Length limit: 20 characters.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: Keyword tag. Array length limit: 20 tags. Each tag length limit: 128 characters.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] usages: Keyword usage. Valid values: 1.`Recognition.Ocr`: OCR-based content recognition. 2.`Recognition.Asr`: ASR-based content recognition. 3.`Review.Ocr`: OCR-based inappropriate information recognition. 4.`Review.Asr`: ASR-based inappropriate information recognition.
        """
        if keyword is not None:
            pulumi.set(__self__, "keyword", keyword)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if usages is not None:
            pulumi.set(__self__, "usages", usages)

    @property
    @pulumi.getter
    def keyword(self) -> Optional[pulumi.Input[str]]:
        """
        Keyword. Length limit: 20 characters.
        """
        return pulumi.get(self, "keyword")

    @keyword.setter
    def keyword(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "keyword", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Keyword tag. Array length limit: 20 tags. Each tag length limit: 128 characters.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter
    def usages(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Keyword usage. Valid values: 1.`Recognition.Ocr`: OCR-based content recognition. 2.`Recognition.Asr`: ASR-based content recognition. 3.`Review.Ocr`: OCR-based inappropriate information recognition. 4.`Review.Asr`: ASR-based inappropriate information recognition.
        """
        return pulumi.get(self, "usages")

    @usages.setter
    def usages(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "usages", value)


class WordSample(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 keyword: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 usages: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Provides a resource to create a mps word_sample

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        word_sample = tencentcloud.mps.WordSample("wordSample",
            keyword="tf_test_kw_1",
            tags=[
                "tags_1",
                "tags_2",
            ],
            usages=[
                "Recognition.Ocr",
                "Review.Ocr",
                "Review.Asr",
            ])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        mps word_sample can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Mps/wordSample:WordSample word_sample keyword
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] keyword: Keyword. Length limit: 20 characters.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: Keyword tag. Array length limit: 20 tags. Each tag length limit: 128 characters.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] usages: Keyword usage. Valid values: 1.`Recognition.Ocr`: OCR-based content recognition. 2.`Recognition.Asr`: ASR-based content recognition. 3.`Review.Ocr`: OCR-based inappropriate information recognition. 4.`Review.Asr`: ASR-based inappropriate information recognition.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: WordSampleArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a mps word_sample

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        word_sample = tencentcloud.mps.WordSample("wordSample",
            keyword="tf_test_kw_1",
            tags=[
                "tags_1",
                "tags_2",
            ],
            usages=[
                "Recognition.Ocr",
                "Review.Ocr",
                "Review.Asr",
            ])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        mps word_sample can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Mps/wordSample:WordSample word_sample keyword
        ```

        :param str resource_name: The name of the resource.
        :param WordSampleArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(WordSampleArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 keyword: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 usages: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = WordSampleArgs.__new__(WordSampleArgs)

            if keyword is None and not opts.urn:
                raise TypeError("Missing required property 'keyword'")
            __props__.__dict__["keyword"] = keyword
            __props__.__dict__["tags"] = tags
            if usages is None and not opts.urn:
                raise TypeError("Missing required property 'usages'")
            __props__.__dict__["usages"] = usages
        super(WordSample, __self__).__init__(
            'tencentcloud:Mps/wordSample:WordSample',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            keyword: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            usages: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'WordSample':
        """
        Get an existing WordSample resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] keyword: Keyword. Length limit: 20 characters.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: Keyword tag. Array length limit: 20 tags. Each tag length limit: 128 characters.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] usages: Keyword usage. Valid values: 1.`Recognition.Ocr`: OCR-based content recognition. 2.`Recognition.Asr`: ASR-based content recognition. 3.`Review.Ocr`: OCR-based inappropriate information recognition. 4.`Review.Asr`: ASR-based inappropriate information recognition.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _WordSampleState.__new__(_WordSampleState)

        __props__.__dict__["keyword"] = keyword
        __props__.__dict__["tags"] = tags
        __props__.__dict__["usages"] = usages
        return WordSample(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def keyword(self) -> pulumi.Output[str]:
        """
        Keyword. Length limit: 20 characters.
        """
        return pulumi.get(self, "keyword")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Keyword tag. Array length limit: 20 tags. Each tag length limit: 128 characters.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def usages(self) -> pulumi.Output[Sequence[str]]:
        """
        Keyword usage. Valid values: 1.`Recognition.Ocr`: OCR-based content recognition. 2.`Recognition.Asr`: ASR-based content recognition. 3.`Review.Ocr`: OCR-based inappropriate information recognition. 4.`Review.Asr`: ASR-based inappropriate information recognition.
        """
        return pulumi.get(self, "usages")

