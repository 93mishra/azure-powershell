---
external help file:
Module Name: Az.ConnectedVMware
online version: https://docs.microsoft.com/powershell/module/az.connectedvmware/get-azconnectedvmwareresourcepool
schema: 2.0.0
---

# Get-AzConnectedVMwareResourcePool

## SYNOPSIS
Implements resourcePool GET method.

## SYNTAX

### List (Default)
```
Get-AzConnectedVMwareResourcePool [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### Get
```
Get-AzConnectedVMwareResourcePool -Name <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzConnectedVMwareResourcePool -InputObject <IConnectedVMwareIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### List1
```
Get-AzConnectedVMwareResourcePool -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Implements resourcePool GET method.

## EXAMPLES

### Example 1: List Resource Pools in current subscription
```powershell
Get-AzConnectedVMwareResourcePool -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location      Name                                          ResourceGroupName
----   --------      ----                                          -----------------
       eastus        test-rp1                                      test-rg1
       eastus        test-rp2                                      test-rg2
       eastus        test-rp3                                      test-rg3
       eastus        test-rp4                                      test-rg4
       eastus        test-rp5                                      test-rg5
       eastus        test-rp6                                      test-rg6
       eastus        test-rp7                                      test-rg7
       eastus        test-rp8                                      test-rg8
```

This command lists Resource Pools in current subscription.

### Example 2: List Resource Pools in a resource group
```powershell
Get-AzConnectedVMwareResourcePool -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-rp1     test-rg
VMware eastus   test-rp2     test-rg
```

This command lists Resource Pools in a resource group named `test-rg`.

### Example 3: Get a specific Resource Pool
```powershell
Get-AzConnectedVMwareResourcePool -Name "test-rp" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-rp      test-rg
```

This command gets a Resource Pool named `test-rp` in a resource group named `test-rg`.

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
Name of the resourcePool.

```yaml
Type: System.String
Parameter Sets: Get
Aliases: ResourcePoolName

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

### Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IResourcePool

## NOTES

## RELATED LINKS

