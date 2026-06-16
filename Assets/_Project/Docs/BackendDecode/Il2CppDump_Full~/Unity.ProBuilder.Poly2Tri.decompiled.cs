using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.ProBuilder.Poly2Tri;

[Token(Token = "0x2000002")]
internal class Polygon : Triangulatable
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	protected List<TriangulationPoint> _points;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	protected List<TriangulationPoint> _steinerPoints;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	protected List<Polygon> _holes;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	protected List<DelaunayTriangle> _triangles;

	[Token(Token = "0x17000001")]
	public TriangulationMode TriangulationMode
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2B71C54", Offset = "0x2B6DC54", VA = "0x2B71C54", Slot = "8")]
		get
		{
			return default(TriangulationMode);
		}
	}

	[Token(Token = "0x17000002")]
	public IList<DelaunayTriangle> Triangles
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2B71D48", Offset = "0x2B6DD48", VA = "0x2B71D48", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2B7181C", Offset = "0x2B6D81C", VA = "0x2B7181C")]
	public Polygon(IList<PolygonPoint> points)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2B71BCC", Offset = "0x2B6DBCC", VA = "0x2B71BCC")]
	public Polygon(IEnumerable<PolygonPoint> points)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2B71C5C", Offset = "0x2B6DC5C", VA = "0x2B71C5C")]
	public void AddHole(Polygon poly)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2B71D50", Offset = "0x2B6DD50", VA = "0x2B71D50", Slot = "6")]
	public void AddTriangle(DelaunayTriangle t)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2B71DF4", Offset = "0x2B6DDF4", VA = "0x2B71DF4", Slot = "7")]
	public void AddTriangles(IEnumerable<DelaunayTriangle> list)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2B71E4C", Offset = "0x2B6DE4C", VA = "0x2B71E4C", Slot = "4")]
	public void Prepare(TriangulationContext tcx)
	{
	}
}
[Token(Token = "0x2000003")]
internal class PolygonPoint : TriangulationPoint
{
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2B7221C", Offset = "0x2B6E21C", VA = "0x2B7221C")]
	public PolygonPoint(double x, double y, int index = -1)
	{
	}
}
[Token(Token = "0x2000004")]
internal class DelaunayTriangle
{
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x10")]
	public FixedArray3<TriangulationPoint> Points;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x28")]
	public FixedArray3<DelaunayTriangle> Neighbors;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	public FixedBitArray3 EdgeIsConstrained;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x43")]
	public FixedBitArray3 EdgeIsDelaunay;

