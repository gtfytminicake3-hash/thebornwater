# KẾ HOẠCH REBUILD DỰ ÁN GAME

**The Bonfire 2: Uncharted Shores — hướng UI-first từ dữ liệu decode**  
**Mục tiêu trước mắt:** dựng luồng UI cơ bản để kiểm chứng dự án có thể rebuild từ dữ liệu decode hay không.  
**Ngày lập tài liệu:** 11/06/2026

---

## 0. Hướng dẫn dành cho Anti / agent thực hiện

Bạn là agent kỹ thuật được giao nhiệm vụ kiểm chứng khả năng rebuild một game Unity đã decode. Hãy thực hiện theo thứ tự trong tài liệu này, không nhảy sang backend thật trước khi UI MVP chạy được.

### Mục tiêu cần hoàn thành đầu tiên

Tạo được một Unity project mới có luồng UI cơ bản:

```text
BootScene -> MainMenuScene -> LoadingScene -> TownScene
                         -> BuildMenuUI
                         -> VillagerPanelUI
                         -> SettingsPopup
                         -> DebugOverlay
```

UI phải chạy bằng `MockBackend`, chưa yêu cầu backend thật.

### Nguyên tắc bắt buộc

1. Không coi folder decode là Unity source project hoàn chỉnh.
2. Tạo Unity project mới, sau đó import/phục dựng assets cần thiết.
3. Xây UI/frontend trước.
4. Backend thật chỉ được xây sau khi UI MVP chạy được.
5. Frontend chỉ gọi backend qua `IGameBackend`.
6. Trong giai đoạn UI MVP, dùng `MockBackend` để trả dữ liệu giả.
7. Khi hoàn thành mỗi giai đoạn, cập nhật checklist và ghi nhận lỗi/rủi ro.
8. Sau khi chạy thử, tạo báo cáo cuối tên `REBUILD_UI_MVP_REPORT.md`.

### Đầu ra bắt buộc sau khi thực hiện

| Deliverable | Bắt buộc | Mô tả |
|---|---:|---|
| Unity project mới | Có | Project rebuild sạch, không phụ thuộc trực tiếp vào folder decode như source. |
| AssetManifest.csv | Có | Danh sách assets đã tìm/import/phục dựng, trạng thái và rủi ro. |
| UI MVP scene flow | Có | Boot, MainMenu, Loading, Town chạy được trong Editor. |
| MockBackend | Có | Dữ liệu giả cho resource, building, villager, command. |
| Contract frontend/backend | Có | `IGameBackend`, `GameSnapshot`, `GameCommand`, `GameStateDelta`, `CommandResult`. |
| Android proof build | Ưu tiên cao | APK/AAB mở được tới TownScene nếu toolchain Android có sẵn. |
| REBUILD_UI_MVP_REPORT.md | Có | Báo cáo kết quả kiểm chứng, lỗi, ảnh/chứng cứ nếu có. |

### Cách báo cáo lại

Sau khi làm xong, hãy báo cáo theo mẫu ở cuối file này. Không chỉ nói “done”; phải ghi rõ:

- Đã tạo được scene nào.
- UI nào hoạt động.
- Assets nào import được.
- Assets nào lỗi/missing.
- MockBackend có command nào chạy được.
- Editor test pass/fail.
- Android build pass/fail.
- Kết luận: `PASS`, `PASS_CÓ_RỦI_RO`, hoặc `TẠM_DỪNG`.

---

## 1. Tóm tắt quyết định kỹ thuật

Không xem gói decode là source Unity hoàn chỉnh. Cách an toàn nhất là tạo một Unity project mới, phục dựng assets và UI trước, dùng `MockBackend` để chạy UI, sau đó mới xây backend dữ liệu/logic tương thích qua một contract cố định.

| Ưu tiên | Kết quả cần đạt |
|---:|---|
| 1 | Frontend/UI MVP chạy được: Boot, Main Menu, Loading, Town Shell, Resource Bar, Build Menu, Villager Panel. |
| 2 | MockBackend cung cấp dữ liệu giả để UI render được mà chưa cần backend thật. |
| 3 | Chốt contract frontend/backend: Snapshot, Command, Delta, Error. |
| 4 | Sau khi UI ổn mới xây Data Repository và Game Systems thật. |
| 5 | Build Android kiểm chứng: mở game, chuyển scene, thao tác UI, không crash. |

> **Lưu ý pháp lý:** Chỉ sử dụng kế hoạch này cho mục đích học tập, nghiên cứu kỹ thuật, hoặc khi bạn có quyền hợp pháp với tài sản/code của game. Nếu không có quyền, nên dùng dữ liệu decode như tham chiếu để xây một game riêng với assets và logic mới.

---

