# Phase 8A: Combat Damage Targeting Backend Fix

## Overview
Implemented the backend fix for combat damage targeting during raids, ensuring Guards intercept damage properly instead of the first alive villager in the list (usually Bryn).

## Root Cause Addressed
- **Old Target Selection:** `ProcessRaidCheck` linearly iterated through the villagers list (`foreach(var v in state.villagers) if (v.hp > 0)... break;`) and dealt damage to the first alive villager.
- **Why Bryn was Hit:** Bryn is `v1`, the first element in the snapshot array. As long as Bryn was alive, he absorbed all raid damage regardless of his job.
- **New Target Selection:** The logic now filters alive villagers into two pools: `guards` and `aliveVillagers`. If there is a guard, it randomly selects from the `guards` pool. If no guards exist, it randomly selects from `aliveVillagers`.

## Implemented Features
1. **Guard Intercept Targeting:**
   - Alive villagers with `IsGuardJob()` returning true absorb the raid damage.
   - Non-combatant villagers remain entirely safe if a guard is present.
2. **No-guard Random Targeting:**
   - If no guard is present or alive, the damage falls to a random alive villager using `SelectRaidDamageTarget(aliveVillagers)`.
   - Avoids the previous deterministic "first person in the array dies" flaw.
3. **Dead Guard Ignored:**
   - Victims are strictly filtered by `hp > 0`. Dead guards cannot absorb damage for the town.
4. **HP Clamp:**
   - Damage safely clamped at 0. If `hp <= 0`, job becomes `Idle` and state `Dead`.
5. **Diagnostics & Logging:**
   - Replaced old damage logs with clear player-facing logs based on intercept status ("Guard [Name] intercepted...").
   - Added `[COMBAT_TARGETING]` and `[COMBAT_DAMAGE]` RuntimeTrace diagnostics.
6. **Test Tool:**
   - Added `Run Phase 8A Combat Targeting Test` in `TheBonwaterTestToolsWindow`.
   - Automatically assigns V1 as Guard, V2 as Forager, forces Evening, and advances to Night to trigger the raid.

## Visual Sync Confirmed
No changes were needed to `HealthBarView` or `LocalCombatVisualizer`. Because `LocalGameBackend` correctly mutates the target villager's HP in the `GameSnapshot`, the visual layers natively bind to the target during `TownRuntimeVisualController.UpdateVisualState`.
