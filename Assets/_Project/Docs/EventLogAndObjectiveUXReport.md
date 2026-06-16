# Event Log and Objective UX Report

## Event Log
- Retains and prints exactly the latest 8 events to prevent text overlap and ensure legibility.
- Job changes, resource failures, time advances, and construction progress are printed directly to the log.

## Objective Panel
Now explicitly tracks realtime progress:
```text
Survive to Day 3: 1 / 3
Build Huts: 0 / 2
Villagers alive: 2 / 2
Status: IN_PROGRESS
```
The counts automatically update whenever `OnStateChanged` fires.
