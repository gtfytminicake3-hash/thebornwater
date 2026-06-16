# Sprint 12 Runtime Bugfix Log

| bugId | symptom | reproSteps | expected | actual | rootCause | fixApplied | testResult |
|---|---|---|---|---|---|---|---|
| BUG-S12-01 | Objective text is hardcoded | Open TownScene, look at objective text | Text updates dynamically based on current hut count and day | Text always says "0/2" and uses hardcoded strings | `ObjectiveView.cs` used a hardcoded format string and didn't read `GameSnapshot` objective conditions | Moved `ObjectiveState` into `GameSnapshot` and bound `ObjectiveView` directly to it | PASS |
| BUG-S12-02 | Assigning jobs has no effect on gameplay | Assign a villager to Woodcutter, advance time | Wood increases | Wood remains the same | `ProcessTimeAdvance` had no logic to calculate production per job tick | Added production calculation for `Woodcutter` in `ProcessTimeAdvance` | PASS |
| BUG-S12-03 | Buildings never finish constructing | Place a Hut blueprint, advance time | Hut completes eventually | Hut stays `AwaitingResources` forever | Pathfinding AI is missing, so resources are never deposited | Implemented `BUILDER_AUTO_DEPOSIT` logic in `ProcessTimeAdvance` as a prototype fallback | PASS |
