# AssetStudioHeadlessProbeReport

## Tool Check
- `AssetStudioGUI.exe --help` output: (GUI likely launched and exited, no CLI help printed)
- `AssetStudioGUI.exe /?` output: (GUI likely launched and exited, no CLI help printed)

## DLL Availability
Checked folder `D:\Tinh\TheBonwater\Tools\AssetStudio`.
Found various DLLs (e.g. AssetStudio.dll, AssetStudioUtility.dll).

## C# Probe Result
Status: `GUI_ONLY_TOOL` / `NO_PUBLIC_EXPORT_API_DOCUMENTED`

AssetStudio.dll can be loaded as a .NET assembly, but writing a custom C# wrapper to load `data.unity3d` and apply DummyDlls programmatically requires reverse engineering the AssetStudio API itself (which has no documentation). 
Without a pre-built AssetStudio CLI or an official API, building a reliable wrapper within this sprint is out of scope and highly error-prone.
