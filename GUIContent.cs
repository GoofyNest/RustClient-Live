public class GUIContent // TypeDefIndex: 4035
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Texture m_Image; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_Tooltip; // 0x20
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	// Properties
	public string text { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }

	// Methods

	// RVA: 0x1818780 Offset: 0x1817B80 VA: 0x181818780
	public string get_text() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_text(string value) { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_image(Texture value) { }

	// RVA: 0x1A5DBD0 Offset: 0x1A5CFD0 VA: 0x181A5DBD0
	public string get_tooltip() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_tooltip(string value) { }

	// RVA: 0x1A5DB40 Offset: 0x1A5CF40 VA: 0x181A5DB40
	public void .ctor() { }

	// RVA: 0x1A5DAE0 Offset: 0x1A5CEE0 VA: 0x181A5DAE0
	public void .ctor(string text) { }

	// RVA: 0x1A5DBB0 Offset: 0x1A5CFB0 VA: 0x181A5DBB0
	public void .ctor(string text, string tooltip) { }

	// RVA: 0x1A5D940 Offset: 0x1A5CD40 VA: 0x181A5D940
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x1A5DA10 Offset: 0x1A5CE10 VA: 0x181A5DA10
	public void .ctor(GUIContent src) { }

	// RVA: 0x1A5D420 Offset: 0x1A5C820 VA: 0x181A5D420
	internal static GUIContent Temp(string t) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCCF90 Offset: 0xCC390 VA: 0x1800CCF90
	// RVA: 0x1A5D2C0 Offset: 0x1A5C6C0 VA: 0x181A5D2C0
	internal static void ClearStaticCache() { }

	// RVA: 0x1A5D4E0 Offset: 0x1A5C8E0 VA: 0x181A5D4E0
	internal static GUIContent[] Temp(string[] texts) { }

	// RVA: 0x1A5D6F0 Offset: 0x1A5CAF0 VA: 0x181A5D6F0
	private static void .cctor() { }

}

