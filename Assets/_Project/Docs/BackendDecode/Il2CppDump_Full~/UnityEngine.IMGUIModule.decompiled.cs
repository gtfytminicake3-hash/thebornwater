using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.TextCore.Text;
using UnityEngineInternal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine;

[StructLayout(0)]
[Token(Token = "0x2000002")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/Event.bindings.h")]
[UnityEngine.Bindings.StaticAccessor("GUIEvent", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
public sealed class Event
{
	[NonSerialized]
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal IntPtr m_Ptr;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Event s_Current;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Event s_MasterEvent;

	[Token(Token = "0x17000001")]
	[UnityEngine.Bindings.NativeProperty("type", false, UnityEngine.Bindings.TargetType.Field)]
	public extern EventType rawType
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2E54644", Offset = "0x2E50644", VA = "0x2E54644")]
		get;
	}

	[Token(Token = "0x17000002")]
	[UnityEngine.Bindings.NativeProperty("mousePosition", false, UnityEngine.Bindings.TargetType.Field)]
	public Vector2 mousePosition
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2E54680", Offset = "0x2E50680", VA = "0x2E54680")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2E54710", Offset = "0x2E50710", VA = "0x2E54710")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	[UnityEngine.Bindings.NativeProperty("delta", false, UnityEngine.Bindings.TargetType.Field)]
	public Vector2 delta
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2E5479C", Offset = "0x2E5079C", VA = "0x2E5479C")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2E5482C", Offset = "0x2E5082C", VA = "0x2E5482C")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	[UnityEngine.Bindings.NativeProperty("pointerType", false, UnityEngine.Bindings.TargetType.Field)]
	public extern PointerType pointerType
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2E548B8", Offset = "0x2E508B8", VA = "0x2E548B8")]
		get;
	}

	[Token(Token = "0x17000005")]
	[UnityEngine.Bindings.NativeProperty("button", false, UnityEngine.Bindings.TargetType.Field)]
	public extern int button
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2E548F4", Offset = "0x2E508F4", VA = "0x2E548F4")]
		get;
	}

	[Token(Token = "0x17000006")]
	[UnityEngine.Bindings.NativeProperty("modifiers", false, UnityEngine.Bindings.TargetType.Field)]
	public extern EventModifiers modifiers
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2E54930", Offset = "0x2E50930", VA = "0x2E54930")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2E5496C", Offset = "0x2E5096C", VA = "0x2E5496C")]
		set;
	}

	[Token(Token = "0x17000007")]
	[UnityEngine.Bindings.NativeProperty("pressure", false, UnityEngine.Bindings.TargetType.Field)]
	public extern float pressure
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2E549B0", Offset = "0x2E509B0", VA = "0x2E549B0")]
		get;
	}

	[Token(Token = "0x17000008")]
	[UnityEngine.Bindings.NativeProperty("twist", false, UnityEngine.Bindings.TargetType.Field)]
	public extern float twist
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2E549EC", Offset = "0x2E509EC", VA = "0x2E549EC")]
		get;
	}

	[Token(Token = "0x17000009")]
	[UnityEngine.Bindings.NativeProperty("tilt", false, UnityEngine.Bindings.TargetType.Field)]
	public Vector2 tilt
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2E54A28", Offset = "0x2E50A28", VA = "0x2E54A28")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700000A")]
	[UnityEngine.Bindings.NativeProperty("penStatus", false, UnityEngine.Bindings.TargetType.Field)]
	public extern PenStatus penStatus
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2E54AB8", Offset = "0x2E50AB8", VA = "0x2E54AB8")]
		get;
	}

	[Token(Token = "0x1700000B")]
	[UnityEngine.Bindings.NativeProperty("clickCount", false, UnityEngine.Bindings.TargetType.Field)]
	public extern int clickCount
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2E54AF4", Offset = "0x2E50AF4", VA = "0x2E54AF4")]
		get;
	}

	[Token(Token = "0x1700000C")]
	[UnityEngine.Bindings.NativeProperty("character", false, UnityEngine.Bindings.TargetType.Field)]
	public extern char character
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2E54B30", Offset = "0x2E50B30", VA = "0x2E54B30")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2E54B6C", Offset = "0x2E50B6C", VA = "0x2E54B6C")]
		set;
	}

	[Token(Token = "0x1700000D")]
	[UnityEngine.Bindings.NativeProperty("keycode", false, UnityEngine.Bindings.TargetType.Field)]
	public extern KeyCode keyCode
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2E54BB0", Offset = "0x2E50BB0", VA = "0x2E54BB0")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2E54BEC", Offset = "0x2E50BEC", VA = "0x2E54BEC")]
		set;
	}

	[Token(Token = "0x1700000E")]
	[UnityEngine.Bindings.NativeProperty("displayIndex", false, UnityEngine.Bindings.TargetType.Field)]
	public extern int displayIndex
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2E54C30", Offset = "0x2E50C30", VA = "0x2E54C30")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2E54C6C", Offset = "0x2E50C6C", VA = "0x2E54C6C")]
		set;
	}

	[Token(Token = "0x1700000F")]
	public extern EventType type
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2E54CB0", Offset = "0x2E50CB0", VA = "0x2E54CB0")]
		[UnityEngine.Bindings.FreeFunction("GUIEvent::GetType", HasExplicitThis = true)]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2E54CEC", Offset = "0x2E50CEC", VA = "0x2E54CEC")]
		[UnityEngine.Bindings.FreeFunction("GUIEvent::SetType", HasExplicitThis = true)]
		set;
	}

	[Token(Token = "0x17000010")]
	public extern string commandName
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2E54D30", Offset = "0x2E50D30", VA = "0x2E54D30")]
		[UnityEngine.Bindings.FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = true)]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2E54D6C", Offset = "0x2E50D6C", VA = "0x2E54D6C")]
		[UnityEngine.Bindings.FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = true)]
		set;
	}

	[Token(Token = "0x17000011")]
	public bool shift
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2E55264", Offset = "0x2E51264", VA = "0x2E55264")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000012")]
	public bool control
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2E552A8", Offset = "0x2E512A8", VA = "0x2E552A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public bool alt
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2E552EC", Offset = "0x2E512EC", VA = "0x2E552EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public bool command
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2E55330", Offset = "0x2E51330", VA = "0x2E55330")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public static Event current
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2E55374", Offset = "0x2E51374", VA = "0x2E55374")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2E553BC", Offset = "0x2E513BC", VA = "0x2E553BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public bool isKey
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2E5544C", Offset = "0x2E5144C", VA = "0x2E5544C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public bool isMouse
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2E55498", Offset = "0x2E51498", VA = "0x2E55498")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	internal bool isDirectManipulationDevice
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2E55504", Offset = "0x2E51504", VA = "0x2E55504")]
		get
		{
			return default(bool);
		}
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2E54DB0", Offset = "0x2E50DB0", VA = "0x2E54DB0")]
	[UnityEngine.Bindings.NativeMethod("Use")]
	private extern void Internal_Use();

	[MethodImpl(4096)]
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2E54DEC", Offset = "0x2E50DEC", VA = "0x2E54DEC")]
	[UnityEngine.Bindings.FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = true)]
	private static extern IntPtr Internal_Create(int displayIndex);

	[MethodImpl(4096)]
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2E54E28", Offset = "0x2E50E28", VA = "0x2E54E28")]
	[UnityEngine.Bindings.FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = true)]
	private static extern void Internal_Destroy(IntPtr ptr);

	[MethodImpl(4096)]
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2E54E64", Offset = "0x2E50E64", VA = "0x2E54E64")]
	[UnityEngine.Bindings.FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = true)]
	public extern EventType GetTypeForControl(int controlID);

	[MethodImpl(4096)]
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2E54EA8", Offset = "0x2E50EA8", VA = "0x2E54EA8")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	[UnityEngine.Bindings.FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = true, HasExplicitThis = true)]
	internal extern void CopyFromPtr(IntPtr ptr);

	[MethodImpl(4096)]
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2E54EEC", Offset = "0x2E50EEC", VA = "0x2E54EEC")]
	public static extern bool PopEvent([UnityEngine.Bindings.NotNull("ArgumentNullException")] Event outEvent);

	[MethodImpl(4096)]
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2E54F28", Offset = "0x2E50F28", VA = "0x2E54F28")]
	private static extern void Internal_SetNativeEvent(IntPtr ptr);

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2E54F64", Offset = "0x2E50F64", VA = "0x2E54F64")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void Internal_MakeMasterEventCurrent(int displayIndex)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2E550A4", Offset = "0x2E510A4", VA = "0x2E550A4")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal static extern int GetDoubleClickTime();

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2E550CC", Offset = "0x2E510CC", VA = "0x2E550CC")]
	public Event()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2E55054", Offset = "0x2E51054", VA = "0x2E55054")]
	public Event(int displayIndex)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2E55118", Offset = "0x2E51118", VA = "0x2E55118", Slot = "1")]
	~Event()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2E551F4", Offset = "0x2E511F4", VA = "0x2E551F4")]
	internal void CopyFrom(Event e)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2E55580", Offset = "0x2E51580", VA = "0x2E55580")]
	public static Event KeyboardEvent(string key)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2E57624", Offset = "0x2E53624", VA = "0x2E57624", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2E57720", Offset = "0x2E53720", VA = "0x2E57720", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2E5798C", Offset = "0x2E5398C", VA = "0x2E5798C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2E5813C", Offset = "0x2E5413C", VA = "0x2E5813C")]
	public void Use()
	{
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2E546CC", Offset = "0x2E506CC", VA = "0x2E546CC")]
	private extern void get_mousePosition_Injected(out Vector2 ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2E54758", Offset = "0x2E50758", VA = "0x2E54758")]
	private extern void set_mousePosition_Injected(ref Vector2 value);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2E547E8", Offset = "0x2E507E8", VA = "0x2E547E8")]
	private extern void get_delta_Injected(out Vector2 ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2E54874", Offset = "0x2E50874", VA = "0x2E54874")]
	private extern void set_delta_Injected(ref Vector2 value);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2E54A74", Offset = "0x2E50A74", VA = "0x2E54A74")]
	private extern void get_tilt_Injected(out Vector2 ret);
}
[Token(Token = "0x2000003")]
public enum EventType
{
	[Token(Token = "0x4000005")]
	MouseDown = 0,
	[Token(Token = "0x4000006")]
	MouseUp = 1,
	[Token(Token = "0x4000007")]
	MouseMove = 2,
	[Token(Token = "0x4000008")]
	MouseDrag = 3,
	[Token(Token = "0x4000009")]
	KeyDown = 4,
	[Token(Token = "0x400000A")]
	KeyUp = 5,
	[Token(Token = "0x400000B")]
	ScrollWheel = 6,
	[Token(Token = "0x400000C")]
	Repaint = 7,
	[Token(Token = "0x400000D")]
	Layout = 8,
	[Token(Token = "0x400000E")]
	DragUpdated = 9,
	[Token(Token = "0x400000F")]
	DragPerform = 10,
	[Token(Token = "0x4000010")]
	DragExited = 15,
	[Token(Token = "0x4000011")]
	Ignore = 11,
	[Token(Token = "0x4000012")]
	Used = 12,
	[Token(Token = "0x4000013")]
	ValidateCommand = 13,
	[Token(Token = "0x4000014")]
	ExecuteCommand = 14,
	[Token(Token = "0x4000015")]
	ContextClick = 16,
	[Token(Token = "0x4000016")]
	MouseEnterWindow = 20,
	[Token(Token = "0x4000017")]
	MouseLeaveWindow = 21,
	[Token(Token = "0x4000018")]
	TouchDown = 30,
	[Token(Token = "0x4000019")]
	TouchUp = 31,
	[Token(Token = "0x400001A")]
	TouchMove = 32,
	[Token(Token = "0x400001B")]
	TouchEnter = 33,
	[Token(Token = "0x400001C")]
	TouchLeave = 34,
	[Token(Token = "0x400001D")]
	TouchStationary = 35,
	[Token(Token = "0x400001E")]
	[Obsolete("Use MouseDown instead (UnityUpgradable) -> MouseDown", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	mouseDown = 0,
	[Token(Token = "0x400001F")]
	[Obsolete("Use MouseUp instead (UnityUpgradable) -> MouseUp", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	mouseUp = 1,
	[Token(Token = "0x4000020")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use MouseMove instead (UnityUpgradable) -> MouseMove", true)]
	mouseMove = 2,
	[Token(Token = "0x4000021")]
	[Obsolete("Use MouseDrag instead (UnityUpgradable) -> MouseDrag", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	mouseDrag = 3,
	[Token(Token = "0x4000022")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use KeyDown instead (UnityUpgradable) -> KeyDown", true)]
	keyDown = 4,
	[Token(Token = "0x4000023")]
	[Obsolete("Use KeyUp instead (UnityUpgradable) -> KeyUp", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	keyUp = 5,
	[Token(Token = "0x4000024")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use ScrollWheel instead (UnityUpgradable) -> ScrollWheel", true)]
	scrollWheel = 6,
	[Token(Token = "0x4000025")]
	[Obsolete("Use Repaint instead (UnityUpgradable) -> Repaint", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	repaint = 7,
	[Token(Token = "0x4000026")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use Layout instead (UnityUpgradable) -> Layout", true)]
	layout = 8,
	[Token(Token = "0x4000027")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use DragUpdated instead (UnityUpgradable) -> DragUpdated", true)]
	dragUpdated = 9,
	[Token(Token = "0x4000028")]
	[Obsolete("Use DragPerform instead (UnityUpgradable) -> DragPerform", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	dragPerform = 10,
	[Token(Token = "0x4000029")]
	[Obsolete("Use Ignore instead (UnityUpgradable) -> Ignore", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	ignore = 11,
	[Token(Token = "0x400002A")]
	[Obsolete("Use Used instead (UnityUpgradable) -> Used", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	used = 12
}
[Token(Token = "0x2000004")]
[Flags]
public enum EventModifiers
{
	[Token(Token = "0x400002C")]
	None = 0,
	[Token(Token = "0x400002D")]
	Shift = 1,
	[Token(Token = "0x400002E")]
	Control = 2,
	[Token(Token = "0x400002F")]
	Alt = 4,
	[Token(Token = "0x4000030")]
	Command = 8,
	[Token(Token = "0x4000031")]
	Numeric = 0x10,
	[Token(Token = "0x4000032")]
	CapsLock = 0x20,
	[Token(Token = "0x4000033")]
	FunctionKey = 0x40
}
[Token(Token = "0x2000005")]
public enum PointerType
{
	[Token(Token = "0x4000035")]
	Mouse,
	[Token(Token = "0x4000036")]
	Touch,
	[Token(Token = "0x4000037")]
	Pen
}
[Token(Token = "0x2000006")]
internal struct EventInterests
{
	[Token(Token = "0x17000019")]
	public bool wantsMouseMove
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2E58300", Offset = "0x2E54300", VA = "0x2E58300")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2E58308", Offset = "0x2E54308", VA = "0x2E58308")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public bool wantsMouseEnterLeaveWindow
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2E58310", Offset = "0x2E54310", VA = "0x2E58310")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2E58318", Offset = "0x2E54318", VA = "0x2E58318")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public readonly bool wantsLessLayoutEvents
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2E58320", Offset = "0x2E54320", VA = "0x2E58320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2E58328", Offset = "0x2E54328", VA = "0x2E58328")]
	public bool WantsEvent(EventType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2E58350", Offset = "0x2E54350", VA = "0x2E58350")]
	public bool WantsLayoutPass(EventType type)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000007")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUI.bindings.h")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
public class GUI
{
	[Token(Token = "0x2000008")]
	public delegate void WindowFunction(int id);

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int s_ScrollControlId;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int s_HotTextField;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int s_BoxHash;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly int s_ButonHash;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly int s_RepeatButtonHash;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static readonly int s_ToggleHash;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly int s_ButtonGridHash;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static readonly int s_SliderHash;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly int s_BeginGroupHash;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly int s_ScrollviewHash;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static GUISkin s_Skin;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	internal static Rect s_ToolTipRect;

	[Token(Token = "0x1700001C")]
	public static Color color
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2E58464", Offset = "0x2E54464", VA = "0x2E58464")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2E58528", Offset = "0x2E54528", VA = "0x2E58528")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public static Color backgroundColor
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2E585E8", Offset = "0x2E545E8", VA = "0x2E585E8")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2E586AC", Offset = "0x2E546AC", VA = "0x2E586AC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public static Color contentColor
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2E5876C", Offset = "0x2E5476C", VA = "0x2E5876C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2E58830", Offset = "0x2E54830", VA = "0x2E58830")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public static extern bool changed
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2E588F0", Offset = "0x2E548F0", VA = "0x2E588F0")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2E58918", Offset = "0x2E54918", VA = "0x2E58918")]
		set;
	}

	[Token(Token = "0x17000020")]
	public static extern bool enabled
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2E58954", Offset = "0x2E54954", VA = "0x2E58954")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2E5897C", Offset = "0x2E5497C", VA = "0x2E5897C")]
		set;
	}

	[Token(Token = "0x17000021")]
	internal static extern bool usePageScrollbars
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2E589B8", Offset = "0x2E549B8", VA = "0x2E589B8")]
		get;
	}

	[Token(Token = "0x17000022")]
	internal static extern Material blendMaterial
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2E589E0", Offset = "0x2E549E0", VA = "0x2E589E0")]
		[UnityEngine.Bindings.FreeFunction("GetGUIBlendMaterial")]
		get;
	}

	[Token(Token = "0x17000023")]
	internal static extern Material blitMaterial
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2E58A08", Offset = "0x2E54A08", VA = "0x2E58A08")]
		[UnityEngine.Bindings.FreeFunction("GetGUIBlitMaterial")]
		get;
	}

	[Token(Token = "0x17000024")]
	internal static extern Material roundedRectMaterial
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2E58A30", Offset = "0x2E54A30", VA = "0x2E58A30")]
		[UnityEngine.Bindings.FreeFunction("GetGUIRoundedRectMaterial")]
		get;
	}

	[Token(Token = "0x17000025")]
	internal static extern Material roundedRectWithColorPerBorderMaterial
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2E58A58", Offset = "0x2E54A58", VA = "0x2E58A58")]
		[UnityEngine.Bindings.FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")]
		get;
	}

	[Token(Token = "0x17000026")]
	internal static int scrollTroughSide
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2E5903C", Offset = "0x2E5503C", VA = "0x2E5903C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2E59094", Offset = "0x2E55094", VA = "0x2E59094")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	internal static DateTime nextScrollStepTime
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2E590F0", Offset = "0x2E550F0", VA = "0x2E590F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2E59148", Offset = "0x2E55148", VA = "0x2E59148")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public static GUISkin skin
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2E593A4", Offset = "0x2E553A4", VA = "0x2E593A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2E591A4", Offset = "0x2E551A4", VA = "0x2E591A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public static Matrix4x4 matrix
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2E5959C", Offset = "0x2E5559C", VA = "0x2E5959C")]
		get
		{
			return default(Matrix4x4);
		}
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2E5966C", Offset = "0x2E5566C", VA = "0x2E5966C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	internal static GenericStack scrollViewStates
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2E5EF60", Offset = "0x2E5AF60", VA = "0x2E5EF60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2E58A80", Offset = "0x2E54A80", VA = "0x2E58A80")]
	internal static extern void GrabMouseControl(int id);

	[MethodImpl(4096)]
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2E58ABC", Offset = "0x2E54ABC", VA = "0x2E58ABC")]
	internal static extern bool HasMouseControl(int id);

	[MethodImpl(4096)]
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2E58AF8", Offset = "0x2E54AF8", VA = "0x2E58AF8")]
	internal static extern void ReleaseMouseControl();

	[MethodImpl(4096)]
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2E58B20", Offset = "0x2E54B20", VA = "0x2E58B20")]
	internal static extern void InternalRepaintEditorWindow();

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2E58B48", Offset = "0x2E54B48", VA = "0x2E58B48")]
	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2E58CCC", Offset = "0x2E54CCC", VA = "0x2E58CCC")]
	public static void DragWindow(Rect position)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2E58D8C", Offset = "0x2E54D8C", VA = "0x2E58D8C")]
	static GUI()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2E592DC", Offset = "0x2E552DC", VA = "0x2E592DC")]
	internal static void DoSetSkin(GUISkin newSkin)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2E596F4", Offset = "0x2E556F4", VA = "0x2E596F4")]
	public static void Label(Rect position, string text)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2E59914", Offset = "0x2E55914", VA = "0x2E59914")]
	public static void Label(Rect position, string text, GUIStyle style)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2E59858", Offset = "0x2E55858", VA = "0x2E59858")]
	public static void Label(Rect position, GUIContent content, GUIStyle style)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2E59CA8", Offset = "0x2E55CA8", VA = "0x2E59CA8")]
	public static void DrawTexture(Rect position, Texture image)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2E59D30", Offset = "0x2E55D30", VA = "0x2E59D30")]
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2E59DC8", Offset = "0x2E55DC8", VA = "0x2E59DC8")]
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2E59E68", Offset = "0x2E55E68", VA = "0x2E59E68")]
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2E59F38", Offset = "0x2E55F38", VA = "0x2E59F38")]
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2E5A050", Offset = "0x2E56050", VA = "0x2E5A050")]
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2E5A170", Offset = "0x2E56170", VA = "0x2E5A170")]
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2E5A2C0", Offset = "0x2E562C0", VA = "0x2E5A2C0")]
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2E5A418", Offset = "0x2E56418", VA = "0x2E5A418")]
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2E5A9D4", Offset = "0x2E569D4", VA = "0x2E5A9D4")]
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect)
	{
		return default(bool);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2E5AADC", Offset = "0x2E56ADC", VA = "0x2E5AADC")]
	public static void Box(Rect position, string text)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2E5ABB4", Offset = "0x2E56BB4", VA = "0x2E5ABB4")]
	public static void Box(Rect position, GUIContent content, GUIStyle style)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2E5AEEC", Offset = "0x2E56EEC", VA = "0x2E5AEEC")]
	public static bool Button(Rect position, string text)
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2E5AFC4", Offset = "0x2E56FC4", VA = "0x2E5AFC4")]
	public static bool Button(Rect position, GUIContent content, GUIStyle style)
	{
		return default(bool);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2E5B150", Offset = "0x2E57150", VA = "0x2E5B150")]
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style)
	{
		return default(bool);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2E5B320", Offset = "0x2E57320", VA = "0x2E5B320")]
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2E5B7B8", Offset = "0x2E577B8", VA = "0x2E5B7B8")]
	public static string TextField(Rect position, string text, GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2E5BA28", Offset = "0x2E57A28", VA = "0x2E5BA28")]
	internal static string PasswordFieldGetStrToShow(string password, char maskChar)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2E5B968", Offset = "0x2E57968", VA = "0x2E5B968")]
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2E5BB6C", Offset = "0x2E57B6C", VA = "0x2E5BB6C")]
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2E5BC34", Offset = "0x2E57C34", VA = "0x2E5BC34")]
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2E5C3B8", Offset = "0x2E583B8", VA = "0x2E5C3B8")]
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2E5C844", Offset = "0x2E58844", VA = "0x2E5C844")]
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2E5C038", Offset = "0x2E58038", VA = "0x2E5C038")]
	private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2E5D240", Offset = "0x2E59240", VA = "0x2E5D240")]
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style)
	{
		return default(bool);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2E599DC", Offset = "0x2E559DC", VA = "0x2E599DC")]
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2E5B214", Offset = "0x2E57214", VA = "0x2E5B214")]
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style)
	{
		return default(bool);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2E5D88C", Offset = "0x2E5988C", VA = "0x2E5D88C")]
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb)
	{
		return default(float);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2E5D958", Offset = "0x2E59958", VA = "0x2E5D958")]
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, [Optional] GUIStyle thumbExtent)
	{
		return default(float);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x2E5DAEC", Offset = "0x2E59AEC", VA = "0x2E5DAEC")]
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style)
	{
		return default(float);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2E5E4B8", Offset = "0x2E5A4B8", VA = "0x2E5E4B8")]
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style)
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2E5E79C", Offset = "0x2E5A79C", VA = "0x2E5E79C")]
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style)
	{
		return default(float);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2E5DF80", Offset = "0x2E59F80", VA = "0x2E5DF80")]
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz)
	{
		return default(float);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2E5EA4C", Offset = "0x2E5AA4C", VA = "0x2E5EA4C")]
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2E5EB24", Offset = "0x2E5AB24", VA = "0x2E5EB24")]
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2E5EECC", Offset = "0x2E5AECC", VA = "0x2E5EECC")]
	public static void EndGroup()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2E5EFB8", Offset = "0x2E5AFB8", VA = "0x2E5EFB8")]
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2E5FC88", Offset = "0x2E5BC88", VA = "0x2E5FC88")]
	public static void EndScrollView(bool handleScrollWheel)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2E60924", Offset = "0x2E5C924", VA = "0x2E60924")]
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text)
	{
		return default(Rect);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2E60B40", Offset = "0x2E5CB40", VA = "0x2E60B40")]
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style)
	{
		return default(Rect);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2E60C54", Offset = "0x2E5CC54", VA = "0x2E60C54")]
	public static Rect Window(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style)
	{
		return default(Rect);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2E60A44", Offset = "0x2E5CA44", VA = "0x2E60A44")]
	private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout)
	{
		return default(Rect);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2E60D34", Offset = "0x2E5CD34", VA = "0x2E60D34")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2E61720", Offset = "0x2E5D720", VA = "0x2E61720")]
	public static void DragWindow()
	{
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2E584EC", Offset = "0x2E544EC", VA = "0x2E584EC")]
	private static extern void get_color_Injected(out Color ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2E585AC", Offset = "0x2E545AC", VA = "0x2E585AC")]
	private static extern void set_color_Injected(ref Color value);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2E58670", Offset = "0x2E54670", VA = "0x2E58670")]
	private static extern void get_backgroundColor_Injected(out Color ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2E58730", Offset = "0x2E54730", VA = "0x2E58730")]
	private static extern void set_backgroundColor_Injected(ref Color value);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2E587F4", Offset = "0x2E547F4", VA = "0x2E587F4")]
	private static extern void get_contentColor_Injected(out Color ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2E588B4", Offset = "0x2E548B4", VA = "0x2E588B4")]
	private static extern void set_contentColor_Injected(ref Color value);

	[MethodImpl(4096)]
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2E58C30", Offset = "0x2E54C30", VA = "0x2E58C30")]
	private static extern void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret);

	[MethodImpl(4096)]
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2E58D50", Offset = "0x2E54D50", VA = "0x2E58D50")]
	private static extern void DragWindow_Injected(ref Rect position);
}
[Token(Token = "0x2000009")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUIState.h")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUIClip.h")]
internal sealed class GUIClip
{
	[Token(Token = "0x200000A")]
	internal struct ParentClipScope : IDisposable
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_Disposed;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2E61B60", Offset = "0x2E5DB60", VA = "0x2E61B60")]
		public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2E61BA4", Offset = "0x2E5DBA4", VA = "0x2E61BA4", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x1700002B")]
	internal static Rect visibleRect
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2E5D77C", Offset = "0x2E5977C", VA = "0x2E5D77C")]
		[UnityEngine.Bindings.FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2E6185C", Offset = "0x2E5D85C", VA = "0x2E6185C")]
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2E5EF38", Offset = "0x2E5AF38", VA = "0x2E5EF38")]
	internal static extern void Internal_Pop();

	[MethodImpl(4096)]
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2E6191C", Offset = "0x2E5D91C", VA = "0x2E6191C")]
	[UnityEngine.Bindings.FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
	internal static extern int Internal_GetCount();

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2E61944", Offset = "0x2E5D944", VA = "0x2E61944")]
	[UnityEngine.Bindings.FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.UnclipToWindow")]
	private static Vector2 UnclipToWindow_Vector2(Vector2 pos)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2E59608", Offset = "0x2E55608", VA = "0x2E59608")]
	[UnityEngine.Bindings.FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
	internal static Matrix4x4 GetMatrix()
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2E596B8", Offset = "0x2E556B8", VA = "0x2E596B8")]
	internal static void SetMatrix(Matrix4x4 m)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2E61A4C", Offset = "0x2E5DA4C", VA = "0x2E61A4C")]
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2E61A84", Offset = "0x2E5DA84", VA = "0x2E61A84")]
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2E61B34", Offset = "0x2E5DB34", VA = "0x2E61B34")]
	internal static extern void Internal_PopParentClip();

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2E5EEC8", Offset = "0x2E5AEC8", VA = "0x2E5EEC8")]
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2E608FC", Offset = "0x2E5C8FC", VA = "0x2E608FC")]
	internal static void Pop()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2E61B5C", Offset = "0x2E5DB5C", VA = "0x2E61B5C")]
	public static Vector2 UnclipToWindow(Vector2 pos)
	{
		return default(Vector2);
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2E61820", Offset = "0x2E5D820", VA = "0x2E61820")]
	private static extern void get_visibleRect_Injected(out Rect ret);

	[MethodImpl(4096)]
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x2E618C0", Offset = "0x2E5D8C0", VA = "0x2E618C0")]
	private static extern void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset);

	[MethodImpl(4096)]
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2E61990", Offset = "0x2E5D990", VA = "0x2E61990")]
	private static extern void UnclipToWindow_Vector2_Injected(ref Vector2 pos, out Vector2 ret);

	[MethodImpl(4096)]
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2E619D4", Offset = "0x2E5D9D4", VA = "0x2E619D4")]
	private static extern void GetMatrix_Injected(out Matrix4x4 ret);

	[MethodImpl(4096)]
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2E61A10", Offset = "0x2E5DA10", VA = "0x2E61A10")]
	private static extern void SetMatrix_Injected(ref Matrix4x4 m);

	[MethodImpl(4096)]
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x2E61AE0", Offset = "0x2E5DAE0", VA = "0x2E61AE0")]
	private static extern void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect);
}
[Serializable]
[StructLayout(0)]
[Token(Token = "0x200000B")]
[UnityEngine.Scripting.RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUIContent.h")]
public class GUIContent
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string m_Text;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Texture m_Image;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_Tooltip;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action OnTextChanged;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly GUIContent s_Text;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly GUIContent s_Image;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly GUIContent s_TextImage;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static GUIContent none;

	[Token(Token = "0x1700002C")]
	public string text
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2E5BA20", Offset = "0x2E57A20", VA = "0x2E5BA20")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2E5BF7C", Offset = "0x2E57F7C", VA = "0x2E5BF7C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public Texture image
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2E61BE4", Offset = "0x2E5DBE4", VA = "0x2E61BE4")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public string tooltip
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2E5D774", Offset = "0x2E59774", VA = "0x2E5D774")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2E61BEC", Offset = "0x2E5DBEC", VA = "0x2E61BEC")]
		set
		{
		}
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2E61BF4", Offset = "0x2E5DBF4", VA = "0x2E61BF4")]
	public GUIContent()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2E61C50", Offset = "0x2E5DC50", VA = "0x2E61C50")]
	public GUIContent(string text)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2E61CB4", Offset = "0x2E5DCB4", VA = "0x2E61CB4")]
	public GUIContent(string text, Texture image, string tooltip)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2E61D40", Offset = "0x2E5DD40", VA = "0x2E61D40")]
	public GUIContent(GUIContent src)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2E597C4", Offset = "0x2E557C4", VA = "0x2E597C4")]
	internal static GUIContent Temp(string t)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2E61DC8", Offset = "0x2E5DDC8", VA = "0x2E61DC8")]
	internal static void ClearStaticCache()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2E61E68", Offset = "0x2E5DE68", VA = "0x2E61E68", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200000C")]
public enum ScaleMode
{
	[Token(Token = "0x4000054")]
	StretchToFill,
	[Token(Token = "0x4000055")]
	ScaleAndCrop,
	[Token(Token = "0x4000056")]
	ScaleToFit
}
[Token(Token = "0x200000D")]
public enum FocusType
{
	[Token(Token = "0x4000058")]
	[Obsolete("FocusType.Native now behaves the same as FocusType.Passive in all OS cases. (UnityUpgradable) -> Passive", false)]
	Native,
	[Token(Token = "0x4000059")]
	Keyboard,
	[Token(Token = "0x400005A")]
	Passive
}
[Token(Token = "0x200000E")]
public class GUILayout
{
	[Token(Token = "0x200000F")]
	private sealed class LayoutedWindow
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly GUI.WindowFunction m_Func;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Rect m_ScreenRect;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly GUILayoutOption[] m_Options;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly GUIStyle m_Style;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2E64764", Offset = "0x2E60764", VA = "0x2E64764")]
		internal LayoutedWindow(GUI.WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2E647C8", Offset = "0x2E607C8", VA = "0x2E647C8")]
		public void DoWindow(int windowID)
		{
		}
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2E61F44", Offset = "0x2E5DF44", VA = "0x2E61F44")]
	public static void Label(string text, params GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2E620B8", Offset = "0x2E5E0B8", VA = "0x2E620B8")]
	public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2E61FEC", Offset = "0x2E5DFEC", VA = "0x2E61FEC")]
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2E62194", Offset = "0x2E5E194", VA = "0x2E62194")]
	public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x2E62198", Offset = "0x2E5E198", VA = "0x2E62198")]
	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2E62264", Offset = "0x2E5E264", VA = "0x2E62264")]
	public static bool Button(string text, params GUILayoutOption[] options)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2E623D8", Offset = "0x2E5E3D8", VA = "0x2E623D8")]
	public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2E62448", Offset = "0x2E5E448", VA = "0x2E62448")]
	public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x2E6230C", Offset = "0x2E5E30C", VA = "0x2E6230C")]
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2E6244C", Offset = "0x2E5E44C", VA = "0x2E6244C")]
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
	{
		return default(float);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x2E62450", Offset = "0x2E5E450", VA = "0x2E62450")]
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options)
	{
		return default(float);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x2E62594", Offset = "0x2E5E594", VA = "0x2E62594")]
	public static void Space(float pixels)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2E62934", Offset = "0x2E5E934", VA = "0x2E62934")]
	public static void FlexibleSpace()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2E62CF8", Offset = "0x2E5ECF8", VA = "0x2E62CF8")]
	public static void BeginHorizontal(params GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x2E62F3C", Offset = "0x2E5EF3C", VA = "0x2E62F3C")]
	public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x2E62D8C", Offset = "0x2E5ED8C", VA = "0x2E62D8C")]
	public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2E632F4", Offset = "0x2E5F2F4", VA = "0x2E632F4")]
	public static void EndHorizontal()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2E635C4", Offset = "0x2E5F5C4", VA = "0x2E635C4")]
	public static void BeginVertical(params GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2E63658", Offset = "0x2E5F658", VA = "0x2E63658")]
	public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2E6380C", Offset = "0x2E5F80C", VA = "0x2E6380C")]
	public static void EndVertical()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x2E63858", Offset = "0x2E5F858", VA = "0x2E63858")]
	public static void BeginArea(Rect screenRect)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x2E63B10", Offset = "0x2E5FB10", VA = "0x2E63B10")]
	public static void BeginArea(Rect screenRect, GUIStyle style)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x2E63914", Offset = "0x2E5F914", VA = "0x2E63914")]
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x2E63EB8", Offset = "0x2E5FEB8", VA = "0x2E63EB8")]
	public static void EndArea()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2E64150", Offset = "0x2E60150", VA = "0x2E64150")]
	public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2E6420C", Offset = "0x2E6020C", VA = "0x2E6420C")]
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2E64490", Offset = "0x2E60490", VA = "0x2E64490")]
	public static void EndScrollView()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2E64498", Offset = "0x2E60498", VA = "0x2E64498")]
	internal static void EndScrollView(bool handleScrollWheel)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x2E64514", Offset = "0x2E60514", VA = "0x2E64514")]
	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
	{
		return default(Rect);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x2E64604", Offset = "0x2E60604", VA = "0x2E64604")]
	private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
		return default(Rect);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x2E61138", Offset = "0x2E5D138", VA = "0x2E61138")]
	public static GUILayoutOption Width(float width)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x2E611CC", Offset = "0x2E5D1CC", VA = "0x2E611CC")]
	public static GUILayoutOption Height(float height)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x2E62C2C", Offset = "0x2E5EC2C", VA = "0x2E62C2C")]
	public static GUILayoutOption ExpandWidth(bool expand)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x2E62B90", Offset = "0x2E5EB90", VA = "0x2E62B90")]
	public static GUILayoutOption ExpandHeight(bool expand)
	{
		return null;
	}
}
[Token(Token = "0x2000010")]
public sealed class GUILayoutOption
{
	[Token(Token = "0x2000011")]
	internal enum Type
	{
		[Token(Token = "0x4000062")]
		fixedWidth,
		[Token(Token = "0x4000063")]
		fixedHeight,
		[Token(Token = "0x4000064")]
		minWidth,
		[Token(Token = "0x4000065")]
		maxWidth,
		[Token(Token = "0x4000066")]
		minHeight,
		[Token(Token = "0x4000067")]
		maxHeight,
		[Token(Token = "0x4000068")]
		stretchWidth,
		[Token(Token = "0x4000069")]
		stretchHeight,
		[Token(Token = "0x400006A")]
		alignStart,
		[Token(Token = "0x400006B")]
		alignMiddle,
		[Token(Token = "0x400006C")]
		alignEnd,
		[Token(Token = "0x400006D")]
		alignJustify,
		[Token(Token = "0x400006E")]
		equalSize,
		[Token(Token = "0x400006F")]
		spacing
	}

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal Type type;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal object value;

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x2E62CC8", Offset = "0x2E5ECC8", VA = "0x2E62CC8")]
	internal GUILayoutOption(Type type, object value)
	{
	}
}
[Token(Token = "0x2000012")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
public class GUILayoutUtility
{
	[Token(Token = "0x2000013")]
	[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
	internal sealed class LayoutCache
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal GUILayoutGroup topLevel;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal GenericStack layoutGroups;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal GUILayoutGroup windows;

		[Token(Token = "0x17000031")]
		private int id
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2E663A0", Offset = "0x2E623A0", VA = "0x2E663A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2E64C40", Offset = "0x2E60C40", VA = "0x2E64C40")]
		internal LayoutCache(int instanceID = -1)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2E663A8", Offset = "0x2E623A8", VA = "0x2E663A8")]
		public void ResetCursor()
		{
		}
	}

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<int, LayoutCache> s_StoredLayouts;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<int, LayoutCache> s_StoredWindows;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal static LayoutCache current;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal static readonly Rect kDummyRect;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static GUIStyle s_SpaceStyle;

	[Token(Token = "0x1700002F")]
	internal static int unbalancedgroupscount
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2E64AD4", Offset = "0x2E60AD4", VA = "0x2E64AD4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2E64B2C", Offset = "0x2E60B2C", VA = "0x2E64B2C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	internal static GUIStyle spaceStyle
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2E627BC", Offset = "0x2E5E7BC", VA = "0x2E627BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x2E64930", Offset = "0x2E60930", VA = "0x2E64930")]
	private static Rect Internal_GetWindowRect(int windowID)
	{
		return default(Rect);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x2E64A04", Offset = "0x2E60A04", VA = "0x2E64A04")]
	private static void Internal_MoveWindow(int windowID, Rect r)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x2E64B88", Offset = "0x2E60B88", VA = "0x2E64B88")]
	internal static LayoutCache GetLayoutCache(int instanceID, bool isWindow)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x2E61004", Offset = "0x2E5D004", VA = "0x2E61004")]
	internal static LayoutCache SelectIDList(int instanceID, bool isWindow)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x2E64D14", Offset = "0x2E60D14", VA = "0x2E64D14")]
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x2E64DF8", Offset = "0x2E60DF8", VA = "0x2E64DF8")]
	internal static void Begin(int instanceID)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x2E64FD0", Offset = "0x2E60FD0", VA = "0x2E64FD0")]
	internal static void BeginContainer(LayoutCache cache)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x2E61264", Offset = "0x2E5D264", VA = "0x2E61264")]
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x2E614E8", Offset = "0x2E5D4E8", VA = "0x2E614E8")]
	internal static void Layout()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x2E65484", Offset = "0x2E61484", VA = "0x2E65484")]
	internal static void LayoutFromEditorWindow()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x2E65694", Offset = "0x2E61694", VA = "0x2E65694")]
	internal static void LayoutFromContainer(float w, float h)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x2E65154", Offset = "0x2E61154", VA = "0x2E65154")]
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x2E6530C", Offset = "0x2E6130C", VA = "0x2E6530C")]
	private static void LayoutSingleGroup(GUILayoutGroup i)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x2E6581C", Offset = "0x2E6181C", VA = "0x2E6581C")]
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x2E62FAC", Offset = "0x2E5EFAC", VA = "0x2E62FAC")]
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType)
	{
		return null;
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2E63340", Offset = "0x2E5F340", VA = "0x2E63340")]
	internal static void EndLayoutGroup()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x2E63BA0", Offset = "0x2E5FBA0", VA = "0x2E63BA0")]
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x2E63FCC", Offset = "0x2E5FFCC", VA = "0x2E63FCC")]
	internal static void EndLayoutArea()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x2E62128", Offset = "0x2E5E128", VA = "0x2E62128")]
	public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		return default(Rect);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x2E65A38", Offset = "0x2E61A38", VA = "0x2E65A38")]
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
		return default(Rect);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x2E628B0", Offset = "0x2E5E8B0", VA = "0x2E628B0")]
	public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options)
	{
		return default(Rect);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x2E65F2C", Offset = "0x2E61F2C", VA = "0x2E65F2C")]
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options)
	{
		return default(Rect);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x2E660E8", Offset = "0x2E620E8", VA = "0x2E660E8")]
	public static Rect GetLastRect()
	{
		return default(Rect);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x2E649C0", Offset = "0x2E609C0", VA = "0x2E649C0")]
	private static extern void Internal_GetWindowRect_Injected(int windowID, out Rect ret);

	[MethodImpl(4096)]
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x2E64A90", Offset = "0x2E60A90", VA = "0x2E64A90")]
	private static extern void Internal_MoveWindow_Injected(int windowID, ref Rect r);
}
[Serializable]
[Token(Token = "0x2000014")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
public sealed class GUISettings
{
	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private bool m_DoubleClickSelectsWord;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[SerializeField]
	private bool m_TripleClickSelectsLine;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private Color m_CursorColor;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float m_CursorFlashSpeed;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Color m_SelectionColor;

	[Token(Token = "0x17000032")]
	public bool doubleClickSelectsWord
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2E5D188", Offset = "0x2E59188", VA = "0x2E5D188")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000033")]
	public bool tripleClickSelectsLine
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2E5D190", Offset = "0x2E59190", VA = "0x2E5D190")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000034")]
	public Color cursorColor
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2E66690", Offset = "0x2E62690", VA = "0x2E66690")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000035")]
	public float cursorFlashSpeed
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2E6669C", Offset = "0x2E6269C", VA = "0x2E6669C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000036")]
	public Color selectionColor
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2E666D4", Offset = "0x2E626D4", VA = "0x2E666D4")]
		get
		{
			return default(Color);
		}
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2E66668", Offset = "0x2E62668", VA = "0x2E66668")]
	private static extern float Internal_GetCursorFlashSpeed();

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x2E666E0", Offset = "0x2E626E0", VA = "0x2E666E0")]
	public GUISettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000015")]
[ExecuteInEditMode]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.AssetFileNameExtension("guiskin", new string[] { })]
public sealed class GUISkin : ScriptableObject
{
	[Token(Token = "0x2000016")]
	internal delegate void SkinChangedDelegate();

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Font m_Font;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GUIStyle m_box;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GUIStyle m_button;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GUIStyle m_toggle;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GUIStyle m_label;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GUIStyle m_textField;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GUIStyle m_textArea;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GUIStyle m_window;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GUIStyle m_horizontalSlider;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GUIStyle m_horizontalSliderThumb;

	[NonSerialized]
	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GUIStyle m_horizontalSliderThumbExtent;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GUIStyle m_verticalSlider;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GUIStyle m_verticalSliderThumb;

	[NonSerialized]
	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GUIStyle m_verticalSliderThumbExtent;

	[NonSerialized]
	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GUIStyle m_SliderMixed;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GUIStyle m_horizontalScrollbar;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GUIStyle m_horizontalScrollbarThumb;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GUIStyle m_horizontalScrollbarLeftButton;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GUIStyle m_horizontalScrollbarRightButton;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private GUIStyle m_verticalScrollbar;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GUIStyle m_verticalScrollbarThumb;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GUIStyle m_verticalScrollbarUpButton;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GUIStyle m_verticalScrollbarDownButton;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GUIStyle m_ScrollView;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	internal GUIStyle[] m_CustomStyles;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private GUISettings m_Settings;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static GUIStyle ms_Error;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Dictionary<string, GUIStyle> m_Styles;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	internal static SkinChangedDelegate m_SkinChanged;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal static GUISkin current;

	[Token(Token = "0x17000037")]
	public Font font
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2E5D1D4", Offset = "0x2E591D4", VA = "0x2E5D1D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2E6688C", Offset = "0x2E6288C", VA = "0x2E6688C")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public GUIStyle box
	{
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2E5ABAC", Offset = "0x2E56BAC", VA = "0x2E5ABAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2E669B0", Offset = "0x2E629B0", VA = "0x2E669B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public GUIStyle label
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2E59850", Offset = "0x2E55850", VA = "0x2E59850")]
		get
		{
			return null;
		}
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2E669B8", Offset = "0x2E629B8", VA = "0x2E669B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public GUIStyle textField
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2E669C0", Offset = "0x2E629C0", VA = "0x2E669C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2E669C8", Offset = "0x2E629C8", VA = "0x2E669C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public GUIStyle textArea
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2E669D0", Offset = "0x2E629D0", VA = "0x2E669D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2E669D8", Offset = "0x2E629D8", VA = "0x2E669D8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public GUIStyle button
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2E5AFBC", Offset = "0x2E56FBC", VA = "0x2E5AFBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2E669E0", Offset = "0x2E629E0", VA = "0x2E669E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public GUIStyle toggle
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2E669E8", Offset = "0x2E629E8", VA = "0x2E669E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2E669F0", Offset = "0x2E629F0", VA = "0x2E669F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public GUIStyle window
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2E60A3C", Offset = "0x2E5CA3C", VA = "0x2E60A3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2E669F8", Offset = "0x2E629F8", VA = "0x2E669F8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003F")]
	public GUIStyle horizontalSlider
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2E66A00", Offset = "0x2E62A00", VA = "0x2E66A00")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2E66A08", Offset = "0x2E62A08", VA = "0x2E66A08")]
		set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public GUIStyle horizontalSliderThumb
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2E66A10", Offset = "0x2E62A10", VA = "0x2E66A10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2E66A18", Offset = "0x2E62A18", VA = "0x2E66A18")]
		set
		{
		}
	}

	[Token(Token = "0x17000041")]
	internal GUIStyle horizontalSliderThumbExtent
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2E66A20", Offset = "0x2E62A20", VA = "0x2E66A20")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2E66A28", Offset = "0x2E62A28", VA = "0x2E66A28")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	internal GUIStyle sliderMixed
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2E66A30", Offset = "0x2E62A30", VA = "0x2E66A30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2E66A38", Offset = "0x2E62A38", VA = "0x2E66A38")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public GUIStyle verticalSlider
	{
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2E66A40", Offset = "0x2E62A40", VA = "0x2E66A40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2E66A48", Offset = "0x2E62A48", VA = "0x2E66A48")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public GUIStyle verticalSliderThumb
	{
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2E66A50", Offset = "0x2E62A50", VA = "0x2E66A50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2E66A58", Offset = "0x2E62A58", VA = "0x2E66A58")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	internal GUIStyle verticalSliderThumbExtent
	{
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2E66A60", Offset = "0x2E62A60", VA = "0x2E66A60")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2E66A68", Offset = "0x2E62A68", VA = "0x2E66A68")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public GUIStyle horizontalScrollbar
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2E641F4", Offset = "0x2E601F4", VA = "0x2E641F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2E66A70", Offset = "0x2E62A70", VA = "0x2E66A70")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public GUIStyle horizontalScrollbarThumb
	{
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2E66A78", Offset = "0x2E62A78", VA = "0x2E66A78")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2E66A80", Offset = "0x2E62A80", VA = "0x2E66A80")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public GUIStyle horizontalScrollbarLeftButton
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2E66A88", Offset = "0x2E62A88", VA = "0x2E66A88")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2E66A90", Offset = "0x2E62A90", VA = "0x2E66A90")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public GUIStyle horizontalScrollbarRightButton
	{
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2E66A98", Offset = "0x2E62A98", VA = "0x2E66A98")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2E66AA0", Offset = "0x2E62AA0", VA = "0x2E66AA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public GUIStyle verticalScrollbar
	{
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2E641FC", Offset = "0x2E601FC", VA = "0x2E641FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2E66AA8", Offset = "0x2E62AA8", VA = "0x2E66AA8")]
		set
		{
		}
	}

	[Token(Token = "0x1700004B")]
	public GUIStyle verticalScrollbarThumb
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2E66AB0", Offset = "0x2E62AB0", VA = "0x2E66AB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2E66AB8", Offset = "0x2E62AB8", VA = "0x2E66AB8")]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public GUIStyle verticalScrollbarUpButton
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2E66AC0", Offset = "0x2E62AC0", VA = "0x2E66AC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2E66AC8", Offset = "0x2E62AC8", VA = "0x2E66AC8")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public GUIStyle verticalScrollbarDownButton
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2E66AD0", Offset = "0x2E62AD0", VA = "0x2E66AD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2E66AD8", Offset = "0x2E62AD8", VA = "0x2E66AD8")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public GUIStyle scrollView
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2E64204", Offset = "0x2E60204", VA = "0x2E64204")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2E66AE0", Offset = "0x2E62AE0", VA = "0x2E66AE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public GUIStyle[] customStyles
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2E66AE8", Offset = "0x2E62AE8", VA = "0x2E66AE8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2E66AF0", Offset = "0x2E62AF0", VA = "0x2E66AF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public GUISettings settings
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2E5D180", Offset = "0x2E59180", VA = "0x2E5D180")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000051")]
	internal static GUIStyle error
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2E66AF8", Offset = "0x2E62AF8", VA = "0x2E66AF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2E6670C", Offset = "0x2E6270C", VA = "0x2E6670C")]
	public GUISkin()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2E667C0", Offset = "0x2E627C0", VA = "0x2E667C0")]
	internal void OnEnable()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x2E66840", Offset = "0x2E62840", VA = "0x2E66840")]
	internal static void CleanupRoots()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x2E667C4", Offset = "0x2E627C4", VA = "0x2E667C4")]
	internal void Apply()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x2E66C2C", Offset = "0x2E62C2C", VA = "0x2E66C2C")]
	private void BuildStyleCache()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x2E5DD70", Offset = "0x2E59D70", VA = "0x2E5DD70")]
	public GUIStyle GetStyle(string styleName)
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x2E67BD4", Offset = "0x2E63BD4", VA = "0x2E67BD4")]
	public GUIStyle FindStyle(string styleName)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x2E594CC", Offset = "0x2E554CC", VA = "0x2E594CC")]
	internal void MakeCurrent()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x2E67C5C", Offset = "0x2E63C5C", VA = "0x2E67C5C")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
[Token(Token = "0x2000017")]
internal class GUIStateObjects
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<int, object> s_StateCache;

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x2E67DB8", Offset = "0x2E63DB8", VA = "0x2E67DB8")]
	internal static object GetStateObject(Type t, int controlID)
	{
		return null;
	}
}
[Serializable]
[StructLayout(0)]
[Token(Token = "0x2000018")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
public sealed class GUIStyleState
{
	[NonSerialized]
	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal IntPtr m_Ptr;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GUIStyle m_SourceStyle;

	[Token(Token = "0x17000052")]
	[UnityEngine.Bindings.NativeProperty("Background", false, UnityEngine.Bindings.TargetType.Function)]
	public extern Texture2D background
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2E67F8C", Offset = "0x2E63F8C", VA = "0x2E67F8C")]
		set;
	}

	[Token(Token = "0x17000053")]
	[UnityEngine.Bindings.NativeProperty("textColor", false, UnityEngine.Bindings.TargetType.Field)]
	public Color textColor
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2E67B80", Offset = "0x2E63B80", VA = "0x2E67B80")]
		set
		{
		}
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x2E68014", Offset = "0x2E64014", VA = "0x2E68014")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = true)]
	private static extern IntPtr Init();

	[MethodImpl(4096)]
	[Token(Token = "0x600014B")]
	[Address(RVA = "0x2E6803C", Offset = "0x2E6403C", VA = "0x2E6803C")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
	private extern void Cleanup();

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x2E68078", Offset = "0x2E64078", VA = "0x2E68078")]
	public GUIStyleState()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x2E680BC", Offset = "0x2E640BC", VA = "0x2E680BC")]
	private GUIStyleState(GUIStyle sourceStyle, IntPtr source)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x2E680E8", Offset = "0x2E640E8", VA = "0x2E680E8")]
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x2E68150", Offset = "0x2E64150", VA = "0x2E68150", Slot = "1")]
	~GUIStyleState()
	{
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x2E67FD0", Offset = "0x2E63FD0", VA = "0x2E67FD0")]
	private extern void set_textColor_Injected(ref Color value);
}
[Serializable]
[StructLayout(0)]
[Token(Token = "0x2000019")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[UnityEngine.Bindings.NativeHeader("IMGUIScriptingClasses.h")]
public sealed class GUIStyle
{
	[NonSerialized]
	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal IntPtr m_Ptr;

	[NonSerialized]
	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GUIStyleState m_Normal;

	[NonSerialized]
	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GUIStyleState m_Hover;

	[NonSerialized]
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GUIStyleState m_Active;

	[NonSerialized]
	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GUIStyleState m_Focused;

	[NonSerialized]
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GUIStyleState m_OnNormal;

	[NonSerialized]
	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GUIStyleState m_OnHover;

	[NonSerialized]
	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GUIStyleState m_OnActive;

	[NonSerialized]
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GUIStyleState m_OnFocused;

	[NonSerialized]
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private RectOffset m_Border;

	[NonSerialized]
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private RectOffset m_Padding;

	[NonSerialized]
	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private RectOffset m_Margin;

	[NonSerialized]
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private RectOffset m_Overflow;

	[NonSerialized]
	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string m_Name;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static bool showKeyboardFocus;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GUIStyle s_None;

	[Token(Token = "0x17000054")]
	[UnityEngine.Bindings.NativeProperty("Name", false, UnityEngine.Bindings.TargetType.Function)]
	internal extern string rawName
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2E68214", Offset = "0x2E64214", VA = "0x2E68214")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2E68250", Offset = "0x2E64250", VA = "0x2E68250")]
		set;
	}

	[Token(Token = "0x17000055")]
	[UnityEngine.Bindings.NativeProperty("Font", false, UnityEngine.Bindings.TargetType.Function)]
	public extern Font font
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2E5D198", Offset = "0x2E59198", VA = "0x2E5D198")]
		get;
	}

	[Token(Token = "0x17000056")]
	[UnityEngine.Bindings.NativeProperty("m_ImagePosition", false, UnityEngine.Bindings.TargetType.Field)]
	public extern ImagePosition imagePosition
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2E68294", Offset = "0x2E64294", VA = "0x2E68294")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2E682D0", Offset = "0x2E642D0", VA = "0x2E682D0")]
		set;
	}

	[Token(Token = "0x17000057")]
	[UnityEngine.Bindings.NativeProperty("m_Alignment", false, UnityEngine.Bindings.TargetType.Field)]
	public extern TextAnchor alignment
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2E68314", Offset = "0x2E64314", VA = "0x2E68314")]
		set;
	}

	[Token(Token = "0x17000058")]
	[UnityEngine.Bindings.NativeProperty("m_WordWrap", false, UnityEngine.Bindings.TargetType.Field)]
	public extern bool wordWrap
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2E68358", Offset = "0x2E64358", VA = "0x2E68358")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2E68394", Offset = "0x2E64394", VA = "0x2E68394")]
		set;
	}

	[Token(Token = "0x17000059")]
	[UnityEngine.Bindings.NativeProperty("m_Clipping", false, UnityEngine.Bindings.TargetType.Field)]
	public extern TextClipping clipping
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2E683D8", Offset = "0x2E643D8", VA = "0x2E683D8")]
		set;
	}

	[Token(Token = "0x1700005A")]
	[UnityEngine.Bindings.NativeProperty("m_ContentOffset", false, UnityEngine.Bindings.TargetType.Field)]
	public Vector2 contentOffset
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2E6841C", Offset = "0x2E6441C", VA = "0x2E6841C")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2E684AC", Offset = "0x2E644AC", VA = "0x2E684AC")]
		set
		{
		}
	}

	[Token(Token = "0x1700005B")]
	[UnityEngine.Bindings.NativeProperty("m_FixedWidth", false, UnityEngine.Bindings.TargetType.Field)]
	public extern float fixedWidth
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2E5E9D4", Offset = "0x2E5A9D4", VA = "0x2E5E9D4")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2E68538", Offset = "0x2E64538", VA = "0x2E68538")]
		set;
	}

	[Token(Token = "0x1700005C")]
	[UnityEngine.Bindings.NativeProperty("m_FixedHeight", false, UnityEngine.Bindings.TargetType.Field)]
	public extern float fixedHeight
	{
		[MethodImpl(4096)]
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2E5EA10", Offset = "0x2E5AA10", VA = "0x2E5EA10")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2E68584", Offset = "0x2E64584", VA = "0x2E68584")]
		set;
	}

	[Token(Token = "0x1700005D")]
	[UnityEngine.Bindings.NativeProperty("m_StretchWidth", false, UnityEngine.Bindings.TargetType.Field)]
	public extern bool stretchWidth
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2E685D0", Offset = "0x2E645D0", VA = "0x2E685D0")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2E66270", Offset = "0x2E62270", VA = "0x2E66270")]
		set;
	}

	[Token(Token = "0x1700005E")]
	[UnityEngine.Bindings.NativeProperty("m_StretchHeight", false, UnityEngine.Bindings.TargetType.Field)]
	public extern bool stretchHeight
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2E6860C", Offset = "0x2E6460C", VA = "0x2E6860C")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2E67AE0", Offset = "0x2E63AE0", VA = "0x2E67AE0")]
		set;
	}

	[Token(Token = "0x1700005F")]
	[UnityEngine.Bindings.NativeProperty("m_FontSize", false, UnityEngine.Bindings.TargetType.Field)]
	public extern int fontSize
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2E68648", Offset = "0x2E64648", VA = "0x2E68648")]
		set;
	}

	[Token(Token = "0x17000060")]
	[UnityEngine.Bindings.NativeProperty("m_FontStyle", false, UnityEngine.Bindings.TargetType.Field)]
	public extern FontStyle fontStyle
	{
		[MethodImpl(4096)]
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2E6868C", Offset = "0x2E6468C", VA = "0x2E6868C")]
		set;
	}

	[Token(Token = "0x17000061")]
	[UnityEngine.Bindings.NativeProperty("m_ClipOffset", false, UnityEngine.Bindings.TargetType.Field)]
	internal Vector2 Internal_clipOffset
	{
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2E686D0", Offset = "0x2E646D0", VA = "0x2E686D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000062")]
	public string name
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2E5DD24", Offset = "0x2E59D24", VA = "0x2E5DD24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2E66BE4", Offset = "0x2E62BE4", VA = "0x2E66BE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000063")]
	public GUIStyleState normal
	{
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2E67B24", Offset = "0x2E63B24", VA = "0x2E67B24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000064")]
	public GUIStyleState hover
	{
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2E694E4", Offset = "0x2E654E4", VA = "0x2E694E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000065")]
	public GUIStyleState active
	{
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2E69540", Offset = "0x2E65540", VA = "0x2E69540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000066")]
	public RectOffset border
	{
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2E6959C", Offset = "0x2E6559C", VA = "0x2E6959C")]
		set
		{
		}
	}

	[Token(Token = "0x17000067")]
	public RectOffset margin
	{
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2E5FB28", Offset = "0x2E5BB28", VA = "0x2E5FB28")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2E695EC", Offset = "0x2E655EC", VA = "0x2E695EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000068")]
	public RectOffset padding
	{
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2E6963C", Offset = "0x2E6563C", VA = "0x2E6963C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2E696DC", Offset = "0x2E656DC", VA = "0x2E696DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000069")]
	public float lineHeight
	{
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2E6972C", Offset = "0x2E6572C", VA = "0x2E6972C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700006A")]
	public static GUIStyle none
	{
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2E5EDF0", Offset = "0x2E5ADF0", VA = "0x2E5EDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006B")]
	public bool isHeightDependantOnWidth
	{
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2E65DA8", Offset = "0x2E61DA8", VA = "0x2E65DA8")]
		get
		{
			return default(bool);
		}
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x2E6875C", Offset = "0x2E6475C", VA = "0x2E6875C")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = true)]
	private static extern IntPtr Internal_Create(GUIStyle self);

	[MethodImpl(4096)]
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x2E68798", Offset = "0x2E64798", VA = "0x2E68798")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = true)]
	private static extern IntPtr Internal_Copy(GUIStyle self, GUIStyle other);

	[MethodImpl(4096)]
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x2E687DC", Offset = "0x2E647DC", VA = "0x2E687DC")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = true)]
	private static extern void Internal_Destroy(IntPtr self);

	[MethodImpl(4096)]
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x2E68818", Offset = "0x2E64818", VA = "0x2E68818")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = true, HasExplicitThis = true)]
	private extern IntPtr GetStyleStatePtr(int idx);

	[MethodImpl(4096)]
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x2E6885C", Offset = "0x2E6485C", VA = "0x2E6885C")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = true)]
	private extern IntPtr GetRectOffsetPtr(int idx);

	[MethodImpl(4096)]
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x2E688A0", Offset = "0x2E648A0", VA = "0x2E688A0")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::AssignRectOffset", HasExplicitThis = true)]
	private extern void AssignRectOffset(int idx, IntPtr srcRectOffset);

	[MethodImpl(4096)]
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x2E688F4", Offset = "0x2E648F4", VA = "0x2E688F4")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_GetLineHeight")]
	private static extern float Internal_GetLineHeight(IntPtr target);

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x2E68930", Offset = "0x2E64930", VA = "0x2E68930")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = true)]
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x2E68A40", Offset = "0x2E64A40", VA = "0x2E68A40")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = true)]
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x2E68B20", Offset = "0x2E64B20", VA = "0x2E68B20")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawCursor", HasExplicitThis = true)]
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x2E68C04", Offset = "0x2E64C04", VA = "0x2E68C04")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawWithTextSelection", HasExplicitThis = true)]
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x2E68D94", Offset = "0x2E64D94", VA = "0x2E68D94")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorPixelPosition", HasExplicitThis = true)]
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x2E68E74", Offset = "0x2E64E74", VA = "0x2E68E74")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorStringIndex", HasExplicitThis = true)]
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
	{
		return default(int);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x2E68F34", Offset = "0x2E64F34", VA = "0x2E68F34")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_GetSelectedRenderedText", HasExplicitThis = true)]
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex)
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x2E69014", Offset = "0x2E65014", VA = "0x2E69014")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = true)]
	internal Vector2 Internal_CalcSize(GUIContent content)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x2E690C4", Offset = "0x2E650C4", VA = "0x2E690C4")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = true)]
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
	{
		return default(Vector2);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x2E69184", Offset = "0x2E65184", VA = "0x2E69184")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = true)]
	private extern float Internal_CalcHeight(GUIContent content, float width);

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x2E691D8", Offset = "0x2E651D8", VA = "0x2E691D8")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = true)]
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x2E5D800", Offset = "0x2E59800", VA = "0x2E5D800")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	internal static void SetMouseTooltip(string tooltip, Rect screenRect)
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x2E5D7C4", Offset = "0x2E597C4", VA = "0x2E5D7C4")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	internal static extern bool IsTooltipActive(string tooltip);

	[MethodImpl(4096)]
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x2E692CC", Offset = "0x2E652CC", VA = "0x2E692CC")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorFlashOffset")]
	private static extern float Internal_GetCursorFlashOffset();

	[MethodImpl(4096)]
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x2E66974", Offset = "0x2E62974", VA = "0x2E66974")]
	[UnityEngine.Bindings.FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	internal static extern void SetDefaultFont(Font font);

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x2E661E8", Offset = "0x2E621E8", VA = "0x2E661E8")]
	public GUIStyle()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x2E692F4", Offset = "0x2E652F4", VA = "0x2E692F4")]
	public GUIStyle(GUIStyle other)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x2E693D4", Offset = "0x2E653D4", VA = "0x2E693D4", Slot = "1")]
	~GUIStyle()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x2E5FBC8", Offset = "0x2E5BBC8", VA = "0x2E5FBC8")]
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x2E5D770", Offset = "0x2E59770", VA = "0x2E5D770")]
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x2E5EE78", Offset = "0x2E5AE78", VA = "0x2E5EE78")]
	public void Draw(Rect position, GUIContent content, int controlID)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x2E5D16C", Offset = "0x2E5916C", VA = "0x2E5D16C")]
	public void Draw(Rect position, GUIContent content, int controlID, bool on)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x2E5AE1C", Offset = "0x2E56E1C", VA = "0x2E5AE1C")]
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x2E69828", Offset = "0x2E65828", VA = "0x2E69828")]
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x2E6990C", Offset = "0x2E6590C", VA = "0x2E6990C")]
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x2E69B24", Offset = "0x2E65B24", VA = "0x2E69B24")]
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x2E69DA8", Offset = "0x2E65DA8", VA = "0x2E69DA8")]
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x2E69F04", Offset = "0x2E65F04", VA = "0x2E69F04")]
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x2E69F0C", Offset = "0x2E65F0C", VA = "0x2E69F0C")]
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x2E69F10", Offset = "0x2E65F10", VA = "0x2E69F10")]
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
	{
		return default(int);
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x2E69F14", Offset = "0x2E65F14", VA = "0x2E69F14")]
	public Vector2 CalcSize(GUIContent content)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x2E65E54", Offset = "0x2E61E54", VA = "0x2E65E54")]
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x2E69F18", Offset = "0x2E65F18", VA = "0x2E69F18")]
	public float CalcHeight(GUIContent content, float width)
	{
		return default(float);
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x2E69F6C", Offset = "0x2E65F6C", VA = "0x2E69F6C")]
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x2E69F94", Offset = "0x2E65F94", VA = "0x2E69F94", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x2E68468", Offset = "0x2E64468", VA = "0x2E68468")]
	private extern void get_contentOffset_Injected(out Vector2 ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x2E684F4", Offset = "0x2E644F4", VA = "0x2E684F4")]
	private extern void set_contentOffset_Injected(ref Vector2 value);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x2E68718", Offset = "0x2E64718", VA = "0x2E68718")]
	private extern void set_Internal_clipOffset_Injected(ref Vector2 value);

	[MethodImpl(4096)]
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x2E689BC", Offset = "0x2E649BC", VA = "0x2E689BC")]
	private extern void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);

	[MethodImpl(4096)]
	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x2E68AB4", Offset = "0x2E64AB4", VA = "0x2E68AB4")]
	private extern void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on);

	[MethodImpl(4096)]
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x2E68B98", Offset = "0x2E64B98", VA = "0x2E68B98")]
	private extern void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor);

	[MethodImpl(4096)]
	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x2E68CD4", Offset = "0x2E64CD4", VA = "0x2E68CD4")]
	private extern void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor);

	[MethodImpl(4096)]
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x2E68E08", Offset = "0x2E64E08", VA = "0x2E68E08")]
	private extern void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret);

	[MethodImpl(4096)]
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x2E68ED8", Offset = "0x2E64ED8", VA = "0x2E68ED8")]
	private extern int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition);

	[MethodImpl(4096)]
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x2E68FA8", Offset = "0x2E64FA8", VA = "0x2E68FA8")]
	private extern string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex);

	[MethodImpl(4096)]
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x2E69070", Offset = "0x2E65070", VA = "0x2E69070")]
	private extern void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret);

	[MethodImpl(4096)]
	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x2E69128", Offset = "0x2E65128", VA = "0x2E69128")]
	private extern void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret);

	[MethodImpl(4096)]
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x2E69234", Offset = "0x2E65234", VA = "0x2E69234")]
	private extern void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret);

	[MethodImpl(4096)]
	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x2E69288", Offset = "0x2E65288", VA = "0x2E69288")]
	private static extern void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect);
}
[Token(Token = "0x200001A")]
public enum ImagePosition
{
	[Token(Token = "0x40000B1")]
	ImageLeft,
	[Token(Token = "0x40000B2")]
	ImageAbove,
	[Token(Token = "0x40000B3")]
	ImageOnly,
	[Token(Token = "0x40000B4")]
	TextOnly
}
[Token(Token = "0x200001B")]
public enum TextClipping
{
	[Token(Token = "0x40000B6")]
	Overflow,
	[Token(Token = "0x40000B7")]
	Clip
}
[Token(Token = "0x200001C")]
[AttributeUsage(AttributeTargets.Method)]
public class GUITargetAttribute : Attribute
{
	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal int displayMask;

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x2E6A0C4", Offset = "0x2E660C4", VA = "0x2E6A0C4")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static int GetGUITargetAttrValue(Type klass, string methodName)
	{
		return default(int);
	}
}
[Token(Token = "0x200001D")]
[UnityEngine.Bindings.NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUIUtility.h")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUIManager.h")]
[UnityEngine.Bindings.NativeHeader("Runtime/Utilities/CopyPaste.h")]
[UnityEngine.Bindings.NativeHeader("Runtime/Input/InputManager.h")]
[UnityEngine.Bindings.NativeHeader("Runtime/Input/InputBindings.h")]
public class GUIUtility
{
	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static int s_ControlCount;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	internal static int s_SkinMode;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	internal static int s_OriginalID;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal static Action takeCapture;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal static Action releaseCapture;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal static Func<int, IntPtr, bool> processEvent;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal static Action cleanupRoots;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal static Func<Exception, bool> endContainerGUIFromException;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal static Action guiChanged;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	internal static Action<EventType, KeyCode> beforeEventProcessed;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Event m_Event;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc;

