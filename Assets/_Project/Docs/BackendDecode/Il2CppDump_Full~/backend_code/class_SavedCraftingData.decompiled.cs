public class SavedCraftingData
{
	[Token(Token = "0x4000F57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int currentQuantity;

	[Token(Token = "0x4000F58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int capacity;

	[Token(Token = "0x4000F59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isBeingCrafted;

	[Token(Token = "0x4000F5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float currentProgress;

	[Token(Token = "0x4000F5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int[] currentlyStored;

	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x16A74AC", Offset = "0x16A34AC", VA = "0x16A74AC")]
	public SavedCraftingData(StoredItemData storedData)
	{
	}
}
[Serializable]
[Token(Token = "0x2000212")]