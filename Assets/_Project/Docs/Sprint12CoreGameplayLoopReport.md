# Sprint 12 Core Gameplay Loop Report

## Overview
The 3-day core gameplay loop is now fully implemented and testable in the runtime.

## Job & Resource Production
- **Woodcutter**: When time advances, active Woodcutters produce wood (`totalProd = count * 10`). This simulates resource gathering without needing real-time pathfinding AI.
- **Builder**: When time advances, active Builders automatically deposit available global resources into pending construction tasks. Once resources are met, they apply `25` labour points per tick.
- **Guard**: Guards contribute to the `totalDefense` stat when night falls.

## Construction Loop
- Triggering `BuildHutCommand` checks for required resources. If sufficient, a blueprint is placed.
- Builders handle auto-deposit and construction over subsequent time ticks.
- Once completed, the `Hut` count increments and is evaluated by the objective system.

## Day/Night & Raid Loop
- **Time Shift**: Morning -> Afternoon -> Evening -> Night -> Morning.
- **Raid**: At Night, `ProcessRaidCheck()` runs. Evaluates `totalDefense` against the incoming enemy's attack. Logs damage taken.
- **Upkeep**: At Morning, `ProcessDailyUpkeep()` consumes food. If insufficient, villagers take starvation damage.

## Trace Logging (PROTOTYPE_FALLBACK)
Detailed trace logs (`TIME_ADVANCE`, `BUILDER_AUTO_DEPOSIT`, `CONSTRUCTION_PROGRESS`, `CONSTRUCTION_COMPLETED`, `DAILY_UPKEEP`, `RAID_CHECK`, `RAID_RESULT`, `OBJECTIVE_COMPLETED/FAILED`) are now written to `runtime_backend_trace.log` for debugging and analytics.
