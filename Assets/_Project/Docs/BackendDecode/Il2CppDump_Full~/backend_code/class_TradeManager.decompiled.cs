public class TradeManager : MonoBehaviour, ICharacterManager
{
	[Token(Token = "0x40008C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static TradeManager mInstance;

	[Token(Token = "0x40008C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<TradeRoute> tradeRoutes;

	[Token(Token = "0x40008C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public StrangerType strangerType;

	[Token(Token = "0x40008C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AIAgent strangerInstance;

	[Token(Token = "0x40008C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private DayPhase mCurrentPhase;

	[Token(Token = "0x6000916")]
	[Address(RVA = "0x1765684", Offset = "0x1761684", VA = "0x1765684")]
	public static TradeManager GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6000917")]
	[Address(RVA = "0x17656CC", Offset = "0x17616CC", VA = "0x17656CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000918")]
	[Address(RVA = "0x1765760", Offset = "0x1761760", VA = "0x1765760")]
	private void Update()
	{
	}

	[Token(Token = "0x6000919")]
	[Address(RVA = "0x175C870", Offset = "0x1758870", VA = "0x175C870")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600091A")]
	[Address(RVA = "0x175C89C", Offset = "0x175889C", VA = "0x175C89C")]
	public void Initialize(List<TradeRoute> tradeRouteArg, bool isStrangerPresentArg, WorkerData stranger, StrangerType strangerTypeArg)
	{
	}

	[Token(Token = "0x600091B")]
	[Address(RVA = "0x175E7A8", Offset = "0x175A7A8", VA = "0x175E7A8")]
	public void StrangerSpawn()
	{
	}

	[Token(Token = "0x600091C")]
	[Address(RVA = "0x175EE6C", Offset = "0x175AE6C", VA = "0x175EE6C")]
	public void StrangerLeaves()
	{
	}

	[Token(Token = "0x600091D")]
	[Address(RVA = "0x17605AC", Offset = "0x175C5AC", VA = "0x17605AC")]
	public bool IsStranger(AIAgent agent)
	{
		return default(bool);
	}

	[Token(Token = "0x600091E")]
	[Address(RVA = "0x1760618", Offset = "0x175C618", VA = "0x1760618")]
	public Messages.Message GetMessage()
	{
		return default(Messages.Message);
	}

	[Token(Token = "0x600091F")]
	[Address(RVA = "0x1760634", Offset = "0x175C634", VA = "0x1760634")]
	public Resource GetStrangerResource()
	{
		return default(Resource);
	}

	[Token(Token = "0x6000920")]
	[Address(RVA = "0x176065C", Offset = "0x175C65C", VA = "0x176065C")]
	public string GetAcceptMessage()
	{
		return null;
	}

	[Token(Token = "0x6000921")]
	[Address(RVA = "0x1765764", Offset = "0x1761764", VA = "0x1765764")]
	public Messages.Message StrangerThankMessage()
	{
		return default(Messages.Message);
	}

	[Token(Token = "0x6000922")]
	[Address(RVA = "0x1765788", Offset = "0x1761788", VA = "0x1765788")]
	public void GiveResource()
	{
	}

	[Token(Token = "0x6000923")]
	[Address(RVA = "0x1765AB8", Offset = "0x1761AB8", VA = "0x1765AB8")]
	public void DenyResource()
	{
	}

	[Token(Token = "0x6000924")]
	[Address(RVA = "0x1765ABC", Offset = "0x1761ABC", VA = "0x1765ABC", Slot = "9")]
	public void UpdateActiveAgentsList()
	{
	}

	[Token(Token = "0x6000925")]
	[Address(RVA = "0x1761814", Offset = "0x175D814", VA = "0x1761814", Slot = "20")]
	public void UpdateBuffs()
	{
	}

	[Token(Token = "0x6000926")]
	[Address(RVA = "0x1765AC0", Offset = "0x1761AC0", VA = "0x1765AC0", Slot = "17")]
	public int GetTotalPillagedResources()
	{
		return default(int);
	}

	[Token(Token = "0x6000927")]
	[Address(RVA = "0x1765AC8", Offset = "0x1761AC8", VA = "0x1765AC8", Slot = "16")]
	public int GetMaxPillageQuantity()
	{
		return default(int);
	}

	[Token(Token = "0x6000928")]
	[Address(RVA = "0x1765AD0", Offset = "0x1761AD0", VA = "0x1765AD0", Slot = "15")]
	public Resource GetResourceToPillage()
	{
		return default(Resource);
	}

	[Token(Token = "0x6000929")]
	[Address(RVA = "0x1765AD8", Offset = "0x1761AD8", VA = "0x1765AD8", Slot = "11")]
	public void OnActionFinish(AIAgent agent, GoapActions action)
	{
	}

	[Token(Token = "0x600092A")]
	[Address(RVA = "0x1765BE0", Offset = "0x1761BE0", VA = "0x1765BE0", Slot = "4")]
	public bool IsWorker()
	{
		return default(bool);
	}

	[Token(Token = "0x600092B")]
	[Address(RVA = "0x1765BE8", Offset = "0x1761BE8", VA = "0x1765BE8", Slot = "5")]
	public void OnAgentKilled(AIAgent agent, bool showMessage)
	{
	}

	[Token(Token = "0x600092C")]
	[Address(RVA = "0x1765BEC", Offset = "0x1761BEC", VA = "0x1765BEC", Slot = "6")]
	public void OnAgentAttacked(AIAgent attacked, AIAgent attacker)
	{
	}

	[Token(Token = "0x600092D")]
	[Address(RVA = "0x1765BF0", Offset = "0x1761BF0", VA = "0x1765BF0", Slot = "7")]
	public List<AIAgent> GetEnemies()
	{
		return null;
	}

	[Token(Token = "0x600092E")]
	[Address(RVA = "0x1765BF8", Offset = "0x1761BF8", VA = "0x1765BF8", Slot = "8")]
	public void RemoveCorpse(AIAgent agent)
	{
	}

	[Token(Token = "0x600092F")]
	[Address(RVA = "0x1765BFC", Offset = "0x1761BFC", VA = "0x1765BFC", Slot = "12")]
	public Vector2 FlockSeparation(AIAgent agent)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000930")]
	[Address(RVA = "0x1765C3C", Offset = "0x1761C3C", VA = "0x1765C3C", Slot = "13")]
	public bool AllEnemiesKilled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000931")]
	[Address(RVA = "0x1765C44", Offset = "0x1761C44", VA = "0x1765C44", Slot = "14")]
	public void CalculatePositions()
	{
	}

	[Token(Token = "0x6000932")]
	[Address(RVA = "0x1765C48", Offset = "0x1761C48", VA = "0x1765C48", Slot = "10")]
	public void AddNewAgent(AIAgent agent)
	{
	}

	[Token(Token = "0x6000933")]
	[Address(RVA = "0x1765C4C", Offset = "0x1761C4C", VA = "0x1765C4C", Slot = "19")]
	public DayPhase GetDayPhase()
	{
		return default(DayPhase);
	}

	[Token(Token = "0x6000934")]
	[Address(RVA = "0x1765C54", Offset = "0x1761C54", VA = "0x1765C54", Slot = "18")]
	public void CheckActions(float currentCycleTime, DayPhase currentPhase)
	{
	}

	[Token(Token = "0x6000935")]
	[Address(RVA = "0x1765C58", Offset = "0x1761C58", VA = "0x1765C58", Slot = "21")]
	public void ScreenShake()
	{
	}

	[Token(Token = "0x6000936")]
	[Address(RVA = "0x1765D00", Offset = "0x1761D00", VA = "0x1765D00", Slot = "22")]
	public bool IsJob(AIAgent agent, Jobs job)
	{
		return default(bool);
	}

	[Token(Token = "0x6000937")]
	[Address(RVA = "0x1765D08", Offset = "0x1761D08", VA = "0x1765D08", Slot = "23")]
	public float GetSpeedOnTile(int x, int y)
	{
		return default(float);
	}

	[Token(Token = "0x6000938")]
	[Address(RVA = "0x1765E0C", Offset = "0x1761E0C", VA = "0x1765E0C")]
	public TradeManager()
	{
	}
}
[Serializable]
[Token(Token = "0x2000145")]
public struct IslandData
{
	[Token(Token = "0x40008C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject prefab;

	[Token(Token = "0x40008C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Resource requires;

	[Token(Token = "0x40008C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int quantity;

	[Token(Token = "0x40008C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public QuestDialogue questDialogue;

	[Token(Token = "0x40008CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite icon;

	[Token(Token = "0x40008CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite image;
}
[Token(Token = "0x2000146")]