# Sprint 11 Runtime Bugfix Log

| Bug ID | Symptom | Repro Steps | Expected | Actual | Root Cause | Fix Applied | Test Result |
|---|---|---|---|---|---|---|---|
| BUG-S11-01 | Save/Load failure is silent | Delete save file, click LOAD in-game | Error is logged to TaskLog UI | Exception handled but UI shows nothing | `LoadGameCommand` inside `LocalGameBackend` did not push to `state.taskLogs` | Added `Log(...)` on success/failure in SaveGameCommand and LoadGameCommand | PASS |
| BUG-S11-02 | Building without resources | Have 0 Wood, click BUILD HUT | Task Log shows "Not enough resources" | Task Log says "Started construction site..." without checking resources | `BuildHutCommand` execution skipped `HasEnoughResourcesToStartConstruction` check | Added resource validation before `StartConstruction` and `Log(...)` failure to UI | PASS |
| BUG-S11-03 | Missing "BUILD" verb | Storage button just says "STORAGE" | Button says "BUILD STORAGE" | Button text missing verb | `BuildMenuView` used "STORAGE" and `RebuildSceneGenerator` used "STORAGE" | Changed logic in `BuildMenuView` and UI generation to prefix with "BUILD" | PASS |
