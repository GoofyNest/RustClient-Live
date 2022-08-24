public sealed class GUIStyle // TypeDefIndex: 4048
{
	internal IntPtr m_Ptr; 
	private GUIStyleState m_Normal; 
	private GUIStyleState m_Hover; 
	private GUIStyleState m_Active; 
	private GUIStyleState m_Focused; 
	private GUIStyleState m_OnNormal; 
	private GUIStyleState m_OnHover; 
	private GUIStyleState m_OnActive; 
	private GUIStyleState m_OnFocused; 
	private RectOffset m_Border; 
	private RectOffset m_Padding; 
	private RectOffset m_Margin; 
	private RectOffset m_Overflow; 
	private string m_Name; 
	internal static bool showKeyboardFocus; 
	private static GUIStyle s_None; 

	[NativePropertyAttribute] 
	internal string rawName { get; set; }
	[NativePropertyAttribute] 
	public Font font { get; }
	[NativePropertyAttribute] 
	public ImagePosition imagePosition { get; }
	[NativePropertyAttribute] 
	public TextAnchor alignment { set; }
	[NativePropertyAttribute] 
	public bool wordWrap { get; }
	[NativePropertyAttribute] 
	public Vector2 contentOffset { get; set; }
	[NativePropertyAttribute] 
	public float fixedWidth { get; }
	[NativePropertyAttribute] 
	public float fixedHeight { get; }
	[NativePropertyAttribute] 
	public bool stretchWidth { get; set; }
	[NativePropertyAttribute] 
	public bool stretchHeight { get; set; }
	[NativePropertyAttribute] 
	public int fontSize { set; }
	[NativePropertyAttribute] 
	internal Vector2 Internal_clipOffset { set; }
	public string name { get; set; }
	public GUIStyleState normal { get; }
	public RectOffset margin { get; }
	public RectOffset padding { get; }
	public float lineHeight { get; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }


	internal string get_rawName() { }

	internal void set_rawName(string value) { }

	public Font get_font() { }

	public ImagePosition get_imagePosition() { }

	public void set_alignment(TextAnchor value) { }

	public bool get_wordWrap() { }

	public Vector2 get_contentOffset() { }

	public void set_contentOffset(Vector2 value) { }

	public float get_fixedWidth() { }

	public float get_fixedHeight() { }

	public bool get_stretchWidth() { }

	public void set_stretchWidth(bool value) { }

	public bool get_stretchHeight() { }

	public void set_stretchHeight(bool value) { }

	public void set_fontSize(int value) { }

	internal void set_Internal_clipOffset(Vector2 value) { }

	[FreeFunctionAttribute] 
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] 
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunctionAttribute] 
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] 
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] 
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] 
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunctionAttribute] 
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] 
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] 
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunctionAttribute] 
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunctionAttribute] 
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunctionAttribute] 
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunctionAttribute] 
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunctionAttribute] 
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] 
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] 
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] 
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] 
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] 
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunctionAttribute] 
	internal static void SetDefaultFont(Font font) { }

	public void .ctor() { }

	public void .ctor(GUIStyle other) { }

	protected override void Finalize() { }

	public string get_name() { }

	public void set_name(string value) { }

	public GUIStyleState get_normal() { }

	public RectOffset get_margin() { }

	public RectOffset get_padding() { }

	public float get_lineHeight() { }

	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	public static GUIStyle op_Implicit(string str) { }

	public static GUIStyle get_none() { }

	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	public Vector2 CalcSize(GUIContent content) { }

	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	public float CalcHeight(GUIContent content, float width) { }

	public bool get_isHeightDependantOnWidth() { }

	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	public override string ToString() { }

	private static void .cctor() { }

	private void get_contentOffset_Injected(out Vector2 ret) { }

	private void set_contentOffset_Injected(ref Vector2 value) { }

	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

}

