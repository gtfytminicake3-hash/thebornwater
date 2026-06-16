# Full Backend Rebuild From Dump Report

## 1. Goal
Rebuild the local gameplay backend using the exact class, field, and method signatures found in the Il2Cpp dump.

## 2. Ingestion
Il2Cpp dump files successfully copied to `Assets/_Project/Docs/BackendDecode/Il2CppDump_Full/`.

## 3. MockBackend Usage
`MockBackend` has been verified to NOT be used in the main runtime flow. The primary runtime backend is `LocalGameBackend`.

## 4. Systems Implemented
- **Resource**: Tracked via `wood`, `iron`, `food` in GameSnapshot. DepositResource method implemented.
- **Building/Construction**: `BuildingDetails`, `BuildingData` tracked. `DepositResource`, `UpdateConstruction`, `FinishConstruction` implemented without instant-complete.
- **Villager/Job**: Tracked via `VillagerSnapshot` matching `CharacterData` and `JobData` schemas.
- **Day/Night/Survival**: Handled via `ProcessTimeAdvance` and `ProcessDailyUpkeep`, mapping to `DayNightController` concepts.
- **Combat/Raid**: Handled via `ProcessRaidCheck`, mapping to `MonsterManager` and `Enemy` schemas.
- **Save/Load**: Handled via `SaveGameCommand`, aligning with `SaveData` schema structure.

## 5. Fallbacks
All specific numeric balance values (HP, damage, cost, capacity, time) are `PROTOTYPE_FALLBACK` with `DECODE_EVIDENCE_PARTIAL` labels in definition JSONs.
