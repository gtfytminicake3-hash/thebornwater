# Phase 7G: Objective / GameOver / Game Status Report

- **New State Tracking:** Inserted `gameStatus` and `objectiveText` strings directly into `GameSnapshot` to manage the core meta-loop of a playthrough.
- **Victory Condition:** Modified `CheckObjectives()` to check if `day >= 3` and `hutCount >= 2`. If so, `gameStatus = "Victory"`. The HUD and logs actively reflect this.
- **Game Over Condition:** If all villagers' HP reach 0, the game triggers `gameStatus = "GameOver"`.
- **UI Alignment:** `TopResourceBarView` dynamically appends the objective text and `[VICTORY]` or `[GAMEOVER]` status to the top UI, remaining clean and accessible without breaking the resource layout.
- **Save/Load Integrity:** The standard Unity JSON Serializer cleanly grabs these new string states, ensuring that quitting out and coming back to a won or lost town will correctly load the game status.
