// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cos
{
    /// <summary>
    /// Provides a resource to create a cos bucket batch.
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
    ///     var cosBatch = new Tencentcloud.Cos.Batch("cosBatch", new()
    ///     {
    ///         Appid = 1308919341,
    ///         ConfirmationRequired = true,
    ///         Description = "cos_batch",
    ///         Manifest = new Tencentcloud.Cos.Inputs.BatchManifestArgs
    ///         {
    ///             Location = new Tencentcloud.Cos.Inputs.BatchManifestLocationArgs
    ///             {
    ///                 Etag = "64357de8fd75a3abae2200135a2c9627",
    ///                 ObjectArn = "qcs::cos:ap-guangzhou:uid/1308919341:keep-test-1308919341/cos_bucket_inventory/1308919341/keep-test/test/20230621/manifest.json",
    ///             },
    ///             Spec = new Tencentcloud.Cos.Inputs.BatchManifestSpecArgs
    ///             {
    ///                 Format = "COSInventoryReport_CSV_V1",
    ///             },
    ///         },
    ///         Operation = new Tencentcloud.Cos.Inputs.BatchOperationArgs
    ///         {
    ///             CosPutObjectCopy = new Tencentcloud.Cos.Inputs.BatchOperationCosPutObjectCopyArgs
    ///             {
    ///                 AccessControlDirective = "Copy",
    ///                 MetadataDirective = "Copy",
    ///                 PrefixReplace = false,
    ///                 StorageClass = "STANDARD",
    ///                 TaggingDirective = "Copy",
    ///                 TargetResource = "qcs::cos:ap-guangzhou:uid/1308919341:cos-lock-1308919341",
    ///             },
    ///         },
    ///         Priority = 1,
    ///         Report = new Tencentcloud.Cos.Inputs.BatchReportArgs
    ///         {
    ///             Bucket = "qcs::cos:ap-guangzhou:uid/1308919341:keep-test-1308919341",
    ///             Enabled = "true",
    ///             Format = "Report_CSV_V1",
    ///             ReportScope = "AllTasks",
    ///         },
    ///         RoleArn = "qcs::cam::uin/100022975249:roleName/COSBatch_QCSRole",
    ///         Status = "Cancelled",
    ///         Uin = "100022975249",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// cos bucket batch can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Cos/batch:Batch cos_batch ${uin}#${appid}#{job_id}
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Cos/batch:Batch")]
    public partial class Batch : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Appid.
        /// </summary>
        [Output("appid")]
        public Output<int> Appid { get; private set; } = null!;

        /// <summary>
        /// Whether to confirm before performing the task. The default is false.
        /// </summary>
        [Output("confirmationRequired")]
        public Output<bool?> ConfirmationRequired { get; private set; } = null!;

        /// <summary>
        /// Mission description. If you configured this information when you created the task, the content is returned. The description length ranges from 0 to 256 bytes.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Job id.
        /// </summary>
        [Output("jobId")]
        public Output<string> JobId { get; private set; } = null!;

        /// <summary>
        /// List of objects to be processed.
        /// </summary>
        [Output("manifest")]
        public Output<Outputs.BatchManifest> Manifest { get; private set; } = null!;

        /// <summary>
        /// Select the action to be performed on the objects in the manifest file.
        /// </summary>
        [Output("operation")]
        public Output<Outputs.BatchOperation> Operation { get; private set; } = null!;

        /// <summary>
        /// Mission priority. The higher the value, the higher the priority of the task. Priority values range from 0 to 2147483647.
        /// </summary>
        [Output("priority")]
        public Output<int> Priority { get; private set; } = null!;

        /// <summary>
        /// Task completion report.
        /// </summary>
        [Output("report")]
        public Output<Outputs.BatchReport> Report { get; private set; } = null!;

        /// <summary>
        /// COS resource identifier, which is used to identify the role you created. You need this resource identifier to verify your identity.
        /// </summary>
        [Output("roleArn")]
        public Output<string> RoleArn { get; private set; } = null!;

        /// <summary>
        /// Current status of the task.
        /// Legal parameter values include Active, Cancelled, Cancelling, Complete, Completing, Failed, Failing, New, Paused, Pausing, Preparing, Ready, Suspended.
        /// For Update status, when you move a task to the Ready state, COS will assume that you have confirmed the task and will perform it. When you move a task to the Cancelled state, COS cancels the task. Optional parameters include: Ready, Cancelled.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Uin.
        /// </summary>
        [Output("uin")]
        public Output<string> Uin { get; private set; } = null!;


        /// <summary>
        /// Create a Batch resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Batch(string name, BatchArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cos/batch:Batch", name, args ?? new BatchArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Batch(string name, Input<string> id, BatchState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cos/batch:Batch", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Batch resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Batch Get(string name, Input<string> id, BatchState? state = null, CustomResourceOptions? options = null)
        {
            return new Batch(name, id, state, options);
        }
    }

    public sealed class BatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Appid.
        /// </summary>
        [Input("appid", required: true)]
        public Input<int> Appid { get; set; } = null!;

        /// <summary>
        /// Whether to confirm before performing the task. The default is false.
        /// </summary>
        [Input("confirmationRequired")]
        public Input<bool>? ConfirmationRequired { get; set; }

        /// <summary>
        /// Mission description. If you configured this information when you created the task, the content is returned. The description length ranges from 0 to 256 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// List of objects to be processed.
        /// </summary>
        [Input("manifest", required: true)]
        public Input<Inputs.BatchManifestArgs> Manifest { get; set; } = null!;

        /// <summary>
        /// Select the action to be performed on the objects in the manifest file.
        /// </summary>
        [Input("operation", required: true)]
        public Input<Inputs.BatchOperationArgs> Operation { get; set; } = null!;

        /// <summary>
        /// Mission priority. The higher the value, the higher the priority of the task. Priority values range from 0 to 2147483647.
        /// </summary>
        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        /// <summary>
        /// Task completion report.
        /// </summary>
        [Input("report", required: true)]
        public Input<Inputs.BatchReportArgs> Report { get; set; } = null!;

        /// <summary>
        /// COS resource identifier, which is used to identify the role you created. You need this resource identifier to verify your identity.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        /// <summary>
        /// Current status of the task.
        /// Legal parameter values include Active, Cancelled, Cancelling, Complete, Completing, Failed, Failing, New, Paused, Pausing, Preparing, Ready, Suspended.
        /// For Update status, when you move a task to the Ready state, COS will assume that you have confirmed the task and will perform it. When you move a task to the Cancelled state, COS cancels the task. Optional parameters include: Ready, Cancelled.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Uin.
        /// </summary>
        [Input("uin", required: true)]
        public Input<string> Uin { get; set; } = null!;

        public BatchArgs()
        {
        }
        public static new BatchArgs Empty => new BatchArgs();
    }

    public sealed class BatchState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Appid.
        /// </summary>
        [Input("appid")]
        public Input<int>? Appid { get; set; }

        /// <summary>
        /// Whether to confirm before performing the task. The default is false.
        /// </summary>
        [Input("confirmationRequired")]
        public Input<bool>? ConfirmationRequired { get; set; }

        /// <summary>
        /// Mission description. If you configured this information when you created the task, the content is returned. The description length ranges from 0 to 256 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Job id.
        /// </summary>
        [Input("jobId")]
        public Input<string>? JobId { get; set; }

        /// <summary>
        /// List of objects to be processed.
        /// </summary>
        [Input("manifest")]
        public Input<Inputs.BatchManifestGetArgs>? Manifest { get; set; }

        /// <summary>
        /// Select the action to be performed on the objects in the manifest file.
        /// </summary>
        [Input("operation")]
        public Input<Inputs.BatchOperationGetArgs>? Operation { get; set; }

        /// <summary>
        /// Mission priority. The higher the value, the higher the priority of the task. Priority values range from 0 to 2147483647.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        /// <summary>
        /// Task completion report.
        /// </summary>
        [Input("report")]
        public Input<Inputs.BatchReportGetArgs>? Report { get; set; }

        /// <summary>
        /// COS resource identifier, which is used to identify the role you created. You need this resource identifier to verify your identity.
        /// </summary>
        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        /// <summary>
        /// Current status of the task.
        /// Legal parameter values include Active, Cancelled, Cancelling, Complete, Completing, Failed, Failing, New, Paused, Pausing, Preparing, Ready, Suspended.
        /// For Update status, when you move a task to the Ready state, COS will assume that you have confirmed the task and will perform it. When you move a task to the Cancelled state, COS cancels the task. Optional parameters include: Ready, Cancelled.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Uin.
        /// </summary>
        [Input("uin")]
        public Input<string>? Uin { get; set; }

        public BatchState()
        {
        }
        public static new BatchState Empty => new BatchState();
    }
}