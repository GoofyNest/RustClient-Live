public class GUILayoutUtility // TypeDefIndex: 4041
{	// Fields
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18
	private static GUIStyle s_SpaceStyle; // 0x28

	// Properties
	internal static GUIStyle spaceStyle { get; }

	// Methods

	// RVA: 0x1A638C0 Offset: 0x1A62CC0 VA: 0x181A638C0
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x1A63990 Offset: 0x1A62D90 VA: 0x181A63990
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF4A0 Offset: 0xCE8A0 VA: 0x1800CF4A0
	// RVA: 0x1A64940 Offset: 0x1A63D40 VA: 0x181A64940
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x1A62810 Offset: 0x1A61C10 VA: 0x181A62810
	internal static void Begin(int instanceID) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF680 Offset: 0xCEA80 VA: 0x1800CF680
	// RVA: 0x1A61C20 Offset: 0x1A61020 VA: 0x181A61C20
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	// RVA: 0x1A62450 Offset: 0x1A61850 VA: 0x181A62450
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A64640 Offset: 0x1A63A40 VA: 0x181A64640
	internal static void Layout() { }

	// RVA: 0x1A640B0 Offset: 0x1A634B0 VA: 0x181A640B0
	internal static void LayoutFromEditorWindow() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCF870 Offset: 0xCEC70 VA: 0x1800CF870
	// RVA: 0x1A63ED0 Offset: 0x1A632D0 VA: 0x181A63ED0
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x1A63A10 Offset: 0x1A62E10 VA: 0x181A63A10
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x1A64300 Offset: 0x1A63700 VA: 0x181A64300
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x1A62AC0 Offset: 0x1A61EC0 VA: 0x181A62AC0
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x1A62100 Offset: 0x1A61500 VA: 0x181A62100
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x1A63470 Offset: 0x1A62870 VA: 0x181A63470
	internal static void EndLayoutGroup() { }

	// RVA: 0x1A61E00 Offset: 0x1A61200 VA: 0x181A61E00
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x1A63720 Offset: 0x1A62B20 VA: 0x181A63720
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A62BE0 Offset: 0x1A61FE0 VA: 0x181A62BE0
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A637C0 Offset: 0x1A62BC0 VA: 0x181A637C0
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A63210 Offset: 0x1A62610 VA: 0x181A63210
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1A64C30 Offset: 0x1A64030 VA: 0x181A64C30
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x1A64B10 Offset: 0x1A63F10 VA: 0x181A64B10
	private static void .cctor() { }

	// RVA: 0x1A63880 Offset: 0x1A62C80 VA: 0x181A63880
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x1A63950 Offset: 0x1A62D50 VA: 0x181A63950
	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }

}

internal sealed class GUILayoutUtility.LayoutCache // TypeDefIndex: 4042
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0xCFDD0 Offset: 0xCF1D0 VA: 0x1800CFDD0
	internal GUILayoutGroup topLevel; // 0x10
	internal GenericStack layoutGroups; // 0x18
	internal GUILayoutGroup windows; // 0x20

	// Methods

	[VisibleToOtherModulesAttribute] // RVA: 0xCFEF0 Offset: 0xCF2F0 VA: 0x1800CFEF0
	// RVA: 0x1A76BF0 Offset: 0x1A75FF0 VA: 0x181A76BF0
	internal void .ctor() { }

}