## 2. Hiện trạng dữ liệu decode đã kiểm tra

Gói decode cung cấp đủ dấu hiệu của một game Unity build bằng IL2CPP. Điều này có nghĩa là assets có thể phục dựng tương đối trực quan hơn, còn logic backend không còn ở dạng C# source sạch mà nằm trong native binary và metadata.

| Thành phần | Đường dẫn trong gói decode | Vai trò |
|---|---|---|
| Unity asset data | `resources/com.xigmaGames.thebonfire2.apk/assets/bin/Data/data.unity3d`<br>Kích thước: `94,434,128 bytes` | Nguồn phục dựng scene, sprite, prefab, material, animation, texture và các dữ liệu Unity khác. |
| FMOD Master Bank | `resources/com.xigmaGames.thebonfire2.apk/assets/Master.bank`<br>Kích thước: `36,450,880 bytes` | Nguồn âm thanh chính. Cần import qua FMOD Unity Integration hoặc dựng adapter audio riêng. |
| FMOD strings bank | `resources/com.xigmaGames.thebonfire2.apk/assets/Master.strings.bank`<br>Kích thước: `5,816 bytes` | Map tên event/string audio nếu khôi phục được. |
| IL2CPP metadata | `resources/com.xigmaGames.thebonfire2.apk/assets/bin/Data/Managed/Metadata/global-metadata.dat`<br>Kích thước: `9,522,456 bytes` | Nguồn tham chiếu tên class, method, field, enum để suy ra cấu trúc logic. |
| Native game logic | `resources/config.arm64_v8a.apk/lib/arm64-v8a/libil2cpp.so`<br>Kích thước: `54,553,432 bytes` | Logic đã biên dịch native. Dùng để mapping/tham khảo, không nên coi là source có thể build lại trực tiếp. |
| Unity native runtime | `resources/config.arm64_v8a.apk/lib/arm64-v8a/libunity.so`<br>Kích thước: `19,161,720 bytes` | Runtime Unity Android. Không phải source gameplay. |

### Dấu hiệu thư viện cần lưu ý

| Dấu hiệu thư viện trong `ScriptingAssemblies.json` | Ý nghĩa khi rebuild |
|---|---|
| `Assembly-CSharp.dll`, `Assembly-CSharp-firstpass.dll` | Có code gameplay gốc trước khi IL2CPP, nhưng trong build hiện tại không còn dạng DLL đọc được như Mono. |
| `Unity.RenderPipelines.Universal.*` | Có khả năng dự án dùng URP/2D Renderer hoặc shader URP. Cần ưu tiên dựng project Unity có URP. |
| `FMODUnity.dll`, `FMODUnityResonance.dll` | Âm thanh dùng FMOD. UI MVP có thể chỉ cần load bank và phát một số event/click sound. |
| `DOTween*.dll` | Nhiều UI animation/tween có thể phụ thuộc DOTween. Nên cài DOTween hoặc thay bằng tween adapter. |
| `Firebase.*`, `Google.Play.Games.dll`, `CleverAdsSolutions.dll`, Unity IAP nếu có | Các service ngoài cần stub ở giai đoạn UI MVP, chưa tích hợp thật. |
| `Newtonsoft.Json.dll` | Dữ liệu/save/config có thể dùng JSON. Nên chọn JSON cho Data Repository mới. |

### Kết luận hiện trạng

Có đủ dữ liệu để thử phục dựng frontend trước: Unity asset data + FMOD bank + dấu hiệu URP/UI modules. Backend nên được viết lại theo contract mới, dùng thông tin IL2CPP để tham khảo tên class và luồng logic, không phụ thuộc vào việc khôi phục source C# hoàn hảo.

---

## 3. Nguyên tắc rebuild: UI-first trước, backend sau

Mục tiêu giai đoạn đầu không phải là clone toàn bộ gameplay, mà là chứng minh rằng dự án có thể được dựng lại thành một Unity project chạy được. Vì vậy luồng ưu tiên phải là frontend/UI trước.

```text
Decoded Assets + FMOD Banks
        |
        v
Unity Project mới
        |
        v
UI MVP + MockBackend
        |
        v
Frontend/Backend Contract
        |
        v
Data Repository + Backend Systems thật
        |
        v
Android Build
```

| Quy tắc | Áp dụng thực tế |
|---|---|
| Frontend không gọi backend thật trực tiếp | UI chỉ gọi qua interface `IGameBackend`. Khi backend chưa xong, dùng `MockBackend`. |
| Backend không biết UI prefab | Backend chỉ trả `Snapshot`/`Delta`; UI tự quyết định render thế nào. |
| Không chờ logic gốc mới dựng UI | Dữ liệu giả đủ để dựng Main Menu, Town Shell, Resource Bar, Build Menu, Villager Panel. |
| Chốt contract sớm | Sau khi UI cơ bản chạy, khóa schema để backend thật phải tương thích với UI đã xây. |
| Không hard-code balance trong UI | UI chỉ hiển thị; thông số tài nguyên/công trình/dân sẽ lấy từ backend hoặc JSON data. |

