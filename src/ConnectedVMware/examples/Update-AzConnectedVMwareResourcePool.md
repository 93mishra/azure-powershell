### Example 1: Update Resource Pool
```powershell
Update-AzConnectedVMwareResourcePool -Name "test-rp" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
-Tag @{"rp"="test"}
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-rp      test-rg
```

This command update tag of a Resource Pool named `test-rp` in a resource group named `test-rg`.