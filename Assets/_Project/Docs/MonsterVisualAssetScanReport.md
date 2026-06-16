# Monster Visual Asset Scan Report

## Candidates found

- **name**: `Spider_COL_1k.png`
- **path**: `Assets/_Project/ImportedDecoded/Texture2D/Spider_COL_1k.png`
- **type**: Texture2D/Sprite
- **reason why candidate**: Explicitly named "Spider", commonly acts as a basic monster/enemy in survival/RTS games.
- **visual role**: monster/enemy
- **confidence**: HIGH

- **name**: `Crocodile_COL_1k.png` (and `Crocodile_Boss_COL_1k.png`)
- **path**: `Assets/_Project/ImportedDecoded/Texture2D/Crocodile_COL_1k.png`
- **type**: Texture2D/Sprite
- **reason why candidate**: Name contains Crocodile, a hostile beast.
- **visual role**: monster/enemy
- **confidence**: HIGH

- **name**: `Bear_Brown_COL_1k.png`
- **path**: `Assets/_Project/ImportedDecoded/Texture2D/Bear_Brown_COL_1k.png`
- **type**: Texture2D/Sprite
- **reason why candidate**: A bear is a hostile animal/beast.
- **visual role**: animal/enemy
- **confidence**: MEDIUM

- **name**: `skull.png` / `skullHAT.png`
- **path**: `Assets/_Project/ImportedDecoded/Texture2D/skull.png`
- **type**: Texture2D/Sprite
- **reason why candidate**: Undead/skeleton imagery.
- **visual role**: enemy/decoration
- **confidence**: LOW

## Selected monster visual
- **selected asset**: `Spider_COL_1k.png`
- **reason**: It is clearly a monster with available matching animations (`Spider_Idle`, `Spider_Attack`, `Spider_Walk`, `Spider_Dead`). It matches the generic 'SmallMonster' profile perfectly.
- **fallback label**: `DECODED_ASSET_MONSTER_CANDIDATE`

## Rejected assets
- **asset**: `beastOfBurden.png`
- **reason rejected**: Previously mapped in `asset_map.json` under `SmallMonster`, but the newly scanned decoded assets have much more explicit monster counterparts (Spider, Crocodile) that also have matching animation files in the `Animation` folder.
- **asset**: `head1.png`, `Woman Head.png`
- **reason rejected**: Poor visual fit for a monster compared to `Spider`.
