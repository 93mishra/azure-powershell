### Example 1: Update Datastore
```powershell
Update-AzConnectedVMwareDatastore -Name "test-datastore" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d"
-Tag @{"datastore"="test"}
```

```output
Kind   Location Name           ResourceGroupName
----   -------- ----           -----------------
VMware eastus   test-datastore test-rg
```

This command update tag of a Datastore named `test-datastore` in a resource group named `test-rg`.