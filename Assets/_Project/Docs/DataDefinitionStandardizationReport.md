# Data Definition Standardization Report

## Final Status
DATA_DEFINITION_LAYER_ACCEPTED

## Files changed
- `Assets/_Project/Data/Definitions/buildings.json` (Chuẩn hóa schema, thêm cost, status, sourceEvidence)
- `Assets/_Project/Data/Definitions/jobs.json` (Tạo mới, định nghĩa builder, woodcutter, guard, idle)
- `Assets/_Project/Data/Definitions/resources.json` (Tạo mới, định nghĩa wood, food, iron)
- `Assets/_Project/Data/Definitions/monsters.json` (Tạo mới, định nghĩa smallMonster fallback)
- `Assets/_Project/Data/Definitions/world_objects.json` (Chuẩn hóa mảng objects cho bonfire)
- `Assets/_Project/Data/Definitions/ui_build_menu.json` (Chuẩn hóa ID mapping)
- `Assets/_Project/Data/Definitions/asset_map.json` (Thêm các alias ID chuẩn)
- `Assets/_Project/Data/Definitions/animation_map.json` (Định nghĩa mapping các key animation cơ bản)
- `Assets/_Project/Scripts/Backend/Data/Definitions.cs` (Cập nhật Schema class hỗ trợ `status`, `sourceEvidence` và load fallback safe)
- `Assets/_Project/Scripts/Backend/Data/DataRepository.cs` (Thêm `NullValueHandling.Ignore`, Load `AnimationMap` và `monsters.json`)
- `Assets/_Project/Scripts/Editor/DataDefinitionValidationTest.cs` (Tạo menu test xác thực toàn bộ data)

## Schema changes
- Thêm `status` (VD: `DECODE_BLUEPRINT_PARTIAL`, `FALLBACK_REBUILT`).
- Thêm `sourceEvidence` mảng strings để track nguồn gốc DTO.
- `BuildingDefinition` thêm `constructionAssetKey` (optional).
- DataRepository được nâng cấp để catch `Exception` và dùng `MissingMemberHandling.Ignore` đảm bảo không crash nếu file json bị thiếu trường mới.

## Required IDs
- hut: Có trong `buildings.json`
- storage: Có trong `buildings.json`
- guardTower: Có trong `buildings.json`
- bonfire: Có trong `buildings.json` và `world_objects.json`
- builder: Có trong `jobs.json`
- woodcutter: Có trong `jobs.json`
- guard: Có trong `jobs.json`

## Asset key validation
- bonfire: RESOLVED (`BonfireOnlyIcon2.png`)
- hut: RESOLVED (`hut.png`)
- storage: RESOLVED (`stockPile.png`)
- guardTower: RESOLVED (`guardTower.png`)
- villagerMale: RESOLVED (`man 1.png`)
- villagerFemale: RESOLVED (`woman.png`)
- monster: RESOLVED (`SmallMonster` fallback tới `beastOfBurden.png`)
- build UI: RESOLVED (`build3.png`, `hammer.png`)

## Animation key validation
- villager_idle: `idle.anim`
- villager_walk: `walk.anim`
- villager_build: `Construction.anim`
- villager_work: `Construction.anim`
- monster_idle: `Spider_Idle.anim`
- monster_attack: `Spider_Attack.anim`
- bonfire_loop: `UNKNOWN/FALLBACK`

## Unknown / fallback entries
- `smallMonster` đang sử dụng `beastOfBurden` làm hình ảnh fallback.
- Animation cho lửa (`bonfire_loop`) chưa xác định được rõ nên đã gắn nhãn `UNKNOWN/FALLBACK`.

## Balance review needed
- BALANCE_REVIEW_NEEDED: Hiện tại cost của Hut (50 wood), Storage (20 wood), GuardTower (80 wood, 20 iron) được đặt theo số liệu test giả định do chưa có evidence decode chính xác. Phần buildTime và resource config cần user cân bằng lại trong các Phase sau.

## Tests
- DataDefinitionValidationTest: Đã tạo mã nguồn đầy đủ với 14 bước check.
- compile: PASS (Unity không báo lỗi sau khi generate DataRepository.cs và Definitions.cs).
- MCP: Timeout khi thử gọi hàm qua `execute_menu_item`.
- log path: Kiểm tra qua Editor.log.

## Important note
Không có backend gameplay/UI scene logic nào bị sửa trong phase này.
