public class Input // TypeDefIndex: 4075
{	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static bool anyKey { get; }
	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static bool anyKeyDown { get; }
	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static Vector3 mousePosition { get; }
	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static bool mousePresent { get; }
	public static int touchCount { get; }
	public static bool touchSupported { get; }
	public static Touch[] touches { get; }


	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static float GetAxis(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static float GetAxisRaw(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static bool GetMouseButton(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	public static Touch GetTouch(int index) { }

	public static bool GetKey(KeyCode key) { }

	public static bool GetKeyUp(KeyCode key) { }

	public static bool GetKeyDown(KeyCode key) { }

	public static bool get_anyKey() { }

	public static bool get_anyKeyDown() { }

	public static Vector3 get_mousePosition() { }

	public static Vector2 get_mouseScrollDelta() { }

	public static IMECompositionMode get_imeCompositionMode() { }

	public static void set_imeCompositionMode(IMECompositionMode value) { }

	public static string get_compositionString() { }

	public static Vector2 get_compositionCursorPos() { }

	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xEA400 Offset: 0xE9800 VA: 0x1800EA400
	public static bool get_mousePresent() { }

	[FreeFunctionAttribute] // RVA: 0xEA4A0 Offset: 0xE98A0 VA: 0x1800EA4A0
	public static int get_touchCount() { }

	[FreeFunctionAttribute] // RVA: 0xEA580 Offset: 0xE9980 VA: 0x1800EA580
	public static bool get_touchSupported() { }

	public static Touch[] get_touches() { }

	private static void GetTouch_Injected(int index, out Touch ret) { }

	private static void get_mousePosition_Injected(out Vector3 ret) { }

	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}

public static class Input // TypeDefIndex: 6667
{
public static class Input // TypeDefIndex: 6667
	private static readonly Memoized<string, string> WithoutFirstChar; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<string, bool> RunBind; // 0x8
	private static List<Input.Button> buttons; // 0x10
	private static List<Action> frameThinks; // 0x18


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void add_RunBind(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void remove_RunBind(Action<string, bool> value) { }

	public static void Frame() { }

	public static void Update() { }

	public static void AddButton(string name, KeyCode key, Func<bool> TestFunction, Action FrameThink, bool transient = False) { }

	public static bool HasButton(string name) { }

	public static void SetBind(string name, string bind, bool cycled = False) { }

	public static string GetBind(string name) { }

	public static Input.Button GetButton(string name) { }

	public static void ClearBinds() { }

	public static Dictionary<string, Input.Button> GetAllBinds() { }

	public static string[] GetAllButtons() { }

	public static string[] GetPressedButtons() { }

	public static string[] GetButtonsWithBind(string bind) { }

	public static bool IsBindInUse(string bind) { }

	public static string GetButtonWithBind(string bind) { }

	public static Input.Button GetButtonObjectWithBind(string bind) { }

	public static void GetButtonsWithBind(string bind, List<Input.Button> results) { }

	private static void .cctor() { }

}

public class Input.Button // TypeDefIndex: 6668
{	public string Name; // 0x10
	public Func<bool> TestFunction; // 0x18
	public bool CurrentValue; // 0x20
	public bool LastValue; // 0x21
	public string[] Binds; // 0x28
	public bool Transient; // 0x30
	public bool Cycle; // 0x31
	public int CycleIndex; // 0x34
	public KeyCode Code; // 0x38


	public virtual void Update() { }

	private void RunBinds(bool pressed) { }

	private static void RunBindImpl(string bind, bool pressed) { }

	public void .ctor() { }

}

private sealed class Input.<>c__DisplayClass13_0 // TypeDefIndex: 6669
{	public string name; // 0x10


	public void .ctor() { }

	internal bool <GetButton>b__0(Input.Button x) { }

}

private sealed class Input.<>c // TypeDefIndex: 6670
{	public static readonly Input.<>c <>9; // 0x0
	public static Func<Input.Button, bool> <>9__15_0; // 0x8
	public static Func<Input.Button, string> <>9__15_1; // 0x10
	public static Func<Input.Button, string> <>9__16_0; // 0x18
	public static Func<Input.Button, bool> <>9__17_0; // 0x20
	public static Func<Input.Button, string> <>9__17_1; // 0x28
	public static Func<Input.Button, string> <>9__18_1; // 0x30


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetAllBinds>b__15_0(Input.Button x) { }

	internal string <GetAllBinds>b__15_1(Input.Button x) { }

	internal string <GetAllButtons>b__16_0(Input.Button x) { }

	internal bool <GetPressedButtons>b__17_0(Input.Button x) { }

	internal string <GetPressedButtons>b__17_1(Input.Button x) { }

	internal string <GetButtonsWithBind>b__18_1(Input.Button x) { }

	internal string <.cctor>b__23_0(string s) { }

}

private sealed class Input.<>c__DisplayClass18_0 // TypeDefIndex: 6671
{	public string bind; // 0x10


	public void .ctor() { }

	internal bool <GetButtonsWithBind>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass19_0 // TypeDefIndex: 6672
{	public string bind; // 0x10


	public void .ctor() { }

	internal bool <IsBindInUse>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass21_0 // TypeDefIndex: 6673
{	public string bind; // 0x10


	public void .ctor() { }

	internal bool <GetButtonObjectWithBind>b__0(Input.Button x) { }

}

public class Input : ConsoleSystem // TypeDefIndex: 11932
{	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool flipy; // 0x0
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool autocrouch; // 0x1
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float sensitivity; // 0x4
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float ads_sensitivity; // 0x8
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float vehicle_sensitivity; // 0xC
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool vehicle_flipy; // 0x10
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool toggleDuck; // 0x11
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool alwayssprint; // 0x12
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool toggleAds; // 0x13
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float holdtime; // 0x14


	[ClientVar] // RVA: 0xA73D0 Offset: 0xA67D0 VA: 0x1800A73D0
	public static string bind(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void clearbinds(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

