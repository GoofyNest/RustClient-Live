public class GUI // TypeDefIndex: 4030
{
	private static int s_HotTextField; 
	private static readonly int s_BoxHash; 
	private static readonly int s_ButonHash; 
	private static readonly int s_RepeatButtonHash; 
	private static readonly int s_ToggleHash; 
	private static readonly int s_ButtonGridHash; 
	private static readonly int s_SliderHash; 
	private static readonly int s_BeginGroupHash; 
	private static readonly int s_ScrollviewHash; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static int <scrollTroughSide>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static DateTime <nextScrollStepTime>k__BackingField; 
	private static GUISkin s_Skin; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static GenericStack <scrollViewStates>k__BackingField; 

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


public static Color get_color() { }

public static void set_color(Color value) { }

public static Color get_backgroundColor() { }

public static void set_backgroundColor(Color value) { }

public static Color get_contentColor() { }

public static void set_contentColor(Color value) { }

public static bool get_changed() { }

public static void set_changed(bool value) { }

public static bool get_enabled() { }

public static void set_enabled(bool value) { }

internal static bool get_usePageScrollbars() { }

	[FreeFunctionAttribute] 
internal static Material get_blendMaterial() { }

	[FreeFunctionAttribute] 
internal static Material get_blitMaterial() { }

	[FreeFunctionAttribute] 
internal static Material get_roundedRectMaterial() { }

	[FreeFunctionAttribute] 
internal static Material get_roundedRectWithColorPerBorderMaterial() { }

internal static void GrabMouseControl(int id) { }

internal static bool HasMouseControl(int id) { }

internal static void ReleaseMouseControl() { }

	[FreeFunctionAttribute] 
public static void SetNextControlName(string name) { }

internal static void InternalRepaintEditorWindow() { }

private static void .cctor() { }

	[CompilerGeneratedAttribute] 
internal static int get_scrollTroughSide() { }

	[CompilerGeneratedAttribute] 
internal static void set_scrollTroughSide(int value) { }

	[CompilerGeneratedAttribute] 
internal static DateTime get_nextScrollStepTime() { }

	[CompilerGeneratedAttribute] 
internal static void set_nextScrollStepTime(DateTime value) { }

public static void set_skin(GUISkin value) { }

public static GUISkin get_skin() { }

internal static void DoSetSkin(GUISkin newSkin) { }

public static Matrix4x4 get_matrix() { }

public static void set_matrix(Matrix4x4 value) { }

public static void Label(Rect position, string text) { }

public static void Label(Rect position, string text, GUIStyle style) { }

public static void Label(Rect position, GUIContent content, GUIStyle style) { }

public static void DrawTexture(Rect position, Texture image) { }

public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

public static void Box(Rect position, string text) { }

public static void Box(Rect position, GUIContent content, GUIStyle style) { }

public static bool Button(Rect position, string text) { }

public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

internal static string PasswordFieldGetStrToShow(string password, char maskChar) { }

internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) { }

private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) { }

private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount) { }

public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style) { }

internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) { }

private static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled) { }

private static Rect[] CalcMouseRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders, GUI.ToolbarButtonSize buttonSize) { }

public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue) { }

public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

public static void EndGroup() { }

	[CompilerGeneratedAttribute] 
internal static GenericStack get_scrollViewStates() { }

	[RequiredByNativeCodeAttribute] 
internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

private static void get_color_Injected(out Color ret) { }

private static void set_color_Injected(ref Color value) { }

private static void get_backgroundColor_Injected(out Color ret) { }

private static void set_backgroundColor_Injected(ref Color value) { }

private static void get_contentColor_Injected(out Color ret) { }

private static void set_contentColor_Injected(ref Color value) { }

}

public enum GUI.ToolbarButtonSize // TypeDefIndex: 4031
{
	public int value__; 
public const GUI.ToolbarButtonSize Fixed = 0;
public const GUI.ToolbarButtonSize FitToContents = 1;

}

public sealed class GUI.WindowFunction : MulticastDelegate // TypeDefIndex: 4032
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(int id) { }

public virtual IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

