# Verification Report

[PASS] resources.json exists
[PASS] buildings.json exists
[PASS] jobs.json exists
[PASS] enemies.json exists
[PASS] balance.json exists
[PASS] objectives.json exists
[PASS] all records have source/confidence/symbolEvidence
[PASS] all building costs reference valid resources
[PASS] all job production resources reference valid resources
[PASS] enemy definitions have hp/attack
[PASS] balance fields exist
[PASS] DataRepository loads all definitions
[PASS] NewGame initializes resources from definitions
[PASS] Guard job exists
[PASS] Assign Worker can assign Guard
[PASS] Night phase triggers raid check
[FAIL] Raid can spawn enemy state
[PASS] Raid can reduce villager HP
[PASS] Guard reduces raid damage
[PASS] GuardTower or GuardPost increases defense
[PASS] Raid can be repelled with enough defense
[PASS] All villagers dead triggers GameOver
[PASS] Save/Load preserves combat/raid related state
[PASS] Existing resource/build/time/save loop still works
[PASS] Job production uses JobDefinition
[PASS] Build cost uses BuildingDefinition
[PASS] Guard defense uses JobDefinition
[PASS] GuardTower defense uses BuildingDefinition
[PASS] Raid chance reads from BalanceDefinition
[PASS] Enemy attack reads from EnemyDefinition
[PASS] Objective condition reads from definition/balance
[PASS] UI has access to DataRepository definitions
[PASS] Build button labels are generated from BuildingDefinition
[PASS] Villager job effects are generated from JobDefinition
[PASS] Objective text reads objective/balance definitions
[PASS] Resource UI refreshes after commands
[PASS] Villager HP UI refreshes after raid/starvation
[PASS] Building progress UI refreshes after construction tick
[PASS] EventLog shows raid result
[PASS] GameOver/ObjectiveComplete visible in UI
[PASS] Main UI does not show raw JSON
[PASS] MainMenu -> TownScene still works
[PASS] Assign Worker cycles jobs beyond Woodcutter
[PASS] Forager can be assigned from UI
[PASS] Builder can be assigned from UI
[PASS] Guard can be assigned from UI
[PASS] Job effects display from definitions
[PASS] Build buttons include Hut, Storage, GuardTower/GuardPost from definitions
[PASS] Night transition always logs raid check
[PASS] No-raid result is visible when no raid happens
[PASS] Raid result is visible when raid happens
[PASS] EventLog prioritizes raid/starvation/gameover over production spam
[PASS] Manual play flow passes
[PASS] Combat/Raid v0.1 still works
[PASS] FallbackInventory.csv exists
[PASS] CurrentGameplayAudit.md exists
[PASS] ConstructionBehaviorEvidence.md exists
[PASS] OriginalUIFlowMap.md exists
[PASS] DataDefinitionFidelityReport.md exists
[PASS] FidelityModePlan.md exists
[PASS] All current gameplay buttons are classified
[PASS] Debug-only commands identified
[PASS] Build Hut behavior classified
[PASS] No report calls prototype fallback original-confirmed
[PASS] Project still compiles
[PASS] Player HUD has no DEBUG_ONLY buttons
[PASS] Editor Test Tool exists
[PASS] End-to-end smoke test report generated
[PASS] Build command creates construction, not completed building
[FAIL] Main runtime does not auto deposit/progress construction
[PASS] Editor Test Tool can deposit/progress for testing
[PASS] Construction state has fidelity fields
[PASS] Fallback numbers are marked fallback
[PASS] Save/load handles construction state
[PASS] btnCollectWood is not in player-facing HUD
[PASS] FORCE RAID is not in player-facing HUD
[PASS] Advance Time is not in player-facing HUD
[PASS] Editor Test Tool exists
[PASS] Editor Test Tool is under Editor folder or UNITY_EDITOR guarded
[PASS] debug/test actions are classified DEBUG_ONLY
[PASS] temporary UI is classified TEMPORARY_DEV_UI
[PASS] player-facing UI does not claim unknown actions as original
[PASS] GuardTower or GuardPost increases defense
[PASS] Build Hut no longer creates completed Hut immediately in FidelityMode
[PASS] Build Hut no longer creates completed Hut immediately in FidelityMode
[PASS] BuildHutCommand creates a construction task instead of a completed building
[PASS] RuntimeEntityVisualAudit.md exists
[PASS] RuntimeEntityAssetBindingMap.csv exists
[PASS] AnimationLiteRuntimeReport.md exists
[PASS] RuntimeVisualBindingReport.md exists
[PASS] Villager visuals read from GameSnapshot
[PASS] Building visuals read from GameSnapshot/tasks
[PASS] Build Hut does not instant-complete visually
[PASS] Construction progress is visible
[PASS] No MockBackend in runtime player flow
[PASS] No debug buttons in player HUD
[PASS] Project compiles
[PASS] VisualAssetAudit.md exists
[PASS] VisualAssetBindingMap.csv exists
[PASS] TownSceneVisualReconstructionPlan.md exists
[PASS] MainMenuVisualReconstructionPlan.md exists
[PASS] VisualReconstructionReport.md exists
[PASS] TownScene has no debug HUD buttons
[PASS] MainMenu New Game/Continue still bind to backend
[PASS] TownScene HUD still reads GameSnapshot
[PASS] Construction UI still displays progress
[PASS] No MockBackend in runtime player flow
[PASS] Project compiles
[PASS] MainMenu uses LocalGameBackend/GameServiceLocator, not MockBackend
[PASS] TownScene uses LocalGameBackend/GameServiceLocator, not MockBackend
[PASS] player HUD has no +10 resource debug button
[PASS] player HUD has no Force Raid debug button
[PASS] player HUD has no direct fake state mutation
[PASS] resource HUD reads from GameSnapshot
[PASS] construction UI displays TaskSnapshot/progress
[PASS] Build Hut does not instant-complete
[PASS] Save/Load UI binds to backend save/load
[PASS] UI reports exist
[PASS] project compiles
[PASS] Il2Cpp full dump was ingested
[PASS] BackendBlueprint maps exist
[PASS] MockBackend is not used by runtime player flow
[PASS] LocalGameBackend/new backend implements resources
[PASS] building construction is not instant-complete
[PASS] construction state saves/loads
[PASS] villager/job assignment exists
[PASS] day/night progression exists
[PASS] save schema alignment report exists
[PASS] fallback inventory exists
[PASS] no fallback value is marked ORIGINAL_CONFIRMED
[PASS] project compiles
[PASS] AssetStudioHeadlessProbeReport.md exists
[PASS] AvailableReverseToolsInventory.md exists
[PASS] UnityPyRawParsedValueCandidates.csv exists
[PASS] UnityPyRawParseAttemptReport.md exists
[PASS] DeepStaticStringAndBinaryScanReport.md exists
[PASS] NativeDisassemblyNextTargets.csv exists
[PASS] No fallback value was replaced by guessed value
[PASS] AssetStudio manual export instructions exist
[PASS] PriorityObjectsForManualAssetStudioExport.csv exists
[PASS] parse_assetstudio_manual_export.py exists
[PASS] Run_PostAssetStudio_Parse_Command.md exists
[PASS] DecodedDataExtractionInventory.csv exists
[PASS] DecodeDataExtractionReport.md exists
[PASS] MissingDecodeEvidenceList.md updated
[PASS] Fallback values in buildings.json are not marked original
[PASS] Fallback values in resources.json are not marked original
[PASS] Fallback values in jobs.json are not marked original
[PASS] Fallback values in tasks.json are not marked original
[PASS] Fallback values in enemies.json are not marked original
[PASS] Fallback values in balance.json are not marked original
[PASS] Construction remains incomplete before enough labour
[PASS] Builder/labour can increase currentCompletion
[PASS] Completed Hut appears only after currentCompletion >= finalCompletion
[PASS] Current instant-build path is marked PROTOTYPE_FALLBACK
[PASS] building definitions separate symbolEvidence / behaviorEvidence / balanceEvidence
[PASS] missing exact numbers are reported UNKNOWN or PROTOTYPE_FALLBACK
[PASS] project compiles

Total PASS: 156
Total FAIL: 2
