
---
title: "getListKeys"
title_tag: "tencentcloud.Kms.getListKeys"
meta_desc: "Documentation for the tencentcloud.Kms.getListKeys function with examples, input properties, output properties, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Use this data source to query detailed information of kms list_keys

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const example = tencentcloud.Kms.getListKeys({
    role: 1,
});
```
```python
import pulumi
import pulumi_tencentcloud as tencentcloud

example = tencentcloud.Kms.get_list_keys(role=1)
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = Pulumi.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var example = Tencentcloud.Kms.GetListKeys.Invoke(new()
    {
        Role = 1,
    });

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Kms"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Kms.GetListKeys(ctx, &kms.GetListKeysArgs{
			Role: pulumi.IntRef(1),
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
import com.pulumi.tencentcloud.Kms.KmsFunctions;
import com.pulumi.tencentcloud.Kms.inputs.GetListKeysArgs;
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
        final var example = KmsFunctions.getListKeys(GetListKeysArgs.builder()
            .role(1)
            .build());

    }
}
```
```yaml
variables:
  example:
    fn::invoke:
      Function: tencentcloud:Kms:getListKeys
      Arguments:
        role: 1
```
<!--End PulumiCodeChooser -->




## Using getListKeys {#using}

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
><span class="k">function </span>getListKeys<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetListKeysArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Promise&lt;<span class="nx"><a href="#result">GetListKeysResult</a></span>></span
><span class="k">
function </span>getListKeysOutput<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetListKeysOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Output&lt;<span class="nx"><a href="#result">GetListKeysResult</a></span>></span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"
><span class="k">def </span>get_list_keys<span class="p">(</span><span class="nx">hsm_cluster_id</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                  <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                  <span class="nx">role</span><span class="p">:</span> <span class="nx">Optional[int]</span> = None<span class="p">,</span>
                  <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>GetListKeysResult</span
><span class="k">
def </span>get_list_keys_output<span class="p">(</span><span class="nx">hsm_cluster_id</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                  <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                  <span class="nx">role</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[int]]</span> = None<span class="p">,</span>
                  <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>Output[GetListKeysResult]</span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"
><span class="k">func </span>GetListKeys<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetListKeysArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) (*<span class="nx"><a href="#result">GetListKeysResult</a></span>, error)</span
><span class="k">
func </span>GetListKeysOutput<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetListKeysOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) GetListKeysResultOutput</span
></code></pre></div>

&gt; Note: This function is named `GetListKeys` in the Go SDK.

</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static class </span><span class="nx">GetListKeys </span><span class="p">
{</span><span class="k">
    public static </span>Task&lt;<span class="nx"><a href="#result">GetListKeysResult</a></span>> <span class="p">InvokeAsync(</span><span class="nx">GetListKeysArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="k">
    public static </span>Output&lt;<span class="nx"><a href="#result">GetListKeysResult</a></span>> <span class="p">Invoke(</span><span class="nx">GetListKeysInvokeArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="p">
}</span></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static CompletableFuture&lt;<span class="nx"><a href="#result">GetListKeysResult</a></span>> </span>getListKeys<span class="p">(</span><span class="nx">GetListKeysArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">InvokeOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
<span class="c">// Output-based functions aren't available in Java yet</span>
</code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml"><span class="k">fn::invoke:</span>
<span class="k">&nbsp;&nbsp;function:</span> tencentcloud:Kms/getListKeys:getListKeys
<span class="k">&nbsp;&nbsp;arguments:</span>
<span class="c">&nbsp;&nbsp;&nbsp;&nbsp;# arguments dictionary</span></code></pre></div>
</pulumi-choosable>
</div>



The following arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="hsmclusterid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsmclusterid_csharp" style="color: inherit; text-decoration: inherit;">Hsm<wbr>Cluster<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>HSM cluster ID (only valid for KMS exclusive/managed service instances).</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_csharp" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="role_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_csharp" style="color: inherit; text-decoration: inherit;">Role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Filter based on the creator role. The default value is 0, which indicates the cmk created by the user himself, and 1, which indicates the cmk automatically created by authorizing other cloud products.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="hsmclusterid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsmclusterid_go" style="color: inherit; text-decoration: inherit;">Hsm<wbr>Cluster<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>HSM cluster ID (only valid for KMS exclusive/managed service instances).</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_go" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="role_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_go" style="color: inherit; text-decoration: inherit;">Role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Filter based on the creator role. The default value is 0, which indicates the cmk created by the user himself, and 1, which indicates the cmk automatically created by authorizing other cloud products.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="hsmclusterid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsmclusterid_java" style="color: inherit; text-decoration: inherit;">hsm<wbr>Cluster<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>HSM cluster ID (only valid for KMS exclusive/managed service instances).</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_java" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="role_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_java" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd><p>Filter based on the creator role. The default value is 0, which indicates the cmk created by the user himself, and 1, which indicates the cmk automatically created by authorizing other cloud products.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="hsmclusterid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsmclusterid_nodejs" style="color: inherit; text-decoration: inherit;">hsm<wbr>Cluster<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>HSM cluster ID (only valid for KMS exclusive/managed service instances).</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_nodejs" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="role_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_nodejs" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd><p>Filter based on the creator role. The default value is 0, which indicates the cmk created by the user himself, and 1, which indicates the cmk automatically created by authorizing other cloud products.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="hsm_cluster_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsm_cluster_id_python" style="color: inherit; text-decoration: inherit;">hsm_<wbr>cluster_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>HSM cluster ID (only valid for KMS exclusive/managed service instances).</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="result_output_file_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#result_output_file_python" style="color: inherit; text-decoration: inherit;">result_<wbr>output_<wbr>file</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="role_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_python" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd><p>Filter based on the creator role. The default value is 0, which indicates the cmk created by the user himself, and 1, which indicates the cmk automatically created by authorizing other cloud products.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-optional"
            title="Optional">
        <span id="hsmclusterid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsmclusterid_yaml" style="color: inherit; text-decoration: inherit;">hsm<wbr>Cluster<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>HSM cluster ID (only valid for KMS exclusive/managed service instances).</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="resultoutputfile_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_yaml" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Used to save results.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="role_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_yaml" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd><p>Filter based on the creator role. The default value is 0, which indicates the cmk created by the user himself, and 1, which indicates the cmk automatically created by authorizing other cloud products.</p>
</dd></dl>
</pulumi-choosable>
</div>




## getListKeys Result {#result}

The following output properties are available:



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-"
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
        <span id="keys_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keys_csharp" style="color: inherit; text-decoration: inherit;">Keys</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getlistkeyskey">List&lt;Tencent<wbr>Cloud<wbr>IAC.<wbr>Pulumi<wbr>Package.<wbr>Tencentcloud.<wbr>Kms.<wbr>Outputs.<wbr>Get<wbr>List<wbr>Keys<wbr>Key&gt;</a></span>
    </dt>
    <dd><p>A list of KMS keys.</p>
</dd><dt class="property-"
            title="">
        <span id="hsmclusterid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsmclusterid_csharp" style="color: inherit; text-decoration: inherit;">Hsm<wbr>Cluster<wbr>Id</a>
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
    <dd></dd><dt class="property-"
            title="">
        <span id="role_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_csharp" style="color: inherit; text-decoration: inherit;">Role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-"
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
        <span id="keys_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keys_go" style="color: inherit; text-decoration: inherit;">Keys</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getlistkeyskey">[]Get<wbr>List<wbr>Keys<wbr>Key</a></span>
    </dt>
    <dd><p>A list of KMS keys.</p>
</dd><dt class="property-"
            title="">
        <span id="hsmclusterid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsmclusterid_go" style="color: inherit; text-decoration: inherit;">Hsm<wbr>Cluster<wbr>Id</a>
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
    <dd></dd><dt class="property-"
            title="">
        <span id="role_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_go" style="color: inherit; text-decoration: inherit;">Role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-"
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
        <span id="keys_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keys_java" style="color: inherit; text-decoration: inherit;">keys</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getlistkeyskey">List&lt;Get<wbr>List<wbr>Keys<wbr>Key&gt;</a></span>
    </dt>
    <dd><p>A list of KMS keys.</p>
</dd><dt class="property-"
            title="">
        <span id="hsmclusterid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsmclusterid_java" style="color: inherit; text-decoration: inherit;">hsm<wbr>Cluster<wbr>Id</a>
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
    <dd></dd><dt class="property-"
            title="">
        <span id="role_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_java" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Integer</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-"
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
        <span id="keys_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keys_nodejs" style="color: inherit; text-decoration: inherit;">keys</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getlistkeyskey">Get<wbr>List<wbr>Keys<wbr>Key[]</a></span>
    </dt>
    <dd><p>A list of KMS keys.</p>
</dd><dt class="property-"
            title="">
        <span id="hsmclusterid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsmclusterid_nodejs" style="color: inherit; text-decoration: inherit;">hsm<wbr>Cluster<wbr>Id</a>
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
    <dd></dd><dt class="property-"
            title="">
        <span id="role_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_nodejs" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">number</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-"
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
        <span id="keys_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keys_python" style="color: inherit; text-decoration: inherit;">keys</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getlistkeyskey">Get<wbr>List<wbr>Keys<wbr>Key]</a></span>
    </dt>
    <dd><p>A list of KMS keys.</p>
</dd><dt class="property-"
            title="">
        <span id="hsm_cluster_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsm_cluster_id_python" style="color: inherit; text-decoration: inherit;">hsm_<wbr>cluster_<wbr>id</a>
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
    <dd></dd><dt class="property-"
            title="">
        <span id="role_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_python" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">int</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-"
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
        <span id="keys_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keys_yaml" style="color: inherit; text-decoration: inherit;">keys</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getlistkeyskey">List&lt;Property Map&gt;</a></span>
    </dt>
    <dd><p>A list of KMS keys.</p>
</dd><dt class="property-"
            title="">
        <span id="hsmclusterid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#hsmclusterid_yaml" style="color: inherit; text-decoration: inherit;">hsm<wbr>Cluster<wbr>Id</a>
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
    <dd></dd><dt class="property-"
            title="">
        <span id="role_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_yaml" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Number</span>
    </dt>
    <dd></dd></dl>
</pulumi-choosable>
</div>




## Supporting Types


<h4 id="getlistkeyskey">Get<wbr>List<wbr>Keys<wbr>Key</h4>



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="keyid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keyid_csharp" style="color: inherit; text-decoration: inherit;">Key<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>ID of CMK.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="keyid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keyid_go" style="color: inherit; text-decoration: inherit;">Key<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>ID of CMK.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="keyid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keyid_java" style="color: inherit; text-decoration: inherit;">key<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>ID of CMK.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="keyid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keyid_nodejs" style="color: inherit; text-decoration: inherit;">key<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>ID of CMK.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="key_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#key_id_python" style="color: inherit; text-decoration: inherit;">key_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>ID of CMK.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="keyid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#keyid_yaml" style="color: inherit; text-decoration: inherit;">key<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>ID of CMK.</p>
</dd></dl>
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
