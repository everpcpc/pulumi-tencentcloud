// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package waf

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "tencentcloud:Waf/antiFake:AntiFake":
		r = &AntiFake{}
	case "tencentcloud:Waf/antiInfoLeak:AntiInfoLeak":
		r = &AntiInfoLeak{}
	case "tencentcloud:Waf/autoDenyRules:AutoDenyRules":
		r = &AutoDenyRules{}
	case "tencentcloud:Waf/cc:Cc":
		r = &Cc{}
	case "tencentcloud:Waf/ccAutoStatus:CcAutoStatus":
		r = &CcAutoStatus{}
	case "tencentcloud:Waf/ccSession:CcSession":
		r = &CcSession{}
	case "tencentcloud:Waf/clbDomain:ClbDomain":
		r = &ClbDomain{}
	case "tencentcloud:Waf/clbInstance:ClbInstance":
		r = &ClbInstance{}
	case "tencentcloud:Waf/customRule:CustomRule":
		r = &CustomRule{}
	case "tencentcloud:Waf/customWhiteRule:CustomWhiteRule":
		r = &CustomWhiteRule{}
	case "tencentcloud:Waf/ipAccessControl:IpAccessControl":
		r = &IpAccessControl{}
	case "tencentcloud:Waf/modifyAccessPeriod:ModifyAccessPeriod":
		r = &ModifyAccessPeriod{}
	case "tencentcloud:Waf/moduleStatus:ModuleStatus":
		r = &ModuleStatus{}
	case "tencentcloud:Waf/protectionMode:ProtectionMode":
		r = &ProtectionMode{}
	case "tencentcloud:Waf/saasDomain:SaasDomain":
		r = &SaasDomain{}
	case "tencentcloud:Waf/saasInstance:SaasInstance":
		r = &SaasInstance{}
	case "tencentcloud:Waf/webShell:WebShell":
		r = &WebShell{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := internal.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/antiFake",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/antiInfoLeak",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/autoDenyRules",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/cc",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/ccAutoStatus",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/ccSession",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/clbDomain",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/clbInstance",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/customRule",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/customWhiteRule",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/ipAccessControl",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/modifyAccessPeriod",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/moduleStatus",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/protectionMode",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/saasDomain",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/saasInstance",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"tencentcloud",
		"Waf/webShell",
		&module{version},
	)
}