# DataRepository Report

## Overview
The `DataRepository` serves as a central hub for reading static data configuration from JSON files, decoupling the logic and formulas inside the `LocalGameBackend` from the data constants they depend on.

## Loaded Definitions
The repository currently loads and provides parsed C# models for:
- Resources (wood, food, iron)
- Jobs (Idle, Woodcutter, Forager, Miner, Builder, Guard)
- Buildings (Bonfire, Hut, Storage, GuardTower)
- Enemies (SmallMonster)
- Balance Config
- Objective Config

## JSON Configuration Sources
All JSON sources reside within `Assets/_Project/Data/Definitions/`. 
Each file contains specific definitions following the evidence, confidence, and source guidelines strictly.
- `resources.json`: Sourced largely from IL2CPP data dump metadata representing `ResourceData`.
- `buildings.json`: Derived from structures such as `GuardTower` and `HutBuilding` present in the IL2CPP decompilation.
- `jobs.json`: Driven by references like `JobData` and `OccupantsBuildingUI`.
- `enemies.json`: Representing early values extracted/inspired by `MonsterManager` and `SpawnTitan`.
- `balance.json` and `objectives.json`: Marked as prototype fallbacks to structure the system fully until proper scriptable objects are decompiled.

## Implementation Details
`DataRepository.cs` parses the files on startup. `LocalGameBackend` fetches specific properties (e.g., `repo.GetJob("Woodcutter")?.productionPerPhase`) using standard LINQ matching or retrieves flat structs (e.g., `repo.Balance.raidChanceAtNight`). This completes the `DataRepository` phase.