	[Token(Token = "0x17000003")]
	public bool IsInterior
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2B72294", Offset = "0x2B6E294", VA = "0x2B72294")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2B7229C", Offset = "0x2B6E29C", VA = "0x2B7229C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2B722A4", Offset = "0x2B6E2A4", VA = "0x2B722A4")]
	public DelaunayTriangle(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2B72344", Offset = "0x2B6E344", VA = "0x2B72344")]
	public int IndexOf(TriangulationPoint p)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2B723F0", Offset = "0x2B6E3F0", VA = "0x2B723F0")]
	public int IndexCCWFrom(TriangulationPoint p)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2B72424", Offset = "0x2B6E424", VA = "0x2B72424")]
	public bool Contains(TriangulationPoint p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2B7247C", Offset = "0x2B6E47C", VA = "0x2B7247C")]
	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2B7260C", Offset = "0x2B6E60C", VA = "0x2B7260C")]
	public void MarkNeighbor(DelaunayTriangle t)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2B727B4", Offset = "0x2B6E7B4", VA = "0x2B727B4")]
	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2B72864", Offset = "0x2B6E864", VA = "0x2B72864")]
	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2B72900", Offset = "0x2B6E900", VA = "0x2B72900")]
	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2B7299C", Offset = "0x2B6E99C", VA = "0x2B7299C")]
	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2B72A18", Offset = "0x2B6EA18", VA = "0x2B72A18")]
	public TriangulationPoint PointCCWFrom(TriangulationPoint point)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2B727E0", Offset = "0x2B6E7E0", VA = "0x2B727E0")]
	public TriangulationPoint PointCWFrom(TriangulationPoint point)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2B72A9C", Offset = "0x2B6EA9C", VA = "0x2B72A9C")]
	private void RotateCW()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2B72B64", Offset = "0x2B6EB64", VA = "0x2B72B64")]
	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2B72BF8", Offset = "0x2B6EBF8", VA = "0x2B72BF8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2B72D44", Offset = "0x2B6ED44", VA = "0x2B72D44")]
	public void MarkConstrainedEdge(int index)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2B72DB4", Offset = "0x2B6EDB4", VA = "0x2B72DB4")]
	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2B72540", Offset = "0x2B6E540", VA = "0x2B72540")]
	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2)
	{
		return default(int);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2B72DE4", Offset = "0x2B6EDE4", VA = "0x2B72DE4")]
	public bool GetConstrainedEdgeCCW(TriangulationPoint p)
	{
		return default(bool);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2B72E80", Offset = "0x2B6EE80", VA = "0x2B72E80")]
	public bool GetConstrainedEdgeCW(TriangulationPoint p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2B72EBC", Offset = "0x2B6EEBC", VA = "0x2B72EBC")]
	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2B72F08", Offset = "0x2B6EF08", VA = "0x2B72F08")]
	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2B72F54", Offset = "0x2B6EF54", VA = "0x2B72F54")]
	public bool GetDelaunayEdgeCCW(TriangulationPoint p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2B72F90", Offset = "0x2B6EF90", VA = "0x2B72F90")]
	public bool GetDelaunayEdgeCW(TriangulationPoint p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2B72FCC", Offset = "0x2B6EFCC", VA = "0x2B72FCC")]
	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2B73018", Offset = "0x2B6F018", VA = "0x2B73018")]
	public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce)
	{
	}
}
[Token(Token = "0x2000005")]
internal class AdvancingFront
{
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x10")]
	public AdvancingFrontNode Head;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x18")]
	public AdvancingFrontNode Tail;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x20")]
	protected AdvancingFrontNode Search;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2B73064", Offset = "0x2B6F064", VA = "0x2B73064")]
	public AdvancingFront(AdvancingFrontNode head, AdvancingFrontNode tail)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2B73094", Offset = "0x2B6F094", VA = "0x2B73094")]
	public void AddNode(AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2B73098", Offset = "0x2B6F098", VA = "0x2B73098")]
	public void RemoveNode(AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2B7309C", Offset = "0x2B6F09C", VA = "0x2B7309C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2B73188", Offset = "0x2B6F188", VA = "0x2B73188")]
	private AdvancingFrontNode FindSearchNode(double x)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2B73190", Offset = "0x2B6F190", VA = "0x2B73190")]
	public AdvancingFrontNode LocateNode(TriangulationPoint point)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2B731A4", Offset = "0x2B6F1A4", VA = "0x2B731A4")]
	private AdvancingFrontNode LocateNode(double x)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2B73200", Offset = "0x2B6F200", VA = "0x2B73200")]
	public AdvancingFrontNode LocatePoint(TriangulationPoint point)
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
internal class AdvancingFrontNode
{
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x10")]
	public AdvancingFrontNode Next;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x18")]
	public AdvancingFrontNode Prev;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x20")]
	public double Value;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x28")]
	public TriangulationPoint Point;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x30")]
	public DelaunayTriangle Triangle;

	[Token(Token = "0x17000004")]
	public bool HasNext
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2B73328", Offset = "0x2B6F328", VA = "0x2B73328")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000005")]
	public bool HasPrev
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2B73338", Offset = "0x2B6F338", VA = "0x2B73338")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2B732F0", Offset = "0x2B6F2F0", VA = "0x2B732F0")]
	public AdvancingFrontNode(TriangulationPoint point)
	{
	}
}
[Token(Token = "0x2000007")]
internal static class DTSweep
{
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2B73348", Offset = "0x2B6F348", VA = "0x2B73348")]
	public static void Triangulate(DTSweepContext tcx)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2B735B0", Offset = "0x2B6F5B0", VA = "0x2B735B0")]
	private static void Sweep(DTSweepContext tcx)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2B73868", Offset = "0x2B6F868", VA = "0x2B73868")]
	private static void FinalizationConvexHull(DTSweepContext tcx)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2B73E64", Offset = "0x2B6FE64", VA = "0x2B73E64")]
	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2B737C4", Offset = "0x2B6F7C4", VA = "0x2B737C4")]
	private static void FinalizationPolygon(DTSweepContext tcx)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2B73AF8", Offset = "0x2B6FAF8", VA = "0x2B73AF8")]
	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2B74940", Offset = "0x2B70940", VA = "0x2B74940")]
	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2B73CDC", Offset = "0x2B6FCDC", VA = "0x2B73CDC")]
	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2B74F18", Offset = "0x2B70F18", VA = "0x2B74F18")]
	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2B75334", Offset = "0x2B71334", VA = "0x2B75334")]
	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2B75430", Offset = "0x2B71430", VA = "0x2B75430")]
	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2B75550", Offset = "0x2B71550", VA = "0x2B75550")]
	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2B75120", Offset = "0x2B71120", VA = "0x2B75120")]
	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2B7567C", Offset = "0x2B7167C", VA = "0x2B7567C")]
	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2B75794", Offset = "0x2B71794", VA = "0x2B75794")]
	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2B75888", Offset = "0x2B71888", VA = "0x2B75888")]
	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2B7522C", Offset = "0x2B7122C", VA = "0x2B7522C")]
	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2B74E6C", Offset = "0x2B70E6C", VA = "0x2B74E6C")]
	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq)
	{
		return default(bool);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2B74F44", Offset = "0x2B70F44", VA = "0x2B74F44")]
	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2B759EC", Offset = "0x2B719EC", VA = "0x2B759EC")]
	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2B75ED8", Offset = "0x2B71ED8", VA = "0x2B75ED8")]
	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2B75E34", Offset = "0x2B71E34", VA = "0x2B75E34")]
	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2B76030", Offset = "0x2B72030", VA = "0x2B76030")]
	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2B74AF0", Offset = "0x2B70AF0", VA = "0x2B74AF0")]
	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2B76334", Offset = "0x2B72334", VA = "0x2B76334")]
	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2B764C4", Offset = "0x2B724C4", VA = "0x2B764C4")]
	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2B76638", Offset = "0x2B72638", VA = "0x2B76638")]
	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node)
	{
		return default(bool);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2B761DC", Offset = "0x2B721DC", VA = "0x2B761DC")]
	private static double HoleAngle(AdvancingFrontNode node)
	{
		return default(double);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2B7629C", Offset = "0x2B7229C", VA = "0x2B7629C")]
	private static double BasinAngle(AdvancingFrontNode node)
	{
		return default(double);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2B747A8", Offset = "0x2B707A8", VA = "0x2B747A8")]
	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2B74BD8", Offset = "0x2B70BD8", VA = "0x2B74BD8")]
	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t)
	{
		return default(bool);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2B73FD0", Offset = "0x2B6FFD0", VA = "0x2B73FD0")]
	private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op)
	{
	}
}
[Token(Token = "0x2000008")]
internal class DTSweepBasin
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x10")]
	public AdvancingFrontNode leftNode;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x18")]
	public AdvancingFrontNode bottomNode;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x20")]
	public AdvancingFrontNode rightNode;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x28")]
	public double width;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x30")]
	public bool leftHighest;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2B76774", Offset = "0x2B72774", VA = "0x2B76774")]
	public DTSweepBasin()
	{
	}
}
[Token(Token = "0x2000009")]
internal class DTSweepConstraint : TriangulationConstraint
{
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2B7677C", Offset = "0x2B7277C", VA = "0x2B7677C")]
	public DTSweepConstraint(TriangulationPoint p1, TriangulationPoint p2)
	{
	}
}
[Token(Token = "0x200000A")]
internal class DTSweepContext : TriangulationContext
{
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x40")]
	private readonly float ALPHA;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x48")]
	public AdvancingFront Front;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x60")]
	public DTSweepBasin Basin;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x68")]
	public DTSweepEdgeEvent EdgeEvent;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x70")]
	private DTSweepPointComparator _comparator;

	[Token(Token = "0x17000006")]
	public TriangulationPoint Head
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2B768E0", Offset = "0x2B728E0", VA = "0x2B768E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2B768E8", Offset = "0x2B728E8", VA = "0x2B768E8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public TriangulationPoint Tail
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2B768F0", Offset = "0x2B728F0", VA = "0x2B768F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2B768F8", Offset = "0x2B728F8", VA = "0x2B768F8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public override bool IsDebugEnabled
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2B76AAC", Offset = "0x2B72AAC", VA = "0x2B76AAC", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2B76900", Offset = "0x2B72900", VA = "0x2B76900")]
	public DTSweepContext()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2B7452C", Offset = "0x2B7052C", VA = "0x2B7452C")]
	public void RemoveFromList(DelaunayTriangle triangle)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2B7491C", Offset = "0x2B7091C", VA = "0x2B7491C")]
	public void MeshClean(DelaunayTriangle triangle)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2B76AB4", Offset = "0x2B72AB4", VA = "0x2B76AB4")]
	private void MeshCleanReq(DelaunayTriangle triangle)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2B76BD0", Offset = "0x2B72BD0", VA = "0x2B76BD0", Slot = "6")]
	public override void Clear()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2B74ADC", Offset = "0x2B70ADC", VA = "0x2B74ADC")]
	public void AddNode(AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2B7669C", Offset = "0x2B7269C", VA = "0x2B7669C")]
	public void RemoveNode(AdvancingFrontNode node)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2B74920", Offset = "0x2B70920", VA = "0x2B74920")]
	public AdvancingFrontNode LocateNode(TriangulationPoint point)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2B73394", Offset = "0x2B6F394", VA = "0x2B73394")]
	public void CreateAdvancingFront()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2B74460", Offset = "0x2B70460", VA = "0x2B74460")]
	public void MapTriangleToNodes(DelaunayTriangle t)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2B76CC8", Offset = "0x2B72CC8", VA = "0x2B76CC8", Slot = "4")]
	public override void PrepareTriangulation(Triangulatable t)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2B74584", Offset = "0x2B70584", VA = "0x2B74584")]
	public void FinalizeTriangulation()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2B77050", Offset = "0x2B73050", VA = "0x2B77050", Slot = "5")]
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b)
	{
		return null;
	}
}
[Token(Token = "0x200000B")]
internal class DTSweepDebugContext : TriangulationDebugContext
{
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x18")]
	private DelaunayTriangle _primaryTriangle;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x20")]
	private DelaunayTriangle _secondaryTriangle;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x28")]
	private TriangulationPoint _activePoint;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x30")]
	private AdvancingFrontNode _activeNode;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x38")]
	private DTSweepConstraint _activeConstraint;

	[Token(Token = "0x17000009")]
	public DelaunayTriangle PrimaryTriangle
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2B74E20", Offset = "0x2B70E20", VA = "0x2B74E20")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public DelaunayTriangle SecondaryTriangle
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2B75D70", Offset = "0x2B71D70", VA = "0x2B75D70")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public TriangulationPoint ActivePoint
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2B770B8", Offset = "0x2B730B8", VA = "0x2B770B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public AdvancingFrontNode ActiveNode
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2B74674", Offset = "0x2B70674", VA = "0x2B74674")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public DTSweepConstraint ActiveConstraint
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2B73C90", Offset = "0x2B6FC90", VA = "0x2B73C90")]
		set
		{
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2B77104", Offset = "0x2B73104", VA = "0x2B77104", Slot = "4")]
	public override void Clear()
	{
	}
}
[Token(Token = "0x200000C")]
internal class DTSweepEdgeEvent
{
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x10")]
	public DTSweepConstraint ConstrainedEdge;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x18")]
	public bool Right;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2B769D8", Offset = "0x2B729D8", VA = "0x2B769D8")]
	public DTSweepEdgeEvent()
	{
	}
}
[Token(Token = "0x200000D")]
internal class DTSweepPointComparator : IComparer<TriangulationPoint>
{
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2B77148", Offset = "0x2B73148", VA = "0x2B77148", Slot = "4")]
	public int Compare(TriangulationPoint p1, TriangulationPoint p2)
	{
		return default(int);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2B769E0", Offset = "0x2B729E0", VA = "0x2B769E0")]
	public DTSweepPointComparator()
	{
	}
}
[Token(Token = "0x200000E")]
internal class PointOnEdgeException : NotImplementedException
{
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x90")]
	public readonly TriangulationPoint A;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x98")]
	public readonly TriangulationPoint B;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0xA0")]
	public readonly TriangulationPoint C;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2B759B0", Offset = "0x2B719B0", VA = "0x2B759B0")]
	public PointOnEdgeException(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c)
	{
	}
}
[Token(Token = "0x200000F")]
internal interface Triangulatable
{
	[Token(Token = "0x1700000E")]
	IList<DelaunayTriangle> Triangles
	{
		[Token(Token = "0x6000070")]
		get;
	}

	[Token(Token = "0x1700000F")]
	TriangulationMode TriangulationMode
	{
		[Token(Token = "0x6000073")]
		get;
	}

	[Token(Token = "0x600006F")]
	void Prepare(TriangulationContext tcx);

	[Token(Token = "0x6000071")]
	void AddTriangle(DelaunayTriangle t);

	[Token(Token = "0x6000072")]
	void AddTriangles(IEnumerable<DelaunayTriangle> list);
}
[Token(Token = "0x2000010")]
internal enum Orientation
{
	[Token(Token = "0x4000029")]
	CW,
	[Token(Token = "0x400002A")]
	CCW,
	[Token(Token = "0x400002B")]
	Collinear
}
[Token(Token = "0x2000011")]
internal class PointSet : Triangulatable
{
	[Token(Token = "0x17000010")]
	public IList<TriangulationPoint> Points
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2B7719C", Offset = "0x2B7319C", VA = "0x2B7719C", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2B771A4", Offset = "0x2B731A4", VA = "0x2B771A4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public IList<DelaunayTriangle> Triangles
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2B771AC", Offset = "0x2B731AC", VA = "0x2B771AC", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2B771B4", Offset = "0x2B731B4", VA = "0x2B771B4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public virtual TriangulationMode TriangulationMode
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2B77244", Offset = "0x2B73244", VA = "0x2B77244", Slot = "10")]
		get
		{
			return default(TriangulationMode);
		}
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2B771BC", Offset = "0x2B731BC", VA = "0x2B771BC")]
	public PointSet(List<TriangulationPoint> points)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2B7724C", Offset = "0x2B7324C", VA = "0x2B7724C", Slot = "6")]
	public void AddTriangle(DelaunayTriangle t)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2B772F8", Offset = "0x2B732F8", VA = "0x2B772F8", Slot = "7")]
	public void AddTriangles(IEnumerable<DelaunayTriangle> list)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2B77618", Offset = "0x2B73618", VA = "0x2B77618", Slot = "11")]
	public virtual void Prepare(TriangulationContext tcx)
	{
	}
}
[Token(Token = "0x2000012")]
internal class TriangulationConstraint
{
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x10")]
	public TriangulationPoint P;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x18")]
	public TriangulationPoint Q;

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2B767EC", Offset = "0x2B727EC", VA = "0x2B767EC")]
	public TriangulationConstraint()
	{
	}
}
[Token(Token = "0x2000013")]
internal abstract class TriangulationContext
{
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<DelaunayTriangle> Triangles;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x20")]
	public readonly List<TriangulationPoint> Points;

	[Token(Token = "0x17000013")]
	public TriangulationDebugContext DebugContext
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2B777BC", Offset = "0x2B737BC", VA = "0x2B777BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public TriangulationMode TriangulationMode
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2B777C4", Offset = "0x2B737C4", VA = "0x2B777C4")]
		[CompilerGenerated]
		get
		{
			return default(TriangulationMode);
		}
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2B777CC", Offset = "0x2B737CC", VA = "0x2B777CC")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public Triangulatable Triangulatable
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2B777D4", Offset = "0x2B737D4", VA = "0x2B777D4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2B777DC", Offset = "0x2B737DC", VA = "0x2B777DC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public int StepCount
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2B777E4", Offset = "0x2B737E4", VA = "0x2B777E4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2B777EC", Offset = "0x2B737EC", VA = "0x2B777EC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public virtual bool IsDebugEnabled
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2B777F4", Offset = "0x2B737F4", VA = "0x2B777F4", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public DTSweepDebugContext DTDebugContext
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2B73C14", Offset = "0x2B6FC14", VA = "0x2B73C14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2B73AE8", Offset = "0x2B6FAE8", VA = "0x2B73AE8")]
	public void Done()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2B76F48", Offset = "0x2B72F48", VA = "0x2B76F48", Slot = "4")]
	public virtual void PrepareTriangulation(Triangulatable t)
	{
	}

	[Token(Token = "0x6000087")]
	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b);

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2B73E60", Offset = "0x2B6FE60", VA = "0x2B73E60")]
	public void Update(string message)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2B76C48", Offset = "0x2B72C48", VA = "0x2B76C48", Slot = "6")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2B769E8", Offset = "0x2B729E8", VA = "0x2B769E8")]
	protected TriangulationContext()
	{
	}
}
[Token(Token = "0x2000014")]
internal abstract class TriangulationDebugContext
{
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x10")]
	protected TriangulationContext _tcx;