---

## 4. Mục tiêu UI MVP để kiểm chứng khả năng rebuild

UI MVP là bản dựng tối thiểu để trả lời câu hỏi: assets decode có thể được đưa vào Unity project mới và chạy thành game shell được hay không?

| Màn hình / module | Mục tiêu hiển thị | Dữ liệu dùng trước mắt |
|---|---|---|
| `BootScene` | Khởi tạo service, load FMOD bank, load mock config, chuyển vào Main Menu. | Mock config + audio bank. |
| `MainMenuScene` | Logo/title, nút New Game, Continue, Settings, Exit. | Mock save status. |
| `LoadingScene` | Màn chuyển cảnh, progress bar giả, tips nếu lấy được text. | Mock progress. |
| `TownScene` / Town Shell | Camera, background/map chính, thanh tài nguyên, đồng hồ ngày/đêm, bottom menu. | Mock `GameSnapshot`. |
| `ResourceBarUI` | Hiển thị wood/food/gold/stone hoặc resource tương đương lấy từ mock data. | Mock `ResourceState`. |
| `BuildMenuUI` | Danh sách công trình, cost, trạng thái lock/unlock, nút build. | Mock `BuildingDefinition`. |
| `BuildingPlacementUI` | Preview vị trí đặt nhà, confirm/cancel, feedback thiếu tài nguyên. | Mock `BuildCommand`. |
| `VillagerPanelUI` | Danh sách dân, tên, nghề, HP/hunger/morale, nút assign job. | Mock `VillagerState`. |
| `Popup/Error/Confirm` | Hộp thoại xác nhận, thông báo lỗi, tooltip. | Mock `CommandResult`. |
| `DebugOverlay` | Hiển thị scene hiện tại, backend mode, FPS, nút reset mock data. | Runtime debug. |

### Definition of Done cho UI MVP

Bản UI MVP được xem là đạt khi:

- Mở project Unity.
- Bấm `New Game`.
- Vào `TownScene`.
- Nhìn thấy resource bar.
- Mở `BuildMenuUI`.
- Click một công trình.
- Hiện preview/confirm.
- Mở `VillagerPanelUI`.
- Assign job bằng `MockBackend`.
- Build Android chạy được đến cùng flow này.

---

## 5. Cấu trúc Unity project đề xuất

Tạo project Unity sạch thay vì cố import toàn bộ folder decode như source gốc. Project cần có cấu trúc rõ ràng để tách frontend, contract và backend.

```text
Bonfire2_Rebuild/
  Assets/
    _Project/
      Art/
      Audio/
      Scenes/
        BootScene.unity
        MainMenuScene.unity
        LoadingScene.unity
        TownScene.unity
      Prefabs/
        UI/
        World/
      Scripts/
        Core/
        Contracts/
        Frontend/
        Backend/
          Mock/
          Runtime/
          Data/
      Data/
        Mock/
        Definitions/
      Tests/
  Packages/
  ProjectSettings/
```

| Thư mục | Vai trò |
|---|---|
| `Assets/_Project/Art` | Texture, sprite, material, animation clip, model đã phục dựng. |
| `Assets/_Project/Audio` | FMOD banks, audio wrapper, event references. |
| `Assets/_Project/Scenes` | Scene mới dựng lại: Boot, Main Menu, Loading, Town. |
| `Assets/_Project/Prefabs/UI` | Button, popup, panel, resource item, villager item, build card. |
| `Assets/_Project/Scripts/Contracts` | `IGameBackend`, `GameSnapshot`, `GameCommand`, `GameStateDelta`. |
| `Assets/_Project/Scripts/Frontend` | View, Presenter, UI Controller, Scene Controller. |
| `Assets/_Project/Scripts/Backend/Mock` | `MockBackend` để UI chạy độc lập. |
| `Assets/_Project/Scripts/Backend/Runtime` | Backend thật sau này. Chưa cần hoàn chỉnh ở UI MVP. |
| `Assets/_Project/Data/Mock` | JSON/mock scriptable data cho UI. |

---

## 6. Quy trình triển khai UI-first

### 6.1. Bước A — Audit assets phục vụ UI

