public sealed class GUIStyle // TypeDefIndex: 4048
{	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	[NativePropertyAttribute] // RVA: 0xD5A10 Offset: 0xD4E10 VA: 0x1800D5A10
	internal string rawName { get; set; }
	[NativePropertyAttribute] // RVA: 0xD5A90 Offset: 0xD4E90 VA: 0x1800D5A90
	public Font font { get; }
	[NativePropertyAttribute] // RVA: 0xD5B20 Offset: 0xD4F20 VA: 0x1800D5B20
	public ImagePosition imagePosition { get; }
	[NativePropertyAttribute] // RVA: 0xD5C50 Offset: 0xD5050 VA: 0x1800D5C50
	public TextAnchor alignment { set; }
	[NativePropertyAttribute] // RVA: 0xD5D70 Offset: 0xD5170 VA: 0x1800D5D70
	public bool wordWrap { get; }
	[NativePropertyAttribute] // RVA: 0xD5DB0 Offset: 0xD51B0 VA: 0x1800D5DB0
	public Vector2 contentOffset { get; set; }
	[NativePropertyAttribute] // RVA: 0xD5DF0 Offset: 0xD51F0 VA: 0x1800D5DF0
	public float fixedWidth { get; }
	[NativePropertyAttribute] // RVA: 0xD5EC0 Offset: 0xD52C0 VA: 0x1800D5EC0
	public float fixedHeight { get; }
	[NativePropertyAttribute] // RVA: 0xD6020 Offset: 0xD5420 VA: 0x1800D6020
	public bool stretchWidth { get; set; }
	[NativePropertyAttribute] // RVA: 0xD6180 Offset: 0xD5580 VA: 0x1800D6180
	public bool stretchHeight { get; set; }
	[NativePropertyAttribute] // RVA: 0xD6210 Offset: 0xD5610 VA: 0x1800D6210
	public int fontSize { set; }
	[NativePropertyAttribute] // RVA: 0xD62A0 Offset: 0xD56A0 VA: 0x1800D62A0
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

	[FreeFunctionAttribute] // RVA: 0xD1FE0 Offset: 0xD13E0 VA: 0x1800D1FE0
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] // RVA: 0xD2150 Offset: 0xD1550 VA: 0x1800D2150
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunctionAttribute] // RVA: 0xD2210 Offset: 0xD1610 VA: 0x1800D2210
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] // RVA: 0xD23D0 Offset: 0xD17D0 VA: 0x1800D23D0
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD2490 Offset: 0xD1890 VA: 0x1800D2490
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD2580 Offset: 0xD1980 VA: 0x1800D2580
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunctionAttribute] // RVA: 0xD27B0 Offset: 0xD1BB0 VA: 0x1800D27B0
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] // RVA: 0xD3B20 Offset: 0xD2F20 VA: 0x1800D3B20
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] // RVA: 0xD3C70 Offset: 0xD3070 VA: 0x1800D3C70
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunctionAttribute] // RVA: 0xD3D90 Offset: 0xD3190 VA: 0x1800D3D90
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunctionAttribute] // RVA: 0xD51D0 Offset: 0xD45D0 VA: 0x1800D51D0
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD52F0 Offset: 0xD46F0 VA: 0x1800D52F0
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD5380 Offset: 0xD4780 VA: 0x1800D5380
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5410 Offset: 0xD4810 VA: 0x1800D5410
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5580 Offset: 0xD4980 VA: 0x1800D5580
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] // RVA: 0xD5610 Offset: 0xD4A10 VA: 0x1800D5610
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] // RVA: 0xD5650 Offset: 0xD4A50 VA: 0x1800D5650
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD57C0 Offset: 0xD4BC0 VA: 0x1800D57C0
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] // RVA: 0xD5890 Offset: 0xD4C90 VA: 0x1800D5890
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunctionAttribute] // RVA: 0xD5990 Offset: 0xD4D90 VA: 0x1800D5990
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

