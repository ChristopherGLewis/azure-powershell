---
Module Name: Az.StorageSync
Module Guid: 001b4bbc-9d7d-43b2-9e95-7a70325e9509
Download Help Link: https://learn.microsoft.com/powershell/module/az.storagesync
Help Version: 1.0.0.0
Locale: en-US
---

# Az.StorageSync Module
## Description
The cmdlets in the Storage Sync module enable you to manage operations pertaining to Azure File Sync in PowerShell.
### [Get-AzStorageSyncCloudEndpoint](Get-AzStorageSyncCloudEndpoint.md)
This command lists all cloud endpoints within a given sync group.

### [Get-AzStorageSyncGroup](Get-AzStorageSyncGroup.md)
This command lists all sync groups within a given storage sync service.

### [Get-AzStorageSyncServer](Get-AzStorageSyncServer.md)
This command lists all servers registered to a given storage sync service.

### [Get-AzStorageSyncServerEndpoint](Get-AzStorageSyncServerEndpoint.md)
This command lists all server endpoints within a given sync group.

### [Get-AzStorageSyncService](Get-AzStorageSyncService.md)
This command lists all storage sync services within a given scope of subscription/resource group.

### [Invoke-AzStorageSyncChangeDetection](Invoke-AzStorageSyncChangeDetection.md)
This command can be used to manually initiate the detection of namespace changes. It can be targeted to the entire share, subfolder or set of files. When running the command with the -DirectoryPath or -Path parameters, a maximum of 10,000 items can be detected. If the scope of changes is known to you, limit the execution of this command to parts of the namespace, so change detection can finish quickly and within the 10,000 item limit. Alternatively, you can avoid the item limit by running the cmdlet without these parameters, invoking share-level change detection.  > [!Note]   > If run with -DirectoryPath or -Path parameters, the command will not detect the following changes in the Azure file share: > - Files that are deleted.  > - Files that are moved out of the share. > - Files that are deleted and created with the same name.   >  >  If share-level change detection is invoked, all of these changes will be detected. These changes will also be detected when the scheduled [change detection job](https://learn.microsoft.com/azure/storage/files/storage-sync-files-troubleshoot?tabs=portal1%2Cazure-portal#afs-change-detection) runs.

### [Invoke-AzStorageSyncCompatibilityCheck](Invoke-AzStorageSyncCompatibilityCheck.md)
Checks for potential compatibility issues between your system and Azure File Sync.

### [New-AzStorageSyncCloudEndpoint](New-AzStorageSyncCloudEndpoint.md)
This command creates an Azure File Sync cloud endpoint in a sync group.

### [New-AzStorageSyncGroup](New-AzStorageSyncGroup.md)
This command creates a new sync group within a specified storage sync service.

### [New-AzStorageSyncServerEndpoint](New-AzStorageSyncServerEndpoint.md)
This command creates a new server endpoint on a registered server. This enables the specified path on the server to start syncing the files with other endpoints in the sync group.

### [New-AzStorageSyncService](New-AzStorageSyncService.md)
This command creates a new storage sync service in a resource group.

### [Register-AzStorageSyncServer](Register-AzStorageSyncServer.md)
This command registers a server to a storage sync service which creates a trust relationship. PowerShell or the Azure portal can then be used to configure sync on this server.

### [Remove-AzStorageSyncCloudEndpoint](Remove-AzStorageSyncCloudEndpoint.md)
This command will delete the specified cloud endpoint from a sync group. Without at least one cloud endpoint, no other server endpoints in this sync group can sync.

### [Remove-AzStorageSyncGroup](Remove-AzStorageSyncGroup.md)
This command will delete the specified sync group.

### [Remove-AzStorageSyncServerEndpoint](Remove-AzStorageSyncServerEndpoint.md)
This command will delete the specified server endpoint. Sync to this location will stop immediately.

### [Remove-AzStorageSyncServerEndpointPermission](Remove-AzStorageSyncServerEndpointPermission.md)
This command removes the RBAC permission required for Server endpoint to work.

### [Remove-AzStorageSyncService](Remove-AzStorageSyncService.md)
This command will delete the specified storage sync service.

### [Reset-AzStorageSyncServerCertificate](Reset-AzStorageSyncServerCertificate.md)
Use for troubleshooting only. This command will roll the storage sync server certificate used to describe the server identity to the storage sync service.

### [Set-AzStorageSyncCloudEndpointPermission](Set-AzStorageSyncCloudEndpointPermission.md)
This command sets RBAC permission required for an Azure File Sync cloud endpoint in a sync group.

### [Set-AzStorageSyncServer](Set-AzStorageSyncServer.md)
This command will set the server with identity. This helps to enable the server with identity features.

### [Set-AzStorageSyncServerEndpoint](Set-AzStorageSyncServerEndpoint.md)
This command allows for changes on the adjustable parameters of a server endpoint.

### [Set-AzStorageSyncServerEndpointPermission](Set-AzStorageSyncServerEndpointPermission.md)
This command sets the RBAC permission required for Server endpoint to work.

### [Set-AzStorageSyncService](Set-AzStorageSyncService.md)
This command sets storage sync service in a resource group.

### [Set-AzStorageSyncServiceIdentity](Set-AzStorageSyncServiceIdentity.md)
This command helps to migrate storage sync service in a resource group to start using managed identity.

### [Unregister-AzStorageSyncServer](Unregister-AzStorageSyncServer.md)
Warning: Unregistering a server will result in cascading deletes of all server endpoints on this server. This command will unregister a server from it's storage sync service.

