// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a ssl updateCertificateInstance
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const updateCertificateInstance = new tencentcloud.ssl.UpdateCertificateInstanceOperation("updateCertificateInstance", {
 *     certificateId: "8x1eUSSl",
 *     oldCertificateId: "8xNdi2ig",
 *     resourceTypes: ["cdn"],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Upload certificate
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fs from "fs";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const updateCertificateInstance = new tencentcloud.ssl.UpdateCertificateInstanceOperation("updateCertificateInstance", {
 *     oldCertificateId: "xxx",
 *     certificatePublicKey: fs.readFileSync("xxx.crt", "utf8"),
 *     certificatePrivateKey: fs.readFileSync("xxx.key", "utf8"),
 *     repeatable: true,
 *     resourceTypes: ["cdn"],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class UpdateCertificateInstanceOperation extends pulumi.CustomResource {
    /**
     * Get an existing UpdateCertificateInstanceOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UpdateCertificateInstanceOperationState, opts?: pulumi.CustomResourceOptions): UpdateCertificateInstanceOperation {
        return new UpdateCertificateInstanceOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Ssl/updateCertificateInstanceOperation:UpdateCertificateInstanceOperation';

    /**
     * Returns true if the given object is an instance of UpdateCertificateInstanceOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is UpdateCertificateInstanceOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === UpdateCertificateInstanceOperation.__pulumiType;
    }

    /**
     * Whether to allow downloading, if you choose to upload the certificate, you can configure this parameter.
     */
    public readonly allowDownload!: pulumi.Output<boolean | undefined>;
    /**
     * Update new certificate ID.
     */
    public readonly certificateId!: pulumi.Output<string | undefined>;
    /**
     * Certificate private key. If you upload the certificate public key, CertificateId does not need to be passed.
     */
    public readonly certificatePrivateKey!: pulumi.Output<string | undefined>;
    /**
     * Certificate public key. If you upload the certificate public key, CertificateId does not need to be passed.
     */
    public readonly certificatePublicKey!: pulumi.Output<string | undefined>;
    /**
     * Whether to ignore expiration reminders for old certificates 0: Do not ignore notifications. 1: Ignore the notification and ignore the OldCertificateId expiration reminder.
     */
    public readonly expiringNotificationSwitch!: pulumi.Output<number | undefined>;
    /**
     * Update the original certificate ID.
     */
    public readonly oldCertificateId!: pulumi.Output<string>;
    /**
     * Project ID, if you choose to upload the certificate, you can configure this parameter.
     */
    public readonly projectId!: pulumi.Output<number | undefined>;
    /**
     * Whether the same certificate is allowed to be uploaded repeatedly. If you choose to upload the certificate, you can configure this parameter.
     */
    public readonly repeatable!: pulumi.Output<boolean | undefined>;
    /**
     * The resource type that needs to be deployed. The parameter value is optional: clb, cdn, waf, live, ddos, teo, apigateway, vod, tke, tcb.
     */
    public readonly resourceTypes!: pulumi.Output<string[]>;
    /**
     * List of regions where cloud resources need to be deploye.
     */
    public readonly resourceTypesRegions!: pulumi.Output<outputs.Ssl.UpdateCertificateInstanceOperationResourceTypesRegion[] | undefined>;

    /**
     * Create a UpdateCertificateInstanceOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UpdateCertificateInstanceOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UpdateCertificateInstanceOperationArgs | UpdateCertificateInstanceOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as UpdateCertificateInstanceOperationState | undefined;
            resourceInputs["allowDownload"] = state ? state.allowDownload : undefined;
            resourceInputs["certificateId"] = state ? state.certificateId : undefined;
            resourceInputs["certificatePrivateKey"] = state ? state.certificatePrivateKey : undefined;
            resourceInputs["certificatePublicKey"] = state ? state.certificatePublicKey : undefined;
            resourceInputs["expiringNotificationSwitch"] = state ? state.expiringNotificationSwitch : undefined;
            resourceInputs["oldCertificateId"] = state ? state.oldCertificateId : undefined;
            resourceInputs["projectId"] = state ? state.projectId : undefined;
            resourceInputs["repeatable"] = state ? state.repeatable : undefined;
            resourceInputs["resourceTypes"] = state ? state.resourceTypes : undefined;
            resourceInputs["resourceTypesRegions"] = state ? state.resourceTypesRegions : undefined;
        } else {
            const args = argsOrState as UpdateCertificateInstanceOperationArgs | undefined;
            if ((!args || args.oldCertificateId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'oldCertificateId'");
            }
            if ((!args || args.resourceTypes === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceTypes'");
            }
            resourceInputs["allowDownload"] = args ? args.allowDownload : undefined;
            resourceInputs["certificateId"] = args ? args.certificateId : undefined;
            resourceInputs["certificatePrivateKey"] = args?.certificatePrivateKey ? pulumi.secret(args.certificatePrivateKey) : undefined;
            resourceInputs["certificatePublicKey"] = args?.certificatePublicKey ? pulumi.secret(args.certificatePublicKey) : undefined;
            resourceInputs["expiringNotificationSwitch"] = args ? args.expiringNotificationSwitch : undefined;
            resourceInputs["oldCertificateId"] = args ? args.oldCertificateId : undefined;
            resourceInputs["projectId"] = args ? args.projectId : undefined;
            resourceInputs["repeatable"] = args ? args.repeatable : undefined;
            resourceInputs["resourceTypes"] = args ? args.resourceTypes : undefined;
            resourceInputs["resourceTypesRegions"] = args ? args.resourceTypesRegions : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["certificatePrivateKey", "certificatePublicKey"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(UpdateCertificateInstanceOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering UpdateCertificateInstanceOperation resources.
 */
export interface UpdateCertificateInstanceOperationState {
    /**
     * Whether to allow downloading, if you choose to upload the certificate, you can configure this parameter.
     */
    allowDownload?: pulumi.Input<boolean>;
    /**
     * Update new certificate ID.
     */
    certificateId?: pulumi.Input<string>;
    /**
     * Certificate private key. If you upload the certificate public key, CertificateId does not need to be passed.
     */
    certificatePrivateKey?: pulumi.Input<string>;
    /**
     * Certificate public key. If you upload the certificate public key, CertificateId does not need to be passed.
     */
    certificatePublicKey?: pulumi.Input<string>;
    /**
     * Whether to ignore expiration reminders for old certificates 0: Do not ignore notifications. 1: Ignore the notification and ignore the OldCertificateId expiration reminder.
     */
    expiringNotificationSwitch?: pulumi.Input<number>;
    /**
     * Update the original certificate ID.
     */
    oldCertificateId?: pulumi.Input<string>;
    /**
     * Project ID, if you choose to upload the certificate, you can configure this parameter.
     */
    projectId?: pulumi.Input<number>;
    /**
     * Whether the same certificate is allowed to be uploaded repeatedly. If you choose to upload the certificate, you can configure this parameter.
     */
    repeatable?: pulumi.Input<boolean>;
    /**
     * The resource type that needs to be deployed. The parameter value is optional: clb, cdn, waf, live, ddos, teo, apigateway, vod, tke, tcb.
     */
    resourceTypes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * List of regions where cloud resources need to be deploye.
     */
    resourceTypesRegions?: pulumi.Input<pulumi.Input<inputs.Ssl.UpdateCertificateInstanceOperationResourceTypesRegion>[]>;
}

/**
 * The set of arguments for constructing a UpdateCertificateInstanceOperation resource.
 */
export interface UpdateCertificateInstanceOperationArgs {
    /**
     * Whether to allow downloading, if you choose to upload the certificate, you can configure this parameter.
     */
    allowDownload?: pulumi.Input<boolean>;
    /**
     * Update new certificate ID.
     */
    certificateId?: pulumi.Input<string>;
    /**
     * Certificate private key. If you upload the certificate public key, CertificateId does not need to be passed.
     */
    certificatePrivateKey?: pulumi.Input<string>;
    /**
     * Certificate public key. If you upload the certificate public key, CertificateId does not need to be passed.
     */
    certificatePublicKey?: pulumi.Input<string>;
    /**
     * Whether to ignore expiration reminders for old certificates 0: Do not ignore notifications. 1: Ignore the notification and ignore the OldCertificateId expiration reminder.
     */
    expiringNotificationSwitch?: pulumi.Input<number>;
    /**
     * Update the original certificate ID.
     */
    oldCertificateId: pulumi.Input<string>;
    /**
     * Project ID, if you choose to upload the certificate, you can configure this parameter.
     */
    projectId?: pulumi.Input<number>;
    /**
     * Whether the same certificate is allowed to be uploaded repeatedly. If you choose to upload the certificate, you can configure this parameter.
     */
    repeatable?: pulumi.Input<boolean>;
    /**
     * The resource type that needs to be deployed. The parameter value is optional: clb, cdn, waf, live, ddos, teo, apigateway, vod, tke, tcb.
     */
    resourceTypes: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * List of regions where cloud resources need to be deploye.
     */
    resourceTypesRegions?: pulumi.Input<pulumi.Input<inputs.Ssl.UpdateCertificateInstanceOperationResourceTypesRegion>[]>;
}