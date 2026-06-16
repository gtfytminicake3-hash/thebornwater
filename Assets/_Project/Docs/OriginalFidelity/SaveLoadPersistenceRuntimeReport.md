# Save/Load Persistence Runtime Report

## Save Location
- **Path**: `Application.persistentDataPath + "/local_runtime_save.json"`
- **Format**: JSON serialized via `JsonUtility.ToJson(state, true)`
- **Behavior**: Persistent across Unity restarts.

## Test Procedure & Result
- Tested via `RuntimeBackendTraceTest`.
- Test verifies that a fresh `LocalGameBackend` correctly initializes by reading the existing save file from disk.
- Test verifies that values such as `wood` and `tasks.Count` are accurately deserialized and restored.
- **Status**: PASSED.

## Notes
- `GameSnapshot`, `TaskSnapshot`, `VillagerSnapshot`, `BuildingSnapshot`, `EnemyState`, and `ResourceAmount` are all marked `[Serializable]`.
- The loading logic is safely wrapped in a `try-catch` block that defaults to `NewGame()` if parsing fails.
- Trace events `SAVE_PATH`, `SAVE_READ`, `SAVE_WRITE`, and `LOAD_RESULT` capture all save/load operations in `Logs/runtime_backend_trace.log`.
