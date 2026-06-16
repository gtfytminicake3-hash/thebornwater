# Next Sprint: Backend Runtime & Deep Decoded Integration Plan

Dựa trên prototype UI-First MockBackend vừa được generate thành công, Sprint tiếp theo sẽ chuyển trọng tâm sang **Logic Engine** và **Real Assets**.

## 1. Mục tiêu (Goals)
1. **Real Data Runtime:** Loại bỏ `MockBackend`, thay thế bằng `CoreBackend` với hệ thống quản lý Entity/Component C# độc lập hoàn toàn với Monobehaviour.
2. **Decode Asset Full Mapping:** Tự động map ~1100 assets từ `ImportedDecoded` vào UI prefabs.
3. **Logic Loop:** Viết hệ thống `TickSystem` cho tài nguyên (Wood, Food) và Villager tasks (Gather, Build, Rest).

## 2. Kiến trúc Backend Runtime

### State Management
Sử dụng mô hình Event-Sourced hoặc Reactive State:
- `WorldState`: Chứa `Dictionary<string, Entity>` thay vì list tĩnh.
- `Entities`: Các class Data (không Monobehaviour) bao gồm `VillagerEntity`, `BuildingEntity`, `ResourceEntity`.
- `GameTick`: Update loop tính bằng millisecond (Backend time) không phụ thuộc vào `Time.deltaTime` của Unity.

### Data Layer
- **Def Parser:** Viết logic đọc dữ liệu từ `global-metadata.dat` strings hoặc parse file nhị phân IL2CPP dump (nếu chạy được Il2CppDumper thực sự qua Frida hoặc script ngoài).
- **Save/Load System:** Lưu `WorldState` ra định dạng JSON/Binary giống như game gốc.

## 3. Các bước thực thi chính (Milestones)

### Phase 1: Engine Skeleton
- [ ] Khởi tạo thư mục `Assets/_Project/Scripts/Backend/Engine/`.
- [ ] Khởi tạo hệ thống Tick `GameTimeManager`.
- [ ] Khởi tạo `EntityRegistry` quản lý ID và mapping.

### Phase 2: System Implementations
- [ ] **Resource System:** Tăng/giảm resource dựa trên worker roles.
- [ ] **Task System:** Thuật toán phân rã công việc cho Villagers (Tương tự game The Bonfire 2 gốc).
- [ ] **Combat System (Stub):** Base layer cho Enemy/Villager combat dựa trên keyword hits.

### Phase 3: Data-Driven UI Binding
- [ ] Viết bộ `ReactiveBinder<T>` để UI (Presenter) lắng nghe sự thay đổi của field (vd: `Resource.Wood.Amount`) thay vì reload toàn bộ List như MockBackend.
- [ ] Chạy Asset-Mapping script (RebuildSceneGenerator mở rộng) để tự động tạo LayoutGroup và load full Decoded Sprite.

## 4. Nguy cơ tiềm ẩn (Risks)
- **Thiếu logic chi tiết:** Do chưa dump được IL2CPP logic hoàn chỉnh (chỉ mới có metadata strings), các công thức toán học (ví dụ: lượng gỗ thu thập mỗi giây, tốc độ đi bộ) sẽ phải đoán hoặc tự build lại (clean-room design).
- **Giải pháp:** Sử dụng công cụ proxy để track RAM, hoặc chấp nhận làm một phiên bản "Clone Mechanics" theo trí nhớ và clip gameplay YouTube.
