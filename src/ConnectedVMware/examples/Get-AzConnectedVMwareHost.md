### Example 1: List Hosts in current subscription
```powershell
Get-AzConnectedVMwareHost -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location      Name                                                          ResourceGroupName
----   --------      ----                                                          -----------------
       eastus        test-host1                                                    test-rg1
       eastus        test-host2                                                    test-rg2
       eastus        test-host3                                                    test-rg3
       eastus        test-host4                                                    test-rg4
       eastus        test-host5                                                    test-rg5
       eastus        test-host6                                                    test-rg6
       eastus        test-host7                                                    test-rg7
       eastus        test-host8                                                    test-rg8
```

This command lists Hosts in current subscription.

### Example 2: List Hosts in a resource group
```powershell
Get-AzConnectedVMwareHost -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-host1   test-rg
VMware eastus   test-host2   test-rg
```

This command lists Hosts in a resource group named `test-rg`.

### Example 3: Get a specific Host
```powershell
Get-AzConnectedVMwareHost -Name "test-host" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-host    test-rg
```

This command gets a Host named `test-host` in a resource group named `test-rg`.