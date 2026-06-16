using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("2.0.0.0")]
namespace Prime31;

[Token(Token = "0x2000002")]
internal class CoroutineSurrogate : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2719B18", Offset = "0x2715B18", VA = "0x2719B18")]
	public CoroutineSurrogate()
	{
	}
}
[Token(Token = "0x2000003")]
public class MonoBehaviourGUI : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	protected float _width;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x24")]
	protected float _buttonHeight;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	protected Dictionary<string, bool> _toggleButtons;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	protected Dictionary<string, bool> _toggleTriggers;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x38")]
	protected StringBuilder _logBuilder;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x40")]
	private bool _logRegistered;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 _logScrollPosition;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x4C")]
	private bool _isShowingLogConsole;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	private float _doubleClickDelay;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x54")]
	private float _previousClickTime;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x58")]
	private bool _isIphoneX;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x60")]
	private Texture2D _normalBackground;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x68")]
	private Texture2D _bottomButtonBackground;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x70")]
	private Texture2D _activeBackground;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x78")]
	private Texture2D _toggleButtonBackground;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x80")]
	private bool _didRetinaIpadCheck;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x81")]
	private bool _isRetinaIpad;

	[Token(Token = "0x17000001")]
	private Texture2D normalBackground
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2719B20", Offset = "0x2715B20", VA = "0x2719B20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	private Texture2D bottomButtonBackground
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2719BF8", Offset = "0x2715BF8", VA = "0x2719BF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	private Texture2D activeBackground
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2719CD0", Offset = "0x2715CD0", VA = "0x2719CD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	private Texture2D toggleButtonBackground
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2719DB0", Offset = "0x2715DB0", VA = "0x2719DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2719E88", Offset = "0x2715E88", VA = "0x2719E88")]
	private bool isRetinaOrLargeScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2719EBC", Offset = "0x2715EBC", VA = "0x2719EBC")]
	private bool isRetinaIpad()
	{
		return default(bool);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2719F08", Offset = "0x2715F08", VA = "0x2719F08")]
	private int buttonHeight()
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2719F58", Offset = "0x2715F58", VA = "0x2719F58")]
	private int buttonFontSize()
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2719FA8", Offset = "0x2715FA8", VA = "0x2719FA8")]
	private void checkForIphoneX()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x271A0A8", Offset = "0x27160A8", VA = "0x271A0A8")]
	private int getNotchOffset()
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x271A0EC", Offset = "0x27160EC", VA = "0x271A0EC")]
	private void paintWindow(int id)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x271A27C", Offset = "0x271627C", VA = "0x271A27C")]
	private void handleLog(string logString, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x271A2D8", Offset = "0x27162D8", VA = "0x271A2D8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x271A380", Offset = "0x2716380", VA = "0x271A380")]
	private void Update()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x271A498", Offset = "0x2716498", VA = "0x271A498")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x271A3F4", Offset = "0x27163F4", VA = "0x271A3F4")]
	private void addLogCallback()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x271A2DC", Offset = "0x27162DC", VA = "0x271A2DC")]
	private void removeLogCallback()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x271A6C4", Offset = "0x27166C4", VA = "0x271A6C4")]
	protected void prepGuiSkin()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x271A9BC", Offset = "0x27169BC", VA = "0x271A9BC")]
	protected void beginColumn()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x271AA70", Offset = "0x2716A70", VA = "0x271AA70")]
	protected void endColumn()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x271AA78", Offset = "0x2716A78", VA = "0x271AA78")]
	protected void endColumn(bool hasSecondColumn)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x271ABDC", Offset = "0x2716BDC", VA = "0x271ABDC")]
	private void beginRightColumn()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x271ACA4", Offset = "0x2716CA4", VA = "0x271ACA4")]
	protected bool button(string text)
	{
		return default(bool);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x271ACFC", Offset = "0x2716CFC", VA = "0x271ACFC")]
	protected bool bottomRightButton(string text, float width = 150f)
	{
		return default(bool);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x271AE44", Offset = "0x2716E44", VA = "0x271AE44")]
	protected bool bottomLeftButton(string text, float width = 150f)
	{
		return default(bool);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x271AF78", Offset = "0x2716F78", VA = "0x271AF78")]
	protected bool bottomCenterButton(string text, float width = 150f)
	{
		return default(bool);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x271B0B4", Offset = "0x27170B4", VA = "0x271B0B4")]
	protected bool toggleButton(string defaultText, string selectedText)
	{
		return default(bool);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x271B388", Offset = "0x2717388", VA = "0x271B388")]
	protected bool toggleButtonState(string defaultText)
	{
		return default(bool);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x271B438", Offset = "0x2717438", VA = "0x271B438")]
	protected void setTrigger(string trigger, bool state = true)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x271B4A0", Offset = "0x27174A0", VA = "0x271B4A0")]
	protected bool checkTrigger(string trigger)
	{
		return default(bool);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x271B534", Offset = "0x2717534", VA = "0x271B534", Slot = "4")]
	protected virtual void onLeftColumnGUI()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x271B538", Offset = "0x2717538", VA = "0x271B538", Slot = "5")]
	protected virtual void onRightColumnGUI()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x271B53C", Offset = "0x271753C", VA = "0x271B53C")]
	public static void loadLevel(int level)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x271B594", Offset = "0x2717594", VA = "0x271B594")]
	public static void loadLevel(string level)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x271B5EC", Offset = "0x27175EC", VA = "0x271B5EC")]
	public static void captureScreenshot(string filename)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x271B5F4", Offset = "0x27175F4", VA = "0x271B5F4")]
	public static IEnumerator fetchScreenshot(string filename, float delay = 3f)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x271B68C", Offset = "0x271768C", VA = "0x271B68C")]
	public MonoBehaviourGUI()
	{
	}
}
[Token(Token = "0x2000005")]
public abstract class AbstractManager : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x0")]
	private static LifecycleHelper _prime31LifecycleHelperRef;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x8")]
	private static ThreadingCallbackHelper _threadingCallbackHelper;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x10")]
	private static GameObject _prime31GameObject;

	[Token(Token = "0x17000007")]
	public static LifecycleHelper coroutineSurrogate
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x271B9BC", Offset = "0x27179BC", VA = "0x271B9BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	public static LifecycleHelper lifecycleHelper
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x271BBBC", Offset = "0x2717BBC", VA = "0x271BBBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x271BBC0", Offset = "0x2717BC0", VA = "0x271BBC0")]
	public static ThreadingCallbackHelper getThreadingCallbackHelper()
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x271BC08", Offset = "0x2717C08", VA = "0x271BC08")]
	public static void createThreadingCallbackHelper()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x271BA7C", Offset = "0x2717A7C", VA = "0x271BA7C")]
	public static GameObject getPrime31ManagerGameObject()
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x271BD90", Offset = "0x2717D90", VA = "0x271BD90")]
	public static void initialize(Type type)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x271C0C0", Offset = "0x27180C0", VA = "0x271C0C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x271C188", Offset = "0x2718188", VA = "0x271C188")]
	protected AbstractManager()
	{
	}
}
[Token(Token = "0x2000006")]
public class ThreadingCallbackHelper : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x20")]
	private List<Action> _actions;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	private List<Action> _currentActions;

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x271C190", Offset = "0x2718190", VA = "0x271C190")]
	public void addActionToQueue(Action action)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x271C2B0", Offset = "0x27182B0", VA = "0x271C2B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x271C458", Offset = "0x2718458", VA = "0x271C458")]
	public void disableIfEmpty()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x271C538", Offset = "0x2718538", VA = "0x271C538")]
	public ThreadingCallbackHelper()
	{
	}
}
[Token(Token = "0x2000007")]
public class LifecycleHelper : MonoBehaviour
{
	[Token(Token = "0x14000001")]
	public event Action<bool> onApplicationPausedEvent
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x271C5CC", Offset = "0x27185CC", VA = "0x271C5CC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x271C67C", Offset = "0x271867C", VA = "0x271C67C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x271C72C", Offset = "0x271872C", VA = "0x271C72C")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x271C74C", Offset = "0x271874C", VA = "0x271C74C")]
	public LifecycleHelper()
	{
	}
}
