### Example 1: Update VCenter
```powershell
Update-AzConnectedVMwareVCenter -Name "azcli-test-vc" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d" 
-Tag @{"vc"="test"}
```

```output
Kind   Location Name          ResourceGroupName
----   -------- ----          -----------------
VMware eastus   test-vc       test-rg
```

This command update tag of a VCenter named `azcli-test-vc` in a resource group named `test-rg`.