using UnityEngine;

namespace TheBonwater.Rebuild
{
    /// <summary>
    /// Marks a scene-owned GameObject as a draggable build slot (e.g. BuildSlot_Hut, BuildSlot_Storage, BuildSlot_GuardTower, BuildSlot_Forge).
    /// This component is metadata-only: it does not move the object, build structures, or modify gameplay.
    /// </summary>
    public sealed class BuildSlotAuthoring : MonoBehaviour
    {
        [Tooltip("Type of building this slot is intended for: hut, storage, guardTower, blacksmithsForge")]
        public string buildingType;
    }
}
