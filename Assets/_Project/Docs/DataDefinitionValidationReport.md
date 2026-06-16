# Data Definition Validation Report

## Execution Summary
The `DataDefinitionValidator` performs a full sweep prior to backend launch inside the verification harness. This ensures JSON structure definitions align directly with code dependencies.

## Passes
- `[PASS] resources.json exists`
- `[PASS] buildings.json exists`
- `[PASS] jobs.json exists`
- `[PASS] enemies.json exists`
- `[PASS] balance.json exists`
- `[PASS] objectives.json exists`
- `[PASS] all records have source/confidence/evidence`
- `[PASS] all building costs reference valid resources`
- `[PASS] all job production resources reference valid resources`
- `[PASS] enemy definitions have hp/attack`
- `[PASS] balance fields exist`

## Failure Cases
- None.

## Integrity Analysis
By coupling the Unity Batchmode runner directly to these verifications, the system enforces that missing configurations or missing `source/confidence/evidence` attributes immediately fail the CI build.
The structural checks (`bldCostsValid`, `jobProdValid`) effectively map foreign keys inside the serialized JSON representations preventing undefined IDs from leaking into runtime operations.
