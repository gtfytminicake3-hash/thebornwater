# World Map UI Test Report

[PASS] Run scene-owned UI repair
[PASS] Confirm WorldMapPanel exists
[PASS] Confirm MapViewport exists
[PASS] Confirm MapContent exists
[PASS] Confirm DetailsPanel exists
[PASS] Confirm WorldMapQAStatusPanel exists
[PASS] DiscoverButton exists in TownScene Edit Mode
[PASS] DiscoverButton activeSelf is true
[PASS] DiscoverButton RectTransform width > 0 and height > 0
[FAIL] DiscoverButton is inside visible WorldMapPanel bounds
[PASS] DiscoverButton text says DISCOVER
[PASS] DispatchButton exists in TownScene Edit Mode
[PASS] DispatchButton activeSelf is true
[PASS] DispatchButton RectTransform width > 0 and height > 0
[FAIL] DispatchButton is inside visible WorldMapPanel bounds
[PASS] DispatchButton text says DISPATCH
[PASS] Confirm WorldMapOpenButton exists
[PASS] Confirm SelectedVillagerPanel exists
[PASS] Confirm OptionsScrollArea exists
[PASS] Confirm BlacksmithCraftPanel exists
[PASS] Confirm BuildMenuPanel exists
[PASS] WorldMapQAStatusPanel activeInHierarchy is true
[FAIL] WorldMapQAStatusPanel is inside WorldMapPanel visible bounds
[PASS] Snapshot location list has elements
[PASS] QA Map Data text is Map Data: 12/12 PASS
[PASS] Initial Visual Status is PENDING
[PASS] Confirm northernVillage selected state set
[PASS] DiscoverButton activeSelf is true when northernVillage selected
[PASS] DispatchButton activeSelf is true when northernVillage selected
[PASS] DiscoverButton is interactable when adjacent
[PASS] DispatchButton is not interactable when undiscovered
[PASS] Discover clicked and succeeded
[FAIL] QA Discover Success text is Discover: Success
[PASS] DiscoverButton is not interactable after discovered
[PASS] DispatchButton is interactable when discovered
[PASS] Dispatch clicked and succeeded
[PASS] QA Dispatch Success text is Dispatch: Success
[PASS] QA Dispatch Duplicate Blocked text is Dispatch: Duplicate Blocked
[PASS] Duplicate dispatch does not increase Active Expeditions
[PASS] QA Visual Status is PASS
[PASS] WorldMapPanel closed
[PASS] ExpeditionResultPanel exists
[FAIL] GameplayUIManager panelExpeditionResult reference bound
[PASS] GameplayUIManager txtResultText reference bound
[PASS] GameplayUIManager btnResultOk reference bound
[FAIL] ExpeditionResultPanel is visible when report is pending
[PASS] ExpeditionResultPanel text matches report
[PASS] Pending reports list is empty in backend after dismiss
[PASS] ExpeditionResultPanel is hidden after dismiss
[PASS] Dispatch home blocked interactable=false
[PASS] Dispatch undiscovered blocked interactable=false
[PASS] Dispatch no villager blocked interactable=false
[PASS] Multi-report visible with count=2
[PASS] After dismiss 1st report, 2nd report shows
[PASS] After dismiss all reports, panel hides
[PASS] Pending reports survive save/load
[PASS] Pending report content preserved after load
[PASS] F10 toggle changes QA panel visibility
[PASS] F10 toggle does not break WorldMapPanel
[PASS] WorldMapPanel reopens after QA toggle
[PASS] Location data still accessible after QA toggle
[PASS] Expedition resolves on time advance
[PASS] Reward not duplicated (wood does not exceed expected range)
[PASS] SelectedVillagerPanel still exists after tests
[PASS] BlacksmithCraftPanel still exists after tests
[PASS] BuildMenuPanel still exists after tests
[PASS] OptionsScrollArea still exists after tests

Total PASS: 61
Total FAIL: 6
