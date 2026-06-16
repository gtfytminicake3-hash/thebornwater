# Core Game Loop Report

- Status: CORE_GAME_LOOP_ACCEPTED
- The game now runs on `LocalGameBackend` which fully implements time, resource generation, and consumption logic.
- Time advances through Morning, Afternoon, Evening, Night. Night to Morning triggers Day++.
- Woodcutters, Foragers, and Miners produce Wood, Food, and Iron respectively on time advance.
- Food is consumed at the end of each day. Lack of food causes starvation, reducing villager HP by 10 per day.
- A Game Over state occurs if all villagers die.
- Build Hut creates a task that requires time advance to complete. It adds 1 to Hut count.
- An Objective is tracked: Survive to Day 3 with 2 Huts.
- Saving/Loading persists the entire state snapshot including all villagers, tasks, and objective conditions.
