public class LocalizeText : MonoBehaviour, IClientComponent, ILocalize // TypeDefIndex: 11272
{	public string token; // 0x18
	[TextAreaAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public string english; // 0x20
	public string append; // 0x28
	public LocalizeText.SpecialMode specialMode; // 0x30
	private object[] Tokens; // 0x38

	public string LanguageToken { get; set; }
	public string LanguageEnglish { get; set; }


	public string get_LanguageToken() { }

	public void set_LanguageToken(string value) { }

	public string get_LanguageEnglish() { }

	public void set_LanguageEnglish(string value) { }

	private string GetText(bool englishVersion) { }

	private void Awake() { }

	public void RebuildText() { }

	private void UpdateText(bool forceEnglish) { }

	public void SetToken(int i, object token) { }

	public void SetTokens(object[] tokens) { }

	public static void OnLanguageChanged() { }

	public void .ctor() { }

}

public enum LocalizeText.SpecialMode // TypeDefIndex: 11273
{	public int value__; // 0x0
	public const LocalizeText.SpecialMode None = 0;
	public const LocalizeText.SpecialMode AllUppercase = 1;
	public const LocalizeText.SpecialMode AllLowercase = 2;

}

