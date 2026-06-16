import os
import json

base_dir = r"d:\Tinh\TheBonwater"

# 1. run_il2cpp_dump.bat
bat_il2cpp = """@echo off
echo =========================================
echo IL2CPP Dumper Automation
echo =========================================
set DUMPER_EXE="D:\\Tools\\Il2CppDumper\\Il2CppDumper.exe"
if not exist %DUMPER_EXE% (
    echo [ERROR] Il2CppDumper.exe not found at %DUMPER_EXE%
    echo Please download Il2CppDumper and update the path in this script.
    pause
    exit /b 1
)

set IL2CPP_BIN="D:\\Tinh\\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\\resources\\config.arm64_v8a.apk\\lib\\arm64-v8a\\libil2cpp.so"
set METADATA_BIN="D:\\Tinh\\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\\resources\\com.xigmaGames.thebonfire2.apk\\assets\\bin\\Data\\Managed\\Metadata\\global-metadata.dat"
set OUTPUT_DIR="Assets\\_Project\\Docs\\DecodeAnalysis\\Il2CppDump"

if not exist %OUTPUT_DIR% mkdir %OUTPUT_DIR%

echo Running Il2CppDumper...
%DUMPER_EXE% %IL2CPP_BIN% %METADATA_BIN% %OUTPUT_DIR%

echo Dump complete. Check %OUTPUT_DIR% for dump.cs and DummyDlls.
pause
"""
with open(os.path.join(base_dir, "run_il2cpp_dump.bat"), "w", encoding="utf-8") as f: f.write(bat_il2cpp)

# 2. run_asset_extract.bat
bat_asset = """@echo off
echo =========================================
echo Asset Extraction Automation
echo =========================================
echo This script uses python and UnityPy to extract assets.
python -c "import UnityPy" 2>nul
if errorlevel 1 (
    echo [ERROR] UnityPy is not installed!
    echo Please run: pip install UnityPy
    pause
    exit /b 1
)

python extract_unity_assets.py
pause
"""
with open(os.path.join(base_dir, "run_asset_extract.bat"), "w", encoding="utf-8") as f: f.write(bat_asset)

# 3. extract_unity_assets.py
py_extract = """import os
import sys

try:
    import UnityPy
except ImportError:
    print("UnityPy is not installed. Please run: pip install UnityPy")
    sys.exit(1)

input_file = r"D:\\Tinh\\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\\resources\\com.xigmaGames.thebonfire2.apk\\assets\\bin\\Data\\data.unity3d"
output_dir = r"D:\\Tinh\\TheBonwater\\Assets\\_Project\\ImportedDecoded"

if not os.path.exists(input_file):
    print(f"Error: Input file not found at {input_file}")
    sys.exit(1)

os.makedirs(output_dir, exist_ok=True)
print(f"Loading {input_file}...")
env = UnityPy.load(input_file)

extracted_count = 0
for obj in env.objects:
    if obj.type.name in ["Texture2D", "Sprite", "TextAsset", "Font"]:
        data = obj.read()
        dest = os.path.join(output_dir, obj.type.name, data.name)
        os.makedirs(os.path.dirname(dest), exist_ok=True)
        try:
            if obj.type.name in ["Texture2D", "Sprite"]:
                dest += ".png"
                data.image.save(dest)
            elif obj.type.name == "TextAsset":
                dest += ".txt"
                with open(dest, "wb") as f: f.write(data.script)
            extracted_count += 1
        except Exception as e:
            print(f"Failed to extract {data.name}: {e}")

print(f"Extraction complete! Extracted {extracted_count} assets to {output_dir}")
"""
with open(os.path.join(base_dir, "extract_unity_assets.py"), "w", encoding="utf-8") as f: f.write(py_extract)

# 4. analyze_il2cpp_dump.py
py_analyze = """import os
import json

dump_file = r"D:\\Tinh\\TheBonwater\\Assets\\_Project\\Docs\\DecodeAnalysis\\Il2CppDump\\script.json"
if not os.path.exists(dump_file):
    print(f"Error: {dump_file} not found. Please run run_il2cpp_dump.bat first.")
    exit(1)

print(f"Analyzing {dump_file}...")
with open(dump_file, "r", encoding="utf-8") as f:
    data = json.load(f)

# Sample analysis to find systems
systems = ["Resource", "Building", "Villager", "Task", "Time", "Save"]
found_classes = {}

for cls in data.get("ScriptMethod", []):
    name = cls.get("Name", "")
    for sys in systems:
        if sys in name:
            found_classes[name] = sys

print(f"Found {len(found_classes)} interesting classes:")
for k, v in found_classes.items():
    print(f" - {k} (Probable system: {v})")

print("Analysis complete. Update BackendLogicMap.csv with these findings.")
"""
with open(os.path.join(base_dir, "analyze_il2cpp_dump.py"), "w", encoding="utf-8") as f: f.write(py_analyze)

