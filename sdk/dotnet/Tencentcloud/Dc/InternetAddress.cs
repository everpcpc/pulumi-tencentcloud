// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dc
{
    /// <summary>
    /// Provides a resource to create a dc internet_address
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var internetAddress = new Tencentcloud.Dc.InternetAddress("internetAddress", new()
    ///     {
    ///         AddrProto = 0,
    ///         AddrType = 2,
    ///         MaskLen = 30,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// dc internet_address can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Dc/internetAddress:InternetAddress internet_address internet_address_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Dc/internetAddress:InternetAddress")]
    public partial class InternetAddress : global::Pulumi.CustomResource
    {
        /// <summary>
        /// 0: IPv4, 1: IPv6.
        /// </summary>
        [Output("addrProto")]
        public Output<int> AddrProto { get; private set; } = null!;

        /// <summary>
        /// 0: BGP, 1: china telecom, 2: china mobile, 3: china unicom.
        /// </summary>
        [Output("addrType")]
        public Output<int> AddrType { get; private set; } = null!;

        /// <summary>
        /// CIDR address mask.
        /// </summary>
        [Output("maskLen")]
        public Output<int> MaskLen { get; private set; } = null!;


        /// <summary>
        /// Create a InternetAddress resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public InternetAddress(string name, InternetAddressArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Dc/internetAddress:InternetAddress", name, args ?? new InternetAddressArgs(), MakeResourceOptions(options, ""))
        {
        }

        private InternetAddress(string name, Input<string> id, InternetAddressState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Dc/internetAddress:InternetAddress", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing InternetAddress resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static InternetAddress Get(string name, Input<string> id, InternetAddressState? state = null, CustomResourceOptions? options = null)
        {
            return new InternetAddress(name, id, state, options);
        }
    }

    public sealed class InternetAddressArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// 0: IPv4, 1: IPv6.
        /// </summary>
        [Input("addrProto", required: true)]
        public Input<int> AddrProto { get; set; } = null!;

        /// <summary>
        /// 0: BGP, 1: china telecom, 2: china mobile, 3: china unicom.
        /// </summary>
        [Input("addrType", required: true)]
        public Input<int> AddrType { get; set; } = null!;

        /// <summary>
        /// CIDR address mask.
        /// </summary>
        [Input("maskLen", required: true)]
        public Input<int> MaskLen { get; set; } = null!;

        public InternetAddressArgs()
        {
        }
        public static new InternetAddressArgs Empty => new InternetAddressArgs();
    }

    public sealed class InternetAddressState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// 0: IPv4, 1: IPv6.
        /// </summary>
        [Input("addrProto")]
        public Input<int>? AddrProto { get; set; }

        /// <summary>
        /// 0: BGP, 1: china telecom, 2: china mobile, 3: china unicom.
        /// </summary>
        [Input("addrType")]
        public Input<int>? AddrType { get; set; }

        /// <summary>
        /// CIDR address mask.
        /// </summary>
        [Input("maskLen")]
        public Input<int>? MaskLen { get; set; }

        public InternetAddressState()
        {
        }
        public static new InternetAddressState Empty => new InternetAddressState();
    }
}