# Time Advance UX Report

## Implementation
The test-only "Advance Time" UI interaction has been converted into a player-facing `NEXT PHASE` button in the UI layout.

## Feedback
Pressing the button logs exactly which phase the player transitioned from and to. E.g.:
- `Time advanced: Morning -> Afternoon`
- `Time advanced: Night -> Day 2 Morning`

This gives the player full manual control over the 3-day loop without needing automatic timers.
