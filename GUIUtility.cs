public class GUIUtility // TypeDefIndex: 4051
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0xD66D0 Offset: 0xD5AD0 VA: 0x1800D66D0
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

	// Properties
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

	// Methods

	[VisibleToOtherModulesAttribute] // RVA: 0xD7490 Offset: 0xD6890 VA: 0x1800D7490
	// RVA: 0x1A6F170 Offset: 0x1A6E570 VA: 0x181A6F170
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD7560 Offset: 0xD6960 VA: 0x1800D7560
	// RVA: 0x1A6F140 Offset: 0x1A6E540 VA: 0x181A6F140
	internal static int get_guiDepth() { }

	// RVA: 0x1A6F290 Offset: 0x1A6E690 VA: 0x181A6F290
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x1A6F310 Offset: 0x1A6E710 VA: 0x181A6F310
	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD89F0 Offset: 0xD7DF0 VA: 0x1800D89F0
	// RVA: 0x1A6F1A0 Offset: 0x1A6E5A0 VA: 0x181A6F1A0
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xD8A20 Offset: 0xD7E20 VA: 0x1800D8A20
	// RVA: 0x1A6F2D0 Offset: 0x1A6E6D0 VA: 0x181A6F2D0
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0xD8AA0 Offset: 0xD7EA0 VA: 0x1800D8AA0
	// RVA: 0x1A6E290 Offset: 0x1A6D690 VA: 0x181A6E290
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8C70 Offset: 0xD8070 VA: 0x1800D8C70
	// RVA: 0x1A6D9C0 Offset: 0x1A6CDC0 VA: 0x181A6D9C0
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8F60 Offset: 0xD8360 VA: 0x1800D8F60
	// RVA: 0x1A6DA00 Offset: 0x1A6CE00 VA: 0x181A6DA00
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] // RVA: 0xD9180 Offset: 0xD8580 VA: 0x1800D9180
	// RVA: 0x1A6E810 Offset: 0x1A6DC10 VA: 0x181A6E810
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD91B0 Offset: 0xD85B0 VA: 0x1800D91B0
	// RVA: 0x1A6DBD0 Offset: 0x1A6CFD0 VA: 0x181A6DBD0
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9450 Offset: 0xD8850 VA: 0x1800D9450
	// RVA: 0x1A6F060 Offset: 0x1A6E460 VA: 0x181A6F060
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD96D0 Offset: 0xD8AD0 VA: 0x1800D96D0
	// RVA: 0x1A6F090 Offset: 0x1A6E490 VA: 0x181A6F090
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9920 Offset: 0xD8D20 VA: 0x1800D9920
	// RVA: 0x1A6E4B0 Offset: 0x1A6D8B0 VA: 0x181A6E4B0
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9BF0 Offset: 0xD8FF0 VA: 0x1800D9BF0
	// RVA: 0x1A6EA60 Offset: 0x1A6DE60 VA: 0x181A6EA60
	internal static bool OwnsId(int id) { }

	// RVA: 0x1A6D8E0 Offset: 0x1A6CCE0 VA: 0x181A6D8E0
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9D10 Offset: 0xD9110 VA: 0x1800D9D10
	// RVA: 0x1A6F110 Offset: 0x1A6E510 VA: 0x181A6F110
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9E10 Offset: 0xD9210 VA: 0x1800D9E10
	// RVA: 0x1A6F210 Offset: 0x1A6E610 VA: 0x181A6F210
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1A6E8B0 Offset: 0x1A6DCB0 VA: 0x181A6E8B0
	private static int Internal_GetHotControl() { }

	// RVA: 0x1A6E8E0 Offset: 0x1A6DCE0 VA: 0x181A6E8E0
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x1A6E910 Offset: 0x1A6DD10 VA: 0x181A6E910
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x1A6E950 Offset: 0x1A6DD50 VA: 0x181A6E950
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x1A6E870 Offset: 0x1A6DC70 VA: 0x181A6E870
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x1A6E840 Offset: 0x1A6DC40 VA: 0x181A6E840
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A6EA10 Offset: 0x1A6DE10 VA: 0x181A6EA10
	private static void MarkGUIChanged() { }

	// RVA: 0x1A6E240 Offset: 0x1A6D640 VA: 0x181A6E240
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x1A6E1E0 Offset: 0x1A6D5E0 VA: 0x181A6E1E0
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x1A6E360 Offset: 0x1A6D760 VA: 0x181A6E360
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A6F250 Offset: 0x1A6E650 VA: 0x181A6F250
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x1A6E8B0 Offset: 0x1A6DCB0 VA: 0x181A6E8B0
	public static int get_hotControl() { }

	// RVA: 0x1A6E910 Offset: 0x1A6DD10 VA: 0x181A6E910
	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A6F0C0 Offset: 0x1A6E4C0 VA: 0x181A6F0C0
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A6EB10 Offset: 0x1A6DF10 VA: 0x181A6EB10
	internal static void RemoveCapture() { }

	// RVA: 0x1A6E8E0 Offset: 0x1A6DCE0 VA: 0x181A6E8E0
	public static int get_keyboardControl() { }

	// RVA: 0x1A6E950 Offset: 0x1A6DD50 VA: 0x181A6E950
	public static void set_keyboardControl(int value) { }

	// RVA: 0x1A6E4E0 Offset: 0x1A6D8E0 VA: 0x181A6E4E0
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x1A6E140 Offset: 0x1A6D540 VA: 0x181A6E140
	public static void ExitGUI() { }

	// RVA: 0x1A6E2E0 Offset: 0x1A6D6E0 VA: 0x181A6E2E0
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A6EAA0 Offset: 0x1A6DEA0 VA: 0x181A6EAA0
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA3E0 Offset: 0xD97E0 VA: 0x1800DA3E0
	// RVA: 0x1A6DD00 Offset: 0x1A6D100 VA: 0x181A6DD00
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A6DA40 Offset: 0x1A6CE40 VA: 0x181A6DA40
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A6DDF0 Offset: 0x1A6D1F0 VA: 0x181A6DDF0
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A6DD50 Offset: 0x1A6D150 VA: 0x181A6DD50
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A6DCA0 Offset: 0x1A6D0A0 VA: 0x181A6DCA0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA8B0 Offset: 0xD9CB0 VA: 0x1800DA8B0
	// RVA: 0x1A6EB60 Offset: 0x1A6DF60 VA: 0x181A6EB60
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA9F0 Offset: 0xD9DF0 VA: 0x1800DA9F0
	// RVA: 0x1A6E990 Offset: 0x1A6DD90 VA: 0x181A6E990
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAB20 Offset: 0xD9F20 VA: 0x1800DAB20
	// RVA: 0x1A6E990 Offset: 0x1A6DD90 VA: 0x181A6E990
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x1A6DC10 Offset: 0x1A6D010 VA: 0x181A6DC10
	internal static void CheckOnGUI() { }

	// RVA: 0x1A6EC70 Offset: 0x1A6E070 VA: 0x181A6EC70
	public static void RotateAroundPivot(float angle, Vector2 pivotPoint) { }

	// RVA: 0x1A6D950 Offset: 0x1A6CD50 VA: 0x181A6D950
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x1A6E570 Offset: 0x1A6D970 VA: 0x181A6E570
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x1A6E610 Offset: 0x1A6DA10 VA: 0x181A6E610
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x1A6E6C0 Offset: 0x1A6DAC0 VA: 0x181A6E6C0
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x1A6E190 Offset: 0x1A6D590 VA: 0x181A6E190
	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x1A6D870 Offset: 0x1A6CC70 VA: 0x181A6D870
	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x1A6F1D0 Offset: 0x1A6E5D0 VA: 0x181A6F1D0
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}

