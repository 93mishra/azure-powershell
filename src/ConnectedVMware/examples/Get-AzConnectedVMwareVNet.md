### Example 1: List Virtual Networks in current subscription
```powershell
Get-AzConnectedVMwareVNet -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location      Name                                                          ResourceGroupName
----   --------      ----                                                          -----------------
       eastus        test-vnet1                                                    test-rg1
       eastus        test-vnet2                                                    test-rg2
       eastus        test-vnet3                                                    test-rg3
       eastus        test-vnet4                                                    test-rg4
       eastus        test-vnet5                                                    test-rg5
       eastus        test-vnet6                                                    test-rg6
       eastus        test-vnet7                                                    test-rg7
       eastus        test-vnet8                                                    test-rg8
```

This command lists Virtual Networks in current subscription.

### Example 2: List Virtual Networks in a resource group
```powershell
Get-AzConnectedVMwareVNet -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-vnet1   test-rg
VMware eastus   test-vnet2   test-rg
```

This command lists Virtual Networks in a resource group named `test-rg`.

### Example 3: Get a specific Virtual Network
```powershell
Get-AzConnectedVMwareVNet -Name "test-vnet" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-vnet test-rg
```

This command gets a Virtual Network named `test-vnet` in a resource group named `test-rg`.