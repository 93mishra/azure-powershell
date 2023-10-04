---
external help file:
Module Name: Az.ConnectedVMware
online version: https://docs.microsoft.com/powershell/module/az.connectedvmware/get-azconnectedvmwarevcenter
schema: 2.0.0
---

# Get-AzConnectedVMwareVCenter

## SYNOPSIS
Implements vCenter GET method.

## SYNTAX

### List (Default)
```
Get-AzConnectedVMwareVCenter [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzConnectedVMwareVCenter -Name <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzConnectedVMwareVCenter -InputObject <IConnectedVMwareIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### List1
```
Get-AzConnectedVMwareVCenter -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Implements vCenter GET method.

## EXAMPLES

### Example 1: List VCenters in current subscription
```powershell
Get-AzConnectedVMwareVCenter -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location      Name                                         ResourceGroupName
----   --------      ----                                         -----------------
VMware eastus        test-vc1                                     test-rg1
VMware eastus        test-vc2                                     test-rg2
VMware eastus        test-vc3                                     test-rg3
VMware eastus        test-vc4                                     test-rg4
VMware eastus        test-vc5                                     test-rg5
AVS    eastus        test-vc6                                     test-rg6
VMware eastus        test-vc7                                     test-rg7
VMware EastUS        test-vc8                                     test-rg8
```

This command lists VCenters in current subscription.

### Example 2: List VCenters in a resource group
```powershell
Get-AzConnectedVMwareVCenter -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-vc1     test-rg
VMware eastus   test-vc2     test-rg
```

This command lists VCenters in a resource group named `test-rg`.

### Example 3: Get a specific VCenter
```powershell
Get-AzConnectedVMwareVCenter -Name "test-vc" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-vc      test-rg
```

This command gets a VCenter named `test-vc` in a resource group named `test-rg`.

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
Name of the vCenter.

```yaml
Type: System.String
Parameter Sets: Get
Aliases: VcenterName

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

### Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVCenter

## NOTES

## RELATED LINKS

