# Original UI Flow Map

## Status Overview
The exact player UI flow and prefab layout of "The Bonfire 2: Uncharted Shores" are currently largely **UNKNOWN** due to missing evidence from Canvas prefabs and UI manager scripts. 

## Known Flow Elements (DECODE_EVIDENCE_PARTIAL)
- **Main Menu**: Evidence confirms `MainMenuScene` exists, with options UNKNOWN routing to "New Game", "Load Game", and "Settings".
- **HUD Elements**: Evidence confirms the existence of `ResourceData` mapping to visual resource bars. 

## Unknown Flow Elements (UNKNOWN / NEEDS_MORE_DECODE)
- **Job Assignment**: Original job assignment UI is **UNKNOWN**. Evidence suggests `JobData` / `AIAgent` / building occupation systems exist, but exact player UI flow needs more decode evidence. We do not know if players click a building and press "Add Worker", or if there is a global "Job Management" panel.
- **Build Menu**: We do not know the exact categorization of the build menu, nor the exact sequence of placing a ghost building.
- **Resource Delivery**: Resource transport/deposit is **DECODE_EVIDENCE_PARTIAL**. `DepositResource` / `ResourceInstance` / `AIAgent` evidence exists, but exact delivery sequence and storage interaction are **UNKNOWN** until call flow or ScriptableObject/prefab evidence is found.
- **Time Controls**: It is **UNKNOWN** if the player can pause, fast-forward, or trigger time jumps via UI, or if time flows completely automatically.

## Interim Plan (FidelityMode & PrototypeMode)
1. Any temporary UI needed for developer testing must be labeled clearly with **`TEMPORARY_DEV_UI`**.
2. Cheats and debug actions (`+10 WOOD`, `FORCE RAID`, `NEXT TIME`) must be migrated to a Unity Editor Tool, not the player HUD.
3. We will not claim any custom UI flow (e.g., the current "Assign Worker" random cycle button) as original.
