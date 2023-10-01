### Example 1: Enable Guest Agent on VM
```powershell
New-AzConnectedVMwareGuestAgent -Name "default" -VirtualMachineName "test-vm" -ResourceGroupName "test-rg" -SubscriptionId "204898ee-cd13-4332-b9d4-55ca5c25496d" -CredentialsUsername $VM_User_Name -CredentialsPassword $Secure_String_Pwd -ProvisioningAction "install"
```

```output
Name    ResourceGroupName
----    -----------------
default test-rg
```

This command Enable Guest Agent of a VM named `test-vm` in a resource group named `test-rg`.