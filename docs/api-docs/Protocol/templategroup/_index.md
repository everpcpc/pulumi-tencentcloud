
---
title: "TemplateGroup"
title_tag: "tencentcloud.Protocol.TemplateGroup"
meta_desc: "Documentation for the tencentcloud.Protocol.TemplateGroup resource with examples, input properties, output properties, lookup functions, and supporting types."
layout: api
no_edit_this_page: true
---



<!-- WARNING: this file was generated by Pulumi Docs Generator. -->
<!-- Do not edit by hand unless you're certain you know what you are doing! -->

Provides a resource to manage protocol template group.

## Example Usage

<!--Start PulumiCodeChooser -->
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as tencentcloud from "@tencentcloud_iac/pulumi";

const foo = new tencentcloud.protocol.TemplateGroup("foo", {templateIds: [
    "ipl-axaf24151",
    "ipl-axaf24152",
]});
```
```python
import pulumi
import tencentcloud_iac_pulumi as tencentcloud

foo = tencentcloud.protocol.TemplateGroup("foo", template_ids=[
    "ipl-axaf24151",
    "ipl-axaf24152",
])
```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;

return await Deployment.RunAsync(() => 
{
    var foo = new Tencentcloud.Protocol.TemplateGroup("foo", new()
    {
        TemplateIds = new[]
        {
            "ipl-axaf24151",
            "ipl-axaf24152",
        },
    });

});
```
```go
package main

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Protocol"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := Protocol.NewTemplateGroup(ctx, "foo", &Protocol.TemplateGroupArgs{
			TemplateIds: pulumi.StringArray{
				pulumi.String("ipl-axaf24151"),
				pulumi.String("ipl-axaf24152"),
			},
		})
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
import com.pulumi.tencentcloud.Protocol.TemplateGroup;
import com.pulumi.tencentcloud.Protocol.TemplateGroupArgs;
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
        var foo = new TemplateGroup("foo", TemplateGroupArgs.builder()        
            .templateIds(            
                "ipl-axaf24151",
                "ipl-axaf24152")
            .build());

    }
}
```
```yaml
resources:
  foo:
    type: tencentcloud:Protocol:TemplateGroup
    properties:
      templateIds:
        - ipl-axaf24151
        - ipl-axaf24152
```
<!--End PulumiCodeChooser -->



## Create TemplateGroup Resource {#create}
<div>
<pulumi-chooser type="language" options="typescript,python,go,csharp,java,yaml"></pulumi-chooser>
</div>


