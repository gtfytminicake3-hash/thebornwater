using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

[assembly: AssemblyVersion("4.0.0.0")]
[Token(Token = "0x2000002")]
internal static class SR
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x289CD90", Offset = "0x2898D90", VA = "0x289CD90")]
	internal static string Format(string resourceFormat, object p1)
	{
		return null;
	}
}
namespace System.Numerics
{
	[Serializable]
	[Token(Token = "0x2000003")]
	public readonly struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
	{
		[Token(Token = "0x2000004")]
		private enum GetBytesMode
		{
			[Token(Token = "0x4000009")]
			AllocateArray,
			[Token(Token = "0x400000A")]
			Count,
			[Token(Token = "0x400000B")]
			Span
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly int _sign;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal readonly uint[] _bits;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly BigInteger s_bnMinInt;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BigInteger s_bnOneInt;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly BigInteger s_bnZeroInt;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly BigInteger s_bnMinusOneInt;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly byte[] s_success;

		[Token(Token = "0x17000001")]
		public static BigInteger Zero
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x289DE7C", Offset = "0x2899E7C", VA = "0x289DE7C")]
			get
			{
				return default(BigInteger);
			}
		}

		[Token(Token = "0x17000002")]
		public static BigInteger MinusOne
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x289DED4", Offset = "0x2899ED4", VA = "0x289DED4")]
			get
			{
				return default(BigInteger);
			}
		}

