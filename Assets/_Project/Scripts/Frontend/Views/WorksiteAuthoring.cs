using UnityEngine;

namespace TheBonwater.Rebuild
{
    /// <summary>
    /// Marks a scene-owned GameObject as a draggable gameplay worksite.
    /// This component is metadata-only: it does not move the object,
    /// produce resources, or modify gameplay.
    /// </summary>
    public class WorksiteAuthoring : MonoBehaviour
    {
        [Tooltip("Unique identifier like mine_1, forage_1, coalMine_1, farm_1")]
        public string worksiteId;

        [Tooltip("Job ID assigned to villagers targeting this worksite (Miner, Forager, coalMiner, Farmer)")]
        public string jobId;

        [Tooltip("Asset key for the worksite visual (ironMine, bushes, coalMine, farm)")]
        public string assetKey;
    }
}

// force:reimport
// touch