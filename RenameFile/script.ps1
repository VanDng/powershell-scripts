# Configuration

$Dir = "E:\ASW\PCL\Src\piawe-calculator"

$SearchString = "PIAWE"
$ReplaceString = "Piawe"

$Pattern = "*.*"
$IsRecursive = "1" # 1 = True, 0 = False

# Execution

if (-not ([System.Management.Automation.PSTypeName]'MyScriptSpace.MyScriptMain').Type)
{
    Add-Type -Path "csharp.cs" -PassThru
}

[String[]]$array = $Dir, $SearchString, $ReplaceString, $Pattern, $IsRecursive

[MyScriptSpace.MyScriptMain]::Main($array)