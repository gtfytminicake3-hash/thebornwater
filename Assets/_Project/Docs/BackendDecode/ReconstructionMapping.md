# Backend Reconstruction Mapping

## Resource System
- Original evidence: `ResourceData`, `ResourceInstance`, `ResourceProductionBuilding`, `ResourceStorageBuilding`
- Current implementation: `ResourceSystem` mapped implicitly via `LocalGameBackend` (wood, food, iron).
- Gap: The original game uses ScriptableObjects (`ResourceData`) to define resources, and `ResourceInstance` for runtime instances. It also uses explicit `ResourceProductionBuilding` structures.
- Reconstruction action: Create `resources.json` data definitions and structure `LocalGameBackend` to handle dynamic resource lookups based on definition instead of hardcoded `wood`/`food` fields (eventually). For now, annotate existing system.

## Building System
- Original evidence: `BuildingData`, `BuildingInstance`, `HutBuilding`, `BonfireBuilding`, `GuardTower`
- Current implementation: Building count stored in `List<BuildingSnapshot>`.
- Gap: Original game has specific MonoBehaviour classes for distinct building types (`HutBuilding`, `BonfireBuilding`) and generic `BuildingData` config.
- Reconstruction action: Map `BuildingSnapshot` to `BuildingInstance`. Create `buildings.json` to define costs based on `BuildingData` logic.

## Villager System
- Original evidence: `CharacterData`, `CharacterManager`, `AIAgent`, `JobData`, `SkillData`
- Current implementation: `VillagerSnapshot` (Name, HP, Job).
- Gap: The original game separates the data config (`CharacterData`) and the AI logic (`AIAgent`). It has dedicated `JobData` and `SkillData`.
- Reconstruction action: Map jobs dynamically based on `jobs.json` to reflect `JobData`.

## Task System
- Original evidence: Not explicitly named "Task", but `AgentAnimationPlayable`, `OccupantsBuildingUI` suggest tasks are bound to Jobs.
- Current implementation: Hardcoded `BuildHut` task type.
- Gap: Original uses Job logic directly for assignments rather than generic tasks.
- Reconstruction action: Use fallback task logic, annotated as `// Backend Reconstruction Notes: Fallback task logic`.

## Time System
- Original evidence: `DayNightController`
- Current implementation: Custom enum/state shift in `LocalGameBackend`.
- Gap: Unity MonoBehavior vs Backend data.
- Reconstruction action: Continue using custom state shift but annotate it as mapped to `DayNightController` logic.

## Save System
- Original evidence: `SaveLoadUtility`, `SaveFileReader`, `SaveSlotMenu`, `PersistentData`
- Current implementation: Simple JSON serialization of `GameSnapshot`.
- Gap: Original separates files and uses `SaveLoadUtility`.
- Reconstruction action: Rename/refactor Save command to align with `SaveLoadUtility` concept.

## Combat/Raid
- Original evidence: `MonsterManager`, `AIAgent`, `SpawnTitan`, `GuardTower`
- Current implementation: None.
- Gap: Entire system missing.
- Reconstruction action: Add to Next Sprint.

## Exploration
- Original evidence: `ExploringShipData`, `ExpeditionUI`, `SentShipData`, `MapChunk`
- Current implementation: None.
- Gap: Missing ship expedition.
- Reconstruction action: Add to Next Sprint.
