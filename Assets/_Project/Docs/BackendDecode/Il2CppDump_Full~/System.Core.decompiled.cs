using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Il2CppDummyDll;
using Mono.Security.Cryptography;

[assembly: AssemblyVersion("4.0.0.0")]
[Token(Token = "0x2000002")]
internal static class SR
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x271CAD8", Offset = "0x2718AD8", VA = "0x271CAD8")]
	internal static string GetString(string name)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x271CADC", Offset = "0x2718ADC", VA = "0x271CADC")]
	internal static string Format(string resourceFormat, params object[] args)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x271CB58", Offset = "0x2718B58", VA = "0x271CB58")]
	internal static string Format(string resourceFormat, object p1)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x271CBC8", Offset = "0x2718BC8", VA = "0x271CBC8")]
	internal static string Format(string resourceFormat, object p1, object p2)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x271CC40", Offset = "0x2718C40", VA = "0x271CC40")]
	internal static string Format(string resourceFormat, object p1, object p2, object p3)
	{
		return null;
	}
}
namespace System
{
	[Token(Token = "0x2000003")]
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
	[Token(Token = "0x2000004")]
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
	[Token(Token = "0x2000005")]
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
	[Token(Token = "0x2000006")]
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
	[Token(Token = "0x2000007")]
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
	[Token(Token = "0x2000008")]
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
	[Token(Token = "0x2000009")]
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
	[Token(Token = "0x200000A")]
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
	[Token(Token = "0x200000B")]
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
	[Token(Token = "0x200000C")]
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
	[Token(Token = "0x200000D")]
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
	[Token(Token = "0x200000E")]
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
	[Token(Token = "0x200000F")]
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
	[Token(Token = "0x2000010")]
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
	[Token(Token = "0x2000011")]
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
	[Token(Token = "0x2000012")]
	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
}
namespace System.Security.Cryptography
{
	[Token(Token = "0x2000013")]
	public sealed class AesManaged : Aes
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x48")]
		private RijndaelManaged m_rijndael;

		[Token(Token = "0x17000001")]
		public override int FeedbackSize
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x271CE24", Offset = "0x2718E24", VA = "0x271CE24", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000002")]
		public override byte[] IV
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x271CE40", Offset = "0x2718E40", VA = "0x271CE40", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x271CE5C", Offset = "0x2718E5C", VA = "0x271CE5C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public override byte[] Key
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x271CE78", Offset = "0x2718E78", VA = "0x271CE78", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x271CE94", Offset = "0x2718E94", VA = "0x271CE94", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public override int KeySize
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x271CEB0", Offset = "0x2718EB0", VA = "0x271CEB0", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x271CED0", Offset = "0x2718ED0", VA = "0x271CED0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public override CipherMode Mode
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x271CEF0", Offset = "0x2718EF0", VA = "0x271CEF0", Slot = "16")]
			get
			{
				return default(CipherMode);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x271CF10", Offset = "0x2718F10", VA = "0x271CF10", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public override PaddingMode Padding
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x271CF90", Offset = "0x2718F90", VA = "0x271CF90", Slot = "18")]
			get
			{
				return default(PaddingMode);
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x271CFB0", Offset = "0x2718FB0", VA = "0x271CFB0", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x271CCC8", Offset = "0x2718CC8", VA = "0x271CCC8")]
		public AesManaged()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x271CFD0", Offset = "0x2718FD0", VA = "0x271CFD0", Slot = "22")]
		public override ICryptoTransform CreateDecryptor()
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x271CFF0", Offset = "0x2718FF0", VA = "0x271CFF0", Slot = "23")]
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x271D130", Offset = "0x2719130", VA = "0x271D130", Slot = "20")]
		public override ICryptoTransform CreateEncryptor()
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x271D150", Offset = "0x2719150", VA = "0x271D150", Slot = "21")]
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x271D290", Offset = "0x2719290", VA = "0x271D290", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x271D3CC", Offset = "0x27193CC", VA = "0x271D3CC", Slot = "25")]
		public override void GenerateIV()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x271D3EC", Offset = "0x27193EC", VA = "0x271D3EC", Slot = "24")]
		public override void GenerateKey()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public sealed class AesCryptoServiceProvider : Aes
	{
		[Token(Token = "0x17000007")]
		public override byte[] IV
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x271DD6C", Offset = "0x2719D6C", VA = "0x271DD6C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x271DD74", Offset = "0x2719D74", VA = "0x271DD74", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public override byte[] Key
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x271DD7C", Offset = "0x2719D7C", VA = "0x271DD7C", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x271DD84", Offset = "0x2719D84", VA = "0x271DD84", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public override int KeySize
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x271DD8C", Offset = "0x2719D8C", VA = "0x271DD8C", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x271DD94", Offset = "0x2719D94", VA = "0x271DD94", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public override int FeedbackSize
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x271DD9C", Offset = "0x2719D9C", VA = "0x271DD9C", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000B")]
		public override CipherMode Mode
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x271DDA4", Offset = "0x2719DA4", VA = "0x271DDA4", Slot = "16")]
			get
			{
				return default(CipherMode);
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x271DDAC", Offset = "0x2719DAC", VA = "0x271DDAC", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public override PaddingMode Padding
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x271DE08", Offset = "0x2719E08", VA = "0x271DE08", Slot = "18")]
			get
			{
				return default(PaddingMode);
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x271DE10", Offset = "0x2719E10", VA = "0x271DE10", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x271D40C", Offset = "0x271940C", VA = "0x271D40C")]
		public AesCryptoServiceProvider()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x271D470", Offset = "0x2719470", VA = "0x271D470", Slot = "25")]
		public override void GenerateIV()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x271D494", Offset = "0x2719494", VA = "0x271D494", Slot = "24")]
		public override void GenerateKey()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x271D4B8", Offset = "0x27194B8", VA = "0x271D4B8", Slot = "23")]
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x271DC7C", Offset = "0x2719C7C", VA = "0x271DC7C", Slot = "21")]
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x271DE18", Offset = "0x2719E18", VA = "0x271DE18", Slot = "22")]
		public override ICryptoTransform CreateDecryptor()
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x271DE68", Offset = "0x2719E68", VA = "0x271DE68", Slot = "20")]
		public override ICryptoTransform CreateEncryptor()
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x271DEB8", Offset = "0x2719EB8", VA = "0x271DEB8", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000015")]
	internal class AesTransform : Mono.Security.Cryptography.SymmetricTransform
	{
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x58")]
		private uint[] expandedKey;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x60")]
		private int Nk;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x64")]
		private int Nr;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] Rcon;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] SBox;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] iSBox;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		private static readonly uint[] T0;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		private static readonly uint[] T1;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		private static readonly uint[] T2;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		private static readonly uint[] T3;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x38")]
		private static readonly uint[] iT0;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x40")]
		private static readonly uint[] iT1;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x48")]
		private static readonly uint[] iT2;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x50")]
		private static readonly uint[] iT3;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x271D5A8", Offset = "0x27195A8", VA = "0x271D5A8")]
		public AesTransform(Aes algo, bool encryption, byte[] key, byte[] iv)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x271DF88", Offset = "0x2719F88", VA = "0x271DF88", Slot = "15")]
		protected override void ECB(byte[] input, byte[] output)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x271DEC0", Offset = "0x2719EC0", VA = "0x271DEC0")]
		private uint SubByte(uint a)
		{
			return default(uint);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x271DF9C", Offset = "0x2719F9C", VA = "0x271DF9C")]
		private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x271FAE0", Offset = "0x271BAE0", VA = "0x271FAE0")]
		private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey)
		{
		}
	}
}
namespace System.Security.Cryptography.X509Certificates
{
	[Token(Token = "0x2000016")]
	public static class RSACertificateExtensions
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x27218EC", Offset = "0x271D8EC", VA = "0x27218EC")]
		public static RSA GetRSAPublicKey(this X509Certificate2 certificate)
		{
			return null;
		}
	}
}
namespace System.Linq
{
	[Token(Token = "0x2000017")]
	internal static class Error
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x27219CC", Offset = "0x271D9CC", VA = "0x27219CC")]
		internal static Exception ArgumentNull(string s)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2721A28", Offset = "0x271DA28", VA = "0x2721A28")]
		internal static Exception ArgumentOutOfRange(string s)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2721A84", Offset = "0x271DA84", VA = "0x2721A84")]
		internal static Exception MoreThanOneElement()
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2721AF0", Offset = "0x271DAF0", VA = "0x2721AF0")]
		internal static Exception MoreThanOneMatch()
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2721B5C", Offset = "0x271DB5C", VA = "0x2721B5C")]
		internal static Exception NoElements()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2721BC8", Offset = "0x271DBC8", VA = "0x2721BC8")]
		internal static Exception NoMatch()
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2721C34", Offset = "0x271DC34", VA = "0x2721C34")]
		internal static Exception NotSupported()
		{
			return null;
		}
	}
	[Token(Token = "0x2000018")]
	public static class Enumerable
	{
		[Token(Token = "0x2000019")]
		private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x0")]
			private int threadId;

			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x0")]
			internal int state;

			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x0")]
			internal TSource current;

			[Token(Token = "0x1700000D")]
			public TSource Current
			{
				[Token(Token = "0x6000095")]
				get
				{
					return (TSource)null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600009C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000094")]
			public Iterator()
			{
			}

			[Token(Token = "0x6000096")]
			public abstract Iterator<TSource> Clone();

			[Token(Token = "0x6000097")]
			public virtual void Dispose()
			{
			}

			[Token(Token = "0x6000098")]
			public IEnumerator<TSource> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000099")]
			public abstract bool MoveNext();

			[Token(Token = "0x600009A")]
			public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);

			[Token(Token = "0x600009B")]
			public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);

			[Token(Token = "0x600009D")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600009E")]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001A")]
		private class WhereEnumerableIterator<TSource> : Iterator<TSource>
		{
			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> enumerator;

			[Token(Token = "0x600009F")]
			public WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
			{
			}

			[Token(Token = "0x60000A0")]
			public override Iterator<TSource> Clone()
			{
				return null;
			}

			[Token(Token = "0x60000A1")]
			public override void Dispose()
			{
			}

			[Token(Token = "0x60000A2")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000A3")]
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			[Token(Token = "0x60000A4")]
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}
		}

		[Token(Token = "0x200001B")]
		private class WhereArrayIterator<TSource> : Iterator<TSource>
		{
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x0")]
			private TSource[] source;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x0")]
			private int index;

			[Token(Token = "0x60000A5")]
			public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
			{
			}

			[Token(Token = "0x60000A6")]
			public override Iterator<TSource> Clone()
			{
				return null;
			}

			[Token(Token = "0x60000A7")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000A8")]
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			[Token(Token = "0x60000A9")]
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}
		}

		[Token(Token = "0x200001C")]
		private class WhereListIterator<TSource> : Iterator<TSource>
		{
			[Token(Token = "0x4000019")]
			[FieldOffset(Offset = "0x0")]
			private List<TSource> source;

			[Token(Token = "0x400001A")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			[Token(Token = "0x400001B")]
			[FieldOffset(Offset = "0x0")]
			private List<TSource>.Enumerator enumerator;

			[Token(Token = "0x60000AA")]
			public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
			{
			}

			[Token(Token = "0x60000AB")]
			public override Iterator<TSource> Clone()
			{
				return null;
			}

			[Token(Token = "0x60000AC")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000AD")]
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				return null;
			}

			[Token(Token = "0x60000AE")]
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				return null;
			}
		}

		[Token(Token = "0x200001D")]
		private class WhereSelectEnumerableIterator<TSource, TResult> : Iterator<TResult>
		{
			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, TResult> selector;

			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> enumerator;

			[Token(Token = "0x60000AF")]
			public WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			[Token(Token = "0x60000B0")]
			public override Iterator<TResult> Clone()
			{
				return null;
			}

			[Token(Token = "0x60000B1")]
			public override void Dispose()
			{
			}

			[Token(Token = "0x60000B2")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B3")]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			[Token(Token = "0x60000B4")]
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}
		}

		[Token(Token = "0x200001E")]
		private class WhereSelectArrayIterator<TSource, TResult> : Iterator<TResult>
		{
			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x0")]
			private TSource[] source;

			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, TResult> selector;

			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x0")]
			private int index;

			[Token(Token = "0x60000B5")]
			public WhereSelectArrayIterator(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			[Token(Token = "0x60000B6")]
			public override Iterator<TResult> Clone()
			{
				return null;
			}

			[Token(Token = "0x60000B7")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B8")]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			[Token(Token = "0x60000B9")]
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}
		}

		[Token(Token = "0x200001F")]
		private class WhereSelectListIterator<TSource, TResult> : Iterator<TResult>
		{
			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x0")]
			private List<TSource> source;

			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, TResult> selector;

			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x0")]
			private List<TSource>.Enumerator enumerator;

			[Token(Token = "0x60000BA")]
			public WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			[Token(Token = "0x60000BB")]
			public override Iterator<TResult> Clone()
			{
				return null;
			}

			[Token(Token = "0x60000BC")]
			public override bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BD")]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				return null;
			}

			[Token(Token = "0x60000BE")]
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				return null;
			}
		}

		[Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class <SelectManyIterator>d__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400002C")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0x0")]
			private TResult <>2__current;

			[Token(Token = "0x400002E")]
			[FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400002F")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			[Token(Token = "0x4000030")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__source;

			[Token(Token = "0x4000031")]
			[FieldOffset(Offset = "0x0")]
			private Func<TSource, IEnumerable<TResult>> selector;

			[Token(Token = "0x4000032")]
			[FieldOffset(Offset = "0x0")]
			public Func<TSource, IEnumerable<TResult>> <>3__selector;

			[Token(Token = "0x4000033")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap1;

			[Token(Token = "0x4000034")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TResult> <>7__wrap2;

			[Token(Token = "0x1700000F")]
			private TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[Token(Token = "0x60000C8")]
				[DebuggerHidden]
				get
				{
					return (TResult)null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000CA")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C3")]
			[DebuggerHidden]
			public <SelectManyIterator>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60000C4")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C5")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C6")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000C7")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60000C9")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000CB")]
			[DebuggerHidden]
			private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000CC")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class <TakeIterator>d__25<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000035")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000036")]
			[FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			[Token(Token = "0x4000037")]
			[FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000038")]
			[FieldOffset(Offset = "0x0")]
			private int count;

			[Token(Token = "0x4000039")]
			[FieldOffset(Offset = "0x0")]
			public int <>3__count;

			[Token(Token = "0x400003A")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__source;

			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap1;

			[Token(Token = "0x17000011")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[Token(Token = "0x60000D1")]
				[DebuggerHidden]
				get
				{
					return (TSource)null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D3")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CD")]
			[DebuggerHidden]
			public <TakeIterator>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x60000CE")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000CF")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000D2")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000D4")]
			[DebuggerHidden]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000D5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class <ConcatIterator>d__59<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> first;

			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__first;

			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> second;

			[Token(Token = "0x4000043")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__second;

			[Token(Token = "0x4000044")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap1;

			[Token(Token = "0x17000013")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[Token(Token = "0x60000DB")]
				[DebuggerHidden]
				get
				{
					return (TSource)null;
				}
			}

			[Token(Token = "0x17000014")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000DD")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D6")]
			[DebuggerHidden]
			public <ConcatIterator>d__59(int <>1__state)
			{
			}

			[Token(Token = "0x60000D7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D9")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000DA")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60000DC")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000DE")]
			[DebuggerHidden]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000DF")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class <DistinctIterator>d__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000045")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x0")]
			private IEqualityComparer<TSource> comparer;

			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x0")]
			public IEqualityComparer<TSource> <>3__comparer;

			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__source;

			[Token(Token = "0x400004C")]
			[FieldOffset(Offset = "0x0")]
			private Set<TSource> <set>5__2;

			[Token(Token = "0x400004D")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap2;

			[Token(Token = "0x17000015")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[Token(Token = "0x60000E4")]
				[DebuggerHidden]
				get
				{
					return (TSource)null;
				}
			}

			[Token(Token = "0x17000016")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000E6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E0")]
			[DebuggerHidden]
			public <DistinctIterator>d__68(int <>1__state)
			{
			}

			[Token(Token = "0x60000E1")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E2")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E3")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000E5")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000E7")]
			[DebuggerHidden]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000E8")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class <UnionIterator>d__71<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400004E")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400004F")]
			[FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			[Token(Token = "0x4000050")]
			[FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000051")]
			[FieldOffset(Offset = "0x0")]
			private IEqualityComparer<TSource> comparer;

			[Token(Token = "0x4000052")]
			[FieldOffset(Offset = "0x0")]
			public IEqualityComparer<TSource> <>3__comparer;

			[Token(Token = "0x4000053")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> first;

			[Token(Token = "0x4000054")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__first;

			[Token(Token = "0x4000055")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> second;

			[Token(Token = "0x4000056")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__second;

			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x0")]
			private Set<TSource> <set>5__2;

			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap2;

			[Token(Token = "0x17000017")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[Token(Token = "0x60000EE")]
				[DebuggerHidden]
				get
				{
					return (TSource)null;
				}
			}

			[Token(Token = "0x17000018")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F0")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E9")]
			[DebuggerHidden]
			public <UnionIterator>d__71(int <>1__state)
			{
			}

			[Token(Token = "0x60000EA")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000EB")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000EC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000ED")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60000EF")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000F1")]
			[DebuggerHidden]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000F2")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class <ExceptIterator>d__77<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000059")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400005A")]
			[FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			[Token(Token = "0x400005B")]
			[FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400005C")]
			[FieldOffset(Offset = "0x0")]
			private IEqualityComparer<TSource> comparer;

			[Token(Token = "0x400005D")]
			[FieldOffset(Offset = "0x0")]
			public IEqualityComparer<TSource> <>3__comparer;

			[Token(Token = "0x400005E")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> second;

			[Token(Token = "0x400005F")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__second;

			[Token(Token = "0x4000060")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> first;

			[Token(Token = "0x4000061")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__first;

			[Token(Token = "0x4000062")]
			[FieldOffset(Offset = "0x0")]
			private Set<TSource> <set>5__2;

			[Token(Token = "0x4000063")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap2;

			[Token(Token = "0x17000019")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[Token(Token = "0x60000F7")]
				[DebuggerHidden]
				get
				{
					return (TSource)null;
				}
			}

			[Token(Token = "0x1700001A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000F3")]
			[DebuggerHidden]
			public <ExceptIterator>d__77(int <>1__state)
			{
			}

			[Token(Token = "0x60000F4")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F5")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F6")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000F8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000FA")]
			[DebuggerHidden]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000FB")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class <ReverseIterator>d__79<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000064")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000065")]
			[FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			[Token(Token = "0x4000066")]
			[FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000067")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			[Token(Token = "0x4000068")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__source;

			[Token(Token = "0x4000069")]
			[FieldOffset(Offset = "0x0")]
			private Buffer<TSource> <buffer>5__2;

			[Token(Token = "0x400006A")]
			[FieldOffset(Offset = "0x0")]
			private int <i>5__3;

			[Token(Token = "0x1700001B")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[Token(Token = "0x60000FF")]
				[DebuggerHidden]
				get
				{
					return (TSource)null;
				}
			}

			[Token(Token = "0x1700001C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000101")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000FC")]
			[DebuggerHidden]
			public <ReverseIterator>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x60000FD")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000FE")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000100")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000102")]
			[DebuggerHidden]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000103")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class <OfTypeIterator>d__97<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400006B")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400006C")]
			[FieldOffset(Offset = "0x0")]
			private TResult <>2__current;

			[Token(Token = "0x400006D")]
			[FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400006E")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable source;

			[Token(Token = "0x400006F")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable <>3__source;

			[Token(Token = "0x4000070")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator <>7__wrap1;

			[Token(Token = "0x1700001D")]
			private TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[Token(Token = "0x6000108")]
				[DebuggerHidden]
				get
				{
					return (TResult)null;
				}
			}

			[Token(Token = "0x1700001E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600010A")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000104")]
			[DebuggerHidden]
			public <OfTypeIterator>d__97(int <>1__state)
			{
			}

			[Token(Token = "0x6000105")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000106")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000107")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000109")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600010B")]
			[DebuggerHidden]
			private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600010C")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class <CastIterator>d__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000071")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000072")]
			[FieldOffset(Offset = "0x0")]
			private TResult <>2__current;

			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerable source;

			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerable <>3__source;

			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0x0")]
			private IEnumerator <>7__wrap1;

			[Token(Token = "0x1700001F")]
			private TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[Token(Token = "0x6000111")]
				[DebuggerHidden]
				get
				{
					return (TResult)null;
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000113")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600010D")]
			[DebuggerHidden]
			public <CastIterator>d__99(int <>1__state)
			{
			}

			[Token(Token = "0x600010E")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600010F")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000110")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000112")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000114")]
			[DebuggerHidden]
			private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000115")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class <RangeIterator>d__115 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000077")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000078")]
			[FieldOffset(Offset = "0x14")]
			private int <>2__current;

			[Token(Token = "0x4000079")]
			[FieldOffset(Offset = "0x18")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400007A")]
			[FieldOffset(Offset = "0x1C")]
			private int start;

			[Token(Token = "0x400007B")]
			[FieldOffset(Offset = "0x20")]
			public int <>3__start;

			[Token(Token = "0x400007C")]
			[FieldOffset(Offset = "0x24")]
			private int count;

			[Token(Token = "0x400007D")]
			[FieldOffset(Offset = "0x28")]
			public int <>3__count;

			[Token(Token = "0x400007E")]
			[FieldOffset(Offset = "0x2C")]
			private int <i>5__2;

			[Token(Token = "0x17000021")]
			private int System.Collections.Generic.IEnumerator<System.Int32>.Current
			{
				[Token(Token = "0x6000119")]
				[Address(RVA = "0x27226EC", Offset = "0x271E6EC", VA = "0x27226EC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000022")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600011B")]
				[Address(RVA = "0x272272C", Offset = "0x271E72C", VA = "0x272272C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x2721D54", Offset = "0x271DD54", VA = "0x2721D54")]
			[DebuggerHidden]
			public <RangeIterator>d__115(int <>1__state)
			{
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2722688", Offset = "0x271E688", VA = "0x2722688", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x272268C", Offset = "0x271E68C", VA = "0x272268C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x27226F4", Offset = "0x271E6F4", VA = "0x27226F4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2722788", Offset = "0x271E788", VA = "0x2722788", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600011D")]
			[Address(RVA = "0x272282C", Offset = "0x271E82C", VA = "0x272282C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x600005A")]
		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[IteratorStateMachine(typeof(<SelectManyIterator>d__17<, >))]
		private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[IteratorStateMachine(typeof(<TakeIterator>d__25<>))]
		private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[IteratorStateMachine(typeof(<ConcatIterator>d__59<>))]
		private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[IteratorStateMachine(typeof(<DistinctIterator>d__68<>))]
		private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[IteratorStateMachine(typeof(<UnionIterator>d__71<>))]
		private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[IteratorStateMachine(typeof(<ExceptIterator>d__77<>))]
		private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[IteratorStateMachine(typeof(<ReverseIterator>d__79<>))]
		private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[IteratorStateMachine(typeof(<OfTypeIterator>d__97<>))]
		private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[IteratorStateMachine(typeof(<CastIterator>d__99<>))]
		private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		public static TSource First<TSource>(this IEnumerable<TSource> source)
		{
			return (TSource)null;
		}

		[Token(Token = "0x600007A")]
		public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return (TSource)null;
		}

		[Token(Token = "0x600007B")]
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			return (TSource)null;
		}

		[Token(Token = "0x600007C")]
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return (TSource)null;
		}

		[Token(Token = "0x600007D")]
		public static TSource Last<TSource>(this IEnumerable<TSource> source)
		{
			return (TSource)null;
		}

		[Token(Token = "0x600007E")]
		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			return (TSource)null;
		}

		[Token(Token = "0x600007F")]
		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return (TSource)null;
		}

		[Token(Token = "0x6000080")]
		public static TSource Single<TSource>(this IEnumerable<TSource> source)
		{
			return (TSource)null;
		}

		[Token(Token = "0x6000081")]
		public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return (TSource)null;
		}

		[Token(Token = "0x6000082")]
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			return (TSource)null;
		}

		[Token(Token = "0x6000083")]
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return (TSource)null;
		}

		[Token(Token = "0x6000084")]
		public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
		{
			return (TSource)null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2721C88", Offset = "0x271DC88", VA = "0x2721C88")]
		public static IEnumerable<int> Range(int start, int count)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2721CD4", Offset = "0x271DCD4", VA = "0x2721CD4")]
		[IteratorStateMachine(typeof(<RangeIterator>d__115))]
		private static IEnumerable<int> RangeIterator(int start, int count)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		public static IEnumerable<TResult> Empty<TResult>()
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		public static bool Any<TSource>(this IEnumerable<TSource> source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		public static int Count<TSource>(this IEnumerable<TSource> source)
		{
			return default(int);
		}

		[Token(Token = "0x600008C")]
		public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return default(int);
		}

		[Token(Token = "0x600008D")]
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2721D88", Offset = "0x271DD88", VA = "0x2721D88")]
		public static int Sum(this IEnumerable<int> source)
		{
			return default(int);
		}

		[Token(Token = "0x6000090")]
		public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			return default(int);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2722088", Offset = "0x271E088", VA = "0x2722088")]
		public static int Min(this IEnumerable<int> source)
		{
			return default(int);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2722388", Offset = "0x271E388", VA = "0x2722388")]
		public static int Max(this IEnumerable<int> source)
		{
			return default(int);
		}

		[Token(Token = "0x6000093")]
		public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200002C")]
	internal class EmptyEnumerable<TElement>
	{
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TElement[] Instance;
	}
	[Token(Token = "0x200002D")]
	internal class IdentityFunction<TElement>
	{
		[Token(Token = "0x17000023")]
		public static Func<TElement, TElement> Instance
		{
			[Token(Token = "0x600011F")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200002F")]
	public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable
	{
		[Token(Token = "0x6000123")]
		IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	}
	[Token(Token = "0x2000030")]
	public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement>, IEnumerable
	{
	}
	[Token(Token = "0x2000031")]
	[DefaultMember("Item")]
	public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
	{
		[Token(Token = "0x2000032")]
		internal class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement>
		{
			[Token(Token = "0x2000033")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__7 : IEnumerator<TElement>, IDisposable, IEnumerator
			{
				[Token(Token = "0x400008C")]
				[FieldOffset(Offset = "0x0")]
				private int <>1__state;

				[Token(Token = "0x400008D")]
				[FieldOffset(Offset = "0x0")]
				private TElement <>2__current;

				[Token(Token = "0x400008E")]
				[FieldOffset(Offset = "0x0")]
				public Grouping <>4__this;

				[Token(Token = "0x400008F")]
				[FieldOffset(Offset = "0x0")]
				private int <i>5__2;

				[Token(Token = "0x17000027")]
				private TElement System.Collections.Generic.IEnumerator<TElement>.Current
				{
					[Token(Token = "0x600013E")]
					[DebuggerHidden]
					get
					{
						return (TElement)null;
					}
				}

				[Token(Token = "0x17000028")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000140")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x600013B")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Token(Token = "0x600013C")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x600013D")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x600013F")]
				[DebuggerHidden]
				private void System.Collections.IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x4000086")]
			[FieldOffset(Offset = "0x0")]
			internal TKey key;

			[Token(Token = "0x4000087")]
			[FieldOffset(Offset = "0x0")]
			internal int hashCode;

			[Token(Token = "0x4000088")]
			[FieldOffset(Offset = "0x0")]
			internal TElement[] elements;

			[Token(Token = "0x4000089")]
			[FieldOffset(Offset = "0x0")]
			internal int count;

			[Token(Token = "0x400008A")]
			[FieldOffset(Offset = "0x0")]
			internal Grouping hashNext;

			[Token(Token = "0x400008B")]
			[FieldOffset(Offset = "0x0")]
			internal Grouping next;

			[Token(Token = "0x17000024")]
			private int System.Collections.Generic.ICollection<TElement>.Count
			{
				[Token(Token = "0x600012E")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000025")]
			private bool System.Collections.Generic.ICollection<TElement>.IsReadOnly
			{
				[Token(Token = "0x600012F")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000026")]
			private TElement System.Collections.Generic.IList<TElement>.Item
			{
				[Token(Token = "0x6000138")]
				get
				{
					return (TElement)null;
				}
				[Token(Token = "0x6000139")]
				set
				{
				}
			}

			[Token(Token = "0x600012B")]
			internal void Add(TElement element)
			{
			}

			[Token(Token = "0x600012C")]
			[IteratorStateMachine(typeof(Lookup<, >.Grouping.<GetEnumerator>d__7))]
			public IEnumerator<TElement> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600012D")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000130")]
			private void System.Collections.Generic.ICollection<TElement>.Add(TElement item)
			{
			}

			[Token(Token = "0x6000131")]
			private void System.Collections.Generic.ICollection<TElement>.Clear()
			{
			}

			[Token(Token = "0x6000132")]
			private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item)
			{
				return default(bool);
			}

			[Token(Token = "0x6000133")]
			private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex)
			{
			}

			[Token(Token = "0x6000134")]
			private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item)
			{
				return default(bool);
			}

			[Token(Token = "0x6000135")]
			private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item)
			{
				return default(int);
			}

			[Token(Token = "0x6000136")]
			private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item)
			{
			}

			[Token(Token = "0x6000137")]
			private void System.Collections.Generic.IList<TElement>.RemoveAt(int index)
			{
			}

			[Token(Token = "0x600013A")]
			public Grouping()
			{
			}
		}

		[Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__12 : IEnumerator<IGrouping<TKey, TElement>>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000090")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000091")]
			[FieldOffset(Offset = "0x0")]
			private IGrouping<TKey, TElement> <>2__current;

			[Token(Token = "0x4000092")]
			[FieldOffset(Offset = "0x0")]
			public Lookup<TKey, TElement> <>4__this;

			[Token(Token = "0x4000093")]
			[FieldOffset(Offset = "0x0")]
			private Grouping <g>5__2;

			[Token(Token = "0x17000029")]
			private IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current
			{
				[Token(Token = "0x6000144")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000146")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000141")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000142")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000143")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000145")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> comparer;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x0")]
		private Grouping[] groupings;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x0")]
		private Grouping lastGrouping;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x0")]
		private int count;

		[Token(Token = "0x6000124")]
		internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		private Lookup(IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000126")]
		[IteratorStateMachine(typeof(Lookup<, >.<GetEnumerator>d__12))]
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		internal int InternalGetHashCode(TKey key)
		{
			return default(int);
		}

		[Token(Token = "0x6000129")]
		internal Grouping GetGrouping(TKey key, bool create)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		private void Resize()
		{
		}
	}
	[Token(Token = "0x2000035")]
	internal class Set<TElement>
	{
		[Token(Token = "0x2000036")]
		internal struct Slot
		{
			[Token(Token = "0x4000099")]
			[FieldOffset(Offset = "0x0")]
			internal int hashCode;

			[Token(Token = "0x400009A")]
			[FieldOffset(Offset = "0x0")]
			internal TElement value;

			[Token(Token = "0x400009B")]
			[FieldOffset(Offset = "0x0")]
			internal int next;
		}

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x0")]
		private int[] buckets;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x0")]
		private Slot[] slots;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x0")]
		private int count;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x0")]
		private int freeList;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TElement> comparer;

		[Token(Token = "0x6000147")]
		public Set(IEqualityComparer<TElement> comparer)
		{
		}

		[Token(Token = "0x6000148")]
		public bool Add(TElement value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		private bool Find(TElement value, bool add)
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		private void Resize()
		{
		}

		[Token(Token = "0x600014B")]
		internal int InternalGetHashCode(TElement value)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000037")]
	internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
	{
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerable<TSource> source;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, TKey> keySelector;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x0")]
		private Func<TSource, TElement> elementSelector;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> comparer;

		[Token(Token = "0x600014C")]
		public GroupedEnumerable(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x600014D")]
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
	{
		[Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__1 : IEnumerator<TElement>, IDisposable, IEnumerator
		{
			[Token(Token = "0x40000A1")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40000A2")]
			[FieldOffset(Offset = "0x0")]
			private TElement <>2__current;

			[Token(Token = "0x40000A3")]
			[FieldOffset(Offset = "0x0")]
			public OrderedEnumerable<TElement> <>4__this;

			[Token(Token = "0x40000A4")]
			[FieldOffset(Offset = "0x0")]
			private Buffer<TElement> <buffer>5__2;

			[Token(Token = "0x40000A5")]
			[FieldOffset(Offset = "0x0")]
			private int[] <map>5__3;

			[Token(Token = "0x40000A6")]
			[FieldOffset(Offset = "0x0")]
			private int <i>5__4;

			[Token(Token = "0x1700002B")]
			private TElement System.Collections.Generic.IEnumerator<TElement>.Current
			{
				[Token(Token = "0x6000157")]
				[DebuggerHidden]
				get
				{
					return (TElement)null;
				}
			}

			[Token(Token = "0x1700002C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000159")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000154")]
			[DebuggerHidden]
			public <GetEnumerator>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000155")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000156")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000158")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x0")]
		internal IEnumerable<TElement> source;

		[Token(Token = "0x600014F")]
		[IteratorStateMachine(typeof(OrderedEnumerable<>.<GetEnumerator>d__1))]
		public IEnumerator<TElement> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);

		[Token(Token = "0x6000151")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		protected OrderedEnumerable()
		{
		}
	}
	[Token(Token = "0x200003A")]
	internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement>
	{
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x0")]
		internal OrderedEnumerable<TElement> parent;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		internal Func<TElement, TKey> keySelector;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x0")]
		internal IComparer<TKey> comparer;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x0")]
		internal bool descending;

		[Token(Token = "0x600015A")]
		internal OrderedEnumerable(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
		}

		[Token(Token = "0x600015B")]
		internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next)
		{
			return null;
		}
	}
	[Token(Token = "0x200003B")]
	internal abstract class EnumerableSorter<TElement>
	{
		[Token(Token = "0x600015C")]
		internal abstract void ComputeKeys(TElement[] elements, int count);

		[Token(Token = "0x600015D")]
		internal abstract int CompareKeys(int index1, int index2);

		[Token(Token = "0x600015E")]
		internal int[] Sort(TElement[] elements, int count)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		private void QuickSort(int[] map, int left, int right)
		{
		}

		[Token(Token = "0x6000160")]
		protected EnumerableSorter()
		{
		}
	}
	[Token(Token = "0x200003C")]
	internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement>
	{
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x0")]
		internal Func<TElement, TKey> keySelector;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x0")]
		internal IComparer<TKey> comparer;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x0")]
		internal bool descending;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		internal EnumerableSorter<TElement> next;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x0")]
		internal TKey[] keys;

		[Token(Token = "0x6000161")]
		internal EnumerableSorter(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next)
		{
		}

		[Token(Token = "0x6000162")]
		internal override void ComputeKeys(TElement[] elements, int count)
		{
		}

		[Token(Token = "0x6000163")]
		internal override int CompareKeys(int index1, int index2)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200003D")]
	internal struct Buffer<TElement>
	{
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x0")]
		internal TElement[] items;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x0")]
		internal int count;

		[Token(Token = "0x6000164")]
		internal Buffer(IEnumerable<TElement> source)
		{
		}

		[Token(Token = "0x6000165")]
		internal TElement[] ToArray()
		{
			return null;
		}
	}
}
namespace System.Linq.Expressions
{
	[Token(Token = "0x200003E")]
	internal static class CachedReflectionInfo
	{
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x0")]
		private static MethodInfo s_CallSiteOps_SetNotMatched;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x8")]
		private static MethodInfo s_CallSiteOps_CreateMatchmaker;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x10")]
		private static MethodInfo s_CallSiteOps_GetMatch;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x18")]
		private static MethodInfo s_CallSiteOps_ClearMatch;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x20")]
		private static MethodInfo s_CallSiteOps_UpdateRules;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x28")]
		private static MethodInfo s_CallSiteOps_GetRules;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x30")]
		private static MethodInfo s_CallSiteOps_GetRuleCache;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x38")]
		private static MethodInfo s_CallSiteOps_GetCachedRules;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x40")]
		private static MethodInfo s_CallSiteOps_AddRule;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x48")]
		private static MethodInfo s_CallSiteOps_MoveRule;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x50")]
		private static MethodInfo s_CallSiteOps_Bind;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x58")]
		private static MethodInfo s_String_op_Equality_String_String;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x60")]
		private static MethodInfo s_Math_Pow_Double_Double;

		[Token(Token = "0x1700002D")]
		public static MethodInfo CallSiteOps_SetNotMatched
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2722830", Offset = "0x271E830", VA = "0x2722830")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public static MethodInfo CallSiteOps_CreateMatchmaker
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x27228F8", Offset = "0x271E8F8", VA = "0x27228F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public static MethodInfo CallSiteOps_GetMatch
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x27229C0", Offset = "0x271E9C0", VA = "0x27229C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public static MethodInfo CallSiteOps_ClearMatch
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2722A88", Offset = "0x271EA88", VA = "0x2722A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public static MethodInfo CallSiteOps_UpdateRules
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x2722B50", Offset = "0x271EB50", VA = "0x2722B50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public static MethodInfo CallSiteOps_GetRules
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2722C18", Offset = "0x271EC18", VA = "0x2722C18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public static MethodInfo CallSiteOps_GetRuleCache
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x2722CE0", Offset = "0x271ECE0", VA = "0x2722CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public static MethodInfo CallSiteOps_GetCachedRules
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2722DA8", Offset = "0x271EDA8", VA = "0x2722DA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public static MethodInfo CallSiteOps_AddRule
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x2722E70", Offset = "0x271EE70", VA = "0x2722E70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public static MethodInfo CallSiteOps_MoveRule
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2722F38", Offset = "0x271EF38", VA = "0x2722F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public static MethodInfo CallSiteOps_Bind
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x2723000", Offset = "0x271F000", VA = "0x2723000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public static MethodInfo String_op_Equality_String_String
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x27230C8", Offset = "0x271F0C8", VA = "0x27230C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public static MethodInfo Math_Pow_Double_Double
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x2723250", Offset = "0x271F250", VA = "0x2723250")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200003F")]
	[DebuggerTypeProxy(typeof(BinaryExpressionProxy))]
	public class BinaryExpression : Expression
	{
		[Token(Token = "0x1700003A")]
		public override bool CanReduce
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2723464", Offset = "0x271F464", VA = "0x2723464", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public Expression Right
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2723498", Offset = "0x271F498", VA = "0x2723498")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public Expression Left
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x27234A0", Offset = "0x271F4A0", VA = "0x27234A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public MethodInfo Method
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x27234A8", Offset = "0x271F4A8", VA = "0x27234A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public LambdaExpression Conversion
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x2723630", Offset = "0x271F630", VA = "0x2723630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public bool IsLifted
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x272573C", Offset = "0x272173C", VA = "0x272573C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public bool IsLiftedToNull
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x2723A20", Offset = "0x271FA20", VA = "0x2723A20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		internal bool IsLiftedLogical
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x27258F0", Offset = "0x27218F0", VA = "0x27258F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		internal bool IsReferenceComparison
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x272363C", Offset = "0x271F63C", VA = "0x272363C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x27233EC", Offset = "0x271F3EC", VA = "0x27233EC")]
		internal BinaryExpression(Expression left, Expression right)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2723488", Offset = "0x271F488", VA = "0x2723488")]
		private static bool IsOpAssignment(ExpressionType op)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x27234B4", Offset = "0x271F4B4", VA = "0x27234B4", Slot = "10")]
		internal virtual MethodInfo GetMethod()
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x27234BC", Offset = "0x271F4BC", VA = "0x27234BC")]
		public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x27244DC", Offset = "0x27204DC", VA = "0x27244DC", Slot = "7")]
		public override Expression Reduce()
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2724ECC", Offset = "0x2720ECC", VA = "0x2724ECC")]
		private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op)
		{
			return default(ExpressionType);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2724DC8", Offset = "0x2720DC8", VA = "0x2724DC8")]
		private Expression ReduceVariable()
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2724554", Offset = "0x2720554", VA = "0x2724554")]
		private Expression ReduceMember()
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2724968", Offset = "0x2720968", VA = "0x2724968")]
		private Expression ReduceIndex()
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2725734", Offset = "0x2721734", VA = "0x2725734", Slot = "11")]
		internal virtual LambdaExpression GetConversion()
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x27258CC", Offset = "0x27218CC", VA = "0x27258CC", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2725A58", Offset = "0x2721A58", VA = "0x2725A58")]
		internal Expression ReduceUserdefinedLifted()
		{
			return null;
		}
	}
	[Token(Token = "0x2000040")]
	internal sealed class LogicalBinaryExpression : BinaryExpression
	{
		[Token(Token = "0x17000043")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2726C2C", Offset = "0x2722C2C", VA = "0x2726C2C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x2726C98", Offset = "0x2722C98", VA = "0x2726C98", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2726C00", Offset = "0x2722C00", VA = "0x2726C00")]
		internal LogicalBinaryExpression(ExpressionType nodeType, Expression left, Expression right)
		{
		}
	}
	[Token(Token = "0x2000041")]
	internal class AssignBinaryExpression : BinaryExpression
	{
		[Token(Token = "0x17000045")]
		public sealed override Type Type
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x2726CA4", Offset = "0x2722CA4", VA = "0x2726CA4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2726CC0", Offset = "0x2722CC0", VA = "0x2726CC0", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2726CA0", Offset = "0x2722CA0", VA = "0x2726CA0")]
		internal AssignBinaryExpression(Expression left, Expression right)
		{
		}
	}
	[Token(Token = "0x2000042")]
	internal sealed class CoalesceConversionBinaryExpression : BinaryExpression
	{
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x20")]
		private readonly LambdaExpression _conversion;

		[Token(Token = "0x17000047")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x2726CF4", Offset = "0x2722CF4", VA = "0x2726CF4", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x17000048")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2726CFC", Offset = "0x2722CFC", VA = "0x2726CFC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2726CC8", Offset = "0x2722CC8", VA = "0x2726CC8")]
		internal CoalesceConversionBinaryExpression(Expression left, Expression right, LambdaExpression conversion)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2726CEC", Offset = "0x2722CEC", VA = "0x2726CEC", Slot = "11")]
		internal override LambdaExpression GetConversion()
		{
			return null;
		}
	}
	[Token(Token = "0x2000043")]
	internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression
	{
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x38")]
		private readonly LambdaExpression _conversion;

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2726D18", Offset = "0x2722D18", VA = "0x2726D18")]
		internal OpAssignMethodConversionBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2726DA0", Offset = "0x2722DA0", VA = "0x2726DA0", Slot = "11")]
		internal override LambdaExpression GetConversion()
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	internal class SimpleBinaryExpression : BinaryExpression
	{
		[Token(Token = "0x17000049")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x2726DDC", Offset = "0x2722DDC", VA = "0x2726DDC", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x1700004A")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x2726DE4", Offset = "0x2722DE4", VA = "0x2726DE4", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2726DA8", Offset = "0x2722DA8", VA = "0x2726DA8")]
		internal SimpleBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type)
		{
		}
	}
	[Token(Token = "0x2000045")]
	internal class MethodBinaryExpression : SimpleBinaryExpression
	{
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x30")]
		private readonly MethodInfo _method;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2726D60", Offset = "0x2722D60", VA = "0x2726D60")]
		internal MethodBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2726DEC", Offset = "0x2722DEC", VA = "0x2726DEC", Slot = "10")]
		internal override MethodInfo GetMethod()
		{
			return null;
		}
	}
	[Token(Token = "0x2000046")]
	public abstract class Expression
	{
		[Token(Token = "0x2000047")]
		internal class BinaryExpressionProxy
		{
		}

		[Token(Token = "0x2000048")]
		internal class BlockExpressionProxy
		{
		}

		[Token(Token = "0x2000049")]
		internal class CatchBlockProxy
		{
		}

		[Token(Token = "0x200004A")]
		internal class ConditionalExpressionProxy
		{
		}

		[Token(Token = "0x200004B")]
		internal class ConstantExpressionProxy
		{
		}

		[Token(Token = "0x200004C")]
		internal class DebugInfoExpressionProxy
		{
		}

		[Token(Token = "0x200004D")]
		internal class DefaultExpressionProxy
		{
		}

		[Token(Token = "0x200004E")]
		internal class GotoExpressionProxy
		{
		}

		[Token(Token = "0x200004F")]
		internal class IndexExpressionProxy
		{
		}

		[Token(Token = "0x2000050")]
		internal class InvocationExpressionProxy
		{
		}

		[Token(Token = "0x2000051")]
		internal class LabelExpressionProxy
		{
		}

		[Token(Token = "0x2000052")]
		internal class LambdaExpressionProxy
		{
		}

		[Token(Token = "0x2000053")]
		internal class ListInitExpressionProxy
		{
		}

		[Token(Token = "0x2000054")]
		internal class LoopExpressionProxy
		{
		}

		[Token(Token = "0x2000055")]
		internal class MemberExpressionProxy
		{
		}

		[Token(Token = "0x2000056")]
		internal class MemberInitExpressionProxy
		{
		}

		[Token(Token = "0x2000057")]
		internal class MethodCallExpressionProxy
		{
		}

		[Token(Token = "0x2000058")]
		internal class NewArrayExpressionProxy
		{
		}

		[Token(Token = "0x2000059")]
		internal class NewExpressionProxy
		{
		}

		[Token(Token = "0x200005A")]
		internal class ParameterExpressionProxy
		{
		}

		[Token(Token = "0x200005B")]
		internal class RuntimeVariablesExpressionProxy
		{
		}

		[Token(Token = "0x200005C")]
		internal class SwitchCaseProxy
		{
		}

		[Token(Token = "0x200005D")]
		internal class SwitchExpressionProxy
		{
		}

		[Token(Token = "0x200005E")]
		internal class TryExpressionProxy
		{
		}

		[Token(Token = "0x200005F")]
		internal class TypeBinaryExpressionProxy
		{
		}

		[Token(Token = "0x2000060")]
		internal class UnaryExpressionProxy
		{
		}

		[Token(Token = "0x2000061")]
		private class ExtensionInfo
		{
			[Token(Token = "0x40000CA")]
			[FieldOffset(Offset = "0x10")]
			internal readonly ExpressionType NodeType;

			[Token(Token = "0x40000CB")]
			[FieldOffset(Offset = "0x18")]
			internal readonly Type Type;
		}

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x8")]
		private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x10")]
		private static ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable;

		[Token(Token = "0x1700004B")]
		public virtual ExpressionType NodeType
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x2731B8C", Offset = "0x272DB8C", VA = "0x2731B8C", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x1700004C")]
		public virtual Type Type
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x2731C80", Offset = "0x272DC80", VA = "0x2731C80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public virtual bool CanReduce
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x2731D74", Offset = "0x272DD74", VA = "0x2731D74", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x27250F4", Offset = "0x27210F4", VA = "0x27250F4")]
		public static BinaryExpression Assign(Expression left, Expression right)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2727054", Offset = "0x2723054", VA = "0x2727054")]
		private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2727610", Offset = "0x2723610", VA = "0x2727610")]
		private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2727E84", Offset = "0x2723E84", VA = "0x2727E84")]
		private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2728364", Offset = "0x2724364", VA = "0x2728364")]
		private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2728580", Offset = "0x2724580", VA = "0x2728580")]
		private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x27273F4", Offset = "0x27233F4", VA = "0x27273F4")]
		private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x27287E8", Offset = "0x27247E8", VA = "0x27287E8")]
		private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2727D04", Offset = "0x2723D04", VA = "0x2727D04")]
		internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2727DA8", Offset = "0x2723DA8", VA = "0x2727DA8")]
		private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2727BAC", Offset = "0x2723BAC", VA = "0x2727BAC")]
		private static void ValidateOperator(MethodInfo method)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x27288B0", Offset = "0x27248B0", VA = "0x27288B0")]
		private static void ValidateMethodInfo(MethodInfo method, string paramName)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2728940", Offset = "0x2724940", VA = "0x2728940")]
		private static bool IsNullComparison(Expression left, Expression right)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2728A4C", Offset = "0x2724A4C", VA = "0x2728A4C")]
		private static bool IsNullConstant(Expression e)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2728AD0", Offset = "0x2724AD0", VA = "0x2728AD0")]
		private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x27291F0", Offset = "0x27251F0", VA = "0x27291F0")]
		private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x27290EC", Offset = "0x27250EC", VA = "0x27290EC")]
		private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2724F10", Offset = "0x2720F10", VA = "0x2724F10")]
		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2723AAC", Offset = "0x271FAAC", VA = "0x2723AAC")]
		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x272F078", Offset = "0x272B078", VA = "0x272F078")]
		public static BinaryExpression Equal(Expression left, Expression right)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x272BDFC", Offset = "0x2727DFC", VA = "0x272BDFC")]
		public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2723710", Offset = "0x271F710", VA = "0x2723710")]
		public static BinaryExpression ReferenceEqual(Expression left, Expression right)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x272F500", Offset = "0x272B500", VA = "0x272F500")]
		public static BinaryExpression NotEqual(Expression left, Expression right)
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x272BF2C", Offset = "0x2727F2C", VA = "0x272BF2C")]
		public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2723898", Offset = "0x271F898", VA = "0x2723898")]
		public static BinaryExpression ReferenceNotEqual(Expression left, Expression right)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x272F0E4", Offset = "0x272B0E4", VA = "0x272F0E4")]
		private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x272BB9C", Offset = "0x2727B9C", VA = "0x272BB9C")]
		public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x272B93C", Offset = "0x272793C", VA = "0x272B93C")]
		public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x272BCCC", Offset = "0x2727CCC", VA = "0x272BCCC")]
		public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x272BA6C", Offset = "0x2727A6C", VA = "0x272BA6C")]
		public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x272F56C", Offset = "0x272B56C", VA = "0x272F56C")]
		private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x272F7B0", Offset = "0x272B7B0", VA = "0x272F7B0")]
		public static BinaryExpression AndAlso(Expression left, Expression right)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x272AC04", Offset = "0x2726C04", VA = "0x272AC04")]
		public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x272B358", Offset = "0x2727358", VA = "0x272B358")]
		public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x272C2A4", Offset = "0x27282A4", VA = "0x272C2A4")]
		public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x272F818", Offset = "0x272B818", VA = "0x272F818")]
		private static Type ValidateCoalesceArgTypes(Type left, Type right)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x27293B4", Offset = "0x27253B4", VA = "0x27293B4")]
		public static BinaryExpression Add(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x272CD78", Offset = "0x2728D78", VA = "0x272CD78")]
		public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x27280EC", Offset = "0x27240EC", VA = "0x27280EC")]
		private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x272E8B0", Offset = "0x272A8B0", VA = "0x272E8B0")]
		public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x27295F8", Offset = "0x27255F8", VA = "0x27295F8")]
		public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2729840", Offset = "0x2725840", VA = "0x2729840")]
		public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x272E618", Offset = "0x272A618", VA = "0x272E618")]
		public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x272EB48", Offset = "0x272AB48", VA = "0x272EB48")]
		public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2729A88", Offset = "0x2725A88", VA = "0x2729A88")]
		public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x272A160", Offset = "0x2726160", VA = "0x272A160")]
		public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x272D2A8", Offset = "0x27292A8", VA = "0x272D2A8")]
		public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x272A3A8", Offset = "0x27263A8", VA = "0x272A3A8")]
		public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x272DA44", Offset = "0x2729A44", VA = "0x272DA44")]
		public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2729CD0", Offset = "0x2725CD0", VA = "0x2729CD0")]
		public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x272DCDC", Offset = "0x2729CDC", VA = "0x272DCDC")]
		public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x272EDE0", Offset = "0x272ADE0", VA = "0x272EDE0")]
		public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2729F18", Offset = "0x2725F18", VA = "0x2729F18")]
		public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x272F988", Offset = "0x272B988", VA = "0x272F988")]
		private static bool IsSimpleShift(Type left, Type right)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x272FA80", Offset = "0x272BA80", VA = "0x272FA80")]
		private static Type GetResultTypeOfShift(Type left, Type right)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x272CB5C", Offset = "0x2728B5C", VA = "0x272CB5C")]
		public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x272D7D8", Offset = "0x27297D8", VA = "0x272D7D8")]
		public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x272C940", Offset = "0x2728940", VA = "0x272C940")]
		public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x272E3AC", Offset = "0x272A3AC", VA = "0x272E3AC")]
		public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x272A9BC", Offset = "0x27269BC", VA = "0x272A9BC")]
		public static BinaryExpression And(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x272D010", Offset = "0x2729010", VA = "0x272D010")]
		public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x272B110", Offset = "0x2727110", VA = "0x272B110")]
		public static BinaryExpression Or(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x272DF74", Offset = "0x2729F74", VA = "0x272DF74")]
		public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x272C05C", Offset = "0x272805C", VA = "0x272C05C")]
		public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x272D540", Offset = "0x2729540", VA = "0x272D540")]
		public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x272A5F0", Offset = "0x27265F0", VA = "0x272A5F0")]
		public static BinaryExpression Power(Expression left, Expression right, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x272E20C", Offset = "0x272A20C", VA = "0x272E20C")]
		public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x272C754", Offset = "0x2728754", VA = "0x272C754")]
		public static BinaryExpression ArrayIndex(Expression array, Expression index)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x272FBE8", Offset = "0x272BBE8", VA = "0x272FBE8")]
		public static BlockExpression Block(Expression arg0, Expression arg1)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x272FCA4", Offset = "0x272BCA4", VA = "0x272FCA4")]
		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x272FD94", Offset = "0x272BD94", VA = "0x272FD94")]
		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x272FEB8", Offset = "0x272BEB8", VA = "0x272FEB8")]
		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2730008", Offset = "0x272C008", VA = "0x2730008")]
		public static BlockExpression Block(IEnumerable<Expression> expressions)
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2730094", Offset = "0x272C094", VA = "0x2730094")]
		public static BlockExpression Block(Type type, params Expression[] expressions)
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x273011C", Offset = "0x272C11C", VA = "0x273011C")]
		public static BlockExpression Block(Type type, IEnumerable<Expression> expressions)
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x27303E4", Offset = "0x272C3E4", VA = "0x27303E4")]
		public static BlockExpression Block(IEnumerable<ParameterExpression> variables, params Expression[] expressions)
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2730448", Offset = "0x272C448", VA = "0x2730448")]
		public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, params Expression[] expressions)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x272551C", Offset = "0x272151C", VA = "0x272551C")]
		public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x27301B8", Offset = "0x272C1B8", VA = "0x27301B8")]
		public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2730EC8", Offset = "0x272CEC8", VA = "0x2730EC8")]
		private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions)
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2731250", Offset = "0x272D250", VA = "0x2731250")]
		internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x27305FC", Offset = "0x272C5FC", VA = "0x27305FC")]
		private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x27313F8", Offset = "0x272D3F8", VA = "0x27313F8")]
		public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2726A08", Offset = "0x2722A08", VA = "0x2726A08")]
		public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse)
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2731684", Offset = "0x272D684", VA = "0x2731684")]
		public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type)
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x273190C", Offset = "0x272D90C", VA = "0x273190C")]
		public static ConditionalExpression IfThen(Expression test, Expression ifTrue)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2731A74", Offset = "0x272DA74", VA = "0x2731A74")]
		public static ConstantExpression Constant(object value)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x27267C8", Offset = "0x27227C8", VA = "0x27267C8")]
		public static ConstantExpression Constant(object value, Type type)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x27319CC", Offset = "0x272D9CC", VA = "0x27319CC")]
		public static DefaultExpression Empty()
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2731AD0", Offset = "0x272DAD0", VA = "0x2731AD0")]
		public static DefaultExpression Default(Type type)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x272345C", Offset = "0x271F45C", VA = "0x272345C")]
		protected Expression()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2731D7C", Offset = "0x272DD7C", VA = "0x2731D7C", Slot = "7")]
		public virtual Expression Reduce()
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2731DC4", Offset = "0x272DDC4", VA = "0x2731DC4", Slot = "8")]
		protected internal virtual Expression VisitChildren(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2731F3C", Offset = "0x272DF3C", VA = "0x2731F3C", Slot = "9")]
		protected internal virtual Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2731E38", Offset = "0x272DE38", VA = "0x2731E38")]
		public Expression ReduceAndCheck()
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2731F60", Offset = "0x272DF60", VA = "0x2731F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x27304B4", Offset = "0x272C4B4", VA = "0x27304B4")]
		private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2726DF4", Offset = "0x2722DF4", VA = "0x2726DF4")]
		private static void RequiresCanWrite(Expression expression, string paramName)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2731F68", Offset = "0x272DF68", VA = "0x2731F68")]
		public static GotoExpression Break(LabelTarget target)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x273210C", Offset = "0x272E10C", VA = "0x273210C")]
		public static GotoExpression Return(LabelTarget target)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x27321C4", Offset = "0x272E1C4", VA = "0x27321C4")]
		public static GotoExpression Return(LabelTarget target, Expression value)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2732280", Offset = "0x272E280", VA = "0x2732280")]
		public static GotoExpression Goto(LabelTarget target, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x27322EC", Offset = "0x272E2EC", VA = "0x27322EC")]
		public static GotoExpression Goto(LabelTarget target, Expression value)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2732020", Offset = "0x272E020", VA = "0x2732020")]
		public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x27323A8", Offset = "0x272E3A8", VA = "0x27323A8")]
		private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x273256C", Offset = "0x272E56C", VA = "0x273256C")]
		private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2725690", Offset = "0x2721690", VA = "0x2725690")]
		public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2732C24", Offset = "0x272EC24", VA = "0x2732C24")]
		public static IndexExpression ArrayAccess(Expression array, params Expression[] indexes)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x27327AC", Offset = "0x272E7AC", VA = "0x27327AC")]
		public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x27326F8", Offset = "0x272E6F8", VA = "0x27326F8")]
		public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2732C88", Offset = "0x272EC88", VA = "0x2732C88")]
		private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2732D44", Offset = "0x272ED44", VA = "0x2732D44")]
		private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x27332B8", Offset = "0x272F2B8", VA = "0x27332B8")]
		private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2733520", Offset = "0x272F520", VA = "0x2733520")]
		private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2733958", Offset = "0x272F958", VA = "0x2733958")]
		internal static InvocationExpression Invoke(Expression expression)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2724F98", Offset = "0x2720F98", VA = "0x2724F98")]
		internal static InvocationExpression Invoke(Expression expression, Expression arg0)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2733C78", Offset = "0x272FC78", VA = "0x2733C78")]
		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2733E2C", Offset = "0x272FE2C", VA = "0x2733E2C")]
		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2734030", Offset = "0x2730030", VA = "0x2734030")]
		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x273428C", Offset = "0x273028C", VA = "0x273428C")]
		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2734540", Offset = "0x2730540", VA = "0x2734540")]
		public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2733A5C", Offset = "0x272FA5C", VA = "0x2733A5C")]
		internal static MethodInfo GetInvokeMethod(Expression expression)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2734E70", Offset = "0x2730E70", VA = "0x2734E70")]
		public static LabelExpression Label(LabelTarget target)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2734EC8", Offset = "0x2730EC8", VA = "0x2734EC8")]
		public static LabelExpression Label(LabelTarget target, Expression defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2734F9C", Offset = "0x2730F9C", VA = "0x2734F9C")]
		public static LabelTarget Label()
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2735104", Offset = "0x2731104", VA = "0x2735104")]
		public static LabelTarget Label(string name)
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x27351B4", Offset = "0x27311B4", VA = "0x27351B4")]
		public static LabelTarget Label(Type type)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2735040", Offset = "0x2731040", VA = "0x2735040")]
		public static LabelTarget Label(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x273520C", Offset = "0x273120C", VA = "0x273520C")]
		internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params ParameterExpression[] parameters)
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2735678", Offset = "0x2731678", VA = "0x2735678")]
		public static LambdaExpression Lambda(Type delegateType, Expression body, params ParameterExpression[] parameters)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x27356EC", Offset = "0x27316EC", VA = "0x27356EC")]
		public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
		{
			return null;
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x27357CC", Offset = "0x27317CC", VA = "0x27357CC")]
		private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2735E68", Offset = "0x2731E68", VA = "0x2735E68")]
		public static LoopExpression Loop(Expression body, LabelTarget @break, LabelTarget @continue)
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2735F94", Offset = "0x2731F94", VA = "0x2735F94")]
		public static MemberExpression Field(Expression expression, FieldInfo field)
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2736148", Offset = "0x2732148", VA = "0x2736148")]
		public static MemberExpression Field(Expression expression, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x272618C", Offset = "0x272218C", VA = "0x272618C")]
		public static MemberExpression Property(Expression expression, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x27362B8", Offset = "0x27322B8", VA = "0x27362B8")]
		public static MemberExpression Property(Expression expression, PropertyInfo property)
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2725358", Offset = "0x2721358", VA = "0x2725358")]
		public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x273656C", Offset = "0x273256C", VA = "0x273656C")]
		internal static MethodCallExpression Call(MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2726468", Offset = "0x2722468", VA = "0x2726468")]
		public static MethodCallExpression Call(MethodInfo method, Expression arg0)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x27265B0", Offset = "0x27225B0", VA = "0x27265B0")]
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1)
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x27366D0", Offset = "0x27326D0", VA = "0x27366D0")]
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x27368E8", Offset = "0x27328E8", VA = "0x27368E8")]
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2736B68", Offset = "0x2732B68", VA = "0x2736B68")]
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2736E5C", Offset = "0x2732E5C", VA = "0x2736E5C")]
		public static MethodCallExpression Call(MethodInfo method, params Expression[] arguments)
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2736F30", Offset = "0x2732F30", VA = "0x2736F30")]
		public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2737900", Offset = "0x2733900", VA = "0x2737900")]
		public static MethodCallExpression Call(Expression instance, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2736EC4", Offset = "0x2732EC4", VA = "0x2736EC4")]
		public static MethodCallExpression Call(Expression instance, MethodInfo method, params Expression[] arguments)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2737A0C", Offset = "0x2733A0C", VA = "0x2737A0C")]
		internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0)
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2737B90", Offset = "0x2733B90", VA = "0x2737B90")]
		public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1)
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2737D80", Offset = "0x2733D80", VA = "0x2737D80")]
		public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2726300", Offset = "0x2722300", VA = "0x2726300")]
		public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, params Expression[] arguments)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2736F98", Offset = "0x2732F98", VA = "0x2736F98")]
		public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments)
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x273663C", Offset = "0x273263C", VA = "0x273663C")]
		private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x273823C", Offset = "0x273423C", VA = "0x273823C")]
		private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2733468", Offset = "0x272F468", VA = "0x2733468")]
		private static void ValidateCallInstanceType(Type instanceType, MethodInfo method)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2734E68", Offset = "0x2730E68", VA = "0x2734E68")]
		private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2733C5C", Offset = "0x272FC5C", VA = "0x2733C5C")]
		private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind)
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2733C64", Offset = "0x272FC64", VA = "0x2733C64")]
		private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2733C6C", Offset = "0x272FC6C", VA = "0x2733C6C")]
		private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x27326F0", Offset = "0x272E6F0", VA = "0x27326F0")]
		private static bool TryQuote(Type parameterType, ref Expression argument)
		{
			return default(bool);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2737FDC", Offset = "0x2733FDC", VA = "0x2737FDC")]
		private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x27383D8", Offset = "0x27343D8", VA = "0x27383D8")]
		private static bool IsCompatible(MethodBase m, Expression[] arguments)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2738324", Offset = "0x2734324", VA = "0x2738324")]
		private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2738618", Offset = "0x2734618", VA = "0x2738618")]
		public static NewArrayExpression NewArrayInit(Type type, params Expression[] initializers)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x273867C", Offset = "0x273467C", VA = "0x273867C")]
		public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2738A8C", Offset = "0x2734A8C", VA = "0x2738A8C")]
		public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2738D38", Offset = "0x2734D38", VA = "0x2738D38")]
		public static ParameterExpression Parameter(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x27260E0", Offset = "0x27220E0", VA = "0x27260E0")]
		public static ParameterExpression Parameter(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x27252E0", Offset = "0x27212E0", VA = "0x27252E0")]
		public static ParameterExpression Variable(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2738D90", Offset = "0x2734D90", VA = "0x2738D90")]
		private static void Validate(Type type, bool allowByRef)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2738EBC", Offset = "0x2734EBC", VA = "0x2738EBC")]
		public static TryExpression TryFinally(Expression body, Expression @finally)
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2738F2C", Offset = "0x2734F2C", VA = "0x2738F2C")]
		public static TryExpression MakeTry(Type type, Expression body, Expression @finally, Expression fault, IEnumerable<CatchBlock> handlers)
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2739160", Offset = "0x2735160", VA = "0x2739160")]
		private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2739A44", Offset = "0x2735A44", VA = "0x2739A44")]
		public static TypeBinaryExpression TypeIs(Expression expression, Type type)
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2739B44", Offset = "0x2735B44", VA = "0x2739B44")]
		public static TypeBinaryExpression TypeEqual(Expression expression, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2739C44", Offset = "0x2735C44", VA = "0x2739C44")]
		public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x273BE14", Offset = "0x2737E14", VA = "0x273BE14")]
		private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand)
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x273BF98", Offset = "0x2737F98", VA = "0x273BF98")]
		private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x273C29C", Offset = "0x273829C", VA = "0x273C29C")]
		private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x273C640", Offset = "0x2738640", VA = "0x273C640")]
		private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x273C6F4", Offset = "0x27386F4", VA = "0x273C6F4")]
		private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x273C7D8", Offset = "0x27387D8", VA = "0x273C7D8")]
		private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x273A1C0", Offset = "0x27361C0", VA = "0x273A1C0")]
		public static UnaryExpression Negate(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x273B5D0", Offset = "0x27375D0", VA = "0x273B5D0")]
		public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x273A390", Offset = "0x2736390", VA = "0x273A390")]
		public static UnaryExpression NegateChecked(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x273CB70", Offset = "0x2738B70", VA = "0x273CB70")]
		public static UnaryExpression Not(Expression expression)
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x273A560", Offset = "0x2736560", VA = "0x273A560")]
		public static UnaryExpression Not(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x273A738", Offset = "0x2736738", VA = "0x273A738")]
		public static UnaryExpression IsFalse(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x273A8D0", Offset = "0x27368D0", VA = "0x273A8D0")]
		public static UnaryExpression IsTrue(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x273AA68", Offset = "0x2736A68", VA = "0x273AA68")]
		public static UnaryExpression OnesComplement(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x273B350", Offset = "0x2737350", VA = "0x273B350")]
		public static UnaryExpression TypeAs(Expression expression, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x273B768", Offset = "0x2737768", VA = "0x273B768")]
		public static UnaryExpression Unbox(Expression expression, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2726760", Offset = "0x2722760", VA = "0x2726760")]
		public static UnaryExpression Convert(Expression expression, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x273ADDC", Offset = "0x2736DDC", VA = "0x273ADDC")]
		public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x273AFE4", Offset = "0x2736FE4", VA = "0x273AFE4")]
		public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x273AC00", Offset = "0x2736C00", VA = "0x273AC00")]
		public static UnaryExpression ArrayLength(Expression array)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x273B4B8", Offset = "0x27374B8", VA = "0x273B4B8")]
		public static UnaryExpression Quote(Expression expression)
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x273B208", Offset = "0x2737208", VA = "0x273B208")]
		public static UnaryExpression Throw(Expression value, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x273B944", Offset = "0x2737944", VA = "0x273B944")]
		public static UnaryExpression Increment(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x273BADC", Offset = "0x2737ADC", VA = "0x273BADC")]
		public static UnaryExpression Decrement(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x273CBC8", Offset = "0x2738BC8", VA = "0x273CBC8")]
		public static UnaryExpression PreIncrementAssign(Expression expression)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x273BC74", Offset = "0x2737C74", VA = "0x273BC74")]
		public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x273BD44", Offset = "0x2737D44", VA = "0x273BD44")]
		public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x273BCDC", Offset = "0x2737CDC", VA = "0x273BCDC")]
		public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x273BDAC", Offset = "0x2737DAC", VA = "0x273BDAC")]
		public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x273CC24", Offset = "0x2738C24", VA = "0x273CC24")]
		private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method)
		{
			return null;
		}
	}
	[Token(Token = "0x2000062")]
	[DebuggerTypeProxy(typeof(BlockExpressionProxy))]
	public class BlockExpression : Expression
	{
		[Token(Token = "0x1700004E")]
		public ReadOnlyCollection<Expression> Expressions
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x273CF44", Offset = "0x2738F44", VA = "0x273CF44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public ReadOnlyCollection<ParameterExpression> Variables
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x273CF50", Offset = "0x2738F50", VA = "0x273CF50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x273CFDC", Offset = "0x2738FDC", VA = "0x273CFDC", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x17000051")]
		public override Type Type
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x273CFE4", Offset = "0x2738FE4", VA = "0x273CFE4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		[ExcludeFromCodeCoverage]
		internal virtual int ExpressionCount
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x273D04C", Offset = "0x273904C", VA = "0x273D04C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x273CF60", Offset = "0x2738F60", VA = "0x273CF60")]
		internal BlockExpression()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x273CFB8", Offset = "0x2738FB8", VA = "0x273CFB8", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x273D024", Offset = "0x2739024", VA = "0x273D024", Slot = "10")]
		[ExcludeFromCodeCoverage]
		internal virtual Expression GetExpression(int index)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x273D074", Offset = "0x2739074", VA = "0x273D074", Slot = "12")]
		[ExcludeFromCodeCoverage]
		internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x273D09C", Offset = "0x273909C", VA = "0x273D09C", Slot = "13")]
		internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x273D0F4", Offset = "0x27390F4", VA = "0x273D0F4", Slot = "14")]
		[ExcludeFromCodeCoverage]
		internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x273D11C", Offset = "0x273911C", VA = "0x273D11C")]
		internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection)
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	internal sealed class Block2 : BlockExpression
	{
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x10")]
		private object _arg0;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x18")]
		private readonly Expression _arg1;

		[Token(Token = "0x17000053")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x273D3A0", Offset = "0x27393A0", VA = "0x273D3A0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x273D288", Offset = "0x2739288", VA = "0x273D288")]
		internal Block2(Expression arg0, Expression arg1)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x273D2B0", Offset = "0x27392B0", VA = "0x273D2B0", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x273D3A8", Offset = "0x27393A8", VA = "0x273D3A8", Slot = "12")]
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x273D3B0", Offset = "0x27393B0", VA = "0x273D3B0", Slot = "14")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	internal sealed class Block3 : BlockExpression
	{
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x10")]
		private object _arg0;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x18")]
		private readonly Expression _arg1;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _arg2;

		[Token(Token = "0x17000054")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x273D514", Offset = "0x2739514", VA = "0x273D514", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x273D438", Offset = "0x2739438", VA = "0x273D438")]
		internal Block3(Expression arg0, Expression arg1, Expression arg2)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x273D470", Offset = "0x2739470", VA = "0x273D470", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x273D51C", Offset = "0x273951C", VA = "0x273D51C", Slot = "12")]
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x273D524", Offset = "0x2739524", VA = "0x273D524", Slot = "14")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	internal sealed class Block4 : BlockExpression
	{
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x10")]
		private object _arg0;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x18")]
		private readonly Expression _arg1;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _arg2;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg3;

		[Token(Token = "0x17000055")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x273D6B4", Offset = "0x27396B4", VA = "0x273D6B4", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x273D5BC", Offset = "0x27395BC", VA = "0x273D5BC")]
		internal Block4(Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x273D5F8", Offset = "0x27395F8", VA = "0x273D5F8", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x273D6BC", Offset = "0x27396BC", VA = "0x273D6BC", Slot = "12")]
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x273D6C4", Offset = "0x27396C4", VA = "0x273D6C4", Slot = "14")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000066")]
	internal sealed class Block5 : BlockExpression
	{
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x10")]
		private object _arg0;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x18")]
		private readonly Expression _arg1;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _arg2;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg3;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x30")]
		private readonly Expression _arg4;

		[Token(Token = "0x17000056")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x273D87C", Offset = "0x273987C", VA = "0x273D87C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x273D764", Offset = "0x2739764", VA = "0x273D764")]
		internal Block5(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x273D7B0", Offset = "0x27397B0", VA = "0x273D7B0", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x273D884", Offset = "0x2739884", VA = "0x273D884", Slot = "12")]
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x273D88C", Offset = "0x273988C", VA = "0x273D88C", Slot = "14")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000067")]
	internal class BlockN : BlockExpression
	{
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x10")]
		private IReadOnlyList<Expression> _expressions;

		[Token(Token = "0x17000057")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x273DA10", Offset = "0x2739A10", VA = "0x273DA10", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x273D944", Offset = "0x2739944", VA = "0x273D944")]
		internal BlockN(IReadOnlyList<Expression> expressions)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x273D968", Offset = "0x2739968", VA = "0x273D968", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x273DAB0", Offset = "0x2739AB0", VA = "0x273DAB0", Slot = "12")]
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x273DAF8", Offset = "0x2739AF8", VA = "0x273DAF8", Slot = "14")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000068")]
	internal class ScopeExpression : BlockExpression
	{
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		private IReadOnlyList<ParameterExpression> _variables;

		[Token(Token = "0x17000058")]
		protected IReadOnlyList<ParameterExpression> VariablesList
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x273DBBC", Offset = "0x2739BBC", VA = "0x273DBBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x273DB50", Offset = "0x2739B50", VA = "0x273DB50")]
		internal ScopeExpression(IReadOnlyList<ParameterExpression> variables)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x273DB74", Offset = "0x2739B74", VA = "0x273DB74", Slot = "13")]
		internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x273DBC4", Offset = "0x2739BC4", VA = "0x273DBC4")]
		internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables)
		{
			return null;
		}
	}
	[Token(Token = "0x2000069")]
	internal sealed class Scope1 : ScopeExpression
	{
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x18")]
		private object _body;

		[Token(Token = "0x17000059")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x273DD24", Offset = "0x2739D24", VA = "0x273DD24", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x273DC58", Offset = "0x2739C58", VA = "0x273DC58")]
		internal Scope1(IReadOnlyList<ParameterExpression> variables, Expression body)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x273DC80", Offset = "0x2739C80", VA = "0x273DC80")]
		private Scope1(IReadOnlyList<ParameterExpression> variables, object body)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x273DCA8", Offset = "0x2739CA8", VA = "0x273DCA8", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x273DD2C", Offset = "0x2739D2C", VA = "0x273DD2C", Slot = "12")]
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x273DD34", Offset = "0x2739D34", VA = "0x273DD34", Slot = "14")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x200006A")]
	internal class ScopeN : ScopeExpression
	{
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x18")]
		private IReadOnlyList<Expression> _body;

		[Token(Token = "0x1700005A")]
		protected IReadOnlyList<Expression> Body
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x273DE3C", Offset = "0x2739E3C", VA = "0x273DE3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x273DEEC", Offset = "0x2739EEC", VA = "0x273DEEC", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x273DE14", Offset = "0x2739E14", VA = "0x273DE14")]
		internal ScopeN(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x273DE44", Offset = "0x2739E44", VA = "0x273DE44", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x273DF8C", Offset = "0x2739F8C", VA = "0x273DF8C", Slot = "12")]
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x273DFD4", Offset = "0x2739FD4", VA = "0x273DFD4", Slot = "14")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	internal sealed class ScopeWithType : ScopeN
	{
		[Token(Token = "0x1700005C")]
		public sealed override Type Type
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x273E0D8", Offset = "0x273A0D8", VA = "0x273E0D8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x273E0A0", Offset = "0x273A0A0", VA = "0x273E0A0")]
		internal ScopeWithType(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> expressions, Type type)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x273E0E0", Offset = "0x273A0E0", VA = "0x273E0E0", Slot = "14")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable
	{
		[Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__18 : IEnumerator<Expression>, IDisposable, IEnumerator
		{
			[Token(Token = "0x40000E1")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E2")]
			[FieldOffset(Offset = "0x18")]
			private Expression <>2__current;

			[Token(Token = "0x40000E3")]
			[FieldOffset(Offset = "0x20")]
			public BlockExpressionList <>4__this;

			[Token(Token = "0x40000E4")]
			[FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x17000060")]
			private Expression System.Collections.Generic.IEnumerator<System.Linq.Expressions.Expression>.Current
			{
				[Token(Token = "0x60002BA")]
				[Address(RVA = "0x273E6A0", Offset = "0x273A6A0", VA = "0x273E6A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002BC")]
				[Address(RVA = "0x273E6E0", Offset = "0x273A6E0", VA = "0x273E6E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x273E5AC", Offset = "0x273A5AC", VA = "0x273E5AC")]
			[DebuggerHidden]
			public <GetEnumerator>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x273E5D8", Offset = "0x273A5D8", VA = "0x273E5D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x273E5DC", Offset = "0x273A5DC", VA = "0x273E5DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x273E6A8", Offset = "0x273A6A8", VA = "0x273E6A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x10")]
		private readonly BlockExpression _block;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x18")]
		private readonly Expression _arg0;

		[Token(Token = "0x1700005D")]
		public Expression this[int index]
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x273E2A0", Offset = "0x273A2A0", VA = "0x273E2A0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x273E2C8", Offset = "0x273A2C8", VA = "0x273E2C8", Slot = "5")]
			[ExcludeFromCodeCoverage]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public int Count
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x273E4E0", Offset = "0x273A4E0", VA = "0x273E4E0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005F")]
		[ExcludeFromCodeCoverage]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x273E4FC", Offset = "0x273A4FC", VA = "0x273E4FC", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x273D25C", Offset = "0x273925C", VA = "0x273D25C")]
		internal BlockExpressionList(BlockExpression provider, Expression arg0)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x273E1C8", Offset = "0x273A1C8", VA = "0x273E1C8", Slot = "6")]
		public int IndexOf(Expression item)
		{
			return default(int);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x273E250", Offset = "0x273A250", VA = "0x273E250", Slot = "7")]
		[ExcludeFromCodeCoverage]
		public void Insert(int index, Expression item)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x273E278", Offset = "0x273A278", VA = "0x273E278", Slot = "8")]
		[ExcludeFromCodeCoverage]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x273E2F0", Offset = "0x273A2F0", VA = "0x273E2F0", Slot = "11")]
		[ExcludeFromCodeCoverage]
		public void Add(Expression item)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x273E318", Offset = "0x273A318", VA = "0x273E318", Slot = "12")]
		[ExcludeFromCodeCoverage]
		public void Clear()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x273E340", Offset = "0x273A340", VA = "0x273E340", Slot = "13")]
		public bool Contains(Expression item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x273E358", Offset = "0x273A358", VA = "0x273E358", Slot = "14")]
		public void CopyTo(Expression[] array, int index)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x273E524", Offset = "0x273A524", VA = "0x273E524", Slot = "15")]
		[ExcludeFromCodeCoverage]
		public bool Remove(Expression item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x273E54C", Offset = "0x273A54C", VA = "0x273E54C", Slot = "16")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__18))]
		public IEnumerator<Expression> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x273E5D4", Offset = "0x273A5D4", VA = "0x273E5D4", Slot = "17")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200006E")]
	[DebuggerTypeProxy(typeof(Expression.CatchBlockProxy))]
	public sealed class CatchBlock
	{
		[Token(Token = "0x17000062")]
		public ParameterExpression Variable
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x273E728", Offset = "0x273A728", VA = "0x273E728")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public Type Test
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x273E730", Offset = "0x273A730", VA = "0x273E730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public Expression Body
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x273E738", Offset = "0x273A738", VA = "0x273E738")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public Expression Filter
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x273E740", Offset = "0x273A740", VA = "0x273E740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x273E6E8", Offset = "0x273A6E8", VA = "0x273E6E8")]
		internal CatchBlock(Type test, ParameterExpression variable, Expression body, Expression filter)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x273E748", Offset = "0x273A748", VA = "0x273E748", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x273E7C8", Offset = "0x273A7C8", VA = "0x273E7C8")]
		public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body)
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	internal static class ArrayBuilderExtensions
	{
		[Token(Token = "0x60002C4")]
		public static ReadOnlyCollection<T> ToReadOnly<T>(this System.Collections.Generic.ArrayBuilder<T> builder)
		{
			return null;
		}
	}
	[Token(Token = "0x2000070")]
	internal enum AnalyzeTypeIsResult
	{
		[Token(Token = "0x40000EA")]
		KnownFalse,
		[Token(Token = "0x40000EB")]
		KnownTrue,
		[Token(Token = "0x40000EC")]
		KnownAssignable,
		[Token(Token = "0x40000ED")]
		Unknown
	}
	[Token(Token = "0x2000071")]
	internal static class ConstantCheck
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x273E87C", Offset = "0x273A87C", VA = "0x273E87C")]
		internal static AnalyzeTypeIsResult AnalyzeTypeIs(TypeBinaryExpression typeIs)
		{
			return default(AnalyzeTypeIsResult);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x273E894", Offset = "0x273A894", VA = "0x273E894")]
		private static AnalyzeTypeIsResult AnalyzeTypeIs(Expression operand, Type testType)
		{
			return default(AnalyzeTypeIsResult);
		}
	}
	[Token(Token = "0x2000072")]
	[DebuggerTypeProxy(typeof(ConditionalExpressionProxy))]
	public class ConditionalExpression : Expression
	{
		[Token(Token = "0x17000066")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x273ED20", Offset = "0x273AD20", VA = "0x273ED20", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x17000067")]
		public override Type Type
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x273ED28", Offset = "0x273AD28", VA = "0x273ED28", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public Expression Test
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x273ED44", Offset = "0x273AD44", VA = "0x273ED44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public Expression IfTrue
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x273ED4C", Offset = "0x273AD4C", VA = "0x273ED4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public Expression IfFalse
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x273ED54", Offset = "0x273AD54", VA = "0x273ED54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x273EA6C", Offset = "0x273AA6C", VA = "0x273EA6C")]
		internal ConditionalExpression(Expression test, Expression ifTrue)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x273EADC", Offset = "0x273AADC", VA = "0x273EADC")]
		internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type)
		{
			return null;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x273ED60", Offset = "0x273AD60", VA = "0x273ED60", Slot = "10")]
		internal virtual Expression GetFalse()
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x273EDB8", Offset = "0x273ADB8", VA = "0x273EDB8", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x273EDDC", Offset = "0x273ADDC", VA = "0x273EDDC")]
		public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse)
		{
			return null;
		}
	}
	[Token(Token = "0x2000073")]
	internal class FullConditionalExpression : ConditionalExpression
	{
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _false;

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x273ECFC", Offset = "0x273ACFC", VA = "0x273ECFC")]
		internal FullConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x273EEB0", Offset = "0x273AEB0", VA = "0x273EEB0", Slot = "10")]
		internal override Expression GetFalse()
		{
			return null;
		}
	}
	[Token(Token = "0x2000074")]
	internal sealed class FullConditionalExpressionWithType : FullConditionalExpression
	{
		[Token(Token = "0x1700006B")]
		public sealed override Type Type
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x273EEB8", Offset = "0x273AEB8", VA = "0x273EEB8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x273ECD4", Offset = "0x273ACD4", VA = "0x273ECD4")]
		internal FullConditionalExpressionWithType(Expression test, Expression ifTrue, Expression ifFalse, Type type)
		{
		}
	}
	[Token(Token = "0x2000075")]
	[DebuggerTypeProxy(typeof(ConstantExpressionProxy))]
	public class ConstantExpression : Expression
	{
		[Token(Token = "0x1700006C")]
		public override Type Type
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x273EF2C", Offset = "0x273AF2C", VA = "0x273EF2C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x273EFB4", Offset = "0x273AFB4", VA = "0x273EFB4", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x1700006E")]
		public object Value
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x273EFBC", Offset = "0x273AFBC", VA = "0x273EFBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x273EEC0", Offset = "0x273AEC0", VA = "0x273EEC0")]
		internal ConstantExpression(object value)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x273EFC4", Offset = "0x273AFC4", VA = "0x273EFC4", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
	[Token(Token = "0x2000076")]
	internal class TypedConstantExpression : ConstantExpression
	{
		[Token(Token = "0x1700006F")]
		public sealed override Type Type
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x273F00C", Offset = "0x273B00C", VA = "0x273F00C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x273EFE8", Offset = "0x273AFE8", VA = "0x273EFE8")]
		internal TypedConstantExpression(object value, Type type)
		{
		}
	}
	[Token(Token = "0x2000077")]
	[DebuggerTypeProxy(typeof(DebugInfoExpressionProxy))]
	public class DebugInfoExpression : Expression
	{
		[Token(Token = "0x17000070")]
		[ExcludeFromCodeCoverage]
		public virtual int StartLine
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x273F014", Offset = "0x273B014", VA = "0x273F014", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		[ExcludeFromCodeCoverage]
		public virtual int EndLine
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x273F03C", Offset = "0x273B03C", VA = "0x273F03C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public SymbolDocumentInfo Document
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x273F064", Offset = "0x273B064", VA = "0x273F064")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		[ExcludeFromCodeCoverage]
		public virtual bool IsClear
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x273F06C", Offset = "0x273B06C", VA = "0x273F06C", Slot = "12")]
			get
			{
				return default(bool);
			}
		}
	}
	[Token(Token = "0x2000078")]
	[DebuggerTypeProxy(typeof(DefaultExpressionProxy))]
	public sealed class DefaultExpression : Expression
	{
		[Token(Token = "0x17000074")]
		public sealed override Type Type
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x273F100", Offset = "0x273B100", VA = "0x273F100", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x273F108", Offset = "0x273B108", VA = "0x273F108", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x273F094", Offset = "0x273B094", VA = "0x273F094")]
		internal DefaultExpression(Type type)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x273F110", Offset = "0x273B110", VA = "0x273F110", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
	[Token(Token = "0x2000079")]
	public sealed class ElementInit : IArgumentProvider
	{
		[Token(Token = "0x17000076")]
		public MethodInfo AddMethod
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x273F134", Offset = "0x273B134", VA = "0x273F134")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public ReadOnlyCollection<Expression> Arguments
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x273F13C", Offset = "0x273B13C", VA = "0x273F13C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public int ArgumentCount
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x273F19C", Offset = "0x273B19C", VA = "0x273F19C", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x273F144", Offset = "0x273B144", VA = "0x273F144", Slot = "4")]
		public Expression GetArgument(int index)
		{
			return null;
		}
	}
	[Token(Token = "0x200007A")]
	internal static class Error
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x273F1EC", Offset = "0x273B1EC", VA = "0x273F1EC")]
		internal static Exception ReducibleMustOverrideReduce()
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x273F2B0", Offset = "0x273B2B0", VA = "0x273F2B0")]
		internal static Exception InvalidMetaObjectCreated(object p0)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x273F368", Offset = "0x273B368", VA = "0x273F368")]
		internal static Exception AmbiguousMatchInExpandoObject(object p0)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x273F420", Offset = "0x273B420", VA = "0x273F420")]
		internal static Exception SameKeyExistsInExpando(object key)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x273F4F8", Offset = "0x273B4F8", VA = "0x273F4F8")]
		internal static Exception KeyDoesNotExistInExpando(object p0)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x273F5B0", Offset = "0x273B5B0", VA = "0x273F5B0")]
		internal static Exception CollectionModifiedWhileEnumerating()
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x273F674", Offset = "0x273B674", VA = "0x273F674")]
		internal static Exception CollectionReadOnly()
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x273F738", Offset = "0x273B738", VA = "0x273F738")]
		internal static Exception MustReduceToDifferent()
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x273F7FC", Offset = "0x273B7FC", VA = "0x273F7FC")]
		internal static Exception BinderNotCompatibleWithCallSite(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x273F8E4", Offset = "0x273B8E4", VA = "0x273F8E4")]
		internal static Exception DynamicBindingNeedsRestrictions(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x273F9BC", Offset = "0x273B9BC", VA = "0x273F9BC")]
		internal static Exception DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x273FB90", Offset = "0x273BB90", VA = "0x273FB90")]
		internal static Exception DynamicBinderResultNotAssignable(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x273FC78", Offset = "0x273BC78", VA = "0x273FC78")]
		internal static Exception BindingCannotBeNull()
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x273FD3C", Offset = "0x273BD3C", VA = "0x273FD3C")]
		internal static Exception ReducedNotCompatible()
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x273FE00", Offset = "0x273BE00", VA = "0x273FE00")]
		internal static Exception SetterHasNoParams(string paramName)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x273FED4", Offset = "0x273BED4", VA = "0x273FED4")]
		internal static Exception PropertyCannotHaveRefType(string paramName)
		{
			return null;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x273FFA8", Offset = "0x273BFA8", VA = "0x273FFA8")]
		internal static Exception IndexesOfSetGetMustMatch(string paramName)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x274007C", Offset = "0x273C07C", VA = "0x274007C")]
		internal static Exception TypeParameterIsNotDelegate(object p0)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2740134", Offset = "0x273C134", VA = "0x2740134")]
		internal static Exception FirstArgumentMustBeCallSite()
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x27401F8", Offset = "0x273C1F8", VA = "0x27401F8")]
		internal static Exception AccessorsCannotHaveVarArgs(string paramName)
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x27402CC", Offset = "0x273C2CC", VA = "0x27402CC")]
		private static Exception AccessorsCannotHaveByRefArgs(string paramName)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x27403A0", Offset = "0x273C3A0", VA = "0x27403A0")]
		internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2740444", Offset = "0x273C444", VA = "0x2740444")]
		internal static Exception TypeMustBeDerivedFromSystemDelegate()
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2740508", Offset = "0x273C508", VA = "0x2740508")]
		internal static Exception NoOrInvalidRuleProduced()
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x27405CC", Offset = "0x273C5CC", VA = "0x27405CC")]
		internal static Exception BoundsCannotBeLessThanOne(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x27406A0", Offset = "0x273C6A0", VA = "0x27406A0")]
		internal static Exception TypeMustNotBeByRef(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2740774", Offset = "0x273C774", VA = "0x2740774")]
		internal static Exception TypeMustNotBePointer(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2740848", Offset = "0x273C848", VA = "0x2740848")]
		internal static Exception SetterMustBeVoid(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x274091C", Offset = "0x273C91C", VA = "0x274091C")]
		internal static Exception PropertyTypeMustMatchGetter(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x27409F0", Offset = "0x273C9F0", VA = "0x27409F0")]
		internal static Exception PropertyTypeMustMatchSetter(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2740AC4", Offset = "0x273CAC4", VA = "0x2740AC4")]
		internal static Exception BothAccessorsMustBeStatic(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2740B98", Offset = "0x273CB98", VA = "0x2740B98")]
		internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2740C6C", Offset = "0x273CC6C", VA = "0x2740C6C")]
		internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2740D40", Offset = "0x273CD40", VA = "0x2740D40")]
		internal static Exception OnlyStaticMethodsHaveNullInstance()
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2740E04", Offset = "0x273CE04", VA = "0x2740E04")]
		internal static Exception PropertyTypeCannotBeVoid(string paramName)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2740ED8", Offset = "0x273CED8", VA = "0x2740ED8")]
		internal static Exception InvalidUnboxType(string paramName)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2740FAC", Offset = "0x273CFAC", VA = "0x2740FAC")]
		internal static Exception ExpressionMustBeWriteable(string paramName)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2741080", Offset = "0x273D080", VA = "0x2741080")]
		internal static Exception ArgumentMustNotHaveValueType(string paramName)
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2741154", Offset = "0x273D154", VA = "0x2741154")]
		internal static Exception MustBeReducible()
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x2741218", Offset = "0x273D218", VA = "0x2741218")]
		internal static Exception LabelMustBeVoidOrHaveExpression(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x27412EC", Offset = "0x273D2EC", VA = "0x27412EC")]
		internal static Exception LabelTypeMustBeVoid(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x27413C0", Offset = "0x273D3C0", VA = "0x27413C0")]
		internal static Exception QuotedExpressionMustBeLambda(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2741494", Offset = "0x273D494", VA = "0x2741494")]
		internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x2741574", Offset = "0x273D574", VA = "0x2741574")]
		internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x27415A8", Offset = "0x273D5A8", VA = "0x27415A8")]
		private static Exception DuplicateVariable(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x2741670", Offset = "0x273D670", VA = "0x2741670")]
		internal static Exception DuplicateVariable(object p0, string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x2741694", Offset = "0x273D694", VA = "0x2741694")]
		internal static Exception FaultCannotHaveCatchOrFinally(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2741768", Offset = "0x273D768", VA = "0x2741768")]
		internal static Exception TryMustHaveCatchFinallyOrFault()
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x274182C", Offset = "0x273D82C", VA = "0x274182C")]
		internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry()
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x27418F0", Offset = "0x273D8F0", VA = "0x27418F0")]
		internal static Exception ExtensionNodeMustOverrideProperty(object p0)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x27419A8", Offset = "0x273D9A8", VA = "0x27419A8")]
		internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2741A70", Offset = "0x273DA70", VA = "0x2741A70")]
		internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2741B38", Offset = "0x273DB38", VA = "0x2741B38")]
		internal static Exception CoercionOperatorNotDefined(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2741C10", Offset = "0x273DC10", VA = "0x2741C10")]
		internal static Exception UnaryOperatorNotDefined(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2741CE8", Offset = "0x273DCE8", VA = "0x2741CE8")]
		internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2741DD0", Offset = "0x273DDD0", VA = "0x2741DD0")]
		internal static Exception ReferenceEqualityNotDefined(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2741EA8", Offset = "0x273DEA8", VA = "0x2741EA8")]
		internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2741F80", Offset = "0x273DF80", VA = "0x2741F80")]
		internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2742058", Offset = "0x273E058", VA = "0x2742058")]
		internal static Exception ConversionIsNotSupportedForArithmeticTypes()
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x274211C", Offset = "0x273E11C", VA = "0x274211C")]
		internal static Exception ArgumentMustBeArray(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x27421F0", Offset = "0x273E1F0", VA = "0x27421F0")]
		internal static Exception ArgumentMustBeBoolean(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x27422C4", Offset = "0x273E2C4", VA = "0x27422C4")]
		private static Exception ArgumentMustBeInteger(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2742398", Offset = "0x273E398", VA = "0x2742398")]
		internal static Exception ArgumentMustBeInteger(string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x27423A8", Offset = "0x273E3A8", VA = "0x27423A8")]
		internal static Exception ArgumentMustBeArrayIndexType(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x274247C", Offset = "0x273E47C", VA = "0x274247C")]
		internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2742550", Offset = "0x273E550", VA = "0x2742550")]
		internal static Exception ArgumentTypesMustMatch()
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x2742614", Offset = "0x273E614", VA = "0x2742614")]
		internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0)
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x27426CC", Offset = "0x273E6CC", VA = "0x27426CC")]
		internal static Exception IncorrectTypeForTypeAs(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2742794", Offset = "0x273E794", VA = "0x2742794")]
		internal static Exception CoalesceUsedOnNonNullType()
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2742858", Offset = "0x273E858", VA = "0x2742858")]
		internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2742930", Offset = "0x273E930", VA = "0x2742930")]
		internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2742A08", Offset = "0x273EA08", VA = "0x2742A08")]
		internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2742AE0", Offset = "0x273EAE0", VA = "0x2742AE0")]
		internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x2742BB8", Offset = "0x273EBB8", VA = "0x2742BB8")]
		internal static Exception ExpressionTypeNotInvocable(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x2742C80", Offset = "0x273EC80", VA = "0x2742C80")]
		internal static Exception InstanceFieldNotDefinedForType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x2742D58", Offset = "0x273ED58", VA = "0x2742D58")]
		internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x2742E40", Offset = "0x273EE40", VA = "0x2742E40")]
		internal static Exception IncorrectNumberOfIndexes()
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x2742F04", Offset = "0x273EF04", VA = "0x2742F04")]
		internal static Exception IncorrectNumberOfLambdaDeclarationParameters()
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2742FC8", Offset = "0x273EFC8", VA = "0x2742FC8")]
		internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x274309C", Offset = "0x273F09C", VA = "0x274309C")]
		internal static Exception MemberNotFieldOrProperty(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2743164", Offset = "0x273F164", VA = "0x2743164")]
		internal static Exception MethodContainsGenericParameters(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x274322C", Offset = "0x273F22C", VA = "0x274322C")]
		internal static Exception MethodIsGeneric(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x27432F4", Offset = "0x273F2F4", VA = "0x27432F4")]
		internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x27433BC", Offset = "0x273F3BC", VA = "0x27433BC")]
		internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2743494", Offset = "0x273F494", VA = "0x2743494")]
		internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x2743574", Offset = "0x273F574", VA = "0x2743574")]
		internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2743654", Offset = "0x273F654", VA = "0x2743654")]
		internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x274373C", Offset = "0x273F73C", VA = "0x274373C")]
		internal static Exception UnhandledBinary(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2743804", Offset = "0x273F804", VA = "0x2743804")]
		internal static Exception UnhandledUnary(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x27438CC", Offset = "0x273F8CC", VA = "0x27438CC")]
		internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x27439A4", Offset = "0x273F9A4", VA = "0x27439A4")]
		internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2743A7C", Offset = "0x273FA7C", VA = "0x2743A7C")]
		internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2743B54", Offset = "0x273FB54", VA = "0x2743B54")]
		internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x2743C2C", Offset = "0x273FC2C", VA = "0x2743C2C")]
		internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x2743D04", Offset = "0x273FD04", VA = "0x2743D04")]
		internal static Exception MethodWithMoreThanOneMatch(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2743DDC", Offset = "0x273FDDC", VA = "0x2743DDC")]
		internal static Exception ArgumentCannotBeOfTypeVoid(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x2743EB0", Offset = "0x273FEB0", VA = "0x2743EB0")]
		internal static Exception OutOfRange(string paramName, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2743F8C", Offset = "0x273FF8C", VA = "0x2743F8C")]
		internal static Exception LabelTargetAlreadyDefined(object p0)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x2744044", Offset = "0x2740044", VA = "0x2744044")]
		internal static Exception LabelTargetUndefined(object p0)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x27440FC", Offset = "0x27400FC", VA = "0x27440FC")]
		internal static Exception ControlCannotLeaveFinally()
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x27441C0", Offset = "0x27401C0", VA = "0x27441C0")]
		internal static Exception ControlCannotLeaveFilterTest()
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2744284", Offset = "0x2740284", VA = "0x2744284")]
		internal static Exception AmbiguousJump(object p0)
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x274433C", Offset = "0x274033C", VA = "0x274433C")]
		internal static Exception ControlCannotEnterTry()
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x2744400", Offset = "0x2740400", VA = "0x2744400")]
		internal static Exception ControlCannotEnterExpression()
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x27444C4", Offset = "0x27404C4", VA = "0x27444C4")]
		internal static Exception NonLocalJumpWithValue(object p0)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x274457C", Offset = "0x274057C", VA = "0x274457C")]
		internal static Exception InvalidLvalue(ExpressionType p0)
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x274465C", Offset = "0x274065C", VA = "0x274465C")]
		internal static Exception RethrowRequiresCatch()
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x2744720", Offset = "0x2740720", VA = "0x2744720")]
		internal static Exception MustRewriteToSameNode(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x2744808", Offset = "0x2740808", VA = "0x2744808")]
		internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x27448F0", Offset = "0x27408F0", VA = "0x27448F0")]
		internal static Exception MustRewriteWithoutMethod(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x273D344", Offset = "0x2739344", VA = "0x273D344")]
		internal static Exception ArgumentOutOfRange(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x27449C8", Offset = "0x27409C8", VA = "0x27449C8")]
		internal static Exception NotSupported()
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x2744A1C", Offset = "0x2740A1C", VA = "0x2744A1C")]
		internal static Exception NonAbstractConstructorRequired()
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x2744AE0", Offset = "0x2740AE0", VA = "0x2744AE0")]
		internal static Exception InvalidProgram()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2744B34", Offset = "0x2740B34", VA = "0x2744B34")]
		internal static Exception EnumerationIsDone()
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x2744BF8", Offset = "0x2740BF8", VA = "0x2744BF8")]
		private static Exception TypeContainsGenericParameters(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x2744CC0", Offset = "0x2740CC0", VA = "0x2744CC0")]
		internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2744CE4", Offset = "0x2740CE4", VA = "0x2744CE4")]
		internal static Exception TypeIsGeneric(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x2744DAC", Offset = "0x2740DAC", VA = "0x2744DAC")]
		internal static Exception TypeIsGeneric(object p0, string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2744DD0", Offset = "0x2740DD0", VA = "0x2744DD0")]
		internal static Exception IncorrectNumberOfConstructorArguments()
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x2744E94", Offset = "0x2740E94", VA = "0x2744E94")]
		internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2744F8C", Offset = "0x2740F8C", VA = "0x2744F8C")]
		internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x2744FC8", Offset = "0x2740FC8", VA = "0x2744FC8")]
		internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x27450A8", Offset = "0x27410A8", VA = "0x27450A8")]
		internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x27450DC", Offset = "0x27410DC", VA = "0x27450DC")]
		internal static Exception IncorrectNumberOfLambdaArguments()
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x27451A0", Offset = "0x27411A0", VA = "0x27451A0")]
		internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2745268", Offset = "0x2741268", VA = "0x2745268")]
		internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x2745348", Offset = "0x2741348", VA = "0x2745348")]
		internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x274537C", Offset = "0x274137C", VA = "0x274537C")]
		internal static Exception ExpressionMustBeReadable(string paramName)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x2745450", Offset = "0x2741450", VA = "0x2745450")]
		internal static Exception ExpressionMustBeReadable(string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x2745460", Offset = "0x2741460", VA = "0x2745460")]
		internal static Exception InvalidArgumentValue(string paramName)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2745534", Offset = "0x2741534", VA = "0x2745534")]
		internal static Exception InvalidNullValue(Type type, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x27455FC", Offset = "0x27415FC", VA = "0x27455FC")]
		internal static Exception InvalidTypeException(object value, Type type, string paramName)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x27403B0", Offset = "0x273C3B0", VA = "0x27403B0")]
		private static string GetParamName(string paramName, int index)
		{
			return null;
		}
	}
	[Token(Token = "0x200007B")]
	internal sealed class ExpressionStringBuilder : ExpressionVisitor
	{
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x10")]
		private readonly StringBuilder _out;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<object, int> _ids;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2745710", Offset = "0x2741710", VA = "0x2745710")]
		private ExpressionStringBuilder()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x274577C", Offset = "0x274177C", VA = "0x274577C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x2745798", Offset = "0x2741798", VA = "0x2745798")]
		private int GetLabelId(LabelTarget label)
		{
			return default(int);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x27458B0", Offset = "0x27418B0", VA = "0x27458B0")]
		private int GetParamId(ParameterExpression p)
		{
			return default(int);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x274579C", Offset = "0x274179C", VA = "0x274579C")]
		private int GetId(object o)
		{
			return default(int);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x27458B4", Offset = "0x27418B4", VA = "0x27458B4")]
		private void Out(string s)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x27458CC", Offset = "0x27418CC", VA = "0x27458CC")]
		private void Out(char c)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x27458E4", Offset = "0x27418E4", VA = "0x27458E4")]
		internal static string ExpressionToString(Expression node)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x273E74C", Offset = "0x273A74C", VA = "0x273E74C")]
		internal static string CatchBlockToString(CatchBlock node)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close) where T : Expression
		{
		}

		[Token(Token = "0x6000378")]
		private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator) where T : Expression
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x274595C", Offset = "0x274195C", VA = "0x274595C", Slot = "5")]
		protected internal override Expression VisitBinary(BinaryExpression node)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x2745F80", Offset = "0x2741F80", VA = "0x2745F80", Slot = "21")]
		protected internal override Expression VisitParameter(ParameterExpression node)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		protected internal override Expression VisitLambda<T>(Expression<T> node)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x274608C", Offset = "0x274208C", VA = "0x274608C", Slot = "7")]
		protected internal override Expression VisitConditional(ConditionalExpression node)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x274618C", Offset = "0x274218C", VA = "0x274618C", Slot = "8")]
		protected internal override Expression VisitConstant(ConstantExpression node)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2746300", Offset = "0x2742300", VA = "0x2746300")]
		private void OutMember(Expression instance, MemberInfo member)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x27463B0", Offset = "0x27423B0", VA = "0x27463B0", Slot = "17")]
		protected internal override Expression VisitMember(MemberExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x2746408", Offset = "0x2742408", VA = "0x2746408", Slot = "12")]
		protected internal override Expression VisitInvocation(InvocationExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2746520", Offset = "0x2742520", VA = "0x2746520", Slot = "19")]
		protected internal override Expression VisitMethodCall(MethodCallExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2746728", Offset = "0x2742728", VA = "0x2746728", Slot = "20")]
		protected internal override Expression VisitNewArray(NewArrayExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2746854", Offset = "0x2742854", VA = "0x2746854", Slot = "24")]
		protected internal override Expression VisitTypeBinary(TypeBinaryExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x2746960", Offset = "0x2742960", VA = "0x2746960", Slot = "25")]
		protected internal override Expression VisitUnary(UnaryExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x2746DC0", Offset = "0x2742DC0", VA = "0x2746DC0", Slot = "6")]
		protected internal override Expression VisitBlock(BlockExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x27470D0", Offset = "0x27430D0", VA = "0x27470D0", Slot = "9")]
		protected internal override Expression VisitDefault(DefaultExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2747180", Offset = "0x2743180", VA = "0x2747180", Slot = "14")]
		protected internal override Expression VisitLabel(LabelExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x27472D0", Offset = "0x27432D0", VA = "0x27472D0", Slot = "11")]
		protected internal override Expression VisitGoto(GotoExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2747428", Offset = "0x2743428", VA = "0x2747428", Slot = "16")]
		protected internal override Expression VisitLoop(LoopExpression node)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x2747488", Offset = "0x2743488", VA = "0x2747488", Slot = "22")]
		protected override CatchBlock VisitCatchBlock(CatchBlock node)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2747590", Offset = "0x2743590", VA = "0x2747590", Slot = "23")]
		protected internal override Expression VisitTry(TryExpression node)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x27475F0", Offset = "0x27435F0", VA = "0x27475F0", Slot = "18")]
		protected internal override Expression VisitIndex(IndexExpression node)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x27478C0", Offset = "0x27438C0", VA = "0x27478C0", Slot = "10")]
		protected internal override Expression VisitExtension(Expression node)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2747204", Offset = "0x2743204", VA = "0x2747204")]
		private void DumpLabel(LabelTarget target)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x2745E64", Offset = "0x2741E64", VA = "0x2745E64")]
		private static bool IsBool(Expression node)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007C")]
	public enum ExpressionType
	{
		[Token(Token = "0x40000FB")]
		Add,
		[Token(Token = "0x40000FC")]
		AddChecked,
		[Token(Token = "0x40000FD")]
		And,
		[Token(Token = "0x40000FE")]
		AndAlso,
		[Token(Token = "0x40000FF")]
		ArrayLength,
		[Token(Token = "0x4000100")]
		ArrayIndex,
		[Token(Token = "0x4000101")]
		Call,
		[Token(Token = "0x4000102")]
		Coalesce,
		[Token(Token = "0x4000103")]
		Conditional,
		[Token(Token = "0x4000104")]
		Constant,
		[Token(Token = "0x4000105")]
		Convert,
		[Token(Token = "0x4000106")]
		ConvertChecked,
		[Token(Token = "0x4000107")]
		Divide,
		[Token(Token = "0x4000108")]
		Equal,
		[Token(Token = "0x4000109")]
		ExclusiveOr,
		[Token(Token = "0x400010A")]
		GreaterThan,
		[Token(Token = "0x400010B")]
		GreaterThanOrEqual,
		[Token(Token = "0x400010C")]
		Invoke,
		[Token(Token = "0x400010D")]
		Lambda,
		[Token(Token = "0x400010E")]
		LeftShift,
		[Token(Token = "0x400010F")]
		LessThan,
		[Token(Token = "0x4000110")]
		LessThanOrEqual,
		[Token(Token = "0x4000111")]
		ListInit,
		[Token(Token = "0x4000112")]
		MemberAccess,
		[Token(Token = "0x4000113")]
		MemberInit,
		[Token(Token = "0x4000114")]
		Modulo,
		[Token(Token = "0x4000115")]
		Multiply,
		[Token(Token = "0x4000116")]
		MultiplyChecked,
		[Token(Token = "0x4000117")]
		Negate,
		[Token(Token = "0x4000118")]
		UnaryPlus,
		[Token(Token = "0x4000119")]
		NegateChecked,
		[Token(Token = "0x400011A")]
		New,
		[Token(Token = "0x400011B")]
		NewArrayInit,
		[Token(Token = "0x400011C")]
		NewArrayBounds,
		[Token(Token = "0x400011D")]
		Not,
		[Token(Token = "0x400011E")]
		NotEqual,
		[Token(Token = "0x400011F")]
		Or,
		[Token(Token = "0x4000120")]
		OrElse,
		[Token(Token = "0x4000121")]
		Parameter,
		[Token(Token = "0x4000122")]
		Power,
		[Token(Token = "0x4000123")]
		Quote,
		[Token(Token = "0x4000124")]
		RightShift,
		[Token(Token = "0x4000125")]
		Subtract,
		[Token(Token = "0x4000126")]
		SubtractChecked,
		[Token(Token = "0x4000127")]
		TypeAs,
		[Token(Token = "0x4000128")]
		TypeIs,
		[Token(Token = "0x4000129")]
		Assign,
		[Token(Token = "0x400012A")]
		Block,
		[Token(Token = "0x400012B")]
		DebugInfo,
		[Token(Token = "0x400012C")]
		Decrement,
		[Token(Token = "0x400012D")]
		Dynamic,
		[Token(Token = "0x400012E")]
		Default,
		[Token(Token = "0x400012F")]
		Extension,
		[Token(Token = "0x4000130")]
		Goto,
		[Token(Token = "0x4000131")]
		Increment,
		[Token(Token = "0x4000132")]
		Index,
		[Token(Token = "0x4000133")]
		Label,
		[Token(Token = "0x4000134")]
		RuntimeVariables,
		[Token(Token = "0x4000135")]
		Loop,
		[Token(Token = "0x4000136")]
		Switch,
		[Token(Token = "0x4000137")]
		Throw,
		[Token(Token = "0x4000138")]
		Try,
		[Token(Token = "0x4000139")]
		Unbox,
		[Token(Token = "0x400013A")]
		AddAssign,
		[Token(Token = "0x400013B")]
		AndAssign,
		[Token(Token = "0x400013C")]
		DivideAssign,
		[Token(Token = "0x400013D")]
		ExclusiveOrAssign,
		[Token(Token = "0x400013E")]
		LeftShiftAssign,
		[Token(Token = "0x400013F")]
		ModuloAssign,
		[Token(Token = "0x4000140")]
		MultiplyAssign,
		[Token(Token = "0x4000141")]
		OrAssign,
		[Token(Token = "0x4000142")]
		PowerAssign,
		[Token(Token = "0x4000143")]
		RightShiftAssign,
		[Token(Token = "0x4000144")]
		SubtractAssign,
		[Token(Token = "0x4000145")]
		AddAssignChecked,
		[Token(Token = "0x4000146")]
		MultiplyAssignChecked,
		[Token(Token = "0x4000147")]
		SubtractAssignChecked,
		[Token(Token = "0x4000148")]
		PreIncrementAssign,
		[Token(Token = "0x4000149")]
		PreDecrementAssign,
		[Token(Token = "0x400014A")]
		PostIncrementAssign,
		[Token(Token = "0x400014B")]
		PostDecrementAssign,
		[Token(Token = "0x400014C")]
		TypeEqual,
		[Token(Token = "0x400014D")]
		OnesComplement,
		[Token(Token = "0x400014E")]
		IsTrue,
		[Token(Token = "0x400014F")]
		IsFalse
	}
	[Token(Token = "0x200007D")]
	public abstract class ExpressionVisitor
	{
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2745774", Offset = "0x2741774", VA = "0x2745774")]
		protected ExpressionVisitor()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2747ABC", Offset = "0x2743ABC", VA = "0x2747ABC", Slot = "4")]
		public virtual Expression Visit(Expression node)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2747AE0", Offset = "0x2743AE0", VA = "0x2747AE0")]
		public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2747D0C", Offset = "0x2743D0C", VA = "0x2747D0C")]
		private Expression[] VisitArguments(IArgumentProvider nodes)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2747D14", Offset = "0x2743D14", VA = "0x2747D14")]
		private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		public T VisitAndConvert<T>(T node, string callerName) where T : Expression
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x2747D1C", Offset = "0x2743D1C", VA = "0x2747D1C", Slot = "5")]
		protected internal virtual Expression VisitBinary(BinaryExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2747F5C", Offset = "0x2743F5C", VA = "0x2747F5C", Slot = "6")]
		protected internal virtual Expression VisitBlock(BlockExpression node)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2748050", Offset = "0x2744050", VA = "0x2748050", Slot = "7")]
		protected internal virtual Expression VisitConditional(ConditionalExpression node)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x27480DC", Offset = "0x27440DC", VA = "0x27480DC", Slot = "8")]
		protected internal virtual Expression VisitConstant(ConstantExpression node)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x27480E4", Offset = "0x27440E4", VA = "0x27480E4", Slot = "9")]
		protected internal virtual Expression VisitDefault(DefaultExpression node)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x27480EC", Offset = "0x27440EC", VA = "0x27480EC", Slot = "10")]
		protected internal virtual Expression VisitExtension(Expression node)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x2748110", Offset = "0x2744110", VA = "0x2748110", Slot = "11")]
		protected internal virtual Expression VisitGoto(GotoExpression node)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2748228", Offset = "0x2744228", VA = "0x2748228", Slot = "12")]
		protected internal virtual Expression VisitInvocation(InvocationExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x27482A8", Offset = "0x27442A8", VA = "0x27482A8", Slot = "13")]
		protected virtual LabelTarget VisitLabelTarget(LabelTarget node)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x27482B0", Offset = "0x27442B0", VA = "0x27482B0", Slot = "14")]
		protected internal virtual Expression VisitLabel(LabelExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		protected internal virtual Expression VisitLambda<T>(Expression<T> node)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x27483A4", Offset = "0x27443A4", VA = "0x27483A4", Slot = "16")]
		protected internal virtual Expression VisitLoop(LoopExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x27484D4", Offset = "0x27444D4", VA = "0x27484D4", Slot = "17")]
		protected internal virtual Expression VisitMember(MemberExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2748598", Offset = "0x2744598", VA = "0x2748598", Slot = "18")]
		protected internal virtual Expression VisitIndex(IndexExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2748688", Offset = "0x2744688", VA = "0x2748688", Slot = "19")]
		protected internal virtual Expression VisitMethodCall(MethodCallExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x274872C", Offset = "0x274472C", VA = "0x274872C", Slot = "20")]
		protected internal virtual Expression VisitNewArray(NewArrayExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x27488BC", Offset = "0x27448BC", VA = "0x27488BC", Slot = "21")]
		protected internal virtual Expression VisitParameter(ParameterExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x27488C4", Offset = "0x27448C4", VA = "0x27488C4", Slot = "22")]
		protected virtual CatchBlock VisitCatchBlock(CatchBlock node)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2748980", Offset = "0x2744980", VA = "0x2748980", Slot = "23")]
		protected internal virtual Expression VisitTry(TryExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2748B80", Offset = "0x2744B80", VA = "0x2748B80", Slot = "24")]
		protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2748C6C", Offset = "0x2744C6C", VA = "0x2748C6C", Slot = "25")]
		protected internal virtual Expression VisitUnary(UnaryExpression node)
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2748D68", Offset = "0x2744D68", VA = "0x2748D68")]
		private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2747DF4", Offset = "0x2743DF4", VA = "0x2747DF4")]
		private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after)
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2748E74", Offset = "0x2744E74", VA = "0x2748E74")]
		private static void ValidateChildType(Type before, Type after, string methodName)
		{
		}
	}
	[Token(Token = "0x200007E")]
	public enum GotoExpressionKind
	{
		[Token(Token = "0x4000151")]
		Goto,
		[Token(Token = "0x4000152")]
		Return,
		[Token(Token = "0x4000153")]
		Break,
		[Token(Token = "0x4000154")]
		Continue
	}
	[Token(Token = "0x200007F")]
	[DebuggerTypeProxy(typeof(GotoExpressionProxy))]
	public sealed class GotoExpression : Expression
	{
		[Token(Token = "0x17000079")]
		public sealed override Type Type
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x2748FC8", Offset = "0x2744FC8", VA = "0x2748FC8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x2748FD0", Offset = "0x2744FD0", VA = "0x2748FD0", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x1700007B")]
		public Expression Value
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x2748FD8", Offset = "0x2744FD8", VA = "0x2748FD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public LabelTarget Target
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x2748FE0", Offset = "0x2744FE0", VA = "0x2748FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public GotoExpressionKind Kind
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x2748FE8", Offset = "0x2744FE8", VA = "0x2748FE8")]
			[CompilerGenerated]
			get
			{
				return default(GotoExpressionKind);
			}
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2748F40", Offset = "0x2744F40", VA = "0x2748F40")]
		internal GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2748FF0", Offset = "0x2744FF0", VA = "0x2748FF0", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x274816C", Offset = "0x274416C", VA = "0x274816C")]
		public GotoExpression Update(LabelTarget target, Expression value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000080")]
	public interface IArgumentProvider
	{
		[Token(Token = "0x1700007E")]
		int ArgumentCount
		{
			[Token(Token = "0x60003B9")]
			get;
		}

		[Token(Token = "0x60003B8")]
		Expression GetArgument(int index);
	}
	[Token(Token = "0x2000081")]
	internal interface IParameterProvider
	{
		[Token(Token = "0x1700007F")]
		int ParameterCount
		{
			[Token(Token = "0x60003BB")]
			get;
		}

		[Token(Token = "0x60003BA")]
		ParameterExpression GetParameter(int index);
	}
	[Token(Token = "0x2000082")]
	[DebuggerTypeProxy(typeof(IndexExpressionProxy))]
	public sealed class IndexExpression : Expression, IArgumentProvider
	{
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x10")]
		private IReadOnlyList<Expression> _arguments;

		[Token(Token = "0x17000080")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x27490A4", Offset = "0x27450A4", VA = "0x27490A4", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x17000081")]
		public sealed override Type Type
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x27490AC", Offset = "0x27450AC", VA = "0x27490AC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public Expression Object
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x2749110", Offset = "0x2745110", VA = "0x2749110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public PropertyInfo Indexer
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x2749118", Offset = "0x2745118", VA = "0x2749118")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public int ArgumentCount
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x2747778", Offset = "0x2743778", VA = "0x2747778", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2749014", Offset = "0x2745014", VA = "0x2749014")]
		internal IndexExpression(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2747818", Offset = "0x2743818", VA = "0x2747818", Slot = "10")]
		public Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2749120", Offset = "0x2745120", VA = "0x2749120", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x274860C", Offset = "0x274460C", VA = "0x274860C")]
		internal Expression Rewrite(Expression instance, Expression[] arguments)
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	[DebuggerTypeProxy(typeof(InvocationExpressionProxy))]
	public class InvocationExpression : Expression, IArgumentProvider
	{
		[Token(Token = "0x17000085")]
		public sealed override Type Type
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x27491B8", Offset = "0x27451B8", VA = "0x27491B8", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x27491C0", Offset = "0x27451C0", VA = "0x27491C0", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x17000087")]
		public Expression Expression
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x27491C8", Offset = "0x27451C8", VA = "0x27491C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		[ExcludeFromCodeCoverage]
		public virtual int ArgumentCount
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x27491F8", Offset = "0x27451F8", VA = "0x27491F8", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2749148", Offset = "0x2745148", VA = "0x2749148")]
		internal InvocationExpression(Expression expression, Type returnType)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x27491D0", Offset = "0x27451D0", VA = "0x27491D0", Slot = "12")]
		[ExcludeFromCodeCoverage]
		public virtual Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2749220", Offset = "0x2745220", VA = "0x2749220", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2749244", Offset = "0x2745244", VA = "0x2749244", Slot = "14")]
		[ExcludeFromCodeCoverage]
		internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	internal sealed class InvocationExpressionN : InvocationExpression
	{
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x20")]
		private IReadOnlyList<Expression> _arguments;

		[Token(Token = "0x17000089")]
		public override int ArgumentCount
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x274933C", Offset = "0x274533C", VA = "0x274933C", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x274926C", Offset = "0x274526C", VA = "0x274926C")]
		public InvocationExpressionN(Expression lambda, IReadOnlyList<Expression> arguments, Type returnType)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2749294", Offset = "0x2745294", VA = "0x2749294", Slot = "12")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x27493DC", Offset = "0x27453DC", VA = "0x27493DC", Slot = "14")]
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}
	}
	[Token(Token = "0x2000085")]
	internal sealed class InvocationExpression0 : InvocationExpression
	{
		[Token(Token = "0x1700008A")]
		public override int ArgumentCount
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x27494A0", Offset = "0x27454A0", VA = "0x27494A0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2749450", Offset = "0x2745450", VA = "0x2749450")]
		public InvocationExpression0(Expression lambda, Type returnType)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2749454", Offset = "0x2745454", VA = "0x2749454", Slot = "12")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x27494A8", Offset = "0x27454A8", VA = "0x27494A8", Slot = "14")]
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}
	}
	[Token(Token = "0x2000086")]
	internal sealed class InvocationExpression1 : InvocationExpression
	{
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x20")]
		private object _arg0;

		[Token(Token = "0x1700008B")]
		public override int ArgumentCount
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x27495BC", Offset = "0x27455BC", VA = "0x27495BC", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2749500", Offset = "0x2745500", VA = "0x2749500")]
		public InvocationExpression1(Expression lambda, Type returnType, Expression arg0)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2749524", Offset = "0x2745524", VA = "0x2749524", Slot = "12")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x27495C4", Offset = "0x27455C4", VA = "0x27495C4", Slot = "14")]
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}
	}
	[Token(Token = "0x2000087")]
	internal sealed class InvocationExpression2 : InvocationExpression
	{
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x20")]
		private object _arg0;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg1;

		[Token(Token = "0x1700008C")]
		public override int ArgumentCount
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x274974C", Offset = "0x274574C", VA = "0x274974C", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x2749674", Offset = "0x2745674", VA = "0x2749674")]
		public InvocationExpression2(Expression lambda, Type returnType, Expression arg0, Expression arg1)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x274969C", Offset = "0x274569C", VA = "0x274969C", Slot = "12")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x2749754", Offset = "0x2745754", VA = "0x2749754", Slot = "14")]
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}
	}
	[Token(Token = "0x2000088")]
	internal sealed class InvocationExpression3 : InvocationExpression
	{
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x20")]
		private object _arg0;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg1;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x30")]
		private readonly Expression _arg2;

		[Token(Token = "0x1700008D")]
		public override int ArgumentCount
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x2749914", Offset = "0x2745914", VA = "0x2749914", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x274981C", Offset = "0x274581C", VA = "0x274981C")]
		public InvocationExpression3(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2749854", Offset = "0x2745854", VA = "0x2749854", Slot = "12")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x274991C", Offset = "0x274591C", VA = "0x274991C", Slot = "14")]
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}
	}
	[Token(Token = "0x2000089")]
	internal sealed class InvocationExpression4 : InvocationExpression
	{
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x20")]
		private object _arg0;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg1;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x30")]
		private readonly Expression _arg2;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x38")]
		private readonly Expression _arg3;

		[Token(Token = "0x1700008E")]
		public override int ArgumentCount
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x2749B1C", Offset = "0x2745B1C", VA = "0x2749B1C", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2749A08", Offset = "0x2745A08", VA = "0x2749A08")]
		public InvocationExpression4(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2749A44", Offset = "0x2745A44", VA = "0x2749A44", Slot = "12")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2749B24", Offset = "0x2745B24", VA = "0x2749B24", Slot = "14")]
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	internal sealed class InvocationExpression5 : InvocationExpression
	{
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x20")]
		private object _arg0;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg1;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x30")]
		private readonly Expression _arg2;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x38")]
		private readonly Expression _arg3;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x40")]
		private readonly Expression _arg4;

		[Token(Token = "0x1700008F")]
		public override int ArgumentCount
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x2749D58", Offset = "0x2745D58", VA = "0x2749D58", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2749C24", Offset = "0x2745C24", VA = "0x2749C24")]
		public InvocationExpression5(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2749C70", Offset = "0x2745C70", VA = "0x2749C70", Slot = "12")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x2749D60", Offset = "0x2745D60", VA = "0x2749D60", Slot = "14")]
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	[DebuggerTypeProxy(typeof(LabelExpressionProxy))]
	public sealed class LabelExpression : Expression
	{
		[Token(Token = "0x17000090")]
		public sealed override Type Type
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x2749EEC", Offset = "0x2745EEC", VA = "0x2749EEC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x2749F04", Offset = "0x2745F04", VA = "0x2749F04", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x17000092")]
		public LabelTarget Target
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x2749F0C", Offset = "0x2745F0C", VA = "0x2749F0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public Expression DefaultValue
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x2749F14", Offset = "0x2745F14", VA = "0x2749F14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2749E7C", Offset = "0x2745E7C", VA = "0x2749E7C")]
		internal LabelExpression(LabelTarget label, Expression defaultValue)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2749F1C", Offset = "0x2745F1C", VA = "0x2749F1C", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x274830C", Offset = "0x274430C", VA = "0x274830C")]
		public LabelExpression Update(LabelTarget target, Expression defaultValue)
		{
			return null;
		}
	}
	[Token(Token = "0x200008C")]
	public sealed class LabelTarget
	{
		[Token(Token = "0x17000094")]
		public string Name
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x2749F70", Offset = "0x2745F70", VA = "0x2749F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public Type Type
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x2749F78", Offset = "0x2745F78", VA = "0x2749F78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2749F44", Offset = "0x2745F44", VA = "0x2749F44")]
		internal LabelTarget(Type type, string name)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2749F80", Offset = "0x2745F80", VA = "0x2749F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200008D")]
	[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
	public abstract class LambdaExpression : Expression, IParameterProvider
	{
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x10")]
		private readonly Expression _body;

		[Token(Token = "0x17000096")]
		public sealed override Type Type
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x274A044", Offset = "0x2746044", VA = "0x274A044", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		internal abstract Type TypeCore
		{
			[Token(Token = "0x60003F6")]
			get;
		}

		[Token(Token = "0x17000098")]
		internal abstract Type PublicType
		{
			[Token(Token = "0x60003F7")]
			get;
		}

		[Token(Token = "0x17000099")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x274A050", Offset = "0x2746050", VA = "0x274A050", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x1700009A")]
		public string Name
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x274A058", Offset = "0x2746058", VA = "0x274A058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		internal virtual string NameCore
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x274A068", Offset = "0x2746068", VA = "0x274A068", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public Expression Body
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x274A070", Offset = "0x2746070", VA = "0x274A070")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public Type ReturnType
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x274A078", Offset = "0x2746078", VA = "0x274A078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public bool TailCall
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x274A100", Offset = "0x2746100", VA = "0x274A100")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		internal virtual bool TailCallCore
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x274A110", Offset = "0x2746110", VA = "0x274A110", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A0")]
		[ExcludeFromCodeCoverage]
		private int System.Linq.Expressions.IParameterProvider.ParameterCount
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x274A150", Offset = "0x2746150", VA = "0x274A150", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A1")]
		[ExcludeFromCodeCoverage]
		internal virtual int ParameterCount
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x274A160", Offset = "0x2746160", VA = "0x274A160", Slot = "17")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2749FD8", Offset = "0x2745FD8", VA = "0x2749FD8")]
		internal LambdaExpression(Expression body)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x274A118", Offset = "0x2746118", VA = "0x274A118", Slot = "10")]
		[ExcludeFromCodeCoverage]
		private ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x274A128", Offset = "0x2746128", VA = "0x274A128", Slot = "16")]
		[ExcludeFromCodeCoverage]
		internal virtual ParameterExpression GetParameter(int index)
		{
			return null;
		}
	}
	[Token(Token = "0x200008E")]
	public class Expression<TDelegate> : LambdaExpression
	{
		[Token(Token = "0x170000A2")]
		internal sealed override Type TypeCore
		{
			[Token(Token = "0x6000404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		internal override Type PublicType
		{
			[Token(Token = "0x6000405")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000403")]
		internal Expression(Expression body)
		{
		}

		[Token(Token = "0x6000406")]
		public TDelegate Compile()
		{
			return (TDelegate)null;
		}

		[Token(Token = "0x6000407")]
		public TDelegate Compile(bool preferInterpretation)
		{
			return (TDelegate)null;
		}

		[Token(Token = "0x6000408")]
		[ExcludeFromCodeCoverage]
		internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
	[Token(Token = "0x200008F")]
	internal static class ExpressionCreator<TDelegate>
	{
		[Token(Token = "0x600040A")]
		public static LambdaExpression CreateExpressionFunc(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
		{
			return null;
		}
	}
	[Token(Token = "0x2000090")]
	internal sealed class Expression0<TDelegate> : Expression<TDelegate>
	{
		[Token(Token = "0x170000A4")]
		internal override int ParameterCount
		{
			[Token(Token = "0x600040C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600040B")]
		public Expression0(Expression body)
		{
		}

		[Token(Token = "0x600040D")]
		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}
	}
	[Token(Token = "0x2000091")]
	internal sealed class Expression1<TDelegate> : Expression<TDelegate>
	{
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x0")]
		private object _par0;

		[Token(Token = "0x170000A5")]
		internal override int ParameterCount
		{
			[Token(Token = "0x6000410")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600040F")]
		public Expression1(Expression body, ParameterExpression par0)
		{
		}

		[Token(Token = "0x6000411")]
		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}
	}
	[Token(Token = "0x2000092")]
	internal sealed class Expression2<TDelegate> : Expression<TDelegate>
	{
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x0")]
		private object _par0;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x0")]
		private readonly ParameterExpression _par1;

		[Token(Token = "0x170000A6")]
		internal override int ParameterCount
		{
			[Token(Token = "0x6000414")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000413")]
		public Expression2(Expression body, ParameterExpression par0, ParameterExpression par1)
		{
		}

		[Token(Token = "0x6000415")]
		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}
	}
	[Token(Token = "0x2000093")]
	internal sealed class Expression3<TDelegate> : Expression<TDelegate>
	{
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x0")]
		private object _par0;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x0")]
		private readonly ParameterExpression _par1;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x0")]
		private readonly ParameterExpression _par2;

		[Token(Token = "0x170000A7")]
		internal override int ParameterCount
		{
			[Token(Token = "0x6000418")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000417")]
		public Expression3(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2)
		{
		}

		[Token(Token = "0x6000419")]
		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}
	}
	[Token(Token = "0x2000094")]
	internal class ExpressionN<TDelegate> : Expression<TDelegate>
	{
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x0")]
		private IReadOnlyList<ParameterExpression> _parameters;

		[Token(Token = "0x170000A8")]
		internal override int ParameterCount
		{
			[Token(Token = "0x600041C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600041B")]
		public ExpressionN(Expression body, IReadOnlyList<ParameterExpression> parameters)
		{
		}

		[Token(Token = "0x600041D")]
		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}
	}
	[Token(Token = "0x2000095")]
	internal sealed class FullExpression<TDelegate> : ExpressionN<TDelegate>
	{
		[Token(Token = "0x170000A9")]
		internal override string NameCore
		{
			[Token(Token = "0x6000420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		internal override bool TailCallCore
		{
			[Token(Token = "0x6000421")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600041F")]
		public FullExpression(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters)
		{
		}
	}
	[Token(Token = "0x2000096")]
	[DebuggerTypeProxy(typeof(ListInitExpressionProxy))]
	public sealed class ListInitExpression : Expression
	{
		[Token(Token = "0x170000AB")]
		public NewExpression NewExpression
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x274A188", Offset = "0x2746188", VA = "0x274A188")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public ReadOnlyCollection<ElementInit> Initializers
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x274A190", Offset = "0x2746190", VA = "0x274A190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000097")]
	[DebuggerTypeProxy(typeof(LoopExpressionProxy))]
	public sealed class LoopExpression : Expression
	{
		[Token(Token = "0x170000AD")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x274A218", Offset = "0x2746218", VA = "0x274A218", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x274A2A0", Offset = "0x27462A0", VA = "0x274A2A0", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x170000AF")]
		public Expression Body
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x274A2A8", Offset = "0x27462A8", VA = "0x274A2A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public LabelTarget BreakLabel
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x274A2B0", Offset = "0x27462B0", VA = "0x274A2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		public LabelTarget ContinueLabel
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x274A2B8", Offset = "0x27462B8", VA = "0x274A2B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x274A198", Offset = "0x2746198", VA = "0x274A198")]
		internal LoopExpression(Expression body, LabelTarget @break, LabelTarget @continue)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x274A2C0", Offset = "0x27462C0", VA = "0x274A2C0", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2748428", Offset = "0x2744428", VA = "0x2748428")]
		public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body)
		{
			return null;
		}
	}
	[Token(Token = "0x2000098")]
	public sealed class MemberAssignment : MemberBinding
	{
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _expression;

		[Token(Token = "0x170000B2")]
		public Expression Expression
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x274A2E8", Offset = "0x27462E8", VA = "0x274A2E8")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000099")]
	public enum MemberBindingType
	{
		[Token(Token = "0x4000183")]
		Assignment,
		[Token(Token = "0x4000184")]
		MemberBinding,
		[Token(Token = "0x4000185")]
		ListBinding
	}
	[Token(Token = "0x200009A")]
	public abstract class MemberBinding
	{
		[Token(Token = "0x170000B3")]
		public MemberBindingType BindingType
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x274A2F0", Offset = "0x27462F0", VA = "0x274A2F0")]
			[CompilerGenerated]
			get
			{
				return default(MemberBindingType);
			}
		}

		[Token(Token = "0x170000B4")]
		public MemberInfo Member
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x274A2F8", Offset = "0x27462F8", VA = "0x274A2F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200009B")]
	[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
	public class MemberExpression : Expression
	{
		[Token(Token = "0x170000B5")]
		public MemberInfo Member
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x27463FC", Offset = "0x27423FC", VA = "0x27463FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public Expression Expression
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x274A300", Offset = "0x2746300", VA = "0x274A300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x274A48C", Offset = "0x274648C", VA = "0x274A48C", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x274A308", Offset = "0x2746308", VA = "0x274A308")]
		internal MemberExpression(Expression expression)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x274A374", Offset = "0x2746374", VA = "0x274A374")]
		internal static PropertyExpression Make(Expression expression, PropertyInfo property)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x274A400", Offset = "0x2746400", VA = "0x274A400")]
		internal static FieldExpression Make(Expression expression, FieldInfo field)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x274A494", Offset = "0x2746494", VA = "0x274A494", Slot = "10")]
		[ExcludeFromCodeCoverage]
		internal virtual MemberInfo GetMember()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x274A4BC", Offset = "0x27464BC", VA = "0x274A4BC", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2748504", Offset = "0x2744504", VA = "0x2748504")]
		public MemberExpression Update(Expression expression)
		{
			return null;
		}
	}
	[Token(Token = "0x200009C")]
	internal sealed class FieldExpression : MemberExpression
	{
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x18")]
		private readonly FieldInfo _field;

		[Token(Token = "0x170000B8")]
		public sealed override Type Type
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x274A4EC", Offset = "0x27464EC", VA = "0x274A4EC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x274A468", Offset = "0x2746468", VA = "0x274A468")]
		public FieldExpression(Expression expression, FieldInfo member)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x274A4E4", Offset = "0x27464E4", VA = "0x274A4E4", Slot = "10")]
		internal override MemberInfo GetMember()
		{
			return null;
		}
	}
	[Token(Token = "0x200009D")]
	internal sealed class PropertyExpression : MemberExpression
	{
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x18")]
		private readonly PropertyInfo _property;

		[Token(Token = "0x170000B9")]
		public sealed override Type Type
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x274A514", Offset = "0x2746514", VA = "0x274A514", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x274A3DC", Offset = "0x27463DC", VA = "0x274A3DC")]
		public PropertyExpression(Expression expression, PropertyInfo member)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x274A50C", Offset = "0x274650C", VA = "0x274A50C", Slot = "10")]
		internal override MemberInfo GetMember()
		{
			return null;
		}
	}
	[Token(Token = "0x200009E")]
	[DebuggerTypeProxy(typeof(MemberInitExpressionProxy))]
	public sealed class MemberInitExpression : Expression
	{
		[Token(Token = "0x170000BA")]
		public NewExpression NewExpression
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x274A534", Offset = "0x2746534", VA = "0x274A534")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public ReadOnlyCollection<MemberBinding> Bindings
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x274A53C", Offset = "0x274653C", VA = "0x274A53C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200009F")]
	public sealed class MemberListBinding : MemberBinding
	{
		[Token(Token = "0x170000BC")]
		public ReadOnlyCollection<ElementInit> Initializers
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x274A544", Offset = "0x2746544", VA = "0x274A544")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000A0")]
	public sealed class MemberMemberBinding : MemberBinding
	{
		[Token(Token = "0x170000BD")]
		public ReadOnlyCollection<MemberBinding> Bindings
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x274A54C", Offset = "0x274654C", VA = "0x274A54C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000A1")]
	[DebuggerTypeProxy(typeof(MethodCallExpressionProxy))]
	public class MethodCallExpression : Expression, IArgumentProvider
	{
		[Token(Token = "0x170000BE")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x274A5C8", Offset = "0x27465C8", VA = "0x274A5C8", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x170000BF")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x274A5D0", Offset = "0x27465D0", VA = "0x274A5D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public MethodInfo Method
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x274A5F0", Offset = "0x27465F0", VA = "0x274A5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public Expression Object
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x274671C", Offset = "0x274271C", VA = "0x274671C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		[ExcludeFromCodeCoverage]
		public virtual int ArgumentCount
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x274A670", Offset = "0x2746670", VA = "0x274A670", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x274A554", Offset = "0x2746554", VA = "0x274A554")]
		internal MethodCallExpression(MethodInfo method)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x274A5C0", Offset = "0x27465C0", VA = "0x274A5C0", Slot = "12")]
		internal virtual Expression GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x274A5F8", Offset = "0x27465F8", VA = "0x274A5F8", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x274A620", Offset = "0x2746620", VA = "0x274A620", Slot = "13")]
		[ExcludeFromCodeCoverage]
		internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x274A648", Offset = "0x2746648", VA = "0x274A648", Slot = "14")]
		[ExcludeFromCodeCoverage]
		public virtual Expression GetArgument(int index)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A2")]
	internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x18")]
		private readonly Expression _instance;

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x274A698", Offset = "0x2746698", VA = "0x274A698")]
		public InstanceMethodCallExpression(MethodInfo method, Expression instance)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x274A6BC", Offset = "0x27466BC", VA = "0x274A6BC", Slot = "12")]
		internal override Expression GetInstance()
		{
			return null;
		}
	}
	[Token(Token = "0x20000A3")]
	internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x18")]
		private IReadOnlyList<Expression> _arguments;

		[Token(Token = "0x170000C3")]
		public override int ArgumentCount
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x274A790", Offset = "0x2746790", VA = "0x274A790", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x274A6C4", Offset = "0x27466C4", VA = "0x274A6C4")]
		public MethodCallExpressionN(MethodInfo method, IReadOnlyList<Expression> args)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x274A6E8", Offset = "0x27466E8", VA = "0x274A6E8", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x274A830", Offset = "0x2746830", VA = "0x274A830", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A4")]
	internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x20")]
		private IReadOnlyList<Expression> _arguments;

		[Token(Token = "0x170000C4")]
		public override int ArgumentCount
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x274A96C", Offset = "0x274696C", VA = "0x274A96C", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x274A89C", Offset = "0x274689C", VA = "0x274A89C")]
		public InstanceMethodCallExpressionN(MethodInfo method, Expression instance, IReadOnlyList<Expression> args)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x274A8C4", Offset = "0x27468C4", VA = "0x274A8C4", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x274AA0C", Offset = "0x2746A0C", VA = "0x274AA0C", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A5")]
	internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x170000C5")]
		public override int ArgumentCount
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x274AAD8", Offset = "0x2746AD8", VA = "0x274AAD8", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x274AA88", Offset = "0x2746A88", VA = "0x274AA88")]
		public MethodCallExpression0(MethodInfo method)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x274AA8C", Offset = "0x2746A8C", VA = "0x274AA8C", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x274AAE0", Offset = "0x2746AE0", VA = "0x274AAE0", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A6")]
	internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x18")]
		private object _arg0;

		[Token(Token = "0x170000C6")]
		public override int ArgumentCount
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x274ABF8", Offset = "0x2746BF8", VA = "0x274ABF8", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x274AB3C", Offset = "0x2746B3C", VA = "0x274AB3C")]
		public MethodCallExpression1(MethodInfo method, Expression arg0)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x274AB60", Offset = "0x2746B60", VA = "0x274AB60", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x274AC00", Offset = "0x2746C00", VA = "0x274AC00", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A7")]
	internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x18")]
		private object _arg0;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _arg1;

		[Token(Token = "0x170000C7")]
		public override int ArgumentCount
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x274ADE4", Offset = "0x2746DE4", VA = "0x274ADE4", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x274AD0C", Offset = "0x2746D0C", VA = "0x274AD0C")]
		public MethodCallExpression2(MethodInfo method, Expression arg0, Expression arg1)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x274AD34", Offset = "0x2746D34", VA = "0x274AD34", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x274ADEC", Offset = "0x2746DEC", VA = "0x274ADEC", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A8")]
	internal sealed class MethodCallExpression3 : MethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x18")]
		private object _arg0;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _arg1;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg2;

		[Token(Token = "0x170000C8")]
		public override int ArgumentCount
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x274B060", Offset = "0x2747060", VA = "0x274B060", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x274AF68", Offset = "0x2746F68", VA = "0x274AF68")]
		public MethodCallExpression3(MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x274AFA0", Offset = "0x2746FA0", VA = "0x274AFA0", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x274B068", Offset = "0x2747068", VA = "0x274B068", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x18")]
		private object _arg0;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _arg1;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg2;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x30")]
		private readonly Expression _arg3;

		[Token(Token = "0x170000C9")]
		public override int ArgumentCount
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x274B37C", Offset = "0x274737C", VA = "0x274B37C", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x274B268", Offset = "0x2747268", VA = "0x274B268")]
		public MethodCallExpression4(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x274B2A4", Offset = "0x27472A4", VA = "0x274B2A4", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x274B384", Offset = "0x2747384", VA = "0x274B384", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AA")]
	internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x18")]
		private object _arg0;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _arg1;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg2;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x30")]
		private readonly Expression _arg3;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x38")]
		private readonly Expression _arg4;

		[Token(Token = "0x170000CA")]
		public override int ArgumentCount
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x274B72C", Offset = "0x274772C", VA = "0x274B72C", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x274B5F8", Offset = "0x27475F8", VA = "0x274B5F8")]
		public MethodCallExpression5(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x274B644", Offset = "0x2747644", VA = "0x274B644", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x274B734", Offset = "0x2747734", VA = "0x274B734", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AB")]
	internal sealed class InstanceMethodCallExpression0 : InstanceMethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x170000CB")]
		public override int ArgumentCount
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x274BA80", Offset = "0x2747A80", VA = "0x274BA80", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x274BA10", Offset = "0x2747A10", VA = "0x274BA10")]
		public InstanceMethodCallExpression0(MethodInfo method, Expression instance)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x274BA34", Offset = "0x2747A34", VA = "0x274BA34", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x274BA88", Offset = "0x2747A88", VA = "0x274BA88", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AC")]
	internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x20")]
		private object _arg0;

		[Token(Token = "0x170000CC")]
		public override int ArgumentCount
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x274BBB4", Offset = "0x2747BB4", VA = "0x274BBB4", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x274BAF4", Offset = "0x2747AF4", VA = "0x274BAF4")]
		public InstanceMethodCallExpression1(MethodInfo method, Expression instance, Expression arg0)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x274BB1C", Offset = "0x2747B1C", VA = "0x274BB1C", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x274BBBC", Offset = "0x2747BBC", VA = "0x274BBBC", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AD")]
	internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x20")]
		private object _arg0;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg1;

		[Token(Token = "0x170000CD")]
		public override int ArgumentCount
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x274BDB8", Offset = "0x2747DB8", VA = "0x274BDB8", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x274BCD0", Offset = "0x2747CD0", VA = "0x274BCD0")]
		public InstanceMethodCallExpression2(MethodInfo method, Expression instance, Expression arg0, Expression arg1)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x274BD08", Offset = "0x2747D08", VA = "0x274BD08", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x274BDC0", Offset = "0x2747DC0", VA = "0x274BDC0", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AE")]
	internal sealed class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider
	{
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x20")]
		private object _arg0;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg1;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x30")]
		private readonly Expression _arg2;

		[Token(Token = "0x170000CE")]
		public override int ArgumentCount
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x274C040", Offset = "0x2748040", VA = "0x274C040", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x274BF44", Offset = "0x2747F44", VA = "0x274BF44")]
		public InstanceMethodCallExpression3(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x274BF80", Offset = "0x2747F80", VA = "0x274BF80", Slot = "14")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x274C048", Offset = "0x2748048", VA = "0x274C048", Slot = "13")]
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AF")]
	[DebuggerTypeProxy(typeof(NewArrayExpressionProxy))]
	public class NewArrayExpression : Expression
	{
		[Token(Token = "0x170000CF")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x274C364", Offset = "0x2748364", VA = "0x274C364", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		public ReadOnlyCollection<Expression> Expressions
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x274C36C", Offset = "0x274836C", VA = "0x274C36C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x274C25C", Offset = "0x274825C", VA = "0x274C25C")]
		internal NewArrayExpression(Type type, ReadOnlyCollection<Expression> expressions)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x274C2CC", Offset = "0x27482CC", VA = "0x274C2CC")]
		internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions)
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x274C374", Offset = "0x2748374", VA = "0x274C374", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x2748754", Offset = "0x2744754", VA = "0x2748754")]
		public NewArrayExpression Update(IEnumerable<Expression> expressions)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B0")]
	internal sealed class NewArrayInitExpression : NewArrayExpression
	{
		[Token(Token = "0x170000D1")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x274C39C", Offset = "0x274839C", VA = "0x274C39C", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x274C35C", Offset = "0x274835C", VA = "0x274C35C")]
		internal NewArrayInitExpression(Type type, ReadOnlyCollection<Expression> expressions)
		{
		}
	}
	[Token(Token = "0x20000B1")]
	internal sealed class NewArrayBoundsExpression : NewArrayExpression
	{
		[Token(Token = "0x170000D2")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x274C3A4", Offset = "0x27483A4", VA = "0x274C3A4", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x274C360", Offset = "0x2748360", VA = "0x274C360")]
		internal NewArrayBoundsExpression(Type type, ReadOnlyCollection<Expression> expressions)
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[DebuggerTypeProxy(typeof(NewExpressionProxy))]
	public class NewExpression : Expression
	{
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x10")]
		private IReadOnlyList<Expression> _arguments;

		[Token(Token = "0x170000D3")]
		public ConstructorInfo Constructor
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x274C3AC", Offset = "0x27483AC", VA = "0x274C3AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x274C3B4", Offset = "0x27483B4", VA = "0x274C3B4", Slot = "10")]
		public Expression GetArgument(int index)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B3")]
	[DebuggerTypeProxy(typeof(ParameterExpressionProxy))]
	public class ParameterExpression : Expression
	{
		[Token(Token = "0x170000D4")]
		public override Type Type
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x274CB90", Offset = "0x2748B90", VA = "0x274CB90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x274CBFC", Offset = "0x2748BFC", VA = "0x274CBFC", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x170000D6")]
		public string Name
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x274CC04", Offset = "0x2748C04", VA = "0x274CC04")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public bool IsByRef
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x2746080", Offset = "0x2742080", VA = "0x2746080")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x274C45C", Offset = "0x274845C", VA = "0x274C45C")]
		internal ParameterExpression(string name)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x274C4C8", Offset = "0x27484C8", VA = "0x274C4C8")]
		internal static ParameterExpression Make(Type type, string name, bool isByRef)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x274CC0C", Offset = "0x2748C0C", VA = "0x274CC0C", Slot = "10")]
		internal virtual bool GetIsByRef()
		{
			return default(bool);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x274CC14", Offset = "0x2748C14", VA = "0x274CC14", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B4")]
	internal sealed class ByRefParameterExpression : TypedParameterExpression
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x274CB40", Offset = "0x2748B40", VA = "0x274CB40")]
		internal ByRefParameterExpression(Type type, string name)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x274CC3C", Offset = "0x2748C3C", VA = "0x274CC3C", Slot = "10")]
		internal override bool GetIsByRef()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B5")]
	internal class TypedParameterExpression : ParameterExpression
	{
		[Token(Token = "0x170000D8")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x274CC44", Offset = "0x2748C44", VA = "0x274CC44", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x274CB68", Offset = "0x2748B68", VA = "0x274CB68")]
		internal TypedParameterExpression(Type type, string name)
		{
		}
	}
	[Token(Token = "0x20000B6")]
	internal sealed class PrimitiveParameterExpression<T> : ParameterExpression
	{
		[Token(Token = "0x170000D9")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000497")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000496")]
		internal PrimitiveParameterExpression(string name)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[DebuggerTypeProxy(typeof(RuntimeVariablesExpressionProxy))]
	public sealed class RuntimeVariablesExpression : Expression
	{
		[Token(Token = "0x170000DA")]
		public ReadOnlyCollection<ParameterExpression> Variables
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x274CC4C", Offset = "0x2748C4C", VA = "0x274CC4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000B8")]
	internal sealed class StackGuard
	{
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x10")]
		private int _executionStackCount;

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x274CC54", Offset = "0x2748C54", VA = "0x274CC54")]
		public bool TryEnterOnCurrentStack()
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		public void RunOnEmptyStack<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
		{
		}

		[Token(Token = "0x600049B")]
		private R RunOnEmptyStackCore<R>(Func<object, R> action, object state)
		{
			return (R)null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x274CCB4", Offset = "0x2748CB4", VA = "0x274CCB4")]
		public StackGuard()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	internal static class Strings
	{
		[Token(Token = "0x170000DB")]
		internal static string ReducibleMustOverrideReduce
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x273F270", Offset = "0x273B270", VA = "0x273F270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		internal static string MustReduceToDifferent
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x273F7BC", Offset = "0x273B7BC", VA = "0x273F7BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		internal static string ReducedNotCompatible
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x273FDC0", Offset = "0x273BDC0", VA = "0x273FDC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		internal static string SetterHasNoParams
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x273FE94", Offset = "0x273BE94", VA = "0x273FE94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		internal static string PropertyCannotHaveRefType
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x273FF68", Offset = "0x273BF68", VA = "0x273FF68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		internal static string IndexesOfSetGetMustMatch
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x274003C", Offset = "0x273C03C", VA = "0x274003C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		internal static string AccessorsCannotHaveVarArgs
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x274028C", Offset = "0x273C28C", VA = "0x274028C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		internal static string AccessorsCannotHaveByRefArgs
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x2740360", Offset = "0x273C360", VA = "0x2740360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		internal static string BoundsCannotBeLessThanOne
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x2740660", Offset = "0x273C660", VA = "0x2740660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		internal static string TypeMustNotBeByRef
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x2740734", Offset = "0x273C734", VA = "0x2740734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		internal static string TypeMustNotBePointer
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x2740808", Offset = "0x273C808", VA = "0x2740808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		internal static string SetterMustBeVoid
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x27408DC", Offset = "0x273C8DC", VA = "0x27408DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E7")]
		internal static string PropertyTypeMustMatchGetter
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x27409B0", Offset = "0x273C9B0", VA = "0x27409B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		internal static string PropertyTypeMustMatchSetter
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x2740A84", Offset = "0x273CA84", VA = "0x2740A84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		internal static string BothAccessorsMustBeStatic
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x2740B58", Offset = "0x273CB58", VA = "0x2740B58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		internal static string OnlyStaticFieldsHaveNullInstance
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x2740C2C", Offset = "0x273CC2C", VA = "0x2740C2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EB")]
		internal static string OnlyStaticPropertiesHaveNullInstance
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x2740D00", Offset = "0x273CD00", VA = "0x2740D00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		internal static string OnlyStaticMethodsHaveNullInstance
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x2740DC4", Offset = "0x273CDC4", VA = "0x2740DC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		internal static string PropertyTypeCannotBeVoid
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x2740E98", Offset = "0x273CE98", VA = "0x2740E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		internal static string InvalidUnboxType
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x2740F6C", Offset = "0x273CF6C", VA = "0x2740F6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		internal static string ExpressionMustBeWriteable
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x2741040", Offset = "0x273D040", VA = "0x2741040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		internal static string ArgumentMustNotHaveValueType
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x2741114", Offset = "0x273D114", VA = "0x2741114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F1")]
		internal static string MustBeReducible
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x27411D8", Offset = "0x273D1D8", VA = "0x27411D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		internal static string LabelMustBeVoidOrHaveExpression
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x27412AC", Offset = "0x273D2AC", VA = "0x27412AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F3")]
		internal static string LabelTypeMustBeVoid
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x2741380", Offset = "0x273D380", VA = "0x2741380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F4")]
		internal static string QuotedExpressionMustBeLambda
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x2741454", Offset = "0x273D454", VA = "0x2741454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		internal static string CollectionModifiedWhileEnumerating
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x273F634", Offset = "0x273B634", VA = "0x273F634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F6")]
		internal static string CollectionReadOnly
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x273F6F8", Offset = "0x273B6F8", VA = "0x273F6F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		internal static string BindingCannotBeNull
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x273FCFC", Offset = "0x273BCFC", VA = "0x273FCFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F8")]
		internal static string NoOrInvalidRuleProduced
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x274058C", Offset = "0x273C58C", VA = "0x274058C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F9")]
		internal static string TypeMustBeDerivedFromSystemDelegate
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x27404C8", Offset = "0x273C4C8", VA = "0x27404C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		internal static string FirstArgumentMustBeCallSite
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x27401B8", Offset = "0x273C1B8", VA = "0x27401B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		internal static string FaultCannotHaveCatchOrFinally
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x2741728", Offset = "0x273D728", VA = "0x2741728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		internal static string TryMustHaveCatchFinallyOrFault
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x27417EC", Offset = "0x273D7EC", VA = "0x27417EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FD")]
		internal static string BodyOfCatchMustHaveSameTypeAsBodyOfTry
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x27418B0", Offset = "0x273D8B0", VA = "0x27418B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FE")]
		internal static string ConversionIsNotSupportedForArithmeticTypes
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x27420DC", Offset = "0x273E0DC", VA = "0x27420DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FF")]
		internal static string ArgumentMustBeArray
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x27421B0", Offset = "0x273E1B0", VA = "0x27421B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		internal static string ArgumentMustBeBoolean
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x2742284", Offset = "0x273E284", VA = "0x2742284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000101")]
		internal static string ArgumentMustBeInteger
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x2742358", Offset = "0x273E358", VA = "0x2742358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		internal static string ArgumentMustBeArrayIndexType
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x274243C", Offset = "0x273E43C", VA = "0x274243C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000103")]
		internal static string ArgumentMustBeSingleDimensionalArrayType
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x2742510", Offset = "0x273E510", VA = "0x2742510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		internal static string ArgumentTypesMustMatch
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x27425D4", Offset = "0x273E5D4", VA = "0x27425D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000105")]
		internal static string CoalesceUsedOnNonNullType
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x2742818", Offset = "0x273E818", VA = "0x2742818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		internal static string IncorrectNumberOfIndexes
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x2742EC4", Offset = "0x273EEC4", VA = "0x2742EC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		internal static string IncorrectNumberOfLambdaDeclarationParameters
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x2742F88", Offset = "0x273EF88", VA = "0x2742F88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		internal static string LambdaTypeMustBeDerivedFromSystemDelegate
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x274305C", Offset = "0x273F05C", VA = "0x274305C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000109")]
		internal static string ArgumentCannotBeOfTypeVoid
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x2743E70", Offset = "0x273FE70", VA = "0x2743E70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010A")]
		internal static string ControlCannotLeaveFinally
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x2744180", Offset = "0x2740180", VA = "0x2744180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		internal static string ControlCannotLeaveFilterTest
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x2744244", Offset = "0x2740244", VA = "0x2744244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		internal static string ControlCannotEnterTry
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x27443C0", Offset = "0x27403C0", VA = "0x27443C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		internal static string ControlCannotEnterExpression
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x2744484", Offset = "0x2740484", VA = "0x2744484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		internal static string RethrowRequiresCatch
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x27446E0", Offset = "0x27406E0", VA = "0x27446E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010F")]
		internal static string NonAbstractConstructorRequired
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x2744AA0", Offset = "0x2740AA0", VA = "0x2744AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000110")]
		internal static string ExpressionMustBeReadable
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x2745410", Offset = "0x2741410", VA = "0x2745410")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		internal static string EnumerationIsDone
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x2744BB8", Offset = "0x2740BB8", VA = "0x2744BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		internal static string InvalidArgumentValue
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x27454F4", Offset = "0x27414F4", VA = "0x27454F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000113")]
		internal static string IncorrectNumberOfLambdaArguments
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x2745160", Offset = "0x2741160", VA = "0x2745160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		internal static string IncorrectNumberOfConstructorArguments
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x2744E54", Offset = "0x2740E54", VA = "0x2744E54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2741518", Offset = "0x273D518", VA = "0x2741518")]
		internal static string VariableMustNotBeByRef(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x273F3D4", Offset = "0x273B3D4", VA = "0x273F3D4")]
		internal static string AmbiguousMatchInExpandoObject(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x273F4AC", Offset = "0x273B4AC", VA = "0x273F4AC")]
		internal static string SameKeyExistsInExpando(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x273F564", Offset = "0x273B564", VA = "0x273F564")]
		internal static string KeyDoesNotExistInExpando(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x273F31C", Offset = "0x273B31C", VA = "0x273F31C")]
		internal static string InvalidMetaObjectCreated(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x273F880", Offset = "0x273B880", VA = "0x273F880")]
		internal static string BinderNotCompatibleWithCallSite(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x273F960", Offset = "0x273B960", VA = "0x273F960")]
		internal static string DynamicBindingNeedsRestrictions(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x273FA50", Offset = "0x273BA50", VA = "0x273FA50")]
		internal static string DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x273FC14", Offset = "0x273BC14", VA = "0x273FC14")]
		internal static string DynamicBinderResultNotAssignable(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2741624", Offset = "0x273D624", VA = "0x2741624")]
		internal static string DuplicateVariable(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x27400E8", Offset = "0x273C0E8", VA = "0x27400E8")]
		internal static string TypeParameterIsNotDelegate(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x274195C", Offset = "0x273D95C", VA = "0x274195C")]
		internal static string ExtensionNodeMustOverrideProperty(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2741A24", Offset = "0x273DA24", VA = "0x2741A24")]
		internal static string UserDefinedOperatorMustBeStatic(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2741AEC", Offset = "0x273DAEC", VA = "0x2741AEC")]
		internal static string UserDefinedOperatorMustNotBeVoid(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2741BB4", Offset = "0x273DBB4", VA = "0x2741BB4")]
		internal static string CoercionOperatorNotDefined(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2741C8C", Offset = "0x273DC8C", VA = "0x2741C8C")]
		internal static string UnaryOperatorNotDefined(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2741D6C", Offset = "0x273DD6C", VA = "0x2741D6C")]
		internal static string BinaryOperatorNotDefined(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2741E4C", Offset = "0x273DE4C", VA = "0x2741E4C")]
		internal static string ReferenceEqualityNotDefined(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2741F24", Offset = "0x273DF24", VA = "0x2741F24")]
		internal static string OperandTypesDoNotMatchParameters(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2741FFC", Offset = "0x273DFFC", VA = "0x2741FFC")]
		internal static string OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x2742680", Offset = "0x273E680", VA = "0x2742680")]
		internal static string CannotAutoInitializeValueTypeMemberThroughProperty(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2742748", Offset = "0x273E748", VA = "0x2742748")]
		internal static string IncorrectTypeForTypeAs(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x27428D4", Offset = "0x273E8D4", VA = "0x27428D4")]
		internal static string ExpressionTypeCannotInitializeArrayType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x27429AC", Offset = "0x273E9AC", VA = "0x27429AC")]
		internal static string ExpressionTypeDoesNotMatchReturn(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x2742A84", Offset = "0x273EA84", VA = "0x2742A84")]
		internal static string ExpressionTypeDoesNotMatchAssignment(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2742B5C", Offset = "0x273EB5C", VA = "0x2742B5C")]
		internal static string ExpressionTypeDoesNotMatchLabel(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2742C34", Offset = "0x273EC34", VA = "0x2742C34")]
		internal static string ExpressionTypeNotInvocable(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2742CFC", Offset = "0x273ECFC", VA = "0x2742CFC")]
		internal static string InstanceFieldNotDefinedForType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2742DDC", Offset = "0x273EDDC", VA = "0x2742DDC")]
		internal static string FieldInfoNotDefinedForType(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2743118", Offset = "0x273F118", VA = "0x2743118")]
		internal static string MemberNotFieldOrProperty(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x27431E0", Offset = "0x273F1E0", VA = "0x27431E0")]
		internal static string MethodContainsGenericParameters(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x27432A8", Offset = "0x273F2A8", VA = "0x27432A8")]
		internal static string MethodIsGeneric(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2743370", Offset = "0x273F370", VA = "0x2743370")]
		internal static string PropertyDoesNotHaveAccessor(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2743438", Offset = "0x273F438", VA = "0x2743438")]
		internal static string ParameterExpressionNotValidAsDelegate(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2743518", Offset = "0x273F518", VA = "0x2743518")]
		internal static string PropertyNotDefinedForType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x27435F8", Offset = "0x273F5F8", VA = "0x27435F8")]
		internal static string InstancePropertyNotDefinedForType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x27436D8", Offset = "0x273F6D8", VA = "0x27436D8")]
		internal static string InstanceAndMethodTypeMismatch(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x27437B8", Offset = "0x273F7B8", VA = "0x27437B8")]
		internal static string UnhandledBinary(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2743880", Offset = "0x273F880", VA = "0x2743880")]
		internal static string UnhandledUnary(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2743948", Offset = "0x273F948", VA = "0x2743948")]
		internal static string UserDefinedOpMustHaveConsistentTypes(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2743A20", Offset = "0x273FA20", VA = "0x2743A20")]
		internal static string UserDefinedOpMustHaveValidReturnType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2743AF8", Offset = "0x273FAF8", VA = "0x2743AF8")]
		internal static string LogicalOperatorMustHaveBooleanOperators(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2743BD0", Offset = "0x273FBD0", VA = "0x2743BD0")]
		internal static string MethodWithArgsDoesNotExistOnType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2743CA8", Offset = "0x273FCA8", VA = "0x2743CA8")]
		internal static string GenericMethodWithArgsDoesNotExistOnType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2743D80", Offset = "0x273FD80", VA = "0x2743D80")]
		internal static string MethodWithMoreThanOneMatch(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2743F30", Offset = "0x273FF30", VA = "0x2743F30")]
		internal static string OutOfRange(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2743FF8", Offset = "0x273FFF8", VA = "0x2743FF8")]
		internal static string LabelTargetAlreadyDefined(object p0)
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x27440B0", Offset = "0x27400B0", VA = "0x27440B0")]
		internal static string LabelTargetUndefined(object p0)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x27442F0", Offset = "0x27402F0", VA = "0x27442F0")]
		internal static string AmbiguousJump(object p0)
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2744530", Offset = "0x2740530", VA = "0x2744530")]
		internal static string NonLocalJumpWithValue(object p0)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2744610", Offset = "0x2740610", VA = "0x2744610")]
		internal static string InvalidLvalue(object p0)
		{
			return null;
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x27447A4", Offset = "0x27407A4", VA = "0x27447A4")]
		internal static string MustRewriteToSameNode(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x274488C", Offset = "0x274088C", VA = "0x274488C")]
		internal static string MustRewriteChildToSameType(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x274496C", Offset = "0x274096C", VA = "0x274496C")]
		internal static string MustRewriteWithoutMethod(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x27452EC", Offset = "0x27412EC", VA = "0x27452EC")]
		internal static string ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2744C74", Offset = "0x2740C74", VA = "0x2744C74")]
		internal static string TypeContainsGenericParameters(object p0)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2744D60", Offset = "0x2740D60", VA = "0x2744D60")]
		internal static string TypeIsGeneric(object p0)
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x27455B0", Offset = "0x27415B0", VA = "0x27455B0")]
		internal static string InvalidNullValue(object p0)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x27456B4", Offset = "0x27416B4", VA = "0x27456B4")]
		internal static string InvalidObjectType(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2744F28", Offset = "0x2740F28", VA = "0x2744F28")]
		internal static string ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x274504C", Offset = "0x274104C", VA = "0x274504C")]
		internal static string ExpressionTypeDoesNotMatchParameter(object p0, object p1)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x274521C", Offset = "0x274121C", VA = "0x274521C")]
		internal static string IncorrectNumberOfMethodCallArguments(object p0)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BB")]
	[DebuggerTypeProxy(typeof(Expression.SwitchCaseProxy))]
	public sealed class SwitchCase
	{
		[Token(Token = "0x17000115")]
		public ReadOnlyCollection<Expression> TestValues
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x274CCBC", Offset = "0x2748CBC", VA = "0x274CCBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000116")]
		public Expression Body
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x274CCC4", Offset = "0x2748CC4", VA = "0x274CCC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000BC")]
	[DebuggerTypeProxy(typeof(SwitchExpressionProxy))]
	public sealed class SwitchExpression : Expression
	{
		[Token(Token = "0x17000117")]
		public Expression SwitchValue
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x274CCCC", Offset = "0x2748CCC", VA = "0x274CCCC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000118")]
		public ReadOnlyCollection<SwitchCase> Cases
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x274CCD4", Offset = "0x2748CD4", VA = "0x274CCD4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000119")]
		public Expression DefaultBody
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x274CCDC", Offset = "0x2748CDC", VA = "0x274CCDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		public MethodInfo Comparison
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x274CCE4", Offset = "0x2748CE4", VA = "0x274CCE4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000BD")]
	public class SymbolDocumentInfo
	{
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Guid DocumentType_Text;

		[Token(Token = "0x1700011B")]
		public string FileName
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x274CCEC", Offset = "0x2748CEC", VA = "0x274CCEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000BE")]
	[DebuggerTypeProxy(typeof(TryExpressionProxy))]
	public sealed class TryExpression : Expression
	{
		[Token(Token = "0x1700011C")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x274CE2C", Offset = "0x2748E2C", VA = "0x274CE2C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x274CE34", Offset = "0x2748E34", VA = "0x274CE34", Slot = "4")]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x1700011E")]
		public Expression Body
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x274CE3C", Offset = "0x2748E3C", VA = "0x274CE3C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011F")]
		public ReadOnlyCollection<CatchBlock> Handlers
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x274CE44", Offset = "0x2748E44", VA = "0x274CE44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000120")]
		public Expression Finally
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x274CE4C", Offset = "0x2748E4C", VA = "0x274CE4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		public Expression Fault
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x274CE54", Offset = "0x2748E54", VA = "0x274CE54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x274CD98", Offset = "0x2748D98", VA = "0x274CD98")]
		internal TryExpression(Type type, Expression body, Expression @finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x274CE5C", Offset = "0x2748E5C", VA = "0x274CE5C", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2748A84", Offset = "0x2744A84", VA = "0x2748A84")]
		public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression @finally, Expression fault)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BF")]
	[DebuggerTypeProxy(typeof(TypeBinaryExpressionProxy))]
	public sealed class TypeBinaryExpression : Expression
	{
		[Token(Token = "0x17000122")]
		public sealed override Type Type
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x274CF04", Offset = "0x2748F04", VA = "0x274CF04", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000123")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x274CF70", Offset = "0x2748F70", VA = "0x274CF70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x17000124")]
		public Expression Expression
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x274CF78", Offset = "0x2748F78", VA = "0x274CF78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000125")]
		public Type TypeOperand
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x274CF80", Offset = "0x2748F80", VA = "0x274CF80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x274CE84", Offset = "0x2748E84", VA = "0x274CE84")]
		internal TypeBinaryExpression(Expression expression, Type typeOperand, ExpressionType nodeType)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x274CF88", Offset = "0x2748F88", VA = "0x274CF88", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2748BB0", Offset = "0x2744BB0", VA = "0x2748BB0")]
		public TypeBinaryExpression Update(Expression expression)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C0")]
	[DebuggerTypeProxy(typeof(UnaryExpressionProxy))]
	public sealed class UnaryExpression : Expression
	{
		[Token(Token = "0x17000126")]
		public sealed override Type Type
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x274D038", Offset = "0x2749038", VA = "0x274D038", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000127")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x274D040", Offset = "0x2749040", VA = "0x274D040", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x17000128")]
		public Expression Operand
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x274D048", Offset = "0x2749048", VA = "0x274D048")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000129")]
		public MethodInfo Method
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x274D050", Offset = "0x2749050", VA = "0x274D050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		public bool IsLifted
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x274D058", Offset = "0x2749058", VA = "0x274D058")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012B")]
		public bool IsLiftedToNull
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x274D278", Offset = "0x2749278", VA = "0x274D278")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012C")]
		public override bool CanReduce
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x274D32C", Offset = "0x274932C", VA = "0x274D32C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012D")]
		private bool IsPrefix
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x274E140", Offset = "0x274A140", VA = "0x274E140")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x274CFB0", Offset = "0x2748FB0", VA = "0x274CFB0")]
		internal UnaryExpression(ExpressionType nodeType, Expression expression, Type type, MethodInfo method)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x274D304", Offset = "0x2749304", VA = "0x274D304", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x274D350", Offset = "0x2749350", VA = "0x274D350", Slot = "7")]
		public override Expression Reduce()
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x274E184", Offset = "0x274A184", VA = "0x274E184")]
		private UnaryExpression FunctionalOp(Expression operand)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x274DE80", Offset = "0x2749E80", VA = "0x274DE80")]
		private Expression ReduceVariable()
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x274D99C", Offset = "0x274999C", VA = "0x274D99C")]
		private Expression ReduceMember()
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x274D3C0", Offset = "0x27493C0", VA = "0x274D3C0")]
		private Expression ReduceIndex()
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2748CA8", Offset = "0x2744CA8", VA = "0x2748CA8")]
		public UnaryExpression Update(Expression operand)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C1")]
	internal static class Utils
	{
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly object BoxedFalse;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x8")]
		public static readonly object BoxedTrue;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x10")]
		public static readonly object BoxedIntM1;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x18")]
		public static readonly object BoxedInt0;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x20")]
		public static readonly object BoxedInt1;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x28")]
		public static readonly object BoxedInt2;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x30")]
		public static readonly object BoxedInt3;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x38")]
		public static readonly object BoxedDefaultSByte;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x40")]
		public static readonly object BoxedDefaultChar;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x48")]
		public static readonly object BoxedDefaultInt16;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x50")]
		public static readonly object BoxedDefaultInt64;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x58")]
		public static readonly object BoxedDefaultByte;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x60")]
		public static readonly object BoxedDefaultUInt16;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x68")]
		public static readonly object BoxedDefaultUInt32;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x70")]
		public static readonly object BoxedDefaultUInt64;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x78")]
		public static readonly object BoxedDefaultSingle;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x80")]
		public static readonly object BoxedDefaultDouble;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x88")]
		public static readonly object BoxedDefaultDecimal;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x90")]
		public static readonly object BoxedDefaultDateTime;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x98")]
		private static readonly ConstantExpression s_true;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0xA0")]
		private static readonly ConstantExpression s_false;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0xA8")]
		private static readonly ConstantExpression s_m1;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0xB0")]
		private static readonly ConstantExpression s_0;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0xB8")]
		private static readonly ConstantExpression s_1;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0xC0")]
		private static readonly ConstantExpression s_2;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0xC8")]
		private static readonly ConstantExpression s_3;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly DefaultExpression Empty;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly ConstantExpression Null;

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x274E250", Offset = "0x274A250", VA = "0x274E250")]
		public static ConstantExpression Constant(bool value)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x274E2BC", Offset = "0x274A2BC", VA = "0x274E2BC")]
		public static ConstantExpression Constant(int value)
		{
			return null;
		}
	}
}
namespace System.Linq.Expressions.Interpreter
{
	[Token(Token = "0x20000C2")]
	internal abstract class AddInstruction : Instruction
	{
		[Token(Token = "0x20000C3")]
		private sealed class AddInt16 : AddInstruction
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x274EDB0", Offset = "0x274ADB0", VA = "0x274EDB0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x274ED70", Offset = "0x274AD70", VA = "0x274ED70")]
			public AddInt16()
			{
			}
		}

		[Token(Token = "0x20000C4")]
		private sealed class AddInt32 : AddInstruction
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x274EEF8", Offset = "0x274AEF8", VA = "0x274EEF8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x274ED78", Offset = "0x274AD78", VA = "0x274ED78")]
			public AddInt32()
			{
			}
		}

		[Token(Token = "0x20000C5")]
		private sealed class AddInt64 : AddInstruction
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x274F02C", Offset = "0x274B02C", VA = "0x274F02C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x274ED80", Offset = "0x274AD80", VA = "0x274ED80")]
			public AddInt64()
			{
			}
		}

		[Token(Token = "0x20000C6")]
		private sealed class AddUInt16 : AddInstruction
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x274F174", Offset = "0x274B174", VA = "0x274F174", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x274ED88", Offset = "0x274AD88", VA = "0x274ED88")]
			public AddUInt16()
			{
			}
		}

		[Token(Token = "0x20000C7")]
		private sealed class AddUInt32 : AddInstruction
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x274F2BC", Offset = "0x274B2BC", VA = "0x274F2BC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x274ED90", Offset = "0x274AD90", VA = "0x274ED90")]
			public AddUInt32()
			{
			}
		}

		[Token(Token = "0x20000C8")]
		private sealed class AddUInt64 : AddInstruction
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x274F404", Offset = "0x274B404", VA = "0x274F404", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x274ED98", Offset = "0x274AD98", VA = "0x274ED98")]
			public AddUInt64()
			{
			}
		}

		[Token(Token = "0x20000C9")]
		private sealed class AddSingle : AddInstruction
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x274F54C", Offset = "0x274B54C", VA = "0x274F54C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x274EDA0", Offset = "0x274ADA0", VA = "0x274EDA0")]
			public AddSingle()
			{
			}
		}

		[Token(Token = "0x20000CA")]
		private sealed class AddDouble : AddInstruction
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x274F690", Offset = "0x274B690", VA = "0x274F690", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x274EDA8", Offset = "0x274ADA8", VA = "0x274EDA8")]
			public AddDouble()
			{
			}
		}

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_UInt16;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_UInt32;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt64;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_Single;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_Double;

		[Token(Token = "0x1700012E")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x274E97C", Offset = "0x274A97C", VA = "0x274E97C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012F")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x274E984", Offset = "0x274A984", VA = "0x274E984", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000130")]
		public override string InstructionName
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x274E98C", Offset = "0x274A98C", VA = "0x274E98C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x274E9CC", Offset = "0x274A9CC", VA = "0x274E9CC")]
		private AddInstruction()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x274E9D4", Offset = "0x274A9D4", VA = "0x274E9D4")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CB")]
	internal abstract class AddOvfInstruction : Instruction
	{
		[Token(Token = "0x20000CC")]
		private sealed class AddOvfInt16 : AddOvfInstruction
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x274FB24", Offset = "0x274BB24", VA = "0x274FB24", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0x274FAF4", Offset = "0x274BAF4", VA = "0x274FAF4")]
			public AddOvfInt16()
			{
			}
		}

		[Token(Token = "0x20000CD")]
		private sealed class AddOvfInt32 : AddOvfInstruction
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x274FD70", Offset = "0x274BD70", VA = "0x274FD70", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0x274FAFC", Offset = "0x274BAFC", VA = "0x274FAFC")]
			public AddOvfInt32()
			{
			}
		}

		[Token(Token = "0x20000CE")]
		private sealed class AddOvfInt64 : AddOvfInstruction
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x274FF84", Offset = "0x274BF84", VA = "0x274FF84", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000562")]
			[Address(RVA = "0x274FB04", Offset = "0x274BB04", VA = "0x274FB04")]
			public AddOvfInt64()
			{
			}
		}

		[Token(Token = "0x20000CF")]
		private sealed class AddOvfUInt16 : AddOvfInstruction
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x2750168", Offset = "0x274C168", VA = "0x2750168", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000564")]
			[Address(RVA = "0x274FB0C", Offset = "0x274BB0C", VA = "0x274FB0C")]
			public AddOvfUInt16()
			{
			}
		}

		[Token(Token = "0x20000D0")]
		private sealed class AddOvfUInt32 : AddOvfInstruction
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x27503B4", Offset = "0x274C3B4", VA = "0x27503B4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000566")]
			[Address(RVA = "0x274FB14", Offset = "0x274BB14", VA = "0x274FB14")]
			public AddOvfUInt32()
			{
			}
		}

		[Token(Token = "0x20000D1")]
		private sealed class AddOvfUInt64 : AddOvfInstruction
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x2750580", Offset = "0x274C580", VA = "0x2750580", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0x274FB1C", Offset = "0x274BB1C", VA = "0x274FB1C")]
			public AddOvfUInt64()
			{
			}
		}

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_UInt16;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_UInt32;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt64;

		[Token(Token = "0x17000131")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x274F7D4", Offset = "0x274B7D4", VA = "0x274F7D4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000132")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x274F7DC", Offset = "0x274B7DC", VA = "0x274F7DC", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000133")]
		public override string InstructionName
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x274F7E4", Offset = "0x274B7E4", VA = "0x274F7E4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x274F824", Offset = "0x274B824", VA = "0x274F824")]
		private AddOvfInstruction()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x274F82C", Offset = "0x274B82C", VA = "0x274F82C")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D2")]
	internal abstract class AndInstruction : Instruction
	{
		[Token(Token = "0x20000D3")]
		private sealed class AndSByte : AndInstruction
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x2750BDC", Offset = "0x274CBDC", VA = "0x2750BDC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x2750B94", Offset = "0x274CB94", VA = "0x2750B94")]
			public AndSByte()
			{
			}
		}

		[Token(Token = "0x20000D4")]
		private sealed class AndInt16 : AndInstruction
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x2750CD0", Offset = "0x274CCD0", VA = "0x2750CD0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x2750B9C", Offset = "0x274CB9C", VA = "0x2750B9C")]
			public AndInt16()
			{
			}
		}

		[Token(Token = "0x20000D5")]
		private sealed class AndInt32 : AndInstruction
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x2750DC4", Offset = "0x274CDC4", VA = "0x2750DC4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x2750BA4", Offset = "0x274CBA4", VA = "0x2750BA4")]
			public AndInt32()
			{
			}
		}

		[Token(Token = "0x20000D6")]
		private sealed class AndInt64 : AndInstruction
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x2750EB8", Offset = "0x274CEB8", VA = "0x2750EB8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x2750BAC", Offset = "0x274CBAC", VA = "0x2750BAC")]
			public AndInt64()
			{
			}
		}

		[Token(Token = "0x20000D7")]
		private sealed class AndByte : AndInstruction
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x2750FBC", Offset = "0x274CFBC", VA = "0x2750FBC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x2750BB4", Offset = "0x274CBB4", VA = "0x2750BB4")]
			public AndByte()
			{
			}
		}

		[Token(Token = "0x20000D8")]
		private sealed class AndUInt16 : AndInstruction
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x27510B0", Offset = "0x274D0B0", VA = "0x27510B0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0x2750BBC", Offset = "0x274CBBC", VA = "0x2750BBC")]
			public AndUInt16()
			{
			}
		}

		[Token(Token = "0x20000D9")]
		private sealed class AndUInt32 : AndInstruction
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x27511A4", Offset = "0x274D1A4", VA = "0x27511A4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0x2750BC4", Offset = "0x274CBC4", VA = "0x2750BC4")]
			public AndUInt32()
			{
			}
		}

		[Token(Token = "0x20000DA")]
		private sealed class AndUInt64 : AndInstruction
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x27512A8", Offset = "0x274D2A8", VA = "0x27512A8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x2750BCC", Offset = "0x274CBCC", VA = "0x2750BCC")]
			public AndUInt64()
			{
			}
		}

		[Token(Token = "0x20000DB")]
		private sealed class AndBoolean : AndInstruction
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x27513AC", Offset = "0x274D3AC", VA = "0x27513AC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x2750BD4", Offset = "0x274CBD4", VA = "0x2750BD4")]
			public AndBoolean()
			{
			}
		}

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_SByte;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int16;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int32;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int64;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Byte;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt16;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_UInt32;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_UInt64;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x40")]
		private static Instruction s_Boolean;

		[Token(Token = "0x17000134")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x2750748", Offset = "0x274C748", VA = "0x2750748", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000135")]
		public override int ProducedStack
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x2750750", Offset = "0x274C750", VA = "0x2750750", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000136")]
		public override string InstructionName
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x2750758", Offset = "0x274C758", VA = "0x2750758", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x2750798", Offset = "0x274C798", VA = "0x2750798")]
		private AndInstruction()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x27507A0", Offset = "0x274C7A0", VA = "0x27507A0")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DC")]
	internal sealed class NewArrayInitInstruction : Instruction
	{
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _elementType;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _elementCount;

		[Token(Token = "0x17000137")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x2751530", Offset = "0x274D530", VA = "0x2751530", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000138")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x2751538", Offset = "0x274D538", VA = "0x2751538", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000139")]
		public override string InstructionName
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x2751540", Offset = "0x274D540", VA = "0x2751540", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x2751500", Offset = "0x274D500", VA = "0x2751500")]
		internal NewArrayInitInstruction(Type elementType, int elementCount)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2751580", Offset = "0x274D580", VA = "0x2751580", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000DD")]
	internal sealed class NewArrayInstruction : Instruction
	{
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _elementType;

		[Token(Token = "0x1700013A")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x2751638", Offset = "0x274D638", VA = "0x2751638", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700013B")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x2751640", Offset = "0x274D640", VA = "0x2751640", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700013C")]
		public override string InstructionName
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x2751648", Offset = "0x274D648", VA = "0x2751648", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x2751610", Offset = "0x274D610", VA = "0x2751610")]
		internal NewArrayInstruction(Type elementType)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2751688", Offset = "0x274D688", VA = "0x2751688", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000DE")]
	internal sealed class NewArrayBoundsInstruction : Instruction
	{
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _elementType;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _rank;

		[Token(Token = "0x1700013D")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x2751850", Offset = "0x274D850", VA = "0x2751850", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700013E")]
		public override int ProducedStack
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x2751858", Offset = "0x274D858", VA = "0x2751858", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700013F")]
		public override string InstructionName
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x2751860", Offset = "0x274D860", VA = "0x2751860", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2751820", Offset = "0x274D820", VA = "0x2751820")]
		internal NewArrayBoundsInstruction(Type elementType, int rank)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x27518A0", Offset = "0x274D8A0", VA = "0x27518A0", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000DF")]
	internal sealed class GetArrayItemInstruction : Instruction
	{
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly GetArrayItemInstruction Instance;

		[Token(Token = "0x17000140")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x27519B0", Offset = "0x274D9B0", VA = "0x27519B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000141")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x27519B8", Offset = "0x274D9B8", VA = "0x27519B8", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000142")]
		public override string InstructionName
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x27519C0", Offset = "0x274D9C0", VA = "0x27519C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x27519A8", Offset = "0x274D9A8", VA = "0x27519A8")]
		private GetArrayItemInstruction()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2751A00", Offset = "0x274DA00", VA = "0x2751A00", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E0")]
	internal sealed class SetArrayItemInstruction : Instruction
	{
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly SetArrayItemInstruction Instance;

		[Token(Token = "0x17000143")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x2751B20", Offset = "0x274DB20", VA = "0x2751B20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000144")]
		public override string InstructionName
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x2751B28", Offset = "0x274DB28", VA = "0x2751B28", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2751B18", Offset = "0x274DB18", VA = "0x2751B18")]
		private SetArrayItemInstruction()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2751B68", Offset = "0x274DB68", VA = "0x2751B68", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E1")]
	internal sealed class ArrayLengthInstruction : Instruction
	{
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ArrayLengthInstruction Instance;

		[Token(Token = "0x17000145")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x2751C84", Offset = "0x274DC84", VA = "0x2751C84", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000146")]
		public override int ProducedStack
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x2751C8C", Offset = "0x274DC8C", VA = "0x2751C8C", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000147")]
		public override string InstructionName
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x2751C94", Offset = "0x274DC94", VA = "0x2751C94", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2751CD4", Offset = "0x274DCD4", VA = "0x2751CD4")]
		private ArrayLengthInstruction()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2751CDC", Offset = "0x274DCDC", VA = "0x2751CDC", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E2")]
	internal static class ConvertHelper
	{
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2751718", Offset = "0x274D718", VA = "0x2751718")]
		public static int ToInt32NoNull(object val)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E3")]
	internal readonly struct RuntimeLabel
	{
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x0")]
		public readonly int Index;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x4")]
		public readonly int StackDepth;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x8")]
		public readonly int ContinuationStackDepth;

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2751DDC", Offset = "0x274DDDC", VA = "0x2751DDC")]
		public RuntimeLabel(int index, int continuationStackDepth, int stackDepth)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2751DE8", Offset = "0x274DDE8", VA = "0x2751DE8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000E4")]
	internal sealed class BranchLabel
	{
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x10")]
		private int _targetIndex;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x14")]
		private int _stackDepth;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x18")]
		private int _continuationStackDepth;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x20")]
		private List<int> _forwardBranchFixups;

		[Token(Token = "0x17000148")]
		internal int LabelIndex
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x2751EE4", Offset = "0x274DEE4", VA = "0x2751EE4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x2751EEC", Offset = "0x274DEEC", VA = "0x2751EEC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000149")]
		internal bool HasRuntimeLabel
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x2751EF4", Offset = "0x274DEF4", VA = "0x2751EF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014A")]
		internal int TargetIndex
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x2751F08", Offset = "0x274DF08", VA = "0x2751F08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2751F10", Offset = "0x274DF10", VA = "0x2751F10")]
		internal RuntimeLabel ToRuntimeLabel()
		{
			return default(RuntimeLabel);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2751F20", Offset = "0x274DF20", VA = "0x2751F20")]
		internal void Mark(InstructionList instructions)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x27520A4", Offset = "0x274E0A4", VA = "0x27520A4")]
		internal void AddBranch(InstructionList instructions, int branchIndex)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x275207C", Offset = "0x274E07C", VA = "0x275207C")]
		internal void FixupBranch(InstructionList instructions, int branchIndex)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x27521CC", Offset = "0x274E1CC", VA = "0x27521CC")]
		public BranchLabel()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	internal abstract class CallInstruction : Instruction
	{
		[Token(Token = "0x1700014B")]
		public abstract int ArgumentCount
		{
			[Token(Token = "0x60005AC")]
			get;
		}

		[Token(Token = "0x1700014C")]
		public override string InstructionName
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x27521E8", Offset = "0x274E1E8", VA = "0x27521E8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014D")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x2752944", Offset = "0x274E944", VA = "0x2752944", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2752228", Offset = "0x274E228", VA = "0x2752228")]
		public static CallInstruction Create(MethodInfo info)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x275228C", Offset = "0x274E28C", VA = "0x275228C")]
		public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters)
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2752410", Offset = "0x274E410", VA = "0x2752410")]
		private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount)
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x27528D8", Offset = "0x274E8D8", VA = "0x27528D8")]
		public static void ArrayItemSetter1(Array array, int index0, object value)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x27528F8", Offset = "0x274E8F8", VA = "0x27528F8")]
		public static void ArrayItemSetter2(Array array, int index0, int index1, object value)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x275291C", Offset = "0x274E91C", VA = "0x275291C")]
		public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x2752950", Offset = "0x274E950", VA = "0x2752950")]
		protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2752A4C", Offset = "0x274EA4C", VA = "0x2752A4C")]
		protected object InterpretLambdaInvoke(LightLambda targetLambda, object[] args)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2752AB0", Offset = "0x274EAB0", VA = "0x2752AB0")]
		protected CallInstruction()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	internal class MethodInfoCallInstruction : CallInstruction
	{
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x10")]
		protected readonly MethodInfo _target;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x18")]
		protected readonly int _argumentCount;

		[Token(Token = "0x1700014E")]
		public override int ArgumentCount
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x2752AB8", Offset = "0x274EAB8", VA = "0x2752AB8", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014F")]
		public override int ProducedStack
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x2752AC0", Offset = "0x274EAC0", VA = "0x2752AC0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x27528A8", Offset = "0x274E8A8", VA = "0x27528A8")]
		internal MethodInfoCallInstruction(MethodInfo target, int argumentCount)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2752B70", Offset = "0x274EB70", VA = "0x2752B70", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x2752E70", Offset = "0x274EE70", VA = "0x2752E70")]
		protected object[] GetArgs(InterpretedFrame frame, int first, int skip)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2752FF4", Offset = "0x274EFF4", VA = "0x2752FF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000E7")]
	internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
	{
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x20")]
		private readonly ByRefUpdater[] _byrefArgs;

		[Token(Token = "0x17000150")]
		public override int ProducedStack
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x27530B8", Offset = "0x274F0B8", VA = "0x27530B8", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2753078", Offset = "0x274F078", VA = "0x2753078")]
		internal ByRefMethodInfoCallInstruction(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2753168", Offset = "0x274F168", VA = "0x2753168", Slot = "8")]
		public sealed override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000E8")]
	internal abstract class OffsetInstruction : Instruction
	{
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x10")]
		protected int _offset;

		[Token(Token = "0x17000151")]
		public abstract Instruction[] Cache
		{
			[Token(Token = "0x60005C1")]
			get;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2753644", Offset = "0x274F644", VA = "0x2753644")]
		public Instruction Fixup(int offset)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x27536C0", Offset = "0x274F6C0", VA = "0x27536C0", Slot = "10")]
		public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2753788", Offset = "0x274F788", VA = "0x2753788", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2753854", Offset = "0x274F854", VA = "0x2753854")]
		protected OffsetInstruction()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	internal sealed class BranchFalseInstruction : OffsetInstruction
	{
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction[] s_cache;

		[Token(Token = "0x17000152")]
		public override Instruction[] Cache
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x2753864", Offset = "0x274F864", VA = "0x2753864", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000153")]
		public override string InstructionName
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x27538E8", Offset = "0x274F8E8", VA = "0x27538E8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x2753928", Offset = "0x274F928", VA = "0x2753928", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2753930", Offset = "0x274F930", VA = "0x2753930", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x27539C0", Offset = "0x274F9C0", VA = "0x27539C0")]
		public BranchFalseInstruction()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	internal sealed class BranchTrueInstruction : OffsetInstruction
	{
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction[] s_cache;

		[Token(Token = "0x17000155")]
		public override Instruction[] Cache
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x27539D0", Offset = "0x274F9D0", VA = "0x27539D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000156")]
		public override string InstructionName
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x2753A54", Offset = "0x274FA54", VA = "0x2753A54", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000157")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x2753A94", Offset = "0x274FA94", VA = "0x2753A94", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2753A9C", Offset = "0x274FA9C", VA = "0x2753A9C", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2753B2C", Offset = "0x274FB2C", VA = "0x2753B2C")]
		public BranchTrueInstruction()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	internal sealed class CoalescingBranchInstruction : OffsetInstruction
	{
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction[] s_cache;

		[Token(Token = "0x17000158")]
		public override Instruction[] Cache
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x2753B3C", Offset = "0x274FB3C", VA = "0x2753B3C", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000159")]
		public override string InstructionName
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x2753BC0", Offset = "0x274FBC0", VA = "0x2753BC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x2753C00", Offset = "0x274FC00", VA = "0x2753C00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015B")]
		public override int ProducedStack
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x2753C08", Offset = "0x274FC08", VA = "0x2753C08", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2753C10", Offset = "0x274FC10", VA = "0x2753C10", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2753C44", Offset = "0x274FC44", VA = "0x2753C44")]
		public CoalescingBranchInstruction()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	internal class BranchInstruction : OffsetInstruction
	{
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction[][][] s_caches;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x14")]
		internal readonly bool _hasResult;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x15")]
		internal readonly bool _hasValue;

		[Token(Token = "0x1700015C")]
		public override Instruction[] Cache
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x2753C54", Offset = "0x274FC54", VA = "0x2753C54", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015D")]
		public override string InstructionName
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x2753ED8", Offset = "0x274FED8", VA = "0x2753ED8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x2753F18", Offset = "0x274FF18", VA = "0x2753F18", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015F")]
		public override int ProducedStack
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x2753F20", Offset = "0x274FF20", VA = "0x2753F20", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x2753E7C", Offset = "0x274FE7C", VA = "0x2753E7C")]
		internal BranchInstruction()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2753EA0", Offset = "0x274FEA0", VA = "0x2753EA0")]
		public BranchInstruction(bool hasResult, bool hasValue)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2753F28", Offset = "0x274FF28", VA = "0x2753F28", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000ED")]
	internal abstract class IndexedBranchInstruction : Instruction
	{
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x10")]
		internal readonly int _labelIndex;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2753F30", Offset = "0x274FF30", VA = "0x2753F30")]
		public IndexedBranchInstruction(int labelIndex)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x2753F58", Offset = "0x274FF58", VA = "0x2753F58")]
		public RuntimeLabel GetLabel(InterpretedFrame frame)
		{
			return default(RuntimeLabel);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x2753FA0", Offset = "0x274FFA0", VA = "0x2753FA0", Slot = "10")]
		public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects)
		{
			return null;
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x275407C", Offset = "0x275007C", VA = "0x275407C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000EE")]
	internal sealed class GotoInstruction : IndexedBranchInstruction
	{
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x0")]
		private static readonly GotoInstruction[] s_cache;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x14")]
		private readonly bool _hasResult;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x15")]
		private readonly bool _hasValue;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x16")]
		private readonly bool _labelTargetGetsValue;

		[Token(Token = "0x17000160")]
		public override string InstructionName
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x2754110", Offset = "0x2750110", VA = "0x2754110", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000161")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x2754150", Offset = "0x2750150", VA = "0x2754150", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000162")]
		public override int ProducedStack
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x2754158", Offset = "0x2750158", VA = "0x2754158", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x2754160", Offset = "0x2750160", VA = "0x2754160")]
		private GotoInstruction(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x27541A8", Offset = "0x27501A8", VA = "0x27541A8")]
		internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x2754310", Offset = "0x2750310", VA = "0x2754310", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000EF")]
	internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
	{
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x14")]
		private readonly bool _hasFinally;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x18")]
		private TryCatchFinallyHandler _tryHandler;

		[Token(Token = "0x17000163")]
		internal TryCatchFinallyHandler Handler
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x2754448", Offset = "0x2750448", VA = "0x2754448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000164")]
		public override int ProducedContinuations
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x2754450", Offset = "0x2750450", VA = "0x2754450", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000165")]
		public override string InstructionName
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x2754A44", Offset = "0x2750A44", VA = "0x2754A44", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2754440", Offset = "0x2750440", VA = "0x2754440")]
		internal void SetTryHandler(TryCatchFinallyHandler tryHandler)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x2754458", Offset = "0x2750458", VA = "0x2754458")]
		private EnterTryCatchFinallyInstruction(int targetIndex, bool hasFinally)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x2754488", Offset = "0x2750488", VA = "0x2754488")]
		internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x27544EC", Offset = "0x27504EC", VA = "0x27544EC")]
		internal static EnterTryCatchFinallyInstruction CreateTryCatch()
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x275454C", Offset = "0x275054C", VA = "0x275454C", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2754AB0", Offset = "0x2750AB0", VA = "0x2754AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000F0")]
	internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction
	{
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x18")]
		private TryFaultHandler _tryHandler;

		[Token(Token = "0x17000166")]
		public override string InstructionName
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x2754B78", Offset = "0x2750B78", VA = "0x2754B78", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000167")]
		public override int ProducedContinuations
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x2754BB8", Offset = "0x2750BB8", VA = "0x2754BB8", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000168")]
		internal TryFaultHandler Handler
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x2754BC0", Offset = "0x2750BC0", VA = "0x2754BC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x2754B50", Offset = "0x2750B50", VA = "0x2754B50")]
		internal EnterTryFaultInstruction(int targetIndex)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2754BC8", Offset = "0x2750BC8", VA = "0x2754BC8")]
		internal void SetTryHandler(TryFaultHandler tryHandler)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2754BD0", Offset = "0x2750BD0", VA = "0x2754BD0", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F1")]
	internal sealed class EnterFinallyInstruction : IndexedBranchInstruction
	{
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly EnterFinallyInstruction[] s_cache;

		[Token(Token = "0x17000169")]
		public override string InstructionName
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x2754DF4", Offset = "0x2750DF4", VA = "0x2754DF4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016A")]
		public override int ProducedStack
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x2754E34", Offset = "0x2750E34", VA = "0x2754E34", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016B")]
		public override int ConsumedContinuations
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x2754E3C", Offset = "0x2750E3C", VA = "0x2754E3C", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2754DCC", Offset = "0x2750DCC", VA = "0x2754DCC")]
		private EnterFinallyInstruction(int labelIndex)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2754E44", Offset = "0x2750E44", VA = "0x2754E44")]
		internal static EnterFinallyInstruction Create(int labelIndex)
		{
			return null;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x2754F38", Offset = "0x2750F38", VA = "0x2754F38", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F2")]
	internal sealed class LeaveFinallyInstruction : Instruction
	{
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Instruction Instance;

		[Token(Token = "0x1700016C")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x2755014", Offset = "0x2751014", VA = "0x2755014", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016D")]
		public override string InstructionName
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x275501C", Offset = "0x275101C", VA = "0x275501C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x275500C", Offset = "0x275100C", VA = "0x275500C")]
		private LeaveFinallyInstruction()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x275505C", Offset = "0x275105C", VA = "0x275505C", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F3")]
	internal sealed class EnterFaultInstruction : IndexedBranchInstruction
	{
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly EnterFaultInstruction[] s_cache;

		[Token(Token = "0x1700016E")]
		public override string InstructionName
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x2755128", Offset = "0x2751128", VA = "0x2755128", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016F")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x2755168", Offset = "0x2751168", VA = "0x2755168", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x2755100", Offset = "0x2751100", VA = "0x2755100")]
		private EnterFaultInstruction(int labelIndex)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x2755170", Offset = "0x2751170", VA = "0x2755170")]
		internal static EnterFaultInstruction Create(int labelIndex)
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x2755264", Offset = "0x2751264", VA = "0x2755264", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F4")]
	internal sealed class LeaveFaultInstruction : Instruction
	{
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Instruction Instance;

		[Token(Token = "0x17000170")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x275531C", Offset = "0x275131C", VA = "0x275531C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000171")]
		public override int ConsumedContinuations
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x2755324", Offset = "0x2751324", VA = "0x2755324", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000172")]
		public override string InstructionName
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x275532C", Offset = "0x275132C", VA = "0x275532C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x2755314", Offset = "0x2751314", VA = "0x2755314")]
		private LeaveFaultInstruction()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x275536C", Offset = "0x275136C", VA = "0x275536C", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F5")]
	internal sealed class EnterExceptionFilterInstruction : Instruction
	{
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly EnterExceptionFilterInstruction Instance;

		[Token(Token = "0x17000173")]
		public override string InstructionName
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x27553F4", Offset = "0x27513F4", VA = "0x27553F4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000174")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x2755434", Offset = "0x2751434", VA = "0x2755434", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x27553EC", Offset = "0x27513EC", VA = "0x27553EC")]
		private EnterExceptionFilterInstruction()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x275543C", Offset = "0x275143C", VA = "0x275543C", Slot = "8")]
		[ExcludeFromCodeCoverage]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F6")]
	internal sealed class LeaveExceptionFilterInstruction : Instruction
	{
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly LeaveExceptionFilterInstruction Instance;

		[Token(Token = "0x17000175")]
		public override string InstructionName
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x27554A8", Offset = "0x27514A8", VA = "0x27554A8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000176")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x27554E8", Offset = "0x27514E8", VA = "0x27554E8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x27554A0", Offset = "0x27514A0", VA = "0x27554A0")]
		private LeaveExceptionFilterInstruction()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x27554F0", Offset = "0x27514F0", VA = "0x27554F0", Slot = "8")]
		[ExcludeFromCodeCoverage]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F7")]
	internal sealed class EnterExceptionHandlerInstruction : Instruction
	{
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly EnterExceptionHandlerInstruction Void;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly EnterExceptionHandlerInstruction NonVoid;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool _hasValue;

		[Token(Token = "0x17000177")]
		public override string InstructionName
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x275557C", Offset = "0x275157C", VA = "0x275557C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000178")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x27555BC", Offset = "0x27515BC", VA = "0x27555BC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000179")]
		public override int ProducedStack
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x27555C4", Offset = "0x27515C4", VA = "0x27555C4", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2755554", Offset = "0x2751554", VA = "0x2755554")]
		private EnterExceptionHandlerInstruction(bool hasValue)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x27555CC", Offset = "0x27515CC", VA = "0x27555CC", Slot = "8")]
		[ExcludeFromCodeCoverage]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F8")]
	internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
	{
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LeaveExceptionHandlerInstruction[] s_cache;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x14")]
		private readonly bool _hasValue;

		[Token(Token = "0x1700017A")]
		public override string InstructionName
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x275568C", Offset = "0x275168C", VA = "0x275568C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017B")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x27556CC", Offset = "0x27516CC", VA = "0x27556CC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700017C")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x27556D4", Offset = "0x27516D4", VA = "0x27556D4", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x275565C", Offset = "0x275165C", VA = "0x275565C")]
		private LeaveExceptionHandlerInstruction(int labelIndex, bool hasValue)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x27556DC", Offset = "0x27516DC", VA = "0x27556DC")]
		internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x27557F8", Offset = "0x27517F8", VA = "0x27557F8", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F9")]
	internal sealed class ThrowInstruction : Instruction
	{
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly ThrowInstruction Throw;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly ThrowInstruction VoidThrow;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly ThrowInstruction Rethrow;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly ThrowInstruction VoidRethrow;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool _hasResult;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x11")]
		private readonly bool _rethrow;

		[Token(Token = "0x1700017D")]
		public override string InstructionName
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x27558B4", Offset = "0x27518B4", VA = "0x27558B4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017E")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x27558F4", Offset = "0x27518F4", VA = "0x27558F4", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700017F")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x27558FC", Offset = "0x27518FC", VA = "0x27558FC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2755884", Offset = "0x2751884", VA = "0x2755884")]
		private ThrowInstruction(bool hasResult, bool isRethrow)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x2755904", Offset = "0x2751904", VA = "0x2755904", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x275598C", Offset = "0x275198C", VA = "0x275598C")]
		private static Exception WrapThrownObject(object thrown)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FA")]
	internal sealed class IntSwitchInstruction<T> : Instruction
	{
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<T, int> _cases;

		[Token(Token = "0x17000180")]
		public override string InstructionName
		{
			[Token(Token = "0x600062E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000181")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600062F")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600062D")]
		internal IntSwitchInstruction(Dictionary<T, int> cases)
		{
		}

		[Token(Token = "0x6000630")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000FB")]
	internal sealed class StringSwitchInstruction : Instruction
	{
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, int> _cases;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x18")]
		private readonly StrongBox<int> _nullCase;

		[Token(Token = "0x17000182")]
		public override string InstructionName
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x2755B2C", Offset = "0x2751B2C", VA = "0x2755B2C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x2755B6C", Offset = "0x2751B6C", VA = "0x2755B6C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x2755B00", Offset = "0x2751B00", VA = "0x2755B00")]
		internal StringSwitchInstruction(Dictionary<string, int> cases, StrongBox<int> nullCase)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2755B74", Offset = "0x2751B74", VA = "0x2755B74", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000FC")]
	internal abstract class DecrementInstruction : Instruction
	{
		[Token(Token = "0x20000FD")]
		private sealed class DecrementInt16 : DecrementInstruction
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x2756074", Offset = "0x2752074", VA = "0x2756074", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x2756034", Offset = "0x2752034", VA = "0x2756034")]
			public DecrementInt16()
			{
			}
		}

		[Token(Token = "0x20000FE")]
		private sealed class DecrementInt32 : DecrementInstruction
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x2756118", Offset = "0x2752118", VA = "0x2756118", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x275603C", Offset = "0x275203C", VA = "0x275603C")]
			public DecrementInt32()
			{
			}
		}

		[Token(Token = "0x20000FF")]
		private sealed class DecrementInt64 : DecrementInstruction
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x27561BC", Offset = "0x27521BC", VA = "0x27561BC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x2756044", Offset = "0x2752044", VA = "0x2756044")]
			public DecrementInt64()
			{
			}
		}

		[Token(Token = "0x2000100")]
		private sealed class DecrementUInt16 : DecrementInstruction
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x2756270", Offset = "0x2752270", VA = "0x2756270", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x275604C", Offset = "0x275204C", VA = "0x275604C")]
			public DecrementUInt16()
			{
			}
		}

		[Token(Token = "0x2000101")]
		private sealed class DecrementUInt32 : DecrementInstruction
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x2756314", Offset = "0x2752314", VA = "0x2756314", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x2756054", Offset = "0x2752054", VA = "0x2756054")]
			public DecrementUInt32()
			{
			}
		}

		[Token(Token = "0x2000102")]
		private sealed class DecrementUInt64 : DecrementInstruction
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x27563C8", Offset = "0x27523C8", VA = "0x27563C8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x275605C", Offset = "0x275205C", VA = "0x275605C")]
			public DecrementUInt64()
			{
			}
		}

		[Token(Token = "0x2000103")]
		private sealed class DecrementSingle : DecrementInstruction
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x275647C", Offset = "0x275247C", VA = "0x275647C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x2756064", Offset = "0x2752064", VA = "0x2756064")]
			public DecrementSingle()
			{
			}
		}

		[Token(Token = "0x2000104")]
		private sealed class DecrementDouble : DecrementInstruction
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x2756530", Offset = "0x2752530", VA = "0x2756530", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x275606C", Offset = "0x275206C", VA = "0x275606C")]
			public DecrementDouble()
			{
			}
		}

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_UInt16;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_UInt32;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt64;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_Single;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_Double;

		[Token(Token = "0x17000184")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x2755C40", Offset = "0x2751C40", VA = "0x2755C40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000185")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x2755C48", Offset = "0x2751C48", VA = "0x2755C48", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000186")]
		public override string InstructionName
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x2755C50", Offset = "0x2751C50", VA = "0x2755C50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x2755C90", Offset = "0x2751C90", VA = "0x2755C90")]
		private DecrementInstruction()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x2755C98", Offset = "0x2751C98", VA = "0x2755C98")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000105")]
	internal sealed class DefaultValueInstruction : Instruction
	{
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _type;

		[Token(Token = "0x17000187")]
		public override int ProducedStack
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x275660C", Offset = "0x275260C", VA = "0x275660C", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000188")]
		public override string InstructionName
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x2756614", Offset = "0x2752614", VA = "0x2756614", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x27565E4", Offset = "0x27525E4", VA = "0x27565E4")]
		internal DefaultValueInstruction(Type type)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2756654", Offset = "0x2752654", VA = "0x2756654", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x275668C", Offset = "0x275268C", VA = "0x275668C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000106")]
	internal abstract class DivInstruction : Instruction
	{
		[Token(Token = "0x2000107")]
		private sealed class DivInt16 : DivInstruction
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x2756B2C", Offset = "0x2752B2C", VA = "0x2756B2C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x2756AEC", Offset = "0x2752AEC", VA = "0x2756AEC")]
			public DivInt16()
			{
			}
		}

		[Token(Token = "0x2000108")]
		private sealed class DivInt32 : DivInstruction
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x2756C70", Offset = "0x2752C70", VA = "0x2756C70", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x2756AF4", Offset = "0x2752AF4", VA = "0x2756AF4")]
			public DivInt32()
			{
			}
		}

		[Token(Token = "0x2000109")]
		private sealed class DivInt64 : DivInstruction
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x2756DA4", Offset = "0x2752DA4", VA = "0x2756DA4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x2756AFC", Offset = "0x2752AFC", VA = "0x2756AFC")]
			public DivInt64()
			{
			}
		}

		[Token(Token = "0x200010A")]
		private sealed class DivUInt16 : DivInstruction
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x2756EE8", Offset = "0x2752EE8", VA = "0x2756EE8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x2756B04", Offset = "0x2752B04", VA = "0x2756B04")]
			public DivUInt16()
			{
			}
		}

		[Token(Token = "0x200010B")]
		private sealed class DivUInt32 : DivInstruction
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x275702C", Offset = "0x275302C", VA = "0x275702C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x2756B0C", Offset = "0x2752B0C", VA = "0x2756B0C")]
			public DivUInt32()
			{
			}
		}

		[Token(Token = "0x200010C")]
		private sealed class DivUInt64 : DivInstruction
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x2757170", Offset = "0x2753170", VA = "0x2757170", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x2756B14", Offset = "0x2752B14", VA = "0x2756B14")]
			public DivUInt64()
			{
			}
		}

		[Token(Token = "0x200010D")]
		private sealed class DivSingle : DivInstruction
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x27572B4", Offset = "0x27532B4", VA = "0x27572B4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x2756B1C", Offset = "0x2752B1C", VA = "0x2756B1C")]
			public DivSingle()
			{
			}
		}

		[Token(Token = "0x200010E")]
		private sealed class DivDouble : DivInstruction
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x27573F8", Offset = "0x27533F8", VA = "0x27573F8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x2756B24", Offset = "0x2752B24", VA = "0x2756B24")]
			public DivDouble()
			{
			}
		}

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_UInt16;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_UInt32;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt64;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_Single;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_Double;

		[Token(Token = "0x17000189")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x27566F8", Offset = "0x27526F8", VA = "0x27566F8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700018A")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x2756700", Offset = "0x2752700", VA = "0x2756700", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700018B")]
		public override string InstructionName
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x2756708", Offset = "0x2752708", VA = "0x2756708", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x2756748", Offset = "0x2752748", VA = "0x2756748")]
		private DivInstruction()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x2756750", Offset = "0x2752750", VA = "0x2756750")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200010F")]
	internal abstract class EqualInstruction : Instruction
	{
		[Token(Token = "0x2000110")]
		private sealed class EqualBoolean : EqualInstruction
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x2757E84", Offset = "0x2753E84", VA = "0x2757E84", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x2757E1C", Offset = "0x2753E1C", VA = "0x2757E1C")]
			public EqualBoolean()
			{
			}
		}

		[Token(Token = "0x2000111")]
		private sealed class EqualSByte : EqualInstruction
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x2757F64", Offset = "0x2753F64", VA = "0x2757F64", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x2757E24", Offset = "0x2753E24", VA = "0x2757E24")]
			public EqualSByte()
			{
			}
		}

		[Token(Token = "0x2000112")]
		private sealed class EqualInt16 : EqualInstruction
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x2758044", Offset = "0x2754044", VA = "0x2758044", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x2757E2C", Offset = "0x2753E2C", VA = "0x2757E2C")]
			public EqualInt16()
			{
			}
		}

		[Token(Token = "0x2000113")]
		private sealed class EqualChar : EqualInstruction
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x2758124", Offset = "0x2754124", VA = "0x2758124", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x2757E34", Offset = "0x2753E34", VA = "0x2757E34")]
			public EqualChar()
			{
			}
		}

		[Token(Token = "0x2000114")]
		private sealed class EqualInt32 : EqualInstruction
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x2758204", Offset = "0x2754204", VA = "0x2758204", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x2757E3C", Offset = "0x2753E3C", VA = "0x2757E3C")]
			public EqualInt32()
			{
			}
		}

		[Token(Token = "0x2000115")]
		private sealed class EqualInt64 : EqualInstruction
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x27582E4", Offset = "0x27542E4", VA = "0x27582E4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x2757E44", Offset = "0x2753E44", VA = "0x2757E44")]
			public EqualInt64()
			{
			}
		}

		[Token(Token = "0x2000116")]
		private sealed class EqualByte : EqualInstruction
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x27583C4", Offset = "0x27543C4", VA = "0x27583C4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x2757E4C", Offset = "0x2753E4C", VA = "0x2757E4C")]
			public EqualByte()
			{
			}
		}

		[Token(Token = "0x2000117")]
		private sealed class EqualUInt16 : EqualInstruction
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x27584A4", Offset = "0x27544A4", VA = "0x27584A4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x2757E54", Offset = "0x2753E54", VA = "0x2757E54")]
			public EqualUInt16()
			{
			}
		}

		[Token(Token = "0x2000118")]
		private sealed class EqualUInt32 : EqualInstruction
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x2758584", Offset = "0x2754584", VA = "0x2758584", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x2757E5C", Offset = "0x2753E5C", VA = "0x2757E5C")]
			public EqualUInt32()
			{
			}
		}

		[Token(Token = "0x2000119")]
		private sealed class EqualUInt64 : EqualInstruction
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x2758664", Offset = "0x2754664", VA = "0x2758664", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x2757E64", Offset = "0x2753E64", VA = "0x2757E64")]
			public EqualUInt64()
			{
			}
		}

		[Token(Token = "0x200011A")]
		private sealed class EqualSingle : EqualInstruction
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x2758744", Offset = "0x2754744", VA = "0x2758744", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x2757E6C", Offset = "0x2753E6C", VA = "0x2757E6C")]
			public EqualSingle()
			{
			}
		}

		[Token(Token = "0x200011B")]
		private sealed class EqualDouble : EqualInstruction
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x275882C", Offset = "0x275482C", VA = "0x275882C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x2757E74", Offset = "0x2753E74", VA = "0x2757E74")]
			public EqualDouble()
			{
			}
		}

		[Token(Token = "0x200011C")]
		private sealed class EqualReference : EqualInstruction
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x2758914", Offset = "0x2754914", VA = "0x2758914", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x2757E7C", Offset = "0x2753E7C", VA = "0x2757E7C")]
			public EqualReference()
			{
			}
		}

		[Token(Token = "0x200011D")]
		private sealed class EqualBooleanLiftedToNull : EqualInstruction
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x2758968", Offset = "0x2754968", VA = "0x2758968", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x2757DBC", Offset = "0x2753DBC", VA = "0x2757DBC")]
			public EqualBooleanLiftedToNull()
			{
			}
		}

		[Token(Token = "0x200011E")]
		private sealed class EqualSByteLiftedToNull : EqualInstruction
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x2758A50", Offset = "0x2754A50", VA = "0x2758A50", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x2757DC4", Offset = "0x2753DC4", VA = "0x2757DC4")]
			public EqualSByteLiftedToNull()
			{
			}
		}

		[Token(Token = "0x200011F")]
		private sealed class EqualInt16LiftedToNull : EqualInstruction
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x2758B38", Offset = "0x2754B38", VA = "0x2758B38", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x2757DCC", Offset = "0x2753DCC", VA = "0x2757DCC")]
			public EqualInt16LiftedToNull()
			{
			}
		}

		[Token(Token = "0x2000120")]
		private sealed class EqualCharLiftedToNull : EqualInstruction
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x2758C20", Offset = "0x2754C20", VA = "0x2758C20", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x2757DD4", Offset = "0x2753DD4", VA = "0x2757DD4")]
			public EqualCharLiftedToNull()
			{
			}
		}

		[Token(Token = "0x2000121")]
		private sealed class EqualInt32LiftedToNull : EqualInstruction
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x2758D08", Offset = "0x2754D08", VA = "0x2758D08", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x2757DDC", Offset = "0x2753DDC", VA = "0x2757DDC")]
			public EqualInt32LiftedToNull()
			{
			}
		}

		[Token(Token = "0x2000122")]
		private sealed class EqualInt64LiftedToNull : EqualInstruction
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x2758DF0", Offset = "0x2754DF0", VA = "0x2758DF0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x2757DE4", Offset = "0x2753DE4", VA = "0x2757DE4")]
			public EqualInt64LiftedToNull()
			{
			}
		}

		[Token(Token = "0x2000123")]
		private sealed class EqualByteLiftedToNull : EqualInstruction
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x2758ED8", Offset = "0x2754ED8", VA = "0x2758ED8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x2757DEC", Offset = "0x2753DEC", VA = "0x2757DEC")]
			public EqualByteLiftedToNull()
			{
			}
		}

		[Token(Token = "0x2000124")]
		private sealed class EqualUInt16LiftedToNull : EqualInstruction
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x2758FC0", Offset = "0x2754FC0", VA = "0x2758FC0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x2757DF4", Offset = "0x2753DF4", VA = "0x2757DF4")]
			public EqualUInt16LiftedToNull()
			{
			}
		}

		[Token(Token = "0x2000125")]
		private sealed class EqualUInt32LiftedToNull : EqualInstruction
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x27590A8", Offset = "0x27550A8", VA = "0x27590A8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x2757DFC", Offset = "0x2753DFC", VA = "0x2757DFC")]
			public EqualUInt32LiftedToNull()
			{
			}
		}

		[Token(Token = "0x2000126")]
		private sealed class EqualUInt64LiftedToNull : EqualInstruction
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x2759190", Offset = "0x2755190", VA = "0x2759190", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x2757E04", Offset = "0x2753E04", VA = "0x2757E04")]
			public EqualUInt64LiftedToNull()
			{
			}
		}

		[Token(Token = "0x2000127")]
		private sealed class EqualSingleLiftedToNull : EqualInstruction
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x2759278", Offset = "0x2755278", VA = "0x2759278", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x2757E0C", Offset = "0x2753E0C", VA = "0x2757E0C")]
			public EqualSingleLiftedToNull()
			{
			}
		}

		[Token(Token = "0x2000128")]
		private sealed class EqualDoubleLiftedToNull : EqualInstruction
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x2759368", Offset = "0x2755368", VA = "0x2759368", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x2757E14", Offset = "0x2753E14", VA = "0x2757E14")]
			public EqualDoubleLiftedToNull()
			{
			}
		}

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_reference;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Boolean;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_SByte;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int16;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Char;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_Int32;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_Int64;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_Byte;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x40")]
		private static Instruction s_UInt16;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x48")]
		private static Instruction s_UInt32;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x50")]
		private static Instruction s_UInt64;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x58")]
		private static Instruction s_Single;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x60")]
		private static Instruction s_Double;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x68")]
		private static Instruction s_BooleanLiftedToNull;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x70")]
		private static Instruction s_SByteLiftedToNull;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x78")]
		private static Instruction s_Int16LiftedToNull;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x80")]
		private static Instruction s_CharLiftedToNull;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x88")]
		private static Instruction s_Int32LiftedToNull;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x90")]
		private static Instruction s_Int64LiftedToNull;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x98")]
		private static Instruction s_ByteLiftedToNull;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0xA0")]
		private static Instruction s_UInt16LiftedToNull;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0xA8")]
		private static Instruction s_UInt32LiftedToNull;

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0xB0")]
		private static Instruction s_UInt64LiftedToNull;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0xB8")]
		private static Instruction s_SingleLiftedToNull;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0xC0")]
		private static Instruction s_DoubleLiftedToNull;

		[Token(Token = "0x1700018C")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x275753C", Offset = "0x275353C", VA = "0x275753C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700018D")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x2757544", Offset = "0x2753544", VA = "0x2757544", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700018E")]
		public override string InstructionName
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x275754C", Offset = "0x275354C", VA = "0x275754C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x275758C", Offset = "0x275358C", VA = "0x275758C")]
		private EqualInstruction()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x2757594", Offset = "0x2753594", VA = "0x2757594")]
		public static Instruction Create(Type type, bool liftedToNull)
		{
			return null;
		}
	}
	[Token(Token = "0x2000129")]
	internal abstract class ExclusiveOrInstruction : Instruction
	{
		[Token(Token = "0x200012A")]
		private sealed class ExclusiveOrSByte : ExclusiveOrInstruction
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x27598C4", Offset = "0x27558C4", VA = "0x27598C4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x27598A4", Offset = "0x27558A4", VA = "0x27598A4")]
			public ExclusiveOrSByte()
			{
			}
		}

		[Token(Token = "0x200012B")]
		private sealed class ExclusiveOrInt16 : ExclusiveOrInstruction
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x27599B8", Offset = "0x27559B8", VA = "0x27599B8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x27598AC", Offset = "0x27558AC", VA = "0x27598AC")]
			public ExclusiveOrInt16()
			{
			}
		}

		[Token(Token = "0x200012C")]
		private sealed class ExclusiveOrInt32 : ExclusiveOrInstruction
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x2759AAC", Offset = "0x2755AAC", VA = "0x2759AAC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x27598B4", Offset = "0x27558B4", VA = "0x27598B4")]
			public ExclusiveOrInt32()
			{
			}
		}

		[Token(Token = "0x200012D")]
		private sealed class ExclusiveOrInt64 : ExclusiveOrInstruction
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x2759BA0", Offset = "0x2755BA0", VA = "0x2759BA0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x27598BC", Offset = "0x27558BC", VA = "0x27598BC")]
			public ExclusiveOrInt64()
			{
			}
		}

		[Token(Token = "0x200012E")]
		private sealed class ExclusiveOrByte : ExclusiveOrInstruction
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x2759CA4", Offset = "0x2755CA4", VA = "0x2759CA4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x2759EEC", Offset = "0x2755EEC", VA = "0x2759EEC")]
			public ExclusiveOrByte()
			{
			}
		}

		[Token(Token = "0x200012F")]
		private sealed class ExclusiveOrUInt16 : ExclusiveOrInstruction
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x2759EF4", Offset = "0x2755EF4", VA = "0x2759EF4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x275A094", Offset = "0x2756094", VA = "0x275A094")]
			public ExclusiveOrUInt16()
			{
			}
		}

		[Token(Token = "0x2000130")]
		private sealed class ExclusiveOrUInt32 : ExclusiveOrInstruction
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x275A09C", Offset = "0x275609C", VA = "0x275A09C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x275A194", Offset = "0x2756194", VA = "0x275A194")]
			public ExclusiveOrUInt32()
			{
			}
		}

		[Token(Token = "0x2000131")]
		private sealed class ExclusiveOrUInt64 : ExclusiveOrInstruction
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x275A19C", Offset = "0x275619C", VA = "0x275A19C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x275A294", Offset = "0x2756294", VA = "0x275A294")]
			public ExclusiveOrUInt64()
			{
			}
		}

		[Token(Token = "0x2000132")]
		private sealed class ExclusiveOrBoolean : ExclusiveOrInstruction
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x275A29C", Offset = "0x275629C", VA = "0x275A29C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x275A45C", Offset = "0x275645C", VA = "0x275A45C")]
			public ExclusiveOrBoolean()
			{
			}
		}

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_SByte;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int16;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int32;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int64;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Byte;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt16;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_UInt32;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_UInt64;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x40")]
		private static Instruction s_Boolean;

		[Token(Token = "0x1700018F")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x2759458", Offset = "0x2755458", VA = "0x2759458", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000190")]
		public override int ProducedStack
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x2759460", Offset = "0x2755460", VA = "0x2759460", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000191")]
		public override string InstructionName
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x2759468", Offset = "0x2755468", VA = "0x2759468", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x27594A8", Offset = "0x27554A8", VA = "0x27594A8")]
		private ExclusiveOrInstruction()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x27594B0", Offset = "0x27554B0", VA = "0x27594B0")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000133")]
	internal abstract class FieldInstruction : Instruction
	{
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x10")]
		protected readonly FieldInfo _field;

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x275A464", Offset = "0x2756464", VA = "0x275A464")]
		public FieldInstruction(FieldInfo field)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x275A494", Offset = "0x2756494", VA = "0x275A494", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000134")]
	internal sealed class LoadStaticFieldInstruction : FieldInstruction
	{
		[Token(Token = "0x17000192")]
		public override string InstructionName
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x275A55C", Offset = "0x275655C", VA = "0x275A55C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000193")]
		public override int ProducedStack
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x275A59C", Offset = "0x275659C", VA = "0x275A59C", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x275A534", Offset = "0x2756534", VA = "0x275A534")]
		public LoadStaticFieldInstruction(FieldInfo field)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x275A5A4", Offset = "0x27565A4", VA = "0x275A5A4", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000135")]
	internal sealed class LoadFieldInstruction : FieldInstruction
	{
		[Token(Token = "0x17000194")]
		public override string InstructionName
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x275A610", Offset = "0x2756610", VA = "0x275A610", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000195")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x275A650", Offset = "0x2756650", VA = "0x275A650", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000196")]
		public override int ProducedStack
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x275A658", Offset = "0x2756658", VA = "0x275A658", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x275A5E8", Offset = "0x27565E8", VA = "0x275A5E8")]
		public LoadFieldInstruction(FieldInfo field)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x275A660", Offset = "0x2756660", VA = "0x275A660", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000136")]
	internal sealed class StoreFieldInstruction : FieldInstruction
	{
		[Token(Token = "0x17000197")]
		public override string InstructionName
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x275A6F4", Offset = "0x27566F4", VA = "0x275A6F4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000198")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x275A734", Offset = "0x2756734", VA = "0x275A734", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x275A6CC", Offset = "0x27566CC", VA = "0x275A6CC")]
		public StoreFieldInstruction(FieldInfo field)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x275A73C", Offset = "0x275673C", VA = "0x275A73C", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000137")]
	internal sealed class StoreStaticFieldInstruction : FieldInstruction
	{
		[Token(Token = "0x17000199")]
		public override string InstructionName
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x275A7BC", Offset = "0x27567BC", VA = "0x275A7BC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019A")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x275A7FC", Offset = "0x27567FC", VA = "0x275A7FC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x275A794", Offset = "0x2756794", VA = "0x275A794")]
		public StoreStaticFieldInstruction(FieldInfo field)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x275A804", Offset = "0x2756804", VA = "0x275A804", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000138")]
	internal abstract class GreaterThanInstruction : Instruction
	{
		[Token(Token = "0x2000139")]
		private sealed class GreaterThanSByte : GreaterThanInstruction
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x275B2F4", Offset = "0x27572F4", VA = "0x275B2F4")]
			public GreaterThanSByte(object nullValue)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x275B4AC", Offset = "0x27574AC", VA = "0x275B4AC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200013A")]
		private sealed class GreaterThanInt16 : GreaterThanInstruction
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x275B31C", Offset = "0x275731C", VA = "0x275B31C")]
			public GreaterThanInt16(object nullValue)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x275B588", Offset = "0x2757588", VA = "0x275B588", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200013B")]
		private sealed class GreaterThanChar : GreaterThanInstruction
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x275B344", Offset = "0x2757344", VA = "0x275B344")]
			public GreaterThanChar(object nullValue)
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x275B664", Offset = "0x2757664", VA = "0x275B664", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200013C")]
		private sealed class GreaterThanInt32 : GreaterThanInstruction
		{
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x275B36C", Offset = "0x275736C", VA = "0x275B36C")]
			public GreaterThanInt32(object nullValue)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x275B740", Offset = "0x2757740", VA = "0x275B740", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200013D")]
		private sealed class GreaterThanInt64 : GreaterThanInstruction
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x275B394", Offset = "0x2757394", VA = "0x275B394")]
			public GreaterThanInt64(object nullValue)
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x275B81C", Offset = "0x275781C", VA = "0x275B81C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200013E")]
		private sealed class GreaterThanByte : GreaterThanInstruction
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x275B3BC", Offset = "0x27573BC", VA = "0x275B3BC")]
			public GreaterThanByte(object nullValue)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x275B8F8", Offset = "0x27578F8", VA = "0x275B8F8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200013F")]
		private sealed class GreaterThanUInt16 : GreaterThanInstruction
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x275B3E4", Offset = "0x27573E4", VA = "0x275B3E4")]
			public GreaterThanUInt16(object nullValue)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x275B9D4", Offset = "0x27579D4", VA = "0x275B9D4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000140")]
		private sealed class GreaterThanUInt32 : GreaterThanInstruction
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x275B40C", Offset = "0x275740C", VA = "0x275B40C")]
			public GreaterThanUInt32(object nullValue)
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x275BAB0", Offset = "0x2757AB0", VA = "0x275BAB0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000141")]
		private sealed class GreaterThanUInt64 : GreaterThanInstruction
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x275B434", Offset = "0x2757434", VA = "0x275B434")]
			public GreaterThanUInt64(object nullValue)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x275BB8C", Offset = "0x2757B8C", VA = "0x275BB8C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000142")]
		private sealed class GreaterThanSingle : GreaterThanInstruction
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x275B45C", Offset = "0x275745C", VA = "0x275B45C")]
			public GreaterThanSingle(object nullValue)
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x275BC68", Offset = "0x2757C68", VA = "0x275BC68", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000143")]
		private sealed class GreaterThanDouble : GreaterThanInstruction
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x275B484", Offset = "0x2757484", VA = "0x275B484")]
			public GreaterThanDouble(object nullValue)
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x275BD4C", Offset = "0x2757D4C", VA = "0x275BD4C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _nullValue;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_SByte;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int16;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Char;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int32;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Int64;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_Byte;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_UInt16;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_UInt32;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x40")]
		private static Instruction s_UInt64;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x48")]
		private static Instruction s_Single;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x50")]
		private static Instruction s_Double;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x58")]
		private static Instruction s_liftedToNullSByte;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x60")]
		private static Instruction s_liftedToNullInt16;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x68")]
		private static Instruction s_liftedToNullChar;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x70")]
		private static Instruction s_liftedToNullInt32;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x78")]
		private static Instruction s_liftedToNullInt64;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x80")]
		private static Instruction s_liftedToNullByte;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x88")]
		private static Instruction s_liftedToNullUInt16;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x90")]
		private static Instruction s_liftedToNullUInt32;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x98")]
		private static Instruction s_liftedToNullUInt64;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0xA0")]
		private static Instruction s_liftedToNullSingle;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0xA8")]
		private static Instruction s_liftedToNullDouble;

		[Token(Token = "0x1700019B")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x275A844", Offset = "0x2756844", VA = "0x275A844", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700019C")]
		public override int ProducedStack
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x275A84C", Offset = "0x275684C", VA = "0x275A84C", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700019D")]
		public override string InstructionName
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x275A854", Offset = "0x2756854", VA = "0x275A854", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x275A894", Offset = "0x2756894", VA = "0x275A894")]
		private GreaterThanInstruction(object nullValue)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x275A8BC", Offset = "0x27568BC", VA = "0x275A8BC")]
		public static Instruction Create(Type type, bool liftedToNull = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000144")]
	internal abstract class GreaterThanOrEqualInstruction : Instruction
	{
		[Token(Token = "0x2000145")]
		private sealed class GreaterThanOrEqualSByte : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x275C8E0", Offset = "0x27588E0", VA = "0x275C8E0")]
			public GreaterThanOrEqualSByte(object nullValue)
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x275CA98", Offset = "0x2758A98", VA = "0x275CA98", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000146")]
		private sealed class GreaterThanOrEqualInt16 : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x275C908", Offset = "0x2758908", VA = "0x275C908")]
			public GreaterThanOrEqualInt16(object nullValue)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x275CB74", Offset = "0x2758B74", VA = "0x275CB74", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000147")]
		private sealed class GreaterThanOrEqualChar : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x275C930", Offset = "0x2758930", VA = "0x275C930")]
			public GreaterThanOrEqualChar(object nullValue)
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x275CC50", Offset = "0x2758C50", VA = "0x275CC50", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000148")]
		private sealed class GreaterThanOrEqualInt32 : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x275C958", Offset = "0x2758958", VA = "0x275C958")]
			public GreaterThanOrEqualInt32(object nullValue)
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x275CD2C", Offset = "0x2758D2C", VA = "0x275CD2C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000149")]
		private sealed class GreaterThanOrEqualInt64 : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x275C980", Offset = "0x2758980", VA = "0x275C980")]
			public GreaterThanOrEqualInt64(object nullValue)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x275CE08", Offset = "0x2758E08", VA = "0x275CE08", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200014A")]
		private sealed class GreaterThanOrEqualByte : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x275C9A8", Offset = "0x27589A8", VA = "0x275C9A8")]
			public GreaterThanOrEqualByte(object nullValue)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x275CEE4", Offset = "0x2758EE4", VA = "0x275CEE4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200014B")]
		private sealed class GreaterThanOrEqualUInt16 : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x275C9D0", Offset = "0x27589D0", VA = "0x275C9D0")]
			public GreaterThanOrEqualUInt16(object nullValue)
			{
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x275CFC0", Offset = "0x2758FC0", VA = "0x275CFC0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200014C")]
		private sealed class GreaterThanOrEqualUInt32 : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x275C9F8", Offset = "0x27589F8", VA = "0x275C9F8")]
			public GreaterThanOrEqualUInt32(object nullValue)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x275D09C", Offset = "0x275909C", VA = "0x275D09C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200014D")]
		private sealed class GreaterThanOrEqualUInt64 : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x275CA20", Offset = "0x2758A20", VA = "0x275CA20")]
			public GreaterThanOrEqualUInt64(object nullValue)
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x275D178", Offset = "0x2759178", VA = "0x275D178", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200014E")]
		private sealed class GreaterThanOrEqualSingle : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x275CA48", Offset = "0x2758A48", VA = "0x275CA48")]
			public GreaterThanOrEqualSingle(object nullValue)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x275D254", Offset = "0x2759254", VA = "0x275D254", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200014F")]
		private sealed class GreaterThanOrEqualDouble : GreaterThanOrEqualInstruction
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x275CA70", Offset = "0x2758A70", VA = "0x275CA70")]
			public GreaterThanOrEqualDouble(object nullValue)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x275D338", Offset = "0x2759338", VA = "0x275D338", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _nullValue;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_SByte;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int16;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Char;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int32;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Int64;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_Byte;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_UInt16;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_UInt32;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x40")]
		private static Instruction s_UInt64;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x48")]
		private static Instruction s_Single;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x50")]
		private static Instruction s_Double;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x58")]
		private static Instruction s_liftedToNullSByte;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x60")]
		private static Instruction s_liftedToNullInt16;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x68")]
		private static Instruction s_liftedToNullChar;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x70")]
		private static Instruction s_liftedToNullInt32;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x78")]
		private static Instruction s_liftedToNullInt64;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x80")]
		private static Instruction s_liftedToNullByte;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x88")]
		private static Instruction s_liftedToNullUInt16;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x90")]
		private static Instruction s_liftedToNullUInt32;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x98")]
		private static Instruction s_liftedToNullUInt64;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0xA0")]
		private static Instruction s_liftedToNullSingle;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0xA8")]
		private static Instruction s_liftedToNullDouble;

		[Token(Token = "0x1700019E")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x275BE30", Offset = "0x2757E30", VA = "0x275BE30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700019F")]
		public override int ProducedStack
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x275BE38", Offset = "0x2757E38", VA = "0x275BE38", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A0")]
		public override string InstructionName
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x275BE40", Offset = "0x2757E40", VA = "0x275BE40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x275BE80", Offset = "0x2757E80", VA = "0x275BE80")]
		private GreaterThanOrEqualInstruction(object nullValue)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x275BEA8", Offset = "0x2757EA8", VA = "0x275BEA8")]
		public static Instruction Create(Type type, bool liftedToNull = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000150")]
	internal abstract class IncrementInstruction : Instruction
	{
		[Token(Token = "0x2000151")]
		private sealed class IncrementInt16 : IncrementInstruction
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x275D850", Offset = "0x2759850", VA = "0x275D850", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x275D810", Offset = "0x2759810", VA = "0x275D810")]
			public IncrementInt16()
			{
			}
		}

		[Token(Token = "0x2000152")]
		private sealed class IncrementInt32 : IncrementInstruction
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x275D9A4", Offset = "0x27599A4", VA = "0x275D9A4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x275D818", Offset = "0x2759818", VA = "0x275D818")]
			public IncrementInt32()
			{
			}
		}

		[Token(Token = "0x2000153")]
		private sealed class IncrementInt64 : IncrementInstruction
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x275DAB4", Offset = "0x2759AB4", VA = "0x275DAB4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x275D820", Offset = "0x2759820", VA = "0x275D820")]
			public IncrementInt64()
			{
			}
		}

		[Token(Token = "0x2000154")]
		private sealed class IncrementUInt16 : IncrementInstruction
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x275DB60", Offset = "0x2759B60", VA = "0x275DB60", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x275D828", Offset = "0x2759828", VA = "0x275D828")]
			public IncrementUInt16()
			{
			}
		}

		[Token(Token = "0x2000155")]
		private sealed class IncrementUInt32 : IncrementInstruction
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x275DBF8", Offset = "0x2759BF8", VA = "0x275DBF8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x275D830", Offset = "0x2759830", VA = "0x275D830")]
			public IncrementUInt32()
			{
			}
		}

		[Token(Token = "0x2000156")]
		private sealed class IncrementUInt64 : IncrementInstruction
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x275DCA4", Offset = "0x2759CA4", VA = "0x275DCA4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x275D838", Offset = "0x2759838", VA = "0x275D838")]
			public IncrementUInt64()
			{
			}
		}

		[Token(Token = "0x2000157")]
		private sealed class IncrementSingle : IncrementInstruction
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x275DD50", Offset = "0x2759D50", VA = "0x275DD50", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x275D840", Offset = "0x2759840", VA = "0x275D840")]
			public IncrementSingle()
			{
			}
		}

		[Token(Token = "0x2000158")]
		private sealed class IncrementDouble : IncrementInstruction
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x275DDFC", Offset = "0x2759DFC", VA = "0x275DDFC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x275D848", Offset = "0x2759848", VA = "0x275D848")]
			public IncrementDouble()
			{
			}
		}

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_UInt16;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_UInt32;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt64;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_Single;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_Double;

		[Token(Token = "0x170001A1")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x275D41C", Offset = "0x275941C", VA = "0x275D41C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A2")]
		public override int ProducedStack
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x275D424", Offset = "0x2759424", VA = "0x275D424", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A3")]
		public override string InstructionName
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x275D42C", Offset = "0x275942C", VA = "0x275D42C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x275D46C", Offset = "0x275946C", VA = "0x275D46C")]
		private IncrementInstruction()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x275D474", Offset = "0x2759474", VA = "0x275D474")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000159")]
	internal abstract class Instruction
	{
		[Token(Token = "0x170001A4")]
		public virtual int ConsumedStack
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x275DEA8", Offset = "0x2759EA8", VA = "0x275DEA8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A5")]
		public virtual int ProducedStack
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x275DEB0", Offset = "0x2759EB0", VA = "0x275DEB0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A6")]
		public virtual int ConsumedContinuations
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x275DEB8", Offset = "0x2759EB8", VA = "0x275DEB8", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A7")]
		public virtual int ProducedContinuations
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x275DEC0", Offset = "0x2759EC0", VA = "0x275DEC0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A8")]
		public int StackBalance
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x275DEC8", Offset = "0x2759EC8", VA = "0x275DEC8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A9")]
		public int ContinuationsBalance
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x275DF04", Offset = "0x2759F04", VA = "0x275DF04")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001AA")]
		public abstract string InstructionName
		{
			[Token(Token = "0x6000717")]
			get;
		}

		[Token(Token = "0x6000716")]
		public abstract int Run(InterpretedFrame frame);

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x275DF40", Offset = "0x2759F40", VA = "0x275DF40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x275DF98", Offset = "0x2759F98", VA = "0x275DF98", Slot = "10")]
		public virtual string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects)
		{
			return null;
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x275A6BC", Offset = "0x27566BC", VA = "0x275A6BC")]
		protected static void NullCheck(object o)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x275A48C", Offset = "0x275648C", VA = "0x275A48C")]
		protected Instruction()
		{
		}
	}
	[Token(Token = "0x200015A")]
	[DebuggerTypeProxy(typeof(DebugView))]
	internal readonly struct InstructionArray
	{
		[Token(Token = "0x200015B")]
		internal sealed class DebugView
		{
			[Token(Token = "0x400029F")]
			[FieldOffset(Offset = "0x10")]
			private readonly InstructionArray _array;

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x275DFB4", Offset = "0x2759FB4", VA = "0x275DFB4")]
			public DebugView(InstructionArray array)
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x275E060", Offset = "0x275A060", VA = "0x275E060")]
			public InstructionList.DebugView.InstructionView[] GetInstructionViews(bool includeDebugCookies = false)
			{
				return null;
			}
		}

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x0")]
		internal readonly int MaxStackDepth;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x4")]
		internal readonly int MaxContinuationDepth;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x8")]
		internal readonly Instruction[] Instructions;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x10")]
		internal readonly object[] Objects;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x18")]
		internal readonly RuntimeLabel[] Labels;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x20")]
		internal readonly List<KeyValuePair<int, object>> DebugCookies;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x275DFA4", Offset = "0x2759FA4", VA = "0x275DFA4")]
		internal InstructionArray(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, object[] objects, RuntimeLabel[] labels, List<KeyValuePair<int, object>> debugCookies)
		{
		}
	}
	[Token(Token = "0x200015C")]
	[DebuggerTypeProxy(typeof(DebugView))]
	internal sealed class InstructionList
	{
		[Token(Token = "0x200015D")]
		internal sealed class DebugView
		{
			[Token(Token = "0x200015E")]
			[DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
			internal readonly struct InstructionView
			{
				[Token(Token = "0x40002B9")]
				[FieldOffset(Offset = "0x0")]
				private readonly int _index;

				[Token(Token = "0x40002BA")]
				[FieldOffset(Offset = "0x4")]
				private readonly int _stackDepth;

				[Token(Token = "0x40002BB")]
				[FieldOffset(Offset = "0x8")]
				private readonly int _continuationsDepth;

				[Token(Token = "0x40002BC")]
				[FieldOffset(Offset = "0x10")]
				private readonly string _name;

				[Token(Token = "0x40002BD")]
				[FieldOffset(Offset = "0x18")]
				private readonly Instruction _instruction;

				[Token(Token = "0x6000793")]
				[Address(RVA = "0x2764088", Offset = "0x2760088", VA = "0x2764088")]
				internal string GetValue()
				{
					return null;
				}

				[Token(Token = "0x6000794")]
				[Address(RVA = "0x2764078", Offset = "0x2760078", VA = "0x2764078")]
				public InstructionView(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth)
				{
				}
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x275E100", Offset = "0x275A100", VA = "0x275E100")]
			internal static InstructionView[] GetInstructionViews(IReadOnlyList<Instruction> instructions, IReadOnlyList<object> objects, Func<int, int> labelIndexer, IReadOnlyList<KeyValuePair<int, object>> debugCookies)
			{
				return null;
			}
		}

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Instruction> _instructions;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x18")]
		private List<object> _objects;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x20")]
		private int _currentStackDepth;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x24")]
		private int _maxStackDepth;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x28")]
		private int _currentContinuationsDepth;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x2C")]
		private int _maxContinuationDepth;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x30")]
		private int _runtimeLabelCount;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x38")]
		private List<BranchLabel> _labels;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x40")]
		private List<KeyValuePair<int, object>> _debugCookies;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_null;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_true;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_false;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction[] s_Ints;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction[] s_loadObjectCached;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction[] s_loadLocal;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction[] s_loadLocalBoxed;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction[] s_loadLocalFromClosure;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x40")]
		private static Instruction[] s_loadLocalFromClosureBoxed;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x48")]
		private static Instruction[] s_assignLocal;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x50")]
		private static Instruction[] s_storeLocal;

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x58")]
		private static Instruction[] s_assignLocalBoxed;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x60")]
		private static Instruction[] s_storeLocalBoxed;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x68")]
		private static Instruction[] s_assignLocalToClosure;

		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x70")]
		private static readonly Dictionary<FieldInfo, Instruction> s_loadFields;

		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x78")]
		private static readonly RuntimeLabel[] s_emptyRuntimeLabels;

		[Token(Token = "0x170001AB")]
		public int Count
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x275E960", Offset = "0x275A960", VA = "0x275E960")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001AC")]
		public int CurrentStackDepth
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x275E9A8", Offset = "0x275A9A8", VA = "0x275E9A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001AD")]
		public int CurrentContinuationsDepth
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x275E9B0", Offset = "0x275A9B0", VA = "0x275E9B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x275E6FC", Offset = "0x275A6FC", VA = "0x275E6FC")]
		public void Emit(Instruction instruction)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x275E7A4", Offset = "0x275A7A4", VA = "0x275E7A4")]
		private void UpdateStackDepth(Instruction instruction)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x275E850", Offset = "0x275A850", VA = "0x275E850")]
		public void UnEmit()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x275E9B8", Offset = "0x275A9B8", VA = "0x275E9B8")]
		internal Instruction GetInstruction(int index)
		{
			return null;
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x275EA10", Offset = "0x275AA10", VA = "0x275EA10")]
		public InstructionArray ToArray()
		{
			return default(InstructionArray);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x275ED1C", Offset = "0x275AD1C", VA = "0x275ED1C")]
		public void EmitLoad(object value)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x275F254", Offset = "0x275B254", VA = "0x275F254")]
		public void EmitLoad(bool value)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x275ED24", Offset = "0x275AD24", VA = "0x275ED24")]
		public void EmitLoad(object value, Type type)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x275F3C8", Offset = "0x275B3C8", VA = "0x275F3C8")]
		public void EmitDup()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x275F428", Offset = "0x275B428", VA = "0x275F428")]
		public void EmitPop()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x275F488", Offset = "0x275B488", VA = "0x275F488")]
		internal void SwitchToBoxed(int index, int instructionIndex)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x275F5AC", Offset = "0x275B5AC", VA = "0x275F5AC")]
		public void EmitLoadLocal(int index)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x275F788", Offset = "0x275B788", VA = "0x275F788")]
		public void EmitLoadLocalBoxed(int index)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x275F7F4", Offset = "0x275B7F4", VA = "0x275F7F4")]
		internal static Instruction LoadLocalBoxed(int index)
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x275F9C0", Offset = "0x275B9C0", VA = "0x275F9C0")]
		public void EmitLoadLocalFromClosure(int index)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x275FB9C", Offset = "0x275BB9C", VA = "0x275FB9C")]
		public void EmitLoadLocalFromClosureBoxed(int index)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x275FD78", Offset = "0x275BD78", VA = "0x275FD78")]
		public void EmitAssignLocal(int index)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x275FF54", Offset = "0x275BF54", VA = "0x275FF54")]
		public void EmitStoreLocal(int index)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x2760130", Offset = "0x275C130", VA = "0x2760130")]
		public void EmitAssignLocalBoxed(int index)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x276019C", Offset = "0x275C19C", VA = "0x276019C")]
		internal static Instruction AssignLocalBoxed(int index)
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2760368", Offset = "0x275C368", VA = "0x2760368")]
		public void EmitStoreLocalBoxed(int index)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x27603D4", Offset = "0x275C3D4", VA = "0x27603D4")]
		internal static Instruction StoreLocalBoxed(int index)
		{
			return null;
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x27605A0", Offset = "0x275C5A0", VA = "0x27605A0")]
		public void EmitAssignLocalToClosure(int index)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x276077C", Offset = "0x275C77C", VA = "0x276077C")]
		public void EmitStoreLocalToClosure(int index)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x2760794", Offset = "0x275C794", VA = "0x2760794")]
		public void EmitInitializeLocal(int index, Type type)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x27608F8", Offset = "0x275C8F8", VA = "0x27608F8")]
		internal void EmitInitializeParameter(int index)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x2760964", Offset = "0x275C964", VA = "0x2760964")]
		internal static Instruction Parameter(int index)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x27609C0", Offset = "0x275C9C0", VA = "0x27609C0")]
		internal static Instruction ParameterBox(int index)
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x276089C", Offset = "0x275C89C", VA = "0x276089C")]
		internal static Instruction InitReference(int index)
		{
			return null;
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x2760A1C", Offset = "0x275CA1C", VA = "0x2760A1C")]
		internal static Instruction InitImmutableRefBox(int index)
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x2760A78", Offset = "0x275CA78", VA = "0x2760A78")]
		public void EmitNewRuntimeVariables(int count)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x2760AE4", Offset = "0x275CAE4", VA = "0x2760AE4")]
		public void EmitGetArrayItem()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x2760B44", Offset = "0x275CB44", VA = "0x2760B44")]
		public void EmitSetArrayItem()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x2760BA4", Offset = "0x275CBA4", VA = "0x2760BA4")]
		public void EmitNewArray(Type elementType)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x2760C10", Offset = "0x275CC10", VA = "0x2760C10")]
		public void EmitNewArrayBounds(Type elementType, int rank)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x2760C84", Offset = "0x275CC84", VA = "0x2760C84")]
		public void EmitNewArrayInit(Type elementType, int elementCount)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x2760CF8", Offset = "0x275CCF8", VA = "0x2760CF8")]
		public void EmitAdd(Type type, bool @checked)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x2760D30", Offset = "0x275CD30", VA = "0x2760D30")]
		public void EmitSub(Type type, bool @checked)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x2760D68", Offset = "0x275CD68", VA = "0x2760D68")]
		public void EmitMul(Type type, bool @checked)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x2760DA0", Offset = "0x275CDA0", VA = "0x2760DA0")]
		public void EmitDiv(Type type)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x2760DC4", Offset = "0x275CDC4", VA = "0x2760DC4")]
		public void EmitModulo(Type type)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x2760DE8", Offset = "0x275CDE8", VA = "0x2760DE8")]
		public void EmitExclusiveOr(Type type)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2760E0C", Offset = "0x275CE0C", VA = "0x2760E0C")]
		public void EmitAnd(Type type)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x2760E30", Offset = "0x275CE30", VA = "0x2760E30")]
		public void EmitOr(Type type)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x2760E54", Offset = "0x275CE54", VA = "0x2760E54")]
		public void EmitLeftShift(Type type)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2761210", Offset = "0x275D210", VA = "0x2761210")]
		public void EmitRightShift(Type type)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x2761234", Offset = "0x275D234", VA = "0x2761234")]
		public void EmitEqual(Type type, bool liftedToNull = false)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x276125C", Offset = "0x275D25C", VA = "0x276125C")]
		public void EmitNotEqual(Type type, bool liftedToNull = false)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x2761284", Offset = "0x275D284", VA = "0x2761284")]
		public void EmitLessThan(Type type, bool liftedToNull)
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x2761CE0", Offset = "0x275DCE0", VA = "0x2761CE0")]
		public void EmitLessThanOrEqual(Type type, bool liftedToNull)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x276273C", Offset = "0x275E73C", VA = "0x276273C")]
		public void EmitGreaterThan(Type type, bool liftedToNull)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x2762760", Offset = "0x275E760", VA = "0x2762760")]
		public void EmitGreaterThanOrEqual(Type type, bool liftedToNull)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x2762784", Offset = "0x275E784", VA = "0x2762784")]
		public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x2762808", Offset = "0x275E808", VA = "0x2762808")]
		public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x276288C", Offset = "0x275E88C", VA = "0x276288C")]
		public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x2762900", Offset = "0x275E900", VA = "0x2762900")]
		public void EmitCast(Type toType)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x2762924", Offset = "0x275E924", VA = "0x2762924")]
		public void EmitCastToEnum(Type toType)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x2762990", Offset = "0x275E990", VA = "0x2762990")]
		public void EmitCastReferenceToEnum(Type toType)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x27629FC", Offset = "0x275E9FC", VA = "0x27629FC")]
		public void EmitNot(Type type)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x2762A20", Offset = "0x275EA20", VA = "0x2762A20")]
		public void EmitDefaultValue(Type type)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x2762A8C", Offset = "0x275EA8C", VA = "0x2762A8C")]
		public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x2762B08", Offset = "0x275EB08", VA = "0x2762B08")]
		public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x2762B8C", Offset = "0x275EB8C", VA = "0x2762B8C")]
		internal void EmitCreateDelegate(LightDelegateCreator creator)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x2762BF8", Offset = "0x275EBF8", VA = "0x2762BF8")]
		public void EmitTypeEquals()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x2762C58", Offset = "0x275EC58", VA = "0x2762C58")]
		public void EmitArrayLength()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2762CB8", Offset = "0x275ECB8", VA = "0x2762CB8")]
		public void EmitNegate(Type type)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x2762CDC", Offset = "0x275ECDC", VA = "0x2762CDC")]
		public void EmitNegateChecked(Type type)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x2762D00", Offset = "0x275ED00", VA = "0x2762D00")]
		public void EmitIncrement(Type type)
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2762D20", Offset = "0x275ED20", VA = "0x2762D20")]
		public void EmitDecrement(Type type)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2762D44", Offset = "0x275ED44", VA = "0x2762D44")]
		public void EmitTypeIs(Type type)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2762DB0", Offset = "0x275EDB0", VA = "0x2762DB0")]
		public void EmitTypeAs(Type type)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2762E1C", Offset = "0x275EE1C", VA = "0x2762E1C")]
		public void EmitLoadField(FieldInfo field)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2762E38", Offset = "0x275EE38", VA = "0x2762E38")]
		private Instruction GetLoadField(FieldInfo field)
		{
			return null;
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2763064", Offset = "0x275F064", VA = "0x2763064")]
		public void EmitStoreField(FieldInfo field)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2763100", Offset = "0x275F100", VA = "0x2763100")]
		public void EmitCall(MethodInfo method)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x2763180", Offset = "0x275F180", VA = "0x2763180")]
		public void EmitCall(MethodInfo method, ParameterInfo[] parameters)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x27631A8", Offset = "0x275F1A8", VA = "0x27631A8")]
		public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x2763258", Offset = "0x275F258", VA = "0x2763258")]
		public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x275EAD0", Offset = "0x275AAD0", VA = "0x275EAD0")]
		private RuntimeLabel[] BuildRuntimeLabels()
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x27632AC", Offset = "0x275F2AC", VA = "0x27632AC")]
		public BranchLabel MakeLabel()
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x27633BC", Offset = "0x275F3BC", VA = "0x27633BC")]
		internal void FixupBranch(int branchIndex, int offset)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x27634A0", Offset = "0x275F4A0", VA = "0x27634A0")]
		private int EnsureLabelIndex(BranchLabel label)
		{
			return default(int);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x27634EC", Offset = "0x275F4EC", VA = "0x27634EC")]
		public int MarkRuntimeLabel()
		{
			return default(int);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2763528", Offset = "0x275F528", VA = "0x2763528")]
		public void MarkLabel(BranchLabel label)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2763548", Offset = "0x275F548", VA = "0x2763548")]
		public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x27635EC", Offset = "0x275F5EC", VA = "0x27635EC")]
		private void EmitBranch(OffsetInstruction instruction, BranchLabel label)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x276362C", Offset = "0x275F62C", VA = "0x276362C")]
		public void EmitBranch(BranchLabel label)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2763698", Offset = "0x275F698", VA = "0x2763698")]
		public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x276371C", Offset = "0x275F71C", VA = "0x276371C")]
		public void EmitCoalescingBranch(BranchLabel leftNotNull)
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2763788", Offset = "0x275F788", VA = "0x2763788")]
		public void EmitBranchTrue(BranchLabel elseLabel)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x27637F4", Offset = "0x275F7F4", VA = "0x27637F4")]
		public void EmitBranchFalse(BranchLabel elseLabel)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2763860", Offset = "0x275F860", VA = "0x2763860")]
		public void EmitThrow()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x27638C0", Offset = "0x275F8C0", VA = "0x27638C0")]
		public void EmitThrowVoid()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x2763920", Offset = "0x275F920", VA = "0x2763920")]
		public void EmitRethrow()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x2763980", Offset = "0x275F980", VA = "0x2763980")]
		public void EmitRethrowVoid()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x27639E0", Offset = "0x275F9E0", VA = "0x27639E0")]
		public void EmitEnterTryFinally(BranchLabel finallyStartLabel)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2763A04", Offset = "0x275FA04", VA = "0x2763A04")]
		public void EmitEnterTryCatch()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x2763A24", Offset = "0x275FA24", VA = "0x2763A24")]
		public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd)
		{
			return null;
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2763AAC", Offset = "0x275FAAC", VA = "0x2763AAC")]
		public void EmitEnterFinally(BranchLabel finallyStartLabel)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x2763B30", Offset = "0x275FB30", VA = "0x2763B30")]
		public void EmitLeaveFinally()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x2763B90", Offset = "0x275FB90", VA = "0x2763B90")]
		public void EmitEnterFault(BranchLabel faultStartLabel)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x2763C14", Offset = "0x275FC14", VA = "0x2763C14")]
		public void EmitLeaveFault()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x2763C74", Offset = "0x275FC74", VA = "0x2763C74")]
		public void EmitEnterExceptionFilter()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x2763CD4", Offset = "0x275FCD4", VA = "0x2763CD4")]
		public void EmitLeaveExceptionFilter()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x2763D34", Offset = "0x275FD34", VA = "0x2763D34")]
		public void EmitEnterExceptionHandlerNonVoid()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2763D94", Offset = "0x275FD94", VA = "0x2763D94")]
		public void EmitEnterExceptionHandlerVoid()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2763DF4", Offset = "0x275FDF4", VA = "0x2763DF4")]
		public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel)
		{
		}

		[Token(Token = "0x600078E")]
		public void EmitIntSwitch<T>(Dictionary<T, int> cases)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x2763E80", Offset = "0x275FE80", VA = "0x2763E80")]
		public void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x2763EF4", Offset = "0x275FEF4", VA = "0x2763EF4")]
		public InstructionList()
		{
		}
	}
	[Token(Token = "0x200015F")]
	internal sealed class InterpretedFrame
	{
		[Token(Token = "0x2000160")]
		[CompilerGenerated]
		private sealed class <GetStackTraceDebugInfo>d__29 : IEnumerable<InterpretedFrameInfo>, IEnumerable, IEnumerator<InterpretedFrameInfo>, IDisposable, IEnumerator
		{
			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x18")]
			private InterpretedFrameInfo <>2__current;

			[Token(Token = "0x40002CB")]
			[FieldOffset(Offset = "0x28")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40002CC")]
			[FieldOffset(Offset = "0x30")]
			public InterpretedFrame <>4__this;

			[Token(Token = "0x40002CD")]
			[FieldOffset(Offset = "0x38")]
			private InterpretedFrame <frame>5__2;

			[Token(Token = "0x170001B0")]
			private InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.Current
			{
				[Token(Token = "0x60007B3")]
				[Address(RVA = "0x2764D7C", Offset = "0x2760D7C", VA = "0x2764D7C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(InterpretedFrameInfo);
				}
			}

			[Token(Token = "0x170001B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B5")]
				[Address(RVA = "0x2764DC0", Offset = "0x2760DC0", VA = "0x2764DC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x2764500", Offset = "0x2760500", VA = "0x2764500")]
			[DebuggerHidden]
			public <GetStackTraceDebugInfo>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x2764CE4", Offset = "0x2760CE4", VA = "0x2764CE4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x2764CE8", Offset = "0x2760CE8", VA = "0x2764CE8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x2764D88", Offset = "0x2760D88", VA = "0x2764D88", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x2764E1C", Offset = "0x2760E1C", VA = "0x2764E1C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<InterpretedFrameInfo> System.Collections.Generic.IEnumerable<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x2764EB8", Offset = "0x2760EB8", VA = "0x2764EB8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40002BE")]
		[ThreadStatic]
		private static InterpretedFrame s_currentFrame;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x10")]
		internal readonly Interpreter Interpreter;

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x18")]
		internal InterpretedFrame _parent;

		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x20")]
		private readonly int[] _continuations;

		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x28")]
		private int _continuationIndex;

		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x2C")]
		private int _pendingContinuation;

		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x30")]
		private object _pendingValue;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x38")]
		public readonly object[] Data;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x40")]
		public readonly IStrongBox[] Closure;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x48")]
		public int StackIndex;

		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x4C")]
		public int InstructionIndex;

		[Token(Token = "0x170001AE")]
		public string Name
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x27642D0", Offset = "0x27602D0", VA = "0x27642D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AF")]
		public InterpretedFrame Parent
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x2764484", Offset = "0x2760484", VA = "0x2764484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x2764090", Offset = "0x2760090", VA = "0x2764090")]
		internal InterpretedFrame(Interpreter interpreter, IStrongBox[] closure)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x2764180", Offset = "0x2760180", VA = "0x2764180")]
		public DebugInfo GetDebugInfo(int instructionIndex)
		{
			return null;
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x2759DC4", Offset = "0x2755DC4", VA = "0x2759DC4")]
		public void Push(object value)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x275A384", Offset = "0x2756384", VA = "0x275A384")]
		public void Push(bool value)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x275DA3C", Offset = "0x2759A3C", VA = "0x275DA3C")]
		public void Push(int value)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2759E30", Offset = "0x2755E30", VA = "0x2759E30")]
		public void Push(byte value)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x27642E8", Offset = "0x27602E8", VA = "0x27642E8")]
		public void Push(sbyte value)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x275D8E8", Offset = "0x27598E8", VA = "0x275D8E8")]
		public void Push(short value)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x2759FD8", Offset = "0x2755FD8", VA = "0x2759FD8")]
		public void Push(ushort value)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2759D88", Offset = "0x2755D88", VA = "0x2759D88")]
		public object Pop()
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x27643A4", Offset = "0x27603A4", VA = "0x27643A4")]
		internal void SetStackDepth(int depth)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x27643C4", Offset = "0x27603C4", VA = "0x27643C4")]
		public object Peek()
		{
			return null;
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x27643FC", Offset = "0x27603FC", VA = "0x27643FC")]
		public void Dup()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x276448C", Offset = "0x276048C", VA = "0x276448C")]
		[IteratorStateMachine(typeof(<GetStackTraceDebugInfo>d__29))]
		public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo()
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x2764534", Offset = "0x2760534", VA = "0x2764534")]
		internal void SaveTraceToException(Exception exception)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x2764784", Offset = "0x2760784", VA = "0x2764784")]
		internal InterpretedFrame Enter()
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x27647F0", Offset = "0x27607F0", VA = "0x27647F0")]
		internal void Leave(InterpretedFrame prevFrame)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2764840", Offset = "0x2760840", VA = "0x2764840")]
		internal bool IsJumpHappened()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x2764850", Offset = "0x2760850", VA = "0x2764850")]
		public void RemoveContinuation()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x2764860", Offset = "0x2760860", VA = "0x2764860")]
		public void PushContinuation(int continuation)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x276489C", Offset = "0x276089C", VA = "0x276489C")]
		public int YieldToCurrentContinuation()
		{
			return default(int);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2764918", Offset = "0x2760918", VA = "0x2764918")]
		public int YieldToPendingContinuation()
		{
			return default(int);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2764AAC", Offset = "0x2760AAC", VA = "0x2764AAC")]
		internal void PushPendingContinuation()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2764B2C", Offset = "0x2760B2C", VA = "0x2764B2C")]
		internal void PopPendingContinuation()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2764BB0", Offset = "0x2760BB0", VA = "0x2764BB0")]
		public int Goto(int labelIndex, object value, bool gotoExceptionHandler)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000161")]
	internal sealed class Interpreter
	{
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly object NoValue;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x10")]
		private readonly InstructionArray _instructions;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x38")]
		internal readonly object[] _objects;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x40")]
		internal readonly RuntimeLabel[] _labels;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x48")]
		internal readonly DebugInfo[] _debugInfos;

		[Token(Token = "0x170001B2")]
		internal string Name
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x2764F30", Offset = "0x2760F30", VA = "0x2764F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B3")]
		internal int LocalCount
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x2764F38", Offset = "0x2760F38", VA = "0x2764F38")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B4")]
		internal int ClosureSize
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x2764F40", Offset = "0x2760F40", VA = "0x2764F40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B5")]
		internal InstructionArray Instructions
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x2764F98", Offset = "0x2760F98", VA = "0x2764F98")]
			get
			{
				return default(InstructionArray);
			}
		}

		[Token(Token = "0x170001B6")]
		internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x2764FAC", Offset = "0x2760FAC", VA = "0x2764FAC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x2764EBC", Offset = "0x2760EBC", VA = "0x2764EBC")]
		internal Interpreter(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos)
		{
		}

		[MethodImpl(8)]
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2764FB4", Offset = "0x2760FB4", VA = "0x2764FB4")]
		public void Run(InterpretedFrame frame)
		{
		}
	}
	[Token(Token = "0x2000162")]
	internal sealed class LabelInfo
	{
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x10")]
		private readonly LabelTarget _node;

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x18")]
		private BranchLabel _label;

		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x20")]
		private object _definitions;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<LabelScopeInfo> _references;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x30")]
		private bool _acrossBlockJump;

		[Token(Token = "0x170001B7")]
		private bool HasDefinitions
		{
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x276522C", Offset = "0x276122C", VA = "0x276522C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B8")]
		private bool HasMultipleDefinitions
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x2765900", Offset = "0x2761900", VA = "0x2765900")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x27650A0", Offset = "0x27610A0", VA = "0x27650A0")]
		internal LabelInfo(LabelTarget node)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x2765128", Offset = "0x2761128", VA = "0x2765128")]
		internal BranchLabel GetLabel(LightCompiler compiler)
		{
			return null;
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2765170", Offset = "0x2761170", VA = "0x2765170")]
		internal void Reference(LabelScopeInfo block)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x27654D8", Offset = "0x27614D8", VA = "0x27654D8")]
		internal void Define(LabelScopeInfo block)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x276523C", Offset = "0x276123C", VA = "0x276523C")]
		private void ValidateJump(LabelScopeInfo reference)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2765C00", Offset = "0x2761C00", VA = "0x2765C00")]
		internal void ValidateFinish()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2765140", Offset = "0x2761140", VA = "0x2765140")]
		private void EnsureLabel(LightCompiler compiler)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x276597C", Offset = "0x276197C", VA = "0x276597C")]
		private bool DefinedIn(LabelScopeInfo scope)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x2765A30", Offset = "0x2761A30", VA = "0x2765A30")]
		private LabelScopeInfo FirstDefinition()
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x2765728", Offset = "0x2761728", VA = "0x2765728")]
		private void AddDefinition(LabelScopeInfo scope)
		{
		}

		[Token(Token = "0x60007CC")]
		internal static T CommonNode<T>(T first, T second, Func<T, T> parent) where T : class
		{
			return null;
		}
	}
	[Token(Token = "0x2000164")]
	internal enum LabelScopeKind
	{
		[Token(Token = "0x40002DE")]
		Statement,
		[Token(Token = "0x40002DF")]
		Block,
		[Token(Token = "0x40002E0")]
		Switch,
		[Token(Token = "0x40002E1")]
		Lambda,
		[Token(Token = "0x40002E2")]
		Try,
		[Token(Token = "0x40002E3")]
		Catch,
		[Token(Token = "0x40002E4")]
		Finally,
		[Token(Token = "0x40002E5")]
		Filter,
		[Token(Token = "0x40002E6")]
		Expression
	}
	[Token(Token = "0x2000165")]
	internal sealed class LabelScopeInfo
	{
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x10")]
		private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x18")]
		internal readonly LabelScopeKind Kind;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x20")]
		internal readonly LabelScopeInfo Parent;

		[Token(Token = "0x170001B9")]
		internal bool CanJumpInto
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x2765BF0", Offset = "0x2761BF0", VA = "0x2765BF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x2765D04", Offset = "0x2761D04", VA = "0x2765D04")]
		internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x27656C8", Offset = "0x27616C8", VA = "0x27656C8")]
		internal bool ContainsTarget(LabelTarget target)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x2765D34", Offset = "0x2761D34", VA = "0x2765D34")]
		internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x2765850", Offset = "0x2761850", VA = "0x2765850")]
		internal void AddLabelInfo(LabelTarget target, LabelInfo info)
		{
		}
	}
	[Token(Token = "0x2000166")]
	internal abstract class LeftShiftInstruction : Instruction
	{
		[Token(Token = "0x2000167")]
		private sealed class LeftShiftSByte : LeftShiftInstruction
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x2765E44", Offset = "0x2761E44", VA = "0x2765E44", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x2765E04", Offset = "0x2761E04", VA = "0x2765E04")]
			public LeftShiftSByte()
			{
			}
		}

		[Token(Token = "0x2000168")]
		private sealed class LeftShiftInt16 : LeftShiftInstruction
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x2765F2C", Offset = "0x2761F2C", VA = "0x2765F2C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x2765E0C", Offset = "0x2761E0C", VA = "0x2765E0C")]
			public LeftShiftInt16()
			{
			}
		}

		[Token(Token = "0x2000169")]
		private sealed class LeftShiftInt32 : LeftShiftInstruction
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x2766014", Offset = "0x2762014", VA = "0x2766014", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x2765E14", Offset = "0x2761E14", VA = "0x2765E14")]
			public LeftShiftInt32()
			{
			}
		}

		[Token(Token = "0x200016A")]
		private sealed class LeftShiftInt64 : LeftShiftInstruction
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x27660E8", Offset = "0x27620E8", VA = "0x27660E8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x2765E1C", Offset = "0x2761E1C", VA = "0x2765E1C")]
			public LeftShiftInt64()
			{
			}
		}

		[Token(Token = "0x200016B")]
		private sealed class LeftShiftByte : LeftShiftInstruction
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x27661E8", Offset = "0x27621E8", VA = "0x27661E8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x2765E24", Offset = "0x2761E24", VA = "0x2765E24")]
			public LeftShiftByte()
			{
			}
		}

		[Token(Token = "0x200016C")]
		private sealed class LeftShiftUInt16 : LeftShiftInstruction
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x27662D0", Offset = "0x27622D0", VA = "0x27662D0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x2765E2C", Offset = "0x2761E2C", VA = "0x2765E2C")]
			public LeftShiftUInt16()
			{
			}
		}

		[Token(Token = "0x200016D")]
		private sealed class LeftShiftUInt32 : LeftShiftInstruction
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x27663B8", Offset = "0x27623B8", VA = "0x27663B8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x2765E34", Offset = "0x2761E34", VA = "0x2765E34")]
			public LeftShiftUInt32()
			{
			}
		}

		[Token(Token = "0x200016E")]
		private sealed class LeftShiftUInt64 : LeftShiftInstruction
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x27664B8", Offset = "0x27624B8", VA = "0x27664B8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x2765E3C", Offset = "0x2761E3C", VA = "0x2765E3C")]
			public LeftShiftUInt64()
			{
			}
		}

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_SByte;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int16;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int32;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int64;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Byte;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt16;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_UInt32;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_UInt64;

		[Token(Token = "0x170001BA")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x2765DAC", Offset = "0x2761DAC", VA = "0x2765DAC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001BB")]
		public override int ProducedStack
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x2765DB4", Offset = "0x2761DB4", VA = "0x2765DB4", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001BC")]
		public override string InstructionName
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x2765DBC", Offset = "0x2761DBC", VA = "0x2765DBC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x2765DFC", Offset = "0x2761DFC", VA = "0x2765DFC")]
		private LeftShiftInstruction()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x2760E74", Offset = "0x275CE74", VA = "0x2760E74")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200016F")]
	internal abstract class LessThanInstruction : Instruction
	{
		[Token(Token = "0x2000170")]
		private sealed class LessThanSByte : LessThanInstruction
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x2766630", Offset = "0x2762630", VA = "0x2766630")]
			public LessThanSByte(object nullValue)
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x27667E8", Offset = "0x27627E8", VA = "0x27667E8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000171")]
		private sealed class LessThanInt16 : LessThanInstruction
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x2766658", Offset = "0x2762658", VA = "0x2766658")]
			public LessThanInt16(object nullValue)
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x27668C4", Offset = "0x27628C4", VA = "0x27668C4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000172")]
		private sealed class LessThanChar : LessThanInstruction
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x2766680", Offset = "0x2762680", VA = "0x2766680")]
			public LessThanChar(object nullValue)
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x27669A0", Offset = "0x27629A0", VA = "0x27669A0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000173")]
		private sealed class LessThanInt32 : LessThanInstruction
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x27666A8", Offset = "0x27626A8", VA = "0x27666A8")]
			public LessThanInt32(object nullValue)
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x2766A7C", Offset = "0x2762A7C", VA = "0x2766A7C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000174")]
		private sealed class LessThanInt64 : LessThanInstruction
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x27666D0", Offset = "0x27626D0", VA = "0x27666D0")]
			public LessThanInt64(object nullValue)
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x2766B58", Offset = "0x2762B58", VA = "0x2766B58", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000175")]
		private sealed class LessThanByte : LessThanInstruction
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x27666F8", Offset = "0x27626F8", VA = "0x27666F8")]
			public LessThanByte(object nullValue)
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x2766C34", Offset = "0x2762C34", VA = "0x2766C34", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000176")]
		private sealed class LessThanUInt16 : LessThanInstruction
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x2766720", Offset = "0x2762720", VA = "0x2766720")]
			public LessThanUInt16(object nullValue)
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x2766D10", Offset = "0x2762D10", VA = "0x2766D10", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000177")]
		private sealed class LessThanUInt32 : LessThanInstruction
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x2766748", Offset = "0x2762748", VA = "0x2766748")]
			public LessThanUInt32(object nullValue)
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x2766DEC", Offset = "0x2762DEC", VA = "0x2766DEC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000178")]
		private sealed class LessThanUInt64 : LessThanInstruction
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x2766770", Offset = "0x2762770", VA = "0x2766770")]
			public LessThanUInt64(object nullValue)
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x2766EC8", Offset = "0x2762EC8", VA = "0x2766EC8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000179")]
		private sealed class LessThanSingle : LessThanInstruction
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x2766798", Offset = "0x2762798", VA = "0x2766798")]
			public LessThanSingle(object nullValue)
			{
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x2766FA4", Offset = "0x2762FA4", VA = "0x2766FA4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200017A")]
		private sealed class LessThanDouble : LessThanInstruction
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x27667C0", Offset = "0x27627C0", VA = "0x27667C0")]
			public LessThanDouble(object nullValue)
			{
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x2767088", Offset = "0x2763088", VA = "0x2767088", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _nullValue;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_SByte;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int16;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Char;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int32;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Int64;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_Byte;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_UInt16;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_UInt32;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x40")]
		private static Instruction s_UInt64;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x48")]
		private static Instruction s_Single;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x50")]
		private static Instruction s_Double;

		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x58")]
		private static Instruction s_liftedToNullSByte;

		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x60")]
		private static Instruction s_liftedToNullInt16;

		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x68")]
		private static Instruction s_liftedToNullChar;

		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x70")]
		private static Instruction s_liftedToNullInt32;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x78")]
		private static Instruction s_liftedToNullInt64;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x80")]
		private static Instruction s_liftedToNullByte;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x88")]
		private static Instruction s_liftedToNullUInt16;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x90")]
		private static Instruction s_liftedToNullUInt32;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x98")]
		private static Instruction s_liftedToNullUInt64;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0xA0")]
		private static Instruction s_liftedToNullSingle;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0xA8")]
		private static Instruction s_liftedToNullDouble;

		[Token(Token = "0x170001BD")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x27665B8", Offset = "0x27625B8", VA = "0x27665B8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001BE")]
		public override int ProducedStack
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x27665C0", Offset = "0x27625C0", VA = "0x27665C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001BF")]
		public override string InstructionName
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x27665C8", Offset = "0x27625C8", VA = "0x27665C8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x2766608", Offset = "0x2762608", VA = "0x2766608")]
		private LessThanInstruction(object nullValue)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x27612A8", Offset = "0x275D2A8", VA = "0x27612A8")]
		public static Instruction Create(Type type, bool liftedToNull = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200017B")]
	internal abstract class LessThanOrEqualInstruction : Instruction
	{
		[Token(Token = "0x200017C")]
		private sealed class LessThanOrEqualSByte : LessThanOrEqualInstruction
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x27671E4", Offset = "0x27631E4", VA = "0x27671E4")]
			public LessThanOrEqualSByte(object nullValue)
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x276739C", Offset = "0x276339C", VA = "0x276739C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200017D")]
		private sealed class LessThanOrEqualInt16 : LessThanOrEqualInstruction
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x276720C", Offset = "0x276320C", VA = "0x276720C")]
			public LessThanOrEqualInt16(object nullValue)
			{
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x2767478", Offset = "0x2763478", VA = "0x2767478", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200017E")]
		private sealed class LessThanOrEqualChar : LessThanOrEqualInstruction
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x2767234", Offset = "0x2763234", VA = "0x2767234")]
			public LessThanOrEqualChar(object nullValue)
			{
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x2767554", Offset = "0x2763554", VA = "0x2767554", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200017F")]
		private sealed class LessThanOrEqualInt32 : LessThanOrEqualInstruction
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x276725C", Offset = "0x276325C", VA = "0x276725C")]
			public LessThanOrEqualInt32(object nullValue)
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x2767630", Offset = "0x2763630", VA = "0x2767630", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000180")]
		private sealed class LessThanOrEqualInt64 : LessThanOrEqualInstruction
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x2767284", Offset = "0x2763284", VA = "0x2767284")]
			public LessThanOrEqualInt64(object nullValue)
			{
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x276770C", Offset = "0x276370C", VA = "0x276770C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000181")]
		private sealed class LessThanOrEqualByte : LessThanOrEqualInstruction
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x27672AC", Offset = "0x27632AC", VA = "0x27672AC")]
			public LessThanOrEqualByte(object nullValue)
			{
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0x27677E8", Offset = "0x27637E8", VA = "0x27677E8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000182")]
		private sealed class LessThanOrEqualUInt16 : LessThanOrEqualInstruction
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x27672D4", Offset = "0x27632D4", VA = "0x27672D4")]
			public LessThanOrEqualUInt16(object nullValue)
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x27678C4", Offset = "0x27638C4", VA = "0x27678C4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000183")]
		private sealed class LessThanOrEqualUInt32 : LessThanOrEqualInstruction
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x27672FC", Offset = "0x27632FC", VA = "0x27672FC")]
			public LessThanOrEqualUInt32(object nullValue)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x27679A0", Offset = "0x27639A0", VA = "0x27679A0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000184")]
		private sealed class LessThanOrEqualUInt64 : LessThanOrEqualInstruction
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x2767324", Offset = "0x2763324", VA = "0x2767324")]
			public LessThanOrEqualUInt64(object nullValue)
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x2767A7C", Offset = "0x2763A7C", VA = "0x2767A7C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000185")]
		private sealed class LessThanOrEqualSingle : LessThanOrEqualInstruction
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x276734C", Offset = "0x276334C", VA = "0x276734C")]
			public LessThanOrEqualSingle(object nullValue)
			{
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x2767B58", Offset = "0x2763B58", VA = "0x2767B58", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000186")]
		private sealed class LessThanOrEqualDouble : LessThanOrEqualInstruction
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x2767374", Offset = "0x2763374", VA = "0x2767374")]
			public LessThanOrEqualDouble(object nullValue)
			{
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x2767C3C", Offset = "0x2763C3C", VA = "0x2767C3C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _nullValue;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_SByte;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int16;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Char;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int32;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Int64;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_Byte;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_UInt16;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_UInt32;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x40")]
		private static Instruction s_UInt64;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x48")]
		private static Instruction s_Single;

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x50")]
		private static Instruction s_Double;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x58")]
		private static Instruction s_liftedToNullSByte;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x60")]
		private static Instruction s_liftedToNullInt16;

		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x68")]
		private static Instruction s_liftedToNullChar;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x70")]
		private static Instruction s_liftedToNullInt32;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x78")]
		private static Instruction s_liftedToNullInt64;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x80")]
		private static Instruction s_liftedToNullByte;

		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x88")]
		private static Instruction s_liftedToNullUInt16;

		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x90")]
		private static Instruction s_liftedToNullUInt32;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x98")]
		private static Instruction s_liftedToNullUInt64;

		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0xA0")]
		private static Instruction s_liftedToNullSingle;

		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0xA8")]
		private static Instruction s_liftedToNullDouble;

		[Token(Token = "0x170001C0")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x276716C", Offset = "0x276316C", VA = "0x276716C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001C1")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x2767174", Offset = "0x2763174", VA = "0x2767174", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001C2")]
		public override string InstructionName
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x276717C", Offset = "0x276317C", VA = "0x276717C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x27671BC", Offset = "0x27631BC", VA = "0x27671BC")]
		private LessThanOrEqualInstruction(object nullValue)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x2761D04", Offset = "0x275DD04", VA = "0x2761D04")]
		public static Instruction Create(Type type, bool liftedToNull = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000187")]
	internal sealed class ExceptionFilter
	{
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x10")]
		public readonly int LabelIndex;

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x14")]
		public readonly int StartIndex;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x18")]
		public readonly int EndIndex;

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x2767D20", Offset = "0x2763D20", VA = "0x2767D20")]
		internal ExceptionFilter(int labelIndex, int start, int end)
		{
		}
	}
	[Token(Token = "0x2000188")]
	internal sealed class ExceptionHandler
	{
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _exceptionType;

		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x18")]
		public readonly int LabelIndex;

		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x1C")]
		public readonly int HandlerStartIndex;

		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x20")]
		public readonly int HandlerEndIndex;

		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x28")]
		public readonly ExceptionFilter Filter;

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2767D5C", Offset = "0x2763D5C", VA = "0x2767D5C")]
		internal ExceptionHandler(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x2767DB0", Offset = "0x2763DB0", VA = "0x2767DB0")]
		public bool Matches(Type exceptionType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x2767DD0", Offset = "0x2763DD0", VA = "0x2767DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000189")]
	internal sealed class TryCatchFinallyHandler
	{
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x10")]
		internal readonly int TryStartIndex;

		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x14")]
		internal readonly int TryEndIndex;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x18")]
		internal readonly int FinallyStartIndex;

		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x1C")]
		internal readonly int FinallyEndIndex;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x20")]
		internal readonly int GotoEndTargetIndex;

		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x28")]
		private readonly ExceptionHandler[] _handlers;

		[Token(Token = "0x170001C3")]
		internal bool IsFinallyBlockExist
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x2767ECC", Offset = "0x2763ECC", VA = "0x2767ECC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C4")]
		internal ExceptionHandler[] Handlers
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x2767EE0", Offset = "0x2763EE0", VA = "0x2767EE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C5")]
		internal bool IsCatchBlockExist
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x2767EE8", Offset = "0x2763EE8", VA = "0x2767EE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x2767EF8", Offset = "0x2763EF8", VA = "0x2767EF8")]
		internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers)
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2767F44", Offset = "0x2763F44", VA = "0x2767F44")]
		internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x2767F9C", Offset = "0x2763F9C", VA = "0x2767F9C")]
		internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException)
		{
			return default(bool);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x27680F8", Offset = "0x27640F8", VA = "0x27680F8")]
		private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200018A")]
	internal sealed class TryFaultHandler
	{
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x10")]
		internal readonly int TryStartIndex;

		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x14")]
		internal readonly int TryEndIndex;

		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x18")]
		internal readonly int FinallyStartIndex;

		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x1C")]
		internal readonly int FinallyEndIndex;

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2768304", Offset = "0x2764304", VA = "0x2768304")]
		internal TryFaultHandler(int tryStart, int tryEnd, int finallyStart, int finallyEnd)
		{
		}
	}
	[Token(Token = "0x200018B")]
	internal sealed class RethrowException : Exception
	{
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x2768344", Offset = "0x2764344", VA = "0x2768344")]
		public RethrowException()
		{
		}
	}
	[Token(Token = "0x200018C")]
	internal sealed class DebugInfo
	{
		[Token(Token = "0x200018D")]
		private class DebugInfoComparer : IComparer<DebugInfo>
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x2768648", Offset = "0x2764648", VA = "0x2768648", Slot = "4")]
			private int System.Collections.Generic.IComparer<System.Linq.Expressions.Interpreter.DebugInfo>.Compare(DebugInfo d1, DebugInfo d2)
			{
				return default(int);
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0x2768640", Offset = "0x2764640", VA = "0x2768640")]
			public DebugInfoComparer()
			{
			}
		}

		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x10")]
		public int StartLine;

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x14")]
		public int EndLine;

		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x18")]
		public int Index;

		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x20")]
		public string FileName;

		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x28")]
		public bool IsClear;

		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DebugInfoComparer s_debugComparer;

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x27641EC", Offset = "0x27601EC", VA = "0x27641EC")]
		public static DebugInfo GetMatchingDebugInfo(DebugInfo[] debugInfos, int index)
		{
			return null;
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x27683A4", Offset = "0x27643A4", VA = "0x27683A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x276839C", Offset = "0x276439C", VA = "0x276839C")]
		public DebugInfo()
		{
		}
	}
	[Token(Token = "0x200018E")]
	internal readonly struct InterpretedFrameInfo
	{
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _methodName;

		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x8")]
		private readonly DebugInfo _debugInfo;

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x2764D74", Offset = "0x2760D74", VA = "0x2764D74")]
		public InterpretedFrameInfo(string methodName, DebugInfo info)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2768674", Offset = "0x2764674", VA = "0x2768674", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200018F")]
	internal sealed class LightCompiler
	{
		[Token(Token = "0x2000190")]
		private sealed class QuoteVisitor : ExpressionVisitor
		{
			[Token(Token = "0x4000343")]
			[FieldOffset(Offset = "0x10")]
			private readonly Dictionary<ParameterExpression, int> _definedParameters;

			[Token(Token = "0x4000344")]
			[FieldOffset(Offset = "0x18")]
			public readonly HashSet<ParameterExpression> _hoistedParameters;

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x2774E6C", Offset = "0x2770E6C", VA = "0x2774E6C", Slot = "21")]
			protected internal override Expression VisitParameter(ParameterExpression node)
			{
				return null;
			}

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x2774EF8", Offset = "0x2770EF8", VA = "0x2774EF8", Slot = "6")]
			protected internal override Expression VisitBlock(BlockExpression node)
			{
				return null;
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x27755EC", Offset = "0x27715EC", VA = "0x27755EC", Slot = "22")]
			protected override CatchBlock VisitCatchBlock(CatchBlock node)
			{
				return null;
			}

			[Token(Token = "0x6000895")]
			protected internal override Expression VisitLambda<T>(Expression<T> node)
			{
				return null;
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x2774F60", Offset = "0x2770F60", VA = "0x2774F60")]
			private void PushParameters(IEnumerable<ParameterExpression> parameters)
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x27752A4", Offset = "0x27712A4", VA = "0x27752A4")]
			private void PopParameters(IEnumerable<ParameterExpression> parameters)
			{
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x277571C", Offset = "0x277171C", VA = "0x277571C")]
			public QuoteVisitor()
			{
			}
		}

		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x10")]
		private readonly InstructionList _instructions;

		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalVariables _locals;

		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<DebugInfo> _debugInfos;

		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x28")]
		private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels;

		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x30")]
		private LabelScopeInfo _labelBlock;

		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x38")]
		private readonly Stack<ParameterExpression> _exceptionForRethrowStack;

		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x40")]
		private readonly LightCompiler _parent;

		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x48")]
		private readonly StackGuard _guard;

		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LocalDefinition[] s_emptyLocals;

		[Token(Token = "0x170001C6")]
		public InstructionList Instructions
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x27688E0", Offset = "0x27648E0", VA = "0x27688E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x27686EC", Offset = "0x27646EC", VA = "0x27686EC")]
		public LightCompiler()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x27688BC", Offset = "0x27648BC", VA = "0x27688BC")]
		private LightCompiler(LightCompiler parent)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x27688E8", Offset = "0x27648E8", VA = "0x27688E8")]
		public LightDelegateCreator CompileTop(LambdaExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x2768B28", Offset = "0x2764B28", VA = "0x2768B28")]
		private Interpreter MakeInterpreter(string lambdaName)
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x2768E14", Offset = "0x2764E14", VA = "0x2768E14")]
		private void CompileConstantExpression(Expression expr)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x2768EB8", Offset = "0x2764EB8", VA = "0x2768EB8")]
		private void CompileDefaultExpression(Expression expr)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x2768EEC", Offset = "0x2764EEC", VA = "0x2768EEC")]
		private void CompileDefaultExpression(Type type)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x2769010", Offset = "0x2765010", VA = "0x2769010")]
		private LocalVariable EnsureAvailableForClosure(ParameterExpression expr)
		{
			return null;
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x2769130", Offset = "0x2765130", VA = "0x2769130")]
		private LocalVariable ResolveLocal(ParameterExpression variable)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x2769180", Offset = "0x2765180", VA = "0x2769180")]
		private void CompileGetVariable(ParameterExpression variable)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x2769240", Offset = "0x2765240", VA = "0x2769240")]
		private void EmitCopyValueType(Type valueType)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x27691C0", Offset = "0x27651C0", VA = "0x27691C0")]
		private void LoadLocalNoValueTypeCopy(ParameterExpression variable)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x27692C8", Offset = "0x27652C8", VA = "0x27692C8")]
		private bool MaybeMutableValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x2769324", Offset = "0x2765324", VA = "0x2769324")]
		private void CompileGetBoxedVariable(ParameterExpression variable)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x276937C", Offset = "0x276537C", VA = "0x276937C")]
		private void CompileSetVariable(ParameterExpression variable, bool isVoid)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x2769458", Offset = "0x2765458", VA = "0x2769458")]
		private void CompileParameterExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x27694DC", Offset = "0x27654DC", VA = "0x27694DC")]
		private void CompileBlockExpression(Expression expr, bool asVoid)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x276961C", Offset = "0x276561C", VA = "0x276961C")]
		private LocalDefinition[] CompileBlockStart(BlockExpression node)
		{
			return null;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x2769A6C", Offset = "0x2765A6C", VA = "0x2769A6C")]
		private void CompileBlockEnd(LocalDefinition[] locals)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x2769C90", Offset = "0x2765C90", VA = "0x2769C90")]
		private void CompileIndexExpression(Expression expr)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x2769D64", Offset = "0x2765D64", VA = "0x2769D64")]
		private void EmitIndexGet(IndexExpression index)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2769E54", Offset = "0x2765E54", VA = "0x2769E54")]
		private void CompileIndexAssignment(BinaryExpression node, bool asVoid)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x276A0F0", Offset = "0x27660F0", VA = "0x276A0F0")]
		private void CompileMemberAssignment(BinaryExpression node, bool asVoid)
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x276A1B8", Offset = "0x27661B8", VA = "0x276A1B8")]
		private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x276A540", Offset = "0x2766540", VA = "0x276A540")]
		private void CompileVariableAssignment(BinaryExpression node, bool asVoid)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x276A5EC", Offset = "0x27665EC", VA = "0x276A5EC")]
		private void CompileAssignBinaryExpression(Expression expr, bool asVoid)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x276A738", Offset = "0x2766738", VA = "0x276A738")]
		private void CompileBinaryExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x276B620", Offset = "0x2767620", VA = "0x276B620")]
		private void CompileEqual(Expression left, Expression right, bool liftedToNull)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x276B690", Offset = "0x2767690", VA = "0x276B690")]
		private void CompileNotEqual(Expression left, Expression right, bool liftedToNull)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x276B700", Offset = "0x2767700", VA = "0x276B700")]
		private void CompileComparison(BinaryExpression node)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x276B428", Offset = "0x2767428", VA = "0x276B428")]
		private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x276B894", Offset = "0x2767894", VA = "0x276B894")]
		private void CompileConvertUnaryExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x276C84C", Offset = "0x276884C", VA = "0x276C84C")]
		private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x276CDB0", Offset = "0x2768DB0", VA = "0x276CDB0")]
		private void CompileNotExpression(UnaryExpression node)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x276CE08", Offset = "0x2768E08", VA = "0x276CE08")]
		private void CompileUnaryExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x276D0E0", Offset = "0x27690E0", VA = "0x276D0E0")]
		private void EmitUnaryMethodCall(UnaryExpression node)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x276D210", Offset = "0x2769210", VA = "0x276D210")]
		private void EmitUnaryBoolCheck(UnaryExpression node)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x276D3F4", Offset = "0x27693F4", VA = "0x276D3F4")]
		private void CompileAndAlsoBinaryExpression(Expression expr)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x276D5DC", Offset = "0x27695DC", VA = "0x276D5DC")]
		private void CompileOrElseBinaryExpression(Expression expr)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x276D47C", Offset = "0x276947C", VA = "0x276D47C")]
		private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x276D664", Offset = "0x2769664", VA = "0x276D664")]
		private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x276D7C8", Offset = "0x27697C8", VA = "0x276D7C8")]
		private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x276DEBC", Offset = "0x2769EBC", VA = "0x276DEBC")]
		private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x276DFA4", Offset = "0x2769FA4", VA = "0x276DFA4")]
		private void CompileConditionalExpression(Expression expr, bool asVoid)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x276E1D8", Offset = "0x276A1D8", VA = "0x276E1D8")]
		private void CompileLoopExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x276E4A4", Offset = "0x276A4A4", VA = "0x276E4A4")]
		private void CompileSwitchExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000864")]
		private void CompileIntSwitchExpression<T>(SwitchExpression node)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x276EDFC", Offset = "0x276ADFC", VA = "0x276EDFC")]
		private void CompileStringSwitchExpression(SwitchExpression node)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x276F460", Offset = "0x276B460", VA = "0x276F460")]
		private void CompileLabelExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x276F5FC", Offset = "0x276B5FC", VA = "0x276F5FC")]
		private void CompileGotoExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x276E394", Offset = "0x276A394", VA = "0x276E394")]
		private void PushLabelBlock(LabelScopeKind type)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x276E488", Offset = "0x276A488", VA = "0x276E488")]
		private void PopLabelBlock(LabelScopeKind kind)
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x276F808", Offset = "0x276B808", VA = "0x276F808")]
		private LabelInfo EnsureLabel(LabelTarget node)
		{
			return null;
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x276F7D4", Offset = "0x276B7D4", VA = "0x276F7D4")]
		private LabelInfo ReferenceLabel(LabelTarget node)
		{
			return null;
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x276E404", Offset = "0x276A404", VA = "0x276E404")]
		private LabelInfo DefineLabel(LabelTarget node)
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x276F8D8", Offset = "0x276B8D8", VA = "0x276F8D8")]
		private bool TryPushLabelBlock(Expression node)
		{
			return default(bool);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x276FD30", Offset = "0x276BD30", VA = "0x276FD30")]
		private void DefineBlockLabels(Expression node)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x276FE64", Offset = "0x276BE64", VA = "0x276FE64")]
		private void CheckRethrow()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x276FEB8", Offset = "0x276BEB8", VA = "0x276FEB8")]
		private void CompileThrowUnaryExpression(Expression expr, bool asVoid)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x276FFC0", Offset = "0x276BFC0", VA = "0x276FFC0")]
		private void CompileTryExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2770A78", Offset = "0x276CA78", VA = "0x2770A78")]
		private void CompileTryFaultExpression(TryExpression expr)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2770CAC", Offset = "0x276CCAC", VA = "0x2770CAC")]
		private void CompileMethodCallExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2770D48", Offset = "0x276CD48", VA = "0x2770D48")]
		private void CompileMethodCallExpression(Expression @object, MethodInfo method, IArgumentProvider arguments)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x27712AC", Offset = "0x276D2AC", VA = "0x27712AC")]
		private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex)
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x2769D5C", Offset = "0x2765D5C", VA = "0x2769D5C")]
		private void EmitThisForMethodCall(Expression node)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x27714AC", Offset = "0x276D4AC", VA = "0x27714AC")]
		private static bool ShouldWritebackNode(Expression node)
		{
			return default(bool);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x276BED4", Offset = "0x2767ED4", VA = "0x276BED4")]
		private ByRefUpdater CompileAddress(Expression node, int index)
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x2771630", Offset = "0x276D630", VA = "0x2771630")]
		private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index)
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2771A28", Offset = "0x276DA28", VA = "0x2771A28")]
		private void CompileNewExpression(Expression expr)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x2771DE0", Offset = "0x276DDE0", VA = "0x2771DE0")]
		private void CompileMemberExpression(Expression expr)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x2771E80", Offset = "0x276DE80", VA = "0x2771E80")]
		private void CompileMember(Expression from, MemberInfo member, bool forBinding)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2772208", Offset = "0x276E208", VA = "0x2772208")]
		private void CompileNewArrayExpression(Expression expr)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x2772560", Offset = "0x276E560", VA = "0x2772560")]
		private void CompileDebugInfoExpression(Expression expr)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x27726F8", Offset = "0x276E6F8", VA = "0x27726F8")]
		private void CompileRuntimeVariablesExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x27729CC", Offset = "0x276E9CC", VA = "0x27729CC")]
		private void CompileLambdaExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x2772BCC", Offset = "0x276EBCC", VA = "0x2772BCC")]
		private void CompileCoalesceBinaryExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x2773178", Offset = "0x276F178", VA = "0x2773178")]
		private void CompileInvocationExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x27733EC", Offset = "0x276F3EC", VA = "0x27733EC")]
		private void CompileListInitExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x2773468", Offset = "0x276F468", VA = "0x2773468")]
		private void CompileListInit(ReadOnlyCollection<ElementInit> initializers)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x2773818", Offset = "0x276F818", VA = "0x2773818")]
		private void CompileMemberInitExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x2773894", Offset = "0x276F894", VA = "0x2773894")]
		private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x2773D58", Offset = "0x276FD58", VA = "0x2773D58")]
		private static Type GetMemberType(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x2773EE0", Offset = "0x276FEE0", VA = "0x2773EE0")]
		private void CompileQuoteUnaryExpression(Expression expr)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x2774188", Offset = "0x2770188", VA = "0x2774188")]
		private void CompileUnboxUnaryExpression(Expression expr)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x27742AC", Offset = "0x27702AC", VA = "0x27742AC")]
		private void CompileTypeEqualExpression(Expression expr)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x276D1C4", Offset = "0x27691C4", VA = "0x276D1C4")]
		private void CompileTypeAsExpression(UnaryExpression node)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x27744A0", Offset = "0x27704A0", VA = "0x27744A0")]
		private void CompileTypeIsExpression(Expression expr)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x2769A60", Offset = "0x2765A60", VA = "0x2769A60")]
		private void Compile(Expression expr, bool asVoid)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x2769B08", Offset = "0x2765B08", VA = "0x2769B08")]
		private void CompileAsVoid(Expression expr)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x27746E8", Offset = "0x27706E8", VA = "0x27746E8")]
		private void CompileNoLabelPush(Expression expr)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x2768AE0", Offset = "0x2764AE0", VA = "0x2768AE0")]
		private void Compile(Expression expr)
		{
		}
	}
	[Token(Token = "0x2000192")]
	internal abstract class ByRefUpdater
	{
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x10")]
		public readonly int ArgumentIndex;

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x27759D4", Offset = "0x27719D4", VA = "0x27759D4")]
		public ByRefUpdater(int argumentIndex)
		{
		}

		[Token(Token = "0x600089F")]
		public abstract void Update(InterpretedFrame frame, object value);

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x27759FC", Offset = "0x27719FC", VA = "0x27759FC", Slot = "5")]
		public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals)
		{
		}
	}
	[Token(Token = "0x2000193")]
	internal sealed class ParameterByRefUpdater : ByRefUpdater
	{
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalVariable _parameter;

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x2775A00", Offset = "0x2771A00", VA = "0x2775A00")]
		public ParameterByRefUpdater(LocalVariable parameter, int argumentIndex)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x2775A30", Offset = "0x2771A30", VA = "0x2775A30", Slot = "4")]
		public override void Update(InterpretedFrame frame, object value)
		{
		}
	}
	[Token(Token = "0x2000194")]
	internal sealed class ArrayByRefUpdater : ByRefUpdater
	{
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalDefinition _array;

		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x28")]
		private readonly LocalDefinition _index;

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x2775C3C", Offset = "0x2771C3C", VA = "0x2775C3C")]
		public ArrayByRefUpdater(LocalDefinition array, LocalDefinition index, int argumentIndex)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x2775C8C", Offset = "0x2771C8C", VA = "0x2775C8C", Slot = "4")]
		public override void Update(InterpretedFrame frame, object value)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x2775D94", Offset = "0x2771D94", VA = "0x2775D94", Slot = "5")]
		public override void UndefineTemps(InstructionList instructions, LocalVariables locals)
		{
		}
	}
	[Token(Token = "0x2000195")]
	internal sealed class FieldByRefUpdater : ByRefUpdater
	{
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalDefinition? _object;

		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x30")]
		private readonly FieldInfo _field;

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x2775EE4", Offset = "0x2771EE4", VA = "0x2775EE4")]
		public FieldByRefUpdater(LocalDefinition? obj, FieldInfo field, int argumentIndex)
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x2775F2C", Offset = "0x2771F2C", VA = "0x2775F2C", Slot = "4")]
		public override void Update(InterpretedFrame frame, object value)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x2775FCC", Offset = "0x2771FCC", VA = "0x2775FCC", Slot = "5")]
		public override void UndefineTemps(InstructionList instructions, LocalVariables locals)
		{
		}
	}
	[Token(Token = "0x2000196")]
	internal sealed class PropertyByRefUpdater : ByRefUpdater
	{
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalDefinition? _object;

		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x30")]
		private readonly PropertyInfo _property;

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x2776064", Offset = "0x2772064", VA = "0x2776064")]
		public PropertyByRefUpdater(LocalDefinition? obj, PropertyInfo property, int argumentIndex)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x27760AC", Offset = "0x27720AC", VA = "0x27760AC", Slot = "4")]
		public override void Update(InterpretedFrame frame, object value)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2776208", Offset = "0x2772208", VA = "0x2776208", Slot = "5")]
		public override void UndefineTemps(InstructionList instructions, LocalVariables locals)
		{
		}
	}
	[Token(Token = "0x2000197")]
	internal sealed class IndexMethodByRefUpdater : ByRefUpdater
	{
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x18")]
		private readonly MethodInfo _indexer;

		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x20")]
		private readonly LocalDefinition? _obj;

		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x38")]
		private readonly LocalDefinition[] _args;

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x27762A0", Offset = "0x27722A0", VA = "0x27762A0")]
		public IndexMethodByRefUpdater(LocalDefinition? obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x27762F0", Offset = "0x27722F0", VA = "0x27762F0", Slot = "4")]
		public override void Update(InterpretedFrame frame, object value)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x2776558", Offset = "0x2772558", VA = "0x2776558", Slot = "5")]
		public override void UndefineTemps(InstructionList instructions, LocalVariables locals)
		{
		}
	}
	[Token(Token = "0x2000198")]
	internal sealed class LightDelegateCreator
	{
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x10")]
		private readonly LambdaExpression _lambda;

		[Token(Token = "0x170001C7")]
		internal Interpreter Interpreter
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x2776680", Offset = "0x2772680", VA = "0x2776680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x2776654", Offset = "0x2772654", VA = "0x2776654")]
		internal LightDelegateCreator(Interpreter interpreter, LambdaExpression lambda)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x2776688", Offset = "0x2772688", VA = "0x2776688")]
		public Delegate CreateDelegate()
		{
			return null;
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x2776690", Offset = "0x2772690", VA = "0x2776690")]
		internal Delegate CreateDelegate(IStrongBox[] closure)
		{
			return null;
		}
	}
	[Token(Token = "0x2000199")]
	internal class LightLambda
	{
		[Token(Token = "0x200019A")]
		private class DebugViewPrinter
		{
			[Token(Token = "0x400035A")]
			[FieldOffset(Offset = "0x10")]
			private readonly Interpreter _interpreter;

			[Token(Token = "0x400035B")]
			[FieldOffset(Offset = "0x18")]
			private readonly Dictionary<int, int> _tryStart;

			[Token(Token = "0x400035C")]
			[FieldOffset(Offset = "0x20")]
			private readonly Dictionary<int, string> _handlerEnter;

			[Token(Token = "0x400035D")]
			[FieldOffset(Offset = "0x28")]
			private readonly Dictionary<int, int> _handlerExit;

			[Token(Token = "0x400035E")]
			[FieldOffset(Offset = "0x30")]
			private string _indent;

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x2776A00", Offset = "0x2772A00", VA = "0x2776A00")]
			public DebugViewPrinter(Interpreter interpreter)
			{
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x27787BC", Offset = "0x27747BC", VA = "0x27787BC")]
			private void Analyze()
			{
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0x2778A58", Offset = "0x2774A58", VA = "0x2778A58")]
			private void AddTryStart(int index)
			{
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x2778B28", Offset = "0x2774B28", VA = "0x2778B28")]
			private void AddHandlerExit(int index)
			{
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x2778BCC", Offset = "0x2774BCC", VA = "0x2778BCC")]
			private void Indent()
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x2778C04", Offset = "0x2774C04", VA = "0x2778C04")]
			private void Dedent()
			{
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x2778C3C", Offset = "0x2774C3C", VA = "0x2778C3C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x277911C", Offset = "0x277511C", VA = "0x277911C")]
			private void EmitExits(StringBuilder sb, int index)
			{
			}
		}

		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x10")]
		private readonly IStrongBox[] _closure;

		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x18")]
		private readonly Interpreter _interpreter;

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CacheDict<Type, Func<LightLambda, Delegate>> _runCache;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x20")]
		private readonly LightDelegateCreator _delegateCreator;

		[Token(Token = "0x170001C8")]
		internal string DebugView
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x2776994", Offset = "0x2772994", VA = "0x2776994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B3")]
		internal TRet Run0<TRet>()
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x27767E0", Offset = "0x27727E0", VA = "0x27767E0")]
		internal void RunVoid0()
		{
		}

		[Token(Token = "0x60008B5")]
		internal static Delegate MakeRun0<TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x2776918", Offset = "0x2772918", VA = "0x2776918")]
		internal static Delegate MakeRunVoid0(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		internal TRet Run1<T0, TRet>(T0 arg0)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008B8")]
		internal void RunVoid1<T0>(T0 arg0)
		{
		}

		[Token(Token = "0x60008B9")]
		internal static Delegate MakeRun1<T0, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008BA")]
		internal static Delegate MakeRunVoid1<T0>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		internal TRet Run2<T0, T1, TRet>(T0 arg0, T1 arg1)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008BC")]
		internal void RunVoid2<T0, T1>(T0 arg0, T1 arg1)
		{
		}

		[Token(Token = "0x60008BD")]
		internal static Delegate MakeRun2<T0, T1, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008BE")]
		internal static Delegate MakeRunVoid2<T0, T1>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008BF")]
		internal TRet Run3<T0, T1, T2, TRet>(T0 arg0, T1 arg1, T2 arg2)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008C0")]
		internal void RunVoid3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2)
		{
		}

		[Token(Token = "0x60008C1")]
		internal static Delegate MakeRun3<T0, T1, T2, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008C2")]
		internal static Delegate MakeRunVoid3<T0, T1, T2>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008C3")]
		internal TRet Run4<T0, T1, T2, T3, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008C4")]
		internal void RunVoid4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Token(Token = "0x60008C5")]
		internal static Delegate MakeRun4<T0, T1, T2, T3, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008C6")]
		internal static Delegate MakeRunVoid4<T0, T1, T2, T3>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008C7")]
		internal TRet Run5<T0, T1, T2, T3, T4, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008C8")]
		internal void RunVoid5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Token(Token = "0x60008C9")]
		internal static Delegate MakeRun5<T0, T1, T2, T3, T4, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008CA")]
		internal static Delegate MakeRunVoid5<T0, T1, T2, T3, T4>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008CB")]
		internal TRet Run6<T0, T1, T2, T3, T4, T5, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008CC")]
		internal void RunVoid6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Token(Token = "0x60008CD")]
		internal static Delegate MakeRun6<T0, T1, T2, T3, T4, T5, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008CE")]
		internal static Delegate MakeRunVoid6<T0, T1, T2, T3, T4, T5>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008CF")]
		internal TRet Run7<T0, T1, T2, T3, T4, T5, T6, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008D0")]
		internal void RunVoid7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Token(Token = "0x60008D1")]
		internal static Delegate MakeRun7<T0, T1, T2, T3, T4, T5, T6, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008D2")]
		internal static Delegate MakeRunVoid7<T0, T1, T2, T3, T4, T5, T6>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008D3")]
		internal TRet Run8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008D4")]
		internal void RunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Token(Token = "0x60008D5")]
		internal static Delegate MakeRun8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008D6")]
		internal static Delegate MakeRunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008D7")]
		internal TRet Run9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008D8")]
		internal void RunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Token(Token = "0x60008D9")]
		internal static Delegate MakeRun9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008DA")]
		internal static Delegate MakeRunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		internal TRet Run10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008DC")]
		internal void RunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Token(Token = "0x60008DD")]
		internal static Delegate MakeRun10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008DE")]
		internal static Delegate MakeRunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008DF")]
		internal TRet Run11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008E0")]
		internal void RunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Token(Token = "0x60008E1")]
		internal static Delegate MakeRun11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		internal static Delegate MakeRunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		internal TRet Run12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008E4")]
		internal void RunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Token(Token = "0x60008E5")]
		internal static Delegate MakeRun12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008E6")]
		internal static Delegate MakeRunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		internal TRet Run13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008E8")]
		internal void RunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Token(Token = "0x60008E9")]
		internal static Delegate MakeRun13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008EA")]
		internal static Delegate MakeRunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		internal TRet Run14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008EC")]
		internal void RunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Token(Token = "0x60008ED")]
		internal static Delegate MakeRun14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008EE")]
		internal static Delegate MakeRunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008EF")]
		internal TRet Run15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			return (TRet)null;
		}

		[Token(Token = "0x60008F0")]
		internal void RunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Token(Token = "0x60008F1")]
		internal static Delegate MakeRun15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008F2")]
		internal static Delegate MakeRunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LightLambda lambda)
		{
			return null;
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x2776718", Offset = "0x2772718", VA = "0x2776718")]
		internal LightLambda(LightDelegateCreator delegateCreator, IStrongBox[] closure)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x2776B0C", Offset = "0x2772B0C", VA = "0x2776B0C")]
		private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType)
		{
			return null;
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x2776C8C", Offset = "0x2772C8C", VA = "0x2776C8C")]
		private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType)
		{
			return null;
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x2777B64", Offset = "0x2773B64", VA = "0x2777B64")]
		private Delegate CreateCustomDelegate(Type delegateType)
		{
			return null;
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x2776758", Offset = "0x2772758", VA = "0x2776758")]
		internal Delegate MakeDelegate(Type delegateType)
		{
			return null;
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x27768B4", Offset = "0x27728B4", VA = "0x27768B4")]
		private InterpretedFrame MakeFrame()
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		internal void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x2778460", Offset = "0x2774460", VA = "0x2778460")]
		public object Run(params object[] arguments)
		{
			return null;
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x27785CC", Offset = "0x27745CC", VA = "0x27785CC")]
		public object RunVoid(params object[] arguments)
		{
			return null;
		}
	}
	[Token(Token = "0x200019C")]
	internal interface IBoxableInstruction
	{
		[Token(Token = "0x6000908")]
		Instruction BoxIfIndexMatches(int index);
	}
	[Token(Token = "0x200019D")]
	internal abstract class LocalAccessInstruction : Instruction
	{
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x10")]
		internal readonly int _index;

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x277921C", Offset = "0x277521C", VA = "0x277921C")]
		protected LocalAccessInstruction(int index)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x2779244", Offset = "0x2775244", VA = "0x2779244", Slot = "10")]
		public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects)
		{
			return null;
		}
	}
	[Token(Token = "0x200019E")]
	internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction
	{
		[Token(Token = "0x170001C9")]
		public override int ProducedStack
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x27793EC", Offset = "0x27753EC", VA = "0x27793EC", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001CA")]
		public override string InstructionName
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x27793F4", Offset = "0x27753F4", VA = "0x27793F4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x27793C4", Offset = "0x27753C4", VA = "0x27793C4")]
		internal LoadLocalInstruction(int index)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x2779434", Offset = "0x2775434", VA = "0x2779434", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x27794C0", Offset = "0x27754C0", VA = "0x27794C0", Slot = "11")]
		public Instruction BoxIfIndexMatches(int index)
		{
			return null;
		}
	}
	[Token(Token = "0x200019F")]
	internal sealed class LoadLocalBoxedInstruction : LocalAccessInstruction
	{
		[Token(Token = "0x170001CB")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x2779560", Offset = "0x2775560", VA = "0x2779560", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001CC")]
		public override string InstructionName
		{
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x2779568", Offset = "0x2775568", VA = "0x2779568", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x2779538", Offset = "0x2775538", VA = "0x2779538")]
		internal LoadLocalBoxedInstruction(int index)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x27795A8", Offset = "0x27755A8", VA = "0x27795A8", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001A0")]
	internal sealed class LoadLocalFromClosureInstruction : LocalAccessInstruction
	{
		[Token(Token = "0x170001CD")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x277972C", Offset = "0x277572C", VA = "0x277972C", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001CE")]
		public override string InstructionName
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x2779734", Offset = "0x2775734", VA = "0x2779734", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x2779704", Offset = "0x2775704", VA = "0x2779704")]
		internal LoadLocalFromClosureInstruction(int index)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x2779774", Offset = "0x2775774", VA = "0x2779774", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001A1")]
	internal sealed class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction
	{
		[Token(Token = "0x170001CF")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x27798C4", Offset = "0x27758C4", VA = "0x27798C4", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001D0")]
		public override string InstructionName
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x27798CC", Offset = "0x27758CC", VA = "0x27798CC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x277989C", Offset = "0x277589C", VA = "0x277989C")]
		internal LoadLocalFromClosureBoxedInstruction(int index)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x277990C", Offset = "0x277590C", VA = "0x277990C", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001A2")]
	internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction
	{
		[Token(Token = "0x170001D1")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x27799C4", Offset = "0x27759C4", VA = "0x27799C4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001D2")]
		public override int ProducedStack
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x27799CC", Offset = "0x27759CC", VA = "0x27799CC", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001D3")]
		public override string InstructionName
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x27799D4", Offset = "0x27759D4", VA = "0x27799D4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x277999C", Offset = "0x277599C", VA = "0x277999C")]
		internal AssignLocalInstruction(int index)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x2779A14", Offset = "0x2775A14", VA = "0x2779A14", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x2779A8C", Offset = "0x2775A8C", VA = "0x2779A8C", Slot = "11")]
		public Instruction BoxIfIndexMatches(int index)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A3")]
	internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction
	{
		[Token(Token = "0x170001D4")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x2779B2C", Offset = "0x2775B2C", VA = "0x2779B2C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001D5")]
		public override string InstructionName
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x2779B34", Offset = "0x2775B34", VA = "0x2779B34", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x2779B04", Offset = "0x2775B04", VA = "0x2779B04")]
		internal StoreLocalInstruction(int index)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x2779B74", Offset = "0x2775B74", VA = "0x2779B74", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x2779BEC", Offset = "0x2775BEC", VA = "0x2779BEC", Slot = "11")]
		public Instruction BoxIfIndexMatches(int index)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A4")]
	internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction
	{
		[Token(Token = "0x170001D6")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x2779C8C", Offset = "0x2775C8C", VA = "0x2779C8C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001D7")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x2779C94", Offset = "0x2775C94", VA = "0x2779C94", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001D8")]
		public override string InstructionName
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x2779C9C", Offset = "0x2775C9C", VA = "0x2779C9C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x2779C64", Offset = "0x2775C64", VA = "0x2779C64")]
		internal AssignLocalBoxedInstruction(int index)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x2779CDC", Offset = "0x2775CDC", VA = "0x2779CDC", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001A5")]
	internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction
	{
		[Token(Token = "0x170001D9")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x2779E38", Offset = "0x2775E38", VA = "0x2779E38", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001DA")]
		public override string InstructionName
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x2779E40", Offset = "0x2775E40", VA = "0x2779E40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x2779E10", Offset = "0x2775E10", VA = "0x2779E10")]
		internal StoreLocalBoxedInstruction(int index)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x2779E80", Offset = "0x2775E80", VA = "0x2779E80", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001A6")]
	internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction
	{
		[Token(Token = "0x170001DB")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x2779FE4", Offset = "0x2775FE4", VA = "0x2779FE4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001DC")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x2779FEC", Offset = "0x2775FEC", VA = "0x2779FEC", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001DD")]
		public override string InstructionName
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x2779FF4", Offset = "0x2775FF4", VA = "0x2779FF4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x2779FBC", Offset = "0x2775FBC", VA = "0x2779FBC")]
		internal AssignLocalToClosureInstruction(int index)
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x277A034", Offset = "0x2776034", VA = "0x277A034", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001A7")]
	internal sealed class ValueTypeCopyInstruction : Instruction
	{
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ValueTypeCopyInstruction Instruction;

		[Token(Token = "0x170001DE")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x277A11C", Offset = "0x277611C", VA = "0x277A11C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001DF")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x277A124", Offset = "0x2776124", VA = "0x277A124", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001E0")]
		public override string InstructionName
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x277A12C", Offset = "0x277612C", VA = "0x277A12C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x277A16C", Offset = "0x277616C", VA = "0x277A16C", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x277A1B0", Offset = "0x27761B0", VA = "0x277A1B0")]
		public ValueTypeCopyInstruction()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	internal abstract class InitializeLocalInstruction : LocalAccessInstruction
	{
		[Token(Token = "0x20001A9")]
		internal sealed class Reference : InitializeLocalInstruction, IBoxableInstruction
		{
			[Token(Token = "0x170001E1")]
			public override string InstructionName
			{
				[Token(Token = "0x600093F")]
				[Address(RVA = "0x277A318", Offset = "0x2776318", VA = "0x277A318", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x277A23C", Offset = "0x277623C", VA = "0x277A23C")]
			internal Reference(int index)
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x277A264", Offset = "0x2776264", VA = "0x277A264", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x277A2A0", Offset = "0x27762A0", VA = "0x277A2A0", Slot = "11")]
			public Instruction BoxIfIndexMatches(int index)
			{
				return null;
			}
		}

		[Token(Token = "0x20001AA")]
		internal sealed class ImmutableValue : InitializeLocalInstruction, IBoxableInstruction
		{
			[Token(Token = "0x4000363")]
			[FieldOffset(Offset = "0x18")]
			private readonly object _defaultValue;

			[Token(Token = "0x170001E2")]
			public override string InstructionName
			{
				[Token(Token = "0x6000943")]
				[Address(RVA = "0x277A4A0", Offset = "0x27764A0", VA = "0x277A4A0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x277A358", Offset = "0x2776358", VA = "0x277A358")]
			internal ImmutableValue(int index, object defaultValue)
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x277A388", Offset = "0x2776388", VA = "0x277A388", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x277A3F4", Offset = "0x27763F4", VA = "0x277A3F4", Slot = "11")]
			public Instruction BoxIfIndexMatches(int index)
			{
				return null;
			}
		}

		[Token(Token = "0x20001AB")]
		internal sealed class ImmutableBox : InitializeLocalInstruction
		{
			[Token(Token = "0x4000364")]
			[FieldOffset(Offset = "0x18")]
			private readonly object _defaultValue;

			[Token(Token = "0x170001E3")]
			public override string InstructionName
			{
				[Token(Token = "0x6000946")]
				[Address(RVA = "0x277A5B0", Offset = "0x27765B0", VA = "0x277A5B0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000944")]
			[Address(RVA = "0x277A470", Offset = "0x2776470", VA = "0x277A470")]
			internal ImmutableBox(int index, object defaultValue)
			{
			}

			[Token(Token = "0x6000945")]
			[Address(RVA = "0x277A4E0", Offset = "0x27764E0", VA = "0x277A4E0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20001AC")]
		internal sealed class ImmutableRefBox : InitializeLocalInstruction
		{
			[Token(Token = "0x170001E4")]
			public override string InstructionName
			{
				[Token(Token = "0x6000949")]
				[Address(RVA = "0x277A6E0", Offset = "0x27766E0", VA = "0x277A6E0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000947")]
			[Address(RVA = "0x277A5F0", Offset = "0x27765F0", VA = "0x277A5F0")]
			internal ImmutableRefBox(int index)
			{
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0x277A618", Offset = "0x2776618", VA = "0x277A618", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20001AD")]
		internal sealed class ParameterBox : InitializeLocalInstruction
		{
			[Token(Token = "0x170001E5")]
			public override string InstructionName
			{
				[Token(Token = "0x600094C")]
				[Address(RVA = "0x277A824", Offset = "0x2776824", VA = "0x277A824", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094A")]
			[Address(RVA = "0x277A720", Offset = "0x2776720", VA = "0x277A720")]
			public ParameterBox(int index)
			{
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0x277A748", Offset = "0x2776748", VA = "0x277A748", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20001AE")]
		internal sealed class Parameter : InitializeLocalInstruction, IBoxableInstruction
		{
			[Token(Token = "0x170001E6")]
			public override string InstructionName
			{
				[Token(Token = "0x6000950")]
				[Address(RVA = "0x277A90C", Offset = "0x277690C", VA = "0x277A90C", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094D")]
			[Address(RVA = "0x277A864", Offset = "0x2776864", VA = "0x277A864")]
			internal Parameter(int index)
			{
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0x277A88C", Offset = "0x277688C", VA = "0x277A88C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600094F")]
			[Address(RVA = "0x277A894", Offset = "0x2776894", VA = "0x277A894", Slot = "11")]
			public Instruction BoxIfIndexMatches(int index)
			{
				return null;
			}
		}

		[Token(Token = "0x20001AF")]
		internal sealed class MutableValue : InitializeLocalInstruction, IBoxableInstruction
		{
			[Token(Token = "0x4000365")]
			[FieldOffset(Offset = "0x18")]
			private readonly Type _type;

			[Token(Token = "0x170001E7")]
			public override string InstructionName
			{
				[Token(Token = "0x6000954")]
				[Address(RVA = "0x277AB44", Offset = "0x2776B44", VA = "0x277AB44", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0x277A94C", Offset = "0x277694C", VA = "0x277A94C")]
			internal MutableValue(int index, Type type)
			{
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x277A97C", Offset = "0x277697C", VA = "0x277A97C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x277AA98", Offset = "0x2776A98", VA = "0x277AA98", Slot = "11")]
			public Instruction BoxIfIndexMatches(int index)
			{
				return null;
			}
		}

		[Token(Token = "0x20001B0")]
		internal sealed class MutableBox : InitializeLocalInstruction
		{
			[Token(Token = "0x4000366")]
			[FieldOffset(Offset = "0x18")]
			private readonly Type _type;

			[Token(Token = "0x170001E8")]
			public override string InstructionName
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0x277ACFC", Offset = "0x2776CFC", VA = "0x277ACFC", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x277AB14", Offset = "0x2776B14", VA = "0x277AB14")]
			internal MutableBox(int index, Type type)
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x277AB84", Offset = "0x2776B84", VA = "0x277AB84", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x277A214", Offset = "0x2776214", VA = "0x277A214")]
		internal InitializeLocalInstruction(int index)
		{
		}
	}
	[Token(Token = "0x20001B1")]
	internal sealed class RuntimeVariablesInstruction : Instruction
	{
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x10")]
		private readonly int _count;

		[Token(Token = "0x170001E9")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x277AD64", Offset = "0x2776D64", VA = "0x277AD64", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001EA")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x277AD6C", Offset = "0x2776D6C", VA = "0x277AD6C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001EB")]
		public override string InstructionName
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x277AD74", Offset = "0x2776D74", VA = "0x277AD74", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x277AD3C", Offset = "0x2776D3C", VA = "0x277AD3C")]
		public RuntimeVariablesInstruction(int count)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x277ADB4", Offset = "0x2776DB4", VA = "0x277ADB4", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001B2")]
	internal sealed class LocalVariable
	{
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x10")]
		public readonly int Index;

		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x14")]
		private int _flags;

		[Token(Token = "0x170001EC")]
		public bool IsBoxed
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x2775C30", Offset = "0x2771C30", VA = "0x2775C30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x277AF44", Offset = "0x2776F44", VA = "0x277AF44")]
			set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public bool InClosure
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x2775C24", Offset = "0x2771C24", VA = "0x2775C24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x277AF54", Offset = "0x2776F54", VA = "0x277AF54")]
		internal LocalVariable(int index, bool closure)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x277AF8C", Offset = "0x2776F8C", VA = "0x277AF8C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20001B3")]
	internal readonly struct LocalDefinition
	{
		[Token(Token = "0x170001EE")]
		public int Index
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x277B098", Offset = "0x2777098", VA = "0x277B098")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001EF")]
		public ParameterExpression Parameter
		{
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x277B0A0", Offset = "0x27770A0", VA = "0x277B0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x277B08C", Offset = "0x277708C", VA = "0x277B08C")]
		internal LocalDefinition(int localIndex, ParameterExpression parameter)
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x277B0A8", Offset = "0x27770A8", VA = "0x277B0A8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x277B130", Offset = "0x2777130", VA = "0x277B130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001B4")]
	internal sealed class LocalVariables
	{
		[Token(Token = "0x20001B5")]
		private sealed class VariableScope
		{
			[Token(Token = "0x4000370")]
			[FieldOffset(Offset = "0x10")]
			public readonly int Start;

			[Token(Token = "0x4000371")]
			[FieldOffset(Offset = "0x14")]
			public int Stop;

			[Token(Token = "0x4000372")]
			[FieldOffset(Offset = "0x18")]
			public readonly LocalVariable Variable;

			[Token(Token = "0x4000373")]
			[FieldOffset(Offset = "0x20")]
			public readonly VariableScope Parent;

			[Token(Token = "0x4000374")]
			[FieldOffset(Offset = "0x28")]
			public List<VariableScope> ChildScopes;

			[Token(Token = "0x600096F")]
			[Address(RVA = "0x277B3D0", Offset = "0x27773D0", VA = "0x277B3D0")]
			public VariableScope(LocalVariable variable, int start, VariableScope parent)
			{
			}
		}

		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x10")]
		private readonly HybridReferenceDictionary<ParameterExpression, VariableScope> _variables;

		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ParameterExpression, LocalVariable> _closureVariables;

		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x20")]
		private int _localCount;

		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x24")]
		private int _maxLocalCount;

		[Token(Token = "0x170001F0")]
		public int LocalCount
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x277B568", Offset = "0x2777568", VA = "0x277B568")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F1")]
		internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x277B63C", Offset = "0x277763C", VA = "0x277B63C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x277B178", Offset = "0x2777178", VA = "0x277B178")]
		public LocalDefinition DefineLocal(ParameterExpression variable, int start)
		{
			return default(LocalDefinition);
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x2775E0C", Offset = "0x2771E0C", VA = "0x2775E0C")]
		public void UndefineLocal(LocalDefinition definition, int end)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x277B414", Offset = "0x2777414", VA = "0x277B414")]
		internal void Box(ParameterExpression variable, InstructionList instructions)
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x277B570", Offset = "0x2777570", VA = "0x277B570")]
		public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local)
		{
			return default(bool);
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x277B644", Offset = "0x2777644", VA = "0x277B644")]
		internal LocalVariable AddClosureVariable(ParameterExpression variable)
		{
			return null;
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x277B754", Offset = "0x2777754", VA = "0x277B754")]
		public LocalVariables()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	internal abstract class ModuloInstruction : Instruction
	{
		[Token(Token = "0x20001B7")]
		private sealed class ModuloInt16 : ModuloInstruction
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x277BC04", Offset = "0x2777C04", VA = "0x277BC04", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0x277BBC4", Offset = "0x2777BC4", VA = "0x277BBC4")]
			public ModuloInt16()
			{
			}
		}

		[Token(Token = "0x20001B8")]
		private sealed class ModuloInt32 : ModuloInstruction
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x277BD4C", Offset = "0x2777D4C", VA = "0x277BD4C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0x277BBCC", Offset = "0x2777BCC", VA = "0x277BBCC")]
			public ModuloInt32()
			{
			}
		}

		[Token(Token = "0x20001B9")]
		private sealed class ModuloInt64 : ModuloInstruction
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x277BFD0", Offset = "0x2777FD0", VA = "0x277BFD0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x277BBD4", Offset = "0x2777BD4", VA = "0x277BBD4")]
			public ModuloInt64()
			{
			}
		}

		[Token(Token = "0x20001BA")]
		private sealed class ModuloUInt16 : ModuloInstruction
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x277C118", Offset = "0x2778118", VA = "0x277C118", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0x277BBDC", Offset = "0x2777BDC", VA = "0x277BBDC")]
			public ModuloUInt16()
			{
			}
		}

		[Token(Token = "0x20001BB")]
		private sealed class ModuloUInt32 : ModuloInstruction
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x277C260", Offset = "0x2778260", VA = "0x277C260", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0x277BBE4", Offset = "0x2777BE4", VA = "0x277BBE4")]
			public ModuloUInt32()
			{
			}
		}

		[Token(Token = "0x20001BC")]
		private sealed class ModuloUInt64 : ModuloInstruction
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x277C3A8", Offset = "0x27783A8", VA = "0x277C3A8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x277BBEC", Offset = "0x2777BEC", VA = "0x277BBEC")]
			public ModuloUInt64()
			{
			}
		}

		[Token(Token = "0x20001BD")]
		private sealed class ModuloSingle : ModuloInstruction
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x277C4F0", Offset = "0x27784F0", VA = "0x277C4F0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x277BBF4", Offset = "0x2777BF4", VA = "0x277BBF4")]
			public ModuloSingle()
			{
			}
		}

		[Token(Token = "0x20001BE")]
		private sealed class ModuloDouble : ModuloInstruction
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x277C638", Offset = "0x2778638", VA = "0x277C638", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x277BBFC", Offset = "0x2777BFC", VA = "0x277BBFC")]
			public ModuloDouble()
			{
			}
		}

		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_UInt16;

		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_UInt32;

		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt64;

		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_Single;

		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_Double;

		[Token(Token = "0x170001F2")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x277B7D0", Offset = "0x27777D0", VA = "0x277B7D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F3")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x277B7D8", Offset = "0x27777D8", VA = "0x277B7D8", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F4")]
		public override string InstructionName
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x277B7E0", Offset = "0x27777E0", VA = "0x277B7E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x277B820", Offset = "0x2777820", VA = "0x277B820")]
		private ModuloInstruction()
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x277B828", Offset = "0x2777828", VA = "0x277B828")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20001BF")]
	internal abstract class MulInstruction : Instruction
	{
		[Token(Token = "0x20001C0")]
		private sealed class MulInt16 : MulInstruction
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x277CBB4", Offset = "0x2778BB4", VA = "0x277CBB4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x277CB74", Offset = "0x2778B74", VA = "0x277CB74")]
			public MulInt16()
			{
			}
		}

		[Token(Token = "0x20001C1")]
		private sealed class MulInt32 : MulInstruction
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x277CCF8", Offset = "0x2778CF8", VA = "0x277CCF8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x277CB7C", Offset = "0x2778B7C", VA = "0x277CB7C")]
			public MulInt32()
			{
			}
		}

		[Token(Token = "0x20001C2")]
		private sealed class MulInt64 : MulInstruction
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x277CE28", Offset = "0x2778E28", VA = "0x277CE28", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x277CB84", Offset = "0x2778B84", VA = "0x277CB84")]
			public MulInt64()
			{
			}
		}

		[Token(Token = "0x20001C3")]
		private sealed class MulUInt16 : MulInstruction
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x277CF6C", Offset = "0x2778F6C", VA = "0x277CF6C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x277CB8C", Offset = "0x2778B8C", VA = "0x277CB8C")]
			public MulUInt16()
			{
			}
		}

		[Token(Token = "0x20001C4")]
		private sealed class MulUInt32 : MulInstruction
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x277D0B0", Offset = "0x27790B0", VA = "0x277D0B0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x277CB94", Offset = "0x2778B94", VA = "0x277CB94")]
			public MulUInt32()
			{
			}
		}

		[Token(Token = "0x20001C5")]
		private sealed class MulUInt64 : MulInstruction
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x277D1F4", Offset = "0x27791F4", VA = "0x277D1F4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x277CB9C", Offset = "0x2778B9C", VA = "0x277CB9C")]
			public MulUInt64()
			{
			}
		}

		[Token(Token = "0x20001C6")]
		private sealed class MulSingle : MulInstruction
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x277D338", Offset = "0x2779338", VA = "0x277D338", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x277CBA4", Offset = "0x2778BA4", VA = "0x277CBA4")]
			public MulSingle()
			{
			}
		}

		[Token(Token = "0x20001C7")]
		private sealed class MulDouble : MulInstruction
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x277D47C", Offset = "0x277947C", VA = "0x277D47C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x277CBAC", Offset = "0x2778BAC", VA = "0x277CBAC")]
			public MulDouble()
			{
			}
		}

		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_UInt16;

		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_UInt32;

		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt64;

		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_Single;

		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_Double;

		[Token(Token = "0x170001F5")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x277C780", Offset = "0x2778780", VA = "0x277C780", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F6")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x277C788", Offset = "0x2778788", VA = "0x277C788", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F7")]
		public override string InstructionName
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x277C790", Offset = "0x2778790", VA = "0x277C790", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x277C7D0", Offset = "0x27787D0", VA = "0x277C7D0")]
		private MulInstruction()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x277C7D8", Offset = "0x27787D8", VA = "0x277C7D8")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20001C8")]
	internal abstract class MulOvfInstruction : Instruction
	{
		[Token(Token = "0x20001C9")]
		private sealed class MulOvfInt16 : MulOvfInstruction
		{
			[Token(Token = "0x600099F")]
			[Address(RVA = "0x277D910", Offset = "0x2779910", VA = "0x277D910", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x277D8E0", Offset = "0x27798E0", VA = "0x277D8E0")]
			public MulOvfInt16()
			{
			}
		}

		[Token(Token = "0x20001CA")]
		private sealed class MulOvfInt32 : MulOvfInstruction
		{
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x277DB58", Offset = "0x2779B58", VA = "0x277DB58", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x277D8E8", Offset = "0x27798E8", VA = "0x277D8E8")]
			public MulOvfInt32()
			{
			}
		}

		[Token(Token = "0x20001CB")]
		private sealed class MulOvfInt64 : MulOvfInstruction
		{
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x277DD68", Offset = "0x2779D68", VA = "0x277DD68", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x277D8F0", Offset = "0x27798F0", VA = "0x277D8F0")]
			public MulOvfInt64()
			{
			}
		}

		[Token(Token = "0x20001CC")]
		private sealed class MulOvfUInt16 : MulOvfInstruction
		{
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x277DF64", Offset = "0x2779F64", VA = "0x277DF64", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x277D8F8", Offset = "0x27798F8", VA = "0x277D8F8")]
			public MulOvfUInt16()
			{
			}
		}

		[Token(Token = "0x20001CD")]
		private sealed class MulOvfUInt32 : MulOvfInstruction
		{
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x277E1C0", Offset = "0x277A1C0", VA = "0x277E1C0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x277D900", Offset = "0x2779900", VA = "0x277D900")]
			public MulOvfUInt32()
			{
			}
		}

		[Token(Token = "0x20001CE")]
		private sealed class MulOvfUInt64 : MulOvfInstruction
		{
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x277E388", Offset = "0x277A388", VA = "0x277E388", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x277D908", Offset = "0x2779908", VA = "0x277D908")]
			public MulOvfUInt64()
			{
			}
		}

		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_UInt16;

		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_UInt32;

		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt64;

		[Token(Token = "0x170001F8")]
		public override int ConsumedStack
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x277D5C0", Offset = "0x27795C0", VA = "0x277D5C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F9")]
		public override int ProducedStack
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x277D5C8", Offset = "0x27795C8", VA = "0x277D5C8", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FA")]
		public override string InstructionName
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x277D5D0", Offset = "0x27795D0", VA = "0x277D5D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x277D610", Offset = "0x2779610", VA = "0x277D610")]
		private MulOvfInstruction()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x277D618", Offset = "0x2779618", VA = "0x277D618")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20001CF")]
	internal abstract class NegateInstruction : Instruction
	{
		[Token(Token = "0x20001D0")]
		private sealed class NegateInt16 : NegateInstruction
		{
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x277E850", Offset = "0x277A850", VA = "0x277E850", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x277E828", Offset = "0x277A828", VA = "0x277E828")]
			public NegateInt16()
			{
			}
		}

		[Token(Token = "0x20001D1")]
		private sealed class NegateInt32 : NegateInstruction
		{
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x277E8F4", Offset = "0x277A8F4", VA = "0x277E8F4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x277E830", Offset = "0x277A830", VA = "0x277E830")]
			public NegateInt32()
			{
			}
		}

		[Token(Token = "0x20001D2")]
		private sealed class NegateInt64 : NegateInstruction
		{
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x277E998", Offset = "0x277A998", VA = "0x277E998", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x277E838", Offset = "0x277A838", VA = "0x277E838")]
			public NegateInt64()
			{
			}
		}

		[Token(Token = "0x20001D3")]
		private sealed class NegateSingle : NegateInstruction
		{
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x277EA4C", Offset = "0x277AA4C", VA = "0x277EA4C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x277E840", Offset = "0x277A840", VA = "0x277E840")]
			public NegateSingle()
			{
			}
		}

		[Token(Token = "0x20001D4")]
		private sealed class NegateDouble : NegateInstruction
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x277EAFC", Offset = "0x277AAFC", VA = "0x277EAFC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x277E848", Offset = "0x277A848", VA = "0x277E848")]
			public NegateDouble()
			{
			}
		}

		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Single;

		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Double;

		[Token(Token = "0x170001FB")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x277E54C", Offset = "0x277A54C", VA = "0x277E54C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FC")]
		public override int ProducedStack
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x277E554", Offset = "0x277A554", VA = "0x277E554", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FD")]
		public override string InstructionName
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x277E55C", Offset = "0x277A55C", VA = "0x277E55C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x277E59C", Offset = "0x277A59C", VA = "0x277E59C")]
		private NegateInstruction()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x277E5A4", Offset = "0x277A5A4", VA = "0x277E5A4")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20001D5")]
	internal abstract class NegateCheckedInstruction : Instruction
	{
		[Token(Token = "0x20001D6")]
		private sealed class NegateCheckedInt32 : NegateCheckedInstruction
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x277EDD4", Offset = "0x277ADD4", VA = "0x277EDD4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x277EDC4", Offset = "0x277ADC4", VA = "0x277EDC4")]
			public NegateCheckedInt32()
			{
			}
		}

		[Token(Token = "0x20001D7")]
		private sealed class NegateCheckedInt16 : NegateCheckedInstruction
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x277EEF4", Offset = "0x277AEF4", VA = "0x277EEF4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x277EDBC", Offset = "0x277ADBC", VA = "0x277EDBC")]
			public NegateCheckedInt16()
			{
			}
		}

		[Token(Token = "0x20001D8")]
		private sealed class NegateCheckedInt64 : NegateCheckedInstruction
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x277F030", Offset = "0x277B030", VA = "0x277F030", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x277EDCC", Offset = "0x277ADCC", VA = "0x277EDCC")]
			public NegateCheckedInt64()
			{
			}
		}

		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x170001FE")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x277EBAC", Offset = "0x277ABAC", VA = "0x277EBAC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FF")]
		public override int ProducedStack
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x277EBB4", Offset = "0x277ABB4", VA = "0x277EBB4", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000200")]
		public override string InstructionName
		{
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x277EBBC", Offset = "0x277ABBC", VA = "0x277EBBC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x277EBFC", Offset = "0x277ABFC", VA = "0x277EBFC")]
		private NegateCheckedInstruction()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x277EC04", Offset = "0x277AC04", VA = "0x277EC04")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20001D9")]
	internal class NewInstruction : Instruction
	{
		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x10")]
		protected readonly ConstructorInfo _constructor;

		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x18")]
		protected readonly int _argumentCount;

		[Token(Token = "0x17000201")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x277F17C", Offset = "0x277B17C", VA = "0x277F17C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000202")]
		public override int ProducedStack
		{
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x277F184", Offset = "0x277B184", VA = "0x277F184", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000203")]
		public override string InstructionName
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x277F18C", Offset = "0x277B18C", VA = "0x277F18C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x277F14C", Offset = "0x277B14C", VA = "0x277F14C")]
		public NewInstruction(ConstructorInfo constructor, int argumentCount)
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x277F1CC", Offset = "0x277B1CC", VA = "0x277F1CC", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x277F31C", Offset = "0x277B31C", VA = "0x277F31C")]
		protected object[] GetArgs(InterpretedFrame frame, int first)
		{
			return null;
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x277F498", Offset = "0x277B498", VA = "0x277F498", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20001DA")]
	internal class ByRefNewInstruction : NewInstruction
	{
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x20")]
		private readonly ByRefUpdater[] _byrefArgs;

		[Token(Token = "0x17000204")]
		public override string InstructionName
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x277F600", Offset = "0x277B600", VA = "0x277F600", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x277F5C0", Offset = "0x277B5C0", VA = "0x277F5C0")]
		internal ByRefNewInstruction(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x277F640", Offset = "0x277B640", VA = "0x277F640", Slot = "8")]
		public sealed override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001DB")]
	internal abstract class NotEqualInstruction : Instruction
	{
		[Token(Token = "0x20001DC")]
		private sealed class NotEqualBoolean : NotEqualInstruction
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x27801C0", Offset = "0x277C1C0", VA = "0x27801C0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x2780158", Offset = "0x277C158", VA = "0x2780158")]
			public NotEqualBoolean()
			{
			}
		}

		[Token(Token = "0x20001DD")]
		private sealed class NotEqualSByte : NotEqualInstruction
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x27802A4", Offset = "0x277C2A4", VA = "0x27802A4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x2780160", Offset = "0x277C160", VA = "0x2780160")]
			public NotEqualSByte()
			{
			}
		}

		[Token(Token = "0x20001DE")]
		private sealed class NotEqualInt16 : NotEqualInstruction
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x2780388", Offset = "0x277C388", VA = "0x2780388", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x2780168", Offset = "0x277C168", VA = "0x2780168")]
			public NotEqualInt16()
			{
			}
		}

		[Token(Token = "0x20001DF")]
		private sealed class NotEqualChar : NotEqualInstruction
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x278046C", Offset = "0x277C46C", VA = "0x278046C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x2780170", Offset = "0x277C170", VA = "0x2780170")]
			public NotEqualChar()
			{
			}
		}

		[Token(Token = "0x20001E0")]
		private sealed class NotEqualInt32 : NotEqualInstruction
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x2780550", Offset = "0x277C550", VA = "0x2780550", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x2780178", Offset = "0x277C178", VA = "0x2780178")]
			public NotEqualInt32()
			{
			}
		}

		[Token(Token = "0x20001E1")]
		private sealed class NotEqualInt64 : NotEqualInstruction
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x2780634", Offset = "0x277C634", VA = "0x2780634", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x2780180", Offset = "0x277C180", VA = "0x2780180")]
			public NotEqualInt64()
			{
			}
		}

		[Token(Token = "0x20001E2")]
		private sealed class NotEqualByte : NotEqualInstruction
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x2780718", Offset = "0x277C718", VA = "0x2780718", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x2780188", Offset = "0x277C188", VA = "0x2780188")]
			public NotEqualByte()
			{
			}
		}

		[Token(Token = "0x20001E3")]
		private sealed class NotEqualUInt16 : NotEqualInstruction
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x27807FC", Offset = "0x277C7FC", VA = "0x27807FC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x2780190", Offset = "0x277C190", VA = "0x2780190")]
			public NotEqualUInt16()
			{
			}
		}

		[Token(Token = "0x20001E4")]
		private sealed class NotEqualUInt32 : NotEqualInstruction
		{
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x27808E0", Offset = "0x277C8E0", VA = "0x27808E0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x2780198", Offset = "0x277C198", VA = "0x2780198")]
			public NotEqualUInt32()
			{
			}
		}

		[Token(Token = "0x20001E5")]
		private sealed class NotEqualUInt64 : NotEqualInstruction
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x27809C4", Offset = "0x277C9C4", VA = "0x27809C4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x27801A0", Offset = "0x277C1A0", VA = "0x27801A0")]
			public NotEqualUInt64()
			{
			}
		}

		[Token(Token = "0x20001E6")]
		private sealed class NotEqualSingle : NotEqualInstruction
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x2780AA8", Offset = "0x277CAA8", VA = "0x2780AA8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x27801A8", Offset = "0x277C1A8", VA = "0x27801A8")]
			public NotEqualSingle()
			{
			}
		}

		[Token(Token = "0x20001E7")]
		private sealed class NotEqualDouble : NotEqualInstruction
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x2780B94", Offset = "0x277CB94", VA = "0x2780B94", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x27801B0", Offset = "0x277C1B0", VA = "0x27801B0")]
			public NotEqualDouble()
			{
			}
		}

		[Token(Token = "0x20001E8")]
		private sealed class NotEqualReference : NotEqualInstruction
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x2780C80", Offset = "0x277CC80", VA = "0x2780C80", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x27801B8", Offset = "0x277C1B8", VA = "0x27801B8")]
			public NotEqualReference()
			{
			}
		}

		[Token(Token = "0x20001E9")]
		private sealed class NotEqualSByteLiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x2780CD4", Offset = "0x277CCD4", VA = "0x2780CD4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x2780100", Offset = "0x277C100", VA = "0x2780100")]
			public NotEqualSByteLiftedToNull()
			{
			}
		}

		[Token(Token = "0x20001EA")]
		private sealed class NotEqualInt16LiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x2780DBC", Offset = "0x277CDBC", VA = "0x2780DBC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x2780108", Offset = "0x277C108", VA = "0x2780108")]
			public NotEqualInt16LiftedToNull()
			{
			}
		}

		[Token(Token = "0x20001EB")]
		private sealed class NotEqualCharLiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x2780EA4", Offset = "0x277CEA4", VA = "0x2780EA4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x2780110", Offset = "0x277C110", VA = "0x2780110")]
			public NotEqualCharLiftedToNull()
			{
			}
		}

		[Token(Token = "0x20001EC")]
		private sealed class NotEqualInt32LiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x2780F8C", Offset = "0x277CF8C", VA = "0x2780F8C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x2780118", Offset = "0x277C118", VA = "0x2780118")]
			public NotEqualInt32LiftedToNull()
			{
			}
		}

		[Token(Token = "0x20001ED")]
		private sealed class NotEqualInt64LiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x2781074", Offset = "0x277D074", VA = "0x2781074", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x2780120", Offset = "0x277C120", VA = "0x2780120")]
			public NotEqualInt64LiftedToNull()
			{
			}
		}

		[Token(Token = "0x20001EE")]
		private sealed class NotEqualByteLiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x278115C", Offset = "0x277D15C", VA = "0x278115C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x2780128", Offset = "0x277C128", VA = "0x2780128")]
			public NotEqualByteLiftedToNull()
			{
			}
		}

		[Token(Token = "0x20001EF")]
		private sealed class NotEqualUInt16LiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x2781244", Offset = "0x277D244", VA = "0x2781244", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x2780130", Offset = "0x277C130", VA = "0x2780130")]
			public NotEqualUInt16LiftedToNull()
			{
			}
		}

		[Token(Token = "0x20001F0")]
		private sealed class NotEqualUInt32LiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x278132C", Offset = "0x277D32C", VA = "0x278132C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x2780138", Offset = "0x277C138", VA = "0x2780138")]
			public NotEqualUInt32LiftedToNull()
			{
			}
		}

		[Token(Token = "0x20001F1")]
		private sealed class NotEqualUInt64LiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x2781414", Offset = "0x277D414", VA = "0x2781414", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x2780140", Offset = "0x277C140", VA = "0x2780140")]
			public NotEqualUInt64LiftedToNull()
			{
			}
		}

		[Token(Token = "0x20001F2")]
		private sealed class NotEqualSingleLiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x27814FC", Offset = "0x277D4FC", VA = "0x27814FC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x2780148", Offset = "0x277C148", VA = "0x2780148")]
			public NotEqualSingleLiftedToNull()
			{
			}
		}

		[Token(Token = "0x20001F3")]
		private sealed class NotEqualDoubleLiftedToNull : NotEqualInstruction
		{
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x27815EC", Offset = "0x277D5EC", VA = "0x27815EC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x2780150", Offset = "0x277C150", VA = "0x2780150")]
			public NotEqualDoubleLiftedToNull()
			{
			}
		}

		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_reference;

		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Boolean;

		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_SByte;

		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int16;

		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Char;

		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_Int32;

		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_Int64;

		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_Byte;

		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x40")]
		private static Instruction s_UInt16;

		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x48")]
		private static Instruction s_UInt32;

		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x50")]
		private static Instruction s_UInt64;

		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x58")]
		private static Instruction s_Single;

		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x60")]
		private static Instruction s_Double;

		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x68")]
		private static Instruction s_SByteLiftedToNull;

		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x70")]
		private static Instruction s_Int16LiftedToNull;

		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x78")]
		private static Instruction s_CharLiftedToNull;

		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x80")]
		private static Instruction s_Int32LiftedToNull;

		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x88")]
		private static Instruction s_Int64LiftedToNull;

		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x90")]
		private static Instruction s_ByteLiftedToNull;

		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x98")]
		private static Instruction s_UInt16LiftedToNull;

		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0xA0")]
		private static Instruction s_UInt32LiftedToNull;

		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0xA8")]
		private static Instruction s_UInt64LiftedToNull;

		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0xB0")]
		private static Instruction s_SingleLiftedToNull;

		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0xB8")]
		private static Instruction s_DoubleLiftedToNull;

		[Token(Token = "0x17000205")]
		public override int ConsumedStack
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x277F858", Offset = "0x277B858", VA = "0x277F858", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000206")]
		public override int ProducedStack
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x277F860", Offset = "0x277B860", VA = "0x277F860", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000207")]
		public override string InstructionName
		{
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x277F868", Offset = "0x277B868", VA = "0x277F868", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x277F8A8", Offset = "0x277B8A8", VA = "0x277F8A8")]
		private NotEqualInstruction()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x277F8B0", Offset = "0x277B8B0", VA = "0x277F8B0")]
		public static Instruction Create(Type type, bool liftedToNull)
		{
			return null;
		}
	}
	[Token(Token = "0x20001F4")]
	internal abstract class NotInstruction : Instruction
	{
		[Token(Token = "0x20001F5")]
		private sealed class NotBoolean : NotInstruction
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x2781B70", Offset = "0x277DB70", VA = "0x2781B70", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x2781B28", Offset = "0x277DB28", VA = "0x2781B28")]
			public NotBoolean()
			{
			}
		}

		[Token(Token = "0x20001F6")]
		private sealed class NotInt64 : NotInstruction
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x2781C18", Offset = "0x277DC18", VA = "0x2781C18", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x2781B30", Offset = "0x277DB30", VA = "0x2781B30")]
			public NotInt64()
			{
			}
		}

		[Token(Token = "0x20001F7")]
		private sealed class NotInt32 : NotInstruction
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x2781CCC", Offset = "0x277DCCC", VA = "0x2781CCC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x2781B38", Offset = "0x277DB38", VA = "0x2781B38")]
			public NotInt32()
			{
			}
		}

		[Token(Token = "0x20001F8")]
		private sealed class NotInt16 : NotInstruction
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x2781D70", Offset = "0x277DD70", VA = "0x2781D70", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x2781B40", Offset = "0x277DB40", VA = "0x2781B40")]
			public NotInt16()
			{
			}
		}

		[Token(Token = "0x20001F9")]
		private sealed class NotUInt64 : NotInstruction
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x2781E14", Offset = "0x277DE14", VA = "0x2781E14", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x2781B48", Offset = "0x277DB48", VA = "0x2781B48")]
			public NotUInt64()
			{
			}
		}

		[Token(Token = "0x20001FA")]
		private sealed class NotUInt32 : NotInstruction
		{
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x2781EC8", Offset = "0x277DEC8", VA = "0x2781EC8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x2781B50", Offset = "0x277DB50", VA = "0x2781B50")]
			public NotUInt32()
			{
			}
		}

		[Token(Token = "0x20001FB")]
		private sealed class NotUInt16 : NotInstruction
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x2781F7C", Offset = "0x277DF7C", VA = "0x2781F7C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x2781B58", Offset = "0x277DB58", VA = "0x2781B58")]
			public NotUInt16()
			{
			}
		}

		[Token(Token = "0x20001FC")]
		private sealed class NotByte : NotInstruction
		{
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x2782020", Offset = "0x277E020", VA = "0x2782020", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x2781B60", Offset = "0x277DB60", VA = "0x2781B60")]
			public NotByte()
			{
			}
		}

		[Token(Token = "0x20001FD")]
		private sealed class NotSByte : NotInstruction
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x27820C4", Offset = "0x277E0C4", VA = "0x27820C4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x2781B68", Offset = "0x277DB68", VA = "0x2781B68")]
			public NotSByte()
			{
			}
		}

		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x0")]
		public static Instruction s_Boolean;

		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x8")]
		public static Instruction s_Int64;

		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x10")]
		public static Instruction s_Int32;

		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x18")]
		public static Instruction s_Int16;

		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x20")]
		public static Instruction s_UInt64;

		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x28")]
		public static Instruction s_UInt32;

		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x30")]
		public static Instruction s_UInt16;

		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x38")]
		public static Instruction s_Byte;

		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x40")]
		public static Instruction s_SByte;

		[Token(Token = "0x17000208")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x27816E4", Offset = "0x277D6E4", VA = "0x27816E4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000209")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x27816EC", Offset = "0x277D6EC", VA = "0x27816EC", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700020A")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x27816F4", Offset = "0x277D6F4", VA = "0x27816F4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x27816DC", Offset = "0x277D6DC", VA = "0x27816DC")]
		private NotInstruction()
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x2781734", Offset = "0x277D734", VA = "0x2781734")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20001FE")]
	internal sealed class NullCheckInstruction : Instruction
	{
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Instruction Instance;

		[Token(Token = "0x1700020B")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x2782170", Offset = "0x277E170", VA = "0x2782170", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700020C")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x2782178", Offset = "0x277E178", VA = "0x2782178", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700020D")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x2782180", Offset = "0x277E180", VA = "0x2782180", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x2782168", Offset = "0x277E168", VA = "0x2782168")]
		private NullCheckInstruction()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x27821C0", Offset = "0x277E1C0", VA = "0x27821C0", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001FF")]
	internal abstract class NumericConvertInstruction : Instruction
	{
		[Token(Token = "0x2000200")]
		internal sealed class Unchecked : NumericConvertInstruction
		{
			[Token(Token = "0x17000211")]
			public override string InstructionName
			{
				[Token(Token = "0x6000A28")]
				[Address(RVA = "0x278258C", Offset = "0x277E58C", VA = "0x278258C", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x27825CC", Offset = "0x277E5CC", VA = "0x27825CC")]
			public Unchecked(TypeCode from, TypeCode to, bool isLiftedToNull)
			{
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x2782608", Offset = "0x277E608", VA = "0x2782608", Slot = "11")]
			protected override object Convert(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x2782A04", Offset = "0x277EA04", VA = "0x2782A04")]
			private object ConvertInt32(int obj)
			{
				return null;
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x2782C74", Offset = "0x277EC74", VA = "0x2782C74")]
			private object ConvertInt64(long obj)
			{
				return null;
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x2782F0C", Offset = "0x277EF0C", VA = "0x2782F0C")]
			private object ConvertUInt64(ulong obj)
			{
				return null;
			}

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x27831A8", Offset = "0x277F1A8", VA = "0x27831A8")]
			private object ConvertDouble(double obj)
			{
				return null;
			}
		}

		[Token(Token = "0x2000201")]
		internal sealed class Checked : NumericConvertInstruction
		{
			[Token(Token = "0x17000212")]
			public override string InstructionName
			{
				[Token(Token = "0x6000A2F")]
				[Address(RVA = "0x27834F4", Offset = "0x277F4F4", VA = "0x27834F4", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x2783534", Offset = "0x277F534", VA = "0x2783534")]
			public Checked(TypeCode from, TypeCode to, bool isLiftedToNull)
			{
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x2783570", Offset = "0x277F570", VA = "0x2783570", Slot = "11")]
			protected override object Convert(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x278396C", Offset = "0x277F96C", VA = "0x278396C")]
			private object ConvertInt32(int obj)
			{
				return null;
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x2783C34", Offset = "0x277FC34", VA = "0x2783C34")]
			private object ConvertInt64(long obj)
			{
				return null;
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x2783F3C", Offset = "0x277FF3C", VA = "0x2783F3C")]
			private object ConvertUInt64(ulong obj)
			{
				return null;
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x2784244", Offset = "0x2780244", VA = "0x2784244")]
			private object ConvertDouble(double obj)
			{
				return null;
			}
		}

		[Token(Token = "0x2000202")]
		internal sealed class ToUnderlying : NumericConvertInstruction
		{
			[Token(Token = "0x17000213")]
			public override string InstructionName
			{
				[Token(Token = "0x6000A36")]
				[Address(RVA = "0x27845BC", Offset = "0x27805BC", VA = "0x27845BC", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x27845FC", Offset = "0x27805FC", VA = "0x27845FC")]
			public ToUnderlying(TypeCode to, bool isLiftedToNull)
			{
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x278462C", Offset = "0x278062C", VA = "0x278462C", Slot = "11")]
			protected override object Convert(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x10")]
		internal readonly TypeCode _from;

		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x14")]
		internal readonly TypeCode _to;

		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool _isLiftedToNull;

		[Token(Token = "0x1700020E")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x27823D0", Offset = "0x277E3D0", VA = "0x27823D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020F")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x2782410", Offset = "0x277E410", VA = "0x2782410", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000210")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x2782418", Offset = "0x277E418", VA = "0x2782418", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x2782278", Offset = "0x277E278", VA = "0x2782278")]
		protected NumericConvertInstruction(TypeCode from, TypeCode to, bool isLiftedToNull)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x27822B4", Offset = "0x277E2B4", VA = "0x27822B4", Slot = "8")]
		public sealed override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x6000A23")]
		protected abstract object Convert(object obj);

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x2782420", Offset = "0x277E420", VA = "0x2782420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000203")]
	internal abstract class OrInstruction : Instruction
	{
		[Token(Token = "0x2000204")]
		private sealed class OrSByte : OrInstruction
		{
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x2784D60", Offset = "0x2780D60", VA = "0x2784D60", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x2784D18", Offset = "0x2780D18", VA = "0x2784D18")]
			public OrSByte()
			{
			}
		}

		[Token(Token = "0x2000205")]
		private sealed class OrInt16 : OrInstruction
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x2784E54", Offset = "0x2780E54", VA = "0x2784E54", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x2784D20", Offset = "0x2780D20", VA = "0x2784D20")]
			public OrInt16()
			{
			}
		}

		[Token(Token = "0x2000206")]
		private sealed class OrInt32 : OrInstruction
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x2784F48", Offset = "0x2780F48", VA = "0x2784F48", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x2784D28", Offset = "0x2780D28", VA = "0x2784D28")]
			public OrInt32()
			{
			}
		}

		[Token(Token = "0x2000207")]
		private sealed class OrInt64 : OrInstruction
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x278503C", Offset = "0x278103C", VA = "0x278503C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x2784D30", Offset = "0x2780D30", VA = "0x2784D30")]
			public OrInt64()
			{
			}
		}

		[Token(Token = "0x2000208")]
		private sealed class OrByte : OrInstruction
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x2785140", Offset = "0x2781140", VA = "0x2785140", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x2784D38", Offset = "0x2780D38", VA = "0x2784D38")]
			public OrByte()
			{
			}
		}

		[Token(Token = "0x2000209")]
		private sealed class OrUInt16 : OrInstruction
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x2785234", Offset = "0x2781234", VA = "0x2785234", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x2784D40", Offset = "0x2780D40", VA = "0x2784D40")]
			public OrUInt16()
			{
			}
		}

		[Token(Token = "0x200020A")]
		private sealed class OrUInt32 : OrInstruction
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x2785328", Offset = "0x2781328", VA = "0x2785328", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x2784D48", Offset = "0x2780D48", VA = "0x2784D48")]
			public OrUInt32()
			{
			}
		}

		[Token(Token = "0x200020B")]
		private sealed class OrUInt64 : OrInstruction
		{
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x278542C", Offset = "0x278142C", VA = "0x278542C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x2784D50", Offset = "0x2780D50", VA = "0x2784D50")]
			public OrUInt64()
			{
			}
		}

		[Token(Token = "0x200020C")]
		private sealed class OrBoolean : OrInstruction
		{
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x2785530", Offset = "0x2781530", VA = "0x2785530", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x2784D58", Offset = "0x2780D58", VA = "0x2784D58")]
			public OrBoolean()
			{
			}
		}

		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_SByte;

		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int16;

		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int32;

		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int64;

		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Byte;

		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt16;

		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_UInt32;

		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_UInt64;

		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x40")]
		private static Instruction s_Boolean;

		[Token(Token = "0x17000214")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x27848CC", Offset = "0x27808CC", VA = "0x27848CC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000215")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x27848D4", Offset = "0x27808D4", VA = "0x27848D4", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000216")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x27848DC", Offset = "0x27808DC", VA = "0x27848DC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x278491C", Offset = "0x278091C", VA = "0x278491C")]
		private OrInstruction()
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x2784924", Offset = "0x2780924", VA = "0x2784924")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200020D")]
	internal abstract class RightShiftInstruction : Instruction
	{
		[Token(Token = "0x200020E")]
		private sealed class RightShiftSByte : RightShiftInstruction
		{
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x2785AB8", Offset = "0x2781AB8", VA = "0x2785AB8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x2785A78", Offset = "0x2781A78", VA = "0x2785A78")]
			public RightShiftSByte()
			{
			}
		}

		[Token(Token = "0x200020F")]
		private sealed class RightShiftInt16 : RightShiftInstruction
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x2785BB0", Offset = "0x2781BB0", VA = "0x2785BB0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x2785A80", Offset = "0x2781A80", VA = "0x2785A80")]
			public RightShiftInt16()
			{
			}
		}

		[Token(Token = "0x2000210")]
		private sealed class RightShiftInt32 : RightShiftInstruction
		{
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x2785CA8", Offset = "0x2781CA8", VA = "0x2785CA8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x2785A88", Offset = "0x2781A88", VA = "0x2785A88")]
			public RightShiftInt32()
			{
			}
		}

		[Token(Token = "0x2000211")]
		private sealed class RightShiftInt64 : RightShiftInstruction
		{
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x2785D8C", Offset = "0x2781D8C", VA = "0x2785D8C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x2785A90", Offset = "0x2781A90", VA = "0x2785A90")]
			public RightShiftInt64()
			{
			}
		}

		[Token(Token = "0x2000212")]
		private sealed class RightShiftByte : RightShiftInstruction
		{
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x2785E98", Offset = "0x2781E98", VA = "0x2785E98", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x2785A98", Offset = "0x2781A98", VA = "0x2785A98")]
			public RightShiftByte()
			{
			}
		}

		[Token(Token = "0x2000213")]
		private sealed class RightShiftUInt16 : RightShiftInstruction
		{
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x2785F90", Offset = "0x2781F90", VA = "0x2785F90", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x2785AA0", Offset = "0x2781AA0", VA = "0x2785AA0")]
			public RightShiftUInt16()
			{
			}
		}

		[Token(Token = "0x2000214")]
		private sealed class RightShiftUInt32 : RightShiftInstruction
		{
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x2786088", Offset = "0x2782088", VA = "0x2786088", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x2785AA8", Offset = "0x2781AA8", VA = "0x2785AA8")]
			public RightShiftUInt32()
			{
			}
		}

		[Token(Token = "0x2000215")]
		private sealed class RightShiftUInt64 : RightShiftInstruction
		{
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x2786194", Offset = "0x2782194", VA = "0x2786194", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x2785AB0", Offset = "0x2781AB0", VA = "0x2785AB0")]
			public RightShiftUInt64()
			{
			}
		}

		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_SByte;

		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int16;

		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int32;

		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_Int64;

		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_Byte;

		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt16;

		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_UInt32;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_UInt64;

		[Token(Token = "0x17000217")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x2785684", Offset = "0x2781684", VA = "0x2785684", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000218")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x278568C", Offset = "0x278168C", VA = "0x278568C", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000219")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x2785694", Offset = "0x2781694", VA = "0x2785694", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x27856D4", Offset = "0x27816D4", VA = "0x27856D4")]
		private RightShiftInstruction()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x27856DC", Offset = "0x27816DC", VA = "0x27856DC")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000216")]
	internal sealed class RuntimeVariables : IRuntimeVariables
	{
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x10")]
		private readonly IStrongBox[] _boxes;

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x27862A0", Offset = "0x27822A0", VA = "0x27862A0")]
		private RuntimeVariables(IStrongBox[] boxes)
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x277AEE8", Offset = "0x2776EE8", VA = "0x277AEE8")]
		internal static IRuntimeVariables Create(IStrongBox[] boxes)
		{
			return null;
		}
	}
	[Token(Token = "0x2000217")]
	internal sealed class LoadObjectInstruction : Instruction
	{
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _value;

		[Token(Token = "0x1700021A")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x27862F0", Offset = "0x27822F0", VA = "0x27862F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700021B")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x27862F8", Offset = "0x27822F8", VA = "0x27862F8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x27862C8", Offset = "0x27822C8", VA = "0x27862C8")]
		internal LoadObjectInstruction(object value)
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x2786338", Offset = "0x2782338", VA = "0x2786338", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x27863AC", Offset = "0x27823AC", VA = "0x27863AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000218")]
	internal sealed class LoadCachedObjectInstruction : Instruction
	{
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x10")]
		private readonly uint _index;

		[Token(Token = "0x1700021C")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x2786480", Offset = "0x2782480", VA = "0x2786480", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700021D")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x2786488", Offset = "0x2782488", VA = "0x2786488", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x2786458", Offset = "0x2782458", VA = "0x2786458")]
		internal LoadCachedObjectInstruction(uint index)
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x27864C8", Offset = "0x27824C8", VA = "0x27864C8", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x2786560", Offset = "0x2782560", VA = "0x2786560", Slot = "10")]
		public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects)
		{
			return null;
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x27866A4", Offset = "0x27826A4", VA = "0x27866A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000219")]
	internal sealed class PopInstruction : Instruction
	{
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly PopInstruction Instance;

		[Token(Token = "0x1700021E")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x2786728", Offset = "0x2782728", VA = "0x2786728", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700021F")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x2786730", Offset = "0x2782730", VA = "0x2786730", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x2786720", Offset = "0x2782720", VA = "0x2786720")]
		private PopInstruction()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x2786770", Offset = "0x2782770", VA = "0x2786770", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200021A")]
	internal sealed class DupInstruction : Instruction
	{
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DupInstruction Instance;

		[Token(Token = "0x17000220")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x27867F8", Offset = "0x27827F8", VA = "0x27867F8", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000221")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x2786800", Offset = "0x2782800", VA = "0x2786800", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x27867F0", Offset = "0x27827F0", VA = "0x27867F0")]
		private DupInstruction()
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x2786840", Offset = "0x2782840", VA = "0x2786840", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200021B")]
	internal abstract class SubInstruction : Instruction
	{
		[Token(Token = "0x200021C")]
		private sealed class SubInt16 : SubInstruction
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x2786CF4", Offset = "0x2782CF4", VA = "0x2786CF4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x2786CB4", Offset = "0x2782CB4", VA = "0x2786CB4")]
			public SubInt16()
			{
			}
		}

		[Token(Token = "0x200021D")]
		private sealed class SubInt32 : SubInstruction
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x2786E3C", Offset = "0x2782E3C", VA = "0x2786E3C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x2786CBC", Offset = "0x2782CBC", VA = "0x2786CBC")]
			public SubInt32()
			{
			}
		}

		[Token(Token = "0x200021E")]
		private sealed class SubInt64 : SubInstruction
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x2786F6C", Offset = "0x2782F6C", VA = "0x2786F6C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x2786CC4", Offset = "0x2782CC4", VA = "0x2786CC4")]
			public SubInt64()
			{
			}
		}

		[Token(Token = "0x200021F")]
		private sealed class SubUInt16 : SubInstruction
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x27870B4", Offset = "0x27830B4", VA = "0x27870B4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x2786CCC", Offset = "0x2782CCC", VA = "0x2786CCC")]
			public SubUInt16()
			{
			}
		}

		[Token(Token = "0x2000220")]
		private sealed class SubUInt32 : SubInstruction
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x27871FC", Offset = "0x27831FC", VA = "0x27871FC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x2786CD4", Offset = "0x2782CD4", VA = "0x2786CD4")]
			public SubUInt32()
			{
			}
		}

		[Token(Token = "0x2000221")]
		private sealed class SubUInt64 : SubInstruction
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x2787344", Offset = "0x2783344", VA = "0x2787344", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x2786CDC", Offset = "0x2782CDC", VA = "0x2786CDC")]
			public SubUInt64()
			{
			}
		}

		[Token(Token = "0x2000222")]
		private sealed class SubSingle : SubInstruction
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x278748C", Offset = "0x278348C", VA = "0x278748C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x2786CE4", Offset = "0x2782CE4", VA = "0x2786CE4")]
			public SubSingle()
			{
			}
		}

		[Token(Token = "0x2000223")]
		private sealed class SubDouble : SubInstruction
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x27875D0", Offset = "0x27835D0", VA = "0x27875D0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x2786CEC", Offset = "0x2782CEC", VA = "0x2786CEC")]
			public SubDouble()
			{
			}
		}

		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_UInt16;

		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_UInt32;

		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt64;

		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x30")]
		private static Instruction s_Single;

		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x38")]
		private static Instruction s_Double;

		[Token(Token = "0x17000222")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x27868C0", Offset = "0x27828C0", VA = "0x27868C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000223")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x27868C8", Offset = "0x27828C8", VA = "0x27868C8", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000224")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x27868D0", Offset = "0x27828D0", VA = "0x27868D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x2786910", Offset = "0x2782910", VA = "0x2786910")]
		private SubInstruction()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x2786918", Offset = "0x2782918", VA = "0x2786918")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000224")]
	internal abstract class SubOvfInstruction : Instruction
	{
		[Token(Token = "0x2000225")]
		private sealed class SubOvfInt16 : SubOvfInstruction
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x2787A64", Offset = "0x2783A64", VA = "0x2787A64", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x2787A34", Offset = "0x2783A34", VA = "0x2787A34")]
			public SubOvfInt16()
			{
			}
		}

		[Token(Token = "0x2000226")]
		private sealed class SubOvfInt32 : SubOvfInstruction
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x2787CB0", Offset = "0x2783CB0", VA = "0x2787CB0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x2787A3C", Offset = "0x2783A3C", VA = "0x2787A3C")]
			public SubOvfInt32()
			{
			}
		}

		[Token(Token = "0x2000227")]
		private sealed class SubOvfInt64 : SubOvfInstruction
		{
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x2787EC0", Offset = "0x2783EC0", VA = "0x2787EC0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x2787A44", Offset = "0x2783A44", VA = "0x2787A44")]
			public SubOvfInt64()
			{
			}
		}

		[Token(Token = "0x2000228")]
		private sealed class SubOvfUInt16 : SubOvfInstruction
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x27880A4", Offset = "0x27840A4", VA = "0x27880A4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x2787A4C", Offset = "0x2783A4C", VA = "0x2787A4C")]
			public SubOvfUInt16()
			{
			}
		}

		[Token(Token = "0x2000229")]
		private sealed class SubOvfUInt32 : SubOvfInstruction
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x27882C0", Offset = "0x27842C0", VA = "0x27882C0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x2787A54", Offset = "0x2783A54", VA = "0x2787A54")]
			public SubOvfUInt32()
			{
			}
		}

		[Token(Token = "0x200022A")]
		private sealed class SubOvfUInt64 : SubOvfInstruction
		{
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x278848C", Offset = "0x278448C", VA = "0x278848C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x2787A5C", Offset = "0x2783A5C", VA = "0x2787A5C")]
			public SubOvfUInt64()
			{
			}
		}

		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x0")]
		private static Instruction s_Int16;

		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x8")]
		private static Instruction s_Int32;

		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x10")]
		private static Instruction s_Int64;

		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x18")]
		private static Instruction s_UInt16;

		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x20")]
		private static Instruction s_UInt32;

		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x28")]
		private static Instruction s_UInt64;

		[Token(Token = "0x17000225")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x2787714", Offset = "0x2783714", VA = "0x2787714", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000226")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x278771C", Offset = "0x278371C", VA = "0x278771C", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000227")]
		public override string InstructionName
		{
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x2787724", Offset = "0x2783724", VA = "0x2787724", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x2787764", Offset = "0x2783764", VA = "0x2787764")]
		private SubOvfInstruction()
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x278776C", Offset = "0x278376C", VA = "0x278776C")]
		public static Instruction Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200022B")]
	internal sealed class CreateDelegateInstruction : Instruction
	{
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x10")]
		private readonly LightDelegateCreator _creator;

		[Token(Token = "0x17000228")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x278867C", Offset = "0x278467C", VA = "0x278867C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000229")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x27886A0", Offset = "0x27846A0", VA = "0x27886A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700022A")]
		public override string InstructionName
		{
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x27886A8", Offset = "0x27846A8", VA = "0x27886A8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x2788654", Offset = "0x2784654", VA = "0x2788654")]
		internal CreateDelegateInstruction(LightDelegateCreator delegateCreator)
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x27886E8", Offset = "0x27846E8", VA = "0x27886E8", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200022C")]
	internal sealed class TypeIsInstruction : Instruction
	{
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _type;

		[Token(Token = "0x1700022B")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x2788880", Offset = "0x2784880", VA = "0x2788880", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700022C")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x2788888", Offset = "0x2784888", VA = "0x2788888", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700022D")]
		public override string InstructionName
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x2788890", Offset = "0x2784890", VA = "0x2788890", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x2788858", Offset = "0x2784858", VA = "0x2788858")]
		internal TypeIsInstruction(Type type)
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x27888D0", Offset = "0x27848D0", VA = "0x27888D0", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x2788930", Offset = "0x2784930", VA = "0x2788930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200022D")]
	internal sealed class TypeAsInstruction : Instruction
	{
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _type;

		[Token(Token = "0x1700022E")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x27889C0", Offset = "0x27849C0", VA = "0x27889C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700022F")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x27889C8", Offset = "0x27849C8", VA = "0x27889C8", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000230")]
		public override string InstructionName
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x27889D0", Offset = "0x27849D0", VA = "0x27889D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x2788998", Offset = "0x2784998", VA = "0x2788998")]
		internal TypeAsInstruction(Type type)
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x2788A10", Offset = "0x2784A10", VA = "0x2788A10", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x2788A7C", Offset = "0x2784A7C", VA = "0x2788A7C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200022E")]
	internal sealed class TypeEqualsInstruction : Instruction
	{
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TypeEqualsInstruction Instance;

		[Token(Token = "0x17000231")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x2788AE4", Offset = "0x2784AE4", VA = "0x2788AE4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000232")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x2788AEC", Offset = "0x2784AEC", VA = "0x2788AEC", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000233")]
		public override string InstructionName
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x2788AF4", Offset = "0x2784AF4", VA = "0x2788AF4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x2788B34", Offset = "0x2784B34", VA = "0x2788B34")]
		private TypeEqualsInstruction()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x2788B3C", Offset = "0x2784B3C", VA = "0x2788B3C", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200022F")]
	internal abstract class NullableMethodCallInstruction : Instruction
	{
		[Token(Token = "0x2000230")]
		private sealed class HasValue : NullableMethodCallInstruction
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x278908C", Offset = "0x278508C", VA = "0x278908C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x2788F94", Offset = "0x2784F94", VA = "0x2788F94")]
			public HasValue()
			{
			}
		}

		[Token(Token = "0x2000231")]
		private sealed class GetValue : NullableMethodCallInstruction
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x27890C8", Offset = "0x27850C8", VA = "0x27890C8", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x2788F9C", Offset = "0x2784F9C", VA = "0x2788F9C")]
			public GetValue()
			{
			}
		}

		[Token(Token = "0x2000232")]
		private sealed class GetValueOrDefault : NullableMethodCallInstruction
		{
			[Token(Token = "0x40003E9")]
			[FieldOffset(Offset = "0x10")]
			private readonly Type _defaultValueType;

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x2788FB4", Offset = "0x2784FB4", VA = "0x2788FB4")]
			public GetValueOrDefault(MethodInfo mi)
			{
			}

			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x2789138", Offset = "0x2785138", VA = "0x2789138", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000233")]
		private sealed class GetValueOrDefault1 : NullableMethodCallInstruction
		{
			[Token(Token = "0x17000237")]
			public override int ConsumedStack
			{
				[Token(Token = "0x6000AC5")]
				[Address(RVA = "0x2789198", Offset = "0x2785198", VA = "0x2789198", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x27891A0", Offset = "0x27851A0", VA = "0x27891A0", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x2788FF8", Offset = "0x2784FF8", VA = "0x2788FF8")]
			public GetValueOrDefault1()
			{
			}
		}

		[Token(Token = "0x2000234")]
		private sealed class EqualsClass : NullableMethodCallInstruction
		{
			[Token(Token = "0x17000238")]
			public override int ConsumedStack
			{
				[Token(Token = "0x6000AC8")]
				[Address(RVA = "0x27891F4", Offset = "0x27851F4", VA = "0x27891F4", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x27891FC", Offset = "0x27851FC", VA = "0x27891FC", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x2788FA4", Offset = "0x2784FA4", VA = "0x2788FA4")]
			public EqualsClass()
			{
			}
		}

		[Token(Token = "0x2000235")]
		private sealed class ToStringClass : NullableMethodCallInstruction
		{
			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x27892C4", Offset = "0x27852C4", VA = "0x27892C4", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x2789000", Offset = "0x2785000", VA = "0x2789000")]
			public ToStringClass()
			{
			}
		}

		[Token(Token = "0x2000236")]
		private sealed class GetHashCodeClass : NullableMethodCallInstruction
		{
			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x2789344", Offset = "0x2785344", VA = "0x2789344", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x2788FAC", Offset = "0x2784FAC", VA = "0x2788FAC")]
			public GetHashCodeClass()
			{
			}
		}

		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x0")]
		private static NullableMethodCallInstruction s_hasValue;

		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x8")]
		private static NullableMethodCallInstruction s_value;

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x10")]
		private static NullableMethodCallInstruction s_equals;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x18")]
		private static NullableMethodCallInstruction s_getHashCode;

		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x20")]
		private static NullableMethodCallInstruction s_getValueOrDefault1;

		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x28")]
		private static NullableMethodCallInstruction s_toString;

		[Token(Token = "0x17000234")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x2788BF8", Offset = "0x2784BF8", VA = "0x2788BF8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000235")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x2788C00", Offset = "0x2784C00", VA = "0x2788C00", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000236")]
		public override string InstructionName
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x2788C08", Offset = "0x2784C08", VA = "0x2788C08", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x2788C48", Offset = "0x2784C48", VA = "0x2788C48")]
		private NullableMethodCallInstruction()
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x2788C50", Offset = "0x2784C50", VA = "0x2788C50")]
		public static Instruction Create(string method, int argCount, MethodInfo mi)
		{
			return null;
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x2789008", Offset = "0x2785008", VA = "0x2789008")]
		public static Instruction CreateGetValue()
		{
			return null;
		}
	}
	[Token(Token = "0x2000237")]
	internal abstract class CastInstruction : Instruction
	{
		[Token(Token = "0x2000238")]
		private sealed class CastInstructionT<T> : CastInstruction
		{
			[Token(Token = "0x6000AD4")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000AD5")]
			public CastInstructionT()
			{
			}
		}

		[Token(Token = "0x2000239")]
		private abstract class CastInstructionNoT : CastInstruction
		{
			[Token(Token = "0x200023A")]
			private sealed class Ref : CastInstructionNoT
			{
				[Token(Token = "0x6000ADA")]
				[Address(RVA = "0x2789B74", Offset = "0x2785B74", VA = "0x2789B74")]
				public Ref(Type t)
				{
				}

				[Token(Token = "0x6000ADB")]
				[Address(RVA = "0x2789CEC", Offset = "0x2785CEC", VA = "0x2789CEC", Slot = "11")]
				protected override void ConvertNull(InterpretedFrame frame)
				{
				}
			}

			[Token(Token = "0x200023B")]
			private sealed class Value : CastInstructionNoT
			{
				[Token(Token = "0x6000ADC")]
				[Address(RVA = "0x2789B4C", Offset = "0x2785B4C", VA = "0x2789B4C")]
				public Value(Type t)
				{
				}

				[Token(Token = "0x6000ADD")]
				[Address(RVA = "0x2789D08", Offset = "0x2785D08", VA = "0x2789D08", Slot = "11")]
				protected override void ConvertNull(InterpretedFrame frame)
				{
				}
			}

			[Token(Token = "0x40003F9")]
			[FieldOffset(Offset = "0x10")]
			private readonly Type _t;

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x2789B24", Offset = "0x2785B24", VA = "0x2789B24")]
			protected CastInstructionNoT(Type t)
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x2789A5C", Offset = "0x2785A5C", VA = "0x2789A5C")]
			public new static CastInstruction Create(Type t)
			{
				return null;
			}

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x2789B9C", Offset = "0x2785B9C", VA = "0x2789B9C", Slot = "8")]
			public override int Run(InterpretedFrame frame)
			{
				return default(int);
			}

			[Token(Token = "0x6000AD9")]
			protected abstract void ConvertNull(InterpretedFrame frame);
		}

		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x0")]
		private static CastInstruction s_Boolean;

		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x8")]
		private static CastInstruction s_Byte;

		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x10")]
		private static CastInstruction s_Char;

		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x18")]
		private static CastInstruction s_DateTime;

		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x20")]
		private static CastInstruction s_Decimal;

		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x28")]
		private static CastInstruction s_Double;

		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x30")]
		private static CastInstruction s_Int16;

		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x38")]
		private static CastInstruction s_Int32;

		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x40")]
		private static CastInstruction s_Int64;

		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x48")]
		private static CastInstruction s_SByte;

		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x50")]
		private static CastInstruction s_Single;

		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x58")]
		private static CastInstruction s_String;

		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x60")]
		private static CastInstruction s_UInt16;

		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x68")]
		private static CastInstruction s_UInt32;

		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x70")]
		private static CastInstruction s_UInt64;

		[Token(Token = "0x17000239")]
		public override int ConsumedStack
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x2789394", Offset = "0x2785394", VA = "0x2789394", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700023A")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x278939C", Offset = "0x278539C", VA = "0x278939C", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700023B")]
		public override string InstructionName
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x27893A4", Offset = "0x27853A4", VA = "0x27893A4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x27893E4", Offset = "0x27853E4", VA = "0x27893E4")]
		public static Instruction Create(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x2789B1C", Offset = "0x2785B1C", VA = "0x2789B1C")]
		protected CastInstruction()
		{
		}
	}
	[Token(Token = "0x200023C")]
	internal sealed class CastToEnumInstruction : CastInstruction
	{
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _t;

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x2789D40", Offset = "0x2785D40", VA = "0x2789D40")]
		public CastToEnumInstruction(Type t)
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x2789D68", Offset = "0x2785D68", VA = "0x2789D68", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200023D")]
	internal sealed class CastReferenceToEnumInstruction : CastInstruction
	{
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _t;

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x2789E08", Offset = "0x2785E08", VA = "0x2789E08")]
		public CastReferenceToEnumInstruction(Type t)
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x2789E30", Offset = "0x2785E30", VA = "0x2789E30", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200023E")]
	internal sealed class QuoteInstruction : Instruction
	{
		[Token(Token = "0x200023F")]
		private sealed class ExpressionQuoter : ExpressionVisitor
		{
			[Token(Token = "0x40003FE")]
			[FieldOffset(Offset = "0x10")]
			private readonly Dictionary<ParameterExpression, LocalVariable> _variables;

			[Token(Token = "0x40003FF")]
			[FieldOffset(Offset = "0x18")]
			private readonly InterpretedFrame _frame;

			[Token(Token = "0x4000400")]
			[FieldOffset(Offset = "0x20")]
			private readonly Stack<HashSet<ParameterExpression>> _shadowedVars;

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x278A42C", Offset = "0x278642C", VA = "0x278A42C")]
			internal ExpressionQuoter(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame)
			{
			}

			[Token(Token = "0x6000AE7")]
			protected internal override Expression VisitLambda<T>(Expression<T> node)
			{
				return null;
			}

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x278A4C0", Offset = "0x27864C0", VA = "0x278A4C0", Slot = "6")]
			protected internal override Expression VisitBlock(BlockExpression node)
			{
				return null;
			}

			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0x278A654", Offset = "0x2786654", VA = "0x278A654", Slot = "22")]
			protected override CatchBlock VisitCatchBlock(CatchBlock node)
			{
				return null;
			}

			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x278A7F0", Offset = "0x27867F0", VA = "0x278A7F0", Slot = "21")]
			protected internal override Expression VisitParameter(ParameterExpression node)
			{
				return null;
			}

			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x278A8BC", Offset = "0x27868BC", VA = "0x278A8BC")]
			private IStrongBox GetBox(ParameterExpression variable)
			{
				return null;
			}
		}

		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x10")]
		private readonly Expression _operand;

		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables;

		[Token(Token = "0x1700023C")]
		public override int ProducedStack
		{
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x278A340", Offset = "0x2786340", VA = "0x278A340", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700023D")]
		public override string InstructionName
		{
			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x278A348", Offset = "0x2786348", VA = "0x278A348", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x278A314", Offset = "0x2786314", VA = "0x278A314")]
		public QuoteInstruction(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables)
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x278A388", Offset = "0x2786388", VA = "0x278A388", Slot = "8")]
		public override int Run(InterpretedFrame frame)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000240")]
	internal static class DelegateHelpers
	{
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x27774F4", Offset = "0x27734F4", VA = "0x27774F4")]
		internal static Type MakeDelegate(Type[] types)
		{
			return null;
		}
	}
	[Token(Token = "0x2000242")]
	internal static class ScriptingRuntimeHelpers
	{
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x277BE80", Offset = "0x2777E80", VA = "0x277BE80")]
		public static object Int32ToObject(int i)
		{
			return null;
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x278AA48", Offset = "0x2786A48", VA = "0x278AA48")]
		internal static object GetPrimitiveDefaultValue(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000243")]
	internal static class ExceptionHelpers
	{
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x27761F0", Offset = "0x27721F0", VA = "0x27761F0")]
		public static void UnwrapAndRethrow(TargetInvocationException exception)
		{
		}
	}
	[Token(Token = "0x2000244")]
	internal class HybridReferenceDictionary<TKey, TValue> where TKey : class
	{
		[Token(Token = "0x2000245")]
		[CompilerGenerated]
		private sealed class <GetEnumeratorWorker>d__7 : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000405")]
			[FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000406")]
			[FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> <>2__current;

			[Token(Token = "0x4000407")]
			[FieldOffset(Offset = "0x0")]
			public HybridReferenceDictionary<TKey, TValue> <>4__this;

			[Token(Token = "0x4000408")]
			[FieldOffset(Offset = "0x0")]
			private int <i>5__2;

			[Token(Token = "0x1700023F")]
			private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
			{
				[Token(Token = "0x6000AFE")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			[Token(Token = "0x17000240")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B00")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AFB")]
			[DebuggerHidden]
			public <GetEnumeratorWorker>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000AFC")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AFD")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AFF")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x0")]
		private KeyValuePair<TKey, TValue>[] _keysAndValues;

		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> _dict;

		[Token(Token = "0x1700023E")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6000AF8")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x6000AF9")]
			set
			{
			}
		}

		[Token(Token = "0x6000AF3")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF4")]
		public void Remove(TKey key)
		{
		}

		[Token(Token = "0x6000AF5")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF6")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000AF7")]
		[IteratorStateMachine(typeof(HybridReferenceDictionary<, >.<GetEnumeratorWorker>d__7))]
		private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker()
		{
			return null;
		}

		[Token(Token = "0x6000AFA")]
		public HybridReferenceDictionary()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000246")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class RuntimeOps
	{
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x278AD64", Offset = "0x2786D64", VA = "0x278AD64")]
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x278AEA0", Offset = "0x2786EA0", VA = "0x278AEA0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase)
		{
			return null;
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x278B260", Offset = "0x2787260", VA = "0x278B260")]
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x278B5EC", Offset = "0x27875EC", VA = "0x278B5EC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static bool ExpandoCheckVersion(ExpandoObject expando, object version)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x278B62C", Offset = "0x278762C", VA = "0x278B62C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass)
		{
		}
	}
	[Token(Token = "0x2000247")]
	public class CallSite
	{
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x10")]
		internal readonly CallSiteBinder _binder;

		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x18")]
		internal bool _match;

		[Token(Token = "0x17000241")]
		public CallSiteBinder Binder
		{
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x278B7CC", Offset = "0x27877CC", VA = "0x278B7CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x278B7A4", Offset = "0x27877A4", VA = "0x278B7A4")]
		internal CallSite(CallSiteBinder binder)
		{
		}
	}
	[Token(Token = "0x2000248")]
	public class CallSite<T> : CallSite where T : class
	{
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x0")]
		public T Target;

		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x0")]
		internal T[] Rules;

		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x0")]
		private static T s_cachedUpdate;

		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x0")]
		private static T s_cachedNoMatch;

		[Token(Token = "0x17000242")]
		public T Update
		{
			[Token(Token = "0x6000B08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B09")]
		private CallSite(CallSiteBinder binder)
		{
		}

		[Token(Token = "0x6000B0A")]
		private CallSite()
		{
		}

		[Token(Token = "0x6000B0B")]
		internal CallSite<T> CreateMatchMaker()
		{
			return null;
		}

		[Token(Token = "0x6000B0C")]
		public static CallSite<T> Create(CallSiteBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000B0D")]
		private T GetUpdateDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000B0E")]
		private T GetUpdateDelegate(ref T addr)
		{
			return null;
		}

		[Token(Token = "0x6000B0F")]
		internal void AddRule(T newRule)
		{
		}

		[Token(Token = "0x6000B10")]
		internal void MoveRule(int i)
		{
		}

		[Token(Token = "0x6000B11")]
		internal T MakeUpdateDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000B12")]
		private T CreateCustomUpdateDelegate(MethodInfo invoke)
		{
			return null;
		}

		[Token(Token = "0x6000B13")]
		private T CreateCustomNoMatchDelegate(MethodInfo invoke)
		{
			return null;
		}

		[Token(Token = "0x6000B14")]
		private static Expression Convert(Expression arg, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200024A")]
	public abstract class CallSiteBinder
	{
		[Token(Token = "0x200024B")]
		private sealed class LambdaSignature<T> where T : class
		{
			[Token(Token = "0x4000415")]
			[FieldOffset(Offset = "0x0")]
			private static LambdaSignature<T> s_instance;

			[Token(Token = "0x4000416")]
			[FieldOffset(Offset = "0x0")]
			internal readonly ReadOnlyCollection<ParameterExpression> Parameters;

			[Token(Token = "0x4000417")]
			[FieldOffset(Offset = "0x0")]
			internal readonly LabelTarget ReturnLabel;

			[Token(Token = "0x17000244")]
			internal static LambdaSignature<T> Instance
			{
				[Token(Token = "0x6000B23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B24")]
			private LambdaSignature()
			{
			}
		}

		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x10")]
		internal Dictionary<Type, object> Cache;

		[Token(Token = "0x17000243")]
		public static LabelTarget UpdateLabel
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x278B7DC", Offset = "0x27877DC", VA = "0x278B7DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x278B7D4", Offset = "0x27877D4", VA = "0x278B7D4")]
		protected CallSiteBinder()
		{
		}

		[Token(Token = "0x6000B1C")]
		public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);

		[Token(Token = "0x6000B1D")]
		public virtual T BindDelegate<T>(CallSite<T> site, object[] args) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000B1E")]
		internal T BindCore<T>(CallSite<T> site, object[] args) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000B1F")]
		protected void CacheTarget<T>(T target) where T : class
		{
		}

		[Token(Token = "0x6000B20")]
		private static Expression<T> Stitch<T>(Expression binding, LambdaSignature<T> signature) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000B21")]
		internal RuleCache<T> GetRuleCache<T>() where T : class
		{
			return null;
		}
	}
	[Token(Token = "0x200024C")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class CallSiteOps
	{
		[Token(Token = "0x6000B25")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static CallSite<T> CreateMatchmaker<T>(CallSite<T> site) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x278B8C0", Offset = "0x27878C0", VA = "0x278B8C0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static bool SetNotMatched(CallSite site)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x278B8DC", Offset = "0x27878DC", VA = "0x278B8DC")]
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool GetMatch(CallSite site)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x278B8F0", Offset = "0x27878F0", VA = "0x278B8F0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void ClearMatch(CallSite site)
		{
		}

		[Token(Token = "0x6000B29")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void AddRule<T>(CallSite<T> site, T rule) where T : class
		{
		}

		[Token(Token = "0x6000B2A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void UpdateRules<T>(CallSite<T> @this, int matched) where T : class
		{
		}

		[Token(Token = "0x6000B2B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static T[] GetRules<T>(CallSite<T> site) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000B2C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static RuleCache<T> GetRuleCache<T>(CallSite<T> site) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000B2D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void MoveRule<T>(RuleCache<T> cache, T rule, int i) where T : class
		{
		}

		[Token(Token = "0x6000B2E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static T[] GetCachedRules<T>(RuleCache<T> cache) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000B2F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static T Bind<T>(CallSiteBinder binder, CallSite<T> site, object[] args) where T : class
		{
			return null;
		}
	}
	[Token(Token = "0x200024D")]
	[DefaultMember("Item")]
	public interface IRuntimeVariables
	{
	}
	[Serializable]
	[Token(Token = "0x200024E")]
	public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection
	{
		[Serializable]
		[Token(Token = "0x200024F")]
		private class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400041B")]
			[FieldOffset(Offset = "0x0")]
			private readonly ReadOnlyCollectionBuilder<T> _builder;

			[Token(Token = "0x400041C")]
			[FieldOffset(Offset = "0x0")]
			private readonly int _version;

			[Token(Token = "0x400041D")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			[Token(Token = "0x400041E")]
			[FieldOffset(Offset = "0x0")]
			private T _current;

			[Token(Token = "0x1700024E")]
			public T Current
			{
				[Token(Token = "0x6000B53")]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x1700024F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B55")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B52")]
			internal Enumerator(ReadOnlyCollectionBuilder<T> builder)
			{
			}

			[Token(Token = "0x6000B54")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000B56")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B57")]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x0")]
		private T[] _items;

		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x0")]
		private int _version;

		[Token(Token = "0x17000245")]
		public int Capacity
		{
			[Token(Token = "0x6000B32")]
			set
			{
			}
		}

		[Token(Token = "0x17000246")]
		public int Count
		{
			[Token(Token = "0x6000B33")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000247")]
		public T this[int index]
		{
			[Token(Token = "0x6000B37")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000B38")]
			set
			{
			}
		}

		[Token(Token = "0x17000248")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[Token(Token = "0x6000B3D")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000249")]
		private bool System.Collections.IList.IsReadOnly
		{
			[Token(Token = "0x6000B41")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700024A")]
		private bool System.Collections.IList.IsFixedSize
		{
			[Token(Token = "0x6000B46")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700024B")]
		private object System.Collections.IList.Item
		{
			[Token(Token = "0x6000B48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B49")]
			set
			{
			}
		}

		[Token(Token = "0x1700024C")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x6000B4B")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700024D")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x6000B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B30")]
		public ReadOnlyCollectionBuilder()
		{
		}

		[Token(Token = "0x6000B31")]
		public ReadOnlyCollectionBuilder(int capacity)
		{
		}

		[Token(Token = "0x6000B34")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000B35")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000B36")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000B39")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000B3A")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000B3B")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B3C")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000B3E")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B3F")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000B40")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000B42")]
		private int System.Collections.IList.Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B43")]
		private bool System.Collections.IList.Contains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B44")]
		private int System.Collections.IList.IndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B45")]
		private void System.Collections.IList.Insert(int index, object value)
		{
		}

		[Token(Token = "0x6000B47")]
		private void System.Collections.IList.Remove(object value)
		{
		}

		[Token(Token = "0x6000B4A")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6000B4D")]
		public T[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x6000B4E")]
		public ReadOnlyCollection<T> ToReadOnlyCollection()
		{
			return null;
		}

		[Token(Token = "0x6000B4F")]
		private void EnsureCapacity(int min)
		{
		}

		[Token(Token = "0x6000B50")]
		private static bool IsCompatibleObject(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B51")]
		private static void ValidateNullValue(object value, string argument)
		{
		}
	}
	[Token(Token = "0x2000250")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RuleCache<T> where T : class
	{
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x0")]
		private T[] _rules;

		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x0")]
		private readonly object _cacheLock;

		[Token(Token = "0x6000B58")]
		internal RuleCache()
		{
		}

		[Token(Token = "0x6000B59")]
		internal T[] GetRules()
		{
			return null;
		}

		[Token(Token = "0x6000B5A")]
		internal void MoveRule(T rule, int i)
		{
		}

		[Token(Token = "0x6000B5B")]
		internal void AddRule(T newRule)
		{
		}

		[Token(Token = "0x6000B5C")]
		private static T[] AddOrInsert(T[] rules, T item)
		{
			return null;
		}
	}
	[Token(Token = "0x2000251")]
	internal sealed class TrueReadOnlyCollection<T> : ReadOnlyCollection<T>
	{
		[Token(Token = "0x6000B5D")]
		public TrueReadOnlyCollection(params T[] list)
		{
		}
	}
	[Token(Token = "0x2000252")]
	public class StrongBox<T> : IStrongBox
	{
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x17000250")]
		private object System.Runtime.CompilerServices.IStrongBox.Value
		{
			[Token(Token = "0x6000B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B61")]
			set
			{
			}
		}

		[Token(Token = "0x6000B5E")]
		public StrongBox()
		{
		}

		[Token(Token = "0x6000B5F")]
		public StrongBox(T value)
		{
		}
	}
	[Token(Token = "0x2000253")]
	public interface IStrongBox
	{
		[Token(Token = "0x17000251")]
		object Value
		{
			[Token(Token = "0x6000B62")]
			get;
			[Token(Token = "0x6000B63")]
			set;
		}
	}
}
namespace System.Dynamic
{
	[Token(Token = "0x2000254")]
	public abstract class BinaryOperationBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x17000252")]
		public ExpressionType Operation
		{
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x278B908", Offset = "0x2787908", VA = "0x278B908")]
			[CompilerGenerated]
			get
			{
				return default(ExpressionType);
			}
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x278B910", Offset = "0x2787910", VA = "0x278B910")]
		public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg)
		{
			return null;
		}

		[Token(Token = "0x6000B66")]
		public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x278B920", Offset = "0x2787920", VA = "0x278B920", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000255")]
	[DebuggerTypeProxy(typeof(BindingRestrictionsProxy))]
	[DebuggerDisplay("{DebugView}")]
	public abstract class BindingRestrictions
	{
		[Token(Token = "0x2000256")]
		private sealed class TestBuilder
		{
			[Token(Token = "0x2000257")]
			private struct AndNode
			{
				[Token(Token = "0x4000426")]
				[FieldOffset(Offset = "0x0")]
				internal int Depth;

				[Token(Token = "0x4000427")]
				[FieldOffset(Offset = "0x8")]
				internal Expression Node;
			}

			[Token(Token = "0x4000424")]
			[FieldOffset(Offset = "0x10")]
			private readonly HashSet<BindingRestrictions> _unique;

			[Token(Token = "0x4000425")]
			[FieldOffset(Offset = "0x18")]
			private readonly Stack<AndNode> _tests;

			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x278C030", Offset = "0x2788030", VA = "0x278C030")]
			internal void Append(BindingRestrictions restrictions)
			{
			}

			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x278C1E4", Offset = "0x27881E4", VA = "0x278C1E4")]
			internal Expression ToExpression()
			{
				return null;
			}

			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x278C0BC", Offset = "0x27880BC", VA = "0x278C0BC")]
			private void Push(Expression node, int depth)
			{
			}

			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x278C2B8", Offset = "0x27882B8", VA = "0x278C2B8")]
			public TestBuilder()
			{
			}
		}

		[Token(Token = "0x2000258")]
		private sealed class MergedRestriction : BindingRestrictions
		{
			[Token(Token = "0x4000428")]
			[FieldOffset(Offset = "0x10")]
			internal readonly BindingRestrictions Left;

			[Token(Token = "0x4000429")]
			[FieldOffset(Offset = "0x18")]
			internal readonly BindingRestrictions Right;

			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x278BB00", Offset = "0x2787B00", VA = "0x278BB00")]
			internal MergedRestriction(BindingRestrictions left, BindingRestrictions right)
			{
			}

			[Token(Token = "0x6000B75")]
			[Address(RVA = "0x278C37C", Offset = "0x278837C", VA = "0x278C37C", Slot = "4")]
			internal override Expression GetExpression()
			{
				return null;
			}
		}

		[Token(Token = "0x2000259")]
		private sealed class CustomRestriction : BindingRestrictions
		{
			[Token(Token = "0x400042A")]
			[FieldOffset(Offset = "0x10")]
			private readonly Expression _expression;

			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x278BFC4", Offset = "0x2787FC4", VA = "0x278BFC4")]
			internal CustomRestriction(Expression expression)
			{
			}

			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x278C4C8", Offset = "0x27884C8", VA = "0x278C4C8", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x278C538", Offset = "0x2788538", VA = "0x278C538", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x278C568", Offset = "0x2788568", VA = "0x278C568", Slot = "4")]
			internal override Expression GetExpression()
			{
				return null;
			}
		}

		[Token(Token = "0x200025A")]
		private sealed class TypeRestriction : BindingRestrictions
		{
			[Token(Token = "0x400042B")]
			[FieldOffset(Offset = "0x10")]
			private readonly Expression _expression;

			[Token(Token = "0x400042C")]
			[FieldOffset(Offset = "0x18")]
			private readonly Type _type;

			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x278BC28", Offset = "0x2787C28", VA = "0x278BC28")]
			internal TypeRestriction(Expression parameter, Type type)
			{
			}

			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x278C570", Offset = "0x2788570", VA = "0x278C570", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x278C62C", Offset = "0x278862C", VA = "0x278C62C", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0x278C680", Offset = "0x2788680", VA = "0x278C680", Slot = "4")]
			internal override Expression GetExpression()
			{
				return null;
			}
		}

		[Token(Token = "0x200025B")]
		private sealed class InstanceRestriction : BindingRestrictions
		{
			[Token(Token = "0x400042D")]
			[FieldOffset(Offset = "0x10")]
			private readonly Expression _expression;

			[Token(Token = "0x400042E")]
			[FieldOffset(Offset = "0x18")]
			private readonly object _instance;

			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0x278BEA0", Offset = "0x2787EA0", VA = "0x278BEA0")]
			internal InstanceRestriction(Expression parameter, object instance)
			{
			}

			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x278C6E0", Offset = "0x27886E0", VA = "0x278C6E0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x278C76C", Offset = "0x278876C", VA = "0x278C76C", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000B81")]
			[Address(RVA = "0x278C7B8", Offset = "0x27887B8", VA = "0x278C7B8", Slot = "4")]
			internal override Expression GetExpression()
			{
				return null;
			}
		}

		[Token(Token = "0x200025C")]
		private sealed class BindingRestrictionsProxy
		{
		}

		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BindingRestrictions Empty;

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x278BA08", Offset = "0x2787A08", VA = "0x278BA08")]
		private BindingRestrictions()
		{
		}

		[Token(Token = "0x6000B69")]
		internal abstract Expression GetExpression();

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x278BA10", Offset = "0x2787A10", VA = "0x278BA10")]
		public BindingRestrictions Merge(BindingRestrictions restrictions)
		{
			return null;
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x278BB70", Offset = "0x2787B70", VA = "0x278BB70")]
		public static BindingRestrictions GetTypeRestriction(Expression expression, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x278BC98", Offset = "0x2787C98", VA = "0x278BC98")]
		internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj)
		{
			return null;
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x278BDE0", Offset = "0x2787DE0", VA = "0x278BDE0")]
		public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance)
		{
			return null;
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x278BF10", Offset = "0x2787F10", VA = "0x278BF10")]
		public Expression ToExpression()
		{
			return null;
		}
	}
	[Token(Token = "0x200025D")]
	public abstract class ConvertBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x17000253")]
		public Type Type
		{
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0x278CB30", Offset = "0x2788B30", VA = "0x278CB30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x278CB38", Offset = "0x2788B38", VA = "0x278CB38")]
		public DynamicMetaObject FallbackConvert(DynamicMetaObject target)
		{
			return null;
		}

		[Token(Token = "0x6000B84")]
		public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x278CB48", Offset = "0x2788B48", VA = "0x278CB48", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x200025E")]
	public abstract class CreateInstanceBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x278CBF8", Offset = "0x2788BF8", VA = "0x278CBF8")]
		public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000B87")]
		public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x278CC08", Offset = "0x2788C08", VA = "0x278CC08", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x200025F")]
	public abstract class DeleteIndexBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x278CCC8", Offset = "0x2788CC8", VA = "0x278CCC8", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x278CD84", Offset = "0x2788D84", VA = "0x278CD84")]
		public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes)
		{
			return null;
		}

		[Token(Token = "0x6000B8B")]
		public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
	}
	[Token(Token = "0x2000260")]
	public abstract class DeleteMemberBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x17000254")]
		public string Name
		{
			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0x278CD94", Offset = "0x2788D94", VA = "0x278CD94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000255")]
		public bool IgnoreCase
		{
			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0x278CD9C", Offset = "0x2788D9C", VA = "0x278CD9C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x278CDA4", Offset = "0x2788DA4", VA = "0x278CDA4")]
		public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target)
		{
			return null;
		}

		[Token(Token = "0x6000B8F")]
		public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x278CDB4", Offset = "0x2788DB4", VA = "0x278CDB4", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000261")]
	public class DynamicMetaObject
	{
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DynamicMetaObject[] EmptyMetaObjects;

		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object s_noValueSentinel;

		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _value;

		[Token(Token = "0x17000256")]
		public Expression Expression
		{
			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x278CF58", Offset = "0x2788F58", VA = "0x278CF58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000257")]
		public BindingRestrictions Restrictions
		{
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x278CF60", Offset = "0x2788F60", VA = "0x278CF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000258")]
		public object Value
		{
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x278BD54", Offset = "0x2787D54", VA = "0x278BD54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000259")]
		public bool HasValue
		{
			[Token(Token = "0x6000B96")]
			[Address(RVA = "0x278BD78", Offset = "0x2787D78", VA = "0x278BD78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025A")]
		public Type RuntimeType
		{
			[Token(Token = "0x6000B97")]
			[Address(RVA = "0x278CF68", Offset = "0x2788F68", VA = "0x278CF68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025B")]
		public Type LimitType
		{
			[Token(Token = "0x6000B98")]
			[Address(RVA = "0x278BE6C", Offset = "0x2787E6C", VA = "0x278BE6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x278CE64", Offset = "0x2788E64", VA = "0x278CE64")]
		public DynamicMetaObject(Expression expression, BindingRestrictions restrictions)
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x278CF34", Offset = "0x2788F34", VA = "0x278CF34")]
		public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x278CFE0", Offset = "0x2788FE0", VA = "0x278CFE0", Slot = "4")]
		public virtual DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x278D058", Offset = "0x2789058", VA = "0x278D058", Slot = "5")]
		public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x278D0C8", Offset = "0x27890C8", VA = "0x278D0C8", Slot = "6")]
		public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			return null;
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x278D140", Offset = "0x2789140", VA = "0x278D140", Slot = "7")]
		public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x278D1B8", Offset = "0x27891B8", VA = "0x278D1B8", Slot = "8")]
		public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			return null;
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x278D230", Offset = "0x2789230", VA = "0x278D230", Slot = "9")]
		public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			return null;
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x278D2B8", Offset = "0x27892B8", VA = "0x278D2B8", Slot = "10")]
		public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			return null;
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x278D338", Offset = "0x2789338", VA = "0x278D338", Slot = "11")]
		public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x278D3B0", Offset = "0x27893B0", VA = "0x278D3B0", Slot = "12")]
		public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x278D428", Offset = "0x2789428", VA = "0x278D428", Slot = "13")]
		public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x278D4A8", Offset = "0x27894A8", VA = "0x278D4A8", Slot = "14")]
		public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x278D518", Offset = "0x2789518", VA = "0x278D518", Slot = "15")]
		public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			return null;
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x278D598", Offset = "0x2789598", VA = "0x278D598", Slot = "16")]
		public virtual IEnumerable<string> GetDynamicMemberNames()
		{
			return null;
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x278D62C", Offset = "0x278962C", VA = "0x278D62C")]
		public static DynamicMetaObject Create(object value, Expression expression)
		{
			return null;
		}
	}
	[Token(Token = "0x2000262")]
	public abstract class DynamicMetaObjectBinder : CallSiteBinder
	{
		[Token(Token = "0x1700025C")]
		public virtual Type ReturnType
		{
			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0x278D91C", Offset = "0x278991C", VA = "0x278D91C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025D")]
		internal virtual bool IsStandardBinder
		{
			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x278E1E8", Offset = "0x278A1E8", VA = "0x278E1E8", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x278D8C4", Offset = "0x27898C4", VA = "0x278D8C4")]
		protected DynamicMetaObjectBinder()
		{
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x278D988", Offset = "0x2789988", VA = "0x278D988", Slot = "4")]
		public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel)
		{
			return null;
		}

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x278DF90", Offset = "0x2789F90", VA = "0x278DF90")]
		private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters)
		{
			return null;
		}

		[Token(Token = "0x6000BAC")]
		public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x278E128", Offset = "0x278A128", VA = "0x278E128")]
		public Expression GetUpdateExpression(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000263")]
	internal class ExpandoClass
	{
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x10")]
		private readonly string[] _keys;

		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _hashCode;

		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, List<WeakReference>> _transitions;

		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly ExpandoClass Empty;

		[Token(Token = "0x1700025E")]
		internal string[] Keys
		{
			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x278EA74", Offset = "0x278AA74", VA = "0x278EA74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x278E1F0", Offset = "0x278A1F0", VA = "0x278E1F0")]
		internal ExpandoClass()
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x278E2A0", Offset = "0x278A2A0", VA = "0x278E2A0")]
		internal ExpandoClass(string[] keys, int hashCode)
		{
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x278E2D0", Offset = "0x278A2D0", VA = "0x278E2D0")]
		internal ExpandoClass FindNewClass(string newKey)
		{
			return null;
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x278E69C", Offset = "0x278A69C", VA = "0x278E69C")]
		private List<WeakReference> GetTransitionList(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x278E7C8", Offset = "0x278A7C8", VA = "0x278E7C8")]
		internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x278E958", Offset = "0x278A958", VA = "0x278E958")]
		internal int GetValueIndexCaseSensitive(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x278E7D8", Offset = "0x278A7D8", VA = "0x278E7D8")]
		private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000264")]
	public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged
	{
		[Token(Token = "0x2000265")]
		private sealed class KeyCollectionDebugView
		{
		}

		[Token(Token = "0x2000266")]
		[DebuggerTypeProxy(typeof(KeyCollectionDebugView))]
		[DebuggerDisplay("Count = {Count}")]
		private class KeyCollection : ICollection<string>, IEnumerable<string>, IEnumerable
		{
			[Token(Token = "0x2000267")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__15 : IEnumerator<string>, IDisposable, IEnumerator
			{
				[Token(Token = "0x4000449")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				[Token(Token = "0x400044A")]
				[FieldOffset(Offset = "0x18")]
				private string <>2__current;

				[Token(Token = "0x400044B")]
				[FieldOffset(Offset = "0x20")]
				public KeyCollection <>4__this;

				[Token(Token = "0x400044C")]
				[FieldOffset(Offset = "0x28")]
				private int <i>5__2;

				[Token(Token = "0x400044D")]
				[FieldOffset(Offset = "0x2C")]
				private int <n>5__3;

				[Token(Token = "0x17000267")]
				private string System.Collections.Generic.IEnumerator<System.String>.Current
				{
					[Token(Token = "0x6000BE7")]
					[Address(RVA = "0x2790274", Offset = "0x278C274", VA = "0x2790274", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x17000268")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000BE9")]
					[Address(RVA = "0x27902B4", Offset = "0x278C2B4", VA = "0x27902B4", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000BE4")]
				[Address(RVA = "0x27900CC", Offset = "0x278C0CC", VA = "0x27900CC")]
				[DebuggerHidden]
				public <GetEnumerator>d__15(int <>1__state)
				{
				}

				[Token(Token = "0x6000BE5")]
				[Address(RVA = "0x27900F4", Offset = "0x278C0F4", VA = "0x27900F4", Slot = "5")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x6000BE6")]
				[Address(RVA = "0x27900F8", Offset = "0x278C0F8", VA = "0x27900F8", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x6000BE8")]
				[Address(RVA = "0x279027C", Offset = "0x278C27C", VA = "0x279027C", Slot = "8")]
				[DebuggerHidden]
				private void System.Collections.IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x4000445")]
			[FieldOffset(Offset = "0x10")]
			private readonly ExpandoObject _expando;

			[Token(Token = "0x4000446")]
			[FieldOffset(Offset = "0x18")]
			private readonly int _expandoVersion;

			[Token(Token = "0x4000447")]
			[FieldOffset(Offset = "0x1C")]
			private readonly int _expandoCount;

			[Token(Token = "0x4000448")]
			[FieldOffset(Offset = "0x20")]
			private readonly ExpandoData _expandoData;

			[Token(Token = "0x17000265")]
			public int Count
			{
				[Token(Token = "0x6000BDF")]
				[Address(RVA = "0x2790018", Offset = "0x278C018", VA = "0x2790018", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000266")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6000BE0")]
				[Address(RVA = "0x2790030", Offset = "0x278C030", VA = "0x2790030", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x278ED28", Offset = "0x278AD28", VA = "0x278ED28")]
			internal KeyCollection(ExpandoObject expando)
			{
			}

			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x278FBF0", Offset = "0x278BBF0", VA = "0x278FBF0")]
			private void CheckVersion()
			{
			}

			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x278FC50", Offset = "0x278BC50", VA = "0x278FC50", Slot = "6")]
			public void Add(string item)
			{
			}

			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x278FC78", Offset = "0x278BC78", VA = "0x278FC78", Slot = "7")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x278FCA0", Offset = "0x278BCA0", VA = "0x278FCA0", Slot = "8")]
			public bool Contains(string item)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x278FD94", Offset = "0x278BD94", VA = "0x278FD94", Slot = "9")]
			public void CopyTo(string[] array, int arrayIndex)
			{
			}

			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x2790038", Offset = "0x278C038", VA = "0x2790038", Slot = "10")]
			public bool Remove(string item)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x2790060", Offset = "0x278C060", VA = "0x2790060", Slot = "11")]
			[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
			public IEnumerator<string> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x27900C8", Offset = "0x278C0C8", VA = "0x27900C8", Slot = "12")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000268")]
		private sealed class ValueCollectionDebugView
		{
		}

		[Token(Token = "0x2000269")]
		[DebuggerTypeProxy(typeof(ValueCollectionDebugView))]
		[DebuggerDisplay("Count = {Count}")]
		private class ValueCollection : ICollection<object>, IEnumerable<object>, IEnumerable
		{
			[Token(Token = "0x200026A")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IDisposable, IEnumerator
			{
				[Token(Token = "0x4000452")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				[Token(Token = "0x4000453")]
				[FieldOffset(Offset = "0x18")]
				private object <>2__current;

				[Token(Token = "0x4000454")]
				[FieldOffset(Offset = "0x20")]
				public ValueCollection <>4__this;

				[Token(Token = "0x4000455")]
				[FieldOffset(Offset = "0x28")]
				private ExpandoData <data>5__2;

				[Token(Token = "0x4000456")]
				[FieldOffset(Offset = "0x30")]
				private int <i>5__3;

				[Token(Token = "0x1700026B")]
				private object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[Token(Token = "0x6000BF8")]
					[Address(RVA = "0x2790A7C", Offset = "0x278CA7C", VA = "0x2790A7C", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x1700026C")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000BFA")]
					[Address(RVA = "0x2790ABC", Offset = "0x278CABC", VA = "0x2790ABC", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000BF5")]
				[Address(RVA = "0x279092C", Offset = "0x278C92C", VA = "0x279092C")]
				[DebuggerHidden]
				public <GetEnumerator>d__15(int <>1__state)
				{
				}

				[Token(Token = "0x6000BF6")]
				[Address(RVA = "0x2790958", Offset = "0x278C958", VA = "0x2790958", Slot = "5")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x6000BF7")]
				[Address(RVA = "0x279095C", Offset = "0x278C95C", VA = "0x279095C", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x6000BF9")]
				[Address(RVA = "0x2790A84", Offset = "0x278CA84", VA = "0x2790A84", Slot = "8")]
				[DebuggerHidden]
				private void System.Collections.IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x400044E")]
			[FieldOffset(Offset = "0x10")]
			private readonly ExpandoObject _expando;

			[Token(Token = "0x400044F")]
			[FieldOffset(Offset = "0x18")]
			private readonly int _expandoVersion;

			[Token(Token = "0x4000450")]
			[FieldOffset(Offset = "0x1C")]
			private readonly int _expandoCount;

			[Token(Token = "0x4000451")]
			[FieldOffset(Offset = "0x20")]
			private readonly ExpandoData _expandoData;

			[Token(Token = "0x17000269")]
			public int Count
			{
				[Token(Token = "0x6000BF0")]
				[Address(RVA = "0x2790884", Offset = "0x278C884", VA = "0x2790884", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700026A")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6000BF1")]
				[Address(RVA = "0x279089C", Offset = "0x278C89C", VA = "0x279089C", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x27902BC", Offset = "0x278C2BC", VA = "0x27902BC")]
			internal ValueCollection(ExpandoObject expando)
			{
			}

			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x27903A8", Offset = "0x278C3A8", VA = "0x27903A8")]
			private void CheckVersion()
			{
			}

			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x2790408", Offset = "0x278C408", VA = "0x2790408", Slot = "6")]
			public void Add(object item)
			{
			}

			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x2790430", Offset = "0x278C430", VA = "0x2790430", Slot = "7")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x2790458", Offset = "0x278C458", VA = "0x2790458", Slot = "8")]
			public bool Contains(object item)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x27905B8", Offset = "0x278C5B8", VA = "0x27905B8", Slot = "9")]
			public void CopyTo(object[] array, int arrayIndex)
			{
			}

			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x27908A4", Offset = "0x278C8A4", VA = "0x27908A4", Slot = "10")]
			public bool Remove(object item)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x27908CC", Offset = "0x278C8CC", VA = "0x27908CC", Slot = "11")]
			[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
			public IEnumerator<object> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x2790954", Offset = "0x278C954", VA = "0x2790954", Slot = "12")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200026B")]
		private class MetaExpando : DynamicMetaObject
		{
			[Token(Token = "0x200026D")]
			[CompilerGenerated]
			private sealed class <GetDynamicMemberNames>d__6 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator
			{
				[Token(Token = "0x4000459")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				[Token(Token = "0x400045A")]
				[FieldOffset(Offset = "0x18")]
				private string <>2__current;

				[Token(Token = "0x400045B")]
				[FieldOffset(Offset = "0x20")]
				private int <>l__initialThreadId;

				[Token(Token = "0x400045C")]
				[FieldOffset(Offset = "0x28")]
				public MetaExpando <>4__this;

				[Token(Token = "0x400045D")]
				[FieldOffset(Offset = "0x30")]
				private ExpandoData <expandoData>5__2;

				[Token(Token = "0x400045E")]
				[FieldOffset(Offset = "0x38")]
				private ExpandoClass <klass>5__3;

				[Token(Token = "0x400045F")]
				[FieldOffset(Offset = "0x40")]
				private int <i>5__4;

				[Token(Token = "0x1700026E")]
				private string System.Collections.Generic.IEnumerator<System.String>.Current
				{
					[Token(Token = "0x6000C0C")]
					[Address(RVA = "0x2792158", Offset = "0x278E158", VA = "0x2792158", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x1700026F")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000C0E")]
					[Address(RVA = "0x2792198", Offset = "0x278E198", VA = "0x2792198", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000C09")]
				[Address(RVA = "0x2791EC8", Offset = "0x278DEC8", VA = "0x2791EC8")]
				[DebuggerHidden]
				public <GetDynamicMemberNames>d__6(int <>1__state)
				{
				}

				[Token(Token = "0x6000C0A")]
				[Address(RVA = "0x279201C", Offset = "0x278E01C", VA = "0x279201C", Slot = "7")]
				[DebuggerHidden]
				private void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x6000C0B")]
				[Address(RVA = "0x2792020", Offset = "0x278E020", VA = "0x2792020", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x6000C0D")]
				[Address(RVA = "0x2792160", Offset = "0x278E160", VA = "0x2792160", Slot = "10")]
				[DebuggerHidden]
				private void System.Collections.IEnumerator.Reset()
				{
				}

				[Token(Token = "0x6000C0F")]
				[Address(RVA = "0x27921A0", Offset = "0x278E1A0", VA = "0x27921A0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000C10")]
				[Address(RVA = "0x279223C", Offset = "0x278E23C", VA = "0x279223C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System.Collections.IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x1700026D")]
			public new ExpandoObject Value
			{
				[Token(Token = "0x6000C06")]
				[Address(RVA = "0x2791134", Offset = "0x278D134", VA = "0x2791134")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x2790AC4", Offset = "0x278CAC4", VA = "0x2790AC4")]
			public MetaExpando(Expression expression, ExpandoObject value)
			{
			}

			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x2790B6C", Offset = "0x278CB6C", VA = "0x2790B6C")]
			private DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke)
			{
				return null;
			}

			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x2791534", Offset = "0x278D534", VA = "0x2791534", Slot = "5")]
			public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
			{
				return null;
			}

			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x27915DC", Offset = "0x278D5DC", VA = "0x27915DC", Slot = "11")]
			public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
			{
				return null;
			}

			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x279171C", Offset = "0x278D71C", VA = "0x279171C", Slot = "6")]
			public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
			{
				return null;
			}

			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x2791BA4", Offset = "0x278DBA4", VA = "0x2791BA4", Slot = "7")]
			public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
			{
				return null;
			}

			[Token(Token = "0x6000C01")]
			[Address(RVA = "0x2791E54", Offset = "0x278DE54", VA = "0x2791E54", Slot = "16")]
			[IteratorStateMachine(typeof(<GetDynamicMemberNames>d__6))]
			public override IEnumerable<string> GetDynamicMemberNames()
			{
				return null;
			}

			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x2791280", Offset = "0x278D280", VA = "0x2791280")]
			private DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds)
			{
				return null;
			}

			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x2791AF4", Offset = "0x278DAF4", VA = "0x2791AF4")]
			private ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index)
			{
				return null;
			}

			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x2791198", Offset = "0x278D198", VA = "0x2791198")]
			private Expression GetLimitedSelf()
			{
				return null;
			}

			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x2791EFC", Offset = "0x278DEFC", VA = "0x2791EFC")]
			private BindingRestrictions GetRestrictions()
			{
				return null;
			}
		}

		[Token(Token = "0x200026E")]
		private class ExpandoData
		{
			[Token(Token = "0x4000460")]
			[FieldOffset(Offset = "0x0")]
			internal static ExpandoData Empty;

			[Token(Token = "0x4000461")]
			[FieldOffset(Offset = "0x10")]
			internal readonly ExpandoClass Class;

			[Token(Token = "0x4000462")]
			[FieldOffset(Offset = "0x18")]
			private readonly object[] _dataArray;

			[Token(Token = "0x4000463")]
			[FieldOffset(Offset = "0x20")]
			private int _version;

			[Token(Token = "0x17000270")]
			internal object this[int index]
			{
				[Token(Token = "0x6000C11")]
				[Address(RVA = "0x2790244", Offset = "0x278C244", VA = "0x2790244")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000C12")]
				[Address(RVA = "0x2792240", Offset = "0x278E240", VA = "0x2792240")]
				set
				{
				}
			}

			[Token(Token = "0x17000271")]
			internal int Version
			{
				[Token(Token = "0x6000C13")]
				[Address(RVA = "0x27922B0", Offset = "0x278E2B0", VA = "0x27922B0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000272")]
			internal int Length
			{
				[Token(Token = "0x6000C14")]
				[Address(RVA = "0x27922B8", Offset = "0x278E2B8", VA = "0x27922B8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x27922D0", Offset = "0x278E2D0", VA = "0x27922D0")]
			private ExpandoData()
			{
			}

			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x27923AC", Offset = "0x278E3AC", VA = "0x27923AC")]
			internal ExpandoData(ExpandoClass klass, object[] data, int version)
			{
			}

			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x27923E8", Offset = "0x278E3E8", VA = "0x27923E8")]
			internal ExpandoData UpdateClass(ExpandoClass newClass)
			{
				return null;
			}

			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x2792588", Offset = "0x278E588", VA = "0x2792588")]
			private static int GetAlignedSize(int len)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200026F")]
		[CompilerGenerated]
		private sealed class <GetExpandoEnumerator>d__51 : IEnumerator<KeyValuePair<string, object>>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000464")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000465")]
			[FieldOffset(Offset = "0x18")]
			private KeyValuePair<string, object> <>2__current;

			[Token(Token = "0x4000466")]
			[FieldOffset(Offset = "0x28")]
			public ExpandoObject <>4__this;

			[Token(Token = "0x4000467")]
			[FieldOffset(Offset = "0x30")]
			public int version;

			[Token(Token = "0x4000468")]
			[FieldOffset(Offset = "0x38")]
			public ExpandoData data;

			[Token(Token = "0x4000469")]
			[FieldOffset(Offset = "0x40")]
			private int <i>5__2;

			[Token(Token = "0x17000273")]
			private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current
			{
				[Token(Token = "0x6000C1D")]
				[Address(RVA = "0x27927BC", Offset = "0x278E7BC", VA = "0x27927BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, object>);
				}
			}

			[Token(Token = "0x17000274")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C1F")]
				[Address(RVA = "0x2792800", Offset = "0x278E800", VA = "0x2792800", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x27925EC", Offset = "0x278E5EC", VA = "0x27925EC")]
			[DebuggerHidden]
			public <GetExpandoEnumerator>d__51(int <>1__state)
			{
			}

			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x2792614", Offset = "0x278E614", VA = "0x2792614", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0x2792618", Offset = "0x278E618", VA = "0x2792618", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0x27927C8", Offset = "0x278E7C8", VA = "0x27927C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MethodInfo s_expandoTryGetValue;

		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly MethodInfo s_expandoTrySetValue;

		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly MethodInfo s_expandoTryDeleteValue;

		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x18")]
		private static readonly MethodInfo s_expandoPromoteClass;

		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x20")]
		private static readonly MethodInfo s_expandoCheckVersion;

		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x10")]
		internal readonly object LockObject;

		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x18")]
		private ExpandoData _data;

		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x20")]
		private int _count;

		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly object Uninitialized;

		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x28")]
		private PropertyChangedEventHandler _propertyChanged;

		[Token(Token = "0x1700025F")]
		internal ExpandoClass Class
		{
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x278B614", Offset = "0x2787614", VA = "0x278B614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000260")]
		private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x278ECD0", Offset = "0x278ACD0", VA = "0x278ECD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000261")]
		private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values
		{
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x278EE14", Offset = "0x278AE14", VA = "0x278EE14", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000262")]
		private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item
		{
			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x278EE70", Offset = "0x278AE70", VA = "0x278EE70", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x278EED4", Offset = "0x278AED4", VA = "0x278EED4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000263")]
		private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x278F0E0", Offset = "0x278B0E0", VA = "0x278F0E0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000264")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly
		{
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x278F0E8", Offset = "0x278B0E8", VA = "0x278F0E8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		private event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		{
			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x278F904", Offset = "0x278B904", VA = "0x278F904", Slot = "22")]
			add
			{
			}
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x278F984", Offset = "0x278B984", VA = "0x278F984", Slot = "23")]
			remove
			{
			}
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x278EAD4", Offset = "0x278AAD4", VA = "0x278EAD4")]
		public ExpandoObject()
		{
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x278AD78", Offset = "0x2786D78", VA = "0x278AD78")]
		internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x278AEC8", Offset = "0x2786EC8", VA = "0x278AEC8")]
		internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add)
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x278B2F8", Offset = "0x27872F8", VA = "0x278B2F8")]
		internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x278E9CC", Offset = "0x278A9CC", VA = "0x278E9CC")]
		internal bool IsDeletedMember(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x278EB6C", Offset = "0x278AB6C", VA = "0x278EB6C")]
		private ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass)
		{
			return null;
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x278B63C", Offset = "0x278763C", VA = "0x278B63C")]
		internal void PromoteClass(object oldClass, object newClass)
		{
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x278EBA4", Offset = "0x278ABA4", VA = "0x278EBA4", Slot = "4")]
		private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
		{
			return null;
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x278EC10", Offset = "0x278AC10", VA = "0x278EC10")]
		private void TryAddMember(string key, object value)
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x278EC8C", Offset = "0x278AC8C", VA = "0x278EC8C")]
		private bool TryGetValueForKey(string key, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x278ECA4", Offset = "0x278ACA4", VA = "0x278ECA4")]
		private bool ExpandoContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x278EF50", Offset = "0x278AF50", VA = "0x278EF50", Slot = "10")]
		private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value)
		{
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x278EF54", Offset = "0x278AF54", VA = "0x278EF54", Slot = "9")]
		private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x278F028", Offset = "0x278B028", VA = "0x278F028", Slot = "11")]
		private bool System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x278F0C8", Offset = "0x278B0C8", VA = "0x278F0C8", Slot = "12")]
		private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x278F0F0", Offset = "0x278B0F0", VA = "0x278F0F0", Slot = "15")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item)
		{
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x278F150", Offset = "0x278B150", VA = "0x278F150", Slot = "16")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear()
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x278F374", Offset = "0x278B374", VA = "0x278F374", Slot = "17")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x278F40C", Offset = "0x278B40C", VA = "0x278F40C", Slot = "18")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x278F7E8", Offset = "0x278B7E8", VA = "0x278F7E8", Slot = "19")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x278F854", Offset = "0x278B854", VA = "0x278F854", Slot = "20")]
		private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x278F8EC", Offset = "0x278B8EC", VA = "0x278F8EC", Slot = "21")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x278F86C", Offset = "0x278B86C", VA = "0x278F86C")]
		[IteratorStateMachine(typeof(<GetExpandoEnumerator>d__51))]
		private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoData data, int version)
		{
			return null;
		}
	}
	[Token(Token = "0x2000270")]
	public abstract class GetIndexBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x279285C", Offset = "0x278E85C", VA = "0x279285C", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x2792914", Offset = "0x278E914", VA = "0x2792914")]
		public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes)
		{
			return null;
		}

		[Token(Token = "0x6000C22")]
		public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
	}
	[Token(Token = "0x2000271")]
	public abstract class GetMemberBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x17000275")]
		public sealed override Type ReturnType
		{
			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x2792998", Offset = "0x278E998", VA = "0x2792998", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000276")]
		public string Name
		{
			[Token(Token = "0x6000C25")]
			[Address(RVA = "0x2792A04", Offset = "0x278EA04", VA = "0x2792A04")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000277")]
		public bool IgnoreCase
		{
			[Token(Token = "0x6000C26")]
			[Address(RVA = "0x2792A0C", Offset = "0x278EA0C", VA = "0x2792A0C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000278")]
		internal sealed override bool IsStandardBinder
		{
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x2792AF0", Offset = "0x278EAF0", VA = "0x2792AF0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x2792924", Offset = "0x278E924", VA = "0x2792924")]
		protected GetMemberBinder(string name, bool ignoreCase)
		{
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x27915CC", Offset = "0x278D5CC", VA = "0x27915CC")]
		public DynamicMetaObject FallbackGetMember(DynamicMetaObject target)
		{
			return null;
		}

		[Token(Token = "0x6000C28")]
		public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x2792A14", Offset = "0x278EA14", VA = "0x2792A14", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000272")]
	public interface IDynamicMetaObjectProvider
	{
		[Token(Token = "0x6000C2B")]
		DynamicMetaObject GetMetaObject(Expression parameter);
	}
	[Token(Token = "0x2000273")]
	public abstract class InvokeBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x2792AF8", Offset = "0x278EAF8", VA = "0x2792AF8")]
		public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000C2D")]
		public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x2792B08", Offset = "0x278EB08", VA = "0x2792B08", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000274")]
	public abstract class InvokeMemberBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x17000279")]
		public string Name
		{
			[Token(Token = "0x6000C2F")]
			[Address(RVA = "0x2792BC0", Offset = "0x278EBC0", VA = "0x2792BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027A")]
		public bool IgnoreCase
		{
			[Token(Token = "0x6000C30")]
			[Address(RVA = "0x2792BC8", Offset = "0x278EBC8", VA = "0x2792BC8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x2792BD0", Offset = "0x278EBD0", VA = "0x2792BD0", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x279170C", Offset = "0x278D70C", VA = "0x279170C")]
		public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000C33")]
		public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

		[Token(Token = "0x6000C34")]
		public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
	}
	[Token(Token = "0x2000275")]
	public abstract class SetIndexBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x2792C88", Offset = "0x278EC88", VA = "0x2792C88", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x2792DB4", Offset = "0x278EDB4", VA = "0x2792DB4")]
		public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			return null;
		}

		[Token(Token = "0x6000C37")]
		public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
	}
	[Token(Token = "0x2000276")]
	public abstract class SetMemberBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x1700027B")]
		public sealed override Type ReturnType
		{
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x2792E38", Offset = "0x278EE38", VA = "0x2792E38", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027C")]
		public string Name
		{
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x2792EA4", Offset = "0x278EEA4", VA = "0x2792EA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027D")]
		public bool IgnoreCase
		{
			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0x2792EAC", Offset = "0x278EEAC", VA = "0x2792EAC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700027E")]
		internal sealed override bool IsStandardBinder
		{
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x2792F88", Offset = "0x278EF88", VA = "0x2792F88", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x2792DC4", Offset = "0x278EDC4", VA = "0x2792DC4")]
		protected SetMemberBinder(string name, bool ignoreCase)
		{
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x2792EB4", Offset = "0x278EEB4", VA = "0x2792EB4", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x2792F90", Offset = "0x278EF90", VA = "0x2792F90")]
		public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value)
		{
			return null;
		}

		[Token(Token = "0x6000C3F")]
		public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
	}
	[Token(Token = "0x2000277")]
	public abstract class UnaryOperationBinder : DynamicMetaObjectBinder
	{
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x2792FA0", Offset = "0x278EFA0", VA = "0x2792FA0")]
		public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target)
		{
			return null;
		}

		[Token(Token = "0x6000C41")]
		public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x2792FB0", Offset = "0x278EFB0", VA = "0x2792FB0", Slot = "7")]
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
}
namespace System.Dynamic.Utils
{
	[Token(Token = "0x2000278")]
	internal sealed class CacheDict<TKey, TValue>
	{
		[Token(Token = "0x2000279")]
		private sealed class Entry
		{
			[Token(Token = "0x4000472")]
			[FieldOffset(Offset = "0x0")]
			internal readonly int _hash;

			[Token(Token = "0x4000473")]
			[FieldOffset(Offset = "0x0")]
			internal readonly TKey _key;

			[Token(Token = "0x4000474")]
			[FieldOffset(Offset = "0x0")]
			internal readonly TValue _value;

			[Token(Token = "0x6000C48")]
			internal Entry(int hash, TKey key, TValue value)
			{
			}
		}

		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _mask;

		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x0")]
		private readonly Entry[] _entries;

		[Token(Token = "0x1700027F")]
		internal TKey this[TKey key]
		{
			[Token(Token = "0x6000C47")]
			set
			{
			}
		}

		[Token(Token = "0x6000C43")]
		internal CacheDict(int size)
		{
		}

		[Token(Token = "0x6000C44")]
		private static int AlignSize(int size)
		{
			return default(int);
		}

		[Token(Token = "0x6000C45")]
		internal bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C46")]
		internal void Add(TKey key, TValue value)
		{
		}
	}
	[Token(Token = "0x200027A")]
	internal static class CollectionExtensions
	{
		[Token(Token = "0x6000C49")]
		public static TrueReadOnlyCollection<T> AddFirst<T>(this ReadOnlyCollection<T> list, T item)
		{
			return null;
		}

		[Token(Token = "0x6000C4A")]
		public static T[] AddLast<T>(this T[] array, T item)
		{
			return null;
		}

		[Token(Token = "0x6000C4B")]
		public static T[] RemoveFirst<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x6000C4C")]
		public static T[] RemoveLast<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x6000C4D")]
		public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> enumerable)
		{
			return null;
		}
	}
	[Token(Token = "0x200027B")]
	internal static class ContractUtils
	{
		[Token(Token = "0x17000280")]
		[ExcludeFromCodeCoverage]
		public static Exception Unreachable
		{
			[Token(Token = "0x6000C4E")]
			[Address(RVA = "0x279305C", Offset = "0x278F05C", VA = "0x279305C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x2792ABC", Offset = "0x278EABC", VA = "0x2792ABC")]
		public static void Requires(bool precondition, string paramName)
		{
		}

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x2790838", Offset = "0x278C838", VA = "0x2790838")]
		public static void RequiresNotNull(object value, string paramName)
		{
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x27930C8", Offset = "0x278F0C8", VA = "0x27930C8")]
		public static void RequiresNotNull(object value, string paramName, int index)
		{
		}

		[Token(Token = "0x6000C52")]
		public static void RequiresNotNullItems<T>(IList<T> array, string arrayName)
		{
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x2793120", Offset = "0x278F120", VA = "0x2793120")]
		private static string GetParamName(string paramName, int index)
		{
			return null;
		}

		[Token(Token = "0x6000C54")]
		public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName)
		{
		}
	}
	[Token(Token = "0x200027C")]
	internal static class EmptyReadOnlyCollection<T>
	{
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ReadOnlyCollection<T> Instance;
	}
	[Token(Token = "0x200027D")]
	internal static class ExpressionUtils
	{
		[Token(Token = "0x6000C56")]
		public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection)
		{
			return null;
		}

		[Token(Token = "0x6000C57")]
		public static T ReturnObject<T>(object collectionOrT) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x27931B4", Offset = "0x278F1B4", VA = "0x27931B4")]
		public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName)
		{
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x27934F8", Offset = "0x278F4F8", VA = "0x27934F8")]
		public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis)
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x27935A4", Offset = "0x278F5A4", VA = "0x27935A4")]
		public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1)
		{
			return null;
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x2793C48", Offset = "0x278FC48", VA = "0x2793C48")]
		public static void RequiresCanRead(Expression expression, string paramName)
		{
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x27937B4", Offset = "0x278F7B4", VA = "0x27937B4")]
		public static void RequiresCanRead(Expression expression, string paramName, int idx)
		{
		}

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x2793B20", Offset = "0x278FB20", VA = "0x2793B20")]
		public static bool TryQuote(Type parameterType, ref Expression argument)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x2793464", Offset = "0x278F464", VA = "0x2793464")]
		internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind)
		{
			return null;
		}

		[Token(Token = "0x6000C5F")]
		internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) where T : class
		{
			return default(bool);
		}

		[Token(Token = "0x6000C60")]
		private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) where T : class
		{
			return default(bool);
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x2793DF8", Offset = "0x278FDF8", VA = "0x2793DF8")]
		public static void ValidateArgumentCount(this LambdaExpression lambda)
		{
		}
	}
	[Token(Token = "0x200027E")]
	internal static class ExpressionVisitorUtils
	{
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x2793ECC", Offset = "0x278FECC", VA = "0x2793ECC")]
		public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block)
		{
			return null;
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x2794070", Offset = "0x2790070", VA = "0x2794070")]
		public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName)
		{
			return null;
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x279435C", Offset = "0x279035C", VA = "0x279435C")]
		public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes)
		{
			return null;
		}
	}
	[Token(Token = "0x200027F")]
	internal static class TypeExtensions
	{
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache;

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x27945F0", Offset = "0x27905F0", VA = "0x27945F0")]
		public static MethodInfo GetAnyStaticMethodValidated(this Type type, string name, Type[] types)
		{
			return null;
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x2794694", Offset = "0x2790694", VA = "0x2794694")]
		private static bool MatchesArgumentTypes(this MethodInfo mi, Type[] argTypes)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x27947DC", Offset = "0x27907DC", VA = "0x27947DC")]
		public static Type GetReturnType(this MethodBase mi)
		{
			return null;
		}

		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x279488C", Offset = "0x279088C", VA = "0x279488C")]
		public static TypeCode GetTypeCode(this Type type)
		{
			return default(TypeCode);
		}

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x2793CEC", Offset = "0x278FCEC", VA = "0x2793CEC")]
		internal static ParameterInfo[] GetParametersCached(this MethodBase method)
		{
			return null;
		}
	}
	[Token(Token = "0x2000280")]
	internal static class TypeUtils
	{
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] s_arrayAssignableInterfaces;

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x2794974", Offset = "0x2790974", VA = "0x2794974")]
		public static Type GetNonNullableType(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x2794AD0", Offset = "0x2790AD0", VA = "0x2794AD0")]
		public static Type GetNullableType(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x2794A04", Offset = "0x2790A04", VA = "0x2794A04")]
		public static bool IsNullableType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x2794C14", Offset = "0x2790C14", VA = "0x2794C14")]
		public static bool IsNullableOrReferenceType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x2794C90", Offset = "0x2790C90", VA = "0x2794C90")]
		public static bool IsBool(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x2794D44", Offset = "0x2790D44", VA = "0x2794D44")]
		public static bool IsNumeric(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x2794E00", Offset = "0x2790E00", VA = "0x2794E00")]
		public static bool IsInteger(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x2794EBC", Offset = "0x2790EBC", VA = "0x2794EBC")]
		public static bool IsArithmetic(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x2794F78", Offset = "0x2790F78", VA = "0x2794F78")]
		public static bool IsUnsignedInt(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x2795038", Offset = "0x2791038", VA = "0x2795038")]
		public static bool IsIntegerOrBool(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x27950F8", Offset = "0x27910F8", VA = "0x27950F8")]
		public static bool IsNumericOrBool(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x2795178", Offset = "0x2791178", VA = "0x2795178")]
		public static bool IsValidInstanceType(MemberInfo member, Type instanceType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x2795590", Offset = "0x2791590", VA = "0x2795590")]
		public static bool HasIdentityPrimitiveOrNullableConversionTo(this Type source, Type dest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x2795874", Offset = "0x2791874", VA = "0x2795874")]
		public static bool HasReferenceConversionTo(this Type source, Type dest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x2795D54", Offset = "0x2791D54", VA = "0x2795D54")]
		private static bool StrictHasReferenceConversionTo(this Type source, Type dest, bool skipNonArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x2796058", Offset = "0x2792058", VA = "0x2796058")]
		private static bool HasArrayToInterfaceConversion(Type source, Type dest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x2796218", Offset = "0x2792218", VA = "0x2796218")]
		private static bool HasInterfaceToArrayConversion(Type source, Type dest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x2796404", Offset = "0x2792404", VA = "0x2796404")]
		private static bool IsCovariant(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x279642C", Offset = "0x279242C", VA = "0x279642C")]
		private static bool IsContravariant(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x2796454", Offset = "0x2792454", VA = "0x2796454")]
		private static bool IsInvariant(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x2796480", Offset = "0x2792480", VA = "0x2796480")]
		private static bool IsDelegate(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x2795A5C", Offset = "0x2791A5C", VA = "0x2795A5C")]
		public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x27957BC", Offset = "0x27917BC", VA = "0x27957BC")]
		public static bool IsConvertible(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x2796518", Offset = "0x2792518", VA = "0x2796518")]
		public static bool HasReferenceEquality(Type left, Type right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x27965F8", Offset = "0x27925F8", VA = "0x27965F8")]
		public static bool HasBuiltInEqualityOperator(Type left, Type right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x27967DC", Offset = "0x27927DC", VA = "0x27967DC")]
		public static bool IsImplicitlyConvertibleTo(this Type source, Type destination)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x2796C70", Offset = "0x2792C70", VA = "0x2796C70")]
		public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType)
		{
			return null;
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x2796E88", Offset = "0x2792E88", VA = "0x2796E88")]
		private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo)
		{
			return null;
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x27968E8", Offset = "0x27928E8", VA = "0x27968E8")]
		private static bool IsImplicitNumericConversion(Type source, Type destination)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x27963DC", Offset = "0x27923DC", VA = "0x27963DC")]
		private static bool IsImplicitReferenceConversion(Type source, Type destination)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x2796A58", Offset = "0x2792A58", VA = "0x2796A58")]
		private static bool IsImplicitBoxingConversion(Type source, Type destination)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x2796BC8", Offset = "0x2792BC8", VA = "0x2796BC8")]
		private static bool IsImplicitNullableConversion(Type source, Type destination)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x2797054", Offset = "0x2793054", VA = "0x2797054")]
		public static Type FindGenericType(Type definition, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x27974C8", Offset = "0x27934C8", VA = "0x27974C8")]
		public static MethodInfo GetBooleanOperator(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x279763C", Offset = "0x279363C", VA = "0x279763C")]
		public static Type GetNonRefType(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x2791F54", Offset = "0x278DF54", VA = "0x2791F54")]
		public static bool AreEquivalent(Type t1, Type t2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x2793A58", Offset = "0x278FA58", VA = "0x2793A58")]
		public static bool AreReferenceAssignable(Type dest, Type src)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x2793C50", Offset = "0x278FC50", VA = "0x2793C50")]
		public static bool IsSameOrSubclass(Type type, Type subType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x279767C", Offset = "0x279367C", VA = "0x279767C")]
		public static void ValidateType(Type type, string paramName)
		{
		}

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x279396C", Offset = "0x278F96C", VA = "0x279396C")]
		public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer)
		{
		}

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x27976E8", Offset = "0x27936E8", VA = "0x27976E8")]
		public static bool ValidateType(Type type, string paramName, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x2797814", Offset = "0x2793814", VA = "0x2797814")]
		public static MethodInfo GetInvokeMethod(this Type delegateType)
		{
			return null;
		}
	}
}
namespace System.Collections.Generic
{
	[Token(Token = "0x2000282")]
	[DefaultMember("Item")]
	internal struct ArrayBuilder<T>
	{
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x0")]
		private T[] _array;

		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x0")]
		private int _count;

		[Token(Token = "0x6000C9A")]
		public ArrayBuilder(int capacity)
		{
		}

		[Token(Token = "0x6000C9B")]
		public T[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x6000C9C")]
		public void UncheckedAdd(T item)
		{
		}
	}
	[Token(Token = "0x2000283")]
	internal sealed class BitHelper
	{
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x10")]
		private readonly int _length;

		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x18")]
		private unsafe readonly int* _arrayPtr;

		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x20")]
		private readonly int[] _array;

		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool _useStackAlloc;

		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x2797B18", Offset = "0x2793B18", VA = "0x2797B18")]
		internal unsafe BitHelper(int* bitArrayPtr, int length)
		{
		}

		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0x2797B50", Offset = "0x2793B50", VA = "0x2797B50")]
		internal BitHelper(int[] bitArray, int length)
		{
		}

		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x2797B80", Offset = "0x2793B80", VA = "0x2797B80")]
		internal void MarkBit(int bitPosition)
		{
		}

		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x2797BFC", Offset = "0x2793BFC", VA = "0x2797BFC")]
		internal bool IsMarked(int bitPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x2797C80", Offset = "0x2793C80", VA = "0x2797C80")]
		internal static int ToIntArrayLength(int n)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000284")]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(System.Collections.Generic.ICollectionDebugView<>))]
	public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		[Token(Token = "0x2000285")]
		internal struct ElementCount
		{
			[Token(Token = "0x400048E")]
			[FieldOffset(Offset = "0x0")]
			internal int uniqueCount;

			[Token(Token = "0x400048F")]
			[FieldOffset(Offset = "0x0")]
			internal int unfoundCount;
		}

		[Token(Token = "0x2000286")]
		internal struct Slot
		{
			[Token(Token = "0x4000490")]
			[FieldOffset(Offset = "0x0")]
			internal int hashCode;

			[Token(Token = "0x4000491")]
			[FieldOffset(Offset = "0x0")]
			internal int next;

			[Token(Token = "0x4000492")]
			[FieldOffset(Offset = "0x0")]
			internal T value;
		}

		[Serializable]
		[Token(Token = "0x2000287")]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000493")]
			[FieldOffset(Offset = "0x0")]
			private HashSet<T> _set;

			[Token(Token = "0x4000494")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			[Token(Token = "0x4000495")]
			[FieldOffset(Offset = "0x0")]
			private int _version;

			[Token(Token = "0x4000496")]
			[FieldOffset(Offset = "0x0")]
			private T _current;

			[Token(Token = "0x17000284")]
			public T Current
			{
				[Token(Token = "0x6000CCC")]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x17000285")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CCD")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CC9")]
			internal Enumerator(HashSet<T> set)
			{
			}

			[Token(Token = "0x6000CCA")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000CCB")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CCE")]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400047F")]
		private const int Lower31BitMask = int.MaxValue;

		[Token(Token = "0x4000480")]
		private const int StackAllocThreshold = 100;

		[Token(Token = "0x4000481")]
		private const int ShrinkThreshold = 3;

		[Token(Token = "0x4000482")]
		private const string CapacityName = "Capacity";

		[Token(Token = "0x4000483")]
		private const string ElementsName = "Elements";

		[Token(Token = "0x4000484")]
		private const string ComparerName = "Comparer";

		[Token(Token = "0x4000485")]
		private const string VersionName = "Version";

		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x0")]
		private int[] _buckets;

		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x0")]
		private Slot[] _slots;

		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x0")]
		private int _count;

		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x0")]
		private int _lastIndex;

		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x0")]
		private int _freeList;

		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<T> _comparer;

		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x0")]
		private int _version;

		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x0")]
		private SerializationInfo _siInfo;

		[Token(Token = "0x17000281")]
		public int Count
		{
			[Token(Token = "0x6000CAF")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000282")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[Token(Token = "0x6000CB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000283")]
		public IEqualityComparer<T> Comparer
		{
			[Token(Token = "0x6000CBD")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CA2")]
		public HashSet()
		{
		}

		[Token(Token = "0x6000CA3")]
		public HashSet(IEqualityComparer<T> comparer)
		{
		}

		[Token(Token = "0x6000CA4")]
		public HashSet(int capacity)
		{
		}

		[Token(Token = "0x6000CA5")]
		public HashSet(IEnumerable<T> collection)
		{
		}

		[Token(Token = "0x6000CA6")]
		public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
		{
		}

		[Token(Token = "0x6000CA7")]
		protected HashSet(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000CA8")]
		private void CopyFrom(HashSet<T> source)
		{
		}

		[Token(Token = "0x6000CA9")]
		public HashSet(int capacity, IEqualityComparer<T> comparer)
		{
		}

		[Token(Token = "0x6000CAA")]
		private void System.Collections.Generic.ICollection<T>.Add(T item)
		{
		}

		[Token(Token = "0x6000CAB")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000CAC")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CAD")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000CAE")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CB1")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000CB2")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000CB3")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000CB4")]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000CB5")]
		public virtual void OnDeserialization(object sender)
		{
		}

		[Token(Token = "0x6000CB6")]
		public bool Add(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CB7")]
		public void UnionWith(IEnumerable<T> other)
		{
		}

		[Token(Token = "0x6000CB8")]
		public void ExceptWith(IEnumerable<T> other)
		{
		}

		[Token(Token = "0x6000CB9")]
		public bool SetEquals(IEnumerable<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CBA")]
		public void CopyTo(T[] array)
		{
		}

		[Token(Token = "0x6000CBB")]
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
		}

		[Token(Token = "0x6000CBC")]
		public int RemoveWhere(Predicate<T> match)
		{
			return default(int);
		}

		[Token(Token = "0x6000CBE")]
		public void TrimExcess()
		{
		}

		[Token(Token = "0x6000CBF")]
		private int Initialize(int capacity)
		{
			return default(int);
		}

		[Token(Token = "0x6000CC0")]
		private void IncreaseCapacity()
		{
		}

		[Token(Token = "0x6000CC1")]
		private void SetCapacity(int newSize)
		{
		}

		[Token(Token = "0x6000CC2")]
		private bool AddIfNotPresent(T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CC3")]
		private void AddValue(int index, int hashCode, T value)
		{
		}

		[Token(Token = "0x6000CC4")]
		private bool ContainsAllElements(IEnumerable<T> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CC5")]
		private int InternalIndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000CC6")]
		private ElementCount CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound)
		{
			return default(ElementCount);
		}

		[Token(Token = "0x6000CC7")]
		private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CC8")]
		private int InternalGetHashCode(T item)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000288")]
	internal sealed class ICollectionDebugView<T>
	{
	}
}
namespace System.Threading
{
	[Token(Token = "0x2000289")]
	public enum LockRecursionPolicy
	{
		[Token(Token = "0x4000498")]
		NoRecursion,
		[Token(Token = "0x4000499")]
		SupportsRecursion
	}
	[Token(Token = "0x200028A")]
	internal class ReaderWriterCount
	{
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x10")]
		public long lockID;

		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x18")]
		public int readercount;

		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x1C")]
		public int writercount;

		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x20")]
		public int upgradecount;

		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x28")]
		public ReaderWriterCount next;

		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x2797C94", Offset = "0x2793C94", VA = "0x2797C94")]
		public ReaderWriterCount()
		{
		}
	}
	[Token(Token = "0x200028B")]
	public class ReaderWriterLockSlim : IDisposable
	{
		[Token(Token = "0x200028C")]
		private struct TimeoutTracker
		{
			[Token(Token = "0x40004B2")]
			[FieldOffset(Offset = "0x0")]
			private int m_total;

			[Token(Token = "0x40004B3")]
			[FieldOffset(Offset = "0x4")]
			private int m_start;

			[Token(Token = "0x1700028F")]
			public int RemainingMilliseconds
			{
				[Token(Token = "0x6000CFD")]
				[Address(RVA = "0x2798CD8", Offset = "0x2794CD8", VA = "0x2798CD8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000290")]
			public bool IsExpired
			{
				[Token(Token = "0x6000CFE")]
				[Address(RVA = "0x2798360", Offset = "0x2794360", VA = "0x2798360")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0x2797EE4", Offset = "0x2793EE4", VA = "0x2797EE4")]
			public TimeoutTracker(int millisecondsTimeout)
			{
			}
		}

		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x10")]
		private bool fIsReentrant;

		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x14")]
		private int myLock;

		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x18")]
		private uint numWriteWaiters;

		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x1C")]
		private uint numReadWaiters;

		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x20")]
		private uint numWriteUpgradeWaiters;

		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x24")]
		private uint numUpgradeWaiters;

		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x28")]
		private bool fNoWaiters;

		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x2C")]
		private int upgradeLockOwnerId;

		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x30")]
		private int writeLockOwnerId;

		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x38")]
		private EventWaitHandle writeEvent;

		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x40")]
		private EventWaitHandle readEvent;

		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x48")]
		private EventWaitHandle upgradeEvent;

		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x50")]
		private EventWaitHandle waitUpgradeEvent;

		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x0")]
		private static long s_nextLockID;

		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x58")]
		private long lockID;

		[Token(Token = "0x40004AE")]
		[ThreadStatic]
		private static ReaderWriterCount t_rwc;

		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x60")]
		private bool fUpgradeThreadHoldingRead;

		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x64")]
		private uint owners;

		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x68")]
		private bool fDisposed;

		[Token(Token = "0x17000286")]
		public bool IsReadLockHeld
		{
			[Token(Token = "0x6000CF3")]
			[Address(RVA = "0x2799098", Offset = "0x2795098", VA = "0x2799098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000287")]
		public bool IsUpgradeableReadLockHeld
		{
			[Token(Token = "0x6000CF4")]
			[Address(RVA = "0x27990B0", Offset = "0x27950B0", VA = "0x27990B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000288")]
		public bool IsWriteLockHeld
		{
			[Token(Token = "0x6000CF5")]
			[Address(RVA = "0x27990C8", Offset = "0x27950C8", VA = "0x27990C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000289")]
		public int RecursiveReadCount
		{
			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x27990E0", Offset = "0x27950E0", VA = "0x27990E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700028A")]
		public int RecursiveUpgradeCount
		{
			[Token(Token = "0x6000CF7")]
			[Address(RVA = "0x2799160", Offset = "0x2795160", VA = "0x2799160")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700028B")]
		public int RecursiveWriteCount
		{
			[Token(Token = "0x6000CF8")]
			[Address(RVA = "0x2799210", Offset = "0x2795210", VA = "0x2799210")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700028C")]
		public int WaitingReadCount
		{
			[Token(Token = "0x6000CF9")]
			[Address(RVA = "0x27992C0", Offset = "0x27952C0", VA = "0x27992C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700028D")]
		public int WaitingUpgradeCount
		{
			[Token(Token = "0x6000CFA")]
			[Address(RVA = "0x27992C8", Offset = "0x27952C8", VA = "0x27992C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700028E")]
		public int WaitingWriteCount
		{
			[Token(Token = "0x6000CFB")]
			[Address(RVA = "0x27992D0", Offset = "0x27952D0", VA = "0x27992D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x2797C9C", Offset = "0x2793C9C", VA = "0x2797C9C")]
		private void InitializeThreadCounts()
		{
		}

		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x2797CA8", Offset = "0x2793CA8", VA = "0x2797CA8")]
		public ReaderWriterLockSlim()
		{
		}

		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x2797CB0", Offset = "0x2793CB0", VA = "0x2797CB0")]
		public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x2797D34", Offset = "0x2793D34", VA = "0x2797D34")]
		private static bool IsRWEntryEmpty(ReaderWriterCount rwc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x2797D70", Offset = "0x2793D70", VA = "0x2797D70")]
		private bool IsRwHashEntryChanged(ReaderWriterCount lrwc)
		{
			return default(bool);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x2797D90", Offset = "0x2793D90", VA = "0x2797D90")]
		private ReaderWriterCount GetThreadRWCount(bool dontAllocate)
		{
			return null;
		}

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x2797EB0", Offset = "0x2793EB0", VA = "0x2797EB0")]
		public void EnterWriteLock()
		{
		}

		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x2797EB8", Offset = "0x2793EB8", VA = "0x2797EB8")]
		public bool TryEnterWriteLock(int millisecondsTimeout)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x2797F68", Offset = "0x2793F68", VA = "0x2797F68")]
		private bool TryEnterWriteLock(TimeoutTracker timeout)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x2797F6C", Offset = "0x2793F6C", VA = "0x2797F6C")]
		private bool TryEnterWriteLockCore(TimeoutTracker timeout)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x2798628", Offset = "0x2794628", VA = "0x2798628")]
		public void EnterUpgradeableReadLock()
		{
		}

		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x2798630", Offset = "0x2794630", VA = "0x2798630")]
		public bool TryEnterUpgradeableReadLock(int millisecondsTimeout)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x279865C", Offset = "0x279465C", VA = "0x279865C")]
		private bool TryEnterUpgradeableReadLock(TimeoutTracker timeout)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x2798660", Offset = "0x2794660", VA = "0x2798660")]
		private bool TryEnterUpgradeableReadLockCore(TimeoutTracker timeout)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x27989C4", Offset = "0x27949C4", VA = "0x27989C4")]
		public void ExitWriteLock()
		{
		}

		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x2798B34", Offset = "0x2794B34", VA = "0x2798B34")]
		public void ExitUpgradeableReadLock()
		{
		}

		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x2798410", Offset = "0x2794410", VA = "0x2798410")]
		private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent)
		{
		}

		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x2798508", Offset = "0x2794508", VA = "0x2798508")]
		private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, TimeoutTracker timeout, bool isWriteWaiter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x2798B08", Offset = "0x2794B08", VA = "0x2798B08")]
		private void ExitAndWakeUpAppropriateWaiters()
		{
		}

		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x2798D20", Offset = "0x2794D20", VA = "0x2798D20")]
		private void ExitAndWakeUpAppropriateWaitersPreferringWriters()
		{
		}

		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x2798DA4", Offset = "0x2794DA4", VA = "0x2798DA4")]
		private void ExitAndWakeUpAppropriateReadWaiters()
		{
		}

		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x2798334", Offset = "0x2794334", VA = "0x2798334")]
		private bool IsWriterAcquired()
		{
			return default(bool);
		}

		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x2798344", Offset = "0x2794344", VA = "0x2798344")]
		private void SetWriterAcquired()
		{
		}

		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x2798AF8", Offset = "0x2794AF8", VA = "0x2798AF8")]
		private void ClearWriterAcquired()
		{
		}

		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x2798CB8", Offset = "0x2794CB8", VA = "0x2798CB8")]
		private void SetWritersWaiting()
		{
		}

		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x2798E38", Offset = "0x2794E38", VA = "0x2798E38")]
		private void ClearWritersWaiting()
		{
		}

		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x2798CC8", Offset = "0x2794CC8", VA = "0x2798CC8")]
		private void SetUpgraderWaiting()
		{
		}

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x2798E48", Offset = "0x2794E48", VA = "0x2798E48")]
		private void ClearUpgraderWaiting()
		{
		}

		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x2798354", Offset = "0x2794354", VA = "0x2798354")]
		private uint GetNumReaders()
		{
			return default(uint);
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x2798E58", Offset = "0x2794E58", VA = "0x2798E58")]
		private void EnterMyLock()
		{
		}

		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x2798E8C", Offset = "0x2794E8C", VA = "0x2798E8C")]
		private void EnterMyLockSpin()
		{
		}

		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x279831C", Offset = "0x279431C", VA = "0x279831C")]
		private void ExitMyLock()
		{
		}

		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x2798378", Offset = "0x2794378", VA = "0x2798378")]
		private static void SpinWait(int SpinCount)
		{
		}

		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x2798F60", Offset = "0x2794F60", VA = "0x2798F60", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x2798F68", Offset = "0x2794F68", VA = "0x2798F68")]
		private void Dispose(bool disposing)
		{
		}
	}
}
