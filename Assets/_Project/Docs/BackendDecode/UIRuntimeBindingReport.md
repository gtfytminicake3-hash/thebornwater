# UI Runtime Binding Report
The `MainMenuScene` successfully delegates to `LocalGameBackend` and initiates `TownScene`.
The `TownScene` HUD exclusively listens to `GameSnapshot`.
Commands executed from the UI map to `ExecuteCommand(...)` against `IGameBackend`.
No `MockBackend` is used in the flow.
