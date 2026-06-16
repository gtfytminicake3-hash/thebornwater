# Manual Play Test Checklist (UI-First MVP)

Do agent bị timeout khi run Play Mode qua MCP, bạn vui lòng chạy các bước sau trên máy tính của bạn để xác nhận Prototype đã hoạt động end-to-end.

## Bước 1: Mở Project & Scene
- [ ] Mở Unity Hub, chạy project `D:\Tinh\TheBonwater` bằng Unity 6 (6000.3.17f1).
- [ ] Trong Project window, điều hướng đến `Assets/_Project/Scenes`.
- [ ] Double-click mở `BootScene.unity`.
- [ ] Đảm bảo GameObject `GameBootstrap` tồn tại và có script đính kèm.

## Bước 2: Khởi động Game (Boot -> Main Menu)
- [ ] Nhấn nút **PLAY** (▶️) trong Unity Editor.
- [ ] *Kiểm chứng:* Scene có tự động chuyển đổi sang `MainMenuScene` không?
- [ ] *Kiểm chứng:* Trong MainMenuScene, màn hình có các nút "New Game" và "Load Game" không?
- [ ] *Kiểm chứng:* Nền UI có chứa sprite decoded (ví dụ hình `academy.png` hoặc `AccentBar`) được load không?

## Bước 3: Flow Vào Game (Main Menu -> Town)
- [ ] Nhấn nút **"New Game"** trên màn hình Main Menu.
- [ ] *Kiểm chứng:* Game chuyển sang `LoadingScene` và sau vài giây sang `TownScene`.

## Bước 4: Kiểm tra Town UI & MockBackend Data
Tại `TownScene`, kiểm tra các luồng dữ liệu hiển thị trên màn hình:
- [ ] **Resource Bar:** Nhìn thấy "Resources: Wood: 100/500".
- [ ] **Villager List:** Nhìn thấy "Bryn (Idle) - HP:100".
- [ ] **Building List:** Nhìn thấy "Hut Lv.1".

## Bước 5: Thao tác UI Trigger Command
- [ ] **Collect Resource Button:** Click nút `btnCollect`.
  - *Kết quả mong đợi:* Trong console có thể log event, hoặc `ResourceBarView` chớp reload, hoặc Villager `Bryn` chuyển role thành `Gatherer`.
- [ ] **Assign Worker Button:** Click nút `btnAssign` trên Villager.
  - *Kết quả mong đợi:* Trạng thái Role của Villager chuyển thành `Builder` trên UI.
- [ ] **Advance Time Button:** Click nút `AdvanceTime`.
  - *Kết quả mong đợi:* Gửi event `AdvanceTimeCommand`.

## Ghi chú cho Dev:
- Nếu UI hiển thị thiếu ảnh, kiểm tra Console xem `Resources.Load` hoặc `AssetDatabase.LoadAssetAtPath` có warning không.
- Nếu không click được UI, kiểm tra `EventSystem` GameObject có tồn tại trong Scene hiện tại không.
