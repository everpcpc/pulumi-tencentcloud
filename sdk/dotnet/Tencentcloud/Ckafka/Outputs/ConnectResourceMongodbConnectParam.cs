// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class ConnectResourceMongodbConnectParam
    {
        /// <summary>
        /// Whether to update to the associated Datahub task, default: false.
        /// </summary>
        public readonly bool? IsUpdate;
        /// <summary>
        /// Password for the source of the Mongo DB connection.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// MongoDB port.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// Instance resource of Mongo DB connection source.
        /// </summary>
        public readonly string Resource;
        /// <summary>
        /// Whether the Mongo DB connection source is a self-built cluster.
        /// </summary>
        public readonly bool SelfBuilt;
        /// <summary>
        /// The instance VIP of the Mongo DB connection source, when it is a Tencent Cloud instance, it is required.
        /// </summary>
        public readonly string? ServiceVip;
        /// <summary>
        /// The vpc Id of the Mongo DB connection source, which is required when it is a Tencent Cloud instance.
        /// </summary>
        public readonly string? UniqVpcId;
        /// <summary>
        /// The username of the Mongo DB connection source.
        /// </summary>
        public readonly string UserName;

        [OutputConstructor]
        private ConnectResourceMongodbConnectParam(
            bool? isUpdate,

            string password,

            int port,

            string resource,

            bool selfBuilt,

            string? serviceVip,

            string? uniqVpcId,

            string userName)
        {
            IsUpdate = isUpdate;
            Password = password;
            Port = port;
            Resource = resource;
            SelfBuilt = selfBuilt;
            ServiceVip = serviceVip;
            UniqVpcId = uniqVpcId;
            UserName = userName;
        }
    }
}