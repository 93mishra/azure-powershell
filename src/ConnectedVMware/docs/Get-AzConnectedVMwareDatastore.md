---
external help file:
Module Name: Az.ConnectedVMware
online version: https://docs.microsoft.com/powershell/module/az.connectedvmware/get-azconnectedvmwaredatastore
schema: 2.0.0
---

# Get-AzConnectedVMwareDatastore

## SYNOPSIS
Implements datastore GET method.

## SYNTAX

### List (Default)
```
Get-AzConnectedVMwareDatastore [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzConnectedVMwareDatastore -Name <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzConnectedVMwareDatastore -InputObject <IConnectedVMwareIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### List1
```
Get-AzConnectedVMwareDatastore -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Implements datastore GET method.

## EXAMPLES

### Example 1: List Datastores in current subscription
```powershell
Get-AzConnectedVMwareDatastore -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location      Name                                  ResourceGroupName
----   --------      ----                                  -----------------
       eastus        test-datastore1                       test-rg1
       eastus        test-datastore2                       test-rg2
       eastus        test-datastore3                       test-rg3
       eastus        test-datastore4                       test-rg4
       eastus        test-datastore5                       test-rg5
       eastus        test-datastore6                       test-rg6
       eastus        test-datastore7                       test-rg7
       eastus        test-datastore8                       test-rg8
```

This command lists Datastores in current subscription.

### Example 2: List Datastores in a resource group
```powershell
Get-AzConnectedVMwareDatastore -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name           ResourceGroupName
----   -------- ----           -----------------
VMware eastus   test-datastore test-rg
```

This command lists Datastores in a resource group named `test-rg`.

### Example 3: Get a specific Datastore
```powershell
Get-AzConnectedVMwareDatastore -Name "test-datastore" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name            ResourceGroupName
----   -------- ----            -----------------
VMware eastus   test-datastore1 test-rg
VMware eastus   test-datastore2 test-rg
```

This command gets a Datastore named `test-datastore` in a resource group named `test-rg`.

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IConnectedVMwareIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
Name of the datastore.

```yaml
Type: System.String
Parameter Sets: Get
Aliases: DatastoreName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The Resource Group Name.

```yaml
Type: System.String
Parameter Sets: Get, List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The Subscription ID.

```yaml
Type: System.String[]
Parameter Sets: Get, List, List1
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IConnectedVMwareIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IDatastore

## NOTES

## RELATED LINKS

