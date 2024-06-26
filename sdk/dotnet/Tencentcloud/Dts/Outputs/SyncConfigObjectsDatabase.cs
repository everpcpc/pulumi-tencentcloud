// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dts.Outputs
{

    [OutputType]
    public sealed class SyncConfigObjectsDatabase
    {
        /// <summary>
        /// DB selection mode: All (for all objects under the current object), Partial (for some objects), when the Mode is Partial, this item is required. Note that synchronization of advanced objects does not depend on this value. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? DbMode;
        /// <summary>
        /// The name of the library that needs to be migrated or synchronized. This item is required when the ObjectMode is Partial. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? DbName;
        /// <summary>
        /// Event migration mode, all (for all objects under the current object), partial (partial objects). Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? EventMode;
        /// <summary>
        /// When EventMode is partial, specify the name of the event to be migrated. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> Events;
        /// <summary>
        /// Select the mode to be synchronized, Partial is a part, all is an entire selection. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? FunctionMode;
        /// <summary>
        /// Required when the FunctionMode value is Partial. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> Functions;
        /// <summary>
        /// The name of the library after migration or synchronization, which is the same as the source library by default. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? NewDbName;
        /// <summary>
        /// Schema name after migration or synchronization. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? NewSchemaName;
        /// <summary>
        /// Select the mode to be synchronized, Partial is part, All is the whole selection. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? ProcedureMode;
        /// <summary>
        /// Required when the value of ProcedureMode is Partial. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> Procedures;
        /// <summary>
        /// Migrated or synchronized schemaNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? SchemaName;
        /// <summary>
        /// Table selection mode: All (for all objects under the current object), Partial (for some objects), this item is required when the DBMode is Partial. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? TableMode;
        /// <summary>
        /// A collection of table graph objects, when TableMode is Partial, this item needs to be filled in. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.SyncConfigObjectsDatabaseTable> Tables;
        /// <summary>
        /// Trigger migration mode, all (for all objects under the current object), partial (partial objects). Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? TriggerMode;
        /// <summary>
        /// When TriggerMode is partial, specify the name of the trigger to be migrated. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> Triggers;
        /// <summary>
        /// View selection mode: All is all view objects under the current object, Partial is part of the view objects. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? ViewMode;
        /// <summary>
        /// View object collection, when ViewMode is Partial, this item needs to be filled in. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.SyncConfigObjectsDatabaseView> Views;

        [OutputConstructor]
        private SyncConfigObjectsDatabase(
            string? dbMode,

            string? dbName,

            string? eventMode,

            ImmutableArray<string> events,

            string? functionMode,

            ImmutableArray<string> functions,

            string? newDbName,

            string? newSchemaName,

            string? procedureMode,

            ImmutableArray<string> procedures,

            string? schemaName,

            string? tableMode,

            ImmutableArray<Outputs.SyncConfigObjectsDatabaseTable> tables,

            string? triggerMode,

            ImmutableArray<string> triggers,

            string? viewMode,

            ImmutableArray<Outputs.SyncConfigObjectsDatabaseView> views)
        {
            DbMode = dbMode;
            DbName = dbName;
            EventMode = eventMode;
            Events = events;
            FunctionMode = functionMode;
            Functions = functions;
            NewDbName = newDbName;
            NewSchemaName = newSchemaName;
            ProcedureMode = procedureMode;
            Procedures = procedures;
            SchemaName = schemaName;
            TableMode = tableMode;
            Tables = tables;
            TriggerMode = triggerMode;
            Triggers = triggers;
            ViewMode = viewMode;
            Views = views;
        }
    }
}
