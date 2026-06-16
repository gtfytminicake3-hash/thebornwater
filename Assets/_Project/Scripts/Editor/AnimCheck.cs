using UnityEngine;
using UnityEditor;

public class AnimCheck {
    public static void Run() {
        string[] clips = { "idle.anim", "Construction.anim", "Spider_Idle.anim" };
        foreach(var clipName in clips) {
            string[] guids = AssetDatabase.FindAssets(clipName.Replace(".anim", "") + " t:AnimationClip");
            if (guids.Length > 0) {
                var path = AssetDatabase.GUIDToAssetPath(guids[0]);
                var clip = AssetDatabase.LoadAssetAtPath<AnimationClip>(path);
                if (clip != null) {
                    var bindings = AnimationUtility.GetObjectReferenceCurveBindings(clip);
                    string bindTypes = "";
                    foreach(var b in bindings) {
                        bindTypes += b.type.Name + " ";
                    }
                    Debug.Log(clipName + " binds to: " + (bindTypes == "" ? "transform/other" : bindTypes));
                }
            }
        }
    }
}
