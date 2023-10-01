### Example 1: Create VCenter
```powershell
New-AzConnectedVMwareCluster -Name "test-vc" -Fqdn "1.2.3.4" -CredentialsUsername $VM_User_Name -CredentialsPassword $Secure_String_Pwd -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d" -Location "eastus" -ExtendedLocationName "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourcegroups/test-rg/providers/microsoft.extendedlocation/customlocations/azcli-test-cl" -ExtendedLocationType "CustomLocation"
```

```output
Kind   Location Name         ResourceGroupName
----   -------- ----         -----------------
VMware eastus   test-vc      test-rg
```

This command create a VCenter named `test-vc` in a resource group named `test-rg`.