	[Token(Token = "0x1700006C")]
	[UnityEngine.Bindings.NativeProperty("GetGUIState().m_PixelsPerPoint", true, UnityEngine.Bindings.TargetType.Field)]
	internal static extern float pixelsPerPoint
	{
		[MethodImpl(4096)]
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2E6512C", Offset = "0x2E6112C", VA = "0x2E6512C")]
		get;
	}

	[Token(Token = "0x1700006D")]
	[UnityEngine.Bindings.NativeProperty("GetGUIState().m_OnGUIDepth", true, UnityEngine.Bindings.TargetType.Field)]
	internal static extern int guiDepth
	{
		[MethodImpl(4096)]
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2E6A25C", Offset = "0x2E6625C", VA = "0x2E6A25C")]
		get;
	}

	[Token(Token = "0x1700006E")]
	[UnityEngine.Bindings.NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", true, UnityEngine.Bindings.TargetType.Field)]
	internal static extern bool mouseUsed
	{
		[MethodImpl(4096)]
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2E5EE8C", Offset = "0x2E5AE8C", VA = "0x2E5EE8C")]
		set;
	}

	[Token(Token = "0x1700006F")]
	[UnityEngine.Bindings.StaticAccessor("GetInputManager()", UnityEngine.Bindings.StaticAccessorType.Dot)]
	internal static extern bool textFieldInput
	{
		[MethodImpl(4096)]
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2E5843C", Offset = "0x2E5443C", VA = "0x2E5843C")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2E5D204", Offset = "0x2E59204", VA = "0x2E5D204")]
		set;
	}

	[Token(Token = "0x17000070")]
	public static extern string systemCopyBuffer
	{
		[MethodImpl(4096)]
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2E6A284", Offset = "0x2E66284", VA = "0x2E6A284")]
		[UnityEngine.Bindings.FreeFunction("GetCopyBuffer")]
		get;
		[MethodImpl(4096)]
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2E6A2AC", Offset = "0x2E662AC", VA = "0x2E6A2AC")]
		[UnityEngine.Bindings.FreeFunction("SetCopyBuffer")]
		set;
	}

	[Token(Token = "0x17000071")]
	[UnityEngine.Bindings.StaticAccessor("InputBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	internal static extern string compositionString
	{
		[MethodImpl(4096)]
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2E5D1DC", Offset = "0x2E591DC", VA = "0x2E5D1DC")]
		get;
	}

	[Token(Token = "0x17000072")]
	[UnityEngine.Bindings.StaticAccessor("InputBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	internal static extern IMECompositionMode imeCompositionMode
	{
		[MethodImpl(4096)]
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2E6A670", Offset = "0x2E66670", VA = "0x2E6A670")]
		set;
	}

	[Token(Token = "0x17000073")]
	[UnityEngine.Bindings.StaticAccessor("InputBindings", UnityEngine.Bindings.StaticAccessorType.DoubleColon)]
	internal static Vector2 compositionCursorPos
	{
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2E6A6AC", Offset = "0x2E666AC", VA = "0x2E6A6AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	internal static bool guiIsExiting
	{
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2E6A900", Offset = "0x2E66900", VA = "0x2E6A900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public static int hotControl
	{
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2E5B750", Offset = "0x2E57750", VA = "0x2E5B750")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2E5B6DC", Offset = "0x2E576DC", VA = "0x2E5B6DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000076")]
	public static int keyboardControl
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2E5D090", Offset = "0x2E59090", VA = "0x2E5D090")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2E5D0F8", Offset = "0x2E590F8", VA = "0x2E5D0F8")]
		set
		{
		}
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x2E6A2E8", Offset = "0x2E662E8", VA = "0x2E6A2E8")]
	[UnityEngine.Bindings.FreeFunction("GetGUIState().GetControlID")]
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect)
	{
		return default(int);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x2E5B0A8", Offset = "0x2E570A8", VA = "0x2E5B0A8")]
	public static int GetControlID(int hint, FocusType focusType, Rect rect)
	{
		return default(int);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x2E6A3D8", Offset = "0x2E663D8", VA = "0x2E6A3D8")]
	internal static extern void BeginContainerFromOwner(ScriptableObject owner);

	[MethodImpl(4096)]
	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x2E6A414", Offset = "0x2E66414", VA = "0x2E6A414")]
	internal static extern void BeginContainer(ObjectGUIState objectGUIState);

	[MethodImpl(4096)]
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x2E6A450", Offset = "0x2E66450", VA = "0x2E6A450")]
	[UnityEngine.Bindings.NativeMethod("EndContainer")]
	internal static extern void Internal_EndContainer();

	[MethodImpl(4096)]
	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x2E6A478", Offset = "0x2E66478", VA = "0x2E6A478")]
	internal static extern int CheckForTabEvent(Event evt);

	[MethodImpl(4096)]
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x2E6A4B4", Offset = "0x2E664B4", VA = "0x2E6A4B4")]
	internal static extern void SetKeyboardControlToFirstControlId();

	[MethodImpl(4096)]
	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x2E6A4DC", Offset = "0x2E664DC", VA = "0x2E6A4DC")]
	internal static extern void SetKeyboardControlToLastControlId();

	[MethodImpl(4096)]
	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x2E6A504", Offset = "0x2E66504", VA = "0x2E6A504")]
	internal static extern bool HasFocusableControls();

	[MethodImpl(4096)]
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x2E6A52C", Offset = "0x2E6652C", VA = "0x2E6A52C")]
	internal static extern bool OwnsId(int id);

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x2E6A568", Offset = "0x2E66568", VA = "0x2E6A568")]
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels)
	{
		return default(Rect);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x2E6A760", Offset = "0x2E66760", VA = "0x2E6A760")]
	private static extern int Internal_GetHotControl();

	[MethodImpl(4096)]
	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x2E6A788", Offset = "0x2E66788", VA = "0x2E6A788")]
	private static extern int Internal_GetKeyboardControl();

	[MethodImpl(4096)]
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x2E6A7B0", Offset = "0x2E667B0", VA = "0x2E6A7B0")]
	private static extern void Internal_SetHotControl(int value);

	[MethodImpl(4096)]
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x2E6A7EC", Offset = "0x2E667EC", VA = "0x2E6A7EC")]
	private static extern void Internal_SetKeyboardControl(int value);

	[MethodImpl(4096)]
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x2E6A828", Offset = "0x2E66828", VA = "0x2E6A828")]
	private static extern object Internal_GetDefaultSkin(int skinMode);

	[MethodImpl(4096)]
	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x2E6A864", Offset = "0x2E66864", VA = "0x2E6A864")]
	private static extern void Internal_ExitGUI();

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x2E6A88C", Offset = "0x2E6688C", VA = "0x2E6A88C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void MarkGUIChanged()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x2E5B8E0", Offset = "0x2E578E0", VA = "0x2E5B8E0")]
	public static int GetControlID(FocusType focus, Rect position)
	{
		return default(int);
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x2E5AD80", Offset = "0x2E56D80", VA = "0x2E5AD80")]
	public static int GetControlID(int hint, FocusType focus)
	{
		return default(int);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x2E5BFD4", Offset = "0x2E57FD4", VA = "0x2E5BFD4")]
	public static object GetStateObject(Type t, int controlID)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x2E6A960", Offset = "0x2E66960", VA = "0x2E6A960")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void TakeCapture()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x2E6A9D4", Offset = "0x2E669D4", VA = "0x2E6A9D4")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void RemoveCapture()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x2E6984C", Offset = "0x2E6584C", VA = "0x2E6984C")]
	internal static bool HasKeyFocus(int controlID)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x2E6AA48", Offset = "0x2E66A48", VA = "0x2E6AA48")]
	public static void ExitGUI()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x2E59424", Offset = "0x2E55424", VA = "0x2E59424")]
	internal static GUISkin GetDefaultSkin()
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2E6AB3C", Offset = "0x2E66B3C", VA = "0x2E6AB3C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x2E6ACFC", Offset = "0x2E66CFC", VA = "0x2E6ACFC")]
	internal static void EndContainer()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2E6AD84", Offset = "0x2E66D84", VA = "0x2E6AD84")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x2E6AF5C", Offset = "0x2E66F5C", VA = "0x2E6AF5C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void DestroyGUI(int instanceID)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x2E6AFB4", Offset = "0x2E66FB4", VA = "0x2E6AFB4")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static void EndGUI(int layoutType)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x2E6B1B4", Offset = "0x2E671B4", VA = "0x2E6B1B4")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static bool EndGUIFromException(Exception exception)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x2E6B27C", Offset = "0x2E6727C", VA = "0x2E6B27C")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	internal static bool EndContainerGUIFromException(Exception exception)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x2E6AE30", Offset = "0x2E66E30", VA = "0x2E6AE30")]
	internal static void ResetGlobalState()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x2E6B31C", Offset = "0x2E6731C", VA = "0x2E6B31C")]
	internal static bool IsExitGUIException(Exception exception)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x2E6B228", Offset = "0x2E67228", VA = "0x2E6B228")]
	internal static bool ShouldRethrowException(Exception exception)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x2E59220", Offset = "0x2E55220", VA = "0x2E59220")]
	internal static void CheckOnGUI()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x2E6B3A0", Offset = "0x2E673A0", VA = "0x2E6B3A0")]
	internal static float RoundToPixelGrid(float v)
	{
		return default(float);
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x2E6B450", Offset = "0x2E67450", VA = "0x2E6B450")]
	public static Rect AlignRectToDevice(Rect rect)
	{
		return default(Rect);
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x2E6B4DC", Offset = "0x2E674DC", VA = "0x2E6B4DC")]
	internal static bool HitTest(Rect rect, Vector2 point, int offset)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2E6B520", Offset = "0x2E67520", VA = "0x2E6B520")]
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x2E5D6BC", Offset = "0x2E596BC", VA = "0x2E5D6BC")]
	internal static bool HitTest(Rect rect, Event evt)
	{
		return default(bool);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x2E6A384", Offset = "0x2E66384", VA = "0x2E6A384")]
	private static extern int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect);

	[MethodImpl(4096)]
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x2E6A614", Offset = "0x2E66614", VA = "0x2E6A614")]
	private static extern void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret);

	[MethodImpl(4096)]
	[SpecialName]
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x2E6A724", Offset = "0x2E66724", VA = "0x2E6A724")]
	private static extern void set_compositionCursorPos_Injected(ref Vector2 value);
}
[Token(Token = "0x200001E")]
public sealed class ExitGUIException : Exception
{
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x2E6AA7C", Offset = "0x2E66A7C", VA = "0x2E6AA7C")]
	public ExitGUIException()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x2E65968", Offset = "0x2E61968", VA = "0x2E65968")]
	internal ExitGUIException(string message)
	{
	}
}
[Token(Token = "0x200001F")]
internal class GUILayoutEntry
{
	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float minWidth;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float maxWidth;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minHeight;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxHeight;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rect rect;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int stretchWidth;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int stretchHeight;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool consideredForMargin;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GUIStyle m_Style;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static Rect kDummyRect;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static int indent;

	[Token(Token = "0x17000077")]
	public GUIStyle style
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2E6B64C", Offset = "0x2E6764C", VA = "0x2E6B64C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2E64920", Offset = "0x2E60920", VA = "0x2E64920")]
		set
		{
		}
	}

	[Token(Token = "0x17000078")]
	public virtual int marginLeft
	{
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2E6B654", Offset = "0x2E67654", VA = "0x2E6B654", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000079")]
	public virtual int marginRight
	{
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2E6B678", Offset = "0x2E67678", VA = "0x2E6B678", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700007A")]
	public virtual int marginTop
	{
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2E6B69C", Offset = "0x2E6769C", VA = "0x2E6B69C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700007B")]
	public virtual int marginBottom
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2E6B6C0", Offset = "0x2E676C0", VA = "0x2E6B6C0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700007C")]
	public int marginHorizontal
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2E6B6E4", Offset = "0x2E676E4", VA = "0x2E6B6E4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700007D")]
	public int marginVertical
	{
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2E6B720", Offset = "0x2E67720", VA = "0x2E6B720")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x2E6B75C", Offset = "0x2E6775C", VA = "0x2E6B75C")]
	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x2E65E58", Offset = "0x2E61E58", VA = "0x2E65E58")]
	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x2E6B830", Offset = "0x2E67830", VA = "0x2E6B830", Slot = "8")]
	public virtual void CalcWidth()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x2E6B834", Offset = "0x2E67834", VA = "0x2E6B834", Slot = "9")]
	public virtual void CalcHeight()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x2E6B838", Offset = "0x2E67838", VA = "0x2E6B838", Slot = "10")]
	public virtual void SetHorizontal(float x, float width)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x2E6B844", Offset = "0x2E67844", VA = "0x2E6B844", Slot = "11")]
	public virtual void SetVertical(float y, float height)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x2E6B850", Offset = "0x2E67850", VA = "0x2E6B850", Slot = "12")]
	protected virtual void ApplyStyleSettings(GUIStyle style)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x2E6B94C", Offset = "0x2E6794C", VA = "0x2E6B94C", Slot = "13")]
	public virtual void ApplyOptions(GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x2E6BC54", Offset = "0x2E67C54", VA = "0x2E6BC54", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000020")]
