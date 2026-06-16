# EndToEnd Smoke Test Report

Smoke test method name: TheBonwater.Rebuild.Editor.EndToEndSmokeTest.Run
Unity command used: "D:\UnityGame\UnityEditer\6000.3.17f1\Editor\Unity.exe" -projectPath "D:\Tinh\TheBonwater" -batchmode -quit -executeMethod TheBonwater.Rebuild.Editor.EndToEndSmokeTest.Run -logFile "D:\Tinh\TheBonwater\Logs\unity_e2e_smoke_pass01.log"
Unity log path: D:\Tinh\TheBonwater\Logs\unity_e2e_smoke_pass01.log

## Actual assertions:
- Backend Initialization
  - Expected: Not Null
  - Actual: Not Null
  - Result: PASS
- Debug Buttons in HUD
  - Expected: True
  - Actual: True
  - Result: PASS

Snapshot before BuildHutCommand:
```json
{
    "day": 1,
    "timeOfDay": "Morning",
    "wood": 100,
    "iron": 0,
    "food": 80,
    "woodCapacity": 250,
    "ironCapacity": 250,
    "foodCapacity": 100,
    "villagers": [
        {
            "id": "v1",
            "name": "Bryn",
            "job": "Idle",
            "hp": 100
        },
        {
            "id": "v2",
            "name": "Alaric",
            "job": "Idle",
            "hp": 100
        }
    ],
    "buildings": [],
    "enemies": [],
    "tasks": [],
    "totalDefense": 0,
    "consecutiveDaysWithoutFood": 0,
    "isGameOver": false,
    "isObjectiveComplete": false,
    "lastAction": "Game started.",
    "taskLogs": [
        "Game started."
    ],
    "lastRaidDay": -1
}
```

Snapshot after BuildHutCommand:
```json
{
    "day": 1,
    "timeOfDay": "Morning",
    "wood": 100,
    "iron": 0,
    "food": 80,
    "woodCapacity": 250,
    "ironCapacity": 250,
    "foodCapacity": 100,
    "villagers": [
        {
            "id": "v1",
            "name": "Bryn",
            "job": "Idle",
            "hp": 100
        },
        {
            "id": "v2",
            "name": "Alaric",
            "job": "Idle",
            "hp": 100
        }
    ],
    "buildings": [],
    "enemies": [],
    "tasks": [
        {
            "id": "f26d81c9-c26c-4951-b8af-6de9beffa8bb",
            "type": "Build_Hut",
            "targetBuildingId": "Hut",
            "status": "AwaitingResources",
            "requiredResources": [
                {
                    "resourceId": "wood",
                    "amount": 50
                }
            ],
            "depositedResources": [],
            "isResourcesComplete": false,
            "currentCompletion": 0,
            "finalCompletion": 100,
            "fidelityClassification": "DECODE_EVIDENCE_PARTIAL",
            "finalCompletionEvidence": "UNKNOWN_OR_MISSING",
            "finalCompletionSource": "UNKNOWN_OR_MISSING",
            "depositSequenceEvidence": "UNKNOWN_DEPOSIT_SEQUENCE"
        }
    ],
    "totalDefense": 0,
    "consecutiveDaysWithoutFood": 0,
    "isGameOver": false,
    "isObjectiveComplete": false,
    "lastAction": "Started construction site for Hut. Awaiting resources.",
    "taskLogs": [
        "Started construction site for Hut. Awaiting resources.",
        "Game started."
    ],
    "lastRaidDay": -1
}
```
- Hut Count Immediate Increase
  - Expected: 0
  - Actual: 0
  - Result: PASS
- Construction Task Creation
  - Expected: Not Null
  - Actual: Not Null
  - Result: PASS
- Task Status
  - Expected: AwaitingResources
  - Actual: AwaitingResources
  - Result: PASS
- Test Deposit Success
  - Expected: True
  - Actual: True
  - Result: PASS

