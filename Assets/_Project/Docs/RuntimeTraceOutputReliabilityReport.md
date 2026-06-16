# Runtime Trace Output Reliability Report

## Issue
Writing to `runtime_backend_trace.log` via `File.AppendAllText` would previously crash or throw an `IOException` when the file was locked by an external reader (like `tail` or the Unity Console/Test Runner).

## Fix
Implemented a retry loop in `RuntimeTrace.cs`:
- The system retries 3 times with a 50ms delay if it encounters an `IOException` (e.g. file lock).
- If it still fails after 3 tries, it automatically writes to a fallback file `runtime_backend_trace_fallback.log`.
- All `Exception`s are caught and logged to `Debug.LogError` to prevent crashes.

## Conclusion
Batchmode tests and background game threads can now reliably write logs without crashing. The process generates `.md` reports in `Assets/_Project/Docs/` for each major test to ensure results are always verifiable regardless of terminal log conditions.
