# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['AccessKeyArgs', 'AccessKey']

@pulumi.input_type
class AccessKeyArgs:
    def __init__(__self__, *,
                 access_key: Optional[pulumi.Input[str]] = None,
                 pgp_key: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 target_uin: Optional[pulumi.Input[int]] = None):
        """
        The set of arguments for constructing a AccessKey resource.
        :param pulumi.Input[str] access_key: Access_key is the access key identification, required when updating.
        :param pulumi.Input[str] pgp_key: Either a base-64 encoded PGP public key, or a keybase username in the form keybase:some_person_that_exists, for use in the encrypted_secret output attribute. If providing a base-64 encoded PGP public key, make sure to provide the "raw" version and not the "armored" one (e.g. avoid passing the -a option to gpg --export).
        :param pulumi.Input[str] status: Key status, activated (Active) or inactive (Inactive), required when updating.
        :param pulumi.Input[int] target_uin: Specify user Uin, if not filled, the access key is created for the current user by default.
        """
        if access_key is not None:
            pulumi.set(__self__, "access_key", access_key)
        if pgp_key is not None:
            pulumi.set(__self__, "pgp_key", pgp_key)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if target_uin is not None:
            pulumi.set(__self__, "target_uin", target_uin)

    @property
    @pulumi.getter(name="accessKey")
    def access_key(self) -> Optional[pulumi.Input[str]]:
        """
        Access_key is the access key identification, required when updating.
        """
        return pulumi.get(self, "access_key")

    @access_key.setter
    def access_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_key", value)

    @property
    @pulumi.getter(name="pgpKey")
    def pgp_key(self) -> Optional[pulumi.Input[str]]:
        """
        Either a base-64 encoded PGP public key, or a keybase username in the form keybase:some_person_that_exists, for use in the encrypted_secret output attribute. If providing a base-64 encoded PGP public key, make sure to provide the "raw" version and not the "armored" one (e.g. avoid passing the -a option to gpg --export).
        """
        return pulumi.get(self, "pgp_key")

    @pgp_key.setter
    def pgp_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pgp_key", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Key status, activated (Active) or inactive (Inactive), required when updating.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="targetUin")
    def target_uin(self) -> Optional[pulumi.Input[int]]:
        """
        Specify user Uin, if not filled, the access key is created for the current user by default.
        """
        return pulumi.get(self, "target_uin")

    @target_uin.setter
    def target_uin(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "target_uin", value)


