public class GUILayout // TypeDefIndex: 4038
{	// Methods

	// RVA: 0x1A67140 Offset: 0x1A66540 VA: 0x181A67140
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A65EA0 Offset: 0x1A652A0 VA: 0x181A65EA0
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A65710 Offset: 0x1A64B10 VA: 0x181A65710
	public static void Box(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A65AB0 Offset: 0x1A64EB0 VA: 0x181A65AB0
	private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A658E0 Offset: 0x1A64CE0 VA: 0x181A658E0
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A65BC0 Offset: 0x1A64FC0 VA: 0x181A65BC0
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A67430 Offset: 0x1A66830 VA: 0x181A67430
	public static string TextField(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A67350 Offset: 0x1A66750 VA: 0x181A67350
	public static string TextArea(string text, GUILayoutOption[] options) { }

	// RVA: 0x1A65FF0 Offset: 0x1A653F0 VA: 0x181A65FF0
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A675B0 Offset: 0x1A669B0 VA: 0x181A675B0
	public static bool Toggle(bool value, string text, GUILayoutOption[] options) { }

	// RVA: 0x1A67510 Offset: 0x1A66910 VA: 0x181A67510
	public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A66330 Offset: 0x1A65730 VA: 0x181A66330
	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A66E40 Offset: 0x1A66240 VA: 0x181A66E40
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x1A65CD0 Offset: 0x1A650D0 VA: 0x181A65CD0
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x1A66930 Offset: 0x1A65D30 VA: 0x181A66930
	public static void FlexibleSpace() { }

	// RVA: 0x1A652A0 Offset: 0x1A646A0 VA: 0x181A652A0
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x1A65130 Offset: 0x1A64530 VA: 0x181A65130
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A66790 Offset: 0x1A65B90 VA: 0x181A66790
	public static void EndHorizontal() { }

	// RVA: 0x1A65480 Offset: 0x1A64880 VA: 0x181A65480
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x1A65690 Offset: 0x1A64A90 VA: 0x181A65690
	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A65520 Offset: 0x1A64920 VA: 0x181A65520
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A667E0 Offset: 0x1A65BE0 VA: 0x181A667E0
	public static void EndVertical() { }

	// RVA: 0x1A65080 Offset: 0x1A64480 VA: 0x181A65080
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x1A64D60 Offset: 0x1A64160 VA: 0x181A64D60
	public static void BeginArea(Rect screenRect, string text, GUIStyle style) { }

	// RVA: 0x1A64DF0 Offset: 0x1A641F0 VA: 0x181A64DF0
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x1A665B0 Offset: 0x1A659B0 VA: 0x181A665B0
	public static void EndArea() { }

	// RVA: 0x1A676C0 Offset: 0x1A66AC0 VA: 0x181A676C0
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x1A66DB0 Offset: 0x1A661B0 VA: 0x181A66DB0
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x1A668B0 Offset: 0x1A65CB0 VA: 0x181A668B0
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x1A66830 Offset: 0x1A65C30 VA: 0x181A66830
	public static GUILayoutOption ExpandHeight(bool expand) { }

}

