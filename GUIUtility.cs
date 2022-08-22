public class GUIUtility // TypeDefIndex: 4051
{	[VisibleToOtherModulesAttribute] // RVA: 0xD66D0 Offset: 0xD5AD0 VA: 0x1800D66D0
	internal static int s_SkinMode; // 0x0
	[VisibleToOtherModulesAttribute] // RVA: 0xD6830 Offset: 0xD5C30 VA: 0x1800D6830
	internal static int s_OriginalID; // 0x4
	[VisibleToOtherModulesAttribute] // RVA: 0xD6990 Offset: 0xD5D90 VA: 0x1800D6990
	internal static Action takeCapture; // 0x8
	[VisibleToOtherModulesAttribute] // RVA: 0xD6A90 Offset: 0xD5E90 VA: 0x1800D6A90
	internal static Action releaseCapture; // 0x10
	[VisibleToOtherModulesAttribute] // RVA: 0xD6CA0 Offset: 0xD60A0 VA: 0x1800D6CA0
	internal static Func<int, IntPtr, bool> processEvent; // 0x18
	[VisibleToOtherModulesAttribute] // RVA: 0xD6F80 Offset: 0xD6380 VA: 0x1800D6F80
	internal static Action cleanupRoots; // 0x20
	[VisibleToOtherModulesAttribute] // RVA: 0xD70E0 Offset: 0xD64E0 VA: 0x1800D70E0
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x28
	[VisibleToOtherModulesAttribute] // RVA: 0xD7230 Offset: 0xD6630 VA: 0x1800D7230
	internal static Action guiChanged; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static bool <guiIsExiting>k__BackingField; // 0x38
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x40

	[NativePropertyAttribute] // RVA: 0xDAE40 Offset: 0xDA240 VA: 0x1800DAE40
	internal static float pixelsPerPoint { get; }
	[NativePropertyAttribute] // RVA: 0xDAEF0 Offset: 0xDA2F0 VA: 0x1800DAEF0
	internal static int guiDepth { get; }
	[NativePropertyAttribute] // RVA: 0xDB100 Offset: 0xDA500 VA: 0x1800DB100
	internal static bool mouseUsed { set; }
	[StaticAccessorAttribute] // RVA: 0xDB1F0 Offset: 0xDA5F0 VA: 0x1800DB1F0
	internal static bool textFieldInput { set; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessorAttribute] // RVA: 0xDB290 Offset: 0xDA690 VA: 0x1800DB290
	internal static string compositionString { get; }
	[StaticAccessorAttribute] // RVA: 0xDB290 Offset: 0xDA690 VA: 0x1800DB290
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }


	[VisibleToOtherModulesAttribute] // RVA: 0xD7490 Offset: 0xD6890 VA: 0x1800D7490
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD7560 Offset: 0xD6960 VA: 0x1800D7560
	internal static int get_guiDepth() { }

	internal static void set_mouseUsed(bool value) { }

	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD89F0 Offset: 0xD7DF0 VA: 0x1800D89F0
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xD8A20 Offset: 0xD7E20 VA: 0x1800D8A20
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0xD8AA0 Offset: 0xD7EA0 VA: 0x1800D8AA0
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8C70 Offset: 0xD8070 VA: 0x1800D8C70
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8F60 Offset: 0xD8360 VA: 0x1800D8F60
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] // RVA: 0xD9180 Offset: 0xD8580 VA: 0x1800D9180
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD91B0 Offset: 0xD85B0 VA: 0x1800D91B0
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9450 Offset: 0xD8850 VA: 0x1800D9450
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD96D0 Offset: 0xD8AD0 VA: 0x1800D96D0
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9920 Offset: 0xD8D20 VA: 0x1800D9920
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9BF0 Offset: 0xD8FF0 VA: 0x1800D9BF0
	internal static bool OwnsId(int id) { }

	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9D10 Offset: 0xD9110 VA: 0x1800D9D10
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9E10 Offset: 0xD9210 VA: 0x1800D9E10
	internal static void set_compositionCursorPos(Vector2 value) { }

	private static int Internal_GetHotControl() { }

	private static int Internal_GetKeyboardControl() { }

	private static void Internal_SetHotControl(int value) { }

	private static void Internal_SetKeyboardControl(int value) { }

	private static object Internal_GetDefaultSkin(int skinMode) { }

	private static void Internal_ExitGUI() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void MarkGUIChanged() { }

	public static int GetControlID(FocusType focus) { }

	public static int GetControlID(int hint, FocusType focus) { }

	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void set_guiIsExiting(bool value) { }

	public static int get_hotControl() { }

	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void RemoveCapture() { }

	public static int get_keyboardControl() { }

	public static void set_keyboardControl(int value) { }

	internal static bool HasKeyFocus(int controlID) { }

	public static void ExitGUI() { }

	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA3E0 Offset: 0xD97E0 VA: 0x1800DA3E0
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA8B0 Offset: 0xD9CB0 VA: 0x1800DA8B0
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA9F0 Offset: 0xD9DF0 VA: 0x1800DA9F0
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAB20 Offset: 0xD9F20 VA: 0x1800DAB20
	internal static bool ShouldRethrowException(Exception exception) { }

	internal static void CheckOnGUI() { }

	public static void RotateAroundPivot(float angle, Vector2 pivotPoint) { }

	public static Rect AlignRectToDevice(Rect rect) { }

	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	internal static bool HitTest(Rect rect, Event evt) { }

	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}

