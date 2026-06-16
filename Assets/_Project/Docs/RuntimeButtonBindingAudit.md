# Runtime Button Binding Audit

## Scope
Review of active runtime buttons to ensure clarity, proper backend command binding, and absence of generic/ambiguous labels.

## Findings
| Button | Current Label | Command Bound | Status |
|--------|---------------|---------------|--------|
| `btnBuildHut` | `BUILD HUT (-50 W)` | `BuildHutCommand` | Valid |
| `btnBuildStorage` | `BUILD STORAGE (-75 W)` | `BuildStorageCommand` | Valid |
| `btnBuildGuardTower` | `BUILD GUARD TOWER (-100 W)` | `BuildGuardTowerCommand` | Valid |
| `btnAssignWorker` | `ASSIGN JOB` | `AssignWorkerCommand` | Valid (PROTOTYPE_FALLBACK_JOB_UI) |
| `btnSave` | `SAVE` | `SaveGameCommand` | Valid |
| `btnLoad` | `LOAD` | `LoadGameCommand` | Valid |
| `btnNewGame` | `NEW GAME` | Start New Game Flow | Valid |
| `btnContinue` | `CONTINUE` | Load Existing Save | Valid |

## Assign Job Mechanics
**Note:** `btnAssignWorker` currently cycles through `Idle -> Woodcutter -> Builder -> Guard -> Idle`. This is marked as `TEMPORARY_DEV_UI` and `PROTOTYPE_FALLBACK_JOB_UI` since the original job assignment UI is not yet reconstructed.
