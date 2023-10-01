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