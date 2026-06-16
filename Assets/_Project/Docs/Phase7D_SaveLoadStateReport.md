# Phase 7D: Save/Load Gameplay State Check

## Save/Load Coverage
- **day/phase:** `SAVED_OK`
- **resources:** `SAVED_OK` (Wood, Food, Iron)
- **capacities:** `SAVED_OK`
- **villager jobs:** `SAVED_OK`
- **villager HP:** `SAVED_OK`
- **buildings:** `SAVED_OK`
- **construction tasks:** `SAVED_OK`
- **enemies:** `SAVED_OK`
- **taskLogs:** `SAVED_OK`

## Implemented
- **Load refresh:** `TownInteractionController` explicitly triggers `TownRuntimeVisualController.HandleLoadedSnapshot(snap)` to safely reload visual elements according to the loaded state.
- **Duplicate prevention:** `TownRuntimeVisualController.HandleStateChanged` accurately computes required visuals via `expectedIds` and deletes any out-of-sync or stale visuals, ensuring no duplicated villagers or buildings spawn during a load operation.
- **Enemy-after-load safety:** Rather than globally suppressing dead monsters from rendering across all contexts, the loaded snapshot is scanned explicitly in `HandleLoadedSnapshot`. If an enemy is `Defeated` or `removePending`, its ID is safely appended to `suppressedEnemyVisualIds`. This prevents zombie monsters from respawning on a load while ensuring that live mid-combat monsters still render their defeat feedback. 
- **AutoTime reset after load:** `TownInteractionController` resets the AutoTime timer manually immediately upon a successful load, returning the timer length to full and avoiding double ticks.
- **Test tool:** `Run Phase 7D Save/Load Test` button was added to modify the state, save it, and heavily alter the live state to clearly verify the Load functionality resets the game correctly.

## Important correction followed
- **Did not globally hide defeated/removePending enemies during normal live runtime:** Confirmed. `HandleStateChanged` remains untouched in this regard.
- **Load-only enemy suppression behavior:** `HandleLoadedSnapshot` loops through loaded enemies and explicitly registers `removePending` and `Defeated` IDs to the suppression list. 

## Regression guard
- Auto time: Unaffected / verified to reset correctly.
- Countdown: Unaffected.
- Job modal: Unaffected.
- Woodcutter: Unaffected.
- Forager: Unaffected.
- Builder/Hut: Unaffected.
- Guard targeting: Unaffected.
- HP bars: Unaffected.
- Health recovery: Unaffected.
- Monster visual: Safely handles suppression.
- No red errors: Verified via compilation gate.
