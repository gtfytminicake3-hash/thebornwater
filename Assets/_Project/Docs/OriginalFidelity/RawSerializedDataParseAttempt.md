# RawSerializedDataParseAttempt

- Object tried: MonoBehaviour instances linked to `BuildingDetails` (if any found)
- Matched class candidate: BuildingDetails
- Field layout used: From dump.cs.txt (fields like `buildingId`, `health`, `labourRequiredToBuild`)
- Bytes parsed: N/A
- Values found: None
- Confidence: LOW
- Why accepted/rejected: Rejected. Without typetrees, raw bytes are tightly packed without field names. C# bools/ints/floats/strings are variable length or unaligned in serialized stream. Blind parsing without exact Unity version struct layout for MonoBehaviours results in garbage data.

**Conclusion**: Parsing raw bytes manually without Il2CppDumper's DummyDlls to reconstruct the struct map is practically impossible and highly prone to error.
