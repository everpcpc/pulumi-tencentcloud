
---
title: "getInstTables"
title_tag: "tencentcloud.Mysql.getInstTables"
meta_desc: "Documentation for the tencentcloud.Mysql.getInstTables function with examples, input properties, output properties, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Use this data source to query detailed information of mysql inst_tables

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const instTables = tencentcloud.Mysql.getInstTables({
    database: "tf_ci_test",
    instanceId: "cdb-fitq5t9h",
});
```
```python
import pulumi
import pulumi_tencentcloud as tencentcloud

inst_tables = tencentcloud.Mysql.get_inst_tables(database="tf_ci_test",
    instance_id="cdb-fitq5t9h")
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = Pulumi.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var instTables = Tencentcloud.Mysql.GetInstTables.Invoke(new()
    {
        Database = "tf_ci_test",
        InstanceId = "cdb-fitq5t9h",
    });

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Mysql.GetInstTables(ctx, &mysql.GetInstTablesArgs{
			Database:   "tf_ci_test",
			InstanceId: "cdb-fitq5t9h",
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
import com.pulumi.tencentcloud.Mysql.MysqlFunctions;
import com.pulumi.tencentcloud.Mysql.inputs.GetInstTablesArgs;
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
        final var instTables = MysqlFunctions.getInstTables(GetInstTablesArgs.builder()
            .database("tf_ci_test")
            .instanceId("cdb-fitq5t9h")
            .build());

    }
}
```
```yaml
variables:
  instTables:
    fn::invoke:
      Function: tencentcloud:Mysql:getInstTables
      Arguments:
        database: tf_ci_test
        instanceId: cdb-fitq5t9h
