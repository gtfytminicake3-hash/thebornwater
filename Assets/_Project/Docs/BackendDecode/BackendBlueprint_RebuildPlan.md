# Backend Blueprint Rebuild Plan

## 1. Goal
Rebuild LocalGameBackend according to the exact class, field, and method signatures found in the Il2Cpp dump.

## 2. Resource System
- Implement `ResourceData` (capacity, type) and `ResourceInstance` (current amount).
- Add `DepositResource` methods based on the dump.
- Values for max capacity remain PROTOTYPE_FALLBACK.

## 3. Building/Construction System
- Implement `BuildingDetails` (labourRequiredToBuild, resourceRequired) and `BuildingInstance` (currentCompletion).
- Build commands now create a construction instance.
- Need workers to add labour to construction.

## 4. Villager/Job System
- Implement `CharacterData`, `AIAgent`, `JobData`.
- Map jobs (builder, gatherer, guard) properly.

## 5. DayNight / Combat System
- Implement `DayNightController` (progression).
- Implement `MonsterManager` (raid chance logic).

## 6. Save/Load
- Refactor `GameSnapshot` to match `SaveData` schema closely (including list of placed buildings, resources, day time).
