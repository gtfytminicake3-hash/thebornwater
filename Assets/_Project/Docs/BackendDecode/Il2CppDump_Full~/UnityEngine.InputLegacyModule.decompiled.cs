using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine
{
	[Token(Token = "0x2000002")]
	public enum TouchPhase
	{
		[Token(Token = "0x4000002")]
		Began,
		[Token(Token = "0x4000003")]
		Moved,
		[Token(Token = "0x4000004")]
		Stationary,
		[Token(Token = "0x4000005")]
		Ended,
		[Token(Token = "0x4000006")]
		Canceled
	}
	[Token(Token = "0x2000003")]
	public enum IMECompositionMode
	{
		[Token(Token = "0x4000008")]
		Auto,
		[Token(Token = "0x4000009")]
		On,
		[Token(Token = "0x400000A")]
		Off
	}
	[Token(Token = "0x2000004")]
	public enum TouchType
	{
		[Token(Token = "0x400000C")]
		Direct,
		[Token(Token = "0x400000D")]
		Indirect,
		[Token(Token = "0x400000E")]
		Stylus
	}
	[Token(Token = "0x2000005")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Input/InputBindings.h")]
	public struct Touch
	{
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x0")]
		private int m_FingerId;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x4")]
		private Vector2 m_Position;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0xC")]
		private Vector2 m_RawPosition;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 m_PositionDelta;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x1C")]
		private float m_TimeDelta;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		private int m_TapCount;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x24")]
		private TouchPhase m_Phase;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		private TouchType m_Type;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x2C")]
		private float m_Pressure;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x30")]
		private float m_maximumPossiblePressure;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x34")]
		private float m_Radius;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x38")]
		private float m_RadiusVariance;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x3C")]
		private float m_AltitudeAngle;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x40")]
		private float m_AzimuthAngle;

		[Token(Token = "0x17000001")]
		public int fingerId
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2E798DC", Offset = "0x2E758DC", VA = "0x2E798DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000002")]
		public Vector2 position
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2E798E4", Offset = "0x2E758E4", VA = "0x2E798E4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2E798EC", Offset = "0x2E758EC", VA = "0x2E798EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public Vector2 rawPosition
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2E798F4", Offset = "0x2E758F4", VA = "0x2E798F4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2E798FC", Offset = "0x2E758FC", VA = "0x2E798FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public Vector2 deltaPosition
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2E79904", Offset = "0x2E75904", VA = "0x2E79904")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2E7990C", Offset = "0x2E7590C", VA = "0x2E7990C")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float deltaTime
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2E79914", Offset = "0x2E75914", VA = "0x2E79914")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000006")]
		public int tapCount
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2E7991C", Offset = "0x2E7591C", VA = "0x2E7991C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000007")]
		public TouchPhase phase
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2E79924", Offset = "0x2E75924", VA = "0x2E79924")]
			get
			{
				return default(TouchPhase);
			}
		}

		[Token(Token = "0x17000008")]
		public float pressure
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2E7992C", Offset = "0x2E7592C", VA = "0x2E7992C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000009")]
		public float maximumPossiblePressure
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2E79934", Offset = "0x2E75934", VA = "0x2E79934")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000A")]
		public TouchType type
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2E7993C", Offset = "0x2E7593C", VA = "0x2E7993C")]
			get
			{
				return default(TouchType);
			}
		}

		[Token(Token = "0x1700000B")]
		public float altitudeAngle
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2E79944", Offset = "0x2E75944", VA = "0x2E79944")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000C")]
		public float azimuthAngle
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2E7994C", Offset = "0x2E7594C", VA = "0x2E7994C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000D")]
		public float radius
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2E79954", Offset = "0x2E75954", VA = "0x2E79954")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000E")]
		public float radiusVariance
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2E7995C", Offset = "0x2E7595C", VA = "0x2E7995C")]
			get
			{
				return default(float);
			}
		}
	}
	[Token(Token = "0x2000006")]
	[Flags]
	public enum PenStatus
	{
		[Token(Token = "0x400001E")]
		None = 0,
		[Token(Token = "0x400001F")]
		Contact = 1,
		[Token(Token = "0x4000020")]
		Barrel = 2,
		[Token(Token = "0x4000021")]
		Inverted = 4,
		[Token(Token = "0x4000022")]
		Eraser = 8
	}
	[Token(Token = "0x2000007")]
	public enum PenEventType
	{
		[Token(Token = "0x4000024")]
		NoContact,
		[Token(Token = "0x4000025")]
		PenDown,
		[Token(Token = "0x4000026")]
		PenUp
	}
	[Token(Token = "0x2000008")]
	public struct PenData
	{
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 position;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 tilt;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		public PenStatus penStatus;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x14")]
		public float twist;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		public float pressure;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x1C")]
		public PenEventType contactType;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 deltaPos;
	}
	[Token(Token = "0x2000009")]
	public enum DeviceOrientation
	{
		[Token(Token = "0x400002F")]
		Unknown,
		[Token(Token = "0x4000030")]
		Portrait,
		[Token(Token = "0x4000031")]
		PortraitUpsideDown,
		[Token(Token = "0x4000032")]
		LandscapeLeft,
		[Token(Token = "0x4000033")]
		LandscapeRight,
		[Token(Token = "0x4000034")]
		FaceUp,
		[Token(Token = "0x4000035")]
		FaceDown
	}
	[Token(Token = "0x200000A")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Camera/Camera.h")]
	internal class CameraRaycastHelper
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2E79964", Offset = "0x2E75964", VA = "0x2E79964")]
		[UnityEngine.Bindings.FreeFunction("CameraScripting::RaycastTry")]
		internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2E79A2C", Offset = "0x2E75A2C", VA = "0x2E79A2C")]
		[UnityEngine.Bindings.FreeFunction("CameraScripting::RaycastTry2D")]
		internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask)
		{
			return null;
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2E799C8", Offset = "0x2E759C8", VA = "0x2E799C8")]
		private static extern GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask);

		[MethodImpl(4096)]
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2E79A90", Offset = "0x2E75A90", VA = "0x2E79A90")]
		private static extern GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask);
	}
	[Token(Token = "0x200000B")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Input/InputBindings.h")]
	public class Input
	{
		[Token(Token = "0x1700000F")]
		[UnityEngine.Bindings.NativeThrows]
		public static extern bool anyKey
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2E7A10C", Offset = "0x2E7610C", VA = "0x2E7A10C")]
			get;
		}

		[Token(Token = "0x17000010")]
		[UnityEngine.Bindings.NativeThrows]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2E7A134", Offset = "0x2E76134", VA = "0x2E7A134")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000011")]
		[UnityEngine.Bindings.NativeThrows]
		public static Vector2 mouseScrollDelta
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2E7A1BC", Offset = "0x2E761BC", VA = "0x2E7A1BC")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000012")]
		public static extern IMECompositionMode imeCompositionMode
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2E7A23C", Offset = "0x2E7623C", VA = "0x2E7A23C")]
			get;
			[MethodImpl(4096)]
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2E7A264", Offset = "0x2E76264", VA = "0x2E7A264")]
			set;
		}

		[Token(Token = "0x17000013")]
		public static extern string compositionString
		{
			[MethodImpl(4096)]
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2E7A2A0", Offset = "0x2E762A0", VA = "0x2E7A2A0")]
			get;
		}

		[Token(Token = "0x17000014")]
		public static Vector2 compositionCursorPos
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2E7A2C8", Offset = "0x2E762C8", VA = "0x2E7A2C8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2E7A348", Offset = "0x2E76348", VA = "0x2E7A348")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public static extern bool mousePresent
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2E7A3C4", Offset = "0x2E763C4", VA = "0x2E7A3C4")]
			[UnityEngine.Bindings.FreeFunction("GetMousePresent")]
			get;
		}

		[Token(Token = "0x17000016")]
		public static extern int touchCount
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2E7A3EC", Offset = "0x2E763EC", VA = "0x2E7A3EC")]
			[UnityEngine.Bindings.FreeFunction("GetTouchCount")]
			get;
		}

		[Token(Token = "0x17000017")]
		public static extern bool touchSupported
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2E7A414", Offset = "0x2E76414", VA = "0x2E7A414")]
			[UnityEngine.Bindings.FreeFunction("IsTouchSupported")]
			get;
		}

		[Token(Token = "0x17000018")]
		public static extern DeviceOrientation deviceOrientation
		{
			[MethodImpl(4096)]
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2E7A43C", Offset = "0x2E7643C", VA = "0x2E7A43C")]
			[UnityEngine.Bindings.FreeFunction("GetDeviceOrientation")]
			get;
		}

		[Token(Token = "0x17000019")]
		public static Touch[] touches
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2E7A464", Offset = "0x2E76464", VA = "0x2E7A464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2E79AF4", Offset = "0x2E75AF4", VA = "0x2E79AF4")]
		public static float GetAxis(string axisName)
		{
			return default(float);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2E79B6C", Offset = "0x2E75B6C", VA = "0x2E79B6C")]
		public static float GetAxisRaw(string axisName)
		{
			return default(float);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2E79BE4", Offset = "0x2E75BE4", VA = "0x2E79BE4")]
		public static bool GetButton(string buttonName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2E79C5C", Offset = "0x2E75C5C", VA = "0x2E79C5C")]
		public static bool GetButtonDown(string buttonName)
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2E79CD4", Offset = "0x2E75CD4", VA = "0x2E79CD4")]
		public static bool GetButtonUp(string buttonName)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2E79D4C", Offset = "0x2E75D4C", VA = "0x2E79D4C")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern bool GetKeyInt(KeyCode key);

		[MethodImpl(4096)]
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2E79D88", Offset = "0x2E75D88", VA = "0x2E79D88")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern bool GetKeyUpInt(KeyCode key);

		[MethodImpl(4096)]
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2E79DC4", Offset = "0x2E75DC4", VA = "0x2E79DC4")]
		[UnityEngine.Bindings.NativeThrows]
		private static extern bool GetKeyDownInt(KeyCode key);

		[MethodImpl(4096)]
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2E79E00", Offset = "0x2E75E00", VA = "0x2E79E00")]
		[UnityEngine.Bindings.NativeThrows]
		public static extern bool GetMouseButton(int button);

		[MethodImpl(4096)]
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2E79E3C", Offset = "0x2E75E3C", VA = "0x2E79E3C")]
		[UnityEngine.Bindings.NativeThrows]
		public static extern bool GetMouseButtonDown(int button);

		[MethodImpl(4096)]
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2E79E78", Offset = "0x2E75E78", VA = "0x2E79E78")]
		[UnityEngine.Bindings.NativeThrows]
		public static extern bool GetMouseButtonUp(int button);

		[MethodImpl(4096)]
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2E79EB4", Offset = "0x2E75EB4", VA = "0x2E79EB4")]
		[UnityEngine.Bindings.NativeThrows]
		public static extern string[] GetJoystickNames();

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2E79EDC", Offset = "0x2E75EDC", VA = "0x2E79EDC")]
		[UnityEngine.Bindings.NativeThrows]
		public static Touch GetTouch(int index)
		{
			return default(Touch);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2E79F90", Offset = "0x2E75F90", VA = "0x2E79F90")]
		[UnityEngine.Bindings.NativeThrows]
		public static PenData GetLastPenContactEvent()
		{
			return default(PenData);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2E7A030", Offset = "0x2E76030", VA = "0x2E7A030")]
		[UnityEngine.Bindings.NativeThrows]
		public static extern void ClearLastPenContactEvent();

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2E7A058", Offset = "0x2E76058", VA = "0x2E7A058")]
		public static bool GetKey(KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2E7A094", Offset = "0x2E76094", VA = "0x2E7A094")]
		public static bool GetKeyUp(KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2E7A0D0", Offset = "0x2E760D0", VA = "0x2E7A0D0")]
		public static bool GetKeyDown(KeyCode key)
		{
			return default(bool);
		}

		[MethodImpl(4096)]
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2E7A590", Offset = "0x2E76590", VA = "0x2E7A590")]
		internal static extern bool CheckDisabled();

		[MethodImpl(4096)]
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2E79F4C", Offset = "0x2E75F4C", VA = "0x2E79F4C")]
		private static extern void GetTouch_Injected(int index, out Touch ret);

		[MethodImpl(4096)]
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2E79FF4", Offset = "0x2E75FF4", VA = "0x2E79FF4")]
		private static extern void GetLastPenContactEvent_Injected(out PenData ret);

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2E7A180", Offset = "0x2E76180", VA = "0x2E7A180")]
		private static extern void get_mousePosition_Injected(out Vector3 ret);

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2E7A200", Offset = "0x2E76200", VA = "0x2E7A200")]
		private static extern void get_mouseScrollDelta_Injected(out Vector2 ret);

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2E7A30C", Offset = "0x2E7630C", VA = "0x2E7A30C")]
		private static extern void get_compositionCursorPos_Injected(out Vector2 ret);

		[MethodImpl(4096)]
		[SpecialName]
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2E7A388", Offset = "0x2E76388", VA = "0x2E7A388")]
		private static extern void set_compositionCursorPos_Injected(ref Vector2 value);
	}
	[Token(Token = "0x200000C")]
	internal class SendMouseEvents
	{
		[Token(Token = "0x200000D")]
		private struct HitInfo
		{
			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x0")]
			public GameObject target;

			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x8")]
			public Camera camera;

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2E7B64C", Offset = "0x2E7764C", VA = "0x2E7B64C")]
			public void SendMessage(string name)
			{
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2E7B5AC", Offset = "0x2E775AC", VA = "0x2E7B5AC")]
			public static implicit operator bool(HitInfo exists)
			{
				return default(bool);
			}

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2E7B66C", Offset = "0x2E7766C", VA = "0x2E7B66C")]
			public static bool Compare(HitInfo lhs, HitInfo rhs)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_MouseUsed;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HitInfo[] m_LastHit;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x10")]
		private static readonly HitInfo[] m_MouseDownHit;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x18")]
		private static readonly HitInfo[] m_CurrentHit;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x20")]
		private static Camera[] m_Cameras;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x28")]
		public static Func<KeyValuePair<int, Vector2>> s_GetMouseState;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x30")]
		private static Vector2 s_MousePosition;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x38")]
		private static bool s_MouseButtonPressedThisFrame;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x39")]
		private static bool s_MouseButtonIsPressed;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2E7A5B8", Offset = "0x2E765B8", VA = "0x2E7A5B8")]
		private static void UpdateMouse()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2E7A774", Offset = "0x2E76774", VA = "0x2E7A774")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		private static void SetMouseMoved()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2E7A7D0", Offset = "0x2E767D0", VA = "0x2E7A7D0")]
		[UnityEngine.Scripting.RequiredByNativeCode]
		private static void DoSendMouseEvents(int skipRTCameras)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2E7B154", Offset = "0x2E77154", VA = "0x2E7B154")]
		private static void SendEvents(int i, HitInfo hit)
		{
		}
	}
}
namespace UnityEngine.Internal
{
	[Token(Token = "0x200000E")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Input/InputBindings.h")]
	internal static class InputUnsafeUtility
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2E7B7CC", Offset = "0x2E777CC", VA = "0x2E7B7CC")]
		[UnityEngine.Bindings.NativeThrows]
		internal unsafe static extern bool GetKeyString__Unmanaged(byte* name, int nameLen);

		[MethodImpl(4096)]
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2E7B810", Offset = "0x2E77810", VA = "0x2E7B810")]
		[UnityEngine.Bindings.NativeThrows]
		internal unsafe static extern bool GetKeyUpString__Unmanaged(byte* name, int nameLen);

		[MethodImpl(4096)]
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2E7B854", Offset = "0x2E77854", VA = "0x2E7B854")]
		[UnityEngine.Bindings.NativeThrows]
		internal unsafe static extern bool GetKeyDownString__Unmanaged(byte* name, int nameLen);

		[MethodImpl(4096)]
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2E79B30", Offset = "0x2E75B30", VA = "0x2E79B30")]
		[UnityEngine.Bindings.NativeThrows]
		internal static extern float GetAxis(string axisName);

		[MethodImpl(4096)]
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2E7B898", Offset = "0x2E77898", VA = "0x2E7B898")]
		[UnityEngine.Bindings.NativeThrows]
		internal unsafe static extern float GetAxis__Unmanaged(byte* axisName, int axisNameLen);

		[MethodImpl(4096)]
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2E79BA8", Offset = "0x2E75BA8", VA = "0x2E79BA8")]
		[UnityEngine.Bindings.NativeThrows]
		internal static extern float GetAxisRaw(string axisName);

		[MethodImpl(4096)]
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2E7B8DC", Offset = "0x2E778DC", VA = "0x2E7B8DC")]
		[UnityEngine.Bindings.NativeThrows]
		internal unsafe static extern float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen);

		[MethodImpl(4096)]
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2E79C20", Offset = "0x2E75C20", VA = "0x2E79C20")]
		[UnityEngine.Bindings.NativeThrows]
		internal static extern bool GetButton(string buttonName);

		[MethodImpl(4096)]
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2E7B920", Offset = "0x2E77920", VA = "0x2E7B920")]
		[UnityEngine.Bindings.NativeThrows]
		internal unsafe static extern bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen);

		[MethodImpl(4096)]
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2E79C98", Offset = "0x2E75C98", VA = "0x2E79C98")]
		[UnityEngine.Bindings.NativeThrows]
		internal static extern bool GetButtonDown(string buttonName);

		[MethodImpl(4096)]
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2E7B964", Offset = "0x2E77964", VA = "0x2E7B964")]
		[UnityEngine.Bindings.NativeThrows]
		internal unsafe static extern byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen);

		[MethodImpl(4096)]
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2E79D10", Offset = "0x2E75D10", VA = "0x2E79D10")]
		[UnityEngine.Bindings.NativeThrows]
		internal static extern bool GetButtonUp(string buttonName);

		[MethodImpl(4096)]
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2E7B9A8", Offset = "0x2E779A8", VA = "0x2E7B9A8")]
		[UnityEngine.Bindings.NativeThrows]
		internal unsafe static extern bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen);
	}
}
