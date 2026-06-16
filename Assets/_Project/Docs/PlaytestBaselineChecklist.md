# PlaytestBaselineChecklist
**Sprint**: SPRINT_09_VERIFIER_DEBT_CLEANUP_AND_PLAYTEST_BASELINE
**Date**: 2026-06-12

## Setup
- [ ] Open project in Unity Editor
- [ ] Open `Assets/_Project/Scenes/MainMenuScene.unity`
- [ ] Press Play

## MainMenu
- [ ] MainMenu loads with background sprite
- [ ] "NEW GAME" button is visible and clickable
- [ ] "CONTINUE" button is visible and clickable

## TownScene — Initial State
- [ ] TownScene loads after New Game or Continue
- [ ] Sky background visible (Blue Sky.png, preserve aspect)
- [ ] Scene background visible (BG_Beach.png, preserve aspect)
- [ ] Terrain floor visible (ForestFloor.png, anchored bottom)
- [ ] Bonfire, hut, guard tower, tree sprites visible at correct positions
- [ ] HUD shows: Day 1, Wood, Food, Iron values
- [ ] Villagers appear on ground line with sprite and labels
- [ ] No red/magenta missing-sprite placeholders

## Building
- [ ] "BUILD HUT" button visible in action panel
- [ ] Clicking "BUILD HUT" does NOT instant-complete the hut
- [ ] Construction task appears in task list
- [ ] Construction progress UI shows correct state

## Job Assignment
- [ ] "ASSIGN JOB" button visible
- [ ] Clicking assigns villager to Woodcutter (temporary fallback)

## Time / Survival
- [ ] Time advances through phases (Morning → Afternoon → Evening → Night)
- [ ] Night phase triggers raid check
- [ ] Raid can spawn enemy and cause damage
- [ ] Guard assignment reduces raid damage
- [ ] Wood/Food consumption works

## Save/Load
- [ ] "SAVE" button works
- [ ] "LOAD" button works
- [ ] Saved state preserves resources, buildings, villagers, tasks

## Game Over / Objective
- [ ] All villagers dead triggers Game Over
- [ ] Surviving to Day 3 with 2 huts triggers Objective Complete

## No Debug HUD
- [ ] No "+10 Wood" debug button visible
- [ ] No "Force Raid" debug button visible
- [ ] No "Advance Time" debug button visible
- [ ] Player HUD does not show raw JSON

## Visual Quality
- [ ] Backgrounds not stretched/pixelated (preserve aspect)
- [ ] Entities sit on ground line (not floating)
- [ ] No fallback magenta color blocks in scene
