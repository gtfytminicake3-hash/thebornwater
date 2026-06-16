# Debug Tool Migration Report

## Overview
In Sprint 1, all non-original testing and cheating utilities have been stripped from the `TownScene` player HUD. These tools have been centralized into a single developer-facing editor window.

## Buttons/actions removed from player HUD:
- `+10 WOOD` (CollectWoodCommand)
- `FORCE RAID` (ForceRaidCommand)
- `ASSIGN WORKER` (AssignWorkerCommand - exact UI unknown)
- `NEXT TIME` (AdvanceTimeCommand)
- `SAVE` / `LOAD` (SaveGameCommand/LoadGameCommand - UNKNOWN be separate menu)

## Buttons/actions moved to Editor Test Tool:
- Added to `Tools > TheBonwater > Test Tools` (`TheBonwaterTestToolsWindow.cs`):
    - Advance simulation tick
    - Add Test Wood (+10)
    - Add Test Iron (+10)
    - Add Test Food (+10)
    - Assign Test Builder
    - Trigger Raid Test
    - Print Current Snapshot

## Risks
- The game can no longer be "played" rapidly from the Game View without using the new Editor Tool, as time will not advance on its own until `DayNightController` is implemented.
- We cannot fully test the loop outside the Editor. This is expected behavior for `PrototypeMode`.

## Next recommended sprint
Sprint 2: Continuous `DayNightController` implementation to restore natural time flow without debug buttons.
