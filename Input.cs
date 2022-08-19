public class Input // TypeDefIndex: 4075
{	// Properties
	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
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

	// Methods

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x230E5A0 Offset: 0x230D9A0 VA: 0x18230E5A0
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x230E5E0 Offset: 0x230D9E0 VA: 0x18230E5E0
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x230E560 Offset: 0x230D960 VA: 0x18230E560
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x230E4E0 Offset: 0x230D8E0 VA: 0x18230E4E0
	public static float GetAxis(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x230E4A0 Offset: 0x230D8A0 VA: 0x18230E4A0
	public static float GetAxisRaw(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x230E520 Offset: 0x230D920 VA: 0x18230E520
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x230E6A0 Offset: 0x230DAA0 VA: 0x18230E6A0
	public static bool GetMouseButton(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x230E620 Offset: 0x230DA20 VA: 0x18230E620
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x230E660 Offset: 0x230DA60 VA: 0x18230E660
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x230E720 Offset: 0x230DB20 VA: 0x18230E720
	public static Touch GetTouch(int index) { }

	// RVA: 0x230E5A0 Offset: 0x230D9A0 VA: 0x18230E5A0
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x230E5E0 Offset: 0x230D9E0 VA: 0x18230E5E0
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x230E560 Offset: 0x230D960 VA: 0x18230E560
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x230E7B0 Offset: 0x230DBB0 VA: 0x18230E7B0
	public static bool get_anyKey() { }

	// RVA: 0x230E780 Offset: 0x230DB80 VA: 0x18230E780
	public static bool get_anyKeyDown() { }

	// RVA: 0x230E900 Offset: 0x230DD00 VA: 0x18230E900
	public static Vector3 get_mousePosition() { }

	// RVA: 0x230E9B0 Offset: 0x230DDB0 VA: 0x18230E9B0
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x230E890 Offset: 0x230DC90 VA: 0x18230E890
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x230EC00 Offset: 0x230E000 VA: 0x18230EC00
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x230E860 Offset: 0x230DC60 VA: 0x18230E860
	public static string get_compositionString() { }

	// RVA: 0x230E820 Offset: 0x230DC20 VA: 0x18230E820
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x230EBC0 Offset: 0x230DFC0 VA: 0x18230EBC0
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xEA400 Offset: 0xE9800 VA: 0x1800EA400
	// RVA: 0x230E940 Offset: 0x230DD40 VA: 0x18230E940
	public static bool get_mousePresent() { }

	[FreeFunctionAttribute] // RVA: 0xEA4A0 Offset: 0xE98A0 VA: 0x1800EA4A0
	// RVA: 0x230E9F0 Offset: 0x230DDF0 VA: 0x18230E9F0
	public static int get_touchCount() { }

	[FreeFunctionAttribute] // RVA: 0xEA580 Offset: 0xE9980 VA: 0x1800EA580
	// RVA: 0x230EA20 Offset: 0x230DE20 VA: 0x18230EA20
	public static bool get_touchSupported() { }

	// RVA: 0x230EA50 Offset: 0x230DE50 VA: 0x18230EA50
	public static Touch[] get_touches() { }

	// RVA: 0x230E6E0 Offset: 0x230DAE0 VA: 0x18230E6E0
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x230E8C0 Offset: 0x230DCC0 VA: 0x18230E8C0
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x230E970 Offset: 0x230DD70 VA: 0x18230E970
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x230E7E0 Offset: 0x230DBE0 VA: 0x18230E7E0
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x230EB80 Offset: 0x230DF80 VA: 0x18230EB80
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}

public static class Input // TypeDefIndex: 6667
{
// Namespace: Facepunch
public static class Input // TypeDefIndex: 6667
	// Fields
	private static readonly Memoized<string, string> WithoutFirstChar; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<string, bool> RunBind; // 0x8
	private static List<Input.Button> buttons; // 0x10
	private static List<Action> frameThinks; // 0x18

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2309FC0 Offset: 0x23093C0 VA: 0x182309FC0
	public static void add_RunBind(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230A0C0 Offset: 0x23094C0 VA: 0x18230A0C0
	public static void remove_RunBind(Action<string, bool> value) { }

	// RVA: 0x2308D60 Offset: 0x2308160 VA: 0x182308D60
	public static void Frame() { }

	// RVA: 0x2309D30 Offset: 0x2309130 VA: 0x182309D30
	public static void Update() { }

	// RVA: 0x2308A50 Offset: 0x2307E50 VA: 0x182308A50
	public static void AddButton(string name, KeyCode key, Func<bool> TestFunction, Action FrameThink, bool transient = False) { }

	// RVA: 0x2309AE0 Offset: 0x2308EE0 VA: 0x182309AE0
	public static bool HasButton(string name) { }

	// RVA: 0x2309C30 Offset: 0x2309030 VA: 0x182309C30
	public static void SetBind(string name, string bind, bool cycled = False) { }

	// RVA: 0x2309140 Offset: 0x2308540 VA: 0x182309140
	public static string GetBind(string name) { }

	// RVA: 0x23094D0 Offset: 0x23088D0 VA: 0x1823094D0
	public static Input.Button GetButton(string name) { }

	// RVA: 0x2308C20 Offset: 0x2308020 VA: 0x182308C20
	public static void ClearBinds() { }

	// RVA: 0x2308E30 Offset: 0x2308230 VA: 0x182308E30
	public static Dictionary<string, Input.Button> GetAllBinds() { }

	// RVA: 0x2309010 Offset: 0x2308410 VA: 0x182309010
	public static string[] GetAllButtons() { }

	// RVA: 0x23098F0 Offset: 0x2308CF0 VA: 0x1823098F0
	public static string[] GetPressedButtons() { }

	// RVA: 0x2309740 Offset: 0x2308B40 VA: 0x182309740
	public static string[] GetButtonsWithBind(string bind) { }

	// RVA: 0x2309B40 Offset: 0x2308F40 VA: 0x182309B40
	public static bool IsBindInUse(string bind) { }

	// RVA: 0x23092B0 Offset: 0x23086B0 VA: 0x1823092B0
	public static string GetButtonWithBind(string bind) { }

	// RVA: 0x23091D0 Offset: 0x23085D0 VA: 0x1823091D0
	public static Input.Button GetButtonObjectWithBind(string bind) { }

	// RVA: 0x23095B0 Offset: 0x23089B0 VA: 0x1823095B0
	public static void GetButtonsWithBind(string bind, List<Input.Button> results) { }

	// RVA: 0x2309E80 Offset: 0x2309280 VA: 0x182309E80
	private static void .cctor() { }

}

public class Input.Button // TypeDefIndex: 6668
{	// Fields
	public string Name; // 0x10
	public Func<bool> TestFunction; // 0x18
	public bool CurrentValue; // 0x20
	public bool LastValue; // 0x21
	public string[] Binds; // 0x28
	public bool Transient; // 0x30
	public bool Cycle; // 0x31
	public int CycleIndex; // 0x34
	public KeyCode Code; // 0x38

	// Methods

	// RVA: 0x23089C0 Offset: 0x2307DC0 VA: 0x1823089C0 Slot: 4
	public virtual void Update() { }

	// RVA: 0x2308880 Offset: 0x2307C80 VA: 0x182308880
	private void RunBinds(bool pressed) { }

	// RVA: 0x2308760 Offset: 0x2307B60 VA: 0x182308760
	private static void RunBindImpl(string bind, bool pressed) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class Input.<>c__DisplayClass13_0 // TypeDefIndex: 6669
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x230A240 Offset: 0x2309640 VA: 0x18230A240
	internal bool <GetButton>b__0(Input.Button x) { }

}

private sealed class Input.<>c // TypeDefIndex: 6670
{	// Fields
	public static readonly Input.<>c <>9; // 0x0
	public static Func<Input.Button, bool> <>9__15_0; // 0x8
	public static Func<Input.Button, string> <>9__15_1; // 0x10
	public static Func<Input.Button, string> <>9__16_0; // 0x18
	public static Func<Input.Button, bool> <>9__17_0; // 0x20
	public static Func<Input.Button, string> <>9__17_1; // 0x28
	public static Func<Input.Button, string> <>9__18_1; // 0x30

	// Methods

	// RVA: 0x230A3C0 Offset: 0x23097C0 VA: 0x18230A3C0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x230A1C0 Offset: 0x23095C0 VA: 0x18230A1C0
	internal bool <GetAllBinds>b__15_0(Input.Button x) { }

	// RVA: 0x6C6330 Offset: 0x6C5730 VA: 0x1806C6330
	internal string <GetAllBinds>b__15_1(Input.Button x) { }

	// RVA: 0x6C6330 Offset: 0x6C5730 VA: 0x1806C6330
	internal string <GetAllButtons>b__16_0(Input.Button x) { }

	// RVA: 0x230A1F0 Offset: 0x23095F0 VA: 0x18230A1F0
	internal bool <GetPressedButtons>b__17_0(Input.Button x) { }

	// RVA: 0x6C6330 Offset: 0x6C5730 VA: 0x1806C6330
	internal string <GetPressedButtons>b__17_1(Input.Button x) { }

	// RVA: 0x6C6330 Offset: 0x6C5730 VA: 0x1806C6330
	internal string <GetButtonsWithBind>b__18_1(Input.Button x) { }

	// RVA: 0x230A210 Offset: 0x2309610 VA: 0x18230A210
	internal string <.cctor>b__23_0(string s) { }

}

private sealed class Input.<>c__DisplayClass18_0 // TypeDefIndex: 6671
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x230A270 Offset: 0x2309670 VA: 0x18230A270
	internal bool <GetButtonsWithBind>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass19_0 // TypeDefIndex: 6672
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x230A2E0 Offset: 0x23096E0 VA: 0x18230A2E0
	internal bool <IsBindInUse>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass21_0 // TypeDefIndex: 6673
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x230A350 Offset: 0x2309750 VA: 0x18230A350
	internal bool <GetButtonObjectWithBind>b__0(Input.Button x) { }

}

public class Input : ConsoleSystem // TypeDefIndex: 11932
{	// Fields
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
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

	// Methods

	[ClientVar] // RVA: 0xA73D0 Offset: 0xA67D0 VA: 0x1800A73D0
	// RVA: 0x362CF0 Offset: 0x3620F0 VA: 0x180362CF0
	public static string bind(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x362F50 Offset: 0x362350 VA: 0x180362F50
	public static void clearbinds(ConsoleSystem.Arg arg) { }

	// RVA: 0x362C90 Offset: 0x362090 VA: 0x180362C90
	public void .ctor() { }

	// RVA: 0x362BA0 Offset: 0x361FA0 VA: 0x180362BA0
	private static void .cctor() { }

}