1. Trích xuất assets từ `data.unity3d` bằng công cụ phục dựng Unity asset phù hợp.
2. Tạo `AssetManifest.csv` để ghi lại asset type, tên gốc, nhóm dùng, dependency và tình trạng import.
3. Ưu tiên assets UI trước: logo, button, panel, icon resource, icon building, font, background menu, sprite/prefab town shell.
4. Đánh dấu asset nào bị mất shader/material để thay bằng material tạm trong UI MVP.
5. Không xử lý sâu combat/exploration nếu chưa cần cho UI MVP.

| Nhóm asset ưu tiên | Cần có để qua bước UI MVP |
|---|---|
| Logo/title/menu background | Dựng Main Menu nhìn giống flow game. |
| Button/panel/icon UI | Dựng các panel cơ bản. Nếu thiếu thì dùng placeholder nhưng giữ layout. |
| Resource icons | Resource bar có icon và số lượng. |
| Building icons/cards | Build Menu có danh sách công trình. |
| Villager portrait/icon | Villager Panel có item list. |
| Font/localization text | Dùng font thay thế nếu font gốc lỗi, nhưng phải hiển thị tiếng Anh/Việt không lỗi glyph. |
| FMOD UI sounds | Âm click/open panel nếu map được. Nếu chưa map được thì bỏ qua nhưng không block UI. |

#### Checklist Bước A

- [ ] Extract hoặc liệt kê được assets từ `data.unity3d`.
- [ ] Tạo `AssetManifest.csv`.
- [ ] Xác định được ít nhất 1 background/menu asset hoặc placeholder.
- [ ] Xác định được icon resource hoặc placeholder.
- [ ] Xác định được icon building hoặc placeholder.
- [ ] Xác định được font dùng cho UI.
- [ ] Ghi danh sách asset lỗi/missing.

### 6.2. Bước B — Tạo UI style guide tạm

- Chốt resolution reference: `1920x1080 landscape`.
- `Canvas Scaler = Scale With Screen Size`.
- Tạo UI prefab base: `PrimaryButton`, `IconButton`, `Panel`, `Modal`, `ResourceItem`, `BuildCard`, `VillagerCard`.
- Tạo màu/spacing/font tạm trong `UITheme.asset` hoặc `ui_theme.json`.
- Tất cả UI view phải render được bằng mock data, không phụ thuộc backend thật.

#### Checklist Bước B

- [ ] Tạo `UITheme.asset` hoặc `ui_theme.json`.
- [ ] Tạo prefab `PrimaryButton`.
- [ ] Tạo prefab `Panel`.
- [ ] Tạo prefab `Modal`.
- [ ] Tạo prefab `ResourceItem`.
- [ ] Tạo prefab `BuildCard`.
- [ ] Tạo prefab `VillagerCard`.
- [ ] Kiểm tra responsive ở tối thiểu 16:9 và một tỷ lệ màn hình khác nếu có thể.

### 6.3. Bước C — Dựng flow scene cơ bản

```text
BootScene
  -> MainMenuScene
  -> New Game
  -> LoadingScene
  -> TownScene
      -> BuildMenuUI
      -> VillagerPanelUI
      -> SettingsPopup
      -> DebugOverlay
```

| Scene | Action kiểm thử |
|---|---|
| `BootScene` | Tự load config, init `MockBackend`, init `AudioService`, chuyển scene. |
| `MainMenuScene` | `New Game` chuyển được sang `LoadingScene`; Settings mở/đóng được. |
| `LoadingScene` | Progress bar chạy, sau đó vào `TownScene`. |
| `TownScene` | Render resource bar, day/time, mock buildings, mock villagers. |
| `BuildMenuUI` | Mở/đóng, chọn building, hiện cost, bấm Build tạo mock delta. |
| `VillagerPanelUI` | Mở danh sách dân, chọn dân, assign role/job bằng mock command. |

#### Checklist Bước C

- [ ] `BootScene` chạy đầu tiên.
- [ ] `MainMenuScene` hiển thị nút `New Game`.
- [ ] `New Game` chuyển sang `LoadingScene`.
- [ ] `LoadingScene` chuyển sang `TownScene`.
- [ ] `TownScene` có resource bar.
- [ ] `BuildMenuUI` mở/đóng được.
- [ ] `VillagerPanelUI` mở/đóng được.
- [ ] `SettingsPopup` mở/đóng được.
- [ ] `DebugOverlay` hiển thị backend mode là `MockBackend`.

### 6.4. Bước D — Tạo MockBackend để UI có dữ liệu sống

`MockBackend` là phần bắt buộc ở giữa frontend và backend thật. Nó giúp UI chạy được ngay, đồng thời buộc backend sau này phải tuân thủ cùng contract.

```csharp
public interface IGameBackend
{
    GameSnapshot GetSnapshot();
    CommandResult Execute(GameCommand command);
    event Action<GameStateDelta> OnStateChanged;
}
```