	[Token(Token = "0x600008D")]
	public abstract void Clear();
}
[Token(Token = "0x2000015")]
internal enum TriangulationMode
{
	[Token(Token = "0x4000039")]
	Unconstrained,
	[Token(Token = "0x400003A")]
	Constrained,
	[Token(Token = "0x400003B")]
	Polygon
}
[Token(Token = "0x2000016")]
internal class TriangulationPoint
{
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x18")]
	public double X;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x20")]
	public double Y;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x28")]
	public int Index;

	[Token(Token = "0x17000019")]
	public List<DTSweepConstraint> Edges
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2B777FC", Offset = "0x2B737FC", VA = "0x2B777FC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2B77804", Offset = "0x2B73804", VA = "0x2B77804")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public bool HasEdges
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2B73C04", Offset = "0x2B6FC04", VA = "0x2B73C04")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2B72258", Offset = "0x2B6E258", VA = "0x2B72258")]
	public TriangulationPoint(double x, double y, int index = -1)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2B7780C", Offset = "0x2B7380C", VA = "0x2B7780C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2B767F4", Offset = "0x2B727F4", VA = "0x2B767F4")]
	public void AddEdge(DTSweepConstraint e)
	{
	}
}
[Token(Token = "0x2000017")]
internal class TriangulationUtil
{
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x0")]
	public static double EPSILON;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2B766B0", Offset = "0x2B726B0", VA = "0x2B766B0")]
	public static bool SmartIncircle(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd)
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2B75DBC", Offset = "0x2B71DBC", VA = "0x2B75DBC")]
	public static bool InScanArea(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd)
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2B746C0", Offset = "0x2B706C0", VA = "0x2B746C0")]
	public static Orientation Orient2d(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc)
	{
		return default(Orientation);
	}
}
[Token(Token = "0x2000018")]
internal struct FixedArray3<T> : IEnumerable<T>, IEnumerable where T : class
{
	[Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class <Enumerate>d__10 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x0")]
		private T <>2__current;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x0")]
		private int <>l__initialThreadId;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x0")]
		public FixedArray3<T> <>4__this;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		public FixedArray3<T> <>3__<>4__this;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x0")]
		private int <i>5__2;

		[Token(Token = "0x1700001C")]
		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x60000A3")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A5")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A0")]
		[DebuggerHidden]
		public <Enumerate>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60000A1")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A2")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60000A6")]
		[DebuggerHidden]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x0")]
	public T _0;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x0")]
	public T _1;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x0")]
	public T _2;

	[Token(Token = "0x1700001B")]
	public T this[int index]
	{
		[Token(Token = "0x6000098")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000099")]
		set
		{
		}
	}

	[Token(Token = "0x600009A")]
	public bool Contains(T value)
	{
		return default(bool);
	}

	[Token(Token = "0x600009B")]
	public int IndexOf(T value)
	{
		return default(int);
	}

	[Token(Token = "0x600009C")]
	public void Clear()
	{
	}

	[Token(Token = "0x600009D")]
	[IteratorStateMachine(typeof(FixedArray3<>.<Enumerate>d__10))]
	private IEnumerable<T> Enumerate()
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
internal struct FixedBitArray3 : IEnumerable<bool>, IEnumerable
{
	[Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class <Enumerate>d__10 : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x14")]
		private bool <>2__current;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x18")]
		private int <>l__initialThreadId;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x1C")]
		public FixedBitArray3 <>4__this;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x1F")]
		public FixedBitArray3 <>3__<>4__this;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x24")]
		private int <i>5__2;

		[Token(Token = "0x1700001F")]
		private bool System.Collections.Generic.IEnumerator<System.Boolean>.Current
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x2B77B44", Offset = "0x2B73B44", VA = "0x2B77B44", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2B77B84", Offset = "0x2B73B84", VA = "0x2B77B84", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2B779EC", Offset = "0x2B739EC", VA = "0x2B779EC")]
		[DebuggerHidden]
		public <Enumerate>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2B77ACC", Offset = "0x2B73ACC", VA = "0x2B77ACC", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2B77AD0", Offset = "0x2B73AD0", VA = "0x2B77AD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2B77B4C", Offset = "0x2B73B4C", VA = "0x2B77B4C", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2B77BE0", Offset = "0x2B73BE0", VA = "0x2B77BE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<bool> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2B77C84", Offset = "0x2B73C84", VA = "0x2B77C84", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x0")]
	public bool _0;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x1")]
	public bool _1;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x2")]
	public bool _2;

	[Token(Token = "0x1700001E")]
	public bool this[int index]
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2B72E20", Offset = "0x2B6EE20", VA = "0x2B72E20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2B72D50", Offset = "0x2B6ED50", VA = "0x2B72D50")]
		set
		{
		}
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2B761D0", Offset = "0x2B721D0", VA = "0x2B761D0")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x2B7796C", Offset = "0x2B7396C", VA = "0x2B7796C")]
	[IteratorStateMachine(typeof(<Enumerate>d__10))]
	private IEnumerable<bool> Enumerate()
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2B77A20", Offset = "0x2B73A20", VA = "0x2B77A20", Slot = "4")]
	public IEnumerator<bool> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2B77AC8", Offset = "0x2B73AC8", VA = "0x2B77AC8", Slot = "5")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}
}
