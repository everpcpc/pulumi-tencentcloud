
---
title: "getParseLiveStreamProcessNotification"
title_tag: "tencentcloud.Mps.getParseLiveStreamProcessNotification"
meta_desc: "Documentation for the tencentcloud.Mps.getParseLiveStreamProcessNotification function with examples, input properties, output properties, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Use this data source to query detailed information of mps parse_live_stream_process_notification

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const parseLiveStreamProcessNotification = tencentcloud.Mps.getParseLiveStreamProcessNotification({
    content: "your_content",
});
```
```python
import pulumi
import pulumi_tencentcloud as tencentcloud

parse_live_stream_process_notification = tencentcloud.Mps.get_parse_live_stream_process_notification(content="your_content")
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = Pulumi.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var parseLiveStreamProcessNotification = Tencentcloud.Mps.GetParseLiveStreamProcessNotification.Invoke(new()
    {
        Content = "your_content",
    });

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mps"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Mps.GetParseLiveStreamProcessNotification(ctx, &mps.GetParseLiveStreamProcessNotificationArgs{
			Content: "your_content",
		}, nil)
		if err != nil {
			return err
		}
		return nil
	})
}
```
```java
package generated_program;

import com.pulumi.Context;
import com.pulumi.Pulumi;
import com.pulumi.core.Output;
import com.pulumi.tencentcloud.Mps.MpsFunctions;
import com.pulumi.tencentcloud.Mps.inputs.GetParseLiveStreamProcessNotificationArgs;
import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.io.File;
import java.nio.file.Files;
import java.nio.file.Paths;

public class App {
    public static void main(String[] args) {
        Pulumi.run(App::stack);
    }

    public static void stack(Context ctx) {
        final var parseLiveStreamProcessNotification = MpsFunctions.getParseLiveStreamProcessNotification(GetParseLiveStreamProcessNotificationArgs.builder()
            .content("your_content")
            .build());

    }
}
```
```yaml
variables:
  parseLiveStreamProcessNotification:
    fn::invoke:
      Function: tencentcloud:Mps:getParseLiveStreamProcessNotification
      Arguments:
        content: your_content
