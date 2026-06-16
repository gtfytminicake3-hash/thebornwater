# Job Control UX Report

## Implementation
The `ASSIGN JOB` button was replaced with `ASSIGN NEXT JOB` to remove ambiguity about what the button does.

## Feedback
When the player clicks `ASSIGN NEXT JOB`, the event log now correctly prints:
`Bryn changed job: Idle -> Woodcutter`

This gives clear visibility on exactly who was assigned and what their new job is. The cycle remains `Idle -> Woodcutter -> Builder -> Guard` as a `PROTOTYPE_FALLBACK_JOB_UI`.
