public class GUI // TypeDefIndex: 4030
{	// Fields
	private static int s_HotTextField; // 0x0
	private static readonly int s_BoxHash; // 0x4
	private static readonly int s_ButonHash; // 0x8
	private static readonly int s_RepeatButtonHash; // 0xC
	private static readonly int s_ToggleHash; // 0x10
	private static readonly int s_ButtonGridHash; // 0x14
	private static readonly int s_SliderHash; // 0x18
	private static readonly int s_BeginGroupHash; // 0x1C
	private static readonly int s_ScrollviewHash; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static int <scrollTroughSide>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x28
	private static GUISkin s_Skin; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static GenericStack <scrollViewStates>k__BackingField; // 0x38

	// Properties
	public static Color color { get; set; }
	public static Color backgroundColor { get; set; }
	public static Color contentColor { get; set; }
	public static bool changed { get; set; }
	public static bool enabled { get; set; }
	internal static bool usePageScrollbars { get; }
	internal static Material blendMaterial { get; }
	internal static Material blitMaterial { get; }
	internal static Material roundedRectMaterial { get; }
	internal static Material roundedRectWithColorPerBorderMaterial { get; }
	internal static int scrollTroughSide { get; set; }
	internal static DateTime nextScrollStepTime { get; set; }
	public static GUISkin skin { get; set; }
	public static Matrix4x4 matrix { get; set; }
	internal static GenericStack scrollViewStates { get; }

	// Methods

	// RVA: 0x1A76120 Offset: 0x1A75520 VA: 0x181A76120
	public static Color get_color() { }

	// RVA: 0x1A766C0 Offset: 0x1A75AC0 VA: 0x181A766C0
	public static void set_color(Color value) { }

	// RVA: 0x1A75FD0 Offset: 0x1A753D0 VA: 0x181A75FD0
	public static Color get_backgroundColor() { }

	// RVA: 0x1A765D0 Offset: 0x1A759D0 VA: 0x181A765D0
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x1A761E0 Offset: 0x1A755E0 VA: 0x181A761E0
	public static Color get_contentColor() { }

	// RVA: 0x1A76770 Offset: 0x1A75B70 VA: 0x181A76770
	public static void set_contentColor(Color value) { }

	// RVA: 0x1A760B0 Offset: 0x1A754B0 VA: 0x181A760B0
	public static bool get_changed() { }

	// RVA: 0x1A76640 Offset: 0x1A75A40 VA: 0x181A76640
	public static void set_changed(bool value) { }

	// RVA: 0x1A76260 Offset: 0x1A75660 VA: 0x181A76260
	public static bool get_enabled() { }

	// RVA: 0x1A767E0 Offset: 0x1A75BE0 VA: 0x181A767E0
	public static void set_enabled(bool value) { }

	// RVA: 0x1A76560 Offset: 0x1A75960 VA: 0x181A76560
	internal static bool get_usePageScrollbars() { }

	[FreeFunctionAttribute] // RVA: 0xCA800 Offset: 0xC9C00 VA: 0x1800CA800
	// RVA: 0x1A76050 Offset: 0x1A75450 VA: 0x181A76050
	internal static Material get_blendMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCA8B0 Offset: 0xC9CB0 VA: 0x1800CA8B0
	// RVA: 0x1A76080 Offset: 0x1A75480 VA: 0x181A76080
	internal static Material get_blitMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCA980 Offset: 0xC9D80 VA: 0x1800CA980
	// RVA: 0x1A76380 Offset: 0x1A75780 VA: 0x181A76380
	internal static Material get_roundedRectMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xCAB30 Offset: 0xC9F30 VA: 0x1800CAB30
	// RVA: 0x1A763B0 Offset: 0x1A757B0 VA: 0x181A763B0
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x1A74120 Offset: 0x1A73520 VA: 0x181A74120
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x1A74F10 Offset: 0x1A74310 VA: 0x181A74F10
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x1A75620 Offset: 0x1A74A20 VA: 0x181A75620
	internal static void ReleaseMouseControl() { }

	[FreeFunctionAttribute] // RVA: 0xCAC70 Offset: 0xCA070 VA: 0x1800CAC70
	// RVA: 0x1A758B0 Offset: 0x1A74CB0 VA: 0x181A758B0
	public static void SetNextControlName(string name) { }

	// RVA: 0x1A75230 Offset: 0x1A74630 VA: 0x181A75230
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x1A75D10 Offset: 0x1A75110 VA: 0x181A75D10
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A763E0 Offset: 0x1A757E0 VA: 0x181A763E0
	internal static int get_scrollTroughSide() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A76940 Offset: 0x1A75D40 VA: 0x181A76940
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A76320 Offset: 0x1A75720 VA: 0x181A76320
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A76880 Offset: 0x1A75C80 VA: 0x181A76880
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x1A76A00 Offset: 0x1A75E00 VA: 0x181A76A00
	public static void set_skin(GUISkin value) { }

	// RVA: 0x1A76500 Offset: 0x1A75900 VA: 0x181A76500
	public static GUISkin get_skin() { }

	// RVA: 0x1A725A0 Offset: 0x1A719A0 VA: 0x181A725A0
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x1A76290 Offset: 0x1A75690 VA: 0x181A76290
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x1A76820 Offset: 0x1A75C20 VA: 0x181A76820
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x1A75350 Offset: 0x1A74750 VA: 0x181A75350
	public static void Label(Rect position, string text) { }

