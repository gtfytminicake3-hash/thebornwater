import os

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\OriginalFidelity"

reports = {
    "EndToEndReconstructionPass01Report.md": "# EndToEndReconstructionPass01Report\n\n- All systems audited and separated.\n- FidelityMode stripped of auto-progress logic.\n- Editor Test Tool handles fallback progression.\n- Pass 01 partial but faithful.",
    "EndToEndEvidenceRefreshReport.md": "# EndToEndEvidenceRefreshReport\n\n## Building / Construction\n- ORIGINAL_CONFIRMED: BuildingInstance, DepositResource, currentCompletion, finalCompletion\n- UNKNOWN: Exact deposit sequence, addedLabour per tick, finalCompletion value.\n\n## Villager / AIAgent\n- DECODE_EVIDENCE_PARTIAL: JobData, AIAgent exist.\n- UNKNOWN_JOB_UI_FLOW: The button cycle is a prototype fallback.\n\n## Resource / Deposit\n- DECODE_EVIDENCE_PARTIAL: ResourceProductionBuilding exists.\n- UNKNOWN_DEPOSIT_SEQUENCE: Delivery logic is missing.\n\n## Time / DayNight / Survival\n- ORIGINAL_CONFIRMED: DayNightController, food upkeep.\n- UNKNOWN: exact numeric balance.\n\n## Combat / Raid\n- DECODE_EVIDENCE_PARTIAL: MonsterManager exists.\n- PROTOTYPE_FALLBACK: Raid chance 50%.\n\n## Save / Load\n- DECODE_EVIDENCE_PARTIAL: SaveLoadUtility exists.\n- SAVE_SCHEMA_UNKNOWN: Current JSON is fallback.\n\n## Frontend / UI\n- DECODE_EVIDENCE_PARTIAL: TownScene exists.\n- DEBUG_ONLY: +10 Wood buttons removed.\n\n## Assets\n- ORIGINAL_CONFIRMED: Imported sprites.",
    "BuildingConstructionRuntimeFidelityReport.md": "# BuildingConstructionRuntimeFidelityReport\n- Instant-build removed.\n- TaskSnapshot created awaiting resources.\n- Fallback progression isolated to Editor Test Tool.\n- Final Status: ORIGINAL_BUILDING_CONSTRUCTION_PARTIAL_WITH_UNKNOWN_BALANCE_AND_UNKNOWN_DEPOSIT_SEQUENCE",
    "VillagerAIAgentFidelityReport.md": "# VillagerAIAgentFidelityReport\n- Cycle button is PROTOTYPE_FALLBACK.\n- Exact UI flow is UNKNOWN_JOB_UI_FLOW.",
    "ResourceDepositFidelityReport.md": "# ResourceDepositFidelityReport\n- Deposit sequence marked UNKNOWN_DEPOSIT_SEQUENCE.\n- Auto-adding resources disabled.",
    "DayNightSurvivalFidelityReport.md": "# DayNightSurvivalFidelityReport\n- Time skip moved to Editor Test Tool.\n- Upkeep exists but uses fallback numbers.",
    "CombatRaidFidelityReport.md": "# CombatRaidFidelityReport\n- Raid forces moved to Editor tool.\n- Fallback stats used for testing.",
    "SaveLoadFidelityReport.md": "# SaveLoadFidelityReport\n- JSON schema is PROTOTYPE_FALLBACK.\n- Handles TaskSnapshot serialization.",
    "FrontendTemporaryUIFidelityReport.md": "# FrontendTemporaryUIFidelityReport\n- Player HUD cleared of DEBUG_ONLY elements.\n- Building buttons kept as TEMPORARY_DEV_UI.",
    "AssetMappingFidelityReport.md": "# AssetMappingFidelityReport\n- Sprites mapped. Role confirmed.",
    "MissingDecodeEvidenceList.md": "# Missing Decode Evidence\n- Deposit sequence\n- finalCompletion numbers\n- labourRequiredToBuild numbers\n- Job UI flow"
}

for filename, content in reports.items():
    with open(os.path.join(base_dir, filename), "w", encoding="utf-8") as f:
        f.write(content)

print("All reports generated.")
