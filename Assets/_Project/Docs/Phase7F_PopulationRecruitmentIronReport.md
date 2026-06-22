# Phase 7F: Miner/Iron + Non-dev Population Recruitment Report

- **Miner Job:** Added `miner` to `jobs.json` providing +1 iron per phase. Backend explicitly hooks into this job.
- **Iron Generation:** Correctly increases and is clamped by `state.ironCapacity`.
- **Recruitment Rule:** Triggered dynamically every Morning if the game status is "Playing".
  - If population < `maxPopulation` and food >= 10, then 5 food is consumed and 1 new Villager is spawned (`job=Idle`, `hp=100`, `state=Alive`).
- **New Villager Integration:** Fully serializable, immediately enters the registry and correctly joins the save state. Does not auto-open the Job modal.
- **Log output:** `[RECRUITMENT_SUCCESS]`, `[RECRUITMENT_SKIP]` ensure full backend traceability.
