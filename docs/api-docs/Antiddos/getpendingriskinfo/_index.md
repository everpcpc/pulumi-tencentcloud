
---
title: "getPendingRiskInfo"
title_tag: "tencentcloud.Antiddos.getPendingRiskInfo"
meta_desc: "Documentation for the tencentcloud.Antiddos.getPendingRiskInfo function with examples, input properties, output properties, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Use this data source to query detailed information of antiddos pending risk info

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const pendingRiskInfo = tencentcloud.Antiddos.getPendingRiskInfo({});
```
```python
import pulumi
import pulumi_tencentcloud as tencentcloud

pending_risk_info = tencentcloud.Antiddos.get_pending_risk_info()
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = Pulumi.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var pendingRiskInfo = Tencentcloud.Antiddos.GetPendingRiskInfo.Invoke();

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Antiddos"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Antiddos.GetPendingRiskInfo(ctx, nil, nil)
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
import com.pulumi.tencentcloud.Antiddos.AntiddosFunctions;
import com.pulumi.tencentcloud.Antiddos.inputs.GetPendingRiskInfoArgs;
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
        final var pendingRiskInfo = AntiddosFunctions.getPendingRiskInfo();

    }
}
```
```yaml
variables:
  pendingRiskInfo:
    fn::invoke:
      Function: tencentcloud:Antiddos:getPendingRiskInfo
      Arguments: {}
