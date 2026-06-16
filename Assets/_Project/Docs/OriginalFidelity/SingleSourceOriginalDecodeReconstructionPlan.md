# Single Source Original Decode Reconstruction Plan

## Project Goal
To rebuild "The Bonfire 2: Uncharted Shores" strictly and solely from its decoded origin data, extracting the original backend architecture, numeric balance, UI flow, and visual assets without inventing custom mechanics or relying on placeholder playable logic.

## Non-Negotiable Rules
1. **Decode Fidelity Only**: Do not invent gameplay, UI flow, backend behavior, or numbers.
2. **Strict Segregation**: If evidence is missing, use `UNKNOWN`, `MISSING_FROM_CURRENT_DECODE`, or strictly partition the fallback into `PROTOTYPE_FALLBACK` or `DECODE_EVIDENCE_PARTIAL`.
3. **No Fake Originality**: Never claim a prototype fallback as the original game loop. Never use phrases like "UNKNOWN", "UNKNOWN", "UNKNOWN", or "original UNKNOWN" to describe unverified mechanics.
4. **Tooling over Cheats**: Debug features must reside in developer-only tools, never in the player-facing UI.

## Current Work Audit Summary
The project successfully established a foundational Unity pipeline, integrated decoded art/sprites, and mapped the basic C# symbol structure. However, the implementation of the core game loop (`LocalGameBackend`, discrete time phases, instant assignment UI) was built as a playable prototype. This sprint acknowledges those fallbacks and mandates a transition to true fidelity.

## Current Work Disposition Table
*(See `Assets/_Project/Docs/OriginalFidelity/CurrentWorkDispositionTable.csv` for the full breakdown.)*
- **Keep**: Imported original assets, data definition schemas, and multi-step construction state.
- **Rewrite**: Backend runtime loop (move from discrete math to continuous physical simulation), UI routing.
- **Move to Debug Tool**: Action Panel cheat buttons (`+10 WOOD`, `NEXT TIME`, `FORCE RAID`, `ADD RESOURCE`, `SKIP TO NIGHT`, `PROGRESS BUILDING`).
- **Remove**: Mock backend stubs, fake JSON balance numbers.

## Evidence Sources
1. **Asset Bundle Dumps**: `resources/com.xigmaGames.thebonfire2.apk/assets/bin/Data/data.unity3d` (Visuals, Prefabs).
2. **Metadata**: `global-metadata.dat` (Type strings).
3. **Assembly Code**: `libil2cpp.so` (Game logic DLLs extracted via Il2CppDumper to `dump.cs.txt`).
4. **Audio Banks**: `Master.bank`, `Master.strings.bank`.

## Fidelity Labels
- `KEEP_AS_ORIGINAL_CONFIRMED`: Verifiably matches IL2CPP dumps or extracted Unity metadata.
- `KEEP_AS_DECODE_EVIDENCE_PARTIAL`: Structure is known, but exact parameters (like numbers) are missing.
- `PROTOTYPE_FALLBACK`: Invented logic meant only for testing. Must be purged from FidelityMode.
- `UNKNOWN_NEEDS_MORE_DECODE`: Functionality whose source origin is entirely obscured.

## FidelityMode vs PrototypeMode
**FidelityMode**:
- Uses ONLY verified behavior, data, UI, and assets.
- Absolutely NO debug buttons visible.
- If data is unknown, the game must fail gracefully or log missing data, rather than faking it.

**PrototypeMode**:
- Exists strictly to test mechanical connections.
- Cheats (`+10 Wood`, `Skip Time`) are permitted but MUST be sandboxed within the Unity Editor or a hidden `DebugOverlay`.
- Must never be compiled as the "Final Game".

## Debug/Test Tool Policy
To preserve the purity of the UI, all manual overrides must be placed in a **Unity Editor Window** or a developer-only debug script. Any temporary UI required on-screen for testing must be clearly labeled `TEMPORARY_DEV_UI`.
Allowed Tools (Debug Only, `TEMPORARY_DEV_UI`):
- Advance simulation tick
- Skip to Night
- Add test resources
- Assign test builder
- Progress selected construction
- Trigger raid test
- Reset save
- Print current snapshot

## System-by-System Reconstruction Plan

### Building / Construction
- **Evidence needed**: `BuildingData` (cost, size), `BuildingInstance` exact flow.
- **Current status**: `DECODE_EVIDENCE_PARTIAL` (Backend tracks multi-step, but uses fake phase math).
- **Plan**: Require an actual `AIAgent` arriving at the physical grid location to trigger `UpdateConstruction(addedLabour)`.
- **Acceptance Gate**: Building only completes when a physical Builder pathfinds to it and hammers.