| Mock function | Mục đích UI |
|---|---|
| `GetSnapshot()` | Trả toàn bộ trạng thái giả để render `TownScene`. |
| `Execute(BuildCommand)` | Trừ resource giả, thêm building giả, phát Delta cho UI. |
| `Execute(AssignWorkerCommand)` | Đổi role/currentTask của villager giả. |
| `Execute(OpenPanelCommand)` nếu cần | Ghi analytics/debug event nội bộ, không cần backend thật. |
| `ResetMockData()` | Cho phép test UI lại từ đầu không cần restart game. |

#### Checklist Bước D

- [ ] Có file `IGameBackend.cs`.
- [ ] Có file `GameSnapshot.cs`.
- [ ] Có file `GameCommand.cs` hoặc hierarchy command tương đương.
- [ ] Có file `CommandResult.cs`.
- [ ] Có file `GameStateDelta.cs`.
- [ ] Có file `MockBackend.cs`.
- [ ] `GetSnapshot()` trả mock resources, villagers, buildings.
- [ ] `BuildCommand` làm UI cập nhật resource/building.
- [ ] `AssignWorkerCommand` làm UI cập nhật villager/job.
- [ ] `ResetMockData()` hoạt động.

### 6.5. Bước E — Build Android kiểm chứng sớm

- Target: Android, ARM64, IL2CPP, landscape, min SDK theo project gốc nếu xác định được.
- Scene order: `BootScene`, `MainMenuScene`, `LoadingScene`, `TownScene`.
- Các SDK ngoài như Firebase/Ads/Play Games để stub hoặc disable trong UI MVP.
- Mục tiêu Android MVP: app mở được, không crash, chuyển scene được, UI touch hoạt động.

#### Checklist Bước E

- [ ] Build Settings có đúng scene order.
- [ ] Android target là ARM64.
- [ ] IL2CPP bật nếu toolchain hỗ trợ.
- [ ] App mở được trên emulator/thiết bị.
- [ ] Bấm `New Game` được.
- [ ] Vào `TownScene` được.
- [ ] Touch/click UI hoạt động.
- [ ] Không crash trong flow UI MVP.

---

## 7. Contract frontend/backend cần khóa sau UI MVP

Sau khi UI cơ bản chạy bằng `MockBackend`, khóa contract để backend thật chỉ cần implement đúng các object này. Đây là cách bảo đảm backend tương thích với frontend đã xây.

| Object | Trường dữ liệu tối thiểu |
|---|---|
| `GameSnapshot` | `day`, `timeOfDay`, `resources[]`, `villagers[]`, `buildings[]`, `tasks[]`, `unlocks[]`, `uiFlags` |
| `ResourceState` | `id`, `displayName`, `iconId`, `amount`, `capacity` |
| `VillagerState` | `id`, `name`, `role`, `health`, `hunger`, `morale`, `position`, `currentTaskId`, `status` |
| `BuildingState` | `id`, `typeId`, `level`, `position`, `constructionProgress`, `workerIds[]`, `productionState` |
| `TaskState` | `id`, `type`, `targetId`, `assignedVillagerId`, `progress`, `status` |
| `CommandResult` | `success`, `errorCode`, `messageKey`, `delta` |
| `GameStateDelta` | `changedResources[]`, `changedVillagers[]`, `changedBuildings[]`, `createdTasks[]`, `removedTasks[]`, `uiEvents[]` |

| Command | Frontend dùng trong UI MVP |
|---|---|
| `StartNewGameCommand` | Main Menu bắt đầu game mới. |
| `LoadGameCommand` | Continue nếu có mock save. |
| `BuildCommand` | Build Menu -> đặt công trình. |
| `CancelBuildCommand` | Hủy placement/preview. |
| `AssignWorkerCommand` | Villager Panel -> giao việc. |
| `SelectBuildingCommand` | Click building để mở thông tin. |
| `AdvanceTimeCommand` hoặc `Tick` | DebugOverlay test day/time/resource update. |

### Điểm khóa tương thích

Frontend không được đổi contract tùy tiện sau khi UI MVP đã pass. Nếu cần thêm dữ liệu, thêm field versioned hoặc optional để backend không làm vỡ UI cũ.

---

## 8. Kế hoạch backend sau khi UI chạy được

Backend thật chỉ bắt đầu sau khi UI MVP đã chứng minh được project có thể chạy. Backend phải thay thế `MockBackend` mà không cần sửa View.

