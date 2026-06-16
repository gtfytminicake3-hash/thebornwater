# Decode Inventory

- **data.unity3d**: FOUND (`resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data\data.unity3d`)
- **Master.bank / Master.strings.bank**: FOUND (`resources\com.xigmaGames.thebonfire2.apk\assets\Master.bank`)
- **global-metadata.dat**: FOUND (`resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data\Managed\Metadata\global-metadata.dat`)
- **libil2cpp.so**: FOUND (`resources\config.arm64_v8a.apk\lib\arm64-v8a\libil2cpp.so`)
- **dump.cs / script.json / il2cpp.h / DummyDll**: NOT FOUND. Il2CppDumper needs to be run.
- **sources folder**: FOUND (Contains Java/Kotlin wrapper, not Unity logic).
- **ScriptingAssemblies.json**: FOUND.

**Conclusion**: The game is an IL2CPP build. We have the metadata and binary but no dumped C# code yet. Assets are packed in `data.unity3d`.
