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
    'GetRouteTablesResult',
    'AwaitableGetRouteTablesResult',
    'get_route_tables',
    'get_route_tables_output',
]

@pulumi.output_type
class GetRouteTablesResult:
    """
    A collection of values returned by getRouteTables.
    """
    def __init__(__self__, association_main=None, id=None, instance_lists=None, name=None, result_output_file=None, route_table_id=None, tag_key=None, tags=None, vpc_id=None):
        if association_main and not isinstance(association_main, bool):
            raise TypeError("Expected argument 'association_main' to be a bool")
        pulumi.set(__self__, "association_main", association_main)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_lists and not isinstance(instance_lists, list):
            raise TypeError("Expected argument 'instance_lists' to be a list")
        pulumi.set(__self__, "instance_lists", instance_lists)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if route_table_id and not isinstance(route_table_id, str):
            raise TypeError("Expected argument 'route_table_id' to be a str")
        pulumi.set(__self__, "route_table_id", route_table_id)
        if tag_key and not isinstance(tag_key, str):
            raise TypeError("Expected argument 'tag_key' to be a str")
        pulumi.set(__self__, "tag_key", tag_key)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if vpc_id and not isinstance(vpc_id, str):
            raise TypeError("Expected argument 'vpc_id' to be a str")
        pulumi.set(__self__, "vpc_id", vpc_id)

    @property
    @pulumi.getter(name="associationMain")
    def association_main(self) -> Optional[bool]:
        return pulumi.get(self, "association_main")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceLists")
    def instance_lists(self) -> Sequence['outputs.GetRouteTablesInstanceListResult']:
        """
        The information list of the VPC route table.
        """
        return pulumi.get(self, "instance_lists")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name of the routing table.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="routeTableId")
    def route_table_id(self) -> Optional[str]:
        """
        ID of the routing table.
        """
        return pulumi.get(self, "route_table_id")

    @property
    @pulumi.getter(name="tagKey")
    def tag_key(self) -> Optional[str]:
        return pulumi.get(self, "tag_key")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, Any]]:
        """
        Tags of the routing table.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> Optional[str]:
        """
        ID of the VPC.
        """
        return pulumi.get(self, "vpc_id")


class AwaitableGetRouteTablesResult(GetRouteTablesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRouteTablesResult(
            association_main=self.association_main,
            id=self.id,
            instance_lists=self.instance_lists,
            name=self.name,
            result_output_file=self.result_output_file,
            route_table_id=self.route_table_id,
            tag_key=self.tag_key,
            tags=self.tags,
            vpc_id=self.vpc_id)


def get_route_tables(association_main: Optional[bool] = None,
                     name: Optional[str] = None,
                     result_output_file: Optional[str] = None,
                     route_table_id: Optional[str] = None,
                     tag_key: Optional[str] = None,
                     tags: Optional[Mapping[str, Any]] = None,
                     vpc_id: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRouteTablesResult:
    """
    Use this data source to query vpc route tables information.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    config = pulumi.Config()
    availability_zone = config.get("availabilityZone")
    if availability_zone is None:
        availability_zone = "ap-guangzhou-3"
    foo = tencentcloud.vpc.Instance("foo", cidr_block="10.0.0.0/16")
    route_table = tencentcloud.route.Table("routeTable",
        vpc_id=foo.id,
        tags={
            "test": "test",
        })
    id_instances = tencentcloud.Vpc.get_route_tables_output(route_table_id=route_table.id)
    name_instances = tencentcloud.Vpc.get_route_tables_output(name=route_table.name)
    vpc_default_instance = tencentcloud.Vpc.get_route_tables_output(vpc_id=foo.id,
        association_main=True)
    tags_instances = route_table.tags.apply(lambda tags: tencentcloud.Vpc.get_route_tables_output(tags=tags))
    ```


    :param bool association_main: Filter the main routing table.
    :param str name: Name of the routing table to be queried.
    :param str result_output_file: Used to save results.
    :param str route_table_id: ID of the routing table to be queried.
    :param str tag_key: Filter if routing table has this tag.
    :param Mapping[str, Any] tags: Tags of the routing table to be queried.
    :param str vpc_id: ID of the VPC to be queried.
    """
    __args__ = dict()
    __args__['associationMain'] = association_main
    __args__['name'] = name
    __args__['resultOutputFile'] = result_output_file
    __args__['routeTableId'] = route_table_id
    __args__['tagKey'] = tag_key
    __args__['tags'] = tags
    __args__['vpcId'] = vpc_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('tencentcloud:Vpc/getRouteTables:getRouteTables', __args__, opts=opts, typ=GetRouteTablesResult).value

    return AwaitableGetRouteTablesResult(
        association_main=__ret__.association_main,
        id=__ret__.id,
        instance_lists=__ret__.instance_lists,
        name=__ret__.name,
        result_output_file=__ret__.result_output_file,
        route_table_id=__ret__.route_table_id,
        tag_key=__ret__.tag_key,
        tags=__ret__.tags,
        vpc_id=__ret__.vpc_id)


@_utilities.lift_output_func(get_route_tables)
def get_route_tables_output(association_main: Optional[pulumi.Input[Optional[bool]]] = None,
                            name: Optional[pulumi.Input[Optional[str]]] = None,
                            result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                            route_table_id: Optional[pulumi.Input[Optional[str]]] = None,
                            tag_key: Optional[pulumi.Input[Optional[str]]] = None,
                            tags: Optional[pulumi.Input[Optional[Mapping[str, Any]]]] = None,
                            vpc_id: Optional[pulumi.Input[Optional[str]]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRouteTablesResult]:
    """
    Use this data source to query vpc route tables information.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_tencentcloud as tencentcloud

    config = pulumi.Config()
    availability_zone = config.get("availabilityZone")
    if availability_zone is None:
        availability_zone = "ap-guangzhou-3"
    foo = tencentcloud.vpc.Instance("foo", cidr_block="10.0.0.0/16")
    route_table = tencentcloud.route.Table("routeTable",
        vpc_id=foo.id,
        tags={
            "test": "test",
        })
    id_instances = tencentcloud.Vpc.get_route_tables_output(route_table_id=route_table.id)
    name_instances = tencentcloud.Vpc.get_route_tables_output(name=route_table.name)
    vpc_default_instance = tencentcloud.Vpc.get_route_tables_output(vpc_id=foo.id,
        association_main=True)
    tags_instances = route_table.tags.apply(lambda tags: tencentcloud.Vpc.get_route_tables_output(tags=tags))
    ```


    :param bool association_main: Filter the main routing table.
    :param str name: Name of the routing table to be queried.
    :param str result_output_file: Used to save results.
    :param str route_table_id: ID of the routing table to be queried.
    :param str tag_key: Filter if routing table has this tag.
    :param Mapping[str, Any] tags: Tags of the routing table to be queried.
    :param str vpc_id: ID of the VPC to be queried.
    """
    ...