internal sealed class GUIWordWrapSizer : GUILayoutEntry
{
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly GUIContent m_Content;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly float m_ForcedMinHeight;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private readonly float m_ForcedMaxHeight;

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x2E6C148", Offset = "0x2E68148", VA = "0x2E6C148")]
	public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x2E6C224", Offset = "0x2E68224", VA = "0x2E6C224", Slot = "8")]
	public override void CalcWidth()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x2E6C2B4", Offset = "0x2E682B4", VA = "0x2E6C2B4", Slot = "9")]
	public override void CalcHeight()
	{
	}
}
[Token(Token = "0x2000021")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
internal class GUILayoutGroup : GUILayoutEntry
{
	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<GUILayoutEntry> entries;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool isVertical;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool resetCoords;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float spacing;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool sameSize;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool isWindow;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int windowID;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int m_Cursor;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected int m_StretchableCountX;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected int m_StretchableCountY;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	protected bool m_UserSpecifiedWidth;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	protected bool m_UserSpecifiedHeight;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected float m_ChildMinWidth;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	protected float m_ChildMaxWidth;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected float m_ChildMinHeight;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected float m_ChildMaxHeight;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected int m_MarginLeft;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected int m_MarginRight;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected int m_MarginTop;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	protected int m_MarginBottom;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly GUILayoutEntry none;

	[Token(Token = "0x1700007E")]
	public override int marginLeft
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2E6C318", Offset = "0x2E68318", VA = "0x2E6C318", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700007F")]
	public override int marginRight
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2E6C320", Offset = "0x2E68320", VA = "0x2E6C320", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000080")]
	public override int marginTop
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2E6C328", Offset = "0x2E68328", VA = "0x2E6C328", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000081")]
	public override int marginBottom
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2E6C330", Offset = "0x2E68330", VA = "0x2E6C330", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x2E6C338", Offset = "0x2E68338", VA = "0x2E6C338")]
	public GUILayoutGroup()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x2E6C44C", Offset = "0x2E6844C", VA = "0x2E6C44C", Slot = "13")]
	public override void ApplyOptions(GUILayoutOption[] options)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x2E6C570", Offset = "0x2E68570", VA = "0x2E6C570", Slot = "12")]
	protected override void ApplyStyleSettings(GUIStyle style)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x2E6C5EC", Offset = "0x2E685EC", VA = "0x2E6C5EC")]
	public void ResetCursor()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x2E6C5F4", Offset = "0x2E685F4", VA = "0x2E6C5F4")]
	public GUILayoutEntry GetNext()
	{
		return null;
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x2E6C850", Offset = "0x2E68850", VA = "0x2E6C850")]
	public Rect GetLast()
	{
		return default(Rect);
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x2E6CB1C", Offset = "0x2E68B1C", VA = "0x2E6CB1C")]
	public void Add(GUILayoutEntry e)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x2E6CBC0", Offset = "0x2E68BC0", VA = "0x2E6CBC0", Slot = "8")]
	public override void CalcWidth()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x2E6D1F8", Offset = "0x2E691F8", VA = "0x2E6D1F8", Slot = "10")]
	public override void SetHorizontal(float x, float width)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x2E6D9DC", Offset = "0x2E699DC", VA = "0x2E6D9DC", Slot = "9")]
	public override void CalcHeight()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x2E6DFA0", Offset = "0x2E69FA0", VA = "0x2E6DFA0", Slot = "11")]
	public override void SetVertical(float y, float height)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x2E6E794", Offset = "0x2E6A794", VA = "0x2E6E794", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000022")]
