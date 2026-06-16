@echo off
set UNITY_EXE="C:\Program Files\Unity\Hub\Editor\2022.3.10f1\Editor\Unity.exe"
if not exist %UNITY_EXE% set UNITY_EXE="C:\Program Files\Unity\Editor\Unity.exe"

echo Running Verification...
%UNITY_EXE% -projectPath "%~dp0." -batchmode -quit -executeMethod TheBonwater.Rebuild.Editor.RebuildVerifier.Verify
echo Done.
