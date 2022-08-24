public class GUIContent // TypeDefIndex: 4035
{
	[SerializeField] 
	private string m_Text; 
	[SerializeField] 
	private Texture m_Image; 
	[SerializeField] 
	private string m_Tooltip; 
	private static readonly GUIContent s_Text; 
	private static readonly GUIContent s_Image; 
	private static readonly GUIContent s_TextImage; 
	public static GUIContent none; 

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

	[VisibleToOtherModulesAttribute] 
internal static void ClearStaticCache() { }

internal static GUIContent[] Temp(string[] texts) { }

private static void .cctor() { }

}

