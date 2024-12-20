
---
title: "getInstanceNodeInfo"
title_tag: "tencentcloud.Dcdb.getInstanceNodeInfo"
meta_desc: "Documentation for the tencentcloud.Dcdb.getInstanceNodeInfo function with examples, input properties, output properties, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Use this data source to query detailed information of dcdb instance_node_info

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const instanceNodeInfo = tencentcloud.Dcdb.getInstanceNodeInfo({
    instanceId: local.dcdb_id,
});
```
```python
import pulumi
import pulumi_tencentcloud as tencentcloud

instance_node_info = tencentcloud.Dcdb.get_instance_node_info(instance_id=local["dcdb_id"])
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = Pulumi.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var instanceNodeInfo = Tencentcloud.Dcdb.GetInstanceNodeInfo.Invoke(new()
    {
        InstanceId = local.Dcdb_id,
    });

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dcdb"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Dcdb.GetInstanceNodeInfo(ctx, &dcdb.GetInstanceNodeInfoArgs{
			InstanceId: local.Dcdb_id,
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
import com.pulumi.tencentcloud.Dcdb.DcdbFunctions;
import com.pulumi.tencentcloud.Dcdb.inputs.GetInstanceNodeInfoArgs;
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
        final var instanceNodeInfo = DcdbFunctions.getInstanceNodeInfo(GetInstanceNodeInfoArgs.builder()
            .instanceId(local.dcdb_id())
            .build());

    }
}
```
```yaml
variables:
  instanceNodeInfo:
    fn::invoke:
      Function: tencentcloud:Dcdb:getInstanceNodeInfo
      Arguments:
        instanceId: ${local.dcdb_id}
