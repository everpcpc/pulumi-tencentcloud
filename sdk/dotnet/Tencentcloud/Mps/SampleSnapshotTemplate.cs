// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps
{
    /// <summary>
    /// Provides a resource to create a mps sample_snapshot_template
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var sampleSnapshotTemplate = new Tencentcloud.Mps.SampleSnapshotTemplate("sampleSnapshotTemplate", new Tencentcloud.Mps.SampleSnapshotTemplateArgs
    ///         {
    ///             FillType = "stretch",
    ///             Format = "jpg",
    ///             Height = 128,
    ///             ResolutionAdaptive = "open",
    ///             SampleInterval = 10,
    ///             SampleType = "Percent",
    ///             Width = 140,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// mps sample_snapshot_template can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import tencentcloud:Mps/sampleSnapshotTemplate:SampleSnapshotTemplate sample_snapshot_template sample_snapshot_template_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Mps/sampleSnapshotTemplate:SampleSnapshotTemplate")]
    public partial class SampleSnapshotTemplate : Pulumi.CustomResource
    {
        /// <summary>
        /// Template description information, length limit: 256 characters.
        /// </summary>
        [Output("comment")]
        public Output<string?> Comment { get; private set; } = null!;

        /// <summary>
        /// Filling type, when the aspect ratio of the video stream configuration is inconsistent with the aspect ratio of the original video, the processing method for transcoding is filling. Optional filling type:stretch: Stretching, stretching each frame to fill the entire screen, which may cause the transcoded video to be squashed or stretched.black: Leave black, keep the video aspect ratio unchanged, and fill the rest of the edge with black.white: Leave blank, keep the aspect ratio of the video, and fill the rest of the edge with white.gauss: Gaussian blur, keep the aspect ratio of the video unchanged, and use Gaussian blur for the rest of the edge.Default value: black.
        /// </summary>
        [Output("fillType")]
        public Output<string?> FillType { get; private set; } = null!;

        /// <summary>
        /// Image format, the value can be jpg, png, webp. Default is jpg.
        /// </summary>
        [Output("format")]
        public Output<string?> Format { get; private set; } = null!;

        /// <summary>
        /// The maximum value of the snapshot height (or short side), value range: 0 and [128, 4096], unit: px.When Width and Height are both 0, the resolution is the same.When Width is 0 and Height is not 0, Width is scaled proportionally.When Width is not 0 and Height is 0, Height is scaled proportionally.When both Width and Height are not 0, the resolution is specified by the user.Default value: 0.
        /// </summary>
        [Output("height")]
        public Output<int?> Height { get; private set; } = null!;

        /// <summary>
        /// Sample snapshot template name, length limit: 64 characters.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Adaptive resolution, optional value:open: At this time, Width represents the long side of the video, Height represents the short side of the video.close: At this point, Width represents the width of the video, and Height represents the height of the video.Default value: open.
        /// </summary>
        [Output("resolutionAdaptive")]
        public Output<string?> ResolutionAdaptive { get; private set; } = null!;

        /// <summary>
        /// Sampling interval.When SampleType is Percent, specify the percentage of the sampling interval.When SampleType is Time, specify the sampling interval time in seconds.
        /// </summary>
        [Output("sampleInterval")]
        public Output<int> SampleInterval { get; private set; } = null!;

        /// <summary>
        /// Sampling snapshot type, optional value:Percent/Time.
        /// </summary>
        [Output("sampleType")]
        public Output<string> SampleType { get; private set; } = null!;

        /// <summary>
        /// The maximum value of the snapshot width (or long side), value range: 0 and [128, 4096], unit: px.When Width and Height are both 0, the resolution is the same.When Width is 0 and Height is not 0, Width is scaled proportionally.When Width is not 0 and Height is 0, Height is scaled proportionally.When both Width and Height are not 0, the resolution is specified by the user.Default value: 0.
        /// </summary>
        [Output("width")]
        public Output<int?> Width { get; private set; } = null!;


        /// <summary>
        /// Create a SampleSnapshotTemplate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SampleSnapshotTemplate(string name, SampleSnapshotTemplateArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Mps/sampleSnapshotTemplate:SampleSnapshotTemplate", name, args ?? new SampleSnapshotTemplateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SampleSnapshotTemplate(string name, Input<string> id, SampleSnapshotTemplateState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Mps/sampleSnapshotTemplate:SampleSnapshotTemplate", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SampleSnapshotTemplate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SampleSnapshotTemplate Get(string name, Input<string> id, SampleSnapshotTemplateState? state = null, CustomResourceOptions? options = null)
        {
            return new SampleSnapshotTemplate(name, id, state, options);
        }
    }

    public sealed class SampleSnapshotTemplateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Template description information, length limit: 256 characters.
        /// </summary>
        [Input("comment")]
        public Input<string>? Comment { get; set; }

        /// <summary>
        /// Filling type, when the aspect ratio of the video stream configuration is inconsistent with the aspect ratio of the original video, the processing method for transcoding is filling. Optional filling type:stretch: Stretching, stretching each frame to fill the entire screen, which may cause the transcoded video to be squashed or stretched.black: Leave black, keep the video aspect ratio unchanged, and fill the rest of the edge with black.white: Leave blank, keep the aspect ratio of the video, and fill the rest of the edge with white.gauss: Gaussian blur, keep the aspect ratio of the video unchanged, and use Gaussian blur for the rest of the edge.Default value: black.
        /// </summary>
        [Input("fillType")]
        public Input<string>? FillType { get; set; }

        /// <summary>
        /// Image format, the value can be jpg, png, webp. Default is jpg.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// The maximum value of the snapshot height (or short side), value range: 0 and [128, 4096], unit: px.When Width and Height are both 0, the resolution is the same.When Width is 0 and Height is not 0, Width is scaled proportionally.When Width is not 0 and Height is 0, Height is scaled proportionally.When both Width and Height are not 0, the resolution is specified by the user.Default value: 0.
        /// </summary>
        [Input("height")]
        public Input<int>? Height { get; set; }

        /// <summary>
        /// Sample snapshot template name, length limit: 64 characters.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Adaptive resolution, optional value:open: At this time, Width represents the long side of the video, Height represents the short side of the video.close: At this point, Width represents the width of the video, and Height represents the height of the video.Default value: open.
        /// </summary>
        [Input("resolutionAdaptive")]
        public Input<string>? ResolutionAdaptive { get; set; }

        /// <summary>
        /// Sampling interval.When SampleType is Percent, specify the percentage of the sampling interval.When SampleType is Time, specify the sampling interval time in seconds.
        /// </summary>
        [Input("sampleInterval", required: true)]
        public Input<int> SampleInterval { get; set; } = null!;

        /// <summary>
        /// Sampling snapshot type, optional value:Percent/Time.
        /// </summary>
        [Input("sampleType", required: true)]
        public Input<string> SampleType { get; set; } = null!;

        /// <summary>
        /// The maximum value of the snapshot width (or long side), value range: 0 and [128, 4096], unit: px.When Width and Height are both 0, the resolution is the same.When Width is 0 and Height is not 0, Width is scaled proportionally.When Width is not 0 and Height is 0, Height is scaled proportionally.When both Width and Height are not 0, the resolution is specified by the user.Default value: 0.
        /// </summary>
        [Input("width")]
        public Input<int>? Width { get; set; }

        public SampleSnapshotTemplateArgs()
        {
        }
    }

    public sealed class SampleSnapshotTemplateState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Template description information, length limit: 256 characters.
        /// </summary>
        [Input("comment")]
        public Input<string>? Comment { get; set; }

        /// <summary>
        /// Filling type, when the aspect ratio of the video stream configuration is inconsistent with the aspect ratio of the original video, the processing method for transcoding is filling. Optional filling type:stretch: Stretching, stretching each frame to fill the entire screen, which may cause the transcoded video to be squashed or stretched.black: Leave black, keep the video aspect ratio unchanged, and fill the rest of the edge with black.white: Leave blank, keep the aspect ratio of the video, and fill the rest of the edge with white.gauss: Gaussian blur, keep the aspect ratio of the video unchanged, and use Gaussian blur for the rest of the edge.Default value: black.
        /// </summary>
        [Input("fillType")]
        public Input<string>? FillType { get; set; }

        /// <summary>
        /// Image format, the value can be jpg, png, webp. Default is jpg.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// The maximum value of the snapshot height (or short side), value range: 0 and [128, 4096], unit: px.When Width and Height are both 0, the resolution is the same.When Width is 0 and Height is not 0, Width is scaled proportionally.When Width is not 0 and Height is 0, Height is scaled proportionally.When both Width and Height are not 0, the resolution is specified by the user.Default value: 0.
        /// </summary>
        [Input("height")]
        public Input<int>? Height { get; set; }

        /// <summary>
        /// Sample snapshot template name, length limit: 64 characters.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Adaptive resolution, optional value:open: At this time, Width represents the long side of the video, Height represents the short side of the video.close: At this point, Width represents the width of the video, and Height represents the height of the video.Default value: open.
        /// </summary>
        [Input("resolutionAdaptive")]
        public Input<string>? ResolutionAdaptive { get; set; }

        /// <summary>
        /// Sampling interval.When SampleType is Percent, specify the percentage of the sampling interval.When SampleType is Time, specify the sampling interval time in seconds.
        /// </summary>
        [Input("sampleInterval")]
        public Input<int>? SampleInterval { get; set; }

        /// <summary>
        /// Sampling snapshot type, optional value:Percent/Time.
        /// </summary>
        [Input("sampleType")]
        public Input<string>? SampleType { get; set; }

        /// <summary>
        /// The maximum value of the snapshot width (or long side), value range: 0 and [128, 4096], unit: px.When Width and Height are both 0, the resolution is the same.When Width is 0 and Height is not 0, Width is scaled proportionally.When Width is not 0 and Height is 0, Height is scaled proportionally.When both Width and Height are not 0, the resolution is specified by the user.Default value: 0.
        /// </summary>
        [Input("width")]
        public Input<int>? Width { get; set; }

        public SampleSnapshotTemplateState()
        {
        }
    }
}