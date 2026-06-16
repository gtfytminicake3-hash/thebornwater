import os

docs_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\DecodeAnalysis"

report_content = """# Logic Extraction Report

## Tool Discovery
- Il2CppDumper: 404 Download Error. Using Metadata Strings Fallback.
- Il2CppInspector: NOT FOUND
- AssetRipper: NOT FOUND
- AssetStudio: Downloaded via PowerShell to D:\\Tinh\\TheBonwater\\Tools
- UnityPy: Installed successfully via pip.

## IL2CPP Dump Attempt
- Attempted: YES
- Tool used: Metadata Strings Fallback script (`analyze_metadata_strings.py`) because Il2CppDumper download failed (404).
- Input global-metadata.dat: `D:\\Tinh\\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\\resources\\com.xigmaGames.thebonfire2.apk\\assets\\bin\\Data\\Managed\\Metadata\\global-metadata.dat`
- Output folder: `Assets\\_Project\\Docs\\DecodeAnalysis\\MetadataStrings.csv`
- Result: SUCCESS (Extracted 13064 keyword hits).
- Error if failed: N/A

## Asset Extraction Attempt
- Attempted: YES
- Tool used: UnityPy via python
- Input data.unity3d: `D:\\Tinh\\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\\resources\\com.xigmaGames.thebonfire2.apk\\assets\\bin\\Data\\data.unity3d`
- Output folder: `Assets\\_Project\\ImportedDecoded\\`
- Result: SUCCESS (Extracted 1190 assets, mostly PNGs and Texts).

## Mapping Result
- Systems mapped count: 7
- High confidence: 0
- Medium confidence: 7 (Resource, Building, Villager, Task, Time, Save, Combat mapped from metadata strings)
- Low confidence: 0
- Not found: Explore
"""
with open(os.path.join(docs_dir, "LogicExtractionReport.md"), "w", encoding="utf-8") as f: f.write(report_content)

integration = """# Integration Decision

- **Asset Integration**: Extracted 1190 files into `ImportedDecoded`. Ready to be hooked up to UI generator (`RebuildSceneGenerator.cs`) in the next pass. Currently EXTRACTED_BUT_NOT_INTEGRATED in Scene generator because Unity batchmode cannot run to assign them.
- **Backend Logic**: Mapped 7 Core systems using MEDIUM confidence strings extracted from `global-metadata.dat`.
- **MockData**: Updated `MockData.json` using metadata hit evidences for resources and buildings.
"""
with open(os.path.join(docs_dir, "IntegrationDecision.md"), "w", encoding="utf-8") as f: f.write(integration)

# RebuildStatus.md
status_path = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\RebuildStatus.md"
with open(status_path, "a", encoding="utf-8") as f:
    f.write("\n## Final Integration Pass\n- Extracted 1190 assets via UnityPy\n- Mapped 7 logic systems via metadata string fallback\n- Unity.exe missing, so scene generation blocked.\n")

