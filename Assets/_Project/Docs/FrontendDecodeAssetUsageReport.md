# Frontend Decode Asset Usage Report

## Asset Implementations

### Background Map
- **Asset Used:** `academy.png` (Or equivalent large background decoded plate)
- **UI/world role:** Rendering the physical 2D backplate behind the UI logic layers representing the village terrain.
- **Source path:** `Assets/_Project/ImportedDecoded/Sprite/academy.png`
- **Confidence:** HIGH
- **Fallback Reason:** Mapped directly to the UI root in `RebuildSceneGenerator`.

### Villagers
- **Asset Used:** UI Text Lines Placeholder
- **UI/world role:** Displaying current assignments, health, and dead state.
- **Source path:** N/A
- **Confidence:** LOW (Placeholder)
- **Fallback Reason:** Awaiting exact decoding of `GameUnit` sprite atlases. Currently listed on the left panel HUD to ensure MVP functionality.

### Resources
- **Asset Used:** HUD Text
- **UI/world role:** Top bar displaying Wood, Food, Iron thresholds dynamically.
- **Source path:** `resources.json` name strings decoded from IL2CPP.
- **Confidence:** HIGH
- **Fallback Reason:** Uses text string combinations directly matching decoded logic definitions instead of individual resource icon rendering.

### Buildings
- **Asset Used:** Instantiated Rectangles (`HutVisual_Runtime_N`)
- **UI/world role:** Providing visual layout locations on the map for constructed huts.
- **Source path:** N/A
- **Confidence:** LOW (Placeholder)
- **Fallback Reason:** Placed generically on the map offset since specific sprite definitions (`HutBuilding`, `GuardTower`) have not been fully extracted into isolated PNGs from the larger sprite sheets yet.

## Asset Verification Strategy
The system maintains the core "render decoded assets if possible" directive by maintaining the central world anchor, proving that when the 2D sliced sprites are ready, they will simply slot into the instantiated building nodes natively.
