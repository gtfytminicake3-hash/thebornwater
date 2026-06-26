# Plan Status

PHASE_15D_SCENE_OWNED_WORLDMAP_PANEL_UI_PLAN_READY_FOR_REVIEW

# Read-Only Audit Findings

Based on the read-only audit of the Town Scene and codebase, here is the current status:
1. **HUD / Canvas Hierarchy**: The scene contains `TownUIRoot/SafeAreaRoot/HUDRoot`.
2. **Existing Panels**: The scene contains `SelectedVillagerPanel`, `OptionsScrollArea`, `BlacksmithCraftPanel`, and `BuildMenuPanel` registered under `GameplayUIManager`.
3. **Existing UI Repair Tool**: `EnsureSceneOwnedUIPanels.cs` manages the checking, recreation, and layout verification of all HUD elements in Edit Mode.
4. **Existing Backend Data**: 
   - `WorldMapState` tracks a list of `WorldMapLocationState` and `ExpeditionState` (activeExpeditions).
   - Commands `DiscoverWorldMapLocationCommand` and `DispatchExpeditionCommand` are fully implemented in the simulation layer.
5. **Decoded Assets**: 
   - Sprites for all 12 locations exist in `Assets/_Project/ImportedDecoded/Sprite/` (e.g. `City_Bonfire_2.png`, `NorthernVillage.png`, etc.).
   - Expedition icon exists at `Assets/_Project/ImportedDecoded/Sprite/expedition.png`.
6. **UI Conventions**: The UI uses built-in fonts (`LegacyRuntime.ttf`/`Arial.ttf`), semi-transparent dark backgrounds for panels, and standard layout components (`VerticalLayoutGroup`, `ContentSizeFitter`, `ScrollRect`).

# Proposed Scene-Owned UI Hierarchy

The following hierarchy will be registered in `TownScene.unity` under `TownUIRoot/SafeAreaRoot/HUDRoot`:

* `WorldMapPanel` (Root Panel, RectTransform middle-center anchor, size 800x600, Image background with dark-slate/gray color)
  * `Header` (RectTransform top-stretch, height 50, Image header background)
    * `TitleText` (Text component, value: "WORLD MAP", font size 24, center aligned)
    * `CloseButton` (Button component, anchored top-right, size 40x40, red background, Text component with value "X")
  * `Body` (RectTransform stretch-stretch with top/bottom offsets, HorizontalLayoutGroup)
    * `MapViewport` (RectTransform left-aligned, size 520x480, Image background, Mask/RectMask2D component, ScrollRect component)
      * `MapContent` (RectTransform content container, size 1000x1000, anchored top-left)
        * `Background` (Image component displaying `Sea.png` sprite)
        * `LocationNodes` (RectTransform content root for location button pins)
    * `DetailsPanel` (RectTransform right-aligned, size 250x480, VerticalLayoutGroup with padding and spacing, Image panel background)
      * `LocationNameText` (Text component, size 22, bold, color: white)
      * `LocationTypeText` (Text component, size 14, color: light-gray)
      * `CoordinatesText` (Text component, size 14, color: light-gray)
      * `DiscoveredStatusText` (Text component, size 16, color: green/red)
      * `DangerText` (Text component, size 16, color: orange)
      * `RewardText` (Text component, size 16, color: yellow)
      * `ExpeditionStatusText` (Text component, size 16, color: white)
      * `DiscoverButton` (Button component, Image component blue background, Text component "DISCOVER")
      * `DispatchButton` (Button component, Image component blue background, Text component "DISPATCH EXPEDITION")
  * `Footer` (RectTransform bottom-stretch, height 50, Image footer background)
    * `ActiveExpeditionSummaryText` (Text component, size 16, left-aligned, value: "Active Expeditions: 0")
    * `RefreshButton` (Button component, anchored bottom-right, blue background, Text component "REFRESH")

We also introduce a scene-owned HUD button:
* `WorldMapOpenButton`
  - Positioned inside `BottomActionBar` next to `BtnOpenBuildMenu`.
  - RectTransform anchored bottom-left, size 80x80.
  - Image component displaying `expedition.png` icon (with gray fallback).
  - Button component calling `GameplayUIManager.Instance.ToggleWorldMap()`.

# Files Proposed To Modify

