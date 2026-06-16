# UnityPyRawParseAttemptReport

## Result
Status: `AUTOMATED_EXTRACTION_BLOCKED_NEEDS_EXTERNAL_TOOL`

Parsed 3 candidate fields from raw bytes.
All candidates are marked `REJECTED_LOW_CONFIDENCE` or `UNKNOWN` because we cannot map a byte offset to a specific field name without a TypeTree structure map.

## Conclusion
UnityPy raw parsing of MonoBehaviours without TypeTrees cannot yield verified decoded values. It only yields unaligned numbers that could be anything (pointers, lengths, garbage).
