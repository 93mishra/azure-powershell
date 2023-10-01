### Example 1: List VM Templates in current subscription
```powershell
Get-AzConnectedVMwareVMTemplate -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location      Name                                             ResourceGroupName
----   --------      ----                                             -----------------
       eastus        test-vmtmpl1                                     test-rg1
       eastus        test-vmtmpl2                                     test-rg2
       eastus        test-vmtmpl3                                     test-rg3
       eastus        test-vmtmpl4                                     test-rg4
       eastus        test-vmtmpl5                                     test-rg5
       eastus        test-vmtmpl6                                     test-rg6
       eastus        test-vmtmpl7                                     test-rg7
       eastus        test-vmtmpl8                                     test-rg8
```

This command lists VM Templates in current subscription.

### Example 2: List VM Templates in a resource group
```powershell
Get-AzConnectedVMwareVMTemplate -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-vmtmpl1 test-rg
VMware eastus   test-vmtmpl2 test-rg
```

This command lists VM Templates in a resource group named `test-rg`.

### Example 3: Get a specific VM Template
```powershell
Get-AzConnectedVMwareVMTemplate -Name "test-vmtmpl" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-vmtmpl  test-rg
```

This command gets a VM Template named `test-vmtmpl` in a resource group named `test-rg`.