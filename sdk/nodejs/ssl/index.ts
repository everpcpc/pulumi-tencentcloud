// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./certificate";
export * from "./checkCertificateChainOperation";
export * from "./completeCertificateOperation";
export * from "./deployCertificateInstanceOperation";
export * from "./deployCertificateRecordRetryOperation";
export * from "./deployCertificateRecordRollbackOperation";
export * from "./downloadCertificateOperation";
export * from "./freeCertificate";
export * from "./getCertificates";
export * from "./getDescribeCertificate";
export * from "./getDescribeCompanies";
export * from "./getDescribeHostApiGatewayInstanceList";
export * from "./getDescribeHostCdnInstanceList";
export * from "./getDescribeHostClbInstanceList";
export * from "./getDescribeHostCosInstanceList";
export * from "./getDescribeHostDdosInstanceList";
export * from "./getDescribeHostDeployRecord";
export * from "./getDescribeHostDeployRecordDetail";
export * from "./getDescribeHostLighthouseInstanceList";
export * from "./getDescribeHostLiveInstanceList";
export * from "./getDescribeHostTeoInstanceList";
export * from "./getDescribeHostTkeInstanceList";
export * from "./getDescribeHostUpdateRecord";
export * from "./getDescribeHostUpdateRecordDetail";
export * from "./getDescribeHostVodInstanceList";
export * from "./getDescribeHostWafInstanceList";
export * from "./getDescribeManagerDetail";
export * from "./getDescribeManagers";
export * from "./payCertificate";
export * from "./replaceCertificateOperation";
export * from "./revokeCertificateOperation";
export * from "./updateCertificateInstanceOperation";
export * from "./updateCertificateRecordRetryOperation";
export * from "./updateCertificateRecordRollbackOperation";
export * from "./uploadRevokeLetterOperation";

// Import resources to register:
import { Certificate } from "./certificate";
import { CheckCertificateChainOperation } from "./checkCertificateChainOperation";
import { CompleteCertificateOperation } from "./completeCertificateOperation";
import { DeployCertificateInstanceOperation } from "./deployCertificateInstanceOperation";
import { DeployCertificateRecordRetryOperation } from "./deployCertificateRecordRetryOperation";
import { DeployCertificateRecordRollbackOperation } from "./deployCertificateRecordRollbackOperation";
import { DownloadCertificateOperation } from "./downloadCertificateOperation";
import { FreeCertificate } from "./freeCertificate";
import { PayCertificate } from "./payCertificate";
import { ReplaceCertificateOperation } from "./replaceCertificateOperation";
import { RevokeCertificateOperation } from "./revokeCertificateOperation";
import { UpdateCertificateInstanceOperation } from "./updateCertificateInstanceOperation";
import { UpdateCertificateRecordRetryOperation } from "./updateCertificateRecordRetryOperation";
import { UpdateCertificateRecordRollbackOperation } from "./updateCertificateRecordRollbackOperation";
import { UploadRevokeLetterOperation } from "./uploadRevokeLetterOperation";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Ssl/certificate:Certificate":
                return new Certificate(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/checkCertificateChainOperation:CheckCertificateChainOperation":
                return new CheckCertificateChainOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/completeCertificateOperation:CompleteCertificateOperation":
                return new CompleteCertificateOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/deployCertificateInstanceOperation:DeployCertificateInstanceOperation":
                return new DeployCertificateInstanceOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/deployCertificateRecordRetryOperation:DeployCertificateRecordRetryOperation":
                return new DeployCertificateRecordRetryOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/deployCertificateRecordRollbackOperation:DeployCertificateRecordRollbackOperation":
                return new DeployCertificateRecordRollbackOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/downloadCertificateOperation:DownloadCertificateOperation":
                return new DownloadCertificateOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/freeCertificate:FreeCertificate":
                return new FreeCertificate(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/payCertificate:PayCertificate":
                return new PayCertificate(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/replaceCertificateOperation:ReplaceCertificateOperation":
                return new ReplaceCertificateOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/revokeCertificateOperation:RevokeCertificateOperation":
                return new RevokeCertificateOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/updateCertificateInstanceOperation:UpdateCertificateInstanceOperation":
                return new UpdateCertificateInstanceOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/updateCertificateRecordRetryOperation:UpdateCertificateRecordRetryOperation":
                return new UpdateCertificateRecordRetryOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/updateCertificateRecordRollbackOperation:UpdateCertificateRecordRollbackOperation":
                return new UpdateCertificateRecordRollbackOperation(name, <any>undefined, { urn })
            case "tencentcloud:Ssl/uploadRevokeLetterOperation:UploadRevokeLetterOperation":
                return new UploadRevokeLetterOperation(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/certificate", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/checkCertificateChainOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/completeCertificateOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/deployCertificateInstanceOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/deployCertificateRecordRetryOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/deployCertificateRecordRollbackOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/downloadCertificateOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/freeCertificate", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/payCertificate", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/replaceCertificateOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/revokeCertificateOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/updateCertificateInstanceOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/updateCertificateRecordRetryOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/updateCertificateRecordRollbackOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ssl/uploadRevokeLetterOperation", _module)
