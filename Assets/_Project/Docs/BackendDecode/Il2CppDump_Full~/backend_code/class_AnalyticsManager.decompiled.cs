public class AnalyticsManager : MonoBehaviour
{
	[Token(Token = "0x4000EBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AnalyticsManager mInstance;

	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0x169F478", Offset = "0x169B478", VA = "0x169F478")]
	private void Start()
	{
	}

	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x169F4C4", Offset = "0x169B4C4", VA = "0x169F4C4")]
	public static AnalyticsManager GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6000CED")]
	[Address(RVA = "0x169F50C", Offset = "0x169B50C", VA = "0x169F50C")]
	public void SendDayStartedEvent(int DayNumber)
	{
	}

	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x169F680", Offset = "0x169B680", VA = "0x169F680")]
	public void SendCastleCompleted()
	{
	}

	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x169F77C", Offset = "0x169B77C", VA = "0x169F77C")]
	public void SendDungeonsCompleted(DungeonIslandDifficulty difficulty)
	{
	}

	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x169F7F4", Offset = "0x169B7F4", VA = "0x169F7F4")]
	public AnalyticsManager()
	{
	}
}
[Token(Token = "0x20001E5")]