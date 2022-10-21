public static class Translate // TypeDefIndex: 6888
{

private struct <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=128

private struct <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=256

internal class <Module>

public static class Translate
	private static Dictionary<string, string> translations; 
	private static string language; 


	public static void Init() { }

	public static void LoadLanguage(string lang) { }

	private static void AddLanguageFile(string fileName) { }

	public static string Get(string key, string def) { }

	public static string FormatTranslated(Translate.Phrase phrase, string b) { }

	public static string GetLanguage() { }

	public static void SetLanguage(string str) { }

	private static void .cctor() { }

}

public class Translate.Phrase // TypeDefIndex: 6889
{
	public string token; 
	[TextAreaAttribute] 
	public string english; 

	public virtual string translated { get; }


	public virtual string get_translated() { }

	public bool IsValid() { }

	public void .ctor(string t = "", string eng = "") { }

	public static Translate.Phrase op_Implicit(string b) { }

}

