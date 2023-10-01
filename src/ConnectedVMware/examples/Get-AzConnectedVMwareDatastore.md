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