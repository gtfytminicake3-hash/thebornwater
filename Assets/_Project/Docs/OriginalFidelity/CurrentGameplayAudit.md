# Current Gameplay Audit

This document reviews all current implemented features against decoded evidence to classify them strictly.

## 1. Features classified as DEBUG_ONLY
- **+10 WOOD button**: No evidence of manual clicker mechanics.
- **FORCE RAID**: Developer tool.
- **NEXT TIME**: Real game uses continuous time (`DayNightController.Update()`), not turn-based buttons.

## 2. Features classified as PROTOTYPE_FALLBACK
- **ASSIGN WORKER cycle**: The game currently rotates jobs linearly via a single button. Original UI UNKNOWN had a `JobMenu` or `OccupantsBuildingUI`.
- **Instant Construction**: `Build Hut`, `Build Storage`, `Build GuardTower` instantly complete. Evidence proves original buildings have `UpdateConstruction(addedLabour, agent)`, meaning workers must walk and build.
- **Resource Production**: Currently +N per phase. Original evidence (`ResourceProductionBuilding`, `DepositResource`) indicates physical transport of resources by workers.
- **Save/Load**: Current `JsonUtility` dumps the whole prototype state. Original has dedicated `SaveManager` with specific serialization logic.
- **Objectives**: "Survive Day 3 + 2 Huts" is a mocked prototype goal.

## 3. Features classified as DECODE_EVIDENCE_PARTIAL
- **Food Upkeep / Starvation**: We know villagers eat food and die, but the exact phase or tick is not confirmed.
- **Raid Chance & Defense**: `GuardTower` exists and `SmallMonster` exists. Combat math is currently a fallback placeholder.

## 4. Features classified as ORIGINAL_CONFIRMED
- **Basic Entities**: `HutBuilding`, `ResourceStorageBuilding`, `GuardTower`, `SmallMonster` exist in `dump.cs.txt`.
- **Jobs**: `Woodcutter`, `Builder`, `Guard`, `Miner` exist in IL2CPP symbols.
