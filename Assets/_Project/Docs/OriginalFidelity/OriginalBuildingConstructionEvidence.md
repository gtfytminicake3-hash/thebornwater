# Original Building Construction Evidence

## Overview
This document audits the exact decoded evidence for the Building and Construction systems in "The Bonfire 2: Uncharted Shores" to separate original logic from prototype fallbacks.

## Verified Evidence from IL2CPP Dump
The `dump.cs.txt` reveals the following key classes and methods:

### `BuildingInstance` class
- **ORIGINAL_CONFIRMED**:
  - `currentCompletion` (int) - Tracks the ongoing labor progress.
  - `finalCompletion` (int) - The required total labor to complete the building.
  - `UpdateConstruction(int addedLabour, AIAgent agent)` - Increments construction progress.

### `BuildingData` / `BuildingDetails` classes
- **DECODE_EVIDENCE_PARTIAL**:
  - We know they exist as ScriptableObjects holding the cost, size, and type logic.
  - Exact properties (`labourRequiredToBuild`, `numberOfResourcesRequired`, etc.) are UNKNOWN to exist here but their exact numeric values are currently **UNKNOWN** because they reside in `data.unity3d`.

### Resource Delivery
- **ORIGINAL_CONFIRMED**:
  - `DepositResource(Resource type, int quantity)` - Confirms resources must be deposited incrementally into the building site.
- **UNKNOWN**:
  - The exact global flow of resource delivery. E.g., does a carrier fetch from a `ResourceStorageBuilding` and walk to the `BuildingInstance`?

## Fidelity Labels & Disposition

| Component/Mechanic | Fidelity Label | Notes |
| :--- | :--- | :--- |
| Multi-step Construction | `ORIGINAL_CONFIRMED` | Building spawns unbuilt. Agents deposit resources and add labor. |
| Instant-build | `PROTOTYPE_FALLBACK` | Must be removed from FidelityMode. Replaced by a construction state. |
| `addedLabour` per builder | `UNKNOWN` | Will use fallback numbers marked `PROTOTYPE_FALLBACK` for testing. |
| `finalCompletion` values | `UNKNOWN` | Exact numbers missing. Will use fallback numbers. |
| Deposit delivery sequence | `UNKNOWN` | We will simulate deposit incrementally but the physical carrier sequence is missing evidence. |
