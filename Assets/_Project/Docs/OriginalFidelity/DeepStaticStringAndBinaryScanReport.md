# DeepStaticStringAndBinaryScanReport

## Targets Scanned
- `script.json`
- `stringliteral.json`
- IL2CPP metadata

## Keywords
Hut, Bonfire, GuardTower, Storage, Wood, Food, Iron, Coal, Gold, labour, labourRequiredToBuild, finalCompletion, currentCompletion, capacity, production, damage, raid, monster, enemy, health

## Results
- String literals confirm the existence of UI labels ("GuardTower", "Storage", "Wood").
- Methods confirm class structures (`labourRequiredToBuild` getter/setter).
- **NO VALUES FOUND**: IL2CPP string literals do not contain the default values of primitives (ints/floats) assigned in constructors.
