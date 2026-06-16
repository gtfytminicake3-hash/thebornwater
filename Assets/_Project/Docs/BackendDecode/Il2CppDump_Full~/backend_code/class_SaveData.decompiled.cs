public class SaveData
{
	[Token(Token = "0x4000F95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string lastPlayed;

	[Token(Token = "0x4000F96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int chunkWidth;

	[Token(Token = "0x4000F97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int chunkHeight;

	[Token(Token = "0x4000F98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ChunkType[] mapChunks;

	[Token(Token = "0x4000F99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int groundTilesWidth;

	[Token(Token = "0x4000F9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int groundTilesHeight;

	[Token(Token = "0x4000F9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TileType[] groundTiles;

	[Token(Token = "0x4000F9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool[] areasUnlocked;

	[Token(Token = "0x4000F9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int gameDays;

	[Token(Token = "0x4000F9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public RandomEvents todaysEvent;

	[Token(Token = "0x4000F9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float currentDayTime;

	[Token(Token = "0x4000FA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float snowValue;

	[Token(Token = "0x4000FA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float rainValue;

	[Token(Token = "0x4000FA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<PlacedBuilding> placedBuildingsData;

	[Token(Token = "0x4000FA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<WorkerData> newSpawn;

	[Token(Token = "0x4000FA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<WorkerData> workers;

	[Token(Token = "0x4000FA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<WorkerData> thieves;

	[Token(Token = "0x4000FA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<WorkerData> possessed;

	[Token(Token = "0x4000FA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AgentType spawnTonight;

	[Token(Token = "0x4000FA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<WorkerData> attackingMonsters;

	[Token(Token = "0x4000FA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public AgentType spawnToday;

	[Token(Token = "0x4000FAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<WorkerData> roamingAnimals;

	[Token(Token = "0x4000FAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<WorkerData> workerCorpse;

	[Token(Token = "0x4000FAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<WorkerData> monsterCorpse;

	[Token(Token = "0x4000FAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<WorkerData> theifCorpse;

	[Token(Token = "0x4000FAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<WorkerData> possessedCorpse;

	[Token(Token = "0x4000FAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<WorkerData> animalCorpse;

	[Token(Token = "0x4000FB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<TradeRoute> tradeRoutes;

	[Token(Token = "0x4000FB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float tradeCooldown;

	[Token(Token = "0x4000FB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isStrangerPresent;

	[Token(Token = "0x4000FB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public WorkerData stranger;

	[Token(Token = "0x4000FB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public StrangerType strangerType;

	[Token(Token = "0x4000FB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public bool isLootDropped;

	[Token(Token = "0x4000FB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public CustomVector3 lootDropPos;

	[Token(Token = "0x4000FB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool isLootSelected;

	[Token(Token = "0x4000FB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public Item lootContains;

	[Token(Token = "0x4000FB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<DroppedResource> dropResourceInstances;

	[Token(Token = "0x4000FBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public WorldMapTile[] worldTiles;

	[Token(Token = "0x4000FBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public WorldTileSaveData[] tileData;

	[Token(Token = "0x4000FBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public ShipOnExpedition ships;

	[Token(Token = "0x4000FBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public bool[] discovered;

	[Token(Token = "0x4000FBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public int questStatus;

	[Token(Token = "0x4000FBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public WorkerData titanData;

	[Token(Token = "0x4000FC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public bool isTitanSummoned;

	[Token(Token = "0x4000FC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public AcademyBuildingData academyBuildingData;

	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x16A8140", Offset = "0x16A4140", VA = "0x16A8140")]
	public SaveData()
	{
	}

	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x16A824C", Offset = "0x16A424C", VA = "0x16A824C")]
	public SaveData(ChunkType[,] mapChunksArg, TileType[,] groundTilesArg, bool[] areasUnlockedArg, int days, float currentTime, RandomEvents currentEvent, float snowArg, List<PlacedBuilding> placedBuildings, List<WorkerData> newWorkersArg, List<WorkerData> workersArg, List<WorkerData> thievesArg, List<WorkerData> possessedArg, AgentType spawnTonightArg, List<WorkerData> attackingMonstersArg, AgentType spawnTodayArg, List<WorkerData> roamingAnimalsArg, List<WorkerData> workerCorpseArg, List<WorkerData> monsterCorpseArg, List<WorkerData> theifCorpseArg, List<WorkerData> animalCorpseArg, List<WorkerData> possessedCorpseArg, List<TradeRoute> tradeRoutesArg, bool isStrangerPresentArg, WorkerData strangerArg, StrangerType strangerTypeArg, bool isLootDroppedArg, CustomVector3 lootDropPosArg, bool isLootSelectedArg, Item lootContainsArg, List<DropResource> dropResourceInstancesArg, WorldMapTile[] worldTilesArg, WorldTileSaveData[] tileDataArg, ShipOnExpedition shipsArg, bool[] discoveredArg, int questStatusArg, AIAgent titan, bool isTitanSummonedArg, AcademyBuildingData academyBuildingData)
	{
	}

	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x16A89DC", Offset = "0x16A49DC", VA = "0x16A89DC")]
	public WorldTileSaveData GetHomeData()
	{
		return null;
	}

	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x16A8A08", Offset = "0x16A4A08", VA = "0x16A8A08")]
	public PlacedBuilding GetPlacedBuilding(Building b)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000216")]
public enum SaveSlots
{
	[Token(Token = "0x4000FC3")]
	Slot1,
	[Token(Token = "0x4000FC4")]
	Slot2,
	[Token(Token = "0x4000FC5")]
	Slot3,
	[Token(Token = "0x4000FC6")]
	Slot4,
	[Token(Token = "0x4000FC7")]
	Slot5,
	[Token(Token = "0x4000FC8")]
	none
}
[Serializable]
[Token(Token = "0x2000217")]