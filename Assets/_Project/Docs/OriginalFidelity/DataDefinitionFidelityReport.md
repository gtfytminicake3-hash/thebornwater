# Data Definition Fidelity Report

To ensure we don't treat invented fallback balance numbers as original truth, all data definitions (`resources.json`, `buildings.json`, `jobs.json`, etc.) must split their evidence into three strict categories:

## 1. Symbol Evidence (`symbolEvidence`)
Confirms the *concept* exists.
- *Example*: `GuardTower` class found in `dump.cs.txt`.

## 2. Behavior Evidence (`behaviorEvidence`)
Confirms *how* it works.
- *Example*: `UpdateConstruction(addedLabour)` proves buildings require labor.

## 3. Balance Evidence (`balanceEvidence`)
Confirms the *exact numbers*.
- *Example*: Wood cost = 50. (Currently, most of our balance data is `PROTOTYPE_FALLBACK` or `UNKNOWN` because we haven't decrypted the exact ScriptableObject values from the APK).

## Action Required
The JSON schema for `Definitions` has been logically updated in this sprint to separate `confidence` into these three buckets. Until balance data is extracted from Unity TextAssets/ScriptableObjects, all numerical costs/damage/health will be tagged `PROTOTYPE_FALLBACK`.
