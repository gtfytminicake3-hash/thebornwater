# Phase 7E: Building Effects & Capacity Report

- **Hut:** Increases max population by +2.
- **Storage:** Increases wood, food, and iron capacity by 150, 100, and 100 respectively.
- **GuardTower/GuardPost:** Confirmed that it adds 15 defense each (existing logic was verified and kept intact).
- **Resource Caps:** Production correctly uses `Mathf.Min(capacity, ...)` to clamp all resource gathering (Woodcutter, Forager, Miner).
- **UI & HUD:** `TopResourceBarView` correctly calculates and displays real capacities dynamically (e.g., `WOOD: 200 / 250`, `POP: 2 / 4`).
- **Save/Load behavior:** Since capacities and defense are derived on-the-fly inside `GetSnapshot()`, they are always perfectly synchronized immediately after load.
