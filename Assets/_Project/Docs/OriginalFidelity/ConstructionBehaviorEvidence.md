# Construction Behavior Evidence

## HutBuilding / BuildingInstance
- **Evidence symbols**: `BuildingInstance`, `HutBuilding` (TypeDefIndex: 3592)
- **Fields**: `currentCompletion`, `finalCompletion`, `underConstructionParticles`, `constructionAnimator`, `requiredResources`
- **Methods**: `DepositResource(Resource type, int quantity)`, `UpdateConstruction(int addedLabour, AIAgent agent)`, `FinishConstruction(AIAgent agent)`, `HasEnoughResourcesToStartConstruction()`
- **Related assets**: `Construction`, `Builder` (AIAgent job)
- **Inferred original behavior**: 
  1. A building site is placed.
  2. Workers carry and `DepositResource` until `HasEnoughResourcesToStartConstruction()` is true.
  3. A Builder (`AIAgent`) is assigned.
  4. Builder performs an action that triggers `UpdateConstruction(addedLabour, agent)`.
  5. When `currentCompletion >= finalCompletion`, `FinishConstruction()` is called.
- **Confidence**: HIGH
- **What is still unknown**: Exact labor added per tick, exact worker assignment UI flow.

## Current implementation comparison
- **Current behavior**: Instant completion (deducts cost, instantly spawns finished building).
- **Matches original**: NO
- **Required change**: Must refactor construction into a multi-step process involving tasks, resource carrying, and a dedicated Builder AI loop. To be done in a future fidelity sprint.
