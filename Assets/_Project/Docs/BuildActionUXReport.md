# Build Action UX Report

## Implementation
Build buttons now check if the player has enough resources *before* creating tasks or placing blueprints.

## Feedback
If the player attempts to build without sufficient resources, an event is logged detailing exactly why it failed:
`Cannot build Hut: Not enough Wood: need 50, have 30`

This prevents the confusing creation of empty `AwaitingResources` tasks when the player is completely out of wood.
