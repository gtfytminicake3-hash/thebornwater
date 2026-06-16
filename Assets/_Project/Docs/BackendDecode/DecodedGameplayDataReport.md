# Decoded Gameplay Data Report

## 1. Inventory Summary
- Total files scanned: 20 TextAssets.
- Extracted locations: `Assets/_Project/ImportedDecoded/TextAsset/`
- Full inventory at: `Assets/_Project/Docs/BackendDecode/DecodedGameplayDataInventory.csv`

## 2. Findings
- The extraction revealed mostly localization files (e.g. `EnglishText.txt`, `VietnameseText.txt`).
- No generic `buildings.json` or `balance.csv` were found as flat text assets.
- However, string literals extracted directly from `global-metadata.dat` (via Il2CppDumper) contained clear gameplay strings such as:
  - `<BUILDING>`
  - `agent can attack building`
  - `The building has been contructed `
  - `GatherWood`

## 3. Conclusion
- The original game appears to store balance configs and definitions as `ScriptableObject` instances serialized within `data.unity3d`, which could not be perfectly flattened to JSON via the generic unpacker. 
- Therefore, for data definitions, we will reconstruct `resources.json`, `buildings.json`, and `jobs.json` manually with `source: prototype_fallback` and `confidence: HIGH` based on the symbol evidence found in `dump.cs` (e.g., `BuildingData`, `ResourceData`, `JobData`).
