# Fidelity Mode Plan

## Concept
We introduce two conceptual modes for the project:
1. **FidelityMode**: Strict adherence to original-confirmed behavior.
2. **PrototypeMode**: Allows fallback/debug mechanics for testing core loops.

## Feature Restrictions in FidelityMode

### +10 WOOD / NEXT TIME / FORCE RAID
- **PrototypeMode**: Allowed (currently on screen).
- **FidelityMode**: Disabled completely. Will be moved to a hidden `DebugOverlay`.

### Assign Worker
- **PrototypeMode**: Allowed via single-button cycle.
- **FidelityMode**: Must use the original UI job assignment flow (UNKNOWN a popup list of workers and jobs).

### Building Construction
- **PrototypeMode**: Instant completion upon pressing Build.
- **FidelityMode**: Must spawn a construction site, await resource delivery, and require a Builder unit to hammer it to completion.

### Save / Load
- **PrototypeMode**: Manual buttons using JSON.
- **FidelityMode**: Auto-save triggers matching original timing (e.g. dawn), utilizing original data serialization structures if decoded.