	// RVA: 0x1A75260 Offset: 0x1A74660 VA: 0x181A75260
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x1A75460 Offset: 0x1A74860 VA: 0x181A75460
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A73730 Offset: 0x1A72B30 VA: 0x181A73730
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x1A732D0 Offset: 0x1A726D0 VA: 0x181A732D0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x1A73DE0 Offset: 0x1A731E0 VA: 0x181A73DE0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x1A73CA0 Offset: 0x1A730A0 VA: 0x181A73CA0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x1A73470 Offset: 0x1A72870 VA: 0x181A73470
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x1A73A70 Offset: 0x1A72E70 VA: 0x181A73A70
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x1A73F50 Offset: 0x1A73350 VA: 0x181A73F50
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x1A73910 Offset: 0x1A72D10 VA: 0x181A73910
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1A72D20 Offset: 0x1A72120 VA: 0x181A72D20
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1A708F0 Offset: 0x1A6FCF0 VA: 0x181A708F0
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x1A6FCE0 Offset: 0x1A6F0E0 VA: 0x181A6FCE0
	public static void Box(Rect position, string text) { }

	// RVA: 0x1A6FAE0 Offset: 0x1A6EEE0 VA: 0x181A6FAE0
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6FDA0 Offset: 0x1A6F1A0 VA: 0x181A6FDA0
	public static bool Button(Rect position, string text) { }

	// RVA: 0x1A6FFD0 Offset: 0x1A6F3D0 VA: 0x181A6FFD0
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6FE60 Offset: 0x1A6F260 VA: 0x181A6FE60
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A754F0 Offset: 0x1A748F0 VA: 0x181A754F0
	internal static string PasswordFieldGetStrToShow(string password, char maskChar) { }

	// RVA: 0x1A72A20 Offset: 0x1A71E20 VA: 0x181A72A20
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x1A72B20 Offset: 0x1A71F20 VA: 0x181A72B20
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x1A72750 Offset: 0x1A71B50 VA: 0x181A72750
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) { }

	// RVA: 0x1A74950 Offset: 0x1A73D50 VA: 0x181A74950
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) { }

	// RVA: 0x1A74160 Offset: 0x1A73560 VA: 0x181A74160
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x1A75B50 Offset: 0x1A74F50 VA: 0x181A75B50
	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A75750 Offset: 0x1A74B50 VA: 0x181A75750
	public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount) { }

	// RVA: 0x1A75650 Offset: 0x1A74A50 VA: 0x181A75650
	public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style) { }

	// RVA: 0x1A706E0 Offset: 0x1A6FAE0 VA: 0x181A706E0
	internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) { }

	// RVA: 0x1A71ED0 Offset: 0x1A712D0 VA: 0x181A71ED0
	private static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A72310 Offset: 0x1A71710 VA: 0x181A72310
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A72BE0 Offset: 0x1A71FE0 VA: 0x181A72BE0
	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A71DA0 Offset: 0x1A711A0 VA: 0x181A71DA0
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A710B0 Offset: 0x1A704B0 VA: 0x181A710B0
	private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled) { }

	// RVA: 0x1A701C0 Offset: 0x1A6F5C0 VA: 0x181A701C0
	private static Rect[] CalcMouseRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders, GUI.ToolbarButtonSize buttonSize) { }

	// RVA: 0x1A75020 Offset: 0x1A74420 VA: 0x181A75020
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue) { }

	// RVA: 0x1A74F50 Offset: 0x1A74350 VA: 0x181A74F50
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x1A758F0 Offset: 0x1A74CF0 VA: 0x181A758F0
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x1A6F6C0 Offset: 0x1A6EAC0 VA: 0x181A6F6C0
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A6F780 Offset: 0x1A6EB80 VA: 0x181A6F780
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x1A740E0 Offset: 0x1A734E0 VA: 0x181A740E0
	public static void EndGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A764A0 Offset: 0x1A758A0 VA: 0x181A764A0
	internal static GenericStack get_scrollViewStates() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A70C20 Offset: 0x1A70020 VA: 0x181A70C20
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x1A760E0 Offset: 0x1A754E0 VA: 0x181A760E0
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x1A76680 Offset: 0x1A75A80 VA: 0x181A76680
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x1A75F90 Offset: 0x1A75390 VA: 0x181A75F90
	private static void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x1A76590 Offset: 0x1A75990 VA: 0x181A76590
	private static void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x1A761A0 Offset: 0x1A755A0 VA: 0x181A761A0
	private static void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x1A76730 Offset: 0x1A75B30 VA: 0x181A76730
	private static void set_contentColor_Injected(ref Color value) { }

}

public enum GUI.ToolbarButtonSize // TypeDefIndex: 4031
{	// Fields
	public int value__; // 0x0
	public const GUI.ToolbarButtonSize Fixed = 0;
	public const GUI.ToolbarButtonSize FitToContents = 1;

}

public sealed class GUI.WindowFunction : MulticastDelegate // TypeDefIndex: 4032
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A378D0 Offset: 0x1A36CD0 VA: 0x181A378D0 Slot: 12
	public virtual void Invoke(int id) { }

	// RVA: 0x1A791D0 Offset: 0x1A785D0 VA: 0x181A791D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

