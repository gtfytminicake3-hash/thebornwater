# Phase 7B-Fix and Phase 8A: Combat Feedback Completion

## Overview
Implemented a subset of visual and logic improvements focusing on time display, health bars, realtime combat feedback, and immediate guard return logic.

## Implemented Features
1. **Time Display:**
   - Modified `AutoTimeController` to expose `TimeRemaining` and `IsRunning`.
   - Updated `TopResourceBarView` with a Unity `Update()` loop to append the remaining countdown to the current day/phase text format.
   - Triggers `[TIME_DISPLAY_BOUND]` when attached.

2. **HP Bars:**
   - Created `HealthBarView.cs`.
   - Dynamically instantiated and attached to both villagers and monsters in `TownRuntimeVisualController`.
   - Initializes with snapshot `hp` but caches as `maxHp`. If the snapshot `hp` is 0 (as is often the case with instant backend raids), falls back to `20` for enemies or `100` for villagers to provide a base for visual depletion.

3. **Realtime Combat Feedback:**
   - Created `LocalCombatVisualizer.cs`.
   - Iterates through `VillagerAgentView` guards tracking their targets.
   - When a guard's `targetId` points to a monster and `visualState` is `Working`, triggers a 2.0-second combat interpolation sequence.
   - Depletes both `HealthBarView` targets from their `maxHp` down to the final `hp` reported by the snapshot (typically 0 for enemies).
   - Once completed, locally destroys the monster visual GameObject.

4. **Guard Return Home:**
   - Modified `VillagerAgentView` to cache `homePosition` during `Awake()`.
   - Added `ReturnHome()` which resets `targetId` to `home` and `currentTarget` to the `homePosition`.
   - Called by `LocalCombatVisualizer` the instant the combat sequence finishes.

5. **Enemy Visual Suppression:**
   - Created `suppressedEnemyVisualIds` HashSet in `TownRuntimeVisualController`.
   - `LocalCombatVisualizer` adds defeated enemy IDs to this set.
   - `TownRuntimeVisualController.Initialize` skips creating visuals for suppressed IDs, preventing the backend's `removePending=true` enemies from reappearing until the next phase clears them entirely.

## Tests & Verification
- Compile logs verified clean.
- Manual test suite defined.
- Run New Game and wait for Night raid, verify combat ends within 2-3 seconds instead of waiting for Morning.
