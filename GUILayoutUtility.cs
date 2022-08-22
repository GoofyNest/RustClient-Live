public class GUILayoutUtility // TypeDefIndex: 4041
{	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18
	private static GUIStyle s_SpaceStyle; // 0x28

	internal static GUIStyle spaceStyle { get; }


	private static Rect Internal_GetWindowRect(int windowID) { }

	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF4A0 Offset: 0xCE8A0 VA: 0x1800CF4A0
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	internal static void Begin(int instanceID) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF680 Offset: 0xCEA80 VA: 0x1800CF680
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	internal static void Layout() { }

	internal static void LayoutFromEditorWindow() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF870 Offset: 0xCEC70 VA: 0x1800CF870
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

internal sealed class GUILayoutUtility.LayoutCache // TypeDefIndex: 4042
{	[VisibleToOtherModulesAttribute] // RVA: 0xCFDD0 Offset: 0xCF1D0 VA: 0x1800CFDD0
	internal GUILayoutGroup topLevel; // 0x10
	internal GenericStack layoutGroups; // 0x18
	internal GUILayoutGroup windows; // 0x20


	[VisibleToOtherModulesAttribute] // RVA: 0xCFEF0 Offset: 0xCF2F0 VA: 0x1800CFEF0
	internal void .ctor() { }

}