@pulumi.input_type
class _AccessKeyState:
    def __init__(__self__, *,
                 access_key: Optional[pulumi.Input[str]] = None,
                 encrypted_secret_access_key: Optional[pulumi.Input[str]] = None,
                 key_fingerprint: Optional[pulumi.Input[str]] = None,
                 pgp_key: Optional[pulumi.Input[str]] = None,
                 secret_access_key: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 target_uin: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering AccessKey resources.
        :param pulumi.Input[str] access_key: Access_key is the access key identification, required when updating.
        :param pulumi.Input[str] encrypted_secret_access_key: Encrypted secret, base64 encoded, if pgp_key was specified. This attribute is not available for imported resources. The
               encrypted secret may be decrypted using the command line, for example: terraform output -raw encrypted_secret | base64
               --decode | keybase pgp decrypt.
        :param pulumi.Input[str] key_fingerprint: Fingerprint of the PGP key used to encrypt the secret. This attribute is not available for imported resources.
        :param pulumi.Input[str] pgp_key: Either a base-64 encoded PGP public key, or a keybase username in the form keybase:some_person_that_exists, for use in the encrypted_secret output attribute. If providing a base-64 encoded PGP public key, make sure to provide the "raw" version and not the "armored" one (e.g. avoid passing the -a option to gpg --export).
        :param pulumi.Input[str] secret_access_key: Access key (key is only visible when created, please keep it properly).
        :param pulumi.Input[str] status: Key status, activated (Active) or inactive (Inactive), required when updating.
        :param pulumi.Input[int] target_uin: Specify user Uin, if not filled, the access key is created for the current user by default.
        """
        if access_key is not None:
            pulumi.set(__self__, "access_key", access_key)
        if encrypted_secret_access_key is not None:
            pulumi.set(__self__, "encrypted_secret_access_key", encrypted_secret_access_key)
        if key_fingerprint is not None:
            pulumi.set(__self__, "key_fingerprint", key_fingerprint)
        if pgp_key is not None:
            pulumi.set(__self__, "pgp_key", pgp_key)
        if secret_access_key is not None:
            pulumi.set(__self__, "secret_access_key", secret_access_key)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if target_uin is not None:
            pulumi.set(__self__, "target_uin", target_uin)

    @property
    @pulumi.getter(name="accessKey")
    def access_key(self) -> Optional[pulumi.Input[str]]:
        """
        Access_key is the access key identification, required when updating.
        """
        return pulumi.get(self, "access_key")

    @access_key.setter
    def access_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_key", value)

    @property
    @pulumi.getter(name="encryptedSecretAccessKey")
    def encrypted_secret_access_key(self) -> Optional[pulumi.Input[str]]:
        """
        Encrypted secret, base64 encoded, if pgp_key was specified. This attribute is not available for imported resources. The
        encrypted secret may be decrypted using the command line, for example: terraform output -raw encrypted_secret | base64
        --decode | keybase pgp decrypt.
        """
        return pulumi.get(self, "encrypted_secret_access_key")

    @encrypted_secret_access_key.setter
    def encrypted_secret_access_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "encrypted_secret_access_key", value)

    @property
    @pulumi.getter(name="keyFingerprint")
    def key_fingerprint(self) -> Optional[pulumi.Input[str]]:
        """
        Fingerprint of the PGP key used to encrypt the secret. This attribute is not available for imported resources.
        """
        return pulumi.get(self, "key_fingerprint")

    @key_fingerprint.setter
    def key_fingerprint(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key_fingerprint", value)

    @property
    @pulumi.getter(name="pgpKey")
    def pgp_key(self) -> Optional[pulumi.Input[str]]:
        """
        Either a base-64 encoded PGP public key, or a keybase username in the form keybase:some_person_that_exists, for use in the encrypted_secret output attribute. If providing a base-64 encoded PGP public key, make sure to provide the "raw" version and not the "armored" one (e.g. avoid passing the -a option to gpg --export).
        """
        return pulumi.get(self, "pgp_key")

    @pgp_key.setter
    def pgp_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pgp_key", value)

    @property
    @pulumi.getter(name="secretAccessKey")
    def secret_access_key(self) -> Optional[pulumi.Input[str]]:
        """
        Access key (key is only visible when created, please keep it properly).
        """
        return pulumi.get(self, "secret_access_key")

    @secret_access_key.setter
    def secret_access_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "secret_access_key", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Key status, activated (Active) or inactive (Inactive), required when updating.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="targetUin")
    def target_uin(self) -> Optional[pulumi.Input[int]]:
        """
        Specify user Uin, if not filled, the access key is created for the current user by default.
        """
        return pulumi.get(self, "target_uin")

    @target_uin.setter
    def target_uin(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "target_uin", value)


class AccessKey(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_key: Optional[pulumi.Input[str]] = None,
                 pgp_key: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 target_uin: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Provides a resource to create a cam access_key

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        access_key = tencentcloud.cam.AccessKey("accessKey", target_uin=100033690181)
        ```
        <!--End PulumiCodeChooser -->

        ### Update

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        access_key = tencentcloud.cam.AccessKey("accessKey",
            status="Inactive",
            target_uin=100033690181)
        ```
        <!--End PulumiCodeChooser -->

        ### Encrypted

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        access_key = tencentcloud.cam.AccessKey("accessKey",
            pgp_key="keybase:some_person_that_exists",
            target_uin=100033690181)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cam access_key can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cam/accessKey:AccessKey access_key access_key_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] access_key: Access_key is the access key identification, required when updating.
        :param pulumi.Input[str] pgp_key: Either a base-64 encoded PGP public key, or a keybase username in the form keybase:some_person_that_exists, for use in the encrypted_secret output attribute. If providing a base-64 encoded PGP public key, make sure to provide the "raw" version and not the "armored" one (e.g. avoid passing the -a option to gpg --export).
        :param pulumi.Input[str] status: Key status, activated (Active) or inactive (Inactive), required when updating.
        :param pulumi.Input[int] target_uin: Specify user Uin, if not filled, the access key is created for the current user by default.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[AccessKeyArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a cam access_key

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        access_key = tencentcloud.cam.AccessKey("accessKey", target_uin=100033690181)
        ```
        <!--End PulumiCodeChooser -->

        ### Update

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        access_key = tencentcloud.cam.AccessKey("accessKey",
            status="Inactive",
            target_uin=100033690181)
        ```
        <!--End PulumiCodeChooser -->

        ### Encrypted

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        access_key = tencentcloud.cam.AccessKey("accessKey",
            pgp_key="keybase:some_person_that_exists",
            target_uin=100033690181)
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        cam access_key can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Cam/accessKey:AccessKey access_key access_key_id
        ```

        :param str resource_name: The name of the resource.
        :param AccessKeyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AccessKeyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_key: Optional[pulumi.Input[str]] = None,
                 pgp_key: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 target_uin: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AccessKeyArgs.__new__(AccessKeyArgs)

            __props__.__dict__["access_key"] = access_key
            __props__.__dict__["pgp_key"] = pgp_key
            __props__.__dict__["status"] = status
            __props__.__dict__["target_uin"] = target_uin
            __props__.__dict__["encrypted_secret_access_key"] = None
            __props__.__dict__["key_fingerprint"] = None
            __props__.__dict__["secret_access_key"] = None
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["secretAccessKey"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(AccessKey, __self__).__init__(
            'tencentcloud:Cam/accessKey:AccessKey',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            access_key: Optional[pulumi.Input[str]] = None,
            encrypted_secret_access_key: Optional[pulumi.Input[str]] = None,
            key_fingerprint: Optional[pulumi.Input[str]] = None,
            pgp_key: Optional[pulumi.Input[str]] = None,
            secret_access_key: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None,
            target_uin: Optional[pulumi.Input[int]] = None) -> 'AccessKey':
        """
        Get an existing AccessKey resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] access_key: Access_key is the access key identification, required when updating.
        :param pulumi.Input[str] encrypted_secret_access_key: Encrypted secret, base64 encoded, if pgp_key was specified. This attribute is not available for imported resources. The
               encrypted secret may be decrypted using the command line, for example: terraform output -raw encrypted_secret | base64
               --decode | keybase pgp decrypt.
        :param pulumi.Input[str] key_fingerprint: Fingerprint of the PGP key used to encrypt the secret. This attribute is not available for imported resources.
        :param pulumi.Input[str] pgp_key: Either a base-64 encoded PGP public key, or a keybase username in the form keybase:some_person_that_exists, for use in the encrypted_secret output attribute. If providing a base-64 encoded PGP public key, make sure to provide the "raw" version and not the "armored" one (e.g. avoid passing the -a option to gpg --export).
        :param pulumi.Input[str] secret_access_key: Access key (key is only visible when created, please keep it properly).
        :param pulumi.Input[str] status: Key status, activated (Active) or inactive (Inactive), required when updating.
        :param pulumi.Input[int] target_uin: Specify user Uin, if not filled, the access key is created for the current user by default.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AccessKeyState.__new__(_AccessKeyState)

        __props__.__dict__["access_key"] = access_key
        __props__.__dict__["encrypted_secret_access_key"] = encrypted_secret_access_key
        __props__.__dict__["key_fingerprint"] = key_fingerprint
        __props__.__dict__["pgp_key"] = pgp_key
        __props__.__dict__["secret_access_key"] = secret_access_key
        __props__.__dict__["status"] = status
        __props__.__dict__["target_uin"] = target_uin
        return AccessKey(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessKey")
    def access_key(self) -> pulumi.Output[str]:
        """
        Access_key is the access key identification, required when updating.
        """
        return pulumi.get(self, "access_key")

    @property
    @pulumi.getter(name="encryptedSecretAccessKey")
    def encrypted_secret_access_key(self) -> pulumi.Output[str]:
        """
        Encrypted secret, base64 encoded, if pgp_key was specified. This attribute is not available for imported resources. The
        encrypted secret may be decrypted using the command line, for example: terraform output -raw encrypted_secret | base64
        --decode | keybase pgp decrypt.
        """
        return pulumi.get(self, "encrypted_secret_access_key")

    @property
    @pulumi.getter(name="keyFingerprint")
    def key_fingerprint(self) -> pulumi.Output[str]:
        """
        Fingerprint of the PGP key used to encrypt the secret. This attribute is not available for imported resources.
        """
        return pulumi.get(self, "key_fingerprint")

    @property
    @pulumi.getter(name="pgpKey")
    def pgp_key(self) -> pulumi.Output[Optional[str]]:
        """
        Either a base-64 encoded PGP public key, or a keybase username in the form keybase:some_person_that_exists, for use in the encrypted_secret output attribute. If providing a base-64 encoded PGP public key, make sure to provide the "raw" version and not the "armored" one (e.g. avoid passing the -a option to gpg --export).
        """
        return pulumi.get(self, "pgp_key")

    @property
    @pulumi.getter(name="secretAccessKey")
    def secret_access_key(self) -> pulumi.Output[str]:
        """
        Access key (key is only visible when created, please keep it properly).
        """
        return pulumi.get(self, "secret_access_key")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Key status, activated (Active) or inactive (Inactive), required when updating.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="targetUin")
    def target_uin(self) -> pulumi.Output[Optional[int]]:
        """
        Specify user Uin, if not filled, the access key is created for the current user by default.
        """
        return pulumi.get(self, "target_uin")