| Module backend | Nhiệm vụ | Đầu ra |
|---|---|---|
| `DataRepository` | Load dữ liệu JSON/ScriptableObject cho resource, building, villager, job, recipe. | Definitions cache + validation report. |
| `ResourceSystem` | Tính tăng/giảm tài nguyên, capacity, thiếu nguyên liệu. | `ResourceState` + `ResourceChanged` delta. |
| `BuildingSystem` | Đặt, xây, nâng cấp, hoàn thành công trình. | `BuildingState` + `BuildingPlaced/Completed` delta. |
| `VillagerSystem` | Quản lý dân, chỉ số, role/job, trạng thái. | `VillagerState` + `VillagerChanged` delta. |
| `TaskSystem` | Tạo/gán/tick task, progress, complete/fail. | `TaskState` + `TaskCompleted` delta. |
| `TimeSystem` | Ngày/đêm, tick, event theo thời gian. | `DayChanged/TimeChanged` delta. |
| `SaveSystem` | Save/load versioned local file. | `saveVersion` + save data migration. |

Backend thật phải có dạng:

```csharp
IGameBackend backend = new LocalGameBackend(dataRepository, systems);
```

UI không cần biết `LocalGameBackend` có bao nhiêu system bên trong. UI chỉ gọi `GetSnapshot()`, `Execute(command)`, và lắng nghe `OnStateChanged`.

---

## 9. Checklist nghiệm thu UI MVP

| Mã | Tiêu chí | Kết quả mong muốn | Trạng thái |
|---|---|---|---|
| UI-01 | Mở project Unity không lỗi compile nghiêm trọng. | Editor vào được `BootScene`. | [ ] |
| UI-02 | `BootScene` init được `MockBackend` và `AudioService`. | Console không có exception chặn flow. | [ ] |
| UI-03 | `MainMenuScene` hiển thị và click được `New Game`. | Chuyển sang `LoadingScene`. | [ ] |
| UI-04 | `LoadingScene` chuyển sang `TownScene`. | Progress/tip hoạt động hoặc placeholder. | [ ] |
| UI-05 | `TownScene` render `ResourceBar` từ `MockBackend`. | Số lượng resource đổi được khi mock delta phát ra. | [ ] |
| UI-06 | `BuildMenuUI` mở/đóng được. | Danh sách building mock hiện đúng icon/cost/name. | [ ] |
| UI-07 | Chọn building và confirm build. | UI nhận `BuildingPlaced` delta và spawn/hiển thị building placeholder. | [ ] |
| UI-08 | `VillagerPanelUI` mở được. | Danh sách villager mock hiện name/role/status. | [ ] |
| UI-09 | Assign worker/job bằng command. | `VillagerState` đổi role/currentTask và UI refresh đúng. | [ ] |
| UI-10 | Build Android chạy trên thiết bị/emulator. | Mở app, vào `TownScene`, thao tác UI touch không crash. | [ ] |

### Cách kết luận sau UI MVP

| Kết luận | Điều kiện |
|---|---|
| `PASS` | Assets UI chính import được, flow scene chạy, `MockBackend` tương thích, Android không crash. |
| `PASS_CÓ_RỦI_RO` | UI chạy nhưng nhiều material/shader/audio mapping lỗi; cần thêm sprint phục hồi assets. |
| `TẠM_DỪNG` | Không extract được assets UI đủ dùng, scene/prefab dependency vỡ nặng, hoặc Android build không vào được `BootScene`. |

---

## 10. Rủi ro chính và cách xử lý

| Rủi ro | Dấu hiệu | Cách xử lý |
|---|---|---|
| Mất script reference trên prefab/scene | Prefab import được nhưng `MonoBehaviour` missing. | Không cố sửa toàn bộ ngay. Dựng UI prefab mới, dùng asset hình ảnh cũ làm visual, viết script mới. |
| Shader/material lỗi | Material hồng hoặc render sai. | Map lại sang URP Lit/Sprite Unlit tạm thời; ghi danh sách shader cần phục hồi sau. |
| FMOD event không map được | Có bank nhưng không biết event name. | UI MVP cho phép dùng `AudioService` stub; audio không block UI. |
| Backend gốc không khôi phục sạch | Il2CppDumper chỉ cho dummy/stub hoặc method body khó đọc. | Dùng IL2CPP để mapping class/field/enum, viết lại systems theo contract mới. |
| Third-party SDK gây lỗi build | Firebase/Ads/Play Games thiếu config hoặc dependency. | Tắt/stub ở UI MVP; chỉ bật lại sau khi core game chạy. |
| Scope quá rộng | Muốn dựng cả combat/exploration trước khi có Town UI. | Giới hạn UI MVP: Main Menu -> Town -> Build -> Villager -> Android build. |

---

## 11. Roadmap triển khai theo sprint kỹ thuật

