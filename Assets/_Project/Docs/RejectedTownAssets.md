# Rejected Assets

This document lists decoded assets that were initially considered for the `TownScene` visual prototype but were rejected because they caused visual clutter or were not actually the intended game sprites.

| Asset Path | Intended Role | Reason for Rejection | Fallback Used |
|---|---|---|---|
| `Assets/_Project/ImportedDecoded/Sprite/bonfire.png` | `bonfire` | This is actually a UI Card / Frame containing the bonfire picture, not a transparent building sprite. Using it makes the scene look like a collage of UI menus. | Colored Rectangle placeholder (Orange) |
| `Assets/_Project/ImportedDecoded/Sprite/hut.png` | `hut` | Same as above. It's a UI button/frame graphic. | Colored Rectangle placeholder (Brown) |
| `Assets/_Project/ImportedDecoded/Sprite/house.png` | `house` | Same as above. It's a UI frame graphic. | Colored Rectangle placeholder (Grey) |
| `Assets/_Project/ImportedDecoded/Sprite/guardTower.png` | `tower` | Same as above. It's a UI frame graphic. | Colored Rectangle placeholder (Dark Grey) |

By rejecting these and using colored placeholders for buildings, the scene layout becomes much cleaner and easier to read, allowing the real transparent sprites (Villagers, Trees, Ground) to stand out properly and prove the layout MVP without looking messy.
