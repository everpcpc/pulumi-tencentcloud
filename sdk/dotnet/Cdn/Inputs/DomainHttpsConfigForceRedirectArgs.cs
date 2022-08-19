// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Inputs
{

    public sealed class DomainHttpsConfigForceRedirectArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Forced redirect status code. Valid values are `301` and `302`. When `switch` setting `off`, this property does not need to be set or set to `302`. Default value is `302`.
        /// </summary>
        [Input("redirectStatusCode")]
        public Input<int>? RedirectStatusCode { get; set; }

        /// <summary>
        /// Forced redirect type. Valid values are `http` and `https`. `http` means a forced redirect from HTTPS to HTTP, `https` means a forced redirect from HTTP to HTTPS. When `switch` setting `off`, this property does not need to be set or set to `http`. Default value is `http`.
        /// </summary>
        [Input("redirectType")]
        public Input<string>? RedirectType { get; set; }

        /// <summary>
        /// Forced redirect configuration switch. Valid values are `on` and `off`. Default value is `off`.
        /// </summary>
        [Input("switch")]
        public Input<string>? Switch { get; set; }

        public DomainHttpsConfigForceRedirectArgs()
        {
        }
    }
}