```
<!--End PulumiCodeChooser -->




## Using getInstTables {#using}

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
><span class="k">function </span>getInstTables<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetInstTablesArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Promise&lt;<span class="nx"><a href="#result">GetInstTablesResult</a></span>></span
><span class="k">
function </span>getInstTablesOutput<span class="p">(</span><span class="nx">args</span><span class="p">:</span> <span class="nx">GetInstTablesOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#InvokeOptions">InvokeOptions</a></span><span class="p">): Output&lt;<span class="nx"><a href="#result">GetInstTablesResult</a></span>></span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"
><span class="k">def </span>get_inst_tables<span class="p">(</span><span class="nx">database</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                    <span class="nx">instance_id</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                    <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                    <span class="nx">table_regexp</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                    <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>GetInstTablesResult</span
><span class="k">
def </span>get_inst_tables_output<span class="p">(</span><span class="nx">database</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                    <span class="nx">instance_id</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                    <span class="nx">result_output_file</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                    <span class="nx">table_regexp</span><span class="p">:</span> <span class="nx">Optional[pulumi.Input[str]]</span> = None<span class="p">,</span>
                    <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.InvokeOptions">Optional[InvokeOptions]</a></span> = None<span class="p">) -&gt;</span> <span>Output[GetInstTablesResult]</span
></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"
><span class="k">func </span>GetInstTables<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetInstTablesArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) (*<span class="nx"><a href="#result">GetInstTablesResult</a></span>, error)</span
><span class="k">
func </span>GetInstTablesOutput<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">args</span><span class="p"> *</span><span class="nx">GetInstTablesOutputArgs</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#InvokeOption">InvokeOption</a></span><span class="p">) GetInstTablesResultOutput</span
></code></pre></div>

&gt; Note: This function is named `GetInstTables` in the Go SDK.

</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static class </span><span class="nx">GetInstTables </span><span class="p">
{</span><span class="k">
    public static </span>Task&lt;<span class="nx"><a href="#result">GetInstTablesResult</a></span>> <span class="p">InvokeAsync(</span><span class="nx">GetInstTablesArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="k">
    public static </span>Output&lt;<span class="nx"><a href="#result">GetInstTablesResult</a></span>> <span class="p">Invoke(</span><span class="nx">GetInstTablesInvokeArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.InvokeOptions.html">InvokeOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span><span class="p">
}</span></code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static CompletableFuture&lt;<span class="nx"><a href="#result">GetInstTablesResult</a></span>> </span>getInstTables<span class="p">(</span><span class="nx">GetInstTablesArgs</span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">InvokeOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
<span class="c">// Output-based functions aren't available in Java yet</span>
</code></pre></div>
</pulumi-choosable>
</div>


<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml"><span class="k">fn::invoke:</span>
<span class="k">&nbsp;&nbsp;function:</span> tencentcloud:Mysql/getInstTables:getInstTables
<span class="k">&nbsp;&nbsp;arguments:</span>
<span class="c">&nbsp;&nbsp;&nbsp;&nbsp;# arguments dictionary</span></code></pre></div>
</pulumi-choosable>
</div>



The following arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="database_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_csharp" style="color: inherit; text-decoration: inherit;">Database</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The name of the database.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instanceid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_csharp" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="tableregexp_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tableregexp_csharp" style="color: inherit; text-decoration: inherit;">Table<wbr>Regexp</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Match the regular expression of the database table name, the rules are the same as MySQL official website.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="database_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_go" style="color: inherit; text-decoration: inherit;">Database</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The name of the database.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instanceid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_go" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="tableregexp_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tableregexp_go" style="color: inherit; text-decoration: inherit;">Table<wbr>Regexp</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Match the regular expression of the database table name, the rules are the same as MySQL official website.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="database_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_java" style="color: inherit; text-decoration: inherit;">database</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The name of the database.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instanceid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_java" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="tableregexp_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tableregexp_java" style="color: inherit; text-decoration: inherit;">table<wbr>Regexp</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Match the regular expression of the database table name, the rules are the same as MySQL official website.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="database_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_nodejs" style="color: inherit; text-decoration: inherit;">database</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The name of the database.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instanceid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_nodejs" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="tableregexp_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tableregexp_nodejs" style="color: inherit; text-decoration: inherit;">table<wbr>Regexp</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Match the regular expression of the database table name, the rules are the same as MySQL official website.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="database_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_python" style="color: inherit; text-decoration: inherit;">database</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>The name of the database.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instance_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instance_id_python" style="color: inherit; text-decoration: inherit;">instance_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="table_regexp_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#table_regexp_python" style="color: inherit; text-decoration: inherit;">table_<wbr>regexp</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Match the regular expression of the database table name, the rules are the same as MySQL official website.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="database_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_yaml" style="color: inherit; text-decoration: inherit;">database</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The name of the database.</p>
</dd><dt class="property-required"
            title="Required">
        <span id="instanceid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_yaml" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.</p>
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
        <span id="tableregexp_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tableregexp_yaml" style="color: inherit; text-decoration: inherit;">table<wbr>Regexp</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Match the regular expression of the database table name, the rules are the same as MySQL official website.</p>
</dd></dl>
</pulumi-choosable>
</div>




## getInstTables Result {#result}

The following output properties are available:



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-"
            title="">
        <span id="database_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_csharp" style="color: inherit; text-decoration: inherit;">Database</a>
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
        <span id="instanceid_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_csharp" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="items_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_csharp" style="color: inherit; text-decoration: inherit;">Items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;string&gt;</span>
    </dt>
    <dd><p>The returned database table information.</p>
</dd><dt class="property-"
            title="">
        <span id="resultoutputfile_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_csharp" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="tableregexp_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tableregexp_csharp" style="color: inherit; text-decoration: inherit;">Table<wbr>Regexp</a>
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
        <span id="database_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_go" style="color: inherit; text-decoration: inherit;">Database</a>
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
        <span id="instanceid_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_go" style="color: inherit; text-decoration: inherit;">Instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="items_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_go" style="color: inherit; text-decoration: inherit;">Items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">[]string</span>
    </dt>
    <dd><p>The returned database table information.</p>
</dd><dt class="property-"
            title="">
        <span id="resultoutputfile_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_go" style="color: inherit; text-decoration: inherit;">Result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="tableregexp_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tableregexp_go" style="color: inherit; text-decoration: inherit;">Table<wbr>Regexp</a>
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
        <span id="database_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_java" style="color: inherit; text-decoration: inherit;">database</a>
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
        <span id="instanceid_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_java" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="items_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_java" style="color: inherit; text-decoration: inherit;">items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>The returned database table information.</p>
</dd><dt class="property-"
            title="">
        <span id="resultoutputfile_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_java" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="tableregexp_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tableregexp_java" style="color: inherit; text-decoration: inherit;">table<wbr>Regexp</a>
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
        <span id="database_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_nodejs" style="color: inherit; text-decoration: inherit;">database</a>
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
        <span id="instanceid_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_nodejs" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="items_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_nodejs" style="color: inherit; text-decoration: inherit;">items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string[]</span>
    </dt>
    <dd><p>The returned database table information.</p>
</dd><dt class="property-"
            title="">
        <span id="resultoutputfile_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_nodejs" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="tableregexp_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tableregexp_nodejs" style="color: inherit; text-decoration: inherit;">table<wbr>Regexp</a>
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
        <span id="database_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_python" style="color: inherit; text-decoration: inherit;">database</a>
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
        <span id="instance_id_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instance_id_python" style="color: inherit; text-decoration: inherit;">instance_<wbr>id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="items_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_python" style="color: inherit; text-decoration: inherit;">items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Sequence[str]</span>
    </dt>
    <dd><p>The returned database table information.</p>
</dd><dt class="property-"
            title="">
        <span id="result_output_file_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#result_output_file_python" style="color: inherit; text-decoration: inherit;">result_<wbr>output_<wbr>file</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="table_regexp_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#table_regexp_python" style="color: inherit; text-decoration: inherit;">table_<wbr>regexp</a>
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
        <span id="database_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#database_yaml" style="color: inherit; text-decoration: inherit;">database</a>
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
        <span id="instanceid_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#instanceid_yaml" style="color: inherit; text-decoration: inherit;">instance<wbr>Id</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="items_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#items_yaml" style="color: inherit; text-decoration: inherit;">items</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>The returned database table information.</p>
</dd><dt class="property-"
            title="">
        <span id="resultoutputfile_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#resultoutputfile_yaml" style="color: inherit; text-decoration: inherit;">result<wbr>Output<wbr>File</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd></dd><dt class="property-"
            title="">
        <span id="tableregexp_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#tableregexp_yaml" style="color: inherit; text-decoration: inherit;">table<wbr>Regexp</a>
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
