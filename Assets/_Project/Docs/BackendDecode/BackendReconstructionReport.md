# Backend Reconstruction From Decode Report

## 1. Final Status
- Status: BACKEND_RECONSTRUCTION_ACCEPTED
- Reason: Il2CppDump was successfully executed on `libil2cpp.so` and `global-metadata.dat`. We extracted 321 game-specific classes and mapped their backend logic to our current systems. Data definitions have been updated with source confidence and evidence. The core game loop remains fully playable without regression.

## 2. IL2CPP Extraction
- Dump attempted: YES
- Tool used: Il2CppDumper v6.7.46 (self-contained win-x64)
- dump.cs: YES (21.3 MB)
- DummyDll: YES (renamed to DummyDll~ to avoid Unity compiler conflicts)
- script.json: YES (59.6 MB)
- Result: SUCCESS

## 3. Decode Evidence
- Class map: `OriginalBackendClassMap.csv` (321 game classes extracted)
- Method map: `OriginalBackendMethodMap.csv` (263 methods)
- Enum map: `OriginalEnumMap.csv` (68 enums)
- Field map: `OriginalFieldMap.csv` (234 fields)
- Gameplay data inventory: `DecodedGameplayDataInventory.csv` (20 localization TextAssets found, data mostly embedded in ScriptableObjects/IL2CPP strings)

## 4. Systems Mapped
- ResourceSystem: mapped from `ResourceData`, `ResourceInstance`
- BuildingSystem: mapped from `BuildingData`, `BuildingInstance`, `HutBuilding`, `BonfireBuilding`
- VillagerSystem: mapped from `CharacterData`, `CharacterManager`, `AIAgent`, `JobData`
- TaskSystem: implicitly mapped via jobs (Fallback prototype used)
- TimeSystem: mapped from `DayNightController`
- SaveSystem: mapped from `SaveLoadUtility`, `SaveFileReader`
- Combat/Raid: Identified `MonsterManager`, `AIAgent`, `SpawnTitan`, `GuardTower` (Pending implementation)
- Exploration: Identified `ExploringShipData`, `MapChunk` (Pending implementation)

## 5. Backend Updated
- Data definitions: `resources.json`, `buildings.json`, `villagers.json`, `jobs.json`, `tasks.json`, `balance.json` created in `Assets/_Project/Data/Definitions/`.
- LocalGameBackend: Code annotated with `// Backend Reconstruction Notes:` header.
- Systems: RebuildVerifier updated to validate IL2CPP dump presence, symbols maps, and definitions.
- Source/confidence/evidence fields: Present in all JSON data definition files.

## 6. Playability Regression
- MainMenu -> TownScene: PASS
- Assign Worker: PASS
- Advance Time: PASS
- Build Hut: PASS
- Save/Load: PASS
- Objective complete: PASS

## 7. Gaps
- Missing original logic: Specific `BuildingInstance` tick systems and native AI agent pathfinding.
- Need deeper dump: Asset bundle ScriptableObject unpacking for `BuildingData` fields (costs, capacities).
- Need manual analysis: Tie `MonsterManager` into a new combat prototype loop.
- Prototype fallback remaining: Task progression and exact balance logic is using the fallback.

## 8. Next Sprint
1. Migrate fallback data definitions into Unity ScriptableObjects mimicking `ResourceData` and `BuildingData`.
2. Implement Combat/Raid backend using mapped `MonsterManager` logic.
3. Replace discrete `LocalGameBackend` text log with events synced to an actual `AIAgent` or simulated agent pool.
