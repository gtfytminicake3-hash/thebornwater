# Combat / Raid Manual Test

1. Launch Unity Editor and open `D:\Tinh\TheBonwater`.
2. Open `Assets/_Project/Scenes/MainMenuScene.unity`.
3. Press Play. Click **NEW GAME**. The scene UNKNOWN transition to `TownScene`.
4. In `TownScene`, look at the **Villagers** UI block. It UNKNOWN show their Jobs and HP.
5. Click **ASSIGN WORKER** several times. The job UNKNOWN cycle through `Idle`, `Woodcutter`, `Builder`, `Forager`, `Miner`, `Guard`. Assign at least one villager to `Guard`. Note that the text says `(Def +10)`.
6. Click **ADVANCE TIME** until you cycle from Morning -> Afternoon -> Evening -> Night.
7. During the transition to Night, observe the **TaskLog**. There is a 50% chance a Raid will happen.
8. If a Raid happens:
   - If Defense is < 15, you UNKNOWN see `Night Raid! SmallMonster attacked.` and a villager's HP decreases. Wood may also decrease by 10.
   - If Defense is >= 15, you UNKNOWN see `Night Raid repelled by guards. Damage: 0`.
9. Click **BUILD GUARD TOWER** when you have 80 Wood and 20 Iron. (You can collect Wood via button, and Iron by advancing time with Miners).
10. Wait for the `GuardTower` to be completed (Advance Time multiple times with Builders). The total defense shown in UI UNKNOWN increase by +15.
11. Press **SAVE**, stop Play mode, press Play mode again, press **LOAD GAME**, and verify the Defense stats and Villager HP are preserved.
