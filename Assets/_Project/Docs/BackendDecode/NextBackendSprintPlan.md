# Next Backend Sprint Plan

1. Migrate fallback data definitions (balance, costs) into ScriptableObjects mimicking `ResourceData` and `BuildingData`.
2. Implement Combat/Raid prototype backend using mapped `MonsterManager` and `GuardTower` logic.
3. Replace discrete `LocalGameBackend` text log with events synced to an actual `AIAgent` or simulated agent pool.
4. Add exploring logic via `ExploringShipData` integration.
