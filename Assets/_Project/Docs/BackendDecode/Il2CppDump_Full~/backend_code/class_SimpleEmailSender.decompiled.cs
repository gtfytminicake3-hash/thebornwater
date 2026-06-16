public class SimpleEmailSender
{
	[Token(Token = "0x2000120")]
	public struct EmailSettings
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string STMPClient;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int SMTPPort;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string UserName;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string UserPass;
	}

	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static EmailSettings emailSettings;

	[Token(Token = "0x600087D")]
	[Address(RVA = "0x1758414", Offset = "0x1754414", VA = "0x1758414")]
	public static void Send(string to, string subject, string body, string attachFile, Action<object, AsyncCompletedEventArgs> callback)
	{
	}

	[Token(Token = "0x600087E")]
	[Address(RVA = "0x175893C", Offset = "0x175493C", VA = "0x175893C")]
	public SimpleEmailSender()
	{
	}
}
[Token(Token = "0x2000122")]