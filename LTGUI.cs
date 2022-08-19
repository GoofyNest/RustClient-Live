public class LTGUI // TypeDefIndex: 5587
{	// Fields
	public static int RECT_LEVELS; // 0x0
	public static int RECTS_PER_LEVEL; // 0x4
	public static int BUTTONS_MAX; // 0x8
	private static LTRect[] levels; // 0x10
	private static int[] levelDepths; // 0x18
	private static Rect[] buttons; // 0x20
	private static int[] buttonLevels; // 0x28
	private static int[] buttonLastFrame; // 0x30
	private static LTRect r; // 0x38
	private static Color color; // 0x40
	private static bool isGUIEnabled; // 0x50
	private static int global_counter; // 0x54

	// Methods

	// RVA: 0x199BCA0 Offset: 0x199B0A0 VA: 0x18199BCA0
	public static void init() { }

	// RVA: 0x199BAC0 Offset: 0x199AEC0 VA: 0x18199BAC0
	public static void initRectCheck() { }

	// RVA: 0x199C140 Offset: 0x199B540 VA: 0x18199C140
	public static void reset() { }

	// RVA: 0x199C4D0 Offset: 0x199B8D0 VA: 0x18199C4D0
	public static void update(int updateLevel) { }

	// RVA: 0x199AC70 Offset: 0x199A070 VA: 0x18199AC70
	public static bool checkOnScreen(Rect rect) { }

	// RVA: 0x199AF60 Offset: 0x199A360 VA: 0x18199AF60
	public static void destroy(int id) { }

	// RVA: 0x199AE40 Offset: 0x199A240 VA: 0x18199AE40
	public static void destroyAll(int depth) { }

	// RVA: 0x199BE20 Offset: 0x199B220 VA: 0x18199BE20
	public static LTRect label(Rect rect, string label, int depth) { }

	// RVA: 0x199BD90 Offset: 0x199B190 VA: 0x18199BD90
	public static LTRect label(LTRect rect, string label, int depth) { }

	// RVA: 0x199C3D0 Offset: 0x199B7D0 VA: 0x18199C3D0
	public static LTRect texture(Rect rect, Texture texture, int depth) { }

	// RVA: 0x199C330 Offset: 0x199B730 VA: 0x18199C330
	public static LTRect texture(LTRect rect, Texture texture, int depth) { }

	// RVA: 0x199B140 Offset: 0x199A540 VA: 0x18199B140
	public static LTRect element(LTRect rect, int depth) { }

	// RVA: 0x199B6B0 Offset: 0x199AAB0 VA: 0x18199B6B0
	public static bool hasNoOverlap(Rect rect, int depth) { }

	// RVA: 0x199BF20 Offset: 0x199B320 VA: 0x18199BF20
	public static bool pressedWithinRect(Rect rect) { }

	// RVA: 0x199AD80 Offset: 0x199A180 VA: 0x18199AD80
	public static bool checkWithinRect(Vector2 vec2, Rect rect) { }

	// RVA: 0x199B5B0 Offset: 0x199A9B0 VA: 0x18199B5B0
	public static Vector2 firstTouch() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x199ABC0 Offset: 0x1999FC0 VA: 0x18199ABC0
	private static void .cctor() { }

}

public enum LTGUI.Element_Type // TypeDefIndex: 5588
{	// Fields
	public int value__; // 0x0
	public const LTGUI.Element_Type Texture = 0;
	public const LTGUI.Element_Type Label = 1;

}