<div>
<pulumi-choosable type="language" values="javascript,typescript">
<div class="highlight"><pre class="chroma"><code class="language-typescript" data-lang="typescript"><span class="k">new </span><span class="nx">TemplateGroup</span><span class="p">(</span><span class="nx">name</span><span class="p">:</span> <span class="nx">string</span><span class="p">,</span> <span class="nx">args</span><span class="p">:</span> <span class="nx"><a href="#inputs">TemplateGroupArgs</a></span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#CustomResourceOptions">CustomResourceOptions</a></span><span class="p">);</span></code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"><span class=nd>@overload</span>
<span class="k">def </span><span class="nx">TemplateGroup</span><span class="p">(</span><span class="nx">resource_name</span><span class="p">:</span> <span class="nx">str</span><span class="p">,</span>
                  <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.ResourceOptions">Optional[ResourceOptions]</a></span> = None<span class="p">,</span>
                  <span class="nx">name</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
                  <span class="nx">template_ids</span><span class="p">:</span> <span class="nx">Optional[Sequence[str]]</span> = None<span class="p">)</span>
<span class=nd>@overload</span>
<span class="k">def </span><span class="nx">TemplateGroup</span><span class="p">(</span><span class="nx">resource_name</span><span class="p">:</span> <span class="nx">str</span><span class="p">,</span>
                  <span class="nx">args</span><span class="p">:</span> <span class="nx"><a href="#inputs">TemplateGroupArgs</a></span><span class="p">,</span>
                  <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.ResourceOptions">Optional[ResourceOptions]</a></span> = None<span class="p">)</span></code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"><span class="k">func </span><span class="nx">NewTemplateGroup</span><span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">name</span><span class="p"> </span><span class="nx">string</span><span class="p">,</span> <span class="nx">args</span><span class="p"> </span><span class="nx"><a href="#inputs">TemplateGroupArgs</a></span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#ResourceOption">ResourceOption</a></span><span class="p">) (*<span class="nx">TemplateGroup</span>, error)</span></code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public </span><span class="nx">TemplateGroup</span><span class="p">(</span><span class="nx">string</span><span class="p"> </span><span class="nx">name<span class="p">,</span> <span class="nx"><a href="#inputs">TemplateGroupArgs</a></span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.CustomResourceOptions.html">CustomResourceOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span></code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma">
<code class="language-java" data-lang="java"><span class="k">public </span><span class="nx">TemplateGroup</span><span class="p">(</span><span class="nx">String</span><span class="p"> </span><span class="nx">name<span class="p">,</span> <span class="nx"><a href="#inputs">TemplateGroupArgs</a></span><span class="p"> </span><span class="nx">args<span class="p">)</span>
<span class="k">public </span><span class="nx">TemplateGroup</span><span class="p">(</span><span class="nx">String</span><span class="p"> </span><span class="nx">name<span class="p">,</span> <span class="nx"><a href="#inputs">TemplateGroupArgs</a></span><span class="p"> </span><span class="nx">args<span class="p">,</span> <span class="nx">CustomResourceOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span>
</code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml">type: <span class="nx">tencentcloud:Protocol:TemplateGroup</span><span class="p"></span>
<span class="p">properties</span><span class="p">: </span><span class="c">#&nbsp;The arguments to resource properties.</span>
<span class="p"></span><span class="p">options</span><span class="p">: </span><span class="c">#&nbsp;Bag of options to control resource&#39;s behavior.</span>
<span class="p"></span>
</code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">

<dl class="resources-properties"><dt
        class="property-required" title="Required">
        <span>name</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd>The unique name of the resource.</dd><dt
        class="property-required" title="Required">
        <span>args</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#inputs">TemplateGroupArgs</a></span>
    </dt>
    <dd>The arguments to resource properties.</dd><dt
        class="property-optional" title="Optional">
        <span>opts</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#CustomResourceOptions">CustomResourceOptions</a></span>
    </dt>
    <dd>Bag of options to control resource&#39;s behavior.</dd></dl>

</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">

<dl class="resources-properties"><dt
        class="property-required" title="Required">
        <span>resource_name</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd>The unique name of the resource.</dd><dt
        class="property-required" title="Required">
        <span>args</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#inputs">TemplateGroupArgs</a></span>
    </dt>
    <dd>The arguments to resource properties.</dd><dt
        class="property-optional" title="Optional">
        <span>opts</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="/docs/reference/pkg/python/pulumi/#pulumi.ResourceOptions">ResourceOptions</a></span>
    </dt>
    <dd>Bag of options to control resource&#39;s behavior.</dd></dl>

</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">

<dl class="resources-properties"><dt
        class="property-optional" title="Optional">
        <span>ctx</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span>
    </dt>
    <dd>Context object for the current deployment.</dd><dt
        class="property-required" title="Required">
        <span>name</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd>The unique name of the resource.</dd><dt
        class="property-required" title="Required">
        <span>args</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#inputs">TemplateGroupArgs</a></span>
    </dt>
    <dd>The arguments to resource properties.</dd><dt
        class="property-optional" title="Optional">
        <span>opts</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#ResourceOption">ResourceOption</a></span>
    </dt>
    <dd>Bag of options to control resource&#39;s behavior.</dd></dl>

</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="csharp">

<dl class="resources-properties"><dt
        class="property-required" title="Required">
        <span>name</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd>The unique name of the resource.</dd><dt
        class="property-required" title="Required">
        <span>args</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#inputs">TemplateGroupArgs</a></span>
    </dt>
    <dd>The arguments to resource properties.</dd><dt
        class="property-optional" title="Optional">
        <span>opts</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.CustomResourceOptions.html">CustomResourceOptions</a></span>
    </dt>
    <dd>Bag of options to control resource&#39;s behavior.</dd></dl>

</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">

<dl class="resources-properties"><dt
        class="property-required" title="Required">
        <span>name</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd>The unique name of the resource.</dd><dt
        class="property-required" title="Required">
        <span>args</span>
        <span class="property-indicator"></span>
        <span class="property-type"><a href="#inputs">TemplateGroupArgs</a></span>
    </dt>
    <dd>The arguments to resource properties.</dd><dt
        class="property-optional" title="Optional">
        <span>options</span>
        <span class="property-indicator"></span>
        <span class="property-type">CustomResourceOptions</span>
    </dt>
    <dd>Bag of options to control resource&#39;s behavior.</dd></dl>

</pulumi-choosable>
</div>

## TemplateGroup Resource Properties {#properties}

To learn more about resource properties and how to use them, see [Inputs and Outputs](/docs/intro/concepts/inputs-outputs) in the Architecture and Concepts docs.

### Inputs

The TemplateGroup resource accepts the following [input](/docs/intro/concepts/inputs-outputs) properties:



<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="templateids_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#templateids_csharp" style="color: inherit; text-decoration: inherit;">Template<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;string&gt;</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd><dt class="property-optional property-replacement"
            title="Optional">
        <span id="name_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_csharp" style="color: inherit; text-decoration: inherit;">Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="templateids_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#templateids_go" style="color: inherit; text-decoration: inherit;">Template<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">[]string</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd><dt class="property-optional property-replacement"
            title="Optional">
        <span id="name_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_go" style="color: inherit; text-decoration: inherit;">Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="templateids_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#templateids_java" style="color: inherit; text-decoration: inherit;">template<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd><dt class="property-optional property-replacement"
            title="Optional">
        <span id="name_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_java" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="templateids_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#templateids_nodejs" style="color: inherit; text-decoration: inherit;">template<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string[]</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd><dt class="property-optional property-replacement"
            title="Optional">
        <span id="name_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_nodejs" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="template_ids_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#template_ids_python" style="color: inherit; text-decoration: inherit;">template_<wbr>ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Sequence[str]</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd><dt class="property-optional property-replacement"
            title="Optional">
        <span id="name_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_python" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-required"
            title="Required">
        <span id="templateids_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#templateids_yaml" style="color: inherit; text-decoration: inherit;">template<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd><dt class="property-optional property-replacement"
            title="Optional">
        <span id="name_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#name_yaml" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd></dl>
</pulumi-choosable>
</div>


### Outputs

All [input](#inputs) properties are implicitly available as output properties. Additionally, the TemplateGroup resource produces the following output properties:



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
</dd></dl>
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
</dd></dl>
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
</dd></dl>
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
</dd></dl>
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
</dd></dl>
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
</dd></dl>
</pulumi-choosable>
</div>



## Look up Existing TemplateGroup Resource {#look-up}

Get an existing TemplateGroup resource's state with the given name, ID, and optional extra properties used to qualify the lookup.
<div>
<pulumi-chooser type="language" options="typescript,python,go,csharp,java,yaml"></pulumi-chooser>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<div class="highlight"><pre class="chroma"><code class="language-typescript" data-lang="typescript"><span class="k">public static </span><span class="nf">get</span><span class="p">(</span><span class="nx">name</span><span class="p">:</span> <span class="nx">string</span><span class="p">,</span> <span class="nx">id</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#ID">Input&lt;ID&gt;</a></span><span class="p">,</span> <span class="nx">state</span><span class="p">?:</span> <span class="nx">TemplateGroupState</span><span class="p">,</span> <span class="nx">opts</span><span class="p">?:</span> <span class="nx"><a href="/docs/reference/pkg/nodejs/pulumi/pulumi/#CustomResourceOptions">CustomResourceOptions</a></span><span class="p">): </span><span class="nx">TemplateGroup</span></code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<div class="highlight"><pre class="chroma"><code class="language-python" data-lang="python"><span class=nd>@staticmethod</span>
<span class="k">def </span><span class="nf">get</span><span class="p">(</span><span class="nx">resource_name</span><span class="p">:</span> <span class="nx">str</span><span class="p">,</span>
        <span class="nx">id</span><span class="p">:</span> <span class="nx">str</span><span class="p">,</span>
        <span class="nx">opts</span><span class="p">:</span> <span class="nx"><a href="/docs/reference/pkg/python/pulumi/#pulumi.ResourceOptions">Optional[ResourceOptions]</a></span> = None<span class="p">,</span>
        <span class="nx">name</span><span class="p">:</span> <span class="nx">Optional[str]</span> = None<span class="p">,</span>
        <span class="nx">template_ids</span><span class="p">:</span> <span class="nx">Optional[Sequence[str]]</span> = None<span class="p">) -&gt;</span> TemplateGroup</code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<div class="highlight"><pre class="chroma"><code class="language-go" data-lang="go"><span class="k">func </span>GetTemplateGroup<span class="p">(</span><span class="nx">ctx</span><span class="p"> *</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#Context">Context</a></span><span class="p">,</span> <span class="nx">name</span><span class="p"> </span><span class="nx">string</span><span class="p">,</span> <span class="nx">id</span><span class="p"> </span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#IDInput">IDInput</a></span><span class="p">,</span> <span class="nx">state</span><span class="p"> *</span><span class="nx">TemplateGroupState</span><span class="p">,</span> <span class="nx">opts</span><span class="p"> ...</span><span class="nx"><a href="https://pkg.go.dev/github.com/pulumi/pulumi/sdk/v3/go/pulumi?tab=doc#ResourceOption">ResourceOption</a></span><span class="p">) (*<span class="nx">TemplateGroup</span>, error)</span></code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="csharp">
<div class="highlight"><pre class="chroma"><code class="language-csharp" data-lang="csharp"><span class="k">public static </span><span class="nx">TemplateGroup</span><span class="nf"> Get</span><span class="p">(</span><span class="nx">string</span><span class="p"> </span><span class="nx">name<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.Input-1.html">Input&lt;string&gt;</a></span><span class="p"> </span><span class="nx">id<span class="p">,</span> <span class="nx">TemplateGroupState</span><span class="p">? </span><span class="nx">state<span class="p">,</span> <span class="nx"><a href="/docs/reference/pkg/dotnet/Pulumi/Pulumi.CustomResourceOptions.html">CustomResourceOptions</a></span><span class="p">? </span><span class="nx">opts = null<span class="p">)</span></code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<div class="highlight"><pre class="chroma"><code class="language-java" data-lang="java"><span class="k">public static </span><span class="nx">TemplateGroup</span><span class="nf"> get</span><span class="p">(</span><span class="nx">String</span><span class="p"> </span><span class="nx">name<span class="p">,</span> <span class="nx">Output&lt;String&gt;</span><span class="p"> </span><span class="nx">id<span class="p">,</span> <span class="nx">TemplateGroupState</span><span class="p"> </span><span class="nx">state<span class="p">,</span> <span class="nx">CustomResourceOptions</span><span class="p"> </span><span class="nx">options<span class="p">)</span></code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<div class="highlight"><pre class="chroma"><code class="language-yaml" data-lang="yaml">Resource lookup is not supported in YAML</code></pre></div>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">

<dl class="resources-properties">
    <dt class="property-required" title="Required">
        <span>name</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>The unique name of the resulting resource.</dd>
    <dt class="property-required" title="Required">
        <span>id</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>The <em>unique</em> provider ID of the resource to lookup.</dd>
    <dt class="property-optional" title="Optional">
        <span>state</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>Any extra arguments used during the lookup.</dd>
    <dt class="property-optional" title="Optional">
        <span>opts</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>A bag of options that control this resource's behavior.</dd>
</dl>

</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties">
    <dt class="property-required" title="Required">
        <span>resource_name</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>The unique name of the resulting resource.</dd>
    <dt class="property-required" title="Optional">
        <span>id</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>The <em>unique</em> provider ID of the resource to lookup.</dd>
</dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">

<dl class="resources-properties">
    <dt class="property-required" title="Required">
        <span>name</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>The unique name of the resulting resource.</dd>
    <dt class="property-required" title="Required">
        <span>id</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>The <em>unique</em> provider ID of the resource to lookup.</dd>
    <dt class="property-optional" title="Optional">
        <span>state</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>Any extra arguments used during the lookup.</dd>
    <dt class="property-optional" title="Optional">
        <span>opts</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>A bag of options that control this resource's behavior.</dd>
</dl>

</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="csharp">

<dl class="resources-properties">
    <dt class="property-required" title="Required">
        <span>name</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>The unique name of the resulting resource.</dd>
    <dt class="property-required" title="Required">
        <span>id</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>The <em>unique</em> provider ID of the resource to lookup.</dd>
    <dt class="property-optional" title="Optional">
        <span>state</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>Any extra arguments used during the lookup.</dd>
    <dt class="property-optional" title="Optional">
        <span>opts</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>A bag of options that control this resource's behavior.</dd>
</dl>

</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">

<dl class="resources-properties">
    <dt class="property-required" title="Required">
        <span>name</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>The unique name of the resulting resource.</dd>
    <dt class="property-required" title="Required">
        <span>id</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>The <em>unique</em> provider ID of the resource to lookup.</dd>
    <dt class="property-optional" title="Optional">
        <span>state</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>Any extra arguments used during the lookup.</dd>
    <dt class="property-optional" title="Optional">
        <span>opts</span>
        <span class="property-indicator"></span>
    </dt>
    <dd>A bag of options that control this resource's behavior.</dd>
</dl>

</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="typescript,javascript,python,go,csharp,java">
The following state arguments are supported:


<div>
<pulumi-choosable type="language" values="csharp">
<dl class="resources-properties"><dt class="property-optional property-replacement"
            title="Optional">
        <span id="state_name_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_name_csharp" style="color: inherit; text-decoration: inherit;">Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="state_templateids_csharp">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_templateids_csharp" style="color: inherit; text-decoration: inherit;">Template<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;string&gt;</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="go">
<dl class="resources-properties"><dt class="property-optional property-replacement"
            title="Optional">
        <span id="state_name_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_name_go" style="color: inherit; text-decoration: inherit;">Name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="state_templateids_go">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_templateids_go" style="color: inherit; text-decoration: inherit;">Template<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">[]string</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="java">
<dl class="resources-properties"><dt class="property-optional property-replacement"
            title="Optional">
        <span id="state_name_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_name_java" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="state_templateids_java">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_templateids_java" style="color: inherit; text-decoration: inherit;">template<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="javascript,typescript">
<dl class="resources-properties"><dt class="property-optional property-replacement"
            title="Optional">
        <span id="state_name_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_name_nodejs" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="state_templateids_nodejs">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_templateids_nodejs" style="color: inherit; text-decoration: inherit;">template<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">string[]</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="python">
<dl class="resources-properties"><dt class="property-optional property-replacement"
            title="Optional">
        <span id="state_name_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_name_python" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">str</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="state_template_ids_python">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_template_ids_python" style="color: inherit; text-decoration: inherit;">template_<wbr>ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">Sequence[str]</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd></dl>
</pulumi-choosable>
</div>

<div>
<pulumi-choosable type="language" values="yaml">
<dl class="resources-properties"><dt class="property-optional property-replacement"
            title="Optional">
        <span id="state_name_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_name_yaml" style="color: inherit; text-decoration: inherit;">name</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">String</span>
    </dt>
    <dd><p>Name of the protocol template group.</p>
</dd><dt class="property-optional"
            title="Optional">
        <span id="state_templateids_yaml">
<a data-swiftype-name="resource-property" data-swiftype-type="text" href="#state_templateids_yaml" style="color: inherit; text-decoration: inherit;">template<wbr>Ids</a>
</span>
        <span class="property-indicator"></span>
        <span class="property-type">List&lt;String&gt;</span>
    </dt>
    <dd><p>Service template ID list.</p>
</dd></dl>
</pulumi-choosable>
</div>
</pulumi-choosable>
</div>






## Import



Protocol template group can be imported using the id, e.g.

```sh
$ pulumi import tencentcloud:Protocol/templateGroup:TemplateGroup foo ppmg-0np3u974
```





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
