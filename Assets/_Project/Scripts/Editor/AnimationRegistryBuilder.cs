using UnityEngine;
using UnityEditor;
using TheBonwater.Rebuild.Data;
using System.IO;
using Newtonsoft.Json;

namespace TheBonwater.Rebuild.Editor {
    public static class AnimationRegistryBuilder {
        [MenuItem("Tools/TheBonwater/Build Animation Registry")]
        public static void BuildRegistry() {
            var registryGo = new GameObject("AnimationRegistry");
            var registry = registryGo.AddComponent<AnimationRegistry>();

            string jsonPath = Path.Combine(Application.dataPath, "_Project/Data/Definitions/animation_map.json");
            if (!File.Exists(jsonPath)) {
                Debug.LogError("animation_map.json not found.");
                return;
            }

            string json = File.ReadAllText(jsonPath);
            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Ignore };
            var map = JsonConvert.DeserializeObject<AnimationMapDefinition>(json, settings);

            if (map != null && map.animations != null) {
                foreach (var kvp in map.animations) {
                    if (string.IsNullOrEmpty(kvp.Value) || kvp.Value == "UNKNOWN/FALLBACK") {
                        continue;
                    }
                    var clip = AssetDatabase.LoadAssetAtPath<AnimationClip>(kvp.Value);
                    if (clip != null) {
                        bool isSpriteRendererClip = false;
                        var objBindings = AnimationUtility.GetObjectReferenceCurveBindings(clip);
                        foreach (var b in objBindings) {
                            if (b.type == typeof(SpriteRenderer)) isSpriteRendererClip = true;
                        }

                        AnimationClip finalClip = clip;
                        
                        if (isSpriteRendererClip) {
                            // Copy the clip to avoid modifying the imported original
                            string generatedDir = "Assets/_Project/Generated/Animations/UIConverted";
                            if (!Directory.Exists(generatedDir)) Directory.CreateDirectory(generatedDir);
                            
                            string newPath = $"{generatedDir}/{clip.name}_UI.anim";
                            finalClip = new AnimationClip();
                            EditorUtility.CopySerialized(clip, finalClip);
                            
                            foreach (var b in objBindings) {
                                if (b.type == typeof(SpriteRenderer)) {
                                    var curve = AnimationUtility.GetObjectReferenceCurve(clip, b);
                                    AnimationUtility.SetObjectReferenceCurve(finalClip, b, null); // remove old binding
                                    var newBinding = b;
                                    newBinding.type = typeof(UnityEngine.UI.Image);
                                    AnimationUtility.SetObjectReferenceCurve(finalClip, newBinding, curve);
                                }
                            }
                            
                            AssetDatabase.CreateAsset(finalClip, newPath);
                            AssetDatabase.SaveAssets();
                            // Mark as perfectly compatible with UI.Image now
                            isSpriteRendererClip = false;
                        }

                        // Mark as legacy if needed
                        bool isLegacy = finalClip.legacy;
                        if (!isLegacy) {
                            finalClip.legacy = true;
                            EditorUtility.SetDirty(finalClip);
                        }
                        
                        registry.AddOrUpdateClip(kvp.Key, finalClip, isSpriteRendererClip, true);
                    } else {
                        Debug.LogWarning($"Failed to load clip at path: {kvp.Value} for key: {kvp.Key}");
                    }
                }
            }
            
            string resourcesDir = "Assets/_Project/Resources";
            if (!Directory.Exists(resourcesDir)) Directory.CreateDirectory(resourcesDir);
            
            PrefabUtility.SaveAsPrefabAsset(registryGo, $"{resourcesDir}/AnimationRegistryPrefab.prefab");
            GameObject.DestroyImmediate(registryGo);
            
            Debug.Log("Animation Registry built successfully and saved as Prefab to Resources.");
        }
    }
}
