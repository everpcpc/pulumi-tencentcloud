
---
title: "getDefaultHealthCheckIp"
title_tag: "tencentcloud.Vpn.getDefaultHealthCheckIp"
meta_desc: "Documentation for the tencentcloud.Vpn.getDefaultHealthCheckIp function with examples, input properties, output properties, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Use this data source to query detailed information of vpn default_health_check_ip

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const defaultHealthCheckIp = tencentcloud.Vpn.getDefaultHealthCheckIp({
    vpnGatewayId: "vpngw-gt8bianl",
});
```
```python
import pulumi
import pulumi_tencentcloud as tencentcloud

default_health_check_ip = tencentcloud.Vpn.get_default_health_check_ip(vpn_gateway_id="vpngw-gt8bianl")
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = Pulumi.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var defaultHealthCheckIp = Tencentcloud.Vpn.GetDefaultHealthCheckIp.Invoke(new()
    {
        VpnGatewayId = "vpngw-gt8bianl",
    });

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpn"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Vpn.GetDefaultHealthCheckIp(ctx, &vpn.GetDefaultHealthCheckIpArgs{
			VpnGatewayId: "vpngw-gt8bianl",
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
import com.pulumi.tencentcloud.Vpn.VpnFunctions;
import com.pulumi.tencentcloud.Vpn.inputs.GetDefaultHealthCheckIpArgs;
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
        final var defaultHealthCheckIp = VpnFunctions.getDefaultHealthCheckIp(GetDefaultHealthCheckIpArgs.builder()
            .vpnGatewayId("vpngw-gt8bianl")
            .build());

    }
}
```
```yaml
variables:
  defaultHealthCheckIp:
    fn::invoke:
      Function: tencentcloud:Vpn:getDefaultHealthCheckIp
      Arguments:
        vpnGatewayId: vpngw-gt8bianl
