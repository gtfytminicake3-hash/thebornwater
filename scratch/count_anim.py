import os
import UnityPy

src = r"D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data"
env = UnityPy.load(src)

count = 0
for obj in env.objects:
    if obj.type.name == "AnimationClip":
        count += 1
print(f"Found {count} AnimationClips")
