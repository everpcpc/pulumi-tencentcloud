// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./chcConfig";
export * from "./exportImages";
export * from "./getChcDeniedActions";
export * from "./getChcHosts";
export * from "./getDisasterRecoverGroupQuota";
export * from "./getImageQuota";
export * from "./getImageSharePermission";
export * from "./getImportImageOs";
export * from "./getInstanceVncUrl";
export * from "./getInstancesModification";
export * from "./hpcCluster";
export * from "./imageSharePermission";
export * from "./importImage";
export * from "./launchTemplate";
export * from "./launchTemplateDefaultVersion";
export * from "./launchTemplateVersion";
export * from "./modifyInstanceDiskType";
export * from "./programFpgaImage";
export * from "./rebootInstance";
export * from "./renewHost";
export * from "./renewInstance";
export * from "./securityGroupAttachment";
export * from "./syncImage";

// Import resources to register:
import { ChcConfig } from "./chcConfig";
import { ExportImages } from "./exportImages";
import { HpcCluster } from "./hpcCluster";
import { ImageSharePermission } from "./imageSharePermission";
import { ImportImage } from "./importImage";
import { LaunchTemplate } from "./launchTemplate";
import { LaunchTemplateDefaultVersion } from "./launchTemplateDefaultVersion";
import { LaunchTemplateVersion } from "./launchTemplateVersion";
import { ModifyInstanceDiskType } from "./modifyInstanceDiskType";
import { ProgramFpgaImage } from "./programFpgaImage";
import { RebootInstance } from "./rebootInstance";
import { RenewHost } from "./renewHost";
import { RenewInstance } from "./renewInstance";
import { SecurityGroupAttachment } from "./securityGroupAttachment";
import { SyncImage } from "./syncImage";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Cvm/chcConfig:ChcConfig":
                return new ChcConfig(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/exportImages:ExportImages":
                return new ExportImages(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/hpcCluster:HpcCluster":
                return new HpcCluster(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/imageSharePermission:ImageSharePermission":
                return new ImageSharePermission(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/importImage:ImportImage":
                return new ImportImage(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/launchTemplate:LaunchTemplate":
                return new LaunchTemplate(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/launchTemplateDefaultVersion:LaunchTemplateDefaultVersion":
                return new LaunchTemplateDefaultVersion(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/launchTemplateVersion:LaunchTemplateVersion":
                return new LaunchTemplateVersion(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/modifyInstanceDiskType:ModifyInstanceDiskType":
                return new ModifyInstanceDiskType(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/programFpgaImage:ProgramFpgaImage":
                return new ProgramFpgaImage(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/rebootInstance:RebootInstance":
                return new RebootInstance(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/renewHost:RenewHost":
                return new RenewHost(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/renewInstance:RenewInstance":
                return new RenewInstance(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/securityGroupAttachment:SecurityGroupAttachment":
                return new SecurityGroupAttachment(name, <any>undefined, { urn })
            case "tencentcloud:Cvm/syncImage:SyncImage":
                return new SyncImage(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/chcConfig", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/exportImages", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/hpcCluster", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/imageSharePermission", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/importImage", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/launchTemplate", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/launchTemplateDefaultVersion", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/launchTemplateVersion", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/modifyInstanceDiskType", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/programFpgaImage", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/rebootInstance", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/renewHost", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/renewInstance", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/securityGroupAttachment", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cvm/syncImage", _module)