```
<!--End PulumiCodeChooser -->




## Using getInstanceNodeInfo {#using}

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
><span class="k">function </span>getInstanceNodeInfo<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetInstanceNodeInfoArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Promise&lt;<span class="nx"><a href="#result">GetInstanceNodeInfoResult</a></span>></span
><span class="k">
function </span>getInstanceNodeInfoOutput<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetInstanceNodeInfoOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Output&lt;<span class="nx"><a href="#result">GetInstanceNodeInfoResult</a></span>></span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"
><span class="k">def </span>get_instance_node_info<span class="p">(</span><span class="nx">instance_id</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                           <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                           <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>GetInstanceNodeInfoResult</span
><span class="k">
def </span>get_instance_node_info_output<span class="p">(</span><span class="nx">instance_id</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                           <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                           <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>Output[GetInstanceNodeInfoResult]</span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"
><span class="k">func </span>GetInstanceNodeInfo<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetInstanceNodeInfoArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) (*<span class="nx"><a href="#result">GetInstanceNodeInfoResult</a></span>, error)</span
><span class="k">
func </span>GetInstanceNodeInfoOutput<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetInstanceNodeInfoOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) GetInstanceNodeInfoResultOutput</span
></code></pre></div>

&gt; Note: This function is named `GetInstanceNodeInfo` in the Go SDK.

</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static class </span><span class="nx">GetInstanceNodeInfo </span><span class="p">
{</span><span class="k">
    public static </span>Task&lt;<span class="nx"><a href="#result">GetInstanceNodeInfoResult</a></span>> <span class="p">InvokeAsync(</span><span class="nx">GetInstanceNodeInfoArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="k">
    public static </span>Output&lt;<span class="nx"><a href="#result">GetInstanceNodeInfoResult</a></span>> <span class="p">Invoke(</span><span class="nx">GetInstanceNodeInfoInvokeArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="p">
}</span></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static CompletableFuture&lt;<span class="nx"><a href="#result">GetInstanceNodeInfoResult</a></span>> </span>getInstanceNodeInfo<span class="p">(</span><span class="nx">GetInstanceNodeInfoArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">InvokeOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
<span class="c">// Output-based functions aren't available in Java yet</span>
</code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml"><span class="k">fn::invoke:</span>
<span class="k">&nbsp;&nbsp;function:</span> tencentcloud:Dcdb/getInstanceNodeInfo:getInstanceNodeInfo
<span class="k">&nbsp;&nbsp;arguments:</span>
<span class="c">&nbsp;&nbsp;&nbsp;&nbsp;# arguments dictionary</span></code></pre></div>
</pulumi-choosable>
</div>



The following arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="instanceid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_csharp" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Instance ID, such as tdsqlshard-6ltok4u9.</p>
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
        <span id="instanceid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_go" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Instance ID, such as tdsqlshard-6ltok4u9.</p>
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
        <span id="instanceid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_java" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Instance ID, such as tdsqlshard-6ltok4u9.</p>
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
        <span id="instanceid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_nodejs" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Instance ID, such as tdsqlshard-6ltok4u9.</p>
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
        <span id="instance_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instance_id_python" style="color: inherit; text-decoration: inherit;">instance_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Instance ID, such as tdsqlshard-6ltok4u9.</p>
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
        <span id="instanceid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_yaml" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Instance ID, such as tdsqlshard-6ltok4u9.</p>
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




## getInstanceNodeInfo Result {#result}

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
        <span id="instanceid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_csharp" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="nodesinfos_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodesinfos_csharp" style="color: inherit; text-decoration: inherit;">Nodes<wbr>Infos</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancenodeinfonodesinfo">List&lt;Tencent<wbr>Cloud<wbr>IAC.<wbr>Pulumi<wbr>Package.<wbr>Tencentcloud.<wbr>Dcdb.<wbr>Outputs.<wbr>Get<wbr>Instance<wbr>Node<wbr>Info<wbr>Nodes<wbr>Info&gt;</a></span>
    </dt>
    <dd><p>Node information.</p>
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
        <span id="id_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_go" style="color: inherit; text-decoration: inherit;">Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instanceid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_go" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="nodesinfos_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodesinfos_go" style="color: inherit; text-decoration: inherit;">Nodes<wbr>Infos</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancenodeinfonodesinfo">[]Get<wbr>Instance<wbr>Node<wbr>Info<wbr>Nodes<wbr>Info</a></span>
    </dt>
    <dd><p>Node information.</p>
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
        <span id="id_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_java" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instanceid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_java" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="nodesinfos_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodesinfos_java" style="color: inherit; text-decoration: inherit;">nodes<wbr>Infos</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancenodeinfonodesinfo">List&lt;Get<wbr>Instance<wbr>Node<wbr>Info<wbr>Nodes<wbr>Info&gt;</a></span>
    </dt>
    <dd><p>Node information.</p>
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
        <span id="id_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_nodejs" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instanceid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_nodejs" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="nodesinfos_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodesinfos_nodejs" style="color: inherit; text-decoration: inherit;">nodes<wbr>Infos</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancenodeinfonodesinfo">Get<wbr>Instance<wbr>Node<wbr>Info<wbr>Nodes<wbr>Info[]</a></span>
    </dt>
    <dd><p>Node information.</p>
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
        <span id="id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_python" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instance_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instance_id_python" style="color: inherit; text-decoration: inherit;">instance_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="nodes_infos_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodes_infos_python" style="color: inherit; text-decoration: inherit;">nodes_<wbr>infos</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancenodeinfonodesinfo">Get<wbr>Instance<wbr>Node<wbr>Info<wbr>Nodes<wbr>Info]</a></span>
    </dt>
    <dd><p>Node information.</p>
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
        <span id="id_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#id_yaml" style="color: inherit; text-decoration: inherit;">id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The provider-assigned unique ID for this managed resource.</p>
</dd><dt class="property-"
            title="">
        <span id="instanceid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_yaml" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="nodesinfos_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodesinfos_yaml" style="color: inherit; text-decoration: inherit;">nodes<wbr>Infos</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#getinstancenodeinfonodesinfo">List&lt;Property Map&gt;</a></span>
    </dt>
    <dd><p>Node information.</p>
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




## Supporting Types


<h4 id="getinstancenodeinfonodesinfo">Get<wbr>Instance<wbr>Node<wbr>Info<wbr>Nodes<wbr>Info</h4>



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="nodeid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodeid_csharp" style="color: inherit; text-decoration: inherit;">Node<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Node ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="role_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_csharp" style="color: inherit; text-decoration: inherit;">Role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Node role. Valid values: <code>master</code>, <code>slave</code>.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="shardid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#shardid_csharp" style="color: inherit; text-decoration: inherit;">Shard<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Instance shard ID.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="nodeid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodeid_go" style="color: inherit; text-decoration: inherit;">Node<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Node ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="role_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_go" style="color: inherit; text-decoration: inherit;">Role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Node role. Valid values: <code>master</code>, <code>slave</code>.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="shardid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#shardid_go" style="color: inherit; text-decoration: inherit;">Shard<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Instance shard ID.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="nodeid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodeid_java" style="color: inherit; text-decoration: inherit;">node<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Node ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="role_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_java" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Node role. Valid values: <code>master</code>, <code>slave</code>.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="shardid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#shardid_java" style="color: inherit; text-decoration: inherit;">shard<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Instance shard ID.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="nodeid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodeid_nodejs" style="color: inherit; text-decoration: inherit;">node<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Node ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="role_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_nodejs" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Node role. Valid values: <code>master</code>, <code>slave</code>.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="shardid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#shardid_nodejs" style="color: inherit; text-decoration: inherit;">shard<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Instance shard ID.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="node_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#node_id_python" style="color: inherit; text-decoration: inherit;">node_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Node ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="role_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_python" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Node role. Valid values: <code>master</code>, <code>slave</code>.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="shard_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#shard_id_python" style="color: inherit; text-decoration: inherit;">shard_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Instance shard ID.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="nodeid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#nodeid_yaml" style="color: inherit; text-decoration: inherit;">node<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Node ID.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="role_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#role_yaml" style="color: inherit; text-decoration: inherit;">role</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Node role. Valid values: <code>master</code>, <code>slave</code>.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="shardid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#shardid_yaml" style="color: inherit; text-decoration: inherit;">shard<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Instance shard ID.</p>
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

