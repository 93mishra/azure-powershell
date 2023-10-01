if(($null -eq $TestName) -or ($TestName -contains 'AzConnectedVMwareCluster'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'AzConnectedVMwareCluster.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'AzConnectedVMwareCluster' {
    It 'CreateExpanded' -Skip {
        New-AzConnectedVMwareCluster -Name $env.clusterName -ResourceGroupName $env.resourceGroupName -Location $env.location -ExtendedLocationName $env.extendedLocationName -ExtendedLocationType $env.extendedLocationType -InventoryItemId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/azcli-test-rg/providers/Microsoft.ConnectedVMwarevSphere/VCenters/azcli-test-vc/InventoryItems/domain-c649660"
    }

    It 'Get' {
        $cluster = Get-AzConnectedVMwareCluster -ResourceGroupName $env.ResourceGroupName -Name "Cluster1"
        $cluster.Name | Should -Be "Cluster1"
    }

    It 'Delete' -Skip {
        Remove-AzConnectedVMwareCluster -Name "Cluster1" -ResourceGroupName $env.resourceGroupName
    }
}
