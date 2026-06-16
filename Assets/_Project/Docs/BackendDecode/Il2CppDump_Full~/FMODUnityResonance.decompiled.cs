using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using FMOD;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[CompilerGenerated]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x17E6280", Offset = "0x17E2280", VA = "0x17E6280")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x17E633C", Offset = "0x17E233C", VA = "0x17E633C")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace FMODUnityResonance;

[Token(Token = "0x2000004")]
public static class FmodResonanceAudio
{
	[Token(Token = "0x2000005")]
	private struct RoomProperties
	{
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x0")]
		public float PositionX;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x4")]
		public float PositionY;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x8")]
		public float PositionZ;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0xC")]
		public float RotationX;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x10")]
		public float RotationY;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x14")]
		public float RotationZ;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		public float RotationW;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x1C")]
		public float DimensionsX;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x20")]
		public float DimensionsY;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x24")]
		public float DimensionsZ;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		public FmodResonanceAudioRoom.SurfaceMaterial MaterialLeft;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x2C")]
		public FmodResonanceAudioRoom.SurfaceMaterial MaterialRight;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		public FmodResonanceAudioRoom.SurfaceMaterial MaterialBottom;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x34")]
		public FmodResonanceAudioRoom.SurfaceMaterial MaterialTop;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x38")]
		public FmodResonanceAudioRoom.SurfaceMaterial MaterialFront;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x3C")]
		public FmodResonanceAudioRoom.SurfaceMaterial MaterialBack;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x40")]
		public float ReflectionScalar;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x44")]
		public float ReverbGain;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x48")]
		public float ReverbTime;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x4C")]
		public float ReverbBrightness;
	}

	[Token(Token = "0x4000006")]
	public const float MaxGainDb = 24f;

	[Token(Token = "0x4000007")]
	public const float MinGainDb = -24f;

	[Token(Token = "0x4000008")]
	public const float MaxReverbBrightness = 1f;

	[Token(Token = "0x4000009")]
	public const float MinReverbBrightness = -1f;

	[Token(Token = "0x400000A")]
	public const float MaxReverbTime = 3f;

	[Token(Token = "0x400000B")]
	public const float MaxReflectivity = 2f;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Matrix4x4 flipZ;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x40")]
	private static readonly string listenerPluginName;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x48")]
	private static readonly int roomPropertiesSize;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly int roomPropertiesIndex;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x50")]
	private static Bounds bounds;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x68")]
	private static List<FmodResonanceAudioRoom> enabledRooms;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x70")]
	private static VECTOR listenerPositionFmod;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x80")]
	private static DSP listenerPlugin;

	[Token(Token = "0x17000001")]
	private static DSP ListenerPlugin
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x17E67A4", Offset = "0x17E27A4", VA = "0x17E67A4")]
		get
		{
			return default(DSP);
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x17E6344", Offset = "0x17E2344", VA = "0x17E6344")]
	public static void UpdateAudioRoom(FmodResonanceAudioRoom room, bool roomEnabled)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x17E6914", Offset = "0x17E2914", VA = "0x17E6914")]
	public static bool IsListenerInsideRoom(FmodResonanceAudioRoom room)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x17E6E78", Offset = "0x17E2E78", VA = "0x17E6E78")]
	private static float ConvertAmplitudeFromDb(float db)
	{
		return default(float);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x17E6E8C", Offset = "0x17E2E8C", VA = "0x17E6E8C")]
	private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x17E6848", Offset = "0x17E2848", VA = "0x17E6848")]
	private static byte[] GetBytes(IntPtr ptr, int length)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x17E6624", Offset = "0x17E2624", VA = "0x17E6624")]
	private static RoomProperties GetRoomProperties(FmodResonanceAudioRoom room)
	{
		return default(RoomProperties);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x17E6AF8", Offset = "0x17E2AF8", VA = "0x17E6AF8")]
	private static DSP Initialize()
	{
		return default(DSP);
	}
}
[Token(Token = "0x2000006")]
[AddComponentMenu("ResonanceAudio/FmodResonanceAudioRoom")]
public class FmodResonanceAudioRoom : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	public enum SurfaceMaterial
	{
		[Token(Token = "0x4000034")]
		Transparent,
		[Token(Token = "0x4000035")]
		AcousticCeilingTiles,
		[Token(Token = "0x4000036")]
		BrickBare,
		[Token(Token = "0x4000037")]
		BrickPainted,
		[Token(Token = "0x4000038")]
		ConcreteBlockCoarse,
		[Token(Token = "0x4000039")]
		ConcreteBlockPainted,
		[Token(Token = "0x400003A")]
		CurtainHeavy,
		[Token(Token = "0x400003B")]
		FiberglassInsulation,
		[Token(Token = "0x400003C")]
		GlassThin,
		[Token(Token = "0x400003D")]
		GlassThick,
		[Token(Token = "0x400003E")]
		Grass,
		[Token(Token = "0x400003F")]
		LinoleumOnConcrete,
		[Token(Token = "0x4000040")]
		Marble,
		[Token(Token = "0x4000041")]
		Metal,
		[Token(Token = "0x4000042")]
		ParquetOnConcrete,
		[Token(Token = "0x4000043")]
		PlasterRough,
		[Token(Token = "0x4000044")]
		PlasterSmooth,
		[Token(Token = "0x4000045")]
		PlywoodPanel,
		[Token(Token = "0x4000046")]
		PolishedConcreteOrTile,
		[Token(Token = "0x4000047")]
		Sheetrock,
		[Token(Token = "0x4000048")]
		WaterOrIceSurface,
		[Token(Token = "0x4000049")]
		WoodCeiling,
		[Token(Token = "0x400004A")]
		WoodPanel
	}

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("leftWall")]
	public SurfaceMaterial LeftWall;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("rightWall")]
	public SurfaceMaterial RightWall;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("floor")]
	public SurfaceMaterial Floor;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x2C")]
	[FormerlySerializedAs("ceiling")]
	public SurfaceMaterial Ceiling;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("backWall")]
	public SurfaceMaterial BackWall;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("frontWall")]
	public SurfaceMaterial FrontWall;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("reflectivity")]
	public float Reflectivity;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("reverbGainDb")]
	public float ReverbGainDb;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("reverbBrightness")]
	public float ReverbBrightness;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x44")]
	[FormerlySerializedAs("reverbTime")]
	public float ReverbTime;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("size")]
	public Vector3 Size;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x17E7244", Offset = "0x17E3244", VA = "0x17E7244")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x17E72A8", Offset = "0x17E32A8", VA = "0x17E72A8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x17E7300", Offset = "0x17E3300", VA = "0x17E7300")]
	private void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x17E7364", Offset = "0x17E3364", VA = "0x17E7364")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x17E7428", Offset = "0x17E3428", VA = "0x17E7428")]
	public FmodResonanceAudioRoom()
	{
	}
}
