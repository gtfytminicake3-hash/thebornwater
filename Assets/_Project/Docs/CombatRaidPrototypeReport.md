# Combat / Raid Prototype Report

## 1. Final Status
- Status: COMBAT_RAID_V0_1_ACCEPTED
- Reason: The combat/raid prototype has been successfully integrated into the backend. Raid checks run at night, Guard jobs and GuardTower buildings properly contribute to defense and mitigate damage, and game over triggers if all villagers die. Verifier passes 11/11 tests. UI has been updated to reflect new states.

## 2. Decode Evidence Used
- MonsterManager: Inspired the `EnemyState` structure and list of active enemies during a raid.
- SpawnTitan: Influenced the logic for triggering a raid/spawn event on certain phases/conditions (Night phase with chance).
- GuardTower: Added as a buildable `BuildingSnapshot` which contributes +15 defense.
- DayNightController: Used to align the raid check to the transition from Evening to Night (`state.timeOfDay == "Evening"` transitioning to `"Night"`).
- CharacterManager / AIAgent: Influenced the `Guard` job definition and how damage calculation is resolved against individual villager HP.

## 3. Runtime Behavior
- Raid trigger: 50% chance when transitioning to Night phase. Max 1 per day. Avoided if objective is complete or Game Over.
- Enemy state: Represented by `EnemyState` class. Default is `SmallMonster` with 30 HP and 15 Attack.
- Defense: `totalDefense` is calculated dynamically. +10 per alive `Guard`, +15 per completed `GuardTower`.
- Damage: Base damage = 15. Damage taken = max(0, 15 - defense). If > 0, first alive villager takes damage and 10 wood may be lost.
- GameOver: If all villagers' HP reaches 0 due to starvation or raid damage, `isGameOver` is set to true.

## 4. Playability Regression
- Resource loop: PASS
- Building loop: PASS
- Time loop: PASS
- Save/Load: PASS (Enemy states, defense, and lastRaidDay are properly saved and loaded via GameSnapshot)
- Objective: PASS

## 5. Known Fallbacks
- No actual NavMesh or AIAgent instancing. Everything is calculated instantaneously during the AdvanceTime command.
- Attack values and enemy types are hardcoded fallback values for prototyping, as deep scriptable object extraction for exact stats was not within sprint scope.