		[Token(Token = "0x17000003")]
		public bool IsZero
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x289DF2C", Offset = "0x2899F2C", VA = "0x289DF2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x289CE00", Offset = "0x2898E00", VA = "0x289CE00")]
		public BigInteger(int value)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x289CE7C", Offset = "0x2898E7C", VA = "0x289CE7C")]
		[CLSCompliant(false)]
		public BigInteger(uint value)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x289CF00", Offset = "0x2898F00", VA = "0x289CF00")]
		public BigInteger(long value)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x289D014", Offset = "0x2899014", VA = "0x289D014")]
		[CLSCompliant(false)]
		public BigInteger(ulong value)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x289D0D0", Offset = "0x28990D0", VA = "0x289D0D0")]
		public BigInteger(float value)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x289D134", Offset = "0x2899134", VA = "0x289D134")]
		public BigInteger(double value)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x289D458", Offset = "0x2899458", VA = "0x289D458")]
		public BigInteger(decimal value)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x289D620", Offset = "0x2899620", VA = "0x289D620")]
		[CLSCompliant(false)]
		public BigInteger(byte[] value)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x289D6E4", Offset = "0x28996E4", VA = "0x289D6E4")]
		public BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false, bool isBigEndian = false)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x289DCE4", Offset = "0x2899CE4", VA = "0x289DCE4")]
		internal BigInteger(int n, uint[] rgu)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x289DCF0", Offset = "0x2899CF0", VA = "0x289DCF0")]
		internal BigInteger(uint[] value, bool negative)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x289DF3C", Offset = "0x2899F3C", VA = "0x289DF3C")]
		public static BigInteger Parse(string value, IFormatProvider provider)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x289DFC4", Offset = "0x2899FC4", VA = "0x289DFC4")]
		public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x289E0A4", Offset = "0x289A0A4", VA = "0x289E0A4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x289E0FC", Offset = "0x289A0FC", VA = "0x289E0FC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x289E264", Offset = "0x289A264", VA = "0x289E264")]
		public bool Equals(long other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x289E1A8", Offset = "0x289A1A8", VA = "0x289E1A8", Slot = "7")]
		public bool Equals(BigInteger other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x289E350", Offset = "0x289A350", VA = "0x289E350")]
		public int CompareTo(long other)
		{
			return default(int);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x289E3DC", Offset = "0x289A3DC", VA = "0x289E3DC", Slot = "6")]
		public int CompareTo(BigInteger other)
		{
			return default(int);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x289E500", Offset = "0x289A500", VA = "0x289E500", Slot = "5")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x289E608", Offset = "0x289A608", VA = "0x289E608")]
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x289EBAC", Offset = "0x289ABAC", VA = "0x289EBAC")]
		internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x289E6B8", Offset = "0x289A6B8", VA = "0x289E6B8")]
		private byte[] TryGetBytes(GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x289EC54", Offset = "0x289AC54", VA = "0x289EC54", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x289ED2C", Offset = "0x289AD2C", VA = "0x289ED2C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x289ED60", Offset = "0x289AD60", VA = "0x289ED60", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x289ED98", Offset = "0x289AD98", VA = "0x289ED98")]
		private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x289F0F4", Offset = "0x289B0F4", VA = "0x289F0F4")]
		public static BigInteger operator -(BigInteger left, BigInteger right)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x289F1A4", Offset = "0x289B1A4", VA = "0x289F1A4")]
		private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x289F574", Offset = "0x289B574", VA = "0x289F574")]
		public static implicit operator BigInteger(byte value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x289F5A0", Offset = "0x289B5A0", VA = "0x289F5A0")]
		[CLSCompliant(false)]
		public static implicit operator BigInteger(sbyte value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x289F5C8", Offset = "0x289B5C8", VA = "0x289F5C8")]
		public static implicit operator BigInteger(short value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x289F5F0", Offset = "0x289B5F0", VA = "0x289F5F0")]
		[CLSCompliant(false)]
		public static implicit operator BigInteger(ushort value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x289F61C", Offset = "0x289B61C", VA = "0x289F61C")]
		public static implicit operator BigInteger(int value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x289F644", Offset = "0x289B644", VA = "0x289F644")]
		[CLSCompliant(false)]
		public static implicit operator BigInteger(uint value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x289EEFC", Offset = "0x289AEFC", VA = "0x289EEFC")]
		public static implicit operator BigInteger(long value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x289D430", Offset = "0x2899430", VA = "0x289D430")]
		[CLSCompliant(false)]
		public static implicit operator BigInteger(ulong value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x289F66C", Offset = "0x289B66C", VA = "0x289F66C")]
		public static explicit operator byte(BigInteger value)
		{
			return default(byte);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x289F7D8", Offset = "0x289B7D8", VA = "0x289F7D8")]
		[CLSCompliant(false)]
		public static explicit operator sbyte(BigInteger value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x289F868", Offset = "0x289B868", VA = "0x289F868")]
		public static explicit operator short(BigInteger value)
		{
			return default(short);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x289F8F8", Offset = "0x289B8F8", VA = "0x289F8F8")]
		[CLSCompliant(false)]
		public static explicit operator ushort(BigInteger value)
		{
			return default(ushort);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x289F6FC", Offset = "0x289B6FC", VA = "0x289F6FC")]
		public static explicit operator int(BigInteger value)
		{
			return default(int);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x289F988", Offset = "0x289B988", VA = "0x289F988")]
		[CLSCompliant(false)]
		public static explicit operator uint(BigInteger value)
		{
			return default(uint);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x289FA30", Offset = "0x289BA30", VA = "0x289FA30")]
		public static explicit operator long(BigInteger value)
		{
			return default(long);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x289FAD8", Offset = "0x289BAD8", VA = "0x289FAD8")]
		[CLSCompliant(false)]
		public static explicit operator ulong(BigInteger value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x289FB94", Offset = "0x289BB94", VA = "0x289FB94")]
		public static explicit operator float(BigInteger value)
		{
			return default(float);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x289FC00", Offset = "0x289BC00", VA = "0x289FC00")]
		public static explicit operator double(BigInteger value)
		{
			return default(double);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x289FE08", Offset = "0x289BE08", VA = "0x289FE08")]
		public static explicit operator decimal(BigInteger value)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x289FF74", Offset = "0x289BF74", VA = "0x289FF74")]
		public static BigInteger operator <<(BigInteger value, int shift)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x28A01C0", Offset = "0x289C1C0", VA = "0x28A01C0")]
		public static BigInteger operator >>(BigInteger value, int shift)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x28A05AC", Offset = "0x289C5AC", VA = "0x28A05AC")]
		public static BigInteger operator -(BigInteger value)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x28A05B4", Offset = "0x289C5B4", VA = "0x28A05B4")]
		public static BigInteger operator +(BigInteger left, BigInteger right)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x28A0664", Offset = "0x289C664", VA = "0x28A0664")]
		public static BigInteger operator *(BigInteger left, BigInteger right)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x28A0A68", Offset = "0x289CA68", VA = "0x28A0A68")]
		public static BigInteger operator /(BigInteger dividend, BigInteger divisor)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x28A0D48", Offset = "0x289CD48", VA = "0x28A0D48")]
		public static bool operator <=(BigInteger left, BigInteger right)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x28A0DC8", Offset = "0x289CDC8", VA = "0x28A0DC8")]
		public static bool operator !=(BigInteger left, BigInteger right)
		{
			return default(bool);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x28A0E48", Offset = "0x289CE48", VA = "0x28A0E48")]
		public static bool operator <(BigInteger left, long right)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x28A0EB4", Offset = "0x289CEB4", VA = "0x28A0EB4")]
		public static bool operator <=(BigInteger left, long right)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x28A0F24", Offset = "0x289CF24", VA = "0x28A0F24")]
		public static bool operator ==(BigInteger left, long right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x28A0F90", Offset = "0x289CF90", VA = "0x28A0F90")]
		public static bool operator !=(BigInteger left, long right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x28A1000", Offset = "0x289D000", VA = "0x28A1000")]
		public static bool operator <(long left, BigInteger right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x28A1070", Offset = "0x289D070", VA = "0x28A1070")]
		public static bool operator <=(long left, BigInteger right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x28A04E8", Offset = "0x289C4E8", VA = "0x28A04E8")]
		private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x289E2D8", Offset = "0x289A2D8", VA = "0x289E2D8")]
		internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000005")]
	internal static class BigIntegerCalculator
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int ReducerThreshold;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int SquareThreshold;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int AllocationThreshold;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static int MultiplyThreshold;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x289EF30", Offset = "0x289AF30", VA = "0x289EF30")]
		public static uint[] Add(uint[] left, uint right)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x289F008", Offset = "0x289B008", VA = "0x289F008")]
		public static uint[] Add(uint[] left, uint[] right)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x28A1238", Offset = "0x289D238", VA = "0x28A1238")]
		private unsafe static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x28A12BC", Offset = "0x289D2BC", VA = "0x28A12BC")]
		private unsafe static void AddSelf(uint* left, int leftLength, uint* right, int rightLength)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x289F340", Offset = "0x289B340", VA = "0x289F340")]
		public static uint[] Subtract(uint[] left, uint right)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x289F480", Offset = "0x289B480", VA = "0x289F480")]
		public static uint[] Subtract(uint[] left, uint[] right)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x28A1328", Offset = "0x289D328", VA = "0x28A1328")]
		private unsafe static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x289F3F4", Offset = "0x289B3F4", VA = "0x289F3F4")]
		public static int Compare(uint[] left, uint[] right)
		{
			return default(int);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x28A0BB4", Offset = "0x289CBB4", VA = "0x28A0BB4")]
		public static uint[] Divide(uint[] left, uint right)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x28A0C6C", Offset = "0x289CC6C", VA = "0x28A0C6C")]
		public static uint[] Divide(uint[] left, uint[] right)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x28A141C", Offset = "0x289D41C", VA = "0x28A141C")]
		private unsafe static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x28A183C", Offset = "0x289D83C", VA = "0x28A183C")]
		private unsafe static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength)
		{
			return default(uint);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x28A17F4", Offset = "0x289D7F4", VA = "0x28A17F4")]
		private unsafe static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q)
		{
			return default(uint);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x28A17B4", Offset = "0x289D7B4", VA = "0x28A17B4")]
		private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x28A13A0", Offset = "0x289D3A0", VA = "0x28A13A0")]
		private static uint[] CreateCopy(uint[] value)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x28A173C", Offset = "0x289D73C", VA = "0x28A173C")]
		private static int LeadingZeros(uint value)
		{
			return default(int);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x28A08B4", Offset = "0x289C8B4", VA = "0x28A08B4")]
		public static uint[] Square(uint[] value)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x28A187C", Offset = "0x289D87C", VA = "0x28A187C")]
		private unsafe static void Square(uint* value, int valueLength, uint* bits, int bitsLength)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x28A07DC", Offset = "0x289C7DC", VA = "0x28A07DC")]
		public static uint[] Multiply(uint[] left, uint right)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x28A0978", Offset = "0x289C978", VA = "0x28A0978")]
		public static uint[] Multiply(uint[] left, uint[] right)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x28A1D20", Offset = "0x289DD20", VA = "0x28A1D20")]
		private unsafe static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x28A1C5C", Offset = "0x289DC5C", VA = "0x28A1C5C")]
		private unsafe static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength)
		{
		}
	}
	[Token(Token = "0x2000006")]
	internal static class BigNumber
	{
		[Token(Token = "0x2000007")]
		private struct BigNumberBuffer
		{
			[Token(Token = "0x4000010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public StringBuilder digits;

			[Token(Token = "0x4000011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int precision;

			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int scale;

			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool sign;

			[Token(Token = "0x6000067")]
			[Address(RVA = "0x28A2454", Offset = "0x289E454", VA = "0x28A2454")]
			public static BigNumberBuffer Create()
			{
				return default(BigNumberBuffer);
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x28A221C", Offset = "0x289E21C", VA = "0x28A221C")]
		internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e)
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x28A230C", Offset = "0x289E30C", VA = "0x28A230C")]
		internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x289DFF8", Offset = "0x2899FF8", VA = "0x289DFF8")]
		internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x28A2904", Offset = "0x289E904", VA = "0x28A2904")]
		internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info)
		{
			return default(BigInteger);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x28A2594", Offset = "0x289E594", VA = "0x28A2594")]
		private static bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x28A273C", Offset = "0x289E73C", VA = "0x28A273C")]
		private static bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x28A2A3C", Offset = "0x289EA3C", VA = "0x28A2A3C")]
		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
		{
			return default(char);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x28A2B2C", Offset = "0x289EB2C", VA = "0x28A2B2C")]
		private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x289EC84", Offset = "0x289AC84", VA = "0x289EC84")]
		internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x28A34FC", Offset = "0x289F4FC", VA = "0x28A34FC")]
		private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
		{
			return null;
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x2000008")]
	internal struct DoubleUlong
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double dbl;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong uu;
	}
	[Token(Token = "0x2000009")]
	internal static class NumericsHelpers
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x289D3B4", Offset = "0x28993B4", VA = "0x289D3B4")]
		public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x289FD60", Offset = "0x289BD60", VA = "0x289FD60")]
		public static double GetDoubleFromParts(int sign, int exp, ulong man)
		{
			return default(double);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x289DC2C", Offset = "0x2899C2C", VA = "0x289DC2C")]
		public static void DangerousMakeTwosComplement(uint[] d)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x289E2CC", Offset = "0x289A2CC", VA = "0x289E2CC")]
		public static ulong MakeUlong(uint uHi, uint uLo)
		{
			return default(ulong);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x289EF24", Offset = "0x289AF24", VA = "0x289EF24")]
		public static uint Abs(int a)
		{
			return default(uint);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x28A41B0", Offset = "0x28A01B0", VA = "0x28A41B0")]
		public static uint CombineHash(uint u1, uint u2)
		{
			return default(uint);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x289E0F4", Offset = "0x289A0F4", VA = "0x289E0F4")]
		public static int CombineHash(int n1, int n2)
		{
			return default(int);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x289FCE8", Offset = "0x289BCE8", VA = "0x289FCE8")]
		public static int CbitHighZero(uint u)
		{
			return default(int);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x28A418C", Offset = "0x28A018C", VA = "0x28A418C")]
		public static int CbitHighZero(ulong uu)
		{
			return default(int);
		}
	}
}
namespace System.Globalization
{
	[Token(Token = "0x200000A")]
	internal class FormatProvider
	{
		[Token(Token = "0x200000B")]
		private class Number
		{
			[Token(Token = "0x200000C")]
			internal struct NumberBuffer
			{
				[Token(Token = "0x400001C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int precision;

				[Token(Token = "0x400001D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public int scale;

				[Token(Token = "0x400001E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public bool sign;

				[Token(Token = "0x400001F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public unsafe char* overrideDigits;

				[Token(Token = "0x17000004")]
				public unsafe char* digits
				{
					[Token(Token = "0x6000088")]
					[Address(RVA = "0x28A8588", Offset = "0x28A4588", VA = "0x28A8588")]
					get
					{
						//IL_0002: Expected I, but got O
						return (char*)unchecked((nint)null);
					}
				}
			}

			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static string[] s_posCurrencyFormats;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static string[] s_negCurrencyFormats;

			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static string[] s_posPercentFormats;

			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static string[] s_negPercentFormats;

			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static string[] s_negNumberFormats;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static string s_posNumberFormat;

			[Token(Token = "0x6000073")]
			[Address(RVA = "0x28A5AC8", Offset = "0x28A1AC8", VA = "0x28A5AC8")]
			private static bool IsWhite(char ch)
			{
				return default(bool);
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0x28A5AE0", Offset = "0x28A1AE0", VA = "0x28A5AE0")]
			private unsafe static char* MatchChars(char* p, char* pEnd, string str)
			{
				//IL_0002: Expected I, but got O
				return (char*)unchecked((nint)null);
			}

			[Token(Token = "0x6000075")]
			[Address(RVA = "0x28A5BA4", Offset = "0x28A1BA4", VA = "0x28A5BA4")]
			private unsafe static char* MatchChars(char* p, char* pEnd, char* str)
			{
				//IL_0002: Expected I, but got O
				return (char*)unchecked((nint)null);
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0x28A5C00", Offset = "0x28A1C00", VA = "0x28A5C00")]
			private unsafe static bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
			{
				return default(bool);
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0x28A6304", Offset = "0x28A2304", VA = "0x28A6304")]
			private static bool TrailingZeros(ReadOnlySpan<char> s, int index)
			{
				return default(bool);
			}

			[Token(Token = "0x6000078")]
			[Address(RVA = "0x28A5990", Offset = "0x28A1990", VA = "0x28A5990")]
			internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
			{
				return default(bool);
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x28A639C", Offset = "0x28A239C", VA = "0x28A639C")]
			internal unsafe static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits)
			{
			}

			[Token(Token = "0x600007A")]
			[Address(RVA = "0x28A41B8", Offset = "0x28A01B8", VA = "0x28A41B8")]
			internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
			{
				return default(char);
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x28A42FC", Offset = "0x28A02FC", VA = "0x28A42FC")]
			internal static void NumberToString(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
			{
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0x28A64E0", Offset = "0x28A24E0", VA = "0x28A64E0")]
			private static void FormatCurrency(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x28A7768", Offset = "0x28A3768", VA = "0x28A7768")]
			private unsafe static int wcslen(char* s)
			{
				return default(int);
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0x28A6760", Offset = "0x28A2760", VA = "0x28A6760")]
			private static void FormatFixed(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup)
			{
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x28A6CDC", Offset = "0x28A2CDC", VA = "0x28A6CDC")]
			private static void FormatNumber(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0x28A6F44", Offset = "0x28A2F44", VA = "0x28A6F44")]
			private static void FormatScientific(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
			{
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0x28A7A68", Offset = "0x28A3A68", VA = "0x28A7A68")]
			private static void FormatExponent(ref System.Text.ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
			{
			}

			[Token(Token = "0x6000082")]
			[Address(RVA = "0x28A7184", Offset = "0x28A3184", VA = "0x28A7184")]
			private static void FormatGeneral(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
			{
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0x28A74E8", Offset = "0x28A34E8", VA = "0x28A74E8")]
			private static void FormatPercent(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
			}

			[Token(Token = "0x6000084")]
			[Address(RVA = "0x28A63F8", Offset = "0x28A23F8", VA = "0x28A63F8")]
			private static void RoundNumber(ref NumberBuffer number, int pos)
			{
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0x28A7D78", Offset = "0x28A3D78", VA = "0x28A7D78")]
			private static int FindSection(ReadOnlySpan<char> format, int section)
			{
				return default(int);
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0x28A4880", Offset = "0x28A0880", VA = "0x28A4880")]
			internal static void NumberToStringFormat(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
			{
			}
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x28A4058", Offset = "0x28A0058", VA = "0x28A4058")]
		internal static void FormatBigInteger(ref System.Text.ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x28A24B0", Offset = "0x289E4B0", VA = "0x28A24B0")]
		internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign)
		{
			return default(bool);
		}
	}
}
namespace System.Text
{
	[Token(Token = "0x200000D")]
	[DefaultMember("Item")]
	internal ref struct ValueStringBuilder
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private char[] _arrayToReturnToPool;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Span<char> _chars;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _pos;

		[Token(Token = "0x17000005")]
		public int Length
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x28A8590", Offset = "0x28A4590", VA = "0x28A8590")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x28A3164", Offset = "0x289F164", VA = "0x28A3164")]
		public ValueStringBuilder(Span<char> initialBuffer)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x28A342C", Offset = "0x289F42C", VA = "0x28A342C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x28A3340", Offset = "0x289F340", VA = "0x28A3340")]
		public bool TryCopyTo(Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x28A3174", Offset = "0x289F174", VA = "0x28A3174")]
		public void Insert(int index, char value, int count)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x28A87FC", Offset = "0x28A47FC", VA = "0x28A87FC")]
		public void Append(char c)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x28A88F8", Offset = "0x28A48F8", VA = "0x28A88F8")]
		public void Append(string s)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x28A89A4", Offset = "0x28A49A4", VA = "0x28A89A4")]
		private void AppendSlow(string s)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x28A7878", Offset = "0x28A3878", VA = "0x28A7878")]
		public void Append(char c, int count)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x28A7794", Offset = "0x28A3794", VA = "0x28A7794")]
		public unsafe void Append(char* value, int length)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x28A8AD4", Offset = "0x28A4AD4", VA = "0x28A8AD4")]
		public Span<char> AppendSpan(int length)
		{
			return default(Span<char>);
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x28A8878", Offset = "0x28A4878", VA = "0x28A8878")]
		private void GrowAndAppend(char c)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x28A8598", Offset = "0x28A4598", VA = "0x28A8598")]
		private void Grow(int requiredAdditionalCapacity)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x28A8B94", Offset = "0x28A4B94", VA = "0x28A8B94")]
		public void Dispose()
		{
		}
	}
}
