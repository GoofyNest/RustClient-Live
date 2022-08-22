public static class Translate // TypeDefIndex: 6718
{
private struct <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=128 // TypeDefIndex: 6715

private struct <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=256 // TypeDefIndex: 6716

internal class <Module> // TypeDefIndex: 6717

public static class Translate // TypeDefIndex: 6718
	private static Dictionary<string, string> translations; // 0x0
	private static string language; // 0x8


	public static void Init() { }

	public static void LoadLanguage(string lang) { }

	private static void AddLanguageFile(string fileName) { }

	public static string Get(string key, string def) { }

	public static string FormatTranslated(Translate.Phrase phrase, string b) { }

	public static string GetLanguage() { }

	public static void SetLanguage(string str) { }

	private static void .cctor() { }

}

public class Translate.Phrase // TypeDefIndex: 6719
{	public string token; // 0x10
	[TextAreaAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public string english; // 0x18

	public virtual string translated { get; }


	public virtual string get_translated() { }

	public bool IsValid() { }

	public void .ctor(string t = "", string eng = "") { }

	public static Translate.Phrase op_Implicit(string b) { }

}

