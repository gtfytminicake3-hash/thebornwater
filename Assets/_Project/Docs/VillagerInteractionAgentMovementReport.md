# Final Status
VILLAGER_INTERACTION_MODAL_AND_TREE_TARGET_READY_FOR_MANUAL_RETEST

# Files changed
- Assets/_Project/Scripts/Frontend/Views/SelectedVillagerPanelView.cs
- Assets/_Project/Scripts/Frontend/Views/TownRuntimeVisualController.cs
- Assets/_Project/Scripts/Editor/VillagerInteractionTest.cs
- Assets/_Project/Docs/VillagerInteractionAgentMovementReport.md

# UI modal fix
- Modal parent: Modals are now instantiated as direct children of the `SelectedVillagerPanel`'s parent root Canvas (`GetComponentInParent<Canvas>()`), preventing them from being constrained by the right-side info panel's RectTransform.
- Modal anchor/pivot: Uses `AnchorMin = (0.5, 0.5)`, `AnchorMax = (0.5, 0.5)`, `Pivot = (0.5, 0.5)` to explicitly float in the exact center of the screen, completely distinct from the bottom-right corner layout.
- SelectedVillagerPanel buttons removed: `EnsureJobButtons` container generation was completely removed from the right-side info panel. The panel is now shrunken to `(250, 150)` and serves strictly as read-only information display.
- Close behavior: Added explicit `Destroy(go)` behavior inside button listeners to automatically tear down the `JobSelectionModal` immediately after any job selection or Cancel operation.

# Tree target fix
- Search scope: Evaluates target paths via `TownRuntimeVisualController.registry` values and hierarchy transform children retrieved strictly beneath `worldRoot.GetComponentsInChildren<Transform>(true)`. Does not perform global Canvas searches.
- Accept/reject rules: Uses `.ToLowerInvariant().Contains` for `tree`, `wood`, `pine`, and `forest`. Employs explicit string rejections for `btn_`, `button`, `text`, `hud`, `eventlog`, and component-level rejections via `GetComponent<UnityEngine.UI.Button>() != null`.
- Fallback removed: Removed `(200, 100)` prototype fallback entirely. If no real world tree is found, `targetPos` remains unchanged (typically the villager's idle slot or current position), and an `[AGENT_TARGET_MISSING]` log is emitted.
- TREE_TARGET_SELECTED log: Output includes precise identification of candidates: `[TREE_TARGET_SELECTED] villager=<id> target=<key/name> pos=<x,y> source=<registry/worldRoot>`. Rejections are also logged securely.

# Regression guard result
- New Game: Tested clean, 0 compiler errors, 0 runtime exceptions.
- Villager separation: Remains functional, initial index offset overrides standard placement.
- Builder/Hut: Intentionally left untouched, construction logic functions natively.
- Guard/Raid: Wait-on-spawn loops remain isolated, combat targets intact.
- Compile/errors: Verified clean using manual PowerShell gate, no missing references triggered.

# Important note
Do not mark ACCEPTED until user manual retest passes.
