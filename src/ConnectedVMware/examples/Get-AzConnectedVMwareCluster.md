### Example 1: List Clusters in current subscription
```powershell
Get-AzConnectedVMwareCluster -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location      Name                                                             ResourceGroupName
----   --------      ----                                                             -----------------
       eastus        test-cluster1                                                    test-rg1
       eastus        test-cluster2                                                    test-rg2
       eastus        test-cluster3                                                    test-rg3
       eastus        test-cluster4                                                    test-rg4
       eastus        test-cluster5                                                    test-rg5
       eastus        test-cluster6                                                    test-rg6
       eastus        test-cluster7                                                    test-rg7
       eastus        test-cluster8                                                    test-rg8
```

This command lists Clusters in current subscription.

### Example 2: List Clusters in a resource group
```powershell
Get-AzConnectedVMwareCluster -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name          ResourceGroupName
----   -------- ----          -----------------
VMware eastus   test-cluster1 test-rg
VMware eastus   test-cluster2 test-rg
```

This command lists Clusters in a resource group named `test-rg`.

### Example 3: Get a specific Cluster
```powershell
Get-AzConnectedVMwareCluster -Name "test-cluster" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-cluster test-rg
```

This command gets a Cluster named `test-cluster` in a resource group named `test-rg`.