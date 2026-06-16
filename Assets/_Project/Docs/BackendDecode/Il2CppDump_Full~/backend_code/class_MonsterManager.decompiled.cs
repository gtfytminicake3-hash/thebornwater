public class MonsterManager : MonoBehaviour, ICharacterManager
{
	[Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class <waitForDeathAnimation>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AIAgent agent;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterManager <>4__this;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x170E490", Offset = "0x170A490", VA = "0x170E490", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x170E4D0", Offset = "0x170A4D0", VA = "0x170E4D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x170C790", Offset = "0x1708790", VA = "0x170C790")]
		[DebuggerHidden]
		public <waitForDeathAnimation>d__46(int <>1__state)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x170DA24", Offset = "0x1709A24", VA = "0x170DA24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x170DA28", Offset = "0x1709A28", VA = "0x170DA28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x170E498", Offset = "0x170A498", VA = "0x170E498", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BoatCarryingAgents boatPrefab;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[EventRef]
	public string orcWarningSoundPath;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[EventRef]
	public string megaOrcWarningSoundPath;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[EventRef]
	public string slayerOrcWarningSoundPath;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[EventRef]
	public string wolfWarningSoundPath;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[EventRef]
	public string spiderWarningSoundPath;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[EventRef]
	public string chupacabraWarningSoundPath;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<AIAgent> attackingEnemies;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int totalPillagedResources;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<AIAgent> corpse;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<AIAgent> newSpawn;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MonsterManager mInstance;

	[Token(Token = "0x4000311")]
	public const int monsterAttackWarningTime = 19;

	[Token(Token = "0x4000312")]
	public const int monsterAttackStartTime = 21;

	[Token(Token = "0x4000313")]
	public const int monsterAttackOverTime = 2;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool mMonsterSleep;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool finalBattleStarted;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int[,] monsterPositions;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private DayPhase mCurrentPhase;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool isSlayerKilled;

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x1709310", Offset = "0x1705310", VA = "0x1709310")]
	private void Awake()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x17093BC", Offset = "0x17053BC", VA = "0x17093BC")]
	public static MonsterManager GetInstance()
	{
		return null;
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x1709404", Offset = "0x1705404", VA = "0x1709404")]
	public void Initialize(int xSize, int ySize, float currentCycleTime, float cycleLength)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x1709478", Offset = "0x1705478", VA = "0x1709478")]
	public void Initialize(List<WorkerData> attackingEnemiesArg, List<WorkerData> corpseArg, int xSize, int ySize, float currentCycleTime, float cycleLength)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x1709ED8", Offset = "0x1705ED8", VA = "0x1709ED8", Slot = "23")]
	public float GetSpeedOnTile(int x, int y)
	{
		return default(float);
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x1709FE0", Offset = "0x1705FE0", VA = "0x1709FE0", Slot = "17")]
	public int GetTotalPillagedResources()
	{
		return default(int);
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x1709FE8", Offset = "0x1705FE8", VA = "0x1709FE8", Slot = "16")]
	public int GetMaxPillageQuantity()
	{
		return default(int);
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x170A034", Offset = "0x1706034", VA = "0x170A034", Slot = "15")]
	public Resource GetResourceToPillage()
	{
		return default(Resource);
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x170A03C", Offset = "0x170603C", VA = "0x170A03C")]
	public void GetEnemiesInTheForest()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x170A124", Offset = "0x1706124", VA = "0x170A124")]
	public void TimeForAttackWarning(AgentType spawnTonight)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x170A77C", Offset = "0x170677C", VA = "0x170A77C")]
	private void StartFinalBattle()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x170B2B4", Offset = "0x17072B4", VA = "0x170B2B4")]
	public void TimeToSpawnMonster()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x170B788", Offset = "0x1707788", VA = "0x170B788")]
	public void TimeToRetreat()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x170B78C", Offset = "0x170778C", VA = "0x170B78C", Slot = "18")]
	public void CheckActions(float currentCycleTime, DayPhase currentPhase)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x170BC8C", Offset = "0x1707C8C", VA = "0x170BC8C")]
	public void ExecuteActions()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x170BDD4", Offset = "0x1707DD4", VA = "0x170BDD4")]
	public void StartFlee()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x170BDE0", Offset = "0x1707DE0", VA = "0x170BDE0")]
	public void RemoveAllCorpse()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x170BF4C", Offset = "0x1707F4C", VA = "0x170BF4C", Slot = "8")]
	public void RemoveCorpse(AIAgent agent)
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x170ACDC", Offset = "0x1706CDC", VA = "0x170ACDC")]
	private List<AIAgent> TrySpawnMonsters(AgentType spawnTonight, int numberToSpawn)
	{
		return null;
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x170AF98", Offset = "0x1706F98", VA = "0x170AF98")]
	public AIAgent TrySpawnBoss(AgentType boss)
	{
		return null;
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x170B0C0", Offset = "0x17070C0", VA = "0x170B0C0")]
	private Vector3 GetMonsterSpawnPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x170C024", Offset = "0x1708024", VA = "0x170C024")]
	private AIAgent SpawnEach(AgentType spawnTonight, Resource loot, CharacterDetails characterData)
	{
		return null;
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x170C29C", Offset = "0x170829C", VA = "0x170C29C", Slot = "6")]
	public void OnAgentAttacked(AIAgent attacked, AIAgent attacker)
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x170C2A0", Offset = "0x17082A0", VA = "0x170C2A0", Slot = "20")]
	public void UpdateBuffs()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x170C44C", Offset = "0x170844C", VA = "0x170C44C", Slot = "9")]
	public void UpdateActiveAgentsList()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x170C704", Offset = "0x1708704", VA = "0x170C704", Slot = "5")]
	public void OnAgentKilled(AIAgent agent, bool showMessage)
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x170C724", Offset = "0x1708724", VA = "0x170C724")]
	[IteratorStateMachine(typeof(<waitForDeathAnimation>d__46))]
	private IEnumerator waitForDeathAnimation(AIAgent agent)
	{
		return null;
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x170C7B8", Offset = "0x17087B8", VA = "0x170C7B8", Slot = "13")]
	public bool AllEnemiesKilled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x170C7C0", Offset = "0x17087C0", VA = "0x170C7C0", Slot = "11")]
	public void OnActionFinish(AIAgent agent, GoapActions action)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x170C91C", Offset = "0x170891C", VA = "0x170C91C")]
	public void ShowPinHighlightOnlyOn(AIAgent agent)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x170CA98", Offset = "0x1708A98", VA = "0x170CA98")]
	public void RemoveAllPinHighlight()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x170CBCC", Offset = "0x1708BCC", VA = "0x170CBCC", Slot = "7")]
	public List<AIAgent> GetEnemies()
	{
		return null;
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x170D190", Offset = "0x1709190", VA = "0x170D190", Slot = "12")]
	public Vector2 FlockSeparation(AIAgent a)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x170D410", Offset = "0x1709410", VA = "0x170D410", Slot = "4")]
	public bool IsWorker()
	{
		return default(bool);
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x170D418", Offset = "0x1709418", VA = "0x170D418", Slot = "14")]
	public void CalculatePositions()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x170D5D4", Offset = "0x17095D4", VA = "0x170D5D4")]
	public bool isDeadMonster(AIAgent agent)
	{
		return default(bool);
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x170D74C", Offset = "0x170974C", VA = "0x170D74C", Slot = "10")]
	public void AddNewAgent(AIAgent agent)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x170D8E8", Offset = "0x17098E8", VA = "0x170D8E8", Slot = "19")]
	public DayPhase GetDayPhase()
	{
		return default(DayPhase);
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x170D8F0", Offset = "0x17098F0", VA = "0x170D8F0", Slot = "21")]
	public void ScreenShake()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x170D998", Offset = "0x1709998", VA = "0x170D998", Slot = "22")]
	public bool IsJob(AIAgent agent, Jobs job)
	{
		return default(bool);
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x170D9A0", Offset = "0x17099A0", VA = "0x170D9A0")]
	public MonsterManager()
	{
	}
}
[Token(Token = "0x200008B")]