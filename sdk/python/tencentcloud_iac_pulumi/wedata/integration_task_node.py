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
from ._inputs import *

__all__ = ['IntegrationTaskNodeArgs', 'IntegrationTaskNode']

@pulumi.input_type
class IntegrationTaskNodeArgs:
    def __init__(__self__, *,
                 data_source_type: pulumi.Input[str],
                 node_info: pulumi.Input['IntegrationTaskNodeNodeInfoArgs'],
                 node_type: pulumi.Input[str],
                 project_id: pulumi.Input[str],
                 task_id: pulumi.Input[str],
                 task_mode: pulumi.Input[int],
                 task_type: pulumi.Input[int],
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a IntegrationTaskNode resource.
        :param pulumi.Input[str] data_source_type: Data source type: MYSQL, POSTGRE, ORACLE, SQLSERVER, FTP, HIVE, HDFS, ICEBERG, KAFKA, HBASE, SPARK, TBASE, DB2, DM, GAUSSDB, GBASE, IMPALA, ES, S3_DATAINSIGHT, GREENPLUM, PHOENIX, SAP_HANA, SFTP, OCEANBASE, CLICKHOUSE, KUDU, VERTICA, REDIS, COS, DLC, DORIS, CKAFKA, DTS_KAFKA, S3, CDW, TDSQLC, TDSQL, MONGODB, SYBASE, REST_API, StarRocks, TCHOUSE_X.
        :param pulumi.Input['IntegrationTaskNodeNodeInfoArgs'] node_info: Node information.
        :param pulumi.Input[str] node_type: Node type: INPUT, OUTPUT, JOIN, FILTER, TRANSFORM.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[str] task_id: The task id to which the node belongs.
        :param pulumi.Input[int] task_mode: Task display mode, 0: canvas mode, 1: form mode.
        :param pulumi.Input[int] task_type: Task type, 201: real-time task, 202: offline task.
        :param pulumi.Input[str] name: Node Name.
        """
        pulumi.set(__self__, "data_source_type", data_source_type)
        pulumi.set(__self__, "node_info", node_info)
        pulumi.set(__self__, "node_type", node_type)
        pulumi.set(__self__, "project_id", project_id)
        pulumi.set(__self__, "task_id", task_id)
        pulumi.set(__self__, "task_mode", task_mode)
        pulumi.set(__self__, "task_type", task_type)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="dataSourceType")
    def data_source_type(self) -> pulumi.Input[str]:
        """
        Data source type: MYSQL, POSTGRE, ORACLE, SQLSERVER, FTP, HIVE, HDFS, ICEBERG, KAFKA, HBASE, SPARK, TBASE, DB2, DM, GAUSSDB, GBASE, IMPALA, ES, S3_DATAINSIGHT, GREENPLUM, PHOENIX, SAP_HANA, SFTP, OCEANBASE, CLICKHOUSE, KUDU, VERTICA, REDIS, COS, DLC, DORIS, CKAFKA, DTS_KAFKA, S3, CDW, TDSQLC, TDSQL, MONGODB, SYBASE, REST_API, StarRocks, TCHOUSE_X.
        """
        return pulumi.get(self, "data_source_type")

    @data_source_type.setter
    def data_source_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "data_source_type", value)

    @property
    @pulumi.getter(name="nodeInfo")
    def node_info(self) -> pulumi.Input['IntegrationTaskNodeNodeInfoArgs']:
        """
        Node information.
        """
        return pulumi.get(self, "node_info")

    @node_info.setter
    def node_info(self, value: pulumi.Input['IntegrationTaskNodeNodeInfoArgs']):
        pulumi.set(self, "node_info", value)

    @property
    @pulumi.getter(name="nodeType")
    def node_type(self) -> pulumi.Input[str]:
        """
        Node type: INPUT, OUTPUT, JOIN, FILTER, TRANSFORM.
        """
        return pulumi.get(self, "node_type")

    @node_type.setter
    def node_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "node_type", value)

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> pulumi.Input[str]:
        """
        Project ID.
        """
        return pulumi.get(self, "project_id")

    @project_id.setter
    def project_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "project_id", value)

    @property
    @pulumi.getter(name="taskId")
    def task_id(self) -> pulumi.Input[str]:
        """
        The task id to which the node belongs.
        """
        return pulumi.get(self, "task_id")

    @task_id.setter
    def task_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "task_id", value)

    @property
    @pulumi.getter(name="taskMode")
    def task_mode(self) -> pulumi.Input[int]:
        """
        Task display mode, 0: canvas mode, 1: form mode.
        """
        return pulumi.get(self, "task_mode")

    @task_mode.setter
    def task_mode(self, value: pulumi.Input[int]):
        pulumi.set(self, "task_mode", value)

    @property
    @pulumi.getter(name="taskType")
    def task_type(self) -> pulumi.Input[int]:
        """
        Task type, 201: real-time task, 202: offline task.
        """
        return pulumi.get(self, "task_type")

    @task_type.setter
    def task_type(self, value: pulumi.Input[int]):
        pulumi.set(self, "task_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Node Name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _IntegrationTaskNodeState:
    def __init__(__self__, *,
                 data_source_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 node_id: Optional[pulumi.Input[str]] = None,
                 node_info: Optional[pulumi.Input['IntegrationTaskNodeNodeInfoArgs']] = None,
                 node_type: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 task_id: Optional[pulumi.Input[str]] = None,
                 task_mode: Optional[pulumi.Input[int]] = None,
                 task_type: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering IntegrationTaskNode resources.
        :param pulumi.Input[str] data_source_type: Data source type: MYSQL, POSTGRE, ORACLE, SQLSERVER, FTP, HIVE, HDFS, ICEBERG, KAFKA, HBASE, SPARK, TBASE, DB2, DM, GAUSSDB, GBASE, IMPALA, ES, S3_DATAINSIGHT, GREENPLUM, PHOENIX, SAP_HANA, SFTP, OCEANBASE, CLICKHOUSE, KUDU, VERTICA, REDIS, COS, DLC, DORIS, CKAFKA, DTS_KAFKA, S3, CDW, TDSQLC, TDSQL, MONGODB, SYBASE, REST_API, StarRocks, TCHOUSE_X.
        :param pulumi.Input[str] name: Node Name.
        :param pulumi.Input[str] node_id: Node ID.
        :param pulumi.Input['IntegrationTaskNodeNodeInfoArgs'] node_info: Node information.
        :param pulumi.Input[str] node_type: Node type: INPUT, OUTPUT, JOIN, FILTER, TRANSFORM.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[str] task_id: The task id to which the node belongs.
        :param pulumi.Input[int] task_mode: Task display mode, 0: canvas mode, 1: form mode.
        :param pulumi.Input[int] task_type: Task type, 201: real-time task, 202: offline task.
        """
        if data_source_type is not None:
            pulumi.set(__self__, "data_source_type", data_source_type)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if node_id is not None:
            pulumi.set(__self__, "node_id", node_id)
        if node_info is not None:
            pulumi.set(__self__, "node_info", node_info)
        if node_type is not None:
            pulumi.set(__self__, "node_type", node_type)
        if project_id is not None:
            pulumi.set(__self__, "project_id", project_id)
        if task_id is not None:
            pulumi.set(__self__, "task_id", task_id)
        if task_mode is not None:
            pulumi.set(__self__, "task_mode", task_mode)
        if task_type is not None:
            pulumi.set(__self__, "task_type", task_type)

    @property
    @pulumi.getter(name="dataSourceType")
    def data_source_type(self) -> Optional[pulumi.Input[str]]:
        """
        Data source type: MYSQL, POSTGRE, ORACLE, SQLSERVER, FTP, HIVE, HDFS, ICEBERG, KAFKA, HBASE, SPARK, TBASE, DB2, DM, GAUSSDB, GBASE, IMPALA, ES, S3_DATAINSIGHT, GREENPLUM, PHOENIX, SAP_HANA, SFTP, OCEANBASE, CLICKHOUSE, KUDU, VERTICA, REDIS, COS, DLC, DORIS, CKAFKA, DTS_KAFKA, S3, CDW, TDSQLC, TDSQL, MONGODB, SYBASE, REST_API, StarRocks, TCHOUSE_X.
        """
        return pulumi.get(self, "data_source_type")

    @data_source_type.setter
    def data_source_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "data_source_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Node Name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="nodeId")
    def node_id(self) -> Optional[pulumi.Input[str]]:
        """
        Node ID.
        """
        return pulumi.get(self, "node_id")

    @node_id.setter
    def node_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "node_id", value)

    @property
    @pulumi.getter(name="nodeInfo")
    def node_info(self) -> Optional[pulumi.Input['IntegrationTaskNodeNodeInfoArgs']]:
        """
        Node information.
        """
        return pulumi.get(self, "node_info")

    @node_info.setter
    def node_info(self, value: Optional[pulumi.Input['IntegrationTaskNodeNodeInfoArgs']]):
        pulumi.set(self, "node_info", value)

    @property
    @pulumi.getter(name="nodeType")
    def node_type(self) -> Optional[pulumi.Input[str]]:
        """
        Node type: INPUT, OUTPUT, JOIN, FILTER, TRANSFORM.
        """
        return pulumi.get(self, "node_type")

    @node_type.setter
    def node_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "node_type", value)

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> Optional[pulumi.Input[str]]:
        """
        Project ID.
        """
        return pulumi.get(self, "project_id")

    @project_id.setter
    def project_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project_id", value)

    @property
    @pulumi.getter(name="taskId")
    def task_id(self) -> Optional[pulumi.Input[str]]:
        """
        The task id to which the node belongs.
        """
        return pulumi.get(self, "task_id")

    @task_id.setter
    def task_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "task_id", value)

    @property
    @pulumi.getter(name="taskMode")
    def task_mode(self) -> Optional[pulumi.Input[int]]:
        """
        Task display mode, 0: canvas mode, 1: form mode.
        """
        return pulumi.get(self, "task_mode")

    @task_mode.setter
    def task_mode(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "task_mode", value)

    @property
    @pulumi.getter(name="taskType")
    def task_type(self) -> Optional[pulumi.Input[int]]:
        """
        Task type, 201: real-time task, 202: offline task.
        """
        return pulumi.get(self, "task_type")

    @task_type.setter
    def task_type(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "task_type", value)


