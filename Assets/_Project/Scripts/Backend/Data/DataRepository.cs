using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Linq;
using Newtonsoft.Json;

namespace TheBonwater.Rebuild.Data
{
    public class DataRepository
    {
        public List<ResourceDefinition> Resources { get; private set; } = new List<ResourceDefinition>();
        public List<JobDefinition> Jobs { get; private set; } = new List<JobDefinition>();
        public List<BuildingDefinition> Buildings { get; private set; } = new List<BuildingDefinition>();
        public List<EnemyDefinition> Enemies { get; private set; } = new List<EnemyDefinition>();
        public List<EquipmentDefinition> Equipment { get; private set; } = new List<EquipmentDefinition>();
        public BalanceDefinition Balance { get; private set; }
        public List<ObjectiveDefinition> Objectives { get; private set; } = new List<ObjectiveDefinition>();
        public AssetMapDefinition AssetMap { get; private set; }
        public AnimationMapDefinition AnimationMap { get; private set; }
        public BuildMenuDefinition BuildMenu { get; private set; }
        public WorldObjectListDefinition WorldObjects { get; private set; }
        public TownVisualLayoutDefinition VisualLayout { get; private set; }
        public List<WorldMapLocationDefinition> WorldMapLocations { get; private set; } = new List<WorldMapLocationDefinition>();

        private string LoadJson(string filename)
        {
            string path = Path.Combine(Application.dataPath, "_Project/Data/Definitions", filename);
            if (File.Exists(path)) return File.ReadAllText(path);
            return null;
        }

        public void LoadAll()
        {
            try {
                var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Ignore };
                
                string resJson = LoadJson("resources.json");
                if (resJson != null) Resources = JsonConvert.DeserializeObject<List<ResourceDefinition>>(resJson, settings) ?? new List<ResourceDefinition>();

                string jobsJson = LoadJson("jobs.json");
                if (jobsJson != null) Jobs = JsonConvert.DeserializeObject<List<JobDefinition>>(jobsJson, settings) ?? new List<JobDefinition>();

                string bldJson = LoadJson("buildings.json");
                if (bldJson != null) Buildings = JsonConvert.DeserializeObject<List<BuildingDefinition>>(bldJson, settings) ?? new List<BuildingDefinition>();

                string eneJson = LoadJson("monsters.json") ?? LoadJson("enemies.json"); // fallback compat
                if (eneJson != null) Enemies = JsonConvert.DeserializeObject<List<EnemyDefinition>>(eneJson, settings) ?? new List<EnemyDefinition>();

                string balJson = LoadJson("balance.json");
                if (balJson != null) Balance = JsonConvert.DeserializeObject<BalanceDefinition>(balJson, settings);

                string objJson = LoadJson("objectives.json");
                if (objJson != null) Objectives = JsonConvert.DeserializeObject<List<ObjectiveDefinition>>(objJson, settings) ?? new List<ObjectiveDefinition>();

                string assetMapJson = LoadJson("asset_map.json");
                if (assetMapJson != null) AssetMap = JsonConvert.DeserializeObject<AssetMapDefinition>(assetMapJson, settings);

                string animMapJson = LoadJson("animation_map.json");
                if (animMapJson != null) AnimationMap = JsonConvert.DeserializeObject<AnimationMapDefinition>(animMapJson, settings);

                string buildMenuJson = LoadJson("ui_build_menu.json");
                if (buildMenuJson != null) BuildMenu = JsonConvert.DeserializeObject<BuildMenuDefinition>(buildMenuJson, settings);

                string worldObjJson = LoadJson("world_objects.json");
                if (worldObjJson != null) WorldObjects = JsonConvert.DeserializeObject<WorldObjectListDefinition>(worldObjJson, settings);
                
                string layoutJson = LoadJson("town_visual_layout.json");
                if (layoutJson != null) VisualLayout = JsonConvert.DeserializeObject<TownVisualLayoutDefinition>(layoutJson, settings);

                string equipJson = LoadJson("equipment.json");
                if (equipJson != null) Equipment = JsonConvert.DeserializeObject<List<EquipmentDefinition>>(equipJson, settings) ?? new List<EquipmentDefinition>();

                string mapJson = null;
                try {
                    mapJson = LoadJson("world_map_definitions.json");
                } catch (Exception ex) {
                    UnityEngine.Debug.LogWarning($"[WorldMap] Failed to read world_map_definitions.json: {ex.Message}");
                }

                if (!string.IsNullOrEmpty(mapJson)) {
                    try {
                        WorldMapLocations = JsonConvert.DeserializeObject<List<WorldMapLocationDefinition>>(mapJson, settings);
                    } catch (Exception ex) {
                        UnityEngine.Debug.LogWarning($"[WorldMap] Failed to deserialize world_map_definitions.json: {ex.Message}");
                    }
                }

                if (WorldMapLocations == null || WorldMapLocations.Count == 0) {
                    if (string.IsNullOrEmpty(mapJson)) {
                        UnityEngine.Debug.LogWarning("[WorldMap] world_map_definitions.json is missing or empty. Falling back to default home definition.");
                    } else {
                        UnityEngine.Debug.LogWarning("[WorldMap] world_map_definitions.json is corrupt or empty. Falling back to default home definition.");
                    }
                    WorldMapLocations = new List<WorldMapLocationDefinition> {
                        new WorldMapLocationDefinition {
                            id = "home",
                            displayName = "Home",
                            type = "home",
                            x = 0,
                            y = 0,
                            discoveredAtStart = true,
                            isMajorLocation = true,
                            dangerLevel = 0,
                            rewardType = "",
                            rewardAmount = 0,
                            spritePath = "Assets/_Project/ImportedDecoded/Sprite/City_Bonfire_2.png",
                            unlockRequirement = "",
                            notes = "Fallback default home location"
                        }
                    };
                }
                
                ValidateDefinitions();
            }
            catch (Exception ex) {
                UnityEngine.Debug.LogError($"[DataRepository] Failed to load definitions: {ex.Message}");
            }
        }

        private void ValidateDefinitions()
        {
            // Basic validation and warning logs
            if (AssetMap == null || AssetMap.assets == null) {
                UnityEngine.Debug.LogError("[DataRepository] AssetMap is missing or empty.");
            }
            if (AnimationMap == null || AnimationMap.animations == null) {
                UnityEngine.Debug.LogWarning("[DataRepository] AnimationMap is missing or empty.");
            }
        }

        public ResourceDefinition GetResource(string id) => Resources.FirstOrDefault(r => r.id.Equals(id, StringComparison.OrdinalIgnoreCase));
        public JobDefinition GetJob(string id) => Jobs.FirstOrDefault(j => j.id.Equals(id, StringComparison.OrdinalIgnoreCase));
        public BuildingDefinition GetBuilding(string id) => Buildings.FirstOrDefault(b => b.id.Equals(id, StringComparison.OrdinalIgnoreCase));
        public EnemyDefinition GetEnemy(string id) => Enemies.FirstOrDefault(e => e.id.Equals(id, StringComparison.OrdinalIgnoreCase));
        public EquipmentDefinition GetEquipment(string id) => Equipment.FirstOrDefault(e => e.id.Equals(id, StringComparison.OrdinalIgnoreCase));
        public WorldMapLocationDefinition GetWorldMapLocation(string id) => WorldMapLocations.FirstOrDefault(l => l.id.Equals(id, StringComparison.OrdinalIgnoreCase));
        public IReadOnlyList<EquipmentDefinition> GetAllEquipment() => Equipment;
    }
}
