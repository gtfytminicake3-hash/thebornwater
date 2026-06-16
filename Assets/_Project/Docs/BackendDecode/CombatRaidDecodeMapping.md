# Combat Raid Decode Mapping

This document maps the evidence found in `libil2cpp.so` to the current fallback implementation.

## 1. MonsterManager
- **Original Signature:** `MonsterManager : MonoBehaviour`
- **Fallback Implementation:** Incorporated into `LocalGameBackend.cs` as `ProcessRaidCheck()`. Instead of a continuous Monobehaviour, it is evaluated synchronously during Time Shift. 
- **State Data:** Managed via `List<EnemyState> enemies` inside `GameSnapshot`.

## 2. AIAgent / CharacterManager
- **Original Signature:** `AIAgent`, `CharacterManager`
- **Fallback Implementation:** Villagers are simply `VillagerSnapshot` entries. HP and jobs are stored statically. Combat does not involve pathfinding (NavMesh). Damage is subtracted directly from the first valid `VillagerSnapshot`.

## 3. SpawnTitan
- **Original Signature:** `SpawnTitan`
- **Fallback Implementation:** Fallback to random chance logic (`Random.value > 0.5f`) when the `Night` phase begins.

## 4. GuardTower
- **Original Signature:** `GuardTower`
- **Fallback Implementation:** Added `GuardTower` to `buildings.json`. Processed centrally in `LocalGameBackend.cs` `GetSnapshot()` to increase `totalDefense` by 15 per count.

## 5. DayNightController
- **Original Signature:** `DayNightController`
- **Fallback Implementation:** Handled by `LocalGameBackend.ProcessTimeAdvance()`. Evaluates `state.timeOfDay` and triggers events on phase change.
