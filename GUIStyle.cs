public sealed class GUIStyle // TypeDefIndex: 4048
{	// Fields
	internal IntPtr m_Ptr; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0x1A6D220 Offset: 0x1A6C620 VA: 0x181A6D220
	internal string get_rawName() { }

	// RVA: 0x1A6D5F0 Offset: 0x1A6C9F0 VA: 0x181A6D5F0
	internal void set_rawName(string value) { }

	// RVA: 0x1A6CD10 Offset: 0x1A6C110 VA: 0x181A6CD10
	public Font get_font() { }

	// RVA: 0x1A6CD50 Offset: 0x1A6C150 VA: 0x181A6CD50
	public ImagePosition get_imagePosition() { }

	// RVA: 0x1A6D490 Offset: 0x1A6C890 VA: 0x181A6D490
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1A6D2E0 Offset: 0x1A6C6E0 VA: 0x181A6D2E0
	public bool get_wordWrap() { }

	// RVA: 0x1A6CC40 Offset: 0x1A6C040 VA: 0x181A6CC40
	public Vector2 get_contentOffset() { }

	// RVA: 0x1A6D520 Offset: 0x1A6C920 VA: 0x181A6D520
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x1A6CCD0 Offset: 0x1A6C0D0 VA: 0x181A6CCD0
	public float get_fixedWidth() { }

	// RVA: 0x1A6CC90 Offset: 0x1A6C090 VA: 0x181A6CC90
	public float get_fixedHeight() { }

	// RVA: 0x1A6D2A0 Offset: 0x1A6C6A0 VA: 0x181A6D2A0
	public bool get_stretchWidth() { }

	// RVA: 0x1A6D690 Offset: 0x1A6CA90 VA: 0x181A6D690
	public void set_stretchWidth(bool value) { }

	// RVA: 0x1A6D260 Offset: 0x1A6C660 VA: 0x181A6D260
	public bool get_stretchHeight() { }

	// RVA: 0x1A6D640 Offset: 0x1A6CA40 VA: 0x181A6D640
	public void set_stretchHeight(bool value) { }

	// RVA: 0x1A6D560 Offset: 0x1A6C960 VA: 0x181A6D560
	public void set_fontSize(int value) { }

	// RVA: 0x1A6D450 Offset: 0x1A6C850 VA: 0x181A6D450
	internal void set_Internal_clipOffset(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xD1FE0 Offset: 0xD13E0 VA: 0x1800D1FE0
	// RVA: 0x1A6C050 Offset: 0x1A6B450 VA: 0x181A6C050
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] // RVA: 0xD2150 Offset: 0xD1550 VA: 0x1800D2150
	// RVA: 0x1A6C000 Offset: 0x1A6B400 VA: 0x181A6C000
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunctionAttribute] // RVA: 0xD2210 Offset: 0xD1610 VA: 0x1800D2210
	// RVA: 0x1A6C090 Offset: 0x1A6B490 VA: 0x181A6C090
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] // RVA: 0xD23D0 Offset: 0xD17D0 VA: 0x1800D23D0
	// RVA: 0x1A6BE30 Offset: 0x1A6B230 VA: 0x181A6BE30
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD2490 Offset: 0xD1890 VA: 0x1800D2490
	// RVA: 0x1A6BDF0 Offset: 0x1A6B1F0 VA: 0x181A6BDF0
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD2580 Offset: 0xD1980 VA: 0x1800D2580
	// RVA: 0x1A6C720 Offset: 0x1A6BB20 VA: 0x181A6C720
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunctionAttribute] // RVA: 0xD27B0 Offset: 0xD1BB0 VA: 0x1800D27B0
	// RVA: 0x1A6C4A0 Offset: 0x1A6B8A0 VA: 0x181A6C4A0
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] // RVA: 0xD3B20 Offset: 0xD2F20 VA: 0x1800D3B20
	// RVA: 0x1A6C140 Offset: 0x1A6B540 VA: 0x181A6C140
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] // RVA: 0xD3C70 Offset: 0xD3070 VA: 0x1800D3C70
	// RVA: 0x1A6C220 Offset: 0x1A6B620 VA: 0x181A6C220
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunctionAttribute] // RVA: 0xD3D90 Offset: 0xD3190 VA: 0x1800D3D90
	// RVA: 0x1A6C340 Offset: 0x1A6B740 VA: 0x181A6C340
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunctionAttribute] // RVA: 0xD51D0 Offset: 0xD45D0 VA: 0x1800D51D0
	// RVA: 0x1A6C5D0 Offset: 0x1A6B9D0 VA: 0x181A6C5D0
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD52F0 Offset: 0xD46F0 VA: 0x1800D52F0
	// RVA: 0x1A6C6C0 Offset: 0x1A6BAC0 VA: 0x181A6C6C0
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD5380 Offset: 0xD4780 VA: 0x1800D5380
	// RVA: 0x1A6C7D0 Offset: 0x1A6BBD0 VA: 0x181A6C7D0
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD5410 Offset: 0xD4810 VA: 0x1800D5410
	// RVA: 0x1A6AD40 Offset: 0x1A6A140 VA: 0x181A6AD40
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD5580 Offset: 0xD4980 VA: 0x1800D5580
	// RVA: 0x1A6ACE0 Offset: 0x1A6A0E0 VA: 0x181A6ACE0
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] // RVA: 0xD5610 Offset: 0xD4A10 VA: 0x1800D5610
	// RVA: 0x1A6AC00 Offset: 0x1A6A000 VA: 0x181A6AC00
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] // RVA: 0xD5650 Offset: 0xD4A50 VA: 0x1800D5650
	// RVA: 0x1A6BED0 Offset: 0x1A6B2D0 VA: 0x181A6BED0
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xD57C0 Offset: 0xD4BC0 VA: 0x1800D57C0
	// RVA: 0x1A6C8D0 Offset: 0x1A6BCD0 VA: 0x181A6C8D0
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] // RVA: 0xD5890 Offset: 0xD4C90 VA: 0x1800D5890
	// RVA: 0x1A6C530 Offset: 0x1A6B930 VA: 0x181A6C530
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunctionAttribute] // RVA: 0xD5990 Offset: 0xD4D90 VA: 0x1800D5990
	// RVA: 0x1A6C840 Offset: 0x1A6BC40 VA: 0x181A6C840
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x1A6CB70 Offset: 0x1A6BF70 VA: 0x181A6CB70
	public void .ctor() { }

	// RVA: 0x1A6CAA0 Offset: 0x1A6BEA0 VA: 0x181A6CAA0
	public void .ctor(GUIStyle other) { }

	// RVA: 0x1A6BC10 Offset: 0x1A6B010 VA: 0x181A6BC10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A6CF90 Offset: 0x1A6C390 VA: 0x181A6CF90
	public string get_name() { }

	// RVA: 0x1A6D5A0 Offset: 0x1A6C9A0 VA: 0x181A6D5A0
	public void set_name(string value) { }

	// RVA: 0x1A6D0B0 Offset: 0x1A6C4B0 VA: 0x181A6D0B0
	public GUIStyleState get_normal() { }

	// RVA: 0x1A6CEE0 Offset: 0x1A6C2E0 VA: 0x181A6CEE0
	public RectOffset get_margin() { }

	// RVA: 0x1A6D170 Offset: 0x1A6C570 VA: 0x181A6D170
	public RectOffset get_padding() { }

	// RVA: 0x1A6CE30 Offset: 0x1A6C230 VA: 0x181A6CE30
	public float get_lineHeight() { }

	// RVA: 0x1A6B9E0 Offset: 0x1A6ADE0 VA: 0x181A6B9E0
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A6BB50 Offset: 0x1A6AF50 VA: 0x181A6BB50
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x1A6B910 Offset: 0x1A6AD10 VA: 0x181A6B910
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1A6B7F0 Offset: 0x1A6ABF0 VA: 0x181A6B7F0
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x1A6BA70 Offset: 0x1A6AE70 VA: 0x181A6BA70
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A6ADA0 Offset: 0x1A6A1A0 VA: 0x181A6ADA0
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x1A6B260 Offset: 0x1A6A660 VA: 0x181A6B260
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x1A6B080 Offset: 0x1A6A480 VA: 0x181A6B080
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x1A6B620 Offset: 0x1A6AA20 VA: 0x181A6B620
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x1A6D320 Offset: 0x1A6C720 VA: 0x181A6D320
	public static GUIStyle op_Implicit(string str) { }

	// RVA: 0x1A6CFF0 Offset: 0x1A6C3F0 VA: 0x181A6CFF0
	public static GUIStyle get_none() { }

	// RVA: 0x1A6BD10 Offset: 0x1A6B110 VA: 0x181A6BD10
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x1A6BD90 Offset: 0x1A6B190 VA: 0x181A6BD90
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x1A6AD40 Offset: 0x1A6A140 VA: 0x181A6AD40
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x1A6ACE0 Offset: 0x1A6A0E0 VA: 0x181A6ACE0
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x1A6AC00 Offset: 0x1A6A000 VA: 0x181A6AC00
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x1A6CD90 Offset: 0x1A6C190 VA: 0x181A6CD90
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x1A6AC60 Offset: 0x1A6A060 VA: 0x181A6AC60
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x1A6C950 Offset: 0x1A6BD50 VA: 0x181A6C950 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A6CA60 Offset: 0x1A6BE60 VA: 0x181A6CA60
	private static void .cctor() { }

	// RVA: 0x1A6CBF0 Offset: 0x1A6BFF0 VA: 0x181A6CBF0
	private void get_contentOffset_Injected(out Vector2 ret) { }

	// RVA: 0x1A6D4D0 Offset: 0x1A6C8D0 VA: 0x181A6D4D0
	private void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1A6D400 Offset: 0x1A6C800 VA: 0x181A6D400
	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1A6C410 Offset: 0x1A6B810 VA: 0x181A6C410
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1A6C0D0 Offset: 0x1A6B4D0 VA: 0x181A6C0D0
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1A6C1B0 Offset: 0x1A6B5B0 VA: 0x181A6C1B0
	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	// RVA: 0x1A6C290 Offset: 0x1A6B690 VA: 0x181A6C290
	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	// RVA: 0x1A6C560 Offset: 0x1A6B960 VA: 0x181A6C560
	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	// RVA: 0x1A6C650 Offset: 0x1A6BA50 VA: 0x181A6C650
	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	// RVA: 0x1A6C760 Offset: 0x1A6BB60 VA: 0x181A6C760
	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x1A6BFA0 Offset: 0x1A6B3A0 VA: 0x181A6BFA0
	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1A6BF30 Offset: 0x1A6B330 VA: 0x181A6BF30
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x1A6BE70 Offset: 0x1A6B270 VA: 0x181A6BE70
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1A6C880 Offset: 0x1A6BC80 VA: 0x181A6C880
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

}

