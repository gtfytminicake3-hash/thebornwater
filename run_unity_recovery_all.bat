@echo off
set UNITY_EXE="D:\UnityGame\UnityEditer\6000.3.17f1\Editor\Unity.exe"

echo Running RunAll...
%UNITY_EXE% -projectPath "D:\Tinh\TheBonwater" -batchmode -quit -executeMethod TheBonwater.Rebuild.Editor.RebuildRunAll.RunAll -logFile "D:\Tinh\TheBonwater\Logs\unity_recovery_runall.log"

echo Unity batchmode finished with exit code %ERRORLEVEL%
if %ERRORLEVEL% NEQ 0 (
    echo RunAll failed, trying fallback...
    %UNITY_EXE% -projectPath "D:\Tinh\TheBonwater" -batchmode -quit -executeMethod TheBonwater.Rebuild.Editor.RebuildSceneGenerator.CreateScenes -logFile "D:\Tinh\TheBonwater\Logs\unity_recovery_generate.log"
    %UNITY_EXE% -projectPath "D:\Tinh\TheBonwater" -batchmode -quit -executeMethod TheBonwater.Rebuild.Editor.RebuildVerifier.Verify -logFile "D:\Tinh\TheBonwater\Logs\unity_recovery_verify.log"
)
