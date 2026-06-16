# Town Visual Asset Selection

This document maps the visual assets extracted from The Bonfire 2 IL2CPP/UnityPy decode to be used in the `TownScene` MVP.

## Selected Assets

| Role | Asset Path | Object Name | Confidence |
|---|---|---|---|
| Background | `Assets/_Project/ImportedDecoded/Texture2D/ForestFloor.png` | `TownBackground` | HIGH |
| Building 1 | `Assets/_Project/ImportedDecoded/Sprite/bonfire.png` | `Building_Bonfire` | HIGH |
| Building 2 | `Assets/_Project/ImportedDecoded/Sprite/hut.png` | `Building_Hut` | HIGH |
| Building 3 | `Assets/_Project/ImportedDecoded/Sprite/house.png` | `Building_House` | HIGH |
| Building 4 | `Assets/_Project/ImportedDecoded/Sprite/guardTower.png` | `Building_Tower` | HIGH |
| Villager 1 | `Assets/_Project/ImportedDecoded/Texture2D/man 1.png` | `Villager_1` | HIGH |
| Villager 2 | `Assets/_Project/ImportedDecoded/Texture2D/woman.png` | `Villager_2` | HIGH |
| Resource Node | `Assets/_Project/ImportedDecoded/Texture2D/tree.png` | `ResourceNode_Tree` | HIGH |
| Resource Node 2 | `Assets/_Project/ImportedDecoded/Texture2D/wood.png` | `ResourceNode_WoodDrop` | HIGH |

*Note: If an asset is currently imported as `Texture2D`, our scene generator script will automatically reimport it as `Sprite` before assignment.*
