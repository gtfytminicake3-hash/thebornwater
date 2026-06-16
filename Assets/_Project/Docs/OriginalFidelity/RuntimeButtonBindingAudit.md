# Runtime Button Binding Audit

| UI Location | Button Label | Attached Command | Trace Tested | Status |
|---|---|---|---|---|
| MainMenu | NEW GAME | N/A (Deletes save, LoadScene) | YES | OK |
| MainMenu | CONTINUE | N/A (LoadScene) | YES | OK |
| TownScene | ASSIGN JOB | AssignWorkerCommand | YES | OK |
| TownScene | SAVE | SaveGameCommand | YES | OK |
| TownScene | LOAD | LoadGameCommand | YES | OK |
| TownScene | BUILD HUT | BuildHutCommand | YES | OK |
| TownScene | STORAGE | BuildStorageCommand | YES | OK |
| TownScene | GUARD TOWER | BuildGuardTowerCommand | YES | OK |

## Notes
- All player-facing UI buttons are now instrumented with `RuntimeTrace`.
- Output is written to `Logs/runtime_backend_trace.log`.
- No direct state mutations (e.g., `state.wood += 10`) occur in the UI layer. All buttons map to `GameCommand` executions.
