# Save Schema Alignment Report

The `GameSnapshot` class serves as our surrogate for `SaveData` and `PersistentData`.
It successfully stores lists of `VillagerSnapshot`, `BuildingSnapshot`, `TaskSnapshot` (Construction state), and resources/day-time.
This structure mimics the fields found in the Il2Cpp dump for `SaveData`, enabling full save/load of the vertical slice without relying on simplified mock states.
