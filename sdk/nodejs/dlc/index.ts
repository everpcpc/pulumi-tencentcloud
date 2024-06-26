// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./addUsersToWorkGroupAttachment";
export * from "./attachUserPolicyOperation";
export * from "./attachWorkGroupPolicyOperation";
export * from "./bindWorkGroupsToUserAttachment";
export * from "./dataEngine";
export * from "./detachUserPolicyOperation";
export * from "./detachWorkGroupPolicyOperation";
export * from "./getCheckDataEngineConfigPairsValidity";
export * from "./getCheckDataEngineImageCanBeRollback";
export * from "./getCheckDataEngineImageCanBeUpgrade";
export * from "./getDescribeDataEngine";
export * from "./getDescribeDataEngineEvents";
export * from "./getDescribeDataEngineImageVersions";
export * from "./getDescribeDataEnginePythonSparkImages";
export * from "./getDescribeEngineUsageInfo";
export * from "./getDescribeUpdatableDataEngines";
export * from "./getDescribeUserInfo";
export * from "./getDescribeUserRoles";
export * from "./getDescribeUserType";
export * from "./getDescribeWorkGroupInfo";
export * from "./modifyDataEngineDescriptionOperation";
export * from "./modifyUserTypOperation";
export * from "./renewDataEngineOperation";
export * from "./restartDataEngineOperation";
export * from "./rollbackDataEngineImageOperation";
export * from "./storeLocationConfig";
export * from "./suspendResumeDataEngine";
export * from "./switchDataEngineImageOperation";
export * from "./updateDataEngineConfigOperation";
export * from "./updateRowFilterOperation";
export * from "./upgradeDataEngineImageOperation";
export * from "./user";
export * from "./userDataEngineConfig";
export * from "./workGroup";

// Import resources to register:
import { AddUsersToWorkGroupAttachment } from "./addUsersToWorkGroupAttachment";
import { AttachUserPolicyOperation } from "./attachUserPolicyOperation";
import { AttachWorkGroupPolicyOperation } from "./attachWorkGroupPolicyOperation";
import { BindWorkGroupsToUserAttachment } from "./bindWorkGroupsToUserAttachment";
import { DataEngine } from "./dataEngine";
import { DetachUserPolicyOperation } from "./detachUserPolicyOperation";
import { DetachWorkGroupPolicyOperation } from "./detachWorkGroupPolicyOperation";
import { ModifyDataEngineDescriptionOperation } from "./modifyDataEngineDescriptionOperation";
import { ModifyUserTypOperation } from "./modifyUserTypOperation";
import { RenewDataEngineOperation } from "./renewDataEngineOperation";
import { RestartDataEngineOperation } from "./restartDataEngineOperation";
import { RollbackDataEngineImageOperation } from "./rollbackDataEngineImageOperation";
import { StoreLocationConfig } from "./storeLocationConfig";
import { SuspendResumeDataEngine } from "./suspendResumeDataEngine";
import { SwitchDataEngineImageOperation } from "./switchDataEngineImageOperation";
import { UpdateDataEngineConfigOperation } from "./updateDataEngineConfigOperation";
import { UpdateRowFilterOperation } from "./updateRowFilterOperation";
import { UpgradeDataEngineImageOperation } from "./upgradeDataEngineImageOperation";
import { User } from "./user";
import { UserDataEngineConfig } from "./userDataEngineConfig";
import { WorkGroup } from "./workGroup";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Dlc/addUsersToWorkGroupAttachment:AddUsersToWorkGroupAttachment":
                return new AddUsersToWorkGroupAttachment(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/attachUserPolicyOperation:AttachUserPolicyOperation":
                return new AttachUserPolicyOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/attachWorkGroupPolicyOperation:AttachWorkGroupPolicyOperation":
                return new AttachWorkGroupPolicyOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/bindWorkGroupsToUserAttachment:BindWorkGroupsToUserAttachment":
                return new BindWorkGroupsToUserAttachment(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/dataEngine:DataEngine":
                return new DataEngine(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/detachUserPolicyOperation:DetachUserPolicyOperation":
                return new DetachUserPolicyOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/detachWorkGroupPolicyOperation:DetachWorkGroupPolicyOperation":
                return new DetachWorkGroupPolicyOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/modifyDataEngineDescriptionOperation:ModifyDataEngineDescriptionOperation":
                return new ModifyDataEngineDescriptionOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/modifyUserTypOperation:ModifyUserTypOperation":
                return new ModifyUserTypOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/renewDataEngineOperation:RenewDataEngineOperation":
                return new RenewDataEngineOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/restartDataEngineOperation:RestartDataEngineOperation":
                return new RestartDataEngineOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/rollbackDataEngineImageOperation:RollbackDataEngineImageOperation":
                return new RollbackDataEngineImageOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/storeLocationConfig:StoreLocationConfig":
                return new StoreLocationConfig(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/suspendResumeDataEngine:SuspendResumeDataEngine":
                return new SuspendResumeDataEngine(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/switchDataEngineImageOperation:SwitchDataEngineImageOperation":
                return new SwitchDataEngineImageOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/updateDataEngineConfigOperation:UpdateDataEngineConfigOperation":
                return new UpdateDataEngineConfigOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/updateRowFilterOperation:UpdateRowFilterOperation":
                return new UpdateRowFilterOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/upgradeDataEngineImageOperation:UpgradeDataEngineImageOperation":
                return new UpgradeDataEngineImageOperation(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/user:User":
                return new User(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/userDataEngineConfig:UserDataEngineConfig":
                return new UserDataEngineConfig(name, <any>undefined, { urn })
            case "tencentcloud:Dlc/workGroup:WorkGroup":
                return new WorkGroup(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/addUsersToWorkGroupAttachment", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/attachUserPolicyOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/attachWorkGroupPolicyOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/bindWorkGroupsToUserAttachment", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/dataEngine", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/detachUserPolicyOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/detachWorkGroupPolicyOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/modifyDataEngineDescriptionOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/modifyUserTypOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/renewDataEngineOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/restartDataEngineOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/rollbackDataEngineImageOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/storeLocationConfig", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/suspendResumeDataEngine", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/switchDataEngineImageOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/updateDataEngineConfigOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/updateRowFilterOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/upgradeDataEngineImageOperation", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/user", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/userDataEngineConfig", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Dlc/workGroup", _module)
