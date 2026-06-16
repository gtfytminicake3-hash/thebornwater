using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Il2CppDummyDll;
using LipingShare.LCLib.Asn1Processor;

[assembly: AssemblyVersion("0.0.0.0")]
namespace LipingShare.LCLib.Asn1Processor
{
	[Token(Token = "0x2000002")]
	public enum Asn1EndOfIndefiniteLengthNodeType
	{
		[Token(Token = "0x4000002")]
		EndOfStream,
		[Token(Token = "0x4000003")]
		EndOfNodeFooter,
		[Token(Token = "0x4000004")]
		NotEnd
	}
	[Token(Token = "0x2000003")]
	internal class Asn1Node
	{
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x10")]
		private byte tag;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		private long dataOffset;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		private long dataLength;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		private long lengthFieldBytes;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		private byte[] data;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x38")]
		private ArrayList childNodeList;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x40")]
		private byte unusedBits;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x48")]
		private long deepness;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x58")]
		private Asn1Node parentNode;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x60")]
		private bool requireRecalculatePar;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x61")]
		private bool isIndefiniteLength;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x62")]
		private bool parseEncapsulatedData;

		[Token(Token = "0x17000001")]
		public bool IsIndefiniteLength
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2C2BB08", Offset = "0x2C27B08", VA = "0x2C2BB08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000002")]
		public byte Tag
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2C2BB10", Offset = "0x2C27B10", VA = "0x2C2BB10", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000003")]
		public byte MaskedTag
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2C2BB18", Offset = "0x2C27B18", VA = "0x2C2BB18", Slot = "5")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000004")]
		public long ChildNodeCount
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2C2BDBC", Offset = "0x2C27DBC", VA = "0x2C2BDBC", Slot = "10")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000005")]
		public string TagName
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2C2C1EC", Offset = "0x2C281EC", VA = "0x2C2C1EC", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public Asn1Node ParentNode
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2C2C648", Offset = "0x2C28648", VA = "0x2C2C648", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		public long DataLength
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2C2DB14", Offset = "0x2C29B14", VA = "0x2C2DB14", Slot = "16")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000008")]
		public byte[] Data
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2C2DB1C", Offset = "0x2C29B1C", VA = "0x2C2DB1C", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public long Deepness
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2C2DCA4", Offset = "0x2C29CA4", VA = "0x2C2DCA4", Slot = "18")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700000A")]
		protected bool RequireRecalculatePar
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2C2DCAC", Offset = "0x2C29CAC", VA = "0x2C2DCAC")]
			set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2C2B0A8", Offset = "0x2C270A8", VA = "0x2C2B0A8")]
		private Asn1Node(Asn1Node parentNode, long dataOffset)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2C2B13C", Offset = "0x2C2713C", VA = "0x2C2B13C")]
		private void Init()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2C2B1C8", Offset = "0x2C271C8", VA = "0x2C2B1C8")]
		private string GetHexPrintingStr(Asn1Node startNode, string baseLine, string lStr, int lineLen)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2C2B7AC", Offset = "0x2C277AC", VA = "0x2C2B7AC")]
		private string FormatLineString(string lStr, int indent, int lineLen, string msg)
		{
			return null;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2C2B59C", Offset = "0x2C2759C", VA = "0x2C2B59C")]
		private string FormatLineHexString(string lStr, int indent, int lineLen, string msg)
		{
			return null;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2C2BA9C", Offset = "0x2C27A9C", VA = "0x2C2BA9C")]
		public Asn1Node()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2C2BB24", Offset = "0x2C27B24", VA = "0x2C2BB24", Slot = "6")]
		public bool LoadData(Stream xdata)
		{
			return default(bool);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2C2BC90", Offset = "0x2C27C90", VA = "0x2C2BC90", Slot = "7")]
		public bool SaveData(Stream xdata)
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2C2BFD4", Offset = "0x2C27FD4", VA = "0x2C2BFD4", Slot = "8")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2C2C110", Offset = "0x2C28110", VA = "0x2C2C110", Slot = "9")]
		public void AddChild(Asn1Node xdata)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2C2C140", Offset = "0x2C28140", VA = "0x2C2C140")]
		private Asn1Node GetLastChild()
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2C2BF18", Offset = "0x2C27F18", VA = "0x2C2BF18", Slot = "11")]
		public Asn1Node GetChildNode(int index)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2C2C650", Offset = "0x2C28650", VA = "0x2C2C650", Slot = "14")]
		public string GetText(Asn1Node startNode, int lineLen)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2C2D7AC", Offset = "0x2C297AC", VA = "0x2C2D7AC", Slot = "15")]
		public string GetDataStr(bool pureHexMode)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2C2C0BC", Offset = "0x2C280BC", VA = "0x2C2C0BC")]
		protected void RecalculateTreePar()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2C2DCB4", Offset = "0x2C29CB4", VA = "0x2C2DCB4")]
		protected static long ResetBranchDataLength(Asn1Node node)
		{
			return default(long);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2C2DEA4", Offset = "0x2C29EA4", VA = "0x2C2DEA4")]
		protected static void ResetDataLengthFieldWidth(Asn1Node node)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2C2DD80", Offset = "0x2C29D80", VA = "0x2C2DD80")]
		protected void ResetChildNodePar(Asn1Node xNode, long subOffset)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2C2D694", Offset = "0x2C29694", VA = "0x2C2D694")]
		protected string GetListStr(Asn1Node startNode, int lineLen)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2C2B38C", Offset = "0x2C2738C", VA = "0x2C2B38C")]
		protected string GetIndentStr(Asn1Node startNode)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2C2DF60", Offset = "0x2C29F60", VA = "0x2C2DF60")]
		protected bool GeneralDecode(Stream xdata)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2C2E144", Offset = "0x2C2A144", VA = "0x2C2E144")]
		private bool AreTagsOk()
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2C2E1D0", Offset = "0x2C2A1D0", VA = "0x2C2E1D0")]
		private bool GeneralDecodeKnownLengthWithChecks(Stream xdata, long start, long nodeMaxLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2C2E20C", Offset = "0x2C2A20C", VA = "0x2C2E20C")]
		private bool IsGeneralStreamLengthOk(Stream xdata, long start, long nodeMaxLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2C2E278", Offset = "0x2C2A278", VA = "0x2C2E278")]
		private bool GeneralDecodeKnownLength(Stream xdata)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2C2E2F8", Offset = "0x2C2A2F8", VA = "0x2C2E2F8")]
		private void ReadStreamDataDefiniteLength(Stream xdata, int length)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2C2E174", Offset = "0x2C2A174", VA = "0x2C2E174")]
		private bool GeneralDecodeIndefiniteLength(Stream xdata, long nodeMaxLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2C2E37C", Offset = "0x2C2A37C", VA = "0x2C2E37C")]
		private bool ReadStreamDataIndefiniteLength(Stream xdata, long nodeMaxLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2C2E3F4", Offset = "0x2C2A3F4", VA = "0x2C2E3F4")]
		private long MeasureContentLength(Stream xdata)
		{
			return default(long);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2C2E488", Offset = "0x2C2A488", VA = "0x2C2E488")]
		private void ReadMeasuredLengthDataFromStart(Stream xdata, long startPosition, long length)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2C2E538", Offset = "0x2C2A538", VA = "0x2C2E538")]
		protected bool ListDecode(Stream xdata)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2C2E81C", Offset = "0x2C2A81C", VA = "0x2C2E81C")]
		private bool ListDecodeKnownLengthWithChecks(Stream xdata, long start, long childNodeMaxLen)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2C2E838", Offset = "0x2C2A838", VA = "0x2C2E838")]
		private bool IsListStreamLengthOk(Stream xdata, long childNodeMaxLen)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2C2E84C", Offset = "0x2C2A84C", VA = "0x2C2E84C")]
		private bool ListDecodeKnownLength(Stream xdata, long start)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2C2E904", Offset = "0x2C2A904", VA = "0x2C2E904")]
		private long CalculateListEncodeFieldBytesAndOffset(Stream xdata, long start)
		{
			return default(long);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2C2E950", Offset = "0x2C2A950", VA = "0x2C2E950")]
		private bool HandleBitStringTag(Stream xdata, ref long offset)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2C2E9BC", Offset = "0x2C2A9BC", VA = "0x2C2E9BC")]
		private bool ListDecodeKnownLengthInternal(Stream xdata, long offset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2C2E9E8", Offset = "0x2C2A9E8", VA = "0x2C2E9E8")]
		private Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(Stream xdata)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2C2EB04", Offset = "0x2C2AB04", VA = "0x2C2EB04")]
		private bool ListDecodeChildNodesWithKnownLength(Stream secData, long offset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2C2EB80", Offset = "0x2C2AB80", VA = "0x2C2EB80")]
		private bool CreateAndAddChildNode(Stream secData, ref long offset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2C2E778", Offset = "0x2C2A778", VA = "0x2C2E778")]
		private bool ListDecodeIndefiniteLength(Stream xdata, long start, long childNodeMaxLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2C2EC60", Offset = "0x2C2AC60", VA = "0x2C2EC60")]
		private bool ListDecodeIndefiniteLengthInternal(Stream xdata, long offset, long childNodeMaxLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2C2ECDC", Offset = "0x2C2ACDC", VA = "0x2C2ECDC")]
		private bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(Stream xdata, ref long offset, long childNodeMaxLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2C2ED68", Offset = "0x2C2AD68", VA = "0x2C2ED68")]
		private Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(Stream xdata)
		{
			return default(Asn1EndOfIndefiniteLengthNodeType);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2C2EDDC", Offset = "0x2C2ADDC", VA = "0x2C2EDDC")]
		private bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(Stream xdata, ref long offset, long childNodeMaxLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2C2BBC0", Offset = "0x2C27BC0", VA = "0x2C2BBC0")]
		protected bool InternalLoadData(Stream xdata)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000004")]
	internal class Asn1Parser
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		private byte[] rawData;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		private Asn1Node rootNode;

		[Token(Token = "0x1700000B")]
		public Asn1Node RootNode
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2C2F020", Offset = "0x2C2B020", VA = "0x2C2F020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2C2EE9C", Offset = "0x2C2AE9C", VA = "0x2C2EE9C")]
		public Asn1Parser()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2C2EEF8", Offset = "0x2C2AEF8", VA = "0x2C2EEF8")]
		public void LoadData(Stream stream)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2C2F028", Offset = "0x2C2B028", VA = "0x2C2F028")]
		public static string GetNodeTextHeader(int lineLen)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2C2F15C", Offset = "0x2C2B15C", VA = "0x2C2F15C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2C2F168", Offset = "0x2C2B168", VA = "0x2C2F168")]
		public static string GetNodeText(Asn1Node node, int lineLen)
		{
			return null;
		}
	}
	[Token(Token = "0x2000005")]
	internal class Asn1Util
	{
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x0")]
		private static char[] hexDigits;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2C2D98C", Offset = "0x2C2998C", VA = "0x2C2D98C")]
		public static string FormatString(string inStr, int lineLen, int groupLen)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2C2BA04", Offset = "0x2C27A04", VA = "0x2C2BA04")]
		public static string GenStr(int len, char xch)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2C2D63C", Offset = "0x2C2963C", VA = "0x2C2D63C")]
		public static long BytesToLong(byte[] bytes)
		{
			return default(long);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2C2D554", Offset = "0x2C29554", VA = "0x2C2D554")]
		public static string BytesToString(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2C2B42C", Offset = "0x2C2742C", VA = "0x2C2B42C")]
		public static string ToHexString(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2C2F1B4", Offset = "0x2C2B1B4", VA = "0x2C2F1B4")]
		public static int BytePrecision(ulong value)
		{
			return default(int);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2C2BDE8", Offset = "0x2C27DE8", VA = "0x2C2BDE8")]
		public static int DERLengthEncode(Stream xdata, ulong length)
		{
			return default(int);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2C2E098", Offset = "0x2C2A098", VA = "0x2C2E098")]
		public static long DerLengthDecode(Stream bt, ref bool isIndefiniteLength)
		{
			return default(long);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2C2C244", Offset = "0x2C28244", VA = "0x2C2C244")]
		public static string GetTagName(byte tag)
		{
			return null;
		}
	}
	[Token(Token = "0x2000006")]
	internal class Oid
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		private static StringDictionary oidDictionary;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2C2D4A8", Offset = "0x2C294A8", VA = "0x2C2D4A8")]
		public string GetOidName(string inOidStr)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2C2F274", Offset = "0x2C2B274", VA = "0x2C2F274")]
		public string Decode(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2C2F328", Offset = "0x2C2B328", VA = "0x2C2F328", Slot = "4")]
		public virtual string Decode(Stream bt)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2C2D4A0", Offset = "0x2C294A0", VA = "0x2C2D4A0")]
		public Oid()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2C2F584", Offset = "0x2C2B584", VA = "0x2C2F584")]
		protected int DecodeValue(Stream bt, ref ulong v)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000007")]
	internal class RelativeOid : Oid
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2C2D54C", Offset = "0x2C2954C", VA = "0x2C2D54C")]
		public RelativeOid()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2C2F5E0", Offset = "0x2C2B5E0", VA = "0x2C2F5E0", Slot = "4")]
		public override string Decode(Stream bt)
		{
			return null;
		}
	}
}
namespace UnityEngine.Purchasing.Security
{
	[Token(Token = "0x2000008")]
	public class AppleReceiptParser
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, object> _mostRecentReceiptData;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2C2F7E0", Offset = "0x2C2B7E0", VA = "0x2C2F7E0")]
		public AppleReceipt Parse(byte[] receiptData)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2C2F7F4", Offset = "0x2C2B7F4", VA = "0x2C2F7F4")]
		internal AppleReceipt Parse(byte[] receiptData, out PKCS7 receipt)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2C2FE1C", Offset = "0x2C2BE1C", VA = "0x2C2FE1C")]
		private static CultureInfo PushInvariantCultureOnThread()
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2C3035C", Offset = "0x2C2C35C", VA = "0x2C3035C")]
		private static void PopCultureOffThread(CultureInfo originalCulture)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2C2FEE0", Offset = "0x2C2BEE0", VA = "0x2C2FEE0")]
		private AppleReceipt ParseReceipt(Asn1Node data)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2C3038C", Offset = "0x2C2C38C", VA = "0x2C3038C")]
		private Asn1Node GetSetNode(Asn1Node data)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2C303E8", Offset = "0x2C2C3E8", VA = "0x2C303E8")]
		private AppleInAppPurchaseReceipt ParseInAppReceipt(Asn1Node inApp)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2C3082C", Offset = "0x2C2C82C", VA = "0x2C3082C")]
		private static DateTime TryParseDateTimeNode(Asn1Node node)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000058")]
		public static bool ArrayEquals<T>(T[] a, T[] b) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2C30908", Offset = "0x2C2C908", VA = "0x2C30908")]
		public AppleReceiptParser()
		{
		}
	}
	[Token(Token = "0x2000009")]
	internal class DistinguishedName
	{
		[Token(Token = "0x1700000C")]
		public string Country
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2C3099C", Offset = "0x2C2C99C", VA = "0x2C3099C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2C309A4", Offset = "0x2C2C9A4", VA = "0x2C309A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public string Organization
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2C309AC", Offset = "0x2C2C9AC", VA = "0x2C309AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2C309B4", Offset = "0x2C2C9B4", VA = "0x2C309B4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public string OrganizationalUnit
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x2C309BC", Offset = "0x2C2C9BC", VA = "0x2C309BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x2C309C4", Offset = "0x2C2C9C4", VA = "0x2C309C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public string Dnq
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x2C309CC", Offset = "0x2C2C9CC", VA = "0x2C309CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x2C309D4", Offset = "0x2C2C9D4", VA = "0x2C309D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public string State
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x2C309DC", Offset = "0x2C2C9DC", VA = "0x2C309DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x2C309E4", Offset = "0x2C2C9E4", VA = "0x2C309E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public string CommonName
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x2C309EC", Offset = "0x2C2C9EC", VA = "0x2C309EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x2C309F4", Offset = "0x2C2C9F4", VA = "0x2C309F4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public string SerialNumber
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x2C309FC", Offset = "0x2C2C9FC", VA = "0x2C309FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2C30A04", Offset = "0x2C2CA04", VA = "0x2C30A04")]
		public DistinguishedName(Asn1Node n)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2C30FA4", Offset = "0x2C2CFA4", VA = "0x2C30FA4")]
		public bool Equals(DistinguishedName n2)
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2C31048", Offset = "0x2C2D048", VA = "0x2C31048", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200000A")]
	internal class X509Cert
	{
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x48")]
		private Asn1Node TbsCertificate;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x58")]
		public byte[] rawTBSCertificate;

		[Token(Token = "0x17000013")]
		private string SerialNumber
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x2C31174", Offset = "0x2C2D174", VA = "0x2C31174")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		private DateTime ValidAfter
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x2C3117C", Offset = "0x2C2D17C", VA = "0x2C3117C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		private DateTime ValidBefore
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2C31184", Offset = "0x2C2D184", VA = "0x2C31184")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		private RSAKey PubKey
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x2C3118C", Offset = "0x2C2D18C", VA = "0x2C3118C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		private bool SelfSigned
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2C31194", Offset = "0x2C2D194", VA = "0x2C31194")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public DistinguishedName Subject
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2C3119C", Offset = "0x2C2D19C", VA = "0x2C3119C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2C311A4", Offset = "0x2C2D1A4", VA = "0x2C311A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public DistinguishedName Issuer
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2C311AC", Offset = "0x2C2D1AC", VA = "0x2C311AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2C311B4", Offset = "0x2C2D1B4", VA = "0x2C311B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		private Asn1Node Signature
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2C311BC", Offset = "0x2C2D1BC", VA = "0x2C311BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2C311C4", Offset = "0x2C2D1C4", VA = "0x2C311C4")]
		public X509Cert(Asn1Node n)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2C311F0", Offset = "0x2C2D1F0", VA = "0x2C311F0")]
		private void ParseNode(Asn1Node root)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2C314F8", Offset = "0x2C2D4F8", VA = "0x2C314F8")]
		private DateTime ParseTime(Asn1Node n)
		{
			return default(DateTime);
		}
	}
	[Token(Token = "0x200000B")]
	public class InvalidTimeFormat : IAPSecurityException
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2C31758", Offset = "0x2C2D758", VA = "0x2C31758")]
		public InvalidTimeFormat()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class InvalidX509Data : IAPSecurityException
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2C30F20", Offset = "0x2C2CF20", VA = "0x2C30F20")]
		public InvalidX509Data()
		{
		}
	}
	[Token(Token = "0x200000D")]
	internal class PKCS7
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x10")]
		private Asn1Node root;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x30")]
		private bool validStructure;

		[Token(Token = "0x1700001B")]
		public Asn1Node data
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x2C31760", Offset = "0x2C2D760", VA = "0x2C31760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x2C31768", Offset = "0x2C2D768", VA = "0x2C31768")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public List<SignerInfo> sinfos
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x2C31770", Offset = "0x2C2D770", VA = "0x2C31770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x2C31778", Offset = "0x2C2D778", VA = "0x2C31778")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public List<X509Cert> certChain
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x2C31780", Offset = "0x2C2D780", VA = "0x2C31780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2C31788", Offset = "0x2C2D788", VA = "0x2C31788")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2C2FEB4", Offset = "0x2C2BEB4", VA = "0x2C2FEB4")]
		public PKCS7(Asn1Node node)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2C31790", Offset = "0x2C2D790", VA = "0x2C31790")]
		private void CheckStructure()
		{
		}
	}
	[Token(Token = "0x200000E")]
	internal class SignerInfo
	{
		[Token(Token = "0x1700001E")]
		public int Version
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2C31E78", Offset = "0x2C2DE78", VA = "0x2C31E78")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2C31E80", Offset = "0x2C2DE80", VA = "0x2C31E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		private string IssuerSerialNumber
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2C31E88", Offset = "0x2C2DE88", VA = "0x2C31E88")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		private byte[] EncryptedDigest
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x2C31E90", Offset = "0x2C2DE90", VA = "0x2C31E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2C31C9C", Offset = "0x2C2DC9C", VA = "0x2C31C9C")]
		public SignerInfo(Asn1Node n)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class InvalidPKCS7Data : IAPSecurityException
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2C30384", Offset = "0x2C2C384", VA = "0x2C30384")]
		public InvalidPKCS7Data()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class UnsupportedSignerInfoVersion : IAPSecurityException
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2C31E98", Offset = "0x2C2DE98", VA = "0x2C31E98")]
		public UnsupportedSignerInfoVersion()
		{
		}
	}
	[Token(Token = "0x2000011")]
	internal class RSAKey
	{
		[Token(Token = "0x17000021")]
		private RSACryptoServiceProvider rsa
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2C31EA0", Offset = "0x2C2DEA0", VA = "0x2C31EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2C31724", Offset = "0x2C2D724", VA = "0x2C31724")]
		public RSAKey(Asn1Node n)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2C31EA8", Offset = "0x2C2DEA8", VA = "0x2C31EA8")]
		private RSACryptoServiceProvider ParseNode(Asn1Node n)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2C32144", Offset = "0x2C2E144", VA = "0x2C32144")]
		private string ToXML(string modulus, string exponent)
		{
			return null;
		}
	}
	[Token(Token = "0x2000012")]
	public class InvalidRSAData : IAPSecurityException
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2C32230", Offset = "0x2C2E230", VA = "0x2C32230")]
		public InvalidRSAData()
		{
		}
	}
}
