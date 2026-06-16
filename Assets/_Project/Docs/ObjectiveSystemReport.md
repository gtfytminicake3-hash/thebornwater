# Objective System Report

## Overview
The Objective System is now dynamic, reading its state from the `GameSnapshot.objectiveState` instead of using hardcoded string values. 

## Structure
- `surviveToDay`: 3
- `requiredHuts`: 2
- `villagersMustStayAlive`: true
- `status`: "IN_PROGRESS", "COMPLETED", or "FAILED".
- `fidelityLabel`: PROTOTYPE_FALLBACK
- `decodedValueSource`: Objective prototype, not original confirmed

## Behavior
- At the end of every `ProcessTimeAdvance()`, `CheckObjectives()` evaluates the current game state against the requirements.
- If all villagers are dead (`hp <= 0`), the status changes to `FAILED`.
- If `currentDay >= 3`, `hutCount >= 2`, and at least 1 villager is alive, the status changes to `COMPLETED`.
- The `ObjectiveView` UI component listens to `OnStateChanged` and updates the text and color (White = In Progress, Green = Completed, Red = Failed) automatically.
