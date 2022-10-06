public class GUIUtility // TypeDefIndex: 4054
{
	[VisibleToOtherModulesAttribute] 
	internal static int s_SkinMode; 
	[VisibleToOtherModulesAttribute] 
	internal static int s_OriginalID; 
	[VisibleToOtherModulesAttribute] 
	internal static Action takeCapture; 
	[VisibleToOtherModulesAttribute] 
	internal static Action releaseCapture; 
	[VisibleToOtherModulesAttribute] 
	internal static Func<int, IntPtr, bool> processEvent; 
	[VisibleToOtherModulesAttribute] 
	internal static Action cleanupRoots; 
	[VisibleToOtherModulesAttribute] 
	internal static Func<Exception, bool> endContainerGUIFromException; 
	[VisibleToOtherModulesAttribute] 
	internal static Action guiChanged; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static bool <guiIsExiting>k__BackingField; 
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; 

	[NativePropertyAttribute] 
	internal static float pixelsPerPoint { get; }
	[NativePropertyAttribute] 
	internal static int guiDepth { get; }
	[NativePropertyAttribute] 
	internal static bool mouseUsed { set; }
	[StaticAccessorAttribute] 
	internal static bool textFieldInput { set; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessorAttribute] 
	internal static string compositionString { get; }
	[StaticAccessorAttribute] 
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }


	[VisibleToOtherModulesAttribute] 
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] 
	internal static int get_guiDepth() { }

	internal static void set_mouseUsed(bool value) { }

	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] 
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] 
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] 
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] 
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] 
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] 
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] 
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] 
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] 
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] 
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] 
	internal static bool OwnsId(int id) { }

	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] 
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] 
	internal static void set_compositionCursorPos(Vector2 value) { }

	private static int Internal_GetHotControl() { }

	private static int Internal_GetKeyboardControl() { }

	private static void Internal_SetHotControl(int value) { }

	private static void Internal_SetKeyboardControl(int value) { }

	private static object Internal_GetDefaultSkin(int skinMode) { }

	private static void Internal_ExitGUI() { }

	[RequiredByNativeCodeAttribute] 
	private static void MarkGUIChanged() { }

	public static int GetControlID(FocusType focus) { }

	public static int GetControlID(int hint, FocusType focus) { }

	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] 
	internal static void set_guiIsExiting(bool value) { }

	public static int get_hotControl() { }

	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] 
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] 
	internal static void RemoveCapture() { }

	public static int get_keyboardControl() { }

	public static void set_keyboardControl(int value) { }

	internal static bool HasKeyFocus(int controlID) { }

	public static void ExitGUI() { }

	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] 
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[VisibleToOtherModulesAttribute] 
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] 
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] 
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] 
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] 
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] 
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] 
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] 
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

