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