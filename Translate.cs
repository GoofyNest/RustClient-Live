public static class Translate // TypeDefIndex: 6718
{
// Namespace: 
private struct <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=128 // TypeDefIndex: 6715

// Namespace: 
private struct <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=256 // TypeDefIndex: 6716

// Namespace: 
internal class <Module> // TypeDefIndex: 6717

// Namespace: 
public static class Translate // TypeDefIndex: 6718
	// Fields
	private static Dictionary<string, string> translations; // 0x0
	private static string language; // 0x8

	// Methods

	// RVA: 0x231B7B0 Offset: 0x231ABB0 VA: 0x18231B7B0
	public static void Init() { }

	// RVA: 0x231B810 Offset: 0x231AC10 VA: 0x18231B810
	public static void LoadLanguage(string lang) { }

	// RVA: 0x231B210 Offset: 0x231A610 VA: 0x18231B210
	private static void AddLanguageFile(string fileName) { }

	// RVA: 0x231B610 Offset: 0x231AA10 VA: 0x18231B610
	public static string Get(string key, string def) { }

	// RVA: 0x231B500 Offset: 0x231A900 VA: 0x18231B500
	public static string FormatTranslated(Translate.Phrase phrase, string b) { }

	// RVA: 0x231B5B0 Offset: 0x231A9B0 VA: 0x18231B5B0
	public static string GetLanguage() { }

	// RVA: 0x231B960 Offset: 0x231AD60 VA: 0x18231B960
	public static void SetLanguage(string str) { }

	// RVA: 0x231BA70 Offset: 0x231AE70 VA: 0x18231BA70
	private static void .cctor() { }

}

public class Translate.Phrase // TypeDefIndex: 6719
{	// Fields
	public string token; // 0x10
	[TextAreaAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public string english; // 0x18

	// Properties
	public virtual string translated { get; }

	// Methods

	// RVA: 0x231AF90 Offset: 0x231A390 VA: 0x18231AF90 Slot: 4
	public virtual string get_translated() { }

	// RVA: 0xD56330 Offset: 0xD55730 VA: 0x180D56330
	public bool IsValid() { }

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(string t = "", string eng = "") { }

	// RVA: 0x231B190 Offset: 0x231A590 VA: 0x18231B190
	public static Translate.Phrase op_Implicit(string b) { }

}