```
<!--End PulumiCodeChooser -->




## Using getPendingRiskInfo {#using}

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
><span class="k">function </span>getPendingRiskInfo<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetPendingRiskInfoArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Promise&lt;<span class="nx"><a href="#result">GetPendingRiskInfoResult</a></span>></span
><span class="k">
function </span>getPendingRiskInfoOutput<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetPendingRiskInfoOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Output&lt;<span class="nx"><a href="#result">GetPendingRiskInfoResult</a></span>></span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"
><span class="k">def </span>get_pending_risk_info<span class="p">(</span><span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                          <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>GetPendingRiskInfoResult</span
><span class="k">
def </span>get_pending_risk_info_output<span class="p">(</span><span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                          <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>Output[GetPendingRiskInfoResult]</span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"
><span class="k">func </span>GetPendingRiskInfo<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetPendingRiskInfoArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) (*<span class="nx"><a href="#result">GetPendingRiskInfoResult</a></span>, error)</span
><span class="k">
func </span>GetPendingRiskInfoOutput<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetPendingRiskInfoOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) GetPendingRiskInfoResultOutput</span
></code></pre></div>

&gt; Note: This function is named `GetPendingRiskInfo` in the Go SDK.

</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static class </span><span class="nx">GetPendingRiskInfo </span><span class="p">
{</span><span class="k">
    public static </span>Task&lt;<span class="nx"><a href="#result">GetPendingRiskInfoResult</a></span>> <span class="p">InvokeAsync(</span><span class="nx">GetPendingRiskInfoArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="k">
    public static </span>Output&lt;<span class="nx"><a href="#result">GetPendingRiskInfoResult</a></span>> <span class="p">Invoke(</span><span class="nx">GetPendingRiskInfoInvokeArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="p">
}</span></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static CompletableFuture&lt;<span class="nx"><a href="#result">GetPendingRiskInfoResult</a></span>> </span>getPendingRiskInfo<span class="p">(</span><span class="nx">GetPendingRiskInfoArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">InvokeOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
<span class="c">// Output-based functions aren't available in Java yet</span>
</code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml"><span class="k">fn::invoke:</span>
<span class="k">&nbsp;&nbsp;function:</span> tencentcloud:Antiddos/getPendingRiskInfo:getPendingRiskInfo
<span class="k">&nbsp;&nbsp;arguments:</span>
<span class="c">&nbsp;&nbsp;&nbsp;&nbsp;# arguments dictionary</span></code></pre></div>
</pulumi-choosable>
</div>



The following arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-optional"
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
<dl class="resources-properties"><dt class="property-optional"
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
<dl class="resources-properties"><dt class="property-optional"
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
<dl class="resources-properties"><dt class="property-optional"
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
<dl class="resources-properties"><dt class="property-optional"
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
<dl class="resources-properties"><dt class="property-optional"
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




## getPendingRiskInfo Result {#result}

The following output properties are available:



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="attackingcount_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attackingcount_csharp" style="color: inherit; text-decoration: inherit;">Attacking<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of resources in the attack.</p>
</dd><dt class="property-"
            title="">
        <span id="blockingcount_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#blockingcount_csharp" style="color: inherit; text-decoration: inherit;">Blocking<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of resources in blockage.</p>
</dd><dt class="property-"
            title="">
        <span id="expiredcount_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#expiredcount_csharp" style="color: inherit; text-decoration: inherit;">Expired<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of expired resources.</p>
</dd><dt class="property-"
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
        <span id="ispaidusr_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#ispaidusr_csharp" style="color: inherit; text-decoration: inherit;">Is<wbr>Paid<wbr>Usr</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">bool</span>
    </dt>
    <dd><p>Is it a paid user? True: paid user, false: regular user.</p>
</dd><dt class="property-"
            title="">
        <span id="total_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#total_csharp" style="color: inherit; text-decoration: inherit;">Total</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Total number of all pending risk events.</p>
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
        <span id="attackingcount_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attackingcount_go" style="color: inherit; text-decoration: inherit;">Attacking<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of resources in the attack.</p>
</dd><dt class="property-"
            title="">
        <span id="blockingcount_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#blockingcount_go" style="color: inherit; text-decoration: inherit;">Blocking<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of resources in blockage.</p>
</dd><dt class="property-"
            title="">
        <span id="expiredcount_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#expiredcount_go" style="color: inherit; text-decoration: inherit;">Expired<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of expired resources.</p>
</dd><dt class="property-"
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
        <span id="ispaidusr_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#ispaidusr_go" style="color: inherit; text-decoration: inherit;">Is<wbr>Paid<wbr>Usr</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">bool</span>
    </dt>
    <dd><p>Is it a paid user? True: paid user, false: regular user.</p>
</dd><dt class="property-"
            title="">
        <span id="total_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#total_go" style="color: inherit; text-decoration: inherit;">Total</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Total number of all pending risk events.</p>
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
        <span id="attackingcount_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attackingcount_java" style="color: inherit; text-decoration: inherit;">attacking<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>Number of resources in the attack.</p>
</dd><dt class="property-"
            title="">
        <span id="blockingcount_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#blockingcount_java" style="color: inherit; text-decoration: inherit;">blocking<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>Number of resources in blockage.</p>
</dd><dt class="property-"
            title="">
        <span id="expiredcount_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#expiredcount_java" style="color: inherit; text-decoration: inherit;">expired<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>Number of expired resources.</p>
</dd><dt class="property-"
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
        <span id="ispaidusr_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#ispaidusr_java" style="color: inherit; text-decoration: inherit;">is<wbr>Paid<wbr>Usr</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Boolean</span>
    </dt>
    <dd><p>Is it a paid user? True: paid user, false: regular user.</p>
</dd><dt class="property-"
            title="">
        <span id="total_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#total_java" style="color: inherit; text-decoration: inherit;">total</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>Total number of all pending risk events.</p>
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
        <span id="attackingcount_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attackingcount_nodejs" style="color: inherit; text-decoration: inherit;">attacking<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>Number of resources in the attack.</p>
</dd><dt class="property-"
            title="">
        <span id="blockingcount_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#blockingcount_nodejs" style="color: inherit; text-decoration: inherit;">blocking<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>Number of resources in blockage.</p>
</dd><dt class="property-"
            title="">
        <span id="expiredcount_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#expiredcount_nodejs" style="color: inherit; text-decoration: inherit;">expired<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>Number of expired resources.</p>
</dd><dt class="property-"
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
        <span id="ispaidusr_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#ispaidusr_nodejs" style="color: inherit; text-decoration: inherit;">is<wbr>Paid<wbr>Usr</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">boolean</span>
    </dt>
    <dd><p>Is it a paid user? True: paid user, false: regular user.</p>
</dd><dt class="property-"
            title="">
        <span id="total_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#total_nodejs" style="color: inherit; text-decoration: inherit;">total</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>Total number of all pending risk events.</p>
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
        <span id="attacking_count_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attacking_count_python" style="color: inherit; text-decoration: inherit;">attacking_<wbr>count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of resources in the attack.</p>
</dd><dt class="property-"
            title="">
        <span id="blocking_count_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#blocking_count_python" style="color: inherit; text-decoration: inherit;">blocking_<wbr>count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of resources in blockage.</p>
</dd><dt class="property-"
            title="">
        <span id="expired_count_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#expired_count_python" style="color: inherit; text-decoration: inherit;">expired_<wbr>count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Number of expired resources.</p>
</dd><dt class="property-"
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
        <span id="is_paid_usr_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#is_paid_usr_python" style="color: inherit; text-decoration: inherit;">is_<wbr>paid_<wbr>usr</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">bool</span>
    </dt>
    <dd><p>Is it a paid user? True: paid user, false: regular user.</p>
</dd><dt class="property-"
            title="">
        <span id="total_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#total_python" style="color: inherit; text-decoration: inherit;">total</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Total number of all pending risk events.</p>
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
        <span id="attackingcount_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#attackingcount_yaml" style="color: inherit; text-decoration: inherit;">attacking<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>Number of resources in the attack.</p>
</dd><dt class="property-"
            title="">
        <span id="blockingcount_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#blockingcount_yaml" style="color: inherit; text-decoration: inherit;">blocking<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>Number of resources in blockage.</p>
</dd><dt class="property-"
            title="">
        <span id="expiredcount_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#expiredcount_yaml" style="color: inherit; text-decoration: inherit;">expired<wbr>Count</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>Number of expired resources.</p>
</dd><dt class="property-"
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
        <span id="ispaidusr_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#ispaidusr_yaml" style="color: inherit; text-decoration: inherit;">is<wbr>Paid<wbr>Usr</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Boolean</span>
    </dt>
    <dd><p>Is it a paid user? True: paid user, false: regular user.</p>
</dd><dt class="property-"
            title="">
        <span id="total_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#total_yaml" style="color: inherit; text-decoration: inherit;">total</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>Total number of all pending risk events.</p>
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
