public class GUIContent // TypeDefIndex: 4035
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Texture m_Image; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_Tooltip; // 0x20
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	public string text { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }


	public string get_text() { }

	public void set_text(string value) { }

	public void set_image(Texture value) { }

	public string get_tooltip() { }

	public void set_tooltip(string value) { }

	public void .ctor() { }

	public void .ctor(string text) { }

	public void .ctor(string text, string tooltip) { }

	public void .ctor(string text, Texture image, string tooltip) { }

	public void .ctor(GUIContent src) { }

	internal static GUIContent Temp(string t) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCCF90 Offset: 0xCC390 VA: 0x1800CCF90
	internal static void ClearStaticCache() { }

	internal static GUIContent[] Temp(string[] texts) { }

	private static void .cctor() { }

}

