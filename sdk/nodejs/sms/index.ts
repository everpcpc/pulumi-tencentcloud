// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./sign";
export * from "./template";

// Import resources to register:
import { Sign } from "./sign";
import { Template } from "./template";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Sms/sign:Sign":
                return new Sign(name, <any>undefined, { urn })
            case "tencentcloud:Sms/template:Template":
                return new Template(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Sms/sign", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Sms/template", _module)