```
<!--End PulumiCodeChooser -->




## Using getParseLiveStreamProcessNotification {#using}

Two invocation forms are available. The direct form accepts plain
arguments and either blocks until the result value is available, or
returns a Promise-wrapped result. The output form accepts
Input-wrapped arguments and returns an Output-wrapped result.

<div>
<pulumi-chooser type="language" options="typescript,python,go,csharp,java,yaml"></pulumi-chooser>
</div>


<div>
<pulumi-choosable type="language" values="javascript,typescript">
<div class="highlight"
><pre class="chroma"><code class="language-typescript" data-lang="typescript"
><span class="k">function </span>getParseLiveStreamProcessNotification<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetParseLiveStreamProcessNotificationArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Promise&lt;<span class="nx"><a href="#result">GetParseLiveStreamProcessNotificationResult</a></span>></span
><span class="k">
function </span>getParseLiveStreamProcessNotificationOutput<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetParseLiveStreamProcessNotificationOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Output&lt;<span class="nx"><a href="#result">GetParseLiveStreamProcessNotificationResult</a></span>></span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"
><span class="k">def </span>get_parse_live_stream_process_notification<span class="p">(</span><span class="nx">content</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                                               <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                                               <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>GetParseLiveStreamProcessNotificationResult</span
><span class="k">
def </span>get_parse_live_stream_process_notification_output<span class="p">(</span><span class="nx">content</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                                               <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                                               <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>Output[GetParseLiveStreamProcessNotificationResult]</span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"
><span class="k">func </span>GetParseLiveStreamProcessNotification<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetParseLiveStreamProcessNotificationArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) (*<span class="nx"><a href="#result">GetParseLiveStreamProcessNotificationResult</a></span>, error)</span
><span class="k">
func </span>GetParseLiveStreamProcessNotificationOutput<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetParseLiveStreamProcessNotificationOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) GetParseLiveStreamProcessNotificationResultOutput</span
></code></pre></div>

&gt; Note: This function is named `GetParseLiveStreamProcessNotification` in the Go SDK.

</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static class </span><span class="nx">GetParseLiveStreamProcessNotification </span><span class="p">
{</span><span class="k">
    public static </span>Task&lt;<span class="nx"><a href="#result">GetParseLiveStreamProcessNotificationResult</a></span>> <span class="p">InvokeAsync(</span><span class="nx">GetParseLiveStreamProcessNotificationArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="k">
    public static </span>Output&lt;<span class="nx"><a href="#result">GetParseLiveStreamProcessNotificationResult</a></span>> <span class="p">Invoke(</span><span class="nx">GetParseLiveStreamProcessNotificationInvokeArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="p">
}</span></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static CompletableFuture&lt;<span class="nx"><a href="#result">GetParseLiveStreamProcessNotificationResult</a></span>> </span>getParseLiveStreamProcessNotification<span class="p">(</span><span class="nx">GetParseLiveStreamProcessNotificationArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">InvokeOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
<span class="c">// Output-based functions aren't available in Java yet</span>
</code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml"><span class="k">fn::invoke:</span>
<span class="k">&nbsp;&nbsp;function:</span> tencentcloud:Mps/getParseLiveStreamProcessNotification:getParseLiveStreamProcessNotification
<span class="k">&nbsp;&nbsp;arguments:</span>
<span class="c">&nbsp;&nbsp;&nbsp;&nbsp;# arguments dictionary</span></code></pre></div>
</pulumi-choosable>
</div>



The following arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="content_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_csharp" style="color: inherit; text-decoration: inherit;">Content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Live stream event notification obtained from CMQ.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_csharp" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="content_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_go" style="color: inherit; text-decoration: inherit;">Content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Live stream event notification obtained from CMQ.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_go" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="content_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_java" style="color: inherit; text-decoration: inherit;">content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Live stream event notification obtained from CMQ.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_java" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="content_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_nodejs" style="color: inherit; text-decoration: inherit;">content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Live stream event notification obtained from CMQ.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_nodejs" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="content_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_python" style="color: inherit; text-decoration: inherit;">content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Live stream event notification obtained from CMQ.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="result_output_file_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#result_output_file_python" style="color: inherit; text-decoration: inherit;">result_<wbr>output_<wbr>file</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="content_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_yaml" style="color: inherit; text-decoration: inherit;">content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Live stream event notification obtained from CMQ.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_yaml" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd></dl>
</pulumi-choosable>
</div>




## getParseLiveStreamProcessNotification Result {#result}

The following output properties are available:



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="content_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_csharp" style="color: inherit; text-decoration: inherit;">Content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="id_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_csharp" style="color: inherit; text-decoration: inherit;">Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="resultoutputfile_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_csharp" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="content_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_go" style="color: inherit; text-decoration: inherit;">Content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="id_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_go" style="color: inherit; text-decoration: inherit;">Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="resultoutputfile_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_go" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="content_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_java" style="color: inherit; text-decoration: inherit;">content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="id_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_java" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="resultoutputfile_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_java" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="content_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_nodejs" style="color: inherit; text-decoration: inherit;">content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="id_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_nodejs" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="resultoutputfile_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_nodejs" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="content_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_python" style="color: inherit; text-decoration: inherit;">content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_python" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="result_output_file_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#result_output_file_python" style="color: inherit; text-decoration: inherit;">result_<wbr>output_<wbr>file</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="content_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#content_yaml" style="color: inherit; text-decoration: inherit;">content</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="id_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_yaml" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="resultoutputfile_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_yaml" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>





<h2 id="package-details">Package Details</h2>
<dl class="package-details">
	<dt>Repository</dt>
	<dd><a href="https://github.com/tencentcloudstack/pulumi-tencentcloud">tencentcloud tencentcloudstack/pulumi-tencentcloud</a></dd>
	<dt>License</dt>
	<dd>Apache-2.0</dd>
	<dt>Notes</dt>
	<dd><p>This Pulumi package is based on the <a href="https://github.com/tencentcloudstack/terraform-provider-tencentcloud"><code>tencentcloud</code> Terraform Provider</a>.</p>
</dd>
</dl>

