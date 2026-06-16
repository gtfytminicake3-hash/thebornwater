# Decode Data Extraction Report

## Final Status
TYPE_TREE_RECOVERY_PARTIAL_WITH_BLOCKERS

## Sources inspected
- AssetStudio / AssetRipper
- UnityPy
- libil2cpp script.json

## Values successfully extracted
None. We mapped MonoBehaviours to their scripts, but without TypeTrees, we cannot deserialize the fields cleanly.

## Values still missing
All balance and construction numeric values.

## Next recommended sprint
Provide DummyDlls to AssetRipper, or decompile libil2cpp.so using IDA/Ghidra.
