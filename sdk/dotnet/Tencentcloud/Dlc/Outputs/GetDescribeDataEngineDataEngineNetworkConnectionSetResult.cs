// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dlc.Outputs
{

    [OutputType]
    public sealed class GetDescribeDataEngineDataEngineNetworkConnectionSetResult
    {
        /// <summary>
        /// User appid.
        /// </summary>
        public readonly int Appid;
        /// <summary>
        /// Network configuration unique identifier.
        /// </summary>
        public readonly string AssociateId;
        /// <summary>
        /// Create time.
        /// </summary>
        public readonly int CreateTime;
        /// <summary>
        /// Datasource connection cidr block.
        /// </summary>
        public readonly string DatasourceConnectionCidrBlock;
        /// <summary>
        /// Data source id (obsolete).
        /// </summary>
        public readonly string DatasourceConnectionId;
        /// <summary>
        /// Network configuration name.
        /// </summary>
        public readonly string DatasourceConnectionName;
        /// <summary>
        /// Datasource connection subnet cidr block.
        /// </summary>
        public readonly string DatasourceConnectionSubnetCidrBlock;
        /// <summary>
        /// Datasource subnetId.
        /// </summary>
        public readonly string DatasourceConnectionSubnetId;
        /// <summary>
        /// Datasource vpcid.
        /// </summary>
        public readonly string DatasourceConnectionVpcId;
        /// <summary>
        /// Data engine id.
        /// </summary>
        public readonly string HouseId;
        /// <summary>
        /// Data engine name.
        /// </summary>
        public readonly string HouseName;
        /// <summary>
        /// Network configuration id.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// Network configuration description.
        /// </summary>
        public readonly string NetworkConnectionDesc;
        /// <summary>
        /// Network configuration type.
        /// </summary>
        public readonly int NetworkConnectionType;
        /// <summary>
        /// Engine state, only support: 0:Init/-1:Failed/-2:Deleted/1:Pause/2:Running/3:ToBeDelete/4:Deleting.
        /// </summary>
        public readonly int State;
        /// <summary>
        /// Operator.
        /// </summary>
        public readonly string SubAccountUin;
        /// <summary>
        /// User uin.
        /// </summary>
        public readonly string Uin;
        /// <summary>
        /// Update time.
        /// </summary>
        public readonly int UpdateTime;

        [OutputConstructor]
        private GetDescribeDataEngineDataEngineNetworkConnectionSetResult(
            int appid,

            string associateId,

            int createTime,

            string datasourceConnectionCidrBlock,

            string datasourceConnectionId,

            string datasourceConnectionName,

            string datasourceConnectionSubnetCidrBlock,

            string datasourceConnectionSubnetId,

            string datasourceConnectionVpcId,

            string houseId,

            string houseName,

            int id,

            string networkConnectionDesc,

            int networkConnectionType,

            int state,

            string subAccountUin,

            string uin,

            int updateTime)
        {
            Appid = appid;
            AssociateId = associateId;
            CreateTime = createTime;
            DatasourceConnectionCidrBlock = datasourceConnectionCidrBlock;
            DatasourceConnectionId = datasourceConnectionId;
            DatasourceConnectionName = datasourceConnectionName;
            DatasourceConnectionSubnetCidrBlock = datasourceConnectionSubnetCidrBlock;
            DatasourceConnectionSubnetId = datasourceConnectionSubnetId;
            DatasourceConnectionVpcId = datasourceConnectionVpcId;
            HouseId = houseId;
            HouseName = houseName;
            Id = id;
            NetworkConnectionDesc = networkConnectionDesc;
            NetworkConnectionType = networkConnectionType;
            State = state;
            SubAccountUin = subAccountUin;
            Uin = uin;
            UpdateTime = updateTime;
        }
    }
}