@echo off
echo =========================================
echo IL2CPP Dumper Automation
echo =========================================
set DUMPER_EXE="D:\Tools\Il2CppDumper\Il2CppDumper.exe"
if not exist %DUMPER_EXE% (
    echo [ERROR] Il2CppDumper.exe not found at %DUMPER_EXE%
    echo Please download Il2CppDumper and update the path in this script.
    pause
    exit /b 1
)

set IL2CPP_BIN="D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\config.arm64_v8a.apk\lib\arm64-v8a\libil2cpp.so"
set METADATA_BIN="D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data\Managed\Metadata\global-metadata.dat"
set OUTPUT_DIR="Assets\_Project\Docs\DecodeAnalysis\Il2CppDump"

if not exist %OUTPUT_DIR% mkdir %OUTPUT_DIR%

echo Running Il2CppDumper...
%DUMPER_EXE% %IL2CPP_BIN% %METADATA_BIN% %OUTPUT_DIR%

echo Dump complete. Check %OUTPUT_DIR% for dump.cs and DummyDlls.
pause
