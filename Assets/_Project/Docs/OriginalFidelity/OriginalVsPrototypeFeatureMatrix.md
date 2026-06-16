# Original vs Prototype Feature Matrix

| Feature | Original Decode | Current Prototype Fallback | Action Required for FidelityMode |
| :--- | :--- | :--- | :--- |
| **Game Time** | Continuous loop via `DayNightController` | Discrete phases (Morning/Afternoon/Evening/Night) triggered by `NEXT TIME` | Move discrete time to `PrototypeMode` / `DebugTool`. Implement continuous tick loop based on time delta. |
| **Movement** | `AIAgent` using `NavMesh` or A* on physical 2D grid | Simulated entirely in backend arrays with no physical coordinates | Implement 2D Grid / World bounds and Agent physical pathing. |
| **Construction** | 1. Place site ghost<br>2. `DepositResource`<br>3. `AIAgent` assigns labor<br>4. Reaches `finalCompletion` | Arrays map required resources and `ProcessTimeAdvance` applies global fallback builder logic | Keep new construction logic, but attach it to physical agents and physical resource carrying. |
| **Job Assignment** | Original job assignment UI is UNKNOWN. Evidence suggests `JobData` / `AIAgent` / building occupation systems exist, but exact player UI flow needs more decode evidence. | `ASSIGN WORKER` single button cycles one worker randomly | Remove `ASSIGN WORKER` button. Wait for exact decode evidence. Use `TEMPORARY_DEV_UI` for testing. |
| **Resource Transport** | Resource transport/deposit is DECODE_EVIDENCE_PARTIAL. DepositResource / ResourceInstance / AIAgent evidence exists, but exact delivery sequence and storage interaction are UNKNOWN until call flow or ScriptableObject/prefab evidence is found. | Instant global array addition | Investigate exact delivery sequence from decode. |
| **Combat** | `CharacterManager` spawns physical enemies that walk and attack targets | `ProcessRaidCheck()` uses simple math phase comparison (`attack` vs `totalDefense`) | Remove phase math combat. Implement real `EnemyInstance` logic chasing `VillagerInstance`. |
| **Testing Cheats** | Not present in player UI | `+10 WOOD`, `FORCE RAID`, `NEXT TIME` | Move these entirely to a `Unity Editor Test Tool`. Any test buttons on player UI must be labeled `TEMPORARY_DEV_UI`. |
| **Storage Limits** | Read from `BuildingData` (e.g., `capacityBonus`) | Hardcoded fallback arrays in `LocalGameBackend.cs` | Extract exact limits from ScriptableObjects and bind to `ResourceStorageBuilding` instances. |