class IntegrationTaskNode(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 data_source_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 node_info: Optional[pulumi.Input[pulumi.InputType['IntegrationTaskNodeNodeInfoArgs']]] = None,
                 node_type: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 task_id: Optional[pulumi.Input[str]] = None,
                 task_mode: Optional[pulumi.Input[int]] = None,
                 task_type: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Provides a resource to create a wedata integration_task_node

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.wedata.IntegrationTaskNode("example",
            data_source_type="MYSQL",
            node_info=tencentcloud.wedata.IntegrationTaskNodeNodeInfoArgs(
                configs=[
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="Type",
                        value="MYSQL",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="splitPk",
                        value="id",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="PrimaryKey",
                        value="id",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="isNew",
                        value="true",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="PrimaryKey_INPUT_SYMBOL",
                        value="input",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="splitPk_INPUT_SYMBOL",
                        value="input",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="Database",
                        value="demo_mysql",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="TableNames",
                        value="users",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="SiblingNodes",
                        value="[]",
                    ),
                ],
                datasource_id="5085",
                schemas=[
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoSchemaArgs(
                        alias="id",
                        id="471331072",
                        name="id",
                        type="INT",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoSchemaArgs(
                        alias="username",
                        id="422052352",
                        name="username",
                        type="VARCHAR(50)",
                    ),
                ],
            ),
            node_type="INPUT",
            project_id="1612982498218618880",
            task_id="20231022181114990",
            task_mode=2,
            task_type=202)
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] data_source_type: Data source type: MYSQL, POSTGRE, ORACLE, SQLSERVER, FTP, HIVE, HDFS, ICEBERG, KAFKA, HBASE, SPARK, TBASE, DB2, DM, GAUSSDB, GBASE, IMPALA, ES, S3_DATAINSIGHT, GREENPLUM, PHOENIX, SAP_HANA, SFTP, OCEANBASE, CLICKHOUSE, KUDU, VERTICA, REDIS, COS, DLC, DORIS, CKAFKA, DTS_KAFKA, S3, CDW, TDSQLC, TDSQL, MONGODB, SYBASE, REST_API, StarRocks, TCHOUSE_X.
        :param pulumi.Input[str] name: Node Name.
        :param pulumi.Input[pulumi.InputType['IntegrationTaskNodeNodeInfoArgs']] node_info: Node information.
        :param pulumi.Input[str] node_type: Node type: INPUT, OUTPUT, JOIN, FILTER, TRANSFORM.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[str] task_id: The task id to which the node belongs.
        :param pulumi.Input[int] task_mode: Task display mode, 0: canvas mode, 1: form mode.
        :param pulumi.Input[int] task_type: Task type, 201: real-time task, 202: offline task.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: IntegrationTaskNodeArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a wedata integration_task_node

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        example = tencentcloud.wedata.IntegrationTaskNode("example",
            data_source_type="MYSQL",
            node_info=tencentcloud.wedata.IntegrationTaskNodeNodeInfoArgs(
                configs=[
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="Type",
                        value="MYSQL",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="splitPk",
                        value="id",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="PrimaryKey",
                        value="id",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="isNew",
                        value="true",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="PrimaryKey_INPUT_SYMBOL",
                        value="input",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="splitPk_INPUT_SYMBOL",
                        value="input",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="Database",
                        value="demo_mysql",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="TableNames",
                        value="users",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoConfigArgs(
                        name="SiblingNodes",
                        value="[]",
                    ),
                ],
                datasource_id="5085",
                schemas=[
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoSchemaArgs(
                        alias="id",
                        id="471331072",
                        name="id",
                        type="INT",
                    ),
                    tencentcloud.wedata.IntegrationTaskNodeNodeInfoSchemaArgs(
                        alias="username",
                        id="422052352",
                        name="username",
                        type="VARCHAR(50)",
                    ),
                ],
            ),
            node_type="INPUT",
            project_id="1612982498218618880",
            task_id="20231022181114990",
            task_mode=2,
            task_type=202)
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param IntegrationTaskNodeArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(IntegrationTaskNodeArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 data_source_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 node_info: Optional[pulumi.Input[pulumi.InputType['IntegrationTaskNodeNodeInfoArgs']]] = None,
                 node_type: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 task_id: Optional[pulumi.Input[str]] = None,
                 task_mode: Optional[pulumi.Input[int]] = None,
                 task_type: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = IntegrationTaskNodeArgs.__new__(IntegrationTaskNodeArgs)

            if data_source_type is None and not opts.urn:
                raise TypeError("Missing required property 'data_source_type'")
            __props__.__dict__["data_source_type"] = data_source_type
            __props__.__dict__["name"] = name
            if node_info is None and not opts.urn:
                raise TypeError("Missing required property 'node_info'")
            __props__.__dict__["node_info"] = node_info
            if node_type is None and not opts.urn:
                raise TypeError("Missing required property 'node_type'")
            __props__.__dict__["node_type"] = node_type
            if project_id is None and not opts.urn:
                raise TypeError("Missing required property 'project_id'")
            __props__.__dict__["project_id"] = project_id
            if task_id is None and not opts.urn:
                raise TypeError("Missing required property 'task_id'")
            __props__.__dict__["task_id"] = task_id
            if task_mode is None and not opts.urn:
                raise TypeError("Missing required property 'task_mode'")
            __props__.__dict__["task_mode"] = task_mode
            if task_type is None and not opts.urn:
                raise TypeError("Missing required property 'task_type'")
            __props__.__dict__["task_type"] = task_type
            __props__.__dict__["node_id"] = None
        super(IntegrationTaskNode, __self__).__init__(
            'tencentcloud:Wedata/integrationTaskNode:IntegrationTaskNode',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            data_source_type: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            node_id: Optional[pulumi.Input[str]] = None,
            node_info: Optional[pulumi.Input[pulumi.InputType['IntegrationTaskNodeNodeInfoArgs']]] = None,
            node_type: Optional[pulumi.Input[str]] = None,
            project_id: Optional[pulumi.Input[str]] = None,
            task_id: Optional[pulumi.Input[str]] = None,
            task_mode: Optional[pulumi.Input[int]] = None,
            task_type: Optional[pulumi.Input[int]] = None) -> 'IntegrationTaskNode':
        """
        Get an existing IntegrationTaskNode resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] data_source_type: Data source type: MYSQL, POSTGRE, ORACLE, SQLSERVER, FTP, HIVE, HDFS, ICEBERG, KAFKA, HBASE, SPARK, TBASE, DB2, DM, GAUSSDB, GBASE, IMPALA, ES, S3_DATAINSIGHT, GREENPLUM, PHOENIX, SAP_HANA, SFTP, OCEANBASE, CLICKHOUSE, KUDU, VERTICA, REDIS, COS, DLC, DORIS, CKAFKA, DTS_KAFKA, S3, CDW, TDSQLC, TDSQL, MONGODB, SYBASE, REST_API, StarRocks, TCHOUSE_X.
        :param pulumi.Input[str] name: Node Name.
        :param pulumi.Input[str] node_id: Node ID.
        :param pulumi.Input[pulumi.InputType['IntegrationTaskNodeNodeInfoArgs']] node_info: Node information.
        :param pulumi.Input[str] node_type: Node type: INPUT, OUTPUT, JOIN, FILTER, TRANSFORM.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[str] task_id: The task id to which the node belongs.
        :param pulumi.Input[int] task_mode: Task display mode, 0: canvas mode, 1: form mode.
        :param pulumi.Input[int] task_type: Task type, 201: real-time task, 202: offline task.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _IntegrationTaskNodeState.__new__(_IntegrationTaskNodeState)

        __props__.__dict__["data_source_type"] = data_source_type
        __props__.__dict__["name"] = name
        __props__.__dict__["node_id"] = node_id
        __props__.__dict__["node_info"] = node_info
        __props__.__dict__["node_type"] = node_type
        __props__.__dict__["project_id"] = project_id
        __props__.__dict__["task_id"] = task_id
        __props__.__dict__["task_mode"] = task_mode
        __props__.__dict__["task_type"] = task_type
        return IntegrationTaskNode(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dataSourceType")
    def data_source_type(self) -> pulumi.Output[str]:
        """
        Data source type: MYSQL, POSTGRE, ORACLE, SQLSERVER, FTP, HIVE, HDFS, ICEBERG, KAFKA, HBASE, SPARK, TBASE, DB2, DM, GAUSSDB, GBASE, IMPALA, ES, S3_DATAINSIGHT, GREENPLUM, PHOENIX, SAP_HANA, SFTP, OCEANBASE, CLICKHOUSE, KUDU, VERTICA, REDIS, COS, DLC, DORIS, CKAFKA, DTS_KAFKA, S3, CDW, TDSQLC, TDSQL, MONGODB, SYBASE, REST_API, StarRocks, TCHOUSE_X.
        """
        return pulumi.get(self, "data_source_type")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Node Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="nodeId")
    def node_id(self) -> pulumi.Output[str]:
        """
        Node ID.
        """
        return pulumi.get(self, "node_id")

    @property
    @pulumi.getter(name="nodeInfo")
    def node_info(self) -> pulumi.Output['outputs.IntegrationTaskNodeNodeInfo']:
        """
        Node information.
        """
        return pulumi.get(self, "node_info")

    @property
    @pulumi.getter(name="nodeType")
    def node_type(self) -> pulumi.Output[str]:
        """
        Node type: INPUT, OUTPUT, JOIN, FILTER, TRANSFORM.
        """
        return pulumi.get(self, "node_type")

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> pulumi.Output[str]:
        """
        Project ID.
        """
        return pulumi.get(self, "project_id")

    @property
    @pulumi.getter(name="taskId")
    def task_id(self) -> pulumi.Output[str]:
        """
        The task id to which the node belongs.
        """
        return pulumi.get(self, "task_id")

    @property
    @pulumi.getter(name="taskMode")
    def task_mode(self) -> pulumi.Output[int]:
        """
        Task display mode, 0: canvas mode, 1: form mode.
        """
        return pulumi.get(self, "task_mode")

    @property
    @pulumi.getter(name="taskType")
    def task_type(self) -> pulumi.Output[int]:
        """
        Task type, 201: real-time task, 202: offline task.
        """
        return pulumi.get(self, "task_type")
