$ErrorActionPreference = "Stop"

$toolsDir = "D:\Tinh\TheBonwater\Tools"
if (!(Test-Path $toolsDir)) {
    New-Item -ItemType Directory -Force -Path $toolsDir | Out-Null
}

$il2cppUrl = "https://github.com/Perfare/Il2CppDumper/releases/download/v6.7.46/Il2CppDumper-v6.7.46.zip"
$il2cppZip = "$toolsDir\Il2CppDumper.zip"
$il2cppOut = "$toolsDir\Il2CppDumper"

try {
    Write-Host "Downloading Il2CppDumper..."
    Invoke-WebRequest -Uri $il2cppUrl -OutFile $il2cppZip
    Write-Host "Extracting Il2CppDumper..."
    Expand-Archive -Path $il2cppZip -DestinationPath $il2cppOut -Force
    Write-Host "Il2CppDumper downloaded successfully."
} catch {
    $err = $_.Exception.Message
    Write-Host "Error downloading Il2CppDumper: $err"
    Add-Content -Path "D:\Tinh\TheBonwater\Logs\tool_download_error.log" -Value "Il2CppDumper Error: $err"
}

# AssetStudio download (skipping as UnityPy is primary, but doing it just in case)
$assetStudioUrl = "https://github.com/Perfare/AssetStudio/releases/download/v0.16.47/AssetStudio.net472.v0.16.47.zip"
$assetStudioZip = "$toolsDir\AssetStudio.zip"
$assetStudioOut = "$toolsDir\AssetStudio"

try {
    Write-Host "Downloading AssetStudio..."
    Invoke-WebRequest -Uri $assetStudioUrl -OutFile $assetStudioZip
    Write-Host "Extracting AssetStudio..."
    Expand-Archive -Path $assetStudioZip -DestinationPath $assetStudioOut -Force
    Write-Host "AssetStudio downloaded successfully."
} catch {
    $err = $_.Exception.Message
    Write-Host "Error downloading AssetStudio: $err"
    Add-Content -Path "D:\Tinh\TheBonwater\Logs\tool_download_error.log" -Value "AssetStudio Error: $err"
}