| Sprint | Trọng tâm | Đầu ra bắt buộc |
|---|---|---|
| Sprint 0 | Chuẩn bị project, toolchain, asset inventory. | Unity project mới + `AssetManifest.csv` + danh sách asset UI ưu tiên. |
| Sprint 1 | Dựng UI style guide và prefab base. | `PrimaryButton`, `Panel`, `Modal`, `ResourceItem`, `BuildCard`, `VillagerCard`. |
| Sprint 2 | Dựng flow scene UI. | `Boot -> Main Menu -> Loading -> Town` chạy trong Editor. |
| Sprint 3 | MockBackend và contract. | `IGameBackend` + Snapshot + Command + Delta + `MockBackend`. |
| Sprint 4 | UI gameplay cơ bản. | `ResourceBar`, `BuildMenu`, `BuildingPlacement`, `VillagerPanel` hoạt động bằng mock data. |
| Sprint 5 | Android proof build. | APK/AAB test: mở app, `New Game`, vào `Town`, thao tác UI. |
| Sprint 6 | Backend data thật. | JSON definitions + `DataRepository` + validation. |
| Sprint 7 | Backend systems lõi. | `ResourceSystem`, `BuildingSystem`, `VillagerSystem`, `TaskSystem`, `SaveSystem`. |
| Sprint 8 | Tích hợp backend thật. | `LocalGameBackend` thay `MockBackend` mà UI không phải sửa lớn. |

### Ưu tiên bắt đầu ngay

Việc đầu tiên nên làm là dựng `BootScene`, `MainMenuScene`, `LoadingScene` và `TownScene` với `MockBackend`. Nếu flow này chạy được trong Editor và Android, dự án có nền tảng rebuild khả thi. Sau đó mới đầu tư vào backend dữ liệu thật.

---

## 12. Danh sách file/deliverable cần tạo trong project

| Deliverable | Nội dung |
|---|---|
| `AssetManifest.csv` | Danh sách asset decode, type, path gốc, nhóm dùng, trạng thái import, dependency. |
| `UITheme.asset` hoặc `ui_theme.json` | Màu, font, spacing, button style, panel style. |
| `MockData.json` | Resource, villager, building, unlock, task giả để UI chạy. |
| `IGameBackend.cs` | Interface cố định giữa frontend và backend. |
| `GameSnapshot.cs` | Object trạng thái đầy đủ để UI render. |
| `GameCommand.cs` | Command từ UI gửi xuống backend. |
| `GameStateDelta.cs` | Delta backend gửi về UI khi state thay đổi. |
| `MockBackend.cs` | Backend giả phục vụ UI MVP và test UI lâu dài. |
| `SceneFlowController.cs` | Điều hướng Boot/MainMenu/Loading/Town. |
| `UI MVP APK/AAB` | Bản Android proof build để kiểm chứng. |
| `REBUILD_UI_MVP_REPORT.md` | Báo cáo kết quả cuối sau khi thực hiện/check. |

---

## 13. Gợi ý nội dung code tối thiểu cho contract

Agent có thể dùng cấu trúc bên dưới làm điểm bắt đầu. Có thể chỉnh chi tiết theo Unity version, nhưng không được phá nguyên tắc: UI chỉ biết `IGameBackend`.

### 13.1. `IGameBackend.cs`

```csharp
using System;

public interface IGameBackend
{
    GameSnapshot GetSnapshot();
    CommandResult Execute(GameCommand command);
    event Action<GameStateDelta> OnStateChanged;
}
```

### 13.2. `GameSnapshot.cs`

```csharp
using System.Collections.Generic;

[System.Serializable]
public class GameSnapshot
{
    public int day;
    public float timeOfDay;
    public List<ResourceState> resources = new();
    public List<VillagerState> villagers = new();
    public List<BuildingState> buildings = new();
    public List<TaskState> tasks = new();
    public List<string> unlocks = new();
}

[System.Serializable]
public class ResourceState
{
    public string id;
    public string displayName;
    public string iconId;
    public int amount;
    public int capacity;
}

[System.Serializable]
public class VillagerState
{
    public string id;
    public string name;
    public string role;
    public int health;
    public int hunger;
    public int morale;
    public string currentTaskId;
    public string status;
}

[System.Serializable]
public class BuildingState
{
    public string id;
    public string typeId;
    public int level;
    public float x;
    public float y;
    public float constructionProgress;
}

[System.Serializable]
public class TaskState
{
    public string id;
    public string type;
    public string targetId;
    public string assignedVillagerId;
    public float progress;
    public string status;
}
```

### 13.3. `GameCommand.cs`

```csharp
public abstract class GameCommand
{
    public string commandId;
}

public class StartNewGameCommand : GameCommand { }

public class BuildCommand : GameCommand
{
    public string buildingTypeId;
    public float x;
    public float y;
}

public class AssignWorkerCommand : GameCommand
{
    public string villagerId;
    public string taskId;
    public string role;
}

public class AdvanceTimeCommand : GameCommand
{
    public float deltaTime;
}
```