### Villager / Job / AIAgent
- **Evidence needed**: `CharacterManager`, `AIAgent` state machine, `JobData`. Original job assignment UI is UNKNOWN. Evidence suggests `JobData` / `AIAgent` / building occupation systems exist, but exact player UI flow needs more decode evidence.
- **Current status**: `PROTOTYPE_FALLBACK` (Villagers are just backend array integers).
- **Plan**: Implement NavMesh/A* grid movement. Villagers must spawn as physical entities.
- **Acceptance Gate**: Villagers walk to assigned locations. Job UI remains UNKNOWN until proven.

### Resource Production
- **Evidence needed**: `ResourceData`, `ResourceInstance`, `DepositResource()`.
- **Current status**: `PROTOTYPE_FALLBACK` (Instant phase math). Resource transport/deposit is DECODE_EVIDENCE_PARTIAL. DepositResource / ResourceInstance / AIAgent evidence exists, but exact delivery sequence and storage interaction are UNKNOWN until call flow or ScriptableObject/prefab evidence is found.
- **Plan**: Investigate call flow for delivery sequence.
- **Acceptance Gate**: Visual resource transport loop matching evidence.

### UI / Frontend Flow
- **Evidence needed**: Original Canvas prefabs, Button routing map.
- **Current status**: `PROTOTYPE_FALLBACK` (Custom Action Panel).
- **Plan**: Remove action panel cheat buttons. Implement original contextual popups if evidence is found. Otherwise mark as UNKNOWN.
- **Acceptance Gate**: UI visually and mechanically matches the original game screens. Testing UI marked `TEMPORARY_DEV_UI`.

### Time / DayNight / Survival
- **Evidence needed**: `DayNightController` constants, `GameBalance` food limits.
- **Current status**: `PROTOTYPE_FALLBACK` (Discrete Morning/Night steps).
- **Plan**: Rewrite into a continuous `Update()` loop tracking time deltas based on decoded values.
- **Acceptance Gate**: Day transitions naturally over real-time parameters from decode.

### Combat / Raid
- **Evidence needed**: `EnemyData`, combat formulas, `CharacterManager` raid spawners.
- **Current status**: `PROTOTYPE_FALLBACK` (Phase math subtraction).
- **Plan**: Extract physical entity collisions.
- **Acceptance Gate**: Monsters physically walk on screen and attack Villagers based on AI flow.

### Save / Load
- **Evidence needed**: `SaveLoadUtility` format.
- **Current status**: `PROTOTYPE_FALLBACK` (Custom JSON).
- **Plan**: Investigate if it uses ES3 or binary. Rewrite if format is found, else keep fallback in `PrototypeMode`.
- **Acceptance Gate**: Save files match the original game's save structure.

### Asset / Scene / Prefab
- **Current status**: `ORIGINAL_CONFIRMED`.
- **Plan**: Continue using `AssetStudio` to dump raw textures and mapping them into Unity.

### Audio
- **Evidence needed**: FMOD Studio banks.
- **Plan**: Extract `Master.bank` via FMOD bank tools to map original SFX events.
- **Acceptance Gate**: Original UI click and ambient sounds play.

### World Runtime Binding
- **Plan**: Connect the physical `TownScene` logic to the reconstructed `DataRepository`.

## Missing Evidence List
*(See `Assets/_Project/Docs/OriginalFidelity/MissingDecodeEvidenceList.md`)*
Key blockers: Exact ScriptableObject balance numbers, exact length of continuous time ticks, exact UI flow for Job assignment, exact Resource delivery sequence.

## Implementation Order
1. **Sprint 1 — Debug Tool Migration & Fidelity UI Cleanup**: Move debug/prototype actions into Unity Editor Tool. Keep player HUD clean from non-original cheat/debug buttons. Label any required testing UI as `TEMPORARY_DEV_UI`.
2. **Phase 2**: Decode/Extract exact Balance/Data definitions from `data.unity3d`.
3. **Phase 3**: Implement continuous `DayNightController` loop.
4. **Phase 4**: Implement physical grid, `AIAgent`, and `NavMesh` movement.
5. **Phase 5**: Connect Resource and Job logic to physical agents.

## Acceptance Gates
- **Phase 1**: No prototype buttons visible on Play without `TEMPORARY_DEV_UI` warning.
- **Phase 2**: `buildings.json` contains real numbers from decode.
- **Phase 3**: Time flows without button clicks.
- **Phase 4**: Entities move on screen.

## What Must Not Be Claimed As Original Yet
- Any numeric value in `balance.json`, `resources.json`, `buildings.json` (Currently fallback).
- The "Morning/Afternoon/Evening/Night" discrete phase system.
- The global resource math subtraction mechanics.
- The Job Assignment player UI flow (UNKNOWN).
- The exact Resource delivery sequence (UNKNOWN).

## Next Immediate Sprint Recommendation
**Sprint 1 — Debug Tool Migration & Fidelity UI Cleanup**
Goal: 
- Move debug/prototype actions into Unity Editor Tool.
- Keep player HUD clean from non-original cheat/debug buttons.
- Keep minimal temporary UI only if needed for testing and label it TEMPORARY_DEV_UI.
- Do not implement new gameplay logic yet.
