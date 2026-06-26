#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;

namespace TheBonwater.Rebuild.Editor
{
    public static class TestLoadSprite
    {
        [MenuItem("Tools/TheBonwater/Test Load Sprite")]
        public static void Execute()
        {
            string[] paths = new[]
            {
                "Assets/_Project/ImportedDecoded/Sprite/hut.png",
                "Assets/_Project/ImportedDecoded/Sprite/stockPile.png",
                "Assets/_Project/ImportedDecoded/Sprite/guardTower.png",
                "Assets/_Project/ImportedDecoded/Sprite/blacksmith.png"
            };

            foreach (var path in paths)
            {
                Debug.Log($"--- TEST PATH: {path} ---");
                
                // 1. File.Exists
                bool fileExistsProj = File.Exists(path);
                string absPath = Path.Combine(Application.dataPath, "..", path);
                bool fileExistsAbs = File.Exists(absPath);
                Debug.Log($"  File.Exists(projPath): {fileExistsProj}");
                Debug.Log($"  File.Exists(absPath): {fileExistsAbs} ({absPath})");

                // 2. AssetDatabase.LoadAssetAtPath<Sprite>
                Sprite adSprite = AssetDatabase.LoadAssetAtPath<Sprite>(path);
                Debug.Log($"  AssetDatabase Sprite: {(adSprite != null ? adSprite.name : "null")}");

                // 3. AssetDatabase.LoadAssetAtPath<Texture2D>
                Texture2D adTex = AssetDatabase.LoadAssetAtPath<Texture2D>(path);
                Debug.Log($"  AssetDatabase Texture2D: {(adTex != null ? adTex.name : "null")}");

                // 4. AssetDatabase.LoadAllAssetsAtPath
                var allAssets = AssetDatabase.LoadAllAssetsAtPath(path);
                Debug.Log($"  LoadAllAssetsAtPath count: {allAssets.Length}");
                foreach (var asset in allAssets)
                {
                    Debug.Log($"    - Asset: {asset.name} (type: {asset.GetType().FullName})");
                }

                // 5. Raw bytes Texture2D.LoadImage
                if (fileExistsProj)
                {
                    try {
                        var bytes = File.ReadAllBytes(path);
                        var tex = new Texture2D(2, 2);
                        bool loadOk = tex.LoadImage(bytes);
                        Debug.Log($"  Texture2D.LoadImage: {loadOk} (size: {tex.width}x{tex.height})");
                        
                        Sprite createdSp = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                        Debug.Log($"  Sprite.Create: {(createdSp != null ? createdSp.name : "null")}");
                    }
                    catch (System.Exception ex) {
                        Debug.Log($"  Texture2D.LoadImage exception: {ex.Message}");
                    }
                }
            }
        }
    }
}
#endif
