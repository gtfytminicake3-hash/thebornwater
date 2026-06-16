# Logic Extraction Report

## Tool Discovery
- Il2CppDumper: 404 Download Error. Using Metadata Strings Fallback.
- Il2CppInspector: NOT FOUND
- AssetRipper: NOT FOUND
- AssetStudio: Downloaded via PowerShell to D:\Tinh\TheBonwater\Tools
- UnityPy: Installed successfully via pip.

## IL2CPP Dump Attempt
- Attempted: YES
- Tool used: Metadata Strings Fallback script (`analyze_metadata_strings.py`) because Il2CppDumper download failed (404).
- Input global-metadata.dat: `D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data\Managed\Metadata\global-metadata.dat`
- Output folder: `Assets\_Project\Docs\DecodeAnalysis\MetadataStrings.csv`
- Result: SUCCESS (Extracted 13064 keyword hits).
- Error if failed: N/A

## Asset Extraction Attempt
- Attempted: YES
- Tool used: UnityPy via python
- Input data.unity3d: `D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data\data.unity3d`
- Output folder: `Assets\_Project\ImportedDecoded\`
- Result: SUCCESS (Extracted 1190 assets, mostly PNGs and Texts).

## Mapping Result
- Systems mapped count: 7
- High confidence: 0
- Medium confidence: 7 (Resource, Building, Villager, Task, Time, Save, Combat mapped from metadata strings)
- Low confidence: 0
- Not found: Explore
