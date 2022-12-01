public class GUILayoutUtility // TypeDefIndex: 4046
{
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts;
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows;
	internal static GUILayoutUtility.LayoutCache current;
	internal static readonly Rect kDummyRect;
	private static GUIStyle s_SpaceStyle;

	internal static GUIStyle spaceStyle { get; }


	private static Rect Internal_GetWindowRect(int windowID) { }

	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[VisibleToOtherModulesAttribute]
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	internal static void Begin(int instanceID) { }

	[VisibleToOtherModulesAttribute]
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	internal static void Layout() { }

	internal static void LayoutFromEditorWindow() { }

	[VisibleToOtherModulesAttribute]
	internal static void LayoutFromContainer(float w, float h) { }

	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	internal static void EndLayoutGroup() { }

	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	internal static GUIStyle get_spaceStyle() { }

	private static void .cctor() { }

	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }

}

internal sealed class GUILayoutUtility.LayoutCache // TypeDefIndex: 4047
{
	[VisibleToOtherModulesAttribute]
	internal GUILayoutGroup topLevel;
	internal GenericStack layoutGroups;
	internal GUILayoutGroup windows;


	[VisibleToOtherModulesAttribute]
	internal void .ctor() { }

}

