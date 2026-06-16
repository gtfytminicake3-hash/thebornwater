# Phase 7C: Health Recovery and Food Effects Completion

## Overview
Implemented Phase 7C package to introduce villager health recovery upon successful food consumption during the Morning upkeep phase.

## Implemented Features
1. **Max HP Constant:**
   - Defined `MaxVillagerHp = 100` and `WellFedHealAmount = 5` in `LocalGameBackend`.
   - Ensures healing does not exceed maximum allowable health without introducing serialization risk to `VillagerSnapshot`.

2. **Well-Fed Recovery:**
   - Integrated into `ProcessDailyUpkeep()`.
   - If food is sufficient to feed the population, 5 HP is granted to every alive villager whose HP is below 100.
   - Villagers with HP <= 0 (Dead) are strictly skipped and do not recover.
   - Mutually exclusive with starvation: villagers either heal +5 HP (enough food) or lose 10 HP (not enough food).

3. **Diagnostics & Event Logging:**
   - Added clear `[HEALTH_RECOVERY]` and `[HEALTH_RECOVERY_SKIP]` trace logs for backend diagnostics.
   - Appends "Villagers ate well and recovered health." and specific name-based logs into the player-facing EventLog when healing occurs.

4. **Test Tools:**
   - Added `Run Phase 7C Health Recovery Test` in `TheBonwaterTestToolsWindow`.
   - Automatically forces a villager's HP to 90 and injects 50 food, instructing the user to transition to Morning to observe the heal effect.

## Manual Test Steps to Verify
1. Enter Play Mode.
2. Go to `Tools -> TheBonwater -> Test Tools` and click `Run Phase 7C Health Recovery Test`.
3. Click "Next Phase (DEV)" until Morning begins.
4. Observe the EventLog confirming the heal and verify the villager's HP bar slightly fills up.
5. Alternatively, allow a raid to damage a villager, ensure food is gathered, and wait for Morning to see the recovery organically.
