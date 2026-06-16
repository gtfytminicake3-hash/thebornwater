@echo off
set UNITY_EXE="C:\Program Files\Unity\Hub\Editor\2022.3.10f1\Editor\Unity.exe"
if not exist %UNITY_EXE% set UNITY_EXE="C:\Program Files\Unity\Editor\Unity.exe"
:: Update the path above if Unity is installed elsewhere

echo Running Scene Generation...
%UNITY_EXE% -projectPath "%~dp0." -batchmode -quit -executeMethod TheBonwater.Rebuild.Editor.RebuildSceneGenerator.CreateScenes
echo Done.
