# Phase 7A: Resource, Food, and HUD Loop Completion

## Overview
Implemented the Phase 7A package to complete the core food generation and consumption loop. This prevents the guaranteed starvation scenario by introducing the Forager job, ensuring accurate resource ticks, and clarifying daily upkeep logs.

## Implemented Features
1. **Forager Job Added:**
   - Added `forager` to `jobs.json`.
   - Added "Forager" button to `JobSelectionModal` in `SelectedVillagerPanelView.cs`.
   - Backend `ProcessTimeAdvance` now iterates over villagers. If job is Forager, produces 2 food per phase, capped at `foodCapacity`.

2. **Resource Tick Clarity:**
   - Woodcutter and Forager production explicitly log to the event system using `Log($"{v.name} gathered wood/food +{prod}")`.
   - Traces added: `[RESOURCE_TICK] villager=<id> job=Forager foodDelta=+<n> food=<current>/<capacity>`.

3. **Food Upkeep and Starvation Details:**
   - `ProcessDailyUpkeep` clearly logs `Consumed X food for villagers.` or `Food shortage!`.
   - Traces added: `[FOOD_UPKEEP]` and `[STARVATION]`.
   - If villager HP drops to 0 or below, they are explicitly marked as `v.job = "Idle"` and `v.state = "Dead"`, ceasing further production and preventing ghost labor.

4. **HUD and EventLog Sync:**
   - `TopResourceBarView.cs` correctly formats Wood, Food, and Iron against their capacities.
   - `TaskLogView.cs` renders the latest backend taskLogs automatically on state refresh.

## Manual Test Steps to Verify
1. Start New Game.
2. Click a villager, observe the new "Forager" button in the Job Modal.
3. Assign Forager, close modal.
4. Advance Phase -> Confirm Food value in HUD increases and Event Log displays gathering message.
5. Assign another villager as Woodcutter.
6. Advance Phase -> Confirm Wood value in HUD increases.
7. Advance to next Day -> Confirm Event Log displays "Consumed 10 food for villagers" (assuming 2 villagers).
8. Verify no compiler or runtime errors occur.
