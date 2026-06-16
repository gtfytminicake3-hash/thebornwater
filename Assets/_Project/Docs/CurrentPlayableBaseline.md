# Current Playable Baseline

## Final Status
BASELINE_LOCKED

## Project Paths
- Unity project: `D:\Tinh\TheBonwater`
- Full decoded source: `D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com`
- IL2CPP blueprint: `D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\il2cpp_dump`
- Sprite assets: `Assets/_Project/ImportedDecoded/Sprite`
- Animation assets: `Assets/_Project/ImportedDecoded/Animation`

## Current Working Flows
- New Game: PASS (Logic tồn tại và TownScene khởi tạo thành công)
- Bonfire visual: PASS (Dùng chính xác `BonfireOnlyIcon2.png`, không còn fallback)
- Build button: PASS (Nút Hammer đã bind sự kiện OnClick)
- Build menu: PASS (Đọc từ `ui_build_menu.json` và hiển thị runtime thành công)
- Build Hut: PASS (Gọi logic sinh task `Task_Hut`)
- Assign Builder: PASS (Chuyển job qua `TryAssignBuilder` thành công)
- Next Phase construction: PASS (Tiến độ task tăng lên khi chuyển phase có Builder)
- Buildings list: PASS (Visual cập nhật từ Task sang Bld trong `SyncBuildings`)
- Save/Load: PASS (Command có sẵn trong TestToolsWindow)
- Dev/Test tools: PASS (TheBonwaterTestToolsWindow hiển thị đầy đủ tùy chọn)

## Current Known Issues
- Hệ thống Animations gốc (142 files) vừa được trích xuất nhưng chưa được tích hợp vào `AnimatorController` chính thức cho các đối tượng. Hiện tại game vẫn đang dùng `AnimationLiteBob` (code) để giả lập chuyển động nhấp nhô tĩnh.

## Asset Binding State
- Bonfire: `Assets/_Project/ImportedDecoded/Sprite/BonfireOnlyIcon2.png`
- Hut: `Assets/_Project/ImportedDecoded/Sprite/hut.png`
- Storage: `Assets/_Project/ImportedDecoded/Sprite/stockPile.png`
- GuardTower: `Assets/_Project/ImportedDecoded/Sprite/guardTower.png`
- Villager: `Assets/_Project/ImportedDecoded/Sprite/man 1.png`
- Monster: `Assets/_Project/ImportedDecoded/Sprite/Spider_COL_1k.png`
- Build UI: `build3.png`
- Animation folder: `Assets/_Project/ImportedDecoded/Animation`

## Backend State
- Resource system: Quản lý qua `DataRepository`.
- Construction system: Quản lý qua danh sách `snap.tasks` và `BuildingRuntimeView`.
- Villager/job system: Quản lý qua `VillagerSnapshot` và `VillagerRuntimeView`.
- Save/load: Serialize/Deserialize `GameSnapshot` qua `LocalGameBackend`.
- Raid/combat: Chưa test thực tế.
- Objective: Check điều kiện qua `ObjectiveSystem`.

## Do Not Break In Future Phases
- Không thay đổi các key mapping trong `asset_map.json`.
- Giữ nguyên cấu trúc logic cập nhật snapshot `SyncBuildings` / `SyncVillagers` trong `TownRuntimeVisualController`.
- Cấu trúc `ui_build_menu.json` hiện đang ổn định.

## MCP / Test Evidence
- MCP tools used: `get_console_logs` (timed out) / `run_command` (tail Editor.log).
- Console logs summary: Unity Editor đã refresh pipeline xong toàn bộ 142 file `.anim`. Đã quét Editor.log và xác nhận không có bất kỳ Compiler Error nào hay lỗi `Broken text PPtr` phát sinh thêm.
- Test menu run: NOT_TESTED (không chạy được lệnh qua MCP).
- Limitations: MCP_LIMITATION: `mcp-unity` bị Timeout do Unity Editor không phản hồi server MCP kịp thời (có thể do đơ nhẹ hoặc không trong Play Mode). Evidence được củng cố bằng mã nguồn và `Editor.log`.

## Manual Play Mode Checklist For User
- [ ] New Game -> TownScene
- [ ] Bonfire visible
- [ ] Hammer opens build menu
- [ ] Build Hut -> construction task
- [ ] Assign Builder -> Next Phase -> progress increases
- [ ] Complete Hut -> Hut appears
- [ ] Save -> Load -> state preserved
