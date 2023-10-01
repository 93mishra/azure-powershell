if(($null -eq $TestName) -or ($TestName -contains 'AzConnectedVMwareHost'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'AzConnectedVMwareHost.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'AzConnectedVMwareHost' {
    It 'CreateExpanded' -Skip {
        New-AzConnectedVMwareHost -Name $env.hostName -ResourceGroupName $env.resourceGroupName -Location $env.location -ExtendedLocationName $env.extendedLocationName -ExtendedLocationType $env.extendedLocationType -InventoryItemId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/azcli-test-rg/providers/Microsoft.ConnectedVMwarevSphere/VCenters/azcli-test-vc/InventoryItems/host-1147412"
    }

    It 'Get' {
        $hosts = Get-AzConnectedVMwareHost -ResourceGroupName $env.ResourceGroupName -Name "10-150-178-208"
        $hosts.Name | Should -Be "10-150-178-208"
    }

    It 'Delete' -Skip {
        Remove-AzConnectedVMwareHost -Name "10-150-178-208" -ResourceGroupName $env.resourceGroupName
    }
}
