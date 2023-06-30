[CmdletBinding(DefaultParameterSetName = "Build")]
param(
    [Parameter(ParameterSetName="Bootstrap")]
    [switch]
    $Bootstrap,

    [Parameter(ParameterSetName="Build")]
    [switch]
    $Clean,

    [Parameter(ParameterSetName="Build")]
    [switch]
    $Test
)

$NeededTools = @{
    VSCode = "Visual Studio Code"
    NodeJS = "Node.js 6.0 or higher"
    PowerShellGet = "PowerShellGet latest"
    InvokeBuild = "InvokeBuild latest"
}

function needsVSCode {
    $Version = (code -v)
    if($Version)
    {
        return $false
    }

    return $true
}

function needsNode {
    $Version = (node -v)
    if($Version)
    {
        return $false
    }

    return $true
}

function getMissingTools {
    $missingTools = @()

    if (needsVSCode) {
        $missingTools += $NeededTools.VSCode
    }

    if (needsNode) {
        $missingTools += $NeededTools.NodeJS
    }
   
    return $missingTools
}

getMissingTools