```
<!--End PulumiCodeChooser -->




## Using getDefaultHealthCheckIp {#using}

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
><span class="k">function </span>getDefaultHealthCheckIp<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetDefaultHealthCheckIpArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Promise&lt;<span class="nx"><a href="#result">GetDefaultHealthCheckIpResult</a></span>></span
><span class="k">
function </span>getDefaultHealthCheckIpOutput<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetDefaultHealthCheckIpOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Output&lt;<span class="nx"><a href="#result">GetDefaultHealthCheckIpResult</a></span>></span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"
><span class="k">def </span>get_default_health_check_ip<span class="p">(</span><span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                                <span class="nx">vpn_gateway_id</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                                <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>GetDefaultHealthCheckIpResult</span
><span class="k">
def </span>get_default_health_check_ip_output<span class="p">(</span><span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                                <span class="nx">vpn_gateway_id</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                                <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>Output[GetDefaultHealthCheckIpResult]</span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"
><span class="k">func </span>GetDefaultHealthCheckIp<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetDefaultHealthCheckIpArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) (*<span class="nx"><a href="#result">GetDefaultHealthCheckIpResult</a></span>, error)</span
><span class="k">
func </span>GetDefaultHealthCheckIpOutput<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetDefaultHealthCheckIpOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) GetDefaultHealthCheckIpResultOutput</span
></code></pre></div>

&gt; Note: This function is named `GetDefaultHealthCheckIp` in the Go SDK.

</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static class </span><span class="nx">GetDefaultHealthCheckIp </span><span class="p">
{</span><span class="k">
    public static </span>Task&lt;<span class="nx"><a href="#result">GetDefaultHealthCheckIpResult</a></span>> <span class="p">InvokeAsync(</span><span class="nx">GetDefaultHealthCheckIpArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="k">
    public static </span>Output&lt;<span class="nx"><a href="#result">GetDefaultHealthCheckIpResult</a></span>> <span class="p">Invoke(</span><span class="nx">GetDefaultHealthCheckIpInvokeArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="p">
}</span></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static CompletableFuture&lt;<span class="nx"><a href="#result">GetDefaultHealthCheckIpResult</a></span>> </span>getDefaultHealthCheckIp<span class="p">(</span><span class="nx">GetDefaultHealthCheckIpArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">InvokeOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
<span class="c">// Output-based functions aren't available in Java yet</span>
</code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml"><span class="k">fn::invoke:</span>
<span class="k">&nbsp;&nbsp;function:</span> tencentcloud:Vpn/getDefaultHealthCheckIp:getDefaultHealthCheckIp
<span class="k">&nbsp;&nbsp;arguments:</span>
<span class="c">&nbsp;&nbsp;&nbsp;&nbsp;# arguments dictionary</span></code></pre></div>
</pulumi-choosable>
</div>



The following arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="vpngatewayid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpngatewayid_csharp" style="color: inherit; text-decoration: inherit;">Vpn<wbr>Gateway<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>vpn gateway id.</p>
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
        <span id="vpngatewayid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpngatewayid_go" style="color: inherit; text-decoration: inherit;">Vpn<wbr>Gateway<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>vpn gateway id.</p>
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
        <span id="vpngatewayid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpngatewayid_java" style="color: inherit; text-decoration: inherit;">vpn<wbr>Gateway<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>vpn gateway id.</p>
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
        <span id="vpngatewayid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpngatewayid_nodejs" style="color: inherit; text-decoration: inherit;">vpn<wbr>Gateway<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>vpn gateway id.</p>
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
        <span id="vpn_gateway_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpn_gateway_id_python" style="color: inherit; text-decoration: inherit;">vpn_<wbr>gateway_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>vpn gateway id.</p>
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
        <span id="vpngatewayid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpngatewayid_yaml" style="color: inherit; text-decoration: inherit;">vpn<wbr>Gateway<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>vpn gateway id.</p>
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




## getDefaultHealthCheckIp Result {#result}

The following output properties are available:



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="healthchecklocalip_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#healthchecklocalip_csharp" style="color: inherit; text-decoration: inherit;">Health<wbr>Check<wbr>Local<wbr>Ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>local ip of health check.</p>
</dd><dt class="property-"
            title="">
        <span id="healthcheckremoteip_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#healthcheckremoteip_csharp" style="color: inherit; text-decoration: inherit;">Health<wbr>Check<wbr>Remote<wbr>Ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>remote ip for health check.</p>
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
        <span id="vpngatewayid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpngatewayid_csharp" style="color: inherit; text-decoration: inherit;">Vpn<wbr>Gateway<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="healthchecklocalip_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#healthchecklocalip_go" style="color: inherit; text-decoration: inherit;">Health<wbr>Check<wbr>Local<wbr>Ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>local ip of health check.</p>
</dd><dt class="property-"
            title="">
        <span id="healthcheckremoteip_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#healthcheckremoteip_go" style="color: inherit; text-decoration: inherit;">Health<wbr>Check<wbr>Remote<wbr>Ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>remote ip for health check.</p>
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
        <span id="vpngatewayid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpngatewayid_go" style="color: inherit; text-decoration: inherit;">Vpn<wbr>Gateway<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="healthchecklocalip_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#healthchecklocalip_java" style="color: inherit; text-decoration: inherit;">health<wbr>Check<wbr>Local<wbr>Ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>local ip of health check.</p>
</dd><dt class="property-"
            title="">
        <span id="healthcheckremoteip_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#healthcheckremoteip_java" style="color: inherit; text-decoration: inherit;">health<wbr>Check<wbr>Remote<wbr>Ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>remote ip for health check.</p>
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
        <span id="vpngatewayid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpngatewayid_java" style="color: inherit; text-decoration: inherit;">vpn<wbr>Gateway<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="healthchecklocalip_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#healthchecklocalip_nodejs" style="color: inherit; text-decoration: inherit;">health<wbr>Check<wbr>Local<wbr>Ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>local ip of health check.</p>
</dd><dt class="property-"
            title="">
        <span id="healthcheckremoteip_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#healthcheckremoteip_nodejs" style="color: inherit; text-decoration: inherit;">health<wbr>Check<wbr>Remote<wbr>Ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>remote ip for health check.</p>
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
        <span id="vpngatewayid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpngatewayid_nodejs" style="color: inherit; text-decoration: inherit;">vpn<wbr>Gateway<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="health_check_local_ip_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#health_check_local_ip_python" style="color: inherit; text-decoration: inherit;">health_<wbr>check_<wbr>local_<wbr>ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>local ip of health check.</p>
</dd><dt class="property-"
            title="">
        <span id="health_check_remote_ip_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#health_check_remote_ip_python" style="color: inherit; text-decoration: inherit;">health_<wbr>check_<wbr>remote_<wbr>ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>remote ip for health check.</p>
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
        <span id="vpn_gateway_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpn_gateway_id_python" style="color: inherit; text-decoration: inherit;">vpn_<wbr>gateway_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd></dd><dt class="property-"
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
        <span id="healthchecklocalip_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#healthchecklocalip_yaml" style="color: inherit; text-decoration: inherit;">health<wbr>Check<wbr>Local<wbr>Ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>local ip of health check.</p>
</dd><dt class="property-"
            title="">
        <span id="healthcheckremoteip_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#healthcheckremoteip_yaml" style="color: inherit; text-decoration: inherit;">health<wbr>Check<wbr>Remote<wbr>Ip</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>remote ip for health check.</p>
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
        <span id="vpngatewayid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#vpngatewayid_yaml" style="color: inherit; text-decoration: inherit;">vpn<wbr>Gateway<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
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
