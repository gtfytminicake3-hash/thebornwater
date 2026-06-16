# Backend Gap Analysis

- Original logic heavily relies on generic Unity behaviors (`MonoBehaviour`, `ScriptableObject`) for data definition (e.g., `BuildingData`, `ResourceData`). Our current LocalGameBackend uses flat JSON definitions and custom class structures.
- Original uses specific `BuildingInstance` and `ResourceProductionBuilding` structures to manage ticks and events natively in the Unity scene. We currently process these centrally in `LocalGameBackend.ProcessTimeAdvance`.
- AI (`AIAgent`, `MonsterManager`, `AnimalManager`) is completely missing. Currently, villagers are just state data without physical agents navigating the NavMesh.
