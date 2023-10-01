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