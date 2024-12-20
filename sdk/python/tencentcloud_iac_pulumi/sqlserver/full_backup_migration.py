# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['FullBackupMigrationArgs', 'FullBackupMigration']

@pulumi.input_type
class FullBackupMigrationArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 migration_name: pulumi.Input[str],
                 recovery_type: pulumi.Input[str],
                 upload_type: pulumi.Input[str],
                 backup_files: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a FullBackupMigration resource.
        :param pulumi.Input[str] instance_id: ID of imported target instance.
        :param pulumi.Input[str] migration_name: Task name.
        :param pulumi.Input[str] recovery_type: Migration task restoration type. FULL: full backup restoration, FULL_LOG: full backup and transaction log restoration, FULL_DIFF: full backup and differential backup restoration.
        :param pulumi.Input[str] upload_type: Backup upload type. COS_URL: the backup is stored in users Cloud Object Storage, with URL provided. COS_UPLOAD: the backup is stored in the applications Cloud Object Storage and needs to be uploaded by the user.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] backup_files: If the UploadType is COS_URL, fill in the URL here. If the UploadType is COS_UPLOAD, fill in the name of the backup file here. Only 1 backup file is supported, but a backup file can involve multiple databases.
        """
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "migration_name", migration_name)
        pulumi.set(__self__, "recovery_type", recovery_type)
        pulumi.set(__self__, "upload_type", upload_type)
        if backup_files is not None:
            pulumi.set(__self__, "backup_files", backup_files)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        ID of imported target instance.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="migrationName")
    def migration_name(self) -> pulumi.Input[str]:
        """
        Task name.
        """
        return pulumi.get(self, "migration_name")

    @migration_name.setter
    def migration_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "migration_name", value)

    @property
    @pulumi.getter(name="recoveryType")
    def recovery_type(self) -> pulumi.Input[str]:
        """
        Migration task restoration type. FULL: full backup restoration, FULL_LOG: full backup and transaction log restoration, FULL_DIFF: full backup and differential backup restoration.
        """
        return pulumi.get(self, "recovery_type")

    @recovery_type.setter
    def recovery_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "recovery_type", value)

    @property
    @pulumi.getter(name="uploadType")
    def upload_type(self) -> pulumi.Input[str]:
        """
        Backup upload type. COS_URL: the backup is stored in users Cloud Object Storage, with URL provided. COS_UPLOAD: the backup is stored in the applications Cloud Object Storage and needs to be uploaded by the user.
        """
        return pulumi.get(self, "upload_type")

    @upload_type.setter
    def upload_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "upload_type", value)

    @property
    @pulumi.getter(name="backupFiles")
    def backup_files(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        If the UploadType is COS_URL, fill in the URL here. If the UploadType is COS_UPLOAD, fill in the name of the backup file here. Only 1 backup file is supported, but a backup file can involve multiple databases.
        """
        return pulumi.get(self, "backup_files")

    @backup_files.setter
    def backup_files(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "backup_files", value)


@pulumi.input_type
class _FullBackupMigrationState:
    def __init__(__self__, *,
                 backup_files: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 backup_migration_id: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 migration_name: Optional[pulumi.Input[str]] = None,
                 recovery_type: Optional[pulumi.Input[str]] = None,
                 upload_type: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering FullBackupMigration resources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] backup_files: If the UploadType is COS_URL, fill in the URL here. If the UploadType is COS_UPLOAD, fill in the name of the backup file here. Only 1 backup file is supported, but a backup file can involve multiple databases.
        :param pulumi.Input[str] backup_migration_id: Backup import task ID.
        :param pulumi.Input[str] instance_id: ID of imported target instance.
        :param pulumi.Input[str] migration_name: Task name.
        :param pulumi.Input[str] recovery_type: Migration task restoration type. FULL: full backup restoration, FULL_LOG: full backup and transaction log restoration, FULL_DIFF: full backup and differential backup restoration.
        :param pulumi.Input[str] upload_type: Backup upload type. COS_URL: the backup is stored in users Cloud Object Storage, with URL provided. COS_UPLOAD: the backup is stored in the applications Cloud Object Storage and needs to be uploaded by the user.
        """
        if backup_files is not None:
            pulumi.set(__self__, "backup_files", backup_files)
        if backup_migration_id is not None:
            pulumi.set(__self__, "backup_migration_id", backup_migration_id)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if migration_name is not None:
            pulumi.set(__self__, "migration_name", migration_name)
        if recovery_type is not None:
            pulumi.set(__self__, "recovery_type", recovery_type)
        if upload_type is not None:
            pulumi.set(__self__, "upload_type", upload_type)

    @property
    @pulumi.getter(name="backupFiles")
    def backup_files(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        If the UploadType is COS_URL, fill in the URL here. If the UploadType is COS_UPLOAD, fill in the name of the backup file here. Only 1 backup file is supported, but a backup file can involve multiple databases.
        """
        return pulumi.get(self, "backup_files")

    @backup_files.setter
    def backup_files(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "backup_files", value)

    @property
    @pulumi.getter(name="backupMigrationId")
    def backup_migration_id(self) -> Optional[pulumi.Input[str]]:
        """
        Backup import task ID.
        """
        return pulumi.get(self, "backup_migration_id")

    @backup_migration_id.setter
    def backup_migration_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "backup_migration_id", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of imported target instance.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="migrationName")
    def migration_name(self) -> Optional[pulumi.Input[str]]:
        """
        Task name.
        """
        return pulumi.get(self, "migration_name")

    @migration_name.setter
    def migration_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "migration_name", value)

    @property
    @pulumi.getter(name="recoveryType")
    def recovery_type(self) -> Optional[pulumi.Input[str]]:
        """
        Migration task restoration type. FULL: full backup restoration, FULL_LOG: full backup and transaction log restoration, FULL_DIFF: full backup and differential backup restoration.
        """
        return pulumi.get(self, "recovery_type")

    @recovery_type.setter
    def recovery_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "recovery_type", value)

    @property
    @pulumi.getter(name="uploadType")
    def upload_type(self) -> Optional[pulumi.Input[str]]:
        """
        Backup upload type. COS_URL: the backup is stored in users Cloud Object Storage, with URL provided. COS_UPLOAD: the backup is stored in the applications Cloud Object Storage and needs to be uploaded by the user.
        """
        return pulumi.get(self, "upload_type")

    @upload_type.setter
    def upload_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "upload_type", value)


class FullBackupMigration(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backup_files: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 migration_name: Optional[pulumi.Input[str]] = None,
                 recovery_type: Optional[pulumi.Input[str]] = None,
                 upload_type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a sqlserver full_backup_migration

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_tencentcloud as tencentcloud
        import tencentcloud_iac_pulumi as tencentcloud

        zones = tencentcloud.Availability.get_zones_by_product(product="sqlserver")
        vpc = tencentcloud.vpc.Instance("vpc", cidr_block="10.0.0.0/16")
        subnet = tencentcloud.subnet.Instance("subnet",
            availability_zone=zones.zones[4].name,
            vpc_id=vpc.id,
            cidr_block="10.0.0.0/16",
            is_multicast=False)
        security_group = tencentcloud.security.Group("securityGroup", description="desc.")
        example_basic_instance = tencentcloud.sqlserver.BasicInstance("exampleBasicInstance",
            availability_zone=zones.zones[4].name,
            charge_type="POSTPAID_BY_HOUR",
            vpc_id=vpc.id,
            subnet_id=subnet.id,
            project_id=0,
            memory=4,
            storage=100,
            cpu=2,
            machine_type="CLOUD_PREMIUM",
            maintenance_week_sets=[
                1,
                2,
                3,
            ],
            maintenance_start_time="09:00",
            maintenance_time_span=3,
            security_groups=[security_group.id],
            tags={
                "test": "test",
            })
        example_db = tencentcloud.sqlserver.Db("exampleDb",
            instance_id=example_basic_instance.id,
            charset="Chinese_PRC_BIN",
            remark="test-remark")
        example_general_backup = tencentcloud.sqlserver.GeneralBackup("exampleGeneralBackup",
            instance_id=example_db.instance_id,
            backup_name="tf_example_backup",
            strategy=0)
        example_backups = tencentcloud.Sqlserver.get_backups_output(instance_id=example_db.instance_id,
            backup_name=example_general_backup.backup_name,
            start_time="2023-07-25 00:00:00",
            end_time="2023-08-04 00:00:00")
        example_full_backup_migration = tencentcloud.sqlserver.FullBackupMigration("exampleFullBackupMigration",
            instance_id=example_general_backup.instance_id,
            recovery_type="FULL",
            upload_type="COS_URL",
            migration_name="migration_test",
            backup_files=[example_backups.lists[0].internet_url])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        sqlserver full_backup_migration can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Sqlserver/fullBackupMigration:FullBackupMigration example mssql-si2823jyl#mssql-backup-migration-cg0ffgqt
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] backup_files: If the UploadType is COS_URL, fill in the URL here. If the UploadType is COS_UPLOAD, fill in the name of the backup file here. Only 1 backup file is supported, but a backup file can involve multiple databases.
        :param pulumi.Input[str] instance_id: ID of imported target instance.
        :param pulumi.Input[str] migration_name: Task name.
        :param pulumi.Input[str] recovery_type: Migration task restoration type. FULL: full backup restoration, FULL_LOG: full backup and transaction log restoration, FULL_DIFF: full backup and differential backup restoration.
        :param pulumi.Input[str] upload_type: Backup upload type. COS_URL: the backup is stored in users Cloud Object Storage, with URL provided. COS_UPLOAD: the backup is stored in the applications Cloud Object Storage and needs to be uploaded by the user.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: FullBackupMigrationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a sqlserver full_backup_migration

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_tencentcloud as tencentcloud
        import tencentcloud_iac_pulumi as tencentcloud

        zones = tencentcloud.Availability.get_zones_by_product(product="sqlserver")
        vpc = tencentcloud.vpc.Instance("vpc", cidr_block="10.0.0.0/16")
        subnet = tencentcloud.subnet.Instance("subnet",
            availability_zone=zones.zones[4].name,
            vpc_id=vpc.id,
            cidr_block="10.0.0.0/16",
            is_multicast=False)
        security_group = tencentcloud.security.Group("securityGroup", description="desc.")
        example_basic_instance = tencentcloud.sqlserver.BasicInstance("exampleBasicInstance",
            availability_zone=zones.zones[4].name,
            charge_type="POSTPAID_BY_HOUR",
            vpc_id=vpc.id,
            subnet_id=subnet.id,
            project_id=0,
            memory=4,
            storage=100,
            cpu=2,
            machine_type="CLOUD_PREMIUM",
            maintenance_week_sets=[
                1,
                2,
                3,
            ],
            maintenance_start_time="09:00",
            maintenance_time_span=3,
            security_groups=[security_group.id],
            tags={
                "test": "test",
            })
        example_db = tencentcloud.sqlserver.Db("exampleDb",
            instance_id=example_basic_instance.id,
            charset="Chinese_PRC_BIN",
            remark="test-remark")
        example_general_backup = tencentcloud.sqlserver.GeneralBackup("exampleGeneralBackup",
            instance_id=example_db.instance_id,
            backup_name="tf_example_backup",
            strategy=0)
        example_backups = tencentcloud.Sqlserver.get_backups_output(instance_id=example_db.instance_id,
            backup_name=example_general_backup.backup_name,
            start_time="2023-07-25 00:00:00",
            end_time="2023-08-04 00:00:00")
        example_full_backup_migration = tencentcloud.sqlserver.FullBackupMigration("exampleFullBackupMigration",
            instance_id=example_general_backup.instance_id,
            recovery_type="FULL",
            upload_type="COS_URL",
            migration_name="migration_test",
            backup_files=[example_backups.lists[0].internet_url])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        sqlserver full_backup_migration can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Sqlserver/fullBackupMigration:FullBackupMigration example mssql-si2823jyl#mssql-backup-migration-cg0ffgqt
        ```

        :param str resource_name: The name of the resource.
        :param FullBackupMigrationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FullBackupMigrationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backup_files: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 migration_name: Optional[pulumi.Input[str]] = None,
                 recovery_type: Optional[pulumi.Input[str]] = None,
                 upload_type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = FullBackupMigrationArgs.__new__(FullBackupMigrationArgs)

            __props__.__dict__["backup_files"] = backup_files
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            if migration_name is None and not opts.urn:
                raise TypeError("Missing required property 'migration_name'")
            __props__.__dict__["migration_name"] = migration_name
            if recovery_type is None and not opts.urn:
                raise TypeError("Missing required property 'recovery_type'")
            __props__.__dict__["recovery_type"] = recovery_type
            if upload_type is None and not opts.urn:
                raise TypeError("Missing required property 'upload_type'")
            __props__.__dict__["upload_type"] = upload_type
            __props__.__dict__["backup_migration_id"] = None
        super(FullBackupMigration, __self__).__init__(
            'tencentcloud:Sqlserver/fullBackupMigration:FullBackupMigration',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            backup_files: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            backup_migration_id: Optional[pulumi.Input[str]] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            migration_name: Optional[pulumi.Input[str]] = None,
            recovery_type: Optional[pulumi.Input[str]] = None,
            upload_type: Optional[pulumi.Input[str]] = None) -> 'FullBackupMigration':
        """
        Get an existing FullBackupMigration resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] backup_files: If the UploadType is COS_URL, fill in the URL here. If the UploadType is COS_UPLOAD, fill in the name of the backup file here. Only 1 backup file is supported, but a backup file can involve multiple databases.
        :param pulumi.Input[str] backup_migration_id: Backup import task ID.
        :param pulumi.Input[str] instance_id: ID of imported target instance.
        :param pulumi.Input[str] migration_name: Task name.
        :param pulumi.Input[str] recovery_type: Migration task restoration type. FULL: full backup restoration, FULL_LOG: full backup and transaction log restoration, FULL_DIFF: full backup and differential backup restoration.
        :param pulumi.Input[str] upload_type: Backup upload type. COS_URL: the backup is stored in users Cloud Object Storage, with URL provided. COS_UPLOAD: the backup is stored in the applications Cloud Object Storage and needs to be uploaded by the user.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _FullBackupMigrationState.__new__(_FullBackupMigrationState)

        __props__.__dict__["backup_files"] = backup_files
        __props__.__dict__["backup_migration_id"] = backup_migration_id
        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["migration_name"] = migration_name
        __props__.__dict__["recovery_type"] = recovery_type
        __props__.__dict__["upload_type"] = upload_type
        return FullBackupMigration(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="backupFiles")
    def backup_files(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        If the UploadType is COS_URL, fill in the URL here. If the UploadType is COS_UPLOAD, fill in the name of the backup file here. Only 1 backup file is supported, but a backup file can involve multiple databases.
        """
        return pulumi.get(self, "backup_files")

    @property
    @pulumi.getter(name="backupMigrationId")
    def backup_migration_id(self) -> pulumi.Output[str]:
        """
        Backup import task ID.
        """
        return pulumi.get(self, "backup_migration_id")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        ID of imported target instance.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="migrationName")
    def migration_name(self) -> pulumi.Output[str]:
        """
        Task name.
        """
        return pulumi.get(self, "migration_name")

    @property
    @pulumi.getter(name="recoveryType")
    def recovery_type(self) -> pulumi.Output[str]:
        """
        Migration task restoration type. FULL: full backup restoration, FULL_LOG: full backup and transaction log restoration, FULL_DIFF: full backup and differential backup restoration.
        """
        return pulumi.get(self, "recovery_type")

    @property
    @pulumi.getter(name="uploadType")
    def upload_type(self) -> pulumi.Output[str]:
        """
        Backup upload type. COS_URL: the backup is stored in users Cloud Object Storage, with URL provided. COS_UPLOAD: the backup is stored in the applications Cloud Object Storage and needs to be uploaded by the user.
        """
        return pulumi.get(self, "upload_type")

