# Backend De-Hardcode Report

## Values Removed from Hardcode
The following values have been successfully moved from `LocalGameBackend.cs` hardcoded variables into the JSON definitions:
- **Resource Start Amounts and Capacities:** (`wood`, `food`, `iron`).
- **Job Production Rates:** (`woodcutter`, `forager`, `miner`).
- **Builder Progress Rate:** Extracted from builder definition `constructionProgressPerPhase`.
- **Building Costs:** Dynamic dictionary lookups via `BuildingDefinition.costs` for `Hut`, `GuardTower`.
- **Building Dependencies:** `constructionRequired` logic replaced hardcoded 100 progress markers.
- **Upkeep Metrics:** `foodConsumptionPerVillagerPerDay` and `starvationHpDamagePerDay`.
- **Combat Stats:** Raid logic retrieves `raidChanceAtNight`, `woodPenaltyOnUnblockedRaid` from Balance configurations, and small monster base variables are sourced from `EnemyDefinition`.
- **Guards and Defense:** Static +10 and +15 defense scores were mapped directly into `JobDefinition` and `BuildingDefinition` properties.
- **Objectives:** `objectiveSurviveDay` and `objectiveRequiredHuts`.

## Fallbacks Still Present
The following areas remain as fallback placeholders:
- Base generic fallback constants via the null coalescing operator (`??`) ensuring the game will not crash or throw exceptions if a specific ID string changes or fails to serialize on initial fetch (e.g. `?? 50` or `?? 10`). These defaults are commented inline (e.g., `// Fallback: 50`).

## Evidence Mapping
- Elements directly supported by IL2CPP decoding evidence were tagged with "HIGH" and "MEDIUM" confidence (resources, buildings, job data).
- The general equilibrium formulas (like hunger drain) or exact monster raid chance curves lack deep serialization exposure in the current dump. Those fields were labeled as `prototype_fallback` with "LOW" confidence to alert future refactoring phases.
