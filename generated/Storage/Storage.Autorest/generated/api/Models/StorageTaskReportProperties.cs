// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Extensions;

    /// <summary>Storage task execution report for a run instance.</summary>
    public partial class StorageTaskReportProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal
    {

        /// <summary>Backing field for <see cref="FinishTime" /> property.</summary>
        private string _finishTime;

        /// <summary>
        /// End time of the run instance. Filter options such as startTime gt '2023-06-26T20:51:24.4494016Z' and other comparison
        /// operators can be used as described for DateTime properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string FinishTime { get => this._finishTime; }

        /// <summary>Internal Acessors for FinishTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.FinishTime { get => this._finishTime; set { {_finishTime = value;} } }

        /// <summary>Internal Acessors for ObjectFailedCount</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.ObjectFailedCount { get => this._objectFailedCount; set { {_objectFailedCount = value;} } }

        /// <summary>Internal Acessors for ObjectsOperatedOnCount</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.ObjectsOperatedOnCount { get => this._objectsOperatedOnCount; set { {_objectsOperatedOnCount = value;} } }

        /// <summary>Internal Acessors for ObjectsSucceededCount</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.ObjectsSucceededCount { get => this._objectsSucceededCount; set { {_objectsSucceededCount = value;} } }

        /// <summary>Internal Acessors for ObjectsTargetedCount</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.ObjectsTargetedCount { get => this._objectsTargetedCount; set { {_objectsTargetedCount = value;} } }

        /// <summary>Internal Acessors for RunResult</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.RunResult { get => this._runResult; set { {_runResult = value;} } }

        /// <summary>Internal Acessors for RunStatusEnum</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.RunStatusEnum { get => this._runStatusEnum; set { {_runStatusEnum = value;} } }

        /// <summary>Internal Acessors for RunStatusError</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.RunStatusError { get => this._runStatusError; set { {_runStatusError = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Internal Acessors for StorageAccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.StorageAccountId { get => this._storageAccountId; set { {_storageAccountId = value;} } }

        /// <summary>Internal Acessors for SummaryReportPath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.SummaryReportPath { get => this._summaryReportPath; set { {_summaryReportPath = value;} } }

        /// <summary>Internal Acessors for TaskAssignmentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.TaskAssignmentId { get => this._taskAssignmentId; set { {_taskAssignmentId = value;} } }

        /// <summary>Internal Acessors for TaskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.TaskId { get => this._taskId; set { {_taskId = value;} } }

        /// <summary>Internal Acessors for TaskVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageTaskReportPropertiesInternal.TaskVersion { get => this._taskVersion; set { {_taskVersion = value;} } }

        /// <summary>Backing field for <see cref="ObjectFailedCount" /> property.</summary>
        private string _objectFailedCount;

        /// <summary>
        /// Total number of objects where task operation failed when was attempted. Filter options such as objectFailedCount eq 0
        /// and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string ObjectFailedCount { get => this._objectFailedCount; }

        /// <summary>Backing field for <see cref="ObjectsOperatedOnCount" /> property.</summary>
        private string _objectsOperatedOnCount;

        /// <summary>
        /// Total number of objects that meet the storage tasks condition and were operated upon. Filter options such as objectsOperatedOnCount
        /// ge 100 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string ObjectsOperatedOnCount { get => this._objectsOperatedOnCount; }

        /// <summary>Backing field for <see cref="ObjectsSucceededCount" /> property.</summary>
        private string _objectsSucceededCount;

        /// <summary>
        /// Total number of objects where task operation succeeded when was attempted.Filter options such as objectsSucceededCount
        /// gt 150 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string ObjectsSucceededCount { get => this._objectsSucceededCount; }

        /// <summary>Backing field for <see cref="ObjectsTargetedCount" /> property.</summary>
        private string _objectsTargetedCount;

        /// <summary>
        /// Total number of objects that meet the condition as defined in the storage task assignment execution context. Filter options
        /// such as objectsTargetedCount gt 50 and other comparison operators can be used as described for Numerical properties in
        /// https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string ObjectsTargetedCount { get => this._objectsTargetedCount; }

        /// <summary>Backing field for <see cref="RunResult" /> property.</summary>
        private string _runResult;

        /// <summary>Represents the overall result of the execution for the run instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string RunResult { get => this._runResult; }

        /// <summary>Backing field for <see cref="RunStatusEnum" /> property.</summary>
        private string _runStatusEnum;

        /// <summary>Represents the status of the execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string RunStatusEnum { get => this._runStatusEnum; }

        /// <summary>Backing field for <see cref="RunStatusError" /> property.</summary>
        private string _runStatusError;

        /// <summary>
        /// Well known Azure Storage error code that represents the error encountered during execution of the run instance.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string RunStatusError { get => this._runStatusError; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private string _startTime;

        /// <summary>
        /// Start time of the run instance. Filter options such as startTime gt '2023-06-26T20:51:24.4494016Z' and other comparison
        /// operators can be used as described for DateTime properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string StartTime { get => this._startTime; }

        /// <summary>Backing field for <see cref="StorageAccountId" /> property.</summary>
        private string _storageAccountId;

        /// <summary>
        /// Represents the Storage Account Id where the storage task definition was applied and executed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string StorageAccountId { get => this._storageAccountId; }

        /// <summary>Backing field for <see cref="SummaryReportPath" /> property.</summary>
        private string _summaryReportPath;

        /// <summary>
        /// Full path to the verbose report stored in the reporting container as specified in the assignment execution context for
        /// the storage account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string SummaryReportPath { get => this._summaryReportPath; }

        /// <summary>Backing field for <see cref="TaskAssignmentId" /> property.</summary>
        private string _taskAssignmentId;

        /// <summary>
        /// Represents the Storage Task Assignment Id associated with the storage task that provided an execution context.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string TaskAssignmentId { get => this._taskAssignmentId; }

        /// <summary>Backing field for <see cref="TaskId" /> property.</summary>
        private string _taskId;

        /// <summary>Storage Task Arm Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string TaskId { get => this._taskId; }

        /// <summary>Backing field for <see cref="TaskVersion" /> property.</summary>
        private string _taskVersion;

        /// <summary>Storage Task Version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string TaskVersion { get => this._taskVersion; }

        /// <summary>Creates an new <see cref="StorageTaskReportProperties" /> instance.</summary>
        public StorageTaskReportProperties()
        {

        }
    }
    /// Storage task execution report for a run instance.
    public partial interface IStorageTaskReportProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.IJsonSerializable
    {
        /// <summary>
        /// End time of the run instance. Filter options such as startTime gt '2023-06-26T20:51:24.4494016Z' and other comparison
        /// operators can be used as described for DateTime properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"End time of the run instance. Filter options such as startTime gt '2023-06-26T20:51:24.4494016Z' and other comparison operators can be used as described for DateTime properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators",
        SerializedName = @"finishTime",
        PossibleTypes = new [] { typeof(string) })]
        string FinishTime { get;  }
        /// <summary>
        /// Total number of objects where task operation failed when was attempted. Filter options such as objectFailedCount eq 0
        /// and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Total number of objects where task operation failed when was attempted. Filter options such as objectFailedCount eq 0 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators",
        SerializedName = @"objectFailedCount",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectFailedCount { get;  }
        /// <summary>
        /// Total number of objects that meet the storage tasks condition and were operated upon. Filter options such as objectsOperatedOnCount
        /// ge 100 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Total number of objects that meet the storage tasks condition and were operated upon. Filter options such as objectsOperatedOnCount ge 100 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators",
        SerializedName = @"objectsOperatedOnCount",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectsOperatedOnCount { get;  }
        /// <summary>
        /// Total number of objects where task operation succeeded when was attempted.Filter options such as objectsSucceededCount
        /// gt 150 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Total number of objects where task operation succeeded when was attempted.Filter options such as objectsSucceededCount gt 150 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators",
        SerializedName = @"objectsSucceededCount",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectsSucceededCount { get;  }
        /// <summary>
        /// Total number of objects that meet the condition as defined in the storage task assignment execution context. Filter options
        /// such as objectsTargetedCount gt 50 and other comparison operators can be used as described for Numerical properties in
        /// https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Total number of objects that meet the condition as defined in the storage task assignment execution context. Filter options such as objectsTargetedCount gt 50 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators",
        SerializedName = @"objectsTargetedCount",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectsTargetedCount { get;  }
        /// <summary>Represents the overall result of the execution for the run instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Represents the overall result of the execution for the run instance",
        SerializedName = @"runResult",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Storage.PSArgumentCompleterAttribute("Succeeded", "Failed")]
        string RunResult { get;  }
        /// <summary>Represents the status of the execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Represents the status of the execution.",
        SerializedName = @"runStatusEnum",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Storage.PSArgumentCompleterAttribute("InProgress", "Finished")]
        string RunStatusEnum { get;  }
        /// <summary>
        /// Well known Azure Storage error code that represents the error encountered during execution of the run instance.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Well known Azure Storage error code that represents the error encountered during execution of the run instance.",
        SerializedName = @"runStatusError",
        PossibleTypes = new [] { typeof(string) })]
        string RunStatusError { get;  }
        /// <summary>
        /// Start time of the run instance. Filter options such as startTime gt '2023-06-26T20:51:24.4494016Z' and other comparison
        /// operators can be used as described for DateTime properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Start time of the run instance. Filter options such as startTime gt '2023-06-26T20:51:24.4494016Z' and other comparison operators can be used as described for DateTime properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string StartTime { get;  }
        /// <summary>
        /// Represents the Storage Account Id where the storage task definition was applied and executed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Represents the Storage Account Id where the storage task definition was applied and executed.",
        SerializedName = @"storageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountId { get;  }
        /// <summary>
        /// Full path to the verbose report stored in the reporting container as specified in the assignment execution context for
        /// the storage account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Full path to the verbose report stored in the reporting container as specified in the assignment execution context for the storage account. ",
        SerializedName = @"summaryReportPath",
        PossibleTypes = new [] { typeof(string) })]
        string SummaryReportPath { get;  }
        /// <summary>
        /// Represents the Storage Task Assignment Id associated with the storage task that provided an execution context.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Represents the Storage Task Assignment Id associated with the storage task that provided an execution context.",
        SerializedName = @"taskAssignmentId",
        PossibleTypes = new [] { typeof(string) })]
        string TaskAssignmentId { get;  }
        /// <summary>Storage Task Arm Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Storage Task Arm Id.",
        SerializedName = @"taskId",
        PossibleTypes = new [] { typeof(string) })]
        string TaskId { get;  }
        /// <summary>Storage Task Version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Storage Task Version",
        SerializedName = @"taskVersion",
        PossibleTypes = new [] { typeof(string) })]
        string TaskVersion { get;  }

    }
    /// Storage task execution report for a run instance.
    internal partial interface IStorageTaskReportPropertiesInternal

    {
        /// <summary>
        /// End time of the run instance. Filter options such as startTime gt '2023-06-26T20:51:24.4494016Z' and other comparison
        /// operators can be used as described for DateTime properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        string FinishTime { get; set; }
        /// <summary>
        /// Total number of objects where task operation failed when was attempted. Filter options such as objectFailedCount eq 0
        /// and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        string ObjectFailedCount { get; set; }
        /// <summary>
        /// Total number of objects that meet the storage tasks condition and were operated upon. Filter options such as objectsOperatedOnCount
        /// ge 100 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        string ObjectsOperatedOnCount { get; set; }
        /// <summary>
        /// Total number of objects where task operation succeeded when was attempted.Filter options such as objectsSucceededCount
        /// gt 150 and other comparison operators can be used as described for Numerical properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        string ObjectsSucceededCount { get; set; }
        /// <summary>
        /// Total number of objects that meet the condition as defined in the storage task assignment execution context. Filter options
        /// such as objectsTargetedCount gt 50 and other comparison operators can be used as described for Numerical properties in
        /// https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        string ObjectsTargetedCount { get; set; }
        /// <summary>Represents the overall result of the execution for the run instance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Storage.PSArgumentCompleterAttribute("Succeeded", "Failed")]
        string RunResult { get; set; }
        /// <summary>Represents the status of the execution.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Storage.PSArgumentCompleterAttribute("InProgress", "Finished")]
        string RunStatusEnum { get; set; }
        /// <summary>
        /// Well known Azure Storage error code that represents the error encountered during execution of the run instance.
        /// </summary>
        string RunStatusError { get; set; }
        /// <summary>
        /// Start time of the run instance. Filter options such as startTime gt '2023-06-26T20:51:24.4494016Z' and other comparison
        /// operators can be used as described for DateTime properties in https://learn.microsoft.com/rest/api/storageservices/querying-tables-and-entities#supported-comparison-operators
        /// </summary>
        string StartTime { get; set; }
        /// <summary>
        /// Represents the Storage Account Id where the storage task definition was applied and executed.
        /// </summary>
        string StorageAccountId { get; set; }
        /// <summary>
        /// Full path to the verbose report stored in the reporting container as specified in the assignment execution context for
        /// the storage account.
        /// </summary>
        string SummaryReportPath { get; set; }
        /// <summary>
        /// Represents the Storage Task Assignment Id associated with the storage task that provided an execution context.
        /// </summary>
        string TaskAssignmentId { get; set; }
        /// <summary>Storage Task Arm Id.</summary>
        string TaskId { get; set; }
        /// <summary>Storage Task Version</summary>
        string TaskVersion { get; set; }

    }
}