// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of vpc natDcRoute
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const natDcRoute = tencentcloud.Nat.getDcRoute({
 *     natGatewayId: "nat-gnxkey2e",
 *     vpcId: "vpc-pyyv5k3v",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDcRoute(args: GetDcRouteArgs, opts?: pulumi.InvokeOptions): Promise<GetDcRouteResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Nat/getDcRoute:getDcRoute", {
        "natGatewayId": args.natGatewayId,
        "resultOutputFile": args.resultOutputFile,
        "vpcId": args.vpcId,
    }, opts);
}

/**
 * A collection of arguments for invoking getDcRoute.
 */
export interface GetDcRouteArgs {
    /**
     * Unique identifier of Nat Gateway.
     */
    natGatewayId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Unique identifier of Vpc.
     */
    vpcId: string;
}

/**
 * A collection of values returned by getDcRoute.
 */
export interface GetDcRouteResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Data of route.
     */
    readonly natDirectConnectGatewayRouteSets: outputs.Nat.GetDcRouteNatDirectConnectGatewayRouteSet[];
    readonly natGatewayId: string;
    readonly resultOutputFile?: string;
    readonly vpcId: string;
}
/**
 * Use this data source to query detailed information of vpc natDcRoute
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const natDcRoute = tencentcloud.Nat.getDcRoute({
 *     natGatewayId: "nat-gnxkey2e",
 *     vpcId: "vpc-pyyv5k3v",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDcRouteOutput(args: GetDcRouteOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDcRouteResult> {
    return pulumi.output(args).apply((a: any) => getDcRoute(a, opts))
}

/**
 * A collection of arguments for invoking getDcRoute.
 */
export interface GetDcRouteOutputArgs {
    /**
     * Unique identifier of Nat Gateway.
     */
    natGatewayId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Unique identifier of Vpc.
     */
    vpcId: pulumi.Input<string>;
}