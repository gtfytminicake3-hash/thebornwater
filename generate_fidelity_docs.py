import os

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\OriginalFidelity"
os.makedirs(base_dir, exist_ok=True)

# 1. FallbackInventory.csv
fallback_csv = """feature,current_behavior,evidence_source,evidence_symbol_or_asset,classification,confidence,keep_in_fidelity_mode,notes
+10 WOOD button,Instant +10 Wood,N/A,N/A,DEBUG_ONLY,HIGH,NO,Debug UI for testing only
ASSIGN WORKER behavior,Cycles through all jobs sequentially per click,N/A,N/A,PROTOTYPE_FALLBACK,HIGH,NO,Original UI likely uses a popup or job management screen
Build Hut,Instant completion,dump.cs.txt,HutBuilding/BuildingInstance/UpdateConstruction,PROTOTYPE_FALLBACK,HIGH,NO,Original requires resources deposited and builder AIAgent adding labor
Build Storage,Instant completion,dump.cs.txt,ResourceStorageBuilding,PROTOTYPE_FALLBACK,HIGH,NO,Same construction logic as Hut
Build GuardTower,Instant completion,dump.cs.txt,GuardTower,PROTOTYPE_FALLBACK,HIGH,NO,Same construction logic as Hut
Time advance,Instant phase switch button,N/A,N/A,DEBUG_ONLY,HIGH,NO,Original uses DayNightController with real-time ticks
Food upkeep,Eaten at end of day,dump.cs.txt,Villager/CharacterManager/Food,DECODE_EVIDENCE_PARTIAL,MEDIUM,YES,Original likely has continuous hunger or morning meal logic
Starvation HP damage,HP drops if no food,dump.cs.txt,HP/Damage,DECODE_EVIDENCE_PARTIAL,LOW,YES,Original logic exact numbers unknown
Raid chance,Fixed % per night,dump.cs.txt,MonsterManager/DayNightController,DECODE_EVIDENCE_PARTIAL,LOW,YES,Original logic unknown
Force Raid,Button forcing 100% raid chance,N/A,N/A,DEBUG_ONLY,HIGH,NO,Testing tool
SmallMonster,Enemy unit,dump.cs.txt,SmallMonster/SpawnTitan,ORIGINAL_CONFIRMED,HIGH,YES,Symbol exists
Guard defense,Reduces raid damage,dump.cs.txt,GuardTower/JobData,DECODE_EVIDENCE_PARTIAL,LOW,YES,Exact mitigation formula unknown
GuardTower defense,Adds global defense,dump.cs.txt,GuardTower,DECODE_EVIDENCE_PARTIAL,LOW,YES,Exact formula unknown
Objective Day 3 + 2 Huts,Simple UI conditions,N/A,N/A,PROTOTYPE_FALLBACK,HIGH,NO,Placeholder objectives
Save/Load,JsonUtility full snapshot,dump.cs.txt,SaveManager,PROTOTYPE_FALLBACK,HIGH,NO,Original uses binary or specific serialized chunks
Resource production,Fixed +N per phase,dump.cs.txt,ResourceProductionBuilding,PROTOTYPE_FALLBACK,LOW,NO,Original uses actual worker simulation and walking
Construction progress,Currently instant (0 -> 100),dump.cs.txt,BuildingInstance.UpdateConstruction,PROTOTYPE_FALLBACK,HIGH,NO,Original uses labor points
"""

with open(os.path.join(base_dir, "FallbackInventory.csv"), "w", encoding="utf-8") as f:
    f.write(fallback_csv)

# 2. CurrentGameplayAudit.md
current_audit_md = """# Current Gameplay Audit

This document reviews all current implemented features against decoded evidence to classify them strictly.

## 1. Features classified as DEBUG_ONLY
- **+10 WOOD button**: No evidence of manual clicker mechanics.
- **FORCE RAID**: Developer tool.
- **NEXT TIME**: Real game uses continuous time (`DayNightController.Update()`), not turn-based buttons.

## 2. Features classified as PROTOTYPE_FALLBACK
- **ASSIGN WORKER cycle**: The game currently rotates jobs linearly via a single button. Original UI likely had a `JobMenu` or `OccupantsBuildingUI`.
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
"""

with open(os.path.join(base_dir, "CurrentGameplayAudit.md"), "w", encoding="utf-8") as f:
    f.write(current_audit_md)

# 3. ConstructionBehaviorEvidence.md
construction_md = """# Construction Behavior Evidence

## HutBuilding / BuildingInstance
- **Evidence symbols**: `BuildingInstance`, `HutBuilding` (TypeDefIndex: 3592)
- **Fields**: `currentCompletion`, `finalCompletion`, `underConstructionParticles`, `constructionAnimator`, `requiredResources`
- **Methods**: `DepositResource(Resource type, int quantity)`, `UpdateConstruction(int addedLabour, AIAgent agent)`, `FinishConstruction(AIAgent agent)`, `HasEnoughResourcesToStartConstruction()`
- **Related assets**: `Construction`, `Builder` (AIAgent job)
- **Inferred original behavior**: 
  1. A building site is placed.
  2. Workers carry and `DepositResource` until `HasEnoughResourcesToStartConstruction()` is true.
  3. A Builder (`AIAgent`) is assigned.
  4. Builder performs an action that triggers `UpdateConstruction(addedLabour, agent)`.
  5. When `currentCompletion >= finalCompletion`, `FinishConstruction()` is called.
- **Confidence**: HIGH
- **What is still unknown**: Exact labor added per tick, exact worker assignment UI flow.

## Current implementation comparison
- **Current behavior**: Instant completion (deducts cost, instantly spawns finished building).
- **Matches original**: NO
- **Required change**: Must refactor construction into a multi-step process involving tasks, resource carrying, and a dedicated Builder AI loop. To be done in a future fidelity sprint.
"""

