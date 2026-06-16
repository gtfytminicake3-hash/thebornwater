using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Il2CppDummyDll;
using Mono.Math;
using Mono.Security.Cryptography;
using Mono.Security.X509;

[assembly: AssemblyVersion("4.0.0.0")]
[Token(Token = "0x2000002")]
internal sealed class Locale
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2483D98", Offset = "0x247FD98", VA = "0x2483D98")]
	public static string GetText(string msg)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2483D9C", Offset = "0x247FD9C", VA = "0x2483D9C")]
	public static string GetText(string fmt, params object[] args)
	{
		return null;
	}
}
namespace Mono.Security
{
	[Token(Token = "0x2000003")]
	public class ASN1
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private byte m_nTag;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_aValue;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		private ArrayList elist;

		[Token(Token = "0x17000001")]
		public int Count
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2484074", Offset = "0x2480074", VA = "0x2484074")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000002")]
		public byte Tag
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2484090", Offset = "0x2480090", VA = "0x2484090")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000003")]
		public int Length
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2484098", Offset = "0x2480098", VA = "0x2484098")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000004")]
		public byte[] Value
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x24840B0", Offset = "0x24800B0", VA = "0x24840B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2484140", Offset = "0x2480140", VA = "0x2484140")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public ASN1 this[int index]
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2484A5C", Offset = "0x2480A5C", VA = "0x2484A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2483DA4", Offset = "0x247FDA4", VA = "0x2483DA4")]
		public ASN1(byte tag)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2483DD0", Offset = "0x247FDD0", VA = "0x2483DD0")]
		public ASN1(byte tag, byte[] data)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2483E00", Offset = "0x247FE00", VA = "0x2483E00")]
		public ASN1(byte[] data)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x24841DC", Offset = "0x24801DC", VA = "0x24841DC")]
		private bool CompareArray(byte[] array1, byte[] array2)
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2484244", Offset = "0x2480244", VA = "0x2484244")]
		public bool CompareValue(byte[] value)
		{
			return default(bool);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2484254", Offset = "0x2480254", VA = "0x2484254")]
		public ASN1 Add(ASN1 asn1)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x24842E0", Offset = "0x24802E0", VA = "0x24842E0", Slot = "4")]
		public virtual byte[] GetBytes()
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2483F60", Offset = "0x247FF60", VA = "0x2483F60")]
		protected void Decode(byte[] asn1, ref int anPos, int anLength)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2484948", Offset = "0x2480948", VA = "0x2484948")]
		protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2484B8C", Offset = "0x2480B8C", VA = "0x2484B8C")]
		public ASN1 Element(int index, byte anTag)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2484CE0", Offset = "0x2480CE0", VA = "0x2484CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000004")]
	public static class ASN1Convert
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2484F80", Offset = "0x2480F80", VA = "0x2484F80")]
		public static ASN1 FromInt32(int value)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2485104", Offset = "0x2481104", VA = "0x2485104")]
		public static ASN1 FromOid(string oid)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x24851E0", Offset = "0x24811E0", VA = "0x24851E0")]
		public static ASN1 FromUnsignedBigInteger(byte[] big)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x24852F0", Offset = "0x24812F0", VA = "0x24852F0")]
		public static int ToInt32(ASN1 asn1)
		{
			return default(int);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x24853F4", Offset = "0x24813F4", VA = "0x24853F4")]
		public static string ToOid(ASN1 asn1)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2485660", Offset = "0x2481660", VA = "0x2485660")]
		public static DateTime ToDateTime(ASN1 time)
		{
			return default(DateTime);
		}
	}
	[Token(Token = "0x2000005")]
	internal sealed class BitConverterLE
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2485BD4", Offset = "0x2481BD4", VA = "0x2485BD4")]
		private unsafe static byte[] GetUIntBytes(byte* bytes)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2485C6C", Offset = "0x2481C6C", VA = "0x2485C6C")]
		private unsafe static byte[] GetULongBytes(byte* bytes)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x24850EC", Offset = "0x24810EC", VA = "0x24850EC")]
		internal static byte[] GetBytes(int value)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2485D44", Offset = "0x2481D44", VA = "0x2485D44")]
		internal static byte[] GetBytes(long value)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2485D58", Offset = "0x2481D58", VA = "0x2485D58")]
		private unsafe static void UShortFromBytes(byte* dst, byte[] src, int startIndex)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2485DA0", Offset = "0x2481DA0", VA = "0x2485DA0")]
		private unsafe static void UIntFromBytes(byte* dst, byte[] src, int startIndex)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2485E18", Offset = "0x2481E18", VA = "0x2485E18")]
		internal static int ToInt32(byte[] value, int startIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2485E3C", Offset = "0x2481E3C", VA = "0x2485E3C")]
		internal static ushort ToUInt16(byte[] value, int startIndex)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2485E60", Offset = "0x2481E60", VA = "0x2485E60")]
		internal static uint ToUInt32(byte[] value, int startIndex)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x2000006")]
	public sealed class PKCS7
	{
		[Token(Token = "0x2000007")]
		public class ContentInfo
		{
			[Token(Token = "0x4000004")]
			[FieldOffset(Offset = "0x10")]
			private string contentType;

			[Token(Token = "0x4000005")]
			[FieldOffset(Offset = "0x18")]
			private ASN1 content;

			[Token(Token = "0x17000006")]
			public ASN1 ASN1
			{
				[Token(Token = "0x6000027")]
				[Address(RVA = "0x2486100", Offset = "0x2482100", VA = "0x2486100")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000007")]
			public ASN1 Content
			{
				[Token(Token = "0x6000028")]
				[Address(RVA = "0x24861B0", Offset = "0x24821B0", VA = "0x24861B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000029")]
				[Address(RVA = "0x24861B8", Offset = "0x24821B8", VA = "0x24861B8")]
				set
				{
				}
			}

			[Token(Token = "0x17000008")]
			public string ContentType
			{
				[Token(Token = "0x600002A")]
				[Address(RVA = "0x24861C0", Offset = "0x24821C0", VA = "0x24861C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600002B")]
				[Address(RVA = "0x24861C8", Offset = "0x24821C8", VA = "0x24861C8")]
				set
				{
				}
			}

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2485E84", Offset = "0x2481E84", VA = "0x2485E84")]
			public ContentInfo()
			{
			}

			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2485EF4", Offset = "0x2481EF4", VA = "0x2485EF4")]
			public ContentInfo(string oid)
			{
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2485F18", Offset = "0x2481F18", VA = "0x2485F18")]
			public ContentInfo(byte[] data)
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2485F80", Offset = "0x2481F80", VA = "0x2485F80")]
			public ContentInfo(ASN1 asn1)
			{
			}

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2486104", Offset = "0x2482104", VA = "0x2486104")]
			internal ASN1 GetASN1()
			{
				return null;
			}
		}

		[Token(Token = "0x2000008")]
		public class EncryptedData
		{
			[Token(Token = "0x4000006")]
			[FieldOffset(Offset = "0x10")]
			private byte _version;

			[Token(Token = "0x4000007")]
			[FieldOffset(Offset = "0x18")]
			private ContentInfo _content;

			[Token(Token = "0x4000008")]
			[FieldOffset(Offset = "0x20")]
			private ContentInfo _encryptionAlgorithm;

			[Token(Token = "0x4000009")]
			[FieldOffset(Offset = "0x28")]
			private byte[] _encrypted;

			[Token(Token = "0x17000009")]
			public ContentInfo EncryptionAlgorithm
			{
				[Token(Token = "0x600002F")]
				[Address(RVA = "0x2486490", Offset = "0x2482490", VA = "0x2486490")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			public byte[] EncryptedContent
			{
				[Token(Token = "0x6000030")]
				[Address(RVA = "0x2486498", Offset = "0x2482498", VA = "0x2486498")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x24861D0", Offset = "0x24821D0", VA = "0x24861D0")]
			public EncryptedData()
			{
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x24861EC", Offset = "0x24821EC", VA = "0x24861EC")]
			public EncryptedData(ASN1 asn1)
			{
			}
		}

		[Token(Token = "0x2000009")]
		public class SignedData
		{
			[Token(Token = "0x400000A")]
			[FieldOffset(Offset = "0x10")]
			private byte version;

			[Token(Token = "0x400000B")]
			[FieldOffset(Offset = "0x18")]
			private string hashAlgorithm;

			[Token(Token = "0x400000C")]
			[FieldOffset(Offset = "0x20")]
			private ContentInfo contentInfo;

			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x28")]
			private Mono.Security.X509.X509CertificateCollection certs;

			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x30")]
			private ArrayList crls;

			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x38")]
			private SignerInfo signerInfo;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x40")]
			private bool mda;

			[Token(Token = "0x1700000B")]
			public Mono.Security.X509.X509CertificateCollection Certificates
			{
				[Token(Token = "0x6000032")]
				[Address(RVA = "0x248719C", Offset = "0x248319C", VA = "0x248719C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			public ContentInfo ContentInfo
			{
				[Token(Token = "0x6000033")]
				[Address(RVA = "0x24871A4", Offset = "0x24831A4", VA = "0x24871A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			public string HashName
			{
				[Token(Token = "0x6000034")]
				[Address(RVA = "0x2487180", Offset = "0x2483180", VA = "0x2487180")]
				set
				{
				}
			}

			[Token(Token = "0x1700000E")]
			public SignerInfo SignerInfo
			{
				[Token(Token = "0x6000035")]
				[Address(RVA = "0x24871AC", Offset = "0x24831AC", VA = "0x24871AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x248650C", Offset = "0x248250C", VA = "0x248650C")]
			public SignedData(ASN1 asn1)
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2486FCC", Offset = "0x2482FCC", VA = "0x2486FCC")]
			internal string OidToName(string oid)
			{
				return null;
			}
		}

		[Token(Token = "0x200000A")]
		public class SignerInfo
		{
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x10")]
			private byte version;

			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x18")]
			private string hashAlgorithm;

			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x20")]
			private ArrayList authenticatedAttributes;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x28")]
			private ArrayList unauthenticatedAttributes;

			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x30")]
			private byte[] signature;

			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x38")]
			private string issuer;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x40")]
			private byte[] serial;

			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x48")]
			private byte[] ski;

			[Token(Token = "0x1700000F")]
			public string IssuerName
			{
				[Token(Token = "0x6000039")]
				[Address(RVA = "0x24872F0", Offset = "0x24832F0", VA = "0x24872F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			public byte[] SerialNumber
			{
				[Token(Token = "0x600003A")]
				[Address(RVA = "0x24872F8", Offset = "0x24832F8", VA = "0x24872F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000011")]
			public ArrayList AuthenticatedAttributes
			{
				[Token(Token = "0x600003B")]
				[Address(RVA = "0x248736C", Offset = "0x248336C", VA = "0x248736C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			public string HashName
			{
				[Token(Token = "0x600003C")]
				[Address(RVA = "0x2487374", Offset = "0x2483374", VA = "0x2487374")]
				get
				{
					return null;
				}
				[Token(Token = "0x600003D")]
				[Address(RVA = "0x248737C", Offset = "0x248337C", VA = "0x248737C")]
				set
				{
				}
			}

			[Token(Token = "0x17000013")]
			public byte[] Signature
			{
				[Token(Token = "0x600003E")]
				[Address(RVA = "0x2487384", Offset = "0x2483384", VA = "0x2487384")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			public ArrayList UnauthenticatedAttributes
			{
				[Token(Token = "0x600003F")]
				[Address(RVA = "0x24873F8", Offset = "0x24833F8", VA = "0x24873F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000015")]
			public byte Version
			{
				[Token(Token = "0x6000040")]
				[Address(RVA = "0x2487400", Offset = "0x2483400", VA = "0x2487400")]
				get
				{
					return default(byte);
				}
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2486F48", Offset = "0x2482F48", VA = "0x2486F48")]
			public SignerInfo()
			{
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2486BD4", Offset = "0x2482BD4", VA = "0x2486BD4")]
			public SignerInfo(ASN1 asn1)
			{
			}
		}
	}
}
namespace Mono.Security.X509
{
	[Token(Token = "0x200000B")]
	internal class SafeBag
	{
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		private string _bagOID;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		private ASN1 _asn1;

		[Token(Token = "0x17000016")]
		public string BagOID
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2487434", Offset = "0x2483434", VA = "0x2487434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public ASN1 ASN1
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x248743C", Offset = "0x248343C", VA = "0x248743C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2487408", Offset = "0x2483408", VA = "0x2487408")]
		public SafeBag(string bagOID, ASN1 asn1)
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class PKCS12 : ICloneable
	{
		[Token(Token = "0x200000D")]
		public class DeriveBytes
		{
			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x0")]
			private static byte[] keyDiversifier;

			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x8")]
			private static byte[] ivDiversifier;

			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x10")]
			private static byte[] macDiversifier;

			[Token(Token = "0x4000029")]
			[FieldOffset(Offset = "0x10")]
			private string _hashName;

			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x18")]
			private int _iterations;

			[Token(Token = "0x400002B")]
			[FieldOffset(Offset = "0x20")]
			private byte[] _password;

			[Token(Token = "0x400002C")]
			[FieldOffset(Offset = "0x28")]
			private byte[] _salt;

			[Token(Token = "0x1700001E")]
			public string HashName
			{
				[Token(Token = "0x6000063")]
				[Address(RVA = "0x248DCB8", Offset = "0x2489CB8", VA = "0x248DCB8")]
				set
				{
				}
			}

			[Token(Token = "0x1700001F")]
			public int IterationCount
			{
				[Token(Token = "0x6000064")]
				[Address(RVA = "0x248DCC0", Offset = "0x2489CC0", VA = "0x248DCC0")]
				set
				{
				}
			}

			[Token(Token = "0x17000020")]
			public byte[] Password
			{
				[Token(Token = "0x6000065")]
				[Address(RVA = "0x2489970", Offset = "0x2485970", VA = "0x2489970")]
				set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public byte[] Salt
			{
				[Token(Token = "0x6000066")]
				[Address(RVA = "0x2489A18", Offset = "0x2485A18", VA = "0x2489A18")]
				set
				{
				}
			}

			[Token(Token = "0x6000062")]
			[Address(RVA = "0x2489968", Offset = "0x2485968", VA = "0x2489968")]
			public DeriveBytes()
			{
			}

			[Token(Token = "0x6000067")]
			[Address(RVA = "0x248DCC8", Offset = "0x2489CC8", VA = "0x248DCC8")]
			private void Adjust(byte[] a, int aOff, byte[] b)
			{
			}

			[Token(Token = "0x6000068")]
			[Address(RVA = "0x248DD70", Offset = "0x2489D70", VA = "0x248DD70")]
			private byte[] Derive(byte[] diversifier, int n)
			{
				return null;
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x2489AB4", Offset = "0x2485AB4", VA = "0x2489AB4")]
			public byte[] DeriveKey(int size)
			{
				return null;
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0x2489B24", Offset = "0x2485B24", VA = "0x2489B24")]
			public byte[] DeriveIV(int size)
			{
				return null;
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0x248B1DC", Offset = "0x24871DC", VA = "0x248B1DC")]
			public byte[] DeriveMAC(int size)
			{
				return null;
			}
		}

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		private byte[] _password;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		private ArrayList _keyBags;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		private ArrayList _secretBags;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		private X509CertificateCollection _certs;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x30")]
		private bool _keyBagsChanged;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x31")]
		private bool _secretBagsChanged;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x32")]
		private bool _certsChanged;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x34")]
		private int _iterations;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x38")]
		private ArrayList _safeBags;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x40")]
		private RandomNumberGenerator _rng;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x0")]
		private static int password_max_length;

		[Token(Token = "0x17000018")]
		public string Password
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2487550", Offset = "0x2483550", VA = "0x2487550")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public int IterationCount
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2488748", Offset = "0x2484748", VA = "0x2488748")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2488750", Offset = "0x2484750", VA = "0x2488750")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public ArrayList Keys
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2488758", Offset = "0x2484758", VA = "0x2488758")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public X509CertificateCollection Certificates
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2488FA8", Offset = "0x2484FA8", VA = "0x2488FA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		internal RandomNumberGenerator RNG
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x24893A8", Offset = "0x24853A8", VA = "0x24893A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public static int MaximumPasswordLength
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x248DC14", Offset = "0x2489C14", VA = "0x248DC14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2487444", Offset = "0x2483444", VA = "0x2487444")]
		public PKCS12()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x248751C", Offset = "0x248351C", VA = "0x248751C")]
		public PKCS12(byte[] data)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2487D8C", Offset = "0x2483D8C", VA = "0x2487D8C")]
		public PKCS12(byte[] data, string password)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x248770C", Offset = "0x248370C", VA = "0x248770C")]
		private void Decode(byte[] data)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x24886A8", Offset = "0x24846A8", VA = "0x24886A8", Slot = "1")]
		~PKCS12()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2487F18", Offset = "0x2483F18", VA = "0x2487F18")]
		private bool Compare(byte[] expected, byte[] actual)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x24893C8", Offset = "0x24853C8", VA = "0x24893C8")]
		private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2488E08", Offset = "0x2484E08", VA = "0x2488E08")]
		public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2488618", Offset = "0x2484618", VA = "0x2488618")]
		public byte[] Decrypt(PKCS7.EncryptedData ed)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2489B94", Offset = "0x2485B94", VA = "0x2489B94")]
		public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2489D90", Offset = "0x2485D90", VA = "0x2489D90")]
		private DSAParameters GetExistingParameters(out bool found)
		{
			return default(DSAParameters);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x248A450", Offset = "0x2486450", VA = "0x248A450")]
		private void AddPrivateKey(PKCS8.PrivateKeyInfo pki)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2487F80", Offset = "0x2483F80", VA = "0x2487F80")]
		private void ReadSafeBag(ASN1 safeBag)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x248A6A4", Offset = "0x24866A4", VA = "0x248A6A4")]
		private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2487DC4", Offset = "0x2483DC4", VA = "0x2487DC4")]
		private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x248B24C", Offset = "0x248724C", VA = "0x248B24C")]
		public byte[] GetBytes()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x248D120", Offset = "0x2489120", VA = "0x248D120")]
		private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x248D118", Offset = "0x2489118", VA = "0x248D118")]
		public void AddCertificate(X509Certificate cert)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x248D408", Offset = "0x2489408", VA = "0x248D408")]
		public void AddCertificate(X509Certificate cert, IDictionary attributes)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x248D110", Offset = "0x2489110", VA = "0x248D110")]
		public void RemoveCertificate(X509Certificate cert)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x248D650", Offset = "0x2489650", VA = "0x248D650")]
		public void RemoveCertificate(X509Certificate cert, IDictionary attrs)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x248DB4C", Offset = "0x2489B4C", VA = "0x248DB4C", Slot = "4")]
		public object Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x200000E")]
	public sealed class X501
	{
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] countryName;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] organizationName;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x10")]
		private static byte[] organizationalUnitName;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x18")]
		private static byte[] commonName;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x20")]
		private static byte[] localityName;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x28")]
		private static byte[] stateOrProvinceName;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x30")]
		private static byte[] streetAddress;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x38")]
		private static byte[] serialNumber;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x40")]
		private static byte[] domainComponent;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x48")]
		private static byte[] userid;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x50")]
		private static byte[] email;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x58")]
		private static byte[] dnQualifier;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x60")]
		private static byte[] title;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x68")]
		private static byte[] surname;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x70")]
		private static byte[] givenName;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x78")]
		private static byte[] initial;

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x24871B4", Offset = "0x24831B4", VA = "0x24871B4")]
		public static string ToString(ASN1 seq)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x248EA94", Offset = "0x248AA94", VA = "0x248EA94")]
		public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x248E2C4", Offset = "0x248A2C4", VA = "0x248E2C4")]
		private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes)
		{
		}
	}
	[Token(Token = "0x200000F")]
	[DefaultMember("Item")]
	public class X509Crl
	{
		[Token(Token = "0x2000010")]
		public class X509CrlEntry
		{
			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x10")]
			private byte[] sn;

			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x18")]
			private DateTime revocationDate;

			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x20")]
			private X509ExtensionCollection extensions;

			[Token(Token = "0x17000026")]
			public byte[] SerialNumber
			{
				[Token(Token = "0x600007E")]
				[Address(RVA = "0x248FE0C", Offset = "0x248BE0C", VA = "0x248FE0C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			public DateTime RevocationDate
			{
				[Token(Token = "0x600007F")]
				[Address(RVA = "0x249039C", Offset = "0x248C39C", VA = "0x249039C")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x17000028")]
			public X509ExtensionCollection Extensions
			{
				[Token(Token = "0x6000080")]
				[Address(RVA = "0x24903A4", Offset = "0x248C3A4", VA = "0x24903A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x248F7C8", Offset = "0x248B7C8", VA = "0x248F7C8")]
			internal X509CrlEntry(ASN1 entry)
			{
			}
		}

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x10")]
		private string issuer;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x18")]
		private byte version;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x20")]
		private DateTime thisUpdate;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x28")]
		private DateTime nextUpdate;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x30")]
		private ArrayList entries;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x38")]
		private string signatureOID;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x40")]
		private byte[] signature;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x48")]
		private X509ExtensionCollection extensions;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x50")]
		private byte[] encoded;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x58")]
		private byte[] hash_value;

		[Token(Token = "0x17000022")]
		public X509ExtensionCollection Extensions
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x248F9D0", Offset = "0x248B9D0", VA = "0x248F9D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public byte[] Hash
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x248F9D8", Offset = "0x248B9D8", VA = "0x248F9D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public string IssuerName
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x248FB94", Offset = "0x248BB94", VA = "0x248FB94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public DateTime NextUpdate
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x248FB9C", Offset = "0x248BB9C", VA = "0x248FB9C")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x248F084", Offset = "0x248B084", VA = "0x248F084")]
		public X509Crl(byte[] crl)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x248F178", Offset = "0x248B178", VA = "0x248F178")]
		private void Parse(byte[] crl)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x248FBA4", Offset = "0x248BBA4", VA = "0x248FBA4")]
		private bool Compare(byte[] array1, byte[] array2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x248FC0C", Offset = "0x248BC0C", VA = "0x248FC0C")]
		public X509CrlEntry GetCrlEntry(X509Certificate x509)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x248FC88", Offset = "0x248BC88", VA = "0x248FC88")]
		public X509CrlEntry GetCrlEntry(byte[] serialNumber)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x248FE84", Offset = "0x248BE84", VA = "0x248FE84")]
		internal bool VerifySignature(DSA dsa)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2490148", Offset = "0x248C148", VA = "0x2490148")]
		internal bool VerifySignature(RSA rsa)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x249021C", Offset = "0x248C21C", VA = "0x249021C")]
		public bool VerifySignature(AsymmetricAlgorithm aa)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000011")]
	public class X509Certificate : ISerializable
	{
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x10")]
		private ASN1 decoder;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_encodedcert;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x20")]
		private DateTime m_from;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x28")]
		private DateTime m_until;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x30")]
		private ASN1 issuer;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x38")]
		private string m_issuername;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x40")]
		private string m_keyalgo;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x48")]
		private byte[] m_keyalgoparams;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x50")]
		private ASN1 subject;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x58")]
		private string m_subject;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x60")]
		private byte[] m_publickey;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x68")]
		private byte[] signature;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x70")]
		private string m_signaturealgo;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x78")]
		private byte[] m_signaturealgoparams;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x80")]
		private byte[] certhash;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x88")]
		private RSA _rsa;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x90")]
		private DSA _dsa;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x98")]
		private int version;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xA0")]
		private byte[] serialnumber;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0xA8")]
		private byte[] issuerUniqueID;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xB0")]
		private byte[] subjectUniqueID;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xB8")]
		private X509ExtensionCollection extensions;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x0")]
		private static string encoding_error;

		[Token(Token = "0x17000029")]
		public DSA DSA
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x248A128", Offset = "0x2486128", VA = "0x248A128")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x2490E20", Offset = "0x248CE20", VA = "0x2490E20")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public X509ExtensionCollection Extensions
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x2490E30", Offset = "0x248CE30", VA = "0x2490E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public byte[] Hash
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2490E38", Offset = "0x248CE38", VA = "0x2490E38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public virtual string IssuerName
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x2491070", Offset = "0x248D070", VA = "0x2491070", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public virtual string KeyAlgorithm
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2491078", Offset = "0x248D078", VA = "0x2491078", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public virtual byte[] KeyAlgorithmParameters
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x2491080", Offset = "0x248D080", VA = "0x2491080", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x24910F4", Offset = "0x248D0F4", VA = "0x24910F4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public virtual byte[] PublicKey
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x24910FC", Offset = "0x248D0FC", VA = "0x24910FC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public virtual RSA RSA
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x2491170", Offset = "0x248D170", VA = "0x2491170", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x24912E4", Offset = "0x248D2E4", VA = "0x24912E4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public virtual byte[] RawData
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x24912F4", Offset = "0x248D2F4", VA = "0x24912F4", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public virtual byte[] SerialNumber
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x2491368", Offset = "0x248D368", VA = "0x2491368", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public virtual byte[] Signature
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x24913DC", Offset = "0x248D3DC", VA = "0x24913DC", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public virtual string SubjectName
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x2491810", Offset = "0x248D810", VA = "0x2491810", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public virtual DateTime ValidFrom
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x2491818", Offset = "0x248D818", VA = "0x2491818", Slot = "16")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000036")]
		public virtual DateTime ValidUntil
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x2491820", Offset = "0x248D820", VA = "0x2491820", Slot = "17")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000037")]
		public int Version
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x2491828", Offset = "0x248D828", VA = "0x2491828")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000038")]
		public bool IsCurrent
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2491830", Offset = "0x248D830", VA = "0x2491830")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public bool IsSelfSigned
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x2491CD8", Offset = "0x248DCD8", VA = "0x2491CD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x24903AC", Offset = "0x248C3AC", VA = "0x24903AC")]
		private void Parse(byte[] data)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x24869D8", Offset = "0x24829D8", VA = "0x24869D8")]
		public X509Certificate(byte[] data)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2490D8C", Offset = "0x248CD8C", VA = "0x2490D8C")]
		private byte[] GetUnsignedBigInteger(byte[] integer)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2491890", Offset = "0x248D890", VA = "0x2491890")]
		public bool WasCurrent(DateTime instant)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2491968", Offset = "0x248D968", VA = "0x2491968")]
		internal bool VerifySignature(DSA dsa)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2491A30", Offset = "0x248DA30", VA = "0x2491A30")]
		internal bool VerifySignature(RSA rsa)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2491B58", Offset = "0x248DB58", VA = "0x2491B58")]
		public bool VerifySignature(AsymmetricAlgorithm aa)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2491DE0", Offset = "0x248DDE0", VA = "0x2491DE0", Slot = "18")]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2490C58", Offset = "0x248CC58", VA = "0x2490C58")]
		private static byte[] PEM(string type, byte[] data)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public class X509CertificateCollection : CollectionBase, IEnumerable
	{
		[Token(Token = "0x2000013")]
		public class X509CertificateEnumerator : IEnumerator
		{
			[Token(Token = "0x4000061")]
			[FieldOffset(Offset = "0x10")]
			private IEnumerator enumerator;

			[Token(Token = "0x1700003B")]
			public X509Certificate Current
			{
				[Token(Token = "0x60000AA")]
				[Address(RVA = "0x248A038", Offset = "0x2486038", VA = "0x248A038")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000AB")]
				[Address(RVA = "0x2492300", Offset = "0x248E300", VA = "0x2492300", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x24921A8", Offset = "0x248E1A8", VA = "0x24921A8")]
			public X509CertificateEnumerator(X509CertificateCollection mappings)
			{
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x24923A4", Offset = "0x248E3A4", VA = "0x24923A4", Slot = "4")]
			private bool System.Collections.IEnumerator.MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2492444", Offset = "0x248E444", VA = "0x2492444", Slot = "6")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x248A3B0", Offset = "0x24863B0", VA = "0x248A3B0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public X509Certificate this[int index]
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x2491E9C", Offset = "0x248DE9C", VA = "0x2491E9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x24869D0", Offset = "0x24829D0", VA = "0x24869D0")]
		public X509CertificateCollection()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2486B64", Offset = "0x2482B64", VA = "0x2486B64")]
		public int Add(X509Certificate value)
		{
			return default(int);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2491F34", Offset = "0x248DF34", VA = "0x2491F34")]
		public void AddRange(X509CertificateCollection value)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2492004", Offset = "0x248E004", VA = "0x2492004")]
		public bool Contains(X509Certificate value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2489FE0", Offset = "0x2485FE0", VA = "0x2489FE0")]
		public new X509CertificateEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x249225C", Offset = "0x248E25C", VA = "0x249225C", Slot = "19")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x249227C", Offset = "0x248E27C", VA = "0x249227C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x249201C", Offset = "0x248E01C", VA = "0x249201C")]
		public int IndexOf(X509Certificate value)
		{
			return default(int);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2492298", Offset = "0x248E298", VA = "0x2492298")]
		private bool Compare(byte[] array1, byte[] array2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000014")]
	public class X509Chain
	{
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x10")]
		private X509CertificateCollection roots;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x18")]
		private X509CertificateCollection certs;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x20")]
		private X509Certificate _root;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x28")]
		private X509CertificateCollection _chain;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x30")]
		private X509ChainStatusFlags _status;

		[Token(Token = "0x1700003D")]
		public X509CertificateCollection TrustAnchors
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x249254C", Offset = "0x248E54C", VA = "0x249254C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x24924E8", Offset = "0x248E4E8", VA = "0x24924E8")]
		public X509Chain()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2492694", Offset = "0x248E694", VA = "0x2492694")]
		public void LoadCertificates(X509CertificateCollection collection)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x24926A8", Offset = "0x248E6A8", VA = "0x24926A8")]
		public bool Build(X509Certificate leaf)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2492FA4", Offset = "0x248EFA4", VA = "0x2492FA4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2492EF8", Offset = "0x248EEF8", VA = "0x2492EF8")]
		private bool IsValid(X509Certificate cert)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2492A04", Offset = "0x248EA04", VA = "0x2492A04")]
		private X509Certificate FindCertificateParent(X509Certificate child)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2492BA8", Offset = "0x248EBA8", VA = "0x2492BA8")]
		private X509Certificate FindCertificateRoot(X509Certificate potentialRoot)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2492FE4", Offset = "0x248EFE4", VA = "0x2492FE4")]
		private bool IsTrusted(X509Certificate potentialTrusted)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2492DB4", Offset = "0x248EDB4", VA = "0x2492DB4")]
		private bool IsParent(X509Certificate child, X509Certificate parent)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	[Flags]
	public enum X509ChainStatusFlags
	{
		[Token(Token = "0x4000068")]
		InvalidBasicConstraints = 0x400,
		[Token(Token = "0x4000069")]
		NoError = 0,
		[Token(Token = "0x400006A")]
		NotSignatureValid = 8,
		[Token(Token = "0x400006B")]
		NotTimeNested = 2,
		[Token(Token = "0x400006C")]
		NotTimeValid = 1,
		[Token(Token = "0x400006D")]
		PartialChain = 0x10000,
		[Token(Token = "0x400006E")]
		UntrustedRoot = 0x20
	}
	[Token(Token = "0x2000016")]
	public class X509Extension
	{
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x10")]
		protected string extnOid;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x18")]
		protected bool extnCritical;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x20")]
		protected ASN1 extnValue;

		[Token(Token = "0x1700003E")]
		public string Oid
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x24934F0", Offset = "0x248F4F0", VA = "0x24934F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public bool Critical
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x24934F8", Offset = "0x248F4F8", VA = "0x24934F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public ASN1 Value
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x24934BC", Offset = "0x248F4BC", VA = "0x24934BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x24930C4", Offset = "0x248F0C4", VA = "0x24930C4")]
		public X509Extension(ASN1 asn1)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x249337C", Offset = "0x248F37C", VA = "0x249337C")]
		public X509Extension(X509Extension extension)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x24934E8", Offset = "0x248F4E8", VA = "0x24934E8", Slot = "4")]
		protected virtual void Decode()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x24934EC", Offset = "0x248F4EC", VA = "0x24934EC", Slot = "5")]
		protected virtual void Encode()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2493500", Offset = "0x248F500", VA = "0x2493500", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x249362C", Offset = "0x248F62C", VA = "0x249362C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2493648", Offset = "0x248F648", VA = "0x2493648")]
		private void WriteLine(StringBuilder sb, int n, int pos)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x249386C", Offset = "0x248F86C", VA = "0x249386C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000017")]
	public sealed class X509ExtensionCollection : CollectionBase, IEnumerable
	{
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x18")]
		private bool readOnly;

		[Token(Token = "0x17000041")]
		public X509Extension this[string oid]
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2493010", Offset = "0x248F010", VA = "0x2493010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2493944", Offset = "0x248F944", VA = "0x2493944")]
		public X509ExtensionCollection()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x248F89C", Offset = "0x248B89C", VA = "0x248F89C")]
		public X509ExtensionCollection(ASN1 asn1)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x249394C", Offset = "0x248F94C", VA = "0x249394C")]
		public int IndexOf(string oid)
		{
			return default(int);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2493A84", Offset = "0x248FA84", VA = "0x2493A84", Slot = "19")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000018")]
	public class X509Store
	{
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x10")]
		private string _storePath;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		private X509CertificateCollection _certificates;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		private ArrayList _crls;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		private bool _crl;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x29")]
		private bool _newFormat;

		[Token(Token = "0x17000042")]
		public X509CertificateCollection Certificates
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2493AE4", Offset = "0x248FAE4", VA = "0x2493AE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public ArrayList Crls
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2493CE8", Offset = "0x248FCE8", VA = "0x2493CE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2493AA4", Offset = "0x248FAA4", VA = "0x2493AA4")]
		internal X509Store(string path, bool crl, bool newFormat)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2493F38", Offset = "0x248FF38", VA = "0x2493F38")]
		private byte[] Load(string filename)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x24940F8", Offset = "0x24900F8", VA = "0x24940F8")]
		private X509Certificate LoadCertificate(string filename)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2494160", Offset = "0x2490160", VA = "0x2494160")]
		private X509Crl LoadCrl(string filename)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x24941C8", Offset = "0x24901C8", VA = "0x24941C8")]
		private bool CheckStore(string path, bool throwException)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2493B0C", Offset = "0x248FB0C", VA = "0x2493B0C")]
		private X509CertificateCollection BuildCertificatesCollection(string storeName)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2493D70", Offset = "0x248FD70", VA = "0x2493D70")]
		private ArrayList BuildCrlsCollection(string storeName)
		{
			return null;
		}
	}
	[Token(Token = "0x2000019")]
	public sealed class X509StoreManager
	{
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x0")]
		private static string _userPath;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x8")]
		private static string _localMachinePath;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x10")]
		private static X509Stores _userStore;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x18")]
		private static X509Stores _machineStore;

		[Token(Token = "0x17000044")]
		internal static string CurrentUserPath
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x24942A4", Offset = "0x24902A4", VA = "0x24942A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		internal static string LocalMachinePath
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x249439C", Offset = "0x249039C", VA = "0x249439C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public static X509Stores CurrentUser
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x249447C", Offset = "0x249047C", VA = "0x249447C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public static X509Stores LocalMachine
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x2494544", Offset = "0x2490544", VA = "0x2494544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public static X509CertificateCollection TrustedRootCertificates
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x24925C8", Offset = "0x248E5C8", VA = "0x24925C8")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200001A")]
	public class X509Stores
	{
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x10")]
		private string _storePath;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x18")]
		private bool _newFormat;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x20")]
		private X509Store _trusted;

		[Token(Token = "0x17000049")]
		public X509Store TrustedRoot
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x24945DC", Offset = "0x24905DC", VA = "0x24945DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2494514", Offset = "0x2490514", VA = "0x2494514")]
		internal X509Stores(string path, bool newFormat)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x24946B0", Offset = "0x24906B0", VA = "0x24946B0")]
		public X509Store Open(string storeName, bool create)
		{
			return null;
		}
	}
}
namespace Mono.Security.X509.Extensions
{
	[Token(Token = "0x200001B")]
	public class AuthorityKeyIdentifierExtension : X509Extension
	{
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x28")]
		private byte[] aki;

		[Token(Token = "0x1700004A")]
		public byte[] Identifier
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x24949EC", Offset = "0x24909EC", VA = "0x24949EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x24947C4", Offset = "0x24907C4", VA = "0x24947C4")]
		public AuthorityKeyIdentifierExtension(X509Extension extension)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x24947C8", Offset = "0x24907C8", VA = "0x24947C8", Slot = "4")]
		protected override void Decode()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x24948DC", Offset = "0x24908DC", VA = "0x24948DC", Slot = "5")]
		protected override void Encode()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2494A60", Offset = "0x2490A60", VA = "0x2494A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200001C")]
	public class BasicConstraintsExtension : X509Extension
	{
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x28")]
		private bool cA;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x2C")]
		private int pathLenConstraint;

		[Token(Token = "0x1700004B")]
		public bool CertificateAuthority
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x2494E3C", Offset = "0x2490E3C", VA = "0x2494E3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x24930C0", Offset = "0x248F0C0", VA = "0x24930C0")]
		public BasicConstraintsExtension(X509Extension extension)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2494BE0", Offset = "0x2490BE0", VA = "0x2494BE0", Slot = "4")]
		protected override void Decode()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2494D14", Offset = "0x2490D14", VA = "0x2494D14", Slot = "5")]
		protected override void Encode()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2494E44", Offset = "0x2490E44", VA = "0x2494E44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Mono.Security.Protocol.Ntlm
{
	[Token(Token = "0x200001D")]
	[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
	public class ChallengeResponse : IDisposable
	{
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] magic;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] nullEncMagic;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x10")]
		private bool _disposed;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _challenge;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x20")]
		private byte[] _lmpwd;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x28")]
		private byte[] _ntpwd;

		[Token(Token = "0x1700004C")]
		public string Password
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2495090", Offset = "0x2491090", VA = "0x2495090")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public byte[] Challenge
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x2495498", Offset = "0x2491498", VA = "0x2495498")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public byte[] LM
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x24957EC", Offset = "0x24917EC", VA = "0x24957EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public byte[] NT
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2495B24", Offset = "0x2491B24", VA = "0x2495B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2494FE4", Offset = "0x2490FE4", VA = "0x2494FE4")]
		public ChallengeResponse()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2495058", Offset = "0x2491058", VA = "0x2495058")]
		public ChallengeResponse(string password, byte[] challenge)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x24955B8", Offset = "0x24915B8", VA = "0x24955B8", Slot = "1")]
		~ChallengeResponse()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2495644", Offset = "0x2491644", VA = "0x2495644", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2495B80", Offset = "0x2491B80", VA = "0x2495B80")]
		private void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2495848", Offset = "0x2491848", VA = "0x2495848")]
		private byte[] GetResponse(byte[] pwd)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2495BEC", Offset = "0x2491BEC", VA = "0x2495BEC")]
		private byte[] PrepareDESKey(byte[] key56bits, int position)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x24956A8", Offset = "0x24916A8", VA = "0x24956A8")]
		private byte[] PasswordToKey(string password, int position)
		{
			return null;
		}
	}
	[Token(Token = "0x200001E")]
	public static class ChallengeResponse2
	{
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] magic;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] nullEncMagic;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2495E9C", Offset = "0x2491E9C", VA = "0x2495E9C")]
		private static byte[] Compute_LM(string password, byte[] challenge)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2496624", Offset = "0x2492624", VA = "0x2496624")]
		private static byte[] Compute_NTLM_Password(string password)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2496728", Offset = "0x2492728", VA = "0x2496728")]
		private static byte[] Compute_NTLM(string password, byte[] challenge)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2496794", Offset = "0x2492794", VA = "0x2496794")]
		private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2496960", Offset = "0x2492960", VA = "0x2496960")]
		private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2496E88", Offset = "0x2492E88", VA = "0x2496E88")]
		public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2496330", Offset = "0x2492330", VA = "0x2496330")]
		private static byte[] GetResponse(byte[] challenge, byte[] pwd)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2497074", Offset = "0x2493074", VA = "0x2497074")]
		private static byte[] PrepareDESKey(byte[] key56bits, int position)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x24961C8", Offset = "0x24921C8", VA = "0x24961C8")]
		private static byte[] PasswordToKey(string password, int position)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public abstract class MessageBase
	{
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] header;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x10")]
		private int _type;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x14")]
		private NtlmFlags _flags;

		[Token(Token = "0x17000050")]
		public NtlmFlags Flags
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x249734C", Offset = "0x249334C", VA = "0x249734C")]
			get
			{
				return default(NtlmFlags);
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2497354", Offset = "0x2493354", VA = "0x2497354")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public int Type
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x249735C", Offset = "0x249335C", VA = "0x249735C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2497324", Offset = "0x2493324", VA = "0x2497324")]
		protected MessageBase(int messageType)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2497364", Offset = "0x2493364", VA = "0x2497364")]
		protected byte[] PrepareMessage(int messageSize)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2497464", Offset = "0x2493464", VA = "0x2497464", Slot = "4")]
		protected virtual void Decode(byte[] message)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x24975FC", Offset = "0x24935FC", VA = "0x24975FC")]
		protected bool CheckHeader(byte[] message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		public abstract byte[] GetBytes();
	}
	[Token(Token = "0x2000020")]
	public enum NtlmAuthLevel
	{
		[Token(Token = "0x400008E")]
		LM_and_NTLM,
		[Token(Token = "0x400008F")]
		LM_and_NTLM_and_try_NTLMv2_Session,
		[Token(Token = "0x4000090")]
		NTLM_only,
		[Token(Token = "0x4000091")]
		NTLMv2_only
	}
	[Token(Token = "0x2000021")]
	[Flags]
	public enum NtlmFlags
	{
		[Token(Token = "0x4000093")]
		NegotiateUnicode = 1,
		[Token(Token = "0x4000094")]
		NegotiateOem = 2,
		[Token(Token = "0x4000095")]
		RequestTarget = 4,
		[Token(Token = "0x4000096")]
		NegotiateNtlm = 0x200,
		[Token(Token = "0x4000097")]
		NegotiateDomainSupplied = 0x1000,
		[Token(Token = "0x4000098")]
		NegotiateWorkstationSupplied = 0x2000,
		[Token(Token = "0x4000099")]
		NegotiateAlwaysSign = 0x8000,
		[Token(Token = "0x400009A")]
		NegotiateNtlm2Key = 0x80000,
		[Token(Token = "0x400009B")]
		Negotiate128 = 0x20000000,
		[Token(Token = "0x400009C")]
		Negotiate56 = int.MinValue
	}
	[Token(Token = "0x2000022")]
	public static class NtlmSettings
	{
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		private static NtlmAuthLevel defaultAuthLevel;

		[Token(Token = "0x17000052")]
		public static NtlmAuthLevel DefaultAuthLevel
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x24977AC", Offset = "0x24937AC", VA = "0x24977AC")]
			get
			{
				return default(NtlmAuthLevel);
			}
		}
	}
	[Token(Token = "0x2000023")]
	public class Type1Message : MessageBase
	{
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x18")]
		private string _host;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x20")]
		private string _domain;

		[Token(Token = "0x17000053")]
		public string Domain
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x24978D4", Offset = "0x24938D4", VA = "0x24978D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public string Host
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2497958", Offset = "0x2493958", VA = "0x2497958")]
			set
			{
			}
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2497850", Offset = "0x2493850", VA = "0x2497850")]
		public Type1Message()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x24979DC", Offset = "0x24939DC", VA = "0x24979DC", Slot = "4")]
		protected override void Decode(byte[] message)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2497ACC", Offset = "0x2493ACC", VA = "0x2497ACC", Slot = "5")]
		public override byte[] GetBytes()
		{
			return null;
		}
	}
	[Token(Token = "0x2000024")]
	public class Type2Message : MessageBase
	{
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _nonce;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x20")]
		private string _targetName;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x28")]
		private byte[] _targetInfo;

		[Token(Token = "0x17000055")]
		public byte[] Nonce
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x2496E10", Offset = "0x2492E10", VA = "0x2496E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public string TargetName
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x2497E68", Offset = "0x2493E68", VA = "0x2497E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public byte[] TargetInfo
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2496D98", Offset = "0x2492D98", VA = "0x2496D98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2497D24", Offset = "0x2493D24", VA = "0x2497D24")]
		public Type2Message(byte[] message)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2497DCC", Offset = "0x2493DCC", VA = "0x2497DCC", Slot = "1")]
		~Type2Message()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2497E70", Offset = "0x2493E70", VA = "0x2497E70", Slot = "4")]
		protected override void Decode(byte[] message)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2497FF0", Offset = "0x2493FF0", VA = "0x2497FF0", Slot = "5")]
		public override byte[] GetBytes()
		{
			return null;
		}
	}
	[Token(Token = "0x2000025")]
	public class Type3Message : MessageBase
	{
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x18")]
		private NtlmAuthLevel _level;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x20")]
		private byte[] _challenge;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x28")]
		private string _host;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x30")]
		private string _domain;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x38")]
		private string _username;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x40")]
		private string _password;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x48")]
		private Type2Message _type2;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x50")]
		private byte[] _lm;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x58")]
		private byte[] _nt;

		[Token(Token = "0x17000058")]
		public string Domain
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x2498370", Offset = "0x2494370", VA = "0x2498370")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public string Password
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x24983F4", Offset = "0x24943F4", VA = "0x24983F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public string Username
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x24983FC", Offset = "0x24943FC", VA = "0x24983FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x24980A8", Offset = "0x24940A8", VA = "0x24980A8")]
		public Type3Message(Type2Message type2)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2498290", Offset = "0x2494290", VA = "0x2498290", Slot = "1")]
		~Type3Message()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2498404", Offset = "0x2494404", VA = "0x2498404", Slot = "4")]
		protected override void Decode(byte[] message)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2498624", Offset = "0x2494624", VA = "0x2498624")]
		private string DecodeString(byte[] buffer, int offset, int len)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x249867C", Offset = "0x249467C", VA = "0x249867C")]
		private byte[] EncodeString(string text)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x249870C", Offset = "0x249470C", VA = "0x249870C", Slot = "5")]
		public override byte[] GetBytes()
		{
			return null;
		}
	}
}
namespace Mono.Security.Interface
{
	[Token(Token = "0x2000026")]
	public enum AlertLevel : byte
	{
		[Token(Token = "0x40000AD")]
		Warning = 1,
		[Token(Token = "0x40000AE")]
		Fatal
	}
	[Token(Token = "0x2000027")]
	public enum AlertDescription : byte
	{
		[Token(Token = "0x40000B0")]
		CloseNotify = 0,
		[Token(Token = "0x40000B1")]
		UnexpectedMessage = 10,
		[Token(Token = "0x40000B2")]
		BadRecordMAC = 20,
		[Token(Token = "0x40000B3")]
		DecryptionFailed_RESERVED = 21,
		[Token(Token = "0x40000B4")]
		RecordOverflow = 22,
		[Token(Token = "0x40000B5")]
		DecompressionFailure = 30,
		[Token(Token = "0x40000B6")]
		HandshakeFailure = 40,
		[Token(Token = "0x40000B7")]
		NoCertificate_RESERVED = 41,
		[Token(Token = "0x40000B8")]
		BadCertificate = 42,
		[Token(Token = "0x40000B9")]
		UnsupportedCertificate = 43,
		[Token(Token = "0x40000BA")]
		CertificateRevoked = 44,
		[Token(Token = "0x40000BB")]
		CertificateExpired = 45,
		[Token(Token = "0x40000BC")]
		CertificateUnknown = 46,
		[Token(Token = "0x40000BD")]
		IlegalParameter = 47,
		[Token(Token = "0x40000BE")]
		UnknownCA = 48,
		[Token(Token = "0x40000BF")]
		AccessDenied = 49,
		[Token(Token = "0x40000C0")]
		DecodeError = 50,
		[Token(Token = "0x40000C1")]
		DecryptError = 51,
		[Token(Token = "0x40000C2")]
		ExportRestriction = 60,
		[Token(Token = "0x40000C3")]
		ProtocolVersion = 70,
		[Token(Token = "0x40000C4")]
		InsuficientSecurity = 71,
		[Token(Token = "0x40000C5")]
		InternalError = 80,
		[Token(Token = "0x40000C6")]
		UserCancelled = 90,
		[Token(Token = "0x40000C7")]
		NoRenegotiation = 100,
		[Token(Token = "0x40000C8")]
		UnsupportedExtension = 110
	}
	[Token(Token = "0x2000028")]
	public class Alert
	{
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x10")]
		private AlertLevel level;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x11")]
		private AlertDescription description;

		[Token(Token = "0x1700005B")]
		public AlertLevel Level
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x2498D14", Offset = "0x2494D14", VA = "0x2498D14")]
			get
			{
				return default(AlertLevel);
			}
		}

		[Token(Token = "0x1700005C")]
		public AlertDescription Description
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2498D1C", Offset = "0x2494D1C", VA = "0x2498D1C")]
			get
			{
				return default(AlertDescription);
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2498D24", Offset = "0x2494D24", VA = "0x2498D24")]
		public Alert(AlertDescription description)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2498D94", Offset = "0x2494D94", VA = "0x2498D94")]
		private void inferAlertLevel()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2498DD8", Offset = "0x2494DD8", VA = "0x2498DD8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000029")]
	public class ValidationResult
	{
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x10")]
		private bool trusted;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x11")]
		private bool user_denied;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x14")]
		private int error_code;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x18")]
		private MonoSslPolicyErrors? policy_errors;

		[Token(Token = "0x1700005D")]
		public bool Trusted
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2498EDC", Offset = "0x2494EDC", VA = "0x2498EDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		public bool UserDenied
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2498EE4", Offset = "0x2494EE4", VA = "0x2498EE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2498E94", Offset = "0x2494E94", VA = "0x2498E94")]
		public ValidationResult(bool trusted, bool user_denied, int error_code, MonoSslPolicyErrors? policy_errors)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public interface ICertificateValidator
	{
	}
	[Token(Token = "0x200002B")]
	[CLSCompliant(false)]
	public enum CipherSuiteCode : ushort
	{
		[Token(Token = "0x40000D0")]
		TLS_NULL_WITH_NULL_NULL = 0,
		[Token(Token = "0x40000D1")]
		TLS_RSA_WITH_NULL_MD5 = 1,
		[Token(Token = "0x40000D2")]
		TLS_RSA_WITH_NULL_SHA = 2,
		[Token(Token = "0x40000D3")]
		TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3,
		[Token(Token = "0x40000D4")]
		TLS_RSA_WITH_RC4_128_MD5 = 4,
		[Token(Token = "0x40000D5")]
		TLS_RSA_WITH_RC4_128_SHA = 5,
		[Token(Token = "0x40000D6")]
		TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6,
		[Token(Token = "0x40000D7")]
		TLS_RSA_WITH_IDEA_CBC_SHA = 7,
		[Token(Token = "0x40000D8")]
		TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8,
		[Token(Token = "0x40000D9")]
		TLS_RSA_WITH_DES_CBC_SHA = 9,
		[Token(Token = "0x40000DA")]
		TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10,
		[Token(Token = "0x40000DB")]
		TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11,
		[Token(Token = "0x40000DC")]
		TLS_DH_DSS_WITH_DES_CBC_SHA = 12,
		[Token(Token = "0x40000DD")]
		TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13,
		[Token(Token = "0x40000DE")]
		TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14,
		[Token(Token = "0x40000DF")]
		TLS_DH_RSA_WITH_DES_CBC_SHA = 15,
		[Token(Token = "0x40000E0")]
		TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16,
		[Token(Token = "0x40000E1")]
		TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17,
		[Token(Token = "0x40000E2")]
		TLS_DHE_DSS_WITH_DES_CBC_SHA = 18,
		[Token(Token = "0x40000E3")]
		TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19,
		[Token(Token = "0x40000E4")]
		TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20,
		[Token(Token = "0x40000E5")]
		TLS_DHE_RSA_WITH_DES_CBC_SHA = 21,
		[Token(Token = "0x40000E6")]
		TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22,
		[Token(Token = "0x40000E7")]
		TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23,
		[Token(Token = "0x40000E8")]
		TLS_DH_anon_WITH_RC4_128_MD5 = 24,
		[Token(Token = "0x40000E9")]
		TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25,
		[Token(Token = "0x40000EA")]
		TLS_DH_anon_WITH_DES_CBC_SHA = 26,
		[Token(Token = "0x40000EB")]
		TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27,
		[Token(Token = "0x40000EC")]
		TLS_RSA_WITH_AES_128_CBC_SHA = 47,
		[Token(Token = "0x40000ED")]
		TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48,
		[Token(Token = "0x40000EE")]
		TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49,
		[Token(Token = "0x40000EF")]
		TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50,
		[Token(Token = "0x40000F0")]
		TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51,
		[Token(Token = "0x40000F1")]
		TLS_DH_anon_WITH_AES_128_CBC_SHA = 52,
		[Token(Token = "0x40000F2")]
		TLS_RSA_WITH_AES_256_CBC_SHA = 53,
		[Token(Token = "0x40000F3")]
		TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54,
		[Token(Token = "0x40000F4")]
		TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55,
		[Token(Token = "0x40000F5")]
		TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56,
		[Token(Token = "0x40000F6")]
		TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57,
		[Token(Token = "0x40000F7")]
		TLS_DH_anon_WITH_AES_256_CBC_SHA = 58,
		[Token(Token = "0x40000F8")]
		TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65,
		[Token(Token = "0x40000F9")]
		TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66,
		[Token(Token = "0x40000FA")]
		TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67,
		[Token(Token = "0x40000FB")]
		TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68,
		[Token(Token = "0x40000FC")]
		TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69,
		[Token(Token = "0x40000FD")]
		TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70,
		[Token(Token = "0x40000FE")]
		TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132,
		[Token(Token = "0x40000FF")]
		TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133,
		[Token(Token = "0x4000100")]
		TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134,
		[Token(Token = "0x4000101")]
		TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135,
		[Token(Token = "0x4000102")]
		TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136,
		[Token(Token = "0x4000103")]
		TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137,
		[Token(Token = "0x4000104")]
		TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186,
		[Token(Token = "0x4000105")]
		TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187,
		[Token(Token = "0x4000106")]
		TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188,
		[Token(Token = "0x4000107")]
		TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189,
		[Token(Token = "0x4000108")]
		TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190,
		[Token(Token = "0x4000109")]
		TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191,
		[Token(Token = "0x400010A")]
		TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192,
		[Token(Token = "0x400010B")]
		TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193,
		[Token(Token = "0x400010C")]
		TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194,
		[Token(Token = "0x400010D")]
		TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195,
		[Token(Token = "0x400010E")]
		TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196,
		[Token(Token = "0x400010F")]
		TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197,
		[Token(Token = "0x4000110")]
		TLS_RSA_WITH_SEED_CBC_SHA = 150,
		[Token(Token = "0x4000111")]
		TLS_DH_DSS_WITH_SEED_CBC_SHA = 151,
		[Token(Token = "0x4000112")]
		TLS_DH_RSA_WITH_SEED_CBC_SHA = 152,
		[Token(Token = "0x4000113")]
		TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153,
		[Token(Token = "0x4000114")]
		TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154,
		[Token(Token = "0x4000115")]
		TLS_DH_anon_WITH_SEED_CBC_SHA = 155,
		[Token(Token = "0x4000116")]
		TLS_PSK_WITH_RC4_128_SHA = 138,
		[Token(Token = "0x4000117")]
		TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139,
		[Token(Token = "0x4000118")]
		TLS_PSK_WITH_AES_128_CBC_SHA = 140,
		[Token(Token = "0x4000119")]
		TLS_PSK_WITH_AES_256_CBC_SHA = 141,
		[Token(Token = "0x400011A")]
		TLS_DHE_PSK_WITH_RC4_128_SHA = 142,
		[Token(Token = "0x400011B")]
		TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143,
		[Token(Token = "0x400011C")]
		TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144,
		[Token(Token = "0x400011D")]
		TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145,
		[Token(Token = "0x400011E")]
		TLS_RSA_PSK_WITH_RC4_128_SHA = 146,
		[Token(Token = "0x400011F")]
		TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147,
		[Token(Token = "0x4000120")]
		TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148,
		[Token(Token = "0x4000121")]
		TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149,
		[Token(Token = "0x4000122")]
		TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153,
		[Token(Token = "0x4000123")]
		TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154,
		[Token(Token = "0x4000124")]
		TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155,
		[Token(Token = "0x4000125")]
		TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156,
		[Token(Token = "0x4000126")]
		TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157,
		[Token(Token = "0x4000127")]
		TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158,
		[Token(Token = "0x4000128")]
		TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159,
		[Token(Token = "0x4000129")]
		TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160,
		[Token(Token = "0x400012A")]
		TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161,
		[Token(Token = "0x400012B")]
		TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162,
		[Token(Token = "0x400012C")]
		TLS_ECDH_RSA_WITH_NULL_SHA = 49163,
		[Token(Token = "0x400012D")]
		TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164,
		[Token(Token = "0x400012E")]
		TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165,
		[Token(Token = "0x400012F")]
		TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166,
		[Token(Token = "0x4000130")]
		TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167,
		[Token(Token = "0x4000131")]
		TLS_ECDHE_RSA_WITH_NULL_SHA = 49168,
		[Token(Token = "0x4000132")]
		TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169,
		[Token(Token = "0x4000133")]
		TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170,
		[Token(Token = "0x4000134")]
		TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171,
		[Token(Token = "0x4000135")]
		TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172,
		[Token(Token = "0x4000136")]
		TLS_ECDH_anon_WITH_NULL_SHA = 49173,
		[Token(Token = "0x4000137")]
		TLS_ECDH_anon_WITH_RC4_128_SHA = 49174,
		[Token(Token = "0x4000138")]
		TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175,
		[Token(Token = "0x4000139")]
		TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176,
		[Token(Token = "0x400013A")]
		TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177,
		[Token(Token = "0x400013B")]
		TLS_PSK_WITH_NULL_SHA = 44,
		[Token(Token = "0x400013C")]
		TLS_DHE_PSK_WITH_NULL_SHA = 45,
		[Token(Token = "0x400013D")]
		TLS_RSA_PSK_WITH_NULL_SHA = 46,
		[Token(Token = "0x400013E")]
		TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178,
		[Token(Token = "0x400013F")]
		TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179,
		[Token(Token = "0x4000140")]
		TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180,
		[Token(Token = "0x4000141")]
		TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181,
		[Token(Token = "0x4000142")]
		TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182,
		[Token(Token = "0x4000143")]
		TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183,
		[Token(Token = "0x4000144")]
		TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184,
		[Token(Token = "0x4000145")]
		TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185,
		[Token(Token = "0x4000146")]
		TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186,
		[Token(Token = "0x4000147")]
		TLS_RSA_WITH_NULL_SHA256 = 59,
		[Token(Token = "0x4000148")]
		TLS_RSA_WITH_AES_128_CBC_SHA256 = 60,
		[Token(Token = "0x4000149")]
		TLS_RSA_WITH_AES_256_CBC_SHA256 = 61,
		[Token(Token = "0x400014A")]
		TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62,
		[Token(Token = "0x400014B")]
		TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63,
		[Token(Token = "0x400014C")]
		TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64,
		[Token(Token = "0x400014D")]
		TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103,
		[Token(Token = "0x400014E")]
		TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104,
		[Token(Token = "0x400014F")]
		TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105,
		[Token(Token = "0x4000150")]
		TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106,
		[Token(Token = "0x4000151")]
		TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107,
		[Token(Token = "0x4000152")]
		TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108,
		[Token(Token = "0x4000153")]
		TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109,
		[Token(Token = "0x4000154")]
		TLS_RSA_WITH_AES_128_GCM_SHA256 = 156,
		[Token(Token = "0x4000155")]
		TLS_RSA_WITH_AES_256_GCM_SHA384 = 157,
		[Token(Token = "0x4000156")]
		TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158,
		[Token(Token = "0x4000157")]
		TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159,
		[Token(Token = "0x4000158")]
		TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160,
		[Token(Token = "0x4000159")]
		TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161,
		[Token(Token = "0x400015A")]
		TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162,
		[Token(Token = "0x400015B")]
		TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163,
		[Token(Token = "0x400015C")]
		TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164,
		[Token(Token = "0x400015D")]
		TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165,
		[Token(Token = "0x400015E")]
		TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166,
		[Token(Token = "0x400015F")]
		TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167,
		[Token(Token = "0x4000160")]
		TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187,
		[Token(Token = "0x4000161")]
		TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188,
		[Token(Token = "0x4000162")]
		TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189,
		[Token(Token = "0x4000163")]
		TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190,
		[Token(Token = "0x4000164")]
		TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191,
		[Token(Token = "0x4000165")]
		TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192,
		[Token(Token = "0x4000166")]
		TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193,
		[Token(Token = "0x4000167")]
		TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194,
		[Token(Token = "0x4000168")]
		TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195,
		[Token(Token = "0x4000169")]
		TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196,
		[Token(Token = "0x400016A")]
		TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197,
		[Token(Token = "0x400016B")]
		TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198,
		[Token(Token = "0x400016C")]
		TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199,
		[Token(Token = "0x400016D")]
		TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200,
		[Token(Token = "0x400016E")]
		TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201,
		[Token(Token = "0x400016F")]
		TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202,
		[Token(Token = "0x4000170")]
		TLS_PSK_WITH_AES_128_GCM_SHA256 = 168,
		[Token(Token = "0x4000171")]
		TLS_PSK_WITH_AES_256_GCM_SHA384 = 169,
		[Token(Token = "0x4000172")]
		TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170,
		[Token(Token = "0x4000173")]
		TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171,
		[Token(Token = "0x4000174")]
		TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172,
		[Token(Token = "0x4000175")]
		TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173,
		[Token(Token = "0x4000176")]
		TLS_PSK_WITH_AES_128_CBC_SHA256 = 174,
		[Token(Token = "0x4000177")]
		TLS_PSK_WITH_AES_256_CBC_SHA384 = 175,
		[Token(Token = "0x4000178")]
		TLS_PSK_WITH_NULL_SHA256 = 176,
		[Token(Token = "0x4000179")]
		TLS_PSK_WITH_NULL_SHA384 = 177,
		[Token(Token = "0x400017A")]
		TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178,
		[Token(Token = "0x400017B")]
		TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179,
		[Token(Token = "0x400017C")]
		TLS_DHE_PSK_WITH_NULL_SHA256 = 180,
		[Token(Token = "0x400017D")]
		TLS_DHE_PSK_WITH_NULL_SHA384 = 181,
		[Token(Token = "0x400017E")]
		TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182,
		[Token(Token = "0x400017F")]
		TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183,
		[Token(Token = "0x4000180")]
		TLS_RSA_PSK_WITH_NULL_SHA256 = 184,
		[Token(Token = "0x4000181")]
		TLS_RSA_PSK_WITH_NULL_SHA384 = 185,
		[Token(Token = "0x4000182")]
		TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203,
		[Token(Token = "0x4000183")]
		TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204,
		[Token(Token = "0x4000184")]
		TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205,
		[Token(Token = "0x4000185")]
		TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206,
		[Token(Token = "0x4000186")]
		TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207,
		[Token(Token = "0x4000187")]
		TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208,
		[Token(Token = "0x4000188")]
		TLS_ECDHE_PSK_WITH_NULL_SHA = 49209,
		[Token(Token = "0x4000189")]
		TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210,
		[Token(Token = "0x400018A")]
		TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211,
		[Token(Token = "0x400018B")]
		TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255,
		[Token(Token = "0x400018C")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266,
		[Token(Token = "0x400018D")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267,
		[Token(Token = "0x400018E")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268,
		[Token(Token = "0x400018F")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269,
		[Token(Token = "0x4000190")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270,
		[Token(Token = "0x4000191")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271,
		[Token(Token = "0x4000192")]
		TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272,
		[Token(Token = "0x4000193")]
		TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273,
		[Token(Token = "0x4000194")]
		TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274,
		[Token(Token = "0x4000195")]
		TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275,
		[Token(Token = "0x4000196")]
		TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276,
		[Token(Token = "0x4000197")]
		TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277,
		[Token(Token = "0x4000198")]
		TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278,
		[Token(Token = "0x4000199")]
		TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279,
		[Token(Token = "0x400019A")]
		TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280,
		[Token(Token = "0x400019B")]
		TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281,
		[Token(Token = "0x400019C")]
		TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282,
		[Token(Token = "0x400019D")]
		TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283,
		[Token(Token = "0x400019E")]
		TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284,
		[Token(Token = "0x400019F")]
		TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285,
		[Token(Token = "0x40001A0")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286,
		[Token(Token = "0x40001A1")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287,
		[Token(Token = "0x40001A2")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288,
		[Token(Token = "0x40001A3")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289,
		[Token(Token = "0x40001A4")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290,
		[Token(Token = "0x40001A5")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291,
		[Token(Token = "0x40001A6")]
		TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292,
		[Token(Token = "0x40001A7")]
		TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293,
		[Token(Token = "0x40001A8")]
		TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294,
		[Token(Token = "0x40001A9")]
		TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295,
		[Token(Token = "0x40001AA")]
		TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296,
		[Token(Token = "0x40001AB")]
		TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297,
		[Token(Token = "0x40001AC")]
		TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298,
		[Token(Token = "0x40001AD")]
		TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299,
		[Token(Token = "0x40001AE")]
		TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300,
		[Token(Token = "0x40001AF")]
		TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301,
		[Token(Token = "0x40001B0")]
		TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302,
		[Token(Token = "0x40001B1")]
		TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303,
		[Token(Token = "0x40001B2")]
		TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304,
		[Token(Token = "0x40001B3")]
		TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305,
		[Token(Token = "0x40001B4")]
		TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306,
		[Token(Token = "0x40001B5")]
		TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307,
		[Token(Token = "0x40001B6")]
		TLS_RSA_WITH_AES_128_CCM = 49308,
		[Token(Token = "0x40001B7")]
		TLS_RSA_WITH_AES_256_CCM = 49309,
		[Token(Token = "0x40001B8")]
		TLS_DHE_RSA_WITH_AES_128_CCM = 49310,
		[Token(Token = "0x40001B9")]
		TLS_DHE_RSA_WITH_AES_256_CCM = 49311,
		[Token(Token = "0x40001BA")]
		TLS_RSA_WITH_AES_128_CCM_8 = 49312,
		[Token(Token = "0x40001BB")]
		TLS_RSA_WITH_AES_256_CCM_8 = 49313,
		[Token(Token = "0x40001BC")]
		TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314,
		[Token(Token = "0x40001BD")]
		TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315,
		[Token(Token = "0x40001BE")]
		TLS_PSK_WITH_AES_128_CCM = 49316,
		[Token(Token = "0x40001BF")]
		TLS_PSK_WITH_AES_256_CCM = 49317,
		[Token(Token = "0x40001C0")]
		TLS_DHE_PSK_WITH_AES_128_CCM = 49318,
		[Token(Token = "0x40001C1")]
		TLS_DHE_PSK_WITH_AES_256_CCM = 49319,
		[Token(Token = "0x40001C2")]
		TLS_PSK_WITH_AES_128_CCM_8 = 49320,
		[Token(Token = "0x40001C3")]
		TLS_PSK_WITH_AES_256_CCM_8 = 49321,
		[Token(Token = "0x40001C4")]
		TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322,
		[Token(Token = "0x40001C5")]
		TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323,
		[Token(Token = "0x40001C6")]
		TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243,
		[Token(Token = "0x40001C7")]
		TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244,
		[Token(Token = "0x40001C8")]
		TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245,
		[Token(Token = "0x40001C9")]
		TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384,
		[Token(Token = "0x40001CA")]
		TLS_RSA_WITH_SALSA20_SHA1 = 58385,
		[Token(Token = "0x40001CB")]
		TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386,
		[Token(Token = "0x40001CC")]
		TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387,
		[Token(Token = "0x40001CD")]
		TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388,
		[Token(Token = "0x40001CE")]
		TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389,
		[Token(Token = "0x40001CF")]
		TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390,
		[Token(Token = "0x40001D0")]
		TLS_PSK_WITH_SALSA20_SHA1 = 58391,
		[Token(Token = "0x40001D1")]
		TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392,
		[Token(Token = "0x40001D2")]
		TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393,
		[Token(Token = "0x40001D3")]
		TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394,
		[Token(Token = "0x40001D4")]
		TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395,
		[Token(Token = "0x40001D5")]
		TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396,
		[Token(Token = "0x40001D6")]
		TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397,
		[Token(Token = "0x40001D7")]
		TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398,
		[Token(Token = "0x40001D8")]
		TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399,
		[Token(Token = "0x40001D9")]
		TLS_FALLBACK_SCSV = 22016
	}
	[Token(Token = "0x200002C")]
	public class MonoTlsConnectionInfo
	{
		[Token(Token = "0x1700005F")]
		[CLSCompliant(false)]
		public CipherSuiteCode CipherSuiteCode
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x2498EEC", Offset = "0x2494EEC", VA = "0x2498EEC")]
			[CompilerGenerated]
			get
			{
				return default(CipherSuiteCode);
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2498EF4", Offset = "0x2494EF4", VA = "0x2498EF4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public TlsProtocols ProtocolVersion
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2498EFC", Offset = "0x2494EFC", VA = "0x2498EFC")]
			[CompilerGenerated]
			get
			{
				return default(TlsProtocols);
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2498F04", Offset = "0x2494F04", VA = "0x2498F04")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public string PeerDomainName
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2498F0C", Offset = "0x2494F0C", VA = "0x2498F0C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2498F14", Offset = "0x2494F14", VA = "0x2498F14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2498FD0", Offset = "0x2494FD0", VA = "0x2498FD0")]
		public MonoTlsConnectionInfo()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[Flags]
	public enum MonoSslPolicyErrors
	{
		[Token(Token = "0x40001DE")]
		None = 0,
		[Token(Token = "0x40001DF")]
		RemoteCertificateNotAvailable = 1,
		[Token(Token = "0x40001E0")]
		RemoteCertificateNameMismatch = 2,
		[Token(Token = "0x40001E1")]
		RemoteCertificateChainErrors = 4
	}
	[Token(Token = "0x200002E")]
	public delegate bool MonoRemoteCertificateValidationCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, MonoSslPolicyErrors sslPolicyErrors);
	[Token(Token = "0x200002F")]
	public delegate System.Security.Cryptography.X509Certificates.X509Certificate MonoLocalCertificateSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
	[Token(Token = "0x2000030")]
	public abstract class MonoTlsProvider
	{
		[Token(Token = "0x17000062")]
		public abstract Guid ID
		{
			[Token(Token = "0x600012F")]
			get;
		}

		[Token(Token = "0x17000063")]
		public abstract string Name
		{
			[Token(Token = "0x6000130")]
			get;
		}

		[Token(Token = "0x17000064")]
		public abstract bool SupportsSslStream
		{
			[Token(Token = "0x6000131")]
			get;
		}

		[Token(Token = "0x17000065")]
		public abstract bool SupportsConnectionInfo
		{
			[Token(Token = "0x6000132")]
			get;
		}

		[Token(Token = "0x17000066")]
		public abstract bool SupportsMonoExtensions
		{
			[Token(Token = "0x6000133")]
			get;
		}

		[Token(Token = "0x17000067")]
		public abstract SslProtocols SupportedProtocols
		{
			[Token(Token = "0x6000134")]
			get;
		}

		[Token(Token = "0x17000068")]
		internal abstract bool SupportsCleanShutdown
		{
			[Token(Token = "0x6000135")]
			get;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2499140", Offset = "0x2495140", VA = "0x2499140")]
		internal MonoTlsProvider()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public static class MonoTlsProviderFactory
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2499148", Offset = "0x2495148", VA = "0x2499148")]
		public static MonoTlsProvider GetProvider()
		{
			return null;
		}
	}
	[Token(Token = "0x2000032")]
	public sealed class MonoTlsSettings
	{
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x70")]
		private bool cloned;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x71")]
		private bool checkCertName;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x72")]
		private bool checkCertRevocationStatus;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x73")]
		private bool? useServicePointManagerCallback;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x75")]
		private bool skipSystemValidators;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x76")]
		private bool callbackNeedsChain;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x78")]
		private ICertificateValidator certificateValidator;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x0")]
		private static MonoTlsSettings defaultSettings;

		[Token(Token = "0x17000069")]
		public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x24991B8", Offset = "0x24951B8", VA = "0x24991B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x24991C0", Offset = "0x24951C0", VA = "0x24991C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x24991C8", Offset = "0x24951C8", VA = "0x24991C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x24991D0", Offset = "0x24951D0", VA = "0x24991D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public bool? UseServicePointManagerCallback
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x24991D8", Offset = "0x24951D8", VA = "0x24991D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x24991E0", Offset = "0x24951E0", VA = "0x24991E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public bool CallbackNeedsCertificateChain
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x24991E8", Offset = "0x24951E8", VA = "0x24991E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public DateTime? CertificateValidationTime
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x24991F0", Offset = "0x24951F0", VA = "0x24991F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x24991FC", Offset = "0x24951FC", VA = "0x24991FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public System.Security.Cryptography.X509Certificates.X509CertificateCollection TrustAnchors
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2499204", Offset = "0x2495204", VA = "0x2499204")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x249920C", Offset = "0x249520C", VA = "0x249920C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public object UserSettings
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2499214", Offset = "0x2495214", VA = "0x2499214")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x249921C", Offset = "0x249521C", VA = "0x249921C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		internal string[] CertificateSearchPaths
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x2499224", Offset = "0x2495224", VA = "0x2499224")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x249922C", Offset = "0x249522C", VA = "0x249922C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		internal bool SendCloseNotify
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2499234", Offset = "0x2495234", VA = "0x2499234")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x249923C", Offset = "0x249523C", VA = "0x249923C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public string[] ClientCertificateIssuers
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2499244", Offset = "0x2495244", VA = "0x2499244")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x249924C", Offset = "0x249524C", VA = "0x249924C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public bool DisallowUnauthenticatedCertificateRequest
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2499254", Offset = "0x2495254", VA = "0x2499254")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x249925C", Offset = "0x249525C", VA = "0x249925C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public TlsProtocols? EnabledProtocols
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2499264", Offset = "0x2495264", VA = "0x2499264")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x249926C", Offset = "0x249526C", VA = "0x249926C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		[CLSCompliant(false)]
		public CipherSuiteCode[] EnabledCiphers
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2499274", Offset = "0x2495274", VA = "0x2499274")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x249927C", Offset = "0x249527C", VA = "0x249927C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public static MonoTlsSettings DefaultSettings
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2499298", Offset = "0x2495298", VA = "0x2499298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		[Obsolete("Do not use outside System.dll!")]
		public ICertificateValidator CertificateValidator
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2499394", Offset = "0x2495394", VA = "0x2499394")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2499284", Offset = "0x2495284", VA = "0x2499284")]
		public MonoTlsSettings()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2499324", Offset = "0x2495324", VA = "0x2499324")]
		public static MonoTlsSettings CopyDefaultSettings()
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x249939C", Offset = "0x249539C", VA = "0x249939C")]
		[Obsolete("Do not use outside System.dll!")]
		public MonoTlsSettings CloneWithValidator(ICertificateValidator validator)
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x249933C", Offset = "0x249533C", VA = "0x249933C")]
		public MonoTlsSettings Clone()
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2499410", Offset = "0x2495410", VA = "0x2499410")]
		private MonoTlsSettings(MonoTlsSettings other)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public sealed class TlsException : Exception
	{
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x90")]
		private Alert alert;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2499544", Offset = "0x2495544", VA = "0x2499544")]
		public TlsException(Alert alert, string message)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x24995B8", Offset = "0x24955B8", VA = "0x24995B8")]
		public TlsException(AlertDescription description, string message)
		{
		}
	}
	[Token(Token = "0x2000034")]
	[Flags]
	public enum TlsProtocols
	{
		[Token(Token = "0x40001F7")]
		Zero = 0,
		[Token(Token = "0x40001F8")]
		Tls10Client = 0x80,
		[Token(Token = "0x40001F9")]
		Tls10Server = 0x40,
		[Token(Token = "0x40001FA")]
		Tls10 = 0xC0,
		[Token(Token = "0x40001FB")]
		Tls11Client = 0x200,
		[Token(Token = "0x40001FC")]
		Tls11Server = 0x100,
		[Token(Token = "0x40001FD")]
		Tls11 = 0x300,
		[Token(Token = "0x40001FE")]
		Tls12Client = 0x800,
		[Token(Token = "0x40001FF")]
		Tls12Server = 0x400,
		[Token(Token = "0x4000200")]
		Tls12 = 0xC00,
		[Token(Token = "0x4000201")]
		ClientMask = 0xA80,
		[Token(Token = "0x4000202")]
		ServerMask = 0x540
	}
}
namespace Mono.Security.Cryptography
{
	[Token(Token = "0x2000035")]
	public sealed class CryptoConvert
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x249962C", Offset = "0x249562C", VA = "0x249962C")]
		public static string ToHex(byte[] input)
		{
			return null;
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class MD2 : HashAlgorithm
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2499768", Offset = "0x2495768", VA = "0x2499768")]
		protected MD2()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2499788", Offset = "0x2495788", VA = "0x2499788")]
		public static MD2 Create()
		{
			return null;
		}
	}
	[Token(Token = "0x2000037")]
	public class MD2Managed : MD2
	{
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x28")]
		private byte[] state;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x30")]
		private byte[] checksum;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x38")]
		private byte[] buffer;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x40")]
		private int count;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x48")]
		private byte[] x;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] PI_SUBST;

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x249988C", Offset = "0x249588C", VA = "0x249988C")]
		private byte[] Padding(int nLength)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x24997D8", Offset = "0x24957D8", VA = "0x24997D8")]
		public MD2Managed()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2499924", Offset = "0x2495924", VA = "0x2499924", Slot = "18")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2499984", Offset = "0x2495984", VA = "0x2499984", Slot = "16")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2499CD8", Offset = "0x2495CD8", VA = "0x2499CD8", Slot = "17")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2499A60", Offset = "0x2495A60", VA = "0x2499A60")]
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public abstract class MD4 : HashAlgorithm
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2499E5C", Offset = "0x2495E5C", VA = "0x2499E5C")]
		protected MD4()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2499E7C", Offset = "0x2495E7C", VA = "0x2499E7C")]
		public static MD4 Create()
		{
			return null;
		}
	}
	[Token(Token = "0x2000039")]
	public class MD4Managed : MD4
	{
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x28")]
		private uint[] state;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x30")]
		private byte[] buffer;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x38")]
		private uint[] count;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x40")]
		private uint[] x;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x48")]
		private byte[] digest;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2499ECC", Offset = "0x2495ECC", VA = "0x2499ECC")]
		public MD4Managed()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2499FB0", Offset = "0x2495FB0", VA = "0x2499FB0", Slot = "18")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x249A064", Offset = "0x2496064", VA = "0x249A064", Slot = "16")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x249A7F8", Offset = "0x24967F8", VA = "0x249A7F8", Slot = "17")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x249A9E8", Offset = "0x24969E8", VA = "0x249A9E8")]
		private byte[] Padding(int nLength)
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x249AA60", Offset = "0x2496A60", VA = "0x249AA60")]
		private uint F(uint x, uint y, uint z)
		{
			return default(uint);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x249AA70", Offset = "0x2496A70", VA = "0x249AA70")]
		private uint G(uint x, uint y, uint z)
		{
			return default(uint);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x249AA84", Offset = "0x2496A84", VA = "0x249AA84")]
		private uint H(uint x, uint y, uint z)
		{
			return default(uint);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x249AA90", Offset = "0x2496A90", VA = "0x249AA90")]
		private uint ROL(uint x, byte n)
		{
			return default(uint);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x249AA9C", Offset = "0x2496A9C", VA = "0x249AA9C")]
		private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x249AAC4", Offset = "0x2496AC4", VA = "0x249AAC4")]
		private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x249AAFC", Offset = "0x2496AFC", VA = "0x249AAFC")]
		private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x249A8F4", Offset = "0x24968F4", VA = "0x249A8F4")]
		private void Encode(byte[] output, uint[] input)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x249AB2C", Offset = "0x2496B2C", VA = "0x249AB2C")]
		private void Decode(uint[] output, byte[] input, int index)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x249A188", Offset = "0x2496188", VA = "0x249A188")]
		private void MD4Transform(uint[] state, byte[] block, int index)
		{
		}
	}
	[Token(Token = "0x200003A")]
	public sealed class PKCS1
	{
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] emptySHA1;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] emptySHA256;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x10")]
		private static byte[] emptySHA384;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x18")]
		private static byte[] emptySHA512;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x249ABF0", Offset = "0x2496BF0", VA = "0x249ABF0")]
		private static bool Compare(byte[] array1, byte[] array2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x249AC58", Offset = "0x2496C58", VA = "0x249AC58")]
		public static byte[] I2OSP(byte[] x, int size)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x249ACE4", Offset = "0x2496CE4", VA = "0x249ACE4")]
		public static byte[] OS2IP(byte[] x)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x249ADA8", Offset = "0x2496DA8", VA = "0x249ADA8")]
		public static byte[] RSAVP1(RSA rsa, byte[] s)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x249ADC0", Offset = "0x2496DC0", VA = "0x249ADC0")]
		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x249AF94", Offset = "0x2496F94", VA = "0x249AF94")]
		public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x249B2DC", Offset = "0x24972DC", VA = "0x249B2DC")]
		internal static string HashNameFromOid(string oid, bool throwOnError = true)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x249B6E4", Offset = "0x24976E4", VA = "0x249B6E4")]
		internal static HashAlgorithm CreateFromOid(string oid)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x249B740", Offset = "0x2497740", VA = "0x249B740")]
		internal static HashAlgorithm CreateFromName(string name)
		{
			return null;
		}
	}
	[Token(Token = "0x200003B")]
	public sealed class PKCS8
	{
		[Token(Token = "0x200003C")]
		public class PrivateKeyInfo
		{
			[Token(Token = "0x4000212")]
			[FieldOffset(Offset = "0x10")]
			private int _version;

			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x18")]
			private string _algorithm;

			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x20")]
			private byte[] _key;

			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x28")]
			private ArrayList _list;

			[Token(Token = "0x17000078")]
			public string Algorithm
			{
				[Token(Token = "0x6000180")]
				[Address(RVA = "0x249BF74", Offset = "0x2497F74", VA = "0x249BF74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			public byte[] PrivateKey
			{
				[Token(Token = "0x6000181")]
				[Address(RVA = "0x249BF7C", Offset = "0x2497F7C", VA = "0x249BF7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x249BC94", Offset = "0x2497C94", VA = "0x249BC94")]
			public PrivateKeyInfo()
			{
			}

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x249BCFC", Offset = "0x2497CFC", VA = "0x249BCFC")]
			public PrivateKeyInfo(byte[] data)
			{
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x249BD24", Offset = "0x2497D24", VA = "0x249BD24")]
			private void Decode(byte[] data)
			{
			}

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x249BFF0", Offset = "0x2497FF0", VA = "0x249BFF0")]
			private static byte[] RemoveLeadingZero(byte[] bigInt)
			{
				return null;
			}

			[Token(Token = "0x6000184")]
			[Address(RVA = "0x249C08C", Offset = "0x249808C", VA = "0x249C08C")]
			private static byte[] Normalize(byte[] bigInt, int length)
			{
				return null;
			}

			[Token(Token = "0x6000185")]
			[Address(RVA = "0x249C12C", Offset = "0x249812C", VA = "0x249C12C")]
			public static RSA DecodeRSA(byte[] keypair)
			{
				return null;
			}

			[Token(Token = "0x6000186")]
			[Address(RVA = "0x249C4F0", Offset = "0x24984F0", VA = "0x249C4F0")]
			public static byte[] Encode(RSA rsa)
			{
				return null;
			}

			[Token(Token = "0x6000187")]
			[Address(RVA = "0x249C6E8", Offset = "0x24986E8", VA = "0x249C6E8")]
			public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters)
			{
				return null;
			}

			[Token(Token = "0x6000188")]
			[Address(RVA = "0x249C800", Offset = "0x2498800", VA = "0x249C800")]
			public static byte[] Encode(DSA dsa)
			{
				return null;
			}

			[Token(Token = "0x6000189")]
			[Address(RVA = "0x249C84C", Offset = "0x249884C", VA = "0x249C84C")]
			public static byte[] Encode(AsymmetricAlgorithm aa)
			{
				return null;
			}
		}

		[Token(Token = "0x200003D")]
		public class EncryptedPrivateKeyInfo
		{
			[Token(Token = "0x4000216")]
			[FieldOffset(Offset = "0x10")]
			private string _algorithm;

			[Token(Token = "0x4000217")]
			[FieldOffset(Offset = "0x18")]
			private byte[] _salt;

			[Token(Token = "0x4000218")]
			[FieldOffset(Offset = "0x20")]
			private int _iterations;

			[Token(Token = "0x4000219")]
			[FieldOffset(Offset = "0x28")]
			private byte[] _data;

			[Token(Token = "0x1700007A")]
			public string Algorithm
			{
				[Token(Token = "0x600018C")]
				[Address(RVA = "0x249CC30", Offset = "0x2498C30", VA = "0x249CC30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public byte[] EncryptedData
			{
				[Token(Token = "0x600018D")]
				[Address(RVA = "0x249CC38", Offset = "0x2498C38", VA = "0x249CC38")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public byte[] Salt
			{
				[Token(Token = "0x600018E")]
				[Address(RVA = "0x249CCAC", Offset = "0x2498CAC", VA = "0x249CCAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			public int IterationCount
			{
				[Token(Token = "0x600018F")]
				[Address(RVA = "0x249CD60", Offset = "0x2498D60", VA = "0x249CD60")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600018A")]
			[Address(RVA = "0x249C970", Offset = "0x2498970", VA = "0x249C970")]
			public EncryptedPrivateKeyInfo()
			{
			}

			[Token(Token = "0x600018B")]
			[Address(RVA = "0x249C978", Offset = "0x2498978", VA = "0x249C978")]
			public EncryptedPrivateKeyInfo(byte[] data)
			{
			}

			[Token(Token = "0x6000190")]
			[Address(RVA = "0x249C9A4", Offset = "0x24989A4", VA = "0x249C9A4")]
			private void Decode(byte[] data)
			{
			}
		}
	}
	[Token(Token = "0x200003E")]
	public class RSAManaged : RSA
	{
		[Token(Token = "0x200003F")]
		public delegate void KeyGeneratedEventHandler(object sender, EventArgs e);

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x20")]
		private bool isCRTpossible;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x21")]
		private bool keyBlinding;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x22")]
		private bool keypairGenerated;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x23")]
		private bool m_disposed;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x28")]
		private BigInteger d;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x30")]
		private BigInteger p;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x38")]
		private BigInteger q;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x40")]
		private BigInteger dp;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x48")]
		private BigInteger dq;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x50")]
		private BigInteger qInv;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x58")]
		private BigInteger n;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x60")]
		private BigInteger e;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x68")]
		[CompilerGenerated]
		private KeyGeneratedEventHandler KeyGenerated;

		[Token(Token = "0x1700007E")]
		public override int KeySize
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x249D710", Offset = "0x2499710", VA = "0x249D710", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007F")]
		public bool PublicOnly
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x249D7AC", Offset = "0x24997AC", VA = "0x249D7AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x249CD68", Offset = "0x2498D68", VA = "0x249CD68")]
		public RSAManaged()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x249CD70", Offset = "0x2498D70", VA = "0x249CD70")]
		public RSAManaged(int keySize)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x249CE3C", Offset = "0x2498E3C", VA = "0x249CE3C", Slot = "1")]
		~RSAManaged()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x249CECC", Offset = "0x2498ECC", VA = "0x249CECC")]
		private void GenerateKeyPair()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x249D8FC", Offset = "0x24998FC", VA = "0x249D8FC", Slot = "10")]
		public override byte[] EncryptValue(byte[] rgb)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x249DD8C", Offset = "0x2499D8C", VA = "0x249DD8C", Slot = "11")]
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			return default(RSAParameters);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x249E1F0", Offset = "0x249A1F0", VA = "0x249E1F0", Slot = "12")]
		public override void ImportParameters(RSAParameters parameters)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x249E630", Offset = "0x249A630", VA = "0x249E630", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x249E834", Offset = "0x249A834", VA = "0x249E834", Slot = "9")]
		public override string ToXmlString(bool includePrivateParameters)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x249DC88", Offset = "0x2499C88", VA = "0x249DC88")]
		private byte[] GetPaddedValue(BigInteger value, int length)
		{
			return null;
		}
	}
}
namespace Mono.Security.Authenticode
{
	[Token(Token = "0x2000040")]
	public class AuthenticodeBase
	{
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x10")]
		private byte[] fileblock;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x18")]
		private Stream fs;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x20")]
		private int blockNo;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x24")]
		private int blockLength;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x28")]
		private int peOffset;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x2C")]
		private int dirSecurityOffset;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x30")]
		private int dirSecuritySize;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x34")]
		private int coffSymbolTableOffset;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x38")]
		private bool pe64;

		[Token(Token = "0x17000080")]
		internal int PEOffset
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x249F030", Offset = "0x249B030", VA = "0x249F030")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x249EFD4", Offset = "0x249AFD4", VA = "0x249EFD4")]
		public AuthenticodeBase()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x249F128", Offset = "0x249B128", VA = "0x249F128")]
		internal void Open(string filename)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x249F1E0", Offset = "0x249B1E0", VA = "0x249F1E0")]
		internal void Open(byte[] rawdata)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x249F1B4", Offset = "0x249B1B4", VA = "0x249F1B4")]
		internal void Close()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x249F058", Offset = "0x249B058", VA = "0x249F058")]
		internal void ReadFirstBlock()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x249F264", Offset = "0x249B264", VA = "0x249F264")]
		internal int ProcessFirstBlock()
		{
			return default(int);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x249F4A0", Offset = "0x249B4A0", VA = "0x249F4A0")]
		internal byte[] GetSecurityEntry()
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x249F570", Offset = "0x249B570", VA = "0x249F570")]
		internal byte[] GetHash(HashAlgorithm hash)
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	public class AuthenticodeDeformatter : AuthenticodeBase
	{
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x40")]
		private string filename;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x48")]
		private byte[] rawdata;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x50")]
		private byte[] hash;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x58")]
		private Mono.Security.X509.X509CertificateCollection coll;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x60")]
		private ASN1 signedHash;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x68")]
		private DateTime timestamp;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x70")]
		private Mono.Security.X509.X509Certificate signingCertificate;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x78")]
		private int reason;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x7C")]
		private bool trustedRoot;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x7D")]
		private bool trustedTimestampRoot;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x80")]
		private byte[] entry;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x88")]
		private Mono.Security.X509.X509Chain signerChain;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x90")]
		private Mono.Security.X509.X509Chain timestampChain;

		[Token(Token = "0x17000081")]
		public byte[] RawData
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x249FAB0", Offset = "0x249BAB0", VA = "0x249FAB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public Mono.Security.X509.X509Certificate SigningCertificate
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x249FF14", Offset = "0x249BF14", VA = "0x249FF14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x249FA08", Offset = "0x249BA08", VA = "0x249FA08")]
		public AuthenticodeDeformatter()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x249FA88", Offset = "0x249BA88", VA = "0x249FA88")]
		public AuthenticodeDeformatter(byte[] rawData)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x249FC24", Offset = "0x249BC24", VA = "0x249FC24")]
		private bool CheckSignature()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x24A08C0", Offset = "0x249C8C0", VA = "0x24A08C0")]
		private bool CompareIssuerSerial(string issuer, byte[] serial, Mono.Security.X509.X509Certificate x509)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x249FF1C", Offset = "0x249BF1C", VA = "0x249FF1C")]
		private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x24A09C4", Offset = "0x249C9C4", VA = "0x24A09C4")]
		private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x249FB80", Offset = "0x249BB80", VA = "0x249FB80")]
		private void Reset()
		{
		}
	}
}
namespace Mono.Math
{
	[Token(Token = "0x2000042")]
	public class BigInteger
	{
		[Token(Token = "0x2000043")]
		public enum Sign
		{
			[Token(Token = "0x4000242")]
			Negative = -1,
			[Token(Token = "0x4000243")]
			Zero,
			[Token(Token = "0x4000244")]
			Positive
		}

		[Token(Token = "0x2000044")]
		public sealed class ModulusRing
		{
			[Token(Token = "0x4000245")]
			[FieldOffset(Offset = "0x10")]
			private BigInteger mod;

			[Token(Token = "0x4000246")]
			[FieldOffset(Offset = "0x18")]
			private BigInteger constant;

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x24A30C0", Offset = "0x249F0C0", VA = "0x24A30C0")]
			public ModulusRing(BigInteger modulus)
			{
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x24A33BC", Offset = "0x249F3BC", VA = "0x24A33BC")]
			public void BarrettReduction(BigInteger x)
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x24A399C", Offset = "0x249F99C", VA = "0x24A399C")]
			public BigInteger Multiply(BigInteger a, BigInteger b)
			{
				return null;
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x24A3B18", Offset = "0x249FB18", VA = "0x24A3B18")]
			public BigInteger Difference(BigInteger a, BigInteger b)
			{
				return null;
			}

			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x24A3194", Offset = "0x249F194", VA = "0x24A3194")]
			public BigInteger Pow(BigInteger a, BigInteger k)
			{
				return null;
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x24A3CCC", Offset = "0x249FCCC", VA = "0x24A3CCC")]
			[CLSCompliant(false)]
			public BigInteger Pow(uint b, BigInteger exp)
			{
				return null;
			}
		}

		[Token(Token = "0x2000045")]
		private sealed class Kernel
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x24A17C0", Offset = "0x249D7C0", VA = "0x24A17C0")]
			public static BigInteger Subtract(BigInteger big, BigInteger small)
			{
				return null;
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x24A3724", Offset = "0x249F724", VA = "0x24A3724")]
			public static void MinusEq(BigInteger big, BigInteger small)
			{
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x24A3824", Offset = "0x249F824", VA = "0x24A3824")]
			public static void PlusEq(BigInteger bi1, BigInteger bi2)
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x24A167C", Offset = "0x249D67C", VA = "0x24A167C")]
			public static Sign Compare(BigInteger bi1, BigInteger bi2)
			{
				return default(Sign);
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x24A298C", Offset = "0x249E98C", VA = "0x24A298C")]
			public static uint SingleByteDivideInPlace(BigInteger n, uint d)
			{
				return default(uint);
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x24A195C", Offset = "0x249D95C", VA = "0x24A195C")]
			public static uint DwordMod(BigInteger n, uint d)
			{
				return default(uint);
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x24A3D3C", Offset = "0x249FD3C", VA = "0x24A3D3C")]
			public static BigInteger[] DwordDivMod(BigInteger n, uint d)
			{
				return null;
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x24A19C0", Offset = "0x249D9C0", VA = "0x24A19C0")]
			public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2)
			{
				return null;
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x24A1F20", Offset = "0x249DF20", VA = "0x24A1F20")]
			public static BigInteger LeftShift(BigInteger bi, int n)
			{
				return null;
			}

			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x24A20F4", Offset = "0x249E0F4", VA = "0x24A20F4")]
			public static BigInteger RightShift(BigInteger bi, int n)
			{
				return null;
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x24A1E38", Offset = "0x249DE38", VA = "0x24A1E38")]
			public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset)
			{
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x24A3614", Offset = "0x249F614", VA = "0x24A3614")]
			public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod)
			{
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x24A3EC4", Offset = "0x249FEC4", VA = "0x24A3EC4")]
			public static uint modInverse(BigInteger bi, uint modulus)
			{
				return default(uint);
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x24A2BA4", Offset = "0x249EBA4", VA = "0x24A2BA4")]
			public static BigInteger modInverse(BigInteger bi, BigInteger modulus)
			{
				return null;
			}
		}

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x10")]
		private uint length;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x18")]
		private uint[] data;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly uint[] smallPrimes;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x8")]
		private static RandomNumberGenerator rng;

		[Token(Token = "0x17000083")]
		private static RandomNumberGenerator Rng
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x24A2264", Offset = "0x249E264", VA = "0x24A2264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x24A1324", Offset = "0x249D324", VA = "0x24A1324")]
		[CLSCompliant(false)]
		public BigInteger(Sign sign, uint len)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x24A1398", Offset = "0x249D398", VA = "0x24A1398")]
		public BigInteger(BigInteger bi)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x24A1458", Offset = "0x249D458", VA = "0x24A1458")]
		[CLSCompliant(false)]
		public BigInteger(BigInteger bi, uint len)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x249DA04", Offset = "0x2499A04", VA = "0x249DA04")]
		public BigInteger(byte[] inData)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x24A1588", Offset = "0x249D588", VA = "0x24A1588")]
		[CLSCompliant(false)]
		public BigInteger(uint ui)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x249D134", Offset = "0x2499134", VA = "0x249D134")]
		[CLSCompliant(false)]
		public static implicit operator BigInteger(uint value)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x249D4D4", Offset = "0x24994D4", VA = "0x249D4D4")]
		public static implicit operator BigInteger(int value)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x249D578", Offset = "0x2499578", VA = "0x249D578")]
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x249D1F8", Offset = "0x24991F8", VA = "0x249D1F8")]
		[CLSCompliant(false)]
		public static uint operator %(BigInteger bi, uint ui)
		{
			return default(uint);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x249D6E4", Offset = "0x24996E4", VA = "0x249D6E4")]
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x24A1E10", Offset = "0x249DE10", VA = "0x24A1E10")]
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x249D2AC", Offset = "0x24992AC", VA = "0x249D2AC")]
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x24A1F1C", Offset = "0x249DF1C", VA = "0x24A1F1C")]
		public static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x24A20F0", Offset = "0x249E0F0", VA = "0x24A20F0")]
		public static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x24A230C", Offset = "0x249E30C", VA = "0x24A230C")]
		public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x24A246C", Offset = "0x249E46C", VA = "0x24A246C")]
		public static BigInteger GenerateRandom(int bits)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x249D454", Offset = "0x2499454", VA = "0x249D454")]
		public int BitCount()
		{
			return default(int);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x24A24C8", Offset = "0x249E4C8", VA = "0x24A24C8")]
		public bool TestBit(int bitNum)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x24A255C", Offset = "0x249E55C", VA = "0x24A255C")]
		[CLSCompliant(false)]
		public void SetBit(uint bitNum)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x24A2564", Offset = "0x249E564", VA = "0x24A2564")]
		[CLSCompliant(false)]
		public void SetBit(uint bitNum, bool value)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x24A25D8", Offset = "0x249E5D8", VA = "0x24A25D8")]
		public int LowestSetBit()
		{
			return default(int);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x249E0B4", Offset = "0x249A0B4", VA = "0x249E0B4")]
		public byte[] GetBytes()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x24A1610", Offset = "0x249D610", VA = "0x24A1610")]
		[CLSCompliant(false)]
		public static bool operator ==(BigInteger bi1, uint ui)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x24A2654", Offset = "0x249E654", VA = "0x24A2654")]
		[CLSCompliant(false)]
		public static bool operator !=(BigInteger bi1, uint ui)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x249D84C", Offset = "0x249984C", VA = "0x249D84C")]
		public static bool operator ==(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x249D1FC", Offset = "0x24991FC", VA = "0x249D1FC")]
		public static bool operator !=(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x24A26C0", Offset = "0x249E6C0", VA = "0x24A26C0")]
		public static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x249D4C0", Offset = "0x24994C0", VA = "0x249D4C0")]
		public static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x24A26D8", Offset = "0x249E6D8", VA = "0x24A26D8")]
		public static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x24A26F0", Offset = "0x249E6F0", VA = "0x24A26F0")]
		public static bool operator <=(BigInteger bi1, BigInteger bi2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x24A2708", Offset = "0x249E708", VA = "0x24A2708")]
		[CLSCompliant(false)]
		public string ToString(uint radix)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x24A2760", Offset = "0x249E760", VA = "0x24A2760")]
		[CLSCompliant(false)]
		public string ToString(uint radix, string characterSet)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x24A152C", Offset = "0x249D52C", VA = "0x24A152C")]
		private void Normalize()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x249DD38", Offset = "0x2499D38", VA = "0x249DD38")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x24A29FC", Offset = "0x249E9FC", VA = "0x24A29FC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x24A2A50", Offset = "0x249EA50", VA = "0x24A2A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x24A2A58", Offset = "0x249EA58", VA = "0x24A2A58", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x249D6E0", Offset = "0x24996E0", VA = "0x249D6E0")]
		public BigInteger ModInverse(BigInteger modulus)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x249DC10", Offset = "0x2499C10", VA = "0x249DC10")]
		public BigInteger ModPow(BigInteger exp, BigInteger n)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x249D18C", Offset = "0x249918C", VA = "0x249D18C")]
		public static BigInteger GeneratePseudoPrime(int bits)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x24A32A0", Offset = "0x249F2A0", VA = "0x24A32A0")]
		public void Incr2()
		{
		}
	}
}
namespace Mono.Math.Prime
{
	[Token(Token = "0x2000046")]
	public enum ConfidenceFactor
	{
		[Token(Token = "0x4000248")]
		ExtraLow,
		[Token(Token = "0x4000249")]
		Low,
		[Token(Token = "0x400024A")]
		Medium,
		[Token(Token = "0x400024B")]
		High,
		[Token(Token = "0x400024C")]
		ExtraHigh,
		[Token(Token = "0x400024D")]
		Provable
	}
	[Token(Token = "0x2000047")]
	public delegate bool PrimalityTest(BigInteger bi, ConfidenceFactor confidence);
	[Token(Token = "0x2000048")]
	public sealed class PrimalityTests
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x24A4098", Offset = "0x24A0098", VA = "0x24A4098")]
		private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence)
		{
			return default(int);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x24A4240", Offset = "0x24A0240", VA = "0x24A4240")]
		public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence)
		{
			return default(bool);
		}
	}
}
namespace Mono.Math.Prime.Generator
{
	[Token(Token = "0x2000049")]
	public abstract class PrimeGeneratorBase
	{
		[Token(Token = "0x17000084")]
		public virtual ConfidenceFactor Confidence
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x24A44E0", Offset = "0x24A04E0", VA = "0x24A44E0", Slot = "4")]
			get
			{
				return default(ConfidenceFactor);
			}
		}

		[Token(Token = "0x17000085")]
		public virtual PrimalityTest PrimalityTest
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x24A44E8", Offset = "0x24A04E8", VA = "0x24A44E8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public virtual int TrialDivisionBounds
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x24A4554", Offset = "0x24A0554", VA = "0x24A4554", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001F7")]
		public abstract BigInteger GenerateNewPrime(int bits);

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x24A455C", Offset = "0x24A055C", VA = "0x24A455C")]
		protected PrimeGeneratorBase()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x24A4564", Offset = "0x24A0564", VA = "0x24A4564", Slot = "8")]
		protected virtual BigInteger GenerateSearchBase(int bits, object context)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x24A45D8", Offset = "0x24A05D8", VA = "0x24A45D8", Slot = "7")]
		public override BigInteger GenerateNewPrime(int bits)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x24A45E8", Offset = "0x24A05E8", VA = "0x24A45E8", Slot = "9")]
		public virtual BigInteger GenerateNewPrime(int bits, object context)
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x24A48CC", Offset = "0x24A08CC", VA = "0x24A48CC", Slot = "10")]
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x24A3298", Offset = "0x249F298", VA = "0x24A3298")]
		public SequentialSearchPrimeGeneratorBase()
		{
		}
	}
}