### 13.4. `CommandResult.cs`

```csharp
public class CommandResult
{
    public bool success;
    public string errorCode;
    public string messageKey;
    public GameStateDelta delta;

    public static CommandResult Ok(GameStateDelta delta = null)
    {
        return new CommandResult { success = true, delta = delta };
    }

    public static CommandResult Fail(string errorCode, string messageKey = null)
    {
        return new CommandResult
        {
            success = false,
            errorCode = errorCode,
            messageKey = messageKey
        };
    }
}
```

### 13.5. `GameStateDelta.cs`

```csharp
using System.Collections.Generic;

[System.Serializable]
public class GameStateDelta
{
    public List<ResourceState> changedResources = new();
    public List<VillagerState> changedVillagers = new();
    public List<BuildingState> changedBuildings = new();
    public List<TaskState> createdTasks = new();
    public List<string> removedTaskIds = new();
    public List<string> uiEvents = new();
}
```

---

## 14. Mẫu báo cáo cuối cho Anti/agent

Khi hoàn tất, tạo file `REBUILD_UI_MVP_REPORT.md` theo mẫu sau:

```markdown
# REBUILD UI MVP REPORT

## 1. Thông tin chạy thử

- Ngày thực hiện:
- Unity version:
- Target platform:
- Máy/emulator test:
- Commit/branch nếu có:

## 2. Kết luận tổng thể

Kết luận: PASS / PASS_CÓ_RỦI_RO / TẠM_DỪNG

Tóm tắt 3-5 dòng:

## 3. Những gì đã tạo được

- [ ] Unity project mới
- [ ] AssetManifest.csv
- [ ] BootScene
- [ ] MainMenuScene
- [ ] LoadingScene
- [ ] TownScene
- [ ] ResourceBarUI
- [ ] BuildMenuUI
- [ ] VillagerPanelUI
- [ ] DebugOverlay
- [ ] MockBackend
- [ ] Android build

## 4. Kết quả test UI MVP

| Mã | Tiêu chí | Pass/Fail | Ghi chú |
|---|---|---|---|
| UI-01 | Mở project Unity không lỗi compile nghiêm trọng |  |  |
| UI-02 | BootScene init được MockBackend và AudioService |  |  |
| UI-03 | MainMenuScene click được New Game |  |  |
| UI-04 | LoadingScene chuyển sang TownScene |  |  |
| UI-05 | TownScene render ResourceBar từ MockBackend |  |  |
| UI-06 | BuildMenuUI mở/đóng được |  |  |
| UI-07 | Confirm build tạo BuildingPlaced delta |  |  |
| UI-08 | VillagerPanelUI mở được |  |  |
| UI-09 | Assign worker/job bằng command |  |  |
| UI-10 | Android build chạy được |  |  |

## 5. Assets import/phục dựng được

| Nhóm asset | Kết quả | Ghi chú |
|---|---|---|
| Logo/menu background |  |  |
| Button/panel/icon UI |  |  |
| Resource icons |  |  |
| Building icons |  |  |
| Villager icons/portrait |  |  |
| Font/localization |  |  |
| FMOD bank/audio |  |  |

## 6. Lỗi/rủi ro còn lại

| Mức độ | Vấn đề | Cách xử lý đề xuất |
|---|---|---|
| High |  |  |
| Medium |  |  |
| Low |  |  |

## 7. File chính đã tạo/sửa

- `Assets/_Project/Scripts/Contracts/...`
- `Assets/_Project/Scripts/Backend/Mock/...`
- `Assets/_Project/Scripts/Frontend/...`
- `Assets/_Project/Scenes/...`
- `Assets/_Project/Data/Mock/...`

## 8. Bước tiếp theo đề xuất

1. 
2. 
3. 
```

---

## 15. Kết luận triển khai

**Kết luận chính:** Project có cơ sở để thử rebuild theo hướng UI-first vì gói decode có Unity asset data, FMOD bank, IL2CPP metadata và native binary đầy đủ. Tuy nhiên, không nên bắt đầu bằng backend hay cố phục hồi toàn bộ C# trước. Hãy dựng frontend/UI MVP trước bằng Unity project mới, chạy bằng `MockBackend`, sau đó khóa contract và viết backend thật tương thích với UI đã xây.

**Thước đo thành công đầu tiên:** Một build Android có thể mở Main Menu, bấm `New Game`, vào `TownScene`, hiển thị resource/villager/build menu và xử lý vài command mock. Khi đạt được mốc này, việc rebuild tiếp backend/data sẽ có nền tảng kỹ thuật rõ ràng hơn nhiều.
