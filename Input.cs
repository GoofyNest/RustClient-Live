public class Input // TypeDefIndex: 4075
{
	[NativeThrowsAttribute] 
	public static bool anyKey { get; }
	[NativeThrowsAttribute] 
	public static bool anyKeyDown { get; }
	[NativeThrowsAttribute] 
	public static Vector3 mousePosition { get; }
	[NativeThrowsAttribute] 
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static bool mousePresent { get; }
	public static int touchCount { get; }
	public static bool touchSupported { get; }
	public static Touch[] touches { get; }


	[NativeThrowsAttribute] 
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrowsAttribute] 
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrowsAttribute] 
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrowsAttribute] 
	public static float GetAxis(string axisName) { }

	[NativeThrowsAttribute] 
	public static float GetAxisRaw(string axisName) { }

	[NativeThrowsAttribute] 
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrowsAttribute] 
	public static bool GetMouseButton(int button) { }

	[NativeThrowsAttribute] 
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrowsAttribute] 
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrowsAttribute] 
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

	[FreeFunctionAttribute] 
	public static bool get_mousePresent() { }

	[FreeFunctionAttribute] 
	public static int get_touchCount() { }

	[FreeFunctionAttribute] 
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

public static class Input 
	private static readonly Memoized<string, string> WithoutFirstChar; 
	[CompilerGeneratedAttribute] 
	private static Action<string, bool> RunBind; 
	private static List<Input.Button> buttons; 
	private static List<Action> frameThinks; 


	[CompilerGeneratedAttribute] 
	public static void add_RunBind(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] 
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
{
	public string Name; 
	public Func<bool> TestFunction; 
	public bool CurrentValue; 
	public bool LastValue; 
	public string[] Binds; 
	public bool Transient; 
	public bool Cycle; 
	public int CycleIndex; 
	public KeyCode Code; 


	public virtual void Update() { }

	private void RunBinds(bool pressed) { }

	private static void RunBindImpl(string bind, bool pressed) { }

	public void .ctor() { }

}

private sealed class Input.<>c__DisplayClass13_0 // TypeDefIndex: 6669
{
	public string name; 


	public void .ctor() { }

	internal bool <GetButton>b__0(Input.Button x) { }

}

private sealed class Input.<>c // TypeDefIndex: 6670
{
	public static readonly Input.<>c <>9; 
	public static Func<Input.Button, bool> <>9__15_0; 
	public static Func<Input.Button, string> <>9__15_1; 
	public static Func<Input.Button, string> <>9__16_0; 
	public static Func<Input.Button, bool> <>9__17_0; 
	public static Func<Input.Button, string> <>9__17_1; 
	public static Func<Input.Button, string> <>9__18_1; 


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
{
	public string bind; 


	public void .ctor() { }

	internal bool <GetButtonsWithBind>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass19_0 // TypeDefIndex: 6672
{
	public string bind; 


	public void .ctor() { }

	internal bool <IsBindInUse>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass21_0 // TypeDefIndex: 6673
{
	public string bind; 


	public void .ctor() { }

	internal bool <GetButtonObjectWithBind>b__0(Input.Button x) { }

}

public class Input : ConsoleSystem // TypeDefIndex: 11932
{
	[ClientVar] 
	public static bool flipy; 
	[ClientVar] 
	public static bool autocrouch; 
	[ClientVar] 
	public static float sensitivity; 
	[ClientVar] 
	public static float ads_sensitivity; 
	[ClientVar] 
	public static float vehicle_sensitivity; 
	[ClientVar] 
	public static bool vehicle_flipy; 
	[ClientVar] 
	public static bool toggleDuck; 
	[ClientVar] 
	public static bool alwayssprint; 
	[ClientVar] 
	public static bool toggleAds; 
	[ClientVar] 
	public static float holdtime; 


	[ClientVar] 
	public static string bind(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void clearbinds(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

