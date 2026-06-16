# EndToEndEvidenceRefreshReport

## Building / Construction
- DECODE_EVIDENCE_PARTIAL: BuildingInstance, DepositResource, currentCompletion, finalCompletion
- UNKNOWN: Exact deposit sequence, addedLabour per tick, finalCompletion value.

## Villager / AIAgent
- DECODE_EVIDENCE_PARTIAL: JobData, AIAgent exist.
- UNKNOWN_JOB_UI_FLOW: The button cycle is a prototype fallback.

## Resource / Deposit
- DECODE_EVIDENCE_PARTIAL: ResourceProductionBuilding exists.
- UNKNOWN_DEPOSIT_SEQUENCE: Delivery logic is missing.

## Time / DayNight / Survival
- DECODE_EVIDENCE_PARTIAL: DayNightController, food upkeep.
- UNKNOWN: exact numeric balance.

## Combat / Raid
- DECODE_EVIDENCE_PARTIAL: MonsterManager exists.
- PROTOTYPE_FALLBACK: Raid chance 50%.

## Save / Load
- DECODE_EVIDENCE_PARTIAL: SaveLoadUtility exists.
- SAVE_SCHEMA_UNKNOWN: Current JSON is fallback.

## Frontend / UI
- DECODE_EVIDENCE_PARTIAL: TownScene exists.
- DEBUG_ONLY: +10 Wood buttons removed.

## Assets
- DECODE_EVIDENCE_PARTIAL: Imported sprites.