Snapshot after test deposit:
```json
{
    "day": 1,
    "timeOfDay": "Morning",
    "wood": 50,
    "iron": 0,
    "food": 80,
    "woodCapacity": 250,
    "ironCapacity": 250,
    "foodCapacity": 100,
    "villagers": [
        {
            "id": "v1",
            "name": "Bryn",
            "job": "Idle",
            "hp": 100
        },
        {
            "id": "v2",
            "name": "Alaric",
            "job": "Idle",
            "hp": 100
        }
    ],
    "buildings": [],
    "enemies": [],
    "tasks": [
        {
            "id": "f26d81c9-c26c-4951-b8af-6de9beffa8bb",
            "type": "Build_Hut",
            "targetBuildingId": "Hut",
            "status": "UnderConstruction",
            "requiredResources": [
                {
                    "resourceId": "wood",
                    "amount": 50
                }
            ],
            "depositedResources": [
                {
                    "resourceId": "wood",
                    "amount": 50
                }
            ],
            "isResourcesComplete": true,
            "currentCompletion": 0,
            "finalCompletion": 100,
            "fidelityClassification": "DECODE_EVIDENCE_PARTIAL",
            "finalCompletionEvidence": "UNKNOWN_OR_MISSING",
            "finalCompletionSource": "UNKNOWN_OR_MISSING",
            "depositSequenceEvidence": "UNKNOWN_DEPOSIT_SEQUENCE"
        }
    ],
    "totalDefense": 0,
    "consecutiveDaysWithoutFood": 0,
    "isGameOver": false,
    "isObjectiveComplete": false,
    "lastAction": "TEST_TOOL: Deposited resources into Hut. isResourcesComplete: True",
    "taskLogs": [
        "TEST_TOOL: Deposited resources into Hut. isResourcesComplete: True",
        "Started construction site for Hut. Awaiting resources.",
        "Game started."
    ],
    "lastRaidDay": -1
}
```
- Test Progress 1 (50)
  - Expected: 50
  - Actual: 50
  - Result: PASS

Snapshot after test progress:
```json
{
    "day": 1,
    "timeOfDay": "Morning",
    "wood": 50,
    "iron": 0,
    "food": 80,
    "woodCapacity": 250,
    "ironCapacity": 250,
    "foodCapacity": 100,
    "villagers": [
        {
            "id": "v1",
            "name": "Bryn",
            "job": "Idle",
            "hp": 100
        },
        {
            "id": "v2",
            "name": "Alaric",
            "job": "Idle",
            "hp": 100
        }
    ],
    "buildings": [
        {
            "id": "Hut",
            "count": 1
        }
    ],
    "enemies": [],
    "tasks": [],
    "totalDefense": 0,
    "consecutiveDaysWithoutFood": 0,
    "isGameOver": false,
    "isObjectiveComplete": false,
    "lastAction": "TEST_TOOL: Completed Hut.",
    "taskLogs": [
        "TEST_TOOL: Completed Hut.",
        "TEST_TOOL: Added 50 labour to Hut. (100/100)",
        "TEST_TOOL: Added 50 labour to Hut. (50/100)",
        "TEST_TOOL: Deposited resources into Hut. isResourcesComplete: True",
        "Started construction site for Hut. Awaiting resources."
    ],
    "lastRaidDay": -1
}
```
- Hut Completed After Progress
  - Expected: True
  - Actual: True
  - Result: PASS
- Save File Exists
  - Expected: True
  - Actual: True
  - Result: PASS
- Load Preserves Hut Count
  - Expected: 1
  - Actual: 1
  - Result: PASS

Snapshot after save/load:
```json
{
    "day": 1,
    "timeOfDay": "Morning",
    "wood": 50,
    "iron": 0,
    "food": 80,
    "woodCapacity": 250,
    "ironCapacity": 250,
    "foodCapacity": 100,
    "villagers": [
        {
            "id": "v1",
            "name": "Bryn",
            "job": "Idle",
            "hp": 100
        },
        {
            "id": "v2",
            "name": "Alaric",
            "job": "Idle",
            "hp": 100
        }
    ],
    "buildings": [
        {
            "id": "Hut",
            "count": 1
        }
    ],
    "enemies": [],
    "tasks": [],
    "totalDefense": 0,
    "consecutiveDaysWithoutFood": 0,
    "isGameOver": false,
    "isObjectiveComplete": false,
    "lastAction": "Game Loaded (PROTOTYPE_FALLBACK).",
    "taskLogs": [
        "Game Loaded (PROTOTYPE_FALLBACK).",
        "TEST_TOOL: Completed Hut.",
        "TEST_TOOL: Added 50 labour to Hut. (100/100)",
        "TEST_TOOL: Added 50 labour to Hut. (50/100)",
        "TEST_TOOL: Deposited resources into Hut. isResourcesComplete: True"
    ],
    "lastRaidDay": -1
}
```
