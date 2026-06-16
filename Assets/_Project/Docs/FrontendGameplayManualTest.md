# Frontend Gameplay Manual Test Protocol

## Prerequisites
1. Ensure the Unity Editor is running.
2. Select `Tools > Rebuild > Create UI MVP Scenes` from the top menu to rebuild the active canvases.
3. Open `MainMenuScene.unity` and press Play.

## Test Flow Steps

1. **Start New Game**
   - Click `NEW GAME` on the MainMenu screen.
   - *Expected:* Scene transitions directly into `TownScene`.

2. **Confirm ResourceBar**
   - Check the top header panel.
   - *Expected:* Display shows `DAY 1 - MORNING` alongside dynamically loaded capacities (e.g. `WOOD: X / 500`).

3. **Assign Workers (Cycle Test)**
   - Click the `ASSIGN JOB` button multiple times.
   - *Expected:* The game systematically picks the next alive villager and advances their job to the next stage in the predefined job pool array (Idle -> Woodcutter -> Forager -> Miner -> Builder -> Guard -> Idle). Event Log correctly reads "Produces +X / Defense +X". The "No idle villagers available" blocker is fully mitigated.

4. **Advance Time**
   - Click `NEXT TIME`.
   - *Expected:* The Day/Time updates, the `LastAction` text at the bottom updates, and resources increment properly according to the active jobs.

5. **Build Hut & Storage**
   - Click `BUILD HUT` and `STORAGE`.
   - *Expected:* Correct costs subtract based on their definition files. Storage visibly increases total capacity metrics.

6. **Build Guard Tower**
   - Click `GUARD TOWER`.
   - *Expected:* Cost validation runs. If successful, progress tracking begins. The building eventually completes, providing passive defense bonuses visible during Night Raids.

7. **Force Raid (Testing Feature)**
   - Click `FORCE RAID` and hit `NEXT TIME` repeatedly into the Night phase.
   - *Expected:* The Night Raid will 100% trigger, guaranteeing explicit visibility of the damage calculation block without having to retry RNG. The Action Panel Button Layout ensures all buttons are easily accessible and unclipped across two distinct rendering rows.

8. **Confirm EventLog Raid Feedback**
   - Look at the `TASK LOG` on the right side.
   - *Expected:* Night transition explicitly pushes "Night falls." and "Raid check triggered." followed by either "Night is quiet. No raid tonight." or explicit combat logs showing defense blocks and damage numbers.

9. **Confirm HP changes**
    - Trigger a raid with low defense.
    - *Expected:* Villager HP values dynamically decrease, shifting to `DEAD` dynamically when hitting 0.

10. **Save & Load**
    - Click `SAVE`. Then change state (advance time). Click `LOAD`.
    - *Expected:* ALL PANELS instantly revert to the saved state numbers perfectly.

11. **Game Conditions**
    - Advance time aggressively.
    - *Expected:* Either the `OBJECTIVE COMPLETE` green banner triggers by hitting the correct day/hut conditions, or the `GAME OVER` red banner triggers if all villagers die.
