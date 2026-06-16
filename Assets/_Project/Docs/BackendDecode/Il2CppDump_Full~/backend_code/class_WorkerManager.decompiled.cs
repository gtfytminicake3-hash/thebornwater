public class WorkerManager : MonoBehaviour, ICharacterManager
{
	[Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class <stopCheer>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WorkerManager <>4__this;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1716544", Offset = "0x1712544", VA = "0x1716544", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1716584", Offset = "0x1712584", VA = "0x1716584", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x17150B0", Offset = "0x17110B0", VA = "0x17150B0")]
		[DebuggerHidden]
		public <stopCheer>d__63(int <>1__state)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x17164A0", Offset = "0x17124A0", VA = "0x17164A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x17164A4", Offset = "0x17124A4", VA = "0x17164A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x171654C", Offset = "0x171254C", VA = "0x171654C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class <waitForDeathAnimation>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AIAgent agent;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isThief;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WorkerManager <>4__this;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isPossessed;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isTitan;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1716AFC", Offset = "0x1712AFC", VA = "0x1716AFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1716B3C", Offset = "0x1712B3C", VA = "0x1716B3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1713BB8", Offset = "0x170FBB8", VA = "0x1713BB8")]
		[DebuggerHidden]
		public <waitForDeathAnimation>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x171658C", Offset = "0x171258C", VA = "0x171658C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1716590", Offset = "0x1712590", VA = "0x1716590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1716B04", Offset = "0x1712B04", VA = "0x1716B04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AIAgent> newSpawn;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<AIAgent>[] mWorkers;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<AIAgent> theives;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<AIAgent> possessed;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<AIAgent> deadWorkers;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<AIAgent> deadThieves;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<AIAgent> deadPossessed;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AIAgent titan;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool isSummonned;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static WorkerManager mInstance;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool allAttackersWereKilled;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int[,] workerPositions;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int[,] thiefPositions;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<AIAgent> mEnemies;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private DayPhase mCurrentPhase;

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x170F058", Offset = "0x170B058", VA = "0x170F058")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x170F1F4", Offset = "0x170B1F4", VA = "0x170F1F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x170F2F0", Offset = "0x170B2F0", VA = "0x170F2F0")]
	public static WorkerManager GetInstance()
	{
		return null;
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x170F338", Offset = "0x170B338", VA = "0x170F338")]
	public void Initialize(int xSize, int ySize)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x170F840", Offset = "0x170B840", VA = "0x170F840")]
	public void Initialize(List<WorkerData> newSpawnArg, List<WorkerData> workersArg, List<WorkerData> theivesArg, List<WorkerData> possessedArg, List<WorkerData> deadWorkersArg, List<WorkerData> deadThievesArg, List<WorkerData> deadPossessedArg, int xSize, int ySize, WorkerData titanArg, bool isTitalSummonedArg)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x1710B3C", Offset = "0x170CB3C", VA = "0x1710B3C", Slot = "18")]
	public void CheckActions(float currentCycleTime, DayPhase currentPhase)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x171109C", Offset = "0x170D09C", VA = "0x171109C")]
	public void ExecuteActions()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x171125C", Offset = "0x170D25C", VA = "0x171125C")]
	public void RemoveAllCorpse()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x171132C", Offset = "0x170D32C", VA = "0x171132C", Slot = "8")]
	public void RemoveCorpse(AIAgent agent)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x171142C", Offset = "0x170D42C", VA = "0x171142C")]
	public void StopFlee()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x17115C8", Offset = "0x170D5C8", VA = "0x17115C8")]
	public void UpdateEnergy()
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x17117CC", Offset = "0x170D7CC", VA = "0x17117CC")]
	public void UpdateHunger()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x1711B90", Offset = "0x170DB90", VA = "0x1711B90")]
	public AIAgent GetRandomWorker(bool preferJob, Jobs job = Jobs.Builder)
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x1711CE4", Offset = "0x170DCE4", VA = "0x1711CE4")]
	public void SpawnWorkers(int numberToSpawn)
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x1712020", Offset = "0x170E020", VA = "0x1712020")]
	public int GetTotalWorkers()
	{
		return default(int);
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x17120B0", Offset = "0x170E0B0", VA = "0x17120B0", Slot = "19")]
	public DayPhase GetDayPhase()
	{
		return default(DayPhase);
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x17120B8", Offset = "0x170E0B8", VA = "0x17120B8")]
	public void GenerateThiefCost()
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x17124B0", Offset = "0x170E4B0", VA = "0x17124B0", Slot = "14")]
	public void CalculatePositions()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x171280C", Offset = "0x170E80C", VA = "0x171280C", Slot = "17")]
	public int GetTotalPillagedResources()
	{
		return default(int);
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x1712814", Offset = "0x170E814", VA = "0x1712814", Slot = "16")]
	public int GetMaxPillageQuantity()
	{
		return default(int);
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x171281C", Offset = "0x170E81C", VA = "0x171281C", Slot = "15")]
	public Resource GetResourceToPillage()
	{
		return default(Resource);
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x1712824", Offset = "0x170E824", VA = "0x1712824")]
	public void ReassignWorkersOfBuilding(BuildingInstance instance)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x1712828", Offset = "0x170E828", VA = "0x1712828")]
	public void RemoveHutFromWorkers(BuildingInstance instance)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x1712A04", Offset = "0x170EA04", VA = "0x1712A04")]
	public Jobs GetWorkerJob(AIAgent agent)
	{
		return default(Jobs);
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x1712AF4", Offset = "0x170EAF4", VA = "0x1712AF4")]
	public string GetWorkerJobString(AIAgent agent)
	{
		return null;
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x1712C60", Offset = "0x170EC60", VA = "0x1712C60")]
	public void ChangeJob(AIAgent agent, Jobs previousJob, Jobs newJob, BuildingInstance building)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x1712E00", Offset = "0x170EE00", VA = "0x1712E00")]
	public void ChangeJob(AIAgent agent, Jobs previousJob, Jobs newJob)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x1712F4C", Offset = "0x170EF4C", VA = "0x1712F4C")]
	public void OnMonsterWarning()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x1709C80", Offset = "0x1705C80", VA = "0x1709C80")]
	public void OnMonstersAppear(List<AIAgent> enemies, bool cancelAction = true)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x17130C4", Offset = "0x170F0C4", VA = "0x17130C4")]
	public void OnMonstersCleared()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x17131EC", Offset = "0x170F1EC", VA = "0x17131EC", Slot = "6")]
	public void OnAgentAttacked(AIAgent attacked, AIAgent attacker)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x1713650", Offset = "0x170F650", VA = "0x1713650", Slot = "5")]
	public void OnAgentKilled(AIAgent agent, bool showMessage)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x1713B1C", Offset = "0x170FB1C", VA = "0x1713B1C")]
	[IteratorStateMachine(typeof(<waitForDeathAnimation>d__47))]
	private IEnumerator waitForDeathAnimation(AIAgent agent, bool isThief, bool isPossessed, bool isTitan)
	{
		return null;
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x1713BE0", Offset = "0x170FBE0", VA = "0x1713BE0")]
	public void SummonTitan(Vector3 spawnPos)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x1713E0C", Offset = "0x170FE0C", VA = "0x1713E0C")]
	public void UnsummonTitan()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x1713E50", Offset = "0x170FE50", VA = "0x1713E50", Slot = "9")]
	public void UpdateActiveAgentsList()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x171407C", Offset = "0x171007C", VA = "0x171407C", Slot = "20")]
	public void UpdateBuffs()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x1714220", Offset = "0x1710220", VA = "0x1714220", Slot = "10")]
	public void AddNewAgent(AIAgent agent)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x1714314", Offset = "0x1710314", VA = "0x1714314")]
	public void AcceptNewWorker()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x17144B4", Offset = "0x17104B4", VA = "0x17144B4")]
	public void RejectNewWorker()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x171460C", Offset = "0x171060C", VA = "0x171460C", Slot = "11")]
	public void OnActionFinish(AIAgent agent, GoapActions action)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x1714948", Offset = "0x1710948", VA = "0x1714948", Slot = "13")]
	public bool AllEnemiesKilled()
	{
		return default(bool);
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x1714950", Offset = "0x1710950", VA = "0x1714950")]
	public List<AIAgent> GetHomless()
	{
		return null;
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x1714BA4", Offset = "0x1710BA4", VA = "0x1714BA4")]
	public List<AIAgent> GetAllWorkersOfType(Jobs job)
	{
		return null;
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x1714BD4", Offset = "0x1710BD4", VA = "0x1714BD4")]
	public List<AIAgent> GetAllWorkersOfType(Jobs job, Skills requiredSkill)
	{
		return null;
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x1714D84", Offset = "0x1710D84", VA = "0x1714D84", Slot = "12")]
	public Vector2 FlockSeparation(AIAgent a)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x170CD38", Offset = "0x1708D38", VA = "0x170CD38")]
	public List<AIAgent> GetWorkersToAttack()
	{
		return null;
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x170E160", Offset = "0x170A160", VA = "0x170E160")]
	public void StartCheer()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x1715050", Offset = "0x1711050", VA = "0x1715050")]
	[IteratorStateMachine(typeof(<stopCheer>d__63))]
	private IEnumerator stopCheer()
	{
		return null;
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x17150D8", Offset = "0x17110D8", VA = "0x17150D8", Slot = "4")]
	public bool IsWorker()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x17150E0", Offset = "0x17110E0", VA = "0x17150E0")]
	public bool isAliveWorker(AIAgent agent)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x17152B4", Offset = "0x17112B4", VA = "0x17152B4")]
	public bool isDeadWorker(AIAgent agent)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x171542C", Offset = "0x171142C", VA = "0x171542C")]
	public bool isNewWorker(AIAgent agent)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x17155A4", Offset = "0x17115A4", VA = "0x17155A4")]
	public bool PossessedCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x17159EC", Offset = "0x17119EC", VA = "0x17159EC")]
	public bool ThiefCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x1715E5C", Offset = "0x1711E5C", VA = "0x1715E5C", Slot = "7")]
	public List<AIAgent> GetEnemies()
	{
		return null;
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x1715E64", Offset = "0x1711E64", VA = "0x1715E64")]
	public void RecycleAllDockWorkers()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x17160C0", Offset = "0x17120C0", VA = "0x17160C0", Slot = "21")]
	public void ScreenShake()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x1716168", Offset = "0x1712168", VA = "0x1716168", Slot = "22")]
	public bool IsJob(AIAgent agent, Jobs job)
	{
		return default(bool);
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x17161E8", Offset = "0x17121E8", VA = "0x17161E8", Slot = "23")]
	public float GetSpeedOnTile(int x, int y)
	{
		return default(float);
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x17162F0", Offset = "0x17122F0", VA = "0x17162F0")]
	public WorkerManager()
	{
	}
}
[Token(Token = "0x2000090")]
public enum Buff
{
	[Token(Token = "0x4000341")]
	Bleed,
	[Token(Token = "0x4000342")]
	Crippled,
	[Token(Token = "0x4000343")]
	Poison
}
[Token(Token = "0x2000091")]