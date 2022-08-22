public class LTGUI // TypeDefIndex: 5587
{	public static int RECT_LEVELS; // 0x0
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


	public static void init() { }

	public static void initRectCheck() { }

	public static void reset() { }

	public static void update(int updateLevel) { }

	public static bool checkOnScreen(Rect rect) { }

	public static void destroy(int id) { }

	public static void destroyAll(int depth) { }

	public static LTRect label(Rect rect, string label, int depth) { }

	public static LTRect label(LTRect rect, string label, int depth) { }

	public static LTRect texture(Rect rect, Texture texture, int depth) { }

	public static LTRect texture(LTRect rect, Texture texture, int depth) { }

	public static LTRect element(LTRect rect, int depth) { }

	public static bool hasNoOverlap(Rect rect, int depth) { }

	public static bool pressedWithinRect(Rect rect) { }

	public static bool checkWithinRect(Vector2 vec2, Rect rect) { }

	public static Vector2 firstTouch() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum LTGUI.Element_Type // TypeDefIndex: 5588
{	public int value__; // 0x0
	public const LTGUI.Element_Type Texture = 0;
	public const LTGUI.Element_Type Label = 1;

}