1. **[EnsureSceneOwnedUIPanels.cs](file:///d:/Tinh/TheBonwater/Assets/_Project/Scripts/Editor/EnsureSceneOwnedUIPanels.cs)**:
   - Add creation and validation logic for `WorldMapPanel`, its subcomponents, and the `WorldMapOpenButton` under `BottomActionBar`.
   - Implement an Edit Mode preview generator that populates all 12 location nodes under `LocationNodes` at their defined coordinates as editor placeholders (destroyed/cleared at runtime initialization).
   - Wire serialized references to the `GameplayUIManager` and `TownInteractionController`.
2. **[GameplayUIManager.cs](file:///d:/Tinh/TheBonwater/Assets/_Project/Scripts/Frontend/Views/GameplayUIManager.cs)**:
   - Declare a public reference for `WorldMapPanelView worldMapPanel`.
   - Add toggling methods: `ToggleWorldMap()`, `OpenWorldMap()`, `CloseWorldMap()`.
   - Wire `WorldMapOpenButton` and `CloseButton` listeners in `Start()`.
   - Call `worldMapPanel.UpdateView(snap)` inside `HandleStateChanged(snap)` if active.
3. **[NEW] [WorldMapPanelView.cs](file:///d:/Tinh/TheBonwater/Assets/_Project/Scripts/Frontend/Views/WorldMapPanelView.cs)**:
   - Implement the script managing initialization, location selection state, button events, and view updates.

# Files Explicitly Not To Modify

The following accepted files are locked and will not be modified:
* `BlacksmithCraftPanel`
* `OptionsScrollArea`
* `SelectedVillagerPanel`
* `BuildMenuPanel`
* `Equipment UI`
* `WorldMap / Expedition backend` (data model and handlers are locked)
* `Phase 15D WorldMapPanel` (only planning is being done here)

# Backend Binding Plan

The UI will communicate exclusively with the simulation layer using read-only lookups on the current `GameSnapshot` and command dispatches on the `TownInteractionController`:
- **Read-Only Data**: Query `snap.worldMapState.locations` and `snap.worldMapState.activeExpeditions` to update UI elements.
- **Commands**: Call `TownInteractionController.Instance.ExecuteCommand(cmd)` to execute `DiscoverWorldMapLocationCommand` and `DispatchExpeditionCommand`.
- **UI Synchronization**: Execution automatically fires `OnStateChanged`, updating the active UI view.

# Discover Button Plan

- **Visibility**: Visible when the selected location `isDiscovered == false`.
- **Enabled State**: 
  - Enabled if the selected location is undiscovered AND adjacent to at least one discovered location (Chebyshev distance <= 1).
  - Disabled if not adjacent.
- **Action**: Clicking executes `DiscoverWorldMapLocationCommand { locationId = selectedLocationId }`.

# Dispatch Button Plan

- **Visibility**: Visible when the selected location `isDiscovered == true` AND `id != "home"`.
- **Enabled State**:
  - Enabled if the location is discovered AND is not "home" AND there is at least one available villager in the snapshot (villager `hp > 0` and `isOnExpedition == false`).
  - Disabled otherwise.
- **First-Available-Villager Behavior**: 
  - The UI will loop through `snap.villagers` and pick the first villager matching the criteria: `v.hp > 0 && !v.isOnExpedition`.
- **Action**: Clicking executes `DispatchExpeditionCommand { targetLocationId = selectedLocationId, villagerIds = new List<string> { firstAvailableVillagerId } }`.

# Decoded Asset Usage Plan

- **Location Sprites**: Paths defined in `world_map_definitions.json` (e.g. `City_Bonfire_2.png`, `NorthernVillage.png`, etc.) will be loaded using `BuildMenuRowVisualFactory.LoadSprite` at runtime (supporting system file and asset database loads).
- **Expedition Icon**: `Assets/_Project/ImportedDecoded/Sprite/expedition.png` will be loaded for the HUD open button.
- **Sea Background**: `Assets/_Project/ImportedDecoded/Sprite/Sea.png` will be loaded as the map background.
- **Fallback**: If any sprite fails to load, the UI will fall back to a colored placeholder (e.g. dark gray box for locations, deep blue for background).

# Editor Repair Tool Plan

Inside `EnsureSceneOwnedUIPanels.cs`, we will add a dedicated method `EnsureWorldMapPanel(...)` that:
- Finds or creates the `WorldMapPanel` hierarchy.
- Re-wires components if missing.
- Refrains from modifying or resetting RectTransforms of other accepted panels (such as `BuildMenuPanel` or `SelectedVillagerPanel`).
- Populates `LocationNodes` with temporary Edit Mode buttons mapping the coordinates of the 12 locations to visual offsets.

# Documentation Naming Fix Plan

We will restructure `walkthrough.md` to establish a unified Phase 15 hierarchy:
- Rename the main heading to: `# Master Phase 15 Walkthrough — Expedition / World Map`
- Group the completed content into sub-headings:
  - `## 15A — Decoded World Map Data Foundation`
  - `## 15B — World Map Discovery Logic`
  - `## 15C — Expedition Dispatch Foundation`
  - `## 15D — Scene-Owned WorldMapPanel UI` (to be added upon implementation)
- We will similarly restructure `task.md` to group remaining work items under `15D`.

# Verification Plan

Upon approval, we will verify the implementation using:
1. **Hierarchy Integrity**: Verify `WorldMapPanel` and its subcomponents exist in TownScene in Edit Mode.
2. **HUD Wiring**: Check that the `DEV TOOLS` and `WorldMapOpenButton` appear in HUD and operate correctly.
3. **Play Mode Integration**:
   - Verify selecting location nodes updates the Details Panel details correctly.
   - Verify `DiscoverButton` succeeds on adjacent nodes and updates status.
   - Verify `DispatchButton` picks the first available villager, sets them to expedition, and removes them from the scene.
   - Verify expedition resolution completes and restores previous jobs after Advance Time ticks.
4. **Regression Audits**: Run editor tests and checklist verifications:
   - `dotnet build TheBonwater.sln`
   - `python .agent/scripts/checklist.py`
   - Verify forbidden files are absent (return `False` for all paths).

# Risks / Questions

* **Open Question 1**: Should we clamp map scrolling bounds strictly (preventing dragging outside map limits) or allow elastic boundaries?
  * *Proposed solution*: Standard clamped boundaries to prevent navigation disorientation.
* **Open Question 2**: Should we allow multiple expeditions to the same destination simultaneously, or disable the dispatch button if an expedition is already active to that location?
  * *Proposed solution*: Allow dispatching only if there is no active expedition currently targeting that location to avoid duplicate dispatches.

---

Waiting for approval before implementation. No code has been changed.
