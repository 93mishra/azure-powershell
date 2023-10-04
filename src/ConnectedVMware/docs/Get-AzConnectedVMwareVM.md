---
external help file:
Module Name: Az.ConnectedVMware
online version: https://docs.microsoft.com/powershell/module/az.connectedvmware/get-azconnectedvmwarevm
schema: 2.0.0
---

# Get-AzConnectedVMwareVM

## SYNOPSIS
Retrieves information about a virtual machine instance.

## SYNTAX

### Get (Default)
```
Get-AzConnectedVMwareVM -ResourceUri <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List
```
Get-AzConnectedVMwareVM -ResourceUri <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Retrieves information about a virtual machine instance.

## EXAMPLES

### Example 1: List VMs in current subscription
```powershell
Get-AzConnectedVMwareVM -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location      Name                                                           ResourceGroupName
----   --------      ----                                                           -----------------
AVS    eastus        test-vm1                                                       test-rg1
VMware eastus        test-vm2                                                       test-rg2
AVS    eastus        test-vm3                                                       test-rg3
VMware eastus        test-vm4                                                       test-rg4
VMware eastus        test-vm5                                                       test-rg5
VMware eastus        test-vm6                                                       test-rg6
VMware eastus        test-vm7                                                       test-rg7
VMware eastus        test-vm8                                                       test-rg8
```

This command lists VMs in current subscription.

### Example 2: List VMs in a resource group
```powershell
Get-AzConnectedVMwareVM -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-vm1     test-rg
VMware eastus   test-vm2     test-rg
```

This command lists VMs in a resource group named `test-rg`.

### Example 3: Get a specific VM
```powershell
Get-AzConnectedVMwareVM -Name "test-vm" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-vm      test-rg
```

This command gets a VM named `test-vm` in a resource group named `test-rg`

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

### -ResourceUri
The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualMachineInstance

## NOTES

## RELATED LINKS

