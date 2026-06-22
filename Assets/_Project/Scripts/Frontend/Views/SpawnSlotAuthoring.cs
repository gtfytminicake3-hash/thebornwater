using UnityEngine;

namespace TheBonwater.Rebuild
{
    /// <summary>
    /// Marks a scene-owned GameObject as a draggable spawn point (e.g. VillagerSpawn, RaidSpawn_Left, RaidSpawn_Right).
    /// This component is metadata-only: it does not move the object, spawn entities, or modify gameplay.
    /// </summary>
    public sealed class SpawnSlotAuthoring : MonoBehaviour
    {
        [Tooltip("Unique identifier like VillagerSpawn, RaidSpawn_Left, RaidSpawn_Right")]
        public string slotId;
    }

    /// <summary>
    /// Metadata component for scene-owned enemy spawn markers in TownScene.
    /// Allows the user to configure spawn positions, enemy types, and manual visual/sprite overrides.
    /// </summary>
    public sealed class EnemySpawnPointAuthoring : MonoBehaviour
    {
        [Tooltip("Unique ID for this enemy spawn point")]
        public string spawnId;

        [Tooltip("Type of enemy this spawn point authors (Basic, Fast, Tank)")]
        public string enemyType;

        [Tooltip("Optional asset key override for the enemy visual (e.g. enemy.basic)")]
        public string visualAssetKey;

        [Tooltip("Optional absolute or relative path to override the enemy sprite (e.g. Assets/_Project/ImportedDecoded/Sprite/orc.png)")]
        public string spriteOverridePath;
    }
}
