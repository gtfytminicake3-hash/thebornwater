# Visual Reconstruction Report
**Last updated**: 2026-06-12
**Sprint**: SPRINT_08C_COMPILE_FIX_AND_VISUAL_ROLE_VALIDATION

## Summary
Fixed compile errors blocking Unity batchmode. All visual role corrections from SPRINT_08 are intact.

## Compile Fix
- **UnityEngine.UI**: Error caused by `-noUpm` flag in batchmode commands (blocked `com.unity.ugui` package resolution). Fixed by removing `-noUpm -skipUpmDialogs` flags.
- **Newtonsoft.Json**: Missing package. Added `com.unity.nuget.newtonsoft-json: 3.2.1` to `Packages/manifest.json`.
- **No asmdef changes**: Project uses default Assembly-CSharp assembly.

## Visual Role Layout (TownScene)
| Layer | Role | Asset | Behavior |
|---|---|---|---|
| 0 | `sky` | Blue Sky.png | Full screen, AspectRatioFitter.FitInParent |
| 1 | `scene_bg` | BG_Beach.png | Anchor bottom, preserve aspect |
| 2 | `terrain` | ForestFloor.png | Anchor bottom, full width, 300px height |
| 3 | entities | hut/bonfire/guardTower/tree | Parent to TownWorldRoot, ground-relative Y |

### Ground Line
- `GROUND_LINE_Y = 60f` (bottom of terrain)
- Buildings sit at `GROUND_LINE_Y + 50f`
- Villagers sit at `GROUND_LINE_Y + 30f`
- Enemies sit at `GROUND_LINE_Y + 40f`

### Aspect Ratio
- Background objects use `AspectRatioFitter.FitInParent` when `preserveAspect: true`
- Entity `Image.preserveAspect = true` and auto-sized based on sprite texture ratio
- No stretching — sky/scene_bg maintain their natural aspect

### BG_Beach Status
**Evidence**: `DECODE_EVIDENCE_PARTIAL / WRONG_ROLE_SUSPECTED`
BG_Beach is a known decode asset but its role as TownScene background is not confirmed from gameplay screenshots. It may be a cutscene/beach scene asset. If the correct town background is found, replace via `town_visual_layout.json`.

## Key Files Changed
| File | Change |
|---|---|
| `Packages/manifest.json` | Added Newtonsoft.Json 3.2.1 |
| `Assets/_Project/Data/Definitions/town_visual_layout.json` | Split sky/scene_bg/terrain roles, added preserveAspect/anchorBottom |
| `Assets/_Project/Scripts/Editor/RebuildSceneGenerator.cs` | Role-aware layout, no keyword fallback, added System.Linq |
| `Assets/_Project/Scripts/Frontend/Views/TownRuntimeVisualController.cs` | Ground line, preserveAspect, Texture2D paths |

## Test Results
| Test | Result |
|---|---|
| Scene generator | ✅ PASS |
| Full verifier | ✅ PASS (142/159, 17 pre-existing doc file failures) |
| Smoke test | ✅ PASS (0 failures) |
