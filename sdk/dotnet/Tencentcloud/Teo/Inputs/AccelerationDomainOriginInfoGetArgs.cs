// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Inputs
{

    public sealed class AccelerationDomainOriginInfoGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the secondary origin group (valid when `OriginType=ORIGIN_GROUP`). If it is not specified, it indicates that secondary origins are not used.
        /// </summary>
        [Input("backupOrigin")]
        public Input<string>? BackupOrigin { get; set; }

        /// <summary>
        /// The origin address. Enter the origin group ID if `OriginType=ORIGIN_GROUP`.
        /// </summary>
        [Input("origin", required: true)]
        public Input<string> Origin { get; set; } = null!;

        /// <summary>
        /// The origin type. Values: `IP_DOMAIN`: IPv4/IPv6 address or domain name; `COS`: COS bucket address; `ORIGIN_GROUP`: Origin group; `AWS_S3`: AWS S3 bucket address; `SPACE`: EdgeOne Shield Space.
        /// </summary>
        [Input("originType", required: true)]
        public Input<string> OriginType { get; set; } = null!;

        /// <summary>
        /// Whether to authenticate access to the private object storage origin (valid when `OriginType=COS/AWS_S3`). Values: `on`: Enable private authentication; `off`: Disable private authentication. If this field is not specified, the default value `off` is used.
        /// </summary>
        [Input("privateAccess")]
        public Input<string>? PrivateAccess { get; set; }

        [Input("privateParameters")]
        private InputList<Inputs.AccelerationDomainOriginInfoPrivateParameterGetArgs>? _privateParameters;

        /// <summary>
        /// The private authentication parameters. This field is valid when `PrivateAccess=on`.
        /// </summary>
        public InputList<Inputs.AccelerationDomainOriginInfoPrivateParameterGetArgs> PrivateParameters
        {
            get => _privateParameters ?? (_privateParameters = new InputList<Inputs.AccelerationDomainOriginInfoPrivateParameterGetArgs>());
            set => _privateParameters = value;
        }

        public AccelerationDomainOriginInfoGetArgs()
        {
        }
        public static new AccelerationDomainOriginInfoGetArgs Empty => new AccelerationDomainOriginInfoGetArgs();
    }
}