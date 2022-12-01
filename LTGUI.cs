public class LTGUI // TypeDefIndex: 5596
{
	public static int RECT_LEVELS;
	public static int RECTS_PER_LEVEL;
	public static int BUTTONS_MAX;
	private static LTRect[] levels;
	private static int[] levelDepths;
	private static Rect[] buttons;
	private static int[] buttonLevels;
	private static int[] buttonLastFrame;
	private static LTRect r;
	private static Color color;
	private static bool isGUIEnabled;
	private static int global_counter;


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

public enum LTGUI.Element_Type // TypeDefIndex: 5597
{
	public int value__;
	public const LTGUI.Element_Type Texture = 0;
	public const LTGUI.Element_Type Label = 1;

}