# Update LogicExtractionReport.md
docs_dir = os.path.join(base_dir, r"Assets\_Project\Docs\DecodeAnalysis")
report_content = """# Logic Extraction Report

## Tool Discovery
- Il2CppDumper: NOT FOUND
- Il2CppInspector: NOT FOUND
- AssetRipper: NOT FOUND
- AssetStudio: NOT FOUND
- UnityPy: NOT FOUND (Python module missing)

## IL2CPP Dump Attempt
- Attempted: YES (Searched local system)
- Tool used: NONE (Missing tools)
- Input libil2cpp.so: `D:\\Tinh\\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\\resources\\config.arm64_v8a.apk\\lib\\arm64-v8a\\libil2cpp.so`
- Input global-metadata.dat: `D:\\Tinh\\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\\resources\\com.xigmaGames.thebonfire2.apk\\assets\\bin\\Data\\Managed\\Metadata\\global-metadata.dat`
- Output folder: `Assets\\_Project\\Docs\\DecodeAnalysis\\Il2CppDump\\`
- Result: FAILED
- Error if failed: No executable tools found in standard paths or PATH. Created `run_il2cpp_dump.bat` to run manually once tool is downloaded.

## Asset Extraction Attempt
- Attempted: YES (Searched for UnityPy/AssetStudio)
- Tool used: NONE (Missing tools)
- Input data.unity3d: `D:\\Tinh\\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\\resources\\com.xigmaGames.thebonfire2.apk\\assets\\bin\\Data\\data.unity3d`
- Output folder: `Assets\\_Project\\ImportedDecoded\\`
- Result: FAILED
- Error if failed: `UnityPy` Python package not installed. Created `extract_unity_assets.py` and `run_asset_extract.bat` to run manually once pip install is done.

## Mapping Result
- Systems mapped count: 0
- High confidence: 0
- Medium confidence: 0
- Low confidence: 0
- Not found: ALL (Pending tool availability)
"""
with open(os.path.join(docs_dir, "LogicExtractionReport.md"), "w", encoding="utf-8") as f: f.write(report_content)

# Update IntegrationDecision.md
integration_content = """# Integration Decision

- **Tool Status**: All required extraction tools (Il2CppDumper, AssetStudio, UnityPy) are missing from the system.
- **UI Assets**: Using Unity standard UI placeholders because extraction failed due to missing tools.
- **MockBackend**: Uses LOW confidence genre-based mock data since C# dump is unavailable.
- **Action Plan**: 
  1. User needs to run `pip install UnityPy` and execute `run_asset_extract.bat`
  2. User needs to download Il2CppDumper and execute `run_il2cpp_dump.bat`
"""
with open(os.path.join(docs_dir, "IntegrationDecision.md"), "w", encoding="utf-8") as f: f.write(integration_content)

# Update RebuildStatus.md
status_path = os.path.join(base_dir, r"Assets\_Project\Docs\RebuildStatus.md")
with open(status_path, "a", encoding="utf-8") as f:
    f.write("\n## Decode Logic Usage (Phase 2)\n- Tool Discovery: Completed (All missing)\n- Extraction Scripts Created: YES\n")

# Update FrontendAssetMap.csv
asset_map = """asset_id,source_path,asset_type,probable_usage,scene_or_ui_guess,import_strategy,placeholder_used,note
main_data,data.unity3d,UnityWebData,All scenes/prefabs,All,TOOL_MISSING,YES,Awaiting UnityPy or AssetStudio installation
audio_bank,Master.bank,FMODBank,Audio,All,FMOD Unity Integration,YES,
audio_strings,Master.strings.bank,FMODStrings,Audio mapping,All,FMOD Unity Integration,YES,
"""
with open(os.path.join(docs_dir, "FrontendAssetMap.csv"), "w", encoding="utf-8") as f: f.write(asset_map)

# Update MockData.json to explicitly include source and confidence for definitions
mock_data = {
    "__metadata": {
        "source": "fallback_placeholder_after_failed_extraction",
        "confidence": "LOW",
        "reason": "Il2Cpp dump unavailable and UnityPy not installed"
    },
    "resources": [
        {"id": "wood", "displayName": "Wood", "amount": 100, "capacity": 500},
        {"id": "food", "displayName": "Food", "amount": 50, "capacity": 200},
        {"id": "coal", "displayName": "Coal", "amount": 0, "capacity": 100},
        {"id": "iron", "displayName": "Iron", "amount": 0, "capacity": 100}
    ],
    "buildings": [
        {"id": "b1", "typeId": "Campfire", "level": 1, "constructionProgress": 100}
    ],
    "villagers": [
        {"id": "v1", "name": "Alaric", "role": "Idle", "health": 100, "currentTaskId": ""},
        {"id": "v2", "name": "Bryn", "role": "Woodcutter", "health": 100, "currentTaskId": ""}
    ]
}
with open(os.path.join(base_dir, r"Assets\_Project\Data\Mock\MockData.json"), "w", encoding="utf-8") as f:
    json.dump(mock_data, f, indent=4)

print("Extraction block scripts and reports generated successfully.")