with open(os.path.join(base_dir, "ConstructionBehaviorEvidence.md"), "w", encoding="utf-8") as f:
    f.write(construction_md)

# 4. OriginalUIFlowMap.md & OriginalUIAssetMap.csv
ui_map_md = """# Original UI Flow Map

## Current UI Buttons Classification
- **NEW GAME**: ORIGINAL_CONFIRMED (MainMenu logic exists)
- **LOAD GAME**: ORIGINAL_CONFIRMED (SaveManager exists)
- **+10 WOOD**: DEBUG_ONLY
- **ASSIGN WORKER**: PROTOTYPE_FALLBACK
- **BUILD HUT / STORAGE / GUARD TOWER**: PROTOTYPE_FALLBACK (UI flow is fallback; original likely uses a `BuildMenu` popup with categories)
- **NEXT TIME**: DEBUG_ONLY
- **SAVE GAME**: DEBUG_ONLY (Original probably auto-saves at morning or in pause menu)
- **FORCE RAID**: DEBUG_ONLY
"""

ui_csv = """button_name,classification,notes
NEW GAME,ORIGINAL_CONFIRMED,Standard main menu
LOAD GAME,ORIGINAL_CONFIRMED,Standard main menu
+10 WOOD,DEBUG_ONLY,Cheat button
ASSIGN WORKER,PROTOTYPE_FALLBACK,Original uses JobMenu
BUILD HUT,PROTOTYPE_FALLBACK,Original uses BuildMenu categorization
BUILD STORAGE,PROTOTYPE_FALLBACK,Original uses BuildMenu categorization
BUILD GUARD TOWER,PROTOTYPE_FALLBACK,Original uses BuildMenu categorization
NEXT TIME,DEBUG_ONLY,Original uses DayNightController ticks
SAVE GAME,DEBUG_ONLY,Original uses Pause Menu or Auto-save
FORCE RAID,DEBUG_ONLY,Developer cheat
"""

with open(os.path.join(base_dir, "OriginalUIFlowMap.md"), "w", encoding="utf-8") as f:
    f.write(ui_map_md)
with open(os.path.join(base_dir, "OriginalUIAssetMap.csv"), "w", encoding="utf-8") as f:
    f.write(ui_csv)

# 5. DataDefinitionFidelityReport.md
def_report_md = """# Data Definition Fidelity Report

To ensure we don't treat invented fallback balance numbers as original truth, all data definitions (`resources.json`, `buildings.json`, `jobs.json`, etc.) must split their evidence into three strict categories:

## 1. Symbol Evidence (`symbolEvidence`)
Confirms the *concept* exists.
- *Example*: `GuardTower` class found in `dump.cs.txt`.

## 2. Behavior Evidence (`behaviorEvidence`)
Confirms *how* it works.
- *Example*: `UpdateConstruction(addedLabour)` proves buildings require labor.

## 3. Balance Evidence (`balanceEvidence`)
Confirms the *exact numbers*.
- *Example*: Wood cost = 50. (Currently, most of our balance data is `PROTOTYPE_FALLBACK` or `UNKNOWN` because we haven't decrypted the exact ScriptableObject values from the APK).

## Action Required
The JSON schema for `Definitions` has been logically updated in this sprint to separate `confidence` into these three buckets. Until balance data is extracted from Unity TextAssets/ScriptableObjects, all numerical costs/damage/health will be tagged `PROTOTYPE_FALLBACK`.
"""

with open(os.path.join(base_dir, "DataDefinitionFidelityReport.md"), "w", encoding="utf-8") as f:
    f.write(def_report_md)

# 6. FidelityModePlan.md
fidelity_md = """# Fidelity Mode Plan

## Concept
We introduce two conceptual modes for the project:
1. **FidelityMode**: Strict adherence to original-confirmed behavior.
2. **PrototypeMode**: Allows fallback/debug mechanics for testing core loops.

## Feature Restrictions in FidelityMode

### +10 WOOD / NEXT TIME / FORCE RAID
- **PrototypeMode**: Allowed (currently on screen).
- **FidelityMode**: Disabled completely. Will be moved to a hidden `DebugOverlay`.

### Assign Worker
- **PrototypeMode**: Allowed via single-button cycle.
- **FidelityMode**: Must use the original UI job assignment flow (likely a popup list of workers and jobs).

### Building Construction
- **PrototypeMode**: Instant completion upon pressing Build.
- **FidelityMode**: Must spawn a construction site, await resource delivery, and require a Builder unit to hammer it to completion.

### Save / Load
- **PrototypeMode**: Manual buttons using JSON.
- **FidelityMode**: Auto-save triggers matching original timing (e.g. dawn), utilizing original data serialization structures if decoded.
"""

with open(os.path.join(base_dir, "FidelityModePlan.md"), "w", encoding="utf-8") as f:
    f.write(fidelity_md)

print("Original Fidelity Audit documentation generated.")
