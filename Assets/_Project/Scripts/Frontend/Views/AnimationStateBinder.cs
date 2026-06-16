using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    [RequireComponent(typeof(Animation))]
    public class AnimationStateBinder : MonoBehaviour {
        public string objectId;
        public string objectType;
        public string currentState;
        public Animation animationLegacy;
        public Image image;
        public bool usingFallbackBob;
        public bool hasRealAnimation;

        private void Awake() {
            animationLegacy = GetComponent<Animation>();
            image = GetComponent<Image>();
        }

        public void Bind(string stateKey, AnimationClipEntry entry) {
            if (currentState == stateKey && !usingFallbackBob) {
                // State hasn't changed, do not restart
                return;
            }

            if (!string.IsNullOrEmpty(currentState)) {
                Diagnostics.RuntimeTrace.Log("ANIMATION_SWITCH", $"object={objectId} from={currentState} to={stateKey}");
            } else {
                Diagnostics.RuntimeTrace.Log("ANIMATION_BIND", $"object={objectId} state={stateKey} clip={(entry != null && entry.clip != null ? entry.clip.name : "null")}");
            }
            currentState = stateKey;

            // Remove previous fallback if exists
            var bob = GetComponent<AnimationLiteBob>();
            if (bob != null) bob.enabled = false;
            usingFallbackBob = false;
            hasRealAnimation = false;

            if (entry == null || entry.clip == null) {
                Diagnostics.RuntimeTrace.Log("ANIMATION_MISSING", stateKey);
                Fallback($"Missing clip for {stateKey}");
                return;
            }

            if (!entry.isLegacy) {
                Diagnostics.RuntimeTrace.Log("ANIMATION_CLIP_INCOMPATIBLE", $"{stateKey} clip={entry.clip.name} reason=Clip is not marked as Legacy");
                Fallback($"Clip {entry.clip.name} is not legacy");
                return;
            }

            if (image != null && entry.isSpriteRendererClip) {
                Diagnostics.RuntimeTrace.Log("ANIMATION_CLIP_INCOMPATIBLE", $"{stateKey} clip={entry.clip.name} reason=SpriteRenderer clip on UI.Image visual");
                Fallback($"Clip {entry.clip.name} is for SpriteRenderer but visual is UI.Image");
                return;
            }

            var clip = entry.clip;
            hasRealAnimation = true;
            animationLegacy.AddClip(clip, stateKey);
            animationLegacy.Play(stateKey);
            // Default loop for works
            animationLegacy[stateKey].wrapMode = WrapMode.Loop;
        }

        public void Fallback(string reason) {
            hasRealAnimation = false;
            usingFallbackBob = true;
            Diagnostics.RuntimeTrace.Log("ANIMATION_FALLBACK", $"object={objectId} reason={reason}");
            
            if (image == null) {
                image = GetComponent<Image>();
            }

            if (animationLegacy != null) {
                animationLegacy.Stop();
            }

            if (GetComponent<RectTransform>() == null) {
                Debug.LogWarning("[ANIMATION_FALLBACK] object=" + objectId + " reason=no RectTransform, bob skipped");
                return;
            }
            
            var bob = GetComponent<AnimationLiteBob>();
            if (bob == null) {
                bob = gameObject.AddComponent<AnimationLiteBob>();
            }
            if (bob != null) {
                bob.enabled = true;
            }
        }

        public void DisableAnimation() {
            currentState = "NONE";
            hasRealAnimation = false;
            usingFallbackBob = false;
            if (animationLegacy != null) {
                animationLegacy.Stop();
            }
            var bob = GetComponent<AnimationLiteBob>();
            if (bob != null) bob.enabled = false;
        }
    }
}
