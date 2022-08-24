public class GUILayout // TypeDefIndex: 4038
{

	public static void Label(string text, GUILayoutOption[] options) { }

	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static void Box(string text, GUILayoutOption[] options) { }

	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static bool Button(string text, GUILayoutOption[] options) { }

	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static string TextField(string text, GUILayoutOption[] options) { }

	public static string TextArea(string text, GUILayoutOption[] options) { }

	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	public static bool Toggle(bool value, string text, GUILayoutOption[] options) { }

	public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) { }

	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	public static void FlexibleSpace() { }

	public static void BeginHorizontal(GUILayoutOption[] options) { }

	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static void EndHorizontal() { }

	public static void BeginVertical(GUILayoutOption[] options) { }

	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static void EndVertical() { }

	public static void BeginArea(Rect screenRect) { }

	public static void BeginArea(Rect screenRect, string text, GUIStyle style) { }

	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	public static void EndArea() { }

	public static GUILayoutOption Width(float width) { }

	public static GUILayoutOption Height(float height) { }

	public static GUILayoutOption ExpandWidth(bool expand) { }

	public static GUILayoutOption ExpandHeight(bool expand) { }

}