internal sealed class GUIScrollGroup : GUILayoutGroup
{
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float calcMinWidth;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float calcMaxWidth;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float calcMinHeight;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float calcMaxHeight;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float clientWidth;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float clientHeight;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool allowHorizontalScroll;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	public bool allowVerticalScroll;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
	public bool needsHorizontalScrollbar;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
	public bool needsVerticalScrollbar;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GUIStyle horizontalScrollbar;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GUIStyle verticalScrollbar;

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x2E6EBC4", Offset = "0x2E6ABC4", VA = "0x2E6EBC4")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public GUIScrollGroup()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x2E6EC20", Offset = "0x2E6AC20", VA = "0x2E6EC20", Slot = "8")]
	public override void CalcWidth()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x2E6EC94", Offset = "0x2E6AC94", VA = "0x2E6EC94", Slot = "10")]
	public override void SetHorizontal(float x, float width)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x2E6ED6C", Offset = "0x2E6AD6C", VA = "0x2E6ED6C", Slot = "9")]
	public override void CalcHeight()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2E6EE3C", Offset = "0x2E6AE3C", VA = "0x2E6EE3C", Slot = "11")]
	public override void SetVertical(float y, float height)
	{
	}
}
[Token(Token = "0x2000023")]
[UnityEngine.Bindings.NativeHeader("Modules/IMGUI/GUIState.h")]
internal class ObjectGUIState : IDisposable
{
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal IntPtr m_Ptr;

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x2E6EFA0", Offset = "0x2E6AFA0", VA = "0x2E6EFA0")]
	public ObjectGUIState()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x2E6F00C", Offset = "0x2E6B00C", VA = "0x2E6F00C", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x2E6F0C8", Offset = "0x2E6B0C8", VA = "0x2E6F0C8", Slot = "1")]
	~ObjectGUIState()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x2E6F06C", Offset = "0x2E6B06C", VA = "0x2E6F06C")]
	private void Destroy()
	{
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x2E6EFE4", Offset = "0x2E6AFE4", VA = "0x2E6EFE4")]
	private static extern IntPtr Internal_Create();

	[MethodImpl(4096)]
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x2E6F14C", Offset = "0x2E6B14C", VA = "0x2E6F14C")]
	[UnityEngine.Bindings.NativeMethod(IsThreadSafe = true)]
	private static extern void Internal_Destroy(IntPtr ptr);
}
[Token(Token = "0x2000024")]
internal class ScrollViewState
{
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rect position;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rect visibleRect;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Rect viewRect;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2 scrollPosition;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool apply;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool isDuringTouchScroll;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector2 touchScrollStartMousePosition;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector2 touchScrollStartPosition;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector2 velocity;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float previousTimeSinceStartup;

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x2E6F188", Offset = "0x2E6B188", VA = "0x2E6F188")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public ScrollViewState()
	{
	}
}
[Token(Token = "0x2000025")]
internal class SliderState
{
	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float dragStartPos;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float dragStartValue;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isDragging;

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x2E6F190", Offset = "0x2E6B190", VA = "0x2E6F190")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public SliderState()
	{
	}
}
[Token(Token = "0x2000026")]
internal struct SliderHandler
{
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Rect position;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly float currentValue;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private readonly float size;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly float start;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private readonly float end;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly GUIStyle slider;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly GUIStyle thumb;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly GUIStyle thumbExtent;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly bool horiz;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private readonly int id;

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x2E6F198", Offset = "0x2E6B198", VA = "0x2E6F198")]
	public SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, [Optional] GUIStyle thumbExtent)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x2E6F1BC", Offset = "0x2E6B1BC", VA = "0x2E6F1BC")]
	public float Handle()
	{
		return default(float);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x2E6F264", Offset = "0x2E6B264", VA = "0x2E6F264")]
	private float OnMouseDown()
	{
		return default(float);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x2E6F680", Offset = "0x2E6B680", VA = "0x2E6F680")]
	private float OnMouseDrag()
	{
		return default(float);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x2E6F79C", Offset = "0x2E6B79C", VA = "0x2E6F79C")]
	private float OnMouseUp()
	{
		return default(float);
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x2E6F838", Offset = "0x2E6B838", VA = "0x2E6F838")]
	private float OnRepaint()
	{
		return default(float);
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x2E6F23C", Offset = "0x2E6B23C", VA = "0x2E6F23C")]
	private EventType CurrentEventType()
	{
		return default(EventType);
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x2E6FFA8", Offset = "0x2E6BFA8", VA = "0x2E6FFA8")]
	private int CurrentScrollTroughSide()
	{
		return default(int);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x2E6FDB0", Offset = "0x2E6BDB0", VA = "0x2E6FDB0")]
	private bool IsEmptySlider()
	{
		return default(bool);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x2E6FE34", Offset = "0x2E6BE34", VA = "0x2E6FE34")]
	private bool SupportsPageMovements()
	{
		return default(bool);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x2E70020", Offset = "0x2E6C020", VA = "0x2E70020")]
	private float PageMovementValue()
	{
		return default(float);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x2E702F4", Offset = "0x2E6C2F4", VA = "0x2E702F4")]
	private float PageUpMovementBound()
	{
		return default(float);
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x2E6FDA8", Offset = "0x2E6BDA8", VA = "0x2E6FDA8")]
	private Event CurrentEvent()
	{
		return null;
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x2E700D0", Offset = "0x2E6C0D0", VA = "0x2E700D0")]
	private float ValueForCurrentMousePosition()
	{
		return default(float);
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x2E70144", Offset = "0x2E6C144", VA = "0x2E70144")]
	private float Clamp(float value)
	{
		return default(float);
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x2E6FDA4", Offset = "0x2E6BDA4", VA = "0x2E6FDA4")]
	private Rect ThumbSelectionRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x2E6FDEC", Offset = "0x2E6BDEC", VA = "0x2E6FDEC")]
	private void StartDraggingWithValue(float dragStartValue)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x2E6FEA4", Offset = "0x2E6BEA4", VA = "0x2E6FEA4")]
	private SliderState SliderState()
	{
		return null;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x2E7026C", Offset = "0x2E6C26C", VA = "0x2E7026C")]
	private Rect ThumbExtRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x2E702E4", Offset = "0x2E6C2E4", VA = "0x2E702E4")]
	private Rect ThumbRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x2E70358", Offset = "0x2E6C358", VA = "0x2E70358")]
	private Rect VerticalThumbRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x2E7047C", Offset = "0x2E6C47C", VA = "0x2E7047C")]
	private Rect HorizontalThumbRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x2E6FDC0", Offset = "0x2E6BDC0", VA = "0x2E6FDC0")]
	private float ClampedCurrentValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x2E70170", Offset = "0x2E6C170", VA = "0x2E70170")]
	private float MousePosition()
	{
		return default(float);
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x2E701C8", Offset = "0x2E6C1C8", VA = "0x2E701C8")]
	private float ValuesPerPixel()
	{
		return default(float);
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x2E705A0", Offset = "0x2E6C5A0", VA = "0x2E705A0")]
	private float ThumbSize()
	{
		return default(float);
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x2E70340", Offset = "0x2E6C340", VA = "0x2E70340")]
	private float MaxValue()
	{
		return default(float);
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x2E70330", Offset = "0x2E6C330", VA = "0x2E70330")]
	private float MinValue()
	{
		return default(float);
	}
}
[Token(Token = "0x2000027")]
internal enum TextEditOp
{
	[Token(Token = "0x400010E")]
	MoveLeft,
	[Token(Token = "0x400010F")]
	MoveRight,
	[Token(Token = "0x4000110")]
	MoveUp,
	[Token(Token = "0x4000111")]
	MoveDown,
	[Token(Token = "0x4000112")]
	MoveLineStart,
	[Token(Token = "0x4000113")]
	MoveLineEnd,
	[Token(Token = "0x4000114")]
	MoveTextStart,
	[Token(Token = "0x4000115")]
	MoveTextEnd,
	[Token(Token = "0x4000116")]
	MovePageUp,
	[Token(Token = "0x4000117")]
	MovePageDown,
	[Token(Token = "0x4000118")]
	MoveGraphicalLineStart,
	[Token(Token = "0x4000119")]
	MoveGraphicalLineEnd,
	[Token(Token = "0x400011A")]
	MoveWordLeft,
	[Token(Token = "0x400011B")]
	MoveWordRight,
	[Token(Token = "0x400011C")]
	MoveParagraphForward,
	[Token(Token = "0x400011D")]
	MoveParagraphBackward,
	[Token(Token = "0x400011E")]
	MoveToStartOfNextWord,
	[Token(Token = "0x400011F")]
	MoveToEndOfPreviousWord,
	[Token(Token = "0x4000120")]
	Delete,
	[Token(Token = "0x4000121")]
	Backspace,
	[Token(Token = "0x4000122")]
	DeleteWordBack,
	[Token(Token = "0x4000123")]
	DeleteWordForward,
	[Token(Token = "0x4000124")]
	DeleteLineBack,
	[Token(Token = "0x4000125")]
	Cut,
	[Token(Token = "0x4000126")]
	Paste,
	[Token(Token = "0x4000127")]
	ScrollStart,
	[Token(Token = "0x4000128")]
	ScrollEnd,
	[Token(Token = "0x4000129")]
	ScrollPageUp,
	[Token(Token = "0x400012A")]
	ScrollPageDown
}
[Token(Token = "0x2000028")]
internal enum TextSelectOp
{
	[Token(Token = "0x400012C")]
	SelectLeft,
	[Token(Token = "0x400012D")]
	SelectRight,
	[Token(Token = "0x400012E")]
	SelectUp,
	[Token(Token = "0x400012F")]
	SelectDown,
	[Token(Token = "0x4000130")]
	SelectTextStart,
	[Token(Token = "0x4000131")]
	SelectTextEnd,
	[Token(Token = "0x4000132")]
	SelectPageUp,
	[Token(Token = "0x4000133")]
	SelectPageDown,
	[Token(Token = "0x4000134")]
	ExpandSelectGraphicalLineStart,
	[Token(Token = "0x4000135")]
	ExpandSelectGraphicalLineEnd,
	[Token(Token = "0x4000136")]
	SelectGraphicalLineStart,
	[Token(Token = "0x4000137")]
	SelectGraphicalLineEnd,
	[Token(Token = "0x4000138")]
	SelectWordLeft,
	[Token(Token = "0x4000139")]
	SelectWordRight,
	[Token(Token = "0x400013A")]
	SelectToEndOfPreviousWord,
	[Token(Token = "0x400013B")]
	SelectToStartOfNextWord,
	[Token(Token = "0x400013C")]
	SelectParagraphBackward,
	[Token(Token = "0x400013D")]
	SelectParagraphForward,
	[Token(Token = "0x400013E")]
	Copy,
	[Token(Token = "0x400013F")]
	SelectAll,
	[Token(Token = "0x4000140")]
	SelectNone
}
[Token(Token = "0x2000029")]
internal class TextEditingUtilities
{
	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private TextSelectingUtilities m_TextSelectingUtility;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UnityEngine.TextCore.Text.TextHandle m_TextHandle;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_CursorIndexSavedState;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	internal bool isCompositionActive;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	private bool m_UpdateImeWindowPosition;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool multiline;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string m_Text;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<Event, TextEditOp> s_KeyEditOps;

	[Token(Token = "0x17000082")]
	private bool hasSelection
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2E70648", Offset = "0x2E6C648", VA = "0x2E70648")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000083")]
	internal bool revealCursor
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2E706C4", Offset = "0x2E6C6C4", VA = "0x2E706C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000084")]
	private int cursorIndex
	{
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2E70734", Offset = "0x2E6C734", VA = "0x2E70734")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2E70754", Offset = "0x2E6C754", VA = "0x2E70754")]
		set
		{
		}
	}

	[Token(Token = "0x17000085")]
	private int selectIndex
	{
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2E707BC", Offset = "0x2E6C7BC", VA = "0x2E707BC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2E707DC", Offset = "0x2E6C7DC", VA = "0x2E707DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000086")]
	public string text
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2E70844", Offset = "0x2E6C844", VA = "0x2E70844")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2E7084C", Offset = "0x2E6C84C", VA = "0x2E7084C")]
		set
		{
		}
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x2E708B8", Offset = "0x2E6C8B8", VA = "0x2E708B8")]
	public TextEditingUtilities(TextSelectingUtilities selectingUtilities, UnityEngine.TextCore.Text.TextHandle textHandle, string text)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x2E70900", Offset = "0x2E6C900", VA = "0x2E70900")]
	public bool UpdateImeState()
	{
		return default(bool);
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x2E70A40", Offset = "0x2E6CA40", VA = "0x2E70A40")]
	public bool ShouldUpdateImeWindowPosition()
	{
		return default(bool);
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x2E70A48", Offset = "0x2E6CA48", VA = "0x2E70A48")]
	public void SetImeWindowPosition(Vector2 worldPosition)
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x2E70AEC", Offset = "0x2E6CAEC", VA = "0x2E70AEC")]
	public string GeneratePreviewString(bool richText)
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x2E70C2C", Offset = "0x2E6CC2C", VA = "0x2E70C2C")]
	public void EnableCursorPreviewState()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x2E70BEC", Offset = "0x2E6CBEC", VA = "0x2E70BEC")]
	public void RestoreCursorState()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x2E70CD8", Offset = "0x2E6CCD8", VA = "0x2E70CD8")]
	[UnityEngine.Bindings.VisibleToOtherModules]
	internal bool HandleKeyEvent(Event e)
	{
		return default(bool);
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x2E7144C", Offset = "0x2E6D44C", VA = "0x2E7144C")]
	private void PerformOperation(TextEditOp operation)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x2E72B40", Offset = "0x2E6EB40", VA = "0x2E72B40")]
	private static void MapKey(string key, TextEditOp action)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x2E70DEC", Offset = "0x2E6CDEC", VA = "0x2E70DEC")]
	private void InitKeyActions()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x2E7298C", Offset = "0x2E6E98C", VA = "0x2E7298C")]
	public bool DeleteLineBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x2E728D0", Offset = "0x2E6E8D0", VA = "0x2E728D0")]
	public bool DeleteWordBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x2E72A84", Offset = "0x2E6EA84", VA = "0x2E72A84")]
	public bool DeleteWordForward()
	{
		return default(bool);
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x2E72680", Offset = "0x2E6E680", VA = "0x2E72680")]
	public bool Delete()
	{
		return default(bool);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x2E7273C", Offset = "0x2E6E73C", VA = "0x2E7273C")]
	public bool Backspace()
	{
		return default(bool);
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x2E72BD0", Offset = "0x2E6EBD0", VA = "0x2E72BD0")]
	public bool DeleteSelection()
	{
		return default(bool);
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x2E709B8", Offset = "0x2E6C9B8", VA = "0x2E709B8")]
	public void ReplaceSelection(string replace)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x2E73200", Offset = "0x2E6F200", VA = "0x2E73200")]
	public void Insert(char c)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x2E73274", Offset = "0x2E6F274", VA = "0x2E73274")]
	public bool CanPaste()
	{
		return default(bool);
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x2E727FC", Offset = "0x2E6E7FC", VA = "0x2E727FC")]
	public bool Cut()
	{
		return default(bool);
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x2E72820", Offset = "0x2E6E820", VA = "0x2E72820")]
	public bool Paste()
	{
		return default(bool);
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x2E73374", Offset = "0x2E6F374", VA = "0x2E73374")]
	private static string ReplaceNewlinesWithSpaces(string value)
	{
		return null;
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x2E73408", Offset = "0x2E6F408", VA = "0x2E73408")]
	internal void OnBlur()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x2E73478", Offset = "0x2E6F478", VA = "0x2E73478")]
	internal bool TouchScreenKeyboardShouldBeUsed()
	{
		return default(bool);
	}
}
[Token(Token = "0x200002A")]
public class TextEditor
{
	[Token(Token = "0x200002B")]
	public enum DblClickSnapping : byte
	{
		[Token(Token = "0x4000162")]
		WORDS,
		[Token(Token = "0x4000163")]
		PARAGRAPHS
	}

	[Token(Token = "0x200002C")]
	private enum CharacterType
	{
		[Token(Token = "0x4000165")]
		LetterLike,
		[Token(Token = "0x4000166")]
		Symbol,
		[Token(Token = "0x4000167")]
		Symbol2,
		[Token(Token = "0x4000168")]
		WhiteSpace
	}

	[Token(Token = "0x200002D")]
	private enum Direction
	{
		[Token(Token = "0x400016A")]
		Forward,
		[Token(Token = "0x400016B")]
		Backward
	}

	[Token(Token = "0x200002E")]
	private enum TextEditOp
	{
		[Token(Token = "0x400016D")]
		MoveLeft,
		[Token(Token = "0x400016E")]
		MoveRight,
		[Token(Token = "0x400016F")]
		MoveUp,
		[Token(Token = "0x4000170")]
		MoveDown,
		[Token(Token = "0x4000171")]
		MoveLineStart,
		[Token(Token = "0x4000172")]
		MoveLineEnd,
		[Token(Token = "0x4000173")]
		MoveTextStart,
		[Token(Token = "0x4000174")]
		MoveTextEnd,
		[Token(Token = "0x4000175")]
		MovePageUp,
		[Token(Token = "0x4000176")]
		MovePageDown,
		[Token(Token = "0x4000177")]
		MoveGraphicalLineStart,
		[Token(Token = "0x4000178")]
		MoveGraphicalLineEnd,
		[Token(Token = "0x4000179")]
		MoveWordLeft,
		[Token(Token = "0x400017A")]
		MoveWordRight,
		[Token(Token = "0x400017B")]
		MoveParagraphForward,
		[Token(Token = "0x400017C")]
		MoveParagraphBackward,
		[Token(Token = "0x400017D")]
		MoveToStartOfNextWord,
		[Token(Token = "0x400017E")]
		MoveToEndOfPreviousWord,
		[Token(Token = "0x400017F")]
		SelectLeft,
		[Token(Token = "0x4000180")]
		SelectRight,
		[Token(Token = "0x4000181")]
		SelectUp,
		[Token(Token = "0x4000182")]
		SelectDown,
		[Token(Token = "0x4000183")]
		SelectTextStart,
		[Token(Token = "0x4000184")]
		SelectTextEnd,
		[Token(Token = "0x4000185")]
		SelectPageUp,
		[Token(Token = "0x4000186")]
		SelectPageDown,
		[Token(Token = "0x4000187")]
		ExpandSelectGraphicalLineStart,
		[Token(Token = "0x4000188")]
		ExpandSelectGraphicalLineEnd,
		[Token(Token = "0x4000189")]
		SelectGraphicalLineStart,
		[Token(Token = "0x400018A")]
		SelectGraphicalLineEnd,
		[Token(Token = "0x400018B")]
		SelectWordLeft,
		[Token(Token = "0x400018C")]
		SelectWordRight,
		[Token(Token = "0x400018D")]
		SelectToEndOfPreviousWord,
		[Token(Token = "0x400018E")]
		SelectToStartOfNextWord,
		[Token(Token = "0x400018F")]
		SelectParagraphBackward,
		[Token(Token = "0x4000190")]
		SelectParagraphForward,
		[Token(Token = "0x4000191")]
		Delete,
		[Token(Token = "0x4000192")]
		Backspace,
		[Token(Token = "0x4000193")]
		DeleteWordBack,
		[Token(Token = "0x4000194")]
		DeleteWordForward,
		[Token(Token = "0x4000195")]
		DeleteLineBack,
		[Token(Token = "0x4000196")]
		Cut,
		[Token(Token = "0x4000197")]
		Copy,
		[Token(Token = "0x4000198")]
		Paste,
		[Token(Token = "0x4000199")]
		SelectAll,
		[Token(Token = "0x400019A")]
		SelectNone,
		[Token(Token = "0x400019B")]
		ScrollStart,
		[Token(Token = "0x400019C")]
		ScrollEnd,
		[Token(Token = "0x400019D")]
		ScrollPageUp,
		[Token(Token = "0x400019E")]
		ScrollPageDown
	}

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TouchScreenKeyboard keyboardOnScreen;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int controlID;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GUIStyle style;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool multiline;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool hasHorizontalCursorPos;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool isPasswordField;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	internal bool m_HasFocus;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector2 scrollOffset;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GUIContent m_Content;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Rect m_Position;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_CursorIndex;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int m_SelectIndex;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_RevealCursor;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector2 graphicalCursorPos;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector2 graphicalSelectCursorPos;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool m_MouseDragSelectsWholeWords;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int m_DblClickInitPos;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private DblClickSnapping m_DblClickSnap;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	private bool m_bJustSelected;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int m_iAltCursorPos;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string oldText;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int oldPos;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int oldSelectPos;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<Event, TextEditOp> s_Keyactions;

	[Token(Token = "0x17000087")]
	public string text
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2E73500", Offset = "0x2E6F500", VA = "0x2E73500")]
		get
		{
			return null;
		}
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2E73518", Offset = "0x2E6F518", VA = "0x2E73518")]
		set
		{
		}
	}

	[Token(Token = "0x17000088")]
	public Rect position
	{
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2E735D8", Offset = "0x2E6F5D8", VA = "0x2E735D8")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2E735E4", Offset = "0x2E6F5E4", VA = "0x2E735E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000089")]
	internal virtual Rect localPosition
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2E73940", Offset = "0x2E6F940", VA = "0x2E73940", Slot = "4")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x1700008A")]
	public int cursorIndex
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2E7394C", Offset = "0x2E6F94C", VA = "0x2E7394C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2E73954", Offset = "0x2E6F954", VA = "0x2E73954")]
		set
		{
		}
	}

	[Token(Token = "0x1700008B")]
	public int selectIndex
	{
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2E739AC", Offset = "0x2E6F9AC", VA = "0x2E739AC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2E739B4", Offset = "0x2E6F9B4", VA = "0x2E739B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700008C")]
	public bool hasSelection
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2E74C88", Offset = "0x2E70C88", VA = "0x2E74C88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x2E73A04", Offset = "0x2E6FA04", VA = "0x2E73A04")]
	private void ClearCursorPos()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x2E73A14", Offset = "0x2E6FA14", VA = "0x2E73A14")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	public TextEditor()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x2E73B08", Offset = "0x2E6FB08", VA = "0x2E73B08")]
	public void OnFocus()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x2E73B94", Offset = "0x2E6FB94", VA = "0x2E73B94")]
	public void OnLostFocus()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x2E73BE8", Offset = "0x2E6FBE8", VA = "0x2E73BE8")]
	private void GrabGraphicalCursorPos()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x2E73C6C", Offset = "0x2E6FC6C", VA = "0x2E73C6C")]
	public bool HandleKeyEvent(Event e)
	{
		return default(bool);
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x2E73C74", Offset = "0x2E6FC74", VA = "0x2E73C74")]
	[UnityEngine.Bindings.VisibleToOtherModules]
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly)
	{
		return default(bool);
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x2E74BB0", Offset = "0x2E70BB0", VA = "0x2E74BB0")]
	public bool DeleteLineBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x2E74E40", Offset = "0x2E70E40", VA = "0x2E74E40")]
	public bool DeleteWordBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x2E74FB8", Offset = "0x2E70FB8", VA = "0x2E74FB8")]
	public bool DeleteWordForward()
	{
		return default(bool);
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x2E75230", Offset = "0x2E71230", VA = "0x2E75230")]
	public bool Delete()
	{
		return default(bool);
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x2E753D8", Offset = "0x2E713D8", VA = "0x2E753D8")]
	public bool Backspace()
	{
		return default(bool);
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x2E73B4C", Offset = "0x2E6FB4C", VA = "0x2E73B4C")]
	public void SelectAll()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x2E7554C", Offset = "0x2E7154C", VA = "0x2E7554C")]
	public void SelectNone()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x2E74C98", Offset = "0x2E70C98", VA = "0x2E74C98")]
	public bool DeleteSelection()
	{
		return default(bool);
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x2E75570", Offset = "0x2E71570", VA = "0x2E75570")]
	public void ReplaceSelection(string replace)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x2E755FC", Offset = "0x2E715FC", VA = "0x2E755FC")]
	public void Insert(char c)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x2E75670", Offset = "0x2E71670", VA = "0x2E75670")]
	public void MoveRight()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x2E756E8", Offset = "0x2E716E8", VA = "0x2E756E8")]
	public void MoveLeft()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x2E75740", Offset = "0x2E71740", VA = "0x2E75740")]
	public void MoveUp()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x2E757F0", Offset = "0x2E717F0", VA = "0x2E757F0")]
	public void MoveDown()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x2E758D4", Offset = "0x2E718D4", VA = "0x2E758D4")]
	public void MoveLineStart()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x2E7594C", Offset = "0x2E7194C", VA = "0x2E7594C")]
	public void MoveLineEnd()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x2E759E8", Offset = "0x2E719E8", VA = "0x2E759E8")]
	public void MoveGraphicalLineStart()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x2E75B00", Offset = "0x2E71B00", VA = "0x2E75B00")]
	public void MoveGraphicalLineEnd()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x2E75C2C", Offset = "0x2E71C2C", VA = "0x2E75C2C")]
	public void MoveTextStart()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x2E75C4C", Offset = "0x2E71C4C", VA = "0x2E75C4C")]
	public void MoveTextEnd()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x2E75C94", Offset = "0x2E71C94", VA = "0x2E75C94")]
	private int IndexOfEndOfLine(int startIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x2E75CF8", Offset = "0x2E71CF8", VA = "0x2E75CF8")]
	public void MoveParagraphForward()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x2E75D7C", Offset = "0x2E71D7C", VA = "0x2E75D7C")]
	public void MoveParagraphBackward()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x2E75DFC", Offset = "0x2E71DFC", VA = "0x2E75DFC")]
	public void MoveCursorToPosition(Vector2 cursorPosition)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x2E75E48", Offset = "0x2E71E48", VA = "0x2E75E48")]
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x2E75ED0", Offset = "0x2E71ED0", VA = "0x2E75ED0")]
	public void SelectToPosition(Vector2 cursorPosition)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x2E762B8", Offset = "0x2E722B8", VA = "0x2E762B8")]
	public void SelectLeft()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x2E76310", Offset = "0x2E72310", VA = "0x2E76310")]
	public void SelectRight()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x2E76368", Offset = "0x2E72368", VA = "0x2E76368")]
	public void SelectUp()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x2E763CC", Offset = "0x2E723CC", VA = "0x2E763CC")]
	public void SelectDown()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x2E7644C", Offset = "0x2E7244C", VA = "0x2E7644C")]
	public void SelectTextEnd()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x2E7647C", Offset = "0x2E7247C", VA = "0x2E7647C")]
	public void SelectTextStart()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x2E76484", Offset = "0x2E72484", VA = "0x2E76484")]
	public void MouseDragSelectsWholeWords(bool on)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x2E76494", Offset = "0x2E72494", VA = "0x2E76494")]
	public void DblClickSnap(DblClickSnapping snapping)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x2E75A28", Offset = "0x2E71A28", VA = "0x2E75A28")]
	private int GetGraphicalLineStart(int p)
	{
		return default(int);
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x2E75B40", Offset = "0x2E71B40", VA = "0x2E75B40")]
	private int GetGraphicalLineEnd(int p)
	{
		return default(int);
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x2E7649C", Offset = "0x2E7249C", VA = "0x2E7649C")]
	private int FindNextSeperator(int startPos)
	{
		return default(int);
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x2E76638", Offset = "0x2E72638", VA = "0x2E76638")]
	private int FindPrevSeperator(int startPos)
	{
		return default(int);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x2E766D4", Offset = "0x2E726D4", VA = "0x2E766D4")]
	public void MoveWordRight()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x2E76730", Offset = "0x2E72730", VA = "0x2E76730")]
	public void MoveToStartOfNextWord()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x2E76790", Offset = "0x2E72790", VA = "0x2E76790")]
	public void MoveToEndOfPreviousWord()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x2E767F0", Offset = "0x2E727F0", VA = "0x2E767F0")]
	public void SelectToStartOfNextWord()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x2E7681C", Offset = "0x2E7281C", VA = "0x2E7681C")]
	public void SelectToEndOfPreviousWord()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x2E76534", Offset = "0x2E72534", VA = "0x2E76534")]
	private CharacterType ClassifyChar(int index)
	{
		return default(CharacterType);
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x2E75064", Offset = "0x2E71064", VA = "0x2E75064")]
	public int FindStartOfNextWord(int p)
	{
		return default(int);
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x2E74EEC", Offset = "0x2E70EEC", VA = "0x2E74EEC")]
	private int FindEndOfPreviousWord(int p)
	{
		return default(int);
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x2E76848", Offset = "0x2E72848", VA = "0x2E76848")]
	public void MoveWordLeft()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x2E76888", Offset = "0x2E72888", VA = "0x2E76888")]
	public void SelectWordRight()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x2E768F0", Offset = "0x2E728F0", VA = "0x2E768F0")]
	public void SelectWordLeft()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x2E76958", Offset = "0x2E72958", VA = "0x2E76958")]
	public void ExpandSelectGraphicalLineStart()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x2E769BC", Offset = "0x2E729BC", VA = "0x2E769BC")]
	public void ExpandSelectGraphicalLineEnd()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x2E76A20", Offset = "0x2E72A20", VA = "0x2E76A20")]
	public void SelectGraphicalLineStart()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x2E76A4C", Offset = "0x2E72A4C", VA = "0x2E76A4C")]
	public void SelectGraphicalLineEnd()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x2E76A78", Offset = "0x2E72A78", VA = "0x2E76A78")]
	public void SelectParagraphForward()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x2E76B04", Offset = "0x2E72B04", VA = "0x2E76B04")]
	public void SelectParagraphBackward()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x2E76BB4", Offset = "0x2E72BB4", VA = "0x2E76BB4")]
	public void SelectCurrentWord()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x2E7613C", Offset = "0x2E7213C", VA = "0x2E7613C")]
	private int FindEndOfClassification(int p, Direction dir)
	{
		return default(int);
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x2E76C20", Offset = "0x2E72C20", VA = "0x2E76C20")]
	public void SelectCurrentParagraph()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x2E76CBC", Offset = "0x2E72CBC", VA = "0x2E76CBC")]
	public void UpdateScrollOffsetIfNeeded(Event evt)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x2E73698", Offset = "0x2E6F698", VA = "0x2E73698")]
	[UnityEngine.Bindings.VisibleToOtherModules]
	internal void UpdateScrollOffset()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x2E76D18", Offset = "0x2E72D18", VA = "0x2E76D18")]
	public void DrawCursor(string newText)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x2E747D8", Offset = "0x2E707D8", VA = "0x2E747D8")]
	private bool PerformOperation(TextEditOp operation, bool textIsReadOnly)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x2E77220", Offset = "0x2E73220", VA = "0x2E77220")]
	public void SaveBackup()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x2E770A0", Offset = "0x2E730A0", VA = "0x2E770A0")]
	public bool Cut()
	{
		return default(bool);
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x2E770C8", Offset = "0x2E730C8", VA = "0x2E770C8")]
	public void Copy()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x2E77250", Offset = "0x2E73250", VA = "0x2E77250")]
	private static string ReplaceNewlinesWithSpaces(string value)
	{
		return null;
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x2E77178", Offset = "0x2E73178", VA = "0x2E77178")]
	public bool Paste()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x2E772E4", Offset = "0x2E732E4", VA = "0x2E772E4")]
	private static void MapKey(string key, TextEditOp action)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x2E73D90", Offset = "0x2E6FD90", VA = "0x2E73D90")]
	private void InitKeyActions()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x2E756DC", Offset = "0x2E716DC", VA = "0x2E756DC")]
	public void DetectFocusChange()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x2E77374", Offset = "0x2E73374", VA = "0x2E77374", Slot = "5")]
	internal virtual void OnDetectFocusChange()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x2E77424", Offset = "0x2E73424", VA = "0x2E77424", Slot = "6")]
	internal virtual void OnCursorIndexChange()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x2E77428", Offset = "0x2E73428", VA = "0x2E77428", Slot = "7")]
	internal virtual void OnSelectIndexChange()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x2E7742C", Offset = "0x2E7342C", VA = "0x2E7742C")]
	private void ClampTextIndex(ref int index)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x2E73598", Offset = "0x2E6F598", VA = "0x2E73598")]
	private void EnsureValidCodePointIndex(ref int index)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x2E77478", Offset = "0x2E73478", VA = "0x2E77478")]
	private bool IsValidCodePointIndex(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x2E7548C", Offset = "0x2E7148C", VA = "0x2E7548C")]
	private int PreviousCodePointIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x2E752EC", Offset = "0x2E712EC", VA = "0x2E752EC")]
	private int NextCodePointIndex(int index)
	{
		return default(int);
	}
}
[Token(Token = "0x200002F")]
internal class TextSelectingUtilities
{
	[Token(Token = "0x2000030")]
	private enum CharacterType
	{
		[Token(Token = "0x40001B1")]
		LetterLike,
		[Token(Token = "0x40001B2")]
		Symbol,
		[Token(Token = "0x40001B3")]
		Symbol2,
		[Token(Token = "0x40001B4")]
		WhiteSpace,
		[Token(Token = "0x40001B5")]
		NewLine
	}

	[Token(Token = "0x2000031")]
	private enum Direction
	{
		[Token(Token = "0x40001B7")]
		Forward,
		[Token(Token = "0x40001B8")]
		Backward
	}

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TextEditor.DblClickSnapping dblClickSnap;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int iAltCursorPos;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool hasHorizontalCursorPos;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool m_bJustSelected;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	private bool m_MouseDragSelectsWholeWords;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int m_DblClickInitPosStart;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_DblClickInitPosEnd;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UnityEngine.TextCore.Text.TextHandle m_TextHandle;

	[Token(Token = "0x40001A7")]
	private const int kMoveDownHeight = 5;

	[Token(Token = "0x40001A8")]
	private const char kNewLineChar = '\n';

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool m_RevealCursor;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int m_CursorIndex;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal int m_SelectIndex;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<Event, TextSelectOp> s_KeySelectOps;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	internal Action OnCursorIndexChange;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	internal Action OnSelectIndexChange;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	internal Action OnRevealCursorChange;

	[Token(Token = "0x1700008D")]
	public bool hasSelection
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2E7068C", Offset = "0x2E6C68C", VA = "0x2E7068C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700008E")]
	public bool revealCursor
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2E77564", Offset = "0x2E73564", VA = "0x2E77564")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2E70704", Offset = "0x2E6C704", VA = "0x2E70704")]
		set
		{
		}
	}

	[Token(Token = "0x1700008F")]
	private int m_CharacterCount
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2E7756C", Offset = "0x2E7356C", VA = "0x2E7756C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000090")]
	private int characterCount
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2E77594", Offset = "0x2E73594", VA = "0x2E77594")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000091")]
	private UnityEngine.TextCore.Text.TextElementInfo[] m_TextElementInfos
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2E77628", Offset = "0x2E73628", VA = "0x2E77628")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000092")]
	public int cursorIndex
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2E7074C", Offset = "0x2E6C74C", VA = "0x2E7074C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2E70790", Offset = "0x2E6C790", VA = "0x2E70790")]
		set
		{
		}
	}

	[Token(Token = "0x17000093")]
	public int selectIndex
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2E707D4", Offset = "0x2E6C7D4", VA = "0x2E707D4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2E70818", Offset = "0x2E6C818", VA = "0x2E70818")]
		set
		{
		}
	}

	[Token(Token = "0x17000094")]
	public string selectedText
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2E776A8", Offset = "0x2E736A8", VA = "0x2E776A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x2E731E0", Offset = "0x2E6F1E0", VA = "0x2E731E0")]
	internal void SetCursorIndexWithoutNotify(int index)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x2E731E8", Offset = "0x2E6F1E8", VA = "0x2E731E8")]
	internal void SetSelectIndexWithoutNotify(int index)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x2E777B8", Offset = "0x2E737B8", VA = "0x2E777B8")]
	public TextSelectingUtilities(UnityEngine.TextCore.Text.TextHandle textHandle)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x2E77800", Offset = "0x2E73800", VA = "0x2E77800")]
	internal bool HandleKeyEvent(Event e)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x2E77D18", Offset = "0x2E73D18", VA = "0x2E77D18")]
	private bool PerformOperation(TextSelectOp operation)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x2E78B5C", Offset = "0x2E74B5C", VA = "0x2E78B5C")]
	private static void MapKey(string key, TextSelectOp action)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x2E7790C", Offset = "0x2E7390C", VA = "0x2E7790C")]
	private void InitKeyActions()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x2E731F0", Offset = "0x2E6F1F0", VA = "0x2E731F0")]
	public void ClearCursorPos()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x2E78BEC", Offset = "0x2E74BEC", VA = "0x2E78BEC")]
	public void OnFocus(bool selectAll = true)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x2E78AF0", Offset = "0x2E74AF0", VA = "0x2E78AF0")]
	public void SelectAll()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x2E7342C", Offset = "0x2E6F42C", VA = "0x2E7342C")]
	public void SelectNone()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x2E77F08", Offset = "0x2E73F08", VA = "0x2E77F08")]
	public void SelectLeft()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x2E78004", Offset = "0x2E74004", VA = "0x2E78004")]
	public void SelectRight()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x2E78100", Offset = "0x2E74100", VA = "0x2E78100")]
	public void SelectUp()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x2E7816C", Offset = "0x2E7416C", VA = "0x2E7816C")]
	public void SelectDown()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x2E785A8", Offset = "0x2E745A8", VA = "0x2E785A8")]
	public void SelectTextEnd()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x2E78580", Offset = "0x2E74580", VA = "0x2E78580")]
	public void SelectTextStart()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x2E78524", Offset = "0x2E74524", VA = "0x2E78524")]
	public void SelectToStartOfNextWord()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x2E784C8", Offset = "0x2E744C8", VA = "0x2E784C8")]
	public void SelectToEndOfPreviousWord()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x2E781D8", Offset = "0x2E741D8", VA = "0x2E781D8")]
	public void SelectWordRight()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x2E78350", Offset = "0x2E74350", VA = "0x2E78350")]
	public void SelectWordLeft()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x2E78A38", Offset = "0x2E74A38", VA = "0x2E78A38")]
	public void SelectGraphicalLineStart()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x2E78A94", Offset = "0x2E74A94", VA = "0x2E78A94")]
	public void SelectGraphicalLineEnd()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x2E787C8", Offset = "0x2E747C8", VA = "0x2E787C8")]
	public void SelectParagraphForward()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x2E788DC", Offset = "0x2E748DC", VA = "0x2E788DC")]
	public void SelectParagraphBackward()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x2E78DD0", Offset = "0x2E74DD0", VA = "0x2E78DD0")]
	public void SelectCurrentWord()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x2E79024", Offset = "0x2E75024", VA = "0x2E79024")]
	public void SelectCurrentParagraph()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x2E71860", Offset = "0x2E6D860", VA = "0x2E71860")]
	public void MoveRight()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x2E71754", Offset = "0x2E6D754", VA = "0x2E71754")]
	public void MoveLeft()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x2E71974", Offset = "0x2E6D974", VA = "0x2E71974")]
	public void MoveUp()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x2E71AA8", Offset = "0x2E6DAA8", VA = "0x2E71AA8")]
	public void MoveDown()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x2E71BE8", Offset = "0x2E6DBE8", VA = "0x2E71BE8")]
	public void MoveLineStart()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x2E71D1C", Offset = "0x2E6DD1C", VA = "0x2E71D1C")]
	public void MoveLineEnd()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x2E72518", Offset = "0x2E6E518", VA = "0x2E72518")]
	public void MoveGraphicalLineStart()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x2E725CC", Offset = "0x2E6E5CC", VA = "0x2E725CC")]
	public void MoveGraphicalLineEnd()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x2E721E8", Offset = "0x2E6E1E8", VA = "0x2E721E8")]
	public void MoveTextStart()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x2E72244", Offset = "0x2E6E244", VA = "0x2E72244")]
	public void MoveTextEnd()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x2E722BC", Offset = "0x2E6E2BC", VA = "0x2E722BC")]
	public void MoveParagraphForward()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x2E723C8", Offset = "0x2E6E3C8", VA = "0x2E723C8")]
	public void MoveParagraphBackward()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x2E71E70", Offset = "0x2E6DE70", VA = "0x2E71E70")]
	public void MoveWordRight()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x2E71F60", Offset = "0x2E6DF60", VA = "0x2E71F60")]
	public void MoveToStartOfNextWord()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x2E72028", Offset = "0x2E6E028", VA = "0x2E72028")]
	public void MoveToEndOfPreviousWord()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x2E720F0", Offset = "0x2E6E0F0", VA = "0x2E720F0")]
	public void MoveWordLeft()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x2E79234", Offset = "0x2E75234", VA = "0x2E79234")]
	public void MouseDragSelectsWholeWords(bool on)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x2E785E8", Offset = "0x2E745E8", VA = "0x2E785E8")]
	public void ExpandSelectGraphicalLineStart()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x2E786D8", Offset = "0x2E746D8", VA = "0x2E786D8")]
	public void ExpandSelectGraphicalLineEnd()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x2E792C8", Offset = "0x2E752C8", VA = "0x2E792C8")]
	public void DblClickSnap(TextEditor.DblClickSnapping snapping)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x2E792D0", Offset = "0x2E752D0", VA = "0x2E792D0")]
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x2E7936C", Offset = "0x2E7536C", VA = "0x2E7936C")]
	public void SelectToPosition(Vector2 cursorPosition)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x2E79114", Offset = "0x2E75114", VA = "0x2E79114")]
	private int FindNextSeperator(int startPos)
	{
		return default(int);
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x2E79198", Offset = "0x2E75198", VA = "0x2E79198")]
	private int FindPrevSeperator(int startPos)
	{
		return default(int);
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x2E72E54", Offset = "0x2E6EE54", VA = "0x2E72E54")]
	public int FindStartOfNextWord(int p)
	{
		return default(int);
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x2E72D78", Offset = "0x2E6ED78", VA = "0x2E72D78")]
	public int FindEndOfPreviousWord(int p)
	{
		return default(int);
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x2E78EE0", Offset = "0x2E74EE0", VA = "0x2E78EE0")]
	private int FindEndOfClassification(int p, Direction dir)
	{
		return default(int);
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x2E7976C", Offset = "0x2E7576C", VA = "0x2E7976C")]
	private int ClampTextIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x2E77650", Offset = "0x2E73650", VA = "0x2E77650")]
	internal int EnsureValidCodePointIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x2E79790", Offset = "0x2E75790", VA = "0x2E79790")]
	private bool IsValidCodePointIndex(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x2E78D90", Offset = "0x2E74D90", VA = "0x2E78D90")]
	private int IndexOfEndOfLine(int startIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x2E730FC", Offset = "0x2E6F0FC", VA = "0x2E730FC")]
	public int PreviousCodePointIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x2E73018", Offset = "0x2E6F018", VA = "0x2E73018")]
	public int NextCodePointIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x2E78C34", Offset = "0x2E74C34", VA = "0x2E78C34")]
	private int GetGraphicalLineStart(int p)
	{
		return default(int);
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x2E78CDC", Offset = "0x2E74CDC", VA = "0x2E78CDC")]
	private int GetGraphicalLineEnd(int p)
	{
		return default(int);
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x2E732DC", Offset = "0x2E6F2DC", VA = "0x2E732DC")]
	public void Copy()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x2E79660", Offset = "0x2E75660", VA = "0x2E79660")]
	private CharacterType ClassifyChar(int index)
	{
		return default(CharacterType);
	}
}
