public static class TMPro_EventManager // TypeDefIndex: 6851
{	// Fields
	public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x0
	public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x8
	public static readonly FastAction<bool, TMP_FontAsset> FONT_PROPERTY_EVENT; // 0x10
	public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
	public static readonly FastAction<bool, TextMeshPro> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
	public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
	public static readonly FastAction<TMP_ColorGradient> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
	public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
	public static readonly FastAction<bool, TextMeshProUGUI> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
	public static readonly FastAction OnPreRenderObject_Event; // 0x58
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; // 0x60

	// Methods

	// RVA: 0x1159220 Offset: 0x1158620 VA: 0x181159220
	public static void ON_PRE_RENDER_OBJECT_CHANGED() { }

	// RVA: 0x1159190 Offset: 0x1158590 VA: 0x181159190
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	// RVA: 0x1159100 Offset: 0x1158500 VA: 0x181159100
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, TMP_FontAsset font) { }

	// RVA: 0x1159300 Offset: 0x1158700 VA: 0x181159300
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x1159390 Offset: 0x1158790 VA: 0x181159390
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, TextMeshPro obj) { }

	// RVA: 0x1159060 Offset: 0x1158460 VA: 0x181159060
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	// RVA: 0x1159530 Offset: 0x1158930 VA: 0x181159530
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	// RVA: 0x1158F50 Offset: 0x1158350 VA: 0x181158F50
	public static void ON_COLOR_GRAIDENT_PROPERTY_CHANGED(TMP_ColorGradient gradient) { }

	// RVA: 0x11594B0 Offset: 0x11588B0 VA: 0x1811594B0
	public static void ON_TEXT_CHANGED(Object obj) { }

	// RVA: 0x11595B0 Offset: 0x11589B0 VA: 0x1811595B0
	public static void ON_TMP_SETTINGS_CHANGED() { }

	// RVA: 0x1159290 Offset: 0x1158690 VA: 0x181159290
	public static void ON_RESOURCES_LOADED() { }

	// RVA: 0x1159420 Offset: 0x1158820 VA: 0x181159420
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, TextMeshProUGUI obj) { }

	// RVA: 0x1158FD0 Offset: 0x11583D0 VA: 0x181158FD0
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	// RVA: 0x1159620 Offset: 0x1158A20 VA: 0x181159620
	private static void .cctor() { }

}

public static class TMPro_ExtensionMethods // TypeDefIndex: 6853
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159940 Offset: 0x1158D40 VA: 0x181159940
	public static string ArrayToString(char[] chars) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159C10 Offset: 0x1159010 VA: 0x181159C10
	public static string IntToString(int[] unicodes) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159CB0 Offset: 0x11590B0 VA: 0x181159CB0
	public static string IntToString(int[] unicodes, int start, int length) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84890 Offset: 0xE83C90 VA: 0x180E84890
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159BD0 Offset: 0x1158FD0 VA: 0x181159BD0
	public static bool Compare(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159A20 Offset: 0x1158E20 VA: 0x181159A20
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159AE0 Offset: 0x1158EE0 VA: 0x181159AE0
	public static bool Compare(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11599F0 Offset: 0x1158DF0 VA: 0x1811599F0
	public static bool CompareRGB(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159DD0 Offset: 0x11591D0 VA: 0x181159DD0
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159DD0 Offset: 0x11591D0 VA: 0x181159DD0
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159EC0 Offset: 0x11592C0 VA: 0x181159EC0
	public static Color32 Tint(Color32 c1, float tint) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159A50 Offset: 0x1158E50 VA: 0x181159A50
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1159B20 Offset: 0x1158F20 VA: 0x181159B20
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }

}

