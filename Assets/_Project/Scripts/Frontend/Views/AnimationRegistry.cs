using System;
using System.Collections.Generic;
using UnityEngine;

namespace TheBonwater.Rebuild {
    [Serializable]
    public class AnimationClipEntry {
        public string key;
        public AnimationClip clip;
        public bool isSpriteRendererClip;
        public bool isLegacy;
    }

    public class AnimationRegistry : MonoBehaviour {
        [SerializeField]
        public List<AnimationClipEntry> entries = new List<AnimationClipEntry>();

        public AnimationClip GetClip(string key) {
            var entry = entries.Find(e => e.key == key);
            return entry != null ? entry.clip : null;
        }

        public void AddOrUpdateClip(string key, AnimationClip clip, bool isSpriteRendererClip, bool isLegacy) {
            var entry = entries.Find(e => e.key == key);
            if (entry != null) {
                entry.clip = clip;
                entry.isSpriteRendererClip = isSpriteRendererClip;
                entry.isLegacy = isLegacy;
            } else {
                entries.Add(new AnimationClipEntry { key = key, clip = clip, isSpriteRendererClip = isSpriteRendererClip, isLegacy = isLegacy });
            }
        }
    }
}
