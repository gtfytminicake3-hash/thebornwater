# Decode Backed Backend Inventory

## System: Resources
- Evidence source:
  - IL2CPP class/method/field: `ResourceInstance` (found in il2cpp dump)
  - decoded asset: `wood.png`
  - existing project file: `LocalGameBackend.cs` / `GameSnapshot.cs`
- Status: FALLBACK_REBUILT
- Action:
  - keep existing backend
  - bind UI visual

## System: Buildings
- Evidence source:
  - IL2CPP class/method/field: `IBuilding`, `BonfireBuilding`, `HutBuilding` (found in il2cpp dump)
  - decoded asset: `hut.png`, `house.png`, `guardTower.png`, `Storage.png`
  - existing project file: `LocalGameBackend.cs` / `buildings.json`
- Status: DECODE_BLUEPRINT_PARTIAL
- Action:
  - keep existing backend
  - bind UI visual (render on map)

## System: Construction
- Evidence source:
  - IL2CPP class/method/field: `BuildingInstance.currentCompletion`, `BuildingInstance.finalCompletion`
  - existing project file: `LocalGameBackend.cs` (StartConstruction, UpdateConstruction, FinishConstruction)
- Status: FALLBACK_REBUILT
- Action:
  - keep existing backend

## System: Bonfire / Campfire
- Evidence source:
  - IL2CPP class/method/field: `BonfireBuilding` (found in il2cpp dump at Line 11476)
  - decoded asset: `bonfire.png`
  - existing project file: `town_visual_layout.json`
- Status: DECODE_BLUEPRINT_PARTIAL
- Action:
  - create missing backend (Add Bonfire logic / initial state to GameSnapshot)
  - bind UI visual (render Bonfire dynamically directly on the map, not just layout)

## System: Villagers
- Evidence source:
  - IL2CPP class/method/field: `VillagerManager`, `ICharacterManager`
  - decoded asset: `man 1.png`, `hair 1.png`
  - existing project file: `LocalGameBackend.cs`
- Status: FALLBACK_REBUILT
- Action:
  - keep existing backend

## System: Jobs
- Evidence source:
  - IL2CPP class/method/field: Implicit within `VillagerManager`
  - existing project file: `LocalGameBackend.cs` (Woodcutter, Builder, Guard)
- Status: FALLBACK_REBUILT
- Action:
  - keep existing backend

## System: Day/Night phase
- Evidence source:
  - IL2CPP class/method/field: `TimeManager`, Day Phase cycles
  - existing project file: `LocalGameBackend.cs` (ProcessTimeAdvance)
- Status: FALLBACK_REBUILT
- Action:
  - keep existing backend

## System: Save/Load
- Evidence source:
  - IL2CPP class/method/field: `SaveManager`
  - existing project file: `LocalGameBackend.cs` (Serialize/Deserialize to JSON)
- Status: FALLBACK_REBUILT
- Action:
  - keep existing backend

## System: Build menu
- Evidence source:
  - decoded asset: `build3.png`
  - existing project file: `RebuildSceneGenerator.cs` (currently using text buttons)
- Status: DECODE_BLUEPRINT_PARTIAL
- Action:
  - replace fallback with decode-backed definition (Use `build3.png` as UI icon panel)
  - bind UI visual (OpenBuildMenu / CloseBuildMenu)

## System: Camera / map movement
- Evidence source:
  - IL2CPP class/method/field: `CameraController`
  - existing project file: `TownRuntimeVisualController.cs`
- Status: FALLBACK_REBUILT
- Action:
  - create missing backend (or frontend Map Drag controller)
  - bind UI visual (Pan TownWorldRoot without moving HUD)

## System: Monsters / wolves / enemies
- Evidence source:
  - IL2CPP class/method/field: `MonsterManager` (Line 9514), `MonsterPower` (Line 14431), `MonsterSpawnData` (Line 13585)
  - decoded asset: `Spider_COL_1k.png`, `beastOfBurden.png`
  - existing project file: `EnemyState` in `GameSnapshot.cs`
- Status: DECODE_BLUEPRINT_PARTIAL
- Action:
  - replace fallback with decode-backed definition (Spawn Spider/Beast instead of red boxes)
  - bind UI visual

## System: Raid / Combat
- Evidence source:
  - IL2CPP class/method/field: `MonsterSpawnData`
  - existing project file: `LocalGameBackend.cs` (ForceRaidCommand / Auto-raid logic)
- Status: FALLBACK_REBUILT
- Action:
  - keep existing backend
  - trigger visual spawn based on state

## System: UI icons / build icons
- Evidence source:
  - decoded asset: `build3.png`
- Status: DECODE_BLUEPRINT_PARTIAL
- Action:
  - bind UI visual

## System: World entity visuals
- Evidence source:
  - decoded asset: `tree.png`, `wood.png`, `hut.png`
  - existing project file: `town_visual_layout.json`
- Status: DECODE_BLUEPRINT_PARTIAL
- Action:
  - bind UI visual (Load assets dynamically instead of color fallbacks where available)
