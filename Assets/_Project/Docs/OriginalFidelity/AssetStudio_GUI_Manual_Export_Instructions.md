# AssetStudio GUI Manual Export Instructions

GUI menu labels are unverified; user must inspect manually.

1. Mở `D:\Tinh\TheBonwater\Tools\AssetStudio\AssetStudioGUI.exe`
2. Load folder decode chứa `data.unity3d` (`D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data`)
3. Nếu GUI có option load DummyDll / Assembly / Type Definition (ví dụ trong Menu Options -> TypeTree), hãy trỏ tới folder `Assets/_Project/Docs/BackendDecode/Il2CppDump/DummyDll~`
4. Ở tab `Asset List`, filter các object thuộc type: `MonoBehaviour`, `ScriptableObject`, `TextAsset`
5. Ưu tiên export các object liên quan tới: BuildingDetails, BuildingData, ResourceData, JobData, Enemy, GuardTower, MonsterManager (Dựa theo file `PriorityObjectsForManualAssetStudioExport.csv`)
6. Export ra (chuột phải -> Export selected assets hoặc Export -> All assets) và trỏ vào folder `D:\Tinh\TheBonwater\ExternalExtracts\AssetStudio_ManualExport\`
7. Quay lại báo Anti chạy parser (Xem file `Run_PostAssetStudio_Parse_Command.md`)
