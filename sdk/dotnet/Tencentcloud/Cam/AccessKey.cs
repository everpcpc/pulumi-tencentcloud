// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cam
{
    /// <summary>
    /// Provides a resource to create a cam access_key
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
    ///     var accessKey = new Tencentcloud.Cam.AccessKey("accessKey", new()
    ///     {
    ///         TargetUin = 100033690181,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ### Update
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
    ///     var accessKey = new Tencentcloud.Cam.AccessKey("accessKey", new()
    ///     {
    ///         Status = "Inactive",
    ///         TargetUin = 100033690181,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ### Encrypted
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
    ///     var accessKey = new Tencentcloud.Cam.AccessKey("accessKey", new()
    ///     {
    ///         PgpKey = "keybase:some_person_that_exists",
    ///         TargetUin = 100033690181,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// cam access_key can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Cam/accessKey:AccessKey access_key access_key_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Cam/accessKey:AccessKey")]
    public partial class AccessKey : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Access_key is the access key identification, required when updating.
        /// </summary>
        [Output("accessKey")]
        public Output<string> CamAccessKey { get; private set; } = null!;

        /// <summary>
        /// Encrypted secret, base64 encoded, if pgp_key was specified. This attribute is not available for imported resources. The
        /// encrypted secret may be decrypted using the command line, for example: terraform output -raw encrypted_secret | base64
        /// --decode | keybase pgp decrypt.
        /// </summary>
        [Output("encryptedSecretAccessKey")]
        public Output<string> EncryptedSecretAccessKey { get; private set; } = null!;

        /// <summary>
        /// Fingerprint of the PGP key used to encrypt the secret. This attribute is not available for imported resources.
        /// </summary>
        [Output("keyFingerprint")]
        public Output<string> KeyFingerprint { get; private set; } = null!;

        /// <summary>
        /// Either a base-64 encoded PGP public key, or a keybase username in the form keybase:some_person_that_exists, for use in the encrypted_secret output attribute. If providing a base-64 encoded PGP public key, make sure to provide the "raw" version and not the "armored" one (e.g. avoid passing the -a option to gpg --export).
        /// </summary>
        [Output("pgpKey")]
        public Output<string?> PgpKey { get; private set; } = null!;

        /// <summary>
        /// Access key (key is only visible when created, please keep it properly).
        /// </summary>
        [Output("secretAccessKey")]
        public Output<string> SecretAccessKey { get; private set; } = null!;

        /// <summary>
        /// Key status, activated (Active) or inactive (Inactive), required when updating.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Specify user Uin, if not filled, the access key is created for the current user by default.
        /// </summary>
        [Output("targetUin")]
        public Output<int?> TargetUin { get; private set; } = null!;


        /// <summary>
        /// Create a AccessKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AccessKey(string name, AccessKeyArgs? args = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cam/accessKey:AccessKey", name, args ?? new AccessKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AccessKey(string name, Input<string> id, AccessKeyState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cam/accessKey:AccessKey", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
                AdditionalSecretOutputs =
                {
                    "secretAccessKey",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AccessKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AccessKey Get(string name, Input<string> id, AccessKeyState? state = null, CustomResourceOptions? options = null)
        {
            return new AccessKey(name, id, state, options);
        }
    }

    public sealed class AccessKeyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Access_key is the access key identification, required when updating.
        /// </summary>
        [Input("accessKey")]
        public Input<string>? CamAccessKey { get; set; }

        /// <summary>
        /// Either a base-64 encoded PGP public key, or a keybase username in the form keybase:some_person_that_exists, for use in the encrypted_secret output attribute. If providing a base-64 encoded PGP public key, make sure to provide the "raw" version and not the "armored" one (e.g. avoid passing the -a option to gpg --export).
        /// </summary>
        [Input("pgpKey")]
        public Input<string>? PgpKey { get; set; }

        /// <summary>
        /// Key status, activated (Active) or inactive (Inactive), required when updating.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Specify user Uin, if not filled, the access key is created for the current user by default.
        /// </summary>
        [Input("targetUin")]
        public Input<int>? TargetUin { get; set; }

        public AccessKeyArgs()
        {
        }
        public static new AccessKeyArgs Empty => new AccessKeyArgs();
    }

    public sealed class AccessKeyState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Access_key is the access key identification, required when updating.
        /// </summary>
        [Input("accessKey")]
        public Input<string>? CamAccessKey { get; set; }

        /// <summary>
        /// Encrypted secret, base64 encoded, if pgp_key was specified. This attribute is not available for imported resources. The
        /// encrypted secret may be decrypted using the command line, for example: terraform output -raw encrypted_secret | base64
        /// --decode | keybase pgp decrypt.
        /// </summary>
        [Input("encryptedSecretAccessKey")]
        public Input<string>? EncryptedSecretAccessKey { get; set; }

        /// <summary>
        /// Fingerprint of the PGP key used to encrypt the secret. This attribute is not available for imported resources.
        /// </summary>
        [Input("keyFingerprint")]
        public Input<string>? KeyFingerprint { get; set; }

        /// <summary>
        /// Either a base-64 encoded PGP public key, or a keybase username in the form keybase:some_person_that_exists, for use in the encrypted_secret output attribute. If providing a base-64 encoded PGP public key, make sure to provide the "raw" version and not the "armored" one (e.g. avoid passing the -a option to gpg --export).
        /// </summary>
        [Input("pgpKey")]
        public Input<string>? PgpKey { get; set; }

        [Input("secretAccessKey")]
        private Input<string>? _secretAccessKey;

        /// <summary>
        /// Access key (key is only visible when created, please keep it properly).
        /// </summary>
        public Input<string>? SecretAccessKey
        {
            get => _secretAccessKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secretAccessKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Key status, activated (Active) or inactive (Inactive), required when updating.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Specify user Uin, if not filled, the access key is created for the current user by default.
        /// </summary>
        [Input("targetUin")]
        public Input<int>? TargetUin { get; set; }

        public AccessKeyState()
        {
        }
        public static new AccessKeyState Empty => new AccessKeyState();
    }
}