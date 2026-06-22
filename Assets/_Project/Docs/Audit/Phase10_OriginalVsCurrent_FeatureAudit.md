Fix Phase 10A final placement/worksite blockers. Do not add new gameplay systems.

Project path:

```text id="luel3o"
D:\Tinh\TheBonwater
```

Current status:

```text id="w64q7v"
PHASE_10A_FINAL_BLOCKERS_READY_FOR_MANUAL_TEST
USER_MANUAL_TEST_FAILED_BUILD_PLACEMENT_AND_WORKSITE_POSITION
```

# User confirmed

These are okay or mostly okay:

```text id="uidbmp"
- mine_1 / forage_1 now appear in Play.
- default Builder behavior appears.
- no major red compile blocker reported in this latest test.
```

# Current blockers

```text id="h3xaz1"
1. mine_1 / forage_1 still reset to old/default position when entering Play.
2. Build placement mode exists but UX is wrong:
   - click building starts ghost
   - to place/build, user currently has to click the build button again
   - because ghost follows cursor, clicking the build button places the construction at the UI button position
3. After placement/build, villagers do not target the construction to build it.
4. Clicking another build button lifts/restarts ghost again instead of completing the previous placement flow properly.
5. Because building cannot be placed correctly, user cannot test Forge/GuardTower/TowerGuard progression.
```

# Goal

Fix only:

```text id="2rllf3"
- persistent/adopted worksite positions
- correct build placement flow
- construction target after placement
```

Do not add new economy/combat systems.

# Forbidden files

Do NOT touch or recreate:

```text id="jnquu5"
Assets/_Project/Scripts/Editor/MainCanvasSetupTool.cs
Assets/_Project/Scripts/Editor/ForceRunSetup.cs
Assets/Prefabs/MainCanvas.prefab
```

# Fix 1 — mine_1 / forage_1 position must not reset

## Required root cause audit

Find exactly why Play uses old position.

Inspect:

```text id="9zoyfn"
Assets/_Project/Data/Definitions/town_visual_layout.json
Assets/_Project/Data/Definitions/world_objects.json
Assets/_Project/Scripts/Frontend/Views/TownRuntimeVisualController.cs
Assets/_Project/Scripts/Frontend/Views/WorldObjectView.cs
```

Search:

```powershell id="oic35u"
Get-ChildItem -Path "Assets\_Project" -Recurse -File -Include *.cs,*.json |
Select-String -Pattern "mine_1|forage_1|town_visual_layout|SpawnMissingDecorations|preserveManualPlacement|anchoredPosition|localPosition|userPlacements"
```

## Required behavior

```text id="sva19e"
- If mine_1 / forage_1 already exist in scene/hierarchy at Play start, keep their current transform position.
- Register their current visible transform position as the target.
- Do not overwrite scene object position with town_visual_layout.json.
- Only spawn from town_visual_layout.json if the object does not exist at all.
- Miner target must follow the visible mine_1 position.
- Forager target must follow the visible forage_1 position.
```

## If scene objects are not reliable

If Unity scene placement cannot be preserved because runtime rebuilds the world, implement one of these safe approaches:

```text id="rr3hao"
Preferred fallback:
- Add a simple dev-only "Save Worksite Position" path that writes current mine_1 / forage_1 positions into town_visual_layout.json, then runtime uses JSON as source of truth.

Minimum acceptable:
- Clearly document that town_visual_layout.json is source of truth.
- Provide exact JSON fields x/y to edit for mine_1 and forage_1.
- Ensure changing those x/y values actually changes Play position.
```

Do NOT silently reset to old coordinates without a way to update them.

# Fix 2 — Build placement flow must not use build button as confirm

Current UX is wrong.

Required new flow:

```text id="jyufdo"
1. User opens Build Menu.
2. User clicks Hut/Storage/GuardTower/Forge.
3. Build menu may close or stay open, but no resources are spent yet.
4. Placement ghost appears.
5. Ghost follows mouse over world/map only.
6. UI buttons should not act as world placement targets.
7. User clicks on map/world area to choose placement.
8. A small Confirm / Cancel UI appears near bottom or near ghost.
9. Confirm sends BuildCommand with selected x/y.
10. Cancel exits placement and spends nothing.
```

Important:

```text id="j7c8p7"
- Clicking the build menu button again must NOT be required to confirm.
- Clicking any UI button while in placement mode must NOT place the ghost at the UI button coordinate.
- Resources are deducted only on Confirm.
- If placement overlaps UI panel, ignore that click as world placement.
```

Minimal acceptable UI:

```text id="gwfe0d"
- Add two temporary runtime buttons: Confirm and Cancel.
- Or use:
  - left click on world = confirm placement immediately
  - right click / ESC = cancel
But if using left click immediate confirm, it must ignore UI clicks and only accept world/map clicks.
```

Given the user complaint, preferred solution:

```text id="a2x7o"
Use Confirm / Cancel buttons.
World click only moves/selects ghost position.
Confirm button performs build.
```

# Fix 3 — Construction target after placement

Current issue:

```text id="i0nieh"
After placed construction exists, villagers do not target it to build.
```

Required behavior:

```text id="vsalno"
- Confirmed placement creates a construction task with x/y.
- Construction visual appears at chosen x/y.
- Builder villagers target that construction site.
- If multiple builders, they occupy slots around it.
- When construction finishes, completed building remains at chosen x/y.
- Builders return to default Builder idle/standby if no construction remains.
```

Audit:

```powershell id="gk6x0t"
Get-ChildItem -Path "Assets\_Project\Scripts" -Recurse -File -Include *.cs |
Select-String -Pattern "construction|tasks|StartConstruction|FinishConstruction|BuildHutCommand|userPlacements|ResolveWorksiteAnchorForJob|Builder"
```

Likely issue:

```text id="r3padg"
- Backend task has x/y but visual target resolver ignores task placement.
- Or userPlacements key does not match construction id.
- Or BuildCommand with x/y creates building but not construction task correctly.
```

Fix so Builder target uses actual construction visual/transform.

# Preserve

Must preserve:

```text id="k1e42x"
- mine_1 / forage_1 visible in Play
- no None job
- default Builder
- Guard around Bonfire
- TowerGuard at GuardTower
- TowerGuard ranged support
- Steel production
- Forge visual
- Save/Load
- map/zoom
- raid movement static blockers disabled during raid
```

# Compile and log gate

Run:

```powershell id="k5sk6a"
dotnet build TheBonwater.sln
Start-Sleep -Seconds 3
Get-Content "$env:LOCALAPPDATA\Unity\Editor\Editor.log" -Tail 1000 | Select-String "error CS"
Get-Content "$env:LOCALAPPDATA\Unity\Editor\Editor.log" -Tail 1000 | Select-String "MissingReferenceException"
Get-Content "$env:LOCALAPPDATA\Unity\Editor\Editor.log" -Tail 1000 | Select-String "NullReferenceException"
Get-Content "$env:LOCALAPPDATA\Unity\Editor\Editor.log" -Tail 1000 | Select-String "Exception"
```

MainCanvas protection:

```powershell id="alh4g5"
Test-Path "Assets\_Project\Scripts\Editor\MainCanvasSetupTool.cs"
Test-Path "Assets\_Project\Scripts\Editor\ForceRunSetup.cs"
Test-Path "Assets\Prefabs\MainCanvas.prefab"
```

Expected:

```text id="hc3drd"
False
False
False
```

# Required final report format

```text id="5bjiyq"
# Final Status
PHASE_10A_PLACEMENT_AND_WORKSITE_POSITION_READY_FOR_MANUAL_TEST
or
PHASE_10A_PLACEMENT_AND_WORKSITE_POSITION_NEEDS_FIX

# Root Cause
- mine/forage position reset root cause:
- build placement wrong confirm root cause:
- builders not targeting construction root cause:

# Fix 1 — Worksite Position
- source of truth:
- scene position preserved:
- JSON fallback behavior:
- how to edit mine_1 position:
- how to edit forage_1 position:
- Miner target source:
- Forager target source:

# Fix 2 — Placement UX
- build button behavior:
- ghost behavior:
- world click behavior:
- UI click ignored:
- confirm behavior:
- cancel behavior:
- resources spent timing:
- construction x/y:

# Fix 3 — Builder Targeting
- construction created:
- construction visual x/y:
- Builder target source:
- completed building x/y:
- save/load position:

# Files Changed
- file:
  - methods/records changed:
  - reason:
  - risk:

# Regression Protection
- mine/forage visible:
- no None:
- default Builder:
- Steel:
- Forge:
- Guard/TowerGuard:
- Raid:
- Save/Load:
- map/zoom:
- no MainCanvas:

# Test Results
- dotnet build:
- error CS:
- MissingReferenceException:
- NullReferenceException:
- Exception:
- MainCanvas files absent:

# Manual Test Required
1. Edit mine_1 / forage_1 supported source position.
2. Enter Play and confirm they use edited position.
3. Assign Miner/Forager and confirm targets follow visible objects.
4. Click Hut in build menu.
5. Confirm no instant build and no resource spent.
6. Move ghost over map.
7. Click map or set position.
8. Confirm build.
9. Construction appears at chosen position.
10. Builder moves to construction and builds.
11. Completed building remains at chosen position.
12. Cancel placement spends nothing.
13. Trigger raid and confirm Guard reaches monster.
14. No red errors.
```

Do not report ACCEPTED. User will manually test.
