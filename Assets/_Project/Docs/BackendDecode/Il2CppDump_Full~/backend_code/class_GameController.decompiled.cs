public class GameController : MonoBehaviour
{
	[Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class <TickGameSecond>d__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameController <>4__this;

		[Token(Token = "0x17000090")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x1761838", Offset = "0x175D838", VA = "0x1761838", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1761878", Offset = "0x175D878", VA = "0x1761878", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x175EF50", Offset = "0x175AF50", VA = "0x175EF50")]
		[DebuggerHidden]
		public <TickGameSecond>d__73(int <>1__state)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x17616FC", Offset = "0x175D6FC", VA = "0x17616FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x1761700", Offset = "0x175D700", VA = "0x1761700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x1761840", Offset = "0x175D840", VA = "0x1761840", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000134")]
	[CompilerGenerated]
	private sealed class <TickRealSecond>d__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameController <>4__this;

		[Token(Token = "0x17000092")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x1761A74", Offset = "0x175DA74", VA = "0x1761A74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x1761AB4", Offset = "0x175DAB4", VA = "0x1761AB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x175F4FC", Offset = "0x175B4FC", VA = "0x175F4FC")]
		[DebuggerHidden]
		public <TickRealSecond>d__75(int <>1__state)
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x1761880", Offset = "0x175D880", VA = "0x1761880", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1761884", Offset = "0x175D884", VA = "0x1761884", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1761A7C", Offset = "0x175DA7C", VA = "0x1761A7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameController mInstance;

	[Token(Token = "0x40007D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isDemo;

	[Token(Token = "0x40007D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public MainQuest questStatus;

	[Token(Token = "0x40007D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string difficultyString;

	[Token(Token = "0x40007DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Difficulty currentDifficulty;

	[Token(Token = "0x40007DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public DifficultyData[] difficulty;

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int day;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Snow snowSystem;

	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Rain rainSystem;

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Beams sunBeam;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RandomEvents todaysEvent;

	[Token(Token = "0x40007E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public AgentType spawnTonight;

	[Token(Token = "0x40007E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int numberToSpawn;

	[Token(Token = "0x40007E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int numberOfBoss;

	[Token(Token = "0x40007E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int numberOfWorkers;

	[Token(Token = "0x40007E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public BuildingData buildingData;

	[Token(Token = "0x40007E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ResourceData resourceData;

	[Token(Token = "0x40007E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ItemData itemData;

	[Token(Token = "0x40007E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public JobData jobData;

	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public SkillData skillData;

	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public WorldMapData islandData;

	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public CharacterData characterData;

	[Token(Token = "0x40007EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public AnimalManager animalManagerInstance;

	[Token(Token = "0x40007ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public WorkerManager workerManagerInstance;

	[Token(Token = "0x40007EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public MonsterManager monsterManagerInstance;

	[Token(Token = "0x40007EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TradeManager tradeManagerInstance;

	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public CharacterManager characterManagerInstance;

	[Token(Token = "0x40007F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GroundObjectLocations groundObjectInstance;

	[Token(Token = "0x40007F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public WorldMusic musicPlayerInstance;

	[Token(Token = "0x40007F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public DayNightMusic dayNightSounds;

	[Token(Token = "0x40007F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public DayNightController dayNightControllerInstance;

	[Token(Token = "0x40007F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public SunMoonDisplay sunMoonInstance;

	[Token(Token = "0x40007F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public CameraMovement camControls;

	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public WorldMapTile[] tinyTiles;

	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public WorldTileSaveData[] worldIslandStatus;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public ShipOnExpedition shipsOnTheSea;

	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public WorldMapDungeonData WorldMapDungeonData;

	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public DropResource dropPrefab;

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public List<DropResource> dropResourceInstances;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public int numberOfCorpses;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public DropResource mTargetDrop;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public TurnOnOffDayNight dayNightOnOff;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public FogMist fogAndMist;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Material windowGlow;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private float temperature;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public FloatingTextManager floatingTextManagerInstance;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public AcademyBuildingData academyBuildingData;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private bool[] discovered;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private BuildingInstance targetBuilding;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private bool showSunBeam;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private SaveData loadedData;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool nekronFightComplete;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private GameObject[] objectsToDisableForLowSettings;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public bool doNotDropResourcesOnTheGround;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private GroundObjectLocations groundObjectLocations;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private bool pauseDayCycle;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private int alternate;

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x175B190", Offset = "0x1757190", VA = "0x175B190")]
	public SaveData GetLoadedData()
	{
		return null;
	}

	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x175B198", Offset = "0x1757198", VA = "0x175B198")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x175B3EC", Offset = "0x17573EC", VA = "0x175B3EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x175D780", Offset = "0x1759780", VA = "0x175D780")]
	public static GameController GetInstance()
	{
		return null;
	}

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x175D7D8", Offset = "0x17597D8", VA = "0x175D7D8")]
	public bool StrongWinds()
	{
		return default(bool);
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x175D81C", Offset = "0x175981C", VA = "0x175D81C")]
	public int GetDay()
	{
		return default(int);
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x175D824", Offset = "0x1759824", VA = "0x175D824")]
	public AcademyBuildingData GetAcademyBuildingData()
	{
		return null;
	}

	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x175D924", Offset = "0x1759924", VA = "0x175D924")]
	private void UpdateShipOnWorldMap()
	{
	}

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x175CC34", Offset = "0x1758C34", VA = "0x175CC34")]
	private void DecideEvent()
	{
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x175DC80", Offset = "0x1759C80", VA = "0x175DC80")]
	public void OnChangeHour(int worldTime)
	{
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x175E27C", Offset = "0x175A27C", VA = "0x175E27C")]
	public void OnDawn()
	{
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x175D258", Offset = "0x1759258", VA = "0x175D258")]
	private int GetMusicEra()
	{
		return default(int);
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x175EAD8", Offset = "0x175AAD8", VA = "0x175EAD8")]
	public int GetMaxWorkers()
	{
		return default(int);
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x175EB60", Offset = "0x175AB60", VA = "0x175EB60")]
	public void OnDay()
	{
	}

	[Token(Token = "0x60008B6")]
	[Address(RVA = "0x175EC58", Offset = "0x175AC58", VA = "0x175EC58")]
	public void OnDusk()
	{
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x175EEE0", Offset = "0x175AEE0", VA = "0x175EEE0")]
	public void OnNight()
	{
	}

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x175EF48", Offset = "0x175AF48", VA = "0x175EF48")]
	public void PauseDayCycle(bool value)
	{
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x175D384", Offset = "0x1759384", VA = "0x175D384")]
	[IteratorStateMachine(typeof(<TickGameSecond>d__73))]
	private IEnumerator TickGameSecond()
	{
		return null;
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x175EF78", Offset = "0x175AF78", VA = "0x175EF78")]
	private void CheckAndAddResourceIfStorageSpaceIsFound()
	{
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x175D324", Offset = "0x1759324", VA = "0x175D324")]
	[IteratorStateMachine(typeof(<TickRealSecond>d__75))]
	private IEnumerator TickRealSecond()
	{
		return null;
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x175F524", Offset = "0x175B524", VA = "0x175F524")]
	private void Update()
	{
	}

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x175E0CC", Offset = "0x175A0CC", VA = "0x175E0CC")]
	private void OnPurchaseCheck()
	{
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x175F6FC", Offset = "0x175B6FC", VA = "0x175F6FC")]
	public void OnPurchaseManagerSuccess()
	{
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x175F708", Offset = "0x175B708", VA = "0x175F708")]
	public void OnPurchaseManagerRevertBack()
	{
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x175CA24", Offset = "0x1758A24", VA = "0x175CA24")]
	public void DropResource(Vector3 position, Resource type, int remainingQuantity, int maxQuantity)
	{
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x175F760", Offset = "0x175B760", VA = "0x175F760")]
	public List<DropResource> GetResourceTargets()
	{
		return null;
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x175F768", Offset = "0x175B768", VA = "0x175F768")]
	public int[,] GetDroppedResourceLocations(Resource resource)
	{
		return null;
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x175FA90", Offset = "0x175BA90", VA = "0x175FA90")]
	public void OnFinishPickingUpDroppedResource(DropResource droppedResource)
	{
	}

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x175FCE4", Offset = "0x175BCE4", VA = "0x175FCE4")]
	public int[,] GetCorpsePositions()
	{
		return null;
	}

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x17600D4", Offset = "0x175C0D4", VA = "0x17600D4")]
	public int GetCorpseTarget()
	{
		return default(int);
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x17600DC", Offset = "0x175C0DC", VA = "0x17600DC")]
	public void RemoveCorpseTarget()
	{
	}

	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x17600EC", Offset = "0x175C0EC", VA = "0x17600EC")]
	public void InteractWith(AIAgent agent)
	{
	}

	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x17608A8", Offset = "0x175C8A8", VA = "0x17608A8")]
	public DropItem GetDroppedLoot()
	{
		return null;
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x17608C0", Offset = "0x175C8C0", VA = "0x17608C0")]
	public void OnFinishPickingUpDroppedLoot()
	{
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x17608D8", Offset = "0x175C8D8", VA = "0x17608D8")]
	public void DestroyBuilding(BuildingInstance instance, int x, int y, float rotation)
	{
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x175D2A0", Offset = "0x17592A0", VA = "0x175D2A0")]
	public void SetCameraLimit()
	{
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x175F4C8", Offset = "0x175B4C8", VA = "0x175F4C8")]
	public void DiscoverResource(Resource newlyDiscovered)
	{
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x176094C", Offset = "0x175C94C", VA = "0x176094C")]
	public bool isResourceDiscovered(Resource r)
	{
		return default(bool);
	}

	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x176097C", Offset = "0x175C97C", VA = "0x176097C")]
	public bool[] GetResourceDiscoveredStatus()
	{
		return null;
	}

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x1760984", Offset = "0x175C984", VA = "0x1760984")]
	public void LoadWorldMap()
	{
	}

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x1760B20", Offset = "0x175CB20", VA = "0x1760B20")]
	public WorldTileSaveData GetSaveDataOfHome()
	{
		return null;
	}

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x1760B4C", Offset = "0x175CB4C", VA = "0x1760B4C")]
	public BuildingInstance GetTargetBuilding(AIAgent agent)
	{
		return null;
	}

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x1760EDC", Offset = "0x175CEDC", VA = "0x1760EDC")]
	public void HideAllCharacters()
	{
	}

	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x1760EE0", Offset = "0x175CEE0", VA = "0x1760EE0")]
	public void ShowAllCharacters()
	{
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x1760EE4", Offset = "0x175CEE4", VA = "0x1760EE4")]
	public void UpdateQuestStatusAndShowCutscene(MainQuest quest, int scene)
	{
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x176104C", Offset = "0x175D04C", VA = "0x176104C")]
	public void CheckForDungeonData()
	{
	}

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x175D3E4", Offset = "0x17593E4", VA = "0x175D3E4")]
	private void CheckForDungeonResourcesAndItems()
	{
	}

	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x17614CC", Offset = "0x175D4CC", VA = "0x17614CC")]
	public GameController()
	{
	}
}
[Token(Token = "0x2000135")]
public enum Item
{
	[Token(Token = "0x4000818")]
	Torch,
	[Token(Token = "0x4000819")]
	Cart,
	[Token(Token = "0x400081A")]
	ArmoredShip,
	[Token(Token = "0x400081B")]
	Spear,
	[Token(Token = "0x400081C")]
	Pickaxe,
	[Token(Token = "0x400081D")]
	Axe,
	[Token(Token = "0x400081E")]
	Sickle,
	[Token(Token = "0x400081F")]
	SteelSword,
	[Token(Token = "0x4000820")]
	BowAndArrow,
	[Token(Token = "0x4000821")]
	FireSword,
	[Token(Token = "0x4000822")]
	Shield,
	[Token(Token = "0x4000823")]
	IronArmor,
	[Token(Token = "0x4000824")]
	SteelArmor,
	[Token(Token = "0x4000825")]
	SolarArmor,
	[Token(Token = "0x4000826")]
	WoodenShip,
	[Token(Token = "0x4000827")]
	SteamShip,
	[Token(Token = "0x4000828")]
	Hammer,
	[Token(Token = "0x4000829")]
	SolarSpear,
	[Token(Token = "0x400082A")]
	SolarShield,
	[Token(Token = "0x400082B")]
	NekronStaff
}
[Token(Token = "0x2000136")]
public enum ItemType
{
	[Token(Token = "0x400082D")]
	Shield,
	[Token(Token = "0x400082E")]
	Cart,
	[Token(Token = "0x400082F")]
	Bag,
	[Token(Token = "0x4000830")]
	RangedWeapon,
	[Token(Token = "0x4000831")]
	MeleeWeapons,
	[Token(Token = "0x4000832")]
	Farming,
	[Token(Token = "0x4000833")]
	Hammer,
	[Token(Token = "0x4000834")]
	Armor,
	[Token(Token = "0x4000835")]
	WoodChopping,
	[Token(Token = "0x4000836")]
	Mining,
	[Token(Token = "0x4000837")]
	Ship,
	[Token(Token = "0x4000838")]
	Fishing
}
[Serializable]
[Token(Token = "0x2000137")]