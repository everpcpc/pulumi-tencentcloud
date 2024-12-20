// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ses.Inputs
{

    public sealed class SendEmailTemplateArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Variable parameters in the template. Please use json.dump to format the JSON object into a string type.The object is a set of key-value pairs. Each key denotes a variable, which is represented by {{key}}. The key will be replaced with the correspondingvalue (represented by {{value}}) when sending the email.Note: The parameter value cannot be data of a complex type such as HTML.Example: {name:xxx,age:xx}.
        /// </summary>
        [Input("templateData", required: true)]
        public Input<string> TemplateData { get; set; } = null!;

        /// <summary>
        /// Template ID. If you do not have any template, please create one.
        /// </summary>
        [Input("templateId", required: true)]
        public Input<int> TemplateId { get; set; } = null!;

        public SendEmailTemplateArgs()
        {
        }
        public static new SendEmailTemplateArgs Empty => new SendEmailTemplateArgs();
    }
}
