# Fidelity UI Cleanup Report

## Overview
This sprint enforces strict source fidelity on the `TownScene` Canvas by removing any layout elements that were assumed or prototyped without concrete evidence from the original game dumps. 

## UI Elements Removed
- Prototype Action Panel (All debug buttons: Collect Wood, Force Raid, Next Time, Assign Worker).

## UI Elements Kept as `TEMPORARY_DEV_UI`
- **Build Buttons (Hut, Storage, GuardTower)**: While construction has a decoded sequence (`DepositResource`, `UpdateConstruction`), the exact UI flow used to trigger this sequence (e.g., clicking a button vs dragging a prefab) is still `UNKNOWN`. These buttons remain active in the scene but are strictly classified as `TEMPORARY_DEV_UI` so development on the building sequence can continue.

## UI Elements with Decode Evidence (`ORIGINAL_CONFIRMED` / `DECODE_EVIDENCE_PARTIAL`)
- **Resource Bars**: Supported by `ResourceData` and matching UI prefabs in `data.unity3d`.
- **Imported Sprites**: Decoded background art and button sprites.

## UI Elements Still `UNKNOWN`
- **Job Assignment Interface**: How the player actually adds villagers to jobs.
- **Save/Load Interface**: How saving is visually triggered from the Town view.

## Risks
- We currently lack a way to assign jobs without using the Editor Debug Tool. This is acceptable for `FidelityMode` adherence.

## Next Recommended Sprint
Sprint 2: Extract real data from `data.unity3d` to populate `buildings.json` and `resources.json`, eliminating fallback